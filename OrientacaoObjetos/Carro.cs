using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrientacaoObjetos
{
    internal class Carro
    {
        public String Modelo { get; set; }
        public String Marca { get; set; }
        public String Cor { get; set; }
        public String Chassi { get; set; }
        public String Placa { get; set; }

        public Carro(string modelo, string marca, string cor, string chassi, string placa)
        {
            Modelo = modelo;
            Marca = marca;
            Cor = cor;
            Chassi = chassi;
            Placa = placa;
        }

        public void acelerar()
        {
            MessageBox.Show($"Acelerando o carro");
        }

        public void frear()
        {
            MessageBox.Show($"Freando o carro");
        }

        public void trocarMarcha()
        {
            MessageBox.Show($"Trocando a marcha do carro");
        }
        public void ligarRadio()
        {
            MessageBox.Show($"Ligando o rádio");
        }
        public void abaixarVidros()
        {
            MessageBox.Show($"Abaixando os vidros");
        }
    }
}
