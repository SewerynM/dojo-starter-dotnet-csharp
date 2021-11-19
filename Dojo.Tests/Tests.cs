using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Dojo.Tests
{
    public class Tests
    {
        [Fact]
        public void StarterTest()
        {
            Assert.True(Solution.IsSetup);
        }

        [Fact]
        public void Should_ReturnFalse_When_ArrayIsEmpty()
        {
            var numbers = Array.Empty<uint>();

            var target = UInt32.MaxValue;

            var result = TwoSumFinder.DoesContainTwoSum(numbers, target);
            
            Assert.False(result);
        }

        [Fact]
        public void Should_ReturnFalse_When_ArrayContainsSingleElement()
        {
            var numbers = new uint[] { 1 };
            
            var target = UInt32.MaxValue;

            var result = TwoSumFinder.DoesContainTwoSum(numbers, target);

            Assert.False(result);
        }

        [Fact]
        public void Should_ReturnFalse_When_ArrayDoesntContainTwoNumbersThatSumUpToTarget()
        {
            var numbers = new uint[] { 1, 2 };

            var target = 1U;

            var result = TwoSumFinder.DoesContainTwoSum(numbers, target);

            Assert.False(result);
        }

        [Fact]
        public void Should_ReturnTrue_When_ArrayContainsTwoNumbersThatSumUpToTarget()
        {
            var numbers = new uint[] { 1, 2 };

            var target = 3U;

            var result = TwoSumFinder.DoesContainTwoSum(numbers, target);

            Assert.True(result);
        }
    }
}
