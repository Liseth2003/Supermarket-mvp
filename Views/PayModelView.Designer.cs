namespace Supermarket_mvp.Views
{
    partial class PayModelView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayModelView));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            titlePAYMODE = new Label();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label1 = new Label();
            tabPagePayMdeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtPayModeObservation = new TextBox();
            textBox3 = new TextBox();
            TxtPayModeName = new TextBox();
            LblPayModeObservation = new Label();
            LblPayModeName = new Label();
            TxtPayModeId = new TextBox();
            LblPayModeId = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayMdeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(titlePAYMODE);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // titlePAYMODE
            // 
            titlePAYMODE.AutoSize = true;
            titlePAYMODE.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            titlePAYMODE.Location = new Point(146, 36);
            titlePAYMODE.Name = "titlePAYMODE";
            titlePAYMODE.Size = new Size(271, 54);
            titlePAYMODE.TabIndex = 0;
            titlePAYMODE.Text = "PAY MODE";
            titlePAYMODE.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayMdeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(854, 435);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label1);
            tabPagePayModeList.Location = new Point(4, 29);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(846, 402);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(552, 321);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(272, 70);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.Location = new Point(552, 245);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(272, 70);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.Location = new Point(552, 169);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(272, 70);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.Location = new Point(552, 93);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(272, 70);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(18, 89);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.RowTemplate.Height = 29;
            DgPayMode.Size = new Size(506, 307);
            DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = (Image)resources.GetObject("BtnSearch.Image");
            BtnSearch.Location = new Point(430, 34);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(94, 49);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(18, 56);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(395, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 0;
            label1.Text = "Search Pay Mode";
            // 
            // tabPagePayMdeDetail
            // 
            tabPagePayMdeDetail.Controls.Add(BtnCancel);
            tabPagePayMdeDetail.Controls.Add(BtnSave);
            tabPagePayMdeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayMdeDetail.Controls.Add(textBox3);
            tabPagePayMdeDetail.Controls.Add(TxtPayModeName);
            tabPagePayMdeDetail.Controls.Add(LblPayModeObservation);
            tabPagePayMdeDetail.Controls.Add(LblPayModeName);
            tabPagePayMdeDetail.Controls.Add(TxtPayModeId);
            tabPagePayMdeDetail.Controls.Add(LblPayModeId);
            tabPagePayMdeDetail.Location = new Point(4, 29);
            tabPagePayMdeDetail.Name = "tabPagePayMdeDetail";
            tabPagePayMdeDetail.Padding = new Padding(3);
            tabPagePayMdeDetail.Size = new Size(846, 402);
            tabPagePayMdeDetail.TabIndex = 1;
            tabPagePayMdeDetail.Text = "Pay Mode Detail";
            tabPagePayMdeDetail.UseVisualStyleBackColor = true;
            tabPagePayMdeDetail.Click += tabPagePayMdeDetail_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = (Image)resources.GetObject("BtnCancel.Image");
            BtnCancel.Location = new Point(245, 312);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(168, 71);
            BtnCancel.TabIndex = 10;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = (Image)resources.GetObject("BtnSave.Image");
            BtnSave.Location = new Point(51, 312);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(168, 71);
            BtnSave.TabIndex = 9;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(52, 209);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(279, 82);
            TxtPayModeObservation.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(51, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(0, 27);
            textBox3.TabIndex = 7;
            textBox3.Text = "Pay Mode Observation";
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(51, 130);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(125, 27);
            TxtPayModeName.TabIndex = 6;
            // 
            // LblPayModeObservation
            // 
            LblPayModeObservation.AutoSize = true;
            LblPayModeObservation.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblPayModeObservation.Location = new Point(51, 186);
            LblPayModeObservation.Name = "LblPayModeObservation";
            LblPayModeObservation.Size = new Size(192, 20);
            LblPayModeObservation.TabIndex = 5;
            LblPayModeObservation.Text = "Pay Mode Observation";
            // 
            // LblPayModeName
            // 
            LblPayModeName.AutoSize = true;
            LblPayModeName.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblPayModeName.Location = new Point(51, 107);
            LblPayModeName.Name = "LblPayModeName";
            LblPayModeName.Size = new Size(140, 20);
            LblPayModeName.TabIndex = 4;
            LblPayModeName.Text = "Pay Mode Name";
            LblPayModeName.Click += label3_Click;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(51, 55);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(125, 27);
            TxtPayModeId.TabIndex = 1;
            // 
            // LblPayModeId
            // 
            LblPayModeId.AutoSize = true;
            LblPayModeId.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblPayModeId.Location = new Point(51, 32);
            LblPayModeId.Name = "LblPayModeId";
            LblPayModeId.Size = new Size(108, 20);
            LblPayModeId.TabIndex = 0;
            LblPayModeId.Text = "Pay Mode Id";
            // 
            // PayModelView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 560);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModelView";
            Load += PayModelView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayMdeDetail.ResumeLayout(false);
            tabPagePayMdeDetail.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private Label titlePAYMODE;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label1;
        private TabPage tabPagePayMdeDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private TextBox textBox3;
        private TextBox TxtPayModeName;
        private Label LblPayModeObservation;
        private Label LblPayModeName;
        private TextBox TxtPayModeId;
        private Label LblPayModeId;
        private TextBox TxtPayModeObservation;
        private Button BtnCancel;
        private Button BtnSave;
        private EventHandler PayModelView_Load;
    }
}