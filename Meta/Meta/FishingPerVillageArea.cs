using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200091E")]
	public sealed class FishingPerVillageArea : IMessage<FishingPerVillageArea>, IMessage, IEquatable<FishingPerVillageArea>, IDeepCloneable<FishingPerVillageArea>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40024F5")]
		private static readonly MessageParser<FishingPerVillageArea> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024F6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40024F7")]
		public const int LocationFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024F8")]
		private VillageAreaType location_;

		[Cpp2IlInjected.Token(Token = "0x40024F9")]
		public const int RarityFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40024FA")]
		private FishRippleRarity rarity_;

		[Cpp2IlInjected.Token(Token = "0x17000D81")]
		[DebuggerNonUserCode]
		public static MessageParser<FishingPerVillageArea> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004F3F")]
			[Cpp2IlInjected.Address(RVA = "0x1800BC0", Offset = "0x17FF5C0", VA = "0x181800BC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D82")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F40")]
			[Cpp2IlInjected.Address(RVA = "0x1800AF0", Offset = "0x17FF4F0", VA = "0x181800AF0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D83")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004F41")]
			[Cpp2IlInjected.Address(RVA = "0x1800C20", Offset = "0x17FF620", VA = "0x181800C20", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D84")]
		[DebuggerNonUserCode]
		public VillageAreaType Location
		{
			[Cpp2IlInjected.Token(Token = "0x6004F45")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F46")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D85")]
		[DebuggerNonUserCode]
		public FishRippleRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6004F47")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return rarity_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F48")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				rarity_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F42")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public FishingPerVillageArea()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004F43")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public FishingPerVillageArea(FishingPerVillageArea other)
		{
			VillageAreaType villageAreaType = (location_ = other.location_);
			FishRippleRarity fishRippleRarity = (rarity_ = other.rarity_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F44")]
		[Cpp2IlInjected.Address(RVA = "0x18006A0", Offset = "0x17FF0A0", VA = "0x1818006A0", Slot = "10")]
		[DebuggerNonUserCode]
		public FishingPerVillageArea Clone()
		{
			//Discarded unreachable code: IL_0037
			FishingPerVillageArea fishingPerVillageArea = new FishingPerVillageArea();
			VillageAreaType villageAreaType = (fishingPerVillageArea.location_ = location_);
			FishRippleRarity fishRippleRarity = (fishingPerVillageArea.rarity_ = rarity_);
			UnknownFieldSet unknownFieldSet = (fishingPerVillageArea._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return fishingPerVillageArea;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F49")]
		[Cpp2IlInjected.Address(RVA = "0x1800730", Offset = "0x17FF130", VA = "0x181800730", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)location_ == (IntPtr)typeof(FishingPerVillageArea).TypeHandle && (IntPtr)(void*)(int)rarity_ == (IntPtr)typeof(FishingPerVillageArea).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4A")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(FishingPerVillageArea other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				VillageAreaType villageAreaType = other.location_;
				if (location_ == villageAreaType)
				{
					FishRippleRarity fishRippleRarity = other.rarity_;
					if (rarity_ == fishRippleRarity)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4B")]
		[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (location_ != 0)
				{
				}
				if (rarity_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4C")]
		[Cpp2IlInjected.Address(RVA = "0x1800980", Offset = "0x17FF380", VA = "0x181800980", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4D")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0025
			if (location_ != 0)
			{
			}
			if (rarity_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4E")]
		[Cpp2IlInjected.Address(RVA = "0x18005D0", Offset = "0x17FEFD0", VA = "0x1818005D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				VillageAreaType villageAreaType = location_;
				num = 0;
				if (villageAreaType != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)villageAreaType);
				}
				FishRippleRarity fishRippleRarity = rarity_;
				if (fishRippleRarity != 0)
				{
					int num3 = CodedOutputStream.ComputeEnumSize((int)fishRippleRarity);
					num3++;
					num += num3;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4F")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(FishingPerVillageArea other)
		{
			if (other != null)
			{
				VillageAreaType villageAreaType = other.location_;
				if (villageAreaType != 0)
				{
					location_ = villageAreaType;
				}
				FishRippleRarity fishRippleRarity = other.rarity_;
				if (fishRippleRarity != 0)
				{
					rarity_ = fishRippleRarity;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F50")]
		[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(location_ = (VillageAreaType)input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (int)(rarity_ = (FishRippleRarity)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F51")]
		[Cpp2IlInjected.Address(RVA = "0x18007C0", Offset = "0x17FF1C0", VA = "0x1818007C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				VillageAreaType villageAreaType = location_;
			}
			if (fieldNumber == 2)
			{
				FishRippleRarity fishRippleRarity = rarity_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F52")]
		[Cpp2IlInjected.Address(RVA = "0x18008B0", Offset = "0x17FF2B0", VA = "0x1818008B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				location_ = (VillageAreaType)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			rarity_ = (FishRippleRarity)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F53")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				location_ = VillageAreaType.Beach;
				break;
			case 2:
				rarity_ = FishRippleRarity.BodyOfWater;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F54")]
		[Cpp2IlInjected.Address(RVA = "0x18009E0", Offset = "0x17FF3E0", VA = "0x1818009E0")]
		static FishingPerVillageArea()
		{
			Func<FishingPerVillageArea> func = default(Func<FishingPerVillageArea>);
			_parser = (MessageParser<FishingPerVillageArea>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
