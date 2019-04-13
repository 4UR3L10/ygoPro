namespace WindowsFormsApp2
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
            this.lblField = new System.Windows.Forms.Label();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblField
            // 
            this.lblField.Image = global::WindowsFormsApp2.Properties.Resources._02;
            this.lblField.Location = new System.Drawing.Point(250, 0);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(752, 693);
            this.lblField.TabIndex = 0;
            // 
            // btnAddCard
            // 
            this.btnAddCard.Location = new System.Drawing.Point(976, 12);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(75, 23);
            this.btnAddCard.TabIndex = 1;
            this.btnAddCard.Text = "AddCard";
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 824);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.lblField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Button btnAddCard;
    }
}

