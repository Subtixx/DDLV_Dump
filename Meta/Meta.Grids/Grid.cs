using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Grids
{
	[Cpp2IlInjected.Token(Token = "0x2001077")]
	public sealed class Grid : IMessage<Grid>, IMessage, IEquatable<Grid>, IDeepCloneable<Grid>, IMessageFieldAccessor, IGridInternal, IGrid, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40043EE")]
		private static readonly MessageParser<Grid> _parser = (MessageParser<Grid>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new Grid()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40043EF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40043F0")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40043F1")]
		private uint iD_;

		[Cpp2IlInjected.Token(Token = "0x40043F2")]
		public const int GridDataPathFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40043F3")]
		private string gridDataPath_;

		[Cpp2IlInjected.Token(Token = "0x40043F4")]
		public const int GridDefaultLayoutPathFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40043F5")]
		private string gridDefaultLayoutPath_;

		[Cpp2IlInjected.Token(Token = "0x40043F6")]
		public const int ObjectsFieldNumber = 4;

		[Cpp2IlInjected.Token(Token = "0x40043F7")]
		private static readonly MapField<uint, GridObject>.Codec _map_objects_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40043F8")]
		private readonly MapField<uint, GridObject> objects_;

		[Cpp2IlInjected.Token(Token = "0x40043F9")]
		public const int NextGridObjectIDFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40043FA")]
		private uint nextGridObjectID_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40043FE")]
		private Dictionary<GridPosition, List<GridObject>> _gridCells;

		[Cpp2IlInjected.Token(Token = "0x1700173D")]
		[DebuggerNonUserCode]
		public static MessageParser<Grid> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008591")]
			[Cpp2IlInjected.Address(RVA = "0x1D1D370", Offset = "0x1D1BD70", VA = "0x181D1D370")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700173E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008592")]
			[Cpp2IlInjected.Address(RVA = "0x1D1D270", Offset = "0x1D1BC70", VA = "0x181D1D270")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700173F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008593")]
			[Cpp2IlInjected.Address(RVA = "0x1D1D3D0", Offset = "0x1D1BDD0", VA = "0x181D1D3D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001740")]
		[DebuggerNonUserCode]
		public uint ID
		{
			[Cpp2IlInjected.Token(Token = "0x6008597")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008598")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001741")]
		[DebuggerNonUserCode]
		public string GridDataPath
		{
			[Cpp2IlInjected.Token(Token = "0x6008599")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "20")]
			get
			{
				return gridDataPath_;
			}
			[Cpp2IlInjected.Token(Token = "0x600859A")]
			[Cpp2IlInjected.Address(RVA = "0x1D1D4E0", Offset = "0x1D1BEE0", VA = "0x181D1D4E0")]
			set
			{
				string text = (gridDataPath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001742")]
		[DebuggerNonUserCode]
		public string GridDefaultLayoutPath
		{
			[Cpp2IlInjected.Token(Token = "0x600859B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return gridDefaultLayoutPath_;
			}
			[Cpp2IlInjected.Token(Token = "0x600859C")]
			[Cpp2IlInjected.Address(RVA = "0x1D1D550", Offset = "0x1D1BF50", VA = "0x181D1D550")]
			set
			{
				string text = (gridDefaultLayoutPath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001743")]
		[DebuggerNonUserCode]
		public MapField<uint, GridObject> Objects
		{
			[Cpp2IlInjected.Token(Token = "0x600859D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return objects_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001744")]
		[DebuggerNonUserCode]
		public uint NextGridObjectID
		{
			[Cpp2IlInjected.Token(Token = "0x600859E")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return nextGridObjectID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600859F")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				nextGridObjectID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001745")]
		GridPosition IGrid.Size
		{
			[Cpp2IlInjected.Token(Token = "0x60085AB")]
			[Cpp2IlInjected.Address(RVA = "0x1D1BF80", Offset = "0x1D1A980", VA = "0x181D1BF80", Slot = "19")]
			get
			{
				GridData gridData = GridData;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001746")]
		public GridData GridData
		{
			[Cpp2IlInjected.Token(Token = "0x60085AC")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return _003CGridData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60085AD")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CGridData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001747")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x40043FC")]
		public GridFloorType AvailableFloorTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60085AE")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0", Slot = "22")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60085AF")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001748")]
		IEnumerable<GridObject> IGrid.Objects
		{
			[Cpp2IlInjected.Token(Token = "0x60085B0")]
			[Cpp2IlInjected.Address(RVA = "0x1D1BF30", Offset = "0x1D1A930", VA = "0x181D1BF30", Slot = "23")]
			get
			{
				ICollection<GridObject> values = (ICollection<GridObject>)((MapField<TKey, TValue>)(object)objects_).get_Values();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001749")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x4C"), Cpp2IlInjected.Token(Token = "0x40043FD")]
		public bool MinimizeChanges
		{
			[Cpp2IlInjected.Token(Token = "0x60085B1")]
			[Cpp2IlInjected.Address(RVA = "0x70CA70", Offset = "0x70B470", VA = "0x18070CA70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60085B2")]
			[Cpp2IlInjected.Address(RVA = "0x70CE60", Offset = "0x70B860", VA = "0x18070CE60")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700174A")]
		internal Dictionary<GridPosition, List<GridObject>> GridCells
		{
			[Cpp2IlInjected.Token(Token = "0x60085B3")]
			[Cpp2IlInjected.Address(RVA = "0x1D1D340", Offset = "0x1D1BD40", VA = "0x181D1D340")]
			get
			{
				Dictionary<GridPosition, List<GridObject>> gridCells = _gridCells;
				if (gridCells == null)
				{
				}
				return gridCells;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008594")]
		[Cpp2IlInjected.Address(RVA = "0x1D1D1C0", Offset = "0x1D1BBC0", VA = "0x181D1D1C0")]
		[DebuggerNonUserCode]
		public Grid()
		{
			gridDataPath_ = "";
			gridDefaultLayoutPath_ = "";
			objects_ = (MapField<uint, GridObject>)(object)new MapField<TKey, TValue>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6008595")]
		[Cpp2IlInjected.Address(RVA = "0x1D1D100", Offset = "0x1D1BB00", VA = "0x181D1D100")]
		[DebuggerNonUserCode]
		public Grid(Grid other)
		{
			uint num = (iD_ = other.iD_);
			string text = (gridDataPath_ = other.gridDataPath_);
			string text2 = (gridDefaultLayoutPath_ = other.gridDefaultLayoutPath_);
			MapField<uint, GridObject> mapField = (objects_ = (MapField<uint, GridObject>)(object)((MapField<TKey, TValue>)(object)other.objects_).Clone());
			uint num2 = (nextGridObjectID_ = other.nextGridObjectID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008596")]
		[Cpp2IlInjected.Address(RVA = "0x1D18140", Offset = "0x1D16B40", VA = "0x181D18140", Slot = "10")]
		[DebuggerNonUserCode]
		public Grid Clone()
		{
			//Discarded unreachable code: IL_006c
			Grid grid = new Grid();
			uint num = (grid.iD_ = iD_);
			string text = (grid.gridDataPath_ = gridDataPath_);
			string text2 = (grid.gridDefaultLayoutPath_ = gridDefaultLayoutPath_);
			MapField<uint, GridObject> mapField = (grid.objects_ = (MapField<uint, GridObject>)(object)((MapField<TKey, TValue>)(object)objects_).Clone());
			uint num2 = (grid.nextGridObjectID_ = nextGridObjectID_);
			UnknownFieldSet unknownFieldSet = (grid._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return grid;
		}

		[Cpp2IlInjected.Token(Token = "0x60085A0")]
		[Cpp2IlInjected.Address(RVA = "0x1D19050", Offset = "0x1D17A50", VA = "0x181D19050", Slot = "0")]
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
				if ((IntPtr)(int)iD_ == (IntPtr)typeof(Grid).TypeHandle)
				{
					string text = gridDataPath_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = gridDefaultLayoutPath_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							MapField<uint, GridObject> mapField = objects_;
							bool flag3 = default(bool);
							if (flag3 && nextGridObjectID_ == (flag3 ? 1u : 0u))
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

		[Cpp2IlInjected.Token(Token = "0x60085A1")]
		[Cpp2IlInjected.Address(RVA = "0x1D18F80", Offset = "0x1D17980", VA = "0x181D18F80", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Grid other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				uint num = other.iD_;
				if (iD_ == num)
				{
					string text = other.gridDataPath_;
					if (!(gridDataPath_ != text))
					{
						string text2 = other.gridDefaultLayoutPath_;
						if (!(gridDefaultLayoutPath_ != text2))
						{
							MapField<uint, GridObject> mapField = objects_;
							MapField<uint, GridObject> mapField2 = other.objects_;
							if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
							{
								uint num2 = other.nextGridObjectID_;
								if (nextGridObjectID_ == num2)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085A2")]
		[Cpp2IlInjected.Address(RVA = "0x1D19D40", Offset = "0x1D18740", VA = "0x181D19D40", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0068
			if (iD_ != 0)
			{
			}
			string text = gridDataPath_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = gridDefaultLayoutPath_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			int hashCode3 = ((MapField<TKey, TValue>)(object)objects_).GetHashCode();
			if (nextGridObjectID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60085A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D1CAB0", Offset = "0x1D1B4B0", VA = "0x181D1CAB0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60085A4")]
		[Cpp2IlInjected.Address(RVA = "0x1D1CD50", Offset = "0x1D1B750", VA = "0x181D1CD50", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0097
			if (iD_ != 0)
			{
				uint value = iD_;
				output.WriteUInt32(value);
			}
			if (gridDataPath_.m_stringLength != 0)
			{
				string value2 = gridDataPath_;
				output.WriteString(value2);
			}
			if (gridDefaultLayoutPath_.m_stringLength != 0)
			{
				string value3 = gridDefaultLayoutPath_;
				output.WriteString(value3);
			}
			MapField<uint, GridObject> mapField = objects_;
			MapField<uint, GridObject>.Codec map_objects_codec = _map_objects_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_objects_codec);
			if (nextGridObjectID_ != 0)
			{
				uint value4 = nextGridObjectID_;
				output.WriteUInt32(value4);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60085A5")]
		[Cpp2IlInjected.Address(RVA = "0x1D17900", Offset = "0x1D16300", VA = "0x181D17900", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00bc
			uint num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeUInt32Size(num);
			}
			string text = gridDataPath_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = gridDefaultLayoutPath_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			MapField<uint, GridObject> mapField = objects_;
			MapField<uint, GridObject>.Codec map_objects_codec = _map_objects_codec;
			int num6 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_objects_codec);
			uint num7 = nextGridObjectID_;
			num2 += num6;
			if (num7 != 0)
			{
				int num8 = CodedOutputStream.ComputeUInt32Size(num7);
				num8++;
				num2 += num8;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num9 = unknownFields.CalculateSize();
				num2 += num9;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60085A6")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B9D0", Offset = "0x1D1A3D0", VA = "0x181D1B9D0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Grid other)
		{
			//Discarded unreachable code: IL_0095
			if (other != null)
			{
				uint num = other.iD_;
				if (num != 0)
				{
					iD_ = num;
				}
				string text = other.gridDataPath_;
				if (text.m_stringLength != 0)
				{
					GridDataPath = text;
				}
				string text2 = other.gridDefaultLayoutPath_;
				if (text2.m_stringLength != 0)
				{
					GridDefaultLayoutPath = text2;
				}
				MapField<uint, GridObject> mapField = objects_;
				MapField<uint, GridObject> mapField2 = other.objects_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				uint num2 = other.nextGridObjectID_;
				if (num2 != 0)
				{
					nextGridObjectID_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60085A7")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B860", Offset = "0x1D1A260", VA = "0x181D1B860", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_009c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 18)
			{
				if (num == 26)
				{
					string text2 = (GridDefaultLayoutPath = input.ReadString());
				}
				if (num == 34)
				{
					MapField<uint, GridObject> mapField = objects_;
					MapField<uint, GridObject>.Codec map_objects_codec = _map_objects_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_objects_codec);
				}
				if (num != 40)
				{
					goto IL_0085;
				}
				int num2 = (int)(nextGridObjectID_ = (uint)input.ReadInt32());
			}
			int num3 = default(int);
			if (num == 8)
			{
				num3 = (int)(iD_ = (uint)input.ReadInt32());
			}
			if (num3 == 18)
			{
				string text4 = (GridDataPath = input.ReadString());
			}
			goto IL_0085;
			IL_0085:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60085A8")]
		[Cpp2IlInjected.Address(RVA = "0x1D19BA0", Offset = "0x1D185A0", VA = "0x181D19BA0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 0 && num != 1)
						{
							goto IL_0035;
						}
						MapField<uint, GridObject> mapField = objects_;
					}
					string text = gridDefaultLayoutPath_;
				}
				string text2 = gridDataPath_;
			}
			uint num2 = iD_;
			goto IL_0035;
			IL_0035:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60085A9")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C580", Offset = "0x1D1AF80", VA = "0x181D1C580", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_003a
			//IL_001f: Expected I4, but got O
			//IL_0039: Expected I4, but got O
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
							object obj = default(object);
							nextGridObjectID_ = (uint)(int)obj;
							return;
						}
						default:
							return;
						case 0:
							break;
						}
						InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
					}
					else if (value == null || value != null)
					{
						return;
					}
					throw new InvalidCastException();
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
			else
			{
				object obj2 = default(object);
				iD_ = (uint)(int)obj2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60085AA")]
		[Cpp2IlInjected.Address(RVA = "0x1D18060", Offset = "0x1D16A60", VA = "0x181D18060", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0025
			//IL_0021: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0 && num != 0 && num != 0 && num != 0 && num == 1)
			{
				nextGridObjectID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60085B4")]
		[Cpp2IlInjected.Address(RVA = "0x1D18230", Offset = "0x1D16C30", VA = "0x181D18230")]
		public void Create(in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_010b, IL_0111, IL_0117
			int num = 0;
			string text = gridDefaultLayoutPath_;
			if ("" == null)
			{
				IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
				string path = gridDefaultLayoutPath_;
				Grid grid = ProtoParser.Parse<Grid>(_003CData_003Ek__BackingField.ReadAllBytes(path));
				grid.iD_ = (uint)num;
				((MapField<TKey, TValue>)(object)objects_).Clear();
				uint num2 = grid.iD_;
				if (num2 != 0)
				{
					iD_ = num2;
				}
				string text2 = grid.gridDataPath_;
				if (text2.m_stringLength != num)
				{
					GridDataPath = text2;
				}
				string text3 = grid.gridDefaultLayoutPath_;
				if (text3.m_stringLength != num)
				{
					GridDefaultLayoutPath = text3;
				}
				MapField<uint, GridObject> mapField = objects_;
				MapField<uint, GridObject> mapField2 = grid.objects_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				uint num3 = grid.nextGridObjectID_;
				if (num3 != 0)
				{
					nextGridObjectID_ = num3;
				}
				UnknownFieldSet unknownFields = grid._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
				string text4 = (gridDefaultLayoutPath_ = ProtoPreconditions.CheckNotNull("", "value"));
			}
			MapField<uint, GridObject> mapField3 = objects_;
			bool flag = default(bool);
			if (flag)
			{
				while (num == 0)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60085B5")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B470", Offset = "0x1D19E70", VA = "0x181D1B470", Slot = "25")]
		public void Init()
		{
			//IL_000c: Expected O, but got I4
			int num = 0;
			int validate = 0;
			bool flag = Init((byte)validate != 0, (GridData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60085B6")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B210", Offset = "0x1D19C10", VA = "0x181D1B210")]
		public void InitFromData(GridData gridData)
		{
			int validate = 0;
			bool flag = Init((byte)validate != 0, gridData);
		}

		[Cpp2IlInjected.Token(Token = "0x60085B7")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B200", Offset = "0x1D19C00", VA = "0x181D1B200")]
		public bool InitAndValidate()
		{
			//IL_000a: Expected O, but got I4
			int num = 0;
			return Init(validate: true, (GridData)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60085B8")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B220", Offset = "0x1D19C20", VA = "0x181D1B220")]
		private bool Init(bool validate, GridData _gridData)
		{
			if (_gridData == null)
			{
				string text = gridDataPath_;
				if ((object)typeof(_003C_003Ec).TypeHandle != null)
				{
					goto IL_006b;
				}
				GridData gridData = GridData.Get(gridDataPath_);
			}
			GridData = _gridData;
			RepeatedField<int> floorTypes_ = GridData.floorTypes_;
			Func<GridFloorType, int, GridFloorType> func = default(Func<GridFloorType, int, GridFloorType>);
			if (_003C_003Ec._003C_003E9__71_0 == null)
			{
				func = (Func<GridFloorType, int, GridFloorType>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T1, T2, TResult>)delegate
				{
					/*Error: Unexpected end of block*/;
				});
			}
			int num = 0;
			int num2 = (int)(AvailableFloorTypes = (GridFloorType)Enumerable.Aggregate<int, GridFloorType>((IEnumerable<>)(object)floorTypes_, num, (Func<, , >)(object)func));
			if (validate)
			{
			}
			goto IL_006b;
			IL_006b:
			ArgumentNullException ex = new ArgumentNullException("GridDataPath", "Grid does not have a data path.");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60085B9")]
		[Cpp2IlInjected.Address(RVA = "0x1D1A040", Offset = "0x1D18A40", VA = "0x181D1A040")]
		internal unsafe void InitAndUpdate(IGridDataUpdateInvalidItemHandler gridDataUpdateInvalidItemHandler, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_03cf, IL_03dc, IL_03e2, IL_03e8
			//IL_0031: Expected O, but got I4
			//IL_0344: Expected O, but got I4
			//IL_034c: Expected O, but got I4
			//IL_036b: Expected I4, but got O
			//IL_0374: Expected I4, but got O
			//IL_03cc: Expected O, but got I4
			_003C_003Ec__DisplayClass72_0 CS_0024_003C_003E8__locals2;
			uint num5 = default(uint);
			bool flag2 = default(bool);
			uint num7 = default(uint);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			GridPosition? gridPosition = default(GridPosition?);
			bool flag6 = default(bool);
			GridPosition? gridPosition2 = default(GridPosition?);
			GridPosition gridPosition3 = default(GridPosition);
			bool flag7 = default(bool);
			bool flag8 = default(bool);
			ulong num12 = default(ulong);
			int num11 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass72_0();
				CS_0024_003C_003E8__locals2.gridDataUpdateInvalidItemHandler = gridDataUpdateInvalidItemHandler;
				CS_0024_003C_003E8__locals2.context = context;
				CS_0024_003C_003E8__locals2._003C_003E4__this = this;
				int num4 = 0;
				int validate = 0;
				bool flag = Init((byte)validate != 0, (GridData)num4);
				Dictionary<GridPosition, List<GridObject>> dictionary = (CS_0024_003C_003E8__locals2.checkGridCells = (Dictionary<GridPosition, List<GridObject>>)(object)new Dictionary<TKey, TValue>());
				List<GridObject> list = (List<GridObject>)(object)new List<T>();
				ICollection<GridObject> values = (ICollection<GridObject>)((MapField<TKey, TValue>)(object)objects_).get_Values();
				Func<GridObject, int> _003C_003E9__ = CS_0024_003C_003E8__locals2._003C_003E9__2;
				if (_003C_003E9__ == null)
				{
					Func<GridObject, int> func = (CS_0024_003C_003E8__locals2._003C_003E9__2 = (Func<GridObject, int>)(object)(Func<T, TResult>)delegate(GridObject x)
					{
						//Discarded unreachable code: IL_001e
						IGridDataUpdateInvalidItemHandler gridDataUpdateInvalidItemHandler7 = CS_0024_003C_003E8__locals2.gridDataUpdateInvalidItemHandler;
						int itemID3 = x.ItemID;
						GridState state_3 = x.state_;
						ITransactionContext context2 = CS_0024_003C_003E8__locals2.context;
						return itemID3;
					});
				}
				IOrderedEnumerable<GridObject> orderedEnumerable = (IOrderedEnumerable<GridObject>)Enumerable.OrderByDescending<GridObject, int>((IEnumerable<>)values, (Func<, >)(object)_003C_003E9__);
				if (orderedEnumerable != null)
				{
					if (num < (int)num5)
					{
						num += num;
						if (num == (int)num5)
						{
							goto IL_00a0;
						}
						num++;
					}
					if (!flag2)
					{
						goto IL_00a0;
					}
				}
				goto IL_00a7;
				IL_00a7:
				int num6 = 0;
				if (orderedEnumerable != null)
				{
				}
				if (num != 0)
				{
					continue;
				}
				List<GridObject> list2 = (List<GridObject>)(object)new List<T>();
				_003C_003Ec__DisplayClass72_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass72_1();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals2;
				CS_0024_003C_003E8__locals0.tryNumber = num6;
				IGridDataUpdateInvalidItemHandler gridDataUpdateInvalidItemHandler2 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.gridDataUpdateInvalidItemHandler;
				if (num6 < (int)num7)
				{
					num6 += num6;
					num6++;
				}
				if (num6 >= num6)
				{
					break;
				}
				Comparison<GridObject> comparison = (Comparison<GridObject>)(object)(Comparison<T>)delegate(GridObject a, GridObject b)
				{
					//Discarded unreachable code: IL_0021
					_003C_003Ec__DisplayClass72_0 cS_0024_003C_003E8__locals12 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1;
					int itemID = b.ItemID;
					_003C_003Ec__DisplayClass72_0 cS_0024_003C_003E8__locals13 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1;
					int itemID2 = a.ItemID;
					int result3 = default(int);
					return result3;
				};
				((List<T>)(object)list).Sort((Comparison<>)(object)comparison);
				int size = ((List<>)(object)list)._size;
				_003C_003Ec__DisplayClass72_2 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass72_2();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals1.invalidObject = (GridObject)(object)CS_0024_003C_003E8__locals1;
				GridObject invalidObject = CS_0024_003C_003E8__locals1.invalidObject;
				IGridDataUpdateInvalidItemHandler gridDataUpdateInvalidItemHandler3 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.gridDataUpdateInvalidItemHandler;
				GridObject invalidObject2 = CS_0024_003C_003E8__locals1.invalidObject;
				GridState state_ = invalidObject2.state_;
				if (invalidObject2 == null)
				{
					_003C_003Ec__DisplayClass72_0 cS_0024_003C_003E8__locals = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1;
					GridObject invalidObject3 = CS_0024_003C_003E8__locals1.invalidObject;
					GridObject invalidObject4 = CS_0024_003C_003E8__locals1.invalidObject;
					if (flag3)
					{
						GridObject invalidObject5 = CS_0024_003C_003E8__locals1.invalidObject;
						int num8 = 0;
						num6 += num6;
						num8 += 312;
					}
					if (false)
					{
						goto IL_0359;
					}
					_003C_003Ec__DisplayClass72_0 cS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1;
					GridObject invalidObject6 = CS_0024_003C_003E8__locals1.invalidObject;
					if (flag4)
					{
						goto IL_0280;
					}
					_003C_003Ec__DisplayClass72_0 cS_0024_003C_003E8__locals3 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1;
					GridObject invalidObject7 = CS_0024_003C_003E8__locals1.invalidObject;
					GridOrientation orientation_ = CS_0024_003C_003E8__locals1.invalidObject.orientation_;
					int tryNumber = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.tryNumber;
					if (flag5)
					{
						GridObject invalidObject8 = CS_0024_003C_003E8__locals1.invalidObject;
						int num9 = 0;
					}
					int num10 = 0;
				}
				GridObject invalidObject9 = CS_0024_003C_003E8__locals1.invalidObject;
				Func<GridPosition, bool> func2 = (Func<GridPosition, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_001d
					_003C_003Ec__DisplayClass72_0 cS_0024_003C_003E8__locals11 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1;
					GridObject invalidObject19 = CS_0024_003C_003E8__locals1.invalidObject;
					Grid _003C_003E4__this = cS_0024_003C_003E8__locals11._003C_003E4__this;
					bool result2 = default(bool);
					return result2;
				};
				if (!((Nullable<>*)(&gridPosition))->has_value)
				{
					_003C_003Ec__DisplayClass72_0 cS_0024_003C_003E8__locals4 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1;
					GridObject invalidObject10 = CS_0024_003C_003E8__locals1.invalidObject;
					if (!flag6)
					{
						GridObject invalidObject11 = CS_0024_003C_003E8__locals1.invalidObject;
						Func<GridPosition, bool> func3 = (Func<GridPosition, bool>)(object)(Func<T, TResult>)delegate
						{
							//Discarded unreachable code: IL_0027
							_003C_003Ec__DisplayClass72_1 cS_0024_003C_003E8__locals9 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2;
							_003C_003Ec__DisplayClass72_0 cS_0024_003C_003E8__locals10 = cS_0024_003C_003E8__locals9.CS_0024_003C_003E8__locals1;
							GridObject invalidObject18 = CS_0024_003C_003E8__locals1.invalidObject;
							int tryNumber4 = cS_0024_003C_003E8__locals9.tryNumber;
							GridOrientation orientation_2 = invalidObject18.orientation_;
							bool result = default(bool);
							return result;
						};
						bool has_value = ((Nullable<>*)(&gridPosition2))->has_value;
					}
					goto IL_0280;
				}
				goto IL_0359;
				IL_0359:
				GridObject invalidObject12 = CS_0024_003C_003E8__locals1.invalidObject;
				invalidObject12.x_ = (int)gridPosition3;
				invalidObject12.y_ = (int)gridPosition3;
				_003C_003Ec__DisplayClass72_0 cS_0024_003C_003E8__locals5 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1;
				GridObject invalidObject13 = CS_0024_003C_003E8__locals1.invalidObject;
				Meta.Grids.GridCells.AddToGridCells((Dictionary<, >)(object)cS_0024_003C_003E8__locals5.checkGridCells, invalidObject13);
				((List<T>)(object)list).RemoveAt(size);
				break;
				IL_00a0:
				orderedEnumerable = (IOrderedEnumerable<GridObject>)(object)((object)orderedEnumerable + (object)orderedEnumerable);
				goto IL_00a7;
				IL_0280:
				_003C_003Ec__DisplayClass72_0 cS_0024_003C_003E8__locals6 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1;
				GridObject invalidObject14 = CS_0024_003C_003E8__locals1.invalidObject;
				if (!flag7)
				{
					break;
				}
				_003C_003Ec__DisplayClass72_1 cS_0024_003C_003E8__locals7 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2;
				IGridDataUpdateInvalidItemHandler gridDataUpdateInvalidItemHandler4 = cS_0024_003C_003E8__locals7.CS_0024_003C_003E8__locals1.gridDataUpdateInvalidItemHandler;
				GridObject invalidObject15 = CS_0024_003C_003E8__locals1.invalidObject;
				int tryNumber2 = cS_0024_003C_003E8__locals7.tryNumber;
				GridState state_2 = invalidObject15.state_;
				((List<T>)(object)list).RemoveAt(size);
				GridObject invalidObject16 = CS_0024_003C_003E8__locals1.invalidObject;
				((List<T>)(object)list2).Add((T)invalidObject16);
				Dictionary<GridPosition, List<GridObject>> checkGridCells = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.checkGridCells;
				GridObject invalidObject17 = CS_0024_003C_003E8__locals1.invalidObject;
				if (flag8)
				{
					_003C_003Ec__DisplayClass72_1 cS_0024_003C_003E8__locals8 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2;
					IGridDataUpdateInvalidItemHandler gridDataUpdateInvalidItemHandler5 = cS_0024_003C_003E8__locals8.CS_0024_003C_003E8__locals1.gridDataUpdateInvalidItemHandler;
					int tryNumber3 = cS_0024_003C_003E8__locals8.tryNumber;
					Meta.Grids.GridCells.RemoveFromGridCells((Dictionary<, >)(object)CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.checkGridCells, (GridObject)num3);
					((List<T>)(object)list2).Add((T)num3);
				}
				num11 = 0;
				if (num12 != 0)
				{
					continue;
				}
				goto IL_0359;
			}
			IGridDataUpdateInvalidItemHandler gridDataUpdateInvalidItemHandler6 = CS_0024_003C_003E8__locals2.gridDataUpdateInvalidItemHandler;
			uint num13 = default(uint);
			if (num11 < (int)num13)
			{
				num11 += num11;
				num11++;
			}
			int num14 = 0;
			uint num15 = default(uint);
			string text = $"Some invalid objects could not be repositioned in grid #{num15}";
		}

		[Cpp2IlInjected.Token(Token = "0x60085BA")]
		[Cpp2IlInjected.Address(RVA = "0x1D1CB10", Offset = "0x1D1B510", VA = "0x181D1CB10", Slot = "33")]
		public bool TryGetObject(uint gridObjectID, out GridObject gridObject)
		{
			//Discarded unreachable code: IL_0009
			MapField<uint, GridObject> mapField = objects_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60085BB")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B480", Offset = "0x1D19E80", VA = "0x181D1B480")]
		public bool IsAreaInside(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea)
		{
			if (gridArea.IsValid)
			{
				GridData gridData = GridData;
				bool flag = default(bool);
				if (flag)
				{
					int y = gridPosition.Y;
					GridData gridData2 = GridData;
					int num = default(int);
					y += num;
					int sizeX_ = gridData2.sizeX_;
					int num2 = default(int);
					num += num2;
					if (num < sizeX_)
					{
						int sizeY_ = GridData.sizeY_;
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085BC")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B640", Offset = "0x1D1A040", VA = "0x181D1B640")]
		public bool IsAreaValid(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, bool automaticSpawning)
		{
			if (_gridCells == null)
			{
			}
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60085BD")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B5B0", Offset = "0x1D19FB0", VA = "0x181D1B5B0")]
		public bool IsAreaValidFor(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning)
		{
			if (_gridCells == null)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60085BE")]
		[Cpp2IlInjected.Address(RVA = "0x1D19F90", Offset = "0x1D18990", VA = "0x181D19F90")]
		public bool HasConflicts(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning, [Optional] Item? clearedBy, GridCellConflict conflictsToCheck = GridCellConflict.All)
		{
			if (_gridCells == null)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60085BF")]
		[Cpp2IlInjected.Address(RVA = "0x1D19AB0", Offset = "0x1D184B0", VA = "0x181D19AB0")]
		public (bool, GridCellConflict) GetConflicts(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning, [Optional] Item? clearedBy, GridCellConflict conflictsToCheck = GridCellConflict.All)
		{
			if (_gridCells == null)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60085C0")]
		[Cpp2IlInjected.Address(RVA = "0x1D19870", Offset = "0x1D18270", VA = "0x181D19870")]
		public (bool, GridCellConflict, GridCellConflict[][]) GetConflictedCells(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning, [Optional] Item? clearedBy)
		{
			GridCellConflict[] array2 = default(GridCellConflict[]);
			while (true)
			{
				GridCellConflict[][] array = new GridCellConflict[ref System.Runtime.CompilerServices.Unsafe.As<GridPosition, _003F>(ref gridPosition)][];
				int num = 0;
				int num2 = 0;
				if (num2 >= array.Length)
				{
					break;
				}
				array2 = new GridCellConflict[ref System.Runtime.CompilerServices.Unsafe.As<GridPosition, _003F>(ref gridPosition)];
				if (array2 == null || array2 != null)
				{
					num2 = num;
					num += 4;
					num++;
					num2 = num;
					break;
				}
			}
			if (array2 == null)
			{
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085C1")]
		[Cpp2IlInjected.Address(RVA = "0x1D19A40", Offset = "0x1D18440", VA = "0x181D19A40")]
		public List<GridObject> GetConflictedObjects(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject)
		{
			if (this == null)
			{
			}
			List<GridObject> result = default(List<GridObject>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60085C2")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BFC0", Offset = "0x1D1A9C0", VA = "0x181D1BFC0", Slot = "30")]
		public int ObjectCount()
		{
			//Discarded unreachable code: IL_000c
			return ((MapField<TKey, TValue>)(object)objects_).Count;
		}

		[Cpp2IlInjected.Token(Token = "0x60085C3")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C010", Offset = "0x1D1AA10", VA = "0x181D1C010", Slot = "31")]
		public int ObjectCount(Item item)
		{
			//Discarded unreachable code: IL_0035
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			ICollection<GridObject> values = (ICollection<GridObject>)((MapField<TKey, TValue>)(object)objects_).get_Values();
			Func<GridObject, bool> func = (Func<GridObject, bool>)(object)(Func<T, TResult>)delegate(GridObject x)
			{
				int itemID2 = x.ItemID;
				throw new NullReferenceException();
			};
			return Enumerable.Count<GridObject>((IEnumerable<>)values, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60085C4")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C110", Offset = "0x1D1AB10", VA = "0x181D1C110", Slot = "32")]
		public int ObjectCount(IEnumerable<Item> items)
		{
			//Discarded unreachable code: IL_0008
			Func<Item, int> func = default(Func<Item, int>);
			return Enumerable.Sum<Item>((IEnumerable<>)items, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60085C5")]
		[Cpp2IlInjected.Address(RVA = "0x1D17710", Offset = "0x1D16110", VA = "0x181D17710", Slot = "14")]
		GridObject IGridInternal.AddObject(Item item, in GridPosition position, GridOrientation orientation, GridState state, IWorldEventDispatcher dispatcher, bool automaticSpawning, [Optional] GridSource? source, [Optional] GridAddObjectOptions options)
		{
			GridObject result = default(GridObject);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60085C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D17710", Offset = "0x1D16110", VA = "0x181D17710")]
		public GridObject AddObject(Item item, in GridPosition position, GridOrientation orientation, GridState state, ProfileEventDispatcher dispatcher, bool automaticSpawning, [Optional] GridSource? source, [Optional] GridAddObjectOptions options)
		{
			GridObject result = default(GridObject);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60085C7")]
		[Cpp2IlInjected.Address(RVA = "0x1D17740", Offset = "0x1D16140", VA = "0x181D17740")]
		internal GridObject AddObject(Item item, in GridPosition position, GridOrientation orientation, GridState state, IWorldEventDispatcher dispatcher, bool automaticSpawning, [Optional] GridSource? source, [Optional] GridAddObjectOptions options)
		{
			//IL_003b: Expected O, but got I4
			int itemID = item.ItemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IGridPlaceableItemData gridPlaceableItemData = default(IGridPlaceableItemData);
			if (gridPlaceableItemData != null)
			{
				GridObject gridObject = new GridObject();
				uint num = (gridObject.iD_ = nextGridObjectID_);
				gridObject.itemID_ = itemID;
				gridObject.state_ = (GridState)0;
				gridObject.orientation_ = orientation;
				if (!MinimizeChanges)
				{
				}
				GridObject gridObject2 = default(GridObject);
				if (gridObject2 == null || MinimizeChanges)
				{
				}
				return gridObject2;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085C8")]
		[Cpp2IlInjected.Address(RVA = "0x1D17730", Offset = "0x1D16130", VA = "0x181D17730")]
		public GridObject AddObject(GridObject gridObject, ProfileEventDispatcher dispatcher, bool automaticSpawning, [Optional] GridAddObjectOptions options)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60085C9")]
		[Cpp2IlInjected.Address(RVA = "0x1D17570", Offset = "0x1D15F70", VA = "0x181D17570")]
		internal GridObject AddObject(GridObject gridObject, IWorldEventDispatcher dispatcher, bool automaticSpawning, [Optional] GridAddObjectOptions options)
		{
			//IL_0031: Expected O, but got I4
			int num = 0;
			GridOrientation orientation_ = gridObject.orientation_;
			if (_gridCells == null)
			{
			}
			bool flag = default(bool);
			if (flag)
			{
				MapField<uint, GridObject> mapField = objects_;
				uint num2 = gridObject.iD_;
				((MapField<TKey, TValue>)(object)mapField).Add((TKey)num2, (TValue)gridObject);
				Meta.Grids.GridCells.AddToGridCells((Dictionary<, >)(object)_gridCells, gridObject);
				if (dispatcher != null)
				{
				}
				return gridObject;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085CA")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BAA0", Offset = "0x1D1A4A0", VA = "0x181D1BAA0", Slot = "15")]
		bool IGridInternal.CanAddObject(Item item, in GridPosition position, GridOrientation orientation, GridState state, IWorldEventDispatcher dispatcher, bool automaticSpawning, GridSource? source, GridAddObjectOptions options)
		{
			//IL_003b: Expected O, but got I4
			int itemID = item.ItemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IGridPlaceableItemData gridPlaceableItemData = default(IGridPlaceableItemData);
			if (gridPlaceableItemData != null)
			{
				GridObject gridObject = new GridObject();
				uint num = (gridObject.iD_ = nextGridObjectID_);
				gridObject.itemID_ = itemID;
				gridObject.state_ = (GridState)0;
				gridObject.orientation_ = orientation;
				int num2 = 0;
				GridOrientation orientation_ = gridObject.orientation_;
				if (_gridCells == null)
				{
				}
				bool result = default(bool);
				return result;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085CB")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BCC0", Offset = "0x1D1A6C0", VA = "0x181D1BCC0", Slot = "16")]
		bool IGridInternal.RemoveObject(GridObject gridObject, in World world, bool automaticRemove)
		{
			return RemoveObject(gridObject, in world, deInitialize: true, automaticRemove);
		}

		[Cpp2IlInjected.Token(Token = "0x60085CC")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C1B0", Offset = "0x1D1ABB0", VA = "0x181D1C1B0")]
		public bool RemoveObject(GridObject gridObject, ProfileEventDispatcher dispatcher)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60085CD")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C210", Offset = "0x1D1AC10", VA = "0x181D1C210")]
		internal bool RemoveObject(GridObject gridObject, in World world, bool deInitialize = true, bool automaticRemove = false)
		{
			//Discarded unreachable code: IL_0099
			//IL_0021: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			MapField<uint, GridObject> mapField = objects_;
			uint num5 = gridObject.iD_;
			if (!((MapField<TKey, TValue>)(object)mapField).Remove((TKey)num5))
			{
			}
			Meta.Grids.GridCells.RemoveFromGridCells((Dictionary<, >)(object)_gridCells, gridObject);
			if (world.dispatcher != null)
			{
			}
			if (num4 == 0)
			{
				uint num6 = default(uint);
				uint num7 = default(uint);
				if (num6 != 0)
				{
					num7 = num6 - 1;
				}
				if (deInitialize)
				{
					GridState state_ = gridObject.state_;
					if (state_ != null)
					{
						IGridStateData stateData = state_.StateData;
					}
					uint num8 = default(uint);
					if (num4 != 0 && num4 < (int)num8)
					{
						num4 += num4;
						num4++;
					}
				}
				num7++;
				num4 += num4;
				num7 += 312;
				if (num7 != 0)
				{
				}
				int num9 = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085CE")]
		[Cpp2IlInjected.Address(RVA = "0x1D19E20", Offset = "0x1D18820", VA = "0x181D19E20")]
		public GridLayers GetLayersForPosition(in GridPosition gridPosition)
		{
			if (_gridCells == null)
			{
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			bool flag = default(bool);
			if (flag && num < num)
			{
				int num4 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				num++;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085CF")]
		[Cpp2IlInjected.Address(RVA = "0x1D19CA0", Offset = "0x1D186A0", VA = "0x181D19CA0")]
		public List<GridObject> GetGridObjectsForPosition(in GridPosition gridPosition)
		{
			GridData gridData = GridData;
			bool flag = default(bool);
			if (!flag || _gridCells == null)
			{
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085D0")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BCE0", Offset = "0x1D1A6E0", VA = "0x181D1BCE0", Slot = "17")]
		bool IGridInternal.UpdateTransform(GridObject gridObject, in GridPosition newGridPosition, GridOrientation newGridOrientation, IWorldEventDispatcher dispatcher)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60085D1")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BCE0", Offset = "0x1D1A6E0", VA = "0x181D1BCE0")]
		public bool UpdateTransform(GridObject gridObject, in GridPosition newGridPosition, GridOrientation newGridOrientation, ProfileEventDispatcher dispatcher)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60085D2")]
		[Cpp2IlInjected.Address(RVA = "0x1D1CB90", Offset = "0x1D1B590", VA = "0x181D1CB90")]
		internal bool UpdateTransform(GridObject gridObject, in GridPosition newGridPosition, GridOrientation newGridOrientation, IWorldEventDispatcher dispatcher)
		{
			if (((MapField<TKey, TValue>)(object)objects_).get_Values() != null)
			{
				if (_gridCells == null)
				{
				}
				bool flag = default(bool);
				if (flag)
				{
					Meta.Grids.GridCells.RemoveFromGridCells((Dictionary<, >)(object)_gridCells, gridObject);
					gridObject.orientation_ = newGridOrientation;
					Meta.Grids.GridCells.AddToGridCells((Dictionary<, >)(object)_gridCells, gridObject);
					int num = 0;
					return true;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085D3")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B750", Offset = "0x1D1A150", VA = "0x181D1B750", Slot = "28")]
		public bool IsParentOf(IGrid subGrid)
		{
			//Discarded unreachable code: IL_002e
			ICollection<GridObject> values = (ICollection<GridObject>)((MapField<TKey, TValue>)(object)objects_).get_Values();
			Func<GridObject, bool> cpp2il__autoParamName__idx_ = (Func<GridObject, bool>)(object)(Func<T, TResult>)delegate(GridObject x)
			{
				//Discarded unreachable code: IL_0034
				GridState state_ = x.state_;
				if (state_ != null)
				{
					SubGrid subGrid2 = state_.SubGrid;
					int num = 0;
					if (subGrid2 == null)
					{
						goto IL_0022;
					}
					uint gridID_ = subGrid2.gridID_;
				}
				int num2 = 0;
				goto IL_0022;
				IL_0022:
				IGrid grid = subGrid;
				return (IntPtr)num2 == (IntPtr)typeof(IGrid).TypeHandle;
			};
			return ((IEnumerable<>)values).Any<GridObject>((Func<, >)(object)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x60085D4")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B6D0", Offset = "0x1D1A0D0", VA = "0x181D1B6D0", Slot = "29")]
		public bool IsOnGrid(GridObject gridObject)
		{
			ICollection<GridObject> values = (ICollection<GridObject>)((MapField<TKey, TValue>)(object)objects_).get_Values();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085D5")]
		[Cpp2IlInjected.Address(RVA = "0x1D17AA0", Offset = "0x1D164A0", VA = "0x181D17AA0", Slot = "26")]
		public bool CanExpandGridSize(string gridDataPath)
		{
			GridData gridData = GridData.Get(gridDataPath);
			GridData gridData2 = GridData;
			int sizeX_ = gridData2.sizeX_;
			int sizeY_ = gridData2.sizeY_;
			RepeatedField<int> floorTypes_ = gridData.floorTypes_;
			Func<GridFloorType, int, GridFloorType> _003C_003E9__101_ = _003C_003Ec._003C_003E9__101_0;
			if (_003C_003E9__101_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T1, T2, TResult>)delegate
				{
					/*Error: Unexpected end of block*/;
				};
			}
			int num = 0;
			int num2 = Enumerable.Aggregate<int, GridFloorType>((IEnumerable<>)(object)floorTypes_, num, (Func<, , >)(object)_003C_003E9__101_);
			ICollection<GridObject> values = (ICollection<GridObject>)((MapField<TKey, TValue>)(object)objects_).get_Values();
			Func<GridObject, bool> cpp2il__autoParamName__idx_ = default(Func<GridObject, bool>);
			if (_003C_003Ec._003C_003E9__101_1 == null)
			{
				bool result = default(bool);
				cpp2il__autoParamName__idx_ = (Func<GridObject, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((GridObject x) => result));
			}
			switch (((IEnumerable<>)values).Any<GridObject>((Func<, >)(object)cpp2il__autoParamName__idx_))
			{
			default:
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60085D6")]
		[Cpp2IlInjected.Address(RVA = "0x1D17D80", Offset = "0x1D16780", VA = "0x181D17D80")]
		private bool CanExpandGridSize(string gridDataPath, out GridData newGridData)
		{
			GridData gridData = GridData.Get(gridDataPath);
			GridData gridData2 = GridData;
			int sizeX_ = gridData2.sizeX_;
			int sizeY_ = gridData2.sizeY_;
			if (_003C_003Ec._003C_003E9__101_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T1, T2, TResult>)delegate
				{
					/*Error: Unexpected end of block*/;
				};
			}
			ICollection<GridObject> values = (ICollection<GridObject>)((MapField<TKey, TValue>)(object)objects_).get_Values();
			Func<GridObject, bool> cpp2il__autoParamName__idx_ = default(Func<GridObject, bool>);
			if (_003C_003Ec._003C_003E9__101_1 == null)
			{
				bool result = default(bool);
				cpp2il__autoParamName__idx_ = (Func<GridObject, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((GridObject x) => result));
			}
			switch (((IEnumerable<>)values).Any<GridObject>((Func<, >)(object)cpp2il__autoParamName__idx_))
			{
			default:
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60085D7")]
		[Cpp2IlInjected.Address(RVA = "0x1D19160", Offset = "0x1D17B60", VA = "0x181D19160", Slot = "27")]
		public unsafe bool ExpandGridSize(string gridDataPath)
		{
			//Discarded unreachable code: IL_0115, IL_011b, IL_0121, IL_0127
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected I4, but got Unknown
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected I4, but got Unknown
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected I4, but got Unknown
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected I4, but got Unknown
			Func<GridObject, bool> func = default(Func<GridObject, bool>);
			bool result = default(bool);
			bool flag2 = default(bool);
			(int, int) tuple = default((int, int));
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				GridData gridData = GridData.Get(gridDataPath);
				int sizeX_ = gridData.sizeX_;
				GridData gridData2 = GridData;
				int sizeY_ = gridData.sizeY_;
				RepeatedField<int> floorTypes_ = gridData.floorTypes_;
				Func<GridFloorType, int, GridFloorType> _003C_003E9__101_ = _003C_003Ec._003C_003E9__101_0;
				if (_003C_003E9__101_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T1, T2, TResult>)delegate
					{
						/*Error: Unexpected end of block*/;
					};
				}
				int num4 = 0;
				int num5 = Enumerable.Aggregate<int, GridFloorType>((IEnumerable<>)(object)floorTypes_, num4, (Func<, , >)(object)_003C_003E9__101_);
				ICollection<GridObject> values = (ICollection<GridObject>)((MapField<TKey, TValue>)(object)objects_).get_Values();
				if (_003C_003Ec._003C_003E9__101_1 == null)
				{
					func = (Func<GridObject, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((GridObject x) => result));
				}
				bool flag = ((IEnumerable<>)values).Any<GridObject>((Func<, >)(object)func);
				if (flag && (flag ? 1 : 0) >= (false ? 1 : 0))
				{
					break;
				}
				GridData gridData3 = GridData;
				int sizeY_2 = gridData.sizeY_;
				sizeY_2 -= func;
				sizeY_2 -= func;
				ICollection<GridObject> values2 = (ICollection<GridObject>)((MapField<TKey, TValue>)(object)objects_).get_Values();
				if (values2 != null)
				{
					GridPosition gridPosition = *(GridPosition*)num + *(GridPosition*)num;
					while (!flag2)
					{
					}
					int sizeX_2 = gridData.sizeX_;
					sizeX_2 -= tuple;
					int sizeY_3 = gridData.sizeY_;
					sizeY_3 -= tuple;
				}
				if (values2 != null)
				{
				}
				if (num == 0)
				{
					int num6 = 0;
					int num7 = 0;
					break;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085D8")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BCF0", Offset = "0x1D1A6F0", VA = "0x181D1BCF0", Slot = "43")]
		IGrid IGrid.Clone()
		{
			Grid grid = Clone();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60085D9")]
		[Cpp2IlInjected.Address(RVA = "0x1D1C750", Offset = "0x1D1B150", VA = "0x181D1C750")]
		public static GridObject SwitchGridObjectGrid(Grid oldGrid, GridObject oldGridObject, Grid newGrid, GridPosition newPosition, GridOrientation newOrientation, bool clearArea, in Player player, in World world)
		{
			int num = 0;
			int num2 = 0;
			GridState state_ = oldGridObject.state_;
			if (oldGridObject.sourceCase_ == GridObject.SourceOneofCase.None)
			{
			}
			GridSource from = oldGridObject.From;
			int num3 = 0;
			int num4 = (int)from;
			int itemID_ = oldGridObject.itemID_;
			GridState state_2 = oldGridObject.state_;
			if (oldGridObject.sourceCase_ == GridObject.SourceOneofCase.None)
			{
			}
			GridSource from2 = oldGridObject.From;
			int num5 = 0;
			int num6 = (int)from2;
			num6 = itemID_;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag && flag2)
			{
				uint num7 = default(uint);
				if (num5 < (int)num7)
				{
					num5 += num5;
					num5++;
				}
				itemID_ += itemID_;
				num5 += 312;
			}
			if (num5 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085DA")]
		[Cpp2IlInjected.Address(RVA = "0x1D18630", Offset = "0x1D17030", VA = "0x181D18630", Slot = "44")]
		void IDataValidation.DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0175, IL_0193, IL_0199, IL_019f, IL_01a5
			//IL_0014: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			//IL_00b1: Expected O, but got I4
			//IL_00c5: Expected O, but got I4
			//IL_00db: Expected O, but got I4
			//IL_016c: Expected O, but got I4
			//IL_016c: Expected O, but got I4
			//IL_016c: Expected O, but got I4
			uint num5 = default(uint);
			bool flag2 = default(bool);
			Func<GridObject, bool> func = default(Func<GridObject, bool>);
			ICollection<> collection = default(ICollection<>);
			bool flag3 = default(bool);
			(bool, GridCellConflict) tuple = default((bool, GridCellConflict));
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int validate = 0;
				bool flag = Init((byte)validate != 0, (GridData)num4);
				Dictionary<GridPosition, List<GridObject>> dictionary = (Dictionary<GridPosition, List<GridObject>>)(object)new Dictionary<TKey, TValue>();
				ICollection<GridObject> values = (ICollection<GridObject>)((MapField<TKey, TValue>)(object)objects_).get_Values();
				if (values != null)
				{
					if (num3 < (int)num5)
					{
						num3 += num3;
						if (num3 == (int)num5)
						{
							goto IL_005b;
						}
						num3++;
					}
					if (!flag2)
					{
						string text = $"Object {flag2} with ID {flag2} at position {flag2} does not fit in the grid";
						goto IL_005b;
					}
					goto IL_0062;
				}
				goto IL_00db;
				IL_00db:
				int num6 = 0;
				if (values != null)
				{
					int num7 = 0;
				}
				if (num3 != 0)
				{
					continue;
				}
				if (_003C_003Ec._003C_003E9__105_0 == null)
				{
					func = (Func<GridObject, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GridObject x)
					{
						//Discarded unreachable code: IL_0012
						int itemID = x.ItemID;
						bool flag4 = default(bool);
						FurnitureItemType furnitureItemType = default(FurnitureItemType);
						return (!flag4) ? flag4 : (furnitureItemType == FurnitureItemType.Fence);
					});
				}
				GridObject[] array = Enumerable.Where<GridObject>((IEnumerable<>)collection, (Func<, >)(object)func).ToArray<GridObject>();
				int length = array.Length;
				if (num6 < length)
				{
					GridObject gridObject = array[num6];
					if (!flag3)
					{
						int itemID_ = gridObject.itemID_;
						uint num8 = gridObject.iD_;
						int y_ = gridObject.y_;
						y_ = itemID_;
						string text2 = $"Fence {itemID_} with ID {y_} at position {itemID_} is in an invalid setup. Extensions are exposed without bases!";
					}
					num6++;
				}
				return;
				IL_005b:
				flag2 = (byte)((flag2 ? 1u : 0u) + (flag2 ? 1u : 0u)) != 0;
				goto IL_0062;
				IL_0062:
				if ((object)tuple != null)
				{
					object[] array2 = new object[4];
					if (array2 != null && array2 == null)
					{
						throw new IndexOutOfRangeException();
					}
					array2[0] = array2;
					if (array2 != null && array2 == null)
					{
						throw new IndexOutOfRangeException();
					}
					array2[1] = array2;
					if (num3 != 0 && num3 == 0)
					{
						throw new IndexOutOfRangeException();
					}
					array2[2] = num3;
					if (num3 != 0 && num3 == 0)
					{
						break;
					}
					array2[3] = num3;
					string text3 = string.Format("Object {0} with ID {1} at position {2} cannot be placed on the grid because of {3}", array2);
				}
				Meta.Grids.GridCells.AddToGridCells((Dictionary<, >)(object)dictionary, (GridObject)num3);
				goto IL_00db;
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085DB")]
		[Cpp2IlInjected.Address(RVA = "0x1D1CED0", Offset = "0x1D1B8D0", VA = "0x181D1CED0")]
		static Grid()
		{
			FieldCodec<uint> fieldCodec = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			MessageParser<GridObject> parser = GridObject._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<GridObject>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<Grid>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60085DC")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BD00", Offset = "0x1D1A700", VA = "0x181D1BD00", Slot = "24")]
		void IGrid.Create(in WorldProfile worldProfile, ITransactionContext context)
		{
			Create(in worldProfile, context);
		}

		[Cpp2IlInjected.Token(Token = "0x60085DD")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BEE0", Offset = "0x1D1A8E0", VA = "0x181D1BEE0", Slot = "34")]
		bool IGrid.IsAreaInside(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea)
		{
			return IsAreaInside(in gridPosition, gridOrientation, in gridArea);
		}

		[Cpp2IlInjected.Token(Token = "0x60085DE")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BF10", Offset = "0x1D1A910", VA = "0x181D1BF10", Slot = "35")]
		bool IGrid.IsAreaValid(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, bool automaticSpawning)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60085DF")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BEF0", Offset = "0x1D1A8F0", VA = "0x181D1BEF0", Slot = "36")]
		bool IGrid.IsAreaValidFor(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60085E0")]
		[Cpp2IlInjected.Address(RVA = "0x1D19E20", Offset = "0x1D18820", VA = "0x181D19E20", Slot = "37")]
		GridLayers IGrid.GetLayersForPosition(in GridPosition gridPosition)
		{
			if (_gridCells == null)
			{
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			bool flag = default(bool);
			if (flag && num < num)
			{
				int num4 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				num++;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085E1")]
		[Cpp2IlInjected.Address(RVA = "0x1D19CA0", Offset = "0x1D186A0", VA = "0x181D19CA0", Slot = "38")]
		List<GridObject> IGrid.GetGridObjectsForPosition(in GridPosition gridPosition)
		{
			GridData gridData = GridData;
			bool flag = default(bool);
			if (!flag || _gridCells == null)
			{
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085E2")]
		[Cpp2IlInjected.Address(RVA = "0x1D19F90", Offset = "0x1D18990", VA = "0x181D19F90", Slot = "39")]
		bool IGrid.HasConflicts(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning, Item? clearedBy, GridCellConflict conflictsToCheck)
		{
			if (_gridCells == null)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60085E3")]
		[Cpp2IlInjected.Address(RVA = "0x1D19AB0", Offset = "0x1D184B0", VA = "0x181D19AB0", Slot = "40")]
		(bool, GridCellConflict) IGrid.GetConflicts(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning, Item? clearedBy, GridCellConflict conflictsToCheck)
		{
			if (_gridCells == null)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60085E4")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BD10", Offset = "0x1D1A710", VA = "0x181D1BD10", Slot = "41")]
		(bool, GridCellConflict, GridCellConflict[][]) IGrid.GetConflictedCells(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning, Item? clearedBy)
		{
			GridCellConflict[] array2 = default(GridCellConflict[]);
			while (true)
			{
				GridCellConflict[][] array = new GridCellConflict[ref System.Runtime.CompilerServices.Unsafe.As<GridPosition, _003F>(ref gridPosition)][];
				int num = 0;
				int num2 = 0;
				if (num2 >= array.Length)
				{
					break;
				}
				array2 = new GridCellConflict[ref System.Runtime.CompilerServices.Unsafe.As<GridPosition, _003F>(ref gridPosition)];
				if (array2 == null || array2 != null)
				{
					num2 = num;
					num += 4;
					num++;
					num2 = num;
					break;
				}
			}
			if (array2 == null)
			{
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60085E5")]
		[Cpp2IlInjected.Address(RVA = "0x1D19A40", Offset = "0x1D18440", VA = "0x181D19A40", Slot = "42")]
		List<GridObject> IGrid.GetConflictedObjects(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject)
		{
			if (this == null)
			{
			}
			List<GridObject> result = default(List<GridObject>);
			return result;
		}
	}
}
