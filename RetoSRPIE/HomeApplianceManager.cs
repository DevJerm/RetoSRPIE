using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Imagina que tienes varios electrodomésticos en casa (nevera, televisor, microondas, etc.), 
//y necesitas administrar su consumo de energía y generar un informe sobre su estado.

//Este código original hace todo en una sola clase(HomeApplianceManager), lo cual viola SRP
//y Information Expert porque una sola clase maneja electrodomésticos, calcula el consumo total y genera informes.

//RETO: REFACTORIZA EL CODIGO TENIENDO EN CUENTA EL SRP e IE
namespace RetoSRPIE
{
    public class HomeApplianceManager
    {
        public List<HomeAppliance> Appliances { get; set; } = new List<HomeAppliance>();

        public void AddAppliance(string name, int powerUsage, bool isOn)
        {
            Appliances.Add(new HomeAppliance { Name = name, PowerUsage = powerUsage, IsOn = isOn });
        }

        public int CalculateTotalPowerUsage()
        {
            return Appliances.Where(a => a.IsOn).Sum(a => a.PowerUsage);
        }

        public void PrintReport()
        {
            Console.WriteLine("---- INFORME DE ELECTRODOMÉSTICOS ----");
            foreach (var appliance in Appliances)
            {
                string status = appliance.IsOn ? "Encendido" : "Apagado";
                Console.WriteLine($"{appliance.Name} | Consumo: {appliance.PowerUsage}W | Estado: {status}");
            }
            Console.WriteLine($"Consumo total: {CalculateTotalPowerUsage()}W");
            Console.WriteLine("--------------------------------------");
        }
    }

    public class HomeAppliance
    {
        public string Name { get; set; }
        public int PowerUsage { get; set; }
        public bool IsOn { get; set; }
    }

    // Simulación de uso
    public class Program
    {
        public static void Main()
        {
            HomeApplianceManager manager = new HomeApplianceManager();
            manager.AddAppliance("Nevera", 150, true);
            manager.AddAppliance("Televisor", 100, false);
            manager.PrintReport();
        }
    }
}
