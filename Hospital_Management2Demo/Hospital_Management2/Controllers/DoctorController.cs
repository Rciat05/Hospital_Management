using FluentValidation;
using FluentValidation.Results;
using Hospital_Management2.Models;
using Hospital_Management2.Repositories.Doctor;
using Hospital_Management2.Validations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace Hospital_Management2.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IValidator<DoctorModel> _validator;
        public DoctorController(IDoctorRepository doctorRepository, 
            IValidator<DoctorModel> validator)
        {
            _doctorRepository = doctorRepository;
            _validator = validator;

        }

        // GET: DoctorController
        public async Task<ActionResult> Index()
        {
            var doctor = await _doctorRepository.GetAllAsync();

            return View(doctor);
        }


        // GET: DoctorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

		// GET: DoctorController/Create
		public ActionResult Create()
		{
			return View();
		}

		// GET: DoctorController/Create
		[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(DoctorModel doctor)
        {
            try
            {
                ValidationResult validationResult =
                    await _validator.ValidateAsync(doctor);

                if (!validationResult.IsValid)
                {
                    validationResult.AddToModelState(this.ModelState);

                    return View(doctor);
                }

                await _doctorRepository.AddAsync(doctor);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(doctor);
            }
        }

        // GET: DoctorController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var doctor = await _doctorRepository.GetByIdAsync(id);

            if (doctor == null)
                return NotFound();

            return View(doctor);
        }

        // POST: DoctorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(DoctorModel doctor)
        {
            try
            {
                await _doctorRepository.EditAsync(doctor);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(doctor);
            }
        }

        // GET: DoctorController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var doctor = await _doctorRepository.GetByIdAsync(id);
            if (doctor == null)
                return NotFound();

            return View(doctor);
        }

        // POST: DoctorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                await _doctorRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                var doctor = await _doctorRepository.GetByIdAsync(id);
                if (doctor == null)
                    return NotFound();

                return View(doctor);
            }
        }
    }
}
