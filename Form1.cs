using System.Diagnostics;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Astronomical_Processing
// Steven Kendall, p341209, Sprint Number 1
// Date: August 2024
// Version: 16
// Name of the program: Astronomical_Processing
// Brief explanation of the program:
// Simulates astronomical data by generating random integers
// the numbers are written to a file called integers.txt
// the file integers.txt is then opened to be the simulated data stream
// the read data is written to a list so that it can be sorted and searched
// the data in the list can be edited and saved
// the data can also be saved to a new file called data_file.txt
//

{
    public partial class Form1 : Form

    {
        // declare the list for use in functions
        List<int> lst_astro_data = new List<int>();
        // declare the path for where the data files are
        string data_path = @".\";
        string data_file_name = "integers.txt";
        // set a boolean to determine whether data has been loaded into list
        bool data_fetched = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // run function to write 24 random integers to a file
            create_random_data();
        }
        private void create_random_data()
        {
            Random rnd = new Random();
            List<int> lst_random_numbers = new List<int>();
            // generate 24 random integers
            for (int i = 0; i < 24; i++)
            {
                // the integers to be between 0 and 90
                int new_data_point = rnd.Next(0, 91);
                // write them to a list
                lst_random_numbers.Add(new_data_point);
            }
            // write the contents of the lst_random_numbers to a file, we will use the file as a datastream
            using var data_stream = new StreamWriter(data_path + "integers.txt");
            foreach (var data_point in lst_random_numbers)
            {
                data_stream.WriteLine(data_point);
            }
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
            // open the saved file using the system default text editor
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "DataFile.txt";
            psi.UseShellExecute = true;
            psi.Verb = "edit";
            Process.Start(psi);
        }

        private void lbl_Search_dataList_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Write_File_Click(object sender, EventArgs e)
        {
        }


        private void btn_sort_data_Click(object sender, EventArgs e)
        {
            BubbleSort(lst_astro_data);
            // clear contents of the listbox to prevent duplication
            listBox1.Items.Clear();
            // add all elements of lst_sorted to the listbox
            for (int y = 0; y < lst_astro_data.Count; y++)
            {
                listBox1.Items.Add(lst_astro_data[y]);
            }
        }

        // Bubble sort method
        private void BubbleSort(List<int> lst_to_sort)
        {
            // count the number of elements in the list
            int n = lst_to_sort.Count;
            // display an error message if no data to sort
            if (n < 1)
            {
                MessageBox.Show("Nothing to sort. Please fetch data.");
            }
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
                string file_path = data_path + data_file_name;
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
                data_fetched = true;
            }
            // display error message
            catch (Exception)
            {
                MessageBox.Show("Error.");
            }
            // clear contents of the listbox to prevent duplication
            listBox1.Items.Clear();
            // add all elemnts of lst_astro_data to the listbox
            for (int y = 0; y < lst_astro_data.Count; y++)
            {
                listBox1.Items.Add(lst_astro_data[y]);
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
            // check that data has been loaded
            if (lst_astro_data.Count == 0)
            {
                MessageBox.Show("No data to search. Please fetch the data first.");
                txt_Search_dataList.Clear();
            }
            else
            {
                int search_int;
                // test whether search input is an integer
                if (int.TryParse(txt_Search_dataList.Text, out search_int))
                {
                    // it's an integer, do the search
                    // use the BinarySearch function
                    // Binary Search assumes sorted data; sort first
                    // create a copy of the original data list to sort
                    List<int> lst_sorted = new List<int>();
                    lst_sorted.AddRange(lst_astro_data);
                    //call the BubbleSort function and parse the copied list to it
                    BubbleSort(lst_sorted);
                    int element_index = BinarySearch(lst_sorted, search_int);
                    // if the element is found, BinarySearch returns the index number
                    if (element_index != -1)
                    {
                        MessageBox.Show("Found \'" + search_int + "\' at index number " + element_index + " of sorted data list.");
                    }
                    else // the user input an integer, but it's not found in the dataList
                    {
                        MessageBox.Show("\'" + search_int + "\' was not found in data.");
                    }
                }
                else // the user did not input an integer
                {
                    MessageBox.Show("\'" + txt_Search_dataList.Text + "\' not found, can only search for integers.");
                }
            }
            // clear the search box contents after performing the search
            txt_Search_dataList.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when an element in the list is selected
            // get the index of the selected element
            int selectedIndex = listBox1.SelectedIndex;
            // cast the selected element as an integer variable
            int selectedElement = (int)listBox1.SelectedItems[0];
            // make the edit text box visible
            textBoxEdit.Visible = true;
            btn_Save.Visible = true;
            lbl_edit_value.Visible = true;
            //display the selected element in the edit text box
            textBoxEdit.Text = (selectedElement.ToString());
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            int.TryParse(textBoxEdit.Text, out int newValue);
            // check that an element from the list has been selected
            // to prevent out-of-range error
            if (selectedIndex > -1)
            {
                // update the lst_astro_data with the edited element
                lst_astro_data[selectedIndex] = newValue;
                //
                // reload the listbox with updated values
                // clear contents of the listbox to prevent duplication
                listBox1.Items.Clear();
                // add all elemnts of lst_astro_data to the listbox
                for (int y = 0; y < lst_astro_data.Count; y++)
                {
                    listBox1.Items.Add(lst_astro_data[y]);
                }
                // clear the old value out of the textBoxEdit
                textBoxEdit.Clear();
                textBoxEdit.Visible = false;
                btn_Save.Visible = false;
                lbl_edit_value.Visible = false;
            }
            else
            {
                MessageBox.Show("Select an integer to edit.");
            }
        }

        private void lbl_edit_value_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mid_Extreme_Click(object sender, EventArgs e)
        {
            // check that data has been loaded
            if (lst_astro_data.Count == 0)
            {
                MessageBox.Show("No data to calculate. Please fetch the data first.");
            }
            else
            {
                // get the min value in the list
                decimal minNumber = lst_astro_data.Min();
                // get the max value  in the list
                decimal maxNumber = lst_astro_data.Max();
                // calculate the mid-extreme
                decimal midExtreme = (minNumber + maxNumber) / 2;
                // display the result with two decimal places
                txt_MidExtreme.Text = midExtreme.ToString("F2");
                txt_MidExtreme.Visible = true;
            }
        }

        private void btn_Range_Click(object sender, EventArgs e)
        {
            // check that data has been loaded
            if (lst_astro_data.Count == 0)
            {
                MessageBox.Show("No data to calculate. Please fetch the data first.");
            }
            else
            {
                // get the min value in the list
                decimal minNumber = lst_astro_data.Min();
                // get the max value  in the list
                decimal maxNumber = lst_astro_data.Max();
                // calculate the range
                decimal list_range = maxNumber - minNumber;
                // display the result with two decimal places
                txt_Range.Text = list_range.ToString();
                txt_Range.Visible = true;
            }
        }

        private void btn_Mode_Click(object sender, EventArgs e)
        {
            List<int> modes = FindModes(lst_astro_data);
            txt_Mode.Text = string.Join(", ", modes);
            txt_Mode.Visible = true;
        }

        private void btn_Average_Click(object sender, EventArgs e)
        {
            // check that data has been loaded
            if (lst_astro_data.Count == 0)
            {
                MessageBox.Show("No data to calculate. Please fetch the data first.");
            }
            else
            {
                txt_Average.Text = lst_astro_data.Average().ToString("F2");
                txt_Average.Visible = true;
            }
        }
        static List<int> FindModes(List<int> lst_astro_data)
        {
            // Dictionary to store the frequency of each number
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            // Fill the frequency dictionary
            foreach (int number in lst_astro_data)
            {
                if (frequency.ContainsKey(number))
                {
                    frequency[number]++;
                }
                else
                {
                    frequency[number] = 1;
                }
            }

            // Find the maximum frequency
            int maxCount = frequency.Values.Max();

            // Find all numbers with the maximum frequency
            List<int> modes = frequency.Where(kvp => kvp.Value == maxCount)
                                        .Select(kvp => kvp.Key)
                                        .ToList();

            return modes;
        }
        static int SequentialSearch(List<int> list, int target)
        {
            // Iterate through the list to find the target
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == target)
                {
                    return i; // Return the index if the target is found
                }
            }

            return -1; // Return -1 if the target is not found
        }

        private void btn_SequentialSearch_Click(object sender, EventArgs e)
        {
            // check that data has been loaded
            if (lst_astro_data.Count == 0)
            {
                MessageBox.Show("No data to search. Please fetch the data first.");
                txt_SequentialSearch.Clear();
            }
            else
            {
                List<int> numbers = lst_astro_data;
                int target = -1;
                if (int.TryParse(txt_SequentialSearch.Text, out target))
                {
                    int index = SequentialSearch(numbers, target);

                    if (index != -1)
                    {
                        MessageBox.Show($"Target {target} found at index {index}.");
                        txt_SequentialSearch.Clear();
                    }
                    else
                    {
                        MessageBox.Show($"Target {target} not found in the list.");
                        txt_SequentialSearch.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please eneter an integer.");
                }
            }
        }
    }
}


