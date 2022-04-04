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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    
    public partial class Window1 : Window
    {
        BDWPFEntities dW = new BDWPFEntities();
        public Window1()
        {
            InitializeComponent();
            dataGrid.ItemsSource = dW.FIO.ToList();
        }



        

        private void Button_Click_1(object sender, RoutedEventArgs e)
            
        {
            var FioForRemoving = dataGrid.SelectedItems.Cast<FIO>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {FioForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    dW.FIO.RemoveRange(FioForRemoving);
                    
                    MessageBox.Show("Данные успешно удалены!");

                    dataGrid.ItemsSource = dW.FIO.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
