using System.Globalization;
using System.Windows;
using System.Windows.Controls;

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

            if (string.IsNullOrEmpty(txtNumDiners.Text))
                txtNumDiners.Text = Properties.Resources.MIN_DINERS_STR;

            if (!int.TryParse(txtNumDiners.Text, out int numDiners))
                numDiners = Properties.Settings.Default.MIN_DINERS;

            if(double.TryParse(txtTipPercent.Text, out double tipPercent))
            {
                if (tipPercent < 0)
                    tipPercent = 0;
                else if (tipPercent > 100)
                    tipPercent = 100;
                txtTipPercent.Text = tipPercent.ToString(new CultureInfo("en-US"));
                tipPercent /= 100;
            }
            else
            {
                _ = txtTipPercent.Focus();
                lblError.Text = Properties.Resources.ERR_PERCENT_OUT_OF_RANGE;
                return;
            }

            if(!double.TryParse(txtMeal.Text, out double mealTotal))
            {
                lblError.Text = Properties.Resources.ERR_NEGATIVE_COST;
                _ = txtMeal.Focus();
                return;
            }
            else
            {
                if (mealTotal < 0)
                {
                    lblError.Text = Properties.Resources.ERR_NEGATIVE_COST;
                    _ = txtMeal.Focus();
                    return;
                }

                double tipAmount = mealTotal * tipPercent;
                double totalCost = mealTotal + tipAmount;
                double dinerAmount = totalCost / numDiners;
                txtTipAmount.Text = string.Format(new CultureInfo("en-US"), "{0:C2}", tipAmount);
                txtTotalBill.Text = string.Format(new CultureInfo("en-US"), "{0:C2}", totalCost);
                txtPricePerDiner.Text = string.Format(new CultureInfo("en-US"), "{0:C2}", dinerAmount);
                lblError.Text = "";
            }
        }

        private void cmdReset_Click(object sender, RoutedEventArgs e)
        {
            txtMeal.Text = "";
            txtTipPercent.Text = Properties.Resources.DEFAULT_TIP_STR;
            txtNumDiners.Text = Properties.Resources.MIN_DINERS_STR;
            txtTipAmount.Text = "";
            txtTotalBill.Text = "";
            txtPricePerDiner.Text = "";
            lblError.Text = "";
            _ = txtMeal.Focus();
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
