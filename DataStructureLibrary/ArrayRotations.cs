using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLibrary
{
    public static class ArrayRotations
    {
        /// <summary>
        /// Rotates array with "noOfElements" using a temp array.
        /// Time complexity : O(n).
        /// Auxiliary Space/Space complexity : O(d).
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="arraySize"></param>
        /// <param name="noOfElements"></param>
        /// <returns></returns>
        public static int[] RotateUsingTempArray(int[] arr, int arraySize, int noOfElements)
        {
            int[] tempArray = new int[noOfElements];

            for (int i = 0; i < arraySize; i++)
            {
                if (i < noOfElements)
                    tempArray[i] = arr[i];

                if (i < arraySize - noOfElements)
                    arr[i] = arr[i + noOfElements];

                if (i > arraySize - noOfElements - 1)
                    arr[i] = tempArray[i - (arraySize - noOfElements)];
            }

            return arr;
        }

        /// <summary>
        /// Left Rotates array by one till noOfElements. 
        /// Time complexity : O(n * d)
        /// Auxiliary Space/Space complexity : O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="arraySize"></param>
        /// <param name="noOfElements"></param>
        /// <returns></returns>
        public static int[] RotateOneByOne(int[] arr, int arraySize, int noOfElements)
        {
            for (int i = 0; i < noOfElements; i++)
            {
                int j, temp = arr[0];
                for (j = 0; j < arraySize - 1; j++)
                    arr[j] = arr[j + 1];

                arr[j] = temp;
            }

            return arr;
        }

        /// <summary>
        /// This is an extension of method 2. Instead of moving one by one, divide the array in different sets where number of sets is equal to GCD of n and d and move the elements within sets.
        /// If GCD is 1 as is for the above example array(n = 7 and d = 2), then elements will be moved within one set only, we just start with temp = arr[0] and keep moving arr[I + d] to arr[I] and finally store temp at the right place.
        /// Time complexity : O(n)
        /// Auxiliary Space : O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="arraySize"></param>
        /// <param name="noOfElements"></param>
        /// <returns></returns>
        public static int[] RotateUsingJugglingAlgorithm(int[] arr, int arraySize, int noOfElements)
        {
            int i, j, k, temp;
            int gcd = GCD(noOfElements, arraySize);
            for (i = 0; i < gcd; i++)
            {
                /* move i-th values of blocks */
                temp = arr[i];
                j = i;
                while (true)
                {
                    k = j + noOfElements;
                    if (k >= arraySize)
                        k = k - arraySize;
                    if (k == i)
                        break;
                    arr[j] = arr[k];
                    j = k;
                }
                arr[j] = temp;
            }

            return arr;
        }

        /// <summary>
        /// Let the array be arr[] = [1, 2, 3, 4, 5, 6, 7], d =2 and n = 7
        /// A = [1, 2]
        /// and B = [3, 4, 5, 6, 7]
        /// Reverse A, we get ArB = [2, 1, 3, 4, 5, 6, 7]
        /// Reverse B, we get ArBr = [2, 1, 7, 6, 5, 4, 3]
        /// Reverse all, we get(ArBr)r = [3, 4, 5, 6, 7, 1, 2]
        /// Time Complexity : O(n)
        /// Auxiliary Space : None
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="arraySize"></param>
        /// <param name="noOfElements"></param>
        /// <returns></returns>
        public static int[] RotateUsingReversalAlgorithm(int[] arr, int arraySize, int noOfElements)
        {
            if (noOfElements == 0)
                return arr;
            rvereseArray(arr, 0, noOfElements - 1);
            rvereseArray(arr, noOfElements, arraySize - 1);
            rvereseArray(arr, 0, arraySize - 1);

            return arr;
        }

        private static void rvereseArray(int[] arr, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        /// <summary>
        /// Initialize A = arr[0..d-1] and B = arr[d..n-1]
        /// 1) Do following until size of A is equal to size of B
        /// a)  If A is shorter, divide B into Bl and Br such that Br is of same
        ///  length as A.Swap A and Br to change ABlBr into BrBlA.Now A
        /// is at its final place, so recur on pieces of B.
        /// b)  If A is longer, divide A into Al and Ar such that Al is of same
        /// length as B Swap Al and B to change AlArB into BArAl.Now B
        /// is at its final place, so recur on pieces of A.
        /// 2)  Finally when A and B are of equal size, block swap them.
        /// Time Complexity: O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="arraySize"></param>
        /// <param name="noOfElements"></param>
        /// <returns></returns>
        public static int[] RotateUsingBlockSwapAlgorithm_IterativeApproach(int[] arr, int arraySize, int noOfElements)
        {
            return null;
        }

        /// <summary>
        /// Initialize A = arr[0..d-1] and B = arr[d..n-1]
        /// 1) Do following until size of A is equal to size of B
        /// a)  If A is shorter, divide B into Bl and Br such that Br is of same
        ///  length as A.Swap A and Br to change ABlBr into BrBlA.Now A
        /// is at its final place, so recur on pieces of B.
        /// b)  If A is longer, divide A into Al and Ar such that Al is of same
        /// length as B Swap Al and B to change AlArB into BArAl.Now B
        /// is at its final place, so recur on pieces of A.
        /// 2)  Finally when A and B are of equal size, block swap them.
        /// Time Complexity: O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="arraySize"></param>
        /// <param name="noOfElements"></param>
        /// <returns></returns>
        public static int[] RotateUsingBlockSwapAlgorithm_RecursiveApproach(int[] arr, int arraySize, int noOfElements)
        {
            return null;
        }


        public static int[] CyclicallyRotateByN(int[] arr, int arraySize, int noOfElements)
        {
            return null;
        }


        #region Helper Methods

        /// <summary>
        /// Recursive function to find Greatest Common Factor.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int GCD(int d, int n)
        {
            if (n == 0)
                return d;
            else
                return GCD(n, d % n);
        }

        #endregion
    }
}
