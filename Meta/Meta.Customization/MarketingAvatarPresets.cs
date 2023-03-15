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
	[Cpp2IlInjected.Token(Token = "0x20010E4")]
	public sealed class MarketingAvatarPresets : IDataValidation, IMessage<MarketingAvatarPresets>, IMessage, IEquatable<MarketingAvatarPresets>, IDeepCloneable<MarketingAvatarPresets>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40045A9")]
		private static readonly MessageParser<MarketingAvatarPresets> _parser = (MessageParser<MarketingAvatarPresets>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new MarketingAvatarPresets()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40045AA")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40045AB")]
		public const int PresetsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40045AC")]
		private static readonly FieldCodec<MarketingAvatarPreset> _repeated_presets_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40045AD")]
		private readonly RepeatedField<MarketingAvatarPreset> presets_ = (RepeatedField<MarketingAvatarPreset>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170017DC")]
		[DebuggerNonUserCode]
		public static MessageParser<MarketingAvatarPresets> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600894F")]
			[Cpp2IlInjected.Address(RVA = "0x18B88F0", Offset = "0x18B72F0", VA = "0x1818B88F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017DD")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008950")]
			[Cpp2IlInjected.Address(RVA = "0x18B8820", Offset = "0x18B7220", VA = "0x1818B8820")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017DE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008951")]
			[Cpp2IlInjected.Address(RVA = "0x18B8950", Offset = "0x18B7350", VA = "0x1818B8950", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017DF")]
		[DebuggerNonUserCode]
		public RepeatedField<MarketingAvatarPreset> Presets
		{
			[Cpp2IlInjected.Token(Token = "0x6008955")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return presets_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600894E")]
		[Cpp2IlInjected.Address(RVA = "0x18B7B60", Offset = "0x18B6560", VA = "0x1818B7B60", Slot = "4")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00c5, IL_00cb, IL_00d1
			//IL_00a0: Expected O, but got I4
			int num = 0;
			RepeatedField<MarketingAvatarPreset> repeatedField = presets_;
			Func<MarketingAvatarPreset, string> _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
			if (_003C_003E9__0_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((MarketingAvatarPreset x) => x.name_);
			}
			IEnumerable<> enumerable = Enumerable.GroupBy<MarketingAvatarPreset, string>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__0_);
			Func<IGrouping<string, MarketingAvatarPreset>, bool> func = default(Func<IGrouping<string, MarketingAvatarPreset>, bool>);
			if (_003C_003Ec._003C_003E9__0_1 == null)
			{
				func = (Func<IGrouping<string, MarketingAvatarPreset>, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((IGrouping<string, MarketingAvatarPreset> g) => Enumerable.Count<MarketingAvatarPreset>((IEnumerable<>)g) > 1));
			}
			IEnumerable<IGrouping<string, MarketingAvatarPreset>> enumerable2 = (IEnumerable<IGrouping<string, MarketingAvatarPreset>>)Enumerable.Where<IGrouping<string, MarketingAvatarPreset>>(enumerable, (Func<, >)(object)func);
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			string text = default(string);
			if (enumerable2 != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_00b1;
					}
					num++;
				}
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					if (num == (int)num4)
					{
						goto IL_00b8;
					}
					num++;
				}
				while (num != 0)
				{
				}
				text = "Multiple presets are named " + (string)num;
				context.AddError(text);
				text += text;
				goto IL_00b1;
			}
			goto IL_00bf;
			IL_00bf:
			if (enumerable2 == null)
			{
			}
			return;
			IL_00b8:
			text += text;
			goto IL_00bf;
			IL_00b1:
			text += text;
			goto IL_00b8;
		}

		[Cpp2IlInjected.Token(Token = "0x6008952")]
		[Cpp2IlInjected.Address(RVA = "0x18B86A0", Offset = "0x18B70A0", VA = "0x1818B86A0")]
		[DebuggerNonUserCode]
		public MarketingAvatarPresets()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008953")]
		[Cpp2IlInjected.Address(RVA = "0x18B8720", Offset = "0x18B7120", VA = "0x1818B8720")]
		[DebuggerNonUserCode]
		public MarketingAvatarPresets(MarketingAvatarPresets other)
		{
			RepeatedField<MarketingAvatarPreset> repeatedField = (presets_ = (RepeatedField<MarketingAvatarPreset>)(object)((RepeatedField<T>)(object)other.presets_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008954")]
		[Cpp2IlInjected.Address(RVA = "0x18B7A30", Offset = "0x18B6430", VA = "0x1818B7A30", Slot = "11")]
		[DebuggerNonUserCode]
		public MarketingAvatarPresets Clone()
		{
			//Discarded unreachable code: IL_003b
			MarketingAvatarPresets marketingAvatarPresets = new MarketingAvatarPresets();
			RepeatedField<MarketingAvatarPreset> repeatedField = (marketingAvatarPresets.presets_ = (RepeatedField<MarketingAvatarPreset>)(object)new RepeatedField<T>());
			RepeatedField<MarketingAvatarPreset> repeatedField2 = (marketingAvatarPresets.presets_ = (RepeatedField<MarketingAvatarPreset>)(object)((RepeatedField<T>)(object)presets_).Clone());
			UnknownFieldSet unknownFieldSet = (marketingAvatarPresets._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return marketingAvatarPresets;
		}

		[Cpp2IlInjected.Token(Token = "0x6008956")]
		[Cpp2IlInjected.Address(RVA = "0x18B7FF0", Offset = "0x18B69F0", VA = "0x1818B7FF0", Slot = "0")]
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
				RepeatedField<MarketingAvatarPreset> repeatedField = presets_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008957")]
		[Cpp2IlInjected.Address(RVA = "0x18B80D0", Offset = "0x18B6AD0", VA = "0x1818B80D0", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(MarketingAvatarPresets other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<MarketingAvatarPreset> repeatedField = presets_;
				RepeatedField<MarketingAvatarPreset> repeatedField2 = other.presets_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008958")]
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

		[Cpp2IlInjected.Token(Token = "0x6008959")]
		[Cpp2IlInjected.Address(RVA = "0x18B83B0", Offset = "0x18B6DB0", VA = "0x1818B83B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600895A")]
		[Cpp2IlInjected.Address(RVA = "0x18B8410", Offset = "0x18B6E10", VA = "0x1818B8410", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<MarketingAvatarPreset> repeatedField = presets_;
			FieldCodec<MarketingAvatarPreset> repeated_presets_codec = _repeated_presets_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_presets_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600895B")]
		[Cpp2IlInjected.Address(RVA = "0x18B7920", Offset = "0x18B6320", VA = "0x1818B7920", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<MarketingAvatarPreset> repeatedField = presets_;
			FieldCodec<MarketingAvatarPreset> repeated_presets_codec = _repeated_presets_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_presets_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600895C")]
		[Cpp2IlInjected.Address(RVA = "0x18B81E0", Offset = "0x18B6BE0", VA = "0x1818B81E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(MarketingAvatarPresets other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<MarketingAvatarPreset> repeatedField = presets_;
				RepeatedField<MarketingAvatarPreset> repeatedField2 = other.presets_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600895D")]
		[Cpp2IlInjected.Address(RVA = "0x18B8260", Offset = "0x18B6C60", VA = "0x1818B8260", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<MarketingAvatarPreset> repeatedField = presets_;
					FieldCodec<MarketingAvatarPreset> repeated_presets_codec = _repeated_presets_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_presets_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600895E")]
		[Cpp2IlInjected.Address(RVA = "0x18B8160", Offset = "0x18B6B60", VA = "0x1818B8160", Slot = "12")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<MarketingAvatarPreset> repeatedField = presets_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600895F")]
		[Cpp2IlInjected.Address(RVA = "0x18B8350", Offset = "0x18B6D50", VA = "0x1818B8350", Slot = "13")]
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

		[Cpp2IlInjected.Token(Token = "0x6008960")]
		[Cpp2IlInjected.Address(RVA = "0x18B79D0", Offset = "0x18B63D0", VA = "0x1818B79D0", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<MarketingAvatarPreset> repeatedField = presets_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008961")]
		[Cpp2IlInjected.Address(RVA = "0x18B84D0", Offset = "0x18B6ED0", VA = "0x1818B84D0")]
		static MarketingAvatarPresets()
		{
			MessageParser<MarketingAvatarPreset> parser = MarketingAvatarPreset._parser;
			uint num = default(uint);
			_parser = (MessageParser<MarketingAvatarPresets>)(object)FieldCodec.ForMessage<MarketingAvatarPreset>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
