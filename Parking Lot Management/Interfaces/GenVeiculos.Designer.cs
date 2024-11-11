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
            desativarBtn = new Button();
            delBtn = new Button();
            atBtn = new Button();
            backBtn = new Button();
            label2 = new Label();
            buscarBtn = new Button();
            idTxtBox = new TextBox();
            title = new Label();
            listaVeiculos = new ListView();
            SuspendLayout();
            // 
            // desativarBtn
            // 
            desativarBtn.Location = new Point(537, 378);
            desativarBtn.Name = "desativarBtn";
            desativarBtn.Size = new Size(169, 39);
            desativarBtn.TabIndex = 25;
            desativarBtn.Text = "Alterar";
            desativarBtn.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.MistyRose;
            delBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            delBtn.ForeColor = Color.FromArgb(192, 0, 0);
            delBtn.Location = new Point(339, 378);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(169, 39);
            delBtn.TabIndex = 24;
            delBtn.Text = "Deletar";
            delBtn.UseVisualStyleBackColor = false;
            // 
            // atBtn
            // 
            atBtn.Location = new Point(138, 378);
            atBtn.Name = "atBtn";
            atBtn.Size = new Size(169, 39);
            atBtn.TabIndex = 23;
            atBtn.Text = "Atualizar";
            atBtn.UseVisualStyleBackColor = true;
            atBtn.Click += this.attBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(31, 35);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(43, 38);
            backBtn.TabIndex = 22;
            backBtn.Text = "<";
            backBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(507, 35);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 21;
            label2.Text = "Buscar por Id:";
            // 
            // buscarBtn
            // 
            buscarBtn.Location = new Point(678, 33);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(77, 34);
            buscarBtn.TabIndex = 20;
            buscarBtn.Text = "Buscar";
            buscarBtn.UseVisualStyleBackColor = true;
            // 
            // idTxtBox
            // 
            idTxtBox.Location = new Point(634, 35);
            idTxtBox.Name = "idTxtBox";
            idTxtBox.Size = new Size(38, 31);
            idTxtBox.TabIndex = 19;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(80, 41);
            title.Name = "title";
            title.Size = new Size(177, 25);
            title.TabIndex = 18;
            title.Text = "Veículos cadastrados";
            // 
            // listaVeiculos
            // 
            listaVeiculos.Location = new Point(80, 79);
            listaVeiculos.Name = "listaVeiculos";
            listaVeiculos.Size = new Size(690, 279);
            listaVeiculos.TabIndex = 17;
            listaVeiculos.UseCompatibleStateImageBehavior = false;
            // 
            // GenVeiculos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(desativarBtn);
            Controls.Add(delBtn);
            Controls.Add(atBtn);
            Controls.Add(backBtn);
            Controls.Add(label2);
            Controls.Add(buscarBtn);
            Controls.Add(idTxtBox);
            Controls.Add(title);
            Controls.Add(listaVeiculos);
            Name = "GenVeiculos";
            Text = "Gerenciamento de Veiculos";
            Load += this.GenVeiculos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button desativarBtn;
        private Button delBtn;
        private Button atBtn;
        private Button backBtn;
        private Label label2;
        private Button buscarBtn;
        private TextBox idTxtBox;
        private Label title;
        private ListView listaVeiculos;
    }
}