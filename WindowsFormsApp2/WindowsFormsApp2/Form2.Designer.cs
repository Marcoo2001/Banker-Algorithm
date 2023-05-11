
namespace WindowsFormsApp2
{
    partial class Form2
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
            this.current_allocated_table = new System.Windows.Forms.DataGridView();
            this.filling_table_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.available_ressources_table = new System.Windows.Forms.DataGridView();
            this.total_ressources_table = new System.Windows.Forms.DataGridView();
            this.maximum_need_table = new System.Windows.Forms.DataGridView();
            this.assume_label = new System.Windows.Forms.Label();
            this.requests_label = new System.Windows.Forms.Label();
            this.ressources_of_type_label = new System.Windows.Forms.Label();
            this.request_ressources_txt = new System.Windows.Forms.TextBox();
            this.processes_combobox = new System.Windows.Forms.ComboBox();
            this.ressources_combobox = new System.Windows.Forms.ComboBox();
            this.optional_label = new System.Windows.Forms.Label();
            this.enter_button = new System.Windows.Forms.Button();
            this.Finish_button = new System.Windows.Forms.Button();
            this.remain_need_label = new System.Windows.Forms.Label();
            this.remain_need_table = new System.Windows.Forms.DataGridView();
            this.safe_unsafe_label = new System.Windows.Forms.Label();
            this.sequence_label = new System.Windows.Forms.Label();
            this.steps_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.current_allocated_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.available_ressources_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_ressources_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximum_need_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remain_need_table)).BeginInit();
            this.SuspendLayout();
            // 
            // current_allocated_table
            // 
            this.current_allocated_table.AllowUserToAddRows = false;
            this.current_allocated_table.AllowUserToResizeColumns = false;
            this.current_allocated_table.AllowUserToResizeRows = false;
            this.current_allocated_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.current_allocated_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.current_allocated_table.BackgroundColor = System.Drawing.Color.White;
            this.current_allocated_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.current_allocated_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.current_allocated_table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.current_allocated_table.Location = new System.Drawing.Point(27, 329);
            this.current_allocated_table.Name = "current_allocated_table";
            this.current_allocated_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.current_allocated_table.RowTemplate.Height = 24;
            this.current_allocated_table.Size = new System.Drawing.Size(369, 224);
            this.current_allocated_table.TabIndex = 0;
            // 
            // filling_table_label
            // 
            this.filling_table_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filling_table_label.Location = new System.Drawing.Point(484, 18);
            this.filling_table_label.Name = "filling_table_label";
            this.filling_table_label.Size = new System.Drawing.Size(431, 47);
            this.filling_table_label.TabIndex = 5;
            this.filling_table_label.Text = "Please fill the tables";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Ressources";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 47);
            this.label3.TabIndex = 7;
            this.label3.Text = "Available Ressources";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 47);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current Allocated";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(512, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(431, 47);
            this.label5.TabIndex = 9;
            this.label5.Text = "Maximum Need ";
            // 
            // available_ressources_table
            // 
            this.available_ressources_table.AllowUserToAddRows = false;
            this.available_ressources_table.AllowUserToResizeColumns = false;
            this.available_ressources_table.AllowUserToResizeRows = false;
            this.available_ressources_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.available_ressources_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.available_ressources_table.BackgroundColor = System.Drawing.Color.White;
            this.available_ressources_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.available_ressources_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.available_ressources_table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.available_ressources_table.Location = new System.Drawing.Point(517, 145);
            this.available_ressources_table.Name = "available_ressources_table";
            this.available_ressources_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.available_ressources_table.RowTemplate.Height = 24;
            this.available_ressources_table.Size = new System.Drawing.Size(326, 59);
            this.available_ressources_table.TabIndex = 10;
            // 
            // total_ressources_table
            // 
            this.total_ressources_table.AllowUserToAddRows = false;
            this.total_ressources_table.AllowUserToResizeColumns = false;
            this.total_ressources_table.AllowUserToResizeRows = false;
            this.total_ressources_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.total_ressources_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.total_ressources_table.BackgroundColor = System.Drawing.Color.White;
            this.total_ressources_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total_ressources_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.total_ressources_table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.total_ressources_table.Location = new System.Drawing.Point(27, 145);
            this.total_ressources_table.Name = "total_ressources_table";
            this.total_ressources_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.total_ressources_table.RowTemplate.Height = 24;
            this.total_ressources_table.Size = new System.Drawing.Size(369, 59);
            this.total_ressources_table.TabIndex = 11;
            // 
            // maximum_need_table
            // 
            this.maximum_need_table.AllowUserToAddRows = false;
            this.maximum_need_table.AllowUserToResizeColumns = false;
            this.maximum_need_table.AllowUserToResizeRows = false;
            this.maximum_need_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.maximum_need_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.maximum_need_table.BackgroundColor = System.Drawing.Color.White;
            this.maximum_need_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maximum_need_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maximum_need_table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.maximum_need_table.Location = new System.Drawing.Point(517, 329);
            this.maximum_need_table.Name = "maximum_need_table";
            this.maximum_need_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.maximum_need_table.RowTemplate.Height = 24;
            this.maximum_need_table.Size = new System.Drawing.Size(364, 224);
            this.maximum_need_table.TabIndex = 12;
            // 
            // assume_label
            // 
            this.assume_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assume_label.Location = new System.Drawing.Point(22, 601);
            this.assume_label.Name = "assume_label";
            this.assume_label.Size = new System.Drawing.Size(96, 31);
            this.assume_label.TabIndex = 14;
            this.assume_label.Text = "Assume";
            // 
            // requests_label
            // 
            this.requests_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requests_label.Location = new System.Drawing.Point(201, 599);
            this.requests_label.Name = "requests_label";
            this.requests_label.Size = new System.Drawing.Size(108, 33);
            this.requests_label.TabIndex = 15;
            this.requests_label.Text = "Requests";
            // 
            // ressources_of_type_label
            // 
            this.ressources_of_type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ressources_of_type_label.Location = new System.Drawing.Point(378, 597);
            this.ressources_of_type_label.Name = "ressources_of_type_label";
            this.ressources_of_type_label.Size = new System.Drawing.Size(201, 35);
            this.ressources_of_type_label.TabIndex = 16;
            this.ressources_of_type_label.Text = "ressources of type ";
            // 
            // request_ressources_txt
            // 
            this.request_ressources_txt.Location = new System.Drawing.Point(305, 601);
            this.request_ressources_txt.Name = "request_ressources_txt";
            this.request_ressources_txt.Size = new System.Drawing.Size(56, 22);
            this.request_ressources_txt.TabIndex = 17;
            // 
            // processes_combobox
            // 
            this.processes_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processes_combobox.FormattingEnabled = true;
            this.processes_combobox.Location = new System.Drawing.Point(124, 603);
            this.processes_combobox.Name = "processes_combobox";
            this.processes_combobox.Size = new System.Drawing.Size(70, 24);
            this.processes_combobox.TabIndex = 18;
            // 
            // ressources_combobox
            // 
            this.ressources_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ressources_combobox.FormattingEnabled = true;
            this.ressources_combobox.Location = new System.Drawing.Point(585, 599);
            this.ressources_combobox.Name = "ressources_combobox";
            this.ressources_combobox.Size = new System.Drawing.Size(70, 24);
            this.ressources_combobox.TabIndex = 19;
            // 
            // optional_label
            // 
            this.optional_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optional_label.Location = new System.Drawing.Point(683, 599);
            this.optional_label.Name = "optional_label";
            this.optional_label.Size = new System.Drawing.Size(118, 30);
            this.optional_label.TabIndex = 20;
            this.optional_label.Text = "( Optional )";
            // 
            // enter_button
            // 
            this.enter_button.Location = new System.Drawing.Point(799, 599);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(82, 30);
            this.enter_button.TabIndex = 21;
            this.enter_button.Text = "Enter";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // Finish_button
            // 
            this.Finish_button.BackColor = System.Drawing.Color.White;
            this.Finish_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finish_button.Location = new System.Drawing.Point(692, 669);
            this.Finish_button.Name = "Finish_button";
            this.Finish_button.Size = new System.Drawing.Size(109, 36);
            this.Finish_button.TabIndex = 22;
            this.Finish_button.Text = "Finish";
            this.Finish_button.UseVisualStyleBackColor = false;
            this.Finish_button.Click += new System.EventHandler(this.Finish_button_Click);
            // 
            // remain_need_label
            // 
            this.remain_need_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remain_need_label.Location = new System.Drawing.Point(1028, 82);
            this.remain_need_label.Name = "remain_need_label";
            this.remain_need_label.Size = new System.Drawing.Size(270, 37);
            this.remain_need_label.TabIndex = 23;
            this.remain_need_label.Text = "Remain need";
            this.remain_need_label.Visible = false;
            // 
            // remain_need_table
            // 
            this.remain_need_table.AllowUserToAddRows = false;
            this.remain_need_table.AllowUserToResizeColumns = false;
            this.remain_need_table.AllowUserToResizeRows = false;
            this.remain_need_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.remain_need_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.remain_need_table.BackgroundColor = System.Drawing.Color.White;
            this.remain_need_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remain_need_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.remain_need_table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.remain_need_table.Location = new System.Drawing.Point(961, 145);
            this.remain_need_table.Name = "remain_need_table";
            this.remain_need_table.ReadOnly = true;
            this.remain_need_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.remain_need_table.RowTemplate.Height = 24;
            this.remain_need_table.Size = new System.Drawing.Size(364, 224);
            this.remain_need_table.TabIndex = 24;
            this.remain_need_table.Visible = false;
            // 
            // safe_unsafe_label
            // 
            this.safe_unsafe_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safe_unsafe_label.Location = new System.Drawing.Point(961, 391);
            this.safe_unsafe_label.Name = "safe_unsafe_label";
            this.safe_unsafe_label.Size = new System.Drawing.Size(359, 54);
            this.safe_unsafe_label.TabIndex = 27;
            this.safe_unsafe_label.Visible = false;
            // 
            // sequence_label
            // 
            this.sequence_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sequence_label.Location = new System.Drawing.Point(961, 487);
            this.sequence_label.Name = "sequence_label";
            this.sequence_label.Size = new System.Drawing.Size(364, 54);
            this.sequence_label.TabIndex = 28;
            this.sequence_label.Text = "The sequence is :";
            this.sequence_label.Visible = false;
            // 
            // steps_button
            // 
            this.steps_button.BackColor = System.Drawing.Color.White;
            this.steps_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steps_button.Location = new System.Drawing.Point(1229, 663);
            this.steps_button.Name = "steps_button";
            this.steps_button.Size = new System.Drawing.Size(124, 53);
            this.steps_button.TabIndex = 29;
            this.steps_button.Text = "Steps ";
            this.steps_button.UseVisualStyleBackColor = false;
            this.steps_button.Visible = false;
            this.steps_button.Click += new System.EventHandler(this.steps_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1391, 765);
            this.Controls.Add(this.steps_button);
            this.Controls.Add(this.sequence_label);
            this.Controls.Add(this.safe_unsafe_label);
            this.Controls.Add(this.remain_need_table);
            this.Controls.Add(this.remain_need_label);
            this.Controls.Add(this.Finish_button);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.optional_label);
            this.Controls.Add(this.ressources_combobox);
            this.Controls.Add(this.processes_combobox);
            this.Controls.Add(this.request_ressources_txt);
            this.Controls.Add(this.ressources_of_type_label);
            this.Controls.Add(this.requests_label);
            this.Controls.Add(this.assume_label);
            this.Controls.Add(this.maximum_need_table);
            this.Controls.Add(this.total_ressources_table);
            this.Controls.Add(this.available_ressources_table);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filling_table_label);
            this.Controls.Add(this.current_allocated_table);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.current_allocated_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.available_ressources_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_ressources_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximum_need_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remain_need_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView current_allocated_table;
        public System.Windows.Forms.Label filling_table_label;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView available_ressources_table;
        private System.Windows.Forms.DataGridView total_ressources_table;
        private System.Windows.Forms.DataGridView maximum_need_table;
        public System.Windows.Forms.Label assume_label;
        public System.Windows.Forms.Label requests_label;
        public System.Windows.Forms.Label ressources_of_type_label;
        private System.Windows.Forms.TextBox request_ressources_txt;
        private System.Windows.Forms.ComboBox processes_combobox;
        private System.Windows.Forms.ComboBox ressources_combobox;
        public System.Windows.Forms.Label optional_label;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Button Finish_button;
        public System.Windows.Forms.Label remain_need_label;
        private System.Windows.Forms.DataGridView remain_need_table;
        public System.Windows.Forms.Label safe_unsafe_label;
        public System.Windows.Forms.Label sequence_label;
        private System.Windows.Forms.Button steps_button;
    }
}