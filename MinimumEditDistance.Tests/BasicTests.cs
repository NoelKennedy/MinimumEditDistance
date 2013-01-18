using FluentAssertions;
using NUnit.Framework;

namespace MinimumEditDistance.Tests {

    [TestFixture]
    public class BasicTests {

        [Test]
        public void Kitten_to_sitting_substitutions_cost_1()
        {
            Levenshtein.CalculateDistance("kitten", "sitting", 1).Should().Be(3);
        }

        [Test]
        public void Kitten_to_sitting_substitutions_cost_2() {
            Levenshtein.CalculateDistance("kitten", "sitting", 2).Should().Be(5);
        }

        [Test]
        public void Empty_to_1_letter() {
            Levenshtein.CalculateDistance("", "s", 2).Should().Be(1);
        }

        [Test]
        public void One_letter_to_empty() {
            Levenshtein.CalculateDistance("a", "", 2).Should().Be(1);
        }

        [Test]
        public void One_substitution_cost1() {
            Levenshtein.CalculateDistance("a", "b", 1).Should().Be(1);
        }

        [Test]
        public void Three_substitutions_cost1() {
            Levenshtein.CalculateDistance("abc", "def", 1).Should().Be(3);
        }

        [Test]
        public void One_substitution_cost2() {
            Levenshtein.CalculateDistance("a", "b", 2).Should().Be(2);
        }

        [Test]
        public void Three_substitutions_cost2() {
            Levenshtein.CalculateDistance("abc", "def", 2).Should().Be(6);
        }
    }
}
