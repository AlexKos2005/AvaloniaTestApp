using System;
using System.Collections.Generic;
using System.Text;
using AvaloniaTestApp.DAL.Services;
using AvaloniaTestApp.DAL.Interfaces;
using AvaloniaTestApp.BLL.Interfaces;
using AvaloniaTestApp.BLL.Services;
using AvaloniaTestApp.DAL.DTO;

namespace AvaloniaTestApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
         public string Greeting => "Welcome to Avalonia!";
        private IJsonRepository _jsonRepository = null;
        private ISqlRepository _sqlRepository = null;
        private IModbusMaster _modbusMaster = null;
        public MainWindowViewModel(IJsonRepository jsonRepository, ISqlRepository sqlRepository, IModbusMaster modbusMaster)
        {
            _jsonRepository = jsonRepository ?? throw new ArgumentNullException(nameof(jsonRepository));
            _sqlRepository = sqlRepository ?? throw new ArgumentNullException(nameof(sqlRepository));
            _modbusMaster = modbusMaster ?? throw new ArgumentNullException(nameof(modbusMaster));
            StartMethod();
        }

        private void StartMethod()
        {
            var chequeDTO = new ChequeDTO()
            {
                Guid = new Guid(),
                Date = DateTime.Now,
                Money = 300,
                CheckFlag = false,
            };
            _sqlRepository.SetValueWithResult(chequeDTO);
        }

    }
}
