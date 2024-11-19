namespace Parking_Lot_Management.Interfaces
{
    partial class CadastroEntrada
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
            resgiterBtn = new Button();
            vagaComboBox = new ComboBox();
            motoComboBox = new ComboBox();
            carroComboBox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 32);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 0;
            label1.Text = "Registro de entrada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 86);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 1;
            label2.Text = "Vaga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 168);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 2;
            label3.Text = "Motorista";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(290, 247);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 3;
            label4.Text = "Carro";
            // 
            // resgiterBtn
            // 
            resgiterBtn.Location = new Point(335, 334);
            resgiterBtn.Name = "resgiterBtn";
            resgiterBtn.Size = new Size(135, 43);
            resgiterBtn.TabIndex = 4;
            resgiterBtn.Text = "Registrar";
            resgiterBtn.UseVisualStyleBackColor = true;
            resgiterBtn.Click += resgiterBtn_Click;
            // 
            // vagaComboBox
            // 
            vagaComboBox.FormattingEnabled = true;
            vagaComboBox.Location = new Point(290, 114);
            vagaComboBox.Name = "vagaComboBox";
            vagaComboBox.Size = new Size(211, 33);
            vagaComboBox.TabIndex = 5;
            // 
            // motoComboBox
            // 
            motoComboBox.FormattingEnabled = true;
            motoComboBox.Location = new Point(290, 196);
            motoComboBox.Name = "motoComboBox";
            motoComboBox.Size = new Size(211, 33);
            motoComboBox.TabIndex = 6;
            motoComboBox.SelectedIndexChanged += motoComboBox_SelectedIndexChanged;
            // 
            // carroComboBox
            // 
            carroComboBox.FormattingEnabled = true;
            carroComboBox.Location = new Point(290, 275);
            carroComboBox.Name = "carroComboBox";
            carroComboBox.Size = new Size(211, 33);
            carroComboBox.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(241, 25);
            button1.Name = "button1";
            button1.Size = new Size(43, 38);
            button1.TabIndex = 27;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CadastroEntrada
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(carroComboBox);
            Controls.Add(motoComboBox);
            Controls.Add(vagaComboBox);
            Controls.Add(resgiterBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroEntrada";
            Text = "Registrar entrada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button resgiterBtn;
        private ComboBox vagaComboBox;
        private ComboBox motoComboBox;
        private ComboBox carroComboBox;
        private Button button1;
    }
}