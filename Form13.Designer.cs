
namespace project_GUI
{
    partial class Form13
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
            this.Medicinea = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Buy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Prepare_bill = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Medicinea
            // 
            this.Medicinea.AutoSize = true;
            this.Medicinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medicinea.Location = new System.Drawing.Point(95, 38);
            this.Medicinea.Name = "Medicinea";
            this.Medicinea.Size = new System.Drawing.Size(88, 24);
            this.Medicinea.TabIndex = 0;
            this.Medicinea.Text = "Medicine";
            this.Medicinea.Click += new System.EventHandler(this.Medicinea_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Buy
            // 
            this.Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy.Location = new System.Drawing.Point(258, 141);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(85, 31);
            this.Buy.TabIndex = 2;
            this.Buy.Text = "Buy";
            this.Buy.UseVisualStyleBackColor = true;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 210);
            this.dataGridView1.TabIndex = 3;
            // 
            // Prepare_bill
            // 
            this.Prepare_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prepare_bill.Location = new System.Drawing.Point(533, 12);
            this.Prepare_bill.Name = "Prepare_bill";
            this.Prepare_bill.Size = new System.Drawing.Size(137, 31);
            this.Prepare_bill.TabIndex = 4;
            this.Prepare_bill.Text = "Prepare bill";
            this.Prepare_bill.UseVisualStyleBackColor = true;
            this.Prepare_bill.Click += new System.EventHandler(this.Prepare_bill_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Black;
            this.Back.Location = new System.Drawing.Point(687, -1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(32, 32);
            this.Back.TabIndex = 6;
            this.Back.Text = "X";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(340, 38);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(78, 24);
            this.Quantity.TabIndex = 7;
            this.Quantity.Text = "Quantity";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(387, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_GUI.Properties.Resources.employee;
            this.ClientSize = new System.Drawing.Size(720, 387);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Prepare_bill);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Medicinea);
            this.Name = "Form13";
            this.Text = "Form13";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Medicinea;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Prepare_bill;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox textBox2;
    }
}