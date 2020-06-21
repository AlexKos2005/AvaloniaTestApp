using System;
using System.Collections.Generic;
using System.Text;
using AvaloniaTestApp.Core.Entities;
using AvaloniaTestApp.DAL.DTO;

namespace AvaloniaTestApp.DAL.Extentions
{
   public static class SettingsDTOExtention
    {
        public static Settings ToModel (SettingsDTO settingsDTO)
        {
           return new Settings()
            {
                DeletingPeriod=settingsDTO.DeletingPeriod,
                WebApiConnection = settingsDTO.WebApiConnection,
                AdminContacts = settingsDTO.AdminContacts,
            };
        }

        public static SettingsDTO FromModel(Settings settings)
        {
            return new SettingsDTO()
            {
                DeletingPeriod = settings.DeletingPeriod,
                WebApiConnection = settings.WebApiConnection,
                AdminContacts = settings.AdminContacts,
            };
        }
    }
}
