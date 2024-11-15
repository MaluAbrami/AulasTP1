﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasseAbstrata
{
    internal class Guitarra : Produto
    {
        public Guitarra(int id, string name, double price) : base(id, name, price) { }

        public override void reajustarPreco()
        {
            this.Price += this.Price * 0.005;
        }
    }
}
