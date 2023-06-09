﻿using EduHome.DAL;
using EduHome.Helper;
using EduHome.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class CoursesController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;

        public CoursesController(AppDbContext db,IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<Course> courses = await _db.Courses.Include(x=>x.CourseDetail).ToListAsync();
            return View(courses);
        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Course course)
        {
            bool isExist = await _db.Courses.Include(x => x.CourseDetail).AnyAsync(x => x.Name == course.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Course already exist !");
                return View();
            }
            #region Photo
            if (course.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo can not be null");
                return View();
            }

            if (!course.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select image type");
                return View();
            }

            if (course.Photo.IsOlder256Kb())
            {
                ModelState.AddModelError("Photo", "max 256Kb");
                return View();
            }

            string folder = Path.Combine(_env.WebRootPath, "img", "course");
            course.Image = await course.Photo.SaveFileAsync(folder);
            #endregion

            await _db.Courses.AddAsync(course);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Course dbcourse = await _db.Courses.Include(x => x.CourseDetail).FirstOrDefaultAsync(x => x.Id == id);
            if (dbcourse == null)
            {
                return BadRequest();
            }

            return View(dbcourse);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, Course course)
        {
            if (id == null)
            {
                return NotFound();
            }
            Course dbcourse = await _db.Courses.Include(x => x.CourseDetail).FirstOrDefaultAsync(x => x.Id == id);
            if (dbcourse == null)
            {
                return BadRequest();
            }

            bool isExist = await _db.Courses.AnyAsync(x => x.Name == course.Name && x.Id != id);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Course already exist !");
                return View();
            }

            #region Photo
            if (course.Photo != null)
            {
                if (!course.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select image type");
                    return View();
                }

                if (course.Photo.IsOlder256Kb())
                {
                    ModelState.AddModelError("Photo", "Max 256Kb");
                    return View();
                }



                string folder = Path.Combine(_env.WebRootPath, "img", "course");
                course.Image = await course.Photo.SaveFileAsync(folder);
                string path = Path.Combine(_env.WebRootPath, folder, dbcourse.Image);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                dbcourse.Image = course.Image;
            }
            #endregion

            dbcourse.Name = course.Name;
            dbcourse.Description = course.Description;

            dbcourse.CourseDetail.AboutCourse = course.CourseDetail.AboutCourse;
            dbcourse.CourseDetail.Apply = course.CourseDetail.Apply;
            dbcourse.CourseDetail.Certification = course.CourseDetail.Certification;
            dbcourse.CourseDetail.Starts = course.CourseDetail.Starts;
            dbcourse.CourseDetail.Duration = course.CourseDetail.Duration;
            dbcourse.CourseDetail.ClassDuration = course.CourseDetail.ClassDuration;
            dbcourse.CourseDetail.SkillLevel = course.CourseDetail.SkillLevel;
            dbcourse.CourseDetail.Language = course.CourseDetail.Language;
            dbcourse.CourseDetail.Student = course.CourseDetail.Student;
            dbcourse.CourseDetail.CourseFee = course.CourseDetail.CourseFee;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Course dbcourse = await _db.Courses.Include(x => x.CourseDetail).FirstOrDefaultAsync(x => x.Id == id);
            if (dbcourse == null)
            {
                return BadRequest();
            }
            return View(dbcourse);
        }
        #endregion

        #region Activity
        public async Task<IActionResult> Activity(int? id)
        {
            if (id == null)
                return NotFound();
            Course dbcourse = await _db.Courses.FirstOrDefaultAsync(x => x.Id == id);
            if (dbcourse == null)
                return BadRequest();

            if (dbcourse.IsDeactive)
                dbcourse.IsDeactive = false;
            else
                dbcourse.IsDeactive = true;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

    }
}
