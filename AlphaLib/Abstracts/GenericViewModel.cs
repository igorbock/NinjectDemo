using AlphaLib.Classes;
using AlphaLib.Interfaces;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Input;

namespace AlphaLib.Abstracts
{
    public abstract class GenericViewModel<TypeT> : INotifyPropertyChanged where TypeT : class
    {
        private readonly GenericRepository<TypeT> _repository;

        private TypeT _currentItem;
        public TypeT CurrentItem
        {
            get => _currentItem;
            set
            {
                _currentItem = value;
                OnPropertyChanged(nameof(CurrentItem));
            }
        }

        private BindingList<TypeT> _listTypeT;
        public BindingList<TypeT> ListTypeT
        {
            get => _listTypeT;
            set
            {
                _listTypeT = value;
                OnPropertyChanged(nameof(ListTypeT));
            }
        }

        private bool _buttonNewEnabled;
        public bool ButtonNewEnabled
        {
            get => _buttonNewEnabled;
            set
            {
                _buttonNewEnabled = value;
                OnPropertyChanged(nameof(ButtonNewEnabled));
            }
        }

        private bool _buttonUpdateEnabled;
        public bool ButtonUpdateEnabled
        {
            get => _buttonUpdateEnabled;
            set
            {
                _buttonUpdateEnabled = value;
                OnPropertyChanged(nameof(ButtonUpdateEnabled));
            }
        }

        private bool _buttonDeleteEnabled;
        public bool ButtonDeleteEnabled
        {
            get => _buttonDeleteEnabled;
            set
            {
                _buttonDeleteEnabled = value;
                OnPropertyChanged(nameof(ButtonDeleteEnabled));
            }
        }

        private bool _buttonCloseEnabled;
        public bool ButtonCloseEnabled
        {
            get => _buttonCloseEnabled;
            set
            {
                _buttonCloseEnabled = value;
                OnPropertyChanged(nameof(ButtonCloseEnabled));
            }
        }

        private bool _buttonSaveEnabled;
        public bool ButtonSaveEnabled
        {
            get => _buttonSaveEnabled;
            set
            {
                _buttonSaveEnabled = value;
                OnPropertyChanged(nameof(ButtonSaveEnabled));
            }
        }

        private bool _buttonCancelEnabled;
        public bool ButtonCancelEnabled
        {
            get => _buttonCancelEnabled;
            set
            {
                _buttonCancelEnabled = value;
                OnPropertyChanged(nameof(ButtonCancelEnabled));
            }
        }

        private bool _controlsEnabled;
        public bool ControlsEnabled
        {
            get => _controlsEnabled;
            set
            {
                _controlsEnabled = value;
                OnPropertyChanged(nameof(ControlsEnabled));
            }
        }

        public GenericViewModel(GenericRepository<TypeT> repository)
        {
            _repository = repository;

            CurrentItem = Activator.CreateInstance<TypeT>();
            ListTypeT = new BindingList<TypeT>();
        }

        protected virtual void Load()
        {
            try
            {
                ReadMode();
                CurrentItem = Activator.CreateInstance<TypeT>();
                ListTypeT = _repository.GetAll();
            }
            catch (Exception ex)
            {
                OnErrorOcurred(ex);
            }
        }

        protected virtual void Save()
        {
            try
            {
                var item = (IEntity)CurrentItem;
                if (item.Id == 0)
                    _repository.Create(CurrentItem);
                else
                    _repository.Update(CurrentItem);

                _repository.SaveChanges();
                ReadMode();

                ListTypeT = _repository.GetAll();
                CurrentItem = ListTypeT.Last();
            }
            catch (Exception ex)
            {
                OnErrorOcurred(ex);
            }
        }

        protected virtual void Create()
        {
            try
            {
                EditMode();
                CurrentItem = Activator.CreateInstance<TypeT>();
            }
            catch (Exception ex)
            {
                OnErrorOcurred(ex);
            }
        }

        protected virtual void Cancel()
        {
            try
            {
                ReadMode();
                var item = (IEntity)CurrentItem;
                if (item.Id == 0)
                    CurrentItem = Activator.CreateInstance<TypeT>();
            }
            catch (Exception ex)
            {
                OnErrorOcurred(ex);
            }
        }

        protected virtual void Update()
        {
            try
            {
                var item = (IEntity)CurrentItem;
                if (CurrentItem == null || item.Id == 0)
                    throw new Exception("Selecione um registro");

                CurrentItem = _repository.GetById(item.Id);
                EditMode();
            }
            catch (Exception ex)
            {
                OnErrorOcurred(ex);
            }
        }

        protected virtual void Delete()
        {
            try
            {
                var item = (IEntity)CurrentItem;
                if (item.Id == 0)
                    throw new Exception("Selecione um registro");

                _repository.Delete(item.Id);
                _repository.SaveChanges();

                ListTypeT = _repository.GetAll();
                CurrentItem = Activator.CreateInstance<TypeT>();
            }
            catch (Exception ex)
            {
                OnErrorOcurred(ex);
            }
        }

        public ICommand LoadCommand => new RelayCommand(a => Load());
        public ICommand SaveCommand => new RelayCommand(a => Save());
        public ICommand CreateCommand => new RelayCommand(a => Create());
        public ICommand CancelCommand => new RelayCommand(a => Cancel());
        public ICommand UpdateCommand => new RelayCommand(a => Update());
        public ICommand DeleteCommand => new RelayCommand(a => Delete());

        public event EventHandler<ErrorEventArgs> ErrorOcurred;
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnErrorOcurred(Exception exception)
        {
            ErrorOcurred?.Invoke(this, new ErrorEventArgs(exception));
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void EditMode()
        {
            ButtonNewEnabled = false;
            ButtonUpdateEnabled = false;
            ButtonDeleteEnabled = false;
            ButtonCloseEnabled = false;
            ButtonSaveEnabled = true;
            ButtonCancelEnabled = true;
            ControlsEnabled = true;
        }

        public virtual void ReadMode()
        {
            ButtonNewEnabled = true;
            ButtonUpdateEnabled = true;
            ButtonDeleteEnabled = true;
            ButtonCloseEnabled = true;
            ButtonSaveEnabled = false;
            ButtonCancelEnabled = false;
            ControlsEnabled = false;
        }
    }
}