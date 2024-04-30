﻿using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Interfaces.IServices;
using Hamburgueria.DATA.Models;
using System.IO;

namespace Hamburgueria.DATA.Service
{
    public class PratosService : IPratosService
    {
        private readonly IPratosRepository _pratosRepository;

        public PratosService(IPratosRepository pratosRepository)
        {
            _pratosRepository = pratosRepository;
        }

        public Pratos GetPratoByName(string nomePrato)
        {
            return _pratosRepository.GetPratoByName(nomePrato);
        }

        public void CadastrarPrato(Pratos prato)
        {

            _pratosRepository.CadastrarPrato(prato);
        }

        public IList<Pratos> ListarPratos()
        {
            return _pratosRepository.ListarPratos();
        }

        public Pratos GetPratoById(int pratoId)
        {
            return _pratosRepository.GetPratoById(pratoId);
        }

        public void DeletarPrato(Pratos prato)
        {
            _pratosRepository.DeletarPrato(prato);
        }

        public void EditarPrato(Pratos prato)
        {
            _pratosRepository.EditarPrato(prato);
        }

        public void CadastrarPratosXIngrediente(PratosXIngrediente pratosXIngrediente)
        {
            _pratosRepository.CadastrarPratosXIngrediente(pratosXIngrediente);
        }
    }
}
