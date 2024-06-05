using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace AireworthVetsTests.Intergration_Testing
{
    [TestClass]
    public class MOTDdataIntegrationTest
    {
        public string motdPath = Environment.CurrentDirectory + "/" + "MOTDdata.txt";
        [TestMethod]
        public void MOTD_fileCreation_Test()
        {
            if (!File.Exists(motdPath))
            {
                File.CreateText(motdPath);
                if (!File.Exists(motdPath))
                {
                    Assert.Fail("File was not created");
                }
            }
        }

        [TestMethod]
        public void MOTD_fileRemoval_Test()
        {
            if (File.Exists(motdPath))
            {
                File.Delete(motdPath);
                if (File.Exists(motdPath))
                {
                    Assert.Fail("File still exists");
                }
            }
        }
    }
}
