
namespace ERP_SERWIS.Forms
{
    partial class InstructionForm
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
            this.btnWroc = new System.Windows.Forms.Button();
            this.btnWrocInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWroc
            // 
            this.btnWroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWroc.Location = new System.Drawing.Point(226, 364);
            this.btnWroc.Name = "btnWroc";
            this.btnWroc.Size = new System.Drawing.Size(146, 40);
            this.btnWroc.TabIndex = 0;
            this.btnWroc.Text = "Wróć";
            this.btnWroc.UseVisualStyleBackColor = true;
            this.btnWroc.Click += new System.EventHandler(this.btnWroc_Click);
            // 
            // btnWrocInfo
            // 
            this.btnWrocInfo.Location = new System.Drawing.Point(110, 203);
            this.btnWrocInfo.Name = "btnWrocInfo";
            this.btnWrocInfo.Size = new System.Drawing.Size(97, 34);
            this.btnWrocInfo.TabIndex = 1;
            this.btnWrocInfo.Text = "Wróć";
            this.btnWrocInfo.UseVisualStyleBackColor = true;
            this.btnWrocInfo.Click += new System.EventHandler(this.btnWroc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dodanie edycja oraz usunięcię studenta\r\njest możliwe przez kliknięcię przycisku S" +
    "tudent.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 64);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dodanie lub usunięcie oceny jest możliwe \r\nprzez kliknięcie przycisku \'Oceny\' wyb" +
    "ranie\r\n z listy studenta, wpisanie oceny z wymagane \r\npole i kliknięcie w przyci" +
    "sk \'Dodaj ocene\'";
            // 
            // Instruction_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWrocInfo);
            this.Controls.Add(this.btnWroc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Instruction_Form";
            this.Text = "Instrukcja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWroc;
        private System.Windows.Forms.Button btnWrocInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}