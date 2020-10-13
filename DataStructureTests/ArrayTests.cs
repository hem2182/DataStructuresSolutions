using System;
using System.Diagnostics;
using DataStructureLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureTests
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void RotateArrayUsingTempArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            var result = ArrayRotations.RotateUsingTempArray(arr, arr.Length, 2);
            var output = PrintArray(result);
            Assert.AreEqual("3 4 5 6 7 1 2", output);
        }

        [TestMethod]
        public void RotateArrayOneByOne()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int[] result = ArrayRotations.RotateOneByOne(arr, arr.Length, 2);
            var output = PrintArray(result);
            Assert.AreEqual("3 4 5 6 7 1 2", output);
        }

        [TestMethod]
        public void RotateArrayUsingJugglingAlgorithm()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] result = ArrayRotations.RotateUsingJugglingAlgorithm(arr, arr.Length, 3);
            var output = PrintArray(result);
            Assert.AreEqual("4 5 6 7 8 9 10 11 12 1 2 3", output);
        }

        [TestMethod]
        public void RotateArrayUsingReversalAlgorithm()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            var result = ArrayRotations.RotateUsingReversalAlgorithm(arr, arr.Length, 2);
            var output = PrintArray(result);
            Assert.AreEqual("3 4 5 6 7 1 2", output);
        }

        #region Private Helper Methods

        private string PrintArray(int[] result)
        {
            string output = string.Empty;
            for (int i = 0; i < result.Length; i++)
            {
                output += $"{result[i]} ";
            }
            return output.Trim();
        }

        #endregion
    }
}
