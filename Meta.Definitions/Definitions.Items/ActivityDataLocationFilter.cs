using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000400")]
	public sealed class ActivityDataLocationFilter : IMessage<ActivityDataLocationFilter>, IMessage, IEquatable<ActivityDataLocationFilter>, IDeepCloneable<ActivityDataLocationFilter>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000401")]
		public enum LocationTypeOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40015F2")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40015F3")]
			VillageArea,
			[Cpp2IlInjected.Token(Token = "0x40015F4")]
			Scene
		}

		[Cpp2IlInjected.Token(Token = "0x40015EB")]
		private static readonly MessageParser<ActivityDataLocationFilter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40015EC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40015ED")]
		public const int VillageAreaFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40015EE")]
		public const int SceneFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40015EF")]
		private object locationType_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40015F0")]
		private LocationTypeOneofCase locationTypeCase_;

		[Cpp2IlInjected.Token(Token = "0x17000C89")]
		[DebuggerNonUserCode]
		public static MessageParser<ActivityDataLocationFilter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60030E2")]
			[Cpp2IlInjected.Address(RVA = "0x3157780", Offset = "0x3156180", VA = "0x183157780")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C8A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60030E3")]
			[Cpp2IlInjected.Address(RVA = "0x31576B0", Offset = "0x31560B0", VA = "0x1831576B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C8B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60030E4")]
			[Cpp2IlInjected.Address(RVA = "0x31578C0", Offset = "0x31562C0", VA = "0x1831578C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C8C")]
		[DebuggerNonUserCode]
		public VillageAreaType VillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x60030E8")]
			[Cpp2IlInjected.Address(RVA = "0x3157850", Offset = "0x3156250", VA = "0x183157850")]
			get
			{
				if (locationTypeCase_ == LocationTypeOneofCase.VillageArea)
				{
					object obj = locationType_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60030E9")]
			[Cpp2IlInjected.Address(RVA = "0x3157A40", Offset = "0x3156440", VA = "0x183157A40")]
			set
			{
				//IL_0016: Expected I4, but got I8
				locationType_ = typeof(VillageAreaType).TypeHandle;
				locationTypeCase_ = LocationTypeOneofCase.VillageArea;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C8D")]
		[DebuggerNonUserCode]
		public int Scene
		{
			[Cpp2IlInjected.Token(Token = "0x60030EA")]
			[Cpp2IlInjected.Address(RVA = "0x31577E0", Offset = "0x31561E0", VA = "0x1831577E0")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (locationTypeCase_ == LocationTypeOneofCase.Scene)
				{
					object obj = locationType_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60030EB")]
			[Cpp2IlInjected.Address(RVA = "0x31579D0", Offset = "0x31563D0", VA = "0x1831579D0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				locationType_ = typeof(int).TypeHandle;
				locationTypeCase_ = LocationTypeOneofCase.Scene;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C8E")]
		[DebuggerNonUserCode]
		public LocationTypeOneofCase LocationTypeCase
		{
			[Cpp2IlInjected.Token(Token = "0x60030EC")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return locationTypeCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030E5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ActivityDataLocationFilter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60030E6")]
		[Cpp2IlInjected.Address(RVA = "0x31575E0", Offset = "0x3155FE0", VA = "0x1831575E0")]
		[DebuggerNonUserCode]
		public ActivityDataLocationFilter(ActivityDataLocationFilter other)
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

		[Cpp2IlInjected.Token(Token = "0x60030E7")]
		[Cpp2IlInjected.Address(RVA = "0x3156BD0", Offset = "0x31555D0", VA = "0x183156BD0", Slot = "10")]
		[DebuggerNonUserCode]
		public ActivityDataLocationFilter Clone()
		{
			//Discarded unreachable code: IL_0055
			//IL_002c: Expected I4, but got I8
			ActivityDataLocationFilter activityDataLocationFilter = new ActivityDataLocationFilter();
			LocationTypeOneofCase locationTypeOneofCase = locationTypeCase_;
			if (locationTypeOneofCase == LocationTypeOneofCase.VillageArea)
			{
				int villageArea = (int)VillageArea;
				activityDataLocationFilter.locationType_ = typeof(VillageAreaType).TypeHandle;
				activityDataLocationFilter.locationTypeCase_ = LocationTypeOneofCase.VillageArea;
			}
			if (locationTypeOneofCase == LocationTypeOneofCase.Scene)
			{
				int num = (activityDataLocationFilter.Scene = Scene);
			}
			UnknownFieldSet unknownFieldSet = (activityDataLocationFilter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return activityDataLocationFilter;
		}

		[Cpp2IlInjected.Token(Token = "0x60030ED")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearLocationType()
		{
			//IL_0010: Expected O, but got I4
			locationType_ = (locationTypeCase_ = LocationTypeOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60030EE")]
		[Cpp2IlInjected.Address(RVA = "0x3156D70", Offset = "0x3155770", VA = "0x183156D70", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60030EF")]
		[Cpp2IlInjected.Address(RVA = "0x3156CD0", Offset = "0x31556D0", VA = "0x183156CD0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ActivityDataLocationFilter other)
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

		[Cpp2IlInjected.Token(Token = "0x60030F0")]
		[Cpp2IlInjected.Address(RVA = "0x3156F40", Offset = "0x3155940", VA = "0x183156F40", Slot = "2")]
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

		[Cpp2IlInjected.Token(Token = "0x60030F1")]
		[Cpp2IlInjected.Address(RVA = "0x31573D0", Offset = "0x3155DD0", VA = "0x1831573D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60030F2")]
		[Cpp2IlInjected.Address(RVA = "0x3157430", Offset = "0x3155E30", VA = "0x183157430", Slot = "6")]
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

		[Cpp2IlInjected.Token(Token = "0x60030F3")]
		[Cpp2IlInjected.Address(RVA = "0x3156930", Offset = "0x3155330", VA = "0x183156930", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x60030F4")]
		[Cpp2IlInjected.Address(RVA = "0x3157220", Offset = "0x3155C20", VA = "0x183157220", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ActivityDataLocationFilter other)
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

		[Cpp2IlInjected.Token(Token = "0x60030F5")]
		[Cpp2IlInjected.Address(RVA = "0x3157130", Offset = "0x3155B30", VA = "0x183157130", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60030F6")]
		[Cpp2IlInjected.Address(RVA = "0x3156E50", Offset = "0x3155850", VA = "0x183156E50", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x60030F7")]
		[Cpp2IlInjected.Address(RVA = "0x31572A0", Offset = "0x3155CA0", VA = "0x1831572A0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60030F8")]
		[Cpp2IlInjected.Address(RVA = "0x3156AA0", Offset = "0x31554A0", VA = "0x183156AA0", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x60030F9")]
		[Cpp2IlInjected.Address(RVA = "0x3157080", Offset = "0x3155A80", VA = "0x183157080", Slot = "14")]
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

		[Cpp2IlInjected.Token(Token = "0x60030FA")]
		[Cpp2IlInjected.Address(RVA = "0x3156B60", Offset = "0x3155560", VA = "0x183156B60", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "LocationType"))
			{
				locationType_ = (locationTypeCase_ = LocationTypeOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030FB")]
		[Cpp2IlInjected.Address(RVA = "0x31574D0", Offset = "0x3155ED0", VA = "0x1831574D0")]
		static ActivityDataLocationFilter()
		{
			Func<ActivityDataLocationFilter> func = default(Func<ActivityDataLocationFilter>);
			_parser = (MessageParser<ActivityDataLocationFilter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
