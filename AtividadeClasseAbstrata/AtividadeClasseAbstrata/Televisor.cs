using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasseAbstrata
{
    internal class Televisor : Produto
    {
        private int polegadas;

        public int Polegadas 
        { 
            get { return  polegadas; } 
            set {  polegadas = value; } 
        }

        public Televisor(int id, string name, double price, int polegadas) : base(id, name, price)
        {
            this.Polegadas = polegadas;
        }

        public override void reajustarPreco()
        {
            this.Price += this.Price * 0.01;
        }
    }
}
