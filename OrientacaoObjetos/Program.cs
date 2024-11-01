using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  EXEMPLO DA AULA
            HelloWorld helloWorld = new HelloWorld("Malu");
            HelloWorld helloWorld1 = new HelloWorld();
            HelloWorld helloWorld2 = new HelloWorld("IFSP");

            helloWorld.sayHello();
            helloWorld1.sayHello();
            helloWorld2.sayHello();
            */

            Carro carro = new Carro("civic", "honda", "preto", "123455656", "ABC-123");
            carro.acelerar();
            carro.frear();
            carro.trocarMarcha();
            carro.ligarRadio();
            carro.abaixarVidros();

            Moto moto = new Moto("ninja", "kawasaki", "verde", "123154563", "CDE-567");
            moto.ligar();
            moto.acelerar();
            moto.frear();
            moto.trocarMarcha();
            moto.cortarDeGiro();

            Cavalo cavalo = new Cavalo("palomino", "quarto de milha", "1.70", "5 anos", "350 kg")
            cavalo.saltar();
            cavalo.relinchar();
            cavalo.correr();
            cavalo.comer();
            cavalo.darCoice();
        }
    }
}
