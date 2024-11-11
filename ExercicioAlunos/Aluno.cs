using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAlunos 
{ 
    internal class Aluno[]
    {
        private int ra;
        private string nome;
        private double[] nota;
        private double media;
        private bool situacao;

        public int Ra
        {
            get { return ra; }
            set { ra = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double[] Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public Aluno(int ra, string nome, double[] nota) 
        {
            this.ra = ra;
            this.nome = nome;
            this.nota = nota;
            this.media = calcularMedia(nota);
        }

        public double calcularMedia(double[] nota)
        {
            double soma = 0;

            for(int i = 0; i < nota.Lenght; i++)
            {
                switch(nota[i])
                {
                    case 1://peso 1
                    case 2://peso 1
                    case 3://peso 1
                    {
                        soma += nota[i]; 
                        break;
                    }
                    case 4://peso 7
                    {
                        soma += (nota[i] * 7);
                        break;
                    }
                }
            }

            return soma/10;
        }

        public void definirSituacao(double media)
        {
            if(media < 4) 
            {
                this.situacao = false;
            }
            else if(media >= 4 && media < 6)
            {
                this.situacao = undefined;
            }
            else
            {
                this.situacao = true;
            }
        }
    }
}