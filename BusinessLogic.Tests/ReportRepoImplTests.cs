using Xunit;

namespace BusinessLogic.Tests
{
    public class ReportRepoImplTests
    {
        [Theory]
        [InlineData("Manager Sales", "Sales")]
        [InlineData("Head of Marketing", "Marketing")]
        [InlineData("Ast Manager IT", "IT")]
        [InlineData("Sr. Manager Finance", "Finance")]
        [InlineData("VP Chief Direktur HR", "HR")]
        public void NormalizeEmployeePositionName_RemovesPrefixes(string input, string expected)
        {
            var repo = new Prove.BusinessLogic.Impl.ReportRepoImpl(null, null, null);

            var result = repo.NormalizeEmployeePositionName(input)?.Trim();

            Assert.Equal(expected, result);
        }
    }
}
