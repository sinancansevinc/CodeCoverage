namespace MathService.Tests
{
	[TestClass]
	public class FundamentalTests
	{
		private Fundamental _fundamentalService;
		public FundamentalTests()
		{
			_fundamentalService = new Fundamental();
		}

		
		[TestMethod]
		public void Should_Square_Area_Is_8_For_2()
		{
			var excepted = 8;
			var result = _fundamentalService.SquarePerimeter(2, 2);

			Assert.AreEqual(excepted, result);
		}

		[TestMethod]
		public void Should_Square_Area_Is_16_For_5_And_3()
		{
			var excepted = 16;
			var result = _fundamentalService.SquarePerimeter(5, 3);

			Assert.AreEqual(excepted, result);
			
		}
	}
}