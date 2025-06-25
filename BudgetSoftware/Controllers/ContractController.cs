using BudgetSoftware.Models;
using Microsoft.AspNetCore.Mvc;

namespace BudgetSoftware.Controllers
{
    public class ContractController : Controller
    {
        private readonly ContractDbContext _context;

        public ContractController(ContractDbContext context)
        {
            _context = context;
        }

        // GET: /Contract
        public async Task<IActionResult> Index()
        {
            var contracts = await Task.FromResult(_context.Contracts.ToList());
            return View(contracts);
        }

        // GET: /Contract/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Contract/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContractNumber,ValidFrom,ValidTo,BudgetValidity,Programme,State,DutyStation,Modality,Comments")] Contract contract)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contract);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contract);
        }
    }
}
