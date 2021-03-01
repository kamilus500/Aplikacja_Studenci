
namespace ERP_SERWIS
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.VersionBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIntruction = new System.Windows.Forms.Button();
            this.btnOceny = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.mainDataGrid = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar,
            this.VersionBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBar
            // 
            this.StatusBar.Image = ((System.Drawing.Image)(resources.GetObject("StatusBar.Image")));
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(107, 17);
            this.StatusBar.Text = "Nie zalogowany";
            // 
            // VersionBar
            // 
            this.VersionBar.Image = ((System.Drawing.Image)(resources.GetObject("VersionBar.Image")));
            this.VersionBar.Name = "VersionBar";
            this.VersionBar.Size = new System.Drawing.Size(97, 17);
            this.VersionBar.Text = "Version 1.0.0.0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.PasswordBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.loginBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 433);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(55, 393);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(83, 26);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Wyloguj";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(55, 197);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(83, 26);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Zaloguj";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(28, 160);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(138, 20);
            this.PasswordBox.TabIndex = 5;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(62, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(28, 99);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(138, 20);
            this.loginBox.TabIndex = 3;
            this.loginBox.TextChanged += new System.EventHandler(this.loginBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(73, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "    Aplikacja\r\nERP SERWIS";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnIntruction);
            this.panel2.Controls.Add(this.btnOceny);
            this.panel2.Controls.Add(this.btnInfo);
            this.panel2.Controls.Add(this.mainDataGrid);
            this.panel2.Location = new System.Drawing.Point(204, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 433);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUsun);
            this.groupBox1.Controls.Add(this.btnEdytuj);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(3, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 46);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // btnUsun
            // 
            this.btnUsun.Image = ((System.Drawing.Image)(resources.GetObject("btnUsun.Image")));
            this.btnUsun.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsun.Location = new System.Drawing.Point(283, 12);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(100, 28);
            this.btnUsun.TabIndex = 2;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Image = ((System.Drawing.Image)(resources.GetObject("btnEdytuj.Image")));
            this.btnEdytuj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdytuj.Location = new System.Drawing.Point(177, 12);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(100, 28);
            this.btnEdytuj.TabIndex = 1;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Image = ((System.Drawing.Image)(resources.GetObject("btnDodaj.Image")));
            this.btnDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodaj.Location = new System.Drawing.Point(70, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 28);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIntruction
            // 
            this.btnIntruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIntruction.Location = new System.Drawing.Point(578, 6);
            this.btnIntruction.Name = "btnIntruction";
            this.btnIntruction.Size = new System.Drawing.Size(107, 31);
            this.btnIntruction.TabIndex = 3;
            this.btnIntruction.Text = "Instrukcja";
            this.btnIntruction.UseVisualStyleBackColor = true;
            this.btnIntruction.Click += new System.EventHandler(this.btnIntruction_Click);
            // 
            // btnOceny
            // 
            this.btnOceny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOceny.Image = ((System.Drawing.Image)(resources.GetObject("btnOceny.Image")));
            this.btnOceny.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOceny.Location = new System.Drawing.Point(428, 9);
            this.btnOceny.Name = "btnOceny";
            this.btnOceny.Size = new System.Drawing.Size(100, 28);
            this.btnOceny.TabIndex = 2;
            this.btnOceny.Text = "Oceny";
            this.btnOceny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOceny.UseVisualStyleBackColor = true;
            this.btnOceny.Click += new System.EventHandler(this.btnOceny_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(691, 6);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(107, 31);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Info";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // mainDataGrid
            // 
            this.mainDataGrid.AllowUserToAddRows = false;
            this.mainDataGrid.AllowUserToDeleteRows = false;
            this.mainDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGrid.Location = new System.Drawing.Point(3, 44);
            this.mainDataGrid.MultiSelect = false;
            this.mainDataGrid.Name = "mainDataGrid";
            this.mainDataGrid.ReadOnly = true;
            this.mainDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDataGrid.Size = new System.Drawing.Size(795, 386);
            this.mainDataGrid.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Aplikacja - ERP SERWIS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel VersionBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.DataGridView mainDataGrid;
        private System.Windows.Forms.Button btnOceny;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnIntruction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnDodaj;
    }
}

