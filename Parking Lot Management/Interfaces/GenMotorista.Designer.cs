namespace Parking_Lot_Management.Interfaces
{
    partial class GenMotorista
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
            backBtn = new Button();
            label2 = new Label();
            buscarBtn = new Button();
            idTxtBox = new TextBox();
            title = new Label();
            listaMotoristas = new ListView();
            delBtn = new Button();
            attBtn = new Button();
            desativarBtn = new Button();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(26, 45);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(43, 38);
            backBtn.TabIndex = 13;
            backBtn.Text = "<";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(502, 45);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 12;
            label2.Text = "Buscar por Id:";
            // 
            // buscarBtn
            // 
            buscarBtn.Location = new Point(673, 43);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(77, 34);
            buscarBtn.TabIndex = 11;
            buscarBtn.Text = "Buscar";
            buscarBtn.UseVisualStyleBackColor = true;
            buscarBtn.Click += buscarBtn_Click;
            // 
            // idTxtBox
            // 
            idTxtBox.Location = new Point(629, 45);
            idTxtBox.Name = "idTxtBox";
            idTxtBox.Size = new Size(38, 31);
            idTxtBox.TabIndex = 10;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(75, 51);
            title.Name = "title";
            title.Size = new Size(181, 25);
            title.TabIndex = 9;
            title.Text = "Usuários cadastrados";
            // 
            // listaMotoristas
            // 
            listaMotoristas.Location = new Point(75, 89);
            listaMotoristas.Name = "listaMotoristas";
            listaMotoristas.Size = new Size(690, 279);
            listaMotoristas.TabIndex = 8;
            listaMotoristas.UseCompatibleStateImageBehavior = false;
            listaMotoristas.SelectedIndexChanged += listaMotoristas_SelectedIndexChanged;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.MistyRose;
            delBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            delBtn.ForeColor = Color.FromArgb(192, 0, 0);
            delBtn.Location = new Point(334, 388);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(169, 39);
            delBtn.TabIndex = 15;
            delBtn.Text = "Deletar";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            // 
            // attBtn
            // 
            attBtn.Location = new Point(133, 388);
            attBtn.Name = "attBtn";
            attBtn.Size = new Size(169, 39);
            attBtn.TabIndex = 14;
            attBtn.Text = "Atualizar";
            attBtn.UseVisualStyleBackColor = true;
            attBtn.Click += attBtn_Click;
            // 
            // desativarBtn
            // 
            desativarBtn.Location = new Point(532, 388);
            desativarBtn.Name = "desativarBtn";
            desativarBtn.Size = new Size(169, 39);
            desativarBtn.TabIndex = 16;
            desativarBtn.Text = "Desativar";
            desativarBtn.UseVisualStyleBackColor = true;
            desativarBtn.Click += desativarBtn_Click;
            // 
            // GenMotorista
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(desativarBtn);
            Controls.Add(delBtn);
            Controls.Add(attBtn);
            Controls.Add(backBtn);
            Controls.Add(label2);
            Controls.Add(buscarBtn);
            Controls.Add(idTxtBox);
            Controls.Add(title);
            Controls.Add(listaMotoristas);
            Name = "GenMotorista";
            Text = "Gerenciamento de motorista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private Label label2;
        private Button buscarBtn;
        private TextBox idTxtBox;
        private Label title;
        private ListView listaMotoristas;
        private Button delBtn;
        private Button attBtn;
        private Button desativarBtn;
    }
}