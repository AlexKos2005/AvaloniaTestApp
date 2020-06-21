using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaTestApp.Core.Entities
{
  public class Settings
    {
        public ushort DeletingPeriod { get; set; }
        public string WebApiConnection { get; set; }
        public string AdminContacts { get; set; }
    }
}
