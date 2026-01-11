namespace CsSSWrap
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            labelTitle = new Label();
            buttonClose = new Button();
            labelVersion = new Label();
            listBoxSSList = new ListBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            label1 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            textBoxPath = new TextBox();
            label3 = new Label();
            textBoxPreview = new TextBox();
            buttonSave = new Button();
            buttonSelPath = new Button();
            buttonSelPreview = new Button();
            buttonUpdate = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            textBoxArgs = new TextBox();
            buttonSelArgs = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(13, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(172, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "CsSSWrap";
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose.Font = new Font("Segoe UI", 11.25F);
            buttonClose.Location = new Point(482, 336);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(80, 38);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelVersion
            // 
            labelVersion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelVersion.AutoSize = true;
            labelVersion.Font = new Font("Segoe UI", 11.25F);
            labelVersion.Location = new Point(460, 9);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(77, 20);
            labelVersion.TabIndex = 1;
            labelVersion.Text = "ver. 1.0.0.0";
            // 
            // listBoxSSList
            // 
            listBoxSSList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxSSList.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxSSList.FormattingEnabled = true;
            listBoxSSList.Location = new Point(13, 70);
            listBoxSSList.Name = "listBoxSSList";
            listBoxSSList.Size = new Size(181, 244);
            listBoxSSList.TabIndex = 3;
            listBoxSSList.SelectedIndexChanged += listBoxSSList_SelectedIndexChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdd.Font = new Font("Segoe UI", 11.25F);
            buttonAdd.Location = new Point(12, 336);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(80, 38);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDelete.Font = new Font("Segoe UI", 11.25F);
            buttonDelete.Location = new Point(184, 336);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(80, 38);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 15;
            label1.Text = "ScreenSaver Name";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Font = new Font("Segoe UI", 9F);
            textBoxName.Location = new Point(3, 23);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(295, 23);
            textBoxName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(3, 61);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 16;
            label2.Text = "File Path";
            // 
            // textBoxPath
            // 
            textBoxPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPath.Font = new Font("Segoe UI", 9F);
            textBoxPath.Location = new Point(3, 84);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(295, 23);
            textBoxPath.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(3, 183);
            label3.Name = "label3";
            label3.Size = new Size(175, 20);
            label3.TabIndex = 18;
            label3.Text = "Preview .bmp (152 x 112)";
            // 
            // textBoxPreview
            // 
            textBoxPreview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPreview.Font = new Font("Segoe UI", 9F);
            textBoxPreview.Location = new Point(3, 206);
            textBoxPreview.Name = "textBoxPreview";
            textBoxPreview.Size = new Size(295, 23);
            textBoxPreview.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.Font = new Font("Segoe UI", 11.25F);
            buttonSave.Location = new Point(372, 336);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(80, 38);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSelPath
            // 
            buttonSelPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSelPath.Font = new Font("Segoe UI", 11.25F);
            buttonSelPath.Location = new Point(304, 84);
            buttonSelPath.Name = "buttonSelPath";
            buttonSelPath.Size = new Size(40, 23);
            buttonSelPath.TabIndex = 8;
            buttonSelPath.Text = "...";
            buttonSelPath.UseVisualStyleBackColor = true;
            buttonSelPath.Click += buttonSelPath_Click;
            // 
            // buttonSelPreview
            // 
            buttonSelPreview.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSelPreview.Font = new Font("Segoe UI", 11.25F);
            buttonSelPreview.Location = new Point(304, 206);
            buttonSelPreview.Name = "buttonSelPreview";
            buttonSelPreview.Size = new Size(40, 23);
            buttonSelPreview.TabIndex = 10;
            buttonSelPreview.Text = "...";
            buttonSelPreview.UseVisualStyleBackColor = true;
            buttonSelPreview.Click += buttonSelPreview_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonUpdate.Font = new Font("Segoe UI", 11.25F);
            buttonUpdate.Location = new Point(98, 336);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(80, 38);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxName, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonSelPath, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxPath, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxPreview, 0, 7);
            tableLayoutPanel1.Controls.Add(buttonSelPreview, 1, 7);
            tableLayoutPanel1.Controls.Add(label3, 0, 6);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(textBoxArgs, 0, 5);
            tableLayoutPanel1.Controls.Add(buttonSelArgs, 1, 5);
            tableLayoutPanel1.Location = new Point(210, 70);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(347, 244);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 122);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 17;
            label4.Text = "Arguments";
            // 
            // textBoxArgs
            // 
            textBoxArgs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxArgs.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxArgs.Location = new Point(3, 145);
            textBoxArgs.Name = "textBoxArgs";
            textBoxArgs.Size = new Size(295, 23);
            textBoxArgs.TabIndex = 6;
            // 
            // buttonSelArgs
            // 
            buttonSelArgs.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSelArgs.Location = new Point(304, 145);
            buttonSelArgs.Name = "buttonSelArgs";
            buttonSelArgs.Size = new Size(40, 23);
            buttonSelArgs.TabIndex = 9;
            buttonSelArgs.Text = "...";
            buttonSelArgs.UseVisualStyleBackColor = true;
            buttonSelArgs.Click += buttonSelArgs_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 386);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxSSList);
            Controls.Add(labelVersion);
            Controls.Add(buttonClose);
            Controls.Add(labelTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(590, 382);
            Name = "SettingsForm";
            Text = "Settings";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonClose;
        private Label labelVersion;
        private ListBox listBoxSSList;
        private Button buttonAdd;
        private Button buttonDelete;
        private Label label1;
        private TextBox textBoxName;
        private Label label2;
        private TextBox textBoxPath;
        private Label label3;
        private TextBox textBoxPreview;
        private Button buttonSave;
        private Button buttonSelPath;
        private Button buttonSelPreview;
        private Button buttonUpdate;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private TextBox textBoxArgs;
        private Button buttonSelArgs;
    }
}