using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Grid;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Meta.Grids;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20007ED")]
	public sealed class Village : IMessage<Village>, IMessage, IEquatable<Village>, IDeepCloneable<Village>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20007EE")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20007EF")]
			public sealed class VillageArea : IMessage<VillageArea>, IMessage, IEquatable<VillageArea>, IDeepCloneable<VillageArea>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001FAB")]
				private static readonly MessageParser<VillageArea> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001FAC")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001FAD")]
				public const int GridIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001FAE")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x4001FAF")]
				public const int UnlockedFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4001FB0")]
				private bool unlocked_;

				[Cpp2IlInjected.Token(Token = "0x4001FB1")]
				public const int BodiesOfWaterFieldNumber = 3;

				[Cpp2IlInjected.Token(Token = "0x4001FB2")]
				private static readonly FieldCodec<BodyOfWater> _repeated_bodiesOfWater_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001FB3")]
				private readonly RepeatedField<BodyOfWater> bodiesOfWater_;

				[Cpp2IlInjected.Token(Token = "0x4001FB4")]
				public const int MiningRocksFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4001FB5")]
				private static readonly FieldCodec<MiningRock> _repeated_miningRocks_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4001FB6")]
				private readonly RepeatedField<MiningRock> miningRocks_;

				[Cpp2IlInjected.Token(Token = "0x17000AB7")]
				[DebuggerNonUserCode]
				public static MessageParser<VillageArea> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600420F")]
					[Cpp2IlInjected.Address(RVA = "0xAE1D40", Offset = "0xAE0740", VA = "0x180AE1D40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AB8")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004210")]
					[Cpp2IlInjected.Address(RVA = "0xAE1CC0", Offset = "0xAE06C0", VA = "0x180AE1CC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000AB9")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6004211")]
					[Cpp2IlInjected.Address(RVA = "0xAE1DA0", Offset = "0xAE07A0", VA = "0x180AE1DA0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000ABA")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6004215")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6004216")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000ABB")]
				[DebuggerNonUserCode]
				public bool Unlocked
				{
					[Cpp2IlInjected.Token(Token = "0x6004217")]
					[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6004218")]
					[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000ABC")]
				[DebuggerNonUserCode]
				public RepeatedField<BodyOfWater> BodiesOfWater
				{
					[Cpp2IlInjected.Token(Token = "0x6004219")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000ABD")]
				[DebuggerNonUserCode]
				public RepeatedField<MiningRock> MiningRocks
				{
					[Cpp2IlInjected.Token(Token = "0x600421A")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6004212")]
				[Cpp2IlInjected.Address(RVA = "0xAE1A70", Offset = "0xAE0470", VA = "0x180AE1A70")]
				[DebuggerNonUserCode]
				public VillageArea()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004213")]
				[Cpp2IlInjected.Address(RVA = "0xAE1B30", Offset = "0xAE0530", VA = "0x180AE1B30")]
				[DebuggerNonUserCode]
				public VillageArea(VillageArea other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004214")]
				[Cpp2IlInjected.Address(RVA = "0xAE0660", Offset = "0xADF060", VA = "0x180AE0660", Slot = "10")]
				[DebuggerNonUserCode]
				public VillageArea Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600421B")]
				[Cpp2IlInjected.Address(RVA = "0xAE08F0", Offset = "0xADF2F0", VA = "0x180AE08F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600421C")]
				[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADF220", VA = "0x180AE0820", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(VillageArea other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600421D")]
				[Cpp2IlInjected.Address(RVA = "0xAE0B10", Offset = "0xADF510", VA = "0x180AE0B10", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600421E")]
				[Cpp2IlInjected.Address(RVA = "0xAE10D0", Offset = "0xADFAD0", VA = "0x180AE10D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600421F")]
				[Cpp2IlInjected.Address(RVA = "0xAE1690", Offset = "0xAE0090", VA = "0x180AE1690", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004220")]
				[Cpp2IlInjected.Address(RVA = "0xAE0490", Offset = "0xADEE90", VA = "0x180AE0490", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004221")]
				[Cpp2IlInjected.Address(RVA = "0xAE0E90", Offset = "0xADF890", VA = "0x180AE0E90", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(VillageArea other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004222")]
				[Cpp2IlInjected.Address(RVA = "0xAE0CF0", Offset = "0xADF6F0", VA = "0x180AE0CF0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004223")]
				[Cpp2IlInjected.Address(RVA = "0xAE0A00", Offset = "0xADF400", VA = "0x180AE0A00", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004224")]
				[Cpp2IlInjected.Address(RVA = "0xAE0F50", Offset = "0xADF950", VA = "0x180AE0F50", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004225")]
				[Cpp2IlInjected.Address(RVA = "0xAE05C0", Offset = "0xADEFC0", VA = "0x180AE05C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004226")]
				[Cpp2IlInjected.Address(RVA = "0xAE0BE0", Offset = "0xADF5E0", VA = "0x180AE0BE0")]
				public void Initialize(in World world, ITransactionContext context)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004227")]
				[Cpp2IlInjected.Address(RVA = "0xAE1130", Offset = "0xADFB30", VA = "0x180AE1130")]
				internal void UnlockArea(VillageAreaType areaType, in World world, ITransactionContext context, [Optional] IEnumerable<CurrencyCost> costs)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001F9C")]
		private static readonly MessageParser<Village> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F9D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F9E")]
		public const int AreasFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4001F9F")]
		private static readonly MapField<int, Types.VillageArea>.Codec _map_areas_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001FA0")]
		private readonly MapField<int, Types.VillageArea> areas_ = (MapField<int, Types.VillageArea>)(object)new MapField<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x4001FA1")]
		public const int SceneItemIdFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001FA2")]
		private int sceneItemId_;

		[Cpp2IlInjected.Token(Token = "0x4001FA3")]
		public const int VillageAreaDataNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001FA4")]
		private string villageAreaDataName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001FA5")]
		public const int VillageObjectLimitNameFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001FA6")]
		private string villageObjectLimitName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001FA7")]
		public const int BoughtObjectLimitFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001FA8")]
		private VillageObjectLimitData boughtObjectLimit_;

		[Cpp2IlInjected.Token(Token = "0x4001FA9")]
		public const int CustomLocationPositionsPathFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001FAA")]
		private string customLocationPositionsPath_ = "";

		[Cpp2IlInjected.Token(Token = "0x17000AAE")]
		[DebuggerNonUserCode]
		public static MessageParser<Village> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60041E8")]
			[Cpp2IlInjected.Address(RVA = "0x15E3AB0", Offset = "0x15E24B0", VA = "0x1815E3AB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AAF")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60041E9")]
			[Cpp2IlInjected.Address(RVA = "0x15E39E0", Offset = "0x15E23E0", VA = "0x1815E39E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60041EA")]
			[Cpp2IlInjected.Address(RVA = "0x15E3B10", Offset = "0x15E2510", VA = "0x1815E3B10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB1")]
		[DebuggerNonUserCode]
		public MapField<int, Types.VillageArea> Areas
		{
			[Cpp2IlInjected.Token(Token = "0x60041EF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return areas_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB2")]
		[DebuggerNonUserCode]
		public int SceneItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60041F0")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return sceneItemId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60041F1")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				sceneItemId_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB3")]
		[DebuggerNonUserCode]
		public string VillageAreaDataName
		{
			[Cpp2IlInjected.Token(Token = "0x60041F2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return villageAreaDataName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60041F3")]
			[Cpp2IlInjected.Address(RVA = "0x15E3C90", Offset = "0x15E2690", VA = "0x1815E3C90")]
			set
			{
				string text = (villageAreaDataName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB4")]
		[DebuggerNonUserCode]
		public string VillageObjectLimitName
		{
			[Cpp2IlInjected.Token(Token = "0x60041F4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return villageObjectLimitName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60041F5")]
			[Cpp2IlInjected.Address(RVA = "0x15E3D00", Offset = "0x15E2700", VA = "0x1815E3D00")]
			set
			{
				string text = (villageObjectLimitName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB5")]
		[DebuggerNonUserCode]
		public VillageObjectLimitData BoughtObjectLimit
		{
			[Cpp2IlInjected.Token(Token = "0x60041F6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return boughtObjectLimit_;
			}
			[Cpp2IlInjected.Token(Token = "0x60041F7")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				boughtObjectLimit_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000AB6")]
		[DebuggerNonUserCode]
		public string CustomLocationPositionsPath
		{
			[Cpp2IlInjected.Token(Token = "0x60041F8")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return customLocationPositionsPath_;
			}
			[Cpp2IlInjected.Token(Token = "0x60041F9")]
			[Cpp2IlInjected.Address(RVA = "0x15E3C20", Offset = "0x15E2620", VA = "0x1815E3C20")]
			set
			{
				string text = (customLocationPositionsPath_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60041EB")]
		[Cpp2IlInjected.Address(RVA = "0x15E38E0", Offset = "0x15E22E0", VA = "0x1815E38E0")]
		[DebuggerNonUserCode]
		public Village()
		{
			VillageObjectLimitData villageObjectLimitData = (boughtObjectLimit_ = new VillageObjectLimitData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60041EC")]
		[Cpp2IlInjected.Address(RVA = "0x15E2C60", Offset = "0x15E1660", VA = "0x1815E2C60")]
		private void OnConstruction()
		{
			VillageObjectLimitData villageObjectLimitData = (boughtObjectLimit_ = new VillageObjectLimitData());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60041ED")]
		[Cpp2IlInjected.Address(RVA = "0x15E36E0", Offset = "0x15E20E0", VA = "0x1815E36E0")]
		[DebuggerNonUserCode]
		public Village(Village other)
		{
			//IL_00a3: Expected O, but got I4
			VillageObjectLimitData villageObjectLimitData = (boughtObjectLimit_ = new VillageObjectLimitData());
			MapField<int, Types.VillageArea> mapField = (areas_ = (MapField<int, Types.VillageArea>)(object)((MapField<TKey, TValue>)(object)other.areas_).Clone());
			int num = (sceneItemId_ = other.sceneItemId_);
			string text = (villageAreaDataName_ = other.villageAreaDataName_);
			string text2 = (villageObjectLimitName_ = other.villageObjectLimitName_);
			VillageObjectLimitData villageObjectLimitData2 = other.boughtObjectLimit_;
			if (villageObjectLimitData2 != null)
			{
				VillageObjectLimitData villageObjectLimitData3 = villageObjectLimitData2.Clone();
			}
			int num2 = 0;
			boughtObjectLimit_ = (VillageObjectLimitData)num2;
			string text3 = (customLocationPositionsPath_ = other.customLocationPositionsPath_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60041EE")]
		[Cpp2IlInjected.Address(RVA = "0x15E1F30", Offset = "0x15E0930", VA = "0x1815E1F30", Slot = "10")]
		[DebuggerNonUserCode]
		public Village Clone()
		{
			return new Village(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60041FA")]
		[Cpp2IlInjected.Address(RVA = "0x15E2090", Offset = "0x15E0A90", VA = "0x1815E2090", Slot = "0")]
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
				MapField<int, Types.VillageArea> mapField = areas_;
				bool flag = default(bool);
				if (flag && sceneItemId_ == (flag ? 1 : 0))
				{
					string text = villageAreaDataName_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text2 = villageObjectLimitName_;
						bool flag3 = default(bool);
						if (!flag3 && object.Equals(boughtObjectLimit_, other))
						{
							string text3 = customLocationPositionsPath_;
							bool flag4 = default(bool);
							if (!flag4)
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

		[Cpp2IlInjected.Token(Token = "0x60041FB")]
		[Cpp2IlInjected.Address(RVA = "0x15E1F90", Offset = "0x15E0990", VA = "0x1815E1F90", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Village other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				MapField<int, Types.VillageArea> mapField = areas_;
				MapField<int, Types.VillageArea> mapField2 = other.areas_;
				if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
				{
					int num = other.sceneItemId_;
					if (sceneItemId_ == num)
					{
						string text = other.villageAreaDataName_;
						if (!(villageAreaDataName_ != text))
						{
							string text2 = other.villageObjectLimitName_;
							if (!(villageObjectLimitName_ != text2))
							{
								VillageObjectLimitData objB = other.boughtObjectLimit_;
								if (object.Equals(boughtObjectLimit_, objB))
								{
									string text3 = other.customLocationPositionsPath_;
									if (!(customLocationPositionsPath_ != text3))
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
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60041FC")]
		[Cpp2IlInjected.Address(RVA = "0x15E2420", Offset = "0x15E0E20", VA = "0x1815E2420", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0094
			int hashCode = ((MapField<TKey, TValue>)(object)areas_).GetHashCode();
			if (sceneItemId_ != 0)
			{
			}
			string text = villageAreaDataName_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			string text2 = villageObjectLimitName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode3 = text2.GetHashCode();
			}
			VillageObjectLimitData villageObjectLimitData = boughtObjectLimit_;
			if (villageObjectLimitData != null)
			{
				int hashCode4 = villageObjectLimitData.GetHashCode();
			}
			string text3 = customLocationPositionsPath_;
			if (text3.m_stringLength != 0)
			{
				int hashCode5 = text3.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60041FD")]
		[Cpp2IlInjected.Address(RVA = "0x15E2EE0", Offset = "0x15E18E0", VA = "0x1815E2EE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60041FE")]
		[Cpp2IlInjected.Address(RVA = "0x15E3300", Offset = "0x15E1D00", VA = "0x1815E3300", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00b5
			MapField<int, Types.VillageArea> mapField = areas_;
			MapField<int, Types.VillageArea>.Codec map_areas_codec = _map_areas_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_areas_codec);
			if (sceneItemId_ != 0)
			{
				int value = sceneItemId_;
				output.WriteInt32(value);
			}
			if (villageAreaDataName_.m_stringLength != 0)
			{
				string value2 = villageAreaDataName_;
				output.WriteString(value2);
			}
			if (villageObjectLimitName_.m_stringLength != 0)
			{
				string value3 = villageObjectLimitName_;
				output.WriteString(value3);
			}
			if ((long)boughtObjectLimit_ != 0)
			{
				VillageObjectLimitData value4 = boughtObjectLimit_;
				output.WriteMessage(value4);
			}
			if (customLocationPositionsPath_.m_stringLength != 0)
			{
				string value5 = customLocationPositionsPath_;
				output.WriteString(value5);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60041FF")]
		[Cpp2IlInjected.Address(RVA = "0x15E1C10", Offset = "0x15E0610", VA = "0x1815E1C10", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00e7
			MapField<int, Types.VillageArea> mapField = areas_;
			MapField<int, Types.VillageArea>.Codec map_areas_codec = _map_areas_codec;
			int num = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_areas_codec);
			int num2 = sceneItemId_;
			if (num2 != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num2);
				num3++;
				num += num3;
			}
			string text = villageAreaDataName_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num += num4;
			}
			string text2 = villageObjectLimitName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num += num5;
			}
			VillageObjectLimitData villageObjectLimitData = boughtObjectLimit_;
			if (villageObjectLimitData != null)
			{
				int num6 = CodedOutputStream.ComputeMessageSize(villageObjectLimitData);
				num6++;
				num += num6;
			}
			string text3 = customLocationPositionsPath_;
			if (text3.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text3);
				num7++;
				num += num7;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				num += num8;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004200")]
		[Cpp2IlInjected.Address(RVA = "0x15E2910", Offset = "0x15E1310", VA = "0x1815E2910", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Village other)
		{
			//Discarded unreachable code: IL_00d5
			if (other == null)
			{
				return;
			}
			MapField<int, Types.VillageArea> mapField = areas_;
			MapField<int, Types.VillageArea> mapField2 = other.areas_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			int num = other.sceneItemId_;
			if (num != 0)
			{
				sceneItemId_ = num;
			}
			string text = other.villageAreaDataName_;
			if (text.m_stringLength != 0)
			{
				VillageAreaDataName = text;
			}
			string text2 = other.villageObjectLimitName_;
			if (text2.m_stringLength != 0)
			{
				VillageObjectLimitName = text2;
			}
			if ((long)other.boughtObjectLimit_ != 0)
			{
				VillageObjectLimitData villageObjectLimitData2 = default(VillageObjectLimitData);
				if (boughtObjectLimit_ == null)
				{
					VillageObjectLimitData villageObjectLimitData = (boughtObjectLimit_ = new VillageObjectLimitData());
					villageObjectLimitData2 = boughtObjectLimit_;
				}
				VillageObjectLimitData other2 = other.boughtObjectLimit_;
				villageObjectLimitData2.MergeFrom(other2);
			}
			string text3 = other.customLocationPositionsPath_;
			if (text3.m_stringLength != 0)
			{
				CustomLocationPositionsPath = text3;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004201")]
		[Cpp2IlInjected.Address(RVA = "0x15E2A70", Offset = "0x15E1470", VA = "0x1815E2A70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00cc
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if (num == 34)
				{
					string text2 = (VillageObjectLimitName = input.ReadString());
				}
				VillageObjectLimitData villageObjectLimitData = default(VillageObjectLimitData);
				if (num == 42)
				{
					VillageObjectLimitData builder = default(VillageObjectLimitData);
					if (boughtObjectLimit_ == null)
					{
						villageObjectLimitData = (boughtObjectLimit_ = new VillageObjectLimitData());
						builder = boughtObjectLimit_;
					}
					input.ReadMessage(builder);
				}
				if ((long)villageObjectLimitData != 50)
				{
					goto IL_00b5;
				}
				string text4 = (CustomLocationPositionsPath = input.ReadString());
			}
			if (num == 10)
			{
				MapField<int, Types.VillageArea> mapField = areas_;
				MapField<int, Types.VillageArea>.Codec map_areas_codec = _map_areas_codec;
				((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_areas_codec);
			}
			int num2 = default(int);
			if (num == 16)
			{
				num2 = (sceneItemId_ = input.ReadInt32());
			}
			if (num2 == 26)
			{
				string text6 = (VillageAreaDataName = input.ReadString());
			}
			goto IL_00b5;
			IL_00b5:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004202")]
		[Cpp2IlInjected.Address(RVA = "0x15E22F0", Offset = "0x15E0CF0", VA = "0x1815E22F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				MapField<int, Types.VillageArea> mapField = areas_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004203")]
		[Cpp2IlInjected.Address(RVA = "0x15E2CC0", Offset = "0x15E16C0", VA = "0x1815E2CC0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0018
			//IL_000d: Expected I4, but got O
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				object obj = default(object);
				sceneItemId_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004204")]
		[Cpp2IlInjected.Address(RVA = "0x15E1E00", Offset = "0x15E0800", VA = "0x1815E1E00", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0011
			if (fieldNumber - 1 <= 5)
			{
				MapField<int, Types.VillageArea> mapField = areas_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004205")]
		[Cpp2IlInjected.Address(RVA = "0x15E3120", Offset = "0x15E1B20", VA = "0x1815E3120")]
		public bool TryGetVillageArea(uint gridID, out VillageAreaType type, out Types.VillageArea value)
		{
			//Discarded unreachable code: IL_0029
			int num = 0;
			int num2 = 0;
			MapField<int, Types.VillageArea> mapField = areas_;
			bool flag = default(bool);
			if (flag)
			{
				type.value__ = 0;
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004206")]
		[Cpp2IlInjected.Address(RVA = "0x15E2F40", Offset = "0x15E1940", VA = "0x1815E2F40")]
		public unsafe bool TryGetAreaType(uint gridID, out VillageAreaType type)
		{
			int num = 0;
			return TryGetVillageArea(gridID, out type, out *(Types.VillageArea*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6004207")]
		[Cpp2IlInjected.Address(RVA = "0x15E2F60", Offset = "0x15E1960", VA = "0x1815E2F60")]
		public bool TryGetFromAreaType(VillageAreaType type, out Types.VillageArea value)
		{
			int num = 0;
			int num2 = 0;
			MapField<int, Types.VillageArea> mapField = areas_;
			bool flag = default(bool);
			if (flag)
			{
				num2++;
			}
			if (num2 + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004208")]
		[Cpp2IlInjected.Address(RVA = "0x15E2670", Offset = "0x15E1070", VA = "0x1815E2670")]
		public unsafe bool IsVillageGridID(uint gridID)
		{
			int num = 0;
			return TryGetVillageArea(gridID, out *(VillageAreaType*)num, out *(Types.VillageArea*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6004209")]
		[Cpp2IlInjected.Address(RVA = "0x15E26A0", Offset = "0x15E10A0", VA = "0x1815E26A0")]
		public bool IsVillageRelatedGrid(IGrid grid, [Optional] GridCollection gridCollection)
		{
			if (grid == null)
			{
				int num = 0;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600420A")]
		[Cpp2IlInjected.Address(RVA = "0x15E2720", Offset = "0x15E1120", VA = "0x1815E2720")]
		public unsafe bool IsVillageRelatedGrid(uint gridID, [Optional] GridCollection gridCollection)
		{
			//Discarded unreachable code: IL_0037
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if (TryGetVillageArea(gridID, out *(VillageAreaType*)num2, out *(Types.VillageArea*)num2) || gridCollection == null)
				{
					break;
				}
				MapField<int, Types.VillageArea> mapField = areas_;
				if (flag)
				{
					while (!flag2)
					{
					}
					num2++;
				}
				num2++;
				if (num2 == 0)
				{
					if (num2 == 0)
					{
					}
					break;
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600420B")]
		[Cpp2IlInjected.Address(RVA = "0x15E2530", Offset = "0x15E0F30", VA = "0x1815E2530")]
		public bool IsVillageAreaRelatedGrid(IGrid grid, VillageAreaType villageAreaType, [Optional] GridCollection gridCollection)
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (grid == null || !flag || gridCollection == null || flag2)
			{
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600420C")]
		[Cpp2IlInjected.Address(RVA = "0x15E25F0", Offset = "0x15E0FF0", VA = "0x1815E25F0")]
		public bool IsVillageAreaRelatedGrid(uint gridID, VillageAreaType villageAreaType, [Optional] GridCollection gridCollection)
		{
			//IL_0010: Expected I4, but got I8
			bool flag = default(bool);
			ulong num = default(ulong);
			if (flag && gridCollection != null && gridCollection.IsSubGridOf(gridID, (uint)num))
			{
				return true;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600420D")]
		[Cpp2IlInjected.Address(RVA = "0x15E21D0", Offset = "0x15E0BD0", VA = "0x1815E21D0")]
		public VillageObjectLimitData GetCurrentLimits()
		{
			//Discarded unreachable code: IL_0022
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			string text = villageObjectLimitName_;
			VillageObjectLimitData limitB = _003CInstance_003Ek__BackingField.Get<VillageObjectLimitData>(text);
			return VillageObjectLimitData.Combine(boughtObjectLimit_, limitB);
		}

		[Cpp2IlInjected.Token(Token = "0x600420E")]
		[Cpp2IlInjected.Address(RVA = "0x15E34B0", Offset = "0x15E1EB0", VA = "0x1815E34B0")]
		static Village()
		{
			Func<Village> func = default(Func<Village>);
			_parser = (MessageParser<Village>)(object)new MessageParser<T>((Func<>)(object)func);
			FieldCodec<int> fieldCodec = (FieldCodec<int>)(object)FieldCodec.ForInt32(8u);
			MessageParser<Types.VillageArea> parser = Types.VillageArea._parser;
			uint num = default(uint);
			FieldCodec<> fieldCodec2 = FieldCodec.ForMessage<Types.VillageArea>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<Village>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, fieldCodec2, num2);
			/*Error: Unexpected end of block*/;
		}
	}
}
