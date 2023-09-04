using System.Collections.Generic;

namespace AppIOT
{
    internal class DeviceIoT
    {
        public string Model { get; internal set; }
        public List<Sensor> Sensors { get; internal set; }
    }
}