using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ContactBook_with_bindings
{
    public class ViewModel
    {
        // Колекція контактів має тип ObservableCollection,
        // який реалізує INotifyCollectionChanged і тим самим повідомляє 
        // про зміну колекції
        private readonly ICollection<Contact> contacts = new ObservableCollection<Contact>();

        public ViewModel()
        {
            // ініціалізація списку контактів парочкою тестових елементів
            contacts.Add(new Contact() { Name = "Vova", Age = 30, Surname = "Pupkin", Phone = "+3807575828", IsMale = true });
            contacts.Add(new Contact() { Name = "Marusia", Age = 25, Surname = "Shishik", Phone = "+380771244", IsMale = false });
            contacts.Add(new Contact() { Name = "Olga", Age = 33, Surname = "Shelesh", Phone = "+38067285792", IsMale = false });
        }

        // Властивість для прив'язки до списку контактів
        public IEnumerable<Contact> Contacts => contacts;

        // Властивість для прив'язки до вибраного контакта
        public Contact SelectedContact { get; set; }

        // Метод дублювання вибраного контакта
        public void DublicateSelectedContact()
        {
            if (SelectedContact != null)
            {
                //contacts.Add(new Contact()
                //{
                //    Name = SelectedContact.Name,
                //    Surname = SelectedContact.Surname,
                //    Age = SelectedContact.Age,
                //    City = SelectedContact.City
                //});
                contacts.Add((Contact)SelectedContact.Clone());
            }
        }

        // Метод видалення вибраного контакта
        public void RemoveSelectedContact()
        {
            if (SelectedContact != null)
                contacts.Remove(SelectedContact);
        }
    }
}
