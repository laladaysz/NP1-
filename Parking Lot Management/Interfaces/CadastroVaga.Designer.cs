namespace Parking_Lot_Management.Interfaces
{
    partial class CadastroVaga
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
            numTxt = new TextBox();
            tipoTxt = new TextBox();
            locTxt = new TextBox();
            cadastrarButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 45);
            label1.Name = "label1";
            label1.Size = new Size(208, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastre uma nova vaga";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 93);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 1;
            label2.Text = "Número da vaga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 262);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "Localização";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(303, 177);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 3;
            label4.Text = "Tipo ";
            // 
            // numTxt
            // 
            numTxt.Location = new Point(303, 121);
            numTxt.Name = "numTxt";
            numTxt.Size = new Size(223, 31);
            numTxt.TabIndex = 4;
            // 
            // tipoTxt
            // 
            tipoTxt.Location = new Point(303, 205);
            tipoTxt.Name = "tipoTxt";
            tipoTxt.Size = new Size(226, 31);
            tipoTxt.TabIndex = 5;
            // 
            // locTxt
            // 
            locTxt.Location = new Point(303, 290);
            locTxt.Name = "locTxt";
            locTxt.Size = new Size(226, 31);
            locTxt.TabIndex = 6;
            // 
            // cadastrarButton
            // 
            cadastrarButton.Location = new Point(360, 359);
            cadastrarButton.Name = "cadastrarButton";
            cadastrarButton.Size = new Size(121, 41);
            cadastrarButton.TabIndex = 7;
            cadastrarButton.Text = "Cadastrar";
            cadastrarButton.UseVisualStyleBackColor = true;
            cadastrarButton.Click += cadastrarButton_Click;
            // 
            // CadastroVaga
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cadastrarButton);
            Controls.Add(locTxt);
            Controls.Add(tipoTxt);
            Controls.Add(numTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroVaga";
            Text = "Cadastro vaga";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox numTxt;
        private TextBox tipoTxt;
        private TextBox locTxt;
        private Button cadastrarButton;
    }
}