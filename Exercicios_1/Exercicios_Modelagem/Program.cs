using System;

namespace Exercicios_Modelagem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TESTE DESPERTADOR
            /*
            AlarmClock despertador = new AlarmClock();
            despertador.weight = 40.5;
            despertador.height = 5.3;
            despertador.length = 10;
            despertador.width = 1.3;
            despertador.color = "Cinza";
            despertador.brand = "Sem marca";
            despertador.model = "Portátil";
            //Definindo um alarme
            despertador.setAlarm( DateTime.Now, "Trabalho" );
            despertador.adjustRing("Sinos", 5, 5);
            despertador.acceptSnooze(15);
            despertador.showDescription();
            //Cancelando o alarme
            Console.WriteLine("-- O alarme está acionado? " + despertador.active + " --");
            despertador.cancelAlarm();
            Console.WriteLine("-- O alarme está acionado? " + despertador.active + " --");
            */

            //TESTE CALCULADORA
            /*
            ScientificCalculator calculadora = new ScientificCalculator(DateTime.Now.AddYears(-5));
            calculadora.weight = 20.3;
            calculadora.height = 15.2;
            calculadora.length = 7.6;
            calculadora.width = 1.9;
            calculadora.color = "Preto";
            calculadora.brand = "Casio";
            calculadora.model = "fx-82MS";
            calculadora.showDescription();
            Console.WriteLine("\n-- Operação com calculadora desligada: " + calculadora.toAdd(5, -2) + " --");
            calculadora.turnOn();
            Console.WriteLine("-- Operação com calculadora ligada: " + calculadora.toAdd(5, -2) + " --");
            Console.WriteLine("-- Operação usando último resultado: " + calculadora.toAdd(calculadora.getLastResult(), 2) + " --");
            Console.ReadLine();
            */

            //TESTE VIDEO GAME
            /*
            VideoGame vGame = new VideoGame(32);
            vGame.weight = 289;
            vGame.height = 23.9;
            vGame.length = 10;
            vGame.width = 5.4;
            vGame.color = "Azul";
            vGame.brand = "Nintendo";
            vGame.model = "Switch Lite";
            vGame.showDescription();
            vGame.installGame("Cuphead", 1.18);
            vGame.installGame("Pokémon Sword", 4);
            vGame.installGame("Hades", 2.72);
            vGame.uninstallGame("Pokémon Sword");
            vGame.installGame("Animal Crossing: New Horizons", 5.8);
            vGame.installGame("The Legend of Zelda: Breath of the Wild", 40);
            vGame.playGame("Pokémon Sword");
            vGame.playGame("The Legend of Zelda: Breath of the Wild");
            vGame.playGame("Cuphead");
            vGame.showDescription();
            vGame.showGameList();
            Console.ReadLine();
            */

            //TESTE FURADEIRA
            /*
            PowerDrill furadeira = new PowerDrill(600, 220);
            furadeira.weight = 10.9;
            furadeira.height = 95;
            furadeira.length = 120;
            furadeira.width = 80;
            furadeira.color = "Azul";
            furadeira.brand = "Bosch";
            furadeira.model = "GBH 5-40";
            Console.WriteLine(furadeira.drillTool);
            furadeira.changeTool("LiXa");
            furadeira.changeTool("Chave Phillips");
            furadeira.toScrew("aço");
            furadeira.toScrew("alvenaria");
            furadeira.changeTool("broca");
            furadeira.toDrill("alvenaria");
            furadeira.showDescription();
            Console.ReadLine();
            */
            


            //TESTE COFRE DIGITAL
            /*
            DigitalSafeBox cofre = new DigitalSafeBox("123456");
            cofre.weight = 1120;
            cofre.height = 25;
            cofre.length = 25;
            cofre.width = 35;
            cofre.color = "Preto";
            cofre.brand = "Safewell";
            cofre.model = "25EK";
            cofre.showDescription();

            cofre.toUnlockSafeBox("123458", "123457");
            cofre.toLockSafeBox();
            cofre.toUnlockSafeBox("123458", "123457");
            cofre.toUnlockSafeBox("123458", "123458");
            cofre.toUnlockSafeBox("123459", "123459");
            cofre.toUpdatePassword("123451");
            cofre.toUnlockSafeBox("123456", "123456");
            cofre.toUpdatePassword("123451");
            cofre.showDescription();

            cofre.toUnlockSafeBox("123455", "123455");
            cofre.toLockSafeBox();
            cofre.toUnlockSafeBox("123457", "123457");
            cofre.toUnlockSafeBox("123456", "123456");
            cofre.toUnlockSafeBox("123459", "123459");
            cofre.toUnlockSafeBox("123458", "123458");
            cofre.toUpdatePassword("123452");
            cofre.toUnlockSafeBox("123451", "123451");
            cofre.showDescription();
            Console.ReadLine();
            */
        }
    }
}