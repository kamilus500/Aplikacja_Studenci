
namespace ERP_SERWIS.Forms
{
    partial class EdycjaStudenta
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datePickerEdit = new System.Windows.Forms.DateTimePicker();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEditNazwisko = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImieEdit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 337);
            this.groupBox2.TabIndex = 3;
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
            this.btnEdytuj.Location = new System.Drawing.Point(64, 271);
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
            // Edycja_Studenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 369);
            this.Controls.Add(this.groupBox2);
            this.Name = "Edycja_Studenta";
            this.Text = "Edycja_Studenta";
            this.Load += new System.EventHandler(this.Edycja_Studenta_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker datePickerEdit;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEditNazwisko;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImieEdit;
        private System.Windows.Forms.Label label8;
    }
}