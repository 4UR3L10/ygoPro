namespace WindowsFormsApp2
{
    partial class deckWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deckWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cardsImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(939, 150);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 603);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cardsImageList
            // 
            this.cardsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cardsImageList.ImageStream")));
            this.cardsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.cardsImageList.Images.SetKeyName(0, "05464695.png");
            this.cardsImageList.Images.SetKeyName(1, "07459013.jpg");
            this.cardsImageList.Images.SetKeyName(2, "11091375.png");
            this.cardsImageList.Images.SetKeyName(3, "11321183.png");
            this.cardsImageList.Images.SetKeyName(4, "12493482.png");
            this.cardsImageList.Images.SetKeyName(5, "14531242.png");
            this.cardsImageList.Images.SetKeyName(6, "16587243.png");
            this.cardsImageList.Images.SetKeyName(7, "23771716.png");
            this.cardsImageList.Images.SetKeyName(8, "38445524.png");
            this.cardsImageList.Images.SetKeyName(9, "46986414.jpg");
            this.cardsImageList.Images.SetKeyName(10, "49003308.png");
            this.cardsImageList.Images.SetKeyName(11, "49881766.png");
            this.cardsImageList.Images.SetKeyName(12, "69140098.png");
            this.cardsImageList.Images.SetKeyName(13, "74852097.png");
            this.cardsImageList.Images.SetKeyName(14, "91731841.png");
            // 
            // deckWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 763);
            this.Controls.Add(this.panel1);
            this.Name = "deckWindow";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.deckWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList cardsImageList;

        
    }
}