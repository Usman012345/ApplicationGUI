
namespace project_GUI
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.check_expiry = new System.Windows.Forms.Button();
            this.remove_medicine = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Print_medicine = new System.Windows.Forms.Button();
            this.add_employee = new System.Windows.Forms.Button();
            this.print_employee = new System.Windows.Forms.Button();
            this.print_employee_requested_medicine = new System.Windows.Forms.Button();
            this.remove_employee = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(190, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add medicine record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // check_expiry
            // 
            this.check_expiry.BackColor = System.Drawing.Color.Lime;
            this.check_expiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_expiry.Location = new System.Drawing.Point(190, 204);
            this.check_expiry.Name = "check_expiry";
            this.check_expiry.Size = new System.Drawing.Size(163, 34);
            this.check_expiry.TabIndex = 0;
            this.check_expiry.Text = "check expiry";
            this.check_expiry.UseVisualStyleBackColor = false;
            this.check_expiry.Click += new System.EventHandler(this.check_expiry_Click);
            // 
            // remove_medicine
            // 
            this.remove_medicine.BackColor = System.Drawing.Color.Silver;
            this.remove_medicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_medicine.Location = new System.Drawing.Point(190, 268);
            this.remove_medicine.Name = "remove_medicine";
            this.remove_medicine.Size = new System.Drawing.Size(201, 32);
            this.remove_medicine.TabIndex = 0;
            this.remove_medicine.Text = "Remove medicine";
            this.remove_medicine.UseVisualStyleBackColor = false;
            this.remove_medicine.Click += new System.EventHandler(this.remove_medicine_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(445, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Print_medicine
            // 
            this.Print_medicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Print_medicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_medicine.Location = new System.Drawing.Point(190, 146);
            this.Print_medicine.Name = "Print_medicine";
            this.Print_medicine.Size = new System.Drawing.Size(163, 34);
            this.Print_medicine.TabIndex = 0;
            this.Print_medicine.Text = "Print medicine record";
            this.Print_medicine.UseVisualStyleBackColor = false;
            this.Print_medicine.Click += new System.EventHandler(this.Print_medicine_Click);
            // 
            // add_employee
            // 
            this.add_employee.BackColor = System.Drawing.Color.Yellow;
            this.add_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_employee.Location = new System.Drawing.Point(445, 91);
            this.add_employee.Name = "add_employee";
            this.add_employee.Size = new System.Drawing.Size(154, 35);
            this.add_employee.TabIndex = 0;
            this.add_employee.Text = "Add Employee";
            this.add_employee.UseVisualStyleBackColor = false;
            this.add_employee.Click += new System.EventHandler(this.add_employee_Click);
            // 
            // print_employee
            // 
            this.print_employee.BackColor = System.Drawing.Color.IndianRed;
            this.print_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_employee.Location = new System.Drawing.Point(445, 146);
            this.print_employee.Name = "print_employee";
            this.print_employee.Size = new System.Drawing.Size(154, 34);
            this.print_employee.TabIndex = 0;
            this.print_employee.Text = "Print employee record";
            this.print_employee.UseVisualStyleBackColor = false;
            this.print_employee.Click += new System.EventHandler(this.print_employee_Click);
            // 
            // print_employee_requested_medicine
            // 
            this.print_employee_requested_medicine.BackColor = System.Drawing.Color.Fuchsia;
            this.print_employee_requested_medicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_employee_requested_medicine.Location = new System.Drawing.Point(445, 204);
            this.print_employee_requested_medicine.Name = "print_employee_requested_medicine";
            this.print_employee_requested_medicine.Size = new System.Drawing.Size(320, 34);
            this.print_employee_requested_medicine.TabIndex = 0;
            this.print_employee_requested_medicine.Text = "print employee requested medicine";
            this.print_employee_requested_medicine.UseVisualStyleBackColor = false;
            this.print_employee_requested_medicine.Click += new System.EventHandler(this.print_employee_requested_medicine_Click);
            // 
            // remove_employee
            // 
            this.remove_employee.BackColor = System.Drawing.Color.OrangeRed;
            this.remove_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_employee.Location = new System.Drawing.Point(445, 268);
            this.remove_employee.Name = "remove_employee";
            this.remove_employee.Size = new System.Drawing.Size(188, 32);
            this.remove_employee.TabIndex = 0;
            this.remove_employee.Text = "Remove employee";
            this.remove_employee.UseVisualStyleBackColor = false;
            this.remove_employee.Click += new System.EventHandler(this.remove_employee_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Black;
            this.Back.Location = new System.Drawing.Point(769, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(32, 32);
            this.Back.TabIndex = 6;
            this.Back.Text = "X";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::project_GUI.Properties.Resources.Admin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.add_employee);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.remove_employee);
            this.Controls.Add(this.remove_medicine);
            this.Controls.Add(this.print_employee);
            this.Controls.Add(this.Print_medicine);
            this.Controls.Add(this.print_employee_requested_medicine);
            this.Controls.Add(this.check_expiry);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button check_expiry;
        private System.Windows.Forms.Button remove_medicine;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Print_medicine;
        private System.Windows.Forms.Button add_employee;
        private System.Windows.Forms.Button print_employee;
        private System.Windows.Forms.Button print_employee_requested_medicine;
        private System.Windows.Forms.Button remove_employee;
        private System.Windows.Forms.Button Back;
    }
}