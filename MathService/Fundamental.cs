using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathService
{
	public class Fundamental
	{
		public double SquarePerimeter(double a,double b)
		{
			if (a==b)
			{
				return 4 * a;
			}
			
			return 2 * (a + b);
		}
	}
}
