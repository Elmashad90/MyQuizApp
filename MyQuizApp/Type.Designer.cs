namespace MyQuizApp
{
    partial class Type
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
            this.btnOOP = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnElectric = new System.Windows.Forms.Button();
            this.btnMath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOOP
            // 
            this.btnOOP.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnOOP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.btnOOP.Font = new System.Drawing.Font("Segoe UI", 13.77391F);
            this.btnOOP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnOOP.Location = new System.Drawing.Point(112, 22);
            this.btnOOP.Name = "btnOOP";
            this.btnOOP.Size = new System.Drawing.Size(336, 76);
            this.btnOOP.TabIndex = 0;
            this.btnOOP.Text = "Object Oriented Programming";
            this.btnOOP.UseVisualStyleBackColor = false;
            this.btnOOP.Click += new System.EventHandler(this.btnOOP_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 13.77391F);
            this.btnStatistics.Location = new System.Drawing.Point(112, 268);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(336, 76);
            this.btnStatistics.TabIndex = 1;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnElectric
            // 
            this.btnElectric.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnElectric.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.btnElectric.Font = new System.Drawing.Font("Segoe UI", 13.77391F);
            this.btnElectric.Location = new System.Drawing.Point(112, 186);
            this.btnElectric.Name = "btnElectric";
            this.btnElectric.Size = new System.Drawing.Size(336, 76);
            this.btnElectric.TabIndex = 2;
            this.btnElectric.Text = "Electric & Electronic Circuits";
            this.btnElectric.UseVisualStyleBackColor = false;
            this.btnElectric.Click += new System.EventHandler(this.btnElectric_Click);
            // 
            // btnMath
            // 
            this.btnMath.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnMath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.btnMath.Font = new System.Drawing.Font("Segoe UI", 13.77391F);
            this.btnMath.Location = new System.Drawing.Point(112, 104);
            this.btnMath.Name = "btnMath";
            this.btnMath.Size = new System.Drawing.Size(336, 76);
            this.btnMath.TabIndex = 3;
            this.btnMath.Text = "Mathematics II";
            this.btnMath.UseVisualStyleBackColor = false;
            this.btnMath.Click += new System.EventHandler(this.btnMath_Click);
            // 
            // Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 383);
            this.Controls.Add(this.btnMath);
            this.Controls.Add(this.btnElectric);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnOOP);
            this.Name = "Type";
            this.Text = "Type";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOOP;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnElectric;
        private System.Windows.Forms.Button btnMath;
    }
}