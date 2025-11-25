using Ball.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryBirdsWinForms
{
    public class Pig : MoveBall
    {
        public Pig(Form form) : base(form)
        {
            brush = Brushes.Pink;
            radius = 35;
        }
    }
}
