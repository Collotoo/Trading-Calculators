using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Trading_Calculators.MVVM.View
{
    public partial class PositionSizeView : UserControl
    {
        private Dictionary<string, double> _pipValues;

        public PositionSizeView()
        {
            InitializeComponent();

            // Initialize symbols ComboBox
            var symbols = new List<string> { "EUR/USD", "GBP/USD", "USD/JPY", "USD/CHF", "AUD/USD", "NZD/USD", "USD/CAD" };
            SymbolComboBox.ItemsSource = symbols;
            SymbolComboBox.SelectedIndex = 0;

            // Initialize pip values dictionary
            _pipValues = new Dictionary<string, double>
            {
                { "EUR/USD", 0.0001 },
                { "GBP/USD", 0.0001 },
                { "USD/JPY", 0.01 },
                { "USD/CHF", 0.0001 },
                { "AUD/USD", 0.0001 },
                { "NZD/USD", 0.0001 },
                { "USD/CAD", 0.0001 }
            };
        }

        private double GetPipValue(string symbol)
        {
            return _pipValues[symbol];
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double capital = double.Parse(CapitalTextBox.Text);
                double riskPercent = double.Parse(RiskTextBox.Text) / 100;
                string symbol = SymbolComboBox.SelectedItem.ToString();
                double stopLossPips = double.Parse(StopLossTextBox.Text);

                // Get pip value for symbol
                double pipValue = GetPipValue(symbol);

                // Calculate position size
                double positionSize = (capital * riskPercent) / (stopLossPips * pipValue);

                PositionSizeLabel.Content = positionSize.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
