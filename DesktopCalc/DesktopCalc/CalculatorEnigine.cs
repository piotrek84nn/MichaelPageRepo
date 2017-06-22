using System.Threading.Tasks;

namespace DesktopCalc
{
    public class CalculatorEnigine : ICalculatorEngine
    {
        public CalculatorEnigine()
        {
        }

        public async Task<double> Addition(double a, double b)
        {
            return await Task.FromResult(a + b);
        }

        public async Task<double> Subtraction(double a, double b)
        {
            return await Task.FromResult(a - b);
        }

        public async Task<double> Multiplication(double a, double b)
        {
            return await Task.FromResult(a * b);
        }

        public async Task<double> Division(double a, double b)
        {
            return await Task.FromResult(a / b);
        }
    }
}
