﻿namespace Astronomical_Processing
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
            lbl_Page_Heading = new Label();
            txt_Search_dataList = new TextBox();
            btn_Write_File = new Button();
            lbl_Search_dataList = new Label();
            lbl_Write_File = new Label();
            lbl_show_list = new Label();
            btn_show_data = new Button();
            btn_sort_data = new Button();
            lbl_sort_data = new Label();
            btn_fetch_data = new Button();
            lbl_fetch_data = new Label();
            btn_binary_search = new Button();
            SuspendLayout();
            // 
            // lbl_Page_Heading
            // 
            lbl_Page_Heading.AutoSize = true;
            lbl_Page_Heading.Location = new Point(252, 27);
            lbl_Page_Heading.Name = "lbl_Page_Heading";
            lbl_Page_Heading.Size = new Size(138, 15);
            lbl_Page_Heading.TabIndex = 0;
            lbl_Page_Heading.Text = "Astronomical Processing";
            lbl_Page_Heading.Click += lbl_Page_Heading_Click;
            // 
            // txt_Search_dataList
            // 
            txt_Search_dataList.Location = new Point(271, 113);
            txt_Search_dataList.Name = "txt_Search_dataList";
            txt_Search_dataList.Size = new Size(100, 23);
            txt_Search_dataList.TabIndex = 1;
            txt_Search_dataList.TextChanged += txt_Search_dataList_TextChanged;
            // 
            // btn_Write_File
            // 
            btn_Write_File.Location = new Point(271, 165);
            btn_Write_File.Name = "btn_Write_File";
            btn_Write_File.Size = new Size(100, 23);
            btn_Write_File.TabIndex = 2;
            btn_Write_File.Text = "Write File";
            btn_Write_File.UseVisualStyleBackColor = true;
            btn_Write_File.Click += btn_Write_File_Click;
            // 
            // lbl_Search_dataList
            // 
            lbl_Search_dataList.AutoSize = true;
            lbl_Search_dataList.Location = new Point(103, 116);
            lbl_Search_dataList.Name = "lbl_Search_dataList";
            lbl_Search_dataList.Size = new Size(162, 15);
            lbl_Search_dataList.TabIndex = 3;
            lbl_Search_dataList.Text = "Enter an integer to search for:";
            lbl_Search_dataList.Click += lbl_Search_dataList_Click;
            // 
            // lbl_Write_File
            // 
            lbl_Write_File.AutoSize = true;
            lbl_Write_File.Location = new Point(116, 173);
            lbl_Write_File.Name = "lbl_Write_File";
            lbl_Write_File.Size = new Size(149, 15);
            lbl_Write_File.TabIndex = 4;
            lbl_Write_File.Text = "Write the data to a text file:";
            lbl_Write_File.Click += lbl_Write_File_Click;
            // 
            // lbl_show_list
            // 
            lbl_show_list.AutoSize = true;
            lbl_show_list.Location = new Point(185, 223);
            lbl_show_list.Name = "lbl_show_list";
            lbl_show_list.Size = new Size(80, 15);
            lbl_show_list.TabIndex = 6;
            lbl_show_list.Text = "Show all data:";
            // 
            // btn_show_data
            // 
            btn_show_data.Location = new Point(271, 215);
            btn_show_data.Name = "btn_show_data";
            btn_show_data.Size = new Size(100, 23);
            btn_show_data.TabIndex = 7;
            btn_show_data.Text = "Show Data";
            btn_show_data.UseVisualStyleBackColor = true;
            btn_show_data.Click += btn_show_data_Click;
            // 
            // btn_sort_data
            // 
            btn_sort_data.Location = new Point(271, 267);
            btn_sort_data.Name = "btn_sort_data";
            btn_sort_data.Size = new Size(100, 23);
            btn_sort_data.TabIndex = 8;
            btn_sort_data.Text = "Sort Data";
            btn_sort_data.UseVisualStyleBackColor = true;
            btn_sort_data.Click += btn_sort_data_Click;
            // 
            // lbl_sort_data
            // 
            lbl_sort_data.AutoSize = true;
            lbl_sort_data.Location = new Point(185, 271);
            lbl_sort_data.Name = "lbl_sort_data";
            lbl_sort_data.Size = new Size(77, 15);
            lbl_sort_data.TabIndex = 9;
            lbl_sort_data.Text = "Sort the data:";
            // 
            // btn_fetch_data
            // 
            btn_fetch_data.Location = new Point(271, 63);
            btn_fetch_data.Name = "btn_fetch_data";
            btn_fetch_data.Size = new Size(100, 23);
            btn_fetch_data.TabIndex = 10;
            btn_fetch_data.Text = "Fetch Data";
            btn_fetch_data.UseVisualStyleBackColor = true;
            btn_fetch_data.Click += btn_fetch_data_Click;
            // 
            // lbl_fetch_data
            // 
            lbl_fetch_data.AutoSize = true;
            lbl_fetch_data.Location = new Point(177, 67);
            lbl_fetch_data.Name = "lbl_fetch_data";
            lbl_fetch_data.Size = new Size(85, 15);
            lbl_fetch_data.TabIndex = 11;
            lbl_fetch_data.Text = "Fetch the data:";
            // 
            // btn_binary_search
            // 
            btn_binary_search.Location = new Point(398, 112);
            btn_binary_search.Name = "btn_binary_search";
            btn_binary_search.Size = new Size(75, 23);
            btn_binary_search.TabIndex = 12;
            btn_binary_search.Text = "Search";
            btn_binary_search.UseVisualStyleBackColor = true;
            btn_binary_search.Click += btn_binary_search_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(620, 359);
            Controls.Add(btn_binary_search);
            Controls.Add(lbl_fetch_data);
            Controls.Add(btn_fetch_data);
            Controls.Add(lbl_sort_data);
            Controls.Add(btn_sort_data);
            Controls.Add(btn_show_data);
            Controls.Add(lbl_show_list);
            Controls.Add(lbl_Write_File);
            Controls.Add(lbl_Search_dataList);
            Controls.Add(btn_Write_File);
            Controls.Add(txt_Search_dataList);
            Controls.Add(lbl_Page_Heading);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Astronomical Processing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Page_Heading;
        private TextBox txt_Search_dataList;
        private Button btn_Write_File;
        private Label lbl_Search_dataList;
        private Label lbl_Write_File;
        private Label lbl_show_list;
        private Button btn_show_data;
        private Button btn_sort_data;
        private Label lbl_sort_data;
        private Button btn_fetch_data;
        private Label lbl_fetch_data;
        private Button btn_binary_search;
    }
}
