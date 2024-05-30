
namespace WindowsFormsApp1
{
    partial class OperatorBasic
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
            this.lblN1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblN2 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDivider = new System.Windows.Forms.Button();
            this.btnMultiplic = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(321, 56);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(53, 13);
            this.lblN1.TabIndex = 0;
            this.lblN1.Text = "Number 1";
            this.lblN1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(406, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(425, 56);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(53, 13);
            this.lblN2.TabIndex = 2;
            this.lblN2.Text = "Number 2";
            this.lblN2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(312, 109);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "Soma";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(412, 109);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 23);
            this.btnSubtract.TabIndex = 5;
            this.btnSubtract.Text = "Subtrair";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnDivider
            // 
            this.btnDivider.Location = new System.Drawing.Point(312, 154);
            this.btnDivider.Name = "btnDivider";
            this.btnDivider.Size = new System.Drawing.Size(75, 23);
            this.btnDivider.TabIndex = 6;
            this.btnDivider.Text = "Dividir";
            this.btnDivider.UseVisualStyleBackColor = true;
            this.btnDivider.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMultiplic
            // 
            this.btnMultiplic.Location = new System.Drawing.Point(412, 154);
            this.btnMultiplic.Name = "btnMultiplic";
            this.btnMultiplic.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplic.TabIndex = 7;
            this.btnMultiplic.Text = "Multiplicar ";
            this.btnMultiplic.UseVisualStyleBackColor = true;
            this.btnMultiplic.Click += new System.EventHandler(this.btnMultiplic_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(349, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(361, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // OperatorBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 363);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnMultiplic);
            this.Controls.Add(this.btnDivider);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblN1);
            this.Name = "OperatorBasic";
            this.Text = "OperatorBasic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnDivider;
        private System.Windows.Forms.Button btnMultiplic;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnClear;
    }
}