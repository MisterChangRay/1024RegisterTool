/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2019/1/15
 * Time: 13:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net.NetworkInformation;

namespace Register1024
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void 关于ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			String tips = "写这个软件其实在去年2018.8月份就有想法了，但由于其他事一直没做.\r\n" +
				"个人小站,请大家多多支持;www.mtils.com" +
				"写个这个帮助大家上岸吧.其实我也是用的这个^_^上的岸。QQ.1070509085希望结交更多的朋友";
			MessageBox.Show(tips);
			
		}
		void 使用方法ToolStripMenuItemClick(object sender, EventArgs e)
		{
			String tips = "caoliu是一个需要邀请码注册的轮胎; \r\n" +
				"有的好人直接发邀请码，大家拿着可以直接注册,这种不用讲了\r\n" +
				"还有一类人不喜欢直接发邀请码, 而是隐藏其中几位再发。\r\n" +
				"大家得到后不能直接注册,要先补全后再注册\r\n" +
				"通常来说隐藏2个字符就有多达81种邀请码组合\r\n" +
				"手工补全后再注册的成功率是可以想象的，抢过的自然明白^_^。所以\r\n" +
				"本工具原理就是通过规则去生成所有可能的注册码,然后用机器逐一去试。\r\n" +
				"使用方法:\r\n" +
				"首先得拿到一个暗码，比如：cbf1c96e6894*7*9\r\n" +
				"这里假如发码好人隐藏了两位：可以看到有两个星号，然后他会说这两个分别是数字和字母\r\n" +
				"那么我们就可以使用 {i} 代替数字的星号, {c} 代替字母的星号\r\n" +
				"替换结果为：cbf1c96e6894{i}7{c}9 \r\n" +
				"将替换的结果填到软件邀请码位置,然后等待计算结果就行。\r\n" +
				"可能有的人要问，如果不知道是字符还是字母怎么办， \r\n" +
				"其实我们还有一个 {a} ,它可以替换那些你不知道具体是什么的星号\r\n" +
				"" ;
			MessageBox.Show(tips);
		}
		void Button1Click(object sender, EventArgs e)
		{
			List<String> res = initIncrement(textBox_code.Text);

			if(null == res || 0 == res.Count) {
				addLog("输入的邀请码解析错误或者需要尝试的组合为0, 请先查看 使用手册->使用方法");
				return;
			} 
			
			addLog(string.Format("破解开始,共 {0} 种组合需要尝试，预估耗时 {1} s",  res.Count, (res.Count * 10)));
			
			this.button1.Enabled = false;
			//方法一：使用Thread类
	        ParameterizedThreadStart threadStart = new ParameterizedThreadStart(threadEntry);//通过ThreadStart委托告诉子线程执行什么方法　　
	        Thread thread = new Thread(threadStart);
	        thread.Start(res);//启动新线程
          
			
		}
		
	
		//线程入口
		void threadEntry(Object o) {
			List<String> res = (List<String>) o;
			Random r1 = new Random();
			for(int i=0; i<res.Count; i++) {
				check(res[i]);
				if(i == res.Count - 1) {
					addLog("end");
				}
				Thread.Sleep(r1.Next(5000, 15000));
			}
		}
		
		//检查邀请码是否有效
		void check(String code) {
			
			String param = String.Format("reginvcode={0}&action=reginvcodeck", code);
			String res = GetContentPost(textBox_url.Text + "/register.php?", param, Encoding.ASCII);
			if(null == res) return;
			Regex rg = new Regex("<script language=\"JavaScript1.2\">(.*?)</script>", RegexOptions.Multiline | RegexOptions.Singleline);
			if(-1 != res.IndexOf("parent.retmsg_invcode('0')")) {
				addLog(String.Format("{0}, {1}", code, "-->> 有效"));
				Application.ExitThread();
			} else {
				addLog(String.Format("{0}, {1}, {2}", code, " 无效", rg.Match(res).Groups[1].Value));
			}
		}
		
		//提交数据
        public string GetContentPost(string uri, string data, Encoding coding)
        {
        	try{
        		HttpWebRequest request = (HttpWebRequest) WebRequest.Create(uri);
	            request.ContentType = "application/x-www-form-urlencoded";
	            request.Method = "POST";
	            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36";
	                        
	            //将字符串数据转化为字节串,这也是POST请求与GET请求区别的地方
	            byte[] buffer = coding.GetBytes(data);
	            request.ContentLength = buffer.Length;
	            
	            //用于将数据写入Internet资源
	            Stream stream = request.GetRequestStream();
	            stream.Write(buffer, 0, buffer.Length);
	
	            WebResponse response = request.GetResponse();
	
	            //从网络资源中返回数据流
	            stream = response.GetResponseStream();
	
	            StreamReader sr = new StreamReader(stream, coding);
	
	            //将数据流转换文字符串
	            string result = sr.ReadToEnd();
	
	            //关闭流数据
	            stream.Close();
	            sr.Close();
	
	            return result;
        	} catch(Exception  e) {
        		addLog(String.Format("网络异常,请检查网络状况:{0}", e.Message));
        		addLog("end");
        		Application.ExitThread();
        		return null;
        	}
        }
	
        
        //自增时初始化环境
		List<String> initIncrement(String t) {
        	List<String> jw = new List<string>();
        	String target = t;
			
			Regex rg = new Regex("(\\{i\\}|\\{a\\}|\\{c\\})", RegexOptions.Multiline | RegexOptions.Singleline);    	
			MatchCollection  mc = rg.Matches(t);
			foreach (Match match in mc) {
				jw.Add( match.Groups[0].Value);
			}
			
			foreach(String tmp in jw) {
				if(tmp.Equals("{c}")) {
					target = target.Replace("{c}", "f");
				}
				if(tmp.Equals("{a}")) {
					target = target.Replace("{a}", "f");
				}
				if(tmp.Equals("{i}")) {
					target = target.Replace("{i}", "9");
				}
			}
			

			
			if(3 < jw.Count) {
				addLog("使用的匹配符不能超出3个,正常情况超出三个尝试时间将会大于5小时");
				return null;
			}
			
			return increment(t, target, jw, null, null);
		
			
		}
        
        
        
        //模拟计数器
        //占位符模拟依次递增,直到满足条件退出
        List<String> increment(String code, String target, List<String> jw, List<Char> last, List<string> res) {
        	if(null == res) res = new List<string>();
        	if(null == last) {
        		last = new List<Char>();
        		foreach(String tmp in jw) {
        			if(tmp.Equals("{c}")) {
        				last.Add('a');
        			} else {
	        			last.Add('0');
        			}
        		}
        	}
        	
    		String tmp2 = code;
        	for(int i =0; i<jw.Count; i++) {
        		if(jw[i].Equals("{c}")) {
                    Regex reg = new Regex("{c}");
                    tmp2 = reg.Replace(tmp2, last[i].ToString(), 1);
				}
				if(jw[i].Equals("{a}")) {
                    Regex reg = new Regex("{a}");
                    tmp2 = reg.Replace(tmp2, last[i].ToString(), 1);
                }
				if(jw[i].Equals("{i}")) {
                    Regex reg = new Regex("{i}");
                    tmp2 = reg.Replace(tmp2, last[i].ToString(), 1);
                }
			}
        	res.Add(tmp2);
        	
        	if(target.Equals(tmp2)) return res;
        	
        	
        	last[0] = (char)((int)(last[0]) + 1);
        	
        	for(int i =0; i<jw.Count; i++) {
        		String tmp = jw[i];
        		
				if(tmp.Equals("{c}")) {
        			if('f' < last[i]) {
        				last[i] = 'a';
        				if(i != jw.Count - 1) last[i+1] = (char)((int)(last[i+1]) + 1);
        			}
				}
				if(tmp.Equals("{a}")) {
        			if('9' < last[i] && 'a' > last[i]) {
        				last[i] = 'a';
        			} else if('f' < last[i]) {
        				last[i] = '0';
    					if(i != jw.Count - 1)  last[i+1] = (char)((int)(last[i+1]) + 1);
        			}
				}

				if(tmp.Equals("{i}")) {
					if('9' < last[i]) {
        				last[i] = '0';
        				if(i != jw.Count - 1)  last[i+1] = (char)((int)(last[i+1]) + 1);
        			}
				}
			}
        	
        
        	return increment(code, target, jw, last, res);
        }
	
        //输出日志
		void addLog(String t) {
        	if(t.Equals("end")) {
        		this.button1.BeginInvoke(new Action(()=>{
                            	this.button1.Enabled = true;
            	}));
        		addLog("本次任务结束");
        		return;
        	}
        	textBox_log.BeginInvoke(new Action(()=>
            {
               textBox_log.AppendText(string.Format("{0}: {1}\r\n",  DateTime.Now, t));
            }));
			
		}
        
        
        //程序退出
		void MainFormCloseing(object sender, EventArgs e)
		{
			System.Environment.Exit(0);
		}
	
		
	
	}
	
	
}
