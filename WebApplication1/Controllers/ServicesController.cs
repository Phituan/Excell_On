using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DbContextExcellOn _context;

        public ServicesController(DbContextExcellOn context)
        {
            _context = context;
        }

        // GET: Services
        public async Task<IActionResult> Index()
        {
            var dbContextExcellOn = _context.Service.Include(s => s.CompanyCompany).Include(s => s.EmployeeEmployee).Include(s => s.ServiceTypeServiceType);
            return View(await dbContextExcellOn.ToListAsync());
        }

        // GET: Services/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Service
                .Include(s => s.CompanyCompany)
                .Include(s => s.EmployeeEmployee)
                .Include(s => s.ServiceTypeServiceType)
                .FirstOrDefaultAsync(m => m.ServiceId == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            ViewData["CompanyCompanyId"] = new SelectList(_context.Company, "CompanyId", "CompanyId");
            ViewData["EmployeeEmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "EmployeeId");
            ViewData["ServiceTypeServiceTypeId"] = new SelectList(_context.ServiceType, "ServiceTypeId", "ServiceTypeId");
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServiceId,ServiceName,ServiceImage,ServicePrice,ServiceDescription,ServiceCharge,ServiceIsDelete,EmployeeEmployeeId,ServiceTypeServiceTypeId,CompanyCompanyId")] Service service)
        {
            if (ModelState.IsValid)
            {
                service.ServiceId = Guid.NewGuid();
                _context.Add(service);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyCompanyId"] = new SelectList(_context.Company, "CompanyId", "CompanyId", service.CompanyCompanyId);
            ViewData["EmployeeEmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "EmployeeId", service.EmployeeEmployeeId);
            ViewData["ServiceTypeServiceTypeId"] = new SelectList(_context.ServiceType, "ServiceTypeId", "ServiceTypeId", service.ServiceTypeServiceTypeId);
            return View(service);
        }

        // GET: Services/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Service.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            ViewData["CompanyCompanyId"] = new SelectList(_context.Company, "CompanyId", "CompanyId", service.CompanyCompanyId);
            ViewData["EmployeeEmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "EmployeeId", service.EmployeeEmployeeId);
            ViewData["ServiceTypeServiceTypeId"] = new SelectList(_context.ServiceType, "ServiceTypeId", "ServiceTypeId", service.ServiceTypeServiceTypeId);
            return View(service);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ServiceId,ServiceName,ServiceImage,ServicePrice,ServiceDescription,ServiceCharge,ServiceIsDelete,EmployeeEmployeeId,ServiceTypeServiceTypeId,CompanyCompanyId")] Service service)
        {
            if (id != service.ServiceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(service);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceExists(service.ServiceId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyCompanyId"] = new SelectList(_context.Company, "CompanyId", "CompanyId", service.CompanyCompanyId);
            ViewData["EmployeeEmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "EmployeeId", service.EmployeeEmployeeId);
            ViewData["ServiceTypeServiceTypeId"] = new SelectList(_context.ServiceType, "ServiceTypeId", "ServiceTypeId", service.ServiceTypeServiceTypeId);
            return View(service);
        }

        // GET: Services/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Service
                .Include(s => s.CompanyCompany)
                .Include(s => s.EmployeeEmployee)
                .Include(s => s.ServiceTypeServiceType)
                .FirstOrDefaultAsync(m => m.ServiceId == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var service = await _context.Service.FindAsync(id);
            _context.Service.Remove(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceExists(Guid id)
        {
            return _context.Service.Any(e => e.ServiceId == id);
        }
    }
}
