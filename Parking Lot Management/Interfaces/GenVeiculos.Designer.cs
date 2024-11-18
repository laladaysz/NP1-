namespace Parking_Lot_Management.Interfaces
{
    partial class GenVeiculos
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
            alterarBtn = new Button();
            button1 = new Button();
            label2 = new Label();
            button3 = new Button();
            idTxtBox = new TextBox();
            button2 = new Button();
            attBtn = new Button();
            title = new Label();
            listaVeiculos = new ListView();
            SuspendLayout();
            // 
            // alterarBtn
            // 
            alterarBtn.Location = new Point(520, 373);
            alterarBtn.Name = "alterarBtn";
            alterarBtn.Size = new Size(169, 39);
            alterarBtn.TabIndex = 18;
            alterarBtn.Text = "Alterar";
            alterarBtn.UseVisualStyleBackColor = true;
            alterarBtn.Click += alterarBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(31, 34);
            button1.Name = "button1";
            button1.Size = new Size(43, 38);
            button1.TabIndex = 17;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(507, 34);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 16;
            label2.Text = "Buscar por Id:";
            // 
            // button3
            // 
            button3.Location = new Point(678, 32);
            button3.Name = "button3";
            button3.Size = new Size(77, 34);
            button3.TabIndex = 15;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // idTxtBox
            // 
            idTxtBox.Location = new Point(634, 34);
            idTxtBox.Name = "idTxtBox";
            idTxtBox.Size = new Size(38, 31);
            idTxtBox.TabIndex = 14;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(345, 373);
            button2.Name = "button2";
            button2.Size = new Size(169, 39);
            button2.TabIndex = 13;
            button2.Text = "Deletar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // attBtn
            // 
            attBtn.Location = new Point(170, 373);
            attBtn.Name = "attBtn";
            attBtn.Size = new Size(169, 39);
            attBtn.TabIndex = 12;
            attBtn.Text = "Atualizar";
            attBtn.UseVisualStyleBackColor = true;
            attBtn.Click += attBtn_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(80, 40);
            title.Name = "title";
            title.Size = new Size(177, 25);
            title.TabIndex = 11;
            title.Text = "Veículos cadastrados";
            // 
            // listaVeiculos
            // 
            listaVeiculos.Location = new Point(80, 78);
            listaVeiculos.Name = "listaVeiculos";
            listaVeiculos.Size = new Size(690, 279);
            listaVeiculos.TabIndex = 10;
            listaVeiculos.UseCompatibleStateImageBehavior = false;
            // 
            // GenVeiculos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(alterarBtn);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(idTxtBox);
            Controls.Add(button2);
            Controls.Add(attBtn);
            Controls.Add(title);
            Controls.Add(listaVeiculos);
            Name = "GenVeiculos";
            Text = "Gerenciamento de veículos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button alterarBtn;
        private Button button1;
        private Label label2;
        private Button button3;
        private TextBox idTxtBox;
        private Button button2;
        private Button attBtn;
        private Label title;
        private ListView listaVeiculos;
    }
}