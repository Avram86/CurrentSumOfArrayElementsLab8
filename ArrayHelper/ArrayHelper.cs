using System;

namespace ArrayHelper
{
    public static class ArrayHelper
    {
        public static int SumaCurenta(int index, int[] array)
        {
            int suma = 0;
            for (int i = 0; i <= index; i++)
            {
                suma = suma + array[i];
            }
            return suma;
        }
    }
}
