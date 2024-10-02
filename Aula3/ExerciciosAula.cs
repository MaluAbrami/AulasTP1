/* EXERCICIO 1
string senha = "";
do
{
    Console.WriteLine("Informe a senha: ");
    senha = Console.ReadLine();
    if(senha == "12345")
    {
        Console.WriteLine($"Senha {senha} correta!");
        break;
    }
    Console.WriteLine("Senha incorreta, tente novamente.");
} while (senha != "12345");
*/

/* EXERCICIO 2
string pares = "", impares = "";
int entrada, soma = 0, somaImpar = 0, contador = 0, media = 0;

do
{
    Console.WriteLine("Digite um valor: ");
    entrada = Convert.ToInt32(Console.ReadLine());

    if(entrada % 2 == 0)
    {
        pares = $"{pares}" + " " + $"{entrada}";
        soma += entrada;
    }
    else
    {
        impares = $"{impares}" + " " + $"{entrada}";
        contador++;
        somaImpar += entrada;
        media = somaImpar / contador;
    }

} while (entrada != 0);

Console.WriteLine($"Números pares: {pares}\nNúmeros Impares: {impares}\nSoma dos números pares: {soma}\nMédia dos números impares: {media}");
*/

int ano = 0, contador = 0;
double soma = 0;
string aux = "";

do
{
    Console.WriteLine("Informe o ano do carro: ");
    ano = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe o valor do carro: ");
    double valorCarro = Convert.ToDouble(Console.ReadLine());

    if(ano <= 2000)
    {
        double desconto = valorCarro * 0.88;
        soma += desconto;
        contador++;
    }
    else
    {
        double desconto = valorCarro * 0.93;
        soma += desconto;
    }

    Console.WriteLine("Deseja continuar inserindo? Se não digite N");
    aux = Console.ReadLine();

} while (aux != "N");

Console.WriteLine($"Quantidade de carros com ano até 2000: {contador}\nValor total a se pagar em todos os carros com desconto aplicado: {soma}");