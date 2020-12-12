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
            if (gameSize > memoryRemaining) Console.WriteLine("\nMemória insuficiente para instalar {0}! ({1} GB de memória restante)", gameTitle, memoryRemaining);
            else
            {
                Game game = new Game();
                game.gameTitle = gameTitle;
                game.gameSize = gameSize;
                gameList.Add(game);
                updateMemory(game.gameSize, true);
                gameQty++;
                Console.WriteLine("\n{0} instalado com sucesso! ({1} GB de memória restante)", gameTitle, memoryRemaining);
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
                    Console.WriteLine("\n{0} desinstalado com sucesso! ({1} GB de memória restante)", gameTitle, memoryRemaining);
                    gameOccurance = true;
                }
            }
            if( !gameOccurance ) Console.WriteLine("\n{0}não encontrado!", gameTitle);
        }

        public void playGame(string gameTitle)
        {
            bool gameOccurance = false;
            foreach (Game game in gameList)
            {
                if (game.gameTitle == gameTitle)
                {
                    Console.WriteLine("\nAguarde! {0} está carregando...", gameTitle);
                    gameOccurance = true;
                }
            }
            if( !gameOccurance ) Console.WriteLine("\n{0} não encontrado!", gameTitle);
        }

        public void showGameList()
        {
            Console.WriteLine("\n-- Lista de games instalados --");
            foreach (Game game in gameList)
            {
                Console.WriteLine("Título: {0}\nTamanho: {1} GB\n", game.gameTitle, game.gameSize);
            }
        }

        public override void showDescription()
        {
            Console.WriteLine("\nTipo: Video Game");
            base.showDescription();
            Console.WriteLine("Memória total do console: {0} GB\nMemória restante: {1} GB\nQuantidade de jogos instalados: {2} jogos", consoleMemory, memoryRemaining, gameQty);
        }
    }
}