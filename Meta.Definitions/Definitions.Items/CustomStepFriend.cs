using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000460")]
	public sealed class CustomStepFriend : IMessage<CustomStepFriend>, IMessage, IEquatable<CustomStepFriend>, IDeepCloneable<CustomStepFriend>, IMessageFieldAccessor, IMessageOneofAccessor, IStepAmount, IStringTag, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000461")]
		public enum CharacterOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40017B9")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40017BA")]
			Any,
			[Cpp2IlInjected.Token(Token = "0x40017BB")]
			CharacterID
		}

		[Cpp2IlInjected.Token(Token = "0x40017B0")]
		private static readonly MessageParser<CustomStepFriend> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40017B1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40017B2")]
		public const int AnyFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40017B3")]
		public const int CharacterIDFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40017B4")]
		public const int MinimumFriendshipLevelFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40017B5")]
		private int minimumFriendshipLevel_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40017B6")]
		private object character_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40017B7")]
		private CharacterOneofCase characterCase_;

		[Cpp2IlInjected.Token(Token = "0x17000DAF")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepFriend> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60035B8")]
			[Cpp2IlInjected.Address(RVA = "0x34E9320", Offset = "0x34E7D20", VA = "0x1834E9320")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60035B9")]
			[Cpp2IlInjected.Address(RVA = "0x34E9250", Offset = "0x34E7C50", VA = "0x1834E9250")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60035BA")]
			[Cpp2IlInjected.Address(RVA = "0x34E9660", Offset = "0x34E8060", VA = "0x1834E9660", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB2")]
		[DebuggerNonUserCode]
		public CharacterAny Any
		{
			[Cpp2IlInjected.Token(Token = "0x60035BF")]
			[Cpp2IlInjected.Address(RVA = "0x34E90D0", Offset = "0x34E7AD0", VA = "0x1834E90D0")]
			get
			{
				int num = 0;
				if (characterCase_ == CharacterOneofCase.Any)
				{
					object obj = character_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60035C0")]
			[Cpp2IlInjected.Address(RVA = "0x7FE120", Offset = "0x7FCB20", VA = "0x1807FE120")]
			set
			{
				character_ = value;
				bool flag = (byte)(characterCase_ = ((value != null) ? CharacterOneofCase.Any : CharacterOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB3")]
		[DebuggerNonUserCode]
		public int CharacterID
		{
			[Cpp2IlInjected.Token(Token = "0x60035C1")]
			[Cpp2IlInjected.Address(RVA = "0x34E9130", Offset = "0x34E7B30", VA = "0x1834E9130")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (characterCase_ == CharacterOneofCase.CharacterID)
				{
					object obj = character_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x60035C2")]
			[Cpp2IlInjected.Address(RVA = "0x34E9770", Offset = "0x34E8170", VA = "0x1834E9770")]
			set
			{
				//IL_0014: Expected I4, but got I8
				character_ = typeof(int).TypeHandle;
				characterCase_ = CharacterOneofCase.CharacterID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB4")]
		[DebuggerNonUserCode]
		public int MinimumFriendshipLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60035C3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return minimumFriendshipLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x60035C4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				minimumFriendshipLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB5")]
		[DebuggerNonUserCode]
		public CharacterOneofCase CharacterCase
		{
			[Cpp2IlInjected.Token(Token = "0x60035C5")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return characterCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB6")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x60035D4")]
			[Cpp2IlInjected.Address(RVA = "0x34E91A0", Offset = "0x34E7BA0", VA = "0x1834E91A0")]
			get
			{
				if (characterCase_ == CharacterOneofCase.CharacterID)
				{
					object obj = character_;
				}
				long num = Convert.ToInt64(0u);
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB7")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60035D5")]
			[Cpp2IlInjected.Address(RVA = "0x34E9380", Offset = "0x34E7D80", VA = "0x1834E9380", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_001b
				if (characterCase_ != CharacterOneofCase.Any)
				{
					return new StepAmount(1);
				}
				StepAmount result = default(StepAmount);
				if (character_ != null)
				{
					return result;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DB8")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x60035D6")]
			[Cpp2IlInjected.Address(RVA = "0x34E9450", Offset = "0x34E7E50", VA = "0x1834E9450", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_0079
				string[] array;
				while (true)
				{
					array = new string[4];
					if ("TargetName" != null && "TargetName" == null)
					{
						continue;
					}
					array[0] = "TargetName";
					if ("TargetAmount" != null && "TargetAmount" == null)
					{
						continue;
					}
					array[1] = "TargetAmount";
					if ("CurrentAmount" == null || "CurrentAmount" != null)
					{
						array[2] = "CurrentAmount";
						if ("MinimumFriendshipLevel" == null || "MinimumFriendshipLevel" != null)
						{
							break;
						}
					}
				}
				array[3] = "MinimumFriendshipLevel";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035BB")]
		[Cpp2IlInjected.Address(RVA = "0x34E9060", Offset = "0x34E7A60", VA = "0x1834E9060")]
		[DebuggerNonUserCode]
		public CustomStepFriend()
		{
			bool flag = (byte)(characterCase_ = (((character_ = new CharacterAny()) != null) ? CharacterOneofCase.Any : CharacterOneofCase.None)) != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60035BC")]
		[Cpp2IlInjected.Address(RVA = "0x34E8AC0", Offset = "0x34E74C0", VA = "0x1834E8AC0")]
		private void OnConstruction()
		{
			bool flag = (byte)(characterCase_ = (((character_ = new CharacterAny()) != null) ? CharacterOneofCase.Any : CharacterOneofCase.None)) != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60035BD")]
		[Cpp2IlInjected.Address(RVA = "0x34E8F00", Offset = "0x34E7900", VA = "0x1834E8F00")]
		[DebuggerNonUserCode]
		public CustomStepFriend(CustomStepFriend other)
		{
			CharacterAny characterAny = (CharacterAny)(character_ = new CharacterAny());
			int num = 0;
			bool flag = (byte)(characterCase_ = ((characterAny != null) ? CharacterOneofCase.Any : CharacterOneofCase.None)) != 0;
			int num2 = (minimumFriendshipLevel_ = other.minimumFriendshipLevel_);
			CharacterOneofCase characterOneofCase = other.characterCase_;
			if (characterOneofCase == CharacterOneofCase.Any)
			{
				CharacterOneofCase characterOneofCase2 = other.characterCase_;
				if (other.character_ == null)
				{
					throw new InvalidCastException();
				}
				CharacterAny characterAny2 = default(CharacterAny);
				character_ = characterAny2;
				bool flag2 = (byte)(characterCase_ = ((characterAny2 != null) ? CharacterOneofCase.Any : CharacterOneofCase.None)) != 0;
			}
			if (characterOneofCase == CharacterOneofCase.CharacterID)
			{
				int num3 = (CharacterID = other.CharacterID);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035BE")]
		[Cpp2IlInjected.Address(RVA = "0x34E7E80", Offset = "0x34E6880", VA = "0x1834E7E80", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepFriend Clone()
		{
			//Discarded unreachable code: IL_0098
			CustomStepFriend customStepFriend = new CustomStepFriend();
			CharacterAny characterAny = (CharacterAny)(customStepFriend.character_ = new CharacterAny());
			int num = 0;
			bool flag = (byte)(customStepFriend.characterCase_ = ((characterAny != null) ? CharacterOneofCase.Any : CharacterOneofCase.None)) != 0;
			int num2 = (customStepFriend.minimumFriendshipLevel_ = minimumFriendshipLevel_);
			CharacterOneofCase characterOneofCase = characterCase_;
			if (characterOneofCase == CharacterOneofCase.Any)
			{
				CharacterOneofCase characterOneofCase2 = characterCase_;
				if (character_ == null)
				{
					throw new InvalidCastException();
				}
				CharacterAny characterAny2 = default(CharacterAny);
				customStepFriend.character_ = characterAny2;
				bool flag2 = (byte)(customStepFriend.characterCase_ = ((characterAny2 != null) ? CharacterOneofCase.Any : CharacterOneofCase.None)) != 0;
			}
			if (characterOneofCase == CharacterOneofCase.CharacterID)
			{
				int num3 = (customStepFriend.CharacterID = CharacterID);
			}
			UnknownFieldSet unknownFieldSet = (customStepFriend._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepFriend;
		}

		[Cpp2IlInjected.Token(Token = "0x60035C6")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAF0", Offset = "0x7FB4F0", VA = "0x1807FCAF0")]
		[DebuggerNonUserCode]
		public void ClearCharacter()
		{
			//IL_0010: Expected O, but got I4
			character_ = (characterCase_ = CharacterOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60035C7")]
		[Cpp2IlInjected.Address(RVA = "0x34E81B0", Offset = "0x34E6BB0", VA = "0x1834E81B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0079: Expected O, but got I4
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (characterCase_ == CharacterOneofCase.Any)
					{
						object obj = character_;
						if (obj != null && obj == null)
						{
							goto IL_007e;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(CharacterAny).TypeHandle != null && (object)typeof(CharacterAny).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag)
					{
						int characterID = CharacterID;
						int num2 = 0;
						int num3 = default(int);
						if (characterID == num3 && minimumFriendshipLevel_ == num3 && characterCase_ == (CharacterOneofCase)num3)
						{
							bool flag2 = object.Equals(_unknownFields, num2);
						}
					}
				}
			}
			int num4 = 0;
			goto IL_007e;
			IL_007e:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035C8")]
		[Cpp2IlInjected.Address(RVA = "0x34E8310", Offset = "0x34E6D10", VA = "0x1834E8310", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepFriend other)
		{
			//IL_0050: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (characterCase_ == CharacterOneofCase.Any)
				{
					object obj = character_;
					if (obj != null && obj == null)
					{
						goto IL_00a5;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.characterCase_ == CharacterOneofCase.Any)
				{
					obj2 = other.character_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					int characterID = CharacterID;
					int characterID2 = other.CharacterID;
					if (characterID == characterID2)
					{
						int num2 = other.minimumFriendshipLevel_;
						if (minimumFriendshipLevel_ == num2)
						{
							CharacterOneofCase characterOneofCase = other.characterCase_;
							if (characterCase_ == characterOneofCase)
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								bool flag = object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num3 = 0;
			goto IL_00a5;
			IL_00a5:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035C9")]
		[Cpp2IlInjected.Address(RVA = "0x34E8550", Offset = "0x34E6F50", VA = "0x1834E8550", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0055
			CharacterOneofCase characterOneofCase = characterCase_;
			int num = 0;
			if (characterOneofCase == CharacterOneofCase.Any)
			{
				object obj = character_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (characterOneofCase == CharacterOneofCase.CharacterID && characterCase_ == CharacterOneofCase.CharacterID)
			{
				object obj2 = character_;
			}
			if (minimumFriendshipLevel_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60035CA")]
		[Cpp2IlInjected.Address(RVA = "0x34E8C80", Offset = "0x34E7680", VA = "0x1834E8C80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60035CB")]
		[Cpp2IlInjected.Address(RVA = "0x34E8CE0", Offset = "0x34E76E0", VA = "0x1834E8CE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_006d
			//IL_002c: Expected O, but got I4
			CharacterOneofCase characterOneofCase = characterCase_;
			if (characterOneofCase == CharacterOneofCase.Any)
			{
				int num = 0;
				if (characterCase_ == CharacterOneofCase.Any)
				{
					object obj = character_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (characterOneofCase == CharacterOneofCase.CharacterID)
			{
				int characterID = CharacterID;
				output.WriteInt32(characterID);
			}
			if (minimumFriendshipLevel_ != 0)
			{
				int value = minimumFriendshipLevel_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60035CC")]
		[Cpp2IlInjected.Address(RVA = "0x34E7BE0", Offset = "0x34E65E0", VA = "0x1834E7BE0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_008a
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (characterCase_ == CharacterOneofCase.Any)
			{
				if (characterCase_ == CharacterOneofCase.Any)
				{
					object obj = character_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (characterCase_ == CharacterOneofCase.CharacterID)
			{
				if (characterCase_ == CharacterOneofCase.CharacterID)
				{
					object obj2 = character_;
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			int num4 = minimumFriendshipLevel_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num += num5;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60035CD")]
		[Cpp2IlInjected.Address(RVA = "0x34E88D0", Offset = "0x34E72D0", VA = "0x1834E88D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepFriend other)
		{
			if (other == null)
			{
				return;
			}
			int num = other.minimumFriendshipLevel_;
			if (num != 0)
			{
				minimumFriendshipLevel_ = num;
			}
			if (other.characterCase_ == CharacterOneofCase.Any)
			{
				object obj = default(object);
				if (characterCase_ == CharacterOneofCase.Any)
				{
					obj = character_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					bool flag = (byte)(characterCase_ = (((character_ = new CharacterAny()) != null) ? CharacterOneofCase.Any : CharacterOneofCase.None)) != 0;
				}
				if (characterCase_ == CharacterOneofCase.Any)
				{
					object obj2 = character_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.characterCase_ == CharacterOneofCase.Any)
				{
					object obj3 = other.character_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if ((long)typeof(CharacterAny).TypeHandle == 2)
			{
				int num2 = (CharacterID = other.CharacterID);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60035CE")]
		[Cpp2IlInjected.Address(RVA = "0x34E8750", Offset = "0x34E7150", VA = "0x1834E8750", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				CharacterAny characterAny = new CharacterAny();
				if (characterCase_ == CharacterOneofCase.Any)
				{
					if (characterCase_ != CharacterOneofCase.Any)
					{
					}
					object obj = character_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(characterAny);
				character_ = characterAny;
				bool flag = (byte)(characterCase_ = ((characterAny != null) ? CharacterOneofCase.Any : CharacterOneofCase.None)) != 0;
			}
			int num3 = default(int);
			if (num == 16)
			{
				num3 = (CharacterID = input.ReadInt32());
			}
			if (num3 == 24)
			{
				int num4 = (minimumFriendshipLevel_ = input.ReadInt32());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60035CF")]
		[Cpp2IlInjected.Address(RVA = "0x34E8440", Offset = "0x34E6E40", VA = "0x1834E8440", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num != 1)
				{
					ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
					/*Error: Unexpected end of block*/;
				}
				int characterID = CharacterID;
			}
			while (characterCase_ != CharacterOneofCase.Any)
			{
			}
			object obj = character_;
			while (obj == null)
			{
			}
			while (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035D0")]
		[Cpp2IlInjected.Address(RVA = "0x34E8B30", Offset = "0x34E7530", VA = "0x1834E8B30", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0017: Expected I4, but got O
			//IL_002a: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num == 1)
				{
					object obj = default(object);
					minimumFriendshipLevel_ = (int)obj;
				}
				return;
			}
			int num2 = 0;
			if (value == null || value != null)
			{
				character_ = num2;
				bool flag = (byte)(characterCase_ = ((num2 != 0) ? CharacterOneofCase.Any : CharacterOneofCase.None)) != 0;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60035D1")]
		[Cpp2IlInjected.Address(RVA = "0x34E7D70", Offset = "0x34E6770", VA = "0x1834E7D70", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_001f
			//IL_000d: Expected I4, but got I8
			//IL_0015: Expected O, but got I4
			//IL_001e: Expected I4, but got I8
			//IL_0028: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				minimumFriendshipLevel_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035D2")]
		[Cpp2IlInjected.Address(RVA = "0x34E86A0", Offset = "0x34E70A0", VA = "0x1834E86A0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Character"))
			{
				CharacterOneofCase characterOneofCase = characterCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60035D3")]
		[Cpp2IlInjected.Address(RVA = "0x34E7E10", Offset = "0x34E6810", VA = "0x1834E7E10", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Character"))
			{
				character_ = (characterCase_ = CharacterOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035D7")]
		[Cpp2IlInjected.Address(RVA = "0x34E8020", Offset = "0x34E6A20", VA = "0x1834E8020", Slot = "18")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0041
			switch (characterCase_)
			{
			case CharacterOneofCase.CharacterID:
			{
				if (characterCase_ == CharacterOneofCase.CharacterID)
				{
					object obj = character_;
				}
				int num = 0;
				if ((object)typeof(int).TypeHandle != null)
				{
					context.AddError("CharacterID is not valid");
				}
				break;
			}
			case CharacterOneofCase.None:
				context.AddError("Character can't be None");
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60035D8")]
		[Cpp2IlInjected.Address(RVA = "0x34E8DF0", Offset = "0x34E77F0", VA = "0x1834E8DF0")]
		static CustomStepFriend()
		{
			Func<CustomStepFriend> func = default(Func<CustomStepFriend>);
			_parser = (MessageParser<CustomStepFriend>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
