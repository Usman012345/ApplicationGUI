
namespace project_GUI
{
    partial class Form15
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
            this.Remove = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Medicine = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.Location = new System.Drawing.Point(254, 165);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(104, 36);
            this.Remove.TabIndex = 7;
            this.Remove.Text = "ADD";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(121, 99);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(169, 20);
            this.textBox.TabIndex = 6;
            // 
            // Medicine
            // 
            this.Medicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medicine.Location = new System.Drawing.Point(60, 32);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(125, 35);
            this.Medicine.TabIndex = 5;
            this.Medicine.Text = "Medicine";
            this.Medicine.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Black;
            this.Back.Location = new System.Drawing.Point(355, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(32, 32);
            this.Back.TabIndex = 8;
            this.Back.Text = "X";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_GUI.Properties.Resources.employee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 245);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Medicine);
            this.Name = "Form15";
            this.Text = "Form15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Medicine;
        private System.Windows.Forms.Button Back;
    }
}