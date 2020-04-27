using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Output()
        {
            string mark_code = "Mers02";
            string owner = "Owen";
            string mark = "Mercedez r1";
            string fuel = "Diesele";
            float power = 500;
            float volume = 245;
            float fuel_left = (float)0.2;
            float oil = 2;
            var result = XmlForm.XMLjobs.TestCars(mark_code
                            , owner
                            , mark
                            , fuel
                            , power
                            , volume
                            , fuel_left
                            , oil);
            string expected = $"Mark_code: {mark_code}\r\n owner: {owner}\r\n mark: {mark}\r\n fuel: {fuel}\r\n power: {power}\r\n volume: {volume}\r\n fuel_left: {fuel_left}\r\n oil: {oil}\r\n\r\n ";
            Assert.AreEqual(expected, result, "Test failed");
        }

        [TestMethod]
        public void NullOutput()
        {
            string mark_code = "";
            string owner = "Owen";
            string mark = "";
            string fuel = "";
            float power = 500;
            float volume = 245;
            float fuel_left = (float)0.2;
            float oil = 2;
            var result = XmlForm.XMLjobs.TestCars(mark_code
                            , owner
                            , mark
                            , fuel
                            , power
                            , volume
                            , fuel_left
                            , oil);
            string expected = $"Mark_code: {mark_code}\r\n owner: {owner}\r\n mark: {mark}\r\n fuel: {fuel}\r\n power: {power}\r\n volume: {volume}\r\n fuel_left: {fuel_left}\r\n oil: {oil}\r\n\r\n ";
            Assert.AreEqual(expected, result, "Test failed");
        }
        [TestMethod]
        public void FloatCheckNull()
        {
            string str = "";
            bool expected = false;
            var result = XmlForm.XMLjobs.CheckFloatValues(str);
            Assert.AreEqual(expected, result, "Test failed");
        }
        [TestMethod]
        public void FloatCheckString()
        {
            string str = "ab";
            bool expected = false;
            var result = XmlForm.XMLjobs.CheckFloatValues(str);
            Assert.AreEqual(expected, result, "Test failed");
        }
        [TestMethod]
        public void FloatCheckEmpty()
        {
            string str = "   ";
            bool expected = false;
            var result = XmlForm.XMLjobs.CheckFloatValues(str);
            Assert.AreEqual(expected, result, "Test failed");
        }
        [TestMethod]
        public void FloatCheckInt()
        {
            string str = "4";
            bool expected = true;
            var result = XmlForm.XMLjobs.CheckFloatValues(str);
            Assert.AreEqual(expected, result, "Test failed");
        }
        [TestMethod]
        public void FloatCheckFloat()
        {
            string str = "4,002";
            bool expected = true;
            var result = XmlForm.XMLjobs.CheckFloatValues(str);
            Assert.AreEqual(expected, result, "Test failed");
        }
        [TestMethod]
        public void FloatCheckTooManyDelimeters()
        {
            string str = "99,999.99.9.9";
            bool expected = false;
            var result = XmlForm.XMLjobs.CheckFloatValues(str);
            Assert.AreEqual(expected, result, "Test failed");
        }
        [TestMethod]
        public void FloatCheckTooManyWrongScientific()
        {
            string str = "987,654E-2";
            bool expected = true;
            var result = XmlForm.XMLjobs.CheckFloatValues(str);
            Assert.AreEqual(expected, result, "Test failed");
        }
        
        [TestMethod]
        public void ConditionTestNulls()
        {
            string mark_code = "";
            string owner = "Owen";
            string mark = "";
            string fuel = "";
            float power = 500;
            float volume = 245;
            float fuel_left = (float)0.2;
            float oil = 2;
            bool expected = false;
            var result = XmlForm.XMLjobs.CheckValues(mark_code, owner, mark, fuel, power, volume, fuel_left, oil);
            Assert.AreEqual(expected, result, "Wrong answer");
        }
        [TestMethod]
        public void ConditionTestEmpty()
        {
            string mark_code = "h02";
            string owner = "Owen";
            string mark = "    ";
            string fuel = "grass";
            float power = 500;
            float volume = 245;
            float fuel_left = (float)0.2;
            float oil = 2;
            bool expected = true;
            var result = XmlForm.XMLjobs.CheckValues(mark_code, owner, mark, fuel, power, volume, fuel_left, oil);
            Assert.AreEqual(expected, result, "Wrong answer");
        }
        [TestMethod]
        public void ConditionCheckMinusFloats()
        {
            string mark_code = "h02";
            string owner = "Owen";
            string mark = "    ";
            string fuel = "grass";
            float power = -500;
            float volume = -245;
            float fuel_left = -(float)0.2;
            float oil = -2;
            bool expected = false;
            var result = XmlForm.XMLjobs.CheckValues(mark_code, owner, mark, fuel, power, volume, fuel_left, oil);
            Assert.AreEqual(expected, result, "Wrong answer");
        }
        [TestMethod]
        public void ConditionCheckMinusFloats2()
        {
            string mark_code = "h02";
            string owner = "Owen";
            string mark = "    ";
            string fuel = "grass";
            float power = -500;
            float volume = -245;
            float fuel_left = (float)0.2;
            float oil = 2;
            bool expected = false;
            var result = XmlForm.XMLjobs.CheckValues(mark_code, owner, mark, fuel, power, volume, fuel_left, oil);
            Assert.AreEqual(expected, result, "Wrong answer");
        }
        [TestMethod]
        public void ConditionCheckNullsMinusFLoats3()
        {
            string mark_code = "h02";
            string owner = "Owen";
            string mark = "    ";
            string fuel = "grass";
            float power = 234;
            float volume = 245;
            float fuel_left = (float)0.2;
            float oil = -2;
            bool expected = false;
            var result = XmlForm.XMLjobs.CheckValues(mark_code, owner, mark, fuel, power, volume, fuel_left, oil);
            Assert.AreEqual(expected, result, "Wrong answer");
        }







    }
}
