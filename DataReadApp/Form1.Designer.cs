namespace DataReadApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reg_no = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.district = new System.Windows.Forms.TextBox();
            this.province = new System.Windows.Forms.TextBox();
            this.course_code = new System.Windows.Forms.TextBox();
            this.course = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.show_all_grid = new System.Windows.Forms.DataGridView();
            this.view_records = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.show_all_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reg.No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "District";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Province";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Course Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Course";
            // 
            // reg_no
            // 
            this.reg_no.Location = new System.Drawing.Point(100, 46);
            this.reg_no.Name = "reg_no";
            this.reg_no.Size = new System.Drawing.Size(100, 20);
            this.reg_no.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(100, 83);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 9;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(100, 121);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 20);
            this.age.TabIndex = 10;
            // 
            // district
            // 
            this.district.Location = new System.Drawing.Point(100, 155);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(100, 20);
            this.district.TabIndex = 11;
            // 
            // province
            // 
            this.province.Location = new System.Drawing.Point(100, 186);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(100, 20);
            this.province.TabIndex = 12;
            // 
            // course_code
            // 
            this.course_code.Location = new System.Drawing.Point(100, 218);
            this.course_code.Name = "course_code";
            this.course_code.Size = new System.Drawing.Size(100, 20);
            this.course_code.TabIndex = 13;
            // 
            // course
            // 
            this.course.Location = new System.Drawing.Point(100, 262);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(100, 20);
            this.course.TabIndex = 14;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(100, 311);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(100, 23);
            this.submit.TabIndex = 15;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.TextChanged += new System.EventHandler(this.Submit_Click);
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // show_all_grid
            // 
            this.show_all_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_all_grid.Location = new System.Drawing.Point(206, 42);
            this.show_all_grid.Name = "show_all_grid";
            this.show_all_grid.Size = new System.Drawing.Size(743, 240);
            this.show_all_grid.TabIndex = 16;
            this.show_all_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show_all_grid_CellContentClick);
            // 
            // view_records
            // 
            this.view_records.Location = new System.Drawing.Point(206, 12);
            this.view_records.Name = "view_records";
            this.view_records.Size = new System.Drawing.Size(116, 23);
            this.view_records.TabIndex = 17;
            this.view_records.Text = "Refresh";
            this.view_records.UseVisualStyleBackColor = true;
            this.view_records.Click += new System.EventHandler(this.view_records_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.view_records);
            this.Controls.Add(this.show_all_grid);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.course);
            this.Controls.Add(this.course_code);
            this.Controls.Add(this.province);
            this.Controls.Add(this.district);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Controls.Add(this.reg_no);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.show_all_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reg_no;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox district;
        private System.Windows.Forms.TextBox province;
        private System.Windows.Forms.TextBox course_code;
        private System.Windows.Forms.TextBox course;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.DataGridView show_all_grid;
        private System.Windows.Forms.Button view_records;
    }
}

