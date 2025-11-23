using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Collections.Generic;
using System.Reflection;
using Xunit;
using LR_4;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var createMethod = typeof(LR_4.Program).GetMethod("CreateList",
                BindingFlags.NonPublic | BindingFlags.Static);

            var list = (List<int>)createMethod.Invoke(null, null);

            Assert.NotNull(list);
            Assert.True(list.Count >= 5 && list.Count < 10);
            Assert.True(list.All(x => x >= 1 && x <= 9));
        }
    }
}