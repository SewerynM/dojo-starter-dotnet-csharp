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
            var numbers = new [] { 1U };
            
            var target = UInt32.MaxValue;

            var result = TwoSumFinder.DoesContainTwoSum(numbers, target);

            Assert.False(result);
        }

        [Fact]
        public void Should_ReturnFalse_When_ArrayDoesntContainTwoNumbersThatSumUpToTarget()
        {
            var numbers = new [] { 1U, 2U };

            var target = 1U;

            var result = TwoSumFinder.DoesContainTwoSum(numbers, target);

            Assert.False(result);
        }

        [Fact]
        public void Should_ReturnTrue_When_ArrayContainsTwoNumbersThatSumUpToTarget()
        {
            var numbers = new [] { 1U, 2U };

            var target = 3U;

            var result = TwoSumFinder.DoesContainTwoSum(numbers, target);

            Assert.True(result);
        }

        [Fact]
        public void Should_ReturnTrue_When_ArrayContainsMultipleNumbers_And_TwoNumbersSumUpToTarget()
        {
            var numbers = GetNumbersArray();
            var target = 101U;

            var result = TwoSumFinder.DoesContainTwoSum(numbers, target);

            Assert.True(result);
        }

        [Fact]
        public void Should_ReturnFalse_When_ArrayContainsMultipleNumbers_And_NoTwoNumbersSumUpToTarget()
        {
            var numbers = GetNumbersArray();
            var target = 1000U;

            var result = TwoSumFinder.DoesContainTwoSum(numbers, target);

            Assert.False(result);
        }

        [Fact]
        public void Should_ReturnTrue_When_ArrayContainsSeveralNumbers_And_TwoNumbersSumUpToTarget()
        {
            var numbers = new[] { 10U, 15U, 3U, 7U };
            var target = 17U;

            var result = TwoSumFinder.DoesContainTwoSum(numbers, target);

            Assert.True(result);
        }

        [Fact]
        public void Should_ReturnFalse_When_ArrayContainsSeveralNumbers_And_NoTwoNumbersSumUpToTarget()
        {
            var numbers = new []{ 10U, 15U, 3U, 7U };
            var target = 19U;

            var result = TwoSumFinder.DoesContainTwoSum(numbers, target);

            Assert.False(result);
        }

        private static uint[] GetNumbersArray()
        {
            var numbers = new uint[100];

            for (uint i = 0 ; i < numbers.Length; i++)
            {
                numbers[i] = i+1;
            }

            return numbers;
        }
    }
}
