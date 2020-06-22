using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvaloniaTestApp.DAL.DTO;
using AvaloniaTestApp.DAL.Interfaces;
using AvaloniaTestApp.DAL.Services;
using AvaloniaTestApp.DAL.Extentions;

namespace AvaloniaTestApp.DAL.Services
{
    public class SqLiteRepository : ISqlRepository
    {
        private DbDataContext _db = null;
        public (bool IsError, string Message) DeleteValueByGuidWithResult(Guid guid)
        {
            _db = new DbDataContext();

            try
            {
                _db.Remove( _db.Cheques.FirstOrDefault(p => p.Guid == guid));
                _db.SaveChanges();
                return (false, "");
            }
            catch (Exception ex)
            {
                return (true, ex.Source);
            }
            finally
            {
                _db?.Dispose();
            }
        }

        public (bool IsError, string Message) DeleteValuesByDatesWithResult(double daysCount)
        {
            _db = new DbDataContext();
            
            try
            {
                var values = _db.Cheques.Where(p => p.Date.AddDays(daysCount) >= DateTime.Today).ToList();
                _db.RemoveRange(values);
                _db.SaveChanges();
                return (false, "");
            }
            catch (Exception ex)
            {
                return (true, ex.Source);
            }
            finally
            {
                _db?.Dispose();
            }
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

            _db = new DbDataContext();

            try
            {
                _db.Add(ChequeDTOExtention.ToModel(cheque));
                _db.SaveChanges();
                return (false, "");
            }
            catch (Exception ex)
            {
                return (true, ex.Source);
            }
            finally
            {
                _db?.Dispose();
            }
        }
    }
}
