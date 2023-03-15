using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000705")]
	public sealed class ToggleGridData : IMessage<ToggleGridData>, IMessage, IEquatable<ToggleGridData>, IDeepCloneable<ToggleGridData>, IMessageFieldAccessor, IGridStateData, IGridStateDailyResetNotify
	{
		[Cpp2IlInjected.Token(Token = "0x4002393")]
		private static readonly MessageParser<ToggleGridData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002394")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002395")]
		public const int ValueFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002396")]
		private static readonly FieldCodec<bool?> _single_value_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002397")]
		private bool? value_;

		[Cpp2IlInjected.Token(Token = "0x1700140B")]
		[DebuggerNonUserCode]
		public static MessageParser<ToggleGridData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004E44")]
			[Cpp2IlInjected.Address(RVA = "0x354A170", Offset = "0x3548B70", VA = "0x18354A170")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700140C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E45")]
			[Cpp2IlInjected.Address(RVA = "0x354A0A0", Offset = "0x3548AA0", VA = "0x18354A0A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700140D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E46")]
			[Cpp2IlInjected.Address(RVA = "0x354A1D0", Offset = "0x3548BD0", VA = "0x18354A1D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700140E")]
		[DebuggerNonUserCode]
		public bool? Value
		{
			[Cpp2IlInjected.Token(Token = "0x6004E4A")]
			[Cpp2IlInjected.Address(RVA = "0x1D91FB0", Offset = "0x1D909B0", VA = "0x181D91FB0")]
			get
			{
				return value_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E4B")]
			[Cpp2IlInjected.Address(RVA = "0x1D8E2D0", Offset = "0x1D8CCD0", VA = "0x181D8E2D0")]
			set
			{
				value_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E47")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ToggleGridData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E48")]
		[Cpp2IlInjected.Address(RVA = "0x354A050", Offset = "0x3548A50", VA = "0x18354A050")]
		[DebuggerNonUserCode]
		public ToggleGridData(ToggleGridData other)
		{
			bool? flag = (value_ = other.value_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E49")]
		[Cpp2IlInjected.Address(RVA = "0x35496E0", Offset = "0x35480E0", VA = "0x1835496E0", Slot = "10")]
		[DebuggerNonUserCode]
		public ToggleGridData Clone()
		{
			//Discarded unreachable code: IL_0029
			ToggleGridData toggleGridData = new ToggleGridData();
			bool? flag = (toggleGridData.value_ = value_);
			UnknownFieldSet unknownFieldSet = (toggleGridData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return toggleGridData;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E4C")]
		[Cpp2IlInjected.Address(RVA = "0x3549940", Offset = "0x3548340", VA = "0x183549940", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0025: Expected O, but got I4
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
				bool? flag = value_;
				bool flag2 = default(bool);
				bool flag3 = default(bool);
				if (flag2 != flag3)
				{
					return object.Equals(_unknownFields, flag3);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E4D")]
		[Cpp2IlInjected.Address(RVA = "0x3549890", Offset = "0x3548290", VA = "0x183549890", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ToggleGridData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool? flag = value_;
				bool? flag2 = other.value_;
				bool flag3 = (object)flag == (object)flag2;
				if ((object)flag == (object)flag2 != flag3)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E4E")]
		[Cpp2IlInjected.Address(RVA = "0x3549AF0", Offset = "0x35484F0", VA = "0x183549AF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				bool? flag = value_;
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E4F")]
		[Cpp2IlInjected.Address(RVA = "0x3549DE0", Offset = "0x35487E0", VA = "0x183549DE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E50")]
		[Cpp2IlInjected.Address(RVA = "0x3549E40", Offset = "0x3548840", VA = "0x183549E40", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			FieldCodec<bool?> single_value_codec = _single_value_codec;
			bool? value = value_;
			((FieldCodec<T>)(object)single_value_codec).WriteTagAndValue(output, (T)value);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E51")]
		[Cpp2IlInjected.Address(RVA = "0x3549610", Offset = "0x3548010", VA = "0x183549610", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0034
			int num = 0;
			FieldCodec<bool?> single_value_codec = _single_value_codec;
			bool? value = value_;
			int num2 = ((FieldCodec<T>)(object)single_value_codec).CalculateSizeWithTag((T)value);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E52")]
		[Cpp2IlInjected.Address(RVA = "0x3549B90", Offset = "0x3548590", VA = "0x183549B90", Slot = "4")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(ToggleGridData other)
		{
			//IL_0012: Expected I4, but got O
			if (other != null)
			{
				bool? flag = other.value_;
				bool flag2 = (byte)(int)((Nullable<>*)(&flag))->value != 0;
				if ((object)flag == null == flag2)
				{
					bool? flag3 = (value_ = other.value_);
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E53")]
		[Cpp2IlInjected.Address(RVA = "0x3549C20", Offset = "0x3548620", VA = "0x183549C20", Slot = "5")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0043
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				bool? flag = (bool?)((FieldCodec<T>)(object)_single_value_codec).Read(input);
				bool flag2 = (object)flag == null;
				while ((IntPtr)(void*)flag != (IntPtr)(flag2 ? 1 : 0))
				{
				}
				value_ = flag;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004E54")]
		[Cpp2IlInjected.Address(RVA = "0x3549A40", Offset = "0x3548440", VA = "0x183549A40", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool? flag = value_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E55")]
		[Cpp2IlInjected.Address(RVA = "0x3549D40", Offset = "0x3548740", VA = "0x183549D40", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0010
			//IL_000f: Expected O, but got I4
			if (fieldNumber == 1)
			{
				if (value != null)
				{
				}
				value_ = (bool?)(object)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E56")]
		[Cpp2IlInjected.Address(RVA = "0x35496D0", Offset = "0x35480D0", VA = "0x1835496D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				value_ = (bool?)(object)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E57")]
		[Cpp2IlInjected.Address(RVA = "0x3549760", Offset = "0x3548160", VA = "0x183549760")]
		public GridStateDailyResetResult ExecuteDailyReset(Item item, in WorldProfile worldProfile, Random random, ITransactionContext context)
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			FurnitureItemData furnitureItemData = default(FurnitureItemData);
			if (furnitureItemData != null && furnitureItemData.Toggle != null && furnitureItemData.Toggle.backToDefaultOnDailyReset_)
			{
				bool? flag = (value_ = (bool?)furnitureItemData.Toggle.GetDefaultValue());
				return GridStateDailyResetResult.UpdateState;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E58")]
		[Cpp2IlInjected.Address(RVA = "0x3549F00", Offset = "0x3548900", VA = "0x183549F00")]
		static ToggleGridData()
		{
			Func<ToggleGridData> func = default(Func<ToggleGridData>);
			_parser = (MessageParser<ToggleGridData>)(object)new MessageParser<T>((Func<>)(object)func);
			uint num = default(uint);
			_parser = (MessageParser<ToggleGridData>)(object)FieldCodec.ForStructWrapper<bool>(num);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E59")]
		[Cpp2IlInjected.Address(RVA = "0x3549760", Offset = "0x3548160", VA = "0x183549760", Slot = "14")]
		GridStateDailyResetResult IGridStateDailyResetNotify.ExecuteDailyReset(Item item, in WorldProfile worldProfile, Random random, ITransactionContext context)
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			FurnitureItemData furnitureItemData = default(FurnitureItemData);
			if (furnitureItemData != null && furnitureItemData.Toggle != null && furnitureItemData.Toggle.backToDefaultOnDailyReset_)
			{
				bool? flag = (value_ = (bool?)furnitureItemData.Toggle.GetDefaultValue());
				return GridStateDailyResetResult.UpdateState;
			}
			int num = 0;
			throw new NullReferenceException();
		}
	}
}
