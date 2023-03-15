using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000849")]
	public sealed class ItemConditionItems : IMessage<ItemConditionItems>, IMessage, IEquatable<ItemConditionItems>, IDeepCloneable<ItemConditionItems>, IMessageFieldAccessor, IItemCondition, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4002913")]
		private static readonly MessageParser<ItemConditionItems> _parser = (MessageParser<ItemConditionItems>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ItemConditionItems()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002914")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002915")]
		public const int ItemsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002916")]
		private static readonly FieldCodec<int> _repeated_items_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002917")]
		private readonly RepeatedField<int> items_;

		[Cpp2IlInjected.Token(Token = "0x4002918")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002919")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x1700175F")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemConditionItems> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005CB1")]
			[Cpp2IlInjected.Address(RVA = "0x22C5B80", Offset = "0x22C4580", VA = "0x1822C5B80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001760")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005CB2")]
			[Cpp2IlInjected.Address(RVA = "0x22C58E0", Offset = "0x22C42E0", VA = "0x1822C58E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001761")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005CB3")]
			[Cpp2IlInjected.Address(RVA = "0x22C5BE0", Offset = "0x22C45E0", VA = "0x1822C5BE0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001762")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Items
		{
			[Cpp2IlInjected.Token(Token = "0x6005CB7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return items_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001763")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005CB8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CB9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001764")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005CC6")]
			[Cpp2IlInjected.Address(RVA = "0x22C59B0", Offset = "0x22C43B0", VA = "0x1822C59B0", Slot = "15")]
			get
			{
				if (!inversed_)
				{
				}
				RepeatedField<int> repeatedField = items_;
				Func<int, string> func = default(Func<int, string>);
				if (_003C_003Ec._003C_003E9__35_0 == null)
				{
					string result = default(string);
					func = (Func<int, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => result));
				}
				IEnumerable<int> enumerable = (IEnumerable<int>)Enumerable.Select<int, string>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
				string text = string.Join(",", (IEnumerable<>)enumerable);
				return "Is" + " NOT" + " " + text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CB4")]
		[Cpp2IlInjected.Address(RVA = "0x22C5860", Offset = "0x22C4260", VA = "0x1822C5860")]
		[DebuggerNonUserCode]
		public ItemConditionItems()
		{
			items_ = (RepeatedField<int>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6005CB5")]
		[Cpp2IlInjected.Address(RVA = "0x22C57D0", Offset = "0x22C41D0", VA = "0x1822C57D0")]
		[DebuggerNonUserCode]
		public ItemConditionItems(ItemConditionItems other)
		{
			RepeatedField<int> repeatedField = (items_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.items_).Clone());
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005CB6")]
		[Cpp2IlInjected.Address(RVA = "0x22C4EE0", Offset = "0x22C38E0", VA = "0x1822C4EE0", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemConditionItems Clone()
		{
			//Discarded unreachable code: IL_003c
			ItemConditionItems itemConditionItems = new ItemConditionItems();
			RepeatedField<int> repeatedField = (itemConditionItems.items_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)items_).Clone());
			bool flag = (itemConditionItems.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (itemConditionItems._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemConditionItems;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CBA")]
		[Cpp2IlInjected.Address(RVA = "0x22C50C0", Offset = "0x22C3AC0", VA = "0x1822C50C0", Slot = "0")]
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
				RepeatedField<int> repeatedField = items_;
				bool flag = default(bool);
				if (flag && inversed_ == flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005CBB")]
		[Cpp2IlInjected.Address(RVA = "0x22C5020", Offset = "0x22C3A20", VA = "0x1822C5020", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemConditionItems other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = items_;
				RepeatedField<int> repeatedField2 = other.items_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					bool flag = other.inversed_;
					if (inversed_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005CBC")]
		[Cpp2IlInjected.Address(RVA = "0x1BFA7F0", Offset = "0x1BF91F0", VA = "0x181BFA7F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002e
			int hashCode = ((RepeatedField<T>)(object)items_).GetHashCode();
			if (inversed_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CBD")]
		[Cpp2IlInjected.Address(RVA = "0x22C5550", Offset = "0x22C3F50", VA = "0x1822C5550", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005CBE")]
		[Cpp2IlInjected.Address(RVA = "0x22C55B0", Offset = "0x22C3FB0", VA = "0x1822C55B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003f
			RepeatedField<int> repeatedField = items_;
			FieldCodec<int> repeated_items_codec = _repeated_items_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_items_codec);
			if (inversed_)
			{
				bool value = inversed_;
				output.WriteBool(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005CBF")]
		[Cpp2IlInjected.Address(RVA = "0x22C4DC0", Offset = "0x22C37C0", VA = "0x1822C4DC0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<int> repeatedField = items_;
			FieldCodec<int> repeated_items_codec = _repeated_items_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_items_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CC0")]
		[Cpp2IlInjected.Address(RVA = "0x22C53F0", Offset = "0x22C3DF0", VA = "0x1822C53F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemConditionItems other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				RepeatedField<int> repeatedField = items_;
				RepeatedField<int> repeatedField2 = other.items_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				bool flag = other.inversed_;
				if (flag)
				{
					inversed_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CC1")]
		[Cpp2IlInjected.Address(RVA = "0x22C52E0", Offset = "0x22C3CE0", VA = "0x1822C52E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0059
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((long)input != 4294967293L)
			{
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
			RepeatedField<int> repeatedField = items_;
			FieldCodec<int> repeated_items_codec = _repeated_items_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_items_codec);
		}

		[Cpp2IlInjected.Token(Token = "0x6005CC2")]
		[Cpp2IlInjected.Address(RVA = "0x22C5210", Offset = "0x22C3C10", VA = "0x1822C5210", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = items_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CC3")]
		[Cpp2IlInjected.Address(RVA = "0x22C5480", Offset = "0x22C3E80", VA = "0x1822C5480", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0010
			//IL_000f: Expected I4, but got O
			switch (fieldNumber)
			{
			case 2:
			{
				object obj = default(object);
				inversed_ = (byte)(int)obj != 0;
				break;
			}
			case 1:
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				/*Error: Unexpected end of block*/;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CC4")]
		[Cpp2IlInjected.Address(RVA = "0x22C4E70", Offset = "0x22C3870", VA = "0x1822C4E70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0017
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = items_;
			}
			if (fieldNumber == 2)
			{
				inversed_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CC5")]
		[Cpp2IlInjected.Address(RVA = "0x22C51A0", Offset = "0x22C3BA0", VA = "0x1822C51A0", Slot = "14")]
		public bool Evaluate(Item target)
		{
			//Discarded unreachable code: IL_0023
			//IL_0013: Expected O, but got I4
			int itemID = target.ItemID;
			bool condition = ((RepeatedField<T>)(object)items_).Contains((T)itemID);
			bool inversed = inversed_;
			return Operations.EvaluateInverse(condition, inversed);
		}

		[Cpp2IlInjected.Token(Token = "0x6005CC7")]
		[Cpp2IlInjected.Address(RVA = "0x22C4FA0", Offset = "0x22C39A0", VA = "0x1822C4FA0", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001a
			if (((RepeatedField<T>)(object)items_).Count == 0)
			{
				context.AddError("ItemCondition required at least one item");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CC8")]
		[Cpp2IlInjected.Address(RVA = "0x22C5690", Offset = "0x22C4090", VA = "0x1822C5690")]
		static ItemConditionItems()
		{
			_parser = (MessageParser<ItemConditionItems>)(object)FieldCodec.ForInt32(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
