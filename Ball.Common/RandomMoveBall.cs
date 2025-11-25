using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ball.Common
{
    public class RandomMoveBall : MoveBall
    {
        private int angle = 5;
        public RandomMoveBall(Form form) : base(form)
        {
            vx = random.Next(-angle, angle);
            vy = random.Next(-angle, angle);
        }
    }
}
