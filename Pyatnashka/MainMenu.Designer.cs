namespace Pyatnashka
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.leaderboardButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.newGameButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.continueButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.settingsButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.leaderboardButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.closeButton, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(72, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 525);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 121);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пятнашка";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newGameButton
            // 
            this.newGameButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.newGameButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGameButton.Location = new System.Drawing.Point(3, 124);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(234, 43);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "Новая игра";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.continueButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continueButton.Location = new System.Drawing.Point(3, 204);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(234, 43);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Продолжить";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.settingsButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.Location = new System.Drawing.Point(3, 284);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(234, 43);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // leaderboardButton
            // 
            this.leaderboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.leaderboardButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.leaderboardButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leaderboardButton.Location = new System.Drawing.Point(3, 364);
            this.leaderboardButton.Name = "leaderboardButton";
            this.leaderboardButton.Size = new System.Drawing.Size(234, 43);
            this.leaderboardButton.TabIndex = 4;
            this.leaderboardButton.Text = "Таблица лидеров";
            this.leaderboardButton.UseVisualStyleBackColor = true;
            this.leaderboardButton.Click += new System.EventHandler(this.leaderboardButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(3, 444);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(234, 43);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Выйти из игры";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pyatnashka.Properties.Resources.background_image1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button leaderboardButton;
        private System.Windows.Forms.Button closeButton;
    }
}

