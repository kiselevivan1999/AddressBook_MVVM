using AddressBoook.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AddressBook.ViewModel.Commands;
using System.Windows.Input;

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
        

        public ICommand Save { get; }

        public bool CanSaveExecute(object p) => true;

        public void Save_Executed(object p)
        {
            //ProjectSerializer.SaveToFile(contacts);
        }
        

        public MainWindowVM()
        {
            Contacts = new ObservableCollection<Contact>(ProjectSerializer.LoadFromFile());

            Save = new LambdaCommand(Save_Executed, CanSaveExecute);
        }

        public ObservableCollection<Contact> Contacts { get; set; }
    }
}
