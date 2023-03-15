using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Player
{
	[Cpp2IlInjected.Token(Token = "0x200024C")]
	public sealed class PlayerInfo : IMessage<PlayerInfo>, IMessage, IEquatable<PlayerInfo>, IDeepCloneable<PlayerInfo>, IMessageFieldAccessor, IHasItemDependencies
	{
		[Cpp2IlInjected.Token(Token = "0x4000929")]
		private static readonly MessageParser<PlayerInfo> _parser = (MessageParser<PlayerInfo>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new PlayerInfo()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400092A")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400092B")]
		public const int PlayerLevelsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400092C")]
		private static readonly FieldCodec<PlayerLevel> _repeated_playerLevels_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400092D")]
		private readonly RepeatedField<PlayerLevel> playerLevels_ = (RepeatedField<PlayerLevel>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400092E")]
		private List<Item> itemDependencies;

		[Cpp2IlInjected.Token(Token = "0x170004D6")]
		[DebuggerNonUserCode]
		public static MessageParser<PlayerInfo> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60015D2")]
			[Cpp2IlInjected.Address(RVA = "0x28770F0", Offset = "0x2875AF0", VA = "0x1828770F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60015D3")]
			[Cpp2IlInjected.Address(RVA = "0x2876D20", Offset = "0x2875720", VA = "0x182876D20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60015D4")]
			[Cpp2IlInjected.Address(RVA = "0x2877150", Offset = "0x2875B50", VA = "0x182877150", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D9")]
		[DebuggerNonUserCode]
		public RepeatedField<PlayerLevel> PlayerLevels
		{
			[Cpp2IlInjected.Token(Token = "0x60015D8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return playerLevels_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DA")]
		public List<ItemType> ExclusiveItemTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60015E4")]
			[Cpp2IlInjected.Address(RVA = "0x2876DF0", Offset = "0x28757F0", VA = "0x182876DF0", Slot = "14")]
			get
			{
				return (List<ItemType>)(object)new List<T>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DB")]
		public bool AreItemsExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x60015E5")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "15")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DC")]
		public List<Item> ItemDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x60015E6")]
			[Cpp2IlInjected.Address(RVA = "0x2876E50", Offset = "0x2875850", VA = "0x182876E50", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0059, IL_005f
				int num = 0;
				if ((IntPtr)itemDependencies == (IntPtr)num)
				{
					List<Item> list = (itemDependencies = (List<Item>)(object)new List<T>());
					RepeatedField<PlayerLevel> repeatedField = playerLevels_;
					bool flag = default(bool);
					if (flag)
					{
						List<Item> list2 = itemDependencies;
						if (_003C_003Ec._003C_003E9__34_0 == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ItemReward x) => x.Item);
						}
						IEnumerable<ItemReward> enumerable = default(IEnumerable<ItemReward>);
						((List<T>)(object)list2).AddRange((IEnumerable<>)enumerable);
					}
				}
				return itemDependencies;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015D5")]
		[Cpp2IlInjected.Address(RVA = "0x2876BA0", Offset = "0x28755A0", VA = "0x182876BA0")]
		[DebuggerNonUserCode]
		public PlayerInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60015D6")]
		[Cpp2IlInjected.Address(RVA = "0x2876C20", Offset = "0x2875620", VA = "0x182876C20")]
		[DebuggerNonUserCode]
		public PlayerInfo(PlayerInfo other)
		{
			RepeatedField<PlayerLevel> repeatedField = (playerLevels_ = (RepeatedField<PlayerLevel>)(object)((RepeatedField<T>)(object)other.playerLevels_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60015D7")]
		[Cpp2IlInjected.Address(RVA = "0x28763C0", Offset = "0x2874DC0", VA = "0x1828763C0", Slot = "10")]
		[DebuggerNonUserCode]
		public PlayerInfo Clone()
		{
			//Discarded unreachable code: IL_003b
			PlayerInfo playerInfo = new PlayerInfo();
			RepeatedField<PlayerLevel> repeatedField = (playerInfo.playerLevels_ = (RepeatedField<PlayerLevel>)(object)new RepeatedField<T>());
			RepeatedField<PlayerLevel> repeatedField2 = (playerInfo.playerLevels_ = (RepeatedField<PlayerLevel>)(object)((RepeatedField<T>)(object)playerLevels_).Clone());
			UnknownFieldSet unknownFieldSet = (playerInfo._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return playerInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x60015D9")]
		[Cpp2IlInjected.Address(RVA = "0x2876580", Offset = "0x2874F80", VA = "0x182876580", Slot = "0")]
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
				RepeatedField<PlayerLevel> repeatedField = playerLevels_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60015DA")]
		[Cpp2IlInjected.Address(RVA = "0x28764F0", Offset = "0x2874EF0", VA = "0x1828764F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PlayerInfo other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<PlayerLevel> repeatedField = playerLevels_;
				RepeatedField<PlayerLevel> repeatedField2 = other.playerLevels_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60015DB")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)playerLevels_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60015DC")]
		[Cpp2IlInjected.Address(RVA = "0x28768B0", Offset = "0x28752B0", VA = "0x1828768B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60015DD")]
		[Cpp2IlInjected.Address(RVA = "0x2876910", Offset = "0x2875310", VA = "0x182876910", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<PlayerLevel> repeatedField = playerLevels_;
			FieldCodec<PlayerLevel> repeated_playerLevels_codec = _repeated_playerLevels_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_playerLevels_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60015DE")]
		[Cpp2IlInjected.Address(RVA = "0x28762B0", Offset = "0x2874CB0", VA = "0x1828762B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0033
			RepeatedField<PlayerLevel> repeatedField = playerLevels_;
			FieldCodec<PlayerLevel> repeated_playerLevels_codec = _repeated_playerLevels_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_playerLevels_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60015DF")]
		[Cpp2IlInjected.Address(RVA = "0x28766E0", Offset = "0x28750E0", VA = "0x1828766E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PlayerInfo other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<PlayerLevel> repeatedField = playerLevels_;
				RepeatedField<PlayerLevel> repeatedField2 = other.playerLevels_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015E0")]
		[Cpp2IlInjected.Address(RVA = "0x2876760", Offset = "0x2875160", VA = "0x182876760", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<PlayerLevel> repeatedField = playerLevels_;
					FieldCodec<PlayerLevel> repeated_playerLevels_codec = _repeated_playerLevels_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_playerLevels_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015E1")]
		[Cpp2IlInjected.Address(RVA = "0x2876660", Offset = "0x2875060", VA = "0x182876660", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<PlayerLevel> repeatedField = playerLevels_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60015E2")]
		[Cpp2IlInjected.Address(RVA = "0x2876850", Offset = "0x2875250", VA = "0x182876850", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60015E3")]
		[Cpp2IlInjected.Address(RVA = "0x2876360", Offset = "0x2874D60", VA = "0x182876360", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<PlayerLevel> repeatedField = playerLevels_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015E7")]
		[Cpp2IlInjected.Address(RVA = "0x28769D0", Offset = "0x28753D0", VA = "0x1828769D0")]
		static PlayerInfo()
		{
			MessageParser<PlayerLevel> parser = PlayerLevel._parser;
			uint num = default(uint);
			_parser = (MessageParser<PlayerInfo>)(object)FieldCodec.ForMessage<PlayerLevel>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
