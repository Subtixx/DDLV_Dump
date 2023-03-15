using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Keyholes;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002C7")]
	public sealed class KeyholeInteraction : IMessage<KeyholeInteraction>, IMessage, IEquatable<KeyholeInteraction>, IDeepCloneable<KeyholeInteraction>, IMessageFieldAccessor, IGridStateDataProvider, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4000C81")]
		private static readonly MessageParser<KeyholeInteraction> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000C82")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000C83")]
		public const int KeyholeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000C84")]
		private string keyhole_ = "";

		[Cpp2IlInjected.Token(Token = "0x170006CF")]
		[DebuggerNonUserCode]
		public static MessageParser<KeyholeInteraction> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001DC6")]
			[Cpp2IlInjected.Address(RVA = "0x273EED0", Offset = "0x273D8D0", VA = "0x18273EED0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001DC7")]
			[Cpp2IlInjected.Address(RVA = "0x273EE00", Offset = "0x273D800", VA = "0x18273EE00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001DC8")]
			[Cpp2IlInjected.Address(RVA = "0x273EF30", Offset = "0x273D930", VA = "0x18273EF30", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D2")]
		[DebuggerNonUserCode]
		public string Keyhole
		{
			[Cpp2IlInjected.Token(Token = "0x6001DCC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return keyhole_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001DCD")]
			[Cpp2IlInjected.Address(RVA = "0x273F040", Offset = "0x273DA40", VA = "0x18273F040")]
			set
			{
				string text = (keyhole_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DC9")]
		[Cpp2IlInjected.Address(RVA = "0x273ED10", Offset = "0x273D710", VA = "0x18273ED10")]
		[DebuggerNonUserCode]
		public KeyholeInteraction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001DCA")]
		[Cpp2IlInjected.Address(RVA = "0x273ED60", Offset = "0x273D760", VA = "0x18273ED60")]
		[DebuggerNonUserCode]
		public KeyholeInteraction(KeyholeInteraction other)
		{
			string text = (keyhole_ = other.keyhole_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DCB")]
		[Cpp2IlInjected.Address(RVA = "0x273E440", Offset = "0x273CE40", VA = "0x18273E440", Slot = "10")]
		[DebuggerNonUserCode]
		public KeyholeInteraction Clone()
		{
			//Discarded unreachable code: IL_0034
			KeyholeInteraction keyholeInteraction = new KeyholeInteraction();
			keyholeInteraction.keyhole_ = "";
			string text = (keyholeInteraction.keyhole_ = keyhole_);
			UnknownFieldSet unknownFieldSet = (keyholeInteraction._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return keyholeInteraction;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DCE")]
		[Cpp2IlInjected.Address(RVA = "0x273E8C0", Offset = "0x273D2C0", VA = "0x18273E8C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = keyhole_;
				bool flag = default(bool);
				if (!flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DCF")]
		[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(KeyholeInteraction other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.keyhole_;
				if (!(keyhole_ != text))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD0")]
		[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002b
			string text = keyhole_;
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

		[Cpp2IlInjected.Token(Token = "0x6001DD1")]
		[Cpp2IlInjected.Address(RVA = "0x273EBA0", Offset = "0x273D5A0", VA = "0x18273EBA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD2")]
		[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002f
			if (keyhole_.m_stringLength != 0)
			{
				string value = keyhole_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD3")]
		[Cpp2IlInjected.Address(RVA = "0x273E310", Offset = "0x273CD10", VA = "0x18273E310", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0033
			string text = keyhole_;
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

		[Cpp2IlInjected.Token(Token = "0x6001DD4")]
		[Cpp2IlInjected.Address(RVA = "0x273E9F0", Offset = "0x273D3F0", VA = "0x18273E9F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(KeyholeInteraction other)
		{
			//Discarded unreachable code: IL_0037
			if (other != null)
			{
				string text = other.keyhole_;
				if (text.m_stringLength != 0)
				{
					Keyhole = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD5")]
		[Cpp2IlInjected.Address(RVA = "0x273EA50", Offset = "0x273D450", VA = "0x18273EA50", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0035
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (Keyhole = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD6")]
		[Cpp2IlInjected.Address(RVA = "0x273E970", Offset = "0x273D370", VA = "0x18273E970", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = keyhole_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD7")]
		[Cpp2IlInjected.Address(RVA = "0x273EAE0", Offset = "0x273D4E0", VA = "0x18273EAE0", Slot = "12")]
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
				string text = (keyhole_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD8")]
		[Cpp2IlInjected.Address(RVA = "0x273E3B0", Offset = "0x273CDB0", VA = "0x18273E3B0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (keyhole_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001DD9")]
		[Cpp2IlInjected.Address(RVA = "0x273E7A0", Offset = "0x273D1A0", VA = "0x18273E7A0")]
		public unsafe IGridStateData GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			string text = keyhole_;
			int num = 0;
			if ((object)typeof(KeyholeGridData).TypeHandle == null)
			{
				KeyholeGridData keyholeGridData = default(KeyholeGridData);
				keyholeGridData.keyholeConfigDataGUID_ = "";
				int num2 = 0;
				keyholeGridData.Deinitialize(in *(WorldProfile*)num2);
				if (worldProfile.Section != null)
				{
					IProfileWorld section = worldProfile.Section;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DDA")]
		[Cpp2IlInjected.Address(RVA = "0x273E500", Offset = "0x273CF00", VA = "0x18273E500", Slot = "15")]
		public void DataValidation(DataValidation.Context context)
		{
			string text = keyhole_;
			if ("Keyhole cannot be empty/none" == null)
			{
				string guid = keyhole_;
				KeyholeConfig._003C_003Ec__DisplayClass51_0 CS_0024_003C_003E8__locals0 = new KeyholeConfig._003C_003Ec__DisplayClass51_0();
				CS_0024_003C_003E8__locals0.guid = guid;
				IEnumerable<> enumerable = ProtoDatabase.Instance.Enumerate<KeyholeConfig>();
				Func<KeyholeConfig, bool> func = (Func<KeyholeConfig, bool>)(object)(Func<T, TResult>)delegate(KeyholeConfig x)
				{
					//Discarded unreachable code: IL_0014
					string guid2 = CS_0024_003C_003E8__locals0.guid;
					return string.Equals(x.gUID_, guid2);
				};
				if (Enumerable.FirstOrDefault<KeyholeConfig>(enumerable, (Func<, >)(object)func) == null)
				{
					string text2 = keyhole_;
					string error = "Keyhole value is invalid. Did you delete keyhole config from protodabase ? (value: " + text2 + ")";
					context.AddError(error);
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001DDB")]
		[Cpp2IlInjected.Address(RVA = "0x273EC00", Offset = "0x273D600", VA = "0x18273EC00")]
		static KeyholeInteraction()
		{
			Func<KeyholeInteraction> func = default(Func<KeyholeInteraction>);
			_parser = (MessageParser<KeyholeInteraction>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001DDC")]
		[Cpp2IlInjected.Address(RVA = "0x273E7A0", Offset = "0x273D1A0", VA = "0x18273E7A0", Slot = "14")]
		unsafe IGridStateData IGridStateDataProvider.GetGridStateData(in WorldProfile worldProfile, ITransactionContext context)
		{
			string text = keyhole_;
			int num = 0;
			if ((object)typeof(KeyholeGridData).TypeHandle == null)
			{
				KeyholeGridData keyholeGridData = default(KeyholeGridData);
				keyholeGridData.keyholeConfigDataGUID_ = "";
				int num2 = 0;
				keyholeGridData.Deinitialize(in *(WorldProfile*)num2);
				if (worldProfile.Section != null)
				{
					IProfileWorld section = worldProfile.Section;
				}
			}
			throw new NullReferenceException();
		}
	}
}
