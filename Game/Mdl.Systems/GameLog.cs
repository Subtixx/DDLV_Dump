using Cpp2IlInjected;
using Serilog;
using UnityEngine;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000979")]
	public static class GameLog
	{
		[Cpp2IlInjected.Token(Token = "0x6002C25")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF50", Offset = "0x8BB950", VA = "0x1808BCF50")]
		public static void Info(string msg, params object[] args)
		{
			//Discarded unreachable code: IL_002c
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.SeriLogger != null)
			{
				Serilog.ILogger seriLogger = SystemRoot.Instance.SeriLogger;
			}
			else
			{
				Debug.Log(string.Format(msg, args));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C26")]
		[Cpp2IlInjected.Address(RVA = "0x8BD120", Offset = "0x8BBB20", VA = "0x1808BD120")]
		public static void Warning(string msg, params object[] args)
		{
			//Discarded unreachable code: IL_002c
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.SeriLogger != null)
			{
				Serilog.ILogger seriLogger = SystemRoot.Instance.SeriLogger;
			}
			else
			{
				Debug.LogWarning(string.Format(msg, args));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C27")]
		[Cpp2IlInjected.Address(RVA = "0x8BCD80", Offset = "0x8BB780", VA = "0x1808BCD80")]
		public static void Error(string msg, params object[] args)
		{
			//Discarded unreachable code: IL_002c
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.SeriLogger != null)
			{
				Serilog.ILogger seriLogger = SystemRoot.Instance.SeriLogger;
			}
			else
			{
				Debug.LogError(string.Format(msg, args));
			}
		}
	}
}
