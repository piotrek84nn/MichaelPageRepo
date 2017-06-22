using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DesktopCalc
{
    public partial class DesktopCalc : Form, INotifyPropertyChanged
    {
        private ICalculatorEngine calcEngine;
        private string _inserterdValue = String.Empty;
        public string InsertedValue
        {
            get
            {
                return this._inserterdValue;
            }
            set
            {
                this._inserterdValue = value;
                NotifyPropertyChanged();
            }
        }
        private double number1, number2;
        private Operation operation = Operation.NONE;
        private StateOfCalc state = StateOfCalc.FIRSTTOSET;
        public event PropertyChangedEventHandler PropertyChanged;

        public DesktopCalc()
        {
            InitializeComponent();

            calcEngine = new CalculatorEnigine();
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void num_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (state == StateOfCalc.OPERATIONSET)
            {
                state = StateOfCalc.SECTOSET;
                InsertedValue = String.Empty;
            }
            else if(state == StateOfCalc.RESULT)
            {
                InsertedValue = String.Empty;
                state = StateOfCalc.FIRSTTOSET;
            }

            if ("," == btn.Text)
            {
                if (InsertedValue.Contains(","))
                {
                    return;
                }
                else if (InsertedValue == String.Empty)
                {
                    InsertedValue = "0,";
                    return;
                }
            }

            InsertedValue += btn.Text;
        }

        private void operationBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (state)
            {
                case StateOfCalc.FIRSTTOSET:
                    if (InsertedValue != String.Empty)
                    {
                        number1 = ParsetoDouble(InsertedValue);
                        state = StateOfCalc.OPERATIONSET;
                        SetOperationOfCalc(btn.Text);
                    }
                    break;
                case StateOfCalc.OPERATIONSET:
                    SetOperationOfCalc(btn.Text);
                    break;
                case StateOfCalc.SECTOSET:
                    operation = Operation.NONE;
                    state = StateOfCalc.FIRSTTOSET;
                    break;
            }

            InsertedValue = String.Empty;
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            CalculateResult();
        }

        private void SetOperationOfCalc(string obj)
        {
            switch (obj)
            {
                case "+":
                    operation = Operation.ADD;
                    state = StateOfCalc.OPERATIONSET;
                    break;
                case "-":
                    operation = Operation.SUB;
                    state = StateOfCalc.OPERATIONSET;
                    break;
                case "*":
                    operation = Operation.MUL;
                    state = StateOfCalc.OPERATIONSET;
                    break;
                case "/":
                    operation = Operation.DIV;
                    state = StateOfCalc.OPERATIONSET;
                    break;
                case "C":
                    operation = Operation.NONE;
                    state = StateOfCalc.FIRSTTOSET;
                    break;
            }
        }

        private void CalculateResult()
        {
            if (state == StateOfCalc.SECTOSET)
            {
                number2 = ParsetoDouble(InsertedValue);
                try
                {
                    switch (operation)
                    {
                        case Operation.ADD:
                            InsertedValue = calcEngine.Addition(number1, number2).Result.ToString();
                            break;
                        case Operation.SUB:
                            InsertedValue = calcEngine.Subtraction(number1, number2).Result.ToString();
                            break;
                        case Operation.MUL:
                            InsertedValue = calcEngine.Multiplication(number1, number2).Result.ToString();
                            break;
                        case Operation.DIV:
                            if (number2.Equals(0))
                            {
                                InsertedValue = "Can't div by ZERO";
                                return;
                            }
                            InsertedValue = calcEngine.Division(number1, number2).Result.ToString();
                            break;
                    }
                    state = StateOfCalc.RESULT;
                }
                catch (Exception e)
                {
                    
                }

            }
        }

        private double ParsetoDouble(string s)
        {
            return double.Parse(s, CultureInfo.InvariantCulture);
        }

        private void SetResultLabel(string s)
        {
            Result.Text = s;
        }
    }

    public enum StateOfCalc
    {
        FIRSTTOSET,
        OPERATIONSET,
        SECTOSET,
        RESULT
    }

    public enum Operation
    {
        ADD,
        DIV,
        MUL,
        SUB,
        NONE
    }
}
