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
using System.Diagnostics;

namespace Calculator_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int operationType = 0;
        // Type of operation selected (1 = Addition / 2 = Subtraction / 3 = Multiplication / 4 = Division)
        int operationValue = 0;
        // Value of current operation (0 = Pick first number / 1 = Pick operation type / 2 = Pick second number / 3 = Show result)
        string num1 = "";
        string num2 = "";
        int intNum1 = 0;
        int intNum2 = 0;
        int result = 0;
        // These buttons below set num1 or num2 to the 
        private void Num1Btn_Click(object sender, RoutedEventArgs e) // The sender variable/paramter holds the information on the object that caused the function to run
        {
            Button NumButton = (Button)sender; // This is converting the object to a button
            if (num1.Length < 9 && (operationValue == 0 || operationValue == 1))
            {
                num1 = num1 + NumButton.Content.ToString();
                operationValue = 1;
                calculatorDisplay.Text = num1;
            }
            else if (num2.Length < 9 && (operationValue == 2 || operationValue == 3))
            {
                num2 = num2 + NumButton.Content.ToString();
                operationValue = 3;
                calculatorDisplay.Text = num2;
            }
        }
        private void AdditionBtn_Click(object sender, RoutedEventArgs e)
        {
            Button mathBtn = (Button)sender;
            if ((mathBtn.Content.ToString() == "+") & (operationValue == 1 || operationValue == 2))
            {
                operationType = 1;
                operationValue = 2;
                intNum1 = Int32.Parse(num1);
                calculatorDisplay.Text = "+";
            }
            else if ((mathBtn.Content.ToString() == "-") & (operationValue == 1 || operationValue == 2))
            {
                operationType = 2;
                operationValue = 2;
                intNum1 = Int32.Parse(num1);
                calculatorDisplay.Text = "-";
            }
            else if ((mathBtn.Content.ToString() == "X") & (operationValue == 1 || operationValue == 2))
            {
                operationType = 3;
                operationValue = 2;
                intNum1 = Int32.Parse(num1);
                calculatorDisplay.Text = "X";
            }
            else if ((mathBtn.Content.ToString() == "/") & (operationValue == 1 || operationValue == 2))
            {
                operationType = 4;
                operationValue = 2;
                intNum1 = Int32.Parse(num1);
                calculatorDisplay.Text = "/";
            }
        }
        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operationValue == 3)
            {

                intNum2 = Int32.Parse(num2);
                if (operationType == 1)
                {
                    result = intNum1 + intNum2;
                }
                else if (operationType == 2)
                {
                    result = intNum1 - intNum2;
                }
                else if (operationType == 3)
                {
                    result = intNum1 * intNum2;
                }
                else if (operationType == 4)
                {
                    result = intNum1 / intNum2;
                }
                calculatorDisplay.Text = result.ToString();
                operationValue = 4;
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            operationValue = 0;
            calculatorDisplay.Text = "";
            num1 = "";
            num2 = "";
        }
    }
}
