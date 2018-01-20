using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestEntityBaseFirst
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Northwind_B2Entities db { get; set; }

        public MainWindow()
        {
            db = new Northwind_B2Entities();
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            cb_Categories.ItemsSource = db.Categories
                        .Select(c => new
                        {
                            c.CategoryID,
                            c.CategoryName
                        }).ToList();
            cb_Categories.DisplayMemberPath = "CategoryName";
            cb_Categories.SelectedValuePath = "CategoryID";

        }

        private void cb_Categories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cb_Categories.SelectedValue.ToString()))
            {
                var id = (int)cb_Categories.SelectedValue;
                dg_produits.ItemsSource = db.Products
                    .Where(p => p.CategoryID == id)
                    .Select(p => new
                    {
                        p.ProductID
                        ,
                        p.ProductName
                        ,
                        p.UnitPrice
                    }).ToList()
                    .Select(p => new
                    {
                        p.ProductID
                        ,
                        p.ProductName
                        ,
                        UnitPrice = string.Format("{0:C", p.UnitPrice)
                    });
            }
            else
            {
                dg_produits.ItemsSource = null;
            }
        }
    }
}
