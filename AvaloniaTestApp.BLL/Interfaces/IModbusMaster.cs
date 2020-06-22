using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaTestApp.BLL.Interfaces
{
   public interface IModbusMaster
    {
        (bool IsError, string Message,Dictionary<short,short> cellsValues) GetValuesWithResult(List<short> cellsAddreses);
    }
}
