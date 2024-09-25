/* PRIMEIRO EXEMPLO
int idade = 25;
double altura = 1.75;
string nome = "João";
bool possuiCarteiraDeMotorista = true;

Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Altura: {altura}");
Console.WriteLine(string.Format("Altura: {0}", altura));//outra forma de escrever
Console.WriteLine($"Possui carteira de motorista? {possuiCarteiraDeMotorista}");
*/

/* SEGUNDO EXEMPLO
Console.Write("Digite o seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite a sua idade: ");
string idadeString = Console.ReadLine();
int idade = int.Parse(idadeString);

//Pode-se utilizar o convert:
double idade = Convert.ToInt32(idadeString);
 

Console.Write("Digite a sua altura: ");
string alturaString = Console.ReadLine();
double altura = double.Parse(alturaString);

//Pode-se utilizar o convert:
double altura = Convert.ToDouble(alturaString);


Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade} anos");
Console.WriteLine($"Altura: {altura} cm");

//OBSERVAÇÃO:
Usa-se o Parse quando você tem certeza de que a entrada é uma string válida e
precisa convertê-la diretamente para o tipo numérico correspondente ou outro
tipo compatível.
                VS
Usa-se o Convert quando você não tem certeza do tipo de entrada (por exemplo,
pode ser um object ou pode ser null) e deseja realizar uma conversão segura,
lidando com valores null e tipos diferentes.

//Exponenciação:
Console.Write("Digite a base (número que será elevado): ");
string baseString = Console.ReadLine();
double baseNumero = Convert.ToDouble(baseString);

Console.Write("Digite o expoente: ");
string expoenteString = Console.ReadLine();
double expoente = Convert.ToDouble(expoenteString);

double resultado = Math.Pow(baseNumero, expoente);

Console.WriteLine($"\nResultado: {baseNumero} elevado a {expoente} = {resultado}");

//Radiciação:

//Módulo:
 */

/*EXERCÍCIO 1
Console.WriteLine("Digite o primeiro número: ");
string numero1String = Console.ReadLine();
double numero1 = Convert.ToDouble(numero1String);

Console.WriteLine("Digite o segundo número: ");
string numero2String = Console.ReadLine();
double numero2 = Convert.ToDouble(numero2String);

double soma = numero1 + numero2;
double subtracao = numero1 - numero2;
double multiplicacao = numero1 * numero2;
double divisao = numero1 / numero2;

Console.WriteLine("Resultados:");
Console.WriteLine($"{numero1} + {numero2} = {soma}");
Console.WriteLine($"{numero1} - {numero2} = {subtracao}");
Console.WriteLine($"{numero1} * {numero2} = {multiplicacao}");
Console.WriteLine($"{numero1} / {numero2} = {divisao}");

EXERCÍCIO 2
Console.WriteLine("Digite o raio da circunferência: ");
string raioString = Console.ReadLine();
double raio = Convert.ToDouble(raioString);

double raioAoQuadrado = Math.Pow(raio, 2);
double pi = 3.14;
double areaCircunferencia = raioAoQuadrado * pi;

Console.WriteLine($"O raio {raio} elevado ao quadrado ({raioString}) * pi ({pi}) é igual a uma área de {areaCircunferencia}");

EXERCÍCIO 3
Console.WriteLine("Digite o primeiro cateto: ");
string primeiroCatetoString = Console.ReadLine();
double primeiroCateto = Convert.ToDouble(primeiroCatetoString);

Console.WriteLine("Digite o segundo cateto: ");
string segundoCatetoString = Console.ReadLine();
double segundoCateto = Convert.ToDouble(segundoCatetoString);

double hipotenusa;
double primeiroCatetoAoQuadrado = Math.Pow(primeiroCateto, 2);
double segundoCatetoAoQuadrado = Math.Pow(segundoCateto, 2);

if(primeiroCateto < 0 || segundoCateto < 0)
{
    Console.WriteLine("Erro: Não é possível calcular raiz quadrada de número negativos!");
}
else
{
    hipotenusa = Math.Sqrt(primeiroCatetoAoQuadrado + segundoCatetoAoQuadrado);
    Console.WriteLine($"A hipotenusa é igual a raiz quadrada do primeiro cateto ao quadrado {primeiroCatetoAoQuadrado} mais o segundo cateto ao quadrado {segundoCatetoAoQuadrado}, ou seja, é igual a {hipotenusa}");
}

EXERCÍCIO 4
Console.WriteLine("Digite a altura da lata de óleo: ");
string alturaLataString = Console.ReadLine();
double alturaLata = Convert.ToDouble(alturaLataString);

Console.WriteLine("Digite o raio da lata de óleo: ");
string raioLataString = Console.ReadLine();
double raioLata = Convert.ToDouble(raioLataString);

double pi = 3.14;
double volumeLata = alturaLata * (raioLata * pi);

Console.WriteLine($"O volume da lata é igual a altura {alturaLata} * o raio {raioLata} * pi {pi} que resulta em {volumeLata}");
*/