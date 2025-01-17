using BMIApp.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIApp.MVVM.ViewModels
{
    public class BMIViewModel
    {
        public BMI BMI { get; set; }
        public BMIViewModel()
        {
            BMI = new BMI();
            BMI.Weight = 75;
            BMI.Height = 180;
            BMI.Result = BMI.Weight / (BMI.Height / 100 * BMI.Height / 100);
        }
    }
}
