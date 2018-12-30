namespace Dogbytes
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbAccID = new System.Windows.Forms.ComboBox();
            this.lblAccID = new System.Windows.Forms.Label();
            this.lblAccrued = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCurrBal = new System.Windows.Forms.Label();
            this.lblNewBal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOverNight = new System.Windows.Forms.ToolStripMenuItem();
            this.tssmChangeOver = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripContainer2.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // cbAccID
            // 
            this.cbAccID.FormattingEnabled = true;
            this.cbAccID.Location = new System.Drawing.Point(448, 71);
            this.cbAccID.Name = "cbAccID";
            this.cbAccID.Size = new System.Drawing.Size(121, 23);
            this.cbAccID.TabIndex = 1;
            this.cbAccID.SelectedIndexChanged += new System.EventHandler(this.cbAccID_SelectedIndexChanged);
            // 
            // lblAccID
            // 
            this.lblAccID.AutoSize = true;
            this.lblAccID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccID.Location = new System.Drawing.Point(257, 119);
            this.lblAccID.Name = "lblAccID";
            this.lblAccID.Size = new System.Drawing.Size(109, 26);
            this.lblAccID.TabIndex = 2;
            this.lblAccID.Text = "Account ID";
            // 
            // lblAccrued
            // 
            this.lblAccrued.AutoSize = true;
            this.lblAccrued.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccrued.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccrued.Location = new System.Drawing.Point(257, 166);
            this.lblAccrued.Name = "lblAccrued";
            this.lblAccrued.Size = new System.Drawing.Size(158, 26);
            this.lblAccrued.TabIndex = 3;
            this.lblAccrued.Text = "Accrued Interest";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDep.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.Location = new System.Drawing.Point(257, 217);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(80, 26);
            this.lblDep.TabIndex = 4;
            this.lblDep.Text = "Deposit";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Transparent;
            this.btnSubmit.Location = new System.Drawing.Point(397, 369);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 55);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Run Updates";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCurrBal
            // 
            this.lblCurrBal.AutoSize = true;
            this.lblCurrBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrBal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrBal.Location = new System.Drawing.Point(257, 263);
            this.lblCurrBal.Name = "lblCurrBal";
            this.lblCurrBal.Size = new System.Drawing.Size(154, 26);
            this.lblCurrBal.TabIndex = 7;
            this.lblCurrBal.Text = "Current Balance";
            // 
            // lblNewBal
            // 
            this.lblNewBal.AutoSize = true;
            this.lblNewBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNewBal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBal.Location = new System.Drawing.Point(257, 314);
            this.lblNewBal.Name = "lblNewBal";
            this.lblNewBal.Size = new System.Drawing.Size(127, 26);
            this.lblNewBal.TabIndex = 8;
            this.lblNewBal.Text = "New Balance";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(-1, -4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 77);
            this.label2.TabIndex = 12;
            this.label2.Text = "Outlaw Hess";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCustomer,
            this.tsmOverNight,
            this.tsmExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(119, 393);
            this.menuStrip1.TabIndex = 13;
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
            this.tsmCustomer.Size = new System.Drawing.Size(118, 34);
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
            this.tsmCustView.Size = new System.Drawing.Size(216, 26);
            this.tsmCustView.Text = "View";
            this.tsmCustView.Click += new System.EventHandler(this.tsmCustView_Click);
            // 
            // tsmGrid
            // 
            this.tsmGrid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmGrid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmGrid.Name = "tsmGrid";
            this.tsmGrid.Size = new System.Drawing.Size(216, 26);
            this.tsmGrid.Text = "Grid";
            this.tsmGrid.Click += new System.EventHandler(this.tsmGrid_Click);
            // 
            // tsmOverNight
            // 
            this.tsmOverNight.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssmChangeOver});
            this.tsmOverNight.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmOverNight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmOverNight.Image = global::Dogbytes.Properties.Resources.help;
            this.tsmOverNight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmOverNight.Name = "tsmOverNight";
            this.tsmOverNight.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.tsmOverNight.Size = new System.Drawing.Size(118, 34);
            this.tsmOverNight.Text = "Overnight";
            this.tsmOverNight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmOverNight.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tssmChangeOver
            // 
            this.tssmChangeOver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tssmChangeOver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tssmChangeOver.Name = "tssmChangeOver";
            this.tssmChangeOver.Size = new System.Drawing.Size(216, 26);
            this.tssmChangeOver.Text = "Change";
            this.tssmChangeOver.Click += new System.EventHandler(this.tssmChangeOver_Click);
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
            this.tsmExit.Size = new System.Drawing.Size(118, 34);
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(2, 77);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 14;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(78, 393);
            // 
            // toolStripContainer2.LeftToolStripPanel
            // 
            this.toolStripContainer2.LeftToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer2.Location = new System.Drawing.Point(-1, 71);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(197, 418);
            this.toolStripContainer2.TabIndex = 15;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "End Of Year";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslDate
            // 
            this.tsslDate.Name = "tsslDate";
            this.tsslDate.Size = new System.Drawing.Size(42, 20);
            this.tsslDate.Text = "Time";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(679, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Outlaw Hess";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Dogbytes.Properties.Resources.Drawing__1_;
            this.pictureBox1.Location = new System.Drawing.Point(717, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStripContainer2);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNewBal);
            this.Controls.Add(this.lblCurrBal);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.lblAccrued);
            this.Controls.Add(this.lblAccID);
            this.Controls.Add(this.cbAccID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripContainer2.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAccID;
        private System.Windows.Forms.Label lblAccID;
        private System.Windows.Forms.Label lblAccrued;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCurrBal;
        private System.Windows.Forms.Label lblNewBal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmCustView;
        private System.Windows.Forms.ToolStripMenuItem tsmGrid;
        private System.Windows.Forms.ToolStripMenuItem tsmOverNight;
        private System.Windows.Forms.ToolStripMenuItem tssmChangeOver;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel tsslDate;
    }
}