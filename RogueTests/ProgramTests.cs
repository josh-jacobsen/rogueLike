using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace RogueTests
{
    public class ProgramTests
    {
        [Fact]
        public void Working()
        {
            Assert.True(true);
        }
    }

    class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }

    }
}
