using System;
using System.Collections.Generic;
using System.Text;
using AvaloniaTestApp.DAL.Interfaces;
using AvaloniaTestApp.DAL.DTO;
using AvaloniaTestApp.Core.Entities;
using System.IO;
using System.Text.Json;
using AvaloniaTestApp.DAL.Extentions;
using System.Threading.Tasks;

namespace AvaloniaTestApp.DAL.Services
{
    public class JSonRepository : IJsonRepository
    {
        private FileStream _fileStream = null;

        public JSonRepository()
        {
            if(!File.Exists("Settings.json"))
            {
                MakeFile();
            }
        }

        public (bool IsError, string Message, SettingsDTO settings) GetSettingsWithResult()
        {
            _fileStream = new FileStream("Settings.json", FileMode.Open);
            try
            {
                var stream = new StreamReader(_fileStream);

                var settings = SettingsDTOExtention.FromModel(JsonSerializer.Deserialize<Settings>(stream.ReadToEnd()));

                stream.Close();
                return (false, "", settings);
            }
            catch (Exception ex)
            {
                return (true, ex.Source, null);
            }
            finally
            {
                _fileStream?.Dispose();
            }
           
        }

        public (bool IsError, string Message) SetSettingsWithResult(SettingsDTO settingsDTO)
        {
            _fileStream = new FileStream("Settings.json", FileMode.Open);
            try
            {
                var stream = new StreamWriter(_fileStream);

                var result = JsonSerializer.Serialize<Settings>(SettingsDTOExtention.ToModel(settingsDTO),null);
                stream.WriteLine(result);
                stream.Close();
                return (false, "");
            }
            catch (Exception ex)
            {
                return (true, ex.Source);
            }
            finally
            {
                _fileStream?.Dispose();
            }
        }

        public void MakeFile()
        {
            var fileStream = new FileStream("Settings.json", FileMode.Open);
            var stream =new StreamWriter(fileStream);
            
            var json = JsonSerializer.Serialize<Settings>( 
                new Settings()
                {
                    DeletingPeriod = 30,
                    WebApiConnection = "",
                    AdminContacts = "+7900",
                }
            );

            stream.Write(json);
            stream.Close();
        }

        }

    }

