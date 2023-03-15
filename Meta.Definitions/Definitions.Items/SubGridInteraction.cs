using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002C3")]
	public sealed class SubGridInteraction : IMessage<SubGridInteraction>, IMessage, IEquatable<SubGridInteraction>, IDeepCloneable<SubGridInteraction>, IMessageFieldAccessor, IGridStateDataProvider
	{
		[Cpp2IlInjected.Token(Token = "0x4000C75")]
		private static readonly MessageParser<SubGridInteraction> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000C76")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000C77")]
		public const int SubGridDataPathFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000C78")]
		private string subGridDataPath_ = "";

		[Cpp2IlInjected.Token(Token = "0x170006C6")]
		[DebuggerNonUserCode]
		public static MessageParser<SubGridInteraction> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001D94")]
			[Cpp2IlInjected.Address(RVA = "0x2557BA0", Offset = "0x25565A0", VA = "0x182557BA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001D95")]
			[Cpp2IlInjected.Address(RVA = "0x2557AD0", Offset = "0x25564D0", VA = "0x182557AD0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001D96")]
			[Cpp2IlInjected.Address(RVA = "0x2557C00", Offset = "0x2556600", VA = "0x182557C00", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006C9")]
		[DebuggerNonUserCode]
		public string SubGridDataPath
		{
			[Cpp2IlInjected.Token(Token = "0x6001D9A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return subGridDataPath_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D9B")]
			[Cpp2IlInjected.Address(RVA = "0x2557D10", Offset = "0x2556710", VA = "0x182557D10")]
			set
			{
				string text = (subGridDataPath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D97")]
		[Cpp2IlInjected.Address(RVA = "0x25579E0", Offset = "0x25563E0", VA = "0x1825579E0")]
		[DebuggerNonUserCode]
		public SubGridInteraction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001D98")]
		[Cpp2IlInjected.Address(RVA = "0x2557A30", Offset = "0x2556430", VA = "0x182557A30")]
		[DebuggerNonUserCode]
		public SubGridInteraction(SubGridInteraction other)
		{
			string text = (subGridDataPath_ = other.subGridDataPath_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D99")]
		[Cpp2IlInjected.Address(RVA = "0x25573F0", Offset = "0x2555DF0", VA = "0x1825573F0", Slot = "10")]
		[DebuggerNonUserCode]
		public SubGridInteraction Clone()
		{
			//Discarded unreachable code: IL_0034
			SubGridInteraction subGridInteraction = new SubGridInteraction();
			subGridInteraction.subGridDataPath_ = "";
			string text = (subGridInteraction.subGridDataPath_ = subGridDataPath_);
			UnknownFieldSet unknownFieldSet = (subGridInteraction._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return subGridInteraction;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D9C")]
		[Cpp2IlInjected.Address(RVA = "0x2557590", Offset = "0x2555F90", VA = "0x182557590", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = subGridDataPath_;
				bool flag = default(bool);
				if (!flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D9D")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SubGridInteraction other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.subGridDataPath_;
				if (!(subGridDataPath_ != text))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D9E")]
		[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002b
			string text = subGridDataPath_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D9F")]
		[Cpp2IlInjected.Address(RVA = "0x2557870", Offset = "0x2556270", VA = "0x182557870", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DA0")]
		[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002f
			if (subGridDataPath_.m_stringLength != 0)
			{
				string value = subGridDataPath_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DA1")]
		[Cpp2IlInjected.Address(RVA = "0x25572C0", Offset = "0x2555CC0", VA = "0x1825572C0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0033
			string text = subGridDataPath_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DA2")]
		[Cpp2IlInjected.Address(RVA = "0x2557750", Offset = "0x2556150", VA = "0x182557750", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SubGridInteraction other)
		{
			//Discarded unreachable code: IL_0037
			if (other != null)
			{
				string text = other.subGridDataPath_;
				if (text.m_stringLength != 0)
				{
					SubGridDataPath = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DA3")]
		[Cpp2IlInjected.Address(RVA = "0x25576C0", Offset = "0x25560C0", VA = "0x1825576C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0035
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (SubGridDataPath = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DA4")]
		[Cpp2IlInjected.Address(RVA = "0x2557640", Offset = "0x2556040", VA = "0x182557640", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = subGridDataPath_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DA5")]
		[Cpp2IlInjected.Address(RVA = "0x25577B0", Offset = "0x25561B0", VA = "0x1825577B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0019: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				string text = (subGridDataPath_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DA6")]
		[Cpp2IlInjected.Address(RVA = "0x2557360", Offset = "0x2555D60", VA = "0x182557360", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (subGridDataPath_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DA7")]
		[Cpp2IlInjected.Address(RVA = "0x25574B0", Offset = "0x2555EB0", VA = "0x1825574B0")]
		public IGridStateData GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			//IL_002e: Expected I4, but got O
			string text = subGridDataPath_;
			int num = 0;
			if ((object)typeof(SubGrid).TypeHandle == null)
			{
				SubGrid subGrid = new SubGrid();
				if (worldProfile.Section != null)
				{
					IProfileWorld section = worldProfile.Section;
					subGrid.gridID_ = (uint)(int)section;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DA8")]
		[Cpp2IlInjected.Address(RVA = "0x25578D0", Offset = "0x25562D0", VA = "0x1825578D0")]
		static SubGridInteraction()
		{
			Func<SubGridInteraction> func = default(Func<SubGridInteraction>);
			_parser = (MessageParser<SubGridInteraction>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DA9")]
		[Cpp2IlInjected.Address(RVA = "0x25574B0", Offset = "0x2555EB0", VA = "0x1825574B0", Slot = "14")]
		IGridStateData IGridStateDataProvider.GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			//IL_002e: Expected I4, but got O
			string text = subGridDataPath_;
			int num = 0;
			if ((object)typeof(SubGrid).TypeHandle == null)
			{
				SubGrid subGrid = new SubGrid();
				if (worldProfile.Section != null)
				{
					IProfileWorld section = worldProfile.Section;
					subGrid.gridID_ = (uint)(int)section;
				}
			}
			throw new NullReferenceException();
		}
	}
}
