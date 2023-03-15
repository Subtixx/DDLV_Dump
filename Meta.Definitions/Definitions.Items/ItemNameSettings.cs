using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005D2")]
	public sealed class ItemNameSettings : IMessage<ItemNameSettings>, IMessage, IEquatable<ItemNameSettings>, IDeepCloneable<ItemNameSettings>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001FC1")]
		private static readonly MessageParser<ItemNameSettings> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001FC2")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001FC3")]
		public const int UseTagConditionsFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001FC4")]
		private bool useTagConditions_;

		[Cpp2IlInjected.Token(Token = "0x4001FC5")]
		public const int TagConditionsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001FC6")]
		private static readonly FieldCodec<ItemNameTagCondition> _repeated_tagConditions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001FC7")]
		private readonly RepeatedField<ItemNameTagCondition> tagConditions_ = (RepeatedField<ItemNameTagCondition>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170012B2")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemNameSettings> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004894")]
			[Cpp2IlInjected.Address(RVA = "0x25E4BE0", Offset = "0x25E35E0", VA = "0x1825E4BE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012B3")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004895")]
			[Cpp2IlInjected.Address(RVA = "0x25E4A30", Offset = "0x25E3430", VA = "0x1825E4A30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012B4")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004896")]
			[Cpp2IlInjected.Address(RVA = "0x25E4C40", Offset = "0x25E3640", VA = "0x1825E4C40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012B5")]
		[DebuggerNonUserCode]
		public bool UseTagConditions
		{
			[Cpp2IlInjected.Token(Token = "0x600489A")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return useTagConditions_;
			}
			[Cpp2IlInjected.Token(Token = "0x600489B")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				useTagConditions_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012B6")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemNameTagCondition> TagConditions
		{
			[Cpp2IlInjected.Token(Token = "0x600489C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return tagConditions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012B7")]
		public static ItemNameSettings Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60048A8")]
			[Cpp2IlInjected.Address(RVA = "0x25E4B00", Offset = "0x25E3500", VA = "0x1825E4B00")]
			get
			{
				//Discarded unreachable code: IL_0010
				return ProtoDatabase.Instance.Get<ItemNameSettings>("ItemNameSettings");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004897")]
		[Cpp2IlInjected.Address(RVA = "0x25E49B0", Offset = "0x25E33B0", VA = "0x1825E49B0")]
		[DebuggerNonUserCode]
		public ItemNameSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004898")]
		[Cpp2IlInjected.Address(RVA = "0x25E48B0", Offset = "0x25E32B0", VA = "0x1825E48B0")]
		[DebuggerNonUserCode]
		public ItemNameSettings(ItemNameSettings other)
		{
			bool flag = (useTagConditions_ = other.useTagConditions_);
			RepeatedField<ItemNameTagCondition> repeatedField = (tagConditions_ = (RepeatedField<ItemNameTagCondition>)(object)((RepeatedField<T>)(object)other.tagConditions_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004899")]
		[Cpp2IlInjected.Address(RVA = "0x25E3EC0", Offset = "0x25E28C0", VA = "0x1825E3EC0", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemNameSettings Clone()
		{
			//Discarded unreachable code: IL_004b
			ItemNameSettings itemNameSettings = new ItemNameSettings();
			RepeatedField<ItemNameTagCondition> repeatedField = (itemNameSettings.tagConditions_ = (RepeatedField<ItemNameTagCondition>)(object)new RepeatedField<T>());
			bool flag = (itemNameSettings.useTagConditions_ = useTagConditions_);
			RepeatedField<ItemNameTagCondition> repeatedField2 = (itemNameSettings.tagConditions_ = (RepeatedField<ItemNameTagCondition>)(object)((RepeatedField<T>)(object)tagConditions_).Clone());
			UnknownFieldSet unknownFieldSet = (itemNameSettings._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemNameSettings;
		}

		[Cpp2IlInjected.Token(Token = "0x600489D")]
		[Cpp2IlInjected.Address(RVA = "0x25E4090", Offset = "0x25E2A90", VA = "0x1825E4090", Slot = "0")]
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
				if ((IntPtr)(useTagConditions_ ? 1 : 0) == (IntPtr)typeof(ItemNameSettings).TypeHandle)
				{
					RepeatedField<ItemNameTagCondition> repeatedField = tagConditions_;
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

		[Cpp2IlInjected.Token(Token = "0x600489E")]
		[Cpp2IlInjected.Address(RVA = "0x25E3FF0", Offset = "0x25E29F0", VA = "0x1825E3FF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemNameSettings other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.useTagConditions_;
				if (useTagConditions_ == flag)
				{
					RepeatedField<ItemNameTagCondition> repeatedField = tagConditions_;
					RepeatedField<ItemNameTagCondition> repeatedField2 = other.tagConditions_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600489F")]
		[Cpp2IlInjected.Address(RVA = "0x78BEE0", Offset = "0x78A8E0", VA = "0x18078BEE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002a
			if (useTagConditions_)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)tagConditions_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60048A0")]
		[Cpp2IlInjected.Address(RVA = "0x25E4590", Offset = "0x25E2F90", VA = "0x1825E4590", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60048A1")]
		[Cpp2IlInjected.Address(RVA = "0x25E45F0", Offset = "0x25E2FF0", VA = "0x1825E45F0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003f
			if (useTagConditions_)
			{
				bool value = useTagConditions_;
				output.WriteBool(value);
			}
			RepeatedField<ItemNameTagCondition> repeatedField = tagConditions_;
			FieldCodec<ItemNameTagCondition> repeated_tagConditions_codec = _repeated_tagConditions_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tagConditions_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60048A2")]
		[Cpp2IlInjected.Address(RVA = "0x25E3D90", Offset = "0x25E2790", VA = "0x1825E3D90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			RepeatedField<ItemNameTagCondition> repeatedField = tagConditions_;
			FieldCodec<ItemNameTagCondition> repeated_tagConditions_codec = _repeated_tagConditions_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tagConditions_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<ItemNameTagCondition>)(repeatedField + num2);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60048A3")]
		[Cpp2IlInjected.Address(RVA = "0x25E4330", Offset = "0x25E2D30", VA = "0x1825E4330", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemNameSettings other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				bool flag = other.useTagConditions_;
				if (flag)
				{
					useTagConditions_ = flag;
				}
				RepeatedField<ItemNameTagCondition> repeatedField = tagConditions_;
				RepeatedField<ItemNameTagCondition> repeatedField2 = other.tagConditions_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048A4")]
		[Cpp2IlInjected.Address(RVA = "0x25E43C0", Offset = "0x25E2DC0", VA = "0x1825E43C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0051
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					bool flag = (useTagConditions_ = input.ReadBool());
				}
				if (num == 18)
				{
					RepeatedField<ItemNameTagCondition> repeatedField = tagConditions_;
					FieldCodec<ItemNameTagCondition> repeated_tagConditions_codec = _repeated_tagConditions_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tagConditions_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60048A5")]
		[Cpp2IlInjected.Address(RVA = "0x25E4170", Offset = "0x25E2B70", VA = "0x1825E4170", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool flag = useTagConditions_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<ItemNameTagCondition> repeatedField = tagConditions_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60048A6")]
		[Cpp2IlInjected.Address(RVA = "0x25E44C0", Offset = "0x25E2EC0", VA = "0x1825E44C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				useTagConditions_ = (byte)(int)obj != 0;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60048A7")]
		[Cpp2IlInjected.Address(RVA = "0x25E3E50", Offset = "0x25E2850", VA = "0x1825E3E50", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				useTagConditions_ = false;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<ItemNameTagCondition> repeatedField = tagConditions_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60048A9")]
		[Cpp2IlInjected.Address(RVA = "0x25E4240", Offset = "0x25E2C40", VA = "0x1825E4240")]
		public ItemNameTagCondition GetItemNameStyle(Item item)
		{
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			if (useTagConditions_)
			{
				RepeatedField<ItemNameTagCondition> repeatedField = tagConditions_;
				Func<ItemNameTagCondition, bool> func = (Func<ItemNameTagCondition, bool>)(object)(Func<T, TResult>)delegate(ItemNameTagCondition x)
				{
					//Discarded unreachable code: IL_0016
					ItemConditionsList condition_ = x.condition_;
					Item target = item2;
					return condition_.Evaluate(target);
				};
				return Enumerable.FirstOrDefault<ItemNameTagCondition>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60048AA")]
		[Cpp2IlInjected.Address(RVA = "0x25E46E0", Offset = "0x25E30E0", VA = "0x1825E46E0")]
		static ItemNameSettings()
		{
			Func<ItemNameSettings> func = default(Func<ItemNameSettings>);
			_parser = (MessageParser<ItemNameSettings>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<ItemNameTagCondition> parser = ItemNameTagCondition._parser;
			uint num = default(uint);
			_parser = (MessageParser<ItemNameSettings>)(object)FieldCodec.ForMessage<ItemNameTagCondition>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
