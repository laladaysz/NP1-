namespace Parking_Lot_Management.Interfaces
{
    partial class BI
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
            button1 = new Button();
            relatorios = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 23);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 1;
            label1.Text = "Relatório";
            // 
            // button1
            // 
            button1.Location = new Point(346, 381);
            button1.Name = "button1";
            button1.Size = new Size(119, 39);
            button1.TabIndex = 2;
            button1.Text = "Carregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // relatorios
            // 
            relatorios.Location = new Point(84, 66);
            relatorios.Name = "relatorios";
            relatorios.Size = new Size(642, 280);
            relatorios.TabIndex = 3;
            relatorios.UseCompatibleStateImageBehavior = false;
            // 
            // BI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(relatorios);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "BI";
            Text = "Relatórios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private ListView relatorios;
    }
}