
namespace ERP_SERWIS.Forms
{
    partial class Student_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUsun = new System.Windows.Forms.Button();
            this.dataGridStudent = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datePickerEdit = new System.Windows.Forms.DateTimePicker();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEditNazwisko = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImieEdit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 561);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUsun);
            this.groupBox3.Controls.Add(this.dataGridStudent);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(499, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 456);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usunięcie Studenta";
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(178, 369);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(108, 44);
            this.btnUsun.TabIndex = 1;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // dataGridStudent
            // 
            this.dataGridStudent.AllowUserToAddRows = false;
            this.dataGridStudent.AllowUserToDeleteRows = false;
            this.dataGridStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudent.Location = new System.Drawing.Point(6, 26);
            this.dataGridStudent.MultiSelect = false;
            this.dataGridStudent.Name = "dataGridStudent";
            this.dataGridStudent.ReadOnly = true;
            this.dataGridStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStudent.Size = new System.Drawing.Size(461, 327);
            this.dataGridStudent.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datePickerEdit);
            this.groupBox2.Controls.Add(this.btnEdytuj);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtEditNazwisko);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtImieEdit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(250, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 456);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edycja Studenta";
            // 
            // datePickerEdit
            // 
            this.datePickerEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datePickerEdit.Location = new System.Drawing.Point(13, 205);
            this.datePickerEdit.Name = "datePickerEdit";
            this.datePickerEdit.Size = new System.Drawing.Size(215, 20);
            this.datePickerEdit.TabIndex = 18;
            this.datePickerEdit.ValueChanged += new System.EventHandler(this.datePickerEdit_ValueChanged);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(70, 369);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(108, 44);
            this.btnEdytuj.TabIndex = 17;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Data urodzenia";
            // 
            // txtEditNazwisko
            // 
            this.txtEditNazwisko.Location = new System.Drawing.Point(13, 127);
            this.txtEditNazwisko.Name = "txtEditNazwisko";
            this.txtEditNazwisko.Size = new System.Drawing.Size(215, 26);
            this.txtEditNazwisko.TabIndex = 15;
            this.txtEditNazwisko.TextChanged += new System.EventHandler(this.txtEditNazwisko_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nazwisko";
            // 
            // txtImieEdit
            // 
            this.txtImieEdit.Location = new System.Drawing.Point(13, 75);
            this.txtImieEdit.Name = "txtImieEdit";
            this.txtImieEdit.Size = new System.Drawing.Size(215, 26);
            this.txtImieEdit.TabIndex = 11;
            this.txtImieEdit.TextChanged += new System.EventHandler(this.txtImieEdit_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Imie";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(677, 508);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 41);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Wróć";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNazwisko);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIndex);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtImie);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodanie Studenta";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Location = new System.Drawing.Point(6, 231);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(63, 369);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(108, 44);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data urodzenia";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(6, 127);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(215, 26);
            this.txtNazwisko.TabIndex = 5;
            this.txtNazwisko.TextChanged += new System.EventHandler(this.txtNazwisko_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numer Indeksu";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(6, 179);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(215, 26);
            this.txtIndex.TabIndex = 3;
            this.txtIndex.TextChanged += new System.EventHandler(this.txtIndex_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(6, 75);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(215, 26);
            this.txtImie.TabIndex = 1;
            this.txtImie.TextChanged += new System.EventHandler(this.txtImie_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Student_Form";
            this.Text = "Formularz Studenta";
            this.Load += new System.EventHandler(this.Student_Form_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker datePickerEdit;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEditNazwisko;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImieEdit;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridStudent;
        private System.Windows.Forms.Button btnUsun;
    }
}