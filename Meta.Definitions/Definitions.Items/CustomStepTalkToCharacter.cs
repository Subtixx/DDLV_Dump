using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000439")]
	public sealed class CustomStepTalkToCharacter : IMessage<CustomStepTalkToCharacter>, IMessage, IEquatable<CustomStepTalkToCharacter>, IDeepCloneable<CustomStepTalkToCharacter>, IMessageFieldAccessor, IItemSelectorsWithAmount, IStringTag, ITargetCharacterOverride, ICharacterDialog
	{
		[Cpp2IlInjected.Token(Token = "0x4001717")]
		private static readonly MessageParser<CustomStepTalkToCharacter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001718")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001719")]
		public const int TargetIsNotOwnerFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400171A")]
		private OptionalField targetIsNotOwner_;

		[Cpp2IlInjected.Token(Token = "0x400171B")]
		public const int TalkToCharacterDialogAssetFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400171C")]
		private string talkToCharacterDialogAsset_ = "";

		[Cpp2IlInjected.Token(Token = "0x400171D")]
		public const int ItemsToGiveFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x400171E")]
		private static readonly FieldCodec<AnyItemSelectorWithAmount> _repeated_itemsToGive_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400171F")]
		private readonly RepeatedField<AnyItemSelectorWithAmount> itemsToGive_ = (RepeatedField<AnyItemSelectorWithAmount>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000D40")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepTalkToCharacter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60033D0")]
			[Cpp2IlInjected.Address(RVA = "0x3206E20", Offset = "0x3205820", VA = "0x183206E20")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D41")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60033D1")]
			[Cpp2IlInjected.Address(RVA = "0x3206D50", Offset = "0x3205750", VA = "0x183206D50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D42")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60033D2")]
			[Cpp2IlInjected.Address(RVA = "0x32070E0", Offset = "0x3205AE0", VA = "0x1832070E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D43")]
		[DebuggerNonUserCode]
		public OptionalField TargetIsNotOwner
		{
			[Cpp2IlInjected.Token(Token = "0x60033D7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return targetIsNotOwner_;
			}
			[Cpp2IlInjected.Token(Token = "0x60033D8")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				targetIsNotOwner_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D44")]
		[DebuggerNonUserCode]
		public string TalkToCharacterDialogAsset
		{
			[Cpp2IlInjected.Token(Token = "0x60033D9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return talkToCharacterDialogAsset_;
			}
			[Cpp2IlInjected.Token(Token = "0x60033DA")]
			[Cpp2IlInjected.Address(RVA = "0x32071F0", Offset = "0x3205BF0", VA = "0x1832071F0")]
			set
			{
				string text = (talkToCharacterDialogAsset_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D45")]
		[DebuggerNonUserCode]
		public RepeatedField<AnyItemSelectorWithAmount> ItemsToGive
		{
			[Cpp2IlInjected.Token(Token = "0x60033DB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return itemsToGive_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D46")]
		public (Item? characterItem, bool random) TargetCharacterOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60033E7")]
			[Cpp2IlInjected.Address(RVA = "0x3207020", Offset = "0x3205A20", VA = "0x183207020", Slot = "16")]
			get
			{
				int num = 0;
				CharacterList characterList = default(CharacterList);
				int targetCharacter = characterList.TargetCharacter;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D47")]
		IEnumerable<AnyItemSelectorWithAmount> IItemSelectorsWithAmount.ItemSelectorsWithAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60033E8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "14")]
			get
			{
				RepeatedField<AnyItemSelectorWithAmount> repeatedField = itemsToGive_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D48")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x60033E9")]
			[Cpp2IlInjected.Address(RVA = "0x3206E80", Offset = "0x3205880", VA = "0x183206E80", Slot = "15")]
			get
			{
				//Discarded unreachable code: IL_005d
				string[] array;
				while (true)
				{
					array = new string[3];
					if ("TargetNPC" != null && "TargetNPC" == null)
					{
						continue;
					}
					array[0] = "TargetNPC";
					if ("ReceivedItemName" == null || "ReceivedItemName" != null)
					{
						array[1] = "ReceivedItemName";
						if ("ReceivedItemAmount" == null || "ReceivedItemAmount" != null)
						{
							break;
						}
					}
				}
				array[2] = "ReceivedItemAmount";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D49")]
		string ICharacterDialog.GetCharacterDialog
		{
			[Cpp2IlInjected.Token(Token = "0x60033EA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "17")]
			get
			{
				return talkToCharacterDialogAsset_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D4A")]
		bool ICharacterDialog.CompleteObjectiveAfterDialogue
		{
			[Cpp2IlInjected.Token(Token = "0x60033EB")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "18")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60033D3")]
		[Cpp2IlInjected.Address(RVA = "0x3206A40", Offset = "0x3205440", VA = "0x183206A40")]
		[DebuggerNonUserCode]
		public CustomStepTalkToCharacter()
		{
			OptionalField optionalField = new OptionalField();
			CharacterList characterList2 = (optionalField.Character = new CharacterList());
			targetIsNotOwner_ = optionalField;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60033D4")]
		[Cpp2IlInjected.Address(RVA = "0x3206510", Offset = "0x3204F10", VA = "0x183206510")]
		private void OnConstruction()
		{
			OptionalField optionalField = new OptionalField();
			CharacterList characterList2 = (optionalField.Character = new CharacterList());
			targetIsNotOwner_ = optionalField;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60033D5")]
		[Cpp2IlInjected.Address(RVA = "0x3206B70", Offset = "0x3205570", VA = "0x183206B70")]
		[DebuggerNonUserCode]
		public CustomStepTalkToCharacter(CustomStepTalkToCharacter other)
		{
			//IL_0056: Expected O, but got I4
			OptionalField optionalField = new OptionalField();
			CharacterList characterList2 = (optionalField.Character = new CharacterList());
			targetIsNotOwner_ = optionalField;
			OptionalField optionalField2 = other.targetIsNotOwner_;
			if (optionalField2 != null)
			{
				OptionalField optionalField3 = optionalField2.Clone();
			}
			int num = 0;
			targetIsNotOwner_ = (OptionalField)num;
			string text = (talkToCharacterDialogAsset_ = other.talkToCharacterDialogAsset_);
			RepeatedField<AnyItemSelectorWithAmount> repeatedField = (itemsToGive_ = (RepeatedField<AnyItemSelectorWithAmount>)(object)((RepeatedField<T>)(object)other.itemsToGive_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60033D6")]
		[Cpp2IlInjected.Address(RVA = "0x3205E80", Offset = "0x3204880", VA = "0x183205E80", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepTalkToCharacter Clone()
		{
			return new CustomStepTalkToCharacter(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60033DC")]
		[Cpp2IlInjected.Address(RVA = "0x3205EE0", Offset = "0x32048E0", VA = "0x183205EE0", Slot = "0")]
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
				if (object.Equals(targetIsNotOwner_, other))
				{
					string text = talkToCharacterDialogAsset_;
					bool flag = default(bool);
					if (!flag)
					{
						RepeatedField<AnyItemSelectorWithAmount> repeatedField = itemsToGive_;
						bool flag2 = default(bool);
						if (flag2)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60033DD")]
		[Cpp2IlInjected.Address(RVA = "0x3205FE0", Offset = "0x32049E0", VA = "0x183205FE0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepTalkToCharacter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				OptionalField objB = other.targetIsNotOwner_;
				if (object.Equals(targetIsNotOwner_, objB))
				{
					string text = other.talkToCharacterDialogAsset_;
					if (!(talkToCharacterDialogAsset_ != text))
					{
						RepeatedField<AnyItemSelectorWithAmount> repeatedField = itemsToGive_;
						RepeatedField<AnyItemSelectorWithAmount> repeatedField2 = other.itemsToGive_;
						if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60033DE")]
		[Cpp2IlInjected.Address(RVA = "0x32061E0", Offset = "0x3204BE0", VA = "0x1832061E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004e
			OptionalField optionalField = targetIsNotOwner_;
			if (optionalField != null)
			{
				int hashCode = optionalField.GetHashCode();
			}
			string text = talkToCharacterDialogAsset_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			int hashCode3 = ((RepeatedField<T>)(object)itemsToGive_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60033DF")]
		[Cpp2IlInjected.Address(RVA = "0x32066F0", Offset = "0x32050F0", VA = "0x1832066F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60033E0")]
		[Cpp2IlInjected.Address(RVA = "0x3206750", Offset = "0x3205150", VA = "0x183206750", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0060
			if ((long)targetIsNotOwner_ != 0)
			{
				OptionalField value = targetIsNotOwner_;
				output.WriteMessage(value);
			}
			if (talkToCharacterDialogAsset_.m_stringLength != 0)
			{
				string value2 = talkToCharacterDialogAsset_;
				output.WriteString(value2);
			}
			RepeatedField<AnyItemSelectorWithAmount> repeatedField = itemsToGive_;
			FieldCodec<AnyItemSelectorWithAmount> repeated_itemsToGive_codec = _repeated_itemsToGive_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_itemsToGive_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60033E1")]
		[Cpp2IlInjected.Address(RVA = "0x3205C90", Offset = "0x3204690", VA = "0x183205C90", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0073
			OptionalField optionalField = targetIsNotOwner_;
			int num = 0;
			if (optionalField != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(optionalField);
			}
			string text = talkToCharacterDialogAsset_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
				num += num3;
			}
			RepeatedField<AnyItemSelectorWithAmount> repeatedField = itemsToGive_;
			FieldCodec<AnyItemSelectorWithAmount> repeated_itemsToGive_codec = _repeated_itemsToGive_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_itemsToGive_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num4;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60033E2")]
		[Cpp2IlInjected.Address(RVA = "0x3206280", Offset = "0x3204C80", VA = "0x183206280", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepTalkToCharacter other)
		{
			//Discarded unreachable code: IL_0088
			if (other == null)
			{
				return;
			}
			if ((long)other.targetIsNotOwner_ != 0)
			{
				OptionalField optionalField = targetIsNotOwner_;
				if (optionalField == null)
				{
					OptionalField optionalField2 = (targetIsNotOwner_ = new OptionalField());
				}
				OptionalField other2 = other.targetIsNotOwner_;
				optionalField.MergeFrom(other2);
			}
			string text = other.talkToCharacterDialogAsset_;
			if (text.m_stringLength != 0)
			{
				TalkToCharacterDialogAsset = text;
			}
			RepeatedField<AnyItemSelectorWithAmount> repeatedField = itemsToGive_;
			RepeatedField<AnyItemSelectorWithAmount> repeatedField2 = other.itemsToGive_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60033E3")]
		[Cpp2IlInjected.Address(RVA = "0x3206390", Offset = "0x3204D90", VA = "0x183206390", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_007c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				OptionalField optionalField = targetIsNotOwner_;
				if (optionalField == null)
				{
					OptionalField optionalField2 = (targetIsNotOwner_ = new OptionalField());
				}
				input.ReadMessage(optionalField);
			}
			string text2 = default(string);
			if (num == 18)
			{
				text2 = (TalkToCharacterDialogAsset = input.ReadString());
			}
			if ((long)text2 == 34)
			{
				RepeatedField<AnyItemSelectorWithAmount> repeatedField = itemsToGive_;
				FieldCodec<AnyItemSelectorWithAmount> repeated_itemsToGive_codec = _repeated_itemsToGive_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemsToGive_codec);
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60033E4")]
		[Cpp2IlInjected.Address(RVA = "0x3206130", Offset = "0x3204B30", VA = "0x183206130", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<AnyItemSelectorWithAmount> repeatedField = itemsToGive_;
				string text = talkToCharacterDialogAsset_;
				OptionalField optionalField = targetIsNotOwner_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60033E5")]
		[Cpp2IlInjected.Address(RVA = "0x32065C0", Offset = "0x3204FC0", VA = "0x1832065C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0025: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0)
					{
						return;
					}
					if (num == 1)
					{
						InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
						goto IL_0046;
					}
				}
				int num2 = 0;
				if (value == null || value != null)
				{
					TalkToCharacterDialogAsset = (string)num2;
					return;
				}
				goto IL_0046;
			}
			if (value == null || value != null)
			{
				targetIsNotOwner_ = (OptionalField)value;
			}
			throw new InvalidCastException();
			IL_0046:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60033E6")]
		[Cpp2IlInjected.Address(RVA = "0x3205DD0", Offset = "0x32047D0", VA = "0x183205DD0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0028
			int num = fieldNumber - 1;
			if (num == 0)
			{
				return;
			}
			if (num != 0)
			{
				if (num == 0 || num != 1)
				{
					return;
				}
				RepeatedField<AnyItemSelectorWithAmount> repeatedField = itemsToGive_;
			}
			TalkToCharacterDialogAsset = "";
		}

		[Cpp2IlInjected.Token(Token = "0x60033EC")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "19")]
		bool ICharacterDialog.CheckCharacterDialogStatus(MissionStepStatus status)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60033ED")]
		[Cpp2IlInjected.Address(RVA = "0x32060A0", Offset = "0x3204AA0", VA = "0x1832060A0")]
		private Item? GetCharacterItemId()
		{
			OptionalField optionalField = targetIsNotOwner_;
			if (!optionalField.useField_)
			{
				int num = 0;
			}
			int targetCharacter = optionalField.Character.TargetCharacter;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60033EE")]
		[Cpp2IlInjected.Address(RVA = "0x3206870", Offset = "0x3205270", VA = "0x183206870")]
		static CustomStepTalkToCharacter()
		{
			Func<CustomStepTalkToCharacter> func = default(Func<CustomStepTalkToCharacter>);
			_parser = (MessageParser<CustomStepTalkToCharacter>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<AnyItemSelectorWithAmount> parser = AnyItemSelectorWithAmount._parser;
			uint num = default(uint);
			_parser = (MessageParser<CustomStepTalkToCharacter>)(object)FieldCodec.ForMessage<AnyItemSelectorWithAmount>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
