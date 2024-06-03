using FluentValidation;
using FluentValidation.Results;
using Hospital_Management2.Models;
using Hospital_Management2.Repositories.Prescripcion;
using Hospital_Management2.Validations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management2.Controllers
{
    public class PrescripcionController : Controller
    {
        private readonly IPrescripcionRepository _prescripcionRepository;
        private readonly IValidator<PrescripcionModel> _validator;

        public PrescripcionController(IValidator<PrescripcionModel> validator, IPrescripcionRepository prescripcionRepository)
        {
            _validator = validator;
            _prescripcionRepository = prescripcionRepository;
        }



        // GET: PrescripcionController
        public async Task<ActionResult> Index()
        {
            var prescripcion = await _prescripcionRepository.GetAllAsync();

            return View(prescripcion);
        }

        // GET: PrescripcionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrescripcionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrescripcionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PrescripcionModel prescripcion)
        {
            try
            {
                ValidationResult validationResult =
                    await _validator.ValidateAsync(prescripcion);

                if (!validationResult.IsValid)
                {
                    validationResult.AddToModelState(this.ModelState);

                    return View(prescripcion);
                }

                await _prescripcionRepository.AddAsync(prescripcion);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(prescripcion);
            }
        }


        // GET: PrescripcionController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var prescripcion = await _prescripcionRepository.GetByIdAsync(id);

            if (prescripcion == null)
                return NotFound();

            return View(prescripcion);
        }

        // POST: PrescripcionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PrescripcionModel prescripcion)
        {
            try
            {
                await _prescripcionRepository.EditAsync(prescripcion);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(prescripcion);
            }
        }

        // GET: PrescripcionController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var prescripcion = await _prescripcionRepository.GetByIdAsync(id);
            if (prescripcion == null)
                return NotFound();

            return View(prescripcion);
        }

        // POST: PrescripcionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                await _prescripcionRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                var prescripcion = await _prescripcionRepository.GetByIdAsync(id);
                if (prescripcion == null)
                    return NotFound();

                return View(prescripcion);
            }
        }
    }
}
