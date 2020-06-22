using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AvaloniaTestApp.Core.Entities
{
    public class Cheque
    {
        [Key]
        public Guid Guid { get; set; }
        public DateTime Date { get; set; }
        public double Money { get; set; }
        public bool CheckFlag { get; set; }
    }
}
