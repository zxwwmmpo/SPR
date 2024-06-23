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
    public int size = 0;
    public int n = 0;
    public int m = 0;
    private static int MAX_SIZE = 10;
    Random rand = new Random();
    public MainForm()
    {
        InitializeComponent();
        first = new FirsrtTask();
    }

    private void button1DMassive_Click(object sender, EventArgs e)
    {
        textBoxInitial.Text = string.Empty;
        size = (int)numericUpDownSize1D.Value;
        arr1 = new int[MAX_SIZE];
        for (int i = 0; i < size; i++)
        {
            arr1[i] = rand.Next((int)numericUpDownMinValue.Value, (int)numericUpDownMaxValue.Value);
        }

        for (int i = 0; i < size; i++)
        {
            textBoxInitial.Text += Convert.ToString(arr1[i]) + " ";
        }
    }

    private void button2DMassive_Click(object sender, EventArgs e)
    {
        textBoxInitial.Text = string.Empty;
        int n = (int)numericUpDownNOf2D.Value;
        int m = (int)numericUpDownMOf2D.Value;
        arr2 = new int[MAX_SIZE, MAX_SIZE];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                arr2[i, j] = rand.Next((int)numericUpDownMinValue.Value, (int)numericUpDownMaxValue.Value);
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                textBoxInitial.Text += Convert.ToString(arr2[i, j]) + "  ";
            }
            textBoxInitial.Text += "\r\n";
        }
    }

    private void buttonFirst_Click(object sender, EventArgs e)
    {
        textBoxOutPutTask.Text = string.Empty;
        textBoxOutPutArray.Text = string.Empty;
        textBoxOutPutTask.Text += "Дан массив ненулевых целых чисел размера N. Проверить, чередуются ли в нем четные и нечетные числа. Если чередуются, то вывести 0, если нет, то вывести номер первого элемента, нарушающего закономерность.";
        textBoxOutPutArray.Text += Convert.ToString(first.First(arr1, size));
    }

    private void buttonSecond_Click(object sender, EventArgs e)
    {
        textBoxOutPutTask.Text = string.Empty;
        textBoxOutPutArray.Text = string.Empty;
        textBoxOutPutTask.Text += "Дан целочисленный массив размера N. Переставить в обратном порядке элементы массива, расположенные между наибольшим четным и наименьшим нечетным.";
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
        textBoxOutPutTask.Text += "Дан целочисленный массив размера N. Назовем серией группу элементов, на которых элементы имеют одинаковые знаки (то есть участков, на которых все элементы положительные или все элементы отрицательные). Добавить в конец каждой его серии еще один элемент (-1 для отрицательных и 1 для положительных).";
        arr1 = first.Third(arr1, size);
        for (int i = 0; i < size; i++)
        {
            textBoxOutPutArray.Text += Convert.ToString(arr1[i]) + " ";
        }
    }
}
