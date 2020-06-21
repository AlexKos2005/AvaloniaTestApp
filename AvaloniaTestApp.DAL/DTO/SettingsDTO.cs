using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaTestApp.DAL.DTO
{
    [Serializable]
    public class SettingsDTO
    {
        public ushort DeletingPeriod { get; set; }
        public string WebApiConnection { get; set; }
        public string AdminContacts { get; set; }
    }
}
