namespace OPD_Section
{
    partial class Notes
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
            this.sriealno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSymptomRemove = new System.Windows.Forms.Button();
            this.BtnSymptomAdd = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSymptomBack = new System.Windows.Forms.Button();
            this.BtnSymptomCancle = new System.Windows.Forms.Button();
            this.BtnSymptomNext = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.sriealno,
            this.Description});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(704, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(825, 793);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sriealno
            // 
            this.sriealno.FillWeight = 96.25668F;
            this.sriealno.HeaderText = "Sr. No.";
            this.sriealno.MinimumWidth = 6;
            this.sriealno.Name = "sriealno";
            this.sriealno.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.FillWeight = 103.7433F;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 42);
            this.label2.TabIndex = 36;
            this.label2.Text = "Note";
            // 
            // BtnSymptomRemove
            // 
            this.BtnSymptomRemove.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.BtnSymptomRemove.Location = new System.Drawing.Point(388, 568);
            this.BtnSymptomRemove.Name = "BtnSymptomRemove";
            this.BtnSymptomRemove.Size = new System.Drawing.Size(169, 56);
            this.BtnSymptomRemove.TabIndex = 43;
            this.BtnSymptomRemove.Text = "REMOVE";
            this.BtnSymptomRemove.UseVisualStyleBackColor = true;
            this.BtnSymptomRemove.Click += new System.EventHandler(this.BtnSymptomRemove_Click);
            // 
            // BtnSymptomAdd
            // 
            this.BtnSymptomAdd.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.BtnSymptomAdd.Location = new System.Drawing.Point(114, 568);
            this.BtnSymptomAdd.Name = "BtnSymptomAdd";
            this.BtnSymptomAdd.Size = new System.Drawing.Size(169, 56);
            this.BtnSymptomAdd.TabIndex = 42;
            this.BtnSymptomAdd.Text = "ADD";
            this.BtnSymptomAdd.UseVisualStyleBackColor = true;
            this.BtnSymptomAdd.Click += new System.EventHandler(this.BtnSymptomAdd_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.richTextBox1.Location = new System.Drawing.Point(133, 210);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(390, 287);
            this.richTextBox1.TabIndex = 41;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 40;
            this.label1.Text = "Note Description";
            // 
            // BtnSymptomBack
            // 
            this.BtnSymptomBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.BtnSymptomBack.Location = new System.Drawing.Point(235, 731);
            this.BtnSymptomBack.Name = "BtnSymptomBack";
            this.BtnSymptomBack.Size = new System.Drawing.Size(242, 62);
            this.BtnSymptomBack.TabIndex = 67;
            this.BtnSymptomBack.Text = "BACK";
            this.BtnSymptomBack.UseVisualStyleBackColor = true;
            this.BtnSymptomBack.Click += new System.EventHandler(this.BtnSymptomBack_Click_1);
            // 
            // BtnSymptomCancle
            // 
            this.BtnSymptomCancle.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.BtnSymptomCancle.Location = new System.Drawing.Point(1, 731);
            this.BtnSymptomCancle.Name = "BtnSymptomCancle";
            this.BtnSymptomCancle.Size = new System.Drawing.Size(228, 62);
            this.BtnSymptomCancle.TabIndex = 66;
            this.BtnSymptomCancle.Text = "CANCLE";
            this.BtnSymptomCancle.UseVisualStyleBackColor = true;
            this.BtnSymptomCancle.Click += new System.EventHandler(this.BtnSymptomCancle_Click_1);
            // 
            // BtnSymptomNext
            // 
            this.BtnSymptomNext.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.BtnSymptomNext.Location = new System.Drawing.Point(483, 731);
            this.BtnSymptomNext.Name = "BtnSymptomNext";
            this.BtnSymptomNext.Size = new System.Drawing.Size(215, 62);
            this.BtnSymptomNext.TabIndex = 65;
            this.BtnSymptomNext.Text = "NEXT";
            this.BtnSymptomNext.UseVisualStyleBackColor = true;
            this.BtnSymptomNext.Click += new System.EventHandler(this.BtnSymptomNext_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(129, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 19);
            this.label4.TabIndex = 70;
            this.label4.Text = "*This Field is Required!";
            this.label4.Visible = false;
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 793);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSymptomBack);
            this.Controls.Add(this.BtnSymptomCancle);
            this.Controls.Add(this.BtnSymptomNext);
            this.Controls.Add(this.BtnSymptomRemove);
            this.Controls.Add(this.BtnSymptomAdd);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sriealno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSymptomRemove;
        private System.Windows.Forms.Button BtnSymptomAdd;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSymptomBack;
        private System.Windows.Forms.Button BtnSymptomCancle;
        private System.Windows.Forms.Button BtnSymptomNext;
        private System.Windows.Forms.Label label4;
    }
}