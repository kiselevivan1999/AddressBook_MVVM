using AddressBoook.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AddressBook.ViewModel
{
    public class MainWindowVM : ViewModelBase
    {

        private Contact _selectedContact = new Contact();

        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
            }
        }

        public MainWindowVM()
        {
            Contacts = new ObservableCollection<Contact>(ProjectSerializer.LoadFromFile());
        }

        public ObservableCollection<Contact> Contacts { get; set; }
    }
}
