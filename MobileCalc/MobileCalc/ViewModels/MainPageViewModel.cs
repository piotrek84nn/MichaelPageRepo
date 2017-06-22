//
// MainPageViewModel.cs
//
// Author:
//       Piotr Niżnik <piotrek84nn@gmail.com>
//
// Copyright (c) 2017 (c) Piotr Niżnik
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
using System;
using System.Globalization;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileCalc.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        public string insertedValue = String.Empty;
        public string InsertedValue
        {
            get { return insertedValue; }
            set { SetProperty(ref insertedValue, value); }
        }

        private ICalculatorEngine calcEngine;
        private double number1, number2;
        private Operation operation = Operation.NONE;
        private StateOfCalc state = StateOfCalc.FIRSTTOSET;

        public ICommand GetResultCmd { get; }
        public ICommand NumberCmd { get; }
        public ICommand OperCmd { get; }

        public MainPageViewModel()
        {
            calcEngine = DependencyService.Get<ICalculatorEngine>();

            NumberCmd = new Command<string>(NumberPassing);
            OperCmd = new Command<string>(SetOperation);
            GetResultCmd = new Command(CalculateResult);
        }

        private void NumberPassing(string value)
        {
            if (state == StateOfCalc.OPERATIONSET)
            {
                state = StateOfCalc.SECTOSET;
                InsertedValue = String.Empty;
            }
            else if (state == StateOfCalc.RESULT)
            {
                InsertedValue = String.Empty;
                state = StateOfCalc.FIRSTTOSET;
            }

            if ("," == value)
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

            InsertedValue += value;
        }

        private void SetOperation(string obj)
        {
            switch (state)
            {
                case StateOfCalc.FIRSTTOSET:
                    if (InsertedValue != String.Empty)
                    {
                        number1 = ParsetoDouble(InsertedValue);
                        state = StateOfCalc.OPERATIONSET;
                        SetOperationOfCalc(obj);
                    }
                    break;
                case StateOfCalc.OPERATIONSET:
                    SetOperationOfCalc(obj);
                    break;
                case StateOfCalc.SECTOSET:
                    operation = Operation.NONE;
                    state = StateOfCalc.FIRSTTOSET;
                    break;
            }

            InsertedValue = String.Empty;
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
                    MessagingCenter.Send(new MessagingCenterAlert
                    {
                        Title = "Error",
                        Message = e.Message,
                        Cancel = "OK"
                    }, "message");
                }

            }
        }

        private double ParsetoDouble(string s)
        {
            return double.Parse(s, CultureInfo.InvariantCulture);
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
