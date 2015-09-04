using Shouldly;
using Xunit;

namespace blazey.specifications.specs
{
    public class Passes
    {
        [Fact]
        public void Pass()
        {
            true.ShouldBe(true);
        }
    }
}
