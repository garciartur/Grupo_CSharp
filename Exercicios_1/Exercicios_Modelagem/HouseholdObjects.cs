using System;

namespace Exercicios_Modelagem
{
    public class HouseholdObjects
    {
        public double weight { get; set; }
        public double height { get; set; }
        public double length { get; set; }
        public double width { get; set; }
        public String color { get; set; }
        public String brand { get; set; }
        public String model { get; set; }
        public bool active { get; set; }

        public void turnOn()
        {
            this.active = true;
        }

        public void turnOff()
        {
            this.active = false;
        }

        public virtual void showDescription()
        {
            Console.WriteLine(
                "Peso: {0}g\n" +
                "Altura: {1}cm\n" +
                "Comprimento: {2}cm\n" +
                "Largura: {3}cm\n" +
                "Cor: {4}\n" +
                "Marca: {5}\n" +
                "Modelo: {6}", weight, height, length, width, color, brand, model);
        }
    }
}
