using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

string jogo = "s";
while (jogo == "s")
{
string nome1 = "", nome2 = "";
Console.WriteLine("---------------------------------------------");
Console.WriteLine("Vamos jogar dados?\nInforme abaixo o nome dos dois jogadores: ");
Console.WriteLine("---------------------------------------------");
while (nome1 == nome2)
{
    Console.Write("Informe o nome do primeiro jogador: ");
    nome1 = Console.ReadLine();
    nome1 = nome1.ToLower();
    Console.Write("Informe agora o nome do segundo jogador: ");
    nome2 = Console.ReadLine();
    nome2 = nome2.ToLower();    
    if (nome1 == nome2)
    {
        Console.WriteLine("Informe o nome de jogadores distintos!");
    }
}

int rodadasTotaisN = 0;

while (rodadasTotaisN == 0)
{
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("Quantas rodadas iremos jogar para determinar o vencedor?");
    string rodadasTotais = Console.ReadLine();
    rodadasTotaisN = Convert.ToInt32(rodadasTotais);
    Console.WriteLine("---------------------------------------------");
        if (rodadasTotaisN == 0)
        {
            Console.WriteLine("Com 0 rodadas não temos jogo!");
        }
        else
    {

TextInfo nome01 = new CultureInfo("pt-BR").TextInfo;
TextInfo nome02 = new CultureInfo("pt-BR").TextInfo;

nome1 = nome01.ToTitleCase(nome1);
nome2 = nome02.ToTitleCase(nome2);
Console.WriteLine($"Ok, vamos começar o jogo entre {nome1} e {nome2} com {rodadasTotaisN} rodadas:");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("Vamos rolar os dados para a primeira rodada: ");
Console.Write("Pressione enter para continuar... ");
Console.ReadLine();
Console.WriteLine("---------------------------------------------");

int pontos1 = 0, pontos2 = 0;
    for (var contador = 0; contador<rodadasTotaisN;contador++)
    {
    Random numero =  new Random();
    int item1 = numero.Next(1,6);
    int item2 = numero.Next(1,6);
    pontos1 = pontos1 + item1;
    pontos2 = pontos2 + item2; 
        Console.WriteLine($"O número sorteado para {nome1} foi {item1}");
        Console.WriteLine($"O número sorteado para {nome2} foi {item2}");
    int contador2 = contador +1;
        Console.WriteLine("---------");
        if (item1 > item2)
        {
            Console.WriteLine($"O vencedor da rodada {contador2} foi {nome1}");
        }
        else if (item1 < item2) 
        {
            Console.WriteLine($"O vencedor da rodada {contador2} foi {nome2}");
        }
        else if (item1 == item2)
        {
            Console.WriteLine($"A rodada {contador2} terminou empate!");
        }
        Console.WriteLine($"{nome1} agora tem {pontos1}\n{nome2} agora tem {pontos2}");
            Console.WriteLine("---------------------------------------------");
        

    }

    if (pontos1 > pontos2)
    {
        Console.WriteLine($"Somando os resultados de todas a rodadas o vencedor geral foi {nome1} com {pontos1} pontos!");
    }
    else if (pontos1 < pontos2)
    {
        Console.WriteLine($"Somando os resultados de todas a rodadas o vencedor geral foi {nome2} com {pontos2} pontos!");
    }
    else
    {
        Console.WriteLine($"A Partida terminou empate com um total de {pontos2} pontos para ambos os jogadores");
    }
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("---------------------------------------------");
    }
}
Console.WriteLine("Deseja jogar novamente? [S/N]");
jogo = Console.ReadLine();
jogo = jogo.ToLower();
}