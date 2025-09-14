using Rftim8Convoy.Services.Static.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8xUnitLeetCode.Unit
{
    public class _01452_PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherList_Test
    {
        // Arrange
        private static readonly List<string> Input = RftLeetCodeStaticData.Input_Test(problemName: nameof(_01452_PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherList))!;
        private static readonly int ExpectedPartOne = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01452_PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherList))![0]);
        private static readonly int ExpectedPartTwo = int.Parse(RftLeetCodeStaticData.Output_Test(problemName: nameof(_01452_PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherList))![1]);

        public static TheoryData<List<string>, int> _01452_PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherListPartOne_Data =>
            new()
            {
                { Input, ExpectedPartOne }
            };

        public static TheoryData<List<string>, int> _01452_PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherListPartTwo_Data =>
            new()
            {
                { Input, ExpectedPartTwo }
            };

        [Theory]
        [MemberData(nameof(_01452_PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherListPartOne_Data))]
        public void RftPartOne(List<string> a0, int expected)
        {
            // Act
            int actual = _01452_PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherList.PartOne_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(_01452_PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherListPartTwo_Data))]
        public void RftPartTwo(List<string> a0, int expected)
        {
            // Act
            int actual = _01452_PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherList.PartTwo_Test(a0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
