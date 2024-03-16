﻿using Hamburgueria.DATA.Infrastructure;
using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Repository
{
    public class PratosRepository : IPratosRepository
    {

        private readonly ConnectionContext _context = new();

        public void CadastrarPrato(Pratos prato)
        {
            _context.Pratos.Add(prato);
            _context.SaveChanges();
        }

        public void DeletarPrato(Pratos prato)
        {
            _context.Entry(prato).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EditarPrato(Pratos prato)
        {
            _context.Entry(prato).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Pratos GetPratoById(int pratoId)
        {
            return _context.Pratos.Where(a => a.Codigo == pratoId && a.Ativo == true).ToList().FirstOrDefault();
        }

        public Pratos GetPratoByName(string nomePrato)
        {
            return _context.Pratos.Where(a => a.NomePrato.ToLower() == nomePrato.ToLower() && a.Ativo == true).ToList().FirstOrDefault();
        }

        public IList<Pratos> ListarPratos()
        {
            return _context.Pratos.Where(a => a.Ativo == true).ToList();
        }
    }
}
