using System;
using System.ComponentModel.DataAnnotations;

namespace AvaloniaTestApp.DAL.DTO
{
    class ChequeDTO
    {
        [Key]
        public Guid Guid { get; set; }
        public DateTime Date { get; set; }
        public double Money { get; set; }
    }
}
