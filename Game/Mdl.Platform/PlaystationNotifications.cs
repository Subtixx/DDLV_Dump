using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002CD")]
	public class PlaystationNotifications : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20002CE")]
		public delegate void ApplicationPauseCB(bool isPaused);

		[Cpp2IlInjected.Token(Token = "0x20002CF")]
		public delegate void ApplicationQuit();

		[Cpp2IlInjected.Token(Token = "0x20002D0")]
		public delegate void SystemUiOverlaid(bool isOverlaid);

		[Cpp2IlInjected.Token(Token = "0x400158B")]
		public static PlaystationNotifications Instance;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event ApplicationPauseCB OnApplicationPause
		{
			[Cpp2IlInjected.Token(Token = "0x6000C63")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F10", Offset = "0xCB1910", VA = "0x180CB2F10")]
			[CompilerGenerated]
			add
			{
				ApplicationPauseCB onApplicationPause = this.OnApplicationPause;
				Delegate @delegate = Delegate.Combine(onApplicationPause, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onApplicationPause)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000C64")]
			[Cpp2IlInjected.Address(RVA = "0xCB30F0", Offset = "0xCB1AF0", VA = "0x180CB30F0")]
			[CompilerGenerated]
			remove
			{
				ApplicationPauseCB onApplicationPause = this.OnApplicationPause;
				Delegate @delegate = Delegate.Remove(onApplicationPause, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onApplicationPause)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event ApplicationQuit OnApplicationQuit
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0xCB2FB0", Offset = "0xCB19B0", VA = "0x180CB2FB0")]
			[CompilerGenerated]
			add
			{
				ApplicationQuit onApplicationQuit = this.OnApplicationQuit;
				Delegate @delegate = Delegate.Combine(onApplicationQuit, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onApplicationQuit)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000C66")]
			[Cpp2IlInjected.Address(RVA = "0xCB3190", Offset = "0xCB1B90", VA = "0x180CB3190")]
			[CompilerGenerated]
			remove
			{
				ApplicationQuit onApplicationQuit = this.OnApplicationQuit;
				Delegate @delegate = Delegate.Remove(onApplicationQuit, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onApplicationQuit)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event SystemUiOverlaid OnSystemUiOverlaid
		{
			[Cpp2IlInjected.Token(Token = "0x6000C67")]
			[Cpp2IlInjected.Address(RVA = "0xCB3050", Offset = "0xCB1A50", VA = "0x180CB3050")]
			[CompilerGenerated]
			add
			{
				SystemUiOverlaid onSystemUiOverlaid = this.OnSystemUiOverlaid;
				Delegate @delegate = Delegate.Combine(onSystemUiOverlaid, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSystemUiOverlaid)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000C68")]
			[Cpp2IlInjected.Address(RVA = "0xCB3230", Offset = "0xCB1C30", VA = "0x180CB3230")]
			[CompilerGenerated]
			remove
			{
				SystemUiOverlaid onSystemUiOverlaid = this.OnSystemUiOverlaid;
				Delegate @delegate = Delegate.Remove(onSystemUiOverlaid, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSystemUiOverlaid)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0xCB2E40", Offset = "0xCB1840", VA = "0x180CB2E40")]
		private void Awake()
		{
			Instance = this;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0xCB2EB0", Offset = "0xCB18B0", VA = "0x180CB2EB0")]
		private void OnDestroy()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PlaystationNotifications()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		static PlaystationNotifications()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
