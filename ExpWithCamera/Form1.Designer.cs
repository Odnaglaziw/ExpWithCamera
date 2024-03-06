namespace ExpWithCamera
{
    partial class Form1
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
            this.settings_panel = new System.Windows.Forms.Panel();
            this.position_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синнийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оружиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базовоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простоПотыкатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settings_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_panel
            // 
            this.settings_panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.settings_panel.Controls.Add(this.position_label);
            this.settings_panel.Controls.Add(this.label1);
            this.settings_panel.Controls.Add(this.menuStrip1);
            this.settings_panel.Location = new System.Drawing.Point(0, 19);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(800, 90);
            this.settings_panel.TabIndex = 0;
            // 
            // position_label
            // 
            this.position_label.AutoSize = true;
            this.position_label.Location = new System.Drawing.Point(0, 24);
            this.position_label.Name = "position_label";
            this.position_label.Size = new System.Drawing.Size(0, 13);
            this.position_label.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "settings";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветToolStripMenuItem,
            this.оружиеToolStripMenuItem,
            this.простоПотыкатьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.синнийToolStripMenuItem,
            this.красныйToolStripMenuItem});
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.цветToolStripMenuItem.Text = "Цвет";
            // 
            // синнийToolStripMenuItem
            // 
            this.синнийToolStripMenuItem.Name = "синнийToolStripMenuItem";
            this.синнийToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.синнийToolStripMenuItem.Text = "Синний";
            // 
            // красныйToolStripMenuItem
            // 
            this.красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            this.красныйToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.красныйToolStripMenuItem.Text = "Красный";
            // 
            // оружиеToolStripMenuItem
            // 
            this.оружиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базовоеToolStripMenuItem});
            this.оружиеToolStripMenuItem.Name = "оружиеToolStripMenuItem";
            this.оружиеToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.оружиеToolStripMenuItem.Text = "Оружие";
            // 
            // базовоеToolStripMenuItem
            // 
            this.базовоеToolStripMenuItem.Name = "базовоеToolStripMenuItem";
            this.базовоеToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.базовоеToolStripMenuItem.Text = "базовое";
            this.базовоеToolStripMenuItem.Click += new System.EventHandler(this.базовоеToolStripMenuItem_Click);
            // 
            // простоПотыкатьToolStripMenuItem
            // 
            this.простоПотыкатьToolStripMenuItem.Name = "простоПотыкатьToolStripMenuItem";
            this.простоПотыкатьToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.простоПотыкатьToolStripMenuItem.Text = "просто потыкать";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settings_panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.settings_panel.ResumeLayout(false);
            this.settings_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синнийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem красныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оружиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базовоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem простоПотыкатьToolStripMenuItem;
        private System.Windows.Forms.Label position_label;
    }
}

