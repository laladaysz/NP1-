namespace Parking_Lot_Management.Interfaces
{
    partial class CadastroUser
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nomeTxt = new TextBox();
            emailTxt = new TextBox();
            senhaTxt = new TextBox();
            cadBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 46);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 0;
            label1.Text = "Crie uma conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 105);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 186);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 264);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 3;
            label4.Text = "Senha";
            // 
            // nomeTxt
            // 
            nomeTxt.Location = new Point(279, 133);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(230, 31);
            nomeTxt.TabIndex = 4;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(279, 214);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(230, 31);
            emailTxt.TabIndex = 5;
            // 
            // senhaTxt
            // 
            senhaTxt.Location = new Point(279, 292);
            senhaTxt.Name = "senhaTxt";
            senhaTxt.Size = new Size(230, 31);
            senhaTxt.TabIndex = 6;
            // 
            // cadBtn
            // 
            cadBtn.Location = new Point(357, 353);
            cadBtn.Name = "cadBtn";
            cadBtn.Size = new Size(90, 39);
            cadBtn.TabIndex = 7;
            cadBtn.Text = "Cadastre-se";
            cadBtn.UseVisualStyleBackColor = true;
            cadBtn.Click += cadBtn_Click;
            // 
            // CadastroUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cadBtn);
            Controls.Add(senhaTxt);
            Controls.Add(emailTxt);
            Controls.Add(nomeTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroUser";
            Text = "Cadastre-se";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nomeTxt;
        private TextBox emailTxt;
        private TextBox senhaTxt;
        private Button cadBtn;
    }
}