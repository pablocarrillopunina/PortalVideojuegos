namespace PortalVideojuegos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            label2 = new Label();
            label1 = new Label();
            panelLateral = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panelTop.SuspendLayout();
            panelLateral.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.WhiteSmoke;
            panelTop.Controls.Add(label2);
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1182, 80);
            panelTop.TabIndex = 0;
            panelTop.Paint += panelTop_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(774, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "mi perfil";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(584, 43);
            label1.Name = "label1";
            label1.Size = new Size(255, 23);
            label1.TabIndex = 0;
            label1.Text = "TIENDA COMUNIDAD SOPORTE";
            label1.Click += label1_Click;
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.White;
            panelLateral.Controls.Add(label5);
            panelLateral.Controls.Add(label4);
            panelLateral.Controls.Add(label3);
            panelLateral.Location = new Point(105, 86);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(285, 531);
            panelLateral.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 363);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 2;
            label5.Text = "Configuracion";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 245);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 1;
            label4.Text = "Mis juegos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 112);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 0;
            label3.Text = "Destacados";
            label3.Click += Destacados;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(431, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 531);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Location = new Point(44, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(104, 80);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Location = new Point(235, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(125, 80);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label8);
            panel3.Location = new Point(448, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(102, 80);
            panel3.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 28);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 0;
            label6.Text = "Juego";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 28);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 0;
            label7.Text = "Juego";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 28);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 0;
            label8.Text = "Juego";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1182, 653);
            Controls.Add(groupBox1);
            Controls.Add(panelLateral);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Portal de Videojuegos";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelLateral.ResumeLayout(false);
            panelLateral.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label label2;
        private Label label1;
        private Panel panelLateral;
        private Label label4;
        private Label label3;
        private Label label5;
        private GroupBox groupBox1;
        private Panel panel1;
        private Panel panel3;
        private Label label8;
        private Panel panel2;
        private Label label7;
        private Label label6;
    }
}
