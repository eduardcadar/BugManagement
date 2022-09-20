
namespace Presentation.Tabs
{
    partial class BuguriController
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
            this.buttonVerificaBug = new System.Windows.Forms.Button();
            this.buttonRezolvaBug = new System.Windows.Forms.Button();
            this.buttonStergePas = new System.Windows.Forms.Button();
            this.buttonModificaPas = new System.Windows.Forms.Button();
            this.buttonAdaugaPas = new System.Windows.Forms.Button();
            this.buttonInregistrareBug = new System.Windows.Forms.Button();
            this.dataGridViewBuguri = new System.Windows.Forms.DataGridView();
            this.dataGridViewPasi = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelProgramator = new System.Windows.Forms.Panel();
            this.buttonReview = new System.Windows.Forms.Button();
            this.panelVerificator = new System.Windows.Forms.Panel();
            this.textBoxTester = new System.Windows.Forms.RichTextBox();
            this.panelBug = new System.Windows.Forms.Panel();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxReview = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDescriere = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuguri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasi)).BeginInit();
            this.panelProgramator.SuspendLayout();
            this.panelVerificator.SuspendLayout();
            this.panelBug.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVerificaBug
            // 
            this.buttonVerificaBug.Location = new System.Drawing.Point(0, 44);
            this.buttonVerificaBug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonVerificaBug.Name = "buttonVerificaBug";
            this.buttonVerificaBug.Size = new System.Drawing.Size(172, 32);
            this.buttonVerificaBug.TabIndex = 1;
            this.buttonVerificaBug.Text = "Verifica bug rezolvat";
            this.buttonVerificaBug.UseVisualStyleBackColor = true;
            this.buttonVerificaBug.Click += new System.EventHandler(this.ButtonVerificaBug_Click);
            // 
            // buttonRezolvaBug
            // 
            this.buttonRezolvaBug.Location = new System.Drawing.Point(0, 0);
            this.buttonRezolvaBug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRezolvaBug.Name = "buttonRezolvaBug";
            this.buttonRezolvaBug.Size = new System.Drawing.Size(172, 32);
            this.buttonRezolvaBug.TabIndex = 0;
            this.buttonRezolvaBug.Text = "Bug rezolvat";
            this.buttonRezolvaBug.UseVisualStyleBackColor = true;
            this.buttonRezolvaBug.Click += new System.EventHandler(this.ButtonRezolvaBug_Click);
            // 
            // buttonStergePas
            // 
            this.buttonStergePas.Location = new System.Drawing.Point(307, 0);
            this.buttonStergePas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStergePas.Name = "buttonStergePas";
            this.buttonStergePas.Size = new System.Drawing.Size(137, 32);
            this.buttonStergePas.TabIndex = 3;
            this.buttonStergePas.Text = "Sterge pas";
            this.buttonStergePas.UseVisualStyleBackColor = true;
            this.buttonStergePas.Click += new System.EventHandler(this.ButtonStergePas_Click);
            // 
            // buttonModificaPas
            // 
            this.buttonModificaPas.Location = new System.Drawing.Point(307, 78);
            this.buttonModificaPas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonModificaPas.Name = "buttonModificaPas";
            this.buttonModificaPas.Size = new System.Drawing.Size(137, 32);
            this.buttonModificaPas.TabIndex = 2;
            this.buttonModificaPas.Text = "Modifica pas";
            this.buttonModificaPas.UseVisualStyleBackColor = true;
            this.buttonModificaPas.Click += new System.EventHandler(this.ButtonModificaPas_Click);
            // 
            // buttonAdaugaPas
            // 
            this.buttonAdaugaPas.Location = new System.Drawing.Point(307, 38);
            this.buttonAdaugaPas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdaugaPas.Name = "buttonAdaugaPas";
            this.buttonAdaugaPas.Size = new System.Drawing.Size(137, 32);
            this.buttonAdaugaPas.TabIndex = 1;
            this.buttonAdaugaPas.Text = "Adauga pas";
            this.buttonAdaugaPas.UseVisualStyleBackColor = true;
            this.buttonAdaugaPas.Click += new System.EventHandler(this.ButtonAdaugaPas_Click);
            // 
            // buttonInregistrareBug
            // 
            this.buttonInregistrareBug.Location = new System.Drawing.Point(307, 143);
            this.buttonInregistrareBug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonInregistrareBug.Name = "buttonInregistrareBug";
            this.buttonInregistrareBug.Size = new System.Drawing.Size(137, 32);
            this.buttonInregistrareBug.TabIndex = 0;
            this.buttonInregistrareBug.Text = "Inregistreaza bug";
            this.buttonInregistrareBug.UseVisualStyleBackColor = true;
            this.buttonInregistrareBug.Click += new System.EventHandler(this.ButtonInregistrareBug_Click);
            // 
            // dataGridViewBuguri
            // 
            this.dataGridViewBuguri.AllowUserToAddRows = false;
            this.dataGridViewBuguri.AllowUserToDeleteRows = false;
            this.dataGridViewBuguri.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewBuguri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuguri.Location = new System.Drawing.Point(23, 32);
            this.dataGridViewBuguri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewBuguri.Name = "dataGridViewBuguri";
            this.dataGridViewBuguri.ReadOnly = true;
            this.dataGridViewBuguri.RowHeadersWidth = 51;
            this.dataGridViewBuguri.RowTemplate.Height = 24;
            this.dataGridViewBuguri.Size = new System.Drawing.Size(490, 295);
            this.dataGridViewBuguri.TabIndex = 1;
            this.dataGridViewBuguri.SelectionChanged += new System.EventHandler(this.DataGridViewBuguri_SelectionChanged);
            // 
            // dataGridViewPasi
            // 
            this.dataGridViewPasi.AllowUserToAddRows = false;
            this.dataGridViewPasi.AllowUserToDeleteRows = false;
            this.dataGridViewPasi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPasi.Location = new System.Drawing.Point(537, 32);
            this.dataGridViewPasi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewPasi.Name = "dataGridViewPasi";
            this.dataGridViewPasi.ReadOnly = true;
            this.dataGridViewPasi.RowHeadersWidth = 51;
            this.dataGridViewPasi.RowTemplate.Height = 24;
            this.dataGridViewPasi.Size = new System.Drawing.Size(447, 295);
            this.dataGridViewPasi.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(847, 642);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(137, 32);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // panelProgramator
            // 
            this.panelProgramator.Controls.Add(this.buttonReview);
            this.panelProgramator.Controls.Add(this.buttonVerificaBug);
            this.panelProgramator.Controls.Add(this.buttonRezolvaBug);
            this.panelProgramator.Location = new System.Drawing.Point(537, 528);
            this.panelProgramator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelProgramator.Name = "panelProgramator";
            this.panelProgramator.Size = new System.Drawing.Size(181, 146);
            this.panelProgramator.TabIndex = 8;
            // 
            // buttonReview
            // 
            this.buttonReview.Location = new System.Drawing.Point(0, 88);
            this.buttonReview.Name = "buttonReview";
            this.buttonReview.Size = new System.Drawing.Size(172, 32);
            this.buttonReview.TabIndex = 2;
            this.buttonReview.Text = "Modifica review";
            this.buttonReview.UseVisualStyleBackColor = true;
            this.buttonReview.Click += new System.EventHandler(this.ButtonReview_Click);
            // 
            // panelVerificator
            // 
            this.panelVerificator.Controls.Add(this.textBoxTester);
            this.panelVerificator.Controls.Add(this.buttonInregistrareBug);
            this.panelVerificator.Controls.Add(this.buttonAdaugaPas);
            this.panelVerificator.Controls.Add(this.buttonStergePas);
            this.panelVerificator.Controls.Add(this.buttonModificaPas);
            this.panelVerificator.Location = new System.Drawing.Point(534, 340);
            this.panelVerificator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelVerificator.Name = "panelVerificator";
            this.panelVerificator.Size = new System.Drawing.Size(447, 175);
            this.panelVerificator.TabIndex = 9;
            // 
            // textBoxTester
            // 
            this.textBoxTester.Location = new System.Drawing.Point(3, 41);
            this.textBoxTester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTester.Name = "textBoxTester";
            this.textBoxTester.Size = new System.Drawing.Size(298, 134);
            this.textBoxTester.TabIndex = 4;
            this.textBoxTester.Text = "";
            // 
            // panelBug
            // 
            this.panelBug.Controls.Add(this.comboBoxStatus);
            this.panelBug.Controls.Add(this.textBoxReview);
            this.panelBug.Controls.Add(this.label1);
            this.panelBug.Controls.Add(this.labelDescriere);
            this.panelBug.Controls.Add(this.textBoxDescription);
            this.panelBug.Location = new System.Drawing.Point(23, 340);
            this.panelBug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBug.Name = "panelBug";
            this.panelBug.Size = new System.Drawing.Size(493, 334);
            this.panelBug.TabIndex = 10;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Enabled = false;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "ADAUGAT",
            "REZOLVAT",
            "VERIFICAT"});
            this.comboBoxStatus.Location = new System.Drawing.Point(350, 4);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(140, 28);
            this.comboBoxStatus.TabIndex = 5;
            this.comboBoxStatus.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxStatus_StatusChanged);
            // 
            // textBoxReview
            // 
            this.textBoxReview.Location = new System.Drawing.Point(0, 218);
            this.textBoxReview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxReview.Name = "textBoxReview";
            this.textBoxReview.Size = new System.Drawing.Size(490, 90);
            this.textBoxReview.TabIndex = 3;
            this.textBoxReview.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Review";
            // 
            // labelDescriere
            // 
            this.labelDescriere.AutoSize = true;
            this.labelDescriere.Location = new System.Drawing.Point(10, 2);
            this.labelDescriere.Name = "labelDescriere";
            this.labelDescriere.Size = new System.Drawing.Size(101, 20);
            this.labelDescriere.TabIndex = 1;
            this.labelDescriere.Text = "Descriere bug";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(0, 41);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(490, 134);
            this.textBoxDescription.TabIndex = 0;
            this.textBoxDescription.Text = "";
            // 
            // BuguriController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panelBug);
            this.Controls.Add(this.panelVerificator);
            this.Controls.Add(this.panelProgramator);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewPasi);
            this.Controls.Add(this.dataGridViewBuguri);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BuguriController";
            this.Size = new System.Drawing.Size(1000, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuguri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasi)).EndInit();
            this.panelProgramator.ResumeLayout(false);
            this.panelVerificator.ResumeLayout(false);
            this.panelBug.ResumeLayout(false);
            this.panelBug.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonInregistrareBug;
        private System.Windows.Forms.DataGridView dataGridViewBuguri;
        private System.Windows.Forms.Button buttonStergePas;
        private System.Windows.Forms.Button buttonModificaPas;
        private System.Windows.Forms.Button buttonAdaugaPas;
        private System.Windows.Forms.DataGridView dataGridViewPasi;
        private System.Windows.Forms.Button buttonVerificaBug;
        private System.Windows.Forms.Button buttonRezolvaBug;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelProgramator;
        private System.Windows.Forms.Panel panelVerificator;
        private System.Windows.Forms.RichTextBox textBoxTester;
        private System.Windows.Forms.Panel panelBug;
        private System.Windows.Forms.Label labelDescriere;
        private System.Windows.Forms.RichTextBox textBoxDescription;
        private System.Windows.Forms.RichTextBox textBoxReview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private Button buttonReview;
    }
}
