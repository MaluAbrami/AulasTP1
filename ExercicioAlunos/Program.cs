using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno(1, "Malu", {1, 1, 2, 1});
            
            Console.WriteLine(aluno1.ra);
            Console.WriteLine(aluno1.nome);

            for(int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Nota {i} = {aluno1.nota[i]}");
            }

            Console.WriteLine($"Media de {aluno1.nome} é {aluno1.media}");

            switch(op)
            {
                case 1:
                {
                    //CADASTRAR ALUNO
                }
                case 2:
                {
                    //EXIBIR APROVADOS, RECUPERAÇÃO E REPROVADOS
                }
            }
        }
    }
}
