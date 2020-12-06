using System;

namespace Exercicios_Modelagem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Despertador propriedades
            alarmClock despertador = new alarmClock();
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

            //Calculadora propriedades
            scientificCalculator calculadora = new scientificCalculator(DateTime.Now.AddYears(-3));
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
        }
    }
}
