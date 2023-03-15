using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010E0")]
	public sealed class AvatarBodyPresets : IDataValidation, IMessage<AvatarBodyPresets>, IMessage, IEquatable<AvatarBodyPresets>, IDeepCloneable<AvatarBodyPresets>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4004582")]
		private static readonly MessageParser<AvatarBodyPresets> _parser = (MessageParser<AvatarBodyPresets>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new AvatarBodyPresets()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004583")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4004584")]
		public const int PresetsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4004585")]
		private static readonly FieldCodec<AvatarBodyPreset> _repeated_presets_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004586")]
		private readonly RepeatedField<AvatarBodyPreset> presets_ = (RepeatedField<AvatarBodyPreset>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170017C8")]
		[DebuggerNonUserCode]
		public static MessageParser<AvatarBodyPresets> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008905")]
			[Cpp2IlInjected.Address(RVA = "0x1AAB8F0", Offset = "0x1AAA2F0", VA = "0x181AAB8F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017C9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008906")]
			[Cpp2IlInjected.Address(RVA = "0x1AAB820", Offset = "0x1AAA220", VA = "0x181AAB820")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017CA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008907")]
			[Cpp2IlInjected.Address(RVA = "0x1AAB950", Offset = "0x1AAA350", VA = "0x181AAB950", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017CB")]
		[DebuggerNonUserCode]
		public RepeatedField<AvatarBodyPreset> Presets
		{
			[Cpp2IlInjected.Token(Token = "0x600890B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return presets_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008904")]
		[Cpp2IlInjected.Address(RVA = "0x1AAABB0", Offset = "0x1AA95B0", VA = "0x181AAABB0", Slot = "4")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00b1, IL_00b7, IL_00bd
			//IL_0093: Expected O, but got I4
			int num = 0;
			RepeatedField<AvatarBodyPreset> repeatedField = presets_;
			Func<AvatarBodyPreset, string> _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
			if (_003C_003E9__0_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AvatarBodyPreset x) => x.name_);
			}
			IEnumerable<> enumerable = Enumerable.GroupBy<AvatarBodyPreset, string>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__0_);
			Func<IGrouping<string, AvatarBodyPreset>, bool> func = default(Func<IGrouping<string, AvatarBodyPreset>, bool>);
			if (_003C_003Ec._003C_003E9__0_1 == null)
			{
				func = (Func<IGrouping<string, AvatarBodyPreset>, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((IGrouping<string, AvatarBodyPreset> g) => Enumerable.Count<AvatarBodyPreset>((IEnumerable<>)g) > 1));
			}
			IEnumerable<IGrouping<string, AvatarBodyPreset>> enumerable2 = (IEnumerable<IGrouping<string, AvatarBodyPreset>>)Enumerable.Where<IGrouping<string, AvatarBodyPreset>>(enumerable, (Func<, >)(object)func);
			string text = default(string);
			if (enumerable2 != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_009d;
					}
					num++;
				}
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_00a4;
					}
					num++;
				}
				while (num != 0)
				{
				}
				text = "Multiple presets are named " + (string)num;
				context.AddError(text);
				goto IL_009d;
			}
			goto IL_00ab;
			IL_009d:
			text += text;
			goto IL_00a4;
			IL_00a4:
			text += text;
			goto IL_00ab;
			IL_00ab:
			if (enumerable2 == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008908")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB7A0", Offset = "0x1AAA1A0", VA = "0x181AAB7A0")]
		[DebuggerNonUserCode]
		public AvatarBodyPresets()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008909")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB6A0", Offset = "0x1AAA0A0", VA = "0x181AAB6A0")]
		[DebuggerNonUserCode]
		public AvatarBodyPresets(AvatarBodyPresets other)
		{
			RepeatedField<AvatarBodyPreset> repeatedField = (presets_ = (RepeatedField<AvatarBodyPreset>)(object)((RepeatedField<T>)(object)other.presets_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600890A")]
		[Cpp2IlInjected.Address(RVA = "0x1AAAA80", Offset = "0x1AA9480", VA = "0x181AAAA80", Slot = "11")]
		[DebuggerNonUserCode]
		public AvatarBodyPresets Clone()
		{
			//Discarded unreachable code: IL_003b
			AvatarBodyPresets avatarBodyPresets = new AvatarBodyPresets();
			RepeatedField<AvatarBodyPreset> repeatedField = (avatarBodyPresets.presets_ = (RepeatedField<AvatarBodyPreset>)(object)new RepeatedField<T>());
			RepeatedField<AvatarBodyPreset> repeatedField2 = (avatarBodyPresets.presets_ = (RepeatedField<AvatarBodyPreset>)(object)((RepeatedField<T>)(object)presets_).Clone());
			UnknownFieldSet unknownFieldSet = (avatarBodyPresets._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return avatarBodyPresets;
		}

		[Cpp2IlInjected.Token(Token = "0x600890C")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB080", Offset = "0x1AA9A80", VA = "0x181AAB080", Slot = "0")]
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
				RepeatedField<AvatarBodyPreset> repeatedField = presets_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600890D")]
		[Cpp2IlInjected.Address(RVA = "0x1AAAFF0", Offset = "0x1AA99F0", VA = "0x181AAAFF0", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(AvatarBodyPresets other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<AvatarBodyPreset> repeatedField = presets_;
				RepeatedField<AvatarBodyPreset> repeatedField2 = other.presets_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600890E")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)presets_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x600890F")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB3B0", Offset = "0x1AA9DB0", VA = "0x181AAB3B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008910")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB410", Offset = "0x1AA9E10", VA = "0x181AAB410", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<AvatarBodyPreset> repeatedField = presets_;
			FieldCodec<AvatarBodyPreset> repeated_presets_codec = _repeated_presets_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_presets_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008911")]
		[Cpp2IlInjected.Address(RVA = "0x1AAA970", Offset = "0x1AA9370", VA = "0x181AAA970", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<AvatarBodyPreset> repeatedField = presets_;
			FieldCodec<AvatarBodyPreset> repeated_presets_codec = _repeated_presets_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_presets_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6008912")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB2D0", Offset = "0x1AA9CD0", VA = "0x181AAB2D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(AvatarBodyPresets other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<AvatarBodyPreset> repeatedField = presets_;
				RepeatedField<AvatarBodyPreset> repeatedField2 = other.presets_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008913")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB1E0", Offset = "0x1AA9BE0", VA = "0x181AAB1E0", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<AvatarBodyPreset> repeatedField = presets_;
					FieldCodec<AvatarBodyPreset> repeated_presets_codec = _repeated_presets_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_presets_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008914")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB160", Offset = "0x1AA9B60", VA = "0x181AAB160", Slot = "12")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<AvatarBodyPreset> repeatedField = presets_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008915")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB350", Offset = "0x1AA9D50", VA = "0x181AAB350", Slot = "13")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008916")]
		[Cpp2IlInjected.Address(RVA = "0x1AAAA20", Offset = "0x1AA9420", VA = "0x181AAAA20", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<AvatarBodyPreset> repeatedField = presets_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008917")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB4D0", Offset = "0x1AA9ED0", VA = "0x181AAB4D0")]
		static AvatarBodyPresets()
		{
			MessageParser<AvatarBodyPreset> parser = AvatarBodyPreset._parser;
			uint num = default(uint);
			_parser = (MessageParser<AvatarBodyPresets>)(object)FieldCodec.ForMessage<AvatarBodyPreset>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
