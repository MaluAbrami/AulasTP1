/*

-------------Ex1-------------:

int[] vetor = new int[10];
int soma = 0, media;

foreach(int i in vetor)
{
    Console.WriteLine("Informe um número: ");
    vetor[i] = Convert.ToInt32(Console.ReadLine());
    soma += vetor[i];
}

media = soma / 10;
Console.WriteLine($"A média dos 10 números do array é {media}");

-------------Ex2-------------:

int[] vetor = new int[10];

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Informe um número: ");
    vetor[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Os números primos são: ");
for(int i = 0; i < 10 ; i++)
{
    if (vetor[i] == 2)
    {
        Console.WriteLine($"{vetor[i]}");
    }
    else if (vetor[i] % 2 != 0 && vetor[i] != 1)
    {
        Console.WriteLine($"{vetor[i]}");
    }
}

-------------Ex3-------------:

int[,] matriz = new int[5, 5];

int[] somaLinha = new int[5];
int[] mediaLinha = new int[5];

int[] somaColuna = new int[5];
int[] mediaColuna = new int[5];

for(int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        Console.WriteLine($"Informe o número de posição {i+1}, {j+1}: "); //Inserir na matriz
        matriz[i, j] = Convert.ToInt32(Console.ReadLine());

        somaLinha[i] += matriz[i, j]; //Para somar cada linha

        somaColuna[j] += matriz[i, j]; //Para somar cada coluna
    }

    mediaLinha[i] = somaLinha[i] / 5; //Para tirar a média de cada linha
}

for(int j = 0; j < 5; j++) //Para tirar a média de cada coluna 
{
    mediaColuna[j] = somaColuna[j] / 5;
}

int somaMatriz = 0;
foreach (int i in matriz) //Para somarmos o total da matriz
{
    somaMatriz += i;
}
int mediaMatriz = somaMatriz / 25; //Para tirarmos a média total da matriz

Console.WriteLine("\n------------Matriz------------");
for(int i = 0; i < 5; i++) //Para imprimirmos a matriz
{
    for(int j = 0; j < 5; j++)
    {
        Console.Write($"{matriz[i, j]}\t"); //vai imprimir toda a linha
    }
    Console.WriteLine(); //pula a linha
}

for(int i=0; i < 5; i++) //Para apresentarmos a soma e média de cada linha e coluna da matriz
{
    Console.WriteLine($"\nLinha {i + 1}:\nSoma = {somaLinha[i]}\tMedia = {mediaLinha[i]}");
    Console.WriteLine($"Coluna {i + 1}:\nSoma = {somaColuna[i]}\tMedia = {mediaColuna[i]}");
}

Console.WriteLine($"\nA soma total da matriz é {somaMatriz}\nA média total da matriz é {mediaMatriz}");

-------------Ex4-------------:

int[,] matriz = new int[5, 5];
bool aux = false;

for (int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        Console.WriteLine($"Informe o número da posição {i+1}, {j+1}: ");
        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
        if(i == j && matriz[i, j] == 1)
        {
            aux = true;
        }
        else if(i != j && matriz[i, j] == 0)
        {
            aux = true;
        }
        else
        {
            aux = false;
        }
    }
}

if(aux == true)
{
    Console.WriteLine("A matriz inserida é uma matriz identidade!");
    for(int i = 0; i < 5; i++)
    {
        for(int j = 0; j < 5; j++)
        {
            Console.Write($"{matriz[i, j]}\t");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("A matriz inserida não é uma matriz identidade!");
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write($"{matriz[i, j]}\t");
        }
        Console.WriteLine();
    }
}

-------------Ex5-------------:

int n , m;

Console.WriteLine("Informe o número de linhas da matriz: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o número de colunas da matriz: ");
m = Convert.ToInt32(Console.ReadLine());

int[,] matriz = new int[n, m];

for(int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
        Console.WriteLine($"Informe o número da posição {i+1}, {j+1}: ");
        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("------Matriz Original------");
for(int i = 0;i < n; i++)
{
    for(int j = 0;j < m; j++)
    {
        Console.Write($"{matriz[i, j]}\t");
    }
    Console.WriteLine();
}

int[,] matrizTransposta = new int[m, n];

Console.WriteLine("------Matriz Transposta------");
for (int i = 0;i < m; i++)
{
    for( int j = 0; j < n; j++)
    {
        matrizTransposta[i, j] = matriz[j, i];
        Console.Write($"{matrizTransposta[i, j]}\t");
    }
    Console.WriteLine();
}

*/