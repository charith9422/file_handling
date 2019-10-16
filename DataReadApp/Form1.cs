using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataReadApp
{
    public partial class Form1 : Form
    {
        string path = @"C:\Users\DSP\source\repos\DataReadApp\DataReadApp\Data\StudentDetails.txt";
        public Form1()
        {
            InitializeComponent();
            ReadFile();
            
        }

        

        public void WriteData(string id) {


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Submit_Click(object sender, EventArgs e)
        {
            string input_registration_no = reg_no.Text;
            string input_name = name.Text;
            string input_age = age.Text;
            string input_district = district.Text;
            string input_province = province.Text;
            string input_course_code = course_code.Text;
            string input_course = course.Text;

            
         
            string[] lines = { input_registration_no, input_name, input_age, input_district, input_province, input_course_code, input_course };
            if (!File.Exists(path))
            {
               
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    /*for (int i = 0; i < lines.Length; i++)
                    {
                        if(isDoneLine)
                        sw.Write(lines[i] + delimiter);
                        ClearFields(reg_no, name, age, district, province, course_code, course);

                    }*/
                    ClearFields(reg_no, name, age, district, province, course_code, course);
                    sw.Write(input_registration_no + "," + input_name + "," + input_age + "," + input_district + "," + input_province + "," + input_course_code +","+input_course+"\n");
                  
                    MessageBox.Show("Data added!");
                }
            }


            using (StreamWriter sw = File.AppendText(path))
            {

                /*for (int i = 0; i < lines.Length; i++)
                {
                    sw.Write(lines[i]+ delimiter);
                    
                    ClearFields(reg_no,name,age,district,province,course_code,course);  
                    
                }*/
                ClearFields(reg_no, name, age, district, province, course_code, course);
                sw.Write(input_registration_no + "," + input_name + "," + input_age + "," + input_district + "," + input_province + "," + input_course_code + "," + input_course+"\n");
                MessageBox.Show("Data added!");
            }

            // Open the file to read from.
            



        }
        private string[] Splitter(string input)
        {
            return Regex.Split(input, @"\W+");
        }

        public void ReadFile() {
            
           
        }

        
        public void ClearFields(TextBox id, TextBox name, TextBox age, TextBox district, TextBox province, TextBox course_code, TextBox course) {

            id.Text = "";
            name.Text = "";
            age.Text = "";
            district.Text = "";
            province.Text = "";
            course_code.Text = "";
            course.Text = "";
        }
        public void DisplayData(string[] data) {
            show_all_grid.ColumnCount = 7;
            show_all_grid.Columns[0].Name = "Student Reg No";
            show_all_grid.Columns[1].Name = "Name";
            show_all_grid.Columns[2].Name = "Age";
            show_all_grid.Columns[3].Name = "District";
            show_all_grid.Columns[4].Name = "Province";
            show_all_grid.Columns[5].Name = "Course Code";
            show_all_grid.Columns[6].Name = "Course";

            string[] row = new string[100];
            
            show_all_grid.Rows.Add(row);
        }
        private void view_records_Click(object sender, EventArgs e)
        {
            ReadFile();

        }
    }
}
