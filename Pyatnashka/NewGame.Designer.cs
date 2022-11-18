namespace Pyatnashka
{
    partial class NewGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.difficultyBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.startNewGameButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.difficultyBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.startNewGameButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.mainMenuButton, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(74, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 392);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 131);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новая игра";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difficultyBar
            // 
            this.difficultyBar.Location = new System.Drawing.Point(3, 134);
            this.difficultyBar.Maximum = 2;
            this.difficultyBar.Name = "difficultyBar";
            this.difficultyBar.Size = new System.Drawing.Size(239, 45);
            this.difficultyBar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сложность";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startNewGameButton
            // 
            this.startNewGameButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.startNewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startNewGameButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startNewGameButton.Location = new System.Drawing.Point(3, 219);
            this.startNewGameButton.Name = "startNewGameButton";
            this.startNewGameButton.Size = new System.Drawing.Size(239, 43);
            this.startNewGameButton.TabIndex = 3;
            this.startNewGameButton.Text = "Начать новую игру";
            this.startNewGameButton.UseVisualStyleBackColor = true;
            this.startNewGameButton.Click += new System.EventHandler(this.startNewGameButton_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mainMenuButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuButton.Location = new System.Drawing.Point(3, 306);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(239, 43);
            this.mainMenuButton.TabIndex = 4;
            this.mainMenuButton.Text = "Выйти в главное меню";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pyatnashka.Properties.Resources.background_image1;
            this.ClientSize = new System.Drawing.Size(384, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая игра";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar difficultyBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startNewGameButton;
        private System.Windows.Forms.Button mainMenuButton;
    }
}