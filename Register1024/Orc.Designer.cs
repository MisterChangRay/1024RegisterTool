/*
 * Created by SharpDevelop.
 * User: Mrui
 * Date: 2022/12/28
 * Time: 15:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Register1024
{
	partial class OrcForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label 验证码图片;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_orc;
		private System.Windows.Forms.Label currentTry;
		private System.Windows.Forms.Label current;
		private System.Windows.Forms.Label label3;
		
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
		/// 
		private void InitializeComponent(){
			this.验证码图片 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_orc = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.currentTry = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// 验证码图片
			// 
			this.验证码图片.Location = new System.Drawing.Point(43, 87);
			this.验证码图片.Name = "验证码图片";
			this.验证码图片.Size = new System.Drawing.Size(192, 22);
			this.验证码图片.TabIndex = 0;
			this.验证码图片.Text = "验证码图片(点击图片可刷新)";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(43, 112);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(239, 57);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(43, 172);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "识别结果";
			// 
			// textBox_orc
			// 
			this.textBox_orc.Location = new System.Drawing.Point(43, 198);
			this.textBox_orc.Name = "textBox_orc";
			this.textBox_orc.Size = new System.Drawing.Size(127, 21);
			this.textBox_orc.TabIndex = 3;
			this.textBox_orc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1KeyDown);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(214, 220);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "确定";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(43, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(245, 41);
			this.label2.TabIndex = 5;
			this.label2.Text = "这里使用了验证码ORC识别模块,模块将会自动识别并填充。如果正确则直接回车确认，错误则手动录入验证码然后回车";
			// 
			// currentTry
			// 
			this.currentTry.ForeColor = System.Drawing.SystemColors.Highlight;
			this.currentTry.Location = new System.Drawing.Point(43, 54);
			this.currentTry.Name = "currentTry";
			this.currentTry.Size = new System.Drawing.Size(192, 22);
			this.currentTry.TabIndex = 6;
			this.currentTry.Text = "当前尝试";
			// 
			// OrcForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 253);
			this.Controls.Add(this.currentTry);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox_orc);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.验证码图片);
			this.Name = "OrcForm";
			this.Text = "验证码识别";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrcFormFormClosing);
			this.Load += new System.EventHandler(this.OrcFormLoad);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrcFormKeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
