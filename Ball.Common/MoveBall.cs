using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ball.Common
{
    public class MoveBall : RandomPointBall
    {
        
        public MoveBall(Form form) : base(form)
        {
            vx = GenerateRandomProjection();
            vy = GenerateRandomProjection();
        }
        private int GenerateRandomProjection()
        {
            var randomDouble = random.NextDouble();
            var sign = 1;
            if (randomDouble < 0.5) { sign = -1; }
            return random.Next(2, 5) * sign;
        }
    }
}
