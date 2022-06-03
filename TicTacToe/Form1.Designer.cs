namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_1 = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_1
            // 
            this.Btn_1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_1.Location = new System.Drawing.Point(58, 37);
            this.Btn_1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(149, 59);
            this.Btn_1.TabIndex = 0;
            this.Btn_1.UseVisualStyleBackColor = false;
            // 
            // Btn_2
            // 
            this.Btn_2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_2.Location = new System.Drawing.Point(58, 103);
            this.Btn_2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(149, 59);
            this.Btn_2.TabIndex = 1;
            this.Btn_2.UseVisualStyleBackColor = false;
            // 
            // Btn_3
            // 
            this.Btn_3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_3.Location = new System.Drawing.Point(58, 168);
            this.Btn_3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(149, 59);
            this.Btn_3.TabIndex = 2;
            this.Btn_3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 404);
            this.Controls.Add(this.Btn_3);
            this.Controls.Add(this.Btn_2);
            this.Controls.Add(this.Btn_1);
            this.Font = new System.Drawing.Font("Swis721 BlkEx BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_1;
        private Button Btn_2;
        private Button Btn_3;
    }
}