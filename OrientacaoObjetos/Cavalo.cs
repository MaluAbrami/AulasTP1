using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrientacaoObjetos
{
    internal class Cavalo
    {
        public String Pelagem { get; set; }
        public String Raça { get; set; }
        public String Altura { get; set; }
        public String Idade { get; set; }
        public String Peso { get; set; }

        public Cavalo(string pelagem, string raça, string altura, string idade, string peso)
        {
            Pelagem = pelagem;
            Raça = raça;
            Altura = altura;
            Idade = idade;
            Peso = peso;
        }

        public void relinchar()
        {
            MessageBox.Show("Relinchando");
        }
        public void darCoice()
        {
            MessageBox.Show("Dando coices");
        }
        public void correr()
        {
            MessageBox.Show("Cavalo está correndo");
        }
        public void saltar()
        {
            MessageBox.Show("Cavalo está saltando");
        }
        public void comer()
        {
            MessageBox.Show("Cavalo está comendo");
        }
    }
}
