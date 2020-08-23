namespace Assignment5p
{
    partial class SelectForm
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
            this.hardwareselection = new System.Windows.Forms.Label();
            this.selection = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hardwareselection
            // 
            this.hardwareselection.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hardwareselection.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F);
            this.hardwareselection.Location = new System.Drawing.Point(52, 27);
            this.hardwareselection.Name = "hardwareselection";
            this.hardwareselection.Size = new System.Drawing.Size(703, 53);
            this.hardwareselection.TabIndex = 0;
            this.hardwareselection.Text = "Hardware Selection";
            // 
            // selection
            // 
            this.selection.AutoSize = true;
            this.selection.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.selection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selection.Location = new System.Drawing.Point(170, 373);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(139, 25);
            this.selection.TabIndex = 1;
            this.selection.Text = "Your Selection";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(463, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(623, 357);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(118, 36);
            this.Next.TabIndex = 3;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.selection);
            this.Controls.Add(this.hardwareselection);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hardwareselection;
        private System.Windows.Forms.Label selection;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button button2;
    }
}