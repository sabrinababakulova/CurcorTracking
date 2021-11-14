namespace the_eyes_looking_at_the_mouse
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftEye = new System.Windows.Forms.PictureBox();
            this.rightEye = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.face = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightEye)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.face)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.leftEye);
            this.panel1.Location = new System.Drawing.Point(515, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 61);
            this.panel1.TabIndex = 3;
            // 
            // leftEye
            // 
            this.leftEye.BackgroundImage = global::the_eyes_looking_at_the_mouse.Properties.Resources.pupil;
            this.leftEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftEye.Location = new System.Drawing.Point(0, 0);
            this.leftEye.Name = "leftEye";
            this.leftEye.Size = new System.Drawing.Size(30, 31);
            this.leftEye.TabIndex = 2;
            this.leftEye.TabStop = false;
            // 
            // rightEye
            // 
            this.rightEye.BackgroundImage = global::the_eyes_looking_at_the_mouse.Properties.Resources.pupil;
            this.rightEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightEye.Location = new System.Drawing.Point(0, 0);
            this.rightEye.Name = "rightEye";
            this.rightEye.Size = new System.Drawing.Size(30, 31);
            this.rightEye.TabIndex = 1;
            this.rightEye.TabStop = false;
            this.rightEye.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rightEye);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(346, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 61);
            this.panel2.TabIndex = 4;
            // 
            // face
            // 
            this.face.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.face.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.face.BackgroundImage = global::the_eyes_looking_at_the_mouse.Properties.Resources.фиолетовое_говно_для_проги;
            this.face.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.face.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.face.Location = new System.Drawing.Point(276, 257);
            this.face.Margin = new System.Windows.Forms.Padding(2);
            this.face.Name = "face";
            this.face.Size = new System.Drawing.Size(420, 370);
            this.face.TabIndex = 0;
            this.face.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.face);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightEye)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.face)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox face;
        private System.Windows.Forms.PictureBox rightEye;
        private System.Windows.Forms.PictureBox leftEye;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
    }
}

