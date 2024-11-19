namespace Parking_Lot_Management.Interfaces
{
    partial class AlterarVaga
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
            vltBtn = new Button();
            cadastrarButton = new Button();
            locTxt = new TextBox();
            tipoTxt = new TextBox();
            numTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // vltBtn
            // 
            vltBtn.Location = new Point(258, 44);
            vltBtn.Name = "vltBtn";
            vltBtn.Size = new Size(43, 38);
            vltBtn.TabIndex = 26;
            vltBtn.Text = "<";
            vltBtn.UseVisualStyleBackColor = true;
            // 
            // cadastrarButton
            // 
            cadastrarButton.Location = new Point(374, 365);
            cadastrarButton.Name = "cadastrarButton";
            cadastrarButton.Size = new Size(121, 41);
            cadastrarButton.TabIndex = 25;
            cadastrarButton.Text = "Salvar";
            cadastrarButton.UseVisualStyleBackColor = true;
            // 
            // locTxt
            // 
            locTxt.Location = new Point(317, 296);
            locTxt.Name = "locTxt";
            locTxt.Size = new Size(226, 31);
            locTxt.TabIndex = 24;
            // 
            // tipoTxt
            // 
            tipoTxt.Location = new Point(317, 211);
            tipoTxt.Name = "tipoTxt";
            tipoTxt.Size = new Size(226, 31);
            tipoTxt.TabIndex = 23;
            // 
            // numTxt
            // 
            numTxt.Location = new Point(317, 127);
            numTxt.Name = "numTxt";
            numTxt.Size = new Size(223, 31);
            numTxt.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 183);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 21;
            label4.Text = "Tipo ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 268);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 20;
            label3.Text = "Localização";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 99);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 19;
            label2.Text = "Número da vaga";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(380, 51);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 18;
            label1.Text = "Altere a vaga";
            // 
            // AlterarVaga
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vltBtn);
            Controls.Add(cadastrarButton);
            Controls.Add(locTxt);
            Controls.Add(tipoTxt);
            Controls.Add(numTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AlterarVaga";
            Text = "Alterar vaga";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button vltBtn;
        private Button cadastrarButton;
        private TextBox locTxt;
        private TextBox tipoTxt;
        private TextBox numTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}