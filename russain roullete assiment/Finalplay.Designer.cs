namespace russain_roullete_assiment
{
    partial class Finalplay
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
            this.Loaderbtn = new System.Windows.Forms.Button();
            this.spinnerbtn = new System.Windows.Forms.Button();
            this.Shooterbtn = new System.Windows.Forms.Button();
            this.Missbtn = new System.Windows.Forms.Button();
            this.Retrybtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Loaderbtn
            // 
            this.Loaderbtn.Font = new System.Drawing.Font("SimSun-ExtB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loaderbtn.Location = new System.Drawing.Point(23, 115);
            this.Loaderbtn.Name = "Loaderbtn";
            this.Loaderbtn.Size = new System.Drawing.Size(128, 65);
            this.Loaderbtn.TabIndex = 0;
            this.Loaderbtn.Text = "Load";
            this.Loaderbtn.UseVisualStyleBackColor = true;
            this.Loaderbtn.Click += new System.EventHandler(this.Loaderbtn_Click);
            // 
            // spinnerbtn
            // 
            this.spinnerbtn.Font = new System.Drawing.Font("SimSun-ExtB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinnerbtn.Location = new System.Drawing.Point(23, 343);
            this.spinnerbtn.Name = "spinnerbtn";
            this.spinnerbtn.Size = new System.Drawing.Size(128, 65);
            this.spinnerbtn.TabIndex = 1;
            this.spinnerbtn.Text = "Spin";
            this.spinnerbtn.UseVisualStyleBackColor = true;
            this.spinnerbtn.Click += new System.EventHandler(this.spinnerbtn_Click);
            // 
            // Shooterbtn
            // 
            this.Shooterbtn.Font = new System.Drawing.Font("SimSun-ExtB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shooterbtn.Location = new System.Drawing.Point(650, 115);
            this.Shooterbtn.Name = "Shooterbtn";
            this.Shooterbtn.Size = new System.Drawing.Size(128, 65);
            this.Shooterbtn.TabIndex = 2;
            this.Shooterbtn.Text = "Shoot";
            this.Shooterbtn.UseVisualStyleBackColor = true;
            this.Shooterbtn.Click += new System.EventHandler(this.Shooterbtn_Click);
            // 
            // Missbtn
            // 
            this.Missbtn.Font = new System.Drawing.Font("SimSun-ExtB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Missbtn.Location = new System.Drawing.Point(650, 343);
            this.Missbtn.Name = "Missbtn";
            this.Missbtn.Size = new System.Drawing.Size(128, 65);
            this.Missbtn.TabIndex = 3;
            this.Missbtn.Text = "Miss";
            this.Missbtn.UseVisualStyleBackColor = true;
            this.Missbtn.Click += new System.EventHandler(this.Missbtn_Click);
            // 
            // Retrybtn
            // 
            this.Retrybtn.Font = new System.Drawing.Font("SimSun-ExtB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retrybtn.Location = new System.Drawing.Point(332, 12);
            this.Retrybtn.Name = "Retrybtn";
            this.Retrybtn.Size = new System.Drawing.Size(128, 65);
            this.Retrybtn.TabIndex = 4;
            this.Retrybtn.Text = "Retry";
            this.Retrybtn.UseVisualStyleBackColor = true;
            this.Retrybtn.Click += new System.EventHandler(this.Retrybtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(175, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 293);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Finalplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Retrybtn);
            this.Controls.Add(this.Missbtn);
            this.Controls.Add(this.Shooterbtn);
            this.Controls.Add(this.spinnerbtn);
            this.Controls.Add(this.Loaderbtn);
            this.Name = "Finalplay";
            this.Text = "Finalplay";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Loaderbtn;
        private System.Windows.Forms.Button spinnerbtn;
        private System.Windows.Forms.Button Shooterbtn;
        private System.Windows.Forms.Button Missbtn;
        private System.Windows.Forms.Button Retrybtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}