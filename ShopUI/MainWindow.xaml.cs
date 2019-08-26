using Shop.BLL.Abstract;
using Shop.BLL.Concrate;
using Shop.DAL.Concrate;
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

namespace ShopUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InsertToDG();
        }

        private void InsertToDG()
        {
            ProductRepository pr = new ProductRepository();
            IProductService productService = new ProductService(pr);

            dgBuchok.ItemsSource = productService.GetAll();
        }
    }
}
