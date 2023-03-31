using System;
using System.Collections.Generic;
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

namespace Trading_Calculators.MVVM.View
{
    /// <summary>
    /// Interaction logic for RiskView.xaml
    /// </summary>
    public partial class RiskView : UserControl
    {


        public RiskView()
        {
            InitializeComponent();
        } 

        private int _MaxRisk = 0;
        private int _WinPercentage = 0;
        private int _LossPercentage = 0;
        private int _NoOfTrades = 0;
        private double _AverageLoser = 0;
        private double _AverageWinner = 0;
        private double _InitialCapital = 0;


        private void FormulaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FormulaComboBox.SelectedIndex == 0)
            {
                WinPercentage.Visibility = Visibility.Visible;
                LossPercentage.Visibility = Visibility.Visible;
                NoOfTrades.Visibility = Visibility.Visible;
                MaxRisk.Visibility = Visibility.Collapsed;
                AverageLoser.Visibility = Visibility.Collapsed;
                AverageWinner.Visibility = Visibility.Collapsed;
                InitialCapital.Visibility = Visibility.Collapsed;
            }
            else if (FormulaComboBox.SelectedIndex == 1)
            {
                WinPercentage.Visibility = Visibility.Visible;
                LossPercentage.Visibility = Visibility.Visible;
                NoOfTrades.Visibility = Visibility.Collapsed;
                MaxRisk.Visibility = Visibility.Visible;
                AverageLoser.Visibility = Visibility.Visible;
                AverageWinner.Visibility = Visibility.Visible;
                InitialCapital.Visibility = Visibility.Visible;
            }
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(WinPercentage.Text, out _WinPercentage) &&
                int.TryParse(LossPercentage.Text, out _LossPercentage) &&
                int.TryParse(NoOfTrades.Text, out _NoOfTrades) &&
                int.TryParse(MaxRisk.Text, out _MaxRisk) &&
                double.TryParse(AverageLoser.Text, out _AverageLoser) &&
                double.TryParse(AverageWinner.Text, out _AverageWinner) &&
                double.TryParse(InitialCapital.Text, out _InitialCapital))
            {
                // Update formula code here
            }
        }



        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;
            double _edge = (_WinPercentage - _LossPercentage) / 100;

            double averageWin = _AverageWinner /_InitialCapital;
            double averageLoss = _AverageLoser / _InitialCapital;

            if (FormulaComboBox.SelectedIndex == 0)
            {
                result = Math.Pow((1 - _edge) / (1 + _edge), _NoOfTrades);
            }
            else if (FormulaComboBox.SelectedIndex == 1)
            {
                double A = Math.Pow(_WinPercentage / 100 * Math.Pow(averageWin, 2) - _LossPercentage / 100 * Math.Pow(averageLoss, 2), 0.5);
                double Z = (_WinPercentage / 100 * averageWin) - (_LossPercentage / 100 * averageLoss);
                double P = 0.5 * (1 + Z) / A;
                double power = _MaxRisk / 100 / A;

                result = Math.Pow((1 - P) / P, power);
            }
            PositionSizeLabel.Content = result.ToString("0.00");
        }



    }
}
