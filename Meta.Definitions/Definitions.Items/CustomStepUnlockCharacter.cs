using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000469")]
	public sealed class CustomStepUnlockCharacter : IMessage<CustomStepUnlockCharacter>, IMessage, IEquatable<CustomStepUnlockCharacter>, IDeepCloneable<CustomStepUnlockCharacter>, IMessageFieldAccessor, IStringTag, ITargetCharacterOverride, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x200046A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x200046B")]
			public enum UnlockType
			{
				[Cpp2IlInjected.Token(Token = "0x40017DF")]
				[OriginalName("UnlockType_Unlocked")]
				Unlocked,
				[Cpp2IlInjected.Token(Token = "0x40017E0")]
				[OriginalName("UnlockType_LockedInVillage")]
				LockedInVillage
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40017D6")]
		private static readonly MessageParser<CustomStepUnlockCharacter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40017D7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40017D8")]
		public const int CharacterFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40017D9")]
		private int character_;

		[Cpp2IlInjected.Token(Token = "0x40017DA")]
		public const int NextStateFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40017DB")]
		private Types.UnlockType nextState_;

		[Cpp2IlInjected.Token(Token = "0x40017DC")]
		public const int SkipCinematicFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40017DD")]
		private bool skipCinematic_;

		[Cpp2IlInjected.Token(Token = "0x17000DCB")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepUnlockCharacter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003622")]
			[Cpp2IlInjected.Address(RVA = "0x355CB90", Offset = "0x355B590", VA = "0x18355CB90")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DCC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003623")]
			[Cpp2IlInjected.Address(RVA = "0x355CAC0", Offset = "0x355B4C0", VA = "0x18355CAC0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DCD")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003624")]
			[Cpp2IlInjected.Address(RVA = "0x355CE20", Offset = "0x355B820", VA = "0x18355CE20", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DCE")]
		[DebuggerNonUserCode]
		public int Character
		{
			[Cpp2IlInjected.Token(Token = "0x6003628")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return character_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003629")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				character_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DCF")]
		[DebuggerNonUserCode]
		public Types.UnlockType NextState
		{
			[Cpp2IlInjected.Token(Token = "0x600362A")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return nextState_;
			}
			[Cpp2IlInjected.Token(Token = "0x600362B")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				nextState_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD0")]
		[DebuggerNonUserCode]
		public bool SkipCinematic
		{
			[Cpp2IlInjected.Token(Token = "0x600362C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return skipCinematic_;
			}
			[Cpp2IlInjected.Token(Token = "0x600362D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				skipCinematic_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD1")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003639")]
			[Cpp2IlInjected.Address(RVA = "0x355CA60", Offset = "0x355B460", VA = "0x18355CA60")]
			get
			{
				long num = Convert.ToInt64((uint)character_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD2")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x600363A")]
			[Cpp2IlInjected.Address(RVA = "0x355CBF0", Offset = "0x355B5F0", VA = "0x18355CBF0", Slot = "14")]
			get
			{
				//Discarded unreachable code: IL_0021
				string[] array;
				do
				{
					array = new string[1];
				}
				while ("TargetCharacter" != null && array == null);
				array[0] = "TargetCharacter";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DD3")]
		public (Item? characterItem, bool random) TargetCharacterOverride
		{
			[Cpp2IlInjected.Token(Token = "0x600363B")]
			[Cpp2IlInjected.Address(RVA = "0x355CCB0", Offset = "0x355B6B0", VA = "0x18355CCB0", Slot = "15")]
			get
			{
				if ((object)typeof(Item).TypeHandle == null)
				{
				}
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003625")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CustomStepUnlockCharacter()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			DataValidation((DataValidation.Context)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6003626")]
		[Cpp2IlInjected.Address(RVA = "0x75C320", Offset = "0x75AD20", VA = "0x18075C320")]
		[DebuggerNonUserCode]
		public CustomStepUnlockCharacter(CustomStepUnlockCharacter other)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			DataValidation((DataValidation.Context)num);
			int num2 = (character_ = other.character_);
			Types.UnlockType unlockType = (nextState_ = other.nextState_);
			bool flag = (skipCinematic_ = other.skipCinematic_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003627")]
		[Cpp2IlInjected.Address(RVA = "0x355C2D0", Offset = "0x355ACD0", VA = "0x18355C2D0", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepUnlockCharacter Clone()
		{
			//Discarded unreachable code: IL_004c
			//IL_0009: Expected O, but got I4
			int num = 0;
			CustomStepUnlockCharacter customStepUnlockCharacter = default(CustomStepUnlockCharacter);
			customStepUnlockCharacter.DataValidation((DataValidation.Context)num);
			int num2 = (customStepUnlockCharacter.character_ = character_);
			Types.UnlockType unlockType = (customStepUnlockCharacter.nextState_ = nextState_);
			bool flag = (customStepUnlockCharacter.skipCinematic_ = skipCinematic_);
			UnknownFieldSet unknownFieldSet = (customStepUnlockCharacter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepUnlockCharacter;
		}

		[Cpp2IlInjected.Token(Token = "0x600362E")]
		[Cpp2IlInjected.Address(RVA = "0x355C360", Offset = "0x355AD60", VA = "0x18355C360", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)character_ == (IntPtr)typeof(CustomStepUnlockCharacter).TypeHandle && (IntPtr)(void*)(int)nextState_ == (IntPtr)typeof(CustomStepUnlockCharacter).TypeHandle && (IntPtr)(skipCinematic_ ? 1 : 0) == (IntPtr)typeof(CustomStepUnlockCharacter).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600362F")]
		[Cpp2IlInjected.Address(RVA = "0x75BC40", Offset = "0x75A640", VA = "0x18075BC40", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepUnlockCharacter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.character_;
				if (character_ == num)
				{
					Types.UnlockType unlockType = other.nextState_;
					if (nextState_ == unlockType)
					{
						bool flag = other.skipCinematic_;
						if (skipCinematic_ == flag)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003630")]
		[Cpp2IlInjected.Address(RVA = "0x1E0EC90", Offset = "0x1E0D690", VA = "0x181E0EC90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				int num = 0;
				if (character_ != 0)
				{
				}
				if (nextState_ != 0)
				{
				}
				if (skipCinematic_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003631")]
		[Cpp2IlInjected.Address(RVA = "0x355C8F0", Offset = "0x355B2F0", VA = "0x18355C8F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003632")]
		[Cpp2IlInjected.Address(RVA = "0x75C160", Offset = "0x75AB60", VA = "0x18075C160", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_004a
			if (character_ != 0)
			{
				int value = character_;
				output.WriteInt32(value);
			}
			if (nextState_ != 0)
			{
			}
			if (skipCinematic_)
			{
				bool value2 = skipCinematic_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003633")]
		[Cpp2IlInjected.Address(RVA = "0x355C200", Offset = "0x355AC00", VA = "0x18355C200", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = character_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				Types.UnlockType unlockType = nextState_;
				if (unlockType != 0)
				{
					int num4 = CodedOutputStream.ComputeEnumSize((int)unlockType);
					num4++;
					num2 += num4;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num5 = unknownFields.CalculateSize();
			return num5 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003634")]
		[Cpp2IlInjected.Address(RVA = "0x75BEC0", Offset = "0x75A8C0", VA = "0x18075BEC0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepUnlockCharacter other)
		{
			if (other != null)
			{
				int num = other.character_;
				if (num != 0)
				{
					character_ = num;
				}
				Types.UnlockType unlockType = other.nextState_;
				if (unlockType != 0)
				{
					nextState_ = unlockType;
				}
				bool flag = other.skipCinematic_;
				if (flag)
				{
					skipCinematic_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003635")]
		[Cpp2IlInjected.Address(RVA = "0x75BF30", Offset = "0x75A930", VA = "0x18075BF30", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (character_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 16)
				{
					num3 = (int)(nextState_ = (Types.UnlockType)input.ReadInt32());
				}
				if (num3 == 24)
				{
					bool flag = (skipCinematic_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003636")]
		[Cpp2IlInjected.Address(RVA = "0x355C400", Offset = "0x355AE00", VA = "0x18355C400", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0 && num != 0)
			{
				if (num != 1)
				{
					goto IL_001e;
				}
				bool flag = skipCinematic_;
			}
			int num2 = character_;
			goto IL_001e;
			IL_001e:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003637")]
		[Cpp2IlInjected.Address(RVA = "0x355C7D0", Offset = "0x355B1D0", VA = "0x18355C7D0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028, IL_002e, IL_0034
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					skipCinematic_ = (byte)(int)obj2 != 0;
					break;
				}
				case 0:
				{
					object obj = default(object);
					nextState_ = (Types.UnlockType)obj;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				character_ = (int)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003638")]
		[Cpp2IlInjected.Address(RVA = "0x75BB80", Offset = "0x75A580", VA = "0x18075BB80", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0016
			//IL_0015: Expected I4, but got I8
			//IL_001f: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				skipCinematic_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600363C")]
		[Cpp2IlInjected.Address(RVA = "0x355C650", Offset = "0x355B050", VA = "0x18355C650")]
		public bool IsTargetCharacter(MissionItemData missionData, Item characterItem)
		{
			//Discarded unreachable code: IL_0023
			//IL_0023: Expected I4, but got O
			int num = character_;
			if ((object)typeof(Item).TypeHandle != null)
			{
				int ownerCharacter = missionData.OwnerCharacter;
			}
			int num2 = character_;
			return (byte)(int)typeof(Item).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600363D")]
		[Cpp2IlInjected.Address(RVA = "0x355C510", Offset = "0x355AF10", VA = "0x18355C510")]
		public Item GetTargetCharacter(MissionItemData missionData)
		{
			int num = character_;
			if ((object)typeof(Item).TypeHandle != null)
			{
				int ownerCharacter = missionData.OwnerCharacter;
			}
			long num2 = Convert.ToInt64((uint)character_);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600363E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600363F")]
		[Cpp2IlInjected.Address(RVA = "0x355C950", Offset = "0x355B350", VA = "0x18355C950")]
		static CustomStepUnlockCharacter()
		{
			Func<CustomStepUnlockCharacter> func = default(Func<CustomStepUnlockCharacter>);
			_parser = (MessageParser<CustomStepUnlockCharacter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
