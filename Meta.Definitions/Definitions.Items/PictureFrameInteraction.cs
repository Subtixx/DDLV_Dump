using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002CF")]
	public sealed class PictureFrameInteraction : IMessage<PictureFrameInteraction>, IMessage, IEquatable<PictureFrameInteraction>, IDeepCloneable<PictureFrameInteraction>, IMessageFieldAccessor, IGridStateDataProvider
	{
		[Cpp2IlInjected.Token(Token = "0x4000C96")]
		private static readonly MessageParser<PictureFrameInteraction> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000C97")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000C98")]
		public const int TagsToIgnoreFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000C99")]
		private static readonly FieldCodec<int> _repeated_tagsToIgnore_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000C9A")]
		private readonly RepeatedField<int> tagsToIgnore_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170006DC")]
		[DebuggerNonUserCode]
		public static MessageParser<PictureFrameInteraction> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001E15")]
			[Cpp2IlInjected.Address(RVA = "0x2876140", Offset = "0x2874B40", VA = "0x182876140")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006DD")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001E16")]
			[Cpp2IlInjected.Address(RVA = "0x2876070", Offset = "0x2874A70", VA = "0x182876070")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006DE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001E17")]
			[Cpp2IlInjected.Address(RVA = "0x28761A0", Offset = "0x2874BA0", VA = "0x1828761A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006DF")]
		[DebuggerNonUserCode]
		public RepeatedField<int> TagsToIgnore
		{
			[Cpp2IlInjected.Token(Token = "0x6001E1B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return tagsToIgnore_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E18")]
		[Cpp2IlInjected.Address(RVA = "0x2875EF0", Offset = "0x28748F0", VA = "0x182875EF0")]
		[DebuggerNonUserCode]
		public PictureFrameInteraction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001E19")]
		[Cpp2IlInjected.Address(RVA = "0x2875F70", Offset = "0x2874970", VA = "0x182875F70")]
		[DebuggerNonUserCode]
		public PictureFrameInteraction(PictureFrameInteraction other)
		{
			RepeatedField<int> repeatedField = (tagsToIgnore_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.tagsToIgnore_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E1A")]
		[Cpp2IlInjected.Address(RVA = "0x2875460", Offset = "0x2873E60", VA = "0x182875460", Slot = "10")]
		[DebuggerNonUserCode]
		public PictureFrameInteraction Clone()
		{
			//Discarded unreachable code: IL_003b
			PictureFrameInteraction pictureFrameInteraction = new PictureFrameInteraction();
			RepeatedField<int> repeatedField = (pictureFrameInteraction.tagsToIgnore_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<int> repeatedField2 = (pictureFrameInteraction.tagsToIgnore_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)tagsToIgnore_).Clone());
			UnknownFieldSet unknownFieldSet = (pictureFrameInteraction._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return pictureFrameInteraction;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E1C")]
		[Cpp2IlInjected.Address(RVA = "0x28755A0", Offset = "0x2873FA0", VA = "0x1828755A0", Slot = "0")]
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
				RepeatedField<int> repeatedField = tagsToIgnore_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E1D")]
		[Cpp2IlInjected.Address(RVA = "0x2875680", Offset = "0x2874080", VA = "0x182875680", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PictureFrameInteraction other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = tagsToIgnore_;
				RepeatedField<int> repeatedField2 = other.tagsToIgnore_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E1E")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)tagsToIgnore_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E1F")]
		[Cpp2IlInjected.Address(RVA = "0x2875C90", Offset = "0x2874690", VA = "0x182875C90", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E20")]
		[Cpp2IlInjected.Address(RVA = "0x2875CF0", Offset = "0x28746F0", VA = "0x182875CF0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<int> repeatedField = tagsToIgnore_;
			FieldCodec<int> repeated_tagsToIgnore_codec = _repeated_tagsToIgnore_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tagsToIgnore_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E21")]
		[Cpp2IlInjected.Address(RVA = "0x2875350", Offset = "0x2873D50", VA = "0x182875350", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<int> repeatedField = tagsToIgnore_;
			FieldCodec<int> repeated_tagsToIgnore_codec = _repeated_tagsToIgnore_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tagsToIgnore_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E22")]
		[Cpp2IlInjected.Address(RVA = "0x2875BB0", Offset = "0x28745B0", VA = "0x182875BB0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PictureFrameInteraction other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<int> repeatedField = tagsToIgnore_;
				RepeatedField<int> repeatedField2 = other.tagsToIgnore_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E23")]
		[Cpp2IlInjected.Address(RVA = "0x2875AC0", Offset = "0x28744C0", VA = "0x182875AC0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0042
			uint num = input.ReadTag();
			if (num != 0)
			{
				num += 4294967288u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<int> repeatedField = tagsToIgnore_;
				FieldCodec<int> repeated_tagsToIgnore_codec = _repeated_tagsToIgnore_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tagsToIgnore_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E24")]
		[Cpp2IlInjected.Address(RVA = "0x2875710", Offset = "0x2874110", VA = "0x182875710", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = tagsToIgnore_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E25")]
		[Cpp2IlInjected.Address(RVA = "0x2875C30", Offset = "0x2874630", VA = "0x182875C30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E26")]
		[Cpp2IlInjected.Address(RVA = "0x2875400", Offset = "0x2873E00", VA = "0x182875400", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = tagsToIgnore_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E27")]
		[Cpp2IlInjected.Address(RVA = "0x2875790", Offset = "0x2874190", VA = "0x182875790")]
		public IGridStateData GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_004a, IL_0050, IL_0056, IL_005c
			//IL_0041: Expected O, but got I4
			uint num2 = default(uint);
			bool flag = default(bool);
			MemoryShardItemData memoryShardItemData = default(MemoryShardItemData);
			RepeatedField<int> repeatedField;
			int itemID;
			do
			{
				int num = 0;
				PictureFrameGridData pictureFrameGridData = new PictureFrameGridData();
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (!flag)
				{
					break;
				}
				int completedShardFlag = memoryShardItemData.CompletedShardFlag;
				repeatedField = tagsToIgnore_;
				itemID = memoryShardItemData.MemoryShardTagItem.ItemID;
			}
			while (((RepeatedField<T>)(object)repeatedField).Contains((T)itemID));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E28")]
		[Cpp2IlInjected.Address(RVA = "0x2875DB0", Offset = "0x28747B0", VA = "0x182875DB0")]
		static PictureFrameInteraction()
		{
			Func<PictureFrameInteraction> func = default(Func<PictureFrameInteraction>);
			_parser = (MessageParser<PictureFrameInteraction>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<PictureFrameInteraction>)(object)FieldCodec.ForInt32(10u);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E29")]
		[Cpp2IlInjected.Address(RVA = "0x2875590", Offset = "0x2873F90", VA = "0x182875590", Slot = "14")]
		IGridStateData IGridStateDataProvider.GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			return GetGridStateData(in worldProfile, context);
		}
	}
}
