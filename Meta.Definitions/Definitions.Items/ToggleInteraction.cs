using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002CB")]
	public sealed class ToggleInteraction : IMessage<ToggleInteraction>, IMessage, IEquatable<ToggleInteraction>, IDeepCloneable<ToggleInteraction>, IMessageFieldAccessor, IGridStateDataProvider, IProtobufDefaultData
	{
		[Cpp2IlInjected.Token(Token = "0x20002CC")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20002CD")]
			public enum DefaultValueChoices
			{
				[Cpp2IlInjected.Token(Token = "0x4000C92")]
				[OriginalName("Null")]
				Null,
				[Cpp2IlInjected.Token(Token = "0x4000C93")]
				[OriginalName("False")]
				False,
				[Cpp2IlInjected.Token(Token = "0x4000C94")]
				[OriginalName("True")]
				True
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000C8B")]
		private static readonly MessageParser<ToggleInteraction> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000C8C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000C8D")]
		public const int DefaultValueFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000C8E")]
		private Types.DefaultValueChoices defaultValue_;

		[Cpp2IlInjected.Token(Token = "0x4000C8F")]
		public const int BackToDefaultOnDailyResetFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000C90")]
		private bool backToDefaultOnDailyReset_;

		[Cpp2IlInjected.Token(Token = "0x170006D7")]
		[DebuggerNonUserCode]
		public static MessageParser<ToggleInteraction> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001DF8")]
			[Cpp2IlInjected.Address(RVA = "0x354A990", Offset = "0x3549390", VA = "0x18354A990")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001DF9")]
			[Cpp2IlInjected.Address(RVA = "0x354A8C0", Offset = "0x35492C0", VA = "0x18354A8C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001DFA")]
			[Cpp2IlInjected.Address(RVA = "0x354A9F0", Offset = "0x35493F0", VA = "0x18354A9F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006DA")]
		[DebuggerNonUserCode]
		public Types.DefaultValueChoices DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6001DFE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return defaultValue_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001DFF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				defaultValue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006DB")]
		[DebuggerNonUserCode]
		public bool BackToDefaultOnDailyReset
		{
			[Cpp2IlInjected.Token(Token = "0x6001E00")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return backToDefaultOnDailyReset_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001E01")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				backToDefaultOnDailyReset_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DFB")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ToggleInteraction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001DFC")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ToggleInteraction(ToggleInteraction other)
		{
			Types.DefaultValueChoices defaultValueChoices = (defaultValue_ = other.defaultValue_);
			bool flag = (backToDefaultOnDailyReset_ = other.backToDefaultOnDailyReset_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DFD")]
		[Cpp2IlInjected.Address(RVA = "0x354A370", Offset = "0x3548D70", VA = "0x18354A370", Slot = "10")]
		[DebuggerNonUserCode]
		public ToggleInteraction Clone()
		{
			//Discarded unreachable code: IL_0037
			ToggleInteraction toggleInteraction = new ToggleInteraction();
			Types.DefaultValueChoices defaultValueChoices = (toggleInteraction.defaultValue_ = defaultValue_);
			bool flag = (toggleInteraction.backToDefaultOnDailyReset_ = backToDefaultOnDailyReset_);
			UnknownFieldSet unknownFieldSet = (toggleInteraction._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return toggleInteraction;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E02")]
		[Cpp2IlInjected.Address(RVA = "0x354A470", Offset = "0x3548E70", VA = "0x18354A470", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)defaultValue_ == (IntPtr)typeof(ToggleInteraction).TypeHandle && (IntPtr)(backToDefaultOnDailyReset_ ? 1 : 0) == (IntPtr)typeof(ToggleInteraction).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E03")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ToggleInteraction other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				Types.DefaultValueChoices defaultValueChoices = other.defaultValue_;
				if (defaultValue_ == defaultValueChoices)
				{
					bool flag = other.backToDefaultOnDailyReset_;
					if (backToDefaultOnDailyReset_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E04")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (defaultValue_ != 0)
				{
				}
				if (backToDefaultOnDailyReset_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E05")]
		[Cpp2IlInjected.Address(RVA = "0x354A750", Offset = "0x3549150", VA = "0x18354A750", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E06")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0033
			if (defaultValue_ != 0)
			{
			}
			if (backToDefaultOnDailyReset_)
			{
				bool value = backToDefaultOnDailyReset_;
				output.WriteBool(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E07")]
		[Cpp2IlInjected.Address(RVA = "0x354A2E0", Offset = "0x3548CE0", VA = "0x18354A2E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				Types.DefaultValueChoices defaultValueChoices = defaultValue_;
				num = 0;
				if (defaultValueChoices != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)defaultValueChoices);
					num2++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E08")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ToggleInteraction other)
		{
			if (other != null)
			{
				Types.DefaultValueChoices defaultValueChoices = other.defaultValue_;
				if (defaultValueChoices != 0)
				{
					defaultValue_ = defaultValueChoices;
				}
				bool flag = other.backToDefaultOnDailyReset_;
				if (flag)
				{
					backToDefaultOnDailyReset_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E09")]
		[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(defaultValue_ = (Types.DefaultValueChoices)input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (backToDefaultOnDailyReset_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E0A")]
		[Cpp2IlInjected.Address(RVA = "0x354A590", Offset = "0x3548F90", VA = "0x18354A590", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				Types.DefaultValueChoices defaultValueChoices = defaultValue_;
			}
			if (fieldNumber == 2)
			{
				bool flag = backToDefaultOnDailyReset_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E0B")]
		[Cpp2IlInjected.Address(RVA = "0x354A680", Offset = "0x3549080", VA = "0x18354A680", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				defaultValue_ = (Types.DefaultValueChoices)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			backToDefaultOnDailyReset_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E0C")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				defaultValue_ = Types.DefaultValueChoices.Null;
				break;
			case 2:
				backToDefaultOnDailyReset_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E0D")]
		[Cpp2IlInjected.Address(RVA = "0x354A400", Offset = "0x3548E00", VA = "0x18354A400")]
		public IGridStateData GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			ToggleGridData toggleGridData = new ToggleGridData();
			bool? flag = (toggleGridData.value_ = (bool?)this.GetDefaultValue());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E0E")]
		[Cpp2IlInjected.Address(RVA = "0x3501930", Offset = "0x3500330", VA = "0x183501930", Slot = "15")]
		public void SetDefaultData()
		{
			backToDefaultOnDailyReset_ = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E0F")]
		[Cpp2IlInjected.Address(RVA = "0x354A500", Offset = "0x3548F00", VA = "0x18354A500")]
		internal bool? GetDefaultValue()
		{
			Types.DefaultValueChoices defaultValueChoices = defaultValue_;
			if (defaultValueChoices != 0)
			{
				if (defaultValueChoices != 0)
				{
					if (defaultValueChoices != Types.DefaultValueChoices.False)
					{
						goto IL_0019;
					}
					int num = 0;
				}
				int num2 = 0;
				int num3 = 0;
			}
			goto IL_0019;
			IL_0019:
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E10")]
		[Cpp2IlInjected.Address(RVA = "0x354A7B0", Offset = "0x35491B0", VA = "0x18354A7B0")]
		static ToggleInteraction()
		{
			Func<ToggleInteraction> func = default(Func<ToggleInteraction>);
			_parser = (MessageParser<ToggleInteraction>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E11")]
		[Cpp2IlInjected.Address(RVA = "0x354A400", Offset = "0x3548E00", VA = "0x18354A400", Slot = "14")]
		IGridStateData IGridStateDataProvider.GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			ToggleGridData toggleGridData = new ToggleGridData();
			bool? flag = (toggleGridData.value_ = (bool?)this.GetDefaultValue());
			throw new NullReferenceException();
		}
	}
}
