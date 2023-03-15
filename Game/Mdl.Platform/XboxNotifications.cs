using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Log;
using Serilog;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002B2")]
	public class XboxNotifications : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20002B3")]
		public delegate void ApplicationPauseCB(bool isPaused);

		[Cpp2IlInjected.Token(Token = "0x20002B4")]
		public delegate void ApplicationQuit();

		[Cpp2IlInjected.Token(Token = "0x4001519")]
		public static XboxNotifications Instance;

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		[field: Cpp2IlInjected.Token(Token = "0x4001518")]
		private static Serilog.ILogger Logger
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x842730", Offset = "0x841130", VA = "0x180842730")]
			get;
		} = Serilogger.Create<XboxNotifications>();


		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event ApplicationPauseCB OnApplicationPause
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE5")]
			[Cpp2IlInjected.Address(RVA = "0x8425F0", Offset = "0x840FF0", VA = "0x1808425F0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000BE6")]
			[Cpp2IlInjected.Address(RVA = "0x842790", Offset = "0x841190", VA = "0x180842790")]
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

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event ApplicationQuit OnApplicationQuit
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE7")]
			[Cpp2IlInjected.Address(RVA = "0x842690", Offset = "0x841090", VA = "0x180842690")]
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
			[Cpp2IlInjected.Token(Token = "0x6000BE8")]
			[Cpp2IlInjected.Address(RVA = "0x842830", Offset = "0x841230", VA = "0x180842830")]
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

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x842470", Offset = "0x840E70", VA = "0x180842470")]
		private void Awake()
		{
			Logger = (Serilog.ILogger)this;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEA")]
		[Cpp2IlInjected.Address(RVA = "0x8424E0", Offset = "0x840EE0", VA = "0x1808424E0")]
		private void OnDestroy()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEB")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public XboxNotifications()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x842550", Offset = "0x840F50", VA = "0x180842550")]
		static XboxNotifications()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
