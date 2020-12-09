using Exercicios_Modelagem1;
using System;

public class videoGame : HouseholdObjects
{
    private double consoleMemory;
    private double memoryRemaining;
    private List<Game> gameList = new List<Game>;
    private int gameQty;

    public videoGame( double consoleMemory )
    {
        this.consoleMemory = consoleMemory;
        memoryRemaining = consoleMemory
        gameQty = 0;
    }

    public void updateMemory( double gameSize, bool consumeMemory )
    {
        if (consumeMemory) memoryRemaining -= gameSize;
        else memoryRemaining += gameSize;
    }

    public void installGame( string gameTitle, double gameSize )
    {
        if (gameSize > memoryRemaining) Console.WriteLine("\nMemória insuficiente!");
        else;
        {
            Game game = new Game();
            game.gameTitle = gameTitle;
            game.gameSize = gameSize;
            gameList.add(game);
            memoryUpdate(game.gamesize, true);
            gameQty++;
            Console.WriteLine("\nGame instalado com sucesso!");
        }
    }

    public void uninstallGame(string gameTitle)
    {
        foreach( Game game in gameList )
        {
            if (game.gameTitle == gameTitle)
            {
                memoryUpdate(game.gameSize, false);
                gameList.Remove(game);
                gameQty--;
                Console.WriteLine("\nGame desinstalado com sucesso!");
            }
            else Console.WriteLine("\nGame não encontrado!");
        }
    }

    public void playGame(string gameTitle)
    {
        foreach (Game game in gameList)
        {
            if (game.gameTitle == gameTitle) Console.WriteLine("\nCarregando...");
            else Console.WriteLine("\nGame não encontrado!");
        }
    }

    public void showGameList()
    {
        Console.WriteLine("\n-- Lista de games instalados --");
        foreach (Game game in gameList)
        {
            Console.WriteLine("Título: {0}\tTamanho: {1}GB", game.gameTitle, game.gameSize);
        }
    }

    public override void showDescription()
    {
        Console.WriteLine("\nTipo: Video Game");
        base.showDescription();
        Console.WriteLine("Memória total do console: {0}GB\nMemória restante: {1}GB\nQuantidade de jogos instalados: {2} jogos", consoleMemory, memoryRemaining, gameQty);
    }
}

