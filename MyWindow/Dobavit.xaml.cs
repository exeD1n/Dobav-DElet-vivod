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
using System.Windows.Shapes;

namespace WpfApp48.MyWindow
{
    /// <summary>
    /// Логика взаимодействия для Dobavit.xaml
    /// </summary>
    public partial class Dobavit : Window
    {
        public Dobavit()
        {
            InitializeComponent();
            this.Loaded += Dobavit_Loaded;
        }

        private void Dobavit_Loaded(object sender, RoutedEventArgs e)
        {
            BD.Context context = new BD.Context();
            dataGridContext.ItemsSource = context.Students.Include(x => x.Group).ToList();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void dobavit_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                BD.Context context = new BD.Context();
                BD.Student student = new BD.Student();
                student.StudentName = NameStudText.Text;
                student.GroupId = Convert.ToInt32(IdGroups.Text);

                context.Students.Add(student);
                context.SaveChanges();

                MessageBox.Show("Сохранение прошло успешно");
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка");
            }

            
        }
    }
}
