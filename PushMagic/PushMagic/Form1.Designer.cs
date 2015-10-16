namespace PushMagic
{
    partial class frmPushMe
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
            this.btnWest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(31, 104);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(155, 63);
            this.btnWest.TabIndex = 0;
            this.btnWest.Text = "Push Me";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(181, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(151, 202);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(155, 63);
            this.btnSouth.TabIndex = 2;
            this.btnSouth.Text = "Push Me";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(151, 12);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(155, 63);
            this.btnNorth.TabIndex = 3;
            this.btnNorth.Text = "Push Me";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(280, 104);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(155, 63);
            this.btnEast.TabIndex = 4;
            this.btnEast.Text = "Push Me";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // frmPushMe
            // 
            this.AcceptButton = this.btnNorth;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(479, 362);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWest);
            this.Name = "frmPushMe";
            this.Text = "Push Me";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnEast;
    }
}

