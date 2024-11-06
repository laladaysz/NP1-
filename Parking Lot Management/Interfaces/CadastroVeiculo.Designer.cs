namespace Parking_Lot_Management.Interfaces
{
    partial class CadastroVeiculo
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
            corTxt = new TextBox();
            modeloTxt = new TextBox();
            placaTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            motoristaBox = new ComboBox();
            SuspendLayout();
            // 
            // cadBtn
            // 
            cadBtn.Location = new Point(352, 375);
            cadBtn.Name = "cadBtn";
            cadBtn.Size = new Size(90, 39);
            cadBtn.TabIndex = 15;
            cadBtn.Text = "Cadastre-se";
            cadBtn.UseVisualStyleBackColor = true;
            cadBtn.Click += this.cadBtn_Click;
            // 
            // corTxt
            // 
            corTxt.Location = new Point(283, 252);
            corTxt.Name = "corTxt";
            corTxt.Size = new Size(230, 31);
            corTxt.TabIndex = 14;
            // 
            // modeloTxt
            // 
            modeloTxt.Location = new Point(283, 174);
            modeloTxt.Name = "modeloTxt";
            modeloTxt.Size = new Size(230, 31);
            modeloTxt.TabIndex = 13;
            // 
            // placaTxt
            // 
            placaTxt.Location = new Point(283, 93);
            placaTxt.Name = "placaTxt";
            placaTxt.Size = new Size(230, 31);
            placaTxt.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 224);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 11;
            label4.Text = "Cor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 146);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 10;
            label3.Text = "Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 65);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 9;
            label2.Text = "Placa";
            label2.Click += this.label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 20);
            label1.Name = "label1";
            label1.Size = new Size(218, 25);
            label1.TabIndex = 8;
            label1.Text = "Cadastre um novo veículo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(283, 299);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 16;
            label5.Text = "Motorista";
            // 
            // motoristaBox
            // 
            motoristaBox.FormattingEnabled = true;
            motoristaBox.Location = new Point(283, 327);
            motoristaBox.Name = "motoristaBox";
            motoristaBox.Size = new Size(230, 33);
            motoristaBox.TabIndex = 17;
            // 
            // CadastroVeiculo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(motoristaBox);
            Controls.Add(label5);
            Controls.Add(cadBtn);
            Controls.Add(corTxt);
            Controls.Add(modeloTxt);
            Controls.Add(placaTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroVeiculo";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cadBtn;
        private TextBox corTxt;
        private TextBox modeloTxt;
        private TextBox placaTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private ComboBox motoristaBox;
    }
}