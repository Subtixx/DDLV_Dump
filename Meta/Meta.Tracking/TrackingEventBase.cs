using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A69")]
	public abstract class TrackingEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000A6A")]
		public enum DispatchMode
		{
			[Cpp2IlInjected.Token(Token = "0x4002928")]
			MainOnly,
			[Cpp2IlInjected.Token(Token = "0x4002929")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400292A")]
			WhenShouldTrack
		}

		[Cpp2IlInjected.Token(Token = "0x4002922")]
		protected static int InvalidEventId;

		[Cpp2IlInjected.Token(Token = "0x4002923")]
		private static int InvalidEventIdCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002926")]
		public bool isHighPriority;

		[Cpp2IlInjected.Token(Token = "0x17000ECE")]
		public Dictionary<string, object> Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x60059F9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CParameters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60059FA")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CParameters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x17000ECF")]
		public Dictionary<string, object> ComplexParameters
		{
			[Cpp2IlInjected.Token(Token = "0x60059FB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CComplexParameters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60059FC")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CComplexParameters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x17000ED0")]
		public abstract string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x60059FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED1")]
		protected abstract int EventId
		{
			[Cpp2IlInjected.Token(Token = "0x60059FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED2")]
		protected virtual DispatchMode EventDispatchMode
		{
			[Cpp2IlInjected.Token(Token = "0x60059FF")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED3")]
		public bool DispatchToMainOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6005A00")]
			[Cpp2IlInjected.Address(RVA = "0x78CB80", Offset = "0x78B580", VA = "0x18078CB80")]
			get
			{
				return EventDispatchMode == DispatchMode.MainOnly;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED4")]
		public bool DispatchToAll
		{
			[Cpp2IlInjected.Token(Token = "0x6005A01")]
			[Cpp2IlInjected.Address(RVA = "0x78CB60", Offset = "0x78B560", VA = "0x18078CB60")]
			get
			{
				return EventDispatchMode == DispatchMode.All;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000ED5")]
		public bool DispatchWhenShouldTrack
		{
			[Cpp2IlInjected.Token(Token = "0x6005A02")]
			[Cpp2IlInjected.Address(RVA = "0x78CBA0", Offset = "0x78B5A0", VA = "0x18078CBA0")]
			get
			{
				return EventDispatchMode == DispatchMode.WhenShouldTrack;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005A03")]
		[Cpp2IlInjected.Address(RVA = "0x78C990", Offset = "0x78B390", VA = "0x18078C990")]
		public int GetEventId()
		{
			int eventId = EventId;
			string eventName = EventName;
			return InvalidEventIdCounter++;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A04")]
		[Cpp2IlInjected.Address(RVA = "0x175B050", Offset = "0x1759A50", VA = "0x18175B050")]
		protected void AddParameter<T>(T t, string P_1)
		{
			//Discarded unreachable code: IL_0015, IL_0016
			string text = FirstCharLowerCase(P_1);
			Dictionary<string, object> dictionary = Parameters;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005A05")]
		[Cpp2IlInjected.Address(RVA = "0x175AFD0", Offset = "0x17599D0", VA = "0x18175AFD0")]
		protected void AddComplexParameter<T>(T t, string P_1)
		{
			//Discarded unreachable code: IL_0010
			string text = FirstCharLowerCase(P_1);
			Dictionary<string, object> dictionary = ComplexParameters;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A06")]
		[Cpp2IlInjected.Address(RVA = "0x78C900", Offset = "0x78B300", VA = "0x18078C900")]
		private string FirstCharLowerCase(string name)
		{
			//Discarded unreachable code: IL_001e
			char c = Enumerable.First<char>((IEnumerable<>)(object)name);
			string text = default(string);
			string text2 = text.ToLower();
			string text3 = name.Substring(1);
			return text2 + text3;
		}

		[Cpp2IlInjected.Token(Token = "0x6005A07")]
		[Cpp2IlInjected.Address(RVA = "0x78CAB0", Offset = "0x78B4B0", VA = "0x18078CAB0")]
		protected TrackingEventBase()
		{
		}
	}
}
