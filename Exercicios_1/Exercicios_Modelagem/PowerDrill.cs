using System;

namespace Exercicios_Modelagem
{
    class PowerDrill : HouseholdObjects
    {
        public int drillTool { get; set; }
        public string materialType { get; set; }
        private int drillSpeed { get; set; }
        private double drillWattage { get; set; }
        private double drillVoltage { get; set; }

        public PowerDrill(double drillWattage, double drillVoltage)
        {
            this.drillWattage = drillWattage;
            this.drillVoltage = drillVoltage;
        }

        public void changeTool(string drillTool)
        {
            string tool = drillTool.ToLower();
            switch (tool)
            {
                case "chave phillips":
                case "chave de fenda":
                case "chave allen":
                    this.drillTool = 0;
                    Console.WriteLine("{0} ajustada!", drillTool);
                    break;
                case "broca":
                    this.drillTool = 1;
                    Console.WriteLine("{0} ajustada!", drillTool);
                    break;
                case "lixa":
                    this.drillTool = 2;
                    Console.WriteLine("{0} ajustada!", drillTool);
                    break;
                default:
                    Console.WriteLine("Acessório incompatível!");
                    break;
            }
        }

        private double setMaterialType(string materialType)
        {
            string material = materialType.ToLower();
            switch (material)
            {
                case "madeira":
                    drillSpeed = 1;
                    return 300;
                case "alvenaria":
                    drillSpeed = 2;
                    return 500;
                case "aço":
                    drillSpeed = 3;
                    return 700;
                default:
                    return 0;
            }
        }

        public void toScrew(string materialType)
        {
            if (drillTool == 0)
            {
                double wattage = setMaterialType(materialType);
                if (wattage > 0 && wattage <= drillWattage) Console.WriteLine("Parafusando...");
                else Console.WriteLine("Potência insuficiente para parafusar {0}!", materialType);
            }
            else Console.WriteLine("Substitua o acessório para parafusar!");
        }

        public void toDrill(string materialType)
        {
            if (drillTool == 1)
            {
                double wattage = setMaterialType(materialType);
                if (wattage > 0 && wattage <= drillWattage) Console.WriteLine("Perfurando...");
                else Console.WriteLine("Potência insuficiente para perfurar {0}!", materialType);
            }
            else Console.WriteLine("Substitua o acessório para perfurar!");
        }

        public void toSand(string materialType)
        {
            if (drillTool == 2)
            {
                double wattage = setMaterialType(materialType);
                if (wattage > 0 && wattage <= drillWattage) Console.WriteLine("Lixando...");
                else Console.WriteLine("Potência insuficiente para lixar {0}!", materialType);
            }
            else Console.WriteLine("Substitua o acessório para lixar!");
        }

        public override void showDescription()
        {
            Console.WriteLine("\nTipo: Furadeira");
            base.showDescription();
            Console.WriteLine("Potência: {0} W\nVoltagem: {1} V", drillWattage, drillVoltage);
        }
    }
}