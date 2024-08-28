/*//criar um programa que gere um vetor de 1000 valores aleatorios e os ordene por Bubble Sort

using System.Security.Cryptography;

int tamanho = 10, i;
int[] vetor = new int[tamanho];

Random r = new Random();

//Adicionar os valores aleatorios ao vetor

for (i = 0; i < vetor.Length; i++)
{
    vetor[i] = r.Next(1000);
}

Console.Write("Vetor não ordenado: ");

//Imprimir os valores do vetor

for (i = 0; i < vetor.Length; i++)
{
    Console.Write("["+vetor[i]+"]");
    if (i+1 == vetor.Length)
    {
        Console.Write(".");
    }
    else
    {
        Console.Write(", ");
    }
}

//Bubble Sort
bool troca = false;
do
{
    troca = false;
    for (i = 0; i < vetor.Length - 1; i++)
    {
        if (vetor[i] > vetor[i + 1])
        {
            int aux = vetor[i];
            vetor[i] = vetor[i+1];
            vetor[i+1] = aux;
            troca = true;
        }
    }
} while (troca);
//Array.Sort(vetor);

//Imprimir os valores do vetor ja ordenados
Console.WriteLine();
Console.Write("Console Ordenado: ");

for (i = 0; i < vetor.Length; i++)
{
    Console.Write("["+vetor[i]+"]");
    if(i+1 == vetor.Length)
    {
        Console.Write(".");
    }
    else
    {
        Console.Write(", ");
    }
}
*/

/*Exercicio 1, calculo de area de um triangulo

float a = 10, l=20;

Console.WriteLine(a*l);
*/

/*Exercicio 2, conversão de valores, Euro: 6,14, Dollar: 5:17 e Peso: 0,05

double real = 6.14;

Console.WriteLine("Euro: "+real/6.14+"\nDollar: "+real/5.17+"\nPeso: "+real/0.05);
*/
 
/*Exercicio 3, maior ou menor valor

Console.Write("Informe o primeio valor: ");
int n1 = Int32.Parse(Console.ReadLine());

Console.Write("Informe o segundo valor: ");
int n2 = Int32.Parse(Console.ReadLine());
if (n1 > n2)
{
    Console.WriteLine("Primeiro numero é maior");
}
else
{
    Console.WriteLine("Segundo numero é maior");
}
*/

/*receber uma idade e imprimir mensagem de acordo com a idade

Console.WriteLine("Informe a sua idade: ");
int idade = Int32.Parse(Console.ReadLine());

if (idade <= 13)
{
    Console.WriteLine("Criança");
}else if (idade > 13 && idade < 18)
{
    Console.WriteLine("Adolescente!");
}
else if(idade <= 60)
{
    Console.WriteLine("Adulto");
}
else
{
    Console.WriteLine("Idoso");
}
*/

/*Exercicio 5, fib

Console.Write("Informe o numero: ");
int num = int.Parse(Console.ReadLine());

int fib=0, fib1=1;

for (int i = 0; fib != num; i++)
{
    int temp = fib1;
    fib1 = fib + fib1;
    fib = temp;
    
    Console.Write(fib);
}
*/
using System.Security.Cryptography;
public class Exer06a
{
    public static void Main()
    {

        int tamanho = 10, i;
        int[] vetor = new int[tamanho];

        Random r = new Random();

//Adicionar os valores aleatorios ao vetor

        for (i = 0; i < vetor.Length; i++)
        {
            vetor[i] = r.Next(1000);
        }

        Console.Write("Vetor não ordenado: ");

//Imprimir os valores do vetor

        for (i = 0; i < vetor.Length; i++)
        {
            Console.Write("["+vetor[i]+"]");
            if (i+1 == vetor.Length)
            {
                Console.Write(".");
            }
            else
            {
                Console.Write(", ");
            }
        }

        Array.Sort(vetor);

//Imprimir os valores do vetor ja ordenados
        Console.WriteLine();
        Console.Write("Console Ordenado: ");

        for (i = 0; i < vetor.Length; i++)
        {
            Console.Write("["+vetor[i]+"]");
            if(i+1 == vetor.Length)
            {
                Console.Write(".");
            }
            else
            {
                Console.Write(", ");
            }
        }   
    }
}