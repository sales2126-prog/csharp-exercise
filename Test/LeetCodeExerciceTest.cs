using Xunit;

namespace Test
{
    public class LeetCodeExerciceTest
    {
        [Fact]
        public void TestSum()
        {
            Assert.Equal(5, Exercise.LeetCodeExercise.Sum(2, 3));
            Assert.Equal(0, Exercise.LeetCodeExercise.Sum(-1, 1));
            Assert.Equal(-5, Exercise.LeetCodeExercise.Sum(-2, -3));
        }
    }
}