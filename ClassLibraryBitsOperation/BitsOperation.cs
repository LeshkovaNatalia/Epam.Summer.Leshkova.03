using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBitsOperation
{
    public class BitsOperation
    {
        #region Method InsertNumber
        /// <summary>
        ///Method InsertNumber insert sNumber to fNumber from position iPos to jPos
        /// </summary>
        /// <param name="fNumber">The Number in wich insert</param>
        /// <param name="sNumber">Insert number</param>
        /// <param name="iPos">First position to insert</param>
        /// <param name="jPos">Last position to insert</param>
        /// <returns>Combine number</returns>
        public static int InsertNumber(int fNumber, int sNumber, int iPos, int jPos)
        {
            int fTotal = GetNumberOfBits(fNumber);
            int sTotal = GetNumberOfBits(sNumber);

            int countBits = jPos - iPos;

            if (iPos > jPos || iPos == jPos)
                throw new ArgumentException();

            if (iPos < 0 || jPos < 0 || iPos > 30 || jPos > 30)
                throw new ArgumentException();

            if (sTotal > countBits)
                throw new ArgumentException();

            if (fTotal < iPos || sTotal <= countBits)
            {
                for (int i = iPos - 1, j = 0; i < jPos; i++, j++)
                {
                    if (((sNumber >> j) & 1) == 1)
                        fNumber |= 1 << i;
                }
            }
            else
            {
                throw new ArgumentException();
            }

            return fNumber;
        }
        #endregion

        #region Helper Methods
        private static int GetNumberOfBits(int number)
        {
            int order = 0;
            while (number > 1)
            {
                number /= 2;
                order++;
            }
            return order;
        }
        #endregion
    }
}
