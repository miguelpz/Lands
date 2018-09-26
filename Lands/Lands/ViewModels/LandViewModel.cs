﻿using Lands.Models;

namespace Lands.ViewModels
{
    using Models;
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class LandViewModel:BaseViewModel
    {
        #region Attributes
        private ObservableCollection<BorderItemViewModel> borders;
        private ObservableCollection<Currency> currencies;
        #endregion

        #region Propperties
        public Land Land
        {
            get;
            set;
        }

        public ObservableCollection<BorderItemViewModel> Borders
        {
            get { return this.borders; }
            set { SetValue(ref this.borders, value); }
        }

        public ObservableCollection<Currency> Currencies
        {
            get { return this.currencies; }
            set { SetValue(ref this.currencies, value); }
        }
        #endregion

        #region Constructors
        public LandViewModel(Land land)
        {
            this.Land = land;
            this.LoadBorders();
            this.Currencies = new ObservableCollection<Currency>(this.Land.Currencies);
        }
        #endregion

        #region Methods

        private void LoadBorders()
        {
            this.Borders = new ObservableCollection<BorderItemViewModel>();
            foreach (var border in this.Land.Borders)
            {
                var land = MainViewModel.GetInstance().LandsList.Where(l => l.Alpha3Code == border).FirstOrDefault();

                if (land != null)
                {
                    this.Borders.Add(new BorderItemViewModel()
                    {
                        Code = land.Alpha3Code,
                        Name = land.Name,

                    });
                }
            }
        }
        #endregion
    }
}
