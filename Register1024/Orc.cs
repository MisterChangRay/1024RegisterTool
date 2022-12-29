/*
 * Created by SharpDevelop.
 * User: Mrui
 * Date: 2022/12/28
 * Time: 15:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Json;

namespace Register1024
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class OrcForm : Form
	{
		// 验证码加载地址
		private String imageUri;
		// orc图片识别地址
		private String orcUri;
		private MainForm main;
		
		
		public OrcForm(MainForm f1, String uri, String orcUri)
		{
			this.main = f1;
			this.orcUri = orcUri;
			this.imageUri =uri;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.loadPic();
			this.textBox_orc.Focus();
		}
		void OrcFormKeyDown(object sender, KeyEventArgs e)
		{
			// 窗口确认事件
		}
		void TextBox1KeyDown(object sender, KeyEventArgs e)
		{
			// 编辑框确认事件
			
			if(e.KeyCode == Keys.Enter) {
				this.doEnter();

			}
		}
		
		void doEnter() {
			
			((MainForm)this.Owner).emmit(this.textBox_orc.Text);	
			this.loadPic();
		}
		
		 public static T Deserialize<T>(string json)
	    {
	        var stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
	        return (T)new DataContractJsonSerializer(typeof(T)).ReadObject(stream);
	    }
		void PictureBox1Click(object sender, EventArgs e)
		{
			// 刷新验证码
			this.loadPic();
		}
		Random r = new Random();
		void loadPic() {
			this.currentTry.Text = "当前尝试:" + main.codes[main.codesIndex];
			
			string imgurl = this.imageUri + "?0.24475697415052" + r.Next(100, 999);
			
			
			System.Drawing.Bitmap b = MainForm.GetContentImg( imageUri) ;
			this.pictureBox1.Image = b;
			if(this.orcUri == null || this.orcUri.Length < 5) {
				this.textBox_orc.Focus();
				return;
			}
			
			MemoryStream m = new MemoryStream();
			this.pictureBox1.Image.Save(m, this.pictureBox1.Image.RawFormat);
	        byte[] imageBytes = m.ToArray();
	        // Convert byte[] to Base64 String
	        string base64String = Convert.ToBase64String(imageBytes);
	          Console.WriteLine(base64String);
	        string data = "{\"file\":\"                      " + base64String + "\"}";
	        string res = null;
	        try {
	        	res = MainForm.GetContentString("POST", this.orcUri, data,  Encoding.ASCII, "application/json");	
	        }catch (Exception e){
	        	main.addLog(String.Format("验证码识别错误,网络异常,请检查网络状况:{0}", e.Message));
	        }
	        
	        if(null != res && res.Length > 4) {
	        	Res res2 = Deserialize<Res>(res);;
	        	this.textBox_orc.Text = res2.code;
	        }
		    
		}
		
		public class Res {
			public String OK {get; set;}
			public String code {get; set;}
			
		}
		
		
		void OrcFormLoad(object sender, EventArgs e)
		{
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.doEnter();
		}
		void OrcFormFormClosing(object sender, FormClosingEventArgs e)
		{
			main.addLog("end");
		}
	
	}
}
