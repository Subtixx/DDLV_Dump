using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x20007A8")]
	public sealed class ParentEnumOption : IMessage<ParentEnumOption>, IMessage, IEquatable<ParentEnumOption>, IDeepCloneable<ParentEnumOption>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002663")]
		private static readonly MessageParser<ParentEnumOption> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002664")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002665")]
		public const int ChildOptionsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002666")]
		private static readonly FieldCodec<ChildrenEnumOption> _repeated_childOptions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002667")]
		private readonly RepeatedField<ChildrenEnumOption> childOptions_ = (RepeatedField<ChildrenEnumOption>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700155D")]
		[DebuggerNonUserCode]
		public static MessageParser<ParentEnumOption> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600546F")]
			[Cpp2IlInjected.Address(RVA = "0x36A8DF0", Offset = "0x36A77F0", VA = "0x1836A8DF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700155E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005470")]
			[Cpp2IlInjected.Address(RVA = "0x36A8D20", Offset = "0x36A7720", VA = "0x1836A8D20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700155F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005471")]
			[Cpp2IlInjected.Address(RVA = "0x36A8E50", Offset = "0x36A7850", VA = "0x1836A8E50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001560")]
		[DebuggerNonUserCode]
		public RepeatedField<ChildrenEnumOption> ChildOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6005475")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return childOptions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005472")]
		[Cpp2IlInjected.Address(RVA = "0x36A8CA0", Offset = "0x36A76A0", VA = "0x1836A8CA0")]
		[DebuggerNonUserCode]
		public ParentEnumOption()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005473")]
		[Cpp2IlInjected.Address(RVA = "0x36A8BA0", Offset = "0x36A75A0", VA = "0x1836A8BA0")]
		[DebuggerNonUserCode]
		public ParentEnumOption(ParentEnumOption other)
		{
			RepeatedField<ChildrenEnumOption> repeatedField = (childOptions_ = (RepeatedField<ChildrenEnumOption>)(object)((RepeatedField<T>)(object)other.childOptions_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005474")]
		[Cpp2IlInjected.Address(RVA = "0x36A83C0", Offset = "0x36A6DC0", VA = "0x1836A83C0", Slot = "10")]
		[DebuggerNonUserCode]
		public ParentEnumOption Clone()
		{
			//Discarded unreachable code: IL_003b
			ParentEnumOption parentEnumOption = new ParentEnumOption();
			RepeatedField<ChildrenEnumOption> repeatedField = (parentEnumOption.childOptions_ = (RepeatedField<ChildrenEnumOption>)(object)new RepeatedField<T>());
			RepeatedField<ChildrenEnumOption> repeatedField2 = (parentEnumOption.childOptions_ = (RepeatedField<ChildrenEnumOption>)(object)((RepeatedField<T>)(object)childOptions_).Clone());
			UnknownFieldSet unknownFieldSet = (parentEnumOption._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return parentEnumOption;
		}

		[Cpp2IlInjected.Token(Token = "0x6005476")]
		[Cpp2IlInjected.Address(RVA = "0x36A8580", Offset = "0x36A6F80", VA = "0x1836A8580", Slot = "0")]
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
				RepeatedField<ChildrenEnumOption> repeatedField = childOptions_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005477")]
		[Cpp2IlInjected.Address(RVA = "0x36A84F0", Offset = "0x36A6EF0", VA = "0x1836A84F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ParentEnumOption other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<ChildrenEnumOption> repeatedField = childOptions_;
				RepeatedField<ChildrenEnumOption> repeatedField2 = other.childOptions_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005478")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)childOptions_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6005479")]
		[Cpp2IlInjected.Address(RVA = "0x36A88B0", Offset = "0x36A72B0", VA = "0x1836A88B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600547A")]
		[Cpp2IlInjected.Address(RVA = "0x36A8910", Offset = "0x36A7310", VA = "0x1836A8910", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<ChildrenEnumOption> repeatedField = childOptions_;
			FieldCodec<ChildrenEnumOption> repeated_childOptions_codec = _repeated_childOptions_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_childOptions_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600547B")]
		[Cpp2IlInjected.Address(RVA = "0x36A82B0", Offset = "0x36A6CB0", VA = "0x1836A82B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<ChildrenEnumOption> repeatedField = childOptions_;
			FieldCodec<ChildrenEnumOption> repeated_childOptions_codec = _repeated_childOptions_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_childOptions_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600547C")]
		[Cpp2IlInjected.Address(RVA = "0x36A86E0", Offset = "0x36A70E0", VA = "0x1836A86E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ParentEnumOption other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<ChildrenEnumOption> repeatedField = childOptions_;
				RepeatedField<ChildrenEnumOption> repeatedField2 = other.childOptions_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600547D")]
		[Cpp2IlInjected.Address(RVA = "0x36A8760", Offset = "0x36A7160", VA = "0x1836A8760", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<ChildrenEnumOption> repeatedField = childOptions_;
					FieldCodec<ChildrenEnumOption> repeated_childOptions_codec = _repeated_childOptions_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_childOptions_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600547E")]
		[Cpp2IlInjected.Address(RVA = "0x36A8660", Offset = "0x36A7060", VA = "0x1836A8660", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<ChildrenEnumOption> repeatedField = childOptions_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600547F")]
		[Cpp2IlInjected.Address(RVA = "0x36A8850", Offset = "0x36A7250", VA = "0x1836A8850", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6005480")]
		[Cpp2IlInjected.Address(RVA = "0x36A8360", Offset = "0x36A6D60", VA = "0x1836A8360", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<ChildrenEnumOption> repeatedField = childOptions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005481")]
		[Cpp2IlInjected.Address(RVA = "0x36A89D0", Offset = "0x36A73D0", VA = "0x1836A89D0")]
		static ParentEnumOption()
		{
			Func<ParentEnumOption> func = default(Func<ParentEnumOption>);
			_parser = (MessageParser<ParentEnumOption>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<ChildrenEnumOption> parser = ChildrenEnumOption._parser;
			uint num = default(uint);
			_parser = (MessageParser<ParentEnumOption>)(object)FieldCodec.ForMessage<ChildrenEnumOption>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
