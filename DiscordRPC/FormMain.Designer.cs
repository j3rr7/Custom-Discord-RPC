
namespace DiscordRPC
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.dis_app_id = new System.Windows.Forms.TextBox();
            this.menu_strip_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discordDeveloperAppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_timenow_1 = new System.Windows.Forms.Button();
            this.btn_timenow_2 = new System.Windows.Forms.Button();
            this.dis_custom_state = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dis_timestamp_end = new System.Windows.Forms.TextBox();
            this.dis_timestamp_start = new System.Windows.Forms.TextBox();
            this.dis_custom_details = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dis_image_small_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dis_image_small_key = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dis_image_large_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dis_image_large_key = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menu_strip_main.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_set);
            this.groupBox1.Controls.Add(this.dis_app_id);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discord App ID";
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(369, 22);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(75, 23);
            this.btn_set.TabIndex = 1;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // dis_app_id
            // 
            this.dis_app_id.Location = new System.Drawing.Point(6, 22);
            this.dis_app_id.Name = "dis_app_id";
            this.dis_app_id.PlaceholderText = "Insert Your App ID here";
            this.dis_app_id.Size = new System.Drawing.Size(357, 23);
            this.dis_app_id.TabIndex = 0;
            // 
            // menu_strip_main
            // 
            this.menu_strip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.extraToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu_strip_main.Location = new System.Drawing.Point(0, 0);
            this.menu_strip_main.Name = "menu_strip_main";
            this.menu_strip_main.Size = new System.Drawing.Size(476, 24);
            this.menu_strip_main.TabIndex = 1;
            this.menu_strip_main.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveConfigurationToolStripMenuItem,
            this.loadConfigurationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveConfigurationToolStripMenuItem
            // 
            this.saveConfigurationToolStripMenuItem.Name = "saveConfigurationToolStripMenuItem";
            this.saveConfigurationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveConfigurationToolStripMenuItem.Text = "Save Configuration";
            this.saveConfigurationToolStripMenuItem.Click += new System.EventHandler(this.saveConfigurationToolStripMenuItem_Click);
            // 
            // loadConfigurationToolStripMenuItem
            // 
            this.loadConfigurationToolStripMenuItem.Name = "loadConfigurationToolStripMenuItem";
            this.loadConfigurationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.loadConfigurationToolStripMenuItem.Text = "Load Configuration";
            this.loadConfigurationToolStripMenuItem.Click += new System.EventHandler(this.loadConfigurationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.extraToolStripMenuItem.Text = "Extra";
            this.extraToolStripMenuItem.Visible = false;
            this.extraToolStripMenuItem.Click += new System.EventHandler(this.extraToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discordDeveloperAppsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // discordDeveloperAppsToolStripMenuItem
            // 
            this.discordDeveloperAppsToolStripMenuItem.Name = "discordDeveloperAppsToolStripMenuItem";
            this.discordDeveloperAppsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.discordDeveloperAppsToolStripMenuItem.Text = "Discord Developer Apps";
            this.discordDeveloperAppsToolStripMenuItem.Click += new System.EventHandler(this.discordDeveloperAppsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start Timestamp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "End Timestamp";
            // 
            // btn_timenow_1
            // 
            this.btn_timenow_1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_timenow_1.Location = new System.Drawing.Point(369, 134);
            this.btn_timenow_1.Name = "btn_timenow_1";
            this.btn_timenow_1.Size = new System.Drawing.Size(75, 23);
            this.btn_timenow_1.TabIndex = 8;
            this.btn_timenow_1.Text = "Current Time";
            this.btn_timenow_1.UseVisualStyleBackColor = true;
            this.btn_timenow_1.Click += new System.EventHandler(this.btn_timenow_1_Click);
            // 
            // btn_timenow_2
            // 
            this.btn_timenow_2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_timenow_2.Location = new System.Drawing.Point(369, 178);
            this.btn_timenow_2.Name = "btn_timenow_2";
            this.btn_timenow_2.Size = new System.Drawing.Size(75, 23);
            this.btn_timenow_2.TabIndex = 9;
            this.btn_timenow_2.Text = "Current Time";
            this.btn_timenow_2.UseVisualStyleBackColor = true;
            this.btn_timenow_2.Click += new System.EventHandler(this.btn_timenow_2_Click);
            // 
            // dis_custom_state
            // 
            this.dis_custom_state.Location = new System.Drawing.Point(9, 37);
            this.dis_custom_state.Name = "dis_custom_state";
            this.dis_custom_state.PlaceholderText = "Insert Custom State Here";
            this.dis_custom_state.Size = new System.Drawing.Size(437, 23);
            this.dis_custom_state.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dis_timestamp_end);
            this.groupBox2.Controls.Add(this.dis_timestamp_start);
            this.groupBox2.Controls.Add(this.dis_custom_details);
            this.groupBox2.Controls.Add(this.dis_custom_state);
            this.groupBox2.Controls.Add(this.btn_timenow_2);
            this.groupBox2.Controls.Add(this.btn_timenow_1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 217);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RPC Configuration";
            // 
            // dis_timestamp_end
            // 
            this.dis_timestamp_end.Location = new System.Drawing.Point(9, 178);
            this.dis_timestamp_end.Name = "dis_timestamp_end";
            this.dis_timestamp_end.PlaceholderText = "UNIX TIMESTAMP END";
            this.dis_timestamp_end.Size = new System.Drawing.Size(357, 23);
            this.dis_timestamp_end.TabIndex = 12;
            this.dis_timestamp_end.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dis_timestamp_end_KeyDown);
            // 
            // dis_timestamp_start
            // 
            this.dis_timestamp_start.Location = new System.Drawing.Point(9, 134);
            this.dis_timestamp_start.Name = "dis_timestamp_start";
            this.dis_timestamp_start.PlaceholderText = "UNIX TIMESTAMP START";
            this.dis_timestamp_start.Size = new System.Drawing.Size(357, 23);
            this.dis_timestamp_start.TabIndex = 11;
            this.dis_timestamp_start.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dis_timestamp_start_KeyDown);
            // 
            // dis_custom_details
            // 
            this.dis_custom_details.Location = new System.Drawing.Point(9, 81);
            this.dis_custom_details.Name = "dis_custom_details";
            this.dis_custom_details.PlaceholderText = "Insert Custom Details Here";
            this.dis_custom_details.Size = new System.Drawing.Size(437, 23);
            this.dis_custom_details.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dis_image_small_text);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dis_image_small_key);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dis_image_large_text);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dis_image_large_key);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 207);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image Configuration";
            // 
            // dis_image_small_text
            // 
            this.dis_image_small_text.Location = new System.Drawing.Point(8, 169);
            this.dis_image_small_text.Name = "dis_image_small_text";
            this.dis_image_small_text.PlaceholderText = "Insert Small Image Text";
            this.dis_image_small_text.Size = new System.Drawing.Size(437, 23);
            this.dis_image_small_text.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Small Image Key";
            // 
            // dis_image_small_key
            // 
            this.dis_image_small_key.Location = new System.Drawing.Point(8, 125);
            this.dis_image_small_key.Name = "dis_image_small_key";
            this.dis_image_small_key.PlaceholderText = "Insert Small Image Key";
            this.dis_image_small_key.Size = new System.Drawing.Size(437, 23);
            this.dis_image_small_key.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Small Image Key";
            // 
            // dis_image_large_text
            // 
            this.dis_image_large_text.Location = new System.Drawing.Point(9, 81);
            this.dis_image_large_text.Name = "dis_image_large_text";
            this.dis_image_large_text.PlaceholderText = "Insert Large Image Text";
            this.dis_image_large_text.Size = new System.Drawing.Size(437, 23);
            this.dis_image_large_text.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Large Image Text";
            // 
            // dis_image_large_key
            // 
            this.dis_image_large_key.Location = new System.Drawing.Point(9, 37);
            this.dis_image_large_key.Name = "dis_image_large_key";
            this.dis_image_large_key.PlaceholderText = "Insert Large Image Key";
            this.dis_image_large_key.Size = new System.Drawing.Size(437, 23);
            this.dis_image_large_key.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Large Image Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(394, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Author: j3rr7";
            this.label9.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(476, 541);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menu_strip_main);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menu_strip_main;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Discord Custom RPC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menu_strip_main.ResumeLayout(false);
            this.menu_strip_main.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.TextBox dis_app_id;
        private System.Windows.Forms.MenuStrip menu_strip_main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_timenow_1;
        private System.Windows.Forms.Button btn_timenow_2;
        private System.Windows.Forms.TextBox dis_custom_state;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox dis_timestamp_end;
        private System.Windows.Forms.TextBox dis_timestamp_start;
        private System.Windows.Forms.TextBox dis_custom_details;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TextBox dis_image_small_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dis_image_small_key;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dis_image_large_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dis_image_large_key;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discordDeveloperAppsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

