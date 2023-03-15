using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Log;
using Serilog;
using UnityEngine;

namespace Mdl.Platform.Xbox
{
	[Cpp2IlInjected.Token(Token = "0x2000312")]
	public class XboxUserAccount : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400164D")]
		private static XboxUserAccount _instance;

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public string GamerTag
		{
			[Cpp2IlInjected.Token(Token = "0x6000D61")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CGamerTag_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D62")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CGamerTag_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		[field: Cpp2IlInjected.Token(Token = "0x400164C")]
		private static Serilog.ILogger Logger
		{
			[Cpp2IlInjected.Token(Token = "0x6000D63")]
			[Cpp2IlInjected.Address(RVA = "0x842AF0", Offset = "0x8414F0", VA = "0x180842AF0")]
			get;
		} = Serilogger.Create<XboxUserAccount>();


		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public static XboxUserAccount Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000D64")]
			[Cpp2IlInjected.Address(RVA = "0x842950", Offset = "0x841350", VA = "0x180842950")]
			get
			{
				//Discarded unreachable code: IL_0034
				//IL_000f: Expected O, but got I4
				XboxUserAccount instance = _instance;
				int num = 0;
				if (instance == (Object)num)
				{
					GameObject gameObject = new GameObject("XboxUserAccount");
					Object.DontDestroyOnLoad(gameObject);
					Logger = (Serilog.ILogger)gameObject.AddComponent<XboxUserAccount>();
				}
				return _instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D65")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public XboxUserAccount()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D66")]
		[Cpp2IlInjected.Address(RVA = "0x8428D0", Offset = "0x8412D0", VA = "0x1808428D0")]
		static XboxUserAccount()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
