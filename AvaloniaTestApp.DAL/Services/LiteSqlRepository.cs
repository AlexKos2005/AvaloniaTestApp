using System;
using System.Collections.Generic;
using System.Text;
using AvaloniaTestApp.DAL.DTO;
using AvaloniaTestApp.DAL.Interfaces;

namespace AvaloniaTestApp.DAL.Services
{
    public class LiteSqlRepository : ISqlRepository
    {
        public (bool IsError, string Message, ChequeDTO Value) DeleteValueByGuidWithResult(Guid guid)
        {
            throw new NotImplementedException();
        }

        public (bool IsError, string Message) DeleteValuesByDatesWithResult(short daysCount)
        {
            throw new NotImplementedException();
        }

        public (bool IsError, string Message, ChequeDTO Value) GetValueByGuidWithResult(Guid guid)
        {
            throw new NotImplementedException();
        }

        public (bool IsError, string Message, List<ChequeDTO> Values) GetValuesByDateWithResult(DateTime date)
        {
            throw new NotImplementedException();
        }

        public (bool IsError, string Message) SetValueWithResult(ChequeDTO cheque)
        {
            throw new NotImplementedException();
        }
    }
}
