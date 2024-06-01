using FluentValidation;
using FluentValidation.Results;
using Hospital_Management2.Models;
using Hospital_Management2.Repositories.Medicamento;
using Hospital_Management2.Validations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management2.Controllers
{
    public class MedicamentoController : Controller
    {
        private readonly IMedicamentoRepository _medicamentoRepository;
        private readonly IValidator<MedicamentoModel> _validator;

        public MedicamentoController(IMedicamentoRepository medicamentoRepository, 
            IValidator<MedicamentoModel> validator)
        {
            _medicamentoRepository = medicamentoRepository;
            _validator = validator;
        }

        
        // GET: MedicamentoController
        public async Task<ActionResult> Index()
        {
            var medicamentos = await _medicamentoRepository.GetAllAsync();

            return View(medicamentos);
        }

        // GET: MedicamentoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MedicamentoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicamentoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(MedicamentoModel medicamento)
        {
            try
            {
                ValidationResult validationResult =
                    await _validator.ValidateAsync(medicamento);

                if (!validationResult.IsValid)
                {
                    validationResult.AddToModelState(this.ModelState);

                    return View(medicamento);
                }

                await _medicamentoRepository.AddAsync(medicamento);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(medicamento);
            }
        }

        // GET: MedicamentoController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var medicamento = await _medicamentoRepository.GetByIdAsync(id);

            if (medicamento == null)
                return NotFound();

            return View(medicamento);
        }

        // POST: MedicamentoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(MedicamentoModel medicamento)
        {
            try
            {
                await _medicamentoRepository.EditAsync(medicamento);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(medicamento);
            }
        }

        // GET: MedicamentoController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var medicamento = await _medicamentoRepository.GetByIdAsync(id);
            if (medicamento == null)
                return NotFound();

            return View(medicamento);
        }

        // POST: MedicamentoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                await _medicamentoRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                var medicamento = await _medicamentoRepository.GetByIdAsync(id);
                if (medicamento == null)
                    return NotFound();

                return View(medicamento);
            }
        }
    }
}
