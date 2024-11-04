namespace Parking_Lot_Management.View
{
    partial class HomeAdmin
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
            GenUsersBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 55);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 0;
            label1.Text = "Seja, bem-vindo(a)!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 90);
            label2.Name = "label2";
            label2.Size = new Size(200, 25);
            label2.TabIndex = 1;
            label2.Text = "O que deseja visualizar?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 155);
            label3.Name = "label3";
            label3.Size = new Size(227, 25);
            label3.TabIndex = 2;
            label3.Text = "Gerenciamento de usuários";
            // 
            // GenUsersBtn
            // 
            GenUsersBtn.Font = new Font("Segoe UI", 7F);
            GenUsersBtn.Location = new Point(354, 155);
            GenUsersBtn.Name = "GenUsersBtn";
            GenUsersBtn.Size = new Size(95, 29);
            GenUsersBtn.TabIndex = 3;
            GenUsersBtn.Text = "Entrar";
            GenUsersBtn.UseVisualStyleBackColor = true;
            // 
            // HomeAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GenUsersBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HomeAdmin";
            Text = "Página inicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button GenUsersBtn;
    }
}