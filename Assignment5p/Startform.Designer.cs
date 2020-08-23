namespace Assignment5p
{
    partial class Startform
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
            this.startneworder = new System.Windows.Forms.Button();
            this.loadorder = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // startneworder
            // 
            this.startneworder.Location = new System.Drawing.Point(128, 215);
            this.startneworder.Name = "startneworder";
            this.startneworder.Size = new System.Drawing.Size(125, 49);
            this.startneworder.TabIndex = 0;
            this.startneworder.Text = "Start New Order";
            this.startneworder.UseVisualStyleBackColor = true;
            this.startneworder.Click += new System.EventHandler(this.startneworder_Click);
            // 
            // loadorder
            // 
            this.loadorder.Location = new System.Drawing.Point(128, 296);
            this.loadorder.Name = "loadorder";
            this.loadorder.Size = new System.Drawing.Size(125, 45);
            this.loadorder.TabIndex = 1;
            this.loadorder.Text = "Load Saved Order";
            this.loadorder.UseVisualStyleBackColor = true;
            this.loadorder.Click += new System.EventHandler(this.loadorder_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(128, 372);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(125, 41);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Assignment5p.Properties.Resources.image_450w_138951182;
            this.pictureBox2.Location = new System.Drawing.Point(1, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(465, 187);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Startform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.loadorder);
            this.Controls.Add(this.startneworder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Startform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
      


        private System.Windows.Forms.Button startneworder;

        private System.Windows.Forms.Button loadorder;

        private System.Windows.Forms.Button Exit;

        private System.Windows.Forms.PictureBox pictureBox2;
    }
}