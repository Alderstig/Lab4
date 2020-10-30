namespace Lab4WindowsForms
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
            this.buttonEndPractice = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelTranslations = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEndPractice
            // 
            this.buttonEndPractice.Location = new System.Drawing.Point(356, 386);
            this.buttonEndPractice.Name = "buttonEndPractice";
            this.buttonEndPractice.Size = new System.Drawing.Size(200, 56);
            this.buttonEndPractice.TabIndex = 1;
            this.buttonEndPractice.Text = "End Practice";
            this.buttonEndPractice.UseVisualStyleBackColor = true;
            this.buttonEndPractice.Click += new System.EventHandler(this.buttonEndPractice_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(274, 224);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(408, 31);
            this.textBoxInput.TabIndex = 2;
            this.textBoxInput.Text = "Input translation here and press Enter-key";
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // labelTranslations
            // 
            this.labelTranslations.AutoSize = true;
            this.labelTranslations.Location = new System.Drawing.Point(305, 150);
            this.labelTranslations.Name = "labelTranslations";
            this.labelTranslations.Size = new System.Drawing.Size(0, 25);
            this.labelTranslations.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(355, 289);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(201, 25);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "0 of 0 words correct";
            this.labelResult.TextChanged += new System.EventHandler(this.labelResult_TextChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 588);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelTranslations);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonEndPractice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form5";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEndPractice;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelTranslations;
        private System.Windows.Forms.Label labelResult;
    }
}