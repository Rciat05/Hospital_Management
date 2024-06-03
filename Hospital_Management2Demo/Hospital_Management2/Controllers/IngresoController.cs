using FluentValidation;
using FluentValidation.Results;
using Hospital_Management2.Models;
using Hospital_Management2.Repositories.Ingreso;
using Hospital_Management2.Validations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management2.Controllers
{
    public class IngresoController : Controller
    {
        private readonly IIngresoRepository _ingresoRepository;
        private readonly IValidator<IngresoModel> _validator;

        public IngresoController(IValidator<IngresoModel> validator, IIngresoRepository ingresoRepository)
        {
            _validator = validator;
            _ingresoRepository = ingresoRepository;
        }

        // GET: IngresoController
        public async Task<ActionResult> Index()
        {
            var ingreso = await _ingresoRepository.GetAllAsync();

            return View(ingreso);
        }

        // GET: IngresoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IngresoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IngresoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IngresoModel ingreso)
        {
            try
            {
                ValidationResult validationResult =
                    await _validator.ValidateAsync(ingreso);

                if (!validationResult.IsValid)
                {
                    validationResult.AddToModelState(this.ModelState);

                    return View(ingreso);
                }

                await _ingresoRepository.AddAsync(ingreso);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(ingreso);
            }
        }

        // GET: IngresoController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var ingreso = await _ingresoRepository.GetByIdAsync(id);

            if (ingreso == null)
                return NotFound();

            return View(ingreso);
        }

        // POST: IngresoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(IngresoModel ingreso)
        {
            try
            {
                await _ingresoRepository.EditAsync(ingreso);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(ingreso);
            }
        }

        // GET: IngresoController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var ingreso = await _ingresoRepository.GetByIdAsync(id);
            if (ingreso == null)
                return NotFound();

            return View(ingreso);
        }

        // POST: IngresoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                await _ingresoRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                var ingreso = await _ingresoRepository.GetByIdAsync(id);
                if (ingreso == null)
                    return NotFound();

                return View(ingreso);
            }
        }
    }
}
