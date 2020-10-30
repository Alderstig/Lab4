namespace Lab4WindowsForms
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
            this.labelWordLists = new System.Windows.Forms.Label();
            this.labelLanguages = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNewList = new System.Windows.Forms.Button();
            this.listBoxWordLists = new System.Windows.Forms.ListBox();
            this.listBoxLanguages = new System.Windows.Forms.ListBox();
            this.labelwordCount = new System.Windows.Forms.Label();
            this.labelWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWordLists
            // 
            this.labelWordLists.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWordLists.AutoSize = true;
            this.labelWordLists.Location = new System.Drawing.Point(14, 20);
            this.labelWordLists.Name = "labelWordLists";
            this.labelWordLists.Size = new System.Drawing.Size(107, 25);
            this.labelWordLists.TabIndex = 0;
            this.labelWordLists.Text = "Word lists";
            // 
            // labelLanguages
            // 
            this.labelLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLanguages.AutoSize = true;
            this.labelLanguages.Location = new System.Drawing.Point(368, 20);
            this.labelLanguages.Name = "labelLanguages";
            this.labelLanguages.Size = new System.Drawing.Size(119, 25);
            this.labelLanguages.TabIndex = 2;
            this.labelLanguages.Text = "Languages";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect.Location = new System.Drawing.Point(572, 370);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(107, 37);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(449, 370);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 37);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonNewList
            // 
            this.buttonNewList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewList.Location = new System.Drawing.Point(14, 370);
            this.buttonNewList.Name = "buttonNewList";
            this.buttonNewList.Size = new System.Drawing.Size(147, 37);
            this.buttonNewList.TabIndex = 5;
            this.buttonNewList.Text = "New list";
            this.buttonNewList.UseVisualStyleBackColor = true;
            this.buttonNewList.Click += new System.EventHandler(this.buttonNewList_Click);
            // 
            // listBoxWordLists
            // 
            this.listBoxWordLists.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxWordLists.FormattingEnabled = true;
            this.listBoxWordLists.ItemHeight = 25;
            this.listBoxWordLists.Location = new System.Drawing.Point(14, 60);
            this.listBoxWordLists.Name = "listBoxWordLists";
            this.listBoxWordLists.Size = new System.Drawing.Size(322, 304);
            this.listBoxWordLists.TabIndex = 6;
            this.listBoxWordLists.SelectedValueChanged += new System.EventHandler(this.listBox_WordLists_SelectedIndexChanged);
            // 
            // listBoxLanguages
            // 
            this.listBoxLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLanguages.Enabled = false;
            this.listBoxLanguages.FormattingEnabled = true;
            this.listBoxLanguages.ItemHeight = 25;
            this.listBoxLanguages.Location = new System.Drawing.Point(373, 60);
            this.listBoxLanguages.Name = "listBoxLanguages";
            this.listBoxLanguages.Size = new System.Drawing.Size(306, 304);
            this.listBoxLanguages.TabIndex = 7;
            this.listBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.listBox_WordLists_SelectedIndexChanged);
            // 
            // labelwordCount
            // 
            this.labelwordCount.AutoSize = true;
            this.labelwordCount.Location = new System.Drawing.Point(308, 20);
            this.labelwordCount.Name = "labelwordCount";
            this.labelwordCount.Size = new System.Drawing.Size(0, 25);
            this.labelwordCount.TabIndex = 8;
            // 
            // labelWords
            // 
            this.labelWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWords.AutoSize = true;
            this.labelWords.Location = new System.Drawing.Point(228, 20);
            this.labelWords.Name = "labelWords";
            this.labelWords.Size = new System.Drawing.Size(80, 25);
            this.labelWords.TabIndex = 9;
            this.labelWords.Text = "Words:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 418);
            this.Controls.Add(this.labelWords);
            this.Controls.Add(this.labelwordCount);
            this.Controls.Add(this.listBoxLanguages);
            this.Controls.Add(this.listBoxWordLists);
            this.Controls.Add(this.buttonNewList);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.labelLanguages);
            this.Controls.Add(this.labelWordLists);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select word list";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWordLists;
        private System.Windows.Forms.Label labelLanguages;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNewList;
        private System.Windows.Forms.ListBox listBoxWordLists;
        private System.Windows.Forms.ListBox listBoxLanguages;
        private System.Windows.Forms.Label labelwordCount;
        private System.Windows.Forms.Label labelWords;
    }
}