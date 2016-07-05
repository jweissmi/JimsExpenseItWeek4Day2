﻿using System;
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
    /// Interaction logic for ContactListPage.xaml
    /// </summary>
    public partial class ContactListPage : Page
    {
        public ContactListPage()
        {
            InitializeComponent();
        }

        // Custom constructor to pass contact list data
        public ContactListPage(object data) : this()
        {
            // Bind to contact list data.
            this.DataContext = data;
        }
    }
}
