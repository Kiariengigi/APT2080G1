namespace MainCode_Group1
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
            this.Sign_Up_btn = new System.Windows.Forms.Button();
            this.Sign_In_btn = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Confirm_Pass = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Sign_up_btn1 = new System.Windows.Forms.Button();
            this.Sign_In_btn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sign_Up_btn
            // 
            this.Sign_Up_btn.Location = new System.Drawing.Point(401, 62);
            this.Sign_Up_btn.Name = "Sign_Up_btn";
            this.Sign_Up_btn.Size = new System.Drawing.Size(142, 48);
            this.Sign_Up_btn.TabIndex = 0;
            this.Sign_Up_btn.Text = "Sign Up";
            this.Sign_Up_btn.UseVisualStyleBackColor = true;
            this.Sign_Up_btn.Click += new System.EventHandler(this.Sign_Up_btn_Click);
            // 
            // Sign_In_btn
            // 
            this.Sign_In_btn.Location = new System.Drawing.Point(549, 62);
            this.Sign_In_btn.Name = "Sign_In_btn";
            this.Sign_In_btn.Size = new System.Drawing.Size(142, 48);
            this.Sign_In_btn.TabIndex = 1;
            this.Sign_In_btn.Text = "Log in";
            this.Sign_In_btn.UseVisualStyleBackColor = true;
            this.Sign_In_btn.Click += new System.EventHandler(this.Sign_In_btn_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(150, 194);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 22);
            this.Password.TabIndex = 3;
            this.Password.Visible = false;
            // 
            // Confirm_Pass
            // 
            this.Confirm_Pass.Location = new System.Drawing.Point(150, 248);
            this.Confirm_Pass.Name = "Confirm_Pass";
            this.Confirm_Pass.PasswordChar = '*';
            this.Confirm_Pass.Size = new System.Drawing.Size(100, 22);
            this.Confirm_Pass.TabIndex = 4;
            this.Confirm_Pass.Visible = false;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(150, 139);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 22);
            this.Username.TabIndex = 2;
            this.Username.Visible = false;
            this.Username.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Sign_up_btn1
            // 
            this.Sign_up_btn1.Location = new System.Drawing.Point(132, 299);
            this.Sign_up_btn1.Name = "Sign_up_btn1";
            this.Sign_up_btn1.Size = new System.Drawing.Size(142, 48);
            this.Sign_up_btn1.TabIndex = 5;
            this.Sign_up_btn1.Text = "Sign Up";
            this.Sign_up_btn1.UseVisualStyleBackColor = true;
            this.Sign_up_btn1.Visible = false;
            this.Sign_up_btn1.Click += new System.EventHandler(this.Sign_up_btn1_Click);
            // 
            // Sign_In_btn1
            // 
            this.Sign_In_btn1.Location = new System.Drawing.Point(132, 363);
            this.Sign_In_btn1.Name = "Sign_In_btn1";
            this.Sign_In_btn1.Size = new System.Drawing.Size(142, 48);
            this.Sign_In_btn1.TabIndex = 6;
            this.Sign_In_btn1.Text = "Log in";
            this.Sign_In_btn1.UseVisualStyleBackColor = true;
            this.Sign_In_btn1.Visible = false;
            this.Sign_In_btn1.Click += new System.EventHandler(this.Sign_In_btn1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Form2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Form3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sign_In_btn1);
            this.Controls.Add(this.Sign_up_btn1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Confirm_Pass);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Sign_In_btn);
            this.Controls.Add(this.Sign_Up_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sign_Up_btn;
        private System.Windows.Forms.Button Sign_In_btn;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Confirm_Pass;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button Sign_up_btn1;
        private System.Windows.Forms.Button Sign_In_btn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

