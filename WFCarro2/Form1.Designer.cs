namespace WFCarro2
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
            btnEncender = new Button();
            btnAcelerar = new Button();
            lblVelovidad = new Label();
            SuspendLayout();
            // 
            // btnEncender
            // 
            btnEncender.Location = new Point(93, 99);
            btnEncender.Name = "btnEncender";
            btnEncender.Size = new Size(245, 78);
            btnEncender.TabIndex = 0;
            btnEncender.Text = "Encender Carro";
            btnEncender.UseVisualStyleBackColor = true;
            btnEncender.Click += btnEncender_Click;
            // 
            // btnAcelerar
            // 
            btnAcelerar.Enabled = false;
            btnAcelerar.Location = new Point(90, 234);
            btnAcelerar.Name = "btnAcelerar";
            btnAcelerar.Size = new Size(253, 80);
            btnAcelerar.TabIndex = 1;
            btnAcelerar.Text = "Acelerar";
            btnAcelerar.UseVisualStyleBackColor = true;
            // 
            // lblVelovidad
            // 
            lblVelovidad.AutoSize = true;
            lblVelovidad.Font = new Font("Segoe UI", 20F);
            lblVelovidad.Location = new Point(599, 172);
            lblVelovidad.Name = "lblVelovidad";
            lblVelovidad.Size = new Size(96, 54);
            lblVelovidad.TabIndex = 2;
            lblVelovidad.Text = "KPH";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVelovidad);
            Controls.Add(btnAcelerar);
            Controls.Add(btnEncender);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncender;
        private Button btnAcelerar;
        private Label lblVelovidad;
    }
}
