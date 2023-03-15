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
using StoreFrontEnums;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class StoreFrontGroup : IMessage<StoreFrontGroup>, IMessage, IEquatable<StoreFrontGroup>, IDeepCloneable<StoreFrontGroup>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private static readonly MessageParser<StoreFrontGroup> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public const int UniqueNameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private string uniqueName_ = "";

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public const int SupportedStoreFrontFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private static readonly FieldCodec<SupportedMarketplaceType> _repeated_supportedStoreFront_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private readonly RepeatedField<SupportedMarketplaceType> supportedStoreFront_ = (RepeatedField<SupportedMarketplaceType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public const int CustomStoreFrontFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private static readonly FieldCodec<UnsupportedMarketplaceType> _repeated_customStoreFront_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private readonly RepeatedField<UnsupportedMarketplaceType> customStoreFront_ = (RepeatedField<UnsupportedMarketplaceType>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public const int OriginIdsFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly FieldCodec<PlayfabOriginId> _repeated_originIds_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private readonly RepeatedField<PlayfabOriginId> originIds_ = (RepeatedField<PlayfabOriginId>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		[DebuggerNonUserCode]
		public static MessageParser<StoreFrontGroup> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600088A")]
			[Cpp2IlInjected.Address(RVA = "0x263DE40", Offset = "0x263C840", VA = "0x18263DE40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600088B")]
			[Cpp2IlInjected.Address(RVA = "0x263DD70", Offset = "0x263C770", VA = "0x18263DD70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600088C")]
			[Cpp2IlInjected.Address(RVA = "0x263DEA0", Offset = "0x263C8A0", VA = "0x18263DEA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		[DebuggerNonUserCode]
		public string UniqueName
		{
			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return uniqueName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x263E020", Offset = "0x263CA20", VA = "0x18263E020")]
			set
			{
				string text = (uniqueName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		[DebuggerNonUserCode]
		public RepeatedField<SupportedMarketplaceType> SupportedStoreFront
		{
			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return supportedStoreFront_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		[DebuggerNonUserCode]
		public RepeatedField<UnsupportedMarketplaceType> CustomStoreFront
		{
			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return customStoreFront_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		[DebuggerNonUserCode]
		public RepeatedField<PlayfabOriginId> OriginIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return originIds_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000221")]
		public static StoreFrontGroup CurrentStoreFrontGroup
		{
			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0x263DD10", Offset = "0x263C710", VA = "0x18263DD10")]
			[CompilerGenerated]
			get
			{
				return _003CCurrentStoreFrontGroup_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0x263DFB0", Offset = "0x263C9B0", VA = "0x18263DFB0")]
			[CompilerGenerated]
			private set
			{
				_parser = (MessageParser<StoreFrontGroup>)(object)value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x263DBF0", Offset = "0x263C5F0", VA = "0x18263DBF0")]
		[DebuggerNonUserCode]
		public StoreFrontGroup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x263D9C0", Offset = "0x263C3C0", VA = "0x18263D9C0")]
		[DebuggerNonUserCode]
		public StoreFrontGroup(StoreFrontGroup other)
		{
			string text = (uniqueName_ = other.uniqueName_);
			RepeatedField<SupportedMarketplaceType> repeatedField = (supportedStoreFront_ = (RepeatedField<SupportedMarketplaceType>)(object)((RepeatedField<T>)(object)other.supportedStoreFront_).Clone());
			RepeatedField<UnsupportedMarketplaceType> repeatedField2 = (customStoreFront_ = (RepeatedField<UnsupportedMarketplaceType>)(object)((RepeatedField<T>)(object)other.customStoreFront_).Clone());
			RepeatedField<PlayfabOriginId> repeatedField3 = (originIds_ = (RepeatedField<PlayfabOriginId>)(object)((RepeatedField<T>)(object)other.originIds_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x263BE00", Offset = "0x263A800", VA = "0x18263BE00", Slot = "10")]
		[DebuggerNonUserCode]
		public StoreFrontGroup Clone()
		{
			return new StoreFrontGroup(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x263C6A0", Offset = "0x263B0A0", VA = "0x18263C6A0", Slot = "0")]
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
				string text = uniqueName_;
				bool flag = default(bool);
				if (!flag)
				{
					RepeatedField<SupportedMarketplaceType> repeatedField = supportedStoreFront_;
					bool flag2 = default(bool);
					if (flag2)
					{
						RepeatedField<UnsupportedMarketplaceType> repeatedField2 = customStoreFront_;
						bool flag3 = default(bool);
						if (flag3)
						{
							RepeatedField<PlayfabOriginId> repeatedField3 = originIds_;
							bool flag4 = default(bool);
							if (flag4)
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

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x263C7F0", Offset = "0x263B1F0", VA = "0x18263C7F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StoreFrontGroup other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.uniqueName_;
				if (!(uniqueName_ != text))
				{
					RepeatedField<SupportedMarketplaceType> repeatedField = supportedStoreFront_;
					RepeatedField<SupportedMarketplaceType> repeatedField2 = other.supportedStoreFront_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						RepeatedField<UnsupportedMarketplaceType> repeatedField3 = customStoreFront_;
						RepeatedField<UnsupportedMarketplaceType> repeatedField4 = other.customStoreFront_;
						if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
						{
							RepeatedField<PlayfabOriginId> repeatedField5 = originIds_;
							RepeatedField<PlayfabOriginId> repeatedField6 = other.originIds_;
							if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x263CCB0", Offset = "0x263B6B0", VA = "0x18263CCB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0059
			string text = uniqueName_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			int hashCode2 = ((RepeatedField<T>)(object)supportedStoreFront_).GetHashCode();
			int hashCode3 = ((RepeatedField<T>)(object)customStoreFront_).GetHashCode();
			int hashCode4 = ((RepeatedField<T>)(object)originIds_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return hashCode4;
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x263D3C0", Offset = "0x263BDC0", VA = "0x18263D3C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x263D450", Offset = "0x263BE50", VA = "0x18263D450", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0077
			if (uniqueName_.m_stringLength != 0)
			{
				string value = uniqueName_;
				output.WriteString(value);
			}
			RepeatedField<SupportedMarketplaceType> repeatedField = supportedStoreFront_;
			FieldCodec<SupportedMarketplaceType> repeated_supportedStoreFront_codec = _repeated_supportedStoreFront_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_supportedStoreFront_codec);
			RepeatedField<UnsupportedMarketplaceType> repeatedField2 = customStoreFront_;
			FieldCodec<UnsupportedMarketplaceType> repeated_customStoreFront_codec = _repeated_customStoreFront_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_customStoreFront_codec);
			RepeatedField<PlayfabOriginId> repeatedField3 = originIds_;
			FieldCodec<PlayfabOriginId> repeated_originIds_codec = _repeated_originIds_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_originIds_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x263BBF0", Offset = "0x263A5F0", VA = "0x18263BBF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_007d
			string text = uniqueName_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			RepeatedField<SupportedMarketplaceType> repeatedField = supportedStoreFront_;
			FieldCodec<SupportedMarketplaceType> repeated_supportedStoreFront_codec = _repeated_supportedStoreFront_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_supportedStoreFront_codec);
			RepeatedField<UnsupportedMarketplaceType> repeatedField2 = customStoreFront_;
			FieldCodec<UnsupportedMarketplaceType> repeated_customStoreFront_codec = _repeated_customStoreFront_codec;
			int num4 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_customStoreFront_codec);
			RepeatedField<PlayfabOriginId> repeatedField3 = originIds_;
			FieldCodec<PlayfabOriginId> repeated_originIds_codec = _repeated_originIds_codec;
			int num5 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_originIds_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x263CD90", Offset = "0x263B790", VA = "0x18263CD90", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StoreFrontGroup other)
		{
			//Discarded unreachable code: IL_0080
			if (other != null)
			{
				string text = other.uniqueName_;
				if (text.m_stringLength != 0)
				{
					UniqueName = text;
				}
				RepeatedField<SupportedMarketplaceType> repeatedField = supportedStoreFront_;
				RepeatedField<SupportedMarketplaceType> repeatedField2 = other.supportedStoreFront_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				RepeatedField<UnsupportedMarketplaceType> repeatedField3 = customStoreFront_;
				RepeatedField<UnsupportedMarketplaceType> repeatedField4 = other.customStoreFront_;
				((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
				RepeatedField<PlayfabOriginId> repeatedField5 = originIds_;
				RepeatedField<PlayfabOriginId> repeatedField6 = other.originIds_;
				((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x263CE80", Offset = "0x263B880", VA = "0x18263CE80", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00b3
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if ((int)num > 34)
				{
					num += 4294967256u;
					if (num != 4294967293u)
					{
						goto IL_0083;
					}
					RepeatedField<PlayfabOriginId> repeatedField = originIds_;
					FieldCodec<PlayfabOriginId> repeated_originIds_codec = _repeated_originIds_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_originIds_codec);
				}
				num += 4294967264u;
				if (num != 4294967293u)
				{
					goto IL_0083;
				}
				RepeatedField<UnsupportedMarketplaceType> repeatedField2 = customStoreFront_;
				FieldCodec<UnsupportedMarketplaceType> repeated_customStoreFront_codec = _repeated_customStoreFront_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_customStoreFront_codec);
			}
			string text2 = default(string);
			if (num == 18)
			{
				text2 = (UniqueName = input.ReadString());
			}
			if ((long)text2 != 4294967293L)
			{
				goto IL_0083;
			}
			goto IL_0099;
			IL_0099:
			RepeatedField<SupportedMarketplaceType> repeatedField3 = supportedStoreFront_;
			FieldCodec<SupportedMarketplaceType> repeated_supportedStoreFront_codec = _repeated_supportedStoreFront_codec;
			((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_supportedStoreFront_codec);
			return;
			IL_0083:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			goto IL_0099;
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x263CC00", Offset = "0x263B600", VA = "0x18263CC00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<PlayfabOriginId> repeatedField = originIds_;
				RepeatedField<UnsupportedMarketplaceType> repeatedField2 = customStoreFront_;
				RepeatedField<SupportedMarketplaceType> repeatedField3 = supportedStoreFront_;
				string text = uniqueName_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x263D250", Offset = "0x263BC50", VA = "0x18263D250", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0021: Expected O, but got I4
			while (fieldNumber != 0)
			{
				if (fieldNumber != 0)
				{
					switch (fieldNumber)
					{
					case 0:
						continue;
					case 1:
					{
						InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
						/*Error: Unexpected end of block*/;
					}
					}
					break;
				}
			}
			int num = 0;
			if (value == null || value != null)
			{
				UniqueName = (string)num;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x263BD60", Offset = "0x263A760", VA = "0x18263BD60", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0023
			if (fieldNumber != 0)
			{
				if (fieldNumber != 0 && fieldNumber != 0 && fieldNumber != 1)
				{
					return;
				}
				RepeatedField<SupportedMarketplaceType> repeatedField = supportedStoreFront_;
			}
			UniqueName = "";
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x263C900", Offset = "0x263B300", VA = "0x18263C900")]
		public static IEnumerable<StoreFrontGroup> GetAll()
		{
			//Discarded unreachable code: IL_000b
			return (IEnumerable<StoreFrontGroup>)ProtoDatabase.Instance.Enumerate<StoreFrontGroup>();
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x263CAE0", Offset = "0x263B4E0", VA = "0x18263CAE0")]
		public static StoreFrontGroup GetByUniqueName(string uniqueName)
		{
			//Discarded unreachable code: IL_002a
			_003C_003Ec__DisplayClass44_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass44_0();
			CS_0024_003C_003E8__locals0.uniqueName = uniqueName;
			int num = 0;
			IEnumerable<StoreFrontGroup> all = (IEnumerable<StoreFrontGroup>)StoreFrontGroup.GetAll();
			Func<StoreFrontGroup, bool> func = (Func<StoreFrontGroup, bool>)(object)(Func<T, TResult>)delegate(StoreFrontGroup x)
			{
				//Discarded unreachable code: IL_0014
				string uniqueName2 = CS_0024_003C_003E8__locals0.uniqueName;
				return string.Equals(x.uniqueName_, uniqueName2);
			};
			return Enumerable.FirstOrDefault<StoreFrontGroup>((IEnumerable<>)all, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0x263C9C0", Offset = "0x263B3C0", VA = "0x18263C9C0")]
		public static StoreFrontGroup GetByOriginId(PlayfabOriginId oriId)
		{
			//Discarded unreachable code: IL_0033
			int num = 0;
			IEnumerable<StoreFrontGroup> all = (IEnumerable<StoreFrontGroup>)StoreFrontGroup.GetAll();
			Func<StoreFrontGroup, bool> func = (Func<StoreFrontGroup, bool>)(object)(Func<T, TResult>)delegate(StoreFrontGroup x)
			{
				//Discarded unreachable code: IL_0016
				//IL_0015: Expected O, but got I4
				RepeatedField<PlayfabOriginId> repeatedField = x.originIds_;
				PlayfabOriginId playfabOriginId = oriId;
				return ((RepeatedField<T>)(object)repeatedField).Contains((T)playfabOriginId);
			};
			return Enumerable.FirstOrDefault<StoreFrontGroup>(Enumerable.Where<StoreFrontGroup>((IEnumerable<>)all, (Func<, >)(object)func));
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x263D090", Offset = "0x263BA90", VA = "0x18263D090")]
		public static void SetCurrentStoreOrigin(PlayfabOriginId origin)
		{
			int num = 0;
			IEnumerable<StoreFrontGroup> all = (IEnumerable<StoreFrontGroup>)StoreFrontGroup.GetAll();
			Func<StoreFrontGroup, bool> func = (Func<StoreFrontGroup, bool>)(object)(Func<T, TResult>)delegate(StoreFrontGroup x)
			{
				//Discarded unreachable code: IL_0016
				//IL_0015: Expected O, but got I4
				RepeatedField<PlayfabOriginId> repeatedField = x.originIds_;
				PlayfabOriginId playfabOriginId = origin;
				return ((RepeatedField<T>)(object)repeatedField).Contains((T)playfabOriginId);
			};
			_parser = (MessageParser<StoreFrontGroup>)(object)Enumerable.FirstOrDefault<StoreFrontGroup>(Enumerable.Where<StoreFrontGroup>((IEnumerable<>)all, (Func<, >)(object)func));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x263BE60", Offset = "0x263A860", VA = "0x18263BE60", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_01cd, IL_01d3, IL_01df, IL_01eb
			//IL_00f5: Expected O, but got I4
			//IL_0120: Expected O, but got I4
			//IL_0165: Expected O, but got I4
			//IL_01c2: Expected O, but got I4
			bool flag = default(bool);
			SupportedMarketplaceType supportedMarketplaceType = default(SupportedMarketplaceType);
			bool flag2 = default(bool);
			UnsupportedMarketplaceType unsupportedMarketplaceType = default(UnsupportedMarketplaceType);
			bool flag3 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				string text = uniqueName_;
				if (num2 == 0)
				{
					int num5 = 0;
					IEnumerable<StoreFrontGroup> all = (IEnumerable<StoreFrontGroup>)StoreFrontGroup.GetAll();
					Func<StoreFrontGroup, bool> func = (Func<StoreFrontGroup, bool>)(object)(Func<T, TResult>)delegate(StoreFrontGroup x)
					{
						//Discarded unreachable code: IL_0014
						string b = x.uniqueName_;
						return string.Equals(uniqueName_, b);
					};
					if (Enumerable.Count<StoreFrontGroup>(Enumerable.Where<StoreFrontGroup>((IEnumerable<>)all, (Func<, >)(object)func)) == 1)
					{
						goto IL_0068;
					}
					string text2 = uniqueName_;
					string text3 = "UniqueName Must be Unique '" + text2 + "' already used";
				}
				context.AddInvalidMemberError("UniqueName Cannot be empty", "UniqueName");
				goto IL_0068;
				IL_0068:
				if (((RepeatedField<T>)(object)supportedStoreFront_).Count == 0 && ((RepeatedField<T>)(object)customStoreFront_).Count == 0)
				{
					context.AddInvalidMemberError("You must specify at least one SupportedStoreFront or CustomStoreFront", "SupportedStoreFront");
				}
				RepeatedField<SupportedMarketplaceType> repeatedField = supportedStoreFront_;
				if (flag)
				{
					SupportedMarketplaceType store = SupportedMarketplaceType.Amazon;
					int num6 = 0;
					IEnumerable<StoreFrontGroup> all2 = (IEnumerable<StoreFrontGroup>)StoreFrontGroup.GetAll();
					Func<SupportedMarketplaceType, bool> func2 = default(Func<SupportedMarketplaceType, bool>);
					Func<StoreFrontGroup, bool> cpp2il__autoParamName__idx_ = (Func<StoreFrontGroup, bool>)(object)(Func<T, TResult>)delegate(StoreFrontGroup x)
					{
						//Discarded unreachable code: IL_004b
						string text7 = uniqueName_;
						bool flag5 = x.uniqueName_ != text7;
						if (!flag5)
						{
							return flag5;
						}
						RepeatedField<SupportedMarketplaceType> cpp2il__autoParamName__idx_5 = x.supportedStoreFront_;
						Func<SupportedMarketplaceType, bool> cpp2il__autoParamName__idx_6 = default(Func<SupportedMarketplaceType, bool>);
						if (func2 == null)
						{
							cpp2il__autoParamName__idx_6 = (func2 = (Func<SupportedMarketplaceType, bool>)(object)(Func<T, TResult>)((SupportedMarketplaceType y) => y == store));
						}
						return ((IEnumerable<>)(object)cpp2il__autoParamName__idx_5).Any<SupportedMarketplaceType>((Func<, >)(object)cpp2il__autoParamName__idx_6);
					};
					if (!((IEnumerable<>)all2).Any<StoreFrontGroup>((Func<, >)(object)cpp2il__autoParamName__idx_))
					{
						continue;
					}
					supportedMarketplaceType = store;
					string message = $"SupportedStoreFront={supportedMarketplaceType} already in another StoreFrontGroup";
					context.AddInvalidMemberError(message, "SupportedStoreFront");
				}
				if (supportedMarketplaceType == SupportedMarketplaceType.Amazon)
				{
					if (flag2)
					{
						StoreFrontGroup storeFrontGroup = (StoreFrontGroup)0;
						UnsupportedMarketplaceType store2 = (UnsupportedMarketplaceType)num2;
						int num7 = 0;
						IEnumerable<StoreFrontGroup> all3 = (IEnumerable<StoreFrontGroup>)StoreFrontGroup.GetAll();
						Func<UnsupportedMarketplaceType, bool> func3 = default(Func<UnsupportedMarketplaceType, bool>);
						Func<StoreFrontGroup, bool> cpp2il__autoParamName__idx_2 = (Func<StoreFrontGroup, bool>)(object)(Func<T, TResult>)delegate(StoreFrontGroup x)
						{
							//Discarded unreachable code: IL_004b
							string text6 = storeFrontGroup.uniqueName_;
							bool flag4 = x.uniqueName_ != text6;
							if (!flag4)
							{
								return flag4;
							}
							RepeatedField<UnsupportedMarketplaceType> cpp2il__autoParamName__idx_3 = x.customStoreFront_;
							Func<UnsupportedMarketplaceType, bool> cpp2il__autoParamName__idx_4 = default(Func<UnsupportedMarketplaceType, bool>);
							if (func3 == null)
							{
								cpp2il__autoParamName__idx_4 = (func3 = (Func<UnsupportedMarketplaceType, bool>)(object)(Func<T, TResult>)((UnsupportedMarketplaceType y) => y == store2));
							}
							return ((IEnumerable<>)(object)cpp2il__autoParamName__idx_3).Any<UnsupportedMarketplaceType>((Func<, >)(object)cpp2il__autoParamName__idx_4);
						};
						if (!((IEnumerable<>)all3).Any<StoreFrontGroup>((Func<, >)(object)cpp2il__autoParamName__idx_2))
						{
							continue;
						}
						unsupportedMarketplaceType = store2;
						string text4 = $"CustomStoreFront={unsupportedMarketplaceType} already in another StoreFrontGroup";
					}
					if (unsupportedMarketplaceType != 0)
					{
						break;
					}
					if (flag3)
					{
						PlayfabOriginId oriId = (PlayfabOriginId)num2;
						int num8 = 0;
						IEnumerable<StoreFrontGroup> all4 = (IEnumerable<StoreFrontGroup>)StoreFrontGroup.GetAll();
						Func<StoreFrontGroup, bool> func4 = (Func<StoreFrontGroup, bool>)(object)(Func<T, TResult>)delegate(StoreFrontGroup x)
						{
							//Discarded unreachable code: IL_0016
							//IL_0015: Expected O, but got I4
							RepeatedField<PlayfabOriginId> repeatedField2 = x.originIds_;
							PlayfabOriginId playfabOriginId2 = oriId;
							return ((RepeatedField<T>)(object)repeatedField2).Contains((T)playfabOriginId2);
						};
						if (Enumerable.Count<StoreFrontGroup>(Enumerable.Where<StoreFrontGroup>((IEnumerable<>)all4, (Func<, >)(object)func4)) == 1)
						{
							continue;
						}
						PlayfabOriginId playfabOriginId = oriId;
						string text5 = $"OriginId={playfabOriginId} already in another StoreFrontGroup";
					}
					if (unsupportedMarketplaceType == UnsupportedMarketplaceType.MarketplaceEpicId)
					{
						return;
					}
					continue;
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x263D5B0", Offset = "0x263BFB0", VA = "0x18263D5B0")]
		static StoreFrontGroup()
		{
			Func<StoreFrontGroup> func = default(Func<StoreFrontGroup>);
			MessageParser<StoreFrontGroup> CS_0024_003C_003E8__locals0 = (_parser = (MessageParser<StoreFrontGroup>)(object)new MessageParser<T>((Func<>)(object)func));
			Func<SupportedMarketplaceType, int> func2 = (Func<SupportedMarketplaceType, int>)(object)(Func<T, TResult>)((SupportedMarketplaceType x) => (int)x);
			Func<int, SupportedMarketplaceType> func3 = (Func<int, SupportedMarketplaceType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num = default(uint);
			_parser = (MessageParser<StoreFrontGroup>)(object)FieldCodec.ForEnum<SupportedMarketplaceType>(num, (Func<, >)(object)func2, (Func<, >)(object)func3);
			Func<UnsupportedMarketplaceType, int> func4 = (Func<UnsupportedMarketplaceType, int>)(object)(Func<T, TResult>)((UnsupportedMarketplaceType x) => (int)x);
			Func<int, UnsupportedMarketplaceType> func5 = (Func<int, UnsupportedMarketplaceType>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num2 = default(uint);
			_parser = (MessageParser<StoreFrontGroup>)(object)FieldCodec.ForEnum<UnsupportedMarketplaceType>(num2, (Func<, >)(object)func4, (Func<, >)(object)func5);
			Func<PlayfabOriginId, int> func6 = (Func<PlayfabOriginId, int>)(object)(Func<T, TResult>)((PlayfabOriginId x) => (int)x);
			Func<int, PlayfabOriginId> func7 = (Func<int, PlayfabOriginId>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			uint num3 = default(uint);
			_parser = (MessageParser<StoreFrontGroup>)(object)FieldCodec.ForEnum<PlayfabOriginId>(num3, (Func<, >)(object)func6, (Func<, >)(object)func7);
			/*Error: Unexpected end of block*/;
		}
	}
}
