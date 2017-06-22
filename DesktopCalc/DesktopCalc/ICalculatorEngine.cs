using System.Threading.Tasks;

namespace DesktopCalc
{
    public interface ICalculatorEngine
    {
        Task<double> Addition(double a, double b);
        Task<double> Subtraction(double a, double b);
        Task<double> Multiplication(double a, double b);
        Task<double> Division(double a, double b);
    }
}
