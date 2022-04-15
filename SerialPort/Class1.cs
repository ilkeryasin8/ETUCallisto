using System;
using System.Threading;
using Csv;

namespace SerialPort
{
    class SerialPort
    {
        static System.IO.Ports.SerialPort _serialPort;

        public static void Main()
        {
            _serialPort = new System.IO.Ports.SerialPort();
            _serialPort.PortName = "COM3";//Set your board COM
            _serialPort.BaudRate = 9600;
            _serialPort.Open();
            while (true)
            {
                string line = _serialPort.ReadExisting();
                //Console.WriteLine(line);
                CsvIO csv = new CsvIO(line);
                Console.WriteLine(csv.TakimNo);
                Console.WriteLine(csv.PaketNumarasi);
                Console.WriteLine(csv.GondermeSaati);
                Console.WriteLine(csv.Basinc1);
                Console.WriteLine(csv.Basinc2);
                Console.WriteLine(csv.Yukseklik1);
                Console.WriteLine(csv.Yukseklik2);
                Console.WriteLine(csv.IrtifaFarki);
                Console.WriteLine(csv.InisHizi);
                Console.WriteLine(csv.Sicaklik);
                Console.WriteLine(csv.PilGerilimi);
                Console.WriteLine(csv.Gps1Latitude);
                Console.WriteLine(csv.Gps1Longitude);
                Console.WriteLine(csv.Gps1Altitude);
                Console.WriteLine(csv.Gps2Latitude);
                Console.WriteLine(csv.Gps2Longitude);
                Console.WriteLine(csv.Gps2Altitude);
                Console.WriteLine(csv.UyduStatus);
                Console.WriteLine(csv.Pitch);
                Console.WriteLine(csv.Roll);
                Console.WriteLine(csv.Yaw);
                

                Thread.Sleep(1000);
            }
        }
    }
}