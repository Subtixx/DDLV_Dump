using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000913")]
	public sealed class BuildingInfo : IMessage<BuildingInfo>, IMessage, IEquatable<BuildingInfo>, IDeepCloneable<BuildingInfo>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000914")]
		public enum GridsOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40024D4")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40024D5")]
			GridIDs,
			[Cpp2IlInjected.Token(Token = "0x40024D6")]
			Room
		}

		[Cpp2IlInjected.Token(Token = "0x2000915")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000916")]
			public sealed class GridIDList : IMessage<GridIDList>, IMessage, IEquatable<GridIDList>, IDeepCloneable<GridIDList>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40024D7")]
				private static readonly MessageParser<GridIDList> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40024D8")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40024D9")]
				public const int ListFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x40024DA")]
				private static readonly FieldCodec<uint> _repeated_list_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40024DB")]
				private readonly RepeatedField<uint> list_;

				[Cpp2IlInjected.Token(Token = "0x17000D74")]
				[DebuggerNonUserCode]
				public static MessageParser<GridIDList> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004EFC")]
					[Cpp2IlInjected.Address(RVA = "0x27242B0", Offset = "0x2722CB0", VA = "0x1827242B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000D75")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004EFD")]
					[Cpp2IlInjected.Address(RVA = "0x2724230", Offset = "0x2722C30", VA = "0x182724230")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000D76")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004EFE")]
					[Cpp2IlInjected.Address(RVA = "0x2724310", Offset = "0x2722D10", VA = "0x182724310", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000D77")]
				[DebuggerNonUserCode]
				public RepeatedField<uint> List
				{
					[Cpp2IlInjected.Token(Token = "0x6004F02")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004EFF")]
				[Cpp2IlInjected.Address(RVA = "0x27240B0", Offset = "0x2722AB0", VA = "0x1827240B0")]
				[DebuggerNonUserCode]
				public GridIDList()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004F00")]
				[Cpp2IlInjected.Address(RVA = "0x2724130", Offset = "0x2722B30", VA = "0x182724130")]
				[DebuggerNonUserCode]
				public GridIDList(GridIDList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004F01")]
				[Cpp2IlInjected.Address(RVA = "0x2723960", Offset = "0x2722360", VA = "0x182723960", Slot = "10")]
				[DebuggerNonUserCode]
				public GridIDList Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004F03")]
				[Cpp2IlInjected.Address(RVA = "0x2723A90", Offset = "0x2722490", VA = "0x182723A90", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004F04")]
				[Cpp2IlInjected.Address(RVA = "0x2723B70", Offset = "0x2722570", VA = "0x182723B70", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(GridIDList other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6004F05")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004F06")]
				[Cpp2IlInjected.Address(RVA = "0x2723E50", Offset = "0x2722850", VA = "0x182723E50", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004F07")]
				[Cpp2IlInjected.Address(RVA = "0x2723EB0", Offset = "0x27228B0", VA = "0x182723EB0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004F08")]
				[Cpp2IlInjected.Address(RVA = "0x2723850", Offset = "0x2722250", VA = "0x182723850", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004F09")]
				[Cpp2IlInjected.Address(RVA = "0x2723C80", Offset = "0x2722680", VA = "0x182723C80", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(GridIDList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004F0A")]
				[Cpp2IlInjected.Address(RVA = "0x2723D00", Offset = "0x2722700", VA = "0x182723D00", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004F0B")]
				[Cpp2IlInjected.Address(RVA = "0x2723C00", Offset = "0x2722600", VA = "0x182723C00", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004F0C")]
				[Cpp2IlInjected.Address(RVA = "0x2723DF0", Offset = "0x27227F0", VA = "0x182723DF0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004F0D")]
				[Cpp2IlInjected.Address(RVA = "0x2723900", Offset = "0x2722300", VA = "0x182723900", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40024CB")]
		private static readonly MessageParser<BuildingInfo> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024CC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40024CD")]
		public const int GridIDsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40024CE")]
		public const int RoomFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40024CF")]
		public const int CustomLocationPositionsPathFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024D0")]
		private string customLocationPositionsPath_ = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024D1")]
		private object grids_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40024D2")]
		private GridsOneofCase gridsCase_;

		[Cpp2IlInjected.Token(Token = "0x17000D6C")]
		[DebuggerNonUserCode]
		public static MessageParser<BuildingInfo> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004EDC")]
			[Cpp2IlInjected.Address(RVA = "0x1AC6290", Offset = "0x1AC4C90", VA = "0x181AC6290")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D6D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004EDD")]
			[Cpp2IlInjected.Address(RVA = "0x1AC6160", Offset = "0x1AC4B60", VA = "0x181AC6160")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D6E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004EDE")]
			[Cpp2IlInjected.Address(RVA = "0x1AC6350", Offset = "0x1AC4D50", VA = "0x181AC6350", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D6F")]
		[DebuggerNonUserCode]
		public Types.GridIDList GridIDs
		{
			[Cpp2IlInjected.Token(Token = "0x6004EE2")]
			[Cpp2IlInjected.Address(RVA = "0x1AC6230", Offset = "0x1AC4C30", VA = "0x181AC6230")]
			get
			{
				int num = 0;
				if (gridsCase_ == GridsOneofCase.GridIDs)
				{
					object obj = grids_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004EE3")]
			[Cpp2IlInjected.Address(RVA = "0x7FE120", Offset = "0x7FCB20", VA = "0x1807FE120")]
			set
			{
				grids_ = value;
				bool flag = (byte)(gridsCase_ = ((value != null) ? GridsOneofCase.GridIDs : GridsOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D70")]
		[DebuggerNonUserCode]
		public House.Types.Room Room
		{
			[Cpp2IlInjected.Token(Token = "0x6004EE4")]
			[Cpp2IlInjected.Address(RVA = "0x1AC62F0", Offset = "0x1AC4CF0", VA = "0x181AC62F0")]
			get
			{
				int num = 0;
				if (gridsCase_ == GridsOneofCase.Room)
				{
					object obj = grids_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6004EE5")]
			[Cpp2IlInjected.Address(RVA = "0x7FE160", Offset = "0x7FCB60", VA = "0x1807FE160")]
			set
			{
				grids_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D71")]
		[DebuggerNonUserCode]
		public string CustomLocationPositionsPath
		{
			[Cpp2IlInjected.Token(Token = "0x6004EE6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return customLocationPositionsPath_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004EE7")]
			[Cpp2IlInjected.Address(RVA = "0x1AC6460", Offset = "0x1AC4E60", VA = "0x181AC6460")]
			set
			{
				string text = (customLocationPositionsPath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D72")]
		[DebuggerNonUserCode]
		public GridsOneofCase GridsCase
		{
			[Cpp2IlInjected.Token(Token = "0x6004EE8")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return gridsCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D73")]
		public IEnumerable<uint> AllGridIDs
		{
			[Cpp2IlInjected.Token(Token = "0x6004EF7")]
			[Cpp2IlInjected.Address(RVA = "0x1AC6040", Offset = "0x1AC4A40", VA = "0x181AC6040")]
			get
			{
				GridsOneofCase gridsOneofCase = gridsCase_;
				if (gridsOneofCase == GridsOneofCase.GridIDs)
				{
					GridsOneofCase gridsOneofCase2 = gridsCase_;
					if (grids_ == null)
					{
						goto IL_0032;
					}
				}
				if (gridsOneofCase == GridsOneofCase.Room)
				{
					new _003C_003Cget_AllGridIDs_003Eg__AllRoomGridIDs_007C46_0_003Ed(-2)._003C_003E4__this = this;
				}
				Exception ex = new Exception();
				goto IL_0032;
				IL_0032:
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004EDF")]
		[Cpp2IlInjected.Address(RVA = "0x1AC5FF0", Offset = "0x1AC49F0", VA = "0x181AC5FF0")]
		[DebuggerNonUserCode]
		public BuildingInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004EE0")]
		[Cpp2IlInjected.Address(RVA = "0x1AC5E50", Offset = "0x1AC4850", VA = "0x181AC5E50")]
		[DebuggerNonUserCode]
		public BuildingInfo(BuildingInfo other)
		{
			//IL_0077: Expected I4, but got O
			string text = (customLocationPositionsPath_ = other.customLocationPositionsPath_);
			GridsOneofCase gridsOneofCase = other.gridsCase_;
			if (gridsOneofCase == GridsOneofCase.GridIDs)
			{
				GridsOneofCase gridsOneofCase2 = other.gridsCase_;
				if (other.grids_ == null)
				{
					throw new InvalidCastException();
				}
				Types.GridIDList gridIDList = default(Types.GridIDList);
				grids_ = gridIDList;
				bool flag = (byte)(gridsCase_ = ((gridIDList != null) ? GridsOneofCase.GridIDs : GridsOneofCase.None)) != 0;
			}
			if (gridsOneofCase == GridsOneofCase.Room)
			{
				GridsOneofCase gridsOneofCase3 = other.gridsCase_;
				if (other.grids_ == null)
				{
					throw new InvalidCastException();
				}
				House.Types.Room room = default(House.Types.Room);
				grids_ = room;
				gridsCase_ = (GridsOneofCase)room;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004EE1")]
		[Cpp2IlInjected.Address(RVA = "0x1AC4AC0", Offset = "0x1AC34C0", VA = "0x181AC4AC0", Slot = "10")]
		[DebuggerNonUserCode]
		public BuildingInfo Clone()
		{
			return new BuildingInfo(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EE9")]
		[Cpp2IlInjected.Address(RVA = "0x7FCAF0", Offset = "0x7FB4F0", VA = "0x1807FCAF0")]
		[DebuggerNonUserCode]
		public void ClearGrids()
		{
			//IL_0010: Expected O, but got I4
			grids_ = (gridsCase_ = GridsOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EEA")]
		[Cpp2IlInjected.Address(RVA = "0x1AC4B20", Offset = "0x1AC3520", VA = "0x181AC4B20", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (gridsCase_ == GridsOneofCase.GridIDs)
					{
						object obj = grids_;
						if (obj != null && obj == null)
						{
							goto IL_0080;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(Types.GridIDList).TypeHandle != null && (object)typeof(Types.GridIDList).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					House.Types.Room objB = default(House.Types.Room);
					if (flag && object.Equals(Room, objB))
					{
						string text = customLocationPositionsPath_;
						bool flag2 = default(bool);
						if (!flag2 && gridsCase_ == (flag2 ? GridsOneofCase.GridIDs : GridsOneofCase.None))
						{
							bool flag3 = object.Equals(_unknownFields, objB);
						}
					}
				}
			}
			int num2 = 0;
			goto IL_0080;
			IL_0080:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004EEB")]
		[Cpp2IlInjected.Address(RVA = "0x1AC4CA0", Offset = "0x1AC36A0", VA = "0x181AC4CA0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BuildingInfo other)
		{
			//IL_0050: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (gridsCase_ == GridsOneofCase.GridIDs)
				{
					object obj = grids_;
					if (obj != null && obj == null)
					{
						goto IL_00b1;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.gridsCase_ == GridsOneofCase.GridIDs)
				{
					obj2 = other.grids_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					House.Types.Room room = Room;
					House.Types.Room room2 = other.Room;
					if (object.Equals(room, room2))
					{
						string text = other.customLocationPositionsPath_;
						if (!(customLocationPositionsPath_ != text))
						{
							GridsOneofCase gridsOneofCase = other.gridsCase_;
							if (gridsCase_ == gridsOneofCase)
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								bool flag = object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num2 = 0;
			goto IL_00b1;
			IL_00b1:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004EEC")]
		[Cpp2IlInjected.Address(RVA = "0x1AC4F10", Offset = "0x1AC3910", VA = "0x181AC4F10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_006c
			GridsOneofCase gridsOneofCase = gridsCase_;
			int num = 0;
			if (gridsOneofCase == GridsOneofCase.GridIDs)
			{
				object obj = grids_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			if (gridsOneofCase == GridsOneofCase.Room)
			{
				object obj2 = grids_;
				if (obj2 == null)
				{
					throw new InvalidCastException();
				}
				int hashCode2 = obj2.GetHashCode();
			}
			string text = customLocationPositionsPath_;
			if (text.m_stringLength != 0)
			{
				int hashCode3 = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EED")]
		[Cpp2IlInjected.Address(RVA = "0x1AC5B10", Offset = "0x1AC4510", VA = "0x181AC5B10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EEE")]
		[Cpp2IlInjected.Address(RVA = "0x1AC5BE0", Offset = "0x1AC45E0", VA = "0x181AC5BE0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_007c
			//IL_002c: Expected O, but got I4
			GridsOneofCase gridsOneofCase = gridsCase_;
			int num = 0;
			if (gridsOneofCase == GridsOneofCase.GridIDs)
			{
				if (gridsCase_ == GridsOneofCase.GridIDs)
				{
					object obj = grids_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			if (gridsOneofCase == GridsOneofCase.Room && gridsCase_ == GridsOneofCase.Room)
			{
				object obj2 = grids_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			if (customLocationPositionsPath_.m_stringLength != 0)
			{
				string value = customLocationPositionsPath_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EEF")]
		[Cpp2IlInjected.Address(RVA = "0x1AC4840", Offset = "0x1AC3240", VA = "0x181AC4840", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_009a
			//IL_002c: Expected O, but got I4
			int num = 0;
			if (gridsCase_ == GridsOneofCase.GridIDs)
			{
				if (gridsCase_ == GridsOneofCase.GridIDs)
				{
					object obj = grids_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			if (gridsCase_ == GridsOneofCase.Room)
			{
				if (gridsCase_ == GridsOneofCase.Room)
				{
					object obj2 = grids_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			string text = customLocationPositionsPath_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num += num4;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				num += num5;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF0")]
		[Cpp2IlInjected.Address(RVA = "0x1AC5520", Offset = "0x1AC3F20", VA = "0x181AC5520", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BuildingInfo other)
		{
			//Discarded unreachable code: IL_0107
			//IL_00ce: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			string text = other.customLocationPositionsPath_;
			if (text.m_stringLength != 0)
			{
				CustomLocationPositionsPath = text;
			}
			if (other.gridsCase_ == GridsOneofCase.GridIDs)
			{
				object obj = default(object);
				if (gridsCase_ == GridsOneofCase.GridIDs)
				{
					obj = grids_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					bool flag = (byte)(gridsCase_ = (((grids_ = new Types.GridIDList()) != null) ? GridsOneofCase.GridIDs : GridsOneofCase.None)) != 0;
				}
				if (gridsCase_ == GridsOneofCase.GridIDs)
				{
					object obj2 = grids_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.gridsCase_ == GridsOneofCase.GridIDs)
				{
					object obj3 = other.grids_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if ((long)typeof(Types.GridIDList).TypeHandle == 2)
			{
				if (Room == null)
				{
					gridsCase_ = (GridsOneofCase)(grids_ = new House.Types.Room());
				}
				House.Types.Room room = Room;
				House.Types.Room room2 = other.Room;
				room.MergeFrom(room2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF1")]
		[Cpp2IlInjected.Address(RVA = "0x1AC5790", Offset = "0x1AC4190", VA = "0x181AC5790", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_00a8: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Types.GridIDList gridIDList = new Types.GridIDList();
				if (gridsCase_ == GridsOneofCase.GridIDs)
				{
					if (gridsCase_ != GridsOneofCase.GridIDs)
					{
					}
					object obj = grids_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(gridIDList);
				grids_ = gridIDList;
				bool flag = (byte)(gridsCase_ = ((gridIDList != null) ? GridsOneofCase.GridIDs : GridsOneofCase.None)) != 0;
			}
			if (num == 18)
			{
				House.Types.Room builder = new House.Types.Room();
				if (gridsCase_ == GridsOneofCase.Room)
				{
					if (gridsCase_ != GridsOneofCase.Room)
					{
					}
					object obj2 = grids_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(builder);
				grids_ = builder;
				gridsCase_ = (GridsOneofCase)typeof(House.Types.Room).TypeHandle;
			}
			if ((long)typeof(House.Types.Room).TypeHandle == 26)
			{
				string text2 = (CustomLocationPositionsPath = input.ReadString());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF2")]
		[Cpp2IlInjected.Address(RVA = "0x1AC4DF0", Offset = "0x1AC37F0", VA = "0x181AC4DF0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				string text = customLocationPositionsPath_;
				while (gridsCase_ != GridsOneofCase.Room)
				{
				}
				object obj = grids_;
				while (obj == null)
				{
				}
				if (obj != null)
				{
					while (gridsCase_ != GridsOneofCase.GridIDs)
					{
					}
					object obj2 = grids_;
					while (obj2 == null)
					{
					}
					while (obj2 != null)
					{
					}
					throw new InvalidCastException();
				}
			}
			else
			{
				ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF3")]
		[Cpp2IlInjected.Address(RVA = "0x1AC59C0", Offset = "0x1AC43C0", VA = "0x181AC59C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0021: Expected O, but got I4
			//IL_003c: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					int num2 = 0;
					if (value == null || value != null)
					{
						CustomLocationPositionsPath = (string)num2;
						break;
					}
					throw new InvalidCastException();
				}
				case 0:
					if (value == null || value != null)
					{
						grids_ = value;
						gridsCase_ = (GridsOneofCase)typeof(string).TypeHandle;
						break;
					}
					throw new InvalidCastException();
				}
			}
			else
			{
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				grids_ = value;
				bool flag = (byte)(gridsCase_ = ((value != null) ? GridsOneofCase.GridIDs : GridsOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF4")]
		[Cpp2IlInjected.Address(RVA = "0x1AC49D0", Offset = "0x1AC33D0", VA = "0x181AC49D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0025: Expected O, but got I4
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					CustomLocationPositionsPath = "";
					return;
				case 0:
					break;
				default:
					return;
				}
			}
			int num2 = 0;
			grids_ = num2;
			gridsCase_ = (GridsOneofCase)num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF5")]
		[Cpp2IlInjected.Address(RVA = "0x1AC5060", Offset = "0x1AC3A60", VA = "0x181AC5060", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Grids"))
			{
				GridsOneofCase gridsOneofCase = gridsCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF6")]
		[Cpp2IlInjected.Address(RVA = "0x1AC4A50", Offset = "0x1AC3450", VA = "0x181AC4A50", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Grids"))
			{
				grids_ = (gridsCase_ = GridsOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF8")]
		[Cpp2IlInjected.Address(RVA = "0x1AC5110", Offset = "0x1AC3B10", VA = "0x181AC5110")]
		public bool HasGrid(uint gridID)
		{
			//Discarded unreachable code: IL_0033
			switch (gridsCase_)
			{
			case GridsOneofCase.GridIDs:
			{
				GridsOneofCase gridsOneofCase2 = gridsCase_;
				bool result = default(bool);
				if (grids_ != null)
				{
					return result;
				}
				goto IL_0044;
			}
			case GridsOneofCase.Room:
			{
				GridsOneofCase gridsOneofCase = gridsCase_;
				if (grids_ != null)
				{
					return true;
				}
				throw new InvalidCastException();
			}
			default:
				{
					int num = 0;
					goto IL_0044;
				}
				IL_0044:
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF9")]
		[Cpp2IlInjected.Address(RVA = "0x1AC52A0", Offset = "0x1AC3CA0", VA = "0x181AC52A0")]
		public bool IsBuildingRelatedGrid(uint gridID, GridCollection gridCollection)
		{
			GridsOneofCase gridsOneofCase = gridsCase_;
			if (gridsOneofCase == GridsOneofCase.GridIDs)
			{
				GridsOneofCase gridsOneofCase2 = gridsCase_;
				object obj = grids_;
				int num = 0;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				uint num2 = gridID;
				bool flag = default(bool);
				if (flag)
				{
					return true;
				}
				if (grids_ == null)
				{
					throw new InvalidCastException();
				}
				Predicate<uint> predicate = (Predicate<uint>)(object)(Predicate<T>)delegate(uint x)
				{
					//Discarded unreachable code: IL_0017
					GridCollection gridCollection3 = gridCollection;
					uint potentialSubGridID = gridID;
					return gridCollection3.IsSubGridOf(potentialSubGridID, x);
				};
			}
			if (gridsOneofCase == GridsOneofCase.Room)
			{
				if (gridsCase_ == GridsOneofCase.Room)
				{
					object obj2 = grids_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				GridCollection gridCollection2 = gridCollection;
				uint num3 = gridID;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004EFA")]
		[Cpp2IlInjected.Address(RVA = "0x1AC5D40", Offset = "0x1AC4740", VA = "0x181AC5D40")]
		static BuildingInfo()
		{
			Func<BuildingInfo> func = default(Func<BuildingInfo>);
			_parser = (MessageParser<BuildingInfo>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
