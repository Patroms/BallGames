using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitNinjaWinFormsApp
{
    public class Banana : FruitBall
    {
        public Banana(Form form) : base(form)
        {
            brush = Brushes.Yellow;
        }
    }
}
