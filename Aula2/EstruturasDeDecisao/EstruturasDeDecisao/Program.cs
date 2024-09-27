internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número: ");
        string num1String = Console.ReadLine();
        int num1 = Convert.ToInt32(num1String);

        Console.WriteLine("Digite o segundo número: ");
        string num2String = Console.ReadLine();
        int num2 = Convert.ToInt32(num2String);

        if (num1 % num2 == 0)
        {
            Console.WriteLine("O primeiro número é múltiplo do segundo.");
        }
        else
        {
            Console.WriteLine("O primeiro número não é múltiplo do segundo.");
        }

        Console.WriteLine(num1 % num2 == 0 ? "O primeiro número é múltiplo do segundo." : "O primeiro número não é múltiplo do segundo."); //Outra forma de representar
    }
}