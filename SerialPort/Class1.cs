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

                Console.WriteLine(csv.takimNo);

                Thread.Sleep(1000);
            }
        }
    }
}