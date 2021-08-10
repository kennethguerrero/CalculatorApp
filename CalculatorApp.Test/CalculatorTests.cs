using System;
using System.Collections.Generic;
using System.Text;
using CalculatorApp.ViewModel;
using Xunit;

namespace CalculatorApp.Test
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ValuesShouldCalculate()
        {
            // arrange
            var vm = new CalculateViewModel();
            vm.Number1 = double.MaxValue;
            vm.Number2 = 5;
            //double expected = 5;

            // act
            vm.AddCommand.Execute(null);
            //double actual = 5;

            // assert
            //Assert.Equal(expected, actual);
            Assert.True(vm.Output == double.MaxValue);
            
        }
    }
}
