namespace Astronomical_Processing
{
    public partial class Form1 : Form

    {
        // declare the list for use in functions
        List<int> lst_astro_data = new List<int>();
        // declare the path for where the data files are
        string data_path = @"c:\temp\";
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
            using var data_stream = new StreamWriter(data_path + "DataFile.txt");
            foreach (var data_point in lst_astro_data)
            {
                data_stream.WriteLine(data_point);
            }
            MessageBox.Show("Data was written to file called " + data_path + "DataFile.txt");
        }

        private void lbl_Search_dataList_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Write_File_Click(object sender, EventArgs e)
        {
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
            // write the sorted contents of the dataList to a new file
            using var data_stream = new StreamWriter(data_path + "SortedDataFile.txt");
            foreach (var data_point in lst_temp1)
            {
                data_stream.WriteLine(data_point);
            }
            MessageBox.Show("Data was written to file called " + data_path + "SortedDataFile.txt");
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

        private void btn_fetch_data_Click(object sender, EventArgs e)
        {
            // Create an integer list with 24 elements,
            // from a data file located on this computer
            try
            {
                // clear the list to prevent duplication
                lst_astro_data.Clear();
                // where to find the data file
                string file_path = data_path + "integers.txt";
                // open the data file for reading
                StreamReader reader = new StreamReader(file_path);
                string line;
                // add each line in the file to a list
                while ((line = reader.ReadLine()) != null)
                {
                    if (int.TryParse(line, out int astro_value))
                    { lst_astro_data.Add(astro_value); }
                    else { MessageBox.Show("Warning! The data file contains a non-integer value. Only integers will be imported."); }
                }
                // close the file
                reader.Close();
            }
            // display error message
            catch (Exception ex)
            {
                MessageBox.Show("Error.");
            }
        }
        //
        public static int BinarySearch(List<int> lst_to_search, int target)
        //return the index of the target value if it’s found
        //otherwise, return -1
        {
            int low = 0;
            int high = lst_to_search.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (lst_to_search[mid] == target)
                {
                    return mid;
                }
                else if (lst_to_search[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1; // not found
        }
        private void btn_binary_search_Click(object sender, EventArgs e)
        {
            int search_int;
            // test whether search input is an integer
            if (int.TryParse(txt_Search_dataList.Text, out search_int))
            {   // it's an integer, do the search
                // use the BinarySearch function
                int element_index = BinarySearch(lst_astro_data, search_int);
                // if the element is found, BinarySearch returns the index number
                if (element_index != -1)
                {
                    MessageBox.Show("Found \'" + search_int + "\' at index number " + element_index + " of dataList.");
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
    }
}


