using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Displays
{
	[Cpp2IlInjected.Token(Token = "0x2000744")]
	public sealed class LayoutArea : IMessage<LayoutArea>, IMessage, IEquatable<LayoutArea>, IDeepCloneable<LayoutArea>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002455")]
		private static readonly MessageParser<LayoutArea> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002456")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002457")]
		public const int ItemGeneratorFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002458")]
		private ItemGenerator itemGenerator_;

		[Cpp2IlInjected.Token(Token = "0x17001474")]
		[DebuggerNonUserCode]
		public static MessageParser<LayoutArea> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005060")]
			[Cpp2IlInjected.Address(RVA = "0x2744610", Offset = "0x2743010", VA = "0x182744610")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001475")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005061")]
			[Cpp2IlInjected.Address(RVA = "0x2744540", Offset = "0x2742F40", VA = "0x182744540")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001476")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005062")]
			[Cpp2IlInjected.Address(RVA = "0x2744670", Offset = "0x2743070", VA = "0x182744670", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001477")]
		[DebuggerNonUserCode]
		public ItemGenerator ItemGenerator
		{
			[Cpp2IlInjected.Token(Token = "0x6005066")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return itemGenerator_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005067")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				itemGenerator_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600505F")]
		[Cpp2IlInjected.Address(RVA = "0x2743F70", Offset = "0x2742970", VA = "0x182743F70")]
		public ItemAmount GenerateItem(Random random, in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] WeightInfo weightInfo, [Optional] ExtraFilterInfo extraFilterInfo, [Optional] List<ItemWithState> items)
		{
			//IL_0025: Expected I4, but got O
			//IL_002f: Expected I4, but got I8
			ItemGenerator itemGenerator = itemGenerator_;
			int num = 0;
			int num2 = 0;
			IReward reward = default(IReward);
			if (reward != null && reward != null)
			{
				ItemAmount itemAmount = new ItemAmount();
				itemAmount.id_ = (int)itemAmount;
				itemAmount.amount_ = 1;
				return itemAmount;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005063")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LayoutArea()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005064")]
		[Cpp2IlInjected.Address(RVA = "0x27444D0", Offset = "0x2742ED0", VA = "0x1827444D0")]
		[DebuggerNonUserCode]
		public LayoutArea(LayoutArea other)
		{
			//IL_0021: Expected O, but got I4
			ItemGenerator itemGenerator = other.itemGenerator_;
			if (itemGenerator != null)
			{
				ItemGenerator itemGenerator2 = itemGenerator.Clone();
			}
			int num = 0;
			itemGenerator_ = (ItemGenerator)num;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005065")]
		[Cpp2IlInjected.Address(RVA = "0x2743E20", Offset = "0x2742820", VA = "0x182743E20", Slot = "10")]
		[DebuggerNonUserCode]
		public LayoutArea Clone()
		{
			//Discarded unreachable code: IL_0038
			//IL_0021: Expected O, but got I4
			LayoutArea layoutArea = new LayoutArea();
			ItemGenerator itemGenerator = itemGenerator_;
			if (itemGenerator != null)
			{
				ItemGenerator itemGenerator2 = itemGenerator.Clone();
			}
			int num = 0;
			layoutArea.itemGenerator_ = (ItemGenerator)num;
			UnknownFieldSet unknownFieldSet = (layoutArea._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return layoutArea;
		}

		[Cpp2IlInjected.Token(Token = "0x6005068")]
		[Cpp2IlInjected.Address(RVA = "0x2743EC0", Offset = "0x27428C0", VA = "0x182743EC0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(itemGenerator_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005069")]
		[Cpp2IlInjected.Address(RVA = "0x15BA5B0", Offset = "0x15B8FB0", VA = "0x1815BA5B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LayoutArea other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemGenerator objB = other.itemGenerator_;
				if (object.Equals(itemGenerator_, objB))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600506A")]
		[Cpp2IlInjected.Address(RVA = "0x15BAEA0", Offset = "0x15B98A0", VA = "0x1815BAEA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				ItemGenerator itemGenerator = itemGenerator_;
				if (itemGenerator != null)
				{
					int hashCode = itemGenerator.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x600506B")]
		[Cpp2IlInjected.Address(RVA = "0x2744360", Offset = "0x2742D60", VA = "0x182744360", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600506C")]
		[Cpp2IlInjected.Address(RVA = "0x15BC830", Offset = "0x15BB230", VA = "0x1815BC830", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002c
			if ((long)itemGenerator_ != 0)
			{
				ItemGenerator value = itemGenerator_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600506D")]
		[Cpp2IlInjected.Address(RVA = "0x2743D80", Offset = "0x2742780", VA = "0x182743D80", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				ItemGenerator itemGenerator = itemGenerator_;
				num = 0;
				if (itemGenerator != null)
				{
					int num2 = CodedOutputStream.ComputeMessageSize(itemGenerator);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x600506E")]
		[Cpp2IlInjected.Address(RVA = "0x2744210", Offset = "0x2742C10", VA = "0x182744210", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LayoutArea other)
		{
			//Discarded unreachable code: IL_0053
			if (other == null)
			{
				return;
			}
			if ((long)other.itemGenerator_ != 0)
			{
				ItemGenerator itemGenerator = itemGenerator_;
				if (itemGenerator == null)
				{
					ItemGenerator itemGenerator2 = (itemGenerator_ = new ItemGenerator());
				}
				ItemGenerator other2 = other.itemGenerator_;
				itemGenerator.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600506F")]
		[Cpp2IlInjected.Address(RVA = "0x2744130", Offset = "0x2742B30", VA = "0x182744130", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0046
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ItemGenerator itemGenerator = itemGenerator_;
				if (itemGenerator == null)
				{
					ItemGenerator itemGenerator2 = (itemGenerator_ = new ItemGenerator());
				}
				input.ReadMessage(itemGenerator);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005070")]
		[Cpp2IlInjected.Address(RVA = "0x27440B0", Offset = "0x2742AB0", VA = "0x1827440B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ItemGenerator itemGenerator = itemGenerator_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005071")]
		[Cpp2IlInjected.Address(RVA = "0x27442E0", Offset = "0x2742CE0", VA = "0x1827442E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				itemGenerator_ = (ItemGenerator)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005072")]
		[Cpp2IlInjected.Address(RVA = "0x15B97E0", Offset = "0x15B81E0", VA = "0x1815B97E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber != 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005073")]
		[Cpp2IlInjected.Address(RVA = "0x27443C0", Offset = "0x2742DC0", VA = "0x1827443C0")]
		static LayoutArea()
		{
			Func<LayoutArea> func = default(Func<LayoutArea>);
			_parser = (MessageParser<LayoutArea>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
