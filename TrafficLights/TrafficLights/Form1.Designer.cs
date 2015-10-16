namespace TrafficLights
{
    partial class frmTrafficLights
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
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtYellow = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(87, 42);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(100, 20);
            this.txtRed.TabIndex = 2;
            this.txtRed.Enter += new System.EventHandler(this.txtRed_Enter);
            // 
            // txtYellow
            // 
            this.txtYellow.Location = new System.Drawing.Point(87, 93);
            this.txtYellow.Name = "txtYellow";
            this.txtYellow.Size = new System.Drawing.Size(100, 20);
            this.txtYellow.TabIndex = 1;
            this.txtYellow.Enter += new System.EventHandler(this.txtYellow_Enter);
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(87, 147);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(100, 20);
            this.txtGreen.TabIndex = 0;
            this.txtGreen.Enter += new System.EventHandler(this.txtGreen_Enter);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(100, 217);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTrafficLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtYellow);
            this.Controls.Add(this.txtRed);
            this.Name = "frmTrafficLights";
            this.Text = "Traffic Lights";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtYellow;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.Button btnExit;
    }
}

