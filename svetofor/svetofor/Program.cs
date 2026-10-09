using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace svetofor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Светофор запущен ");
            TrafficLightController controller = new TrafficLightController();
            TrafficLight currentLight = TrafficLight.Red;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Свет: {currentLight}");
                Console.WriteLine($"Действие: {controller.GetAction(currentLight)}");
                Thread.Sleep(2000); 
                currentLight = controller.GetNextLight(currentLight);
            }
            Console.WriteLine(" Светофор завершил работу ");
        }
    }
}
