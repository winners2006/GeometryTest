using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTest
{
	public class Triangle : IShape
	{
		private readonly double _sideA;
		private readonly double _sideB;
		private readonly double _sideC;

		public Triangle(double sideA, double sideB, double sideC)
		{
			_sideA = sideA;
			_sideB = sideB;
			_sideC = sideC;
		}

		public double GetArea()
		{
			double semiPerimeter = (_sideA + _sideB + _sideC) / 2;
			return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
		}

		public bool IsRightTriangle()
		{
			double[] sides = { _sideA, _sideB, _sideC };
			Array.Sort(sides);
			return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
		}
	}
}
