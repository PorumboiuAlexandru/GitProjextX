using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitProjextX.Controllers
{
    public class GitStuffController : Controller
    {
        // GET: GitStuffController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GitStuffController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GitStuffController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GitStuffController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GitStuffController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GitStuffController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GitStuffController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GitStuffController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
