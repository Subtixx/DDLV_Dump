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
	[Cpp2IlInjected.Token(Token = "0x20010E8")]
	public sealed class AvatarTransferConfig : IHasItemDependencies, IMessage<AvatarTransferConfig>, IMessage, IEquatable<AvatarTransferConfig>, IDeepCloneable<AvatarTransferConfig>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40045CF")]
		private static readonly MessageParser<AvatarTransferConfig> _parser = (MessageParser<AvatarTransferConfig>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new AvatarTransferConfig()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40045D0")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40045D1")]
		public const int RedeemGiftsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40045D2")]
		private static readonly FieldCodec<int> _repeated_redeemGifts_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40045D3")]
		private readonly RepeatedField<int> redeemGifts_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170017EF")]
		public List<ItemType> ExclusiveItemTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6008995")]
			[Cpp2IlInjected.Address(RVA = "0x1AB2540", Offset = "0x1AB0F40", VA = "0x181AB2540", Slot = "4")]
			get
			{
				return (List<ItemType>)(object)new List<T>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017F0")]
		public bool AreItemsExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x6008996")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "5")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017F1")]
		public List<Item> ItemDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x6008997")]
			[Cpp2IlInjected.Address(RVA = "0x1AB25A0", Offset = "0x1AB0FA0", VA = "0x181AB25A0", Slot = "6")]
			get
			{
				RepeatedField<int> repeatedField = redeemGifts_;
				Func<int, Item> _003C_003E9__5_ = _003C_003Ec._003C_003E9__5_0;
				if (_003C_003E9__5_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => (Item)typeof(Item).TypeHandle);
				}
				return (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<int, Item>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)_003C_003E9__5_));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017F2")]
		[DebuggerNonUserCode]
		public static MessageParser<AvatarTransferConfig> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008998")]
			[Cpp2IlInjected.Address(RVA = "0x1AB26E0", Offset = "0x1AB10E0", VA = "0x181AB26E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017F3")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008999")]
			[Cpp2IlInjected.Address(RVA = "0x1AB2470", Offset = "0x1AB0E70", VA = "0x181AB2470")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017F4")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600899A")]
			[Cpp2IlInjected.Address(RVA = "0x1AB2740", Offset = "0x1AB1140", VA = "0x181AB2740", Slot = "11")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017F5")]
		[DebuggerNonUserCode]
		public RepeatedField<int> RedeemGifts
		{
			[Cpp2IlInjected.Token(Token = "0x600899E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return redeemGifts_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600899B")]
		[Cpp2IlInjected.Address(RVA = "0x1AB22F0", Offset = "0x1AB0CF0", VA = "0x181AB22F0")]
		[DebuggerNonUserCode]
		public AvatarTransferConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600899C")]
		[Cpp2IlInjected.Address(RVA = "0x1AB2370", Offset = "0x1AB0D70", VA = "0x181AB2370")]
		[DebuggerNonUserCode]
		public AvatarTransferConfig(AvatarTransferConfig other)
		{
			RepeatedField<int> repeatedField = (redeemGifts_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.redeemGifts_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600899D")]
		[Cpp2IlInjected.Address(RVA = "0x1AB1BA0", Offset = "0x1AB05A0", VA = "0x181AB1BA0", Slot = "13")]
		[DebuggerNonUserCode]
		public AvatarTransferConfig Clone()
		{
			//Discarded unreachable code: IL_003b
			AvatarTransferConfig avatarTransferConfig = new AvatarTransferConfig();
			RepeatedField<int> repeatedField = (avatarTransferConfig.redeemGifts_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<int> repeatedField2 = (avatarTransferConfig.redeemGifts_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)redeemGifts_).Clone());
			UnknownFieldSet unknownFieldSet = (avatarTransferConfig._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return avatarTransferConfig;
		}

		[Cpp2IlInjected.Token(Token = "0x600899F")]
		[Cpp2IlInjected.Address(RVA = "0x1AB1D60", Offset = "0x1AB0760", VA = "0x181AB1D60", Slot = "0")]
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
				RepeatedField<int> repeatedField = redeemGifts_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60089A0")]
		[Cpp2IlInjected.Address(RVA = "0x1AB1CD0", Offset = "0x1AB06D0", VA = "0x181AB1CD0", Slot = "12")]
		[DebuggerNonUserCode]
		public bool Equals(AvatarTransferConfig other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = redeemGifts_;
				RepeatedField<int> repeatedField2 = other.redeemGifts_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60089A1")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)redeemGifts_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60089A2")]
		[Cpp2IlInjected.Address(RVA = "0x1AB2090", Offset = "0x1AB0A90", VA = "0x181AB2090", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60089A3")]
		[Cpp2IlInjected.Address(RVA = "0x1AB20F0", Offset = "0x1AB0AF0", VA = "0x181AB20F0", Slot = "9")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<int> repeatedField = redeemGifts_;
			FieldCodec<int> repeated_redeemGifts_codec = _repeated_redeemGifts_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_redeemGifts_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60089A4")]
		[Cpp2IlInjected.Address(RVA = "0x1AB1A90", Offset = "0x1AB0490", VA = "0x181AB1A90", Slot = "10")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<int> repeatedField = redeemGifts_;
			FieldCodec<int> repeated_redeemGifts_codec = _repeated_redeemGifts_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_redeemGifts_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60089A5")]
		[Cpp2IlInjected.Address(RVA = "0x1AB1FB0", Offset = "0x1AB09B0", VA = "0x181AB1FB0", Slot = "7")]
		[DebuggerNonUserCode]
		public void MergeFrom(AvatarTransferConfig other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<int> repeatedField = redeemGifts_;
				RepeatedField<int> repeatedField2 = other.redeemGifts_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60089A6")]
		[Cpp2IlInjected.Address(RVA = "0x1AB1EC0", Offset = "0x1AB08C0", VA = "0x181AB1EC0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0042
			uint num = input.ReadTag();
			if (num != 0)
			{
				num += 4294967288u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<int> repeatedField = redeemGifts_;
				FieldCodec<int> repeated_redeemGifts_codec = _repeated_redeemGifts_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_redeemGifts_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60089A7")]
		[Cpp2IlInjected.Address(RVA = "0x1AB1E40", Offset = "0x1AB0840", VA = "0x181AB1E40", Slot = "14")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = redeemGifts_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60089A8")]
		[Cpp2IlInjected.Address(RVA = "0x1AB2030", Offset = "0x1AB0A30", VA = "0x181AB2030", Slot = "15")]
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

		[Cpp2IlInjected.Token(Token = "0x60089A9")]
		[Cpp2IlInjected.Address(RVA = "0x1AB1B40", Offset = "0x1AB0540", VA = "0x181AB1B40", Slot = "16")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = redeemGifts_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60089AA")]
		[Cpp2IlInjected.Address(RVA = "0x1AB21B0", Offset = "0x1AB0BB0", VA = "0x181AB21B0")]
		static AvatarTransferConfig()
		{
			_parser = (MessageParser<AvatarTransferConfig>)(object)FieldCodec.ForInt32(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
