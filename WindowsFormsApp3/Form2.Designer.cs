namespace WindowsFormsApp3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.PalabrasPanel = new System.Windows.Forms.Panel();
            this.PalabraTextBox = new System.Windows.Forms.TextBox();
            this.AgregarPalabraButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mi lista de tareas";
            // 
            // PalabrasPanel
            // 
            this.PalabrasPanel.Location = new System.Drawing.Point(12, 114);
            this.PalabrasPanel.Name = "PalabrasPanel";
            this.PalabrasPanel.Size = new System.Drawing.Size(379, 473);
            this.PalabrasPanel.TabIndex = 1;
            // 
            // PalabraTextBox
            // 
            this.PalabraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalabraTextBox.Location = new System.Drawing.Point(12, 68);
            this.PalabraTextBox.Name = "PalabraTextBox";
            this.PalabraTextBox.Size = new System.Drawing.Size(298, 22);
            this.PalabraTextBox.TabIndex = 2;
            // 
            // AgregarPalabraButton
            // 
            this.AgregarPalabraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarPalabraButton.Location = new System.Drawing.Point(316, 68);
            this.AgregarPalabraButton.Name = "AgregarPalabraButton";
            this.AgregarPalabraButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarPalabraButton.TabIndex = 3;
            this.AgregarPalabraButton.Text = "Agregar";
            this.AgregarPalabraButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 599);
            this.Controls.Add(this.AgregarPalabraButton);
            this.Controls.Add(this.PalabraTextBox);
            this.Controls.Add(this.PalabrasPanel);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PalabrasPanel;
        private System.Windows.Forms.TextBox PalabraTextBox;
        private System.Windows.Forms.Button AgregarPalabraButton;
    }
}