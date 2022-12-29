/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2019/1/15
 * Time: 13:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Register1024
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label 啊;
		private System.Windows.Forms.TextBox textBox_url;
		private System.Windows.Forms.TextBox textBox_code;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 使用方法ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
		private System.Windows.Forms.TextBox textBox_log;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_orc;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.啊 = new System.Windows.Forms.Label();
			this.textBox_url = new System.Windows.Forms.TextBox();
			this.textBox_code = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.使用方法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox_log = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_orc = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(21, 110);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(204, 24);
			this.button1.TabIndex = 0;
			this.button1.Text = "开始破解";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "1024地址(https)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// 啊
			// 
			this.啊.Location = new System.Drawing.Point(340, 25);
			this.啊.Name = "啊";
			this.啊.Size = new System.Drawing.Size(53, 23);
			this.啊.TabIndex = 2;
			this.啊.Text = "邀请码";
			this.啊.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox_url
			// 
			this.textBox_url.Location = new System.Drawing.Point(126, 28);
			this.textBox_url.Name = "textBox_url";
			this.textBox_url.Size = new System.Drawing.Size(175, 21);
			this.textBox_url.TabIndex = 3;
			this.textBox_url.Text = "https://cl.6803x.xyz";
			this.textBox_url.TextChanged += new System.EventHandler(this.TextBox_urlTextChanged);
			// 
			// textBox_code
			// 
			this.textBox_code.Location = new System.Drawing.Point(399, 29);
			this.textBox_code.Name = "textBox_code";
			this.textBox_code.Size = new System.Drawing.Size(175, 21);
			this.textBox_code.TabIndex = 4;
			this.textBox_code.Text = "cbf1c96e6894{i}7{c}9";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.关于ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(761, 25);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 关于ToolStripMenuItem
			// 
			this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.使用方法ToolStripMenuItem,
			this.关于ToolStripMenuItem1});
			this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
			this.关于ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.关于ToolStripMenuItem.Text = "使用手册";
			// 
			// 使用方法ToolStripMenuItem
			// 
			this.使用方法ToolStripMenuItem.Name = "使用方法ToolStripMenuItem";
			this.使用方法ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.使用方法ToolStripMenuItem.Text = "使用方法";
			this.使用方法ToolStripMenuItem.Click += new System.EventHandler(this.使用方法ToolStripMenuItemClick);
			// 
			// 关于ToolStripMenuItem1
			// 
			this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
			this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
			this.关于ToolStripMenuItem1.Text = "关于";
			this.关于ToolStripMenuItem1.Click += new System.EventHandler(this.关于ToolStripMenuItem1Click);
			// 
			// textBox_log
			// 
			this.textBox_log.Location = new System.Drawing.Point(21, 153);
			this.textBox_log.Multiline = true;
			this.textBox_log.Name = "textBox_log";
			this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_log.Size = new System.Drawing.Size(716, 381);
			this.textBox_log.TabIndex = 6;
			this.textBox_log.Text = resources.GetString("textBox_log.Text");
			this.textBox_log.WordWrap = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(-11, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "验证码识别服务器";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox_orc
			// 
			this.textBox_orc.Location = new System.Drawing.Point(126, 70);
			this.textBox_orc.Name = "textBox_orc";
			this.textBox_orc.Size = new System.Drawing.Size(448, 21);
			this.textBox_orc.TabIndex = 8;
			this.textBox_orc.Text = "http://8.131.242.140:7554/upload";
			this.textBox_orc.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(761, 560);
			this.Controls.Add(this.textBox_orc);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_log);
			this.Controls.Add(this.textBox_code);
			this.Controls.Add(this.textBox_url);
			this.Controls.Add(this.啊);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "1024上岸神器 by.蜗牛快快跑 个人小站www.mtils.com ";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormCloseing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
