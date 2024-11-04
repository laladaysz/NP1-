namespace Parking_Lot_Management
{
    partial class LoginPage
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
            label2 = new Label();
            label3 = new Label();
            entrarBtn = new Button();
            cadBtn = new LinkLabel();
            emailTxtBox = new TextBox();
            senhaTxtBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(368, 71);
            label1.Name = "label1";
            label1.Size = new Size(73, 32);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 124);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 214);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // entrarBtn
            // 
            entrarBtn.Location = new Point(344, 305);
            entrarBtn.Name = "entrarBtn";
            entrarBtn.Size = new Size(126, 52);
            entrarBtn.TabIndex = 3;
            entrarBtn.Text = "Entrar";
            entrarBtn.UseVisualStyleBackColor = true;
            entrarBtn.Click += button1_Click_1;
            // 
            // cadBtn
            // 
            cadBtn.AutoSize = true;
            cadBtn.Location = new Point(355, 360);
            cadBtn.Name = "cadBtn";
            cadBtn.Size = new Size(105, 25);
            cadBtn.TabIndex = 4;
            cadBtn.TabStop = true;
            cadBtn.Text = "Cadastre-se";
            cadBtn.LinkClicked += cadBtn_LinkClicked;
            // 
            // emailTxtBox
            // 
            emailTxtBox.Location = new Point(296, 152);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(210, 31);
            emailTxtBox.TabIndex = 5;
            // 
            // senhaTxtBox
            // 
            senhaTxtBox.Location = new Point(296, 242);
            senhaTxtBox.Name = "senhaTxtBox";
            senhaTxtBox.Size = new Size(210, 31);
            senhaTxtBox.TabIndex = 6;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(senhaTxtBox);
            Controls.Add(emailTxtBox);
            Controls.Add(cadBtn);
            Controls.Add(entrarBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginPage";
            Text = "Login Page";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button entrarBtn;
        private LinkLabel cadBtn;
        private TextBox emailTxtBox;
        private TextBox senhaTxtBox;
    }
}
