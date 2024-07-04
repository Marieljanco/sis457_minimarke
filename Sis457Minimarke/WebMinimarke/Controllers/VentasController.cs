using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMinimarke.Models;

namespace WebMinimarke.Controllers
{
    public class VentasController : Controller
    {
        private readonly LabMinimarkeContext _context;

        public VentasController(LabMinimarkeContext context)
        {
            _context = context;
        }

        // GET: Ventas
        public async Task<IActionResult> Index()
        {
            var labMinimarkeContext = _context.Venta
                .Include(v => v.IdClienteNavigation)
                .Include(v => v.IdEmpleadoNavigation)
                .Include(v => v.IdProductoNavigation);
            return View(await labMinimarkeContext.ToListAsync());
        }

        // GET: Ventas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ventum = await _context.Venta
                .Include(v => v.IdClienteNavigation)
                .Include(v => v.IdEmpleadoNavigation)
                .Include(v => v.IdProductoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ventum == null)
            {
                return NotFound();
            }

            return View(ventum);
        }

        // GET: Ventas/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Id");
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "Id", "Id");
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id");
            return View();
        }

        // POST: Ventas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdProducto,IdCliente,IdEmpleado,Transaccion,Fecha")] Ventum ventum)
        {
            if (ventum.Transaccion > 0)
            {
                _context.Add(ventum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Id", ventum.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "Id", "Id", ventum.IdEmpleado);
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id", ventum.IdProducto);
            return View(ventum);
        }

        // GET: Ventas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ventum = await _context.Venta.FindAsync(id);
            if (ventum == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Id", ventum.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "Id", "Id", ventum.IdEmpleado);
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id", ventum.IdProducto);
            return View(ventum);
        }

        // POST: Ventas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdProducto,IdCliente,IdEmpleado,Transaccion,Fecha")] Ventum ventum)
        {
            if (id != ventum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ventum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VentumExists(ventum.Id))
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
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Id", ventum.IdCliente);
            ViewData["IdEmpleado"] = new SelectList(_context.Empleados, "Id", "Id", ventum.IdEmpleado);
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id", ventum.IdProducto);
            return View(ventum);
        }

        // GET: Ventas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ventum = await _context.Venta
                .Include(v => v.IdClienteNavigation)
                .Include(v => v.IdEmpleadoNavigation)
                .Include(v => v.IdProductoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ventum == null)
            {
                return NotFound();
            }

            return View(ventum);
        }

        // POST: Ventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ventum = await _context.Venta.FindAsync(id);
            if (ventum != null)
            {
                _context.Venta.Remove(ventum);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VentumExists(int id)
        {
            return _context.Venta.Any(e => e.Id == id);
        }
    }
}
