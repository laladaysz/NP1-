namespace Parking_Lot_Management.View
{
    partial class GenUsuarios
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
            listaUsuarios = new ListView();
            title = new Label();
            attBtn = new Button();
            button2 = new Button();
            idTxtBox = new TextBox();
            button3 = new Button();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listaUsuarios
            // 
            listaUsuarios.Location = new Point(67, 74);
            listaUsuarios.Name = "listaUsuarios";
            listaUsuarios.Size = new Size(690, 279);
            listaUsuarios.TabIndex = 0;
            listaUsuarios.UseCompatibleStateImageBehavior = false;
            listaUsuarios.SelectedIndexChanged += listaUsuarios_SelectedIndexChanged;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(67, 36);
            title.Name = "title";
            title.Size = new Size(181, 25);
            title.TabIndex = 1;
            title.Text = "Usuários cadastrados";
            title.Click += label1_Click;
            // 
            // attBtn
            // 
            attBtn.Location = new Point(233, 379);
            attBtn.Name = "attBtn";
            attBtn.Size = new Size(169, 39);
            attBtn.TabIndex = 2;
            attBtn.Text = "Atualizar";
            attBtn.UseVisualStyleBackColor = true;
            attBtn.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(446, 379);
            button2.Name = "button2";
            button2.Size = new Size(169, 39);
            button2.TabIndex = 3;
            button2.Text = "Deletar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // idTxtBox
            // 
            idTxtBox.Location = new Point(621, 30);
            idTxtBox.Name = "idTxtBox";
            idTxtBox.Size = new Size(38, 31);
            idTxtBox.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(665, 28);
            button3.Name = "button3";
            button3.Size = new Size(77, 34);
            button3.TabIndex = 5;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 30);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 6;
            label2.Text = "Buscar por Id:";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(18, 30);
            button1.Name = "button1";
            button1.Size = new Size(43, 38);
            button1.TabIndex = 7;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // GenUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(idTxtBox);
            Controls.Add(button2);
            Controls.Add(attBtn);
            Controls.Add(title);
            Controls.Add(listaUsuarios);
            Name = "GenUsuarios";
            Text = "Gerenciamento de usuários";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listaUsuarios;
        private Label title;
        private Button attBtn;
        private Button button2;
        private TextBox idTxtBox;
        private Button button3;
        private Label label2;
        private Button button1;
    }
}