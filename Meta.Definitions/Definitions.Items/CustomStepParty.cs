using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004BB")]
	public sealed class CustomStepParty : IMessage<CustomStepParty>, IMessage, IEquatable<CustomStepParty>, IDeepCloneable<CustomStepParty>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001947")]
		private static readonly MessageParser<CustomStepParty> _parser = (MessageParser<CustomStepParty>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new CustomStepParty()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001948")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001949")]
		public const int PartyIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400194A")]
		private int partyID_;

		[Cpp2IlInjected.Token(Token = "0x400194B")]
		public const int TransformIntoFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400194C")]
		private int transformInto_;

		[Cpp2IlInjected.Token(Token = "0x400194D")]
		public const int CinematicOverrideAddressFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400194E")]
		private string cinematicOverrideAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x400194F")]
		public const int MandatoryCharactersFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4001950")]
		private static readonly FieldCodec<PartyCharacter> _repeated_mandatoryCharacters_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001951")]
		private readonly RepeatedField<PartyCharacter> mandatoryCharacters_ = (RepeatedField<PartyCharacter>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001952")]
		public const int RandomCharacterTagFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4001953")]
		private static readonly FieldCodec<PartyTag> _repeated_randomCharacterTag_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001954")]
		private readonly RepeatedField<PartyTag> randomCharacterTag_ = (RepeatedField<PartyTag>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001955")]
		public const int ForbiddenCharactersFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x4001956")]
		private static readonly FieldCodec<int> _repeated_forbiddenCharacters_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001957")]
		private readonly RepeatedField<int> forbiddenCharacters_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001958")]
		public const int ForbiddenCharacterTagFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x4001959")]
		private static readonly FieldCodec<int> _repeated_forbiddenCharacterTag_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400195A")]
		private readonly RepeatedField<int> forbiddenCharacterTag_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400195B")]
		public const int DefaultAnimationFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400195C")]
		private CharacterAnimation defaultAnimation_;

		[Cpp2IlInjected.Token(Token = "0x17000EDF")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepParty> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003A4E")]
			[Cpp2IlInjected.Address(RVA = "0x31F1AA0", Offset = "0x31F04A0", VA = "0x1831F1AA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE0")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003A4F")]
			[Cpp2IlInjected.Address(RVA = "0x31F1930", Offset = "0x31F0330", VA = "0x1831F1930")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE1")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003A50")]
			[Cpp2IlInjected.Address(RVA = "0x31F1BC0", Offset = "0x31F05C0", VA = "0x1831F1BC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE2")]
		[DebuggerNonUserCode]
		public int PartyID
		{
			[Cpp2IlInjected.Token(Token = "0x6003A54")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return partyID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A55")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				partyID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE3")]
		[DebuggerNonUserCode]
		public int TransformInto
		{
			[Cpp2IlInjected.Token(Token = "0x6003A56")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return transformInto_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A57")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				transformInto_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE4")]
		[DebuggerNonUserCode]
		public string CinematicOverrideAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6003A58")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return cinematicOverrideAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A59")]
			[Cpp2IlInjected.Address(RVA = "0x31F1CD0", Offset = "0x31F06D0", VA = "0x1831F1CD0")]
			set
			{
				string text = (cinematicOverrideAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE5")]
		[DebuggerNonUserCode]
		public RepeatedField<PartyCharacter> MandatoryCharacters
		{
			[Cpp2IlInjected.Token(Token = "0x6003A5A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return mandatoryCharacters_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE6")]
		[DebuggerNonUserCode]
		public RepeatedField<PartyTag> RandomCharacterTag
		{
			[Cpp2IlInjected.Token(Token = "0x6003A5B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return randomCharacterTag_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE7")]
		[DebuggerNonUserCode]
		public RepeatedField<int> ForbiddenCharacters
		{
			[Cpp2IlInjected.Token(Token = "0x6003A5C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return forbiddenCharacters_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE8")]
		[DebuggerNonUserCode]
		public RepeatedField<int> ForbiddenCharacterTag
		{
			[Cpp2IlInjected.Token(Token = "0x6003A5D")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return forbiddenCharacterTag_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EE9")]
		[DebuggerNonUserCode]
		public CharacterAnimation DefaultAnimation
		{
			[Cpp2IlInjected.Token(Token = "0x6003A5E")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return defaultAnimation_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003A5F")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				defaultAnimation_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EEA")]
		public Item PartyItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003A6B")]
			[Cpp2IlInjected.Address(RVA = "0x31F1B00", Offset = "0x31F0500", VA = "0x1831F1B00")]
			get
			{
				long num = Convert.ToInt64((uint)partyID_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EEB")]
		public Item TransformIntoItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003A6C")]
			[Cpp2IlInjected.Address(RVA = "0x31F1B60", Offset = "0x31F0560", VA = "0x1831F1B60")]
			get
			{
				long num = Convert.ToInt64((uint)transformInto_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EEC")]
		public bool HasCinematicOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6003A6D")]
			[Cpp2IlInjected.Address(RVA = "0x539530", Offset = "0x537F30", VA = "0x180539530")]
			get
			{
				return !string.IsNullOrEmpty(cinematicOverrideAddress_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EED")]
		public bool HasMandatoryCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6003A6E")]
			[Cpp2IlInjected.Address(RVA = "0x31F1A00", Offset = "0x31F0400", VA = "0x1831F1A00")]
			get
			{
				//Discarded unreachable code: IL_000f
				return ((RepeatedField<T>)(object)mandatoryCharacters_).Count > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EEE")]
		public bool HasRandomCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6003A72")]
			[Cpp2IlInjected.Address(RVA = "0x31F1A50", Offset = "0x31F0450", VA = "0x1831F1A50")]
			get
			{
				//Discarded unreachable code: IL_000f
				return ((RepeatedField<T>)(object)randomCharacterTag_).Count > 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A51")]
		[Cpp2IlInjected.Address(RVA = "0x31F17E0", Offset = "0x31F01E0", VA = "0x1831F17E0")]
		[DebuggerNonUserCode]
		public CustomStepParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003A52")]
		[Cpp2IlInjected.Address(RVA = "0x31F1540", Offset = "0x31EFF40", VA = "0x1831F1540")]
		[DebuggerNonUserCode]
		public CustomStepParty(CustomStepParty other)
		{
			int num = (partyID_ = other.partyID_);
			int num2 = (transformInto_ = other.transformInto_);
			string text = (cinematicOverrideAddress_ = other.cinematicOverrideAddress_);
			RepeatedField<PartyCharacter> repeatedField = (mandatoryCharacters_ = (RepeatedField<PartyCharacter>)(object)((RepeatedField<T>)(object)other.mandatoryCharacters_).Clone());
			RepeatedField<PartyTag> repeatedField2 = (randomCharacterTag_ = (RepeatedField<PartyTag>)(object)((RepeatedField<T>)(object)other.randomCharacterTag_).Clone());
			RepeatedField<int> repeatedField3 = (forbiddenCharacters_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.forbiddenCharacters_).Clone());
			RepeatedField<int> repeatedField4 = (forbiddenCharacterTag_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.forbiddenCharacterTag_).Clone());
			CharacterAnimation characterAnimation = (defaultAnimation_ = other.defaultAnimation_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A53")]
		[Cpp2IlInjected.Address(RVA = "0x31EF480", Offset = "0x31EDE80", VA = "0x1831EF480", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepParty Clone()
		{
			return new CustomStepParty(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A60")]
		[Cpp2IlInjected.Address(RVA = "0x31EFD40", Offset = "0x31EE740", VA = "0x1831EFD40", Slot = "0")]
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
				if ((object)_repeated_forbiddenCharacters_codec == (object)typeof(CustomStepParty).TypeHandle && (IntPtr)transformInto_ == (IntPtr)typeof(CustomStepParty).TypeHandle)
				{
					string text = cinematicOverrideAddress_;
					bool flag = default(bool);
					if (!flag)
					{
						RepeatedField<PartyCharacter> repeatedField = mandatoryCharacters_;
						bool flag2 = default(bool);
						if (flag2)
						{
							RepeatedField<PartyTag> repeatedField2 = randomCharacterTag_;
							bool flag3 = default(bool);
							if (flag3)
							{
								RepeatedField<int> repeatedField3 = forbiddenCharacters_;
								bool flag4 = default(bool);
								if (flag4)
								{
									RepeatedField<int> repeatedField4 = forbiddenCharacterTag_;
									bool flag5 = default(bool);
									if (flag5 && defaultAnimation_ == (flag5 ? CharacterAnimation.Angry : CharacterAnimation.None))
									{
										return object.Equals(_unknownFields, other);
									}
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A61")]
		[Cpp2IlInjected.Address(RVA = "0x31EFBF0", Offset = "0x31EE5F0", VA = "0x1831EFBF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepParty other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.partyID_;
				if ((IntPtr)_repeated_forbiddenCharacters_codec == (IntPtr)num)
				{
					int num2 = other.transformInto_;
					if (transformInto_ == num2)
					{
						string text = other.cinematicOverrideAddress_;
						if (!(cinematicOverrideAddress_ != text))
						{
							RepeatedField<PartyCharacter> repeatedField = mandatoryCharacters_;
							RepeatedField<PartyCharacter> repeatedField2 = other.mandatoryCharacters_;
							if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
							{
								RepeatedField<PartyTag> repeatedField3 = randomCharacterTag_;
								RepeatedField<PartyTag> repeatedField4 = other.randomCharacterTag_;
								if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
								{
									RepeatedField<int> repeatedField5 = forbiddenCharacters_;
									RepeatedField<int> repeatedField6 = other.forbiddenCharacters_;
									if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
									{
										RepeatedField<int> repeatedField7 = forbiddenCharacterTag_;
										RepeatedField<int> repeatedField8 = other.forbiddenCharacterTag_;
										if (((RepeatedField<T>)(object)repeatedField7).Equals((RepeatedField<>)(object)repeatedField8))
										{
											CharacterAnimation characterAnimation = other.defaultAnimation_;
											if (defaultAnimation_ == characterAnimation)
											{
												UnknownFieldSet unknownFields = other._unknownFields;
												return object.Equals(_unknownFields, unknownFields);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A62")]
		[Cpp2IlInjected.Address(RVA = "0x31F0030", Offset = "0x31EEA30", VA = "0x1831F0030", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_008b
			int num = 0;
			if (partyID_ != 0)
			{
			}
			if (transformInto_ != 0)
			{
			}
			string text = cinematicOverrideAddress_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)mandatoryCharacters_).GetHashCode();
			int hashCode3 = ((RepeatedField<T>)(object)randomCharacterTag_).GetHashCode();
			int hashCode4 = ((RepeatedField<T>)(object)forbiddenCharacters_).GetHashCode();
			RepeatedField<int> repeatedField = forbiddenCharacterTag_;
			hashCode2 = hashCode4;
			hashCode3 = ((RepeatedField<T>)(object)repeatedField).GetHashCode();
			if (defaultAnimation_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return hashCode3;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A63")]
		[Cpp2IlInjected.Address(RVA = "0x31F0FF0", Offset = "0x31EF9F0", VA = "0x1831F0FF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A64")]
		[Cpp2IlInjected.Address(RVA = "0x31F1050", Offset = "0x31EFA50", VA = "0x1831F1050", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00cd
			if ((long)_repeated_forbiddenCharacters_codec != 0)
			{
				int value = partyID_;
				output.WriteInt32(value);
			}
			if (transformInto_ != 0)
			{
				int value2 = transformInto_;
				output.WriteInt32(value2);
			}
			if (cinematicOverrideAddress_.m_stringLength != 0)
			{
				string value3 = cinematicOverrideAddress_;
				output.WriteString(value3);
			}
			RepeatedField<PartyCharacter> repeatedField = mandatoryCharacters_;
			FieldCodec<PartyCharacter> repeated_mandatoryCharacters_codec = _repeated_mandatoryCharacters_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_mandatoryCharacters_codec);
			RepeatedField<PartyTag> repeatedField2 = randomCharacterTag_;
			FieldCodec<PartyTag> repeated_randomCharacterTag_codec = _repeated_randomCharacterTag_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_randomCharacterTag_codec);
			RepeatedField<int> repeatedField3 = forbiddenCharacters_;
			FieldCodec<int> repeated_forbiddenCharacters_codec = _repeated_forbiddenCharacters_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_forbiddenCharacters_codec);
			RepeatedField<int> repeatedField4 = forbiddenCharacterTag_;
			FieldCodec<int> repeated_forbiddenCharacterTag_codec = _repeated_forbiddenCharacterTag_codec;
			((RepeatedField<T>)(object)repeatedField4).WriteTo(output, (FieldCodec<>)(object)repeated_forbiddenCharacterTag_codec);
			if (defaultAnimation_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A65")]
		[Cpp2IlInjected.Address(RVA = "0x31EF130", Offset = "0x31EDB30", VA = "0x1831EF130", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00fe
			int num = partyID_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = transformInto_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			string text = cinematicOverrideAddress_;
			if (text.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text);
				num6++;
				num2 += num6;
			}
			RepeatedField<PartyCharacter> repeatedField = mandatoryCharacters_;
			FieldCodec<PartyCharacter> repeated_mandatoryCharacters_codec = _repeated_mandatoryCharacters_codec;
			int num7 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_mandatoryCharacters_codec);
			RepeatedField<PartyTag> repeatedField2 = randomCharacterTag_;
			FieldCodec<PartyTag> repeated_randomCharacterTag_codec = _repeated_randomCharacterTag_codec;
			int num8 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_randomCharacterTag_codec);
			RepeatedField<int> repeatedField3 = forbiddenCharacters_;
			FieldCodec<int> repeated_forbiddenCharacters_codec = _repeated_forbiddenCharacters_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_forbiddenCharacters_codec);
			RepeatedField<int> repeatedField4 = forbiddenCharacterTag_;
			FieldCodec<int> repeated_forbiddenCharacterTag_codec = _repeated_forbiddenCharacterTag_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField4).CalculateSize((FieldCodec<>)(object)repeated_forbiddenCharacterTag_codec);
			CharacterAnimation characterAnimation = defaultAnimation_;
			if (characterAnimation != 0)
			{
				int num11 = CodedOutputStream.ComputeEnumSize((int)characterAnimation);
				num11++;
				num2 += num11;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num12 = unknownFields.CalculateSize();
				num2 += num12;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A66")]
		[Cpp2IlInjected.Address(RVA = "0x31F0BF0", Offset = "0x31EF5F0", VA = "0x1831F0BF0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepParty other)
		{
			//Discarded unreachable code: IL_00d9
			if (other != null)
			{
				int num = other.partyID_;
				if (num != 0)
				{
					partyID_ = num;
				}
				int num2 = other.transformInto_;
				if (num2 != 0)
				{
					transformInto_ = num2;
				}
				string text = other.cinematicOverrideAddress_;
				if (text.m_stringLength != 0)
				{
					CinematicOverrideAddress = text;
				}
				RepeatedField<PartyCharacter> repeatedField = mandatoryCharacters_;
				RepeatedField<PartyCharacter> repeatedField2 = other.mandatoryCharacters_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<PartyTag> repeatedField3 = randomCharacterTag_;
				RepeatedField<PartyTag> repeatedField4 = other.randomCharacterTag_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				RepeatedField<int> repeatedField5 = forbiddenCharacters_;
				RepeatedField<int> repeatedField6 = other.forbiddenCharacters_;
				((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
				RepeatedField<int> repeatedField7 = forbiddenCharacterTag_;
				RepeatedField<int> repeatedField8 = other.forbiddenCharacterTag_;
				((RepeatedField<T>)(object)repeatedField7).Add((IEnumerable<>)(object)repeatedField8);
				CharacterAnimation characterAnimation = other.defaultAnimation_;
				if (characterAnimation != 0)
				{
					defaultAnimation_ = characterAnimation;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A67")]
		[Cpp2IlInjected.Address(RVA = "0x31F0930", Offset = "0x31EF330", VA = "0x1831F0930", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0118
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 50)
			{
				if ((int)num > 58)
				{
					if ((long)input != 4294967293L)
					{
						if (num != 80)
						{
							goto IL_0101;
						}
						int num2 = (int)(defaultAnimation_ = (CharacterAnimation)input.ReadInt32());
					}
					RepeatedField<int> repeatedField = forbiddenCharacterTag_;
					FieldCodec<int> repeated_forbiddenCharacterTag_codec = _repeated_forbiddenCharacterTag_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_forbiddenCharacterTag_codec);
				}
				num += 4294967240u;
				if (num != 4294967293u)
				{
					goto IL_0101;
				}
				RepeatedField<int> repeatedField2 = forbiddenCharacters_;
				FieldCodec<int> repeated_forbiddenCharacters_codec = _repeated_forbiddenCharacters_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_forbiddenCharacters_codec);
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					string text2 = (CinematicOverrideAddress = input.ReadString());
				}
				if (num == 42)
				{
					RepeatedField<PartyCharacter> repeatedField3 = mandatoryCharacters_;
					FieldCodec<PartyCharacter> repeated_mandatoryCharacters_codec = _repeated_mandatoryCharacters_codec;
					((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_mandatoryCharacters_codec);
				}
				if (num != 50)
				{
					goto IL_0101;
				}
				RepeatedField<PartyTag> repeatedField4 = randomCharacterTag_;
				FieldCodec<PartyTag> repeated_randomCharacterTag_codec = _repeated_randomCharacterTag_codec;
				((RepeatedField<T>)(object)repeatedField4).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_randomCharacterTag_codec);
			}
			int num3 = default(int);
			if (num == 8)
			{
				num3 = (partyID_ = input.ReadInt32());
			}
			if (num3 == 16)
			{
				int num4 = (transformInto_ = input.ReadInt32());
			}
			goto IL_0101;
			IL_0101:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003A68")]
		[Cpp2IlInjected.Address(RVA = "0x31EFED0", Offset = "0x31EE8D0", VA = "0x1831EFED0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 9)
			{
				int num = partyID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A69")]
		[Cpp2IlInjected.Address(RVA = "0x31F0D20", Offset = "0x31EF720", VA = "0x1831F0D20", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0010, IL_0011, IL_001e, IL_0026, IL_002c
			//IL_000e: Expected I4, but got O
			if (fieldNumber - 1 <= 9)
			{
				object obj = default(object);
				partyID_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A6A")]
		[Cpp2IlInjected.Address(RVA = "0x31EF370", Offset = "0x31EDD70", VA = "0x1831EF370", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0016
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 9)
			{
				partyID_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A6F")]
		[Cpp2IlInjected.Address(RVA = "0x31F0670", Offset = "0x31EF070", VA = "0x1831F0670")]
		public bool IsMandatoryCharacter(CharacterItemData characterData)
		{
			//Discarded unreachable code: IL_0029
			RepeatedField<PartyCharacter> repeatedField = mandatoryCharacters_;
			Predicate<PartyCharacter> predicate = (Predicate<PartyCharacter>)(object)(Predicate<T>)delegate(PartyCharacter x)
			{
				//Discarded unreachable code: IL_001a
				CharacterItemData characterItemData = characterData;
				int character_ = x.character_;
				int iD = characterItemData.ID;
				return character_ == iD;
			};
			return ((RepeatedField<>)(object)repeatedField).Any<PartyCharacter>((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A70")]
		[Cpp2IlInjected.Address(RVA = "0x31F03A0", Offset = "0x31EEDA0", VA = "0x1831F03A0")]
		public int IndexOfMandatoryCharacter(CharacterItemData characterData)
		{
			//Discarded unreachable code: IL_0031
			RepeatedField<PartyCharacter> repeatedField = mandatoryCharacters_;
			Func<PartyCharacter, bool> func = (Func<PartyCharacter, bool>)(object)(Func<T, TResult>)delegate(PartyCharacter x)
			{
				//Discarded unreachable code: IL_001a
				CharacterItemData characterItemData = characterData;
				int character_ = x.character_;
				int iD = characterItemData.ID;
				return character_ == iD;
			};
			PartyCharacter item = Enumerable.FirstOrDefault<PartyCharacter>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			return ((RepeatedField<T>)(object)repeatedField).IndexOf((T)item);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A71")]
		[Cpp2IlInjected.Address(RVA = "0x31F0180", Offset = "0x31EEB80", VA = "0x1831F0180")]
		public CharacterAnimation GetMandatoryCharacterAnimation(CharacterItemData characterData)
		{
			//Discarded unreachable code: IL_003b
			RepeatedField<PartyCharacter> repeatedField = mandatoryCharacters_;
			Func<PartyCharacter, bool> func = (Func<PartyCharacter, bool>)(object)(Func<T, TResult>)delegate(PartyCharacter x)
			{
				//Discarded unreachable code: IL_001a
				CharacterItemData characterItemData = characterData;
				int character_ = x.character_;
				int iD = characterItemData.ID;
				return character_ == iD;
			};
			return Enumerable.FirstOrDefault<PartyCharacter>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func)?.animation_ ?? defaultAnimation_;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A73")]
		[Cpp2IlInjected.Address(RVA = "0x31F0780", Offset = "0x31EF180", VA = "0x1831F0780")]
		public bool IsValidRandomCharacter(CharacterItemData characterData)
		{
			//IL_0044: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			RepeatedField<PartyTag> repeatedField = randomCharacterTag_;
			Predicate<PartyTag> predicate = (Predicate<PartyTag>)(object)(Predicate<T>)delegate(PartyTag x)
			{
				//Discarded unreachable code: IL_001a
				CharacterItemData characterItemData2 = characterData;
				int tag_ = x.tag_;
				Item universeTag = characterItemData2.GetUniverseTag();
				return (IntPtr)tag_ == (IntPtr)universeTag;
			};
			bool flag = ((RepeatedField<>)(object)repeatedField).Any<PartyTag>((Predicate<>)(object)predicate);
			if (!flag)
			{
				return flag;
			}
			CharacterItemData characterItemData = characterData;
			int num = default(int);
			if (((RepeatedField<T>)(object)forbiddenCharacters_).Contains((T)num))
			{
			}
			RepeatedField<int> repeatedField2 = forbiddenCharacterTag_;
			Item item = default(Item);
			int itemID = item.ItemID;
			bool flag2 = ((RepeatedField<T>)(object)repeatedField2).Contains((T)itemID);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A74")]
		[Cpp2IlInjected.Address(RVA = "0x31F04B0", Offset = "0x31EEEB0", VA = "0x1831F04B0")]
		public int IndexOfRandomCharacter(CharacterItemData characterData)
		{
			//Discarded unreachable code: IL_0031
			RepeatedField<PartyTag> repeatedField = randomCharacterTag_;
			Func<PartyTag, bool> func = (Func<PartyTag, bool>)(object)(Func<T, TResult>)delegate(PartyTag x)
			{
				//Discarded unreachable code: IL_001a
				CharacterItemData characterItemData = characterData;
				int tag_ = x.tag_;
				Item universeTag = characterItemData.GetUniverseTag();
				return (IntPtr)tag_ == (IntPtr)universeTag;
			};
			PartyTag item = Enumerable.FirstOrDefault<PartyTag>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
			return ((RepeatedField<T>)(object)repeatedField).IndexOf((T)item);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A75")]
		[Cpp2IlInjected.Address(RVA = "0x31F0290", Offset = "0x31EEC90", VA = "0x1831F0290")]
		public CharacterAnimation GetRandomCharacterAnimation(CharacterItemData characterData)
		{
			//Discarded unreachable code: IL_003b
			RepeatedField<PartyTag> repeatedField = randomCharacterTag_;
			Func<PartyTag, bool> func = (Func<PartyTag, bool>)(object)(Func<T, TResult>)delegate(PartyTag x)
			{
				//Discarded unreachable code: IL_001a
				CharacterItemData characterItemData = characterData;
				int tag_ = x.tag_;
				Item universeTag = characterItemData.GetUniverseTag();
				return (IntPtr)tag_ == (IntPtr)universeTag;
			};
			return Enumerable.FirstOrDefault<PartyTag>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func)?.animation_ ?? defaultAnimation_;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A76")]
		[Cpp2IlInjected.Address(RVA = "0x31F05C0", Offset = "0x31EEFC0", VA = "0x1831F05C0")]
		public bool IsForbiddenCharacter(CharacterItemData characterData)
		{
			//Discarded unreachable code: IL_0035
			//IL_0015: Expected O, but got I4
			//IL_0034: Expected O, but got I4
			RepeatedField<int> repeatedField = forbiddenCharacters_;
			int iD = characterData.ID;
			if (((RepeatedField<T>)(object)repeatedField).Contains((T)iD))
			{
				return true;
			}
			RepeatedField<int> repeatedField2 = forbiddenCharacterTag_;
			int itemID = characterData.GetUniverseTag().ItemID;
			return ((RepeatedField<T>)(object)repeatedField2).Contains((T)itemID);
		}

		[Cpp2IlInjected.Token(Token = "0x6003A77")]
		[Cpp2IlInjected.Address(RVA = "0x31EF4E0", Offset = "0x31EDEE0", VA = "0x1831EF4E0", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00d0, IL_00d6, IL_00dc, IL_00e2, IL_00e8, IL_00ee, IL_00f4, IL_00fa, IL_0100, IL_0106
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int count = ((RepeatedField<T>)(object)mandatoryCharacters_).Count;
			RepeatedField<PartyCharacter> repeatedField = mandatoryCharacters_;
			Func<PartyCharacter, int> _003C_003E9__80_ = _003C_003Ec._003C_003E9__80_0;
			if (_003C_003E9__80_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((PartyCharacter x) => x.character_);
			}
			int num4 = Enumerable.Count<int>(Enumerable.Distinct<int>(Enumerable.Select<PartyCharacter, int>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__80_)));
			if (count != num4)
			{
				context.AddInvalidMemberError("Cannot contain duplicate characters", "MandatoryCharacters");
			}
			RepeatedField<PartyCharacter> repeatedField2 = mandatoryCharacters_;
			bool flag = default(bool);
			if (flag)
			{
				RepeatedField<int> repeatedField3 = forbiddenCharacters_;
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				string error = default(string);
				context.AddError(error);
			}
			int num5 = default(int);
			count = num5;
			Func<PartyTag, int> func = default(Func<PartyTag, int>);
			if (_003C_003Ec._003C_003E9__80_1 == null)
			{
				func = (Func<PartyTag, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((PartyTag x) => x.tag_));
			}
			int num6 = Enumerable.Count<int>(Enumerable.Distinct<int>(Enumerable.Select<PartyTag, int>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func)));
			if (count != num6)
			{
			}
			bool flag3 = default(bool);
			if (flag3)
			{
				bool flag4 = default(bool);
				while (!flag4)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A78")]
		[Cpp2IlInjected.Address(RVA = "0x31F1260", Offset = "0x31EFC60", VA = "0x1831F1260")]
		static CustomStepParty()
		{
			MessageParser<PartyCharacter> parser = PartyCharacter._parser;
			uint num = default(uint);
			_parser = (MessageParser<CustomStepParty>)(object)FieldCodec.ForMessage<PartyCharacter>(num, (MessageParser<>)(object)parser);
			MessageParser<PartyTag> parser2 = PartyTag._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<CustomStepParty>)(object)FieldCodec.ForMessage<PartyTag>(num2, (MessageParser<>)(object)parser2);
			_parser = (MessageParser<CustomStepParty>)(object)FieldCodec.ForInt32(58u);
			_parser = (MessageParser<CustomStepParty>)(object)FieldCodec.ForInt32(66u);
			/*Error: Unexpected end of block*/;
		}
	}
}
