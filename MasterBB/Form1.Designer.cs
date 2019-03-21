namespace MasterBB
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
            this.lstDBs = new System.Windows.Forms.ListBox();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.lstViews = new System.Windows.Forms.ListBox();
            this.lstSPs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDBs
            // 
            this.lstDBs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDBs.FormattingEnabled = true;
            this.lstDBs.ItemHeight = 18;
            this.lstDBs.Location = new System.Drawing.Point(12, 35);
            this.lstDBs.Name = "lstDBs";
            this.lstDBs.Size = new System.Drawing.Size(200, 382);
            this.lstDBs.TabIndex = 0;
            this.lstDBs.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstTables
            // 
            this.lstTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTables.FormattingEnabled = true;
            this.lstTables.ItemHeight = 18;
            this.lstTables.Location = new System.Drawing.Point(233, 35);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(200, 382);
            this.lstTables.TabIndex = 1;
            // 
            // lstViews
            // 
            this.lstViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViews.FormattingEnabled = true;
            this.lstViews.ItemHeight = 18;
            this.lstViews.Location = new System.Drawing.Point(452, 35);
            this.lstViews.Name = "lstViews";
            this.lstViews.Size = new System.Drawing.Size(200, 382);
            this.lstViews.TabIndex = 2;
            // 
            // lstSPs
            // 
            this.lstSPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSPs.FormattingEnabled = true;
            this.lstSPs.ItemHeight = 18;
            this.lstSPs.Location = new System.Drawing.Point(670, 35);
            this.lstSPs.Name = "lstSPs";
            this.lstSPs.Size = new System.Drawing.Size(200, 382);
            this.lstSPs.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Bases";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tables";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Views";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(667, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "SPs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSPs);
            this.Controls.Add(this.lstViews);
            this.Controls.Add(this.lstTables);
            this.Controls.Add(this.lstDBs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDBs;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.ListBox lstViews;
        private System.Windows.Forms.ListBox lstSPs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

