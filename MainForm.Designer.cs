
namespace FastCodeSNILBot
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DGV_commands = new System.Windows.Forms.DataGridView();
            this.BT_commands_count = new System.Windows.Forms.Button();
            this.DGV_commands_icons = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.DGV_functions = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.BT_delete_command = new System.Windows.Forms.Button();
            this.BT_mashine_gun = new System.Windows.Forms.Button();
            this.BT_add_commnd = new System.Windows.Forms.Button();
            this.BT_clear_selecting = new System.Windows.Forms.Button();
            this.BT_add_function = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_humanoid_bot = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_collector_bot = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_commands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_commands_icons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_functions)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_commands
            // 
            this.DGV_commands.AllowUserToAddRows = false;
            this.DGV_commands.AllowUserToResizeColumns = false;
            this.DGV_commands.AllowUserToResizeRows = false;
            this.DGV_commands.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.DGV_commands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_commands.ColumnHeadersVisible = false;
            this.DGV_commands.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.DGV_commands.Location = new System.Drawing.Point(91, 27);
            this.DGV_commands.MinimumSize = new System.Drawing.Size(434, 12);
            this.DGV_commands.Name = "DGV_commands";
            this.DGV_commands.RowHeadersVisible = false;
            this.DGV_commands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_commands.Size = new System.Drawing.Size(444, 800);
            this.DGV_commands.TabIndex = 5;
            this.DGV_commands.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_commands_CellClick);
            this.DGV_commands.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_commands_CellMouseDown);
            this.DGV_commands.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGV_commands_CellPainting);
            this.DGV_commands.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV_commands_RowsAdded);
            // 
            // BT_commands_count
            // 
            this.BT_commands_count.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BT_commands_count.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_commands_count.ForeColor = System.Drawing.Color.Black;
            this.BT_commands_count.Location = new System.Drawing.Point(12, 27);
            this.BT_commands_count.Name = "BT_commands_count";
            this.BT_commands_count.Size = new System.Drawing.Size(73, 70);
            this.BT_commands_count.TabIndex = 7;
            this.BT_commands_count.Text = "0";
            this.BT_commands_count.UseVisualStyleBackColor = false;
            this.BT_commands_count.Click += new System.EventHandler(this.BT_commands_count_Click);
            // 
            // DGV_commands_icons
            // 
            this.DGV_commands_icons.AllowUserToAddRows = false;
            this.DGV_commands_icons.AllowUserToResizeColumns = false;
            this.DGV_commands_icons.AllowUserToResizeRows = false;
            this.DGV_commands_icons.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.DGV_commands_icons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_commands_icons.ColumnHeadersVisible = false;
            this.DGV_commands_icons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.DGV_commands_icons.Location = new System.Drawing.Point(12, 103);
            this.DGV_commands_icons.Name = "DGV_commands_icons";
            this.DGV_commands_icons.RowHeadersVisible = false;
            this.DGV_commands_icons.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_commands_icons.Size = new System.Drawing.Size(73, 423);
            this.DGV_commands_icons.TabIndex = 8;
            this.DGV_commands_icons.Click += new System.EventHandler(this.DGV_commands_icons_Click);
            this.DGV_commands_icons.DoubleClick += new System.EventHandler(this.DGV_commands_icons_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 70;
            // 
            // DGV_functions
            // 
            this.DGV_functions.AllowUserToAddRows = false;
            this.DGV_functions.AllowUserToResizeColumns = false;
            this.DGV_functions.AllowUserToResizeRows = false;
            this.DGV_functions.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.DGV_functions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_functions.ColumnHeadersVisible = false;
            this.DGV_functions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_functions.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_functions.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.DGV_functions.Location = new System.Drawing.Point(12, 617);
            this.DGV_functions.Name = "DGV_functions";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_functions.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_functions.RowHeadersVisible = false;
            this.DGV_functions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_functions.Size = new System.Drawing.Size(73, 210);
            this.DGV_functions.TabIndex = 11;
            this.DGV_functions.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_functions_CellMouseClick);
            this.DGV_functions.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_functions_CellMouseDown);
            this.DGV_functions.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGV_functions_CellPainting);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Column1";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 53;
            // 
            // BT_delete_command
            // 
            this.BT_delete_command.BackColor = System.Drawing.Color.Gold;
            this.BT_delete_command.BackgroundImage = global::FastCodeSNILBot.Properties.Resources.DeleteButton;
            this.BT_delete_command.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_delete_command.ForeColor = System.Drawing.Color.Black;
            this.BT_delete_command.Location = new System.Drawing.Point(540, 27);
            this.BT_delete_command.Name = "BT_delete_command";
            this.BT_delete_command.Size = new System.Drawing.Size(73, 70);
            this.BT_delete_command.TabIndex = 13;
            this.BT_delete_command.UseVisualStyleBackColor = false;
            this.BT_delete_command.Click += new System.EventHandler(this.ProcessCommandButton);
            // 
            // BT_mashine_gun
            // 
            this.BT_mashine_gun.BackColor = System.Drawing.Color.Gold;
            this.BT_mashine_gun.BackgroundImage = global::FastCodeSNILBot.Properties.Resources.MashineGun;
            this.BT_mashine_gun.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_mashine_gun.ForeColor = System.Drawing.Color.Black;
            this.BT_mashine_gun.Location = new System.Drawing.Point(541, 255);
            this.BT_mashine_gun.Name = "BT_mashine_gun";
            this.BT_mashine_gun.Size = new System.Drawing.Size(73, 70);
            this.BT_mashine_gun.TabIndex = 15;
            this.BT_mashine_gun.UseVisualStyleBackColor = false;
            this.BT_mashine_gun.Click += new System.EventHandler(this.ProcessCommandButton);
            // 
            // BT_add_commnd
            // 
            this.BT_add_commnd.BackColor = System.Drawing.Color.Gold;
            this.BT_add_commnd.BackgroundImage = global::FastCodeSNILBot.Properties.Resources.AddCommandButton;
            this.BT_add_commnd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_add_commnd.ForeColor = System.Drawing.Color.Black;
            this.BT_add_commnd.Location = new System.Drawing.Point(541, 179);
            this.BT_add_commnd.Name = "BT_add_commnd";
            this.BT_add_commnd.Size = new System.Drawing.Size(73, 70);
            this.BT_add_commnd.TabIndex = 14;
            this.BT_add_commnd.UseVisualStyleBackColor = false;
            this.BT_add_commnd.Click += new System.EventHandler(this.ProcessCommandButton);
            // 
            // BT_clear_selecting
            // 
            this.BT_clear_selecting.BackColor = System.Drawing.Color.Gold;
            this.BT_clear_selecting.BackgroundImage = global::FastCodeSNILBot.Properties.Resources.ClearButton;
            this.BT_clear_selecting.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_clear_selecting.ForeColor = System.Drawing.Color.Black;
            this.BT_clear_selecting.Location = new System.Drawing.Point(540, 103);
            this.BT_clear_selecting.Name = "BT_clear_selecting";
            this.BT_clear_selecting.Size = new System.Drawing.Size(73, 70);
            this.BT_clear_selecting.TabIndex = 12;
            this.BT_clear_selecting.UseVisualStyleBackColor = false;
            this.BT_clear_selecting.Click += new System.EventHandler(this.ProcessCommandButton);
            // 
            // BT_add_function
            // 
            this.BT_add_function.BackColor = System.Drawing.Color.Gold;
            this.BT_add_function.BackgroundImage = global::FastCodeSNILBot.Properties.Resources.BackGround_1;
            this.BT_add_function.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_add_function.ForeColor = System.Drawing.Color.Black;
            this.BT_add_function.Location = new System.Drawing.Point(12, 541);
            this.BT_add_function.Name = "BT_add_function";
            this.BT_add_function.Size = new System.Drawing.Size(73, 70);
            this.BT_add_function.TabIndex = 10;
            this.BT_add_function.Text = "Color";
            this.BT_add_function.UseVisualStyleBackColor = false;
            this.BT_add_function.Click += new System.EventHandler(this.BT_add_function_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_humanoid_bot,
            this.TSMI_collector_bot});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.toolStripMenuItem1.Text = "Тип робота";
            // 
            // TSMI_humanoid_bot
            // 
            this.TSMI_humanoid_bot.Checked = true;
            this.TSMI_humanoid_bot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_humanoid_bot.Name = "TSMI_humanoid_bot";
            this.TSMI_humanoid_bot.Size = new System.Drawing.Size(180, 22);
            this.TSMI_humanoid_bot.Text = "Гуманоид";
            this.TSMI_humanoid_bot.Click += new System.EventHandler(this.TSMI_humanoid_bot_type_process);
            // 
            // TSMI_collector_bot
            // 
            this.TSMI_collector_bot.Name = "TSMI_collector_bot";
            this.TSMI_collector_bot.Size = new System.Drawing.Size(180, 22);
            this.TSMI_collector_bot.Text = "Сборщик";
            this.TSMI_collector_bot.Click += new System.EventHandler(this.TSMI_humanoid_bot_type_process);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(621, 834);
            this.Controls.Add(this.BT_mashine_gun);
            this.Controls.Add(this.BT_add_commnd);
            this.Controls.Add(this.BT_delete_command);
            this.Controls.Add(this.BT_clear_selecting);
            this.Controls.Add(this.DGV_commands_icons);
            this.Controls.Add(this.DGV_functions);
            this.Controls.Add(this.BT_add_function);
            this.Controls.Add(this.BT_commands_count);
            this.Controls.Add(this.DGV_commands);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastCode";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_commands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_commands_icons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_functions)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_commands;
        private System.Windows.Forms.Button BT_commands_count;
        private System.Windows.Forms.DataGridView DGV_commands_icons;
        private System.Windows.Forms.Button BT_add_function;
        private System.Windows.Forms.DataGridView DGV_functions;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button BT_clear_selecting;
        private System.Windows.Forms.Button BT_delete_command;
        private System.Windows.Forms.Button BT_add_commnd;
        private System.Windows.Forms.Button BT_mashine_gun;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_humanoid_bot;
        private System.Windows.Forms.ToolStripMenuItem TSMI_collector_bot;
    }
}

