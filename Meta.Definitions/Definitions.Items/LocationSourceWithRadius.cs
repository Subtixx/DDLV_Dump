using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000519")]
	public sealed class LocationSourceWithRadius : IMessage<LocationSourceWithRadius>, IMessage, IEquatable<LocationSourceWithRadius>, IDeepCloneable<LocationSourceWithRadius>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001B36")]
		private static readonly MessageParser<LocationSourceWithRadius> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001B37")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001B38")]
		public const int LocationFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001B39")]
		private LocationSource location_;

		[Cpp2IlInjected.Token(Token = "0x4001B3A")]
		public const int RadiusFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001B3B")]
		private int radius_;

		[Cpp2IlInjected.Token(Token = "0x1700103B")]
		[DebuggerNonUserCode]
		public static MessageParser<LocationSourceWithRadius> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003F33")]
			[Cpp2IlInjected.Address(RVA = "0x38ED610", Offset = "0x38EC010", VA = "0x1838ED610")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700103C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003F34")]
			[Cpp2IlInjected.Address(RVA = "0x38ED540", Offset = "0x38EBF40", VA = "0x1838ED540")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700103D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003F35")]
			[Cpp2IlInjected.Address(RVA = "0x38ED770", Offset = "0x38EC170", VA = "0x1838ED770", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700103E")]
		[DebuggerNonUserCode]
		public LocationSource Location
		{
			[Cpp2IlInjected.Token(Token = "0x6003F3A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003F3B")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				location_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700103F")]
		[DebuggerNonUserCode]
		public int Radius
		{
			[Cpp2IlInjected.Token(Token = "0x6003F3C")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return radius_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003F3D")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				radius_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001040")]
		public List<VillageAreaType> VillageAreaMapMarker
		{
			[Cpp2IlInjected.Token(Token = "0x6003F49")]
			[Cpp2IlInjected.Address(RVA = "0x38ED670", Offset = "0x38EC070", VA = "0x1838ED670")]
			get
			{
				//Discarded unreachable code: IL_0026
				if (location_.locationCase_ != LocationSource.LocationOneofCase.AnywhereVillageArea)
				{
					int num = 0;
				}
				List<VillageAreaType> result = (List<VillageAreaType>)(object)new List<T>();
				if (location_.location_ != null)
				{
					return result;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F36")]
		[Cpp2IlInjected.Address(RVA = "0x38ED320", Offset = "0x38EBD20", VA = "0x1838ED320")]
		[DebuggerNonUserCode]
		public LocationSourceWithRadius()
		{
			LocationSource locationSource = new LocationSource();
			bool flag = (byte)(locationSource.locationCase_ = (((locationSource.location_ = new Empty()) != null) ? LocationSource.LocationOneofCase.Anywhere : LocationSource.LocationOneofCase.None)) != 0;
			location_ = locationSource;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F37")]
		[Cpp2IlInjected.Address(RVA = "0x38ED020", Offset = "0x38EBA20", VA = "0x1838ED020")]
		private void OnConstruction()
		{
			LocationSource locationSource = new LocationSource();
			bool flag = (byte)(locationSource.locationCase_ = (((locationSource.location_ = new Empty()) != null) ? LocationSource.LocationOneofCase.Anywhere : LocationSource.LocationOneofCase.None)) != 0;
			location_ = locationSource;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F38")]
		[Cpp2IlInjected.Address(RVA = "0x38ED3E0", Offset = "0x38EBDE0", VA = "0x1838ED3E0")]
		[DebuggerNonUserCode]
		public LocationSourceWithRadius(LocationSourceWithRadius other)
		{
			//IL_004e: Expected O, but got I4
			LocationSource locationSource = new LocationSource();
			Empty empty = (Empty)(locationSource.location_ = new Empty());
			int num = 0;
			bool flag = (byte)(locationSource.locationCase_ = ((empty != null) ? LocationSource.LocationOneofCase.Anywhere : LocationSource.LocationOneofCase.None)) != 0;
			location_ = locationSource;
			LocationSource locationSource2 = other.location_;
			if (locationSource2 != null)
			{
				LocationSource locationSource3 = new LocationSource(locationSource2);
			}
			location_ = (LocationSource)num;
			int num2 = (radius_ = other.radius_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003F39")]
		[Cpp2IlInjected.Address(RVA = "0x38EC850", Offset = "0x38EB250", VA = "0x1838EC850", Slot = "10")]
		[DebuggerNonUserCode]
		public LocationSourceWithRadius Clone()
		{
			//Discarded unreachable code: IL_0077
			//IL_0050: Expected O, but got I4
			LocationSourceWithRadius locationSourceWithRadius = new LocationSourceWithRadius();
			LocationSource locationSource = new LocationSource();
			Empty empty = (Empty)(locationSource.location_ = new Empty());
			int num = 0;
			bool flag = (byte)(locationSource.locationCase_ = ((empty != null) ? LocationSource.LocationOneofCase.Anywhere : LocationSource.LocationOneofCase.None)) != 0;
			locationSourceWithRadius.location_ = locationSource;
			LocationSource locationSource2 = location_;
			if (locationSource2 != null)
			{
				LocationSource locationSource3 = new LocationSource(locationSource2);
			}
			locationSourceWithRadius.location_ = (LocationSource)num;
			int num2 = (locationSourceWithRadius.radius_ = radius_);
			UnknownFieldSet unknownFieldSet = (locationSourceWithRadius._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return locationSourceWithRadius;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F3E")]
		[Cpp2IlInjected.Address(RVA = "0x38EC9E0", Offset = "0x38EB3E0", VA = "0x1838EC9E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = object.Equals(location_, other);
				if (flag && radius_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F3F")]
		[Cpp2IlInjected.Address(RVA = "0x75CFC0", Offset = "0x75B9C0", VA = "0x18075CFC0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LocationSourceWithRadius other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				LocationSource objB = other.location_;
				if (object.Equals(location_, objB))
				{
					int num = other.radius_;
					if (radius_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F40")]
		[Cpp2IlInjected.Address(RVA = "0x75D1B0", Offset = "0x75BBB0", VA = "0x18075D1B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				LocationSource locationSource = location_;
				if (locationSource != null)
				{
					int hashCode = locationSource.GetHashCode();
				}
				if (radius_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003F41")]
		[Cpp2IlInjected.Address(RVA = "0x38ED1B0", Offset = "0x38EBBB0", VA = "0x1838ED1B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003F42")]
		[Cpp2IlInjected.Address(RVA = "0x75D5E0", Offset = "0x75BFE0", VA = "0x18075D5E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if ((long)location_ != 0)
			{
				LocationSource value = location_;
				output.WriteMessage(value);
			}
			if (radius_ != 0)
			{
				int value2 = radius_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003F43")]
		[Cpp2IlInjected.Address(RVA = "0x38EC780", Offset = "0x38EB180", VA = "0x1838EC780", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				LocationSource locationSource = location_;
				num = 0;
				if (locationSource != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(locationSource);
				}
				int num3 = radius_;
				if (num3 != 0)
				{
					int num4 = CodedOutputStream.ComputeInt32Size(num3);
					num4++;
					num += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F44")]
		[Cpp2IlInjected.Address(RVA = "0x38ECF40", Offset = "0x38EB940", VA = "0x1838ECF40", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LocationSourceWithRadius other)
		{
			//Discarded unreachable code: IL_0067
			if (other == null)
			{
				return;
			}
			if ((long)other.location_ != 0)
			{
				LocationSource locationSource = location_;
				if (locationSource == null)
				{
					LocationSource locationSource2 = (location_ = new LocationSource());
				}
				LocationSource other2 = other.location_;
				locationSource.MergeFrom(other2);
			}
			int num = other.radius_;
			if (num != 0)
			{
				radius_ = num;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003F45")]
		[Cpp2IlInjected.Address(RVA = "0x38ECE50", Offset = "0x38EB850", VA = "0x1838ECE50", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				LocationSource locationSource = location_;
				if (locationSource == null)
				{
					LocationSource locationSource2 = (location_ = new LocationSource());
				}
				input.ReadMessage(locationSource);
			}
			if (num == 16)
			{
				int num2 = (radius_ = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003F46")]
		[Cpp2IlInjected.Address(RVA = "0x38ECD80", Offset = "0x38EB780", VA = "0x1838ECD80", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				LocationSource locationSource = location_;
			}
			if (fieldNumber == 2)
			{
				int num = radius_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003F47")]
		[Cpp2IlInjected.Address(RVA = "0x38ED0E0", Offset = "0x38EBAE0", VA = "0x1838ED0E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0022
			//IL_0015: Expected O, but got I4
			//IL_0021: Expected I4, but got O
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				location_ = (LocationSource)num;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				object obj = default(object);
				radius_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F48")]
		[Cpp2IlInjected.Address(RVA = "0x75CE20", Offset = "0x75B820", VA = "0x18075CE20", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0011: Expected I4, but got I8
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				radius_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003F4A")]
		[Cpp2IlInjected.Address(RVA = "0x38ECA90", Offset = "0x38EB490", VA = "0x1838ECA90")]
		public List<Item> GetBuildingMapMarker(MissionItemData data, in WorldProfile world)
		{
			//Discarded unreachable code: IL_0083
			LocationSource.LocationOneofCase locationCase_ = location_.locationCase_;
			if ((object)typeof(List<Item>).TypeHandle != null)
			{
				if ((object)typeof(List<Item>).TypeHandle != null)
				{
					if ((long)typeof(List<Item>).TypeHandle != 1)
					{
						if (locationCase_ == LocationSource.LocationOneofCase.NearUniqueItem)
						{
							List<Item> list = (List<Item>)(object)new List<T>();
							LocationNearUniqueItem nearUniqueItem = location_.NearUniqueItem;
						}
						int num = 0;
					}
					List<Item> list2 = (List<Item>)(object)new List<T>();
				}
				List<Item> list3 = (List<Item>)(object)new List<T>();
				IProfileWorld section = world.Section;
				int num2 = 0;
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					num2++;
				}
			}
			List<Item> result = (List<Item>)(object)new List<T>();
			if (location_.location_ != null)
			{
				return result;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003F4B")]
		[Cpp2IlInjected.Address(RVA = "0x38ED210", Offset = "0x38EBC10", VA = "0x1838ED210")]
		static LocationSourceWithRadius()
		{
			Func<LocationSourceWithRadius> func = default(Func<LocationSourceWithRadius>);
			_parser = (MessageParser<LocationSourceWithRadius>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
