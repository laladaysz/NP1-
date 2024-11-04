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
            listView1 = new ListView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(67, 74);
            listView1.Name = "listView1";
            listView1.Size = new Size(690, 279);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 36);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 1;
            label1.Text = "Usuários cadastrados";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(233, 379);
            button1.Name = "button1";
            button1.Size = new Size(169, 39);
            button1.TabIndex = 2;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
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
            // 
            // textBox1
            // 
            textBox1.Location = new Point(621, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(38, 31);
            textBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(665, 28);
            button3.Name = "button3";
            button3.Size = new Size(77, 34);
            button3.TabIndex = 5;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
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
            // GenUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "GenUsuarios";
            Text = "Gerenciamento de usuários";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Label label2;
    }
}