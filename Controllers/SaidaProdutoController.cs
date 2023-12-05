﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_final.Models;

namespace Projeto_final.Controllers
{
    public class SaidaProdutoController : Controller
    {
        private readonly Contexto _context;

        public SaidaProdutoController(Contexto context)
        {
            _context = context;
        }

        // GET: SaidaProduto
        public async Task<IActionResult> Index()
        {
            var contexto = _context.SaidaProduto.Include(s => s.Cliente).Include(s => s.Produto).Include(s => s.TipoSaida);
            return View(await contexto.ToListAsync());
        }

        // GET: SaidaProduto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SaidaProduto == null)
            {
                return NotFound();
            }

            var saidaProduto = await _context.SaidaProduto
                .Include(s => s.Cliente)
                .Include(s => s.Produto)
                .Include(s => s.TipoSaida)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (saidaProduto == null)
            {
                return NotFound();
            }

            return View(saidaProduto);
        }

        // GET: SaidaProduto/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "ClienteNome");
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "NomeProduto");
            ViewData["TipoSaidaId"] = new SelectList(_context.TipoSaida, "Id", "TipoSaidaDescricao");
            return View();
        }

        // POST: SaidaProduto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProdutoId,DataSaida,QuantidadeSaida,ClienteId,TipoSaidaId")] SaidaProduto saidaProduto)
        {
            if (ModelState.IsValid)
            {
                var produto = await _context.Produto.Where(p => p.Id == saidaProduto.ProdutoId).FirstOrDefaultAsync();
                produto.QuantidadeEstoque = produto.QuantidadeEstoque - saidaProduto.QuantidadeSaida;
                _context.Update(produto);
                _context.Add(saidaProduto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "ClienteNome", saidaProduto.ClienteId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "NomeProduto", saidaProduto.ProdutoId);
            ViewData["TipoSaidaId"] = new SelectList(_context.TipoSaida, "Id", "TipoSaidaDescricao", saidaProduto.TipoSaidaId);
            return View(saidaProduto);
        }

        // GET: SaidaProduto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SaidaProduto == null)
            {
                return NotFound();
            }

            var saidaProduto = await _context.SaidaProduto.FindAsync(id);
            if (saidaProduto == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "ClienteNome", saidaProduto.ClienteId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "NomeProduto", saidaProduto.ProdutoId);
            ViewData["TipoSaidaId"] = new SelectList(_context.TipoSaida, "Id", "TipoSaidaDescricao", saidaProduto.TipoSaidaId);
            return View(saidaProduto);
        }

        // POST: SaidaProduto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProdutoId,DataSaida,QuantidadeSaida,ClienteId,TipoSaidaId")] SaidaProduto saidaProduto)
        {
            if (id != saidaProduto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saidaProduto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaidaProdutoExists(saidaProduto.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "ClienteNome", saidaProduto.ClienteId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "NomeProduto", saidaProduto.ProdutoId);
            ViewData["TipoSaidaId"] = new SelectList(_context.TipoSaida, "Id", "TipoSaidaDescricao", saidaProduto.TipoSaidaId);
            return View(saidaProduto);
        }

        // GET: SaidaProduto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SaidaProduto == null)
            {
                return NotFound();
            }

            var saidaProduto = await _context.SaidaProduto
                .Include(s => s.Cliente)
                .Include(s => s.Produto)
                .Include(s => s.TipoSaida)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (saidaProduto == null)
            {
                return NotFound();
            }

            return View(saidaProduto);
        }

        // POST: SaidaProduto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SaidaProduto == null)
            {
                return Problem("Entity set 'Contexto.SaidaProduto'  is null.");
            }
            var saidaProduto = await _context.SaidaProduto.FindAsync(id);
            if (saidaProduto != null)
            {
                _context.SaidaProduto.Remove(saidaProduto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaidaProdutoExists(int id)
        {
          return (_context.SaidaProduto?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
