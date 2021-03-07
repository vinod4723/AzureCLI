using System;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        ValuesController obj=new ValuesController();
        [Fact]
        public void Test1()
        {
            var resturnValues=obj.Get(1);
            Assert.Equal("Bhawesh Paliwal",resturnValues.Value);
        }
    }
}
