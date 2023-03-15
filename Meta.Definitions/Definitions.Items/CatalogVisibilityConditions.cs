using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000293")]
	public sealed class CatalogVisibilityConditions : IMessage<CatalogVisibilityConditions>, IMessage, IEquatable<CatalogVisibilityConditions>, IDeepCloneable<CatalogVisibilityConditions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000A3F")]
		private static readonly MessageParser<CatalogVisibilityConditions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000A40")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000A41")]
		public const int MinLevelFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000A42")]
		private int minLevel_;

		[Cpp2IlInjected.Token(Token = "0x4000A43")]
		public const int CharacterIdFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000A44")]
		private int characterId_;

		[Cpp2IlInjected.Token(Token = "0x4000A45")]
		public const int MinFriendshipFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000A46")]
		private int minFriendship_;

		[Cpp2IlInjected.Token(Token = "0x17000561")]
		[DebuggerNonUserCode]
		public static MessageParser<CatalogVisibilityConditions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001998")]
			[Cpp2IlInjected.Address(RVA = "0x2893690", Offset = "0x2892090", VA = "0x182893690")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000562")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001999")]
			[Cpp2IlInjected.Address(RVA = "0x2893500", Offset = "0x2891F00", VA = "0x182893500")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000563")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600199A")]
			[Cpp2IlInjected.Address(RVA = "0x28936F0", Offset = "0x28920F0", VA = "0x1828936F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000564")]
		[DebuggerNonUserCode]
		public int MinLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600199E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return minLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x600199F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				minLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000565")]
		[DebuggerNonUserCode]
		public int CharacterId
		{
			[Cpp2IlInjected.Token(Token = "0x60019A0")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return characterId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60019A1")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				characterId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000566")]
		[DebuggerNonUserCode]
		public int MinFriendship
		{
			[Cpp2IlInjected.Token(Token = "0x60019A2")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return minFriendship_;
			}
			[Cpp2IlInjected.Token(Token = "0x60019A3")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				minFriendship_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000567")]
		private Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x60019AF")]
			[Cpp2IlInjected.Address(RVA = "0x28934A0", Offset = "0x2891EA0", VA = "0x1828934A0")]
			get
			{
				long num = Convert.ToInt64((uint)characterId_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000568")]
		public bool IsDefined
		{
			[Cpp2IlInjected.Token(Token = "0x60019B0")]
			[Cpp2IlInjected.Address(RVA = "0x28935D0", Offset = "0x2891FD0", VA = "0x1828935D0")]
			get
			{
				if (minLevel_ != 0)
				{
					return true;
				}
				long num = Convert.ToInt64((uint)characterId_);
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600199B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CatalogVisibilityConditions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600199C")]
		[Cpp2IlInjected.Address(RVA = "0x15E0450", Offset = "0x15DEE50", VA = "0x1815E0450")]
		[DebuggerNonUserCode]
		public CatalogVisibilityConditions(CatalogVisibilityConditions other)
		{
			int num = (minLevel_ = other.minLevel_);
			int num2 = (characterId_ = other.characterId_);
			int num3 = (minFriendship_ = other.minFriendship_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600199D")]
		[Cpp2IlInjected.Address(RVA = "0x2893020", Offset = "0x2891A20", VA = "0x182893020", Slot = "10")]
		[DebuggerNonUserCode]
		public CatalogVisibilityConditions Clone()
		{
			//Discarded unreachable code: IL_0047
			CatalogVisibilityConditions catalogVisibilityConditions = new CatalogVisibilityConditions();
			int num = (catalogVisibilityConditions.minLevel_ = minLevel_);
			int num2 = (catalogVisibilityConditions.characterId_ = characterId_);
			int num3 = (catalogVisibilityConditions.minFriendship_ = minFriendship_);
			UnknownFieldSet unknownFieldSet = (catalogVisibilityConditions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return catalogVisibilityConditions;
		}

		[Cpp2IlInjected.Token(Token = "0x60019A4")]
		[Cpp2IlInjected.Address(RVA = "0x28930B0", Offset = "0x2891AB0", VA = "0x1828930B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)minLevel_ == (IntPtr)typeof(CatalogVisibilityConditions).TypeHandle && (IntPtr)characterId_ == (IntPtr)typeof(CatalogVisibilityConditions).TypeHandle && (IntPtr)minFriendship_ == (IntPtr)typeof(CatalogVisibilityConditions).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60019A5")]
		[Cpp2IlInjected.Address(RVA = "0x180AFA0", Offset = "0x18099A0", VA = "0x18180AFA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CatalogVisibilityConditions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.minLevel_;
				if (minLevel_ == num)
				{
					int num2 = other.characterId_;
					if (characterId_ == num2)
					{
						int num3 = other.minFriendship_;
						if (minFriendship_ == num3)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60019A6")]
		[Cpp2IlInjected.Address(RVA = "0x25C36F0", Offset = "0x25C20F0", VA = "0x1825C36F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (minLevel_ != 0)
				{
				}
				if (characterId_ != 0)
				{
				}
				if (minFriendship_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60019A7")]
		[Cpp2IlInjected.Address(RVA = "0x2893330", Offset = "0x2891D30", VA = "0x182893330", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60019A8")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA520", Offset = "0x1DF8F20", VA = "0x181DFA520", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0058
			if (minLevel_ != 0)
			{
				int value = minLevel_;
				output.WriteInt32(value);
			}
			if (characterId_ != 0)
			{
				int value2 = characterId_;
				output.WriteInt32(value2);
			}
			if (minFriendship_ != 0)
			{
				int value3 = minFriendship_;
				output.WriteInt32(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60019A9")]
		[Cpp2IlInjected.Address(RVA = "0x2892BC0", Offset = "0x28915C0", VA = "0x182892BC0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = minLevel_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = characterId_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				int num6 = minFriendship_;
				if (num6 != 0)
				{
					int num7 = CodedOutputStream.ComputeInt32Size(num6);
					num7++;
					num2 += num7;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num8 = unknownFields.CalculateSize();
			return num8 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60019AA")]
		[Cpp2IlInjected.Address(RVA = "0x180B160", Offset = "0x1809B60", VA = "0x18180B160", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CatalogVisibilityConditions other)
		{
			if (other != null)
			{
				int num = other.minLevel_;
				if (num != 0)
				{
					minLevel_ = num;
				}
				int num2 = other.characterId_;
				if (num2 != 0)
				{
					characterId_ = num2;
				}
				int num3 = other.minFriendship_;
				if (num3 != 0)
				{
					minFriendship_ = num3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019AB")]
		[Cpp2IlInjected.Address(RVA = "0x180B1D0", Offset = "0x1809BD0", VA = "0x18180B1D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (minLevel_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (characterId_ = input.ReadInt32());
				}
				if (num3 == 24)
				{
					int num4 = (minFriendship_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019AC")]
		[Cpp2IlInjected.Address(RVA = "0x2893150", Offset = "0x2891B50", VA = "0x182893150", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 1)
			{
				int num2 = minLevel_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60019AD")]
		[Cpp2IlInjected.Address(RVA = "0x2893220", Offset = "0x2891C20", VA = "0x182893220", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					minFriendship_ = (int)obj2;
					break;
				}
				case 0:
				{
					object obj = default(object);
					characterId_ = (int)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				minLevel_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019AE")]
		[Cpp2IlInjected.Address(RVA = "0x15DF800", Offset = "0x15DE200", VA = "0x1815DF800", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				minFriendship_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019B1")]
		[Cpp2IlInjected.Address(RVA = "0x2892CC0", Offset = "0x28916C0", VA = "0x182892CC0")]
		public bool? CanBuy(in PlayerProfile playerProfile, in WorldProfile worldProfile)
		{
			if (minLevel_ == 0)
			{
				int num = characterId_;
				bool flag = default(bool);
				if (flag)
				{
				}
			}
			int num2 = 0;
			if (minLevel_ != num2)
			{
				IProfilePlayer section = playerProfile.Section;
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					num2++;
				}
			}
			int num4 = characterId_;
			bool flag2 = default(bool);
			if (flag2)
			{
				IProfileWorld section2 = worldProfile.Section;
				int num5 = characterId_;
				uint num6 = default(uint);
				if (num2 < (int)num6)
				{
					num2 += num2;
					num2++;
				}
				if (num2 < minFriendship_)
				{
					int num7 = 0;
					num7 += num7;
					num2 += 360;
					num7 += num7;
					num2 += 392;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019B2")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620")]
		public bool CanView(in PlayerProfile playerProfile, in WorldProfile worldProfile)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60019B3")]
		[Cpp2IlInjected.Address(RVA = "0x2893390", Offset = "0x2891D90", VA = "0x182893390")]
		static CatalogVisibilityConditions()
		{
			Func<CatalogVisibilityConditions> func = default(Func<CatalogVisibilityConditions>);
			_parser = (MessageParser<CatalogVisibilityConditions>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
