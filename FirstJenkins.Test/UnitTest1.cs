using System;
using System.IO;
using Xunit;

namespace FirstJenkins.Test
{
    public class UnitTest1
    {
        private const string Expected = "Hello World! from jenkins";
        [Fact]
        public void Test1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main();

                var result = sw.ToString().Trim();
                Assert.Equal(Expected, result);
            }
        }
    }
}
