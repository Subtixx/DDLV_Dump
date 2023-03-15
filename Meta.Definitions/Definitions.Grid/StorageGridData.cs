using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000701")]
	public sealed class StorageGridData : IMessage<StorageGridData>, IMessage, IEquatable<StorageGridData>, IDeepCloneable<StorageGridData>, IMessageFieldAccessor, IGridStateData, IGridStateNeedInitialize, IGridStateNeedDeinitialize
	{
		[Cpp2IlInjected.Token(Token = "0x4002381")]
		private static readonly MessageParser<StorageGridData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002382")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002383")]
		public const int ContainerInventoryIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002384")]
		private uint containerInventoryID_;

		[Cpp2IlInjected.Token(Token = "0x4002385")]
		public const int DefaultContainerInventoryDataFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002386")]
		private string defaultContainerInventoryData_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002387")]
		public const int UnlockKeyItemIDFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002388")]
		private int unlockKeyItemID_;

		[Cpp2IlInjected.Token(Token = "0x4002389")]
		public const int UnlockLocIdFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400238A")]
		private string unlockLocId_ = "";

		[Cpp2IlInjected.Token(Token = "0x170013FE")]
		[DebuggerNonUserCode]
		public static MessageParser<StorageGridData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004E04")]
			[Cpp2IlInjected.Address(RVA = "0x2634BE0", Offset = "0x26335E0", VA = "0x182634BE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013FF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E05")]
			[Cpp2IlInjected.Address(RVA = "0x2634B10", Offset = "0x2633510", VA = "0x182634B10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001400")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E06")]
			[Cpp2IlInjected.Address(RVA = "0x2634CA0", Offset = "0x26336A0", VA = "0x182634CA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001401")]
		[DebuggerNonUserCode]
		public uint ContainerInventoryID
		{
			[Cpp2IlInjected.Token(Token = "0x6004E0A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return containerInventoryID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E0B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				containerInventoryID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001402")]
		[DebuggerNonUserCode]
		public string DefaultContainerInventoryData
		{
			[Cpp2IlInjected.Token(Token = "0x6004E0C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return defaultContainerInventoryData_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E0D")]
			[Cpp2IlInjected.Address(RVA = "0x2634DB0", Offset = "0x26337B0", VA = "0x182634DB0")]
			set
			{
				string text = (defaultContainerInventoryData_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001403")]
		[DebuggerNonUserCode]
		public int UnlockKeyItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6004E0E")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return unlockKeyItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E0F")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				unlockKeyItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001404")]
		[DebuggerNonUserCode]
		public string UnlockLocId
		{
			[Cpp2IlInjected.Token(Token = "0x6004E10")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return unlockLocId_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E11")]
			[Cpp2IlInjected.Address(RVA = "0x2634E20", Offset = "0x2633820", VA = "0x182634E20")]
			set
			{
				string text = (unlockLocId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001405")]
		public Item UnlockKeyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004E1D")]
			[Cpp2IlInjected.Address(RVA = "0x2634C40", Offset = "0x2633640", VA = "0x182634C40")]
			get
			{
				long num = Convert.ToInt64((uint)unlockKeyItemID_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E1E")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				//IL_0007: Expected I4, but got O
				unlockKeyItemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E07")]
		[Cpp2IlInjected.Address(RVA = "0x2634AB0", Offset = "0x26334B0", VA = "0x182634AB0")]
		[DebuggerNonUserCode]
		public StorageGridData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E08")]
		[Cpp2IlInjected.Address(RVA = "0x26349D0", Offset = "0x26333D0", VA = "0x1826349D0")]
		[DebuggerNonUserCode]
		public StorageGridData(StorageGridData other)
		{
			uint num = (containerInventoryID_ = other.containerInventoryID_);
			string text = (defaultContainerInventoryData_ = other.defaultContainerInventoryData_);
			int num2 = (unlockKeyItemID_ = other.unlockKeyItemID_);
			string text2 = (unlockLocId_ = other.unlockLocId_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E09")]
		[Cpp2IlInjected.Address(RVA = "0x2633D40", Offset = "0x2632740", VA = "0x182633D40", Slot = "10")]
		[DebuggerNonUserCode]
		public StorageGridData Clone()
		{
			//Discarded unreachable code: IL_006d
			StorageGridData storageGridData = new StorageGridData();
			storageGridData.defaultContainerInventoryData_ = "";
			storageGridData.unlockLocId_ = "";
			uint num = (storageGridData.containerInventoryID_ = containerInventoryID_);
			string text = (storageGridData.defaultContainerInventoryData_ = defaultContainerInventoryData_);
			int num2 = (storageGridData.unlockKeyItemID_ = unlockKeyItemID_);
			string text2 = (storageGridData.unlockLocId_ = unlockLocId_);
			UnknownFieldSet unknownFieldSet = (storageGridData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return storageGridData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E12")]
		[Cpp2IlInjected.Address(RVA = "0x2633F50", Offset = "0x2632950", VA = "0x182633F50", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(int)containerInventoryID_ == (IntPtr)typeof(StorageGridData).TypeHandle)
				{
					string text = defaultContainerInventoryData_;
					bool flag = default(bool);
					if (!flag && unlockKeyItemID_ == (flag ? 1 : 0))
					{
						string text2 = unlockLocId_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E13")]
		[Cpp2IlInjected.Address(RVA = "0x2634020", Offset = "0x2632A20", VA = "0x182634020", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StorageGridData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				uint num = other.containerInventoryID_;
				if (containerInventoryID_ == num)
				{
					string text = other.defaultContainerInventoryData_;
					if (!(defaultContainerInventoryData_ != text))
					{
						int num2 = other.unlockKeyItemID_;
						if (unlockKeyItemID_ == num2)
						{
							string text2 = other.unlockLocId_;
							if (!(unlockLocId_ != text2))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E14")]
		[Cpp2IlInjected.Address(RVA = "0x26341B0", Offset = "0x2632BB0", VA = "0x1826341B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_005c
			int num = 0;
			if (containerInventoryID_ != 0)
			{
			}
			string text = defaultContainerInventoryData_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (unlockKeyItemID_ != 0)
			{
			}
			string text2 = unlockLocId_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E15")]
		[Cpp2IlInjected.Address(RVA = "0x2634770", Offset = "0x2633170", VA = "0x182634770", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E16")]
		[Cpp2IlInjected.Address(RVA = "0x26347D0", Offset = "0x26331D0", VA = "0x1826347D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_007d
			if (containerInventoryID_ != 0)
			{
				uint value = containerInventoryID_;
				output.WriteUInt32(value);
			}
			if (defaultContainerInventoryData_.m_stringLength != 0)
			{
				string value2 = defaultContainerInventoryData_;
				output.WriteString(value2);
			}
			if (unlockKeyItemID_ != 0)
			{
				int value3 = unlockKeyItemID_;
				output.WriteInt32(value3);
			}
			if (unlockLocId_.m_stringLength != 0)
			{
				string value4 = unlockLocId_;
				output.WriteString(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E17")]
		[Cpp2IlInjected.Address(RVA = "0x2633B60", Offset = "0x2632560", VA = "0x182633B60", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_009c
			uint num = containerInventoryID_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeUInt32Size(num);
			}
			string text = defaultContainerInventoryData_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			int num5 = unlockKeyItemID_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				num2 += num6;
			}
			string text2 = unlockLocId_;
			if (text2.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text2);
				num7++;
				num2 += num7;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num2 += num8;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E18")]
		[Cpp2IlInjected.Address(RVA = "0x2634560", Offset = "0x2632F60", VA = "0x182634560", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StorageGridData other)
		{
			//Discarded unreachable code: IL_0077
			if (other != null)
			{
				uint num = other.containerInventoryID_;
				if (num != 0)
				{
					containerInventoryID_ = num;
				}
				string text = other.defaultContainerInventoryData_;
				if (text.m_stringLength != 0)
				{
					DefaultContainerInventoryData = text;
				}
				int num2 = other.unlockKeyItemID_;
				if (num2 != 0)
				{
					unlockKeyItemID_ = num2;
				}
				string text2 = other.unlockLocId_;
				if (text2.m_stringLength != 0)
				{
					UnlockLocId = text2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E19")]
		[Cpp2IlInjected.Address(RVA = "0x2634480", Offset = "0x2632E80", VA = "0x182634480", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0079
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 24)
				{
					int num2 = (unlockKeyItemID_ = input.ReadInt32());
				}
				if (num != 34)
				{
					goto IL_0062;
				}
				string text2 = (UnlockLocId = input.ReadString());
			}
			int num3 = default(int);
			if (num == 8)
			{
				num3 = (int)(containerInventoryID_ = (uint)input.ReadInt32());
			}
			if (num3 == 18)
			{
				string text4 = (DefaultContainerInventoryData = input.ReadString());
			}
			goto IL_0062;
			IL_0062:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004E1A")]
		[Cpp2IlInjected.Address(RVA = "0x26340B0", Offset = "0x2632AB0", VA = "0x1826340B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0 && num != 0 && num == 1)
			{
				string text = unlockLocId_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E1B")]
		[Cpp2IlInjected.Address(RVA = "0x26345F0", Offset = "0x2632FF0", VA = "0x1826345F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_003f
			//IL_0025: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			//IL_003e: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						int num2 = 0;
						if (value == null || value != null)
						{
							UnlockLocId = (string)num2;
							break;
						}
						throw new InvalidCastException();
					}
					case 0:
					{
						object obj = default(object);
						unlockKeyItemID_ = (int)obj;
						break;
					}
					}
				}
				else if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			else
			{
				object obj2 = default(object);
				containerInventoryID_ = (uint)(int)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E1C")]
		[Cpp2IlInjected.Address(RVA = "0x2633CA0", Offset = "0x26326A0", VA = "0x182633CA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0029: Expected I4, but got I8
			//IL_003f: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
						UnlockLocId = "";
						break;
					case 0:
						unlockKeyItemID_ = 0;
						break;
					}
				}
				else
				{
					DefaultContainerInventoryData = "";
				}
			}
			else
			{
				containerInventoryID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E1F")]
		[Cpp2IlInjected.Address(RVA = "0x2634270", Offset = "0x2632C70", VA = "0x182634270")]
		public void Initialize(IItemData itemData, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0048
			if ("" == null)
			{
				return;
			}
			string text = defaultContainerInventoryData_;
			if ("" == null)
			{
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if ((long)num < (long)(IntPtr)typeof(IItemData).TypeHandle)
				{
					num += num;
					num++;
				}
				containerInventoryID_ = (uint)num;
				DefaultContainerInventoryData = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E20")]
		[Cpp2IlInjected.Address(RVA = "0x2633E40", Offset = "0x2632840", VA = "0x182633E40")]
		public void Deinitialize(in WorldProfile worldProfile)
		{
			//Discarded unreachable code: IL_001b
			if ((object)typeof(IProfile).TypeHandle != null)
			{
				int num = 0;
				if ((long)num < (long)(IntPtr)typeof(IProfile).TypeHandle)
				{
					num += num;
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E21")]
		[Cpp2IlInjected.Address(RVA = "0x26348C0", Offset = "0x26332C0", VA = "0x1826348C0")]
		static StorageGridData()
		{
			Func<StorageGridData> func = default(Func<StorageGridData>);
			_parser = (MessageParser<StorageGridData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E22")]
		[Cpp2IlInjected.Address(RVA = "0x2633F40", Offset = "0x2632940", VA = "0x182633F40", Slot = "14")]
		void IGridStateNeedInitialize.Initialize(IItemData itemData, in WorldProfile worldProfile, ITransactionContext context)
		{
			Initialize(itemData, in worldProfile, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E23")]
		[Cpp2IlInjected.Address(RVA = "0x2633E40", Offset = "0x2632840", VA = "0x182633E40", Slot = "15")]
		void IGridStateNeedDeinitialize.Deinitialize(in WorldProfile worldProfile)
		{
			//Discarded unreachable code: IL_001b
			if ((object)typeof(IProfile).TypeHandle != null)
			{
				int num = 0;
				if ((long)num < (long)(IntPtr)typeof(IProfile).TypeHandle)
				{
					num += num;
					num++;
				}
			}
		}
	}
}
