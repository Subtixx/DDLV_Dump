using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000DE8")]
	public sealed class ProfileConditionalUpdateList : IMessage<ProfileConditionalUpdateList>, IMessage, IEquatable<ProfileConditionalUpdateList>, IDeepCloneable<ProfileConditionalUpdateList>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4003845")]
		private static readonly MessageParser<ProfileConditionalUpdateList> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003846")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4003847")]
		public const int ActionsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4003848")]
		private static readonly FieldCodec<string> _repeated_actions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003849")]
		private readonly RepeatedField<string> actions_ = (RepeatedField<string>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17001413")]
		[DebuggerNonUserCode]
		public static MessageParser<ProfileConditionalUpdateList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6007418")]
			[Cpp2IlInjected.Address(RVA = "0x94F380", Offset = "0x94DD80", VA = "0x18094F380")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001414")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007419")]
			[Cpp2IlInjected.Address(RVA = "0x94F2B0", Offset = "0x94DCB0", VA = "0x18094F2B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001415")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600741A")]
			[Cpp2IlInjected.Address(RVA = "0x94F3E0", Offset = "0x94DDE0", VA = "0x18094F3E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001416")]
		[DebuggerNonUserCode]
		public RepeatedField<string> Actions
		{
			[Cpp2IlInjected.Token(Token = "0x600741E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return actions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600741B")]
		[Cpp2IlInjected.Address(RVA = "0x94F230", Offset = "0x94DC30", VA = "0x18094F230")]
		[DebuggerNonUserCode]
		public ProfileConditionalUpdateList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600741C")]
		[Cpp2IlInjected.Address(RVA = "0x94F130", Offset = "0x94DB30", VA = "0x18094F130")]
		[DebuggerNonUserCode]
		public ProfileConditionalUpdateList(ProfileConditionalUpdateList other)
		{
			RepeatedField<string> repeatedField = (actions_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.actions_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600741D")]
		[Cpp2IlInjected.Address(RVA = "0x94E7B0", Offset = "0x94D1B0", VA = "0x18094E7B0", Slot = "10")]
		[DebuggerNonUserCode]
		public ProfileConditionalUpdateList Clone()
		{
			//Discarded unreachable code: IL_003b
			ProfileConditionalUpdateList profileConditionalUpdateList = new ProfileConditionalUpdateList();
			RepeatedField<string> repeatedField = (profileConditionalUpdateList.actions_ = (RepeatedField<string>)(object)new RepeatedField<T>());
			RepeatedField<string> repeatedField2 = (profileConditionalUpdateList.actions_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)actions_).Clone());
			UnknownFieldSet unknownFieldSet = (profileConditionalUpdateList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return profileConditionalUpdateList;
		}

		[Cpp2IlInjected.Token(Token = "0x600741F")]
		[Cpp2IlInjected.Address(RVA = "0x94EA30", Offset = "0x94D430", VA = "0x18094EA30", Slot = "0")]
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
				RepeatedField<string> repeatedField = actions_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007420")]
		[Cpp2IlInjected.Address(RVA = "0x94EB10", Offset = "0x94D510", VA = "0x18094EB10", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ProfileConditionalUpdateList other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<string> repeatedField = actions_;
				RepeatedField<string> repeatedField2 = other.actions_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007421")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)actions_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6007422")]
		[Cpp2IlInjected.Address(RVA = "0x94EED0", Offset = "0x94D8D0", VA = "0x18094EED0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6007423")]
		[Cpp2IlInjected.Address(RVA = "0x94EF30", Offset = "0x94D930", VA = "0x18094EF30", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<string> repeatedField = actions_;
			FieldCodec<string> repeated_actions_codec = _repeated_actions_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_actions_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6007424")]
		[Cpp2IlInjected.Address(RVA = "0x94E6A0", Offset = "0x94D0A0", VA = "0x18094E6A0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<string> repeatedField = actions_;
			FieldCodec<string> repeated_actions_codec = _repeated_actions_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_actions_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6007425")]
		[Cpp2IlInjected.Address(RVA = "0x94ED00", Offset = "0x94D700", VA = "0x18094ED00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ProfileConditionalUpdateList other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<string> repeatedField = actions_;
				RepeatedField<string> repeatedField2 = other.actions_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007426")]
		[Cpp2IlInjected.Address(RVA = "0x94ED80", Offset = "0x94D780", VA = "0x18094ED80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<string> repeatedField = actions_;
					FieldCodec<string> repeated_actions_codec = _repeated_actions_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_actions_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007427")]
		[Cpp2IlInjected.Address(RVA = "0x94EC10", Offset = "0x94D610", VA = "0x18094EC10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<string> repeatedField = actions_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6007428")]
		[Cpp2IlInjected.Address(RVA = "0x94EE70", Offset = "0x94D870", VA = "0x18094EE70", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6007429")]
		[Cpp2IlInjected.Address(RVA = "0x94E750", Offset = "0x94D150", VA = "0x18094E750", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<string> repeatedField = actions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600742A")]
		[Cpp2IlInjected.Address(RVA = "0x94E8E0", Offset = "0x94D2E0", VA = "0x18094E8E0", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0043
			int num = Enumerable.Count<string>(Enumerable.Distinct<string>((IEnumerable<>)(object)actions_));
			int count = ((RepeatedField<T>)(object)actions_).Count;
			if (num < count)
			{
				context.AddError("Cannot have duplicated entry");
			}
			_003CGetLeafActions_003Ed__30 _003CGetLeafActions_003Ed__ = new _003CGetLeafActions_003Ed__30(-2);
			_003CGetLeafActions_003Ed__._003C_003E4__this = this;
			ConditionalActions.DataValidationForLeafActions((IEnumerable<>)(object)_003CGetLeafActions_003Ed__, context);
		}

		[Cpp2IlInjected.Token(Token = "0x600742B")]
		[Cpp2IlInjected.Address(RVA = "0x94EBA0", Offset = "0x94D5A0", VA = "0x18094EBA0")]
		[IteratorStateMachine(typeof(_003CGetConditionalActions_003Ed__29))]
		public IEnumerable<(ConditionalActions, string)> GetConditionalActions()
		{
			new _003CGetConditionalActions_003Ed__29(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600742C")]
		[Cpp2IlInjected.Address(RVA = "0x94EC90", Offset = "0x94D690", VA = "0x18094EC90")]
		[IteratorStateMachine(typeof(_003CGetLeafActions_003Ed__30))]
		public IEnumerable<IAction> GetLeafActions()
		{
			new _003CGetLeafActions_003Ed__30(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600742D")]
		[Cpp2IlInjected.Address(RVA = "0x94EFF0", Offset = "0x94D9F0", VA = "0x18094EFF0")]
		static ProfileConditionalUpdateList()
		{
			Func<ProfileConditionalUpdateList> func = default(Func<ProfileConditionalUpdateList>);
			_parser = (MessageParser<ProfileConditionalUpdateList>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<ProfileConditionalUpdateList>)(object)FieldCodec.ForString(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
