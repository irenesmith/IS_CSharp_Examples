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

namespace Tipster
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

        private void cmdCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumDiners.Text == string.Empty)
                txtNumDiners.Text = "1";
            int numDiners;
            if (!int.TryParse(txtNumDiners.Text, out numDiners))
                numDiners = 1;
            double tipPercent;
            if(double.TryParse(txtTipPercent.Text, out tipPercent))
            {
                if (tipPercent < 0)
                    tipPercent = 0;
                else if (tipPercent > 100)
                    tipPercent = 100;
                txtTipPercent.Text = tipPercent.ToString();
                tipPercent /= 100;
            }
            else
            {
                tipPercent = 0;
                txtTipPercent.Focus();
                lblError.Text = "Tip percent must be a number between 0 and 100.";
                return;
            }

            double mealTotal;
            if(!double.TryParse(txtMeal.Text, out mealTotal))
            {
                lblError.Text = "The cost of the meal must be a positive decimal number.";
                txtMeal.Focus();
                return;
            }
            else
            {
                if (mealTotal < 0)
                {
                    lblError.Text = "The cost of the meal must be a positive decimal number.";
                    txtMeal.Focus();
                    return;
                }

                double tipAmount = mealTotal * tipPercent;
                double totalCost = mealTotal + tipAmount;
                double dinerAmount = totalCost / numDiners;
                txtTipAmount.Text = string.Format("{0:C2}", tipAmount);
                txtTotalBill.Text = string.Format("{0:C2}", totalCost);
                txtPricePerDiner.Text = string.Format("{0:C2}", dinerAmount);
                lblError.Text = "";
            }
        }

        private void cmdReset_Click(object sender, RoutedEventArgs e)
        {
            txtMeal.Text = "";
            txtTipPercent.Text = "10";
            txtNumDiners.Text = "1";
            txtTipAmount.Text = "";
            txtTotalBill.Text = "";
            txtPricePerDiner.Text = "";
            lblError.Text = "";
            txtMeal.Focus();
        }

        private void OnTextBoxFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtField = (TextBox)sender;
            if (txtField.Text.Length > 0)
            {
                txtField.SelectionStart = 0;
                txtField.SelectionLength = txtField.Text.Length;
            }
        }
    }
}
