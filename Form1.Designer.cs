namespace BunniesAndSqurrellsSwapGame
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
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblMoves = new System.Windows.Forms.Label();
            this.pBoxBunny1 = new System.Windows.Forms.PictureBox();
            this.pBoxSquirrel1 = new System.Windows.Forms.PictureBox();
            this.pBoxSquirrel2 = new System.Windows.Forms.PictureBox();
            this.pBoxBunny2 = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pBoxFrame1 = new System.Windows.Forms.PictureBox();
            this.pBoxFrame2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBunny1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSquirrel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSquirrel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBunny2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFrame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFrame2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.BackColor = System.Drawing.Color.Transparent;
            this.lblTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTarget.Location = new System.Drawing.Point(47, 709);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(705, 51);
            this.lblTarget.TabIndex = 0;
            this.lblTarget.Text = "The target amount of moves is: 16";
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.BackColor = System.Drawing.Color.Transparent;
            this.lblMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMoves.Location = new System.Drawing.Point(47, 760);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(329, 51);
            this.lblMoves.TabIndex = 1;
            this.lblMoves.Text = "Moves made: 0";
            // 
            // pBoxBunny1
            // 
            this.pBoxBunny1.BackColor = System.Drawing.Color.Transparent;
            this.pBoxBunny1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxBunny1.Image = global::BunniesAndSqurrellsSwapGame.Properties.Resources.bunny100x150;
            this.pBoxBunny1.Location = new System.Drawing.Point(154, 194);
            this.pBoxBunny1.Name = "pBoxBunny1";
            this.pBoxBunny1.Size = new System.Drawing.Size(125, 125);
            this.pBoxBunny1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxBunny1.TabIndex = 3;
            this.pBoxBunny1.TabStop = false;
            this.pBoxBunny1.Click += new System.EventHandler(this.getBunny1);
            // 
            // pBoxSquirrel1
            // 
            this.pBoxSquirrel1.BackColor = System.Drawing.Color.Transparent;
            this.pBoxSquirrel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBoxSquirrel1.Image = ((System.Drawing.Image)(resources.GetObject("pBoxSquirrel1.Image")));
            this.pBoxSquirrel1.Location = new System.Drawing.Point(154, 430);
            this.pBoxSquirrel1.Name = "pBoxSquirrel1";
            this.pBoxSquirrel1.Size = new System.Drawing.Size(115, 100);
            this.pBoxSquirrel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxSquirrel1.TabIndex = 4;
            this.pBoxSquirrel1.TabStop = false;
            this.pBoxSquirrel1.Click += new System.EventHandler(this.getSquirrel1);
            // 
            // pBoxSquirrel2
            // 
            this.pBoxSquirrel2.BackColor = System.Drawing.Color.Transparent;
            this.pBoxSquirrel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBoxSquirrel2.Image = global::BunniesAndSqurrellsSwapGame.Properties.Resources.squirrel2;
            this.pBoxSquirrel2.Location = new System.Drawing.Point(488, 430);
            this.pBoxSquirrel2.Name = "pBoxSquirrel2";
            this.pBoxSquirrel2.Size = new System.Drawing.Size(115, 100);
            this.pBoxSquirrel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxSquirrel2.TabIndex = 5;
            this.pBoxSquirrel2.TabStop = false;
            this.pBoxSquirrel2.Click += new System.EventHandler(this.getSquirrel2);
            // 
            // pBoxBunny2
            // 
            this.pBoxBunny2.BackColor = System.Drawing.Color.Transparent;
            this.pBoxBunny2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxBunny2.Image = global::BunniesAndSqurrellsSwapGame.Properties.Resources.bunny2;
            this.pBoxBunny2.Location = new System.Drawing.Point(488, 194);
            this.pBoxBunny2.Name = "pBoxBunny2";
            this.pBoxBunny2.Size = new System.Drawing.Size(125, 125);
            this.pBoxBunny2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxBunny2.TabIndex = 6;
            this.pBoxBunny2.TabStop = false;
            this.pBoxBunny2.Click += new System.EventHandler(this.getBunny2);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestart.Location = new System.Drawing.Point(228, 845);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(365, 63);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.restartGame);
            // 
            // pBoxFrame1
            // 
            this.pBoxFrame1.BackColor = System.Drawing.Color.Transparent;
            this.pBoxFrame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxFrame1.Enabled = false;
            this.pBoxFrame1.Image = global::BunniesAndSqurrellsSwapGame.Properties.Resources.YellowFrame150x150;
            this.pBoxFrame1.Location = new System.Drawing.Point(638, 0);
            this.pBoxFrame1.Name = "pBoxFrame1";
            this.pBoxFrame1.Size = new System.Drawing.Size(150, 150);
            this.pBoxFrame1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxFrame1.TabIndex = 8;
            this.pBoxFrame1.TabStop = false;
            this.pBoxFrame1.Visible = false;
            this.pBoxFrame1.Click += new System.EventHandler(this.moveAnimalIntoPos1);
            // 
            // pBoxFrame2
            // 
            this.pBoxFrame2.BackColor = System.Drawing.Color.Transparent;
            this.pBoxFrame2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxFrame2.Enabled = false;
            this.pBoxFrame2.Image = global::BunniesAndSqurrellsSwapGame.Properties.Resources.YellowFrame2;
            this.pBoxFrame2.Location = new System.Drawing.Point(0, 0);
            this.pBoxFrame2.Name = "pBoxFrame2";
            this.pBoxFrame2.Size = new System.Drawing.Size(150, 150);
            this.pBoxFrame2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxFrame2.TabIndex = 9;
            this.pBoxFrame2.TabStop = false;
            this.pBoxFrame2.Visible = false;
            this.pBoxFrame2.Click += new System.EventHandler(this.moveAnimalIntoPos2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::BunniesAndSqurrellsSwapGame.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 1002);
            this.Controls.Add(this.pBoxFrame2);
            this.Controls.Add(this.pBoxFrame1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.pBoxBunny2);
            this.Controls.Add(this.pBoxSquirrel2);
            this.Controls.Add(this.pBoxSquirrel1);
            this.Controls.Add(this.pBoxBunny1);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.lblTarget);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Bunnies and Squirrels Swap Game";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBunny1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSquirrel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSquirrel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBunny2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFrame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFrame2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.PictureBox pBoxSquirrel1;
        private System.Windows.Forms.PictureBox pBoxSquirrel2;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox pBoxBunny1;
        private System.Windows.Forms.PictureBox pBoxBunny2;
        private System.Windows.Forms.PictureBox pBoxFrame1;
        private System.Windows.Forms.PictureBox pBoxFrame2;
    }
}

