using Microsoft.EntityFrameworkCore;
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

namespace WpfApp48
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            BD.Context context = new BD.Context();
            dataGridContext.ItemsSource = context.Students.Include(x => x.Group).ToList();
        }

        private void Dobavit_Click(object sender, RoutedEventArgs e)
        {
            MyWindow.Dobavit dobavit = new MyWindow.Dobavit();
            dobavit.Show();
            this.Close();
        }

        private void Delet_Click(object sender, RoutedEventArgs e)
        {
            MyWindow.Deleted deleted = new MyWindow.Deleted();
            deleted.Show();
            this.Close();
        }
    }
}
