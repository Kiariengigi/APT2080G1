namespace MainCode_Group1
{
    partial class Form2
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
            this.Next_Btn = new System.Windows.Forms.Button();
            this.tomato_check = new System.Windows.Forms.CheckBox();
            this.Tea_Check = new System.Windows.Forms.CheckBox();
            this.Maize_Check = new System.Windows.Forms.CheckBox();
            this.Sugarcane_Check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Next_Btn
            // 
            this.Next_Btn.Location = new System.Drawing.Point(337, 283);
            this.Next_Btn.Name = "Next_Btn";
            this.Next_Btn.Size = new System.Drawing.Size(75, 23);
            this.Next_Btn.TabIndex = 4;
            this.Next_Btn.Text = "Next";
            this.Next_Btn.UseVisualStyleBackColor = true;
            this.Next_Btn.Click += new System.EventHandler(this.Next_Btn_Click);
            // 
            // tomato_check
            // 
            this.tomato_check.AutoSize = true;
            this.tomato_check.Location = new System.Drawing.Point(99, 181);
            this.tomato_check.Name = "tomato_check";
            this.tomato_check.Size = new System.Drawing.Size(91, 20);
            this.tomato_check.TabIndex = 5;
            this.tomato_check.Text = "Tomatoes";
            this.tomato_check.UseVisualStyleBackColor = true;
            this.tomato_check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Tea_Check
            // 
            this.Tea_Check.AutoSize = true;
            this.Tea_Check.Location = new System.Drawing.Point(268, 181);
            this.Tea_Check.Name = "Tea_Check";
            this.Tea_Check.Size = new System.Drawing.Size(54, 20);
            this.Tea_Check.TabIndex = 6;
            this.Tea_Check.Text = "Tea";
            this.Tea_Check.UseVisualStyleBackColor = true;
            this.Tea_Check.CheckedChanged += new System.EventHandler(this.Tea_Check_CheckedChanged);
            // 
            // Maize_Check
            // 
            this.Maize_Check.AutoSize = true;
            this.Maize_Check.Location = new System.Drawing.Point(434, 181);
            this.Maize_Check.Name = "Maize_Check";
            this.Maize_Check.Size = new System.Drawing.Size(65, 20);
            this.Maize_Check.TabIndex = 7;
            this.Maize_Check.Text = "Maize";
            this.Maize_Check.UseVisualStyleBackColor = true;
            this.Maize_Check.CheckedChanged += new System.EventHandler(this.Maize_Check_CheckedChanged);
            // 
            // Sugarcane_Check
            // 
            this.Sugarcane_Check.AutoSize = true;
            this.Sugarcane_Check.Location = new System.Drawing.Point(589, 181);
            this.Sugarcane_Check.Name = "Sugarcane_Check";
            this.Sugarcane_Check.Size = new System.Drawing.Size(95, 20);
            this.Sugarcane_Check.TabIndex = 8;
            this.Sugarcane_Check.Text = "Sugarcane";
            this.Sugarcane_Check.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sugarcane_Check);
            this.Controls.Add(this.Maize_Check);
            this.Controls.Add(this.Tea_Check);
            this.Controls.Add(this.tomato_check);
            this.Controls.Add(this.Next_Btn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Next_Btn;
        private System.Windows.Forms.CheckBox tomato_check;
        private System.Windows.Forms.CheckBox Tea_Check;
        private System.Windows.Forms.CheckBox Maize_Check;
        private System.Windows.Forms.CheckBox Sugarcane_Check;
    }
}