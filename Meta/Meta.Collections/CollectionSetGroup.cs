using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Collections
{
	[Cpp2IlInjected.Token(Token = "0x200110F")]
	public sealed class CollectionSetGroup : IMessage<CollectionSetGroup>, IMessage, IEquatable<CollectionSetGroup>, IDeepCloneable<CollectionSetGroup>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4004648")]
		private static readonly MessageParser<CollectionSetGroup> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004649")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400464A")]
		public const int GroupIndexFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400464B")]
		private int groupIndex_;

		[Cpp2IlInjected.Token(Token = "0x400464C")]
		public const int GroupsCollectionItemsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x400464D")]
		private static readonly MapField<int, bool>.Codec _map_groupsCollectionItems_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400464E")]
		private readonly MapField<int, bool> groupsCollectionItems_;

		[Cpp2IlInjected.Token(Token = "0x400464F")]
		public const int StateFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4004650")]
		private SetState state_;

		[Cpp2IlInjected.Token(Token = "0x4004651")]
		public const int GroupNameFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4004652")]
		private string groupName_;

		[Cpp2IlInjected.Token(Token = "0x17001863")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4004647")]
		public bool NeedsUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x6008B01")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6008B02")]
			[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001864")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionSetGroup> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008B03")]
			[Cpp2IlInjected.Address(RVA = "0x1678E00", Offset = "0x1677800", VA = "0x181678E00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001865")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008B04")]
			[Cpp2IlInjected.Address(RVA = "0x1678D30", Offset = "0x1677730", VA = "0x181678D30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001866")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008B05")]
			[Cpp2IlInjected.Address(RVA = "0x1678E60", Offset = "0x1677860", VA = "0x181678E60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001867")]
		[DebuggerNonUserCode]
		public int GroupIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6008B09")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return groupIndex_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008B0A")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				groupIndex_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001868")]
		[DebuggerNonUserCode]
		public MapField<int, bool> GroupsCollectionItems
		{
			[Cpp2IlInjected.Token(Token = "0x6008B0B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return groupsCollectionItems_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001869")]
		[DebuggerNonUserCode]
		public SetState State
		{
			[Cpp2IlInjected.Token(Token = "0x6008B0C")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return state_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008B0D")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				state_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700186A")]
		[DebuggerNonUserCode]
		public string GroupName
		{
			[Cpp2IlInjected.Token(Token = "0x6008B0E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return groupName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008B0F")]
			[Cpp2IlInjected.Address(RVA = "0x1678F70", Offset = "0x1677970", VA = "0x181678F70")]
			set
			{
				string text = (groupName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008B06")]
		[Cpp2IlInjected.Address(RVA = "0x1678BE0", Offset = "0x16775E0", VA = "0x181678BE0")]
		[DebuggerNonUserCode]
		public CollectionSetGroup()
		{
			groupsCollectionItems_ = (MapField<int, bool>)(object)new MapField<TKey, TValue>();
			groupName_ = "";
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6008B07")]
		[Cpp2IlInjected.Address(RVA = "0x1678C80", Offset = "0x1677680", VA = "0x181678C80")]
		[DebuggerNonUserCode]
		public CollectionSetGroup(CollectionSetGroup other)
		{
			int num = (groupIndex_ = other.groupIndex_);
			MapField<int, bool> mapField = (groupsCollectionItems_ = (MapField<int, bool>)(object)((MapField<TKey, TValue>)(object)other.groupsCollectionItems_).Clone());
			SetState setState = (state_ = other.state_);
			string text = (groupName_ = other.groupName_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008B08")]
		[Cpp2IlInjected.Address(RVA = "0x16780D0", Offset = "0x1676AD0", VA = "0x1816780D0", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionSetGroup Clone()
		{
			//Discarded unreachable code: IL_005c
			CollectionSetGroup collectionSetGroup = new CollectionSetGroup();
			int num = (collectionSetGroup.groupIndex_ = groupIndex_);
			MapField<int, bool> mapField = (collectionSetGroup.groupsCollectionItems_ = (MapField<int, bool>)(object)((MapField<TKey, TValue>)(object)groupsCollectionItems_).Clone());
			SetState setState = (collectionSetGroup.state_ = state_);
			string text = (collectionSetGroup.groupName_ = groupName_);
			UnknownFieldSet unknownFieldSet = (collectionSetGroup._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return collectionSetGroup;
		}

		[Cpp2IlInjected.Token(Token = "0x6008B10")]
		[Cpp2IlInjected.Address(RVA = "0x1678270", Offset = "0x1676C70", VA = "0x181678270", Slot = "0")]
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
				if ((IntPtr)groupIndex_ == (IntPtr)typeof(CollectionSetGroup).TypeHandle)
				{
					MapField<int, bool> mapField = groupsCollectionItems_;
					bool flag = default(bool);
					if (flag && state_ == (flag ? SetState.Completed : SetState.NotComplete))
					{
						string text = groupName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							return object.Equals(_unknownFields, other);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008B11")]
		[Cpp2IlInjected.Address(RVA = "0x16781B0", Offset = "0x1676BB0", VA = "0x1816781B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionSetGroup other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.groupIndex_;
				if (groupIndex_ == num)
				{
					MapField<int, bool> mapField = groupsCollectionItems_;
					MapField<int, bool> mapField2 = other.groupsCollectionItems_;
					if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
					{
						SetState setState = other.state_;
						if (state_ == setState)
						{
							string text = other.groupName_;
							if (!(groupName_ != text))
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008B12")]
		[Cpp2IlInjected.Address(RVA = "0x1678470", Offset = "0x1676E70", VA = "0x181678470", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004f
			int num = 0;
			if (groupIndex_ != 0)
			{
			}
			int hashCode = ((MapField<TKey, TValue>)(object)groupsCollectionItems_).GetHashCode();
			if (state_ != 0)
			{
			}
			string text = groupName_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6008B13")]
		[Cpp2IlInjected.Address(RVA = "0x16788A0", Offset = "0x16772A0", VA = "0x1816788A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008B14")]
		[Cpp2IlInjected.Address(RVA = "0x1678900", Offset = "0x1677300", VA = "0x181678900", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0067
			if (groupIndex_ != 0)
			{
				int value = groupIndex_;
				output.WriteInt32(value);
			}
			MapField<int, bool> mapField = groupsCollectionItems_;
			MapField<int, bool>.Codec map_groupsCollectionItems_codec = _map_groupsCollectionItems_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_groupsCollectionItems_codec);
			if (state_ != 0)
			{
			}
			if (groupName_.m_stringLength != 0)
			{
				string value2 = groupName_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008B15")]
		[Cpp2IlInjected.Address(RVA = "0x1677EB0", Offset = "0x16768B0", VA = "0x181677EB0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0095
			int num = groupIndex_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			MapField<int, bool> mapField = groupsCollectionItems_;
			MapField<int, bool>.Codec map_groupsCollectionItems_codec = _map_groupsCollectionItems_codec;
			int num4 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_groupsCollectionItems_codec);
			SetState setState = state_;
			num2 += num4;
			if (setState != 0)
			{
				int num5 = CodedOutputStream.ComputeEnumSize((int)setState);
				num5++;
				num2 += num5;
			}
			string text = groupName_;
			if (text.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text);
				num6++;
				num2 += num6;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num7 = unknownFields.CalculateSize();
				num2 += num7;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6008B16")]
		[Cpp2IlInjected.Address(RVA = "0x1678670", Offset = "0x1677070", VA = "0x181678670", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionSetGroup other)
		{
			//Discarded unreachable code: IL_0077
			if (other != null)
			{
				int num = other.groupIndex_;
				if (num != 0)
				{
					groupIndex_ = num;
				}
				MapField<int, bool> mapField = groupsCollectionItems_;
				MapField<int, bool> mapField2 = other.groupsCollectionItems_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				SetState setState = other.state_;
				if (setState != 0)
				{
					state_ = setState;
				}
				string text = other.groupName_;
				if (text.m_stringLength != 0)
				{
					GroupName = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008B17")]
		[Cpp2IlInjected.Address(RVA = "0x1678530", Offset = "0x1676F30", VA = "0x181678530", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0085
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 32)
				{
					int num2 = (int)(state_ = (SetState)input.ReadInt32());
				}
				if (num != 42)
				{
					goto IL_006e;
				}
				string text2 = (GroupName = input.ReadString());
			}
			int num3 = default(int);
			if (num == 8)
			{
				num3 = (groupIndex_ = input.ReadInt32());
			}
			if (num3 == 18)
			{
				MapField<int, bool> mapField = groupsCollectionItems_;
				MapField<int, bool>.Codec map_groupsCollectionItems_codec = _map_groupsCollectionItems_codec;
				((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_groupsCollectionItems_codec);
			}
			goto IL_006e;
			IL_006e:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6008B18")]
		[Cpp2IlInjected.Address(RVA = "0x1678370", Offset = "0x1676D70", VA = "0x181678370", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0)
					{
						goto IL_002d;
					}
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_002d;
						}
						string text = groupName_;
					}
				}
				MapField<int, bool> mapField = groupsCollectionItems_;
			}
			int num2 = groupIndex_;
			goto IL_002d;
			IL_002d:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008B19")]
		[Cpp2IlInjected.Address(RVA = "0x1678720", Offset = "0x1677120", VA = "0x181678720", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_003a
			//IL_0029: Expected O, but got I4
			//IL_0039: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num == 0)
					{
						return;
					}
					switch (num)
					{
					case 1:
						break;
					default:
						return;
					case 0:
						state_ = SetState.NotComplete;
						return;
					}
					int num2 = 0;
					if (value == null || value != null)
					{
						GroupName = (string)num2;
						return;
					}
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				/*Error: Unexpected end of block*/;
			}
			object obj = default(object);
			groupIndex_ = (int)obj;
		}

		[Cpp2IlInjected.Token(Token = "0x6008B1A")]
		[Cpp2IlInjected.Address(RVA = "0x1678010", Offset = "0x1676A10", VA = "0x181678010", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_003f
			//IL_002d: Expected I4, but got I8
			//IL_003e: Expected I4, but got I8
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
							GroupName = "";
							break;
						case 0:
							state_ = SetState.NotComplete;
							break;
						}
					}
					return;
				}
				MapField<int, bool> mapField = groupsCollectionItems_;
			}
			groupIndex_ = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6008B1B")]
		[Cpp2IlInjected.Address(RVA = "0x1678A40", Offset = "0x1677440", VA = "0x181678A40")]
		static CollectionSetGroup()
		{
			Func<CollectionSetGroup> func = default(Func<CollectionSetGroup>);
			_parser = (MessageParser<CollectionSetGroup>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<int> fieldCodec = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			FieldCodec<bool> fieldCodec2 = (FieldCodec<bool>)(object)FieldCodec.ForBool(16u);
			uint num = default(uint);
			_parser = (MessageParser<CollectionSetGroup>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, (FieldCodec<>)(object)fieldCodec2, num);
			/*Error: Unexpected end of block*/;
		}
	}
}
