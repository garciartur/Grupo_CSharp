﻿using System;

namespace Exercicios_Modelagem
{
    public class ScientificCalculator : HouseholdObjects
    {
        private double lastResult { get; set; }
        private DateTime inicializationDate { get; set; }

        public ScientificCalculator(DateTime inicializationDate)
        {
            this.inicializationDate = inicializationDate;
        }

        private void setLastResult(double lastResult)
        {
            this.lastResult = lastResult;
        }

        public double getLastResult()
        {
            return lastResult;
        }

        public TimeSpan batteryRemaining()
        {
            //Duração da bateria de 5 anos
            TimeSpan batteryLife = new TimeSpan(1827, 0, 0, 0);
            TimeSpan batteryUsed = DateTime.Now - inicializationDate;
            return batteryLife - batteryUsed;
        }

        public double toAdd(double numberX, double numberY)
        {
            if (active)
            {
                setLastResult(numberX + numberY);
                return lastResult;
            }
            else return 0;
        }

        public double toSub(double numberX, double numberY)
        {
            if (active)
            {
                setLastResult(numberX - numberY);
                return lastResult;
            }
            else return 0;
        }

        public double toDiv(double numberX, double numberY)
        {
            if (active)
            {
                setLastResult(numberX / numberY);
                return lastResult;
            }
            else return 0;
        }

        public double toMult(double numberX, double numberY)
        {
            if (active)
            {
                setLastResult(numberX * numberY);
                return lastResult;
            }
            else return 0;
        }

        public override void showDescription()
        {
            Console.WriteLine("\nTipo: Calculadora Científica");
            base.showDescription();
            Console.WriteLine("Acionada em: {0}\nTempo restante de bateria: {1:dd} dias", inicializationDate, batteryRemaining());
        }
    }
}