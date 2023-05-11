
namespace WindowsFormsApp2
{
    partial class Form1
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
            this.processes_txt = new System.Windows.Forms.TextBox();
            this.ressources_txt = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processes_txt
            // 
            this.processes_txt.Location = new System.Drawing.Point(545, 189);
            this.processes_txt.Name = "processes_txt";
            this.processes_txt.Size = new System.Drawing.Size(100, 22);
            this.processes_txt.TabIndex = 0;
            // 
            // ressources_txt
            // 
            this.ressources_txt.Location = new System.Drawing.Point(545, 271);
            this.ressources_txt.Name = "ressources_txt";
            this.ressources_txt.Size = new System.Drawing.Size(100, 22);
            this.ressources_txt.TabIndex = 1;
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.White;
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(370, 356);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(95, 29);
            this.Enter.TabIndex = 2;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 77);
            this.label1.TabIndex = 3;
            this.label1.Text = "Banker\'s Algorithm";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please enter the number of processes ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please enter the number of ressources";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.ressources_txt);
            this.Controls.Add(this.processes_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox processes_txt;
        private System.Windows.Forms.TextBox ressources_txt;
        private System.Windows.Forms.Button Enter;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
    }
}

