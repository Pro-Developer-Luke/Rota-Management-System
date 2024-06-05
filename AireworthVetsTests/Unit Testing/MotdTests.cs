using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace AireworthVetsTests.Unit_Testing
{
    [TestClass]
    public class MotdTests
    {
        public string motdPath = Environment.CurrentDirectory + "/" + "MOTDdata.txt";
        [TestMethod]
        public void settingMOTD_Test()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(motdPath))
                {
                    string setMotdText = "Test_Text";
                    sw.WriteLine(setMotdText);
                    return;
                }
            }
            catch
            {
                Assert.Fail("Could not write");
            }
        }

        [TestMethod]
        public void gettingMOTD_Test()
        {
            try
            {
                using (StreamReader sr = new StreamReader(motdPath))
                {
                    string newMotd = sr.ReadLine();
                    if(newMotd == "Test_Text")
                    {
                        return;
                    }
                    else
                    {
                        Assert.Fail("Can read but incorrect text value.");
                    }
                }
            }
            catch
            {
                Assert.Fail("Could not read.");
            }
        }
    }
}
