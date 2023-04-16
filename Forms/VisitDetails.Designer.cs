namespace OPD_Section
{
    partial class VisitDetails
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.vILLAGESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PID_combo = new System.Windows.Forms.ComboBox();
            this.HNO_combo = new System.Windows.Forms.ComboBox();
            this.V_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.BackBtnVisitDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vILLAGESBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visit Details";
            // 
            // vILLAGESBindingSource
            // 
            this.vILLAGESBindingSource.DataMember = "VILLAGES";
            // 
            // PID_combo
            // 
            this.PID_combo.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.PID_combo.FormattingEnabled = true;
            this.PID_combo.Items.AddRange(new object[] {
            "Select House No. First"});
            this.PID_combo.Location = new System.Drawing.Point(224, 404);
            this.PID_combo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PID_combo.Name = "PID_combo";
            this.PID_combo.Size = new System.Drawing.Size(236, 39);
            this.PID_combo.TabIndex = 49;
            this.PID_combo.SelectedIndexChanged += new System.EventHandler(this.PID_combo_SelectedIndexChanged_1);
            // 
            // HNO_combo
            // 
            this.HNO_combo.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.HNO_combo.FormattingEnabled = true;
            this.HNO_combo.Items.AddRange(new object[] {
            "Select Village First!"});
            this.HNO_combo.Location = new System.Drawing.Point(224, 309);
            this.HNO_combo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HNO_combo.Name = "HNO_combo";
            this.HNO_combo.Size = new System.Drawing.Size(236, 39);
            this.HNO_combo.TabIndex = 48;
            this.HNO_combo.SelectedIndexChanged += new System.EventHandler(this.HNO_combo_SelectedIndexChanged_1);
            // 
            // V_combo
            // 
            this.V_combo.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.V_combo.FormattingEnabled = true;
            this.V_combo.Location = new System.Drawing.Point(224, 215);
            this.V_combo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.V_combo.Name = "V_combo";
            this.V_combo.Size = new System.Drawing.Size(236, 39);
            this.V_combo.TabIndex = 47;
            this.V_combo.SelectedIndexChanged += new System.EventHandler(this.V_combo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 33);
            this.label4.TabIndex = 42;
            this.label4.Text = "Person ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 33);
            this.label3.TabIndex = 41;
            this.label3.Text = "House No. : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 33);
            this.label2.TabIndex = 40;
            this.label2.Text = "Village : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 560);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 75);
            this.panel1.TabIndex = 50;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BackBtnVisitDetails);
            this.splitContainer1.Size = new System.Drawing.Size(500, 75);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "CANCLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackBtnVisitDetails
            // 
            this.BackBtnVisitDetails.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackBtnVisitDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackBtnVisitDetails.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.BackBtnVisitDetails.Location = new System.Drawing.Point(0, 0);
            this.BackBtnVisitDetails.Name = "BackBtnVisitDetails";
            this.BackBtnVisitDetails.Size = new System.Drawing.Size(306, 75);
            this.BackBtnVisitDetails.TabIndex = 1;
            this.BackBtnVisitDetails.Text = "BACK";
            this.BackBtnVisitDetails.UseVisualStyleBackColor = false;
            this.BackBtnVisitDetails.Click += new System.EventHandler(this.button2_Click);
            // 
            // VisitDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(500, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PID_combo);
            this.Controls.Add(this.HNO_combo);
            this.Controls.Add(this.V_combo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VisitDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "b";
            this.Load += new System.EventHandler(this.VisitDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vILLAGESBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vILLAGESBindingSource;
        private System.Windows.Forms.ComboBox PID_combo;
        private System.Windows.Forms.ComboBox HNO_combo;
        private System.Windows.Forms.ComboBox V_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackBtnVisitDetails;
    }
}