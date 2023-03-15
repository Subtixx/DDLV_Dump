using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004C9")]
	public sealed class CustomStepPlaceBuilding : IMessage<CustomStepPlaceBuilding>, IMessage, IEquatable<CustomStepPlaceBuilding>, IDeepCloneable<CustomStepPlaceBuilding>, IMessageFieldAccessor, IUniqueItem, IStringTag, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001999")]
		private static readonly MessageParser<CustomStepPlaceBuilding> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400199A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400199B")]
		public const int BuildingFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400199C")]
		private int building_;

		[Cpp2IlInjected.Token(Token = "0x400199D")]
		public const int UnlockedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400199E")]
		private bool unlocked_;

		[Cpp2IlInjected.Token(Token = "0x17000F13")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepPlaceBuilding> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003AEC")]
			[Cpp2IlInjected.Address(RVA = "0x31F6C70", Offset = "0x31F5670", VA = "0x1831F6C70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F14")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003AED")]
			[Cpp2IlInjected.Address(RVA = "0x31F6BA0", Offset = "0x31F55A0", VA = "0x1831F6BA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F15")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003AEE")]
			[Cpp2IlInjected.Address(RVA = "0x31F6D90", Offset = "0x31F5790", VA = "0x1831F6D90", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F16")]
		[DebuggerNonUserCode]
		public int Building
		{
			[Cpp2IlInjected.Token(Token = "0x6003AF2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return building_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003AF3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				building_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F17")]
		[DebuggerNonUserCode]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6003AF4")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return unlocked_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003AF5")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				unlocked_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F18")]
		public Item BuildingItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003B01")]
			[Cpp2IlInjected.Address(RVA = "0x31F6B40", Offset = "0x31F5540", VA = "0x1831F6B40")]
			get
			{
				long num = Convert.ToInt64((uint)building_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F19")]
		public int ItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6003B02")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return building_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F1A")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003B03")]
			[Cpp2IlInjected.Address(RVA = "0x31F6CD0", Offset = "0x31F56D0", VA = "0x1831F6CD0", Slot = "15")]
			get
			{
				//Discarded unreachable code: IL_0021
				string[] array;
				do
				{
					array = new string[1];
				}
				while ("ItemName" != null && array == null);
				array[0] = "ItemName";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AEF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CustomStepPlaceBuilding()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003AF0")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public CustomStepPlaceBuilding(CustomStepPlaceBuilding other)
		{
			int num = (building_ = other.building_);
			bool flag = (unlocked_ = other.unlocked_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003AF1")]
		[Cpp2IlInjected.Address(RVA = "0x31F62C0", Offset = "0x31F4CC0", VA = "0x1831F62C0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepPlaceBuilding Clone()
		{
			//Discarded unreachable code: IL_0037
			CustomStepPlaceBuilding customStepPlaceBuilding = new CustomStepPlaceBuilding();
			int num = (customStepPlaceBuilding.building_ = building_);
			bool flag = (customStepPlaceBuilding.unlocked_ = unlocked_);
			UnknownFieldSet unknownFieldSet = (customStepPlaceBuilding._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepPlaceBuilding;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AF6")]
		[Cpp2IlInjected.Address(RVA = "0x31F6580", Offset = "0x31F4F80", VA = "0x1831F6580", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)building_ == (IntPtr)typeof(CustomStepPlaceBuilding).TypeHandle && (IntPtr)(unlocked_ ? 1 : 0) == (IntPtr)typeof(CustomStepPlaceBuilding).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AF7")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepPlaceBuilding other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.building_;
				if (building_ == num)
				{
					bool flag = other.unlocked_;
					if (unlocked_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AF8")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (building_ != 0)
				{
				}
				if (unlocked_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003AF9")]
		[Cpp2IlInjected.Address(RVA = "0x31F69D0", Offset = "0x31F53D0", VA = "0x1831F69D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AFA")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (building_ != 0)
			{
				int value = building_;
				output.WriteInt32(value);
			}
			if (unlocked_)
			{
				bool value2 = unlocked_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AFB")]
		[Cpp2IlInjected.Address(RVA = "0x31F6230", Offset = "0x31F4C30", VA = "0x1831F6230", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = building_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
					num3++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AFC")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepPlaceBuilding other)
		{
			if (other != null)
			{
				int num = other.building_;
				if (num != 0)
				{
					building_ = num;
				}
				bool flag = other.unlocked_;
				if (flag)
				{
					unlocked_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AFD")]
		[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (building_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (unlocked_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AFE")]
		[Cpp2IlInjected.Address(RVA = "0x31F6810", Offset = "0x31F5210", VA = "0x1831F6810", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = building_;
			}
			if (fieldNumber == 2)
			{
				bool flag = unlocked_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AFF")]
		[Cpp2IlInjected.Address(RVA = "0x31F6900", Offset = "0x31F5300", VA = "0x1831F6900", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				building_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			unlocked_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B00")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				building_ = 0;
				break;
			case 2:
				unlocked_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B04")]
		[Cpp2IlInjected.Address(RVA = "0x31F6610", Offset = "0x31F5010", VA = "0x1831F6610")]
		public Item GetBuildingToPlace(MissionItemData data)
		{
			int num = building_;
			bool flag = default(bool);
			if (!flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				int ownerCharacter = data.OwnerCharacter;
				CharacterItemData characterItemData = default(CharacterItemData);
				int house = characterItemData.House;
			}
			long num2 = Convert.ToInt64((uint)building_);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B05")]
		[Cpp2IlInjected.Address(RVA = "0x31F6350", Offset = "0x31F4D50", VA = "0x1831F6350", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_004c
			int num = 0;
			int num2 = building_;
			if ((object)typeof(Item).TypeHandle != null)
			{
				object _003COwner_003Ek__BackingField = context.Owner;
				bool flag = default(bool);
				if (_003COwner_003Ek__BackingField != null && _003COwner_003Ek__BackingField != null && (!flag || flag))
				{
					string missionStepName = context.MissionStepName;
					string error = "Please select a house or building for " + missionStepName + " (Owner have no house)";
					context.AddError(error);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B06")]
		[Cpp2IlInjected.Address(RVA = "0x31F6A30", Offset = "0x31F5430", VA = "0x1831F6A30")]
		static CustomStepPlaceBuilding()
		{
			Func<CustomStepPlaceBuilding> func = default(Func<CustomStepPlaceBuilding>);
			_parser = (MessageParser<CustomStepPlaceBuilding>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
