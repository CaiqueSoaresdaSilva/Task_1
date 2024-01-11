namespace Task_1
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
            label1 = new Label();
            txtValor = new TextBox();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 27);
            label1.TabIndex = 0;
            label1.Text = "Digite um valor";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValor.Location = new Point(190, 6);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(150, 35);
            txtValor.TabIndex = 2;
            // 
            // btnValidar
            // 
            btnValidar.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValidar.Location = new Point(346, 6);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(177, 36);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar texto";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 53);
            Controls.Add(btnValidar);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Task_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValor;
        private Button btnValidar;
    }
}
