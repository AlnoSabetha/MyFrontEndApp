
using Microsoft.AspNetCore.Components;

namespace FrontEndApp.Pages
{
    public partial class Counter {
        private int currentCount = 0;

        public int MyProperty{get; set;}

        private void IncrementCount() {
            currentCount++;
        }
    }
}