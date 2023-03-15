using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002E8")]
	public sealed class BenefitsStoreData : IMessage<BenefitsStoreData>, IMessage, IEquatable<BenefitsStoreData>, IDeepCloneable<BenefitsStoreData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20002E9")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20002EA")]
			public sealed class StoreDisplay : IMessage<StoreDisplay>, IMessage, IEquatable<StoreDisplay>, IDeepCloneable<StoreDisplay>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000D5A")]
				private static readonly MessageParser<StoreDisplay> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000D5B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000D5C")]
				public const int ItemIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000D5D")]
				private int itemID_;

				[Cpp2IlInjected.Token(Token = "0x4000D5E")]
				public const int QuantityFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000D5F")]
				private int quantity_;

				[Cpp2IlInjected.Token(Token = "0x4000D60")]
				public const int IsShowcasedFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000D61")]
				private bool isShowcased_;

				[Cpp2IlInjected.Token(Token = "0x1700075F")]
				[DebuggerNonUserCode]
				public static MessageParser<StoreDisplay> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001FD7")]
					[Cpp2IlInjected.Address(RVA = "0x9D40E0", Offset = "0x9D2AE0", VA = "0x1809D40E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000760")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001FD8")]
					[Cpp2IlInjected.Address(RVA = "0x9D4060", Offset = "0x9D2A60", VA = "0x1809D4060")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000761")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001FD9")]
					[Cpp2IlInjected.Address(RVA = "0x9D4140", Offset = "0x9D2B40", VA = "0x1809D4140", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000762")]
				[DebuggerNonUserCode]
				public int ItemID
				{
					[Cpp2IlInjected.Token(Token = "0x6001FDD")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001FDE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000763")]
				[DebuggerNonUserCode]
				public int Quantity
				{
					[Cpp2IlInjected.Token(Token = "0x6001FDF")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001FE0")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000764")]
				[DebuggerNonUserCode]
				public bool IsShowcased
				{
					[Cpp2IlInjected.Token(Token = "0x6001FE1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6001FE2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001FDA")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public StoreDisplay()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FDB")]
				[Cpp2IlInjected.Address(RVA = "0x75C320", Offset = "0x75AD20", VA = "0x18075C320")]
				[DebuggerNonUserCode]
				public StoreDisplay(StoreDisplay other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FDC")]
				[Cpp2IlInjected.Address(RVA = "0x9D3BB0", Offset = "0x9D25B0", VA = "0x1809D3BB0", Slot = "10")]
				[DebuggerNonUserCode]
				public StoreDisplay Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001FE3")]
				[Cpp2IlInjected.Address(RVA = "0x9D3C40", Offset = "0x9D2640", VA = "0x1809D3C40", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FE4")]
				[Cpp2IlInjected.Address(RVA = "0x75BC40", Offset = "0x75A640", VA = "0x18075BC40", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(StoreDisplay other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FE5")]
				[Cpp2IlInjected.Address(RVA = "0x75BE10", Offset = "0x75A810", VA = "0x18075BE10", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FE6")]
				[Cpp2IlInjected.Address(RVA = "0x9D3EF0", Offset = "0x9D28F0", VA = "0x1809D3EF0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001FE7")]
				[Cpp2IlInjected.Address(RVA = "0x75C160", Offset = "0x75AB60", VA = "0x18075C160", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FE8")]
				[Cpp2IlInjected.Address(RVA = "0x9D3AE0", Offset = "0x9D24E0", VA = "0x1809D3AE0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001FE9")]
				[Cpp2IlInjected.Address(RVA = "0x75BEC0", Offset = "0x75A8C0", VA = "0x18075BEC0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(StoreDisplay other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FEA")]
				[Cpp2IlInjected.Address(RVA = "0x75BF30", Offset = "0x75A930", VA = "0x18075BF30", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FEB")]
				[Cpp2IlInjected.Address(RVA = "0x9D3CE0", Offset = "0x9D26E0", VA = "0x1809D3CE0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001FEC")]
				[Cpp2IlInjected.Address(RVA = "0x9D3DD0", Offset = "0x9D27D0", VA = "0x1809D3DD0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001FED")]
				[Cpp2IlInjected.Address(RVA = "0x75BB80", Offset = "0x75A580", VA = "0x18075BB80", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000D53")]
		private static readonly MessageParser<BenefitsStoreData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000D54")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000D55")]
		public const int InteriorPrefabAddressFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000D56")]
		private string interiorPrefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000D57")]
		public const int DisplaysFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4000D58")]
		private static readonly FieldCodec<Types.StoreDisplay> _repeated_displays_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000D59")]
		private readonly RepeatedField<Types.StoreDisplay> displays_;

		[Cpp2IlInjected.Token(Token = "0x1700075A")]
		[DebuggerNonUserCode]
		public static MessageParser<BenefitsStoreData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001FC1")]
			[Cpp2IlInjected.Address(RVA = "0x32E6DE0", Offset = "0x32E57E0", VA = "0x1832E6DE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700075B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001FC2")]
			[Cpp2IlInjected.Address(RVA = "0x32E6D10", Offset = "0x32E5710", VA = "0x1832E6D10")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700075C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001FC3")]
			[Cpp2IlInjected.Address(RVA = "0x32E6E40", Offset = "0x32E5840", VA = "0x1832E6E40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700075D")]
		[DebuggerNonUserCode]
		public string InteriorPrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001FC8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return interiorPrefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001FC9")]
			[Cpp2IlInjected.Address(RVA = "0x32E6F50", Offset = "0x32E5950", VA = "0x1832E6F50")]
			set
			{
				string text = (interiorPrefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700075E")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.StoreDisplay> Displays
		{
			[Cpp2IlInjected.Token(Token = "0x6001FCA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return displays_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC4")]
		[Cpp2IlInjected.Address(RVA = "0x32E6B30", Offset = "0x32E5530", VA = "0x1832E6B30")]
		[DebuggerNonUserCode]
		public BenefitsStoreData()
		{
			RepeatedField<Types.StoreDisplay> repeatedField = (displays_ = (RepeatedField<Types.StoreDisplay>)(object)new RepeatedField<T>());
			OnConstruction();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnConstruction()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC6")]
		[Cpp2IlInjected.Address(RVA = "0x32E6BD0", Offset = "0x32E55D0", VA = "0x1832E6BD0")]
		[DebuggerNonUserCode]
		public BenefitsStoreData(BenefitsStoreData other)
		{
			RepeatedField<Types.StoreDisplay> repeatedField = (displays_ = (RepeatedField<Types.StoreDisplay>)(object)new RepeatedField<T>());
			OnConstruction();
			string text = (interiorPrefabAddress_ = other.interiorPrefabAddress_);
			RepeatedField<Types.StoreDisplay> repeatedField2 = (displays_ = (RepeatedField<Types.StoreDisplay>)(object)((RepeatedField<T>)(object)other.displays_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC7")]
		[Cpp2IlInjected.Address(RVA = "0x32E61C0", Offset = "0x32E4BC0", VA = "0x1832E61C0", Slot = "10")]
		[DebuggerNonUserCode]
		public BenefitsStoreData Clone()
		{
			//Discarded unreachable code: IL_005c
			BenefitsStoreData benefitsStoreData = new BenefitsStoreData();
			benefitsStoreData.interiorPrefabAddress_ = "";
			RepeatedField<Types.StoreDisplay> repeatedField = (benefitsStoreData.displays_ = (RepeatedField<Types.StoreDisplay>)(object)new RepeatedField<T>());
			benefitsStoreData.OnConstruction();
			string text = (benefitsStoreData.interiorPrefabAddress_ = interiorPrefabAddress_);
			RepeatedField<Types.StoreDisplay> repeatedField2 = (benefitsStoreData.displays_ = (RepeatedField<Types.StoreDisplay>)(object)((RepeatedField<T>)(object)displays_).Clone());
			UnknownFieldSet unknownFieldSet = (benefitsStoreData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return benefitsStoreData;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FCB")]
		[Cpp2IlInjected.Address(RVA = "0x32E63D0", Offset = "0x32E4DD0", VA = "0x1832E63D0", Slot = "0")]
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
				string text = interiorPrefabAddress_;
				bool flag = default(bool);
				if (!flag)
				{
					RepeatedField<Types.StoreDisplay> repeatedField = displays_;
					bool flag2 = default(bool);
					if (flag2)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FCC")]
		[Cpp2IlInjected.Address(RVA = "0x32E6320", Offset = "0x32E4D20", VA = "0x1832E6320", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BenefitsStoreData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.interiorPrefabAddress_;
				if (!(interiorPrefabAddress_ != text))
				{
					RepeatedField<Types.StoreDisplay> repeatedField = displays_;
					RepeatedField<Types.StoreDisplay> repeatedField2 = other.displays_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FCD")]
		[Cpp2IlInjected.Address(RVA = "0x218CDE0", Offset = "0x218B7E0", VA = "0x18218CDE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0038
			string text = interiorPrefabAddress_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)displays_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FCE")]
		[Cpp2IlInjected.Address(RVA = "0x32E6810", Offset = "0x32E5210", VA = "0x1832E6810", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FCF")]
		[Cpp2IlInjected.Address(RVA = "0x32E6870", Offset = "0x32E5270", VA = "0x1832E6870", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0044
			if (interiorPrefabAddress_.m_stringLength != 0)
			{
				string value = interiorPrefabAddress_;
				output.WriteString(value);
			}
			RepeatedField<Types.StoreDisplay> repeatedField = displays_;
			FieldCodec<Types.StoreDisplay> repeated_displays_codec = _repeated_displays_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_displays_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD0")]
		[Cpp2IlInjected.Address(RVA = "0x32E5FF0", Offset = "0x32E49F0", VA = "0x1832E5FF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0053
			string text = interiorPrefabAddress_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			RepeatedField<Types.StoreDisplay> repeatedField = displays_;
			FieldCodec<Types.StoreDisplay> repeated_displays_codec = _repeated_displays_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_displays_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num3;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD1")]
		[Cpp2IlInjected.Address(RVA = "0x32E6550", Offset = "0x32E4F50", VA = "0x1832E6550", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BenefitsStoreData other)
		{
			//Discarded unreachable code: IL_004e
			if (other != null)
			{
				string text = other.interiorPrefabAddress_;
				if (text.m_stringLength != 0)
				{
					InteriorPrefabAddress = text;
				}
				RepeatedField<Types.StoreDisplay> repeatedField = displays_;
				RepeatedField<Types.StoreDisplay> repeatedField2 = other.displays_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD2")]
		[Cpp2IlInjected.Address(RVA = "0x32E65F0", Offset = "0x32E4FF0", VA = "0x1832E65F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0052
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					string text2 = (InteriorPrefabAddress = input.ReadString());
				}
				if (num == 18)
				{
					RepeatedField<Types.StoreDisplay> repeatedField = displays_;
					FieldCodec<Types.StoreDisplay> repeated_displays_codec = _repeated_displays_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_displays_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD3")]
		[Cpp2IlInjected.Address(RVA = "0x32E64C0", Offset = "0x32E4EC0", VA = "0x1832E64C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = interiorPrefabAddress_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<Types.StoreDisplay> repeatedField = displays_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD4")]
		[Cpp2IlInjected.Address(RVA = "0x32E6700", Offset = "0x32E5100", VA = "0x1832E6700", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0019: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value == null || value != null)
				{
					string text = (interiorPrefabAddress_ = ProtoPreconditions.CheckNotNull((string)num, "value"));
					return;
				}
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD5")]
		[Cpp2IlInjected.Address(RVA = "0x32E60F0", Offset = "0x32E4AF0", VA = "0x1832E60F0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = (interiorPrefabAddress_ = ProtoPreconditions.CheckNotNull("", "value"));
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<Types.StoreDisplay> repeatedField = displays_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FD6")]
		[Cpp2IlInjected.Address(RVA = "0x32E6960", Offset = "0x32E5360", VA = "0x1832E6960")]
		static BenefitsStoreData()
		{
			Func<BenefitsStoreData> func = default(Func<BenefitsStoreData>);
			_parser = (MessageParser<BenefitsStoreData>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<Types.StoreDisplay> parser = Types.StoreDisplay._parser;
			uint num = default(uint);
			_parser = (MessageParser<BenefitsStoreData>)(object)FieldCodec.ForMessage<Types.StoreDisplay>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
