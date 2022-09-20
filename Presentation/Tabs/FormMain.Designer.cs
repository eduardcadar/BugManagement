
namespace Presentation.Tabs
{
    partial class FormMain
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
            this.viewMesaje = new Presentation.Tabs.MesajeController();
            this.viewBuguri = new Presentation.Tabs.BuguriController();
            this.viewMain = new Presentation.Tabs.MainController();
            this.viewLogin = new Presentation.Tabs.LoginController();
            this.labelAngajat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewMesaje
            // 
            this.viewMesaje.BackColor = System.Drawing.SystemColors.Window;
            this.viewMesaje.Location = new System.Drawing.Point(13, 66);
            this.viewMesaje.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.viewMesaje.Name = "viewMesaje";
            this.viewMesaje.Size = new System.Drawing.Size(1000, 700);
            this.viewMesaje.TabIndex = 3;
            // 
            // viewBuguri
            // 
            this.viewBuguri.BackColor = System.Drawing.SystemColors.Window;
            this.viewBuguri.Location = new System.Drawing.Point(16, 66);
            this.viewBuguri.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.viewBuguri.Name = "viewBuguri";
            this.viewBuguri.Size = new System.Drawing.Size(1000, 700);
            this.viewBuguri.TabIndex = 2;
            // 
            // viewMain
            // 
            this.viewMain.BackColor = System.Drawing.SystemColors.Window;
            this.viewMain.Location = new System.Drawing.Point(12, 66);
            this.viewMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.viewMain.Name = "viewMain";
            this.viewMain.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewMain.Size = new System.Drawing.Size(1000, 700);
            this.viewMain.TabIndex = 1;
            // 
            // viewLogin
            // 
            this.viewLogin.BackColor = System.Drawing.SystemColors.Window;
            this.viewLogin.Location = new System.Drawing.Point(16, 66);
            this.viewLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.viewLogin.Name = "viewLogin";
            this.viewLogin.Size = new System.Drawing.Size(1000, 700);
            this.viewLogin.TabIndex = 0;
            // 
            // labelAngajat
            // 
            this.labelAngajat.AutoSize = true;
            this.labelAngajat.Location = new System.Drawing.Point(25, 30);
            this.labelAngajat.Name = "labelAngajat";
            this.labelAngajat.Size = new System.Drawing.Size(59, 20);
            this.labelAngajat.TabIndex = 6;
            this.labelAngajat.Text = "angajat";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1028, 781);
            this.Controls.Add(this.labelAngajat);
            this.Controls.Add(this.viewMesaje);
            this.Controls.Add(this.viewBuguri);
            this.Controls.Add(this.viewMain);
            this.Controls.Add(this.viewLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem bug-uri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tabs.LoginController viewLogin;
        private Presentation.Tabs.MainController viewMain;
        private BuguriController viewBuguri;
        private MesajeController viewMesaje;
        private Label labelAngajat;
    }
}

