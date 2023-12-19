
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KhasanovRV.Sprint7.Project.V4.Lib;

namespace Tyuiu.KhasanovRV.Sprint7.Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint7\OutPutFileProject.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void TestMethod2()
        {
            
            string[,] array = new string[3, 4];
            array[0, 0] = "gdg";
            array[0, 1] = "ndgndong";
            array[0, 2] = "dsgnkjf";
            array[0, 3] = "True";
            array[1, 0] = "gdokgod";
            array[1, 1] = "kmsdglkd";
            array[1, 2] = "mkdmlgkd";
            array[1, 3] = "False";
            array[2, 0] = "mkdglkdm";
            array[2, 1] = "mkldglkg";
            array[2, 2] = "dmkfsmlkfbg";
            array[2, 3] = "False";

            var str = ds.Readed(array);
            string wait = "1/3";
            Assert.AreEqual(wait, str);


        }
    }
}
