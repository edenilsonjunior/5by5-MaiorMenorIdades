// 2- Faça um programa que receba a idade de 10 pessoas e mostre a quantidade de de maiores e menores de idade 

int idade = 0, nroMaiores = 0, nroMenores = 0;

Console.WriteLine("=====Maiores e Menores de Idade=====");


for(int i = 1; i <= 10; i++)
{
    Console.Write($"Digite a idade da pessoa({i}): ");
    idade = int.Parse(Console.ReadLine());

    if(idade <= 18)
        nroMenores++;
    else
        nroMaiores++;
}


Console.WriteLine("=============================");
Console.WriteLine($"Numero de Maiores de Idade: {nroMaiores}");
Console.WriteLine($"Numero de Menores de Idade: {nroMenores}");
Console.WriteLine("=============================");


Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();
