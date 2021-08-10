using System.Threading.Tasks;

namespace CalculatorApp.Services
{
    public interface IOnlineServices
    {
        Task<string> Add(double number1, double number2);
    }
}