namespace Mindbox.TestTaskV2
{
	public class Figure
	{
		public Figure() { }

		/// <summary>
		/// Площадь круга
		/// </summary>
		/// <returns></returns>
		public static double GetArea(double radius)
		{
			if (radius < 0)
				throw new ArgumentException("Радиус должен быть больше 0");

			return Math.PI * Math.Pow(radius, 2);
		}

		/// <summary>
		/// Площадь треугольника
		/// </summary>
		/// <returns></returns>
		public static double GetArea(double sideA, double sideB, double sideC)
		{
			if (sideA < 0 || sideB < 0 || sideC < 0)
				throw new ArgumentException("Длина не может быть отрицательной");

			if (!((sideA + sideB) > sideC &&
				(sideA + sideC) > sideB &&
				(sideB + sideC) > sideA))
				throw new ArgumentException("У треугольника сумма любых двух сторон " +
					"должна быть больше третьей");

			//Полупериметр
			var halfP = (sideA + sideB + sideC) / 2;

			return Math.Sqrt(halfP *
				(halfP - sideA) *
				(halfP - sideB) *
				(halfP - sideC));
		}

		/// <summary>
		/// Является ли треугольник прямоугольным
		/// </summary>
		/// <returns></returns>
		public static bool IsRectangular(double sideA, double sideB, double sideC)
		{
			double[] sides = { sideA, sideB, sideC };

			Array.Sort(sides);
			Array.Reverse(sides);

			if (Math.Pow(sides[0], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2))
				return true;

			return false;
		}
	}
}