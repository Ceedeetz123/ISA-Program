namespace Dogbytes
{
    partial class Form3
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
            this.cbAccID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccID = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEarlyLate = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEndYear = new System.Windows.Forms.ToolStripMenuItem();
            this.tssmChangeEOY = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAccID
            // 
            this.cbAccID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccID.FormattingEnabled = true;
            this.cbAccID.Location = new System.Drawing.Point(466, 90);
            this.cbAccID.Name = "cbAccID";
            this.cbAccID.Size = new System.Drawing.Size(121, 26);
            this.cbAccID.TabIndex = 1;
            this.cbAccID.SelectedIndexChanged += new System.EventHandler(this.cbAcc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account";
            // 
            // lblAccID
            // 
            this.lblAccID.AutoSize = true;
            this.lblAccID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccID.Location = new System.Drawing.Point(226, 162);
            this.lblAccID.Name = "lblAccID";
            this.lblAccID.Size = new System.Drawing.Size(131, 31);
            this.lblAccID.TabIndex = 3;
            this.lblAccID.Text = "Account ID";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNew.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.Location = new System.Drawing.Point(226, 268);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(211, 31);
            this.lblNew.TabIndex = 4;
            this.lblNew.Text = "New Accrued Rate";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrent.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(226, 212);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(243, 31);
            this.lblCurrent.TabIndex = 6;
            this.lblCurrent.Text = "Current Accured Rate";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(449, 345);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(163, 53);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit New Rates";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblEarlyLate
            // 
            this.lblEarlyLate.AutoSize = true;
            this.lblEarlyLate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEarlyLate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarlyLate.ForeColor = System.Drawing.Color.Maroon;
            this.lblEarlyLate.Location = new System.Drawing.Point(292, 410);
            this.lblEarlyLate.Name = "lblEarlyLate";
            this.lblEarlyLate.Size = new System.Drawing.Size(506, 24);
            this.lblEarlyLate.TabIndex = 8;
            this.lblEarlyLate.Text = "It is too late or too early to submit the new rates.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCustomer,
            this.tsmEndYear,
            this.tsmExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(150, 381);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmCustomer
            // 
            this.tsmCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCustView,
            this.tsmGrid});
            this.tsmCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmCustomer.Image = global::Dogbytes.Properties.Resources.eye;
            this.tsmCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmCustomer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmCustomer.Name = "tsmCustomer";
            this.tsmCustomer.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.tsmCustomer.Size = new System.Drawing.Size(149, 34);
            this.tsmCustomer.Text = "Customers";
            this.tsmCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tsmCustView
            // 
            this.tsmCustView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmCustView.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmCustView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmCustView.Name = "tsmCustView";
            this.tsmCustView.Size = new System.Drawing.Size(119, 26);
            this.tsmCustView.Text = "View";
            this.tsmCustView.Click += new System.EventHandler(this.tsmCustView_Click);
            // 
            // tsmGrid
            // 
            this.tsmGrid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmGrid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmGrid.Name = "tsmGrid";
            this.tsmGrid.Size = new System.Drawing.Size(119, 26);
            this.tsmGrid.Text = "Grid";
            this.tsmGrid.Click += new System.EventHandler(this.tsmGrid_Click);
            // 
            // tsmEndYear
            // 
            this.tsmEndYear.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssmChangeEOY});
            this.tsmEndYear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmEndYear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmEndYear.Image = global::Dogbytes.Properties.Resources.help;
            this.tsmEndYear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmEndYear.Name = "tsmEndYear";
            this.tsmEndYear.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.tsmEndYear.Size = new System.Drawing.Size(149, 34);
            this.tsmEndYear.Text = "End Of Year";
            this.tsmEndYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmEndYear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tssmChangeEOY
            // 
            this.tssmChangeEOY.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tssmChangeEOY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tssmChangeEOY.Name = "tssmChangeEOY";
            this.tssmChangeEOY.Size = new System.Drawing.Size(137, 26);
            this.tssmChangeEOY.Text = "Change";
            this.tssmChangeEOY.Click += new System.EventHandler(this.tssmChangeEOY_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmExit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmExit.Image = global::Dogbytes.Properties.Resources.exit;
            this.tsmExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmExit.Margin = new System.Windows.Forms.Padding(0, 160, 0, 0);
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.tsmExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsmExit.Size = new System.Drawing.Size(149, 34);
            this.tsmExit.Text = "Close";
            this.tsmExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmExit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(151, 381);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 68);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(151, 406);
            this.toolStripContainer1.TabIndex = 10;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(-4, -5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 77);
            this.label2.TabIndex = 11;
            this.label2.Text = "Outlaw Hess";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Overnight";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(979, 23);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTime
            // 
            this.tsslTime.BackColor = System.Drawing.Color.Transparent;
            this.tsslTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslTime.Margin = new System.Windows.Forms.Padding(550, 3, 0, 2);
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(41, 18);
            this.tsslTime.Text = "Time";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(854, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "Outlaw Hess";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Dogbytes.Properties.Resources.Drawing__1_;
            this.pictureBox1.Location = new System.Drawing.Point(892, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(979, 474);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.lblEarlyLate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblAccID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAccID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbAccID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccID;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblEarlyLate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmCustView;
        private System.Windows.Forms.ToolStripMenuItem tsmGrid;
        private System.Windows.Forms.ToolStripMenuItem tsmEndYear;
        private System.Windows.Forms.ToolStripMenuItem tssmChangeEOY;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}