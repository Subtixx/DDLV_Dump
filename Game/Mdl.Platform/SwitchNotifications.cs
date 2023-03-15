using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002DF")]
	public class SwitchNotifications : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20002E0")]
		public delegate void ApplicationFocusCB(bool isFocused);

		[Cpp2IlInjected.Token(Token = "0x20002E1")]
		public delegate void ApplicationPauseCB(bool isPaused);

		[Cpp2IlInjected.Token(Token = "0x20002E2")]
		public delegate void ApplicationQuitCB();

		[Cpp2IlInjected.Token(Token = "0x40015BA")]
		public static SwitchNotifications Instance;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event ApplicationFocusCB OnApplicationFocus
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAA")]
			[Cpp2IlInjected.Address(RVA = "0x1069F70", Offset = "0x1068970", VA = "0x181069F70")]
			[CompilerGenerated]
			add
			{
				ApplicationFocusCB onApplicationFocus = this.OnApplicationFocus;
				Delegate @delegate = Delegate.Combine(onApplicationFocus, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onApplicationFocus)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000CAB")]
			[Cpp2IlInjected.Address(RVA = "0x106A150", Offset = "0x1068B50", VA = "0x18106A150")]
			[CompilerGenerated]
			remove
			{
				ApplicationFocusCB onApplicationFocus = this.OnApplicationFocus;
				Delegate @delegate = Delegate.Remove(onApplicationFocus, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onApplicationFocus)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event ApplicationPauseCB OnApplicationPause
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAC")]
			[Cpp2IlInjected.Address(RVA = "0x106A010", Offset = "0x1068A10", VA = "0x18106A010")]
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
			[Cpp2IlInjected.Token(Token = "0x6000CAD")]
			[Cpp2IlInjected.Address(RVA = "0x106A1F0", Offset = "0x1068BF0", VA = "0x18106A1F0")]
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

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event ApplicationQuitCB OnApplicationQuit
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAE")]
			[Cpp2IlInjected.Address(RVA = "0x106A0B0", Offset = "0x1068AB0", VA = "0x18106A0B0")]
			[CompilerGenerated]
			add
			{
				ApplicationQuitCB onApplicationQuit = this.OnApplicationQuit;
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
			[Cpp2IlInjected.Token(Token = "0x6000CAF")]
			[Cpp2IlInjected.Address(RVA = "0x106A290", Offset = "0x1068C90", VA = "0x18106A290")]
			[CompilerGenerated]
			remove
			{
				ApplicationQuitCB onApplicationQuit = this.OnApplicationQuit;
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

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0x1069EA0", Offset = "0x10688A0", VA = "0x181069EA0")]
		private void Awake()
		{
			Instance = this;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x1069F10", Offset = "0x1068910", VA = "0x181069F10")]
		private void OnDestroy()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SwitchNotifications()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		static SwitchNotifications()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
