using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTest
{
	public class Circle : IShape
	{
		private readonly double _radius;

		public Circle(double radius)
		{
			_radius = radius;
		}

		public double GetArea()
		{
			return Math.PI * Math.Pow(_radius, 2);
		}
	}
}
