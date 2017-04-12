namespace GPS_App
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbCooAdd = new System.Windows.Forms.RadioButton();
            this.rdbAddCoo = new System.Windows.Forms.RadioButton();
            this.gbxCoor = new System.Windows.Forms.GroupBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCoordinate = new System.Windows.Forms.RadioButton();
            this.rdbAddress = new System.Windows.Forms.RadioButton();
            this.wbrMap = new System.Windows.Forms.WebBrowser();
            this.btnGet = new System.Windows.Forms.Button();
            this.rdbIPCoor = new System.Windows.Forms.RadioButton();
            this.lblIP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxCoor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnGet);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Search);
            this.splitContainer1.Panel1.Controls.Add(this.txtAddress);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.gbxCoor);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.wbrMap);
            this.splitContainer1.Size = new System.Drawing.Size(972, 587);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Location = new System.Drawing.Point(94, 339);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(13, 139);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(237, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rdbIPCoor);
            this.groupBox3.Controls.Add(this.rdbCooAdd);
            this.groupBox3.Controls.Add(this.rdbAddCoo);
            this.groupBox3.Controls.Add(this.lblIP);
            this.groupBox3.Location = new System.Drawing.Point(12, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 153);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Get info";
            // 
            // rdbCooAdd
            // 
            this.rdbCooAdd.AutoSize = true;
            this.rdbCooAdd.Location = new System.Drawing.Point(9, 68);
            this.rdbCooAdd.Name = "rdbCooAdd";
            this.rdbCooAdd.Size = new System.Drawing.Size(155, 17);
            this.rdbCooAdd.TabIndex = 1;
            this.rdbCooAdd.Text = "From Coordinate to Address";
            this.rdbCooAdd.UseVisualStyleBackColor = true;
            // 
            // rdbAddCoo
            // 
            this.rdbAddCoo.AutoSize = true;
            this.rdbAddCoo.Checked = true;
            this.rdbAddCoo.Location = new System.Drawing.Point(9, 28);
            this.rdbAddCoo.Name = "rdbAddCoo";
            this.rdbAddCoo.Size = new System.Drawing.Size(155, 17);
            this.rdbAddCoo.TabIndex = 2;
            this.rdbAddCoo.TabStop = true;
            this.rdbAddCoo.Text = "From Address to Coordinate";
            this.rdbAddCoo.UseVisualStyleBackColor = true;
            // 
            // gbxCoor
            // 
            this.gbxCoor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCoor.Controls.Add(this.txtLong);
            this.gbxCoor.Controls.Add(this.txtLat);
            this.gbxCoor.Controls.Add(this.label3);
            this.gbxCoor.Controls.Add(this.label2);
            this.gbxCoor.Enabled = false;
            this.gbxCoor.Location = new System.Drawing.Point(12, 184);
            this.gbxCoor.Name = "gbxCoor";
            this.gbxCoor.Size = new System.Drawing.Size(244, 135);
            this.gbxCoor.TabIndex = 0;
            this.gbxCoor.TabStop = false;
            this.gbxCoor.Text = "Coordinate";
            // 
            // txtLong
            // 
            this.txtLong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLong.Location = new System.Drawing.Point(57, 65);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(181, 20);
            this.txtLong.TabIndex = 2;
            // 
            // txtLat
            // 
            this.txtLat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLat.Location = new System.Drawing.Point(57, 29);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(181, 20);
            this.txtLat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Long";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lat";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdbCoordinate);
            this.groupBox1.Controls.Add(this.rdbAddress);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // rdbCoordinate
            // 
            this.rdbCoordinate.AutoSize = true;
            this.rdbCoordinate.Location = new System.Drawing.Point(136, 33);
            this.rdbCoordinate.Name = "rdbCoordinate";
            this.rdbCoordinate.Size = new System.Drawing.Size(76, 17);
            this.rdbCoordinate.TabIndex = 0;
            this.rdbCoordinate.Text = "Coordinate";
            this.rdbCoordinate.UseVisualStyleBackColor = true;
            this.rdbCoordinate.CheckedChanged += new System.EventHandler(this.rdbCoordinate_CheckedChanged);
            // 
            // rdbAddress
            // 
            this.rdbAddress.AutoSize = true;
            this.rdbAddress.Checked = true;
            this.rdbAddress.Location = new System.Drawing.Point(6, 33);
            this.rdbAddress.Name = "rdbAddress";
            this.rdbAddress.Size = new System.Drawing.Size(63, 17);
            this.rdbAddress.TabIndex = 0;
            this.rdbAddress.TabStop = true;
            this.rdbAddress.Text = "Address";
            this.rdbAddress.UseVisualStyleBackColor = true;
            // 
            // wbrMap
            // 
            this.wbrMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrMap.Location = new System.Drawing.Point(0, 0);
            this.wbrMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrMap.Name = "wbrMap";
            this.wbrMap.Size = new System.Drawing.Size(699, 587);
            this.wbrMap.TabIndex = 0;
            this.wbrMap.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // btnGet
            // 
            this.btnGet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGet.Location = new System.Drawing.Point(94, 540);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // rdbIPCoor
            // 
            this.rdbIPCoor.AutoSize = true;
            this.rdbIPCoor.Location = new System.Drawing.Point(9, 103);
            this.rdbIPCoor.Name = "rdbIPCoor";
            this.rdbIPCoor.Size = new System.Drawing.Size(142, 17);
            this.rdbIPCoor.TabIndex = 1;
            this.rdbIPCoor.Text = "From My ip to Coordinate";
            this.rdbIPCoor.UseVisualStyleBackColor = true;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(27, 129);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(0, 13);
            this.lblIP.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 587);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbxCoor.ResumeLayout(false);
            this.gbxCoor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxCoor;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCoordinate;
        private System.Windows.Forms.RadioButton rdbAddress;
        private System.Windows.Forms.WebBrowser wbrMap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbCooAdd;
        private System.Windows.Forms.RadioButton rdbAddCoo;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RadioButton rdbIPCoor;
        private System.Windows.Forms.Label lblIP;
    }
}

