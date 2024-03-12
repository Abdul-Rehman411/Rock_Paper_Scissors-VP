
namespace Rock_Paper_Scissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rock_pictureBox = new System.Windows.Forms.PictureBox();
            this.scissor_pictureBox = new System.Windows.Forms.PictureBox();
            this.paper_pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myScore_label = new System.Windows.Forms.Label();
            this.oppScore_label = new System.Windows.Forms.Label();
            this.oppPictureBox = new System.Windows.Forms.PictureBox();
            this.myPick_label = new System.Windows.Forms.Label();
            this.oppPick_label = new System.Windows.Forms.Label();
            this.pa_label = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rock_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissor_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oppPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rock_pictureBox
            // 
            this.rock_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.rock_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rock_pictureBox.Image = global::Rock_Paper_Scissors.Properties.Resources.rock;
            this.rock_pictureBox.Location = new System.Drawing.Point(10, 151);
            this.rock_pictureBox.Name = "rock_pictureBox";
            this.rock_pictureBox.Size = new System.Drawing.Size(110, 100);
            this.rock_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rock_pictureBox.TabIndex = 0;
            this.rock_pictureBox.TabStop = false;
            this.rock_pictureBox.Click += new System.EventHandler(this.my_pictureBox_Click);
            // 
            // scissor_pictureBox
            // 
            this.scissor_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.scissor_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scissor_pictureBox.Image = global::Rock_Paper_Scissors.Properties.Resources.scissors;
            this.scissor_pictureBox.Location = new System.Drawing.Point(272, 151);
            this.scissor_pictureBox.Name = "scissor_pictureBox";
            this.scissor_pictureBox.Size = new System.Drawing.Size(110, 100);
            this.scissor_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scissor_pictureBox.TabIndex = 0;
            this.scissor_pictureBox.TabStop = false;
            this.scissor_pictureBox.Click += new System.EventHandler(this.my_pictureBox_Click);
            // 
            // paper_pictureBox3
            // 
            this.paper_pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.paper_pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paper_pictureBox3.Image = global::Rock_Paper_Scissors.Properties.Resources.paper;
            this.paper_pictureBox3.Location = new System.Drawing.Point(142, 151);
            this.paper_pictureBox3.Name = "paper_pictureBox3";
            this.paper_pictureBox3.Size = new System.Drawing.Size(110, 100);
            this.paper_pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paper_pictureBox3.TabIndex = 1;
            this.paper_pictureBox3.TabStop = false;
            this.paper_pictureBox3.Click += new System.EventHandler(this.my_pictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rock Paper Scissors";
            // 
            // myScore_label
            // 
            this.myScore_label.AutoSize = true;
            this.myScore_label.BackColor = System.Drawing.Color.Transparent;
            this.myScore_label.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myScore_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.myScore_label.Location = new System.Drawing.Point(68, 100);
            this.myScore_label.MinimumSize = new System.Drawing.Size(280, 32);
            this.myScore_label.Name = "myScore_label";
            this.myScore_label.Size = new System.Drawing.Size(280, 32);
            this.myScore_label.TabIndex = 4;
            this.myScore_label.Text = "Your Score: ";
            this.myScore_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oppScore_label
            // 
            this.oppScore_label.AutoSize = true;
            this.oppScore_label.BackColor = System.Drawing.Color.Transparent;
            this.oppScore_label.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oppScore_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.oppScore_label.Location = new System.Drawing.Point(502, 100);
            this.oppScore_label.MinimumSize = new System.Drawing.Size(280, 32);
            this.oppScore_label.Name = "oppScore_label";
            this.oppScore_label.Size = new System.Drawing.Size(280, 32);
            this.oppScore_label.TabIndex = 5;
            this.oppScore_label.Text = "Opponent\'s Score: ";
            this.oppScore_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oppPictureBox
            // 
            this.oppPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.oppPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("oppPictureBox.Image")));
            this.oppPictureBox.Location = new System.Drawing.Point(590, 151);
            this.oppPictureBox.Name = "oppPictureBox";
            this.oppPictureBox.Size = new System.Drawing.Size(110, 100);
            this.oppPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oppPictureBox.TabIndex = 6;
            this.oppPictureBox.TabStop = false;
            // 
            // myPick_label
            // 
            this.myPick_label.AutoSize = true;
            this.myPick_label.BackColor = System.Drawing.Color.Transparent;
            this.myPick_label.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myPick_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.myPick_label.Location = new System.Drawing.Point(120, 265);
            this.myPick_label.MinimumSize = new System.Drawing.Size(155, 23);
            this.myPick_label.Name = "myPick_label";
            this.myPick_label.Size = new System.Drawing.Size(155, 23);
            this.myPick_label.TabIndex = 7;
            this.myPick_label.Text = "Take Your Pick";
            this.myPick_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oppPick_label
            // 
            this.oppPick_label.AutoSize = true;
            this.oppPick_label.BackColor = System.Drawing.Color.Transparent;
            this.oppPick_label.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oppPick_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.oppPick_label.Location = new System.Drawing.Point(542, 265);
            this.oppPick_label.MinimumSize = new System.Drawing.Size(155, 23);
            this.oppPick_label.Name = "oppPick_label";
            this.oppPick_label.Size = new System.Drawing.Size(211, 23);
            this.oppPick_label.TabIndex = 8;
            this.oppPick_label.Text = "Waiting for Opponent";
            this.oppPick_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pa_label
            // 
            this.pa_label.AutoSize = true;
            this.pa_label.BackColor = System.Drawing.Color.Transparent;
            this.pa_label.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pa_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pa_label.Location = new System.Drawing.Point(172, 318);
            this.pa_label.MinimumSize = new System.Drawing.Size(340, 36);
            this.pa_label.Name = "pa_label";
            this.pa_label.Size = new System.Drawing.Size(340, 36);
            this.pa_label.TabIndex = 9;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.BackColor = System.Drawing.Color.Transparent;
            this.result_label.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.result_label.Location = new System.Drawing.Point(388, 200);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(63, 31);
            this.result_label.TabIndex = 10;
            this.result_label.Text = "       ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(814, 391);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.pa_label);
            this.Controls.Add(this.oppPick_label);
            this.Controls.Add(this.myPick_label);
            this.Controls.Add(this.oppPictureBox);
            this.Controls.Add(this.oppScore_label);
            this.Controls.Add(this.myScore_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paper_pictureBox3);
            this.Controls.Add(this.scissor_pictureBox);
            this.Controls.Add(this.rock_pictureBox);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rock_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissor_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oppPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rock_pictureBox;
        private System.Windows.Forms.PictureBox scissor_pictureBox;
        private System.Windows.Forms.PictureBox paper_pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label myScore_label;
        private System.Windows.Forms.Label oppScore_label;
        private System.Windows.Forms.PictureBox oppPictureBox;
        private System.Windows.Forms.Label myPick_label;
        private System.Windows.Forms.Label oppPick_label;
        private System.Windows.Forms.Label pa_label;
        private System.Windows.Forms.Label result_label;
    }
}

