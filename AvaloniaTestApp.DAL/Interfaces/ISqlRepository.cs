﻿using System;
using System.Collections.Generic;
using System.Text;
using AvaloniaTestApp.DAL.DTO;

namespace AvaloniaTestApp.DAL.Interfaces
{
    interface ISqlRepository
    {
        (bool IsError, string Message,List<ChequeDTO> Values) GetValuesByDateWithResult(DateTime date);
        (bool IsError, string Message) DeleteValuesByDatesWithResult(short daysCount);
        (bool IsError, string Message) SetValueWithResult(ChequeDTO cheque);
        (bool IsError, string Message, ChequeDTO Value) GetValueByGuidWithResult(Guid guid);
        (bool IsError, string Message, ChequeDTO Value) DeleteValueByGuidWithResult(Guid guid);
    }
}
