# 1024RegisterTool
这是一个帮助大家尽快上岸的工具。1024邀请码工具,邀请码暗码破解工具

# 截至2022/07/26，此软件运行正常。不能使用的请注意网络是否能正常访问。

# 另外这里统一做一个说明， 有码不代表100%尝试成功， 软件本身的功能仅仅是提供自动尝试而已。 也有可能别人运气更好， 一次成功。

如果大家注册成功了， 麻烦再issue中回复一下， 方便大家交流。

#### 怎么使用
1. 填入正确的1024网址
2. 填写正确的邀请码规则
  1.`{i}` 匹配数字
  2.`{c}` 匹配字母
  3.`{a}` 匹配所有
3. 点击开始破解
4. 等待结果

举例：
1. 暗码为; `f44f4964e6c99*d*`,隐藏了两个字符,分别为字母,数字; 那替换后的模板为: `f44f4964e6c99{c}d{i}`
2. 暗码为; `68fe*2c*b3*eddd9`,隐藏了三个字符,分别为数字,数字,字母; 那替换后的模板为: `68fe{i}2c{i}b3{c}eddd9`
3. 暗码为; `c124a10e0d*5e4b9`,隐藏了一个字符,不知道隐藏的是什么东西; 那替换后的模板为: `c124a10e0d{a}5e4b9`

#### 工作原理
工具首先根据模板规则生成所有可能的邀请码，然后依次尝试邀请码是否注册。


#### 注意事项
1. 确保填写的1024网址无误;
2. 确保机器能正确的链接到网址,要知道1024现在是被Q了的
3. 不建议大家多开使用,1024有相应的封IP措施


#### 如何下载
1. [点击直接下载 v1.0.1](https://github.com/MisterChangRay/1024RegisterTool/releases/download/V1.0.1/Register1024_V1.0.1.exe)
2. [前往下载页面](https://github.com/MisterChangRay/1024RegisterTool/releases)


#### 代码贡献
- 感谢 sorvon 同学的Bug修复
