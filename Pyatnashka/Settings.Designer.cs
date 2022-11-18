namespace Pyatnashka
{
    partial class Settings
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.musicBox = new System.Windows.Forms.CheckBox();
            this.soundsBox = new System.Windows.Forms.CheckBox();
            this.desighBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.musicBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.soundsBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.desighBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.mainMenuButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(67, 107);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 240);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // musicBox
            // 
            this.musicBox.AutoSize = true;
            this.musicBox.BackColor = System.Drawing.Color.Transparent;
            this.musicBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.musicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicBox.Location = new System.Drawing.Point(3, 87);
            this.musicBox.Name = "musicBox";
            this.musicBox.Size = new System.Drawing.Size(256, 17);
            this.musicBox.TabIndex = 0;
            this.musicBox.Text = "Музыка";
            this.musicBox.UseVisualStyleBackColor = false;
            this.musicBox.CheckedChanged += new System.EventHandler(this.musicBox_CheckedChanged);
            // 
            // soundsBox
            // 
            this.soundsBox.AutoSize = true;
            this.soundsBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.soundsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundsBox.Enabled = false;
            this.soundsBox.Location = new System.Drawing.Point(3, 110);
            this.soundsBox.Name = "soundsBox";
            this.soundsBox.Size = new System.Drawing.Size(256, 17);
            this.soundsBox.TabIndex = 1;
            this.soundsBox.Text = "Звуки";
            this.soundsBox.UseVisualStyleBackColor = true;
            // 
            // desighBox
            // 
            this.desighBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desighBox.FormattingEnabled = true;
            this.desighBox.Items.AddRange(new object[] {
            "Оригинал",
            "Майнкрафт"});
            this.desighBox.Location = new System.Drawing.Point(3, 133);
            this.desighBox.Name = "desighBox";
            this.desighBox.Size = new System.Drawing.Size(256, 21);
            this.desighBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дизайн игры";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainMenuButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuButton.Location = new System.Drawing.Point(3, 186);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(256, 37);
            this.mainMenuButton.TabIndex = 4;
            this.mainMenuButton.Text = "Выйти в главное меню";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 84);
            this.label2.TabIndex = 5;
            this.label2.Text = "Настройки";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pyatnashka.Properties.Resources.background_image1;
            this.ClientSize = new System.Drawing.Size(384, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox musicBox;
        private System.Windows.Forms.CheckBox soundsBox;
        private System.Windows.Forms.ComboBox desighBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label label2;
    }
}