using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svetofor
{
    public class TrafficLightController
    {
        public TrafficLight GetNextLight(TrafficLight current)
        {
            switch (current)
            {
                case TrafficLight.Red:
                    return TrafficLight.Green;
                case TrafficLight.Green:
                    return TrafficLight.Yellow;
                case TrafficLight.Yellow:
                    return TrafficLight.Red;
                default:
                    return TrafficLight.Red;
            }
        }

        public string GetAction(TrafficLight light)
        {
            switch (light)
            {
                case TrafficLight.Red:
                    return "Стой!";
                case TrafficLight.Yellow:
                    return "Внимание! Приготовься.";
                case TrafficLight.Green:
                    return "Иди!";
                default:
                    return "Неизвестный сигнал";
            }
        }
    }

}
