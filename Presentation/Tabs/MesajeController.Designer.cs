
namespace Presentation.Tabs
{
    partial class MesajeController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewMesaje = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonTrimiteMesaj = new System.Windows.Forms.Button();
            this.textBoxMesaj = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewAngajati = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesaje)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAngajati)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMesaje
            // 
            this.dataGridViewMesaje.AllowUserToAddRows = false;
            this.dataGridViewMesaje.AllowUserToDeleteRows = false;
            this.dataGridViewMesaje.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMesaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMesaje.Location = new System.Drawing.Point(50, 25);
            this.dataGridViewMesaje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewMesaje.Name = "dataGridViewMesaje";
            this.dataGridViewMesaje.ReadOnly = true;
            this.dataGridViewMesaje.RowHeadersWidth = 51;
            this.dataGridViewMesaje.RowTemplate.Height = 24;
            this.dataGridViewMesaje.Size = new System.Drawing.Size(497, 657);
            this.dataGridViewMesaje.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(869, 644);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(111, 38);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // buttonTrimiteMesaj
            // 
            this.buttonTrimiteMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTrimiteMesaj.Location = new System.Drawing.Point(274, 11);
            this.buttonTrimiteMesaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTrimiteMesaj.Name = "buttonTrimiteMesaj";
            this.buttonTrimiteMesaj.Size = new System.Drawing.Size(111, 38);
            this.buttonTrimiteMesaj.TabIndex = 3;
            this.buttonTrimiteMesaj.Text = "Trimite mesaj";
            this.buttonTrimiteMesaj.UseVisualStyleBackColor = true;
            this.buttonTrimiteMesaj.Click += new System.EventHandler(this.ButtonTrimiteMesaj_Click);
            // 
            // textBoxMesaj
            // 
            this.textBoxMesaj.Location = new System.Drawing.Point(0, 16);
            this.textBoxMesaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMesaj.Name = "textBoxMesaj";
            this.textBoxMesaj.Size = new System.Drawing.Size(271, 27);
            this.textBoxMesaj.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxMesaj);
            this.panel1.Controls.Add(this.buttonTrimiteMesaj);
            this.panel1.Location = new System.Drawing.Point(592, 282);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 62);
            this.panel1.TabIndex = 5;
            // 
            // dataGridViewAngajati
            // 
            this.dataGridViewAngajati.AllowUserToAddRows = false;
            this.dataGridViewAngajati.AllowUserToDeleteRows = false;
            this.dataGridViewAngajati.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAngajati.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAngajati.Location = new System.Drawing.Point(592, 25);
            this.dataGridViewAngajati.Name = "dataGridViewAngajati";
            this.dataGridViewAngajati.ReadOnly = true;
            this.dataGridViewAngajati.RowHeadersWidth = 51;
            this.dataGridViewAngajati.RowTemplate.Height = 29;
            this.dataGridViewAngajati.Size = new System.Drawing.Size(385, 250);
            this.dataGridViewAngajati.TabIndex = 6;
            this.dataGridViewAngajati.SelectionChanged += new System.EventHandler(this.DataGridViewAngajati_SelectionChanged);
            // 
            // MesajeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dataGridViewAngajati);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewMesaje);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MesajeController";
            this.Size = new System.Drawing.Size(1000, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesaje)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAngajati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMesaje;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonTrimiteMesaj;
        private System.Windows.Forms.TextBox textBoxMesaj;
        private System.Windows.Forms.Panel panel1;
        private DataGridView dataGridViewAngajati;
    }
}
