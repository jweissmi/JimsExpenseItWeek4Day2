using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week4Day2ContactList
{
    /// <summary>
    /// Interaction logic for ContactListHome.xaml
    /// </summary>
    public partial class ContactListHome : Page
    {
        public ContactListHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // View Contact List Item
            ContactListPage contactListPage = new ContactListPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(contactListPage);

        }
    }
}
