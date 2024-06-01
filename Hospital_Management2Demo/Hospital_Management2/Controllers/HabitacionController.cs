using FluentValidation;
using FluentValidation.Results;
using Hospital_Management2.Models;
using Hospital_Management2.Repositories.Habitacion;
using Hospital_Management2.Validations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management2.Controllers
{
    public class HabitacionController : Controller
    {
        private readonly IHabitacionRepository _habitacionRepository;
        private readonly IValidator<HabitacionModel> _validator;

        public HabitacionController(IHabitacionRepository habitacionRepository, 
            IValidator<HabitacionModel> validator)
        {
            _habitacionRepository = habitacionRepository;
            _validator = validator;

        }

        // GET: HabitacionController
        public async Task<ActionResult> Index()
        {
            var habitacion = await _habitacionRepository.GetAllAsync();

            return View(habitacion);
        }

        // GET: HabitacionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HabitacionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HabitacionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(HabitacionModel habitacion)
        {
            try
            {
                ValidationResult validationResult =
                    await _validator.ValidateAsync(habitacion);

                if (!validationResult.IsValid)
                {
                    validationResult.AddToModelState(this.ModelState);

                    return View(habitacion);
                }

                await _habitacionRepository.AddAsync(habitacion);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(habitacion);
            }
        }

        // GET: HabitacionController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var habitacion = await _habitacionRepository.GetByIdAsync(id);

            if (habitacion == null)
                return NotFound();

            return View(habitacion);
        }

        // POST: HabitacionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(HabitacionModel habitacion)
        {
            try
            {
                await _habitacionRepository.EditAsync(habitacion);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(habitacion);
            }
        }

        // GET: HabitacionController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var habitacion = await _habitacionRepository.GetByIdAsync(id);
            if (habitacion == null)
                return NotFound();

            return View(habitacion);
        }

        // POST: HabitacionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                await _habitacionRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                var habitacion = await _habitacionRepository.GetByIdAsync(id);
                if (habitacion == null)
                    return NotFound();

                return View(habitacion);
            }
        }
    }
}
