
namespace project_GUI
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
            this.Sign_UP = new System.Windows.Forms.Button();
            this.Sign_IN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sign_UP
            // 
            this.Sign_UP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_UP.Location = new System.Drawing.Point(461, 325);
            this.Sign_UP.Name = "Sign_UP";
            this.Sign_UP.Size = new System.Drawing.Size(103, 37);
            this.Sign_UP.TabIndex = 0;
            this.Sign_UP.Text = "Sign_UP";
            this.Sign_UP.UseVisualStyleBackColor = true;
            this.Sign_UP.Click += new System.EventHandler(this.Sign_UP_Click);
            // 
            // Sign_IN
            // 
            this.Sign_IN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_IN.Location = new System.Drawing.Point(317, 325);
            this.Sign_IN.Name = "Sign_IN";
            this.Sign_IN.Size = new System.Drawing.Size(90, 37);
            this.Sign_IN.TabIndex = 0;
            this.Sign_IN.Text = "Sign_IN";
            this.Sign_IN.UseVisualStyleBackColor = true;
            this.Sign_IN.Click += new System.EventHandler(this.Sign_IN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_GUI.Properties.Resources.Pharmacy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sign_IN);
            this.Controls.Add(this.Sign_UP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sign_UP;
        private System.Windows.Forms.Button Sign_IN;
    }
}

