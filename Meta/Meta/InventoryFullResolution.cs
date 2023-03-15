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
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class InventoryFullResolution : IMessage<InventoryFullResolution>, IMessage, IEquatable<InventoryFullResolution>, IDeepCloneable<InventoryFullResolution>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static readonly MessageParser<InventoryFullResolution> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public const int PositionsToDropFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static readonly FieldCodec<int> _repeated_positionsToDrop_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private readonly RepeatedField<int> positionsToDrop_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public const int DetailsFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private InventoryFullDetails details_;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[DebuggerNonUserCode]
		public static MessageParser<InventoryFullResolution> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x170EF90", Offset = "0x170D990", VA = "0x18170EF90")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x170EEC0", Offset = "0x170D8C0", VA = "0x18170EEC0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x170EFF0", Offset = "0x170D9F0", VA = "0x18170EFF0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		[DebuggerNonUserCode]
		public RepeatedField<int> PositionsToDrop
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return positionsToDrop_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		[DebuggerNonUserCode]
		public InventoryFullDetails Details
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return details_;
			}
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				details_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x170EE40", Offset = "0x170D840", VA = "0x18170EE40")]
		[DebuggerNonUserCode]
		public InventoryFullResolution()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x170EC60", Offset = "0x170D660", VA = "0x18170EC60")]
		[DebuggerNonUserCode]
		public InventoryFullResolution(InventoryFullResolution other)
		{
			//IL_0081: Expected O, but got I4
			RepeatedField<int> repeatedField = (positionsToDrop_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.positionsToDrop_).Clone());
			InventoryFullDetails inventoryFullDetails = other.details_;
			if (inventoryFullDetails != null)
			{
				InventoryFullDetails inventoryFullDetails2 = new InventoryFullDetails();
				RepeatedField<ItemInstance> repeatedField2 = (inventoryFullDetails2.itemsOverflowing_ = (RepeatedField<ItemInstance>)(object)((RepeatedField<T>)(object)inventoryFullDetails.itemsOverflowing_).Clone());
				RepeatedField<int> repeatedField3 = (inventoryFullDetails2.unavailablePositions_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)inventoryFullDetails.unavailablePositions_).Clone());
				UnknownFieldSet unknownFieldSet = (inventoryFullDetails2._unknownFields = UnknownFieldSet.Clone(inventoryFullDetails._unknownFields));
			}
			int num = 0;
			details_ = (InventoryFullDetails)num;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x170E320", Offset = "0x170CD20", VA = "0x18170E320", Slot = "10")]
		[DebuggerNonUserCode]
		public InventoryFullResolution Clone()
		{
			return new InventoryFullResolution(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x170E380", Offset = "0x170CD80", VA = "0x18170E380", Slot = "0")]
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
				RepeatedField<int> repeatedField = positionsToDrop_;
				bool flag = default(bool);
				if (flag && object.Equals(details_, other))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x170E470", Offset = "0x170CE70", VA = "0x18170E470", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(InventoryFullResolution other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = positionsToDrop_;
				RepeatedField<int> repeatedField2 = other.positionsToDrop_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					InventoryFullDetails objB = other.details_;
					if (object.Equals(details_, objB))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x170E5B0", Offset = "0x170CFB0", VA = "0x18170E5B0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0037
			int hashCode = ((RepeatedField<T>)(object)positionsToDrop_).GetHashCode();
			InventoryFullDetails inventoryFullDetails = details_;
			if (inventoryFullDetails != null)
			{
				int hashCode2 = inventoryFullDetails.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x170E9E0", Offset = "0x170D3E0", VA = "0x18170E9E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x170EA40", Offset = "0x170D440", VA = "0x18170EA40", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			RepeatedField<int> repeatedField = positionsToDrop_;
			FieldCodec<int> repeated_positionsToDrop_codec = _repeated_positionsToDrop_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_positionsToDrop_codec);
			if ((long)details_ != 0)
			{
				InventoryFullDetails value = details_;
				output.WriteMessage(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x170E1A0", Offset = "0x170CBA0", VA = "0x18170E1A0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0054
			RepeatedField<int> repeatedField = positionsToDrop_;
			FieldCodec<int> repeated_positionsToDrop_codec = _repeated_positionsToDrop_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_positionsToDrop_codec);
			InventoryFullDetails inventoryFullDetails = details_;
			if (inventoryFullDetails != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(inventoryFullDetails);
				num2++;
				num += num2;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x170E790", Offset = "0x170D190", VA = "0x18170E790", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(InventoryFullResolution other)
		{
			//Discarded unreachable code: IL_00b6
			if (other == null)
			{
				return;
			}
			RepeatedField<int> repeatedField = positionsToDrop_;
			RepeatedField<int> repeatedField2 = other.positionsToDrop_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			InventoryFullDetails inventoryFullDetails = other.details_;
			if (inventoryFullDetails != null)
			{
				InventoryFullDetails inventoryFullDetails2 = details_;
				if (inventoryFullDetails2 == null)
				{
					InventoryFullDetails inventoryFullDetails3 = (details_ = new InventoryFullDetails());
				}
				if (inventoryFullDetails != null)
				{
					RepeatedField<ItemInstance> itemsOverflowing_ = inventoryFullDetails2.itemsOverflowing_;
					RepeatedField<ItemInstance> itemsOverflowing_2 = inventoryFullDetails.itemsOverflowing_;
					((RepeatedField<T>)(object)itemsOverflowing_).Add((IEnumerable<>)(object)itemsOverflowing_2);
					RepeatedField<int> unavailablePositions_ = inventoryFullDetails2.unavailablePositions_;
					RepeatedField<int> unavailablePositions_2 = inventoryFullDetails.unavailablePositions_;
					((RepeatedField<T>)(object)unavailablePositions_).Add((IEnumerable<>)(object)unavailablePositions_2);
					UnknownFieldSet unknownFields = inventoryFullDetails._unknownFields;
					UnknownFieldSet unknownFieldSet = (inventoryFullDetails2._unknownFields = UnknownFieldSet.MergeFrom(inventoryFullDetails2._unknownFields, unknownFields));
				}
			}
			UnknownFieldSet unknownFields2 = other._unknownFields;
			UnknownFieldSet unknownFieldSet2 = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields2));
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x170E630", Offset = "0x170D030", VA = "0x18170E630", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_006c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((long)input != 4294967293L)
			{
				if (num == 18)
				{
					InventoryFullDetails inventoryFullDetails = details_;
					if (inventoryFullDetails == null)
					{
						InventoryFullDetails inventoryFullDetails2 = (details_ = new InventoryFullDetails());
					}
					input.ReadMessage(inventoryFullDetails);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
			RepeatedField<int> repeatedField = positionsToDrop_;
			FieldCodec<int> repeated_positionsToDrop_codec = _repeated_positionsToDrop_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_positionsToDrop_codec);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x170E520", Offset = "0x170CF20", VA = "0x18170E520", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = positionsToDrop_;
			}
			if (fieldNumber == 2)
			{
				InventoryFullDetails inventoryFullDetails = details_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x170E910", Offset = "0x170D310", VA = "0x18170E910", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0019: Expected O, but got I4
			switch (fieldNumber)
			{
			case 2:
			{
				int num = 0;
				if (value == null || value != null)
				{
					details_ = (InventoryFullDetails)num;
					break;
				}
				throw new InvalidCastException();
			}
			case 1:
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				/*Error: Unexpected end of block*/;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x170E2A0", Offset = "0x170CCA0", VA = "0x18170E2A0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = positionsToDrop_;
			}
			if (fieldNumber != 2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x170EB20", Offset = "0x170D520", VA = "0x18170EB20")]
		static InventoryFullResolution()
		{
			Func<InventoryFullResolution> func = default(Func<InventoryFullResolution>);
			_parser = (MessageParser<InventoryFullResolution>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<InventoryFullResolution>)(object)FieldCodec.ForInt32(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
