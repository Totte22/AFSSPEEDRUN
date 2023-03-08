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

namespace AFS
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1(Reques.fuel b)
        {
            InitializeComponent();
            Inpt_Adrs.Text = b.address;
            Inpt92.Text = b.price1.ToString();
            Inpt95.Text = b.price2.ToString();
            Inpt98.Text = b.price3.ToString();
            InptDF.Text = b.price4.ToString();
            InptAmount92.Text = b.amount1.ToString();
            InptAmount95.Text = b.amount1.ToString();
            InptAmount98.Text = b.amount1.ToString();
            InptAmountDF.Text = b.amount1.ToString();
        }

        private void Inpt_Adrs_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
