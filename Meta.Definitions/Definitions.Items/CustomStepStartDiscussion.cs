using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004A0")]
	public sealed class CustomStepStartDiscussion : IMessage<CustomStepStartDiscussion>, IMessage, IEquatable<CustomStepStartDiscussion>, IDeepCloneable<CustomStepStartDiscussion>, IMessageFieldAccessor, IMessageOneofAccessor, IStepAmount, IStringTag, IProtobufDefaultData, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x20004A1")]
		public enum TargetOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40018CB")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40018CC")]
			CharacterID,
			[Cpp2IlInjected.Token(Token = "0x40018CD")]
			UniverseTagItemID
		}

		[Cpp2IlInjected.Token(Token = "0x40018C0")]
		private static readonly MessageParser<CustomStepStartDiscussion> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40018C1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40018C2")]
		public const int CharacterIDFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40018C3")]
		public const int UniverseTagItemIDFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40018C4")]
		public const int TargetAmountFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40018C5")]
		private StepAmount targetAmount_;

		[Cpp2IlInjected.Token(Token = "0x40018C6")]
		public const int UseDifferentCharacterFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40018C7")]
		private bool useDifferentCharacter_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40018C8")]
		private object target_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40018C9")]
		private TargetOneofCase targetCase_;

		[Cpp2IlInjected.Token(Token = "0x17000E7A")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepStartDiscussion> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60038D1")]
			[Cpp2IlInjected.Address(RVA = "0x3201830", Offset = "0x3200230", VA = "0x183201830")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E7B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60038D2")]
			[Cpp2IlInjected.Address(RVA = "0x3201760", Offset = "0x3200160", VA = "0x183201760")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E7C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60038D3")]
			[Cpp2IlInjected.Address(RVA = "0x3201CB0", Offset = "0x32006B0", VA = "0x183201CB0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E7D")]
		[DebuggerNonUserCode]
		public int CharacterID
		{
			[Cpp2IlInjected.Token(Token = "0x60038D8")]
			[Cpp2IlInjected.Address(RVA = "0x3201640", Offset = "0x3200040", VA = "0x183201640")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (targetCase_ == TargetOneofCase.CharacterID)
				{
					object obj = target_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60038D9")]
			[Cpp2IlInjected.Address(RVA = "0x3201DC0", Offset = "0x32007C0", VA = "0x183201DC0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				target_ = typeof(int).TypeHandle;
				targetCase_ = TargetOneofCase.CharacterID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E7E")]
		[DebuggerNonUserCode]
		public int UniverseTagItemID
		{
			[Cpp2IlInjected.Token(Token = "0x60038DA")]
			[Cpp2IlInjected.Address(RVA = "0x3201AA0", Offset = "0x32004A0", VA = "0x183201AA0")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (targetCase_ == TargetOneofCase.UniverseTagItemID)
				{
					object obj = target_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60038DB")]
			[Cpp2IlInjected.Address(RVA = "0x3201E30", Offset = "0x3200830", VA = "0x183201E30")]
			set
			{
				//IL_0014: Expected I4, but got I8
				target_ = typeof(int).TypeHandle;
				targetCase_ = TargetOneofCase.UniverseTagItemID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E7F")]
		[DebuggerNonUserCode]
		public StepAmount TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60038DC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x60038DD")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E80")]
		[DebuggerNonUserCode]
		public bool UseDifferentCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x60038DE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return useDifferentCharacter_;
			}
			[Cpp2IlInjected.Token(Token = "0x60038DF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				useDifferentCharacter_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E81")]
		[DebuggerNonUserCode]
		public TargetOneofCase TargetCase
		{
			[Cpp2IlInjected.Token(Token = "0x60038E0")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return targetCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E82")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x60038EF")]
			[Cpp2IlInjected.Address(RVA = "0x32016B0", Offset = "0x32000B0", VA = "0x1832016B0")]
			get
			{
				if (targetCase_ == TargetOneofCase.CharacterID)
				{
					object obj = target_;
				}
				long num = Convert.ToInt64(0u);
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E83")]
		public Item UniverseTagItem
		{
			[Cpp2IlInjected.Token(Token = "0x60038F0")]
			[Cpp2IlInjected.Address(RVA = "0x3201B10", Offset = "0x3200510", VA = "0x183201B10")]
			get
			{
				if (targetCase_ == TargetOneofCase.UniverseTagItemID)
				{
					object obj = target_;
				}
				long num = Convert.ToInt64(0u);
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E84")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60038F1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "16")]
			get
			{
				return targetAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E85")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x60038F2")]
			[Cpp2IlInjected.Address(RVA = "0x3201890", Offset = "0x3200290", VA = "0x183201890", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_0079
				string[] array;
				while (true)
				{
					array = new string[4];
					if ("TargetCharacter" != null && "TargetCharacter" == null)
					{
						continue;
					}
					array[0] = "TargetCharacter";
					if ("UniverseTag" != null && "UniverseTag" == null)
					{
						continue;
					}
					array[1] = "UniverseTag";
					if ("TargetAmount" == null || "TargetAmount" != null)
					{
						array[2] = "TargetAmount";
						if ("CurrentAmount" == null || "CurrentAmount" != null)
						{
							break;
						}
					}
				}
				array[3] = "CurrentAmount";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000E86")]
		public bool UseAny
		{
			[Cpp2IlInjected.Token(Token = "0x60038F3")]
			[Cpp2IlInjected.Address(RVA = "0x3201BC0", Offset = "0x32005C0", VA = "0x183201BC0")]
			get
			{
				if (targetCase_ == TargetOneofCase.CharacterID && (object)CharacterItem != null)
				{
					return true;
				}
				if (targetCase_ != TargetOneofCase.UniverseTagItemID)
				{
					int num = 0;
				}
				Item universeTagItem = UniverseTagItem;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038D4")]
		[Cpp2IlInjected.Address(RVA = "0x3201550", Offset = "0x31FFF50", VA = "0x183201550")]
		[DebuggerNonUserCode]
		public CustomStepStartDiscussion()
		{
			//IL_0020: Expected I4, but got I8
			Item invalid = Item.Invalid;
			target_ = typeof(int).TypeHandle;
			targetCase_ = TargetOneofCase.CharacterID;
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038D5")]
		[Cpp2IlInjected.Address(RVA = "0x3200EC0", Offset = "0x31FF8C0", VA = "0x183200EC0")]
		private void OnConstruction()
		{
			//IL_001a: Expected I4, but got I8
			Item invalid = Item.Invalid;
			target_ = typeof(int).TypeHandle;
			targetCase_ = TargetOneofCase.CharacterID;
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038D6")]
		[Cpp2IlInjected.Address(RVA = "0x3201380", Offset = "0x31FFD80", VA = "0x183201380")]
		[DebuggerNonUserCode]
		public CustomStepStartDiscussion(CustomStepStartDiscussion other)
		{
			//IL_0020: Expected I4, but got I8
			//IL_004a: Expected O, but got I4
			//IL_007f: Expected I4, but got I8
			Item invalid = Item.Invalid;
			target_ = typeof(int).TypeHandle;
			targetCase_ = TargetOneofCase.CharacterID;
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			StepAmount stepAmount2 = other.targetAmount_;
			if (stepAmount2 != null)
			{
				StepAmount stepAmount3 = stepAmount2.Clone();
			}
			int num = 0;
			targetAmount_ = (StepAmount)num;
			bool flag = (useDifferentCharacter_ = other.useDifferentCharacter_);
			if (other.targetCase_ == TargetOneofCase.CharacterID)
			{
				int characterID = other.CharacterID;
				target_ = typeof(int).TypeHandle;
				targetCase_ = TargetOneofCase.CharacterID;
			}
			if ((long)typeof(int).TypeHandle == 2)
			{
				int num2 = (UniverseTagItemID = other.UniverseTagItemID);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60038D7")]
		[Cpp2IlInjected.Address(RVA = "0x32003A0", Offset = "0x31FEDA0", VA = "0x1832003A0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepStartDiscussion Clone()
		{
			return new CustomStepStartDiscussion(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60038E1")]
		[Cpp2IlInjected.Address(RVA = "0x17799B0", Offset = "0x17783B0", VA = "0x1817799B0")]
		[DebuggerNonUserCode]
		public void ClearTarget()
		{
			//IL_0010: Expected O, but got I4
			target_ = (targetCase_ = TargetOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038E2")]
		[Cpp2IlInjected.Address(RVA = "0x32004F0", Offset = "0x31FEEF0", VA = "0x1832004F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0033: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				int characterID = CharacterID;
				int num = default(int);
				if (characterID == num)
				{
					int universeTagItemID = UniverseTagItemID;
					int num2 = 0;
					characterID = universeTagItemID;
					int num3 = default(int);
					if (characterID == num3)
					{
						bool flag = object.Equals(targetAmount_, num2);
						if (flag && useDifferentCharacter_ == flag && targetCase_ == (flag ? TargetOneofCase.CharacterID : TargetOneofCase.None))
						{
							return object.Equals(_unknownFields, num2);
						}
					}
				}
			}
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038E3")]
		[Cpp2IlInjected.Address(RVA = "0x32005F0", Offset = "0x31FEFF0", VA = "0x1832005F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepStartDiscussion other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int characterID = CharacterID;
				int characterID2 = other.CharacterID;
				if (characterID == characterID2)
				{
					characterID = UniverseTagItemID;
					int universeTagItemID = other.UniverseTagItemID;
					if (characterID == universeTagItemID)
					{
						StepAmount objB = other.targetAmount_;
						if (object.Equals(targetAmount_, objB))
						{
							bool flag = other.useDifferentCharacter_;
							if (useDifferentCharacter_ == flag)
							{
								TargetOneofCase targetOneofCase = other.targetCase_;
								if (targetCase_ == targetOneofCase)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038E4")]
		[Cpp2IlInjected.Address(RVA = "0x32007D0", Offset = "0x31FF1D0", VA = "0x1832007D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0068
			int num = 0;
			if (targetCase_ == TargetOneofCase.CharacterID)
			{
				if (targetCase_ != TargetOneofCase.CharacterID)
				{
				}
				object obj = target_;
			}
			if (targetCase_ == TargetOneofCase.UniverseTagItemID && targetCase_ == TargetOneofCase.UniverseTagItemID)
			{
				object obj2 = target_;
			}
			StepAmount stepAmount = targetAmount_;
			if (stepAmount != null)
			{
				int hashCode = stepAmount.GetHashCode();
			}
			if (useDifferentCharacter_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60038E5")]
		[Cpp2IlInjected.Address(RVA = "0x3201120", Offset = "0x31FFB20", VA = "0x183201120", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60038E6")]
		[Cpp2IlInjected.Address(RVA = "0x3201180", Offset = "0x31FFB80", VA = "0x183201180", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0073
			TargetOneofCase targetOneofCase = targetCase_;
			if (targetOneofCase == TargetOneofCase.CharacterID)
			{
				int characterID = CharacterID;
				output.WriteInt32(characterID);
			}
			if (targetOneofCase == TargetOneofCase.UniverseTagItemID)
			{
				int universeTagItemID = UniverseTagItemID;
				output.WriteInt32(universeTagItemID);
			}
			if ((long)targetAmount_ != 0)
			{
				StepAmount value = targetAmount_;
				output.WriteMessage(value);
			}
			if (useDifferentCharacter_)
			{
				bool value2 = useDifferentCharacter_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60038E7")]
		[Cpp2IlInjected.Address(RVA = "0x3200140", Offset = "0x31FEB40", VA = "0x183200140", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0084
			int num = 0;
			int num3 = default(int);
			if (targetCase_ == TargetOneofCase.CharacterID)
			{
				if (targetCase_ == TargetOneofCase.CharacterID)
				{
					object obj = target_;
				}
				int num2 = default(int);
				num3 = num2 + 1;
			}
			if (targetCase_ == TargetOneofCase.UniverseTagItemID)
			{
				if (targetCase_ == TargetOneofCase.UniverseTagItemID)
				{
					object obj2 = target_;
				}
				num3++;
				int num4 = default(int);
				num3 += num4;
			}
			StepAmount stepAmount = targetAmount_;
			if (stepAmount != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(stepAmount);
				num5++;
				num3 += num5;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num3 += num6;
			}
			return num3;
		}

		[Cpp2IlInjected.Token(Token = "0x60038E8")]
		[Cpp2IlInjected.Address(RVA = "0x3200DA0", Offset = "0x31FF7A0", VA = "0x183200DA0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepStartDiscussion other)
		{
			//Discarded unreachable code: IL_0098
			if (other == null)
			{
				return;
			}
			if ((long)other.targetAmount_ != 0)
			{
				StepAmount stepAmount = targetAmount_;
				if (stepAmount == null)
				{
					StepAmount stepAmount2 = (targetAmount_ = new StepAmount());
				}
				StepAmount other2 = other.targetAmount_;
				stepAmount.MergeFrom(other2);
			}
			bool flag = other.useDifferentCharacter_;
			if (flag)
			{
				useDifferentCharacter_ = flag;
			}
			int num = default(int);
			if (other.targetCase_ == TargetOneofCase.CharacterID)
			{
				num = (CharacterID = other.CharacterID);
			}
			if (num == 2)
			{
				int num2 = (UniverseTagItemID = other.UniverseTagItemID);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60038E9")]
		[Cpp2IlInjected.Address(RVA = "0x3200C60", Offset = "0x31FF660", VA = "0x183200C60", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0090
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					StepAmount stepAmount = targetAmount_;
					if (stepAmount == null)
					{
						StepAmount stepAmount2 = (targetAmount_ = new StepAmount());
					}
					input.ReadMessage(stepAmount);
				}
				if (num != 32)
				{
					goto IL_0079;
				}
				bool flag = (useDifferentCharacter_ = input.ReadBool());
			}
			int num3 = default(int);
			if (num == 8)
			{
				num3 = (CharacterID = input.ReadInt32());
			}
			if (num3 == 16)
			{
				int num5 = (UniverseTagItemID = input.ReadInt32());
			}
			goto IL_0079;
			IL_0079:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60038EA")]
		[Cpp2IlInjected.Address(RVA = "0x32006B0", Offset = "0x31FF0B0", VA = "0x1832006B0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0031;
						}
						bool flag = useDifferentCharacter_;
					}
					StepAmount stepAmount = targetAmount_;
				}
				int universeTagItemID = UniverseTagItemID;
			}
			int characterID = CharacterID;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038EB")]
		[Cpp2IlInjected.Address(RVA = "0x3200FA0", Offset = "0x31FF9A0", VA = "0x183200FA0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_002d
			//IL_001b: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num == 0 || num == 0)
			{
				return;
			}
			switch (num)
			{
			case 1:
			{
				object obj = default(object);
				useDifferentCharacter_ = (byte)(int)obj != 0;
				break;
			}
			case 0:
				if (value == null || value != null)
				{
					targetAmount_ = (StepAmount)value;
					break;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038EC")]
		[Cpp2IlInjected.Address(RVA = "0x32002F0", Offset = "0x31FECF0", VA = "0x1832002F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_000f
			if (fieldNumber == 1)
			{
				useDifferentCharacter_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038ED")]
		[Cpp2IlInjected.Address(RVA = "0x3200940", Offset = "0x31FF340", VA = "0x183200940", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Target"))
			{
				TargetOneofCase targetOneofCase = targetCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60038EE")]
		[Cpp2IlInjected.Address(RVA = "0x3200330", Offset = "0x31FED30", VA = "0x183200330", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Target"))
			{
				target_ = (targetCase_ = TargetOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038F4")]
		[Cpp2IlInjected.Address(RVA = "0x32009F0", Offset = "0x31FF3F0", VA = "0x1832009F0")]
		public unsafe bool IsValid(Item characterItem)
		{
			if (targetCase_ == TargetOneofCase.CharacterID)
			{
				Item characterItem2 = CharacterItem;
			}
			if (targetCase_ == TargetOneofCase.UniverseTagItemID && (object)UniverseTagItem != null)
			{
				return true;
			}
			TargetOneofCase targetOneofCase = targetCase_;
			if (targetOneofCase != TargetOneofCase.CharacterID)
			{
				if (targetOneofCase != TargetOneofCase.UniverseTagItemID)
				{
					int num = 0;
				}
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				CharacterItemData characterItemData = default(CharacterItemData);
				Item universeTag = characterItemData.GetUniverseTag();
				Item universeTagItem = UniverseTagItem;
				return *(Item*)universeTag == *(Item*)universeTagItem;
			}
			Item characterItem3 = CharacterItem;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60038F5")]
		[Cpp2IlInjected.Address(RVA = "0x2565780", Offset = "0x2564180", VA = "0x182565780", Slot = "18")]
		public void SetDefaultData()
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected I4, but got I8
			targetAmount_.Value.value_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60038F6")]
		[Cpp2IlInjected.Address(RVA = "0x3200400", Offset = "0x31FEE00", VA = "0x183200400", Slot = "19")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_003d
			if (targetCase_ == TargetOneofCase.None)
			{
				context.AddError("Please select a Target (cannot be none)");
			}
			if (useDifferentCharacter_ && targetCase_ == TargetOneofCase.CharacterID)
			{
				Item characterItem = CharacterItem;
				bool flag = default(bool);
				if (flag)
				{
					context.AddError("UseDifferentCharacter must not be used when you select a specific character");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60038F7")]
		[Cpp2IlInjected.Address(RVA = "0x3201270", Offset = "0x31FFC70", VA = "0x183201270")]
		static CustomStepStartDiscussion()
		{
			Func<CustomStepStartDiscussion> func = default(Func<CustomStepStartDiscussion>);
			_parser = (MessageParser<CustomStepStartDiscussion>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
