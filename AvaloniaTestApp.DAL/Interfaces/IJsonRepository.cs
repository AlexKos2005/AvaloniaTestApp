using System;
using System.Collections.Generic;
using System.Text;
using AvaloniaTestApp.DAL.DTO;

namespace AvaloniaTestApp.DAL.Interfaces
{
   public interface IJsonRepository
    {
        (bool IsError, string Message,SettingsDTO settings) GetSettingsWithResult();
        (bool IsError, string Message) SetSettingsWithResult(SettingsDTO settingsDTO);
    }
}
