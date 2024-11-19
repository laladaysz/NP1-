namespace Parking_Lot_Management.Interfaces
{
    partial class GenEntradasSaidas
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
            attBtn = new Button();
            backBtn = new Button();
            label2 = new Label();
            buscarBtn = new Button();
            idTxtBox = new TextBox();
            title = new Label();
            listaEntradasSaidas = new ListView();
            SuspendLayout();
            // 
            // desativarBtn
            // 
            desativarBtn.Location = new Point(476, 376);
            desativarBtn.Name = "desativarBtn";
            desativarBtn.Size = new Size(245, 39);
            desativarBtn.TabIndex = 25;
            desativarBtn.Text = "Registar saída e pagamento";
            desativarBtn.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.MistyRose;
            delBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            delBtn.ForeColor = Color.FromArgb(192, 0, 0);
            delBtn.Location = new Point(278, 376);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(169, 39);
            delBtn.TabIndex = 24;
            delBtn.Text = "Deletar";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            // 
            // attBtn
            // 
            attBtn.Location = new Point(77, 376);
            attBtn.Name = "attBtn";
            attBtn.Size = new Size(169, 39);
            attBtn.TabIndex = 23;
            attBtn.Text = "Atualizar";
            attBtn.UseVisualStyleBackColor = true;
            attBtn.Click += attBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(31, 35);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(43, 38);
            backBtn.TabIndex = 22;
            backBtn.Text = "<";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
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
            title.Size = new Size(148, 25);
            title.TabIndex = 18;
            title.Text = "Entradas e saídas";
            // 
            // listaEntradasSaidas
            // 
            listaEntradasSaidas.Location = new Point(80, 79);
            listaEntradasSaidas.Name = "listaEntradasSaidas";
            listaEntradasSaidas.Size = new Size(690, 279);
            listaEntradasSaidas.TabIndex = 17;
            listaEntradasSaidas.UseCompatibleStateImageBehavior = false;
            // 
            // GenEntradasSaidas
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
            Controls.Add(listaEntradasSaidas);
            Name = "GenEntradasSaidas";
            Text = "Gerenciamento de entradas e saídas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button desativarBtn;
        private Button delBtn;
        private Button attBtn;
        private Button backBtn;
        private Label label2;
        private Button buscarBtn;
        private TextBox idTxtBox;
        private Label title;
        private ListView listaEntradasSaidas;
    }
}