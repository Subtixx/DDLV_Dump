using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Grids
{
	[Cpp2IlInjected.Token(Token = "0x200107F")]
	public sealed class DiffGrid : IMessage<DiffGrid>, IMessage, IEquatable<DiffGrid>, IDeepCloneable<DiffGrid>, IMessageFieldAccessor, IGridInternal, IGrid
	{
		[Cpp2IlInjected.Token(Token = "0x4004412")]
		private static readonly MessageParser<DiffGrid> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004413")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4004414")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004415")]
		private uint iD_;

		[Cpp2IlInjected.Token(Token = "0x4004416")]
		public const int GridDefaultLayoutPathFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004417")]
		private string gridDefaultLayoutPath_ = "";

		[Cpp2IlInjected.Token(Token = "0x4004418")]
		public const int GridDefaultLayoutTypeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004419")]
		private string gridDefaultLayoutType_ = "";

		[Cpp2IlInjected.Token(Token = "0x400441A")]
		public const int DefaultLayoutGridIDFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400441B")]
		private uint defaultLayoutGridID_;

		[Cpp2IlInjected.Token(Token = "0x400441C")]
		public const int DefaultGridHashCodeFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400441D")]
		private int defaultGridHashCode_;

		[Cpp2IlInjected.Token(Token = "0x400441E")]
		public const int DefaultGridDataHashCodeFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400441F")]
		private int defaultGridDataHashCode_;

		[Cpp2IlInjected.Token(Token = "0x4004420")]
		public const int ModifiedObjectsFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x4004421")]
		private static readonly MapField<uint, GridObject>.Codec _map_modifiedObjects_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4004422")]
		private readonly MapField<uint, GridObject> modifiedObjects_ = (MapField<uint, GridObject>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x4004423")]
		public const int RemovedObjectsFieldNumber = 8;

		[Cpp2IlInjected.Token(Token = "0x4004424")]
		private static readonly FieldCodec<uint> _repeated_removedObjects_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004425")]
		private readonly RepeatedField<uint> removedObjects_ = (RepeatedField<uint>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4004426")]
		public const int NextGridObjectIDFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4004427")]
		private uint nextGridObjectID_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4004428")]
		private Grid defaultGrid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4004429")]
		private IWorldEventDispatcher dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400442A")]
		private Dictionary<GridPosition, List<GridObject>> _gridCells;

		[Cpp2IlInjected.Token(Token = "0x1700174B")]
		[DebuggerNonUserCode]
		public static MessageParser<DiffGrid> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60085FD")]
			[Cpp2IlInjected.Address(RVA = "0x1738920", Offset = "0x1737320", VA = "0x181738920")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700174C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60085FE")]
			[Cpp2IlInjected.Address(RVA = "0x1738770", Offset = "0x1737170", VA = "0x181738770")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700174D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60085FF")]
			[Cpp2IlInjected.Address(RVA = "0x17389D0", Offset = "0x17373D0", VA = "0x1817389D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700174E")]
		[DebuggerNonUserCode]
		public uint ID
		{
			[Cpp2IlInjected.Token(Token = "0x6008603")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008604")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700174F")]
		[DebuggerNonUserCode]
		public string GridDefaultLayoutPath
		{
			[Cpp2IlInjected.Token(Token = "0x6008605")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return gridDefaultLayoutPath_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008606")]
			[Cpp2IlInjected.Address(RVA = "0x1738AE0", Offset = "0x17374E0", VA = "0x181738AE0")]
			set
			{
				string text = (gridDefaultLayoutPath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001750")]
		[DebuggerNonUserCode]
		public string GridDefaultLayoutType
		{
			[Cpp2IlInjected.Token(Token = "0x6008607")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return gridDefaultLayoutType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008608")]
			[Cpp2IlInjected.Address(RVA = "0x1738B50", Offset = "0x1737550", VA = "0x181738B50")]
			set
			{
				string text = (gridDefaultLayoutType_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001751")]
		[DebuggerNonUserCode]
		public uint DefaultLayoutGridID
		{
			[Cpp2IlInjected.Token(Token = "0x6008609")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return defaultLayoutGridID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600860A")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				defaultLayoutGridID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001752")]
		[DebuggerNonUserCode]
		public int DefaultGridHashCode
		{
			[Cpp2IlInjected.Token(Token = "0x600860B")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return defaultGridHashCode_;
			}
			[Cpp2IlInjected.Token(Token = "0x600860C")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				defaultGridHashCode_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001753")]
		[DebuggerNonUserCode]
		public int DefaultGridDataHashCode
		{
			[Cpp2IlInjected.Token(Token = "0x600860D")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return defaultGridDataHashCode_;
			}
			[Cpp2IlInjected.Token(Token = "0x600860E")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				defaultGridDataHashCode_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001754")]
		[DebuggerNonUserCode]
		public MapField<uint, GridObject> ModifiedObjects
		{
			[Cpp2IlInjected.Token(Token = "0x600860F")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return modifiedObjects_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001755")]
		[DebuggerNonUserCode]
		public RepeatedField<uint> RemovedObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6008610")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return removedObjects_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001756")]
		[DebuggerNonUserCode]
		public uint NextGridObjectID
		{
			[Cpp2IlInjected.Token(Token = "0x6008611")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return nextGridObjectID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008612")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				nextGridObjectID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001757")]
		public GridPosition Size
		{
			[Cpp2IlInjected.Token(Token = "0x600861E")]
			[Cpp2IlInjected.Address(RVA = "0x1738980", Offset = "0x1737380", VA = "0x181738980", Slot = "19")]
			get
			{
				GridData _003CGridData_003Ek__BackingField = defaultGrid.GridData;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001758")]
		public string GridDataPath
		{
			[Cpp2IlInjected.Token(Token = "0x600861F")]
			[Cpp2IlInjected.Address(RVA = "0x1738870", Offset = "0x1737270", VA = "0x181738870", Slot = "20")]
			get
			{
				//Discarded unreachable code: IL_000c
				return defaultGrid.gridDataPath_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001759")]
		public GridData GridData
		{
			[Cpp2IlInjected.Token(Token = "0x6008620")]
			[Cpp2IlInjected.Address(RVA = "0x1738890", Offset = "0x1737290", VA = "0x181738890", Slot = "21")]
			get
			{
				//Discarded unreachable code: IL_000c
				return defaultGrid.GridData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700175A")]
		public GridFloorType AvailableFloorTypes
		{
			[Cpp2IlInjected.Token(Token = "0x6008621")]
			[Cpp2IlInjected.Address(RVA = "0x1738750", Offset = "0x1737150", VA = "0x181738750", Slot = "22")]
			get
			{
				//Discarded unreachable code: IL_000c
				return defaultGrid.AvailableFloorTypes;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700175B")]
		public IEnumerable<GridObject> Objects
		{
			[Cpp2IlInjected.Token(Token = "0x6008622")]
			[Cpp2IlInjected.Address(RVA = "0x17388B0", Offset = "0x17372B0", VA = "0x1817388B0", Slot = "23")]
			[IteratorStateMachine(typeof(_003Cget_Objects_003Ed__77))]
			get
			{
				new _003Cget_Objects_003Ed__77(-2)._003C_003E4__this = this;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700175C")]
		private Dictionary<GridPosition, List<GridObject>> GridCells
		{
			[Cpp2IlInjected.Token(Token = "0x6008623")]
			[Cpp2IlInjected.Address(RVA = "0x1738840", Offset = "0x1737240", VA = "0x181738840")]
			get
			{
				Dictionary<GridPosition, List<GridObject>> gridCells = _gridCells;
				if (gridCells == null)
				{
				}
				return gridCells;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008600")]
		[Cpp2IlInjected.Address(RVA = "0x1738660", Offset = "0x1737060", VA = "0x181738660")]
		[DebuggerNonUserCode]
		public DiffGrid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008601")]
		[Cpp2IlInjected.Address(RVA = "0x1738460", Offset = "0x1736E60", VA = "0x181738460")]
		[DebuggerNonUserCode]
		public DiffGrid(DiffGrid other)
		{
			uint num = (iD_ = other.iD_);
			string text = (gridDefaultLayoutPath_ = other.gridDefaultLayoutPath_);
			string text2 = (gridDefaultLayoutType_ = other.gridDefaultLayoutType_);
			uint num2 = (defaultLayoutGridID_ = other.defaultLayoutGridID_);
			int num3 = (defaultGridHashCode_ = other.defaultGridHashCode_);
			int num4 = (defaultGridDataHashCode_ = other.defaultGridDataHashCode_);
			MapField<uint, GridObject> mapField = (modifiedObjects_ = (MapField<uint, GridObject>)(object)((MapField<TKey, TValue>)(object)other.modifiedObjects_).Clone());
			RepeatedField<uint> repeatedField = (removedObjects_ = (RepeatedField<uint>)(object)((RepeatedField<T>)(object)other.removedObjects_).Clone());
			uint num5 = (nextGridObjectID_ = other.nextGridObjectID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008602")]
		[Cpp2IlInjected.Address(RVA = "0x17340A0", Offset = "0x1732AA0", VA = "0x1817340A0", Slot = "10")]
		[DebuggerNonUserCode]
		public DiffGrid Clone()
		{
			return new DiffGrid(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008613")]
		[Cpp2IlInjected.Address(RVA = "0x17344D0", Offset = "0x1732ED0", VA = "0x1817344D0", Slot = "0")]
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
				if ((IntPtr)(int)iD_ == (IntPtr)typeof(DiffGrid).TypeHandle)
				{
					string text = gridDefaultLayoutPath_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = gridDefaultLayoutType_;
						bool flag2 = default(bool);
						if (!flag2 && defaultLayoutGridID_ == (flag2 ? 1u : 0u) && defaultGridHashCode_ == (flag2 ? 1 : 0) && defaultGridDataHashCode_ == (flag2 ? 1 : 0))
						{
							MapField<uint, GridObject> mapField = modifiedObjects_;
							bool flag3 = default(bool);
							if (flag3)
							{
								RepeatedField<uint> repeatedField = removedObjects_;
								bool flag4 = default(bool);
								if (flag4 && nextGridObjectID_ == (flag4 ? 1u : 0u))
								{
									return object.Equals(_unknownFields, other);
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008614")]
		[Cpp2IlInjected.Address(RVA = "0x1734640", Offset = "0x1733040", VA = "0x181734640", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DiffGrid other)
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
					string text = other.gridDefaultLayoutPath_;
					if (!(gridDefaultLayoutPath_ != text))
					{
						string text2 = other.gridDefaultLayoutType_;
						if (!(gridDefaultLayoutType_ != text2))
						{
							uint num2 = other.defaultLayoutGridID_;
							if (defaultLayoutGridID_ == num2)
							{
								int num3 = other.defaultGridHashCode_;
								if (defaultGridHashCode_ == num3)
								{
									int num4 = other.defaultGridDataHashCode_;
									if (defaultGridDataHashCode_ == num4)
									{
										MapField<uint, GridObject> mapField = modifiedObjects_;
										MapField<uint, GridObject> mapField2 = other.modifiedObjects_;
										if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
										{
											RepeatedField<uint> repeatedField = removedObjects_;
											RepeatedField<uint> repeatedField2 = other.removedObjects_;
											if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
											{
												uint num5 = other.nextGridObjectID_;
												if (nextGridObjectID_ == num5)
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
					}
				}
			}
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008615")]
		[Cpp2IlInjected.Address(RVA = "0x1734CF0", Offset = "0x17336F0", VA = "0x181734CF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0098
			int num = 0;
			if (iD_ != 0)
			{
			}
			string text = gridDefaultLayoutPath_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = gridDefaultLayoutType_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			if (defaultLayoutGridID_ != 0)
			{
			}
			if (defaultGridHashCode_ != 0)
			{
			}
			if (defaultGridDataHashCode_ != 0)
			{
			}
			int hashCode3 = ((MapField<TKey, TValue>)(object)modifiedObjects_).GetHashCode();
			int hashCode4 = ((RepeatedField<T>)(object)removedObjects_).GetHashCode();
			if (nextGridObjectID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode5 = unknownFields.GetHashCode();
			}
			return hashCode4;
		}

		[Cpp2IlInjected.Token(Token = "0x6008616")]
		[Cpp2IlInjected.Address(RVA = "0x1737B70", Offset = "0x1736570", VA = "0x181737B70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008617")]
		[Cpp2IlInjected.Address(RVA = "0x1737FD0", Offset = "0x17369D0", VA = "0x181737FD0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00fc
			if (iD_ != 0)
			{
				uint value = iD_;
				output.WriteUInt32(value);
			}
			if (gridDefaultLayoutPath_.m_stringLength != 0)
			{
				string value2 = gridDefaultLayoutPath_;
				output.WriteString(value2);
			}
			if (gridDefaultLayoutType_.m_stringLength != 0)
			{
				string value3 = gridDefaultLayoutType_;
				output.WriteString(value3);
			}
			if (defaultLayoutGridID_ != 0)
			{
				uint value4 = defaultLayoutGridID_;
				output.WriteUInt32(value4);
			}
			if (defaultGridHashCode_ != 0)
			{
				int value5 = defaultGridHashCode_;
				output.WriteInt32(value5);
			}
			if (defaultGridDataHashCode_ != 0)
			{
				int value6 = defaultGridDataHashCode_;
				output.WriteInt32(value6);
			}
			MapField<uint, GridObject> mapField = modifiedObjects_;
			MapField<uint, GridObject>.Codec map_modifiedObjects_codec = _map_modifiedObjects_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_modifiedObjects_codec);
			RepeatedField<uint> repeatedField = removedObjects_;
			FieldCodec<uint> repeated_removedObjects_codec = _repeated_removedObjects_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_removedObjects_codec);
			if (nextGridObjectID_ != 0)
			{
				uint value7 = nextGridObjectID_;
				output.WriteUInt32(value7);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008618")]
		[Cpp2IlInjected.Address(RVA = "0x1733CC0", Offset = "0x17326C0", VA = "0x181733CC0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0135
			uint num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeUInt32Size(num);
			}
			string text = gridDefaultLayoutPath_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = gridDefaultLayoutType_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			uint num6 = defaultLayoutGridID_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeUInt32Size(num6);
				num7++;
				num2 += num7;
			}
			int num8 = defaultGridHashCode_;
			if (num8 != 0)
			{
				int num9 = CodedOutputStream.ComputeInt32Size(num8);
				num9++;
				num2 += num9;
			}
			int num10 = defaultGridDataHashCode_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			MapField<uint, GridObject> mapField = modifiedObjects_;
			MapField<uint, GridObject>.Codec map_modifiedObjects_codec = _map_modifiedObjects_codec;
			int num12 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_modifiedObjects_codec);
			RepeatedField<uint> repeatedField = removedObjects_;
			FieldCodec<uint> repeated_removedObjects_codec = _repeated_removedObjects_codec;
			int num13 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_removedObjects_codec);
			uint num14 = nextGridObjectID_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeUInt32Size(num14);
				num15++;
				num2 += num15;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num16 = unknownFields.CalculateSize();
				num2 += num16;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6008619")]
		[Cpp2IlInjected.Address(RVA = "0x1736640", Offset = "0x1735040", VA = "0x181736640", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DiffGrid other)
		{
			//Discarded unreachable code: IL_00ed
			if (other != null)
			{
				uint num = other.iD_;
				if (num != 0)
				{
					iD_ = num;
				}
				string text = other.gridDefaultLayoutPath_;
				if (text.m_stringLength != 0)
				{
					GridDefaultLayoutPath = text;
				}
				string text2 = other.gridDefaultLayoutType_;
				if (text2.m_stringLength != 0)
				{
					GridDefaultLayoutType = text2;
				}
				uint num2 = other.defaultLayoutGridID_;
				if (num2 != 0)
				{
					defaultLayoutGridID_ = num2;
				}
				int num3 = other.defaultGridHashCode_;
				if (num3 != 0)
				{
					defaultGridHashCode_ = num3;
				}
				int num4 = other.defaultGridDataHashCode_;
				if (num4 != 0)
				{
					defaultGridDataHashCode_ = num4;
				}
				MapField<uint, GridObject> mapField = modifiedObjects_;
				MapField<uint, GridObject> mapField2 = other.modifiedObjects_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				RepeatedField<uint> repeatedField = removedObjects_;
				RepeatedField<uint> repeatedField2 = other.removedObjects_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				uint num5 = other.nextGridObjectID_;
				if (num5 != 0)
				{
					nextGridObjectID_ = num5;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600861A")]
		[Cpp2IlInjected.Address(RVA = "0x1736760", Offset = "0x1735160", VA = "0x181736760", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_011b
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 40)
			{
				if ((int)num > 58)
				{
					if ((long)input != 4294967293L)
					{
						if (num != 72)
						{
							goto IL_0104;
						}
						int num2 = (int)(nextGridObjectID_ = (uint)input.ReadInt32());
					}
					RepeatedField<uint> repeatedField = removedObjects_;
					FieldCodec<uint> repeated_removedObjects_codec = _repeated_removedObjects_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_removedObjects_codec);
				}
				if (num == 48)
				{
					int num3 = (defaultGridDataHashCode_ = input.ReadInt32());
				}
				if (num != 58)
				{
					goto IL_0104;
				}
				MapField<uint, GridObject> mapField = modifiedObjects_;
				MapField<uint, GridObject>.Codec map_modifiedObjects_codec = _map_modifiedObjects_codec;
				((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_modifiedObjects_codec);
			}
			int num5 = default(int);
			if ((int)num > 18)
			{
				string text2 = default(string);
				if (num == 26)
				{
					text2 = (GridDefaultLayoutType = input.ReadString());
				}
				int num4 = default(int);
				if ((long)text2 == 32)
				{
					num4 = (int)(defaultLayoutGridID_ = (uint)input.ReadInt32());
				}
				if (num4 != 40)
				{
					goto IL_0104;
				}
				num5 = (defaultGridHashCode_ = input.ReadInt32());
			}
			int num6 = default(int);
			if (num5 == 8)
			{
				num6 = (int)(iD_ = (uint)input.ReadInt32());
			}
			if (num6 == 18)
			{
				string text4 = (GridDefaultLayoutPath = input.ReadString());
			}
			goto IL_0104;
			IL_0104:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600861B")]
		[Cpp2IlInjected.Address(RVA = "0x1734AE0", Offset = "0x17334E0", VA = "0x181734AE0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 8)
			{
				uint num = iD_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600861C")]
		[Cpp2IlInjected.Address(RVA = "0x1737870", Offset = "0x1736270", VA = "0x181737870", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_001d, IL_0025, IL_002d, IL_0035, IL_003d, IL_0043, IL_0049, IL_004f
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 8)
			{
				object obj = default(object);
				iD_ = (uint)(int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600861D")]
		[Cpp2IlInjected.Address(RVA = "0x1733F30", Offset = "0x1732930", VA = "0x181733F30", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0014, IL_0015, IL_0016, IL_0018
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 8)
			{
				iD_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008624")]
		[Cpp2IlInjected.Address(RVA = "0x1734100", Offset = "0x1732B00", VA = "0x181734100")]
		public void Create(in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_008a, IL_0090, IL_0096, IL_009c, IL_00a2
			//IL_006a: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			bool flag = default(bool);
			StallData stallData = default(StallData);
			GridObject gridObject = default(GridObject);
			while (true)
			{
				int num = 0;
				Init();
				defaultGrid.Create(in worldProfile, context);
				int num2 = (defaultGridHashCode_ = defaultGrid.GetHashCode());
				int num3 = (defaultGridDataHashCode_ = defaultGrid.GridData.GetHashCode());
				MapField<uint, GridObject> objects_ = defaultGrid.objects_;
				if (!flag)
				{
					break;
				}
				if (num == 0)
				{
					while (num == 0)
					{
					}
					while (stallData == null)
					{
					}
				}
				if (!((MapField<TKey, TValue>)(object)modifiedObjects_).ContainsKey((TKey)num))
				{
					MapField<uint, GridObject> mapField = modifiedObjects_;
					uint num4 = gridObject.iD_;
					((MapField<TKey, TValue>)(object)mapField).Add((TKey)num4, (TValue)gridObject);
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008625")]
		[Cpp2IlInjected.Address(RVA = "0x1735F40", Offset = "0x1734940", VA = "0x181735F40", Slot = "25")]
		public void Init()
		{
			//IL_005f: Expected O, but got I4
			int num = 0;
			if ((IntPtr)defaultGrid != (IntPtr)num)
			{
				return;
			}
			string path = gridDefaultLayoutPath_;
			byte[] array = FileSystem.Data.ReadAllBytes(path);
			object obj = default(object);
			if (obj == null)
			{
			}
			if (obj != null)
			{
				if (obj != null)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					num += 312;
				}
				if (obj != null)
				{
					uint num3 = defaultLayoutGridID_;
					bool flag = default(bool);
					if (!flag)
					{
						return;
					}
					if (num == 0 || num != 0)
					{
						defaultGrid = (Grid)num;
						return;
					}
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008626")]
		[Cpp2IlInjected.Address(RVA = "0x1734F50", Offset = "0x1733950", VA = "0x181734F50")]
		internal unsafe bool InitAndUpdate(GridCollection gridCollection, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0354, IL_035a, IL_0360, IL_0366, IL_036c, IL_0372, IL_0378, IL_037e, IL_0384, IL_038a, IL_0390, IL_0396, IL_039c, IL_03a2, IL_03a8, IL_03ae, IL_03b4, IL_03ba, IL_03c6, IL_03cc, IL_03d2, IL_03d8, IL_03de, IL_03ea, IL_03f0, IL_03f6, IL_03fc, IL_0402, IL_0408, IL_040e, IL_0414, IL_041a, IL_0420, IL_0426, IL_042c, IL_0432, IL_0438, IL_043e, IL_0444
			//IL_009d: Expected I4, but got O
			//IL_0167: Expected O, but got I4
			//IL_0174: Expected O, but got I4
			//IL_0187: Expected O, but got I4
			//IL_019a: Expected O, but got I4
			//IL_01fa: Expected O, but got I4
			//IL_0202: Expected O, but got I4
			//IL_020f: Expected O, but got I4
			//IL_02f9: Expected O, but got I4
			uint num6 = default(uint);
			uint num7 = default(uint);
			bool flag = default(bool);
			int num8 = default(int);
			uint num9 = default(uint);
			GridObject gridObject = default(GridObject);
			uint gridID_ = default(uint);
			StallData stallData = default(StallData);
			SubGrid subGrid3 = default(SubGrid);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			Action<uint> action = default(Action<uint>);
			bool flag4 = default(bool);
			GridObject gridObject2 = default(GridObject);
			bool flag5 = default(bool);
			IEnumerable<GridPosition> enumerable = default(IEnumerable<GridPosition>);
			uint num12 = default(uint);
			IItemData itemData = default(IItemData);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				Init();
				Grid grid = defaultGrid;
				Dictionary<GridPosition, List<GridObject>> gridCells;
				ICollection<GridObject> values;
				if (grid != null)
				{
					int hashCode = grid.GetHashCode();
					int hashCode2 = defaultGrid.GridData.GetHashCode();
					if (defaultGridDataHashCode_ != 0)
					{
					}
					int num5 = defaultGridHashCode_;
					if (num5 != 0)
					{
					}
					if (hashCode != num5)
					{
						defaultGridHashCode_ = hashCode;
						defaultGridDataHashCode_ = hashCode2;
						int index = ((RepeatedField<T>)(object)removedObjects_).Count - 1;
						Grid grid2 = defaultGrid;
						uint gridObjectID = (uint)(int)((RepeatedField<T>)(object)removedObjects_)[index];
						if (!grid2.TryGetObject(gridObjectID, out *(GridObject*)num))
						{
							((RepeatedField<T>)(object)removedObjects_).RemoveAt(index);
						}
						gridCells = (Dictionary<GridPosition, List<GridObject>>)(object)new Dictionary<TKey, TValue>();
						values = (ICollection<GridObject>)((MapField<TKey, TValue>)(object)defaultGrid.objects_).get_Values();
						if (num < (int)num6)
						{
							num += num;
							num++;
						}
						if (values != null)
						{
							if (num < (int)num7)
							{
								num += num;
								if (num == (int)num7)
								{
									goto IL_011c;
								}
								num++;
							}
							MapField<uint, GridObject> mapField = modifiedObjects_;
							if (!flag)
							{
								if (mapField != null)
								{
									num8 = 0;
									num8 += num8;
									goto IL_011c;
								}
								goto IL_0123;
							}
							goto IL_0167;
						}
						goto IL_01ce;
					}
				}
				goto IL_034b;
				IL_0167:
				if (((MapField<TKey, TValue>)(object)modifiedObjects_).ContainsKey((TKey)num9) || ((RepeatedField<T>)(object)removedObjects_).Contains((T)num9))
				{
					continue;
				}
				Meta.Grids.GridCells.AddToGridCells((Dictionary<, >)(object)gridCells, (GridObject)num);
				goto IL_019a;
				IL_034b:
				int num10 = 0;
				throw new NullReferenceException();
				IL_011c:
				num8 += num8;
				goto IL_0123;
				IL_019a:
				GridState state_ = gridObject.state_;
				SubGrid subGrid = state_.SubGrid;
				string text = gridDefaultLayoutType_;
				SubGrid subGrid2 = state_.SubGrid;
				subGrid.gridID_ = gridID_;
				IWorldEventDispatcher worldEventDispatcher = dispatcher;
				goto IL_01ce;
				IL_0123:
				if (num != 0 || (num != 0 && stallData != null))
				{
					if (num != 0)
					{
					}
					if (num != 0)
					{
						if (subGrid3 != null)
						{
							goto IL_019a;
						}
						IGridStateData stateData = gridObject.state_.StateData;
					}
					MapField<uint, GridObject> mapField2 = modifiedObjects_;
					num9 = gridObject.iD_;
					((MapField<TKey, TValue>)(object)mapField2).Add((TKey)num9, (TValue)gridObject);
				}
				goto IL_0167;
				IL_01ce:
				if (values != null)
				{
				}
				if (num == 0)
				{
					List<uint> list = (List<uint>)(object)new List<T>();
					List<uint> list2 = (List<uint>)(object)new List<T>();
					if (flag2)
					{
						if (!flag3)
						{
							((List<T>)(object)list).Add((T)num);
							((List<T>)(object)list2).Add((T)num);
						}
						Meta.Grids.GridCells.AddToGridCells((Dictionary<, >)(object)gridCells, (GridObject)num);
					}
					int num11 = 0;
					if (num != 0)
					{
						break;
					}
					((List<T>)(object)list2).ForEach((Action<>)(object)action);
					if (flag4)
					{
						GridObject newGridObject = gridObject2;
						GridObject gridObject3 = newGridObject;
						_003C_003Ec__DisplayClass85_0 _003C_003Ec__DisplayClass85_;
						_003C_003Ec__DisplayClass85_0 _003C_003Ec__DisplayClass85_2 = _003C_003Ec__DisplayClass85_;
						GridPosition position = newGridObject.Position;
						GridObject gridObject4 = newGridObject;
						if (!flag5)
						{
							GridPosition position2 = newGridObject.Position;
							Func<GridPosition, bool> func = (Func<GridPosition, bool>)(object)(Func<T, TResult>)delegate
							{
								//Discarded unreachable code: IL_0018
								GridObject gridObject9 = newGridObject;
								DiffGrid diffGrid = this;
								bool result = default(bool);
								return result;
							};
							if (Enumerable.Take<GridPosition>((IEnumerable<>)enumerable, (int)num12).ToArray<GridPosition>().Length == 0)
							{
								int itemID = newGridObject.ItemID;
								if (!itemData.IsMissionItem())
								{
								}
								GridObject gridObject5 = newGridObject;
								Meta.Grids.GridCells.AddToGridCells((Dictionary<, >)(object)gridCells, gridObject5);
								int itemID2 = newGridObject.ItemID;
								string text2 = $"A mission item {itemID2} is not on a valid position on the grid and there is no place for it anywhere";
							}
							GridObject gridObject6 = newGridObject;
							GridObject gridObject7 = newGridObject;
							Meta.Grids.GridCells.AddToGridCells((Dictionary<, >)(object)gridCells, gridObject7);
						}
						GridObject gridObject8 = newGridObject;
						Meta.Grids.GridCells.AddToGridCells((Dictionary<, >)(object)gridCells, gridObject8);
					}
					if (num != 0)
					{
						continue;
					}
					goto IL_034b;
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008627")]
		[Cpp2IlInjected.Address(RVA = "0x1737750", Offset = "0x1736150", VA = "0x181737750")]
		internal void SetDispatcher(IWorldEventDispatcher dispatcher)
		{
			//Discarded unreachable code: IL_0028
			if ((long)this.dispatcher == 0)
			{
				this.dispatcher = dispatcher;
				if (dispatcher != null)
				{
					ProfileEventDispatcher.GridChanged gridChanged = Dispatcher_OnGridChanged;
					int num = 0;
					int num2 = 0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008628")]
		[Cpp2IlInjected.Address(RVA = "0x1736230", Offset = "0x1734C30", VA = "0x181736230")]
		internal void Init(Grid defaultGrid)
		{
			//Discarded unreachable code: IL_000e
			this.defaultGrid = defaultGrid;
			defaultGrid.Init();
		}

		[Cpp2IlInjected.Token(Token = "0x6008629")]
		[Cpp2IlInjected.Address(RVA = "0x1736990", Offset = "0x1735390", VA = "0x181736990", Slot = "14")]
		GridObject IGridInternal.AddObject(Item item, in GridPosition position, GridOrientation orientation, GridState state, IWorldEventDispatcher dispatcher, bool automaticSpawning, [Optional] GridSource? source, [Optional] GridAddObjectOptions options)
		{
			//IL_004c: Expected O, but got I4
			//IL_0093: Expected O, but got I4
			int itemID = item.ItemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IGridPlaceableItemData gridPlaceableItemData = default(IGridPlaceableItemData);
			if (gridPlaceableItemData != null)
			{
				GridObject gridObject = new GridObject();
				uint num = nextGridObjectID_;
				uint num2 = (nextGridObjectID_ = num + 1);
				gridObject.iD_ = num;
				gridObject.ItemID = itemID;
				gridObject.state_ = (GridState)0;
				gridObject.orientation_ = orientation;
				GridPosition position2 = gridObject.Position;
				GridOrientation orientation_ = gridObject.orientation_;
				if (_gridCells == null)
				{
				}
				int num3 = 0;
				bool flag = default(bool);
				if (flag)
				{
					MapField<uint, GridObject> mapField = modifiedObjects_;
					uint num4 = gridObject.iD_;
					((MapField<TKey, TValue>)(object)mapField).Add((TKey)num4, (TValue)gridObject);
					Meta.Grids.GridCells.AddToGridCells((Dictionary<, >)(object)_gridCells, gridObject);
					int num5 = 0;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600862A")]
		[Cpp2IlInjected.Address(RVA = "0x1733B40", Offset = "0x1732540", VA = "0x181733B40")]
		internal GridObject AddObject(GridObject gridObject, IWorldEventDispatcher dispatcher, bool automaticSpawning, [Optional] GridAddObjectOptions options)
		{
			//IL_0036: Expected O, but got I4
			GridPosition position = gridObject.Position;
			GridOrientation orientation_ = gridObject.orientation_;
			if (_gridCells == null)
			{
			}
			bool flag = default(bool);
			if (flag)
			{
				MapField<uint, GridObject> mapField = modifiedObjects_;
				uint num = gridObject.iD_;
				((MapField<TKey, TValue>)(object)mapField).Add((TKey)num, (TValue)gridObject);
				Meta.Grids.GridCells.AddToGridCells((Dictionary<, >)(object)_gridCells, gridObject);
				if (dispatcher != null)
				{
					int num2 = 0;
				}
				return gridObject;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600862B")]
		[Cpp2IlInjected.Address(RVA = "0x1736C50", Offset = "0x1735650", VA = "0x181736C50", Slot = "15")]
		bool IGridInternal.CanAddObject(Item item, in GridPosition position, GridOrientation orientation, GridState state, IWorldEventDispatcher dispatcher, bool automaticSpawning, GridSource? source, GridAddObjectOptions options)
		{
			//IL_0049: Expected O, but got I4
			int itemID = item.ItemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IGridPlaceableItemData gridPlaceableItemData = default(IGridPlaceableItemData);
			if (gridPlaceableItemData != null)
			{
				GridObject gridObject = new GridObject();
				uint num = nextGridObjectID_;
				uint num2 = (nextGridObjectID_ = num + 1);
				gridObject.iD_ = num;
				gridObject.ItemID = itemID;
				gridObject.state_ = (GridState)0;
				gridObject.orientation_ = orientation;
				GridPosition position2 = gridObject.Position;
				GridOrientation orientation_ = gridObject.orientation_;
				if (_gridCells == null)
				{
				}
				int num3 = 0;
				bool result = default(bool);
				return result;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600862C")]
		[Cpp2IlInjected.Address(RVA = "0x1736E70", Offset = "0x1735870", VA = "0x181736E70", Slot = "16")]
		unsafe bool IGridInternal.RemoveObject(GridObject gridObject, in World world, bool automaticRemove = false)
		{
			//IL_0017: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			int num = 0;
			MapField<uint, GridObject> mapField = modifiedObjects_;
			uint num2 = gridObject.iD_;
			bool flag = ((MapField<TKey, TValue>)(object)mapField).Remove((TKey)num2);
			Grid grid = defaultGrid;
			uint gridObjectID = gridObject.iD_;
			if (grid.TryGetObject(gridObjectID, out *(GridObject*)num))
			{
				RepeatedField<uint> repeatedField = removedObjects_;
				uint num3 = gridObject.iD_;
				((RepeatedField<T>)(object)repeatedField).Add((T)num3);
			}
			uint num4 = default(uint);
			if (num4 != 0)
			{
				Meta.Grids.GridCells.RemoveFromGridCells((Dictionary<, >)(object)_gridCells, gridObject);
				if (dispatcher != null)
				{
				}
				GridState state_ = gridObject.state_;
				if (state_ != null)
				{
					IGridStateData stateData = state_.StateData;
				}
				uint num5 = default(uint);
				if (num != 0 && num < (int)num5)
				{
					num += num;
					num++;
				}
			}
			grid = (Grid)(object)((object)grid + (object)grid);
			num4 += 312;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600862D")]
		[Cpp2IlInjected.Address(RVA = "0x1737090", Offset = "0x1735A90", VA = "0x181737090", Slot = "17")]
		bool IGridInternal.UpdateTransform(GridObject gridObject, in GridPosition newGridPosition, GridOrientation newGridOrientation, IWorldEventDispatcher dispatcher)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600862E")]
		[Cpp2IlInjected.Address(RVA = "0x1737D00", Offset = "0x1736700", VA = "0x181737D00")]
		internal bool UpdateTransform(GridObject gridObject, in GridPosition newGridPosition, GridOrientation newGridOrientation, IWorldEventDispatcher dispatcher)
		{
			//IL_0040: Expected O, but got I4
			ICollection<GridObject> values = (ICollection<GridObject>)((MapField<TKey, TValue>)(object)modifiedObjects_).get_Values();
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				if (num == (int)num2)
				{
					goto IL_0096;
				}
				num++;
			}
			if (values == null)
			{
				RepeatedField<uint> repeatedField = removedObjects_;
				uint num3 = gridObject.iD_;
				if (((RepeatedField<T>)(object)repeatedField).Contains((T)num3) || !defaultGrid.IsOnGrid(gridObject))
				{
					goto IL_0096;
				}
			}
			if (_gridCells == null)
			{
			}
			bool flag = default(bool);
			if (flag)
			{
				Meta.Grids.GridCells.RemoveFromGridCells((Dictionary<, >)(object)_gridCells, gridObject);
				if (defaultGrid.IsOnGrid(gridObject))
				{
					GridObject gridObject2 = gridObject.Clone();
					MapField<uint, GridObject> mapField = modifiedObjects_;
				}
				Dictionary<GridPosition, List<GridObject>> gridCells = _gridCells;
				int num4 = 0;
			}
			goto IL_0096;
			IL_0096:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600862F")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "26")]
		public bool CanExpandGridSize(string gridDataPath)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008630")]
		[Cpp2IlInjected.Address(RVA = "0x1734760", Offset = "0x1733160", VA = "0x181734760", Slot = "27")]
		public bool ExpandGridSize(string gridDataPath)
		{
			InvalidOperationException ex = new InvalidOperationException("Unable to expand a DiffGrid");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008631")]
		[Cpp2IlInjected.Address(RVA = "0x1734EA0", Offset = "0x17338A0", VA = "0x181734EA0")]
		public bool HasConflicts(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning, [Optional] Item? clearedBy, GridCellConflict conflictsToCheck = GridCellConflict.All)
		{
			if (_gridCells == null)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008632")]
		[Cpp2IlInjected.Address(RVA = "0x17349F0", Offset = "0x17333F0", VA = "0x1817349F0")]
		public (bool, GridCellConflict) GetConflicts(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning, [Optional] Item? clearedBy, GridCellConflict conflictsToCheck = GridCellConflict.All)
		{
			if (_gridCells == null)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008633")]
		[Cpp2IlInjected.Address(RVA = "0x17347B0", Offset = "0x17331B0", VA = "0x1817347B0")]
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

		[Cpp2IlInjected.Token(Token = "0x6008634")]
		[Cpp2IlInjected.Address(RVA = "0x1734980", Offset = "0x1733380", VA = "0x181734980")]
		public List<GridObject> GetConflictedObjects(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject)
		{
			if (this == null)
			{
			}
			List<GridObject> result = default(List<GridObject>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008635")]
		[Cpp2IlInjected.Address(RVA = "0x1734C40", Offset = "0x1733640", VA = "0x181734C40")]
		public List<GridObject> GetGridObjectsForPosition(in GridPosition gridPosition)
		{
			GridData _003CGridData_003Ek__BackingField = defaultGrid.GridData;
			bool flag = default(bool);
			if (!flag || _gridCells == null)
			{
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008636")]
		[Cpp2IlInjected.Address(RVA = "0x1734E50", Offset = "0x1733850", VA = "0x181734E50")]
		public GridLayers GetLayersForPosition(in GridPosition gridPosition)
		{
			if (this == null)
			{
			}
			GridLayers result = default(GridLayers);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008637")]
		[Cpp2IlInjected.Address(RVA = "0x1736260", Offset = "0x1734C60", VA = "0x181736260")]
		public bool IsAreaInside(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea)
		{
			//Discarded unreachable code: IL_000f
			return defaultGrid.IsAreaInside(in gridPosition, gridOrientation, in gridArea);
		}

		[Cpp2IlInjected.Token(Token = "0x6008638")]
		[Cpp2IlInjected.Address(RVA = "0x1736320", Offset = "0x1734D20", VA = "0x181736320")]
		public bool IsAreaValid(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, bool automaticSpawning)
		{
			if (_gridCells == null)
			{
			}
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008639")]
		[Cpp2IlInjected.Address(RVA = "0x1736290", Offset = "0x1734C90", VA = "0x181736290")]
		public bool IsAreaValidFor(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning)
		{
			if (_gridCells == null)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600863A")]
		[Cpp2IlInjected.Address(RVA = "0x1736500", Offset = "0x1734F00", VA = "0x181736500", Slot = "28")]
		public bool IsParentOf(IGrid subGrid)
		{
			//Discarded unreachable code: IL_0031
			_003Cget_Objects_003Ed__77 _003Cget_Objects_003Ed__ = new _003Cget_Objects_003Ed__77(-2);
			_003Cget_Objects_003Ed__._003C_003E4__this = this;
			Func<GridObject, bool> cpp2il__autoParamName__idx_ = (Func<GridObject, bool>)(object)(Func<T, TResult>)delegate(GridObject x)
			{
				//Discarded unreachable code: IL_0044
				GridState state_ = x.state_;
				if (state_ != null)
				{
					SubGrid subGrid2 = state_.SubGrid;
					if (subGrid2 != null)
					{
						uint gridID_ = subGrid2.gridID_;
						int num = 0;
					}
				}
				int num2 = 0;
				IGrid grid = subGrid;
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					num2++;
				}
				return num2 == num2;
			};
			return ((IEnumerable<>)(object)_003Cget_Objects_003Ed__).Any<GridObject>((Func<, >)(object)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x600863B")]
		[Cpp2IlInjected.Address(RVA = "0x17363B0", Offset = "0x1734DB0", VA = "0x1817363B0", Slot = "29")]
		public bool IsOnGrid(GridObject gridObject)
		{
			//Discarded unreachable code: IL_002d
			ICollection<GridObject> values = (ICollection<GridObject>)((MapField<TKey, TValue>)(object)modifiedObjects_).get_Values();
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				if (num == (int)num2)
				{
					goto IL_0022;
				}
				num++;
			}
			if (values == null)
			{
			}
			goto IL_0022;
			IL_0022:
			bool flag = default(bool);
			if (flag)
			{
				int num3 = 0;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600863C")]
		[Cpp2IlInjected.Address(RVA = "0x1737410", Offset = "0x1735E10", VA = "0x181737410", Slot = "30")]
		public int ObjectCount()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			return this.ObjectCount((Func<, >)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600863D")]
		[Cpp2IlInjected.Address(RVA = "0x17372C0", Offset = "0x1735CC0", VA = "0x1817372C0", Slot = "31")]
		public int ObjectCount(Item item)
		{
			//Discarded unreachable code: IL_0029
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			Func<Item, bool> func = (Func<Item, bool>)(object)(Func<T, TResult>)((Item x) => (byte)(int)typeof(Item).TypeHandle != 0);
			return this.ObjectCount((Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x600863E")]
		[Cpp2IlInjected.Address(RVA = "0x1737380", Offset = "0x1735D80", VA = "0x181737380", Slot = "32")]
		public int ObjectCount(IEnumerable<Item> items)
		{
			Func<Item, bool> func = default(Func<Item, bool>);
			return this.ObjectCount((Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x600863F")]
		[Cpp2IlInjected.Address(RVA = "0x1737420", Offset = "0x1735E20", VA = "0x181737420")]
		private int ObjectCount(Func<Item, bool> predicate)
		{
			//Discarded unreachable code: IL_005d, IL_0063, IL_0069, IL_006f, IL_0075
			int num = 0;
			if (predicate == null)
			{
				int num2 = defaultGrid.ObjectCount();
				int count = ((RepeatedField<T>)(object)removedObjects_).Count;
				num2 -= count;
			}
			MapField<uint, GridObject> mapField = modifiedObjects_;
			bool flag = default(bool);
			if (flag)
			{
				Grid grid = defaultGrid;
				bool flag2 = default(bool);
				while (flag2)
				{
				}
				if (predicate != null)
				{
					bool flag3 = default(bool);
					while (!flag3)
					{
					}
				}
				num++;
			}
			bool flag4 = default(bool);
			if (flag4)
			{
				bool flag5 = default(bool);
				while (flag5)
				{
				}
				bool flag6 = default(bool);
				while (!flag6)
				{
				}
				num++;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6008640")]
		[Cpp2IlInjected.Address(RVA = "0x1737BD0", Offset = "0x17365D0", VA = "0x181737BD0", Slot = "33")]
		public bool TryGetObject(uint gridObjectID, out GridObject gridObject)
		{
			//Discarded unreachable code: IL_002c
			//IL_0017: Expected O, but got I4
			MapField<uint, GridObject> mapField = modifiedObjects_;
			bool flag = default(bool);
			if (!flag)
			{
				if (!((RepeatedField<T>)(object)removedObjects_).Contains((T)gridObjectID))
				{
					return defaultGrid.TryGetObject(gridObjectID, out gridObject);
				}
				int num = 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6008641")]
		[Cpp2IlInjected.Address(RVA = "0x17343C0", Offset = "0x1732DC0", VA = "0x1817343C0")]
		private void Dispatcher_OnGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [Optional] GridAddObjectOptions options)
		{
			//Discarded unreachable code: IL_0063
			//IL_002a: Expected O, but got I4
			if (operation != GridChangedOperation.UpdateState || grid != this)
			{
				return;
			}
			Grid grid2 = defaultGrid;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			MapField<uint, GridObject> mapField = modifiedObjects_;
			uint num = gridObject.iD_;
			if (!((MapField<TKey, TValue>)(object)mapField).ContainsKey((TKey)num))
			{
				GridObject gridObject2 = gridObject.Clone();
				MapField<uint, GridObject> mapField2 = modifiedObjects_;
				uint num2 = gridObject.iD_;
				Dictionary<GridPosition, List<GridObject>> gridCells = _gridCells;
				if (gridCells != null)
				{
					Meta.Grids.GridCells.RemoveFromGridCells((Dictionary<, >)(object)gridCells, gridObject);
					Dictionary<GridPosition, List<GridObject>> gridCells2 = _gridCells;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008642")]
		[Cpp2IlInjected.Address(RVA = "0x17340A0", Offset = "0x1732AA0", VA = "0x1817340A0", Slot = "43")]
		IGrid IGrid.Clone()
		{
			DiffGrid diffGrid = new DiffGrid(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008643")]
		[Cpp2IlInjected.Address(RVA = "0x1738200", Offset = "0x1736C00", VA = "0x181738200")]
		static DiffGrid()
		{
			Func<DiffGrid> func = default(Func<DiffGrid>);
			_parser = (MessageParser<DiffGrid>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<uint> fieldCodec = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			MessageParser<GridObject> parser = GridObject._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<GridObject>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<DiffGrid>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			_parser = (MessageParser<DiffGrid>)(object)FieldCodec.ForUInt32(66u);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008644")]
		[Cpp2IlInjected.Address(RVA = "0x17370A0", Offset = "0x1735AA0", VA = "0x1817370A0", Slot = "24")]
		void IGrid.Create(in WorldProfile worldProfile, ITransactionContext context)
		{
			Create(in worldProfile, context);
		}

		[Cpp2IlInjected.Token(Token = "0x6008645")]
		[Cpp2IlInjected.Address(RVA = "0x1736260", Offset = "0x1734C60", VA = "0x181736260", Slot = "34")]
		bool IGrid.IsAreaInside(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea)
		{
			//Discarded unreachable code: IL_000f
			return defaultGrid.IsAreaInside(in gridPosition, gridOrientation, in gridArea);
		}

		[Cpp2IlInjected.Token(Token = "0x6008646")]
		[Cpp2IlInjected.Address(RVA = "0x17372A0", Offset = "0x1735CA0", VA = "0x1817372A0", Slot = "35")]
		bool IGrid.IsAreaValid(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, bool automaticSpawning)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008647")]
		[Cpp2IlInjected.Address(RVA = "0x1737280", Offset = "0x1735C80", VA = "0x181737280", Slot = "36")]
		bool IGrid.IsAreaValidFor(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008648")]
		[Cpp2IlInjected.Address(RVA = "0x1734E50", Offset = "0x1733850", VA = "0x181734E50", Slot = "37")]
		GridLayers IGrid.GetLayersForPosition(in GridPosition gridPosition)
		{
			if (this == null)
			{
			}
			GridLayers result = default(GridLayers);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008649")]
		[Cpp2IlInjected.Address(RVA = "0x1734C40", Offset = "0x1733640", VA = "0x181734C40", Slot = "38")]
		List<GridObject> IGrid.GetGridObjectsForPosition(in GridPosition gridPosition)
		{
			GridData _003CGridData_003Ek__BackingField = defaultGrid.GridData;
			bool flag = default(bool);
			if (!flag || _gridCells == null)
			{
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600864A")]
		[Cpp2IlInjected.Address(RVA = "0x1734EA0", Offset = "0x17338A0", VA = "0x181734EA0", Slot = "39")]
		bool IGrid.HasConflicts(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning, Item? clearedBy, GridCellConflict conflictsToCheck)
		{
			if (_gridCells == null)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600864B")]
		[Cpp2IlInjected.Address(RVA = "0x17349F0", Offset = "0x17333F0", VA = "0x1817349F0", Slot = "40")]
		(bool, GridCellConflict) IGrid.GetConflicts(in GridPosition gridPosition, GridOrientation gridOrientation, in GridArea gridArea, GridObject gridObject, bool automaticSpawning, Item? clearedBy, GridCellConflict conflictsToCheck)
		{
			if (_gridCells == null)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600864C")]
		[Cpp2IlInjected.Address(RVA = "0x17370B0", Offset = "0x1735AB0", VA = "0x1817370B0", Slot = "41")]
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

		[Cpp2IlInjected.Token(Token = "0x600864D")]
		[Cpp2IlInjected.Address(RVA = "0x1734980", Offset = "0x1733380", VA = "0x181734980", Slot = "42")]
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
