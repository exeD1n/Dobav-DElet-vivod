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
    /// Логика взаимодействия для Deleted.xaml
    /// </summary>
    public partial class Deleted : Window
    {
        public Deleted()
        {
            InitializeComponent();
            this.Loaded += Deleted_Loaded;
        }

        private void Deleted_Loaded(object sender, RoutedEventArgs e)
        {
            BD.Context context = new BD.Context();
            dataGrid.ItemsSource = context.Students.Include(x => x.Group).ToList();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void deletbluy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BD.Context context = new BD.Context();
                BD.Student student = context.Students.Find(Convert.ToInt32(IDdelet.Text));
                context.Students.Remove(student);
                context.SaveChanges();
                MessageBox.Show($"Студент {student.StudentName} Удален, Закройте окно, Обновите список");

                //Удаление
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка");
            }

            
        }
    }
}
