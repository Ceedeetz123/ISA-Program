namespace Dogbytes
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbCustomerID = new System.Windows.Forms.ComboBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblAccID = new System.Windows.Forms.Label();
            this.lblAccrued = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblProdID = new System.Windows.Forms.Label();
            this.cbAcc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOvernight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOverView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEndOfYear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTimes = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customer";
            // 
            // cbCustomerID
            // 
            this.cbCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomerID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCustomerID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomerID.FormattingEnabled = true;
            this.cbCustomerID.Location = new System.Drawing.Point(233, 88);
            this.cbCustomerID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbCustomerID.Name = "cbCustomerID";
            this.cbCustomerID.Size = new System.Drawing.Size(111, 22);
            this.cbCustomerID.TabIndex = 15;
            this.cbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cbCustomerID_SelectedIndexChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBalance.Location = new System.Drawing.Point(249, 329);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(131, 25);
            this.lblBalance.TabIndex = 17;
            this.lblBalance.Text = "Bank Balance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer Accounts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "Please choose a customer and then a account \r\nfrom the drop down boxes that you w" +
    "ould like to view";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(249, 156);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(117, 25);
            this.lblCustID.TabIndex = 22;
            this.lblCustID.Text = "Customer ID";
            // 
            // lblAccID
            // 
            this.lblAccID.AutoSize = true;
            this.lblAccID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAccID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccID.Location = new System.Drawing.Point(461, 156);
            this.lblAccID.Name = "lblAccID";
            this.lblAccID.Size = new System.Drawing.Size(105, 25);
            this.lblAccID.TabIndex = 23;
            this.lblAccID.Text = "Account ID";
            // 
            // lblAccrued
            // 
            this.lblAccrued.AutoSize = true;
            this.lblAccrued.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccrued.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAccrued.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccrued.Location = new System.Drawing.Point(249, 244);
            this.lblAccrued.Name = "lblAccrued";
            this.lblAccrued.Size = new System.Drawing.Size(80, 25);
            this.lblAccrued.TabIndex = 25;
            this.lblAccrued.Text = "Accrued";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 23);
            this.label8.TabIndex = 26;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblActive.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.Location = new System.Drawing.Point(249, 289);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(61, 25);
            this.lblActive.TabIndex = 27;
            this.lblActive.Text = "Active";
            // 
            // lblProdID
            // 
            this.lblProdID.AutoSize = true;
            this.lblProdID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProdID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProdID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdID.Location = new System.Drawing.Point(249, 201);
            this.lblProdID.Name = "lblProdID";
            this.lblProdID.Size = new System.Drawing.Size(102, 25);
            this.lblProdID.TabIndex = 28;
            this.lblProdID.Text = "Product ID";
            // 
            // cbAcc
            // 
            this.cbAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAcc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAcc.FormattingEnabled = true;
            this.cbAcc.Location = new System.Drawing.Point(607, 86);
            this.cbAcc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbAcc.Name = "cbAcc";
            this.cbAcc.Size = new System.Drawing.Size(92, 22);
            this.cbAcc.TabIndex = 31;
            this.cbAcc.SelectedIndexChanged += new System.EventHandler(this.cbAcc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Account";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCustomer,
            this.tsmOvernight,
            this.tsmEndOfYear,
            this.tsmExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(120, 461);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmCustomer
            // 
            this.tsmCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGrid});
            this.tsmCustomer.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmCustomer.Image = global::Dogbytes.Properties.Resources.eye;
            this.tsmCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmCustomer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmCustomer.Name = "tsmCustomer";
            this.tsmCustomer.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.tsmCustomer.Size = new System.Drawing.Size(119, 34);
            this.tsmCustomer.Text = "Customers";
            this.tsmCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tsmGrid
            // 
            this.tsmGrid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmGrid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmGrid.Name = "tsmGrid";
            this.tsmGrid.Size = new System.Drawing.Size(104, 22);
            this.tsmGrid.Text = "Grid";
            this.tsmGrid.Click += new System.EventHandler(this.tsmGrid_Click);
            // 
            // tsmOvernight
            // 
            this.tsmOvernight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmOvernight.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOverView});
            this.tsmOvernight.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmOvernight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmOvernight.Image = global::Dogbytes.Properties.Resources.Edit;
            this.tsmOvernight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmOvernight.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmOvernight.Name = "tsmOvernight";
            this.tsmOvernight.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.tsmOvernight.Size = new System.Drawing.Size(119, 34);
            this.tsmOvernight.Text = "Overnight";
            this.tsmOvernight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmOvernight.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tsmOverView
            // 
            this.tsmOverView.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmOverView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmOverView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmOverView.Name = "tsmOverView";
            this.tsmOverView.Size = new System.Drawing.Size(109, 22);
            this.tsmOverView.Text = "View";
            this.tsmOverView.Click += new System.EventHandler(this.tsmOverView_Click);
            // 
            // tsmEndOfYear
            // 
            this.tsmEndOfYear.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmChange});
            this.tsmEndOfYear.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmEndOfYear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmEndOfYear.Image = global::Dogbytes.Properties.Resources.Edit;
            this.tsmEndOfYear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmEndOfYear.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmEndOfYear.Name = "tsmEndOfYear";
            this.tsmEndOfYear.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.tsmEndOfYear.Size = new System.Drawing.Size(119, 34);
            this.tsmEndOfYear.Text = "End of Year";
            this.tsmEndOfYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmEndOfYear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tsmChange
            // 
            this.tsmChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmChange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmChange.Name = "tsmChange";
            this.tsmChange.Size = new System.Drawing.Size(129, 22);
            this.tsmChange.Text = "Change";
            this.tsmChange.Click += new System.EventHandler(this.tsmChange_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmExit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmExit.Image = global::Dogbytes.Properties.Resources.exit;
            this.tsmExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmExit.Margin = new System.Windows.Forms.Padding(0, 160, 0, 0);
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.tsmExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsmExit.Size = new System.Drawing.Size(119, 34);
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
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(0, 461);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 78);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(113, 483);
            this.toolStripContainer1.TabIndex = 39;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(682, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Outlaw Hess";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Dogbytes.Properties.Resources.Drawing__1_;
            this.pictureBox1.Location = new System.Drawing.Point(710, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTimes});
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(777, 22);
            this.statusStrip1.TabIndex = 41;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTimes
            // 
            this.tsslTimes.BackColor = System.Drawing.Color.Transparent;
            this.tsslTimes.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslTimes.Margin = new System.Windows.Forms.Padding(590, 3, 50, 2);
            this.tsslTimes.Name = "tsslTimes";
            this.tsslTimes.Size = new System.Drawing.Size(70, 17);
            this.tsslTimes.Text = "Date Time";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(0, -3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 81);
            this.label7.TabIndex = 42;
            this.label7.Text = "Outlaw Hess";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(777, 525);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAcc);
            this.Controls.Add(this.lblProdID);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAccrued);
            this.Controls.Add(this.lblAccID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.cbCustomerID);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Checker";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblAccID;
        private System.Windows.Forms.Label lblAccrued;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblProdID;
        private System.Windows.Forms.ComboBox cbAcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmOvernight;
        private System.Windows.Forms.ToolStripMenuItem tsmOverView;
        private System.Windows.Forms.ToolStripMenuItem tsmEndOfYear;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTimes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem tsmGrid;
        private System.Windows.Forms.ToolStripMenuItem tsmChange;
    }
}