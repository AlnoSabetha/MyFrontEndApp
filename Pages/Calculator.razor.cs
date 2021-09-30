using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEndApp.Pages.Models;

namespace FrontEndApp.Pages
{
    public partial class Calculator 
    {
        private List<CalculatorItem> calculator = new();
        private int newInput1;
        private int newInput2;

        public void hitung() {
           var tambah = newInput1 + newInput2;
           Console.WriteLine(tambah);
        }
    }
}