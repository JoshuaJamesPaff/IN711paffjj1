using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Algorithms
{
    public partial class Form1 : Form
    {
        public ArraySorter sorter = new ArraySorter();
        public int[] currentArray;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// adds random array into listbox
        /// </summary>
        private void buttonCreateArray_Click(object sender, EventArgs e)
        {
            listBoxUnsorted.Items.Clear();
            listBoxSorted.Items.Clear();
            int arraySize = 0;
            bool isNumber = Int32.TryParse(textBoxArraySize.Text, out arraySize);
            int[] randArray = sorter.CreateRandomArray(arraySize);
            currentArray = randArray;

            if(isNumber){
                foreach(int i in randArray){
                    listBoxUnsorted.Items.Add(i);
                }
            }            
        }

        private void buttonBubble_Click(object sender, EventArgs e)
        {
            listBoxSorted.Items.Clear();

            int[] sortedArray = sorter.BubbleSort(currentArray);
            foreach (int i in sortedArray)
            {
                listBoxSorted.Items.Add(i);
            }        
        }

        private void buttonSelection_Click(object sender, EventArgs e)
        {
            listBoxSorted.Items.Clear();

            int[] sortedArray = sorter.SelectionSort(currentArray);
            foreach (int i in sortedArray)
            {
                listBoxSorted.Items.Add(i);
            }
        }

        private void buttonInsertion_Click(object sender, EventArgs e)
        {
            listBoxSorted.Items.Clear();

            int[] sortedArray = sorter.InsertionSort(currentArray);
            foreach (int i in sortedArray)
            {
                listBoxSorted.Items.Add(i);
            }
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            listBoxSorted.Items.Clear();

            int[] sortedArray = sorter.MergeSort(currentArray);
            foreach (int i in sortedArray)
            {
                listBoxSorted.Items.Add(i);
            }
        }

    }
}
