using CalculatorApp.Services;
using System;
using Xamarin.Forms;

namespace CalculatorApp.ViewModel
{
    public class CalculateViewModel : BaseViewModel
    {
        public Command AddCommand { get; }
        //IOnlineServices onlineServices;
        public CalculateViewModel()
        {
            Title = "Calculate Page";

            AddCommand = new Command(Add);
            //onlineServices = DependencyService.Get<IOnlineServices>();
        }

        public void Add()
        {
            //string sum = await onlineServices.Add(number1, number2);
            //Output = sum;
            Output = number1 + number2;
        }

        double number1;
        public double Number1
        {
            get { return number1; }
            set
            {
                SetProperty(ref number1, value);
            }
        }

        double number2;
        public double Number2
        {
            get { return number2; }
            set
            {
                SetProperty(ref number2, value);
            }
        }

        double output;
        public double Output
        {
            get { return output; }
            set
            {
                SetProperty(ref output, value);
            }
        }
    }
}
