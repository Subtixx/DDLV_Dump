using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000319")]
	public sealed class SecretCharacterLocationFilter : IMessage<SecretCharacterLocationFilter>, IMessage, IEquatable<SecretCharacterLocationFilter>, IDeepCloneable<SecretCharacterLocationFilter>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200031A")]
		public enum LocationTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4000FBD")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000FBE")]
			VillageArea,
			[Cpp2IlInjected.Token(Token = "0x4000FBF")]
			Scene
		}

		[Cpp2IlInjected.Token(Token = "0x4000FB6")]
		private static readonly MessageParser<SecretCharacterLocationFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000FB7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000FB8")]
		public const int VillageAreaFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000FB9")]
		public const int SceneFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000FBA")]
		private object locationType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000FBB")]
		private LocationTypeOneofCase locationTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x170008D2")]
		[DebuggerNonUserCode]
		public static MessageParser<SecretCharacterLocationFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60023F0")]
			[Cpp2IlInjected.Address(RVA = "0x38416E0", Offset = "0x38400E0", VA = "0x1838416E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008D3")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60023F1")]
			[Cpp2IlInjected.Address(RVA = "0x3841610", Offset = "0x3840010", VA = "0x183841610")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008D4")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60023F2")]
			[Cpp2IlInjected.Address(RVA = "0x3841820", Offset = "0x3840220", VA = "0x183841820", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008D5")]
		[DebuggerNonUserCode]
		public VillageAreaType VillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x60023F6")]
			[Cpp2IlInjected.Address(RVA = "0x38417B0", Offset = "0x38401B0", VA = "0x1838417B0")]
			get
			{
				if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
				{
					object obj = locationType_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60023F7")]
			[Cpp2IlInjected.Address(RVA = "0x38419A0", Offset = "0x38403A0", VA = "0x1838419A0")]
			set
			{
				//IL_0016: Expected I4, but got I8
				locationType_ = typeof(VillageAreaType).TypeHandle;
				locationTypeCase_ = LocationTypeOneofCase.VillageArea;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008D6")]
		[DebuggerNonUserCode]
		public int Scene
		{
			[Cpp2IlInjected.Token(Token = "0x60023F8")]
			[Cpp2IlInjected.Address(RVA = "0x3841740", Offset = "0x3840140", VA = "0x183841740")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (locationTypeCase_ == LocationTypeOneofCase.Scene)
				{
					object obj = locationType_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60023F9")]
			[Cpp2IlInjected.Address(RVA = "0x3841930", Offset = "0x3840330", VA = "0x183841930")]
			set
			{
				//IL_0014: Expected I4, but got I8
				locationType_ = typeof(int).TypeHandle;
				locationTypeCase_ = LocationTypeOneofCase.Scene;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008D7")]
		[DebuggerNonUserCode]
		public LocationTypeOneofCase LocationTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x60023FA")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return locationTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023F3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SecretCharacterLocationFilter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60023F4")]
		[Cpp2IlInjected.Address(RVA = "0x3841540", Offset = "0x383FF40", VA = "0x183841540")]
		[DebuggerNonUserCode]
		public SecretCharacterLocationFilter(SecretCharacterLocationFilter other)
		{
			//IL_002c: Expected I4, but got I8
			LocationTypeOneofCase locationTypeOneofCase = other.locationTypeCase_;
			if (locationTypeOneofCase == LocationTypeOneofCase.VillageArea)
			{
				int villageArea = (int)other.VillageArea;
				locationType_ = typeof(VillageAreaType).TypeHandle;
				locationTypeCase_ = LocationTypeOneofCase.VillageArea;
			}
			if (locationTypeOneofCase == LocationTypeOneofCase.Scene)
			{
				int num = (Scene = other.Scene);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60023F5")]
		[Cpp2IlInjected.Address(RVA = "0x3840B30", Offset = "0x383F530", VA = "0x183840B30", Slot = "10")]
		[DebuggerNonUserCode]
		public SecretCharacterLocationFilter Clone()
		{
			//Discarded unreachable code: IL_0055
			//IL_002c: Expected I4, but got I8
			SecretCharacterLocationFilter secretCharacterLocationFilter = new SecretCharacterLocationFilter();
			LocationTypeOneofCase locationTypeOneofCase = locationTypeCase_;
			if (locationTypeOneofCase == LocationTypeOneofCase.VillageArea)
			{
				int villageArea = (int)VillageArea;
				secretCharacterLocationFilter.locationType_ = typeof(VillageAreaType).TypeHandle;
				secretCharacterLocationFilter.locationTypeCase_ = LocationTypeOneofCase.VillageArea;
			}
			if (locationTypeOneofCase == LocationTypeOneofCase.Scene)
			{
				int num = (secretCharacterLocationFilter.Scene = Scene);
			}
			UnknownFieldSet unknownFieldSet = (secretCharacterLocationFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return secretCharacterLocationFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x60023FB")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearLocationType()
		{
			//IL_0010: Expected O, but got I4
			locationType_ = (locationTypeCase_ = LocationTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023FC")]
		[Cpp2IlInjected.Address(RVA = "0x3840C30", Offset = "0x383F630", VA = "0x183840C30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_003d: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				int villageArea = (int)VillageArea;
				VillageAreaType villageAreaType = default(VillageAreaType);
				if (villageArea == (int)villageAreaType)
				{
					int scene = Scene;
					int num = 0;
					villageArea = scene;
					int num2 = default(int);
					if (villageArea == num2 && locationTypeCase_ == (LocationTypeOneofCase)num2)
					{
						return object.Equals(_unknownFields, num);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023FD")]
		[Cpp2IlInjected.Address(RVA = "0x3840D10", Offset = "0x383F710", VA = "0x183840D10", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SecretCharacterLocationFilter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int villageArea = (int)VillageArea;
				VillageAreaType villageArea2 = other.VillageArea;
				if (villageArea == (int)villageArea2)
				{
					villageArea = Scene;
					int scene = other.Scene;
					if (villageArea == scene)
					{
						LocationTypeOneofCase locationTypeOneofCase = other.locationTypeCase_;
						if (locationTypeCase_ == locationTypeOneofCase)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023FE")]
		[Cpp2IlInjected.Address(RVA = "0x3840EA0", Offset = "0x383F8A0", VA = "0x183840EA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0049
			int num = 0;
			if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
			{
				if (locationTypeCase_ != LocationTypeOneofCase.VillageArea)
				{
				}
				object obj = locationType_;
			}
			if (locationTypeCase_ == LocationTypeOneofCase.Scene && locationTypeCase_ == LocationTypeOneofCase.Scene)
			{
				object obj2 = locationType_;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60023FF")]
		[Cpp2IlInjected.Address(RVA = "0x3841330", Offset = "0x383FD30", VA = "0x183841330", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002400")]
		[Cpp2IlInjected.Address(RVA = "0x3841390", Offset = "0x383FD90", VA = "0x183841390", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003e
			LocationTypeOneofCase locationTypeOneofCase = locationTypeCase_;
			if (locationTypeOneofCase == LocationTypeOneofCase.VillageArea)
			{
				int villageArea = (int)VillageArea;
				output.WriteInt32(villageArea);
			}
			if (locationTypeOneofCase == LocationTypeOneofCase.Scene)
			{
				int scene = Scene;
				output.WriteInt32(scene);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6002401")]
		[Cpp2IlInjected.Address(RVA = "0x3840890", Offset = "0x383F290", VA = "0x183840890", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0061
			int num = 0;
			if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
			{
				if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
				{
					object obj = locationType_;
				}
				int num2 = CodedOutputStream.ComputeEnumSize(num);
			}
			if (locationTypeCase_ == LocationTypeOneofCase.Scene)
			{
				if (locationTypeCase_ == LocationTypeOneofCase.Scene)
				{
					object obj2 = locationType_;
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6002402")]
		[Cpp2IlInjected.Address(RVA = "0x3841090", Offset = "0x383FA90", VA = "0x183841090", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SecretCharacterLocationFilter other)
		{
			if (other != null)
			{
				LocationTypeOneofCase locationTypeOneofCase = other.locationTypeCase_;
				if (locationTypeOneofCase == LocationTypeOneofCase.VillageArea)
				{
					VillageAreaType villageArea = other.VillageArea;
				}
				if (locationTypeOneofCase == LocationTypeOneofCase.Scene)
				{
					int num = (Scene = other.Scene);
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002403")]
		[Cpp2IlInjected.Address(RVA = "0x3841110", Offset = "0x383FB10", VA = "0x183841110", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0051
			//IL_001f: Expected O, but got I4
			//IL_0028: Expected I4, but got I8
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = input.ReadInt32();
					locationType_ = num2;
					locationTypeCase_ = LocationTypeOneofCase.VillageArea;
				}
				if (num == 16)
				{
					int num4 = (Scene = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002404")]
		[Cpp2IlInjected.Address(RVA = "0x3840DB0", Offset = "0x383F7B0", VA = "0x183840DB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				VillageAreaType villageArea = VillageArea;
			}
			if (fieldNumber == 2)
			{
				int scene = Scene;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002405")]
		[Cpp2IlInjected.Address(RVA = "0x3841200", Offset = "0x383FC00", VA = "0x183841200", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_001e
			//IL_0018: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				locationType_ = typeof(VillageAreaType).TypeHandle;
				locationTypeCase_ = LocationTypeOneofCase.VillageArea;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002406")]
		[Cpp2IlInjected.Address(RVA = "0x3840A00", Offset = "0x383F400", VA = "0x183840A00", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			//IL_0020: Expected O, but got I4
			//IL_0029: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
			{
				VillageAreaType villageAreaType = default(VillageAreaType);
				locationType_ = villageAreaType;
				locationTypeCase_ = LocationTypeOneofCase.VillageArea;
				break;
			}
			case 2:
			{
				int num = default(int);
				locationType_ = num;
				locationTypeCase_ = LocationTypeOneofCase.Scene;
				break;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002407")]
		[Cpp2IlInjected.Address(RVA = "0x3840FE0", Offset = "0x383F9E0", VA = "0x183840FE0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "LocationType"))
			{
				LocationTypeOneofCase locationTypeOneofCase = locationTypeCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002408")]
		[Cpp2IlInjected.Address(RVA = "0x3840AC0", Offset = "0x383F4C0", VA = "0x183840AC0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "LocationType"))
			{
				locationType_ = (locationTypeCase_ = LocationTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002409")]
		[Cpp2IlInjected.Address(RVA = "0x3841430", Offset = "0x383FE30", VA = "0x183841430")]
		static SecretCharacterLocationFilter()
		{
			Func<SecretCharacterLocationFilter> func = default(Func<SecretCharacterLocationFilter>);
			_parser = (MessageParser<SecretCharacterLocationFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
