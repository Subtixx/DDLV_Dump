using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cpp2IlInjected;
using Mdl.Systems;
using Mdl.Utils;
using Meta.Util;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class PlayerLogBackupFileWatcher
{
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private static readonly string ApplicationPath;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private static readonly string FilePlayerPrev;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private static readonly string LogFileFilterMask;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private static readonly string GameStartTag;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private static readonly string FileLogDateMask;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x14C07D0", Offset = "0x14BF1D0", VA = "0x1814C07D0")]
	private static void TagGameStart()
	{
		string gameStartTag = GameStartTag;
		int num = 0;
		DateTime now = DateTime.Now;
		string fileLogDateMask = FileLogDateMask;
		string text = default(string);
		string msg = gameStartTag + text;
		object[] args = Array.Empty<object>();
		GameLog.Info(msg, args);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x14BFF10", Offset = "0x14BE910", VA = "0x1814BFF10")]
	[RuntimeInitializeOnLoadMethod]
	public unsafe static void Init()
	{
		//IL_003b: Expected O, but got I4
		string gameStartTag = GameStartTag;
		int num = 0;
		DateTime now = DateTime.Now;
		string fileLogDateMask = FileLogDateMask;
		string text = default(string);
		string msg = gameStartTag + text;
		object[] args = Array.Empty<object>();
		GameLog.Info(msg, args);
		int num2 = default(int);
		EventHandler value = new EventHandler(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<object, EventArgs, void>*/)(&Process));
		num2 = 0;
		UnityFileSystem.OnInit += value;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x14C0080", Offset = "0x14BEA80", VA = "0x1814C0080")]
	private unsafe static void Process(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_01cf, IL_01d5, IL_01db, IL_01e1, IL_01e7
		//IL_000e: Expected O, but got I4
		//IL_01a0: Expected O, but got I4
		int num;
		int num2 = default(int);
		uint num4 = default(uint);
		string text4 = default(string);
		uint num7 = default(uint);
		uint num8 = default(uint);
		int num9 = default(int);
		do
		{
			num = 0;
			EventHandler value = new EventHandler(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<object, EventArgs, void>*/)(&Process));
			num2 = 0;
			UnityFileSystem.OnInit -= value;
			string applicationPath = ApplicationPath;
			string filePlayerPrev = FilePlayerPrev;
			if (!File.Exists(Path.Combine(applicationPath, filePlayerPrev)))
			{
				break;
			}
			int num3 = 0;
			if (DebugSettings.Settings.playerLogBackupMaxAmount_ == num)
			{
				break;
			}
			string applicationPath2 = ApplicationPath;
			string filePlayerPrev2 = FilePlayerPrev;
			IEnumerable<string> enumerable = (IEnumerable<string>)File.ReadLines(Path.Combine(applicationPath2, filePlayerPrev2));
			Func<string, bool> _003C_003E9__7_ = _003C_003Ec._003C_003E9__7_0;
			if (_003C_003E9__7_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(string line)
				{
					//Discarded unreachable code: IL_0011
					string gameStartTag = GameStartTag;
					return !line.StartsWith(gameStartTag);
				};
			}
			string text = Enumerable.First<string>(Enumerable.Take<string>(Enumerable.SkipWhile<string>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__7_), (int)num4));
			int stringLength = GameStartTag.m_stringLength;
			int stringLength2 = FileLogDateMask.m_stringLength;
			string text2 = text.Substring(stringLength, stringLength2);
			string path = "Player-prev-" + text2 + ".log";
			string text3 = Path.Combine(ApplicationPath, path);
			if (!File.Exists(text3))
			{
				string applicationPath3 = ApplicationPath;
				string filePlayerPrev3 = FilePlayerPrev;
				text4 = Path.Combine(applicationPath3, filePlayerPrev3);
				File.Copy(text4, text3);
			}
			Debug.LogError("Cannot copy prev player.log into a backup file: " + text4);
			int num5 = 0;
			int searchOption = 0;
			string logFileFilterMask = LogFileFilterMask;
			IEnumerable<string> enumerable2 = (IEnumerable<string>)Enumerable.Reverse<string>((IEnumerable<>)(object)Directory.GetFiles(ApplicationPath, logFileFilterMask, (SearchOption)searchOption));
			int num6 = 0;
			int playerLogBackupMaxAmount_ = DebugSettings.Settings.playerLogBackupMaxAmount_;
			IEnumerable<string> enumerable3 = (IEnumerable<string>)Enumerable.Skip<string>((IEnumerable<>)enumerable2, playerLogBackupMaxAmount_);
			if (num5 < (int)num7)
			{
				num5 += num5;
				if (num5 == (int)num7)
				{
					goto IL_01a0;
				}
				num5++;
			}
			if (num5 != 0)
			{
				if (num5 < (int)num8)
				{
					num5 += num5;
					if (num5 == (int)num8)
					{
						goto IL_01b1;
					}
					num5++;
				}
				num9 = 0;
				File.Delete((string)num5);
				goto IL_01a0;
			}
			goto IL_01c2;
			IL_01c2:
			if (num5 != 0)
			{
			}
			continue;
			IL_01a0:
			num9 += num9;
			num5 += 312;
			goto IL_01b1;
			IL_01b1:
			num9 += num9;
			num5 += 312;
			goto IL_01c2;
		}
		while (num != 0);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
	public PlayerLogBackupFileWatcher()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x14C08C0", Offset = "0x14BF2C0", VA = "0x1814C08C0")]
	static PlayerLogBackupFileWatcher()
	{
		int num = 0;
		ApplicationPath = Application.persistentDataPath;
		ApplicationPath = "Player-prev.log";
		ApplicationPath = "Player-prev-*.log";
		ApplicationPath = "==> Started at time:";
		ApplicationPath = "yyyy-MM-dd-HH-mm-ss";
		/*Error: Unexpected end of block*/;
	}
}
