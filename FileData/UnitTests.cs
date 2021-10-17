using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    [TestFixture]
    public class UnitTests
    {
        [TestCase("Invalid Arguments")]
        [Test]
        void Invliad_Command_Line_Arguments_Provide()
        {
            FileVersion fs = new FileVersion();
            string[] args = { "-vdaddw", "c:\test.txt" };
            Program.Main(args);
            Assert.IsNull(true);
        }
    }
}
