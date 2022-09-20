
namespace Presentation.Tabs
{
    partial class MainController
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
            this.buttonBuguri = new System.Windows.Forms.Button();
            this.buttonMesaje = new System.Windows.Forms.Button();
            this.groupBoxAngajat = new System.Windows.Forms.GroupBox();
            this.groupBoxAngajat.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuguri
            // 
            this.buttonBuguri.Location = new System.Drawing.Point(0, 26);
            this.buttonBuguri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuguri.Name = "buttonBuguri";
            this.buttonBuguri.Size = new System.Drawing.Size(282, 44);
            this.buttonBuguri.TabIndex = 0;
            this.buttonBuguri.Text = "Bug-uri";
            this.buttonBuguri.UseVisualStyleBackColor = true;
            this.buttonBuguri.Click += new System.EventHandler(this.ButtonBuguri_Click);
            // 
            // buttonMesaje
            // 
            this.buttonMesaje.Location = new System.Drawing.Point(0, 78);
            this.buttonMesaje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMesaje.Name = "buttonMesaje";
            this.buttonMesaje.Size = new System.Drawing.Size(282, 44);
            this.buttonMesaje.TabIndex = 2;
            this.buttonMesaje.Text = "Mesaje";
            this.buttonMesaje.UseVisualStyleBackColor = true;
            this.buttonMesaje.Click += new System.EventHandler(this.ButtonMesaje_Click);
            // 
            // groupBoxAngajat
            // 
            this.groupBoxAngajat.Controls.Add(this.buttonBuguri);
            this.groupBoxAngajat.Controls.Add(this.buttonMesaje);
            this.groupBoxAngajat.Location = new System.Drawing.Point(348, 274);
            this.groupBoxAngajat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxAngajat.Name = "groupBoxAngajat";
            this.groupBoxAngajat.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxAngajat.Size = new System.Drawing.Size(291, 141);
            this.groupBoxAngajat.TabIndex = 4;
            this.groupBoxAngajat.TabStop = false;
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.groupBoxAngajat);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewMain";
            this.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Size = new System.Drawing.Size(1000, 700);
            this.groupBoxAngajat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBuguri;
        private System.Windows.Forms.Button buttonMesaje;
        private System.Windows.Forms.GroupBox groupBoxAngajat;
    }
}
