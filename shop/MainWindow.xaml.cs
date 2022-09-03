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
using shop.Windows;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace shop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
          
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
           
        }



        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Hide(); 
             Guest guest = new ();
            guest.Show();
        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine(  );
        }
    }
}
