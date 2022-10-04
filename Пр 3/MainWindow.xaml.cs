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

namespace Практическая_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double[,] matr;
        private void Raschet_Click(object sender, RoutedEventArgs e)
        {
            Class2.Raschet(matr, out string num);
            
            if(num=="")
            {
                MessageBox.Show("Необходимых столбцов нет", "Ошибка", MessageBoxButton.OK);
            }
            else Num.Text = num;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(Row.Text, out int row) == true && Int32.TryParse(Column.Text, out int count) == true)
            {
                Class2.CreateArray(out matr, count, row);
                dataGrid.ItemsSource = Class1.ToDataTable(matr).DefaultView;
            }
            else MessageBox.Show("Введите корректные значения", "Ошибка", MessageBoxButton.OK);
        }

        private void Init_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(Row.Text, out int row) == true && Int32.TryParse(Column.Text, out int count) == true)
            {
                Class2.InitArray(out matr, count, row);
                dataGrid.ItemsSource = Class1.ToDataTable(matr).DefaultView;
            }
            else MessageBox.Show("Введите корректные значения", "Ошибка", MessageBoxButton.OK);
        }
    }
}
