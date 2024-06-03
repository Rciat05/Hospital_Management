using FluentValidation;
using FluentValidation.Results;
using Hospital_Management2.Models;
using Hospital_Management2.Repositories.Cita;
using Hospital_Management2.Repositories.Paciente;
using Hospital_Management2.Services;
using Hospital_Management2.Validations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Hospital_Management2.Controllers
{
    public class CitaController : Controller
    {
        private readonly ICitaRepository _citaRepository;
        private readonly IValidator<CitaModel> _validator;
        private readonly IEmailServices _emailService;

        public CitaController(IValidator<CitaModel> validator, ICitaRepository citaRepository, IEmailServices emailService)
        {
            _validator = validator;
            _citaRepository = citaRepository;
            _emailService = emailService;
        }



        // GET: CitaController
        public async Task<ActionResult> Index()
        {
            var cita = await _citaRepository.GetAllAsync();

            return View(cita);
        }

        // GET: CitaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CitaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CitaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CitaModel cita)
        {
            try
            {

                string email = "HospitalRiosAguaViva @gmail.com";
                string subject = "Nuevo Cita";
                string body = "Se a registrado una nueva cita para el paciente " + cita.NombrePaciente;

                _emailService.SendEmail(email, cita.NombrePaciente, subject, body);



                ValidationResult validationResult =
                    await _validator.ValidateAsync(cita);

                if (!validationResult.IsValid)
                {
                    validationResult.AddToModelState(this.ModelState);

                    return View(cita);
                }

                await _citaRepository.AddAsync(cita);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(cita);
            }
        }

        // GET: CitaController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var cita = await _citaRepository.GetByIdAsync(id);

            if (cita == null)
                return NotFound();

            return View(cita);
        }

        // POST: CitaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(CitaModel cita)
        {
            try
            {
                await _citaRepository.EditAsync(cita);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(cita);
            }
        }

        // GET: CitaController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var cita = await _citaRepository.GetByIdAsync(id);
            if (cita == null)
                return NotFound();

            return View(cita);
        }

        // POST: CitaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                await _citaRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                var cita = await _citaRepository.GetByIdAsync(id);
                if (cita == null)
                    return NotFound();

                return View(cita);
            }
        }
    }
}
