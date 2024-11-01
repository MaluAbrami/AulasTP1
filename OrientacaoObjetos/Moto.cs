using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrientacaoObjetos
{
    internal class Moto
    {
        public String Modelo { get; set; }
        public String Marca { get; set; }
        public String Cor { get; set; }
        public String Chassi { get; set; }
        public String Placa { get; set; }

        public Moto(string modelo, string marca, string cor, string chassi, string placa)
        {
            Modelo = modelo;
            Marca = marca;
            Cor = cor;
            Chassi = chassi;
            Placa = placa;
        }
        public void ligar()
        {
            MessageBox.Show($"Ligando a moto");
        }

        public void acelerar()
        {
            MessageBox.Show($"Acelerando a moto");
        }

        public void frear()
        {
            MessageBox.Show($"Freando a moto");
        }

        public void trocarMarcha()
        {
            MessageBox.Show($"Trocando a marcha da moto");
        }
        public void cortarDeGiro()
        {
            MessageBox.Show($"Cortando de giro");
        }

    }
}
