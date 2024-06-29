using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPR;

public partial class MainForm : Form
{
    FirsrtTask first;
    private int[] arr1;
    private int[,] arr2;
    public string res = "";
    public int size = 0;
    public int n = 0;
    public int m = 0;
    private static int MAX_SIZE = 100;
    Random rand = new Random();

    public MainForm()
    {
        InitializeComponent();
        first = new FirsrtTask();
    }

    private void button1DMassive_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxInitial.Text))
        {
            textBoxInitial.Text = string.Empty;
            size = (int)numericUpDownSize1D.Value;
            arr1 = new int[size * 2]; //изменить на сколько изменяется массив 
            for (int i = 0; i < size; i++)
            {
                arr1[i] = rand.Next((int)numericUpDownMinValue.Value, (int)numericUpDownMaxValue.Value);
            }

            for (int i = 0; i < size; i++)
            {
                textBoxInitial.Text += Convert.ToString(arr1[i]) + " ";
            }
        }
        else
        {
            size = (int)numericUpDownSize1D.Value;
            arr1 = new int[size * 2];
            for (int i = 0; i < size; i++)
            {
                arr1[i] = int.Parse(textBoxInitial.Text.Split(" ")[i]);
            }
            textBoxInitial.Text = string.Empty;
            for (int i = 0; i < size; i++)
            {
                textBoxInitial.Text += Convert.ToString(arr1[i]) + " ";
            }
        }
    }

    private void button2DMassive_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxInitial.Text))
        {
            textBoxInitial.Text = string.Empty;
            n = (int)numericUpDownNOf2D.Value;
            m = (int)numericUpDownMOf2D.Value;
            arr2 = new int[n * 2, m * 2];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr2[i, j] = rand.Next((int)numericUpDownMinValue.Value, (int)numericUpDownMaxValue.Value);
                }
            }
        }
        else
        {
            textBoxInitial.Text = string.Empty;
            n = (int)numericUpDownNOf2D.Value;
            m = (int)numericUpDownMOf2D.Value;
            arr2 = new int[n * 2, m * 2];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //arr2[i, j] = int.Parse(textBoxInitial.Text.Split(" ")[i]).Split("\r\n");
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                textBoxInitial.Text += Convert.ToString(arr2[i, j]) + "   ";
            }
            textBoxInitial.Text += "\r\n";
        }
    }

    private void buttonFirst_Click(object sender, EventArgs e)
    {
        textBoxOutPutTask.Text = string.Empty;
        textBoxOutPutArray.Text = string.Empty;
        textBoxOutPutTask.Text += "Дан целочисленный одномерный массив размера N. Серия – это последовательность элементов массива, идущих друг за другом. Значения всех элементов серии одинаково.Серия должна содержать минимум 2 элемента.Длина серии – количество элементов в серии. Найти все серии.Вывести информацию с указанием длины для каждой серий исходного массива.";
        res = first.First(arr1, size);
        textBoxOutPutArray.Text = Convert.ToString(res);
    }

    private void buttonSecond_Click(object sender, EventArgs e)
    {
        textBoxOutPutTask.Text = string.Empty;
        textBoxOutPutArray.Text = string.Empty;
        textBoxOutPutTask.Text += "Дан целочисленный одномерный массив размера N. Переставить в обратном порядке элементы массива, расположенные между наибольшим отрицательным и наименьшим положительным.";
        arr1 = first.Second(arr1, size);
        for (int i = 0; i < size; i++)
        {
            textBoxOutPutArray.Text += Convert.ToString(arr1[i]) + " ";
        }
    }

    private void buttonThird_Click(object sender, EventArgs e)
    {
        textBoxOutPutTask.Text = string.Empty;
        textBoxOutPutArray.Text = string.Empty;
        textBoxOutPutTask.Text += "Дан целочисленный одномерный массив размера N. Вставить 1 после каждого положительного элемента массива";
        arr1 = first.Third(arr1, size);
        size = first.countForThird; // оставить
        for (int i = 0; i < size; i++)
        {
            textBoxOutPutArray.Text += Convert.ToString(arr1[i]) + " ";
        }
    }

    private void buttonFour_Click(object sender, EventArgs e)
    {
        textBoxOutPutTask.Text = string.Empty;
        textBoxOutPutArray.Text = string.Empty;
        textBoxOutPutTask.Text += "Дан целочисленный одномерный массив размера N. Удалить из массива все положительные элементы";
        arr1 = first.Four(arr1, size);
        size = first.countForFour; // оставить
        for (int i = 0; i < size; i++)
        {
            textBoxOutPutArray.Text += Convert.ToString(arr1[i]) + " ";
        }
    }

    private void buttonFifth_Click(object sender, EventArgs e)
    {
        textBoxOutPutTask.Text = string.Empty;
        textBoxOutPutArray.Text = string.Empty;
        textBoxOutPutTask.Text += "Дан целочисленный двумерный массив размера N*N. Добавить в массив столбец -1 после каждого столбца, в котором есть хотя бы один элемент, больший по модулю среднего арифметического отрицательных элементов массива.";
        arr2 = first.Five(arr2, n, m);
        m = first.mForFive;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                textBoxOutPutArray.Text += Convert.ToString(arr2[i, j]) + "   ";
            }
            textBoxOutPutArray.Text += "\r\n";
        }
    }

    private void buttonSix_Click(object sender, EventArgs e)
    {
        textBoxOutPutTask.Text = string.Empty;
        textBoxOutPutArray.Text = string.Empty;
        textBoxOutPutTask.Text += "Дан целочисленный двумерный массив размера N*N. Упорядочить элементы в матрице по возрастанию (слева направо, сверху-вниз)";
        arr2 = first.Six(arr2, n, m);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                textBoxOutPutArray.Text += Convert.ToString(arr2[i, j]) + "  ";
            }
            textBoxOutPutArray.Text += "\r\n  ";
        }
    }

    private void buttonPrintArray_Click(object sender, EventArgs e)
    {
        textBoxOutPutArray.Text = string.Empty;
        for (int i = 0; i < size; i++)
        {
            textBoxOutPutArray.Text += Convert.ToString(arr1[i]) + " ";
        }
    }
}
