using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000285")]
	public sealed class AmountWithState : IMessage<AmountWithState>, IMessage, IEquatable<AmountWithState>, IDeepCloneable<AmountWithState>, IMessageFieldAccessor, IGridStateData
	{
		[Cpp2IlInjected.Token(Token = "0x40009F4")]
		private static readonly MessageParser<AmountWithState> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40009F5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40009F6")]
		public const int AmountFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40009F7")]
		private static readonly FieldCodec<int?> _single_amount_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40009F8")]
		private int? amount_;

		[Cpp2IlInjected.Token(Token = "0x40009F9")]
		public const int StateFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40009FA")]
		private ItemState state_;

		[Cpp2IlInjected.Token(Token = "0x17000555")]
		[DebuggerNonUserCode]
		public static MessageParser<AmountWithState> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001826")]
			[Cpp2IlInjected.Address(RVA = "0x315D6B0", Offset = "0x315C0B0", VA = "0x18315D6B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000556")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001827")]
			[Cpp2IlInjected.Address(RVA = "0x315D5E0", Offset = "0x315BFE0", VA = "0x18315D5E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000557")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001828")]
			[Cpp2IlInjected.Address(RVA = "0x315D710", Offset = "0x315C110", VA = "0x18315D710", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000558")]
		[DebuggerNonUserCode]
		public int? Amount
		{
			[Cpp2IlInjected.Token(Token = "0x600182C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return amount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600182D")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
			set
			{
				amount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000559")]
		[DebuggerNonUserCode]
		public ItemState State
		{
			[Cpp2IlInjected.Token(Token = "0x600182E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return state_;
			}
			[Cpp2IlInjected.Token(Token = "0x600182F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				state_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001829")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public AmountWithState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600182A")]
		[Cpp2IlInjected.Address(RVA = "0x315D560", Offset = "0x315BF60", VA = "0x18315D560")]
		[DebuggerNonUserCode]
		public AmountWithState(AmountWithState other)
		{
			//IL_002f: Expected O, but got I4
			int? num = (amount_ = other.amount_);
			ItemState itemState = other.state_;
			if (itemState != null)
			{
				ItemState itemState2 = itemState.Clone();
			}
			int num2 = 0;
			state_ = (ItemState)num2;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600182B")]
		[Cpp2IlInjected.Address(RVA = "0x315CB40", Offset = "0x315B540", VA = "0x18315CB40", Slot = "10")]
		[DebuggerNonUserCode]
		public AmountWithState Clone()
		{
			//Discarded unreachable code: IL_0048
			//IL_0031: Expected O, but got I4
			AmountWithState amountWithState = new AmountWithState();
			int? num = (amountWithState.amount_ = amount_);
			ItemState itemState = state_;
			if (itemState != null)
			{
				ItemState itemState2 = itemState.Clone();
			}
			int num2 = 0;
			amountWithState.state_ = (ItemState)num2;
			UnknownFieldSet unknownFieldSet = (amountWithState._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return amountWithState;
		}

		[Cpp2IlInjected.Token(Token = "0x6001830")]
		[Cpp2IlInjected.Address(RVA = "0x315CCA0", Offset = "0x315B6A0", VA = "0x18315CCA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0025: Expected O, but got I4
			//IL_0034: Expected O, but got I4
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
				int? num2 = amount_;
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (flag != flag2 && object.Equals(state_, flag2))
				{
					return object.Equals(_unknownFields, flag2);
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001831")]
		[Cpp2IlInjected.Address(RVA = "0x315CBE0", Offset = "0x315B5E0", VA = "0x18315CBE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AmountWithState other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int? num = amount_;
				int? num2 = other.amount_;
				bool flag = (object)num == (object)num2;
				if ((object)num == (object)num2 != flag)
				{
					ItemState objB = other.state_;
					if (object.Equals(state_, objB))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001832")]
		[Cpp2IlInjected.Address(RVA = "0x315CE80", Offset = "0x315B880", VA = "0x18315CE80", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int? num = amount_;
				ItemState itemState = state_;
				if (itemState != null)
				{
					int hashCode = itemState.GetHashCode();
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6001833")]
		[Cpp2IlInjected.Address(RVA = "0x315D2C0", Offset = "0x315BCC0", VA = "0x18315D2C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001834")]
		[Cpp2IlInjected.Address(RVA = "0x315D320", Offset = "0x315BD20", VA = "0x18315D320", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			FieldCodec<int?> single_amount_codec = _single_amount_codec;
			int? value = amount_;
			((FieldCodec<T>)(object)single_amount_codec).WriteTagAndValue(output, (T)value);
			if ((long)state_ != 0)
			{
				ItemState value2 = state_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001835")]
		[Cpp2IlInjected.Address(RVA = "0x315CA00", Offset = "0x315B400", VA = "0x18315CA00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0055
			int num = 0;
			FieldCodec<int?> single_amount_codec = _single_amount_codec;
			int? value = amount_;
			int num2 = ((FieldCodec<T>)(object)single_amount_codec).CalculateSizeWithTag((T)value);
			ItemState itemState = state_;
			if (itemState != null)
			{
				int num3 = CodedOutputStream.ComputeMessageSize(itemState);
				num3++;
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

		[Cpp2IlInjected.Token(Token = "0x6001836")]
		[Cpp2IlInjected.Address(RVA = "0x315D0C0", Offset = "0x315BAC0", VA = "0x18315D0C0", Slot = "4")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(AmountWithState other)
		{
			//Discarded unreachable code: IL_0078
			if (other == null)
			{
				return;
			}
			int? num = other.amount_;
			if ((IntPtr)(((object)num == null) ? 1 : 0) == (IntPtr)(void*)num)
			{
				int? num2 = (amount_ = other.amount_);
			}
			if ((long)other.state_ != 0)
			{
				ItemState itemState2 = default(ItemState);
				if (state_ == null)
				{
					ItemState itemState = (state_ = new ItemState());
					itemState2 = state_;
				}
				ItemState other2 = other.state_;
				itemState2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6001837")]
		[Cpp2IlInjected.Address(RVA = "0x315CF40", Offset = "0x315B940", VA = "0x18315CF40", Slot = "5")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_006d
			ItemState builder = default(ItemState);
			while (true)
			{
				uint num = input.ReadTag();
				if (num == 0)
				{
					break;
				}
				if (num == 10)
				{
					int? num2 = (int?)((FieldCodec<T>)(object)_single_amount_codec).Read(input);
					if ((IntPtr)(((object)num2 == null) ? 1 : 0) != (IntPtr)(void*)num2)
					{
						continue;
					}
					amount_ = num2;
				}
				if (num == 18)
				{
					if (state_ == null)
					{
						ItemState itemState = (state_ = new ItemState());
						builder = state_;
					}
					input.ReadMessage(builder);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001838")]
		[Cpp2IlInjected.Address(RVA = "0x315CDB0", Offset = "0x315B7B0", VA = "0x18315CDB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int? num = amount_;
			}
			if (fieldNumber == 2)
			{
				ItemState itemState = state_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001839")]
		[Cpp2IlInjected.Address(RVA = "0x315D1D0", Offset = "0x315BBD0", VA = "0x18315D1D0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000f: Expected O, but got I4
			if (fieldNumber == 1)
			{
				if (value != null)
				{
				}
				amount_ = (int?)(object)0;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				state_ = (ItemState)value;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600183A")]
		[Cpp2IlInjected.Address(RVA = "0x315CB10", Offset = "0x315B510", VA = "0x18315CB10", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected O, but got I8
			switch (fieldNumber)
			{
			case 1:
				amount_ = (int?)(object)0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600183B")]
		[Cpp2IlInjected.Address(RVA = "0x315D410", Offset = "0x315BE10", VA = "0x18315D410")]
		static AmountWithState()
		{
			Func<AmountWithState> func = default(Func<AmountWithState>);
			_parser = (MessageParser<AmountWithState>)(object)new MessageParser<T>((Func<>)(object)func);
			uint num = default(uint);
			_parser = (MessageParser<AmountWithState>)(object)FieldCodec.ForStructWrapper<int>(num);
			/*Error: Unexpected end of block*/;
		}
	}
}
