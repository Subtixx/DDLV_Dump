using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000978")]
	public class SystemLogQueue : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400345C")]
		private const int LogQueueCapacity = 200;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400345E")]
		private string LogPath;

		[Cpp2IlInjected.Token(Token = "0x17000657")]
		public static bool IsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6002C1D")]
			[Cpp2IlInjected.Address(RVA = "0x106B9E0", Offset = "0x106A3E0", VA = "0x18106B9E0")]
			get
			{
				int num = 0;
				if (Application.webSecurityEnabled)
				{
					return true;
				}
				int num2 = 0;
				return Application.platform == RuntimePlatform.WindowsPlayer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000658")]
		public Queue<string> Logs
		{
			[Cpp2IlInjected.Token(Token = "0x6002C22")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CLogs_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C23")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CLogs_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Queue<string>)(object)new Queue<T>();


		[Cpp2IlInjected.Token(Token = "0x6002C1E")]
		[Cpp2IlInjected.Address(RVA = "0x106B720", Offset = "0x106A120", VA = "0x18106B720")]
		private static bool TryGetLogPath(out string path)
		{
			int num = 0;
			if (!File.Exists(Path.Combine(Application.dataPath, "debug_log")))
			{
				int num2 = 0;
			}
			int num3 = 0;
			string text = Path.Combine(Application.dataPath, "debug_log.txt");
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C1F")]
		[Cpp2IlInjected.Address(RVA = "0x106B820", Offset = "0x106A220", VA = "0x18106B820")]
		public SystemLogQueue()
		{
			int num = 0;
			if (!File.Exists(Path.Combine(Application.dataPath, "debug_log")))
			{
			}
			int num2 = 0;
			string text = (LogPath = Path.Combine(Application.dataPath, "debug_log.txt"));
			if (1L != 0L && File.Exists(LogPath))
			{
				File.Delete(LogPath);
			}
			Application.logMessageReceived += OnLogMessage;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C20")]
		[Cpp2IlInjected.Address(RVA = "0x106B570", Offset = "0x1069F70", VA = "0x18106B570", Slot = "4")]
		public void Dispose()
		{
			Application.logMessageReceived -= OnLogMessage;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C21")]
		[Cpp2IlInjected.Address(RVA = "0x106B5E0", Offset = "0x1069FE0", VA = "0x18106B5E0")]
		private void OnLogMessage(string condition, string stackTrace, LogType type)
		{
			//Discarded unreachable code: IL_0045
			string item = condition + " " + stackTrace;
			Queue<string> queue = Logs;
			string text = (string)((Queue<T>)(object)queue).Dequeue();
			((Queue<T>)(object)queue).Enqueue((T)item);
			string logPath = LogPath;
			if (logPath != null)
			{
				List<string> list = (List<string>)(object)new List<T>();
				((List<T>)(object)list).Add((T)item);
				File.AppendAllLines(logPath, (IEnumerable<>)list);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C24")]
		[Cpp2IlInjected.Address(RVA = "0x106B460", Offset = "0x1069E60", VA = "0x18106B460")]
		private void AddToLogQueue(string msg)
		{
			//Discarded unreachable code: IL_0035
			Queue<string> queue = Logs;
			string text = (string)((Queue<T>)(object)queue).Dequeue();
			((Queue<T>)(object)queue).Enqueue((T)msg);
			string logPath = LogPath;
			if (logPath != null)
			{
				List<string> list = (List<string>)(object)new List<T>();
				((List<T>)(object)list).Add((T)msg);
				File.AppendAllLines(logPath, (IEnumerable<>)list);
			}
		}
	}
}
