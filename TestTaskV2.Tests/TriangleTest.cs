using Mindbox.TestTaskV2;

namespace TestTaskV2.Tests
{
	public class TriangleTest
	{
		[TestCase(-3, 4, 5)]
		[TestCase(-3, -4, -5)]
		[TestCase(4, 5, 10)]
		public void NegativeSidesShouldThrowError(double sideA, double sideB, double sideC)
		{
			Assert.Throws<ArgumentException>(() => Figure.GetArea(sideA, sideB, sideC));
		}

		[TestCase(3.3, 2.4, 3.9)]
		public void CalculateCorrectArea(double sideA, double sideB, double sideC)
		{
			Assert.That(Figure.GetArea(sideA, sideB, sideC), Is.EqualTo(3.9436024140371955));
		}

		[TestCase(4, 3, 5)]
		public void IsRectangularShouldReturnTrue(double sideA, double sideB, double sideC)
		{
			var result = Figure.IsRectangular(sideA, sideB, sideC);
			Assert.That(result, Is.True);
		}

		[TestCase(4, 3, 6)]
		public void IsRectangularShouldReturnFalse(double sideA, double sideB, double sideC)
		{
			var result = Figure.IsRectangular(sideA, sideB, sideC);
			Assert.That(result, Is.False);
		}
	}
}
