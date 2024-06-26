using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SPR;

public class FirsrtTask
{
    public int countForThird = 0;
    public int countForFour = 0;
    public int nForFive = 0;

    public string First(int[] arr, int size)
    {
        string res = "";
        int count = 1;
        int number = arr[0];
        for (int i = 1; i < size + 1; i++)
        {
            if (arr[i] == number)
            {
                count++;
            }
            else
            {
                if (count >= 2)
                {
                    res += count + " ";
                }
                number = arr[i];
                count = 1;
            }
        }
        return res;
    }

    //перестановка
    public int[] Second(int[] arr, int size)
    {
        int indexMax = -10;
        int maxValue = int.MinValue; //наиб отриц
        int indexMin = -10;
        int minValue = int.MaxValue; //наим положит

        for (int i = 0; i < size; i++)
        {
            if ((arr[i] < 0) && (arr[i] > maxValue))
            {
                maxValue = arr[i];
                indexMax = i;
            }
            if ((arr[i] > 0) && (arr[i] < minValue))
            {
                minValue = arr[i];
                indexMin = i;
            }
        }

        if (indexMin < 0 || indexMax < 0)
        {
            MessageBox.Show("массив не удовлетворяет условию");
        }
        else
        {

            if (indexMax < indexMin)
            {
                int tmp = indexMin;
                indexMin = indexMax;
                indexMax = tmp;
            }

            int mx = indexMax - 1;

            for (int i = indexMin + 1; i < mx; i++, mx--)
            {
                int tmp = arr[i];
                arr[i] = arr[mx];
                arr[mx] = tmp;
            }
        }
        return arr;
    }

    public int[] Third(int[] arr, int size)
    {
        int count = 0;
        int l = 0;
        countForThird = size; //оставить
        for (int i = 0; i < arr.Length; i++)
        {
            count++;
            if (arr[i] < 0)
            {
                l++;
                for (int k = size + l - 1; k > count; k--) // изменить
                {
                    arr[k] = arr[k - 1];
                }
                arr[count] = -1;
                countForThird++; //оставить 
                count++;
                i++;
            }
        }
        return arr;
    }

    public int[] Four(int[] arr, int size)
    {
        countForFour = size;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                for (int k = i; k < size - 1; k++)
                {
                    arr[k] = arr[k + 1];
                }
                size--;
                countForFour--;
                i--;
            }
        }
        return arr;
    }

    public int[,] Five(int[,] arr, int n, int m)
    {
        int sr = 0;
        int count = 0;
        int sum = 0;
        nForFive = n;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (arr[i, j] % 2 == 0 && arr[i, j] != 0)
                {
                    sum += Math.Abs(arr[i, j]);
                    count++;
                }
            }
        }
        if (count != 0)
        {
            sr = (sum / count);
        }
        else
        {
            return arr;
        }
        count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (Math.Abs(arr[i, j]) < sr)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                for (int l = n; l > i + 1; l--)
                {
                    for (int h = 0; h < m; h++)
                    {
                        arr[l, h] = arr[l - 1, h];
                    }
                }
                for (int h = 0; h < m; h++)
                {
                    arr[i + 1, h] = 1;
                }
                n++;
                nForFive++;
                i++;
            }
        }
        return arr;
    }

    public int[,] Six(int[,] arr, int n, int m)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    for (int h = 0; h < m; h++)
                    {
                        if (arr[i, j] < arr[k, h])
                        {
                            int tmp = arr[i, j];
                            arr[i, j] = arr[k, h];
                            arr[k, h] = tmp;
                        }
                    }
                }
            }
        }
        return arr;
    }
}
