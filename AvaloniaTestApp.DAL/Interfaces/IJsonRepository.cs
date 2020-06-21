using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaTestApp.DAL.Interfaces
{
    interface IJsonRepository
    {
        (bool IsError, string Message) GetSettingsWithResult();
        (bool IsError, string Message) SetSettingsWithResult();
    }
}
