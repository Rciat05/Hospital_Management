using FluentValidation;
using FluentValidation.Results;
using Hospital_Management2.Models;
using Hospital_Management2.Repositories.Paciente;
using Hospital_Management2.Validations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Hospital_Management2.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IValidator<PacienteModel> _validator;
        public PacienteController(IPacienteRepository pacienteRepository, 
            IValidator<PacienteModel> validator)
        {
            _pacienteRepository = pacienteRepository;
        }

        // GET: PacienteController
        public async Task<ActionResult> Index()
        {
            var pacientes = await _pacienteRepository.GetAllAsync();

            return View(pacientes);
        }

        // GET: PacienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PacienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PacienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PacienteModel paciente)
        {
            try
            {
                ValidationResult validationResult =
                    await _validator.ValidateAsync(paciente);

                if (!validationResult.IsValid)
                {
                    validationResult.AddToModelState(this.ModelState);

                    return View(paciente);
                }

                await _pacienteRepository.AddAsync(paciente);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(paciente);
            }
        }

        // GET: PacienteController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var paciente = await _pacienteRepository.GetByIdAsync(id);

            if (paciente == null)
                return NotFound();

            return View(paciente);
        }

        // POST: PacienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PacienteModel paciente)
        {
            try
            {
                await _pacienteRepository.EditAsync(paciente);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(paciente);
            }
        }

        // GET: PacienteController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var paciente = await _pacienteRepository.GetByIdAsync(id);
            if (paciente == null)
                return NotFound();

            return View(paciente);
        }

        // POST: PacienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                await _pacienteRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                var paciente = await _pacienteRepository.GetByIdAsync(id);
                if (paciente == null)
                    return NotFound();

                return View(paciente);
            }
        }
    }
}
