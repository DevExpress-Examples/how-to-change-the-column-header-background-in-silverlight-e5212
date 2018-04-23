using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace ColumnsSeparator
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
            for (int i = 1; i < 30; i++)
            {
                customers.Add(new Customer() { ID = i, Name = "Name" + i });
            }
            grid.ItemsSource = customers;
        }
    }

    public class Customer
    {
        public int ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
