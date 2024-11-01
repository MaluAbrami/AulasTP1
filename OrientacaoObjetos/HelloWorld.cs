using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrientacaoObjetos
{
    internal class HelloWorld
    {
        private string name;

        public HelloWorld()
        {
            name = "Desconhecido";
        }
        public HelloWorld(string n)
        {
            name = n;
        }
        public void sayHello()
        {
            MessageBox.Show($"Olá {name}");
        }

        /* EXEMPLO DE PROPRIEDADES DE ATRIBUTOS
        public String Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        */
    }
}
