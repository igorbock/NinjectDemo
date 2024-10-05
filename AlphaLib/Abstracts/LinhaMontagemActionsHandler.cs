﻿using System.Collections.Generic;
using System.Windows.Input;
using AlphaLib.Models;
using AlphaLib.Classes;

namespace AlphaLib.Abstracts
{
    public abstract class LinhaMontagemViewModel : GenericViewModel<Carro>
    {
        private Carro _currentCar;
        public Carro CurrentCar
        {
            get => _currentCar;
            set
            {
                _currentCar = value;
                OnPropertyChanged(nameof(CurrentCar));
            }
        }

        private int _deliveredCars;
        public int DeliveredCars
        {
            get => _deliveredCars;
            set
            {
                _deliveredCars = value;
                OnPropertyChanged(nameof(DeliveredCars));
            }
        }

        private List<Carro> _deliveredCarsList;
        public List<Carro> DeliveredCarsList
        {
            get => _deliveredCarsList;
            set
            {
                _deliveredCarsList = value;
                OnPropertyChanged(nameof(DeliveredCarsList));
            }
        }

        public LinhaMontagemViewModel(GenericRepository<Carro> carroRepository) : base(carroRepository)
        {
            ReadMode();
        }

        public abstract void CreateCar(Carro car);
        public abstract void ChangeColor(string color);
        public abstract void ChangeBrand(string brand);
        public abstract void ChangeModel(string model);
        public abstract void ChangeYear(int year);
        public abstract void YieldCar(Carro car);

        public ICommand CreateCarCommand => new RelayCommand(car => CreateCar((Carro)car));
        public ICommand ChangeColorCommand => new RelayCommand(color => ChangeColor(color.ToString()));
        public ICommand ChangeBrandCommand => new RelayCommand(brand => ChangeBrand(brand.ToString()));
        public ICommand ChangeModelCommand => new RelayCommand(model => ChangeModel(model.ToString()));
        public ICommand YieldCarCommand => new RelayCommand(car => YieldCar((Carro)car));
    }
}