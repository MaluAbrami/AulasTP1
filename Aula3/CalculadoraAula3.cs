int op;
do
{
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("Escolha uma opcao: ");
    op = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite um número: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite um número: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int resultado = 0;

    switch (op)
    {
        case 1:
            resultado = num1 + num2;
            Console.WriteLine($"Soma de {num1} + {num2} = {resultado}");
            break;

        case 2:
            resultado = num1 - num2;
            Console.WriteLine($"Subtração de {num1} - {num2} = {resultado}");
            break;

        case 3:
            resultado = num1 * num2;
            Console.WriteLine($"Multiplicação de {num1} * {num2} = {resultado}");
            break;

        case 4:
            if (num2 == 0)
            {
                Console.WriteLine("Não é possível dividir por 0.");
            }
            else
            {
                resultado = num1 / num2;
                Console.WriteLine($"Soma de {num1} / {num2} = {resultado}");
            }
            break;

        default:
            break;
    }
} while (op != 5);