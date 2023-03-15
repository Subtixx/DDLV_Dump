using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000825")]
	public sealed class ConditionWearingClothes : ICondition, IDataValidation, IMessage<ConditionWearingClothes>, IMessage, IEquatable<ConditionWearingClothes>, IDeepCloneable<ConditionWearingClothes>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400287E")]
		private static readonly MessageParser<ConditionWearingClothes> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400287F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002880")]
		public const int ClothesFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002881")]
		private int clothes_;

		[Cpp2IlInjected.Token(Token = "0x4002882")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002883")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x17001712")]
		private Item ClothItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005B30")]
			[Cpp2IlInjected.Address(RVA = "0x24CDA90", Offset = "0x24CC490", VA = "0x1824CDA90")]
			get
			{
				long num = Convert.ToInt64((uint)clothes_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001713")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005B32")]
			[Cpp2IlInjected.Address(RVA = "0x24CDBC0", Offset = "0x24CC5C0", VA = "0x1824CDBC0", Slot = "5")]
			get
			{
				//IL_0025: Expected O, but got I8
				if (!inversed_)
				{
				}
				long num = Convert.ToInt64((uint)clothes_);
				return string.Format("Avatar {0}wearing {1}", "NOT ", num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001714")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005B33")]
			[Cpp2IlInjected.Address(RVA = "0x24CDCB0", Offset = "0x24CC6B0", VA = "0x1824CDCB0", Slot = "6")]
			get
			{
				return ConditionListener.AvatarCustomization;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001715")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionWearingClothes> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005B36")]
			[Cpp2IlInjected.Address(RVA = "0x24CDCC0", Offset = "0x24CC6C0", VA = "0x1824CDCC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001716")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005B37")]
			[Cpp2IlInjected.Address(RVA = "0x24CDAF0", Offset = "0x24CC4F0", VA = "0x1824CDAF0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001717")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005B38")]
			[Cpp2IlInjected.Address(RVA = "0x24CDD20", Offset = "0x24CC720", VA = "0x1824CDD20", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001718")]
		[DebuggerNonUserCode]
		public int Clothes
		{
			[Cpp2IlInjected.Token(Token = "0x6005B3C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return clothes_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B3D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				clothes_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001719")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005B3E")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B3F")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B31")]
		[Cpp2IlInjected.Address(RVA = "0x24CD600", Offset = "0x24CC000", VA = "0x1824CD600")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfilePlayer section = playerProfile.Section;
			int num = clothes_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B34")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B35")]
		[Cpp2IlInjected.Address(RVA = "0x24CD590", Offset = "0x24CBF90", VA = "0x1824CD590", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001a
			if (clothes_ == 0)
			{
				context.AddInvalidMemberError("Please select clothes item", "Item");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B39")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionWearingClothes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005B3A")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionWearingClothes(ConditionWearingClothes other)
		{
			int num = (clothes_ = other.clothes_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005B3B")]
		[Cpp2IlInjected.Address(RVA = "0x24CD500", Offset = "0x24CBF00", VA = "0x1824CD500", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionWearingClothes Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionWearingClothes conditionWearingClothes = new ConditionWearingClothes();
			int num = (conditionWearingClothes.clothes_ = clothes_);
			bool flag = (conditionWearingClothes.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionWearingClothes._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionWearingClothes;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B40")]
		[Cpp2IlInjected.Address(RVA = "0x24CD6D0", Offset = "0x24CC0D0", VA = "0x1824CD6D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)clothes_ == (IntPtr)typeof(ConditionWearingClothes).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionWearingClothes).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B41")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionWearingClothes other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.clothes_;
				if (clothes_ == num)
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

		[Cpp2IlInjected.Token(Token = "0x6005B42")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (clothes_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x6005B43")]
		[Cpp2IlInjected.Address(RVA = "0x24CD920", Offset = "0x24CC320", VA = "0x1824CD920", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B44")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (clothes_ != 0)
			{
				int value = clothes_;
				output.WriteInt32(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B45")]
		[Cpp2IlInjected.Address(RVA = "0x24CD470", Offset = "0x24CBE70", VA = "0x1824CD470", Slot = "12")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = clothes_;
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

		[Cpp2IlInjected.Token(Token = "0x6005B46")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionWearingClothes other)
		{
			if (other != null)
			{
				int num = other.clothes_;
				if (num != 0)
				{
					clothes_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x6005B47")]
		[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (clothes_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B48")]
		[Cpp2IlInjected.Address(RVA = "0x24CD760", Offset = "0x24CC160", VA = "0x1824CD760", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = clothes_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B49")]
		[Cpp2IlInjected.Address(RVA = "0x24CD850", Offset = "0x24CC250", VA = "0x1824CD850", Slot = "17")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				clothes_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B4A")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				clothes_ = 0;
				break;
			case 2:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005B4B")]
		[Cpp2IlInjected.Address(RVA = "0x24CD980", Offset = "0x24CC380", VA = "0x1824CD980")]
		static ConditionWearingClothes()
		{
			Func<ConditionWearingClothes> func = default(Func<ConditionWearingClothes>);
			_parser = (MessageParser<ConditionWearingClothes>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B4C")]
		[Cpp2IlInjected.Address(RVA = "0x24CD600", Offset = "0x24CC000", VA = "0x1824CD600", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfilePlayer section = playerProfile.Section;
			int num = clothes_;
			bool result = default(bool);
			return result;
		}
	}
}
