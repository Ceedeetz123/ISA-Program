namespace Dogbytes
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSelData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTestConn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOverNights = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOverChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEndYear = new System.Windows.Forms.ToolStripMenuItem();
            this.tssmChangeEOY = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.tsbTest = new System.Windows.Forms.ToolStripButton();
            this.tsbSelData = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConnection,
            this.tsmCustomer,
            this.tsmOverNights,
            this.tsmEndYear,
            this.tsmExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(129, 290);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmConnection
            // 
            this.tsmConnection.AutoToolTip = true;
            this.tsmConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSelData,
            this.tsmTestConn});
            this.tsmConnection.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmConnection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmConnection.Image = global::Dogbytes.Properties.Resources.connection;
            this.tsmConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmConnection.ImageTransparentColor = System.Drawing.Color.White;
            this.tsmConnection.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmConnection.Name = "tsmConnection";
            this.tsmConnection.Padding = new System.Windows.Forms.Padding(5, 10, 4, 0);
            this.tsmConnection.Size = new System.Drawing.Size(128, 34);
            this.tsmConnection.Text = "Connection";
            this.tsmConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tsmSelData
            // 
            this.tsmSelData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmSelData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSelData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmSelData.Name = "tsmSelData";
            this.tsmSelData.Size = new System.Drawing.Size(216, 26);
            this.tsmSelData.Text = "Select Database";
            this.tsmSelData.Click += new System.EventHandler(this.tsmSelData_Click);
            // 
            // tsmTestConn
            // 
            this.tsmTestConn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmTestConn.Enabled = false;
            this.tsmTestConn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmTestConn.Name = "tsmTestConn";
            this.tsmTestConn.Size = new System.Drawing.Size(216, 26);
            this.tsmTestConn.Text = "Test Connection";
            this.tsmTestConn.Click += new System.EventHandler(this.tsmTestConn_Click);
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
            this.tsmCustomer.Size = new System.Drawing.Size(128, 34);
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
            // tsmOverNights
            // 
            this.tsmOverNights.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmOverNights.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOverChange});
            this.tsmOverNights.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmOverNights.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmOverNights.Image = global::Dogbytes.Properties.Resources.Edit;
            this.tsmOverNights.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmOverNights.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmOverNights.Name = "tsmOverNights";
            this.tsmOverNights.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.tsmOverNights.Size = new System.Drawing.Size(128, 34);
            this.tsmOverNights.Text = "Overnight";
            this.tsmOverNights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmOverNights.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tsmOverChange
            // 
            this.tsmOverChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmOverChange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmOverChange.Name = "tsmOverChange";
            this.tsmOverChange.Size = new System.Drawing.Size(137, 26);
            this.tsmOverChange.Text = "Change";
            this.tsmOverChange.Click += new System.EventHandler(this.tsmOverChange_Click);
            // 
            // tsmEndYear
            // 
            this.tsmEndYear.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssmChangeEOY});
            this.tsmEndYear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmEndYear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmEndYear.Image = global::Dogbytes.Properties.Resources.help;
            this.tsmEndYear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmEndYear.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tsmEndYear.Name = "tsmEndYear";
            this.tsmEndYear.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.tsmEndYear.Size = new System.Drawing.Size(128, 34);
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
            this.tsmExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmClose});
            this.tsmExit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsmExit.Image = global::Dogbytes.Properties.Resources.exit;
            this.tsmExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.tsmExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsmExit.Size = new System.Drawing.Size(128, 34);
            this.tsmExit.Text = "Exit";
            this.tsmExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmExit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tsmClose
            // 
            this.tsmClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(191, 26);
            this.tsmClose.Text = "Close Program";
            this.tsmClose.Click += new System.EventHandler(this.tsmClose_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExit,
            this.tsbTest,
            this.tsbSelData});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(718, 72);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbExit
            // 
            this.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbExit.AutoSize = false;
            this.tsbExit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbExit.Image = global::Dogbytes.Properties.Resources.quit;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Margin = new System.Windows.Forms.Padding(0, 1, 50, 2);
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbExit.Size = new System.Drawing.Size(100, 68);
            this.tsbExit.Text = "Exit";
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // tsbTest
            // 
            this.tsbTest.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbTest.AutoSize = false;
            this.tsbTest.Enabled = false;
            this.tsbTest.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbTest.Image = global::Dogbytes.Properties.Resources.test;
            this.tsbTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTest.Name = "tsbTest";
            this.tsbTest.Size = new System.Drawing.Size(100, 68);
            this.tsbTest.Text = "Test Database";
            this.tsbTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbTest.Click += new System.EventHandler(this.tsbTest_Click);
            // 
            // tsbSelData
            // 
            this.tsbSelData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSelData.AutoSize = false;
            this.tsbSelData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSelData.Image = global::Dogbytes.Properties.Resources.db;
            this.tsbSelData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelData.Margin = new System.Windows.Forms.Padding(0);
            this.tsbSelData.Name = "tsbSelData";
            this.tsbSelData.Size = new System.Drawing.Size(100, 68);
            this.tsbSelData.Text = "Find Database";
            this.tsbSelData.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbSelData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSelData.Click += new System.EventHandler(this.tsbSelData_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tsslDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(718, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.ActiveLinkColor = System.Drawing.Color.Red;
            this.tsslStatus.BackColor = System.Drawing.Color.Transparent;
            this.tsslStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(135, 21);
            this.tsslStatus.Text = "No Database Set";
            // 
            // tsslDate
            // 
            this.tsslDate.BackColor = System.Drawing.Color.Transparent;
            this.tsslDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslDate.Margin = new System.Windows.Forms.Padding(230, 3, 0, 2);
            this.tsslDate.Name = "tsslDate";
            this.tsslDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsslDate.Size = new System.Drawing.Size(88, 21);
            this.tsslDate.Text = "Time Date";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 77);
            this.label1.TabIndex = 6;
            this.label1.Text = "Outlaw Hess";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(17, 290);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 75);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(146, 315);
            this.toolStripContainer1.TabIndex = 7;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Welcome to the Outlaw Hess Account System!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Dogbytes.Properties.Resources.Drawing__1_;
            this.pictureBox1.Location = new System.Drawing.Point(362, 162);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Outlaw Hess";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(718, 456);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the ISA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmConnection;
        private System.Windows.Forms.ToolStripMenuItem tsmSelData;
        private System.Windows.Forms.ToolStripMenuItem tsmTestConn;
        private System.Windows.Forms.ToolStripMenuItem tsmEndYear;
        private System.Windows.Forms.ToolStripButton tsbSelData;
        private System.Windows.Forms.ToolStripButton tsbTest;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem tsmOverNights;
        private System.Windows.Forms.ToolStripMenuItem tsmOverChange;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmCustView;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel tsslDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem tssmChangeEOY;
        private System.Windows.Forms.ToolStripMenuItem tsmGrid;
    }
}

