using System;
using System.Collections.Generic;
using System.Text;
using AvaloniaTestApp.BLL.Interfaces;
using Modbus.Device;
using System.IO.Ports;


namespace AvaloniaTestApp.BLL.Services
{
    public class ModbusRTUMaster : AvaloniaTestApp.BLL.Interfaces.IModbusMaster
    {
        public (bool IsError, string Message, Dictionary<short, short> cellsValues) GetValuesWithResult(List<short> cellsAddreses)
        {
            SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
            serialPort.PortName = "COM1";
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.Open();
            ModbusSerialMaster master = ModbusSerialMaster.CreateRtu((Modbus.IO.IStreamResource)serialPort);

            byte slaveID = 1;
            ushort startAddress = 0;
            ushort numOfPoints = 1;
            ushort[] holding_register = master.ReadHoldingRegisters(slaveID, startAddress,
            numOfPoints);
            Console.WriteLine(holding_register);

            return (false, "", null);
 
        }
    }
}
