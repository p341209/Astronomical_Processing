using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Astronomical_Processing
{
    public partial class Form1 : Form

    {
        // Create an integer list with 24 elements, available to all functions
        List<int> lst_astro_data = new List<int>() { 10, 30, 20, 40, 21, 11, 31, 41, 12, 32, 22, 42, 13, 23, 33, 43, 14, 24, 34, 44, 15, 25, 35, 45, };
     
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_Page_Heading_Click(object sender, EventArgs e)
        {

        }

        private void txt_Search_dataList_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Write_File_Click(object sender, EventArgs e)
        {
            // write the contents of the dataList to a file
            using var data_stream = new StreamWriter("DataFile.txt");
            foreach (var data_point in lst_astro_data)
            {
                data_stream.WriteLine(data_point);
            }
            MessageBox.Show("Data was written to file called DataFile.txt in current program folder.");
        }

        private void lbl_Search_dataList_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Write_File_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_dataFile_Click(object sender, EventArgs e)
        {
            // Convert the search string to integer
            int search_int;
            if (int.TryParse(txt_Search_dataList.Text, out search_int))
            {
                if (lst_astro_data.Contains(search_int)) // the user input an integer and it is found in the dataList
                {
                    MessageBox.Show("Found \'" + search_int + "\' at index number " + lst_astro_data.IndexOf(search_int) + " of dataList.");
                }
                else // the user input an integer, but it's not found in the dataList
                {
                    MessageBox.Show("\'" + search_int + "\' was not found in data.");
                }
            }
            else // the user did not input an integer
            {
                MessageBox.Show("\'" + txt_Search_dataList.Text + "\' not found, data contains only integers.");
            }

        }

        private void btn_show_data_Click(object sender, EventArgs e)
        {
            // create a string of all the unsorted list elements separated by a comma and space
            var unsorted_list = string.Join(", ", lst_astro_data);
            // display the string in a messagebox
            MessageBox.Show(unsorted_list);
        }

        private void btn_sort_data_Click(object sender, EventArgs e)
        {
            // create a copy of the original data list to sort
            List<int> lst_temp1 = new List<int>();
            lst_temp1.AddRange(lst_astro_data);
            //call the BubbleSort function and parse the copied list to it
            BubbleSort(lst_temp1);
            // create a string of all the sorted list elements separated by a comma and space
            var sorted_list = string.Join(", ", lst_temp1);
            // display the string in a messagebox
            MessageBox.Show(sorted_list);
        }


        // Bubble sort method
        private void BubbleSort(List<int> lst_to_sort)
        {
            // count the number of elements in the list
            int n = lst_to_sort.Count;
            // use a boolean for swapping order of elements
            bool swapped;
            // for each element in the list
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    // if this element is greater than the next element
                    if (lst_to_sort[j] > lst_to_sort[j + 1])
                    {
                        // Swap the elements
                        int temp = lst_to_sort[j];
                        lst_to_sort[j] = lst_to_sort[j + 1];
                        lst_to_sort[j + 1] = temp;
                        swapped = true;
                    }
                }
                // If no two elements were swapped in the inner loop, then the list is sorted
                if (!swapped)
                    break;
             }
        }
    }
}
