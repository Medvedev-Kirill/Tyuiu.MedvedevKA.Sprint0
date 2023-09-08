using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MedvedevKA.Sprint0.Task2.V0.Lib; 
namespace Tyuiu.MedvedevKA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataSecrviceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Кирилл";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Кирилл", res);
        }
    }
}
