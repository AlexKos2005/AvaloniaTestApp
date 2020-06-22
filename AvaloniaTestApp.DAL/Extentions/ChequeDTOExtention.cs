using System;
using System.Collections.Generic;
using System.Text;
using AvaloniaTestApp.Core.Entities;
using AvaloniaTestApp.DAL.DTO;

namespace AvaloniaTestApp.DAL.Extentions
{
    public static class ChequeDTOExtention
    {
        public static Cheque ToModel (ChequeDTO chequeDTO)
        {
            return new Cheque()
            {
                Guid = chequeDTO.Guid,
                Date = chequeDTO.Date,
                Money = chequeDTO.Money,
                CheckFlag=chequeDTO.CheckFlag,

            };
        }

        public static ChequeDTO FromModel(Cheque cheque)
        {
            return new ChequeDTO()
            {
                Guid = cheque.Guid,
                Date = cheque.Date,
                Money = cheque.Money,
                CheckFlag = cheque.CheckFlag,


            };
        }
    }



}
