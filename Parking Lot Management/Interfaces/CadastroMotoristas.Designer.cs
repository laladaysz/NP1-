﻿namespace Parking_Lot_Management.Interfaces
{
    partial class CadastroMotoristas
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
            cadBtn = new Button();
            telTxt = new TextBox();
            emailTxt = new TextBox();
            nomeTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cadBtn
            // 
            cadBtn.Location = new Point(364, 359);
            cadBtn.Name = "cadBtn";
            cadBtn.Size = new Size(90, 39);
            cadBtn.TabIndex = 15;
            cadBtn.Text = "Cadastre-se";
            cadBtn.UseVisualStyleBackColor = true;
            cadBtn.Click += cadBtn_Click;
            // 
            // telTxt
            // 
            telTxt.Location = new Point(286, 298);
            telTxt.Name = "telTxt";
            telTxt.Size = new Size(230, 31);
            telTxt.TabIndex = 14;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(286, 220);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(230, 31);
            emailTxt.TabIndex = 13;
            // 
            // nomeTxt
            // 
            nomeTxt.Location = new Point(286, 139);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(230, 31);
            nomeTxt.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 270);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 11;
            label4.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 192);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 10;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 111);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 9;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 47);
            label1.Name = "label1";
            label1.Size = new Size(244, 50);
            label1.TabIndex = 8;
            label1.Text = "Cadastre um novo motorista:\r\n\r\n";
            // 
            // button1
            // 
            button1.Location = new Point(224, 40);
            button1.Name = "button1";
            button1.Size = new Size(43, 38);
            button1.TabIndex = 16;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CadastroMotoristas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(cadBtn);
            Controls.Add(telTxt);
            Controls.Add(emailTxt);
            Controls.Add(nomeTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroMotoristas";
            Text = "Cadastro de motoristas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cadBtn;
        private TextBox telTxt;
        private TextBox emailTxt;
        private TextBox nomeTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}