/* MINHA SOLUÇÃO(PEQUENO ERRO CASO INSERISSEM O NÚMERO "0"
Console.WriteLine("Digite um número inteiro positivo: ");
int num = Convert.ToInt32(Console.ReadLine());

string numBinario = "";

do
{
    if(num % 2 == 0)
    {
        int aux = num / 2;
        num = aux;
        numBinario = "0" + $"{numBinario}";
    }
    else if(num % 2 == 1)
    {
        int aux = num / 2;
        num = aux;
        numBinario = $"1" + $"{numBinario}";
    }
} while (num > 0 && num != 1);

if(num == 1)
{
    numBinario = "1" + $"{numBinario}";
    Console.WriteLine($"{numBinario}");
}
else
{
    Console.WriteLine($"{numBinario}");
}
 */

//SOLUÇÃO DO PROFESSOR
string resultado = "";
int resto;

Console.WriteLine("Informe um número inteiro positivo: ");
string entrada = Console.ReadLine();

if (entrada == "0" || entrada == "")
{
    resultado = "0";
}
else
{
    int num = int.Parse(entrada);
    while(num > 0)
    {
        resto = num % 2;
        resultado = resto.ToString() + resultado;
        num = num / 2;
    }
}
Console.WriteLine("\n\nNúmero Binário: " + resultado);