using Xunit;

namespace Test
{
	public class Test 
	{
		[Fact]
		public void PassingTest() 
		{
			Assert.True(true);
		}	
		
		[Fact]
		public void FailingTest()
		{
			Assert.True(true);
		}
	}

}