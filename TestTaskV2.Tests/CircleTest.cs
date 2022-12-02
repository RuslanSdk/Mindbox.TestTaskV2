using Mindbox.TestTaskV2;

namespace TestTaskV2.Tests
{
	public class CircleTest
	{
		[SetUp]
		public void Setup()
		{ }

		[TestCase(-3)]
		public void NegativeRadiusShouldThrowError(double r)
		{
			Assert.Throws<ArgumentException>(() => Figure.GetArea(r));
		}

		[TestCase(4.4)]
		public void CalculateCorrectArea(double r)
		{
			Assert.That(Figure.GetArea(r), Is.EqualTo(60.821233773498406));
		}
	}
}