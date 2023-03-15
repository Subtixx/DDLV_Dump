using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000911")]
	public sealed class ToolInfo : IMessage<ToolInfo>, IMessage, IEquatable<ToolInfo>, IDeepCloneable<ToolInfo>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40024C3")]
		private static readonly MessageParser<ToolInfo> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024C4")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40024C5")]
		public const int ToolItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024C6")]
		private int toolItemID_;

		[Cpp2IlInjected.Token(Token = "0x40024C7")]
		public const int UpgradeItemIDsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40024C8")]
		private static readonly FieldCodec<int> _repeated_upgradeItemIDs_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024C9")]
		private readonly RepeatedField<int> upgradeItemIDs_;

		[Cpp2IlInjected.Token(Token = "0x17000D67")]
		[DebuggerNonUserCode]
		public static MessageParser<ToolInfo> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004EC3")]
			[Cpp2IlInjected.Address(RVA = "0x78A4B0", Offset = "0x788EB0", VA = "0x18078A4B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D68")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004EC4")]
			[Cpp2IlInjected.Address(RVA = "0x78A3E0", Offset = "0x788DE0", VA = "0x18078A3E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D69")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004EC5")]
			[Cpp2IlInjected.Address(RVA = "0x78A510", Offset = "0x788F10", VA = "0x18078A510", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D6A")]
		[DebuggerNonUserCode]
		public int ToolItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6004EC9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return toolItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004ECA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				toolItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D6B")]
		[DebuggerNonUserCode]
		public RepeatedField<int> UpgradeItemIDs
		{
			[Cpp2IlInjected.Token(Token = "0x6004ECB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return upgradeItemIDs_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC6")]
		[Cpp2IlInjected.Address(RVA = "0x78A360", Offset = "0x788D60", VA = "0x18078A360")]
		[DebuggerNonUserCode]
		public ToolInfo()
		{
			upgradeItemIDs_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC7")]
		[Cpp2IlInjected.Address(RVA = "0x78A0B0", Offset = "0x788AB0", VA = "0x18078A0B0")]
		[DebuggerNonUserCode]
		public ToolInfo(ToolInfo other)
		{
			upgradeItemIDs_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			base._002Ector();
			int num = (toolItemID_ = other.toolItemID_);
			RepeatedField<int> repeatedField = (upgradeItemIDs_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.upgradeItemIDs_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC8")]
		[Cpp2IlInjected.Address(RVA = "0x789830", Offset = "0x788230", VA = "0x180789830", Slot = "10")]
		[DebuggerNonUserCode]
		public ToolInfo Clone()
		{
			//Discarded unreachable code: IL_004b
			ToolInfo toolInfo = new ToolInfo();
			RepeatedField<int> repeatedField = (toolInfo.upgradeItemIDs_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			int num = (toolInfo.toolItemID_ = toolItemID_);
			RepeatedField<int> repeatedField2 = (toolInfo.upgradeItemIDs_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)upgradeItemIDs_).Clone());
			UnknownFieldSet unknownFieldSet = (toolInfo._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return toolInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ECC")]
		[Cpp2IlInjected.Address(RVA = "0x789A00", Offset = "0x788400", VA = "0x180789A00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				if ((IntPtr)toolItemID_ == (IntPtr)typeof(ToolInfo).TypeHandle)
				{
					RepeatedField<int> repeatedField = upgradeItemIDs_;
					bool flag = default(bool);
					if (flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004ECD")]
		[Cpp2IlInjected.Address(RVA = "0x789960", Offset = "0x788360", VA = "0x180789960", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ToolInfo other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.toolItemID_;
				if (toolItemID_ == num)
				{
					RepeatedField<int> repeatedField = upgradeItemIDs_;
					RepeatedField<int> repeatedField2 = other.upgradeItemIDs_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004ECE")]
		[Cpp2IlInjected.Address(RVA = "0x761FE0", Offset = "0x7609E0", VA = "0x180761FE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0029
			if (toolItemID_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)upgradeItemIDs_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ECF")]
		[Cpp2IlInjected.Address(RVA = "0x789E20", Offset = "0x788820", VA = "0x180789E20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED0")]
		[Cpp2IlInjected.Address(RVA = "0x789E80", Offset = "0x788880", VA = "0x180789E80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003f
			if (toolItemID_ != 0)
			{
				int value = toolItemID_;
				output.WriteInt32(value);
			}
			RepeatedField<int> repeatedField = upgradeItemIDs_;
			FieldCodec<int> repeated_upgradeItemIDs_codec = _repeated_upgradeItemIDs_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_upgradeItemIDs_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED1")]
		[Cpp2IlInjected.Address(RVA = "0x7896D0", Offset = "0x7880D0", VA = "0x1807896D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_004e
			int num = toolItemID_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			RepeatedField<int> repeatedField = upgradeItemIDs_;
			FieldCodec<int> repeated_upgradeItemIDs_codec = _repeated_upgradeItemIDs_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_upgradeItemIDs_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num2 += num4;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num2 += num5;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED2")]
		[Cpp2IlInjected.Address(RVA = "0x789CC0", Offset = "0x7886C0", VA = "0x180789CC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ToolInfo other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				int num = other.toolItemID_;
				if (num != 0)
				{
					toolItemID_ = num;
				}
				RepeatedField<int> repeatedField = upgradeItemIDs_;
				RepeatedField<int> repeatedField2 = other.upgradeItemIDs_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED3")]
		[Cpp2IlInjected.Address(RVA = "0x789BB0", Offset = "0x7885B0", VA = "0x180789BB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0057
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (toolItemID_ = input.ReadInt32());
				}
				num += 4294967280u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<int> repeatedField = upgradeItemIDs_;
				FieldCodec<int> repeated_upgradeItemIDs_codec = _repeated_upgradeItemIDs_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_upgradeItemIDs_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED4")]
		[Cpp2IlInjected.Address(RVA = "0x789AE0", Offset = "0x7884E0", VA = "0x180789AE0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = toolItemID_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<int> repeatedField = upgradeItemIDs_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED5")]
		[Cpp2IlInjected.Address(RVA = "0x789D50", Offset = "0x788750", VA = "0x180789D50", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				toolItemID_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED6")]
		[Cpp2IlInjected.Address(RVA = "0x7897C0", Offset = "0x7881C0", VA = "0x1807897C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				toolItemID_ = 0;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<int> repeatedField = upgradeItemIDs_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED7")]
		[Cpp2IlInjected.Address(RVA = "0x78A1B0", Offset = "0x788BB0", VA = "0x18078A1B0")]
		public ToolInfo(Item toolItem)
		{
			//Discarded unreachable code: IL_0049
			//IL_0048: Expected O, but got I4
			int itemID = toolItem.ItemID;
			upgradeItemIDs_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			base._002Ector();
			toolItemID_ = itemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			ToolItemData toolItemData = default(ToolItemData);
			int defaultUpgrade_ = toolItemData.defaultUpgrade_;
			RepeatedField<int> repeatedField = upgradeItemIDs_;
			int defaultUpgrade_2 = toolItemData.defaultUpgrade_;
			((RepeatedField<T>)(object)repeatedField).Add((T)defaultUpgrade_2);
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED8")]
		[Cpp2IlInjected.Address(RVA = "0x789F70", Offset = "0x788970", VA = "0x180789F70")]
		static ToolInfo()
		{
			Func<ToolInfo> func = default(Func<ToolInfo>);
			_parser = (MessageParser<ToolInfo>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<ToolInfo>)(object)FieldCodec.ForInt32(18u);
			/*Error: Unexpected end of block*/;
		}
	}
}
