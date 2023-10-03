
namespace project_GUI
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.Mark_attendance = new System.Windows.Forms.Button();
            this.Print_record = new System.Windows.Forms.Button();
            this.Edit_prices = new System.Windows.Forms.Button();
            this.Preparebill = new System.Windows.Forms.Button();
            this.new_medicine = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mark_attendance
            // 
            this.Mark_attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mark_attendance.Location = new System.Drawing.Point(59, 119);
            this.Mark_attendance.Name = "Mark_attendance";
            this.Mark_attendance.Size = new System.Drawing.Size(170, 32);
            this.Mark_attendance.TabIndex = 0;
            this.Mark_attendance.Text = "Mark_attendance";
            this.Mark_attendance.UseVisualStyleBackColor = true;
            this.Mark_attendance.Click += new System.EventHandler(this.Mark_attendance_Click);
            // 
            // Print_record
            // 
            this.Print_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_record.Location = new System.Drawing.Point(59, 275);
            this.Print_record.Name = "Print_record";
            this.Print_record.Size = new System.Drawing.Size(170, 33);
            this.Print_record.TabIndex = 0;
            this.Print_record.Text = "Print record";
            this.Print_record.UseVisualStyleBackColor = true;
            this.Print_record.Click += new System.EventHandler(this.Print_record_Click);
            // 
            // Edit_prices
            // 
            this.Edit_prices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_prices.Location = new System.Drawing.Point(59, 348);
            this.Edit_prices.Name = "Edit_prices";
            this.Edit_prices.Size = new System.Drawing.Size(170, 33);
            this.Edit_prices.TabIndex = 0;
            this.Edit_prices.Text = "Edit prices";
            this.Edit_prices.UseVisualStyleBackColor = true;
            this.Edit_prices.Click += new System.EventHandler(this.Edit_prices_Click);
            // 
            // Preparebill
            // 
            this.Preparebill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preparebill.Location = new System.Drawing.Point(59, 195);
            this.Preparebill.Name = "Preparebill";
            this.Preparebill.Size = new System.Drawing.Size(170, 32);
            this.Preparebill.TabIndex = 0;
            this.Preparebill.Text = "Prepare bill";
            this.Preparebill.UseVisualStyleBackColor = true;
            this.Preparebill.Click += new System.EventHandler(this.Preparebill_Click);
            // 
            // new_medicine
            // 
            this.new_medicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_medicine.Location = new System.Drawing.Point(526, 57);
            this.new_medicine.Name = "new_medicine";
            this.new_medicine.Size = new System.Drawing.Size(211, 32);
            this.new_medicine.TabIndex = 0;
            this.new_medicine.Text = "Ask new medicine";
            this.new_medicine.UseVisualStyleBackColor = true;
            this.new_medicine.Click += new System.EventHandler(this.new_medicine_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Black;
            this.Back.Location = new System.Drawing.Point(767, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(32, 32);
            this.Back.TabIndex = 6;
            this.Back.Text = "X";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.new_medicine);
            this.Controls.Add(this.Preparebill);
            this.Controls.Add(this.Edit_prices);
            this.Controls.Add(this.Print_record);
            this.Controls.Add(this.Mark_attendance);
            this.Name = "Form11";
            this.Text = "Form11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mark_attendance;
        private System.Windows.Forms.Button Print_record;
        private System.Windows.Forms.Button Edit_prices;
        private System.Windows.Forms.Button Preparebill;
        private System.Windows.Forms.Button new_medicine;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
    }
}