using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x200076C")]
	public sealed class ChoiceOptions : IMessage<ChoiceOptions>, IMessage, IEquatable<ChoiceOptions>, IDeepCloneable<ChoiceOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40024ED")]
		private static readonly MessageParser<ChoiceOptions> _parser = (MessageParser<ChoiceOptions>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new ChoiceOptions()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024EE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40024EF")]
		public const int ChoicesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40024F0")]
		private static readonly FieldCodec<string> _repeated_choices_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024F1")]
		private readonly RepeatedField<string> choices_ = (RepeatedField<string>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40024F2")]
		public const int EnumRenamesFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40024F3")]
		private static readonly FieldCodec<ChoiceRename> _repeated_enumRenames_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024F4")]
		private readonly RepeatedField<ChoiceRename> enumRenames_ = (RepeatedField<ChoiceRename>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40024F5")]
		public const int ChoiceVariableFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40024F6")]
		private string choiceVariable_ = "";

		[Cpp2IlInjected.Token(Token = "0x40024F7")]
		public const int FormattedChoiceVariableFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40024F8")]
		private string formattedChoiceVariable_ = "";

		[Cpp2IlInjected.Token(Token = "0x40024F9")]
		public const int DynamicChoicesFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40024FA")]
		private bool dynamicChoices_;

		[Cpp2IlInjected.Token(Token = "0x40024FB")]
		public const int RequiredFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40024FC")]
		private bool required_;

		[Cpp2IlInjected.Token(Token = "0x170014C5")]
		[DebuggerNonUserCode]
		public static MessageParser<ChoiceOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60051EB")]
			[Cpp2IlInjected.Address(RVA = "0x28A8790", Offset = "0x28A7190", VA = "0x1828A8790")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60051EC")]
			[Cpp2IlInjected.Address(RVA = "0x28A86C0", Offset = "0x28A70C0", VA = "0x1828A86C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60051ED")]
			[Cpp2IlInjected.Address(RVA = "0x28A87F0", Offset = "0x28A71F0", VA = "0x1828A87F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C8")]
		[DebuggerNonUserCode]
		public RepeatedField<string> Choices
		{
			[Cpp2IlInjected.Token(Token = "0x60051F1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return choices_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014C9")]
		[DebuggerNonUserCode]
		public RepeatedField<ChoiceRename> EnumRenames
		{
			[Cpp2IlInjected.Token(Token = "0x60051F2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return enumRenames_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014CA")]
		[DebuggerNonUserCode]
		public string ChoiceVariable
		{
			[Cpp2IlInjected.Token(Token = "0x60051F3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return choiceVariable_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051F4")]
			[Cpp2IlInjected.Address(RVA = "0x28A8900", Offset = "0x28A7300", VA = "0x1828A8900")]
			set
			{
				string text = (choiceVariable_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014CB")]
		[DebuggerNonUserCode]
		public string FormattedChoiceVariable
		{
			[Cpp2IlInjected.Token(Token = "0x60051F5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return formattedChoiceVariable_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051F6")]
			[Cpp2IlInjected.Address(RVA = "0x28A8970", Offset = "0x28A7370", VA = "0x1828A8970")]
			set
			{
				string text = (formattedChoiceVariable_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014CC")]
		[DebuggerNonUserCode]
		public bool DynamicChoices
		{
			[Cpp2IlInjected.Token(Token = "0x60051F7")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
			get
			{
				return dynamicChoices_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051F8")]
			[Cpp2IlInjected.Address(RVA = "0xA62700", Offset = "0xA61100", VA = "0x180A62700")]
			set
			{
				dynamicChoices_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014CD")]
		[DebuggerNonUserCode]
		public bool Required
		{
			[Cpp2IlInjected.Token(Token = "0x60051F9")]
			[Cpp2IlInjected.Address(RVA = "0xBA18B0", Offset = "0xBA02B0", VA = "0x180BA18B0")]
			get
			{
				return required_;
			}
			[Cpp2IlInjected.Token(Token = "0x60051FA")]
			[Cpp2IlInjected.Address(RVA = "0xBA18E0", Offset = "0xBA02E0", VA = "0x180BA18E0")]
			set
			{
				required_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051E8")]
		[Cpp2IlInjected.Address(RVA = "0x28A71A0", Offset = "0x28A5BA0", VA = "0x1828A71A0")]
		public bool IsValidValue(string value)
		{
			//Discarded unreachable code: IL_0017
			bool flag = default(bool);
			if (flag)
			{
				throw new NullReferenceException();
			}
			return ((List<T>)(object)this.GetChoices()).Contains((T)value);
		}

		[Cpp2IlInjected.Token(Token = "0x60051E9")]
		[Cpp2IlInjected.Address(RVA = "0x28A6900", Offset = "0x28A5300", VA = "0x1828A6900")]
		public unsafe List<string> GetChoices()
		{
			//Discarded unreachable code: IL_0150
			//IL_0022: Expected O, but got I4
			string value = choiceVariable_;
			int num = 0;
			if (!string.IsNullOrEmpty(value))
			{
				string[] variables = (string[])num;
				if (!choiceVariable_.StartsWith("Proto:"))
				{
					if (!choiceVariable_.StartsWith("Item:"))
					{
						goto IL_0105;
					}
					string text = choiceVariable_;
					char[] array = new char[0];
					uint num2 = default(uint);
					array[0] = (char)num2;
					string text2 = default(string);
					variables = text2.Split(array);
					if (!int.TryParse(variables[0], out *(int*)num))
					{
						Func<IItemData, bool> func = (Func<IItemData, bool>)(object)(Func<T, TResult>)delegate
						{
							//Discarded unreachable code: IL_000d
							//IL_000d: Expected I4, but got O
							string[] array3 = variables;
							return (byte)(int)typeof(IItemData).TypeHandle != 0;
						};
						IEnumerable<IItemData> enumerable = default(IEnumerable<IItemData>);
						IItemData itemData = Enumerable.FirstOrDefault<IItemData>((IEnumerable<>)enumerable, (Func<, >)(object)func);
						if (itemData == null)
						{
						}
						if (itemData == null)
						{
							throw new InvalidCastException();
						}
					}
					long num3 = Convert.ToInt64((uint)num);
					IItemData itemData2 = default(IItemData);
					if (itemData2 == null)
					{
					}
					if (itemData2 == null)
					{
						throw new InvalidCastException();
					}
				}
				string text3 = choiceVariable_;
				char[] array2 = new char[1];
				uint num4 = default(uint);
				array2[0] = (char)num4;
				string text4 = default(string);
				variables = text4.Split(array2);
				string text5 = variables[0];
				goto IL_0105;
			}
			goto IL_0144;
			IL_0105:
			List<object> list = (List<object>)(object)new List<T>();
			((List<T>)(object)list).Add((T)"");
			Func<object, string> func2 = default(Func<object, string>);
			if (_003C_003Ec._003C_003E9__1_2 == null)
			{
				func2 = (Func<object, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				});
			}
			IEnumerable<object> enumerable2 = (IEnumerable<object>)Enumerable.Select<object, string>((IEnumerable<>)list, (Func<, >)(object)func2);
			goto IL_0144;
			IL_0144:
			return (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)(object)choices_);
		}

		[Cpp2IlInjected.Token(Token = "0x60051EA")]
		[Cpp2IlInjected.Address(RVA = "0x28A77A0", Offset = "0x28A61A0", VA = "0x1828A77A0")]
		public unsafe bool TryGetFormattedChoices(out Dictionary<string, string> formattedChoices)
		{
			//Discarded unreachable code: IL_0107, IL_0125, IL_012a, IL_0133, IL_0137, IL_0145, IL_014d, IL_015b, IL_0162, IL_0170
			//IL_010f: Expected O, but got Ref
			//IL_017c: Expected O, but got I4
			//IL_017c: Expected O, but got Ref
			int num = 0;
			string text = formattedChoiceVariable_;
			if ("" == null && formattedChoiceVariable_.StartsWith("Proto:"))
			{
				string text2 = formattedChoiceVariable_;
				char[] array = new char[0];
				uint num2 = default(uint);
				array[0] = (char)num2;
				string text3 = default(string);
				string[] array2 = text3.Split(array);
				if (array2[0].StartsWith("(type:"))
				{
					if (_003C_003Ec._003C_003E9__2_0 == null)
					{
						bool result = default(bool);
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((string x) => result);
					}
					int num3 = default(int);
					if (num3 != -1)
					{
						int length = array2.Length;
						if (num3 == length)
						{
							uint num4 = default(uint);
							IEnumerable<string> enumerable = (IEnumerable<string>)Enumerable.Take<string>(Enumerable.Skip<string>((IEnumerable<>)(object)array2, (int)num4), num3);
							string text4 = array2[0];
							Func<string, string, string> func = default(Func<string, string, string>);
							if (_003C_003Ec._003C_003E9__2_1 == null)
							{
								func = (Func<string, string, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T1, T2, TResult>)((string x, string y) => x + "." + y));
							}
							uint value = default(uint);
							int num5 = Enumerable.Aggregate<string, string>((IEnumerable<>)enumerable, text4, (Func<, , >)(object)func).IndexOf((char)value);
							IEnumerable<KeyValuePair<string, IMessage>> enumerable2 = default(IEnumerable<KeyValuePair<string, IMessage>>);
							if (Enumerable.Any<KeyValuePair<string, IMessage>>((IEnumerable<>)enumerable2))
							{
								Dictionary<string, string> dictionary = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
								throw new NullReferenceException();
							}
						}
					}
				}
			}
			((Dictionary<, >)System.Runtime.CompilerServices.Unsafe.AsPointer(ref formattedChoices)).buckets = (int[])num;
			int num6 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051EE")]
		[Cpp2IlInjected.Address(RVA = "0x28A85D0", Offset = "0x28A6FD0", VA = "0x1828A85D0")]
		[DebuggerNonUserCode]
		public ChoiceOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051EF")]
		[Cpp2IlInjected.Address(RVA = "0x28A83F0", Offset = "0x28A6DF0", VA = "0x1828A83F0")]
		[DebuggerNonUserCode]
		public ChoiceOptions(ChoiceOptions other)
		{
			RepeatedField<string> repeatedField = (choices_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.choices_).Clone());
			RepeatedField<ChoiceRename> repeatedField2 = (enumRenames_ = (RepeatedField<ChoiceRename>)(object)((RepeatedField<T>)(object)other.enumRenames_).Clone());
			string text = (choiceVariable_ = other.choiceVariable_);
			string text2 = (formattedChoiceVariable_ = other.formattedChoiceVariable_);
			bool flag = (dynamicChoices_ = other.dynamicChoices_);
			bool flag2 = (required_ = other.required_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051F0")]
		[Cpp2IlInjected.Address(RVA = "0x28A6640", Offset = "0x28A5040", VA = "0x1828A6640", Slot = "10")]
		[DebuggerNonUserCode]
		public ChoiceOptions Clone()
		{
			return new ChoiceOptions(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60051FB")]
		[Cpp2IlInjected.Address(RVA = "0x28A67B0", Offset = "0x28A51B0", VA = "0x1828A67B0", Slot = "0")]
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
				RepeatedField<string> repeatedField = choices_;
				bool flag = default(bool);
				if (flag)
				{
					RepeatedField<ChoiceRename> repeatedField2 = enumRenames_;
					bool flag2 = default(bool);
					if (flag2)
					{
						string text = choiceVariable_;
						bool flag3 = default(bool);
						if (!flag3)
						{
							string text2 = formattedChoiceVariable_;
							bool flag4 = default(bool);
							if (!flag4 && dynamicChoices_ == flag4 && required_ == flag4)
							{
								return object.Equals(_unknownFields, other);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051FC")]
		[Cpp2IlInjected.Address(RVA = "0x28A66A0", Offset = "0x28A50A0", VA = "0x1828A66A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ChoiceOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<string> repeatedField = choices_;
				RepeatedField<string> repeatedField2 = other.choices_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					RepeatedField<ChoiceRename> repeatedField3 = enumRenames_;
					RepeatedField<ChoiceRename> repeatedField4 = other.enumRenames_;
					if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
					{
						string text = other.choiceVariable_;
						if (!(choiceVariable_ != text))
						{
							string text2 = other.formattedChoiceVariable_;
							if (!(formattedChoiceVariable_ != text2))
							{
								bool flag = other.dynamicChoices_;
								if (dynamicChoices_ == flag)
								{
									bool flag2 = other.required_;
									if (required_ == flag2)
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
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60051FD")]
		[Cpp2IlInjected.Address(RVA = "0x28A7090", Offset = "0x28A5A90", VA = "0x1828A7090", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0079
			int hashCode = ((RepeatedField<T>)(object)choices_).GetHashCode();
			int hashCode2 = ((RepeatedField<T>)(object)enumRenames_).GetHashCode();
			string text = choiceVariable_;
			if (text.m_stringLength != 0)
			{
				int hashCode3 = text.GetHashCode();
			}
			string text2 = formattedChoiceVariable_;
			if (text2.m_stringLength != 0)
			{
				int hashCode4 = text2.GetHashCode();
			}
			if (dynamicChoices_)
			{
			}
			if (required_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x60051FE")]
		[Cpp2IlInjected.Address(RVA = "0x28A7740", Offset = "0x28A6140", VA = "0x1828A7740", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60051FF")]
		[Cpp2IlInjected.Address(RVA = "0x28A8040", Offset = "0x28A6A40", VA = "0x1828A8040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00ae
			RepeatedField<string> repeatedField = choices_;
			FieldCodec<string> repeated_choices_codec = _repeated_choices_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_choices_codec);
			RepeatedField<ChoiceRename> repeatedField2 = enumRenames_;
			FieldCodec<ChoiceRename> repeated_enumRenames_codec = _repeated_enumRenames_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_enumRenames_codec);
			if (choiceVariable_.m_stringLength != 0)
			{
				string value = choiceVariable_;
				output.WriteString(value);
			}
			if (formattedChoiceVariable_.m_stringLength != 0)
			{
				string value2 = formattedChoiceVariable_;
				output.WriteString(value2);
			}
			if (dynamicChoices_)
			{
				bool value3 = dynamicChoices_;
				output.WriteBool(value3);
			}
			if (required_)
			{
				bool value4 = required_;
				output.WriteBool(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005200")]
		[Cpp2IlInjected.Address(RVA = "0x28A63B0", Offset = "0x28A4DB0", VA = "0x1828A63B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			RepeatedField<string> repeatedField = choices_;
			FieldCodec<string> repeated_choices_codec = _repeated_choices_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_choices_codec);
			RepeatedField<ChoiceRename> repeatedField2 = enumRenames_;
			FieldCodec<ChoiceRename> repeated_enumRenames_codec = _repeated_enumRenames_codec;
			int num2 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_enumRenames_codec);
			string text = choiceVariable_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
				repeatedField = (RepeatedField<string>)(repeatedField + num3);
			}
			string text2 = formattedChoiceVariable_;
			if (text2.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text2);
				num4++;
				repeatedField = (RepeatedField<string>)(repeatedField + num4);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				repeatedField = (RepeatedField<string>)(repeatedField + num5);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005201")]
		[Cpp2IlInjected.Address(RVA = "0x28A7250", Offset = "0x28A5C50", VA = "0x1828A7250", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ChoiceOptions other)
		{
			//Discarded unreachable code: IL_00af
			if (other != null)
			{
				RepeatedField<string> repeatedField = choices_;
				RepeatedField<string> repeatedField2 = other.choices_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<ChoiceRename> repeatedField3 = enumRenames_;
				RepeatedField<ChoiceRename> repeatedField4 = other.enumRenames_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				string text = other.choiceVariable_;
				if (text.m_stringLength != 0)
				{
					ChoiceVariable = text;
				}
				string text2 = other.formattedChoiceVariable_;
				if (text2.m_stringLength != 0)
				{
					FormattedChoiceVariable = text2;
				}
				bool flag = other.dynamicChoices_;
				if (flag)
				{
					dynamicChoices_ = flag;
				}
				bool flag2 = other.required_;
				if (flag2)
				{
					required_ = flag2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005202")]
		[Cpp2IlInjected.Address(RVA = "0x28A7350", Offset = "0x28A5D50", VA = "0x1828A7350", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00ba
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					string text2 = (FormattedChoiceVariable = input.ReadString());
				}
				bool flag = default(bool);
				if (num == 40)
				{
					flag = (dynamicChoices_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_00a3;
				}
				bool flag2 = (required_ = input.ReadBool());
			}
			if (num == 10)
			{
				RepeatedField<string> repeatedField = choices_;
				FieldCodec<string> repeated_choices_codec = _repeated_choices_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_choices_codec);
			}
			if (num == 18)
			{
				RepeatedField<ChoiceRename> repeatedField2 = enumRenames_;
				FieldCodec<ChoiceRename> repeated_enumRenames_codec = _repeated_enumRenames_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_enumRenames_codec);
			}
			if (num == 26)
			{
				string text4 = (ChoiceVariable = input.ReadString());
			}
			goto IL_00a3;
			IL_00a3:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005203")]
		[Cpp2IlInjected.Address(RVA = "0x28A6F60", Offset = "0x28A5960", VA = "0x1828A6F60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				RepeatedField<string> repeatedField = choices_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005204")]
		[Cpp2IlInjected.Address(RVA = "0x28A7520", Offset = "0x28A5F20", VA = "0x1828A7520", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0019, IL_0021, IL_0029
			//IL_0017: Expected O, but got I4
			while (fieldNumber - 1 <= 5)
			{
				int num = 0;
				if (value == null || value != null)
				{
					ChoiceVariable = (string)num;
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005205")]
		[Cpp2IlInjected.Address(RVA = "0x28A6540", Offset = "0x28A4F40", VA = "0x1828A6540", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0011
			if (fieldNumber - 1 <= 5)
			{
				RepeatedField<string> repeatedField = choices_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005206")]
		[Cpp2IlInjected.Address(RVA = "0x28A8200", Offset = "0x28A6C00", VA = "0x1828A8200")]
		static ChoiceOptions()
		{
			_parser = (MessageParser<ChoiceOptions>)(object)FieldCodec.ForString(10u);
			MessageParser<ChoiceRename> parser = ChoiceRename._parser;
			uint num = default(uint);
			_parser = (MessageParser<ChoiceOptions>)(object)FieldCodec.ForMessage<ChoiceRename>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
