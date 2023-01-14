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

namespace BMICalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //ИМТ = вес(в кг) / рост2(в метрах)
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double height = Convert.ToDouble(HeightInputBox.Text);
            double weight = Convert.ToDouble(WeightInputBox.Text);
            double bmi = weight / Math.Pow(height, 2);
            BMIOutput.Content = bmi;
            
            if (bmi < 18.5)
                StatusOutput.Content = "недостатку веса";
            if (bmi > 18.5 && bmi < 24.99)
                StatusOutput.Content = "нормальной массе тела";
            if (bmi > 24.99 && bmi < 29.99)
                StatusOutput.Content = "избыточному весу";
            if (bmi > 29.99)
                StatusOutput.Content = "жирдяйству";
        }

    }
}
