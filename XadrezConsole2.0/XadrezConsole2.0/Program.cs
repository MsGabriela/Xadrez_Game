﻿using tabuleiro;
using xadrez;
using XadrezConsole2._0;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();


            while (!partida.terminada)
            {
                try
                {
                    Console.Clear();
                    Tela.imprimirPartida(partida);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoDeOrigem(origem);

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoDestino(origem, destino);

                    partida.realizaJogada(origem, destino);
                }
                catch (TabuleiroException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
                
            }
            Console.Clear();
            Tela.imprimirPartida(partida);

            
        }
        catch (TabuleiroException e)
        {

            Console.WriteLine(e.Message); ;
        }

     
        

        Console.ReadLine();
    }
}