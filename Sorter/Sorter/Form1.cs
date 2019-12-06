using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Sorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

    
        private void generate_array_Click(object sender, EventArgs e)
        {
            int array_size = int.Parse(NumberArray.Text);

      
                int minimum_value = int.Parse(min_value.Text);
                int maximum_value = int.Parse(max_value.Text);

      
                    Random random = new Random();
                    int[] Array = new int[array_size];

                    for (int i = 0; i < array_size; i++)
                    {
                        Array[i] = random.Next(minimum_value, maximum_value);
                    }
                    String String_Array = string.Join(",", Array);
                    generated_array.Text = String_Array.ToString();
      
        }

            //insertion sorting
            void sort(int[] arr)
            {
                int n = arr.Length;
                Stopwatch insertionSort_time = new Stopwatch();

                insertionSort_time.Start();
                for (int i = 1; i < n; ++i)
                {
                    int select = arr[i];
                    int index = i - 1;

                    while (index >= 0 && arr[index] > select)
                    {
                        arr[index + 1] = arr[index];
                        index = index - 1;
                    }
                    arr[index + 1] = select;
                
                }
            
                insertionSort_time.Stop();
                sorting_time.Text = (insertionSort_time.Elapsed.TotalMilliseconds + "");
            
            }
            //insertion print
            void printArray(int[] arr)
            {
                int n = arr.Length;
                int[] Array=new int[n];
                String String_Arry;
                for (int i = 0; i < n; ++i)
                {
                    Array[i] = arr[i];
                }
                String_Arry = string.Join(",", Array);
                sorted_array.Text = String_Arry.ToString();

            }

            //heap sorting 
            public void heapsort(int[] array)
            {
                int number = array.Length;
                Stopwatch heapSortTime = new Stopwatch();
                heapSortTime.Start();
                
                for (int i = number / 2 - 1; i >= 0; i--)  //dec
                    heapify(array, number, i);
                    
                for (int i = number - 1; i >= 0; i--)
                {
                    
                    int temp = array[0];
                    array[0] = array[i];
                    array[i] = temp;


                    heapify(array, i, 0);
                }
                heapSortTime.Stop();
                sorting_time.Text = (heapSortTime.Elapsed.TotalMilliseconds + "");
            }

            void heapify(int[] arr, int n, int i)
            {
                int largest = i; 
                int left = 2 * i + 1; 
                int right = 2 * i + 2;

                if (left < n && arr[left] > arr[largest])
                    largest = left;

                if (right < n && arr[right] > arr[largest])
                    largest = right;

                if (largest != i)
                {
                    int swap = arr[i];
                    arr[i] = arr[largest];
                    arr[largest] = swap;

                    heapify(arr, n, largest);
                }
            }


        //quick sorting algorithem code here 

            public int partition(int[] arr, int low, int last)
            {
                int pivotElement = arr[last];

                int i = (low - 1);
                for (int j = low; j < last; j++)
                {

                    if (arr[j] < pivotElement)
                    {
                        i++;

                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

                int temp1 = arr[i + 1];
                arr[i + 1] = arr[last];
                arr[last] = temp1;

                return i + 1;
            }

            public void quickSort(int[] arr, int low, int high)
            {
                if (low < high)
                {
                    Stopwatch quick_sort_time = new Stopwatch();
                    quick_sort_time.Start();
                    
                    int pivot = partition(arr, low, high);
                    quickSort(arr, low, pivot - 1);
                    quickSort(arr, pivot + 1, high);

                    quick_sort_time.Stop();
                    sorting_time.Text = (quick_sort_time.Elapsed.TotalMilliseconds + "");
                }
            }

            //counting sort
            public int[] CountingSort(int[] array)
            {
                int[] sortedArray = new int[array.Length];

                int minimum = array[0];

                Stopwatch countingSort_time = new Stopwatch();
                countingSort_time.Start();
                int maximum = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < minimum) minimum = array[i];
                    else if (array[i] > maximum) maximum = array[i];
                }

                int[] counts = new int[maximum - minimum + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    counts[array[i] - minimum]++;
                }
                
                    counts[0] = counts[0] - 1;
                
                for (int i = 1; i < counts.Length; i++)
                {
                    counts[i] = counts[i] + counts[i - 1];
                }

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    sortedArray[counts[array[i] - minimum]--] = array[i];
                }
                countingSort_time.Stop();
                sorting_time.Text = (countingSort_time.Elapsed.TotalMilliseconds + "");
                return sortedArray;
            }


        private void clear_button_Click(object sender, EventArgs e)
        {
    
        }

        void clear_on_exception()
        {
         sorting_time.Text = "";
            sorted_array.Text = "";
            generated_array.Text = "";
            min_value.Text = "";
            max_value.Text = "";

         
            min_value.Enabled = true;
            max_value.Enabled = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {
          
            sorting_time.Text = "";
            sorted_array.Text = "";
            generated_array.Text = "";
            min_value.Text = "";
            max_value.Text = "";

            NumberArray.Enabled = true;
            min_value.Enabled = true;
            max_value.Enabled = true;

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Arry = generated_array.Text.Split(','); //converting string to array
            int[] convertedItems = Array.ConvertAll<string, int>(Arry, int.Parse);
            sort(convertedItems);
            printArray(convertedItems);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Arry = generated_array.Text.Split(','); //converting string to array
            
            int[] convertedItems = Array.ConvertAll<string, int>(Arry, int.Parse);
          
            int starting_index = 0;
            int ending_index = int.Parse(NumberArray.Text);
            quickSort(convertedItems, starting_index, ending_index - 1);

            printArray(convertedItems);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] Arry = generated_array.Text.Split(','); //converting string to array
            int[] convertedItems = Array.ConvertAll<string, int>(Arry, int.Parse);
            heapsort(convertedItems);
            printArray(convertedItems);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] Arry = generated_array.Text.Split(','); //converting string to array
            int[] convertedItems = Array.ConvertAll<string, int>(Arry, int.Parse);
            int[] a = CountingSort(convertedItems);
            printArray(a);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
