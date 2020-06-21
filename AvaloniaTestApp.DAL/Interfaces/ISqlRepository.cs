using System;
using System.Collections.Generic;
using System.Text;
using AvaloniaTestApp.DAL.DTO;

namespace AvaloniaTestApp.DAL.Interfaces
{
   public interface ISqlRepository
    {
        (bool IsError, string Message,List<ChequeDTO> Values) GetValuesByDateWithResult(DateTime date);
        (bool IsError, string Message) DeleteValuesByDatesWithResult(double daysCount);
        (bool IsError, string Message) SetValueWithResult(ChequeDTO cheque);
        (bool IsError, string Message, ChequeDTO Value) GetValueByGuidWithResult(Guid guid);
        (bool IsError, string Message) DeleteValueByGuidWithResult(Guid guid);
    }
}
