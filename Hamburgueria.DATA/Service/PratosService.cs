﻿using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Service
{
    public class PratosService
    {
        private readonly IPratosRepository _pratosRepository;

        public PratosService(PratosRepository pratosRepository)
        {
            _pratosRepository = pratosRepository;
        }


    }
}
