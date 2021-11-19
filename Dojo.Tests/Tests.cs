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

            var result = TargetFinder.FindTarget(numbers, target);
            Assert.False(result);
        }
    }
}
