using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent1();
        }
        private void InitializeComponent1()
        {
            this.PalabraTextBox = new TextBox();
            this.AgregarPalabraButton = new Button();
            this.PalabrasPanel = new Panel();
            this.SuspendLayout();
            // 
            // PalabraTextBox
            // 
            this.PalabraTextBox.Location = new System.Drawing.Point(12, 12);
            this.PalabraTextBox.Name = "PalabraTextBox";
            this.PalabraTextBox.Size = new System.Drawing.Size(150, 20);
            this.PalabraTextBox.TabIndex = 0;
            // 
            // AgregarPalabraButton
            // 
            this.AgregarPalabraButton.Location = new System.Drawing.Point(168, 10);
            this.AgregarPalabraButton.Name = "AgregarPalabraButton";
            this.AgregarPalabraButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarPalabraButton.TabIndex = 1;
            this.AgregarPalabraButton.Text = "Agregar";
            this.AgregarPalabraButton.UseVisualStyleBackColor = true;
            this.AgregarPalabraButton.Click += new System.EventHandler(this.AgregarPalabraButton_Click);
            // 
            // PalabrasPanel
            // 
            this.PalabrasPanel.AutoScroll = true;
            this.PalabrasPanel.Location = new System.Drawing.Point(12, 39);
            this.PalabrasPanel.Name = "PalabrasPanel";
            this.PalabrasPanel.Size = new System.Drawing.Size(231, 200);
            this.PalabrasPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(255, 251);
            this.Controls.Add(this.PalabrasPanel);
            this.Controls.Add(this.AgregarPalabraButton);
            this.Controls.Add(this.PalabraTextBox);
            this.Name = "MainForm";
            this.Text = "Agenda App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void AgregarPalabraButton_Click(object sender, EventArgs e)
        {
            string nuevaPalabra = PalabraTextBox.Text;
            if (!string.IsNullOrWhiteSpace(nuevaPalabra))
            {
                Label nuevaLabel = new Label();
                nuevaLabel.Text = nuevaPalabra;
                nuevaLabel.AutoSize = true;
                nuevaLabel.Location = new System.Drawing.Point(10, PalabrasPanel.Controls.Count * 20);
                PalabrasPanel.Controls.Add(nuevaLabel);
                PalabraTextBox.Text = ""; // Limpiar el cuadro de texto después de agregar la palabra
            }
        }
    }
}
