namespace RoboFactory
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pnHeader = new Panel();
            lbSubtitle = new Label();
            lbName = new Label();
            pnFooter = new Panel();
            btnGenerate = new Button();
            picAvatar = new PictureBox();
            pnHeader.SuspendLayout();
            pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(lbSubtitle);
            pnHeader.Controls.Add(lbName);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(300, 80);
            pnHeader.TabIndex = 1;
            // 
            // lbSubtitle
            // 
            lbSubtitle.Font = new Font("Segoe UI", 10F);
            lbSubtitle.ForeColor = Color.DimGray;
            lbSubtitle.Location = new Point(12, 46);
            lbSubtitle.Name = "lbSubtitle";
            lbSubtitle.Size = new Size(276, 23);
            lbSubtitle.TabIndex = 1;
            lbSubtitle.Text = "Lorem ipsum dolor sit amet";
            lbSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            lbName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbName.Location = new Point(12, 12);
            lbName.Name = "lbName";
            lbName.Size = new Size(276, 34);
            lbName.TabIndex = 0;
            lbName.Text = "Lorem ipsum";
            lbName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnFooter
            // 
            pnFooter.BackColor = Color.Silver;
            pnFooter.Controls.Add(btnGenerate);
            pnFooter.Dock = DockStyle.Bottom;
            pnFooter.Location = new Point(0, 380);
            pnFooter.Name = "pnFooter";
            pnFooter.Size = new Size(300, 60);
            pnFooter.TabIndex = 3;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.SkyBlue;
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatAppearance.BorderColor = Color.SteelBlue;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(12, 9);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(276, 42);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate!";
            btnGenerate.UseVisualStyleBackColor = false;
            // 
            // picAvatar
            // 
            picAvatar.Dock = DockStyle.Fill;
            picAvatar.Location = new Point(0, 80);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(300, 300);
            picAvatar.TabIndex = 4;
            picAvatar.TabStop = false;
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(300, 440);
            Controls.Add(picAvatar);
            Controls.Add(pnFooter);
            Controls.Add(pnHeader);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoboFactory";
            pnHeader.ResumeLayout(false);
            pnFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnHeader;
        private Label lbName;
        private Label lbSubtitle;
        private Panel pnFooter;
        private PictureBox picAvatar;
        private Button btnGenerate;
    }
}
