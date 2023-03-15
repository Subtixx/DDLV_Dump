using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x2000792")]
	public sealed class CollectionOptions : IMessage<CollectionOptions>, IMessage, IEquatable<CollectionOptions>, IDeepCloneable<CollectionOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40025E6")]
		private static readonly MessageParser<CollectionOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40025E7")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40025E8")]
		public const int FixedSizeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40025E9")]
		private bool fixedSize_;

		[Cpp2IlInjected.Token(Token = "0x40025EA")]
		public const int VerticalSideButtonsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40025EB")]
		private static readonly FieldCodec<bool?> _single_verticalSideButtons_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40025EC")]
		private bool? verticalSideButtons_;

		[Cpp2IlInjected.Token(Token = "0x40025ED")]
		public const int HideButtonsFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x40025EE")]
		private bool hideButtons_;

		[Cpp2IlInjected.Token(Token = "0x40025EF")]
		public const int FoldoutFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40025F0")]
		private static readonly FieldCodec<bool?> _single_foldout_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40025F1")]
		private bool? foldout_;

		[Cpp2IlInjected.Token(Token = "0x40025F2")]
		public const int FoldoutHeaderVariableFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40025F3")]
		private string foldoutHeaderVariable_ = "";

		[Cpp2IlInjected.Token(Token = "0x1700151A")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600535E")]
			[Cpp2IlInjected.Address(RVA = "0x320C480", Offset = "0x320AE80", VA = "0x18320C480")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700151B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600535F")]
			[Cpp2IlInjected.Address(RVA = "0x320C3A0", Offset = "0x320ADA0", VA = "0x18320C3A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700151C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005360")]
			[Cpp2IlInjected.Address(RVA = "0x320C4F0", Offset = "0x320AEF0", VA = "0x18320C4F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700151D")]
		[DebuggerNonUserCode]
		public bool FixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x6005364")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return fixedSize_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005365")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				fixedSize_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700151E")]
		[DebuggerNonUserCode]
		public bool? VerticalSideButtons
		{
			[Cpp2IlInjected.Token(Token = "0x6005366")]
			[Cpp2IlInjected.Address(RVA = "0x320C4E0", Offset = "0x320AEE0", VA = "0x18320C4E0")]
			get
			{
				return verticalSideButtons_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005367")]
			[Cpp2IlInjected.Address(RVA = "0x320C680", Offset = "0x320B080", VA = "0x18320C680")]
			set
			{
				verticalSideButtons_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700151F")]
		[DebuggerNonUserCode]
		public bool HideButtons
		{
			[Cpp2IlInjected.Token(Token = "0x6005368")]
			[Cpp2IlInjected.Address(RVA = "0x63C0A0", Offset = "0x63AAA0", VA = "0x18063C0A0")]
			get
			{
				return hideButtons_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005369")]
			[Cpp2IlInjected.Address(RVA = "0x63C270", Offset = "0x63AC70", VA = "0x18063C270")]
			set
			{
				hideButtons_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001520")]
		[DebuggerNonUserCode]
		public bool? Foldout
		{
			[Cpp2IlInjected.Token(Token = "0x600536A")]
			[Cpp2IlInjected.Address(RVA = "0x320C470", Offset = "0x320AE70", VA = "0x18320C470")]
			get
			{
				return foldout_;
			}
			[Cpp2IlInjected.Token(Token = "0x600536B")]
			[Cpp2IlInjected.Address(RVA = "0x320C670", Offset = "0x320B070", VA = "0x18320C670")]
			set
			{
				foldout_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001521")]
		[DebuggerNonUserCode]
		public string FoldoutHeaderVariable
		{
			[Cpp2IlInjected.Token(Token = "0x600536C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return foldoutHeaderVariable_;
			}
			[Cpp2IlInjected.Token(Token = "0x600536D")]
			[Cpp2IlInjected.Address(RVA = "0x320C600", Offset = "0x320B000", VA = "0x18320C600")]
			set
			{
				string text = (foldoutHeaderVariable_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005361")]
		[Cpp2IlInjected.Address(RVA = "0x320C290", Offset = "0x320AC90", VA = "0x18320C290")]
		[DebuggerNonUserCode]
		public CollectionOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005362")]
		[Cpp2IlInjected.Address(RVA = "0x320C2E0", Offset = "0x320ACE0", VA = "0x18320C2E0")]
		[DebuggerNonUserCode]
		public CollectionOptions(CollectionOptions other)
		{
			bool flag = (fixedSize_ = other.fixedSize_);
			bool? flag2 = (verticalSideButtons_ = other.verticalSideButtons_);
			bool flag3 = (hideButtons_ = other.hideButtons_);
			bool? flag4 = (foldout_ = other.foldout_);
			string text = (foldoutHeaderVariable_ = other.foldoutHeaderVariable_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005363")]
		[Cpp2IlInjected.Address(RVA = "0x320B4A0", Offset = "0x3209EA0", VA = "0x18320B4A0", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionOptions Clone()
		{
			//Discarded unreachable code: IL_0072
			CollectionOptions collectionOptions = new CollectionOptions();
			collectionOptions.foldoutHeaderVariable_ = "";
			bool flag = (collectionOptions.fixedSize_ = fixedSize_);
			bool? flag2 = (collectionOptions.verticalSideButtons_ = verticalSideButtons_);
			bool flag3 = (collectionOptions.hideButtons_ = hideButtons_);
			bool? flag4 = (collectionOptions.foldout_ = foldout_);
			string text = (collectionOptions.foldoutHeaderVariable_ = foldoutHeaderVariable_);
			UnknownFieldSet unknownFieldSet = (collectionOptions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return collectionOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x600536E")]
		[Cpp2IlInjected.Address(RVA = "0x320B580", Offset = "0x3209F80", VA = "0x18320B580", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_0057: Expected O, but got I4
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
				if ((IntPtr)(fixedSize_ ? 1 : 0) == (IntPtr)typeof(CollectionOptions).TypeHandle)
				{
					bool? flag = verticalSideButtons_;
					bool flag2 = default(bool);
					bool flag3 = default(bool);
					if (flag2 != flag3 && hideButtons_ == flag2)
					{
						bool? flag4 = foldout_;
						bool flag5 = default(bool);
						bool flag6 = default(bool);
						if (flag5 != flag6)
						{
							string text = foldoutHeaderVariable_;
							bool flag7 = default(bool);
							if (!flag7)
							{
								return object.Equals(_unknownFields, flag6);
							}
						}
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600536F")]
		[Cpp2IlInjected.Address(RVA = "0x320B6E0", Offset = "0x320A0E0", VA = "0x18320B6E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.fixedSize_;
				if (fixedSize_ == flag)
				{
					bool? flag2 = verticalSideButtons_;
					bool? flag3 = other.verticalSideButtons_;
					bool flag4 = (object)flag2 == (object)flag3;
					if ((object)flag2 == (object)flag3 != flag4)
					{
						bool flag5 = other.hideButtons_;
						if (hideButtons_ == flag5)
						{
							bool? flag6 = foldout_;
							bool? flag7 = other.foldout_;
							bool flag8 = (object)flag6 == (object)flag7;
							if ((object)flag6 == (object)flag7 != flag8)
							{
								string text = other.foldoutHeaderVariable_;
								if (!(foldoutHeaderVariable_ != text))
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

		[Cpp2IlInjected.Token(Token = "0x6005370")]
		[Cpp2IlInjected.Address(RVA = "0x320B930", Offset = "0x320A330", VA = "0x18320B930", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0056
			int num = 0;
			if (fixedSize_)
			{
			}
			bool? flag = verticalSideButtons_;
			if (hideButtons_)
			{
			}
			bool? flag2 = foldout_;
			string text = foldoutHeaderVariable_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005371")]
		[Cpp2IlInjected.Address(RVA = "0x320BF10", Offset = "0x320A910", VA = "0x18320BF10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005372")]
		[Cpp2IlInjected.Address(RVA = "0x320BF70", Offset = "0x320A970", VA = "0x18320BF70", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0090
			if (fixedSize_)
			{
				bool value = fixedSize_;
				output.WriteBool(value);
			}
			FieldCodec<bool?> single_verticalSideButtons_codec = _single_verticalSideButtons_codec;
			bool? value2 = verticalSideButtons_;
			((FieldCodec<T>)(object)single_verticalSideButtons_codec).WriteTagAndValue(output, (T)value2);
			if (hideButtons_)
			{
				bool value3 = hideButtons_;
				output.WriteBool(value3);
			}
			FieldCodec<bool?> single_foldout_codec = _single_foldout_codec;
			bool? value4 = foldout_;
			((FieldCodec<T>)(object)single_foldout_codec).WriteTagAndValue(output, (T)value4);
			if (foldoutHeaderVariable_.m_stringLength != 0)
			{
				string value5 = foldoutHeaderVariable_;
				output.WriteString(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005373")]
		[Cpp2IlInjected.Address(RVA = "0x320B270", Offset = "0x3209C70", VA = "0x18320B270", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			bool flag = fixedSize_;
			FieldCodec<bool?> single_verticalSideButtons_codec = _single_verticalSideButtons_codec;
			bool? value = verticalSideButtons_;
			int num = ((FieldCodec<T>)(object)single_verticalSideButtons_codec).CalculateSizeWithTag((T)value);
			num += (flag ? 1 : 0);
			FieldCodec<bool?> single_foldout_codec = _single_foldout_codec;
			bool? value2 = foldout_;
			int num2 = ((FieldCodec<T>)(object)single_foldout_codec).CalculateSizeWithTag((T)value2);
			flag = (byte)((flag ? 1u : 0u) + (uint)num2) != 0;
			string text = foldoutHeaderVariable_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
				flag = (byte)((flag ? 1u : 0u) + (uint)num3) != 0;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				flag = (byte)((flag ? 1u : 0u) + (uint)num4) != 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005374")]
		[Cpp2IlInjected.Address(RVA = "0x320BC30", Offset = "0x320A630", VA = "0x18320BC30", Slot = "4")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(CollectionOptions other)
		{
			//Discarded unreachable code: IL_00b5
			//IL_0027: Expected I4, but got O
			//IL_0062: Expected I4, but got O
			if (other != null)
			{
				bool flag = other.fixedSize_;
				if (flag)
				{
					fixedSize_ = flag;
				}
				bool? flag2 = other.verticalSideButtons_;
				bool flag3 = (byte)(int)((Nullable<>*)(&flag2))->value != 0;
				if ((object)flag2 == null == flag3)
				{
					bool? flag4 = (verticalSideButtons_ = other.verticalSideButtons_);
				}
				bool flag5 = other.hideButtons_;
				if (flag5)
				{
					hideButtons_ = flag5;
				}
				bool? flag6 = other.foldout_;
				bool flag7 = (byte)(int)((Nullable<>*)(&flag6))->value != 0;
				if ((object)flag6 == null == flag7)
				{
					bool? flag8 = (foldout_ = other.foldout_);
				}
				string text = other.foldoutHeaderVariable_;
				if (text.m_stringLength != 0)
				{
					FoldoutHeaderVariable = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005375")]
		[Cpp2IlInjected.Address(RVA = "0x320BA40", Offset = "0x320A440", VA = "0x18320BA40", Slot = "5")]
		[DebuggerNonUserCode]
		public unsafe void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00b5
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 24)
				{
					bool flag = (hideButtons_ = input.ReadBool());
				}
				bool? flag2 = default(bool?);
				if (num == 34)
				{
					flag2 = (bool?)((FieldCodec<T>)(object)_single_foldout_codec).Read(input);
					bool flag3 = (object)flag2 == null;
					while ((IntPtr)(void*)flag2 != (IntPtr)(flag3 ? 1 : 0))
					{
					}
					foldout_ = flag2;
				}
				if ((long)flag2 != 42)
				{
					goto IL_009e;
				}
				string text2 = (FoldoutHeaderVariable = input.ReadString());
			}
			bool flag4 = default(bool);
			if (num == 8)
			{
				flag4 = (fixedSize_ = input.ReadBool());
			}
			if (flag4)
			{
				bool? flag5 = (bool?)((FieldCodec<T>)(object)_single_verticalSideButtons_codec).Read(input);
				bool flag6 = (object)flag5 == null;
				while ((IntPtr)(void*)flag5 != (IntPtr)(flag6 ? 1 : 0))
				{
				}
				verticalSideButtons_ = flag5;
			}
			goto IL_009e;
			IL_009e:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005376")]
		[Cpp2IlInjected.Address(RVA = "0x320B7F0", Offset = "0x320A1F0", VA = "0x18320B7F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0 && num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0035;
						}
						string text = foldoutHeaderVariable_;
					}
					bool? flag = foldout_;
				}
				bool? flag2 = verticalSideButtons_;
			}
			bool flag3 = fixedSize_;
			goto IL_0035;
			IL_0035:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005377")]
		[Cpp2IlInjected.Address(RVA = "0x320BD20", Offset = "0x320A720", VA = "0x18320BD20", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0052
			//IL_0029: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_003d: Expected I4, but got O
			//IL_0049: Expected O, but got I4
			//IL_0051: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
						{
							int num2 = 0;
							if (value == null || value != null)
							{
								FoldoutHeaderVariable = (string)num2;
								break;
							}
							throw new InvalidCastException();
						}
						case 0:
							if (value != null)
							{
							}
							foldout_ = (bool?)(object)0;
							break;
						}
					}
					else
					{
						object obj = default(object);
						hideButtons_ = (byte)(int)obj != 0;
					}
				}
				else
				{
					if (value != null)
					{
					}
					verticalSideButtons_ = (bool?)(object)0;
				}
			}
			else
			{
				object obj2 = default(object);
				fixedSize_ = (byte)(int)obj2 != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005378")]
		[Cpp2IlInjected.Address(RVA = "0x320B3F0", Offset = "0x3209DF0", VA = "0x18320B3F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_002d: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						switch (num)
						{
						case 1:
							FoldoutHeaderVariable = "";
							break;
						case 0:
						{
							int num2 = 0;
							foldout_ = (bool?)(object)num2;
							break;
						}
						}
					}
					else
					{
						hideButtons_ = false;
					}
				}
				else
				{
					int num3 = 0;
					verticalSideButtons_ = (bool?)(object)num3;
				}
			}
			else
			{
				fixedSize_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005379")]
		[Cpp2IlInjected.Address(RVA = "0x320C110", Offset = "0x320AB10", VA = "0x18320C110")]
		static CollectionOptions()
		{
			Func<CollectionOptions> func = default(Func<CollectionOptions>);
			_parser = (MessageParser<CollectionOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			uint num = default(uint);
			_parser = (MessageParser<CollectionOptions>)(object)FieldCodec.ForStructWrapper<bool>(num);
			uint num2 = default(uint);
			_parser = (MessageParser<CollectionOptions>)(object)FieldCodec.ForStructWrapper<bool>(num2);
			/*Error: Unexpected end of block*/;
		}
	}
}
