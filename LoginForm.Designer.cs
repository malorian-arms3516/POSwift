namespace POSwift
{
    partial class LoginForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            passwordTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            showCredentialCheckbox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 86);
            label1.Name = "label1";
            label1.Size = new Size(105, 32);
            label1.TabIndex = 0;
            label1.Text = "SIGN IN";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(309, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(309, 186);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(252, 23);
            passwordTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(212, 141);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 3;
            label2.Text = "User Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(224, 188);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            label3.Click += label3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(309, 215);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(140, 25);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Admin account?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // showCredentialCheckbox
            // 
            showCredentialCheckbox.AutoSize = true;
            showCredentialCheckbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showCredentialCheckbox.Location = new Point(309, 246);
            showCredentialCheckbox.Name = "showCredentialCheckbox";
            showCredentialCheckbox.Size = new Size(140, 25);
            showCredentialCheckbox.TabIndex = 6;
            showCredentialCheckbox.Text = "Show credential";
            showCredentialCheckbox.UseVisualStyleBackColor = true;
            showCredentialCheckbox.CheckedChanged += showCredentialCheckbox_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showCredentialCheckbox);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordTextBox);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox passwordTextBox;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox showCredentialCheckbox;
    }
}
