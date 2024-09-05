namespace Astronomical_Processing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_Page_Heading = new Label();
            txt_Search_dataList = new TextBox();
            btn_Write_File = new Button();
            lbl_Search_dataList = new Label();
            lbl_Write_File = new Label();
            btn_sort_data = new Button();
            lbl_sort_data = new Label();
            btn_fetch_data = new Button();
            lbl_fetch_data = new Label();
            btn_binary_search = new Button();
            listBox1 = new ListBox();
            textBoxEdit = new TextBox();
            btn_Save = new Button();
            lbl_edit_value = new Label();
            btn_Mid_Extreme = new Button();
            lbl_Mid_Extreme = new Label();
            txt_MidExtreme = new TextBox();
            toolTip1 = new ToolTip(components);
            txt_Mode = new TextBox();
            lbl_Mode = new Label();
            btn_Range = new Button();
            lbl_Range = new Label();
            txt_Range = new TextBox();
            btn_SequentialSearch = new Button();
            lbl_SequentialSearch = new Label();
            btn_Mode = new Button();
            btn_Average = new Button();
            lbl_Average = new Label();
            txt_Average = new TextBox();
            SuspendLayout();
            // 
            // lbl_Page_Heading
            // 
            lbl_Page_Heading.AutoSize = true;
            lbl_Page_Heading.Location = new Point(174, 22);
            lbl_Page_Heading.Name = "lbl_Page_Heading";
            lbl_Page_Heading.Size = new Size(138, 15);
            lbl_Page_Heading.TabIndex = 0;
            lbl_Page_Heading.Text = "Astronomical Processing";
            lbl_Page_Heading.Click += lbl_Page_Heading_Click;
            // 
            // txt_Search_dataList
            // 
            txt_Search_dataList.Location = new Point(120, 146);
            txt_Search_dataList.Name = "txt_Search_dataList";
            txt_Search_dataList.Size = new Size(34, 23);
            txt_Search_dataList.TabIndex = 3;
            txt_Search_dataList.TextChanged += txt_Search_dataList_TextChanged;
            // 
            // btn_Write_File
            // 
            btn_Write_File.Location = new Point(163, 407);
            btn_Write_File.Name = "btn_Write_File";
            btn_Write_File.Size = new Size(95, 23);
            btn_Write_File.TabIndex = 5;
            btn_Write_File.Text = "Write File";
            btn_Write_File.UseVisualStyleBackColor = true;
            btn_Write_File.Click += btn_Write_File_Click;
            // 
            // lbl_Search_dataList
            // 
            lbl_Search_dataList.AutoSize = true;
            lbl_Search_dataList.Location = new Point(51, 149);
            lbl_Search_dataList.Name = "lbl_Search_dataList";
            lbl_Search_dataList.Size = new Size(63, 15);
            lbl_Search_dataList.TabIndex = 3;
            lbl_Search_dataList.Text = "Search for:";
            lbl_Search_dataList.Click += lbl_Search_dataList_Click;
            // 
            // lbl_Write_File
            // 
            lbl_Write_File.AutoSize = true;
            lbl_Write_File.Location = new Point(5, 411);
            lbl_Write_File.Name = "lbl_Write_File";
            lbl_Write_File.Size = new Size(149, 15);
            lbl_Write_File.TabIndex = 4;
            lbl_Write_File.Text = "Write the data to a text file:";
            lbl_Write_File.Click += lbl_Write_File_Click;
            // 
            // btn_sort_data
            // 
            btn_sort_data.Location = new Point(163, 102);
            btn_sort_data.Name = "btn_sort_data";
            btn_sort_data.Size = new Size(95, 23);
            btn_sort_data.TabIndex = 2;
            btn_sort_data.Text = "Sort Data";
            btn_sort_data.UseVisualStyleBackColor = true;
            btn_sort_data.Click += btn_sort_data_Click;
            // 
            // lbl_sort_data
            // 
            lbl_sort_data.AutoSize = true;
            lbl_sort_data.Location = new Point(77, 106);
            lbl_sort_data.Name = "lbl_sort_data";
            lbl_sort_data.Size = new Size(77, 15);
            lbl_sort_data.TabIndex = 9;
            lbl_sort_data.Text = "Sort the data:";
            // 
            // btn_fetch_data
            // 
            btn_fetch_data.Location = new Point(163, 60);
            btn_fetch_data.Name = "btn_fetch_data";
            btn_fetch_data.Size = new Size(95, 23);
            btn_fetch_data.TabIndex = 1;
            btn_fetch_data.Text = "Fetch Data";
            toolTip1.SetToolTip(btn_fetch_data, "Loads the data stream into this program.");
            btn_fetch_data.UseVisualStyleBackColor = true;
            btn_fetch_data.Click += btn_fetch_data_Click;
            // 
            // lbl_fetch_data
            // 
            lbl_fetch_data.AutoSize = true;
            lbl_fetch_data.Location = new Point(64, 64);
            lbl_fetch_data.Name = "lbl_fetch_data";
            lbl_fetch_data.Size = new Size(85, 15);
            lbl_fetch_data.TabIndex = 11;
            lbl_fetch_data.Text = "Fetch the data:";
            // 
            // btn_binary_search
            // 
            btn_binary_search.Location = new Point(163, 145);
            btn_binary_search.Name = "btn_binary_search";
            btn_binary_search.Size = new Size(95, 23);
            btn_binary_search.TabIndex = 4;
            btn_binary_search.Text = "Search";
            btn_binary_search.UseVisualStyleBackColor = true;
            btn_binary_search.Click += btn_binary_search_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(313, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(71, 319);
            listBox1.TabIndex = 13;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBoxEdit
            // 
            textBoxEdit.Location = new Point(428, 100);
            textBoxEdit.Name = "textBoxEdit";
            textBoxEdit.Size = new Size(26, 23);
            textBoxEdit.TabIndex = 14;
            textBoxEdit.Visible = false;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(402, 145);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 45);
            btn_Save.TabIndex = 15;
            btn_Save.Text = "Save Change";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Visible = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // lbl_edit_value
            // 
            lbl_edit_value.AutoSize = true;
            lbl_edit_value.Location = new Point(402, 65);
            lbl_edit_value.Name = "lbl_edit_value";
            lbl_edit_value.Size = new Size(76, 15);
            lbl_edit_value.TabIndex = 16;
            lbl_edit_value.Text = "Edit the data:";
            lbl_edit_value.Visible = false;
            lbl_edit_value.Click += lbl_edit_value_Click;
            // 
            // btn_Mid_Extreme
            // 
            btn_Mid_Extreme.Location = new Point(163, 190);
            btn_Mid_Extreme.Name = "btn_Mid_Extreme";
            btn_Mid_Extreme.Size = new Size(95, 23);
            btn_Mid_Extreme.TabIndex = 17;
            btn_Mid_Extreme.Text = "Mid-Extreme";
            btn_Mid_Extreme.UseVisualStyleBackColor = true;
            btn_Mid_Extreme.Click += btn_Mid_Extreme_Click;
            // 
            // lbl_Mid_Extreme
            // 
            lbl_Mid_Extreme.AutoSize = true;
            lbl_Mid_Extreme.Location = new Point(10, 194);
            lbl_Mid_Extreme.Name = "lbl_Mid_Extreme";
            lbl_Mid_Extreme.Size = new Size(148, 15);
            lbl_Mid_Extreme.TabIndex = 18;
            lbl_Mid_Extreme.Text = "Calculate the mid-extreme";
            lbl_Mid_Extreme.Click += label1_Click;
            // 
            // txt_MidExtreme
            // 
            txt_MidExtreme.Location = new Point(268, 191);
            txt_MidExtreme.Name = "txt_MidExtreme";
            txt_MidExtreme.Size = new Size(39, 23);
            txt_MidExtreme.TabIndex = 19;
            // 
            // txt_Mode
            // 
            txt_Mode.Location = new Point(268, 227);
            txt_Mode.Name = "txt_Mode";
            txt_Mode.Size = new Size(39, 23);
            txt_Mode.TabIndex = 21;
            // 
            // lbl_Mode
            // 
            lbl_Mode.AutoSize = true;
            lbl_Mode.Location = new Point(46, 233);
            lbl_Mode.Name = "lbl_Mode";
            lbl_Mode.Size = new Size(110, 15);
            lbl_Mode.TabIndex = 22;
            lbl_Mode.Text = "Calculate the mode";
            // 
            // btn_Range
            // 
            btn_Range.Location = new Point(163, 317);
            btn_Range.Name = "btn_Range";
            btn_Range.Size = new Size(95, 23);
            btn_Range.TabIndex = 23;
            btn_Range.Text = "Range";
            btn_Range.UseVisualStyleBackColor = true;
            btn_Range.Click += btn_Range_Click;
            // 
            // lbl_Range
            // 
            lbl_Range.AutoSize = true;
            lbl_Range.Location = new Point(40, 320);
            lbl_Range.Name = "lbl_Range";
            lbl_Range.Size = new Size(109, 15);
            lbl_Range.TabIndex = 24;
            lbl_Range.Text = "Calculate the range";
            // 
            // txt_Range
            // 
            txt_Range.Location = new Point(268, 317);
            txt_Range.Name = "txt_Range";
            txt_Range.Size = new Size(39, 23);
            txt_Range.TabIndex = 25;
            // 
            // btn_SequentialSearch
            // 
            btn_SequentialSearch.Location = new Point(163, 358);
            btn_SequentialSearch.Name = "btn_SequentialSearch";
            btn_SequentialSearch.Size = new Size(97, 23);
            btn_SequentialSearch.TabIndex = 26;
            btn_SequentialSearch.Text = "Search";
            btn_SequentialSearch.UseVisualStyleBackColor = true;
            // 
            // lbl_SequentialSearch
            // 
            lbl_SequentialSearch.AutoSize = true;
            lbl_SequentialSearch.Location = new Point(50, 362);
            lbl_SequentialSearch.Name = "lbl_SequentialSearch";
            lbl_SequentialSearch.Size = new Size(99, 15);
            lbl_SequentialSearch.TabIndex = 27;
            lbl_SequentialSearch.Text = "Sequential search";
            // 
            // btn_Mode
            // 
            btn_Mode.Location = new Point(163, 228);
            btn_Mode.Name = "btn_Mode";
            btn_Mode.Size = new Size(95, 25);
            btn_Mode.TabIndex = 28;
            btn_Mode.Text = "Mode";
            btn_Mode.UseVisualStyleBackColor = true;
            btn_Mode.Click += btn_Mode_Click;
            // 
            // btn_Average
            // 
            btn_Average.Location = new Point(163, 273);
            btn_Average.Name = "btn_Average";
            btn_Average.Size = new Size(97, 23);
            btn_Average.TabIndex = 29;
            btn_Average.Text = "Average";
            btn_Average.UseVisualStyleBackColor = true;
            btn_Average.Click += btn_Average_Click;
            // 
            // lbl_Average
            // 
            lbl_Average.AutoSize = true;
            lbl_Average.Location = new Point(34, 277);
            lbl_Average.Name = "lbl_Average";
            lbl_Average.Size = new Size(120, 15);
            lbl_Average.TabIndex = 30;
            lbl_Average.Text = "Calculate tthe aveage";
            // 
            // txt_Average
            // 
            txt_Average.Location = new Point(266, 274);
            txt_Average.Name = "txt_Average";
            txt_Average.Size = new Size(39, 23);
            txt_Average.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(571, 455);
            Controls.Add(txt_Average);
            Controls.Add(lbl_Average);
            Controls.Add(btn_Average);
            Controls.Add(btn_Mode);
            Controls.Add(lbl_SequentialSearch);
            Controls.Add(btn_SequentialSearch);
            Controls.Add(txt_Range);
            Controls.Add(lbl_Range);
            Controls.Add(btn_Range);
            Controls.Add(lbl_Mode);
            Controls.Add(txt_Mode);
            Controls.Add(txt_MidExtreme);
            Controls.Add(lbl_Mid_Extreme);
            Controls.Add(btn_Mid_Extreme);
            Controls.Add(lbl_edit_value);
            Controls.Add(btn_Save);
            Controls.Add(textBoxEdit);
            Controls.Add(listBox1);
            Controls.Add(btn_binary_search);
            Controls.Add(lbl_fetch_data);
            Controls.Add(btn_fetch_data);
            Controls.Add(lbl_sort_data);
            Controls.Add(btn_sort_data);
            Controls.Add(lbl_Write_File);
            Controls.Add(lbl_Search_dataList);
            Controls.Add(btn_Write_File);
            Controls.Add(txt_Search_dataList);
            Controls.Add(lbl_Page_Heading);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Astronomical Processing";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Page_Heading;
        private TextBox txt_Search_dataList;
        private Button btn_Write_File;
        private Label lbl_Search_dataList;
        private Label lbl_Write_File;
        private Button btn_sort_data;
        private Label lbl_sort_data;
        private Button btn_fetch_data;
        private Label lbl_fetch_data;
        private Button btn_binary_search;
        private ListBox listBox1;
        private TextBox textBoxEdit;
        private Button btn_Save;
        private Label lbl_edit_value;
        private Button btn_Mid_Extreme;
        private Label lbl_Mid_Extreme;
        private TextBox txt_MidExtreme;
        private ToolTip toolTip1;
        private TextBox txt_Mode;
        private Label lbl_Mode;
        private Button btn_Range;
        private Label lbl_Range;
        private TextBox txt_Range;
        private Button btn_SequentialSearch;
        private Label lbl_SequentialSearch;
        private Button btn_Mode;
        private Button btn_Average;
        private Label lbl_Average;
        private TextBox txt_Average;
    }
}
