using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004C6")]
	public sealed class HangoutWithCharacter : IMessage<HangoutWithCharacter>, IMessage, IEquatable<HangoutWithCharacter>, IDeepCloneable<HangoutWithCharacter>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20004C7")]
		public enum WithOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001994")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001995")]
			Character,
			[Cpp2IlInjected.Token(Token = "0x4001996")]
			Universe,
			[Cpp2IlInjected.Token(Token = "0x4001997")]
			Profession
		}

		[Cpp2IlInjected.Token(Token = "0x400198C")]
		private static readonly MessageParser<HangoutWithCharacter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400198D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400198E")]
		public const int CharacterFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400198F")]
		public const int UniverseFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4001990")]
		public const int ProfessionFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001991")]
		private object with_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001992")]
		private WithOneofCase withCase_;

		[Cpp2IlInjected.Token(Token = "0x17000F09")]
		[DebuggerNonUserCode]
		public static MessageParser<HangoutWithCharacter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003AC9")]
			[Cpp2IlInjected.Address(RVA = "0x2F9E680", Offset = "0x2F9D080", VA = "0x182F9E680")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F0A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003ACA")]
			[Cpp2IlInjected.Address(RVA = "0x2F9E5B0", Offset = "0x2F9CFB0", VA = "0x182F9E5B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F0B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003ACB")]
			[Cpp2IlInjected.Address(RVA = "0x2F9E920", Offset = "0x2F9D320", VA = "0x182F9E920", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F0C")]
		[DebuggerNonUserCode]
		public int Character
		{
			[Cpp2IlInjected.Token(Token = "0x6003ACF")]
			[Cpp2IlInjected.Address(RVA = "0x2F9E540", Offset = "0x2F9CF40", VA = "0x182F9E540")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (withCase_ == WithOneofCase.Character)
				{
					object obj = with_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6003AD0")]
			[Cpp2IlInjected.Address(RVA = "0x2F9EA30", Offset = "0x2F9D430", VA = "0x182F9EA30")]
			set
			{
				//IL_0014: Expected I4, but got I8
				with_ = typeof(int).TypeHandle;
				withCase_ = WithOneofCase.Character;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F0D")]
		[DebuggerNonUserCode]
		public int Universe
		{
			[Cpp2IlInjected.Token(Token = "0x6003AD1")]
			[Cpp2IlInjected.Address(RVA = "0x2F9E8B0", Offset = "0x2F9D2B0", VA = "0x182F9E8B0")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (withCase_ == WithOneofCase.Universe)
				{
					object obj = with_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6003AD2")]
			[Cpp2IlInjected.Address(RVA = "0x2F9EB10", Offset = "0x2F9D510", VA = "0x182F9EB10")]
			set
			{
				//IL_0014: Expected I4, but got I8
				with_ = typeof(int).TypeHandle;
				withCase_ = WithOneofCase.Universe;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F0E")]
		[DebuggerNonUserCode]
		public int Profession
		{
			[Cpp2IlInjected.Token(Token = "0x6003AD3")]
			[Cpp2IlInjected.Address(RVA = "0x2F9E790", Offset = "0x2F9D190", VA = "0x182F9E790")]
			get
			{
				//Discarded unreachable code: IL_0012
				if (withCase_ == WithOneofCase.Profession)
				{
					object obj = with_;
				}
				return 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6003AD4")]
			[Cpp2IlInjected.Address(RVA = "0x2F9EAA0", Offset = "0x2F9D4A0", VA = "0x182F9EAA0")]
			set
			{
				//IL_0014: Expected I4, but got I8
				with_ = typeof(int).TypeHandle;
				withCase_ = WithOneofCase.Profession;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F0F")]
		[DebuggerNonUserCode]
		public WithOneofCase WithCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003AD5")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return withCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F10")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003AE4")]
			[Cpp2IlInjected.Address(RVA = "0x2F9E490", Offset = "0x2F9CE90", VA = "0x182F9E490")]
			get
			{
				if (withCase_ == WithOneofCase.Character)
				{
					object obj = with_;
				}
				long num = Convert.ToInt64(0u);
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F11")]
		public Item UniverseItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003AE5")]
			[Cpp2IlInjected.Address(RVA = "0x2F9E800", Offset = "0x2F9D200", VA = "0x182F9E800")]
			get
			{
				if (withCase_ == WithOneofCase.Universe)
				{
					object obj = with_;
				}
				long num = Convert.ToInt64(0u);
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F12")]
		public Item ProfessionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003AE6")]
			[Cpp2IlInjected.Address(RVA = "0x2F9E6E0", Offset = "0x2F9D0E0", VA = "0x182F9E6E0")]
			get
			{
				if (withCase_ == WithOneofCase.Profession)
				{
					object obj = with_;
				}
				long num = Convert.ToInt64(0u);
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003ACC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public HangoutWithCharacter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003ACD")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E3E0", Offset = "0x2F9CDE0", VA = "0x182F9E3E0")]
		[DebuggerNonUserCode]
		public HangoutWithCharacter(HangoutWithCharacter other)
		{
			WithOneofCase withOneofCase = other.withCase_;
			if (other != null)
			{
				if (other != null)
				{
					if (withOneofCase != WithOneofCase.Character)
					{
						goto IL_0043;
					}
					int num = (Profession = other.Profession);
				}
				int num2 = (Universe = other.Universe);
			}
			int num3 = (Character = other.Character);
			goto IL_0043;
			IL_0043:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003ACE")]
		[Cpp2IlInjected.Address(RVA = "0x2F9D480", Offset = "0x2F9BE80", VA = "0x182F9D480", Slot = "10")]
		[DebuggerNonUserCode]
		public HangoutWithCharacter Clone()
		{
			//Discarded unreachable code: IL_005c
			HangoutWithCharacter hangoutWithCharacter = new HangoutWithCharacter();
			WithOneofCase withOneofCase = withCase_;
			if (this != null)
			{
				if (this != null)
				{
					if (withOneofCase != WithOneofCase.Character)
					{
						goto IL_0045;
					}
					int num = (hangoutWithCharacter.Profession = Profession);
				}
				int num2 = (hangoutWithCharacter.Universe = Universe);
			}
			int num3 = (hangoutWithCharacter.Character = Character);
			goto IL_0045;
			IL_0045:
			UnknownFieldSet unknownFieldSet = (hangoutWithCharacter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return hangoutWithCharacter;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AD6")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearWith()
		{
			//IL_0010: Expected O, but got I4
			with_ = (withCase_ = WithOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AD7")]
		[Cpp2IlInjected.Address(RVA = "0x2F9DA00", Offset = "0x2F9C400", VA = "0x182F9DA00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_004a: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				int character = Character;
				int num = default(int);
				if (character == num)
				{
					character = Universe;
					int num2 = default(int);
					if (character == num2)
					{
						int profession = Profession;
						int num3 = 0;
						character = profession;
						int num4 = default(int);
						if (character == num4 && withCase_ == (WithOneofCase)num4)
						{
							return object.Equals(_unknownFields, num3);
						}
					}
				}
			}
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AD8")]
		[Cpp2IlInjected.Address(RVA = "0x2F9DB00", Offset = "0x2F9C500", VA = "0x182F9DB00", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(HangoutWithCharacter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int character = Character;
				int character2 = other.Character;
				if (character == character2)
				{
					character = Universe;
					int universe = other.Universe;
					if (character == universe)
					{
						character = Profession;
						int profession = other.Profession;
						if (character == profession)
						{
							WithOneofCase withOneofCase = other.withCase_;
							if (withCase_ == withOneofCase)
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AD9")]
		[Cpp2IlInjected.Address(RVA = "0x2F9DCA0", Offset = "0x2F9C6A0", VA = "0x182F9DCA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0065
			int num = 0;
			if (withCase_ == WithOneofCase.Character)
			{
				if (withCase_ != WithOneofCase.Character)
				{
				}
				object obj = with_;
			}
			if (withCase_ == WithOneofCase.Universe)
			{
				if (withCase_ != WithOneofCase.Universe)
				{
				}
				object obj2 = with_;
			}
			if (withCase_ == WithOneofCase.Profession && withCase_ == WithOneofCase.Profession)
			{
				object obj3 = with_;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003ADA")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E1A0", Offset = "0x2F9CBA0", VA = "0x182F9E1A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003ADB")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E200", Offset = "0x2F9CC00", VA = "0x182F9E200", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0058
			WithOneofCase withOneofCase;
			do
			{
				withOneofCase = withCase_;
				if (withOneofCase == WithOneofCase.Character)
				{
					int character = Character;
					output.WriteInt32(character);
				}
			}
			while (withOneofCase != WithOneofCase.Universe);
			int universe = Universe;
			output.WriteInt32(universe);
			if (withCase_ == WithOneofCase.Profession)
			{
				int profession = Profession;
				output.WriteInt32(profession);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003ADC")]
		[Cpp2IlInjected.Address(RVA = "0x2F9D0F0", Offset = "0x2F9BAF0", VA = "0x182F9D0F0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0084
			int num = 0;
			if (withCase_ == WithOneofCase.Character)
			{
				if (withCase_ == WithOneofCase.Character)
				{
					object obj = with_;
				}
				int num2 = CodedOutputStream.ComputeInt32Size(num);
			}
			if (withCase_ == WithOneofCase.Universe)
			{
				if (withCase_ != WithOneofCase.Universe)
				{
				}
				object obj2 = with_;
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (withCase_ == WithOneofCase.Profession)
			{
				if (withCase_ == WithOneofCase.Profession)
				{
					object obj3 = with_;
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003ADD")]
		[Cpp2IlInjected.Address(RVA = "0x2F9DF00", Offset = "0x2F9C900", VA = "0x182F9DF00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(HangoutWithCharacter other)
		{
			if (other == null)
			{
				return;
			}
			WithOneofCase withOneofCase = other.withCase_;
			if (other != null)
			{
				if (other != null)
				{
					if (withOneofCase != WithOneofCase.Character)
					{
						goto IL_0041;
					}
					int num = (Profession = other.Profession);
				}
				int num2 = (Universe = other.Universe);
			}
			int num3 = (Character = other.Character);
			goto IL_0041;
			IL_0041:
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003ADE")]
		[Cpp2IlInjected.Address(RVA = "0x2F9DFB0", Offset = "0x2F9C9B0", VA = "0x182F9DFB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005d
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num3 = (Character = input.ReadInt32());
				}
				int num5 = default(int);
				if (num == 16)
				{
					num5 = (Universe = input.ReadInt32());
				}
				if (num5 == 24)
				{
					int num7 = (Profession = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003ADF")]
		[Cpp2IlInjected.Address(RVA = "0x2F9DBC0", Offset = "0x2F9C5C0", VA = "0x182F9DBC0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					int profession = Profession;
				}
				int universe = Universe;
			}
			int character = Character;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AE0")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E080", Offset = "0x2F9CA80", VA = "0x182F9E080", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0013
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AE1")]
		[Cpp2IlInjected.Address(RVA = "0x2F9D2F0", Offset = "0x2F9BCF0", VA = "0x182F9D2F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0015, IL_0026
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			//IL_001c: Expected O, but got I4
			//IL_0025: Expected I4, but got I8
			//IL_002e: Expected O, but got I4
			//IL_0037: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				int num = default(int);
				with_ = num;
				withCase_ = WithOneofCase.Profession;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AE2")]
		[Cpp2IlInjected.Address(RVA = "0x2F9DE50", Offset = "0x2F9C850", VA = "0x182F9DE50", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "With"))
			{
				WithOneofCase withOneofCase = withCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AE3")]
		[Cpp2IlInjected.Address(RVA = "0x2F9D410", Offset = "0x2F9BE10", VA = "0x182F9D410", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "With"))
			{
				with_ = (withCase_ = WithOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003AE7")]
		[Cpp2IlInjected.Address(RVA = "0x2F9D560", Offset = "0x2F9BF60", VA = "0x182F9D560")]
		public unsafe bool CurrentHangoutCharacterIsValid(IProfile profile)
		{
			WithOneofCase withOneofCase = withCase_;
			int num = 0;
			if (withOneofCase != 0)
			{
				if (withOneofCase != 0)
				{
					if (withOneofCase != 0)
					{
						if (withOneofCase != WithOneofCase.Character)
						{
							goto IL_004f;
						}
						if (withCase_ == WithOneofCase.Profession)
						{
							object obj = with_;
						}
						if ((long)num < (long)(IntPtr)typeof(IProfile).TypeHandle)
						{
							num += num;
							num++;
						}
						num += 584;
					}
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					CharacterItemData characterItemData = default(CharacterItemData);
					if (characterItemData == null)
					{
						goto IL_004f;
					}
					goto IL_0052;
				}
				goto IL_0063;
			}
			goto IL_007f;
			IL_0052:
			if (withCase_ == WithOneofCase.Universe)
			{
				object obj2 = with_;
			}
			goto IL_0063;
			IL_004f:
			int num2 = 0;
			goto IL_0052;
			IL_007f:
			throw new InvalidCastException();
			IL_0063:
			if ((object)CharacterItem == null)
			{
				Item characterItem = CharacterItem;
				bool flag = *(Item*)characterItem == *(Item*)characterItem;
			}
			goto IL_007f;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AE8")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E2D0", Offset = "0x2F9CCD0", VA = "0x182F9E2D0")]
		static HangoutWithCharacter()
		{
			Func<HangoutWithCharacter> func = default(Func<HangoutWithCharacter>);
			_parser = (MessageParser<HangoutWithCharacter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
