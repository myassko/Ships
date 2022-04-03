
namespace Ships
{
    partial class Shipsik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shipsik));
            this.BreadJetty = new System.Windows.Forms.Button();
            this.BreadCount = new System.Windows.Forms.Label();
            this.BananaJetty = new System.Windows.Forms.Button();
            this.ClothesJetty = new System.Windows.Forms.Button();
            this.ClothesCount = new System.Windows.Forms.Label();
            this.BananaCount = new System.Windows.Forms.Label();
            this.BananaPath = new System.Windows.Forms.Button();
            this.ClothesPath = new System.Windows.Forms.Button();
            this.BreadPath = new System.Windows.Forms.Button();
            this.ShipGenerator = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MagicStick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // BreadJetty
            // 
            this.BreadJetty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BreadJetty.Image = ((System.Drawing.Image)(resources.GetObject("BreadJetty.Image")));
            this.BreadJetty.Location = new System.Drawing.Point(85, 452);
            this.BreadJetty.Name = "BreadJetty";
            this.BreadJetty.Size = new System.Drawing.Size(47, 42);
            this.BreadJetty.TabIndex = 0;
            this.BreadJetty.UseVisualStyleBackColor = true;
            // 
            // BreadCount
            // 
            this.BreadCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BreadCount.AutoSize = true;
            this.BreadCount.Location = new System.Drawing.Point(12, 466);
            this.BreadCount.Name = "BreadCount";
            this.BreadCount.Size = new System.Drawing.Size(13, 15);
            this.BreadCount.TabIndex = 1;
            this.BreadCount.Text = "0";
            // 
            // BananaJetty
            // 
            this.BananaJetty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BananaJetty.Image = ((System.Drawing.Image)(resources.GetObject("BananaJetty.Image")));
            this.BananaJetty.Location = new System.Drawing.Point(85, 332);
            this.BananaJetty.Name = "BananaJetty";
            this.BananaJetty.Size = new System.Drawing.Size(47, 42);
            this.BananaJetty.TabIndex = 4;
            this.BananaJetty.UseVisualStyleBackColor = true;
            // 
            // ClothesJetty
            // 
            this.ClothesJetty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClothesJetty.Image = ((System.Drawing.Image)(resources.GetObject("ClothesJetty.Image")));
            this.ClothesJetty.Location = new System.Drawing.Point(85, 395);
            this.ClothesJetty.Name = "ClothesJetty";
            this.ClothesJetty.Size = new System.Drawing.Size(47, 40);
            this.ClothesJetty.TabIndex = 5;
            this.ClothesJetty.UseVisualStyleBackColor = true;
            // 
            // ClothesCount
            // 
            this.ClothesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClothesCount.AutoSize = true;
            this.ClothesCount.Location = new System.Drawing.Point(12, 408);
            this.ClothesCount.Name = "ClothesCount";
            this.ClothesCount.Size = new System.Drawing.Size(13, 15);
            this.ClothesCount.TabIndex = 6;
            this.ClothesCount.Text = "0";
            // 
            // BananaCount
            // 
            this.BananaCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BananaCount.AutoSize = true;
            this.BananaCount.Location = new System.Drawing.Point(12, 346);
            this.BananaCount.Name = "BananaCount";
            this.BananaCount.Size = new System.Drawing.Size(13, 15);
            this.BananaCount.TabIndex = 7;
            this.BananaCount.Text = "0";
            // 
            // BananaPath
            // 
            this.BananaPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BananaPath.AutoSize = true;
            this.BananaPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BananaPath.Location = new System.Drawing.Point(665, 15);
            this.BananaPath.Name = "BananaPath";
            this.BananaPath.Size = new System.Drawing.Size(201, 25);
            this.BananaPath.TabIndex = 11;
            this.BananaPath.TabStop = false;
            this.BananaPath.Text = "Отправить к причалу с бананами";
            this.BananaPath.UseVisualStyleBackColor = true;
            this.BananaPath.Click += new System.EventHandler(this.BananaPath_Click);
            // 
            // ClothesPath
            // 
            this.ClothesPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClothesPath.Location = new System.Drawing.Point(665, 46);
            this.ClothesPath.Name = "ClothesPath";
            this.ClothesPath.Size = new System.Drawing.Size(201, 23);
            this.ClothesPath.TabIndex = 12;
            this.ClothesPath.Text = "Отправить к причалу с одеждой\r\n";
            this.ClothesPath.UseVisualStyleBackColor = true;
            this.ClothesPath.Click += new System.EventHandler(this.ClothesPath_Click);
            // 
            // BreadPath
            // 
            this.BreadPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BreadPath.Location = new System.Drawing.Point(665, 75);
            this.BreadPath.Name = "BreadPath";
            this.BreadPath.Size = new System.Drawing.Size(201, 23);
            this.BreadPath.TabIndex = 13;
            this.BreadPath.Text = "Отправить к причалу с хлебом\r\n";
            this.BreadPath.UseVisualStyleBackColor = true;
            this.BreadPath.Click += new System.EventHandler(this.BreadPath_Click);
            // 
            // ShipGenerator
            // 
            this.ShipGenerator.Location = new System.Drawing.Point(12, 15);
            this.ShipGenerator.Name = "ShipGenerator";
            this.ShipGenerator.Size = new System.Drawing.Size(120, 46);
            this.ShipGenerator.TabIndex = 14;
            this.ShipGenerator.Text = "Сгенерировать кораблик";
            this.ShipGenerator.UseVisualStyleBackColor = true;
            this.ShipGenerator.Click += new System.EventHandler(this.ShipGenerator_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 243);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(21, 171);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "С бананами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "С одеждой";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "С хлебом";
            // 
            // MagicStick
            // 
            this.MagicStick.Location = new System.Drawing.Point(704, 127);
            this.MagicStick.Name = "MagicStick";
            this.MagicStick.Size = new System.Drawing.Size(104, 55);
            this.MagicStick.TabIndex = 22;
            this.MagicStick.Text = "Палочка выручалочка";
            this.MagicStick.UseVisualStyleBackColor = true;
            this.MagicStick.Click += new System.EventHandler(this.MagicStick_Click);
            // 
            // Shipsik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 518);
            this.Controls.Add(this.MagicStick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ShipGenerator);
            this.Controls.Add(this.BreadPath);
            this.Controls.Add(this.ClothesPath);
            this.Controls.Add(this.BananaPath);
            this.Controls.Add(this.BananaCount);
            this.Controls.Add(this.ClothesCount);
            this.Controls.Add(this.ClothesJetty);
            this.Controls.Add(this.BananaJetty);
            this.Controls.Add(this.BreadCount);
            this.Controls.Add(this.BreadJetty);
            this.Name = "Shipsik";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BreadJetty;
        private System.Windows.Forms.Label BreadCount;
        private System.Windows.Forms.Button BananaJetty;
        private System.Windows.Forms.Button ClothesJetty;
        private System.Windows.Forms.Label ClothesCount;
        private System.Windows.Forms.Label BananaCount;
        private System.Windows.Forms.Button BananaPath;
        private System.Windows.Forms.Button ClothesPath;
        private System.Windows.Forms.Button BreadPath;
        private System.Windows.Forms.Button ShipGenerator;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MagicStick;
    }
}

