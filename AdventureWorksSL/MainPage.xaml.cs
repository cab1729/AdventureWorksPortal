using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ServiceModel;
using AdventureWorksSL.ProductCatalogServiceReference;

namespace AdventureWorksSL
{
    public partial class MainPage : UserControl
    {
        private ProductCatalogServiceClient proxy;

        public MainPage()
        {
            InitializeComponent();

            proxy =
                new ProductCatalogServiceClient();

            //proxy.GetProductListCompleted += 
            //    new EventHandler<GetProductListCompletedEventArgs>(proxy_GetProductListCompleted);
            //proxy.GetProductListAsync();

            proxy.GetProductDetailCompleted += 
                new EventHandler<GetProductDetailCompletedEventArgs>(proxy_GetProductDetailCompleted);
            //proxy.GetProductDetailAsync(712);
        }

        void proxy_GetProductDetailCompleted(object sender, GetProductDetailCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                productNumberTextBox.Text = "Error finding detail";
            }
            else
            {
                productIDTextBlock.Text = e.Result.ProductID.ToString();
                productNumberTextBox.Text = e.Result.ProductNumber;
                nameTextBox.Text = e.Result.Name;
                listPriceTextBox.Text = e.Result.ListPrice.ToString();
            }
        }

        void proxy_GetProductListCompleted(object sender, GetProductListCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            int pid = int.Parse(productIDTextBlock.Text);
            proxy.GetProductDetailAsync(pid);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }
    }
}
