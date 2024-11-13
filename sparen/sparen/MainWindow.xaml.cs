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

namespace sparen
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            float initialamount = float.Parse(initialAmountTextBox.Text);
            float amount = initialamount;
            float verhooging = float.Parse(weeklyInctreaseTextBox.Text);
            float wanted = float.Parse(finalAmountTextBox.Text);
            int time = 1;
            float totalamount = initialamount;
            float incteaseAmount = (initialamount * verhooging);

            do
            {
                amount += (incteaseAmount);
                totalamount += amount;
                time++;
            } while (totalamount < wanted);

            resultTextBox.Text = $"Sparen na {time} weken: {totalamount}\n\nExtra weekgeld op dat moment: {amount}.\n\nTotaal spaargeld: {amount + totalamount}.";
        }

        private void eraseButton_Click(object sender, RoutedEventArgs e)
        {
            initialAmountTextBox.Clear();
            finalAmountTextBox.Clear();
            resultTextBox.Clear();
            weeklyInctreaseTextBox.Clear();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}