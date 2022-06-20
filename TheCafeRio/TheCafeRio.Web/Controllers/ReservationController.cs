using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using TheCafeRio.Web.Entities;
using TheCafeRio.Web.Enums;
using TheCafeRio.Web.Models;
using TheCafeRio.Web.Repositories;

namespace TheCafeRio.Web.Controllers
{
    public class ReservationController : Controller
    {
        IReservationRepository _repository;
        public ReservationController(IReservationRepository repository)
        {
            _repository = repository;
        }
        // GET: ReservationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReservationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReservationController/Create
        public ActionResult ReservationForm()
        {
            var model = new ReservationUpdateModel();
            model.Shifts = new List<SelectListItem>();
            model.Shifts.Add(new SelectListItem
            {
                Value = ((int)ReservationEnum.Launch).ToString(),
                Text = ReservationEnum.Launch.ToString()
            });
            model.Shifts.Add(new SelectListItem
            {
                Value = ((int)ReservationEnum.Dinner).ToString(),
                Text = ReservationEnum.Dinner.ToString()
            });
            return PartialView("_ReservationForm", model);
            //return View(model);
        }

        // POST: ReservationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservationUpdateModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.Create(new Reservation
                    {
                        Id = model.Id,
                        TotalPerson = model.TotalPerson,
                        ContactNo = model.ContactNo,
                        ExpectedDate = model.ExpectedDate,
                        ReservationShift = model.ReservationShift
                    });
                }
                catch
                {
                    return View();
                }
            }
            return RedirectToAction("Index","Home");
        }

        // GET: ReservationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservationController/Edit/5
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

        // GET: ReservationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservationController/Delete/5
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
