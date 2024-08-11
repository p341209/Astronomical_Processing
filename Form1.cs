using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Astronomical_Processing
{
    public partial class Form1 : Form

    {
        // Create an integer list with 24 elements, available to all functions
        List<int> lst_astro_data = new List<int>() { 10, 20, 30, 40, 11, 21, 31, 41, 12, 22, 32, 42, 13, 23, 33, 43, 14, 24, 34, 44, 15, 25, 35, 45, };
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
    }
}
