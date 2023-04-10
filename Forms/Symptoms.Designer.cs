namespace OPD_Section
{
    partial class Symptoms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Col_Sym_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col__Sym_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSymptomRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSymptomBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSymptomCancle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnSymptomNext = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnSymptomAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 60;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Sym_Name,
            this.Col__Sym_Desc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(716, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(813, 793);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Col_Sym_Name
            // 
            this.Col_Sym_Name.HeaderText = "Symptom Name ";
            this.Col_Sym_Name.MinimumWidth = 6;
            this.Col_Sym_Name.Name = "Col_Sym_Name";
            this.Col_Sym_Name.ReadOnly = true;
            this.Col_Sym_Name.Width = 300;
            // 
            // Col__Sym_Desc
            // 
            this.Col__Sym_Desc.HeaderText = "Description";
            this.Col__Sym_Desc.MinimumWidth = 6;
            this.Col__Sym_Desc.Name = "Col__Sym_Desc";
            this.Col__Sym_Desc.ReadOnly = true;
            this.Col__Sym_Desc.Width = 500;
            // 
            // BtnSymptomRemove
            // 
            this.BtnSymptomRemove.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.BtnSymptomRemove.Location = new System.Drawing.Point(394, 581);
            this.BtnSymptomRemove.Name = "BtnSymptomRemove";
            this.BtnSymptomRemove.Size = new System.Drawing.Size(204, 56);
            this.BtnSymptomRemove.TabIndex = 67;
            this.BtnSymptomRemove.Text = "REMOVE";
            this.BtnSymptomRemove.UseVisualStyleBackColor = true;
            this.BtnSymptomRemove.Click += new System.EventHandler(this.BtnSymptomRemove_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 42);
            this.label1.TabIndex = 57;
            this.label1.Text = "Symptoms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 33);
            this.label2.TabIndex = 62;
            this.label2.Text = "Symptom Name";
            // 
            // BtnSymptomBack
            // 
            this.BtnSymptomBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.BtnSymptomBack.Location = new System.Drawing.Point(247, 714);
            this.BtnSymptomBack.Name = "BtnSymptomBack";
            this.BtnSymptomBack.Size = new System.Drawing.Size(242, 62);
            this.BtnSymptomBack.TabIndex = 61;
            this.BtnSymptomBack.Text = "BACK";
            this.BtnSymptomBack.UseVisualStyleBackColor = true;
            this.BtnSymptomBack.Click += new System.EventHandler(this.BtnSymptomBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(142, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 19);
            this.label5.TabIndex = 69;
            this.label5.Text = "*This Field is Required!";
            this.label5.Visible = false;
            // 
            // BtnSymptomCancle
            // 
            this.BtnSymptomCancle.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.BtnSymptomCancle.Location = new System.Drawing.Point(13, 714);
            this.BtnSymptomCancle.Name = "BtnSymptomCancle";
            this.BtnSymptomCancle.Size = new System.Drawing.Size(228, 62);
            this.BtnSymptomCancle.TabIndex = 60;
            this.BtnSymptomCancle.Text = "CANCLE";
            this.BtnSymptomCancle.UseVisualStyleBackColor = true;
            this.BtnSymptomCancle.Click += new System.EventHandler(this.BtnSymptomCancle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.textBox1.Location = new System.Drawing.Point(142, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(408, 39);
            this.textBox1.TabIndex = 63;
            // 
            // BtnSymptomNext
            // 
            this.BtnSymptomNext.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.BtnSymptomNext.Location = new System.Drawing.Point(495, 714);
            this.BtnSymptomNext.Name = "BtnSymptomNext";
            this.BtnSymptomNext.Size = new System.Drawing.Size(215, 62);
            this.BtnSymptomNext.TabIndex = 59;
            this.BtnSymptomNext.Text = "NEXT";
            this.BtnSymptomNext.UseVisualStyleBackColor = true;
            this.BtnSymptomNext.Click += new System.EventHandler(this.BtnSymptomNext_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(142, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 19);
            this.label4.TabIndex = 68;
            this.label4.Text = "*This Field is Required!";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 33);
            this.label3.TabIndex = 64;
            this.label3.Text = "Description";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.richTextBox1.Location = new System.Drawing.Point(142, 284);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 226);
            this.richTextBox1.TabIndex = 65;
            this.richTextBox1.Text = "";
            // 
            // BtnSymptomAdd
            // 
            this.BtnSymptomAdd.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.BtnSymptomAdd.Location = new System.Drawing.Point(142, 581);
            this.BtnSymptomAdd.Name = "BtnSymptomAdd";
            this.BtnSymptomAdd.Size = new System.Drawing.Size(204, 56);
            this.BtnSymptomAdd.TabIndex = 66;
            this.BtnSymptomAdd.Text = "ADD";
            this.BtnSymptomAdd.UseVisualStyleBackColor = true;
            this.BtnSymptomAdd.Click += new System.EventHandler(this.BtnSymptomAdd_Click_2);
            // 
            // Symptoms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 793);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSymptomRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSymptomBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSymptomCancle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnSymptomNext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnSymptomAdd);
            this.Name = "Symptoms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symptoms";
            this.Load += new System.EventHandler(this.Symptoms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Sym_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col__Sym_Desc;
        private System.Windows.Forms.Button BtnSymptomRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSymptomBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSymptomCancle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnSymptomNext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnSymptomAdd;
    }
}