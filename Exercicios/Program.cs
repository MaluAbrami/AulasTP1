/* EXERCICIO 1
Console.WriteLine("Digite a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2) / 2;

if(media >= 6 && media <=10)
{
    Console.WriteLine("APROVADO");
}
else if(media >= 4 && media <= 5.9)
{
    Console.WriteLine("RECUPERAÇÃO");
}
else
{
    Console.WriteLine("REPROVADO");
}
*/

/* EXERCICIO 2
Console.WriteLine("Digite o primeiro número: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o terceiro número: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 < num2 && num2 < num3)
{
    Console.Write(num1  + ", " + num2 + ", " + num3);
}
else if (num1 < num3 && num3 < num2)
{
    Console.Write(num1 + ", " + num3 + ", " + num2);
}
else if(num2 < num1 && num1 < num3)
{
    Console.Write(num2 + ", " + num1 + ", " + num3);
}
else if (num2 < num3 && num3 < num1)
{
    Console.Write(num2 + ", " + num3 + ", " + num1);
}
else if(num3 < num1 && num1 < num2)
{
    Console.Write(num3 + ", " + num1 + ", " + num2);
}
else if (num3 < num2 && num2 < num1)
{
    Console.Write(num3 + ", " + num2 + ", " + num1);
}
*/

/* EXERCICIO 3
Console.WriteLine("Insira o código do produto: ");
int codigo = Convert.ToInt32(Console.ReadLine());

switch (codigo) {
    case 1:
        Console.WriteLine("Alimento não-perecível");
        break;
    case 2:
    case 3:
    case 4:
        Console.WriteLine("Alimento perecível");
        break;
    case 5:
    case 6:
        Console.WriteLine("Vestuário");
        break;
    case 7:
        Console.WriteLine("Higiene pessoal");
        break;
    case 8:
    case 9:
    case 10:
    case 11:
    case 12:
    case 13:
    case 14:
    case 15:
        Console.WriteLine("Limpeza");
        break;
    default:
        Console.WriteLine("Inválido");
        break;
}
*/

/* EXERCICIO 4
Console.WriteLine("Digite um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("Número par");
}
else
{
    Console.WriteLine("Número ímpar");
}
*/

/* EXERCICIO 5
Console.WriteLine("Informe sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

if(idade >= 65)
{
    Console.WriteLine("Permitido aposentar");
}
else
{
    Console.WriteLine($"Faltam {65 - idade} anos para você poder aposentar");
}
*/

/* EXERCICIO 6
Console.WriteLine("Informe o tipo sanguíneo da pessoa que irá receber: ");
string receptor = Console.ReadLine();

Console.WriteLine("Informe o tipo sanguíneo da pessoa que irá doar: ");
string doador = Console.ReadLine();

if(doador == "O")
{
    Console.WriteLine($"Doação liberada, doador {doador} e receptor {receptor}");
}
else if(doador == "A" && (receptor == "A" || receptor == "AB"))
{
    Console.WriteLine($"Doação liberada, doador {doador} e receptor {receptor}");
}
else if(doador == "B" && (receptor == "B" || receptor == "AB"))
{
    Console.WriteLine($"Doação liberada, doador {doador} e receptor {receptor}");
}
else if(doador == "AB" && receptor == "AB")
{
    Console.WriteLine($"Doação liberada, doador {doador} e receptor {receptor}");
}
else
{
    Console.WriteLine($"Doação bloqueada, doador {doador} e receptor {receptor} são incompatíveis");
}
*/
