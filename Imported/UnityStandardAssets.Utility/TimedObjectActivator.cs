using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public enum Action
		{
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			Activate,
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			Deactivate,
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			Destroy,
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			ReloadLevel,
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			Call
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public class Entry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public GameObject target;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public Action action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public float delay;

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public class Entries
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public Entry[] entries;

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Entries()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Entries entries = new Entries();

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3740", Offset = "0x3DC2140", VA = "0x183DC3740")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0084
			Entry[] array = entries.entries;
			int num = 0;
			int length = array.Length;
			if (num >= length)
			{
				return;
			}
			Entry entry = array[num];
			Action action = entry.action;
			if (action != 0)
			{
				if (action != 0)
				{
					if (action != 0)
					{
						if (action != Action.Deactivate)
						{
							goto IL_007f;
						}
						IEnumerator enumerator = ReloadLevel(entry);
					}
					GameObject target = entry.target;
					float delay = entry.delay;
					UnityEngine.Object.Destroy(target, delay);
					num++;
				}
				IEnumerator enumerator2 = Deactivate(entry);
			}
			IEnumerator routine = Activate(entry);
			Coroutine coroutine = StartCoroutine(routine);
			goto IL_007f;
			IL_007f:
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC36D0", Offset = "0x3DC20D0", VA = "0x183DC36D0")]
		[IteratorStateMachine(typeof(_003CActivate_003Ed__5))]
		private IEnumerator Activate(Entry entry)
		{
			//IL_0016: Expected I4, but got I8
			_003CActivate_003Ed__5 _003CActivate_003Ed__ = default(_003CActivate_003Ed__5);
			((IDisposable)_003CActivate_003Ed__).Dispose();
			_003CActivate_003Ed__.entry = entry;
			_003CActivate_003Ed__._003C_003E1__state = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3890", Offset = "0x3DC2290", VA = "0x183DC3890")]
		[IteratorStateMachine(typeof(_003CDeactivate_003Ed__6))]
		private IEnumerator Deactivate(Entry entry)
		{
			//IL_0016: Expected I4, but got I8
			_003CDeactivate_003Ed__6 _003CDeactivate_003Ed__ = default(_003CDeactivate_003Ed__6);
			((IDisposable)_003CDeactivate_003Ed__).Dispose();
			_003CDeactivate_003Ed__.entry = entry;
			_003CDeactivate_003Ed__._003C_003E1__state = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3900", Offset = "0x3DC2300", VA = "0x183DC3900")]
		[IteratorStateMachine(typeof(_003CReloadLevel_003Ed__7))]
		private IEnumerator ReloadLevel(Entry entry)
		{
			//IL_0016: Expected I4, but got I8
			_003CReloadLevel_003Ed__7 _003CReloadLevel_003Ed__ = default(_003CReloadLevel_003Ed__7);
			((IDisposable)_003CReloadLevel_003Ed__).Dispose();
			_003CReloadLevel_003Ed__.entry = entry;
			_003CReloadLevel_003Ed__._003C_003E1__state = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3970", Offset = "0x3DC2370", VA = "0x183DC3970")]
		public TimedObjectActivator()
		{
		}
	}
}
