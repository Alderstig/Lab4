namespace Lab4WindowsForms
{
    partial class FormNewList
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
            this.labelListName = new System.Windows.Forms.Label();
            this.textBoxListName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelAddLanguages = new System.Windows.Forms.Label();
            this.textBoxLanguages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelListName
            // 
            this.labelListName.AutoSize = true;
            this.labelListName.Location = new System.Drawing.Point(29, 36);
            this.labelListName.Name = "labelListName";
            this.labelListName.Size = new System.Drawing.Size(105, 25);
            this.labelListName.TabIndex = 0;
            this.labelListName.Text = "List name";
            // 
            // textBoxListName
            // 
            this.textBoxListName.Location = new System.Drawing.Point(34, 65);
            this.textBoxListName.Name = "textBoxListName";
            this.textBoxListName.Size = new System.Drawing.Size(284, 31);
            this.textBoxListName.TabIndex = 1;
            this.textBoxListName.Text = "Insert list name...";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(34, 454);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 37);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(209, 454);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 37);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelAddLanguages
            // 
            this.labelAddLanguages.AutoSize = true;
            this.labelAddLanguages.Location = new System.Drawing.Point(29, 114);
            this.labelAddLanguages.Name = "labelAddLanguages";
            this.labelAddLanguages.Size = new System.Drawing.Size(119, 25);
            this.labelAddLanguages.TabIndex = 5;
            this.labelAddLanguages.Text = "Languages";
            // 
            // textBoxLanguages
            // 
            this.textBoxLanguages.Location = new System.Drawing.Point(34, 142);
            this.textBoxLanguages.Multiline = true;
            this.textBoxLanguages.Name = "textBoxLanguages";
            this.textBoxLanguages.Size = new System.Drawing.Size(284, 292);
            this.textBoxLanguages.TabIndex = 6;
            this.textBoxLanguages.Text = "Add Languages...";
            // 
            // FormNewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 514);
            this.Controls.Add(this.textBoxLanguages);
            this.Controls.Add(this.labelAddLanguages);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxListName);
            this.Controls.Add(this.labelListName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormNewList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListName;
        private System.Windows.Forms.TextBox textBoxListName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelAddLanguages;
        private System.Windows.Forms.TextBox textBoxLanguages;
    }
}