using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000839")]
	public sealed class ConditionItemInVillage : IMessage<ConditionItemInVillage>, IMessage, IEquatable<ConditionItemInVillage>, IDeepCloneable<ConditionItemInVillage>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40028D7")]
		private static readonly MessageParser<ConditionItemInVillage> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40028D8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40028D9")]
		public const int TargetItemIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40028DA")]
		private int targetItemID_;

		[Cpp2IlInjected.Token(Token = "0x40028DB")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40028DC")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x17001734")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionItemInVillage> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005BF8")]
			[Cpp2IlInjected.Address(RVA = "0x20797B0", Offset = "0x20781B0", VA = "0x1820797B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001735")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005BF9")]
			[Cpp2IlInjected.Address(RVA = "0x20796E0", Offset = "0x20780E0", VA = "0x1820796E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001736")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005BFA")]
			[Cpp2IlInjected.Address(RVA = "0x2079810", Offset = "0x2078210", VA = "0x182079810", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001737")]
		[DebuggerNonUserCode]
		public int TargetItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6005BFE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return targetItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005BFF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				targetItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001738")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005C00")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C01")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005BFB")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionItemInVillage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005BFC")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionItemInVillage(ConditionItemInVillage other)
		{
			int num = (targetItemID_ = other.targetItemID_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005BFD")]
		[Cpp2IlInjected.Address(RVA = "0x2079290", Offset = "0x2077C90", VA = "0x182079290", Slot = "10")]
		[DebuggerNonUserCode]
		public ConditionItemInVillage Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionItemInVillage conditionItemInVillage = new ConditionItemInVillage();
			int num = (conditionItemInVillage.targetItemID_ = targetItemID_);
			bool flag = (conditionItemInVillage.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionItemInVillage._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionItemInVillage;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C02")]
		[Cpp2IlInjected.Address(RVA = "0x2079320", Offset = "0x2077D20", VA = "0x182079320", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)targetItemID_ == (IntPtr)typeof(ConditionItemInVillage).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionItemInVillage).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C03")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionItemInVillage other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.targetItemID_;
				if (targetItemID_ == num)
				{
					bool flag = other.inversed_;
					if (inversed_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C04")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (targetItemID_ != 0)
				{
				}
				if (inversed_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C05")]
		[Cpp2IlInjected.Address(RVA = "0x2079570", Offset = "0x2077F70", VA = "0x182079570", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005C06")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (targetItemID_ != 0)
			{
				int value = targetItemID_;
				output.WriteInt32(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005C07")]
		[Cpp2IlInjected.Address(RVA = "0x2079200", Offset = "0x2077C00", VA = "0x182079200", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = targetItemID_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
					num3++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C08")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionItemInVillage other)
		{
			if (other != null)
			{
				int num = other.targetItemID_;
				if (num != 0)
				{
					targetItemID_ = num;
				}
				bool flag = other.inversed_;
				if (flag)
				{
					inversed_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C09")]
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
					int num2 = (targetItemID_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C0A")]
		[Cpp2IlInjected.Address(RVA = "0x20793B0", Offset = "0x2077DB0", VA = "0x1820793B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = targetItemID_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C0B")]
		[Cpp2IlInjected.Address(RVA = "0x20794A0", Offset = "0x2077EA0", VA = "0x1820794A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				targetItemID_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C0C")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				targetItemID_ = 0;
				break;
			case 2:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C0D")]
		[Cpp2IlInjected.Address(RVA = "0x20795D0", Offset = "0x2077FD0", VA = "0x1820795D0")]
		static ConditionItemInVillage()
		{
			Func<ConditionItemInVillage> func = default(Func<ConditionItemInVillage>);
			_parser = (MessageParser<ConditionItemInVillage>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
