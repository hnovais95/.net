﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(Cliente cliente) : base(cliente)
        {
        }
    }
}