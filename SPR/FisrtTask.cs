using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SPR;

public class FirsrtTask
{
    public int First(int[] arr, int size)
    {
        int flag = -1;
        for (int i = 0; i < size - 1; i++)
        {
            if ((arr[i] + arr[i + 1]) % 2 == 0)
            {
                flag = flag + 1;
                return (i + 1);
                break;
            }
        }
        if (flag < 0)
        {
            return 0;
        }
        return -1;
    }

    //перестановка
    public int[] Second(int[] arr, int size)
    {
        int indexMax = -1;
        int maxValue = 0;
        int indexMin = -1;
        int minValue = 100;

        for (int i = 0; i < size; i++)
        {
            if ((arr[i] % 2 == 0) && (arr[i] > maxValue))
            {
                maxValue = arr[i];
                indexMax = i;
            }
        }

        for (int i = 0; i < size; i++)
        {
            if ((arr[i] % 2 == 0) && (arr[i] < minValue))
            {
                minValue = arr[i];
                indexMin = i;
            }
        }

        if (indexMax < indexMin)
        {
            int tmp = indexMin;
            indexMin = indexMax;
            indexMax = tmp;
        }

        int mx = indexMax;

        for (int i = indexMin; i < mx; i++, mx--)
        {
            int tmp = arr[i];
            arr[i] = arr[mx];
            arr[mx] = tmp;
        }
        return arr;
    }

    public int[] Third(int[] arr, int size)
    {
        int count = 1;
        for (int i = 0; i < size; i++)
        {

            if (arr[i] > 0)
            {
                count++;
            }
        }
        int n = arr.Length;

        for (int i = n - 1; i > count; i--)
        {
            arr[i] = arr[i - 1];
        }

        if (count < n)
        {
            arr[count] = 1;
        }        

        return arr;
    }
}
