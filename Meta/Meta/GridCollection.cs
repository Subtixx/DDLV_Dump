using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Grids;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class GridCollection : IMessage<GridCollection>, IMessage, IEquatable<GridCollection>, IDeepCloneable<GridCollection>, IMessageFieldAccessor, IGridProvider
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private class UniqueItemGridObjectMonitor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private (uint gridID, uint gridObjectID)? instance;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400002E")]
			public Item Item
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1204440", Offset = "0x1202E40", VA = "0x181204440")]
			public unsafe UniqueItemGridObjectMonitor(Item item, GridCollection gridCollection, ProfileEventDispatcher dispatcher)
			{
				//Discarded unreachable code: IL_0049
				//IL_0014: Expected O, but got I4
				//IL_0043: Expected native int or pointer, but got O
				int itemID = item.ItemID;
				base._002Ector();
				Item = (Item)itemID;
				ProfileEventDispatcher.GridChanged value = OnGridChanged;
				dispatcher.OnGridChanged += value;
				if ((object)Item != null)
				{
					(IGrid, GridObject) tuple = default((IGrid, GridObject));
					IGrid item2 = (IGrid)((ValueTuple<, >*)(&tuple))->Item1;
					int has_value = 0;
					((Nullable<>*)(IntPtr)instance)->has_value = (byte)has_value != 0;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1204220", Offset = "0x1202C20", VA = "0x181204220")]
			public unsafe bool TryGetGridAndObject(GridCollection gridCollection, out (IGrid grid, GridObject gridObject) value)
			{
				//IL_0044: Expected O, but got I4
				//IL_0052: Expected O, but got I4
				bool has_value = ((Nullable<>)instance).has_value;
				int num = 0;
				bool flag = default(bool);
				if (flag)
				{
					bool flag2 = gridCollection.TryGetGrid((uint)num, out *(IGrid*)num);
					if (flag2)
					{
						uint num2 = default(uint);
						if (num < (int)num2)
						{
							num += num;
							num++;
						}
						if (flag2 && (object)Item != null)
						{
							int num3 = 0;
							System.Runtime.CompilerServices.Unsafe.As<(IGrid grid, GridObject gridObject), ValueTuple<, >>(ref value).Item1 = (T1)num3;
						}
					}
				}
				int num4 = 0;
				int num5 = 0;
				System.Runtime.CompilerServices.Unsafe.As<(IGrid grid, GridObject gridObject), ValueTuple<, >>(ref value).Item1 = (T1)num4;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x1204060", Offset = "0x1202A60", VA = "0x181204060")]
			private unsafe void OnGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [Optional] GridAddObjectOptions addObjectOptions)
			{
				//IL_0033: Expected native int or pointer, but got O
				//IL_0068: Expected O, but got I4
				int itemID = gridObject.ItemID;
				Item item = Item;
				if ((object)item == null)
				{
					return;
				}
				if (operation == GridChangedOperation.Add)
				{
					uint iD_ = gridObject.iD_;
					int itemID2 = item.ItemID;
					int has_value = 0;
					((Nullable<>*)(IntPtr)instance)->has_value = (byte)has_value != 0;
					return;
				}
				while (operation != GridChangedOperation.Remove)
				{
				}
				bool has_value2 = ((Nullable<>)instance).has_value;
				bool flag = default(bool);
				while (!flag)
				{
				}
				ulong num = default(ulong);
				while ((ulong)(flag ? 1 : 0) != num)
				{
				}
				while ((ulong)(int)gridObject.iD_ != num)
				{
				}
				int num2 = 0;
				instance = ((uint gridID, uint gridObjectID)?)(object)num2;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly MessageParser<GridCollection> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public const int GridsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly MapField<uint, Grid>.Codec _map_grids_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly MapField<uint, Grid> grids_ = (MapField<uint, Grid>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public const int DiffGridsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly MapField<uint, DiffGrid>.Codec _map_diffGrids_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly MapField<uint, DiffGrid> diffGrids_ = (MapField<uint, DiffGrid>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public const int NextGridIDFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private uint nextGridID_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private ProfileEventDispatcher dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly List<UniqueItemGridObjectMonitor> uniqueItemMonitors = (List<UniqueItemGridObjectMonitor>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		[DebuggerNonUserCode]
		public static MessageParser<GridCollection> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1D0BFB0", Offset = "0x1D0A9B0", VA = "0x181D0BFB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1D0BEE0", Offset = "0x1D0A8E0", VA = "0x181D0BEE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x1D0C010", Offset = "0x1D0AA10", VA = "0x181D0C010", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		[DebuggerNonUserCode]
		public MapField<uint, Grid> Grids
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return grids_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[DebuggerNonUserCode]
		public MapField<uint, DiffGrid> DiffGrids
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return diffGrids_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[DebuggerNonUserCode]
		public uint NextGridID
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return nextGridID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				nextGridID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IEnumerable<IGrid> AllGrids
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x1D0BE40", Offset = "0x1D0A840", VA = "0x181D0BE40")]
			get
			{
				//Discarded unreachable code: IL_0020
				ICollection<Grid> values = (ICollection<Grid>)((MapField<TKey, TValue>)(object)grids_).get_Values();
				ICollection<DiffGrid> values2 = (ICollection<DiffGrid>)((MapField<TKey, TValue>)(object)diffGrids_).get_Values();
				return (IEnumerable<IGrid>)Enumerable.Concat<IGrid>((IEnumerable<>)values, (IEnumerable<>)values2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1D0BB70", Offset = "0x1D0A570", VA = "0x181D0BB70")]
		[DebuggerNonUserCode]
		public GridCollection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1D0BC70", Offset = "0x1D0A670", VA = "0x181D0BC70")]
		[DebuggerNonUserCode]
		public GridCollection(GridCollection other)
		{
			MapField<uint, Grid> mapField = (grids_ = (MapField<uint, Grid>)(object)((MapField<TKey, TValue>)(object)other.grids_).Clone());
			MapField<uint, DiffGrid> mapField2 = (diffGrids_ = (MapField<uint, DiffGrid>)(object)((MapField<TKey, TValue>)(object)other.diffGrids_).Clone());
			uint num = (nextGridID_ = other.nextGridID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1D089E0", Offset = "0x1D073E0", VA = "0x181D089E0", Slot = "10")]
		[DebuggerNonUserCode]
		public GridCollection Clone()
		{
			//Discarded unreachable code: IL_007e
			GridCollection gridCollection = new GridCollection();
			MapField<uint, Grid> mapField = (gridCollection.grids_ = (MapField<uint, Grid>)(object)new MapField<TKey, TValue>());
			MapField<uint, DiffGrid> mapField2 = (gridCollection.diffGrids_ = (MapField<uint, DiffGrid>)(object)new MapField<TKey, TValue>());
			List<UniqueItemGridObjectMonitor> list = (gridCollection.uniqueItemMonitors = (List<UniqueItemGridObjectMonitor>)(object)new List<T>());
			MapField<uint, Grid> mapField3 = (gridCollection.grids_ = (MapField<uint, Grid>)(object)((MapField<TKey, TValue>)(object)grids_).Clone());
			MapField<uint, DiffGrid> mapField4 = (gridCollection.diffGrids_ = (MapField<uint, DiffGrid>)(object)((MapField<TKey, TValue>)(object)diffGrids_).Clone());
			uint num = (gridCollection.nextGridID_ = nextGridID_);
			UnknownFieldSet unknownFieldSet = (gridCollection._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return gridCollection;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1D092B0", Offset = "0x1D07CB0", VA = "0x181D092B0", Slot = "0")]
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
				MapField<uint, Grid> mapField = grids_;
				bool flag = default(bool);
				if (flag)
				{
					MapField<uint, DiffGrid> mapField2 = diffGrids_;
					bool flag2 = default(bool);
					if (flag2 && nextGridID_ == (flag2 ? 1u : 0u))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1D091F0", Offset = "0x1D07BF0", VA = "0x181D091F0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GridCollection other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MapField<uint, Grid> mapField = grids_;
				MapField<uint, Grid> mapField2 = other.grids_;
				if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
				{
					MapField<uint, DiffGrid> mapField3 = diffGrids_;
					MapField<uint, DiffGrid> mapField4 = other.diffGrids_;
					if (((MapField<TKey, TValue>)(object)mapField3).Equals((MapField<, >)(object)mapField4))
					{
						uint num = other.nextGridID_;
						if (nextGridID_ == num)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1D09B50", Offset = "0x1D08550", VA = "0x181D09B50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_003b
			int hashCode = ((MapField<TKey, TValue>)(object)grids_).GetHashCode();
			int hashCode2 = ((MapField<TKey, TValue>)(object)diffGrids_).GetHashCode();
			if (nextGridID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return hashCode2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1D0B4B0", Offset = "0x1D09EB0", VA = "0x181D0B4B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1D0B710", Offset = "0x1D0A110", VA = "0x181D0B710", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_005a
			MapField<uint, Grid> mapField = grids_;
			MapField<uint, Grid>.Codec map_grids_codec = _map_grids_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_grids_codec);
			MapField<uint, DiffGrid> mapField2 = diffGrids_;
			MapField<uint, DiffGrid>.Codec map_diffGrids_codec = _map_diffGrids_codec;
			((MapField<TKey, TValue>)(object)mapField2).WriteTo(output, (MapField<, >.Codec)(object)map_diffGrids_codec);
			if (nextGridID_ != 0)
			{
				uint value = nextGridID_;
				output.WriteUInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1D08830", Offset = "0x1D07230", VA = "0x181D08830", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected O, but got Unknown
			MapField<uint, Grid> mapField = grids_;
			MapField<uint, Grid>.Codec map_grids_codec = _map_grids_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_grids_codec);
			MapField<uint, DiffGrid> mapField2 = diffGrids_;
			MapField<uint, DiffGrid>.Codec map_diffGrids_codec = _map_diffGrids_codec;
			int num2 = ((MapField<TKey, TValue>)(object)mapField2).CalculateSize((MapField<, >.Codec)(object)map_diffGrids_codec);
			uint num3 = nextGridID_;
			if (num3 != 0)
			{
				int num4 = CodedOutputStream.ComputeUInt32Size(num3);
				num4++;
				mapField = (MapField<uint, Grid>)(mapField + num4);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num5 = unknownFields.CalculateSize();
				mapField = (MapField<uint, Grid>)(mapField + num5);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1D0A470", Offset = "0x1D08E70", VA = "0x181D0A470", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GridCollection other)
		{
			//Discarded unreachable code: IL_0064
			if (other != null)
			{
				MapField<uint, Grid> mapField = grids_;
				MapField<uint, Grid> mapField2 = other.grids_;
				((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
				MapField<uint, DiffGrid> mapField3 = diffGrids_;
				MapField<uint, DiffGrid> mapField4 = other.diffGrids_;
				((MapField<TKey, TValue>)(object)mapField3).Add((IDictionary<, >)(object)mapField4);
				uint num = other.nextGridID_;
				if (num != 0)
				{
					nextGridID_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1D0A520", Offset = "0x1D08F20", VA = "0x181D0A520", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0071
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					MapField<uint, Grid> mapField = grids_;
					MapField<uint, Grid>.Codec map_grids_codec = _map_grids_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_grids_codec);
				}
				if (num == 18)
				{
					MapField<uint, DiffGrid> mapField2 = diffGrids_;
					MapField<uint, DiffGrid>.Codec map_diffGrids_codec = _map_diffGrids_codec;
					((MapField<TKey, TValue>)(object)mapField2).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_diffGrids_codec);
				}
				if (num == 24)
				{
					int num2 = (int)(nextGridID_ = (uint)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1D09560", Offset = "0x1D07F60", VA = "0x181D09560", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0025;
					}
					uint num2 = nextGridID_;
				}
				MapField<uint, DiffGrid> mapField = diffGrids_;
			}
			MapField<uint, Grid> mapField2 = grids_;
			goto IL_0025;
			IL_0025:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1D0B390", Offset = "0x1D09D90", VA = "0x181D0B390", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0017: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj = default(object);
					nextGridID_ = (uint)(int)obj;
					return;
				}
				default:
					return;
				case 0:
					break;
				}
			}
			else
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			InvalidOperationException ex2 = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1D08960", Offset = "0x1D07360", VA = "0x181D08960", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0019: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					nextGridID_ = 0u;
					return;
				default:
					return;
				case 0:
					break;
				}
			}
			MapField<uint, Grid> mapField = grids_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1D09C00", Offset = "0x1D08600", VA = "0x181D09C00")]
		internal unsafe void Initialize(IGridDataUpdateInvalidItemHandler gridDataUpdateInvalidItemCollector, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0066, IL_006c, IL_0072
			//IL_0036: Expected O, but got I4
			int num;
			ICollection<Grid> values;
			uint num2 = default(uint);
			int num3;
			do
			{
				num = 0;
				values = (ICollection<Grid>)((MapField<TKey, TValue>)(object)grids_).get_Values();
				if (values != null)
				{
					if (num < (int)num2)
					{
						num += num;
						if (num != (int)num2)
						{
							num++;
						}
					}
					num += 312;
				}
				num3 = 0;
			}
			while (values == null);
			int length = ((IEnumerable<>)0).ToArray<KeyValuePair<uint, DiffGrid>>().Length;
			if (num3 < length)
			{
				num3 += 2;
				num3 += num3;
				bool flag = default(bool);
				if (!flag)
				{
					num3++;
				}
				num3++;
			}
			if (num3 != 0)
			{
				int num4 = 0;
			}
			((int*)num)->m_value = num3;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1D08090", Offset = "0x1D06A90", VA = "0x181D08090", Slot = "14")]
		public uint AddGrid(string gridDataPath)
		{
			//Discarded unreachable code: IL_0053
			//IL_0042: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			uint num = nextGridID_;
			uint num2 = (nextGridID_ = num + 1);
			Grid grid = new Grid();
			grid.iD_ = num;
			string text = (grid.gridDataPath_ = ProtoPreconditions.CheckNotNull(gridDataPath, "value"));
			int num3 = 0;
			int validate = 0;
			bool flag = grid.Init((byte)validate != 0, (GridData)num3);
			((MapField<TKey, TValue>)(object)grids_).Add((TKey)num, (TValue)grid);
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1D081B0", Offset = "0x1D06BB0", VA = "0x181D081B0")]
		public uint AddGrid(string gridDataPath, out Grid newGrid)
		{
			//Discarded unreachable code: IL_0042
			uint num = nextGridID_;
			uint num2 = (nextGridID_ = num + 1);
			Grid grid = new Grid();
			grid.iD_ = num;
			string text = (grid.gridDataPath_ = ProtoPreconditions.CheckNotNull(gridDataPath, "value"));
			int num3 = 0;
			int num4 = 0;
			MapField<uint, Grid> mapField = grids_;
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1D07F90", Offset = "0x1D06990", VA = "0x181D07F90")]
		public uint AddDiffGrid(string gridDefaultLayoutPath, string gridDefaultLayoutType, uint defaultLayoutGridID)
		{
			//Discarded unreachable code: IL_0049
			//IL_0047: Expected O, but got I4
			uint num = nextGridID_;
			uint num2 = (nextGridID_ = num + 1);
			DiffGrid diffGrid = new DiffGrid();
			diffGrid.iD_ = num;
			diffGrid.GridDefaultLayoutPath = gridDefaultLayoutPath;
			diffGrid.GridDefaultLayoutType = gridDefaultLayoutType;
			diffGrid.defaultLayoutGridID_ = defaultLayoutGridID;
			diffGrid.Init();
			((MapField<TKey, TValue>)(object)diffGrids_).Add((TKey)num, (TValue)diffGrid);
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1D07E90", Offset = "0x1D06890", VA = "0x181D07E90")]
		public uint AddDiffGrid(string gridDefaultLayoutPath, string gridDefaultLayoutType, uint defaultLayoutGridID, out DiffGrid newDiffGrid)
		{
			//Discarded unreachable code: IL_0045
			//IL_0043: Expected O, but got I4
			//IL_0043: Expected O, but got I4
			uint num = nextGridID_;
			uint num2 = (nextGridID_ = num + 1);
			DiffGrid diffGrid = new DiffGrid();
			diffGrid.iD_ = num;
			diffGrid.GridDefaultLayoutPath = gridDefaultLayoutPath;
			int num3 = 0;
			diffGrid.GridDefaultLayoutType = gridDefaultLayoutType;
			diffGrid.defaultLayoutGridID_ = defaultLayoutGridID;
			((MapField<TKey, TValue>)(object)diffGrids_).Add((TKey)num, (TValue)num3);
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1D0AD20", Offset = "0x1D09720", VA = "0x181D0AD20")]
		public uint MergeGridCollection(GridCollection other, uint mainGridID = 0u, [Optional] List<IGrid> newGridsToFill, [Optional] Action<uint, uint> reattributeGridIDCallback)
		{
			//Discarded unreachable code: IL_007c, IL_0082, IL_0088, IL_008e, IL_0094, IL_009a, IL_00a6, IL_00ac, IL_00b2, IL_00b8, IL_00be, IL_00c4
			//IL_0042: Expected O, but got I4
			bool flag = default(bool);
			Grid grid = default(Grid);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				Dictionary<uint, SubGrid> dictionary = (Dictionary<uint, SubGrid>)(object)new Dictionary<TKey, TValue>();
				MapField<uint, Grid> mapField = other.grids_;
				if (flag)
				{
					uint num2 = nextGridID_;
					uint num3 = (nextGridID_ = num2 + 1);
					grid.iD_ = num2;
					((MapField<TKey, TValue>)(object)grids_).Add((TKey)num2, (TValue)grid);
					ICollection<GridObject> values = (ICollection<GridObject>)((MapField<TKey, TValue>)(object)grid.objects_).get_Values();
					if (values != null)
					{
						if (false)
						{
							SubGrid subGrid;
							while (subGrid == null)
							{
							}
							throw new NullReferenceException();
						}
						continue;
					}
					if (values != null)
					{
					}
					if (num != 0)
					{
						break;
					}
					if (!flag2)
					{
					}
				}
				if (num == 0)
				{
					throw new NullReferenceException();
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1D08BE0", Offset = "0x1D075E0", VA = "0x181D08BE0")]
		public unsafe uint EditorMergeGridCollection(GridCollection other, HashSet<uint> gridIDsToKeepStable, uint mainGridID, [Optional] List<IGrid> newGridsToFill, [Optional] Action<uint, uint> reattributeGridIDCallback)
		{
			//Discarded unreachable code: IL_00f0, IL_00f6, IL_00fc, IL_0102, IL_0108, IL_010e, IL_0114, IL_011a, IL_0120, IL_0126, IL_012c, IL_0132, IL_0138, IL_013e, IL_0144, IL_014a, IL_0150
			//IL_002a: Expected I4, but got O
			//IL_0033: Expected O, but got I4
			//IL_003c: Expected O, but got I4
			//IL_004e: Expected I4, but got O
			//IL_00cc: Expected O, but got I4
			bool flag = default(bool);
			MapField<, > mapField2 = default(MapField<, >);
			UnknownFieldSet unknownFields = default(UnknownFieldSet);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				Dictionary<uint, SubGrid> dictionary = (Dictionary<uint, SubGrid>)(object)new Dictionary<TKey, TValue>();
				MapField<uint, Grid> mapField = other.grids_;
				if (!flag)
				{
					break;
				}
				Grid grid = new Grid();
				int num2 = 0;
				grid.iD_ = (uint)(int)grid;
				grid.gridDataPath_ = (string)num2;
				grid.gridDefaultLayoutPath_ = (string)num2;
				grid.objects_ = (MapField<uint, GridObject>)(object)mapField2;
				grid.nextGridObjectID_ = (uint)(int)mapField2;
				grid._unknownFields = unknownFields;
				uint num3 = nextGridID_;
				if (!flag2)
				{
					uint num4 = (nextGridID_ = num3 + 1);
					grid.iD_ = num3;
				}
				uint val = grid.iD_ + 1;
				uint num5 = Math.Max(num3, val);
				uint iD_ = grid.iD_;
				ICollection<GridObject> values = (ICollection<GridObject>)((MapField<TKey, TValue>)(object)grid.objects_).get_Values();
				if (values != null)
				{
					if (false)
					{
						SubGrid subGrid;
						while (subGrid == null)
						{
						}
						throw new NullReferenceException();
					}
					continue;
				}
				if (values != null)
				{
				}
				if (((Dictionary<TKey, TValue>)(object)dictionary).TryGetValue((TKey)num, out *(TValue*)num))
				{
					uint iD_2 = grid.iD_;
				}
				uint iD_3 = grid.iD_;
				uint iD_4 = grid.iD_;
				break;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1D0ABE0", Offset = "0x1D095E0", VA = "0x181D0ABE0")]
		public uint MergeGridCollectionWithDiffGrids(string gridCollectionPath, IDefaultGridCollectionContainer defaultGridCollectionContainer, uint mainGridID = 0u, [Optional] List<IGrid> newGridsToFill, [Optional] Action<uint, uint> reattributeGridIDCallback)
		{
			//Discarded unreachable code: IL_0018
			Type type = default(Type);
			string assemblyQualifiedName = type.AssemblyQualifiedName;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			uint result = default(uint);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1D0A690", Offset = "0x1D09090", VA = "0x181D0A690")]
		public uint MergeGridCollectionWithDiffGrids(string gridCollectionPath, string gridCollectionType, GridCollection other, uint mainGridID = 0u, [Optional] List<IGrid> newGridsToFill, [Optional] Action<uint, uint> reattributeGridIDCallback)
		{
			//Discarded unreachable code: IL_00f9, IL_00ff, IL_0105, IL_010b, IL_0111, IL_0117, IL_011d, IL_0123, IL_012f, IL_0135, IL_013b, IL_0141, IL_0147
			//IL_0085: Expected O, but got I4
			//IL_00bc: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				Dictionary<uint, SubGrid> dictionary = (Dictionary<uint, SubGrid>)(object)new Dictionary<TKey, TValue>();
				MapField<uint, Grid> mapField = other.grids_;
				if (flag)
				{
					uint num2 = nextGridID_;
					uint num3 = (nextGridID_ = num2 + 1);
					DiffGrid diffGrid = new DiffGrid();
					diffGrid.iD_ = num2;
					int length = 0;
					int num4 = gridCollectionType.IndexOf("Version=");
					int startIndex = 0;
					string text2 = (diffGrid.GridDefaultLayoutType = gridCollectionType.Substring(startIndex, length));
					ProfileEventDispatcher profileEventDispatcher = dispatcher;
					diffGrid.SetDispatcher(profileEventDispatcher);
					((MapField<TKey, TValue>)(object)diffGrids_).Add((TKey)num2, (TValue)diffGrid);
					IEnumerable<GridObject> objects = (IEnumerable<GridObject>)diffGrid.get_Objects();
					if (objects != null)
					{
						if (false)
						{
							SubGrid subGrid;
							while (subGrid == null)
							{
							}
							MapField<uint, GridObject> modifiedObjects_ = diffGrid.modifiedObjects_;
							GridObject gridObject;
							uint iD_ = gridObject.iD_;
							((MapField<TKey, TValue>)(object)modifiedObjects_).Add((TKey)iD_, (TValue)gridObject);
							SubGrid subGrid2 = gridObject.state_.SubGrid;
							SubGrid subGrid3 = gridObject.state_.SubGrid;
							throw new NullReferenceException();
						}
						continue;
					}
					if (objects != null)
					{
					}
					if (num != 0)
					{
						break;
					}
					if (!flag2)
					{
					}
				}
				if (num == 0)
				{
					throw new NullReferenceException();
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1D0B250", Offset = "0x1D09C50", VA = "0x181D0B250", Slot = "15")]
		public unsafe void RemoveGrid(uint gridID)
		{
			//IL_0021: Expected O, but got I4
			int num = 0;
			if (TryGetGrid(gridID, out *(IGridInternal*)num))
			{
				if (num == 0 || num == 0)
				{
					throw new NullReferenceException();
				}
				bool flag = ((MapField<TKey, TValue>)(object)grids_).Remove((TKey)gridID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1D09F50", Offset = "0x1D08950", VA = "0x181D09F50")]
		public unsafe bool IsSubGridOf(uint potentialSubGridID, uint parentGridID)
		{
			//Discarded unreachable code: IL_007c, IL_0082
			//IL_0011: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			bool flag = default(bool);
			SubGrid subGrid = default(SubGrid);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if (((MapField<TKey, TValue>)(object)grids_).TryGetValue((TKey)potentialSubGridID, out *(TValue*)num2) || ((MapField<TKey, TValue>)(object)diffGrids_).TryGetValue((TKey)potentialSubGridID, out *(TValue*)num2))
				{
				}
				if (!((MapField<TKey, TValue>)(object)grids_).TryGetValue((TKey)parentGridID, out *(TValue*)num2))
				{
					flag = ((MapField<TKey, TValue>)(object)diffGrids_).TryGetValue((TKey)parentGridID, out *(TValue*)num2);
					if (!flag)
					{
					}
				}
				if (num2 == 0)
				{
					break;
				}
				if (flag)
				{
					if (0 == 0)
					{
						continue;
					}
					if (subGrid != null)
					{
						uint gridID_ = subGrid.gridID_;
					}
					while (num2 == (int)potentialSubGridID)
					{
					}
					num2++;
				}
				num2++;
				if (flag)
				{
				}
				if (num2 == 0)
				{
					if (num2 == 0)
					{
					}
					break;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1D0A2D0", Offset = "0x1D08CD0", VA = "0x181D0A2D0")]
		public bool IsSubGridOf(uint potentialSubGridID, IEnumerable<uint> parentGridIDs)
		{
			//Discarded unreachable code: IL_0022
			int num = 0;
			int num2 = 0;
			if ((object)typeof(IEnumerator).TypeHandle != null)
			{
				bool flag = default(bool);
				while (!flag)
				{
				}
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1D08440", Offset = "0x1D06E40", VA = "0x181D08440")]
		public VillageObjectLimit CalculateLimits(IEnumerable<uint> villageGridIDs, RepeatedField<ItemTypeSelector> exclusions)
		{
			//Discarded unreachable code: IL_0027, IL_002d
			int num = 0;
			VillageObjectLimit villageObjectLimit = new VillageObjectLimit((RepeatedField<>)(object)exclusions);
			if (villageObjectLimit != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num != (int)num2)
					{
						num++;
					}
				}
				villageObjectLimit = (VillageObjectLimit)(object)((object)villageObjectLimit + (object)villageObjectLimit);
			}
			if (villageObjectLimit != null)
			{
			}
			return villageObjectLimit;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1D085F0", Offset = "0x1D06FF0", VA = "0x181D085F0")]
		private unsafe void CalculateLimits(uint gridID, ref VillageObjectLimit villageObjectLimit)
		{
			//Discarded unreachable code: IL_0045, IL_004b, IL_0051, IL_0057, IL_005d
			int num = 0;
			bool flag = TryGetGrid(gridID, out *(IGridInternal*)num);
			if (!flag)
			{
				return;
			}
			uint gridID_ = default(uint);
			if (flag)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0039;
					}
					num++;
				}
				SubGrid subGrid = default(SubGrid);
				while (subGrid == null)
				{
				}
				SubGrid subGrid2 = default(SubGrid);
				gridID_ = subGrid2.gridID_;
				CalculateLimits(gridID_, ref villageObjectLimit);
				goto IL_0039;
			}
			goto IL_0040;
			IL_0040:
			if (!flag)
			{
			}
			return;
			IL_0039:
			gridID_ += gridID_;
			goto IL_0040;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1D0B640", Offset = "0x1D0A040", VA = "0x181D0B640")]
		public unsafe bool TryGetGrid(uint gridID, out IGrid grid)
		{
			//Discarded unreachable code: IL_0026
			//IL_000f: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			int num = 0;
			bool flag = ((MapField<TKey, TValue>)(object)grids_).TryGetValue((TKey)gridID, out *(TValue*)num);
			if (flag || ((MapField<TKey, TValue>)(object)diffGrids_).TryGetValue((TKey)gridID, out *(TValue*)num))
			{
			}
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1D0B510", Offset = "0x1D09F10", VA = "0x181D0B510")]
		internal unsafe bool TryGetGrid(uint gridID, out IGridInternal gridInternal)
		{
			//Discarded unreachable code: IL_0026
			//IL_000f: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			int num = 0;
			bool flag = ((MapField<TKey, TValue>)(object)grids_).TryGetValue((TKey)gridID, out *(TValue*)num);
			if (flag || ((MapField<TKey, TValue>)(object)diffGrids_).TryGetValue((TKey)gridID, out *(TValue*)num))
			{
			}
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1D099C0", Offset = "0x1D083C0", VA = "0x181D099C0")]
		public unsafe GridObject GetGridObject(uint gridID, uint gridObjectID)
		{
			//IL_000f: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			int num = 0;
			if (((MapField<TKey, TValue>)(object)grids_).TryGetValue((TKey)gridID, out *(TValue*)num) || ((MapField<TKey, TValue>)(object)diffGrids_).TryGetValue((TKey)gridID, out *(TValue*)num))
			{
			}
			if (num != 0)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (num != 0)
				{
					num += num;
					num += 552;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1D09640", Offset = "0x1D08040", VA = "0x181D09640")]
		public (IGrid, GridObject) GetGridObjectFor(Item item)
		{
			//Discarded unreachable code: IL_0048
			//IL_0032: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			bool flag = default(bool);
			if (flag)
			{
				while (!flag)
				{
				}
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			_003CGetAllGridObjectsFor_003Ed__60 _003CGetAllGridObjectsFor_003Ed__ = new _003CGetAllGridObjectsFor_003Ed__60(-2);
			_003CGetAllGridObjectsFor_003Ed__._003C_003E4__this = (GridCollection)0;
			_003CGetAllGridObjectsFor_003Ed__._003C_003E3__item = (Item)0;
			(IGrid, GridObject) tuple = Enumerable.FirstOrDefault<(IGrid, GridObject)>((IEnumerable<>)num3);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1D094E0", Offset = "0x1D07EE0", VA = "0x181D094E0")]
		[IteratorStateMachine(typeof(_003CGetAllGridObjectsFor_003Ed__60))]
		public IEnumerable<(IGrid, GridObject)> GetAllGridObjectsFor(Item item)
		{
			//IL_001d: Expected O, but got I4
			int itemID = item.ItemID;
			_003CGetAllGridObjectsFor_003Ed__60 _003CGetAllGridObjectsFor_003Ed__ = new _003CGetAllGridObjectsFor_003Ed__60(-2);
			_003CGetAllGridObjectsFor_003Ed__._003C_003E4__this = this;
			_003CGetAllGridObjectsFor_003Ed__._003C_003E3__item = (Item)itemID;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1D098E0", Offset = "0x1D082E0", VA = "0x181D098E0")]
		public (IGrid, GridObject) GetGridObjectFor(Func<GridObject, bool> predicate)
		{
			new _003CGetAllGridObjectsFor_003Ed__62(-2)._003C_003E4__this = (GridCollection)(object)predicate;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1D09450", Offset = "0x1D07E50", VA = "0x181D09450")]
		[IteratorStateMachine(typeof(_003CGetAllGridObjectsFor_003Ed__62))]
		public IEnumerable<(IGrid, GridObject)> GetAllGridObjectsFor(Func<GridObject, bool> predicate)
		{
			_003CGetAllGridObjectsFor_003Ed__62 _003CGetAllGridObjectsFor_003Ed__ = new _003CGetAllGridObjectsFor_003Ed__62(-2);
			_003CGetAllGridObjectsFor_003Ed__._003C_003E4__this = this;
			_003CGetAllGridObjectsFor_003Ed__._003C_003E3__predicate = predicate;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1D093C0", Offset = "0x1D07DC0", VA = "0x181D093C0")]
		[IteratorStateMachine(typeof(_003CGetAllGridObjectsFor_003Ed__63))]
		public IEnumerable<(IGrid, GridObject)> GetAllGridObjectsFor(Func<IGrid, GridObject, bool> predicate)
		{
			_003CGetAllGridObjectsFor_003Ed__63 _003CGetAllGridObjectsFor_003Ed__ = new _003CGetAllGridObjectsFor_003Ed__63(-2);
			_003CGetAllGridObjectsFor_003Ed__._003C_003E4__this = this;
			_003CGetAllGridObjectsFor_003Ed__._003C_003E3__predicate = predicate;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1D082E0", Offset = "0x1D06CE0", VA = "0x181D082E0")]
		public void AddUniqueItemMonitor(Item item)
		{
			//Discarded unreachable code: IL_0048
			//IL_0014: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			List<UniqueItemGridObjectMonitor> list = uniqueItemMonitors;
			Predicate<UniqueItemGridObjectMonitor> predicate = (Predicate<UniqueItemGridObjectMonitor>)(object)(Predicate<T>)delegate(UniqueItemGridObjectMonitor x)
			{
				Item _003CItem_003Ek__BackingField = x.Item;
				throw new NullReferenceException();
			};
			if (((List<T>)(object)list).Find((Predicate<>)(object)predicate) == null)
			{
				Item item3 = item2;
				UniqueItemGridObjectMonitor item4 = default(UniqueItemGridObjectMonitor);
				((List<T>)(object)uniqueItemMonitors).Add((T)item4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1D0B1B0", Offset = "0x1D09BB0", VA = "0x181D0B1B0")]
		public static void PrettyOrder(GridCollection gridCollection)
		{
			//Discarded unreachable code: IL_0017
			Order<Grid>((MapField<, >)(object)gridCollection.grids_);
			Order<DiffGrid>((MapField<, >)(object)gridCollection.diffGrids_);
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1BB83A0", Offset = "0x1BB6DA0", VA = "0x181BB83A0")]
			static void Order<T>(MapField<, > cpp2il__autoParamName__idx_0)
			{
				//Discarded unreachable code: IL_0013
				int num = 0;
				_003C_003Ec _003C_003Ec = default(_003C_003Ec);
				if ((long)num < (long)(IntPtr)_003C_003Ec)
				{
					num += 2;
					num += num;
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1D0B830", Offset = "0x1D0A230", VA = "0x181D0B830")]
		static GridCollection()
		{
			Func<GridCollection> func = default(Func<GridCollection>);
			_parser = (MessageParser<GridCollection>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<uint> fieldCodec = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			MessageParser<Grid> parser = Grid._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<Grid>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<GridCollection>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			FieldCodec<uint> fieldCodec3 = (FieldCodec<uint>)(object)FieldCodec.ForUInt32(8u);
			MessageParser<DiffGrid> parser2 = DiffGrid._parser;
			uint num3 = default(uint);
			FieldCodec<> fieldCodec4 = FieldCodec.ForMessage<DiffGrid>(num3, (MessageParser<>)(object)parser2);
			uint num4 = default(uint);
			_parser = (MessageParser<GridCollection>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec3, fieldCodec4, num4);
			/*Error: Unexpected end of block*/;
		}
	}
}
