using System;
using System.Collections.Generic;

namespace Exercicios_Modelagem
{
    public class VideoGame : HouseholdObjects
    {
        private double consoleMemory;
        private double memoryRemaining;
        private List<Game> gameList = new List<Game>();
        private int gameQty;

        public VideoGame(double consoleMemory)
        {
            this.consoleMemory = consoleMemory;
            memoryRemaining = consoleMemory;
            gameQty = 0;
        }

        public void updateMemory(double gameSize, bool consumeMemory)
        {
            if (consumeMemory) memoryRemaining -= gameSize;
            else memoryRemaining += gameSize;
        }

        public void installGame(string gameTitle, double gameSize)
        {
            if (gameSize > memoryRemaining) Console.WriteLine("\nMemória insuficiente!");
            else
            {
                Game game = new Game();
                game.gameTitle = gameTitle;
                game.gameSize = gameSize;
                gameList.Add(game);
                updateMemory(game.gameSize, true);
                gameQty++;
                Console.WriteLine("\nGame instalado com sucesso!");
            }
        }

        public void uninstallGame(string gameTitle)
        {
            bool gameOccurance = false;
            for(int item = gameList.Count-1; item >= 0; item--)
            {
                if (gameList[item].gameTitle == gameTitle)
                {
                    updateMemory(gameList[item].gameSize, false);
                    gameList.Remove(gameList[item]);
                    gameQty--;
                    Console.WriteLine("\nGame desinstalado com sucesso!");
                    gameOccurance = true;
                }
            }
            if( !gameOccurance ) Console.WriteLine("\nGame não encontrado!");
        }

        public void playGame(string gameTitle)
        {
            bool gameOccurance = false;
            foreach (Game game in gameList)
            {
                if (game.gameTitle == gameTitle)
                {
                    Console.WriteLine("\nCarregando...");
                    gameOccurance = true;
                }
            }
            if( !gameOccurance ) Console.WriteLine("\nGame não encontrado!");
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
}