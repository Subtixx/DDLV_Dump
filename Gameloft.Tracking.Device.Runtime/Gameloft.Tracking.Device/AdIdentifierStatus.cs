using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Rewired.UI;

namespace Gameloft.Tracking.Device
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct AdIdentifierStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly AdIdentifierStatus Null;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsDetermined
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6F01E0", Offset = "0x6EEBE0", VA = "0x1806F01E0")]
			[CompilerGenerated]
			readonly get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6F01F0", Offset = "0x6EEBF0", VA = "0x1806F01F0")]
			[CompilerGenerated]
			set
			{
				_003CIsDetermined_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1"), Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsAuthorized
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x16B7F90", Offset = "0x16B6990", VA = "0x1816B7F90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x402B880", Offset = "0x402A280", VA = "0x18402B880")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6DDCA0", Offset = "0x6DC6A0", VA = "0x1806DDCA0")]
			[CompilerGenerated]
			readonly get
			{
				return _003CIdentifier_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6DDCD0", Offset = "0x6DC6D0", VA = "0x1806DDCD0")]
			[CompilerGenerated]
			set
			{
				_003CIdentifier_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x402B730", Offset = "0x402A130", VA = "0x18402B730")]
		public bool Equals(AdIdentifierStatus other)
		{
			bool flag = other.IsAuthorized;
			if (IsAuthorized == flag)
			{
				string b = other.Identifier;
				return string.Equals(Identifier, b);
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x402B610", Offset = "0x402A010", VA = "0x18402B610", Slot = "0")]
		public override bool Equals(object other)
		{
			Type type = other.GetType();
			Type typeFromHandle = typeof(AdIdentifierStatus);
			if (((object)type).Equals((object)typeFromHandle))
			{
				string text = Identifier;
			}
			int num = 0;
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x402B760", Offset = "0x402A160", VA = "0x18402B760", Slot = "2")]
		public override int GetHashCode()
		{
			string text = Identifier;
			Tuple<string, bool, bool> tuple = default(Tuple<string, bool, bool>);
			bool enabled = ((IMouseInputSource)tuple).enabled;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x402B7D0", Offset = "0x402A1D0", VA = "0x18402B7D0")]
		static AdIdentifierStatus()
		{
			//IL_000e: Expected O, but got I4
			int num = 0;
			Guid empty = Guid.Empty;
			Null = (AdIdentifierStatus)num;
		}
	}
}
