using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AddressBoook.Model
{
    public class Contact : INotifyPropertyChanged
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _sername;

        /// <summary>
        /// Отчество контакта.
        /// </summary>
        private string _patronymic;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private PhoneNumber _phone;
        /// <summary>
        /// ID контакта.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя.
        /// </summary>
        public string Name
        {
            get => _name;

            set
            {
                if (!isValidated(value))
                {
                    throw new ArgumentException("Имя должно содержать от 2 до 50 символов.");
                }
                _name = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию.
        /// </summary>
        public string Surname
        {
            get => _sername;

            set
            {
                if (!isValidated(value))
                {
                    throw new ArgumentException("Фамилия должно содержать от 2 до 50 символов.");
                }
                _sername = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задаёт отчество.
        /// </summary>
        public string Patronymic
        {
            get => _patronymic;

            set
            {
                _patronymic = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона
        /// </summary>
        public PhoneNumber Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Проверяет строку на соответствие формату.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>true - строка подходит по требованиям, false - строка не прошла проверку.</returns>
        private bool isValidated(string str)
        {
            return str?.Length >= 2 && str?.Length <= 50;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
