/* 
Exercicio 1

List<int> lista = new List<int>();
int num;

do
{
    Console.WriteLine("Informe um número: ");
    num = Convert.ToInt32(Console.ReadLine());

    if(num != 0)
    {
        lista.Add(num);
    }

} while(num != 0);

List<int> listaPares = new List<int>();
List<int> listaImpares = new List<int>();

listaPares = lista.FindAll(x => (x % 2 == 0));
listaImpares = lista.FindAll(x => (x % 2 != 0));

int somaPar = 0;
foreach(int i in listaPares)
{
    somaPar += i;
}

int somaImpar = 0;
foreach(int i in listaImpares)
{
    somaImpar += i;
}

Console.WriteLine("--------Lista--------");
foreach(int i in lista)
{
    Console.Write($"{i}\t");
}

Console.WriteLine($"\nQuantidade de números pares na lista é {listaPares.Count()} e sua somatória resulta em {somaPar}");
Console.WriteLine($"Quantidade de números impares na lista é {listaImpares.Count()} e sua somatória resulta em {somaImpar}");

Exercicio 2

List<int> lista = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int num;

Console.WriteLine("---------Lista atual---------\n");
foreach (int i in lista)
{
    Console.Write($"{i}  ");
}

Console.WriteLine("\n\nInforme o número que deseja remover da lista: ");
num = Convert.ToInt32(Console.ReadLine());

if (lista.Contains(num))
{
    lista.Remove(num);
    Console.WriteLine("\nNúmero removido com sucesso!\n---------Lista após remoção---------\n");
    foreach(int i in lista)
    {
        Console.Write($"{i}  ");
    }
}
else
{
    Console.WriteLine("\nErro: o número informado não existe na lista.");
}

Exercicio 3

List<int> lista = new List<int>() { 15, 2, 23, 34, 125, 6, 7, 58, 79, 110 };
bool aux = false;

for(int i = 1; i < lista.Count; i++)
{
    if (lista[i] < lista[i - 1])
    {
        aux = true; //significa que a lista não está ordenada
        break;
    }
}

if (aux) //Se não está ordenada, primeiro ordenamos e então pegamos o número no primeiro indice(menor) e o número no último indice(maior)
{
    Console.Write("A lista não está ordenada\n");
    foreach (int i in lista)
    {
        Console.Write($"{i}  ");
    }

    lista.Sort(); //Ordena a lista
    Console.Write("\n\nLista após ordenação\n");
    foreach (int i in lista)
    {
        Console.Write($"{i}  ");
    }

    Console.WriteLine($"\n\nMenor número da lista é {lista[0]}\nMaior número da lista é {lista[lista.Count - 1]} e se encontra no índice {lista.Count - 1}");
}
else //Se já está ordenada, apenas pegamos o menor e maior direto
{
    Console.Write("A lista já está ordenada\n");
    foreach (int i in lista)
    {
        Console.Write($"{i}  ");
    }

    Console.WriteLine($"\n\nMenor número da lista é {lista[0]}\nMaior número da lista é {lista[lista.Count - 1]} e se encontra no índice {lista.Count - 1}");
}

Exercicio 4

List<string> listaStrings = new List<string>() {"Ana Laura", "Ana Beatriz", "Maria Luiza", "Maria Luisa", "Rafael", "Isabela", "Ricardo", "Vagner"};

Console.WriteLine("---------Lista de nomes---------");
foreach (string str in listaStrings)
{
    Console.WriteLine($"{str}  ");
}

listaStrings.Sort();

Console.WriteLine("---------Lista de nomes após ordenação---------");
foreach (string str in listaStrings)
{
    Console.WriteLine($"{str}  ");
}
*/