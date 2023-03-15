using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Grids;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200089E")]
	public sealed class BurningState : IMessage<BurningState>, IMessage, IEquatable<BurningState>, IDeepCloneable<BurningState>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x200089F")]
		public enum BurningStateOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40022B6")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40022B7")]
			Gardening
		}

		[Cpp2IlInjected.Token(Token = "0x20008A0")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20008A1")]
			public sealed class GardeningBurningState : IMessage<GardeningBurningState>, IMessage, IEquatable<GardeningBurningState>, IDeepCloneable<GardeningBurningState>, IMessageFieldAccessor, IBurningState
			{
				[Cpp2IlInjected.Token(Token = "0x40022B8")]
				private static readonly MessageParser<GardeningBurningState> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40022B9")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40022BA")]
				public const int StartTimeFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40022BB")]
				private Timestamp startTime_;

				[Cpp2IlInjected.Token(Token = "0x40022BC")]
				public const int EndTimeFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40022BD")]
				private Timestamp endTime_;

				[Cpp2IlInjected.Token(Token = "0x40022BE")]
				public const int PendingFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40022BF")]
				private bool pending_;

				[Cpp2IlInjected.Token(Token = "0x40022C0")]
				public const int LastCollectFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40022C1")]
				private Timestamp lastCollect_;

				[Cpp2IlInjected.Token(Token = "0x40022C2")]
				public const int GridIDFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40022C3")]
				private uint gridID_;

				[Cpp2IlInjected.Token(Token = "0x40022C4")]
				public const int GridObjectIDFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
				[Cpp2IlInjected.Token(Token = "0x40022C5")]
				private uint gridObjectID_;

				[Cpp2IlInjected.Token(Token = "0x40022C6")]
				public const int SlotIndexFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40022C7")]
				private int slotIndex_;

				[Cpp2IlInjected.Token(Token = "0x17000C44")]
				[DebuggerNonUserCode]
				public static MessageParser<GardeningBurningState> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6004969")]
					[Cpp2IlInjected.Address(RVA = "0x2723730", Offset = "0x2722130", VA = "0x182723730")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C45")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600496A")]
					[Cpp2IlInjected.Address(RVA = "0x27236B0", Offset = "0x27220B0", VA = "0x1827236B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C46")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600496B")]
					[Cpp2IlInjected.Address(RVA = "0x2723790", Offset = "0x2722190", VA = "0x182723790", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C47")]
				[DebuggerNonUserCode]
				public Timestamp StartTime
				{
					[Cpp2IlInjected.Token(Token = "0x600496F")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004970")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510", Slot = "15")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C48")]
				[DebuggerNonUserCode]
				public Timestamp EndTime
				{
					[Cpp2IlInjected.Token(Token = "0x6004971")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004972")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "17")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C49")]
				[DebuggerNonUserCode]
				public bool Pending
				{
					[Cpp2IlInjected.Token(Token = "0x6004973")]
					[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90", Slot = "18")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6004974")]
					[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C4A")]
				[DebuggerNonUserCode]
				public Timestamp LastCollect
				{
					[Cpp2IlInjected.Token(Token = "0x6004975")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "20")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6004976")]
					[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10", Slot = "21")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C4B")]
				[DebuggerNonUserCode]
				public uint GridID
				{
					[Cpp2IlInjected.Token(Token = "0x6004977")]
					[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6004978")]
					[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C4C")]
				[DebuggerNonUserCode]
				public uint GridObjectID
				{
					[Cpp2IlInjected.Token(Token = "0x6004979")]
					[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x600497A")]
					[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000C4D")]
				[DebuggerNonUserCode]
				public int SlotIndex
				{
					[Cpp2IlInjected.Token(Token = "0x600497B")]
					[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600497C")]
					[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600496C")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public GardeningBurningState()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600496D")]
				[Cpp2IlInjected.Address(RVA = "0x27235C0", Offset = "0x2721FC0", VA = "0x1827235C0")]
				[DebuggerNonUserCode]
				public GardeningBurningState(GardeningBurningState other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600496E")]
				[Cpp2IlInjected.Address(RVA = "0x2722740", Offset = "0x2721140", VA = "0x182722740", Slot = "10")]
				[DebuggerNonUserCode]
				public GardeningBurningState Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600497D")]
				[Cpp2IlInjected.Address(RVA = "0x2722960", Offset = "0x2721360", VA = "0x182722960", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600497E")]
				[Cpp2IlInjected.Address(RVA = "0x27228B0", Offset = "0x27212B0", VA = "0x1827228B0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(GardeningBurningState other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600497F")]
				[Cpp2IlInjected.Address(RVA = "0x2722BE0", Offset = "0x27215E0", VA = "0x182722BE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004980")]
				[Cpp2IlInjected.Address(RVA = "0x27232F0", Offset = "0x2721CF0", VA = "0x1827232F0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004981")]
				[Cpp2IlInjected.Address(RVA = "0x2723350", Offset = "0x2721D50", VA = "0x182723350", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004982")]
				[Cpp2IlInjected.Address(RVA = "0x27221E0", Offset = "0x2720BE0", VA = "0x1827221E0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6004983")]
				[Cpp2IlInjected.Address(RVA = "0x2722ED0", Offset = "0x27218D0", VA = "0x182722ED0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(GardeningBurningState other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004984")]
				[Cpp2IlInjected.Address(RVA = "0x2722CF0", Offset = "0x27216F0", VA = "0x182722CF0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004985")]
				[Cpp2IlInjected.Address(RVA = "0x2722A60", Offset = "0x2721460", VA = "0x182722A60", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004986")]
				[Cpp2IlInjected.Address(RVA = "0x27230A0", Offset = "0x2721AA0", VA = "0x1827230A0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004987")]
				[Cpp2IlInjected.Address(RVA = "0x2722390", Offset = "0x2720D90", VA = "0x182722390", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6004988")]
				[Cpp2IlInjected.Address(RVA = "0x2722860", Offset = "0x2721260", VA = "0x182722860")]
				public ContainerInventory.CanAddResult? Collect(in Player player, in World world, ITransactionContext context, VillageAreaType areaType)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6004989")]
				[Cpp2IlInjected.Address(RVA = "0x2722420", Offset = "0x2720E20", VA = "0x182722420")]
				public void Clear(in Player player, in World world, ITransactionContext context)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600498B")]
				[Cpp2IlInjected.Address(RVA = "0x2723080", Offset = "0x2721A80", VA = "0x182723080", Slot = "22")]
				ContainerInventory.CanAddResult? IBurningState.Collect(in Player player, in World world, ITransactionContext context, VillageAreaType areaType)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600498C")]
				[Cpp2IlInjected.Address(RVA = "0x2723070", Offset = "0x2721A70", VA = "0x182723070", Slot = "23")]
				void IBurningState.Clear(in Player player, in World world, ITransactionContext context)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20008A3")]
		public interface IBurningState
		{
			[Cpp2IlInjected.Token(Token = "0x17000C4E")]
			Timestamp StartTime
			{
				[Cpp2IlInjected.Token(Token = "0x6004990")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6004991")]
				[Cpp2IlInjected.Address(Slot = "1")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000C4F")]
			Timestamp EndTime
			{
				[Cpp2IlInjected.Token(Token = "0x6004992")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6004993")]
				[Cpp2IlInjected.Address(Slot = "3")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000C50")]
			bool Pending
			{
				[Cpp2IlInjected.Token(Token = "0x6004994")]
				[Cpp2IlInjected.Address(Slot = "4")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6004995")]
				[Cpp2IlInjected.Address(Slot = "5")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000C51")]
			Timestamp LastCollect
			{
				[Cpp2IlInjected.Token(Token = "0x6004996")]
				[Cpp2IlInjected.Address(Slot = "6")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6004997")]
				[Cpp2IlInjected.Address(Slot = "7")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6004998")]
			[Cpp2IlInjected.Address(Slot = "8")]
			ContainerInventory.CanAddResult? Collect(in Player player, in World world, ITransactionContext context, VillageAreaType areaType);

			[Cpp2IlInjected.Token(Token = "0x6004999")]
			[Cpp2IlInjected.Address(Slot = "9")]
			void Clear(in Player player, in World world, ITransactionContext context);
		}

		[Cpp2IlInjected.Token(Token = "0x40022AB")]
		private static readonly MessageParser<BurningState> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40022AC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40022AD")]
		public const int GardeningFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40022AE")]
		private object burningState_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40022AF")]
		private BurningStateOneofCase burningStateCase_;

		[Cpp2IlInjected.Token(Token = "0x40022B0")]
		private const string RandomSeedName = "BurningState";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40022B2")]
		private World world;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40022B3")]
		private ITransactionContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40022B4")]
		private BurningStateData burningStateData;

		[Cpp2IlInjected.Token(Token = "0x17000C3D")]
		[DebuggerNonUserCode]
		public static MessageParser<BurningState> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004948")]
			[Cpp2IlInjected.Address(RVA = "0x1AC83C0", Offset = "0x1AC6DC0", VA = "0x181AC83C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C3E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004949")]
			[Cpp2IlInjected.Address(RVA = "0x1AC8290", Offset = "0x1AC6C90", VA = "0x181AC8290")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C3F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600494A")]
			[Cpp2IlInjected.Address(RVA = "0x1AC8420", Offset = "0x1AC6E20", VA = "0x181AC8420", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C40")]
		[DebuggerNonUserCode]
		public Types.GardeningBurningState Gardening
		{
			[Cpp2IlInjected.Token(Token = "0x600494E")]
			[Cpp2IlInjected.Address(RVA = "0x1AC8360", Offset = "0x1AC6D60", VA = "0x181AC8360")]
			get
			{
				int num = 0;
				if (burningStateCase_ == BurningStateOneofCase.Gardening)
				{
					object obj = burningState_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600494F")]
			[Cpp2IlInjected.Address(RVA = "0x5C5DD0", Offset = "0x5C47D0", VA = "0x1805C5DD0")]
			set
			{
				burningState_ = value;
				bool flag = (byte)(burningStateCase_ = ((value != null) ? BurningStateOneofCase.Gardening : BurningStateOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C41")]
		[DebuggerNonUserCode]
		public BurningStateOneofCase BurningStateCase
		{
			[Cpp2IlInjected.Token(Token = "0x6004950")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return burningStateCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C42")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x24"), Cpp2IlInjected.Token(Token = "0x40022B1")]
		internal bool Force
		{
			[Cpp2IlInjected.Token(Token = "0x600495F")]
			[Cpp2IlInjected.Address(RVA = "0x1703600", Offset = "0x1702000", VA = "0x181703600")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004960")]
			[Cpp2IlInjected.Address(RVA = "0x1703720", Offset = "0x1702120", VA = "0x181703720")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000C43")]
		public IBurningState CurrentBurningState
		{
			[Cpp2IlInjected.Token(Token = "0x6004964")]
			[Cpp2IlInjected.Address(RVA = "0x1AC8250", Offset = "0x1AC6C50", VA = "0x181AC8250")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6004965")]
			[Cpp2IlInjected.Address(RVA = "0x1AC8530", Offset = "0x1AC6F30", VA = "0x181AC8530")]
			private set
			{
				//IL_001a: Expected I4, but got I8
				//IL_0029: Expected O, but got I4
				int num = 0;
				if (value != null)
				{
					if (value != null)
					{
						burningState_ = value;
						burningStateCase_ = BurningStateOneofCase.Gardening;
					}
				}
				else
				{
					burningStateCase_ = (BurningStateOneofCase)num;
					burningState_ = num;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600494B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public BurningState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600494C")]
		[Cpp2IlInjected.Address(RVA = "0x1AC8170", Offset = "0x1AC6B70", VA = "0x181AC8170")]
		[DebuggerNonUserCode]
		public BurningState(BurningState other)
		{
			if (other.burningStateCase_ == BurningStateOneofCase.Gardening)
			{
				if (other.burningState_ == null)
				{
					throw new InvalidCastException();
				}
				Types.GardeningBurningState gardeningBurningState = default(Types.GardeningBurningState);
				burningState_ = gardeningBurningState;
				bool flag = (byte)(burningStateCase_ = ((gardeningBurningState != null) ? BurningStateOneofCase.Gardening : BurningStateOneofCase.None)) != 0;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600494D")]
		[Cpp2IlInjected.Address(RVA = "0x1AC6B00", Offset = "0x1AC5500", VA = "0x181AC6B00", Slot = "10")]
		[DebuggerNonUserCode]
		public BurningState Clone()
		{
			//Discarded unreachable code: IL_0043
			BurningState burningState = new BurningState();
			if (burningStateCase_ == BurningStateOneofCase.Gardening)
			{
				if (burningState_ == null)
				{
					throw new InvalidCastException();
				}
				Types.GardeningBurningState gardeningBurningState = default(Types.GardeningBurningState);
				burningState.burningState_ = gardeningBurningState;
				bool flag = (byte)(burningState.burningStateCase_ = ((gardeningBurningState != null) ? BurningStateOneofCase.Gardening : BurningStateOneofCase.None)) != 0;
			}
			UnknownFieldSet unknownFieldSet = (burningState._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return burningState;
		}

		[Cpp2IlInjected.Token(Token = "0x6004951")]
		[Cpp2IlInjected.Address(RVA = "0x5C3250", Offset = "0x5C1C50", VA = "0x1805C3250")]
		[DebuggerNonUserCode]
		public void ClearBurningState()
		{
			//IL_0010: Expected O, but got I4
			burningState_ = (burningStateCase_ = BurningStateOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004952")]
		[Cpp2IlInjected.Address(RVA = "0x1AC6C10", Offset = "0x1AC5610", VA = "0x181AC6C10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
				int num = 0;
				if (other != null && other != this)
				{
					if (burningStateCase_ == BurningStateOneofCase.Gardening)
					{
						object obj = burningState_;
						if (obj != null && obj == null)
						{
							goto IL_0053;
						}
					}
					if (1L == 0L)
					{
					}
					if ((object)typeof(Types.GardeningBurningState).TypeHandle != null && (object)typeof(Types.GardeningBurningState).TypeHandle == null)
					{
						throw new InvalidCastException();
					}
					bool flag = default(bool);
					if (flag && burningStateCase_ == (flag ? BurningStateOneofCase.Gardening : BurningStateOneofCase.None))
					{
						UnknownFieldSet unknownFields = _unknownFields;
					}
				}
			}
			int num2 = 0;
			goto IL_0053;
			IL_0053:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004953")]
		[Cpp2IlInjected.Address(RVA = "0x1AC6D50", Offset = "0x1AC5750", VA = "0x181AC6D50", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BurningState other)
		{
			//IL_004d: Expected O, but got I4
			if (other != null && other != this)
			{
				int num = 0;
				if (burningStateCase_ == BurningStateOneofCase.Gardening)
				{
					object obj = burningState_;
					if (obj != null && obj == null)
					{
						goto IL_007a;
					}
				}
				if (1L == 0L)
				{
				}
				object obj2 = default(object);
				if (other.burningStateCase_ == BurningStateOneofCase.Gardening)
				{
					obj2 = other.burningState_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (object.Equals(num, obj2))
				{
					BurningStateOneofCase burningStateOneofCase = other.burningStateCase_;
					if (burningStateCase_ == burningStateOneofCase)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						bool flag = object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			goto IL_007a;
			IL_007a:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004954")]
		[Cpp2IlInjected.Address(RVA = "0x1AC6F20", Offset = "0x1AC5920", VA = "0x181AC6F20", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002f
			if (burningStateCase_ == BurningStateOneofCase.Gardening)
			{
				object obj = burningState_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode = obj.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004955")]
		[Cpp2IlInjected.Address(RVA = "0x1AC77E0", Offset = "0x1AC61E0", VA = "0x181AC77E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004956")]
		[Cpp2IlInjected.Address(RVA = "0x1AC7FB0", Offset = "0x1AC69B0", VA = "0x181AC7FB0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003d
			//IL_002a: Expected O, but got I4
			if (burningStateCase_ == BurningStateOneofCase.Gardening)
			{
				int num = 0;
				if (burningStateCase_ == BurningStateOneofCase.Gardening)
				{
					object obj = burningState_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				output.WriteMessage((IMessage)num);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004957")]
		[Cpp2IlInjected.Address(RVA = "0x1AC66A0", Offset = "0x1AC50A0", VA = "0x181AC66A0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_0029: Expected O, but got I4
			int num = 0;
			if (burningStateCase_ == BurningStateOneofCase.Gardening)
			{
				if (burningStateCase_ == BurningStateOneofCase.Gardening)
				{
					object obj = burningState_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int num2 = CodedOutputStream.ComputeMessageSize((IMessage)num);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num3 = unknownFields.CalculateSize();
				num += num3;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6004958")]
		[Cpp2IlInjected.Address(RVA = "0x1AC7360", Offset = "0x1AC5D60", VA = "0x181AC7360", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BurningState other)
		{
			//Discarded unreachable code: IL_00b0
			if (other == null)
			{
				return;
			}
			if (other.burningStateCase_ == BurningStateOneofCase.Gardening)
			{
				BurningStateOneofCase burningStateOneofCase = burningStateCase_;
				int num = 0;
				if (burningStateOneofCase == BurningStateOneofCase.Gardening)
				{
					object obj = burningState_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (num == 0)
				{
					bool flag = (byte)(burningStateCase_ = (((burningState_ = new Types.GardeningBurningState()) != null) ? BurningStateOneofCase.Gardening : BurningStateOneofCase.None)) != 0;
				}
				if (burningStateCase_ == BurningStateOneofCase.Gardening)
				{
					object obj2 = burningState_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.burningStateCase_ == BurningStateOneofCase.Gardening)
				{
					object obj3 = other.burningState_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004959")]
		[Cpp2IlInjected.Address(RVA = "0x1AC7220", Offset = "0x1AC5C20", VA = "0x181AC7220", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				Types.GardeningBurningState gardeningBurningState = new Types.GardeningBurningState();
				if (burningStateCase_ == BurningStateOneofCase.Gardening)
				{
					if (burningStateCase_ != BurningStateOneofCase.Gardening)
					{
					}
					object obj = burningState_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				input.ReadMessage(gardeningBurningState);
				burningState_ = gardeningBurningState;
				bool flag = (byte)(burningStateCase_ = ((gardeningBurningState != null) ? BurningStateOneofCase.Gardening : BurningStateOneofCase.None)) != 0;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600495A")]
		[Cpp2IlInjected.Address(RVA = "0x1AC6E60", Offset = "0x1AC5860", VA = "0x181AC6E60", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = 0;
				if (burningStateCase_ == BurningStateOneofCase.Gardening)
				{
					object obj = burningState_;
					if (obj != null && obj == null)
					{
						goto IL_002e;
					}
				}
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			goto IL_002e;
			IL_002e:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600495B")]
		[Cpp2IlInjected.Address(RVA = "0x1AC7520", Offset = "0x1AC5F20", VA = "0x181AC7520", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				burningState_ = num;
				bool flag = (byte)(burningStateCase_ = ((num != 0) ? BurningStateOneofCase.Gardening : BurningStateOneofCase.None)) != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600495C")]
		[Cpp2IlInjected.Address(RVA = "0x1AC6A60", Offset = "0x1AC5460", VA = "0x181AC6A60", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected O, but got I8
			//IL_0016: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				burningState_ = 0;
				burningStateCase_ = BurningStateOneofCase.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600495D")]
		[Cpp2IlInjected.Address(RVA = "0x1AC6FD0", Offset = "0x1AC59D0", VA = "0x181AC6FD0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "BurningState"))
			{
				BurningStateOneofCase burningStateOneofCase = burningStateCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600495E")]
		[Cpp2IlInjected.Address(RVA = "0x1AC6A90", Offset = "0x1AC5490", VA = "0x181AC6A90", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "BurningState"))
			{
				burningState_ = (burningStateCase_ = BurningStateOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004961")]
		[Cpp2IlInjected.Address(RVA = "0x1AC7080", Offset = "0x1AC5A80", VA = "0x181AC7080")]
		internal void Initialize(in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0016
			this.context = context;
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			if ((object)typeof(IBurningState).TypeHandle == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004962")]
		[Cpp2IlInjected.Address(RVA = "0x1AC7840", Offset = "0x1AC6240", VA = "0x181AC7840")]
		internal (bool, bool, bool) TryCheckGardeningBurningState(GardenItemData gardenItemData, IGrid grid, GridObject gridObject, int slotIndex, DateTime now, in Player player)
		{
			//IL_0109: Expected I4, but got O
			int num = 0;
			bool flag = default(bool);
			int sizeX_ = default(int);
			if (!flag)
			{
				int num2 = 0;
				GardenData gardenData = default(GardenData);
				RepeatedField<GardenData.Types.GardeningSlot> slots_ = gardenData.slots_;
				GardenData.Types.GardeningSlot gardeningSlot = default(GardenData.Types.GardeningSlot);
				Item plantedSeedItem = gardeningSlot.PlantedSeedItem;
				SeedItemData seedItemData = default(SeedItemData);
				if (!seedItemData.IsMissionItem())
				{
					Item producedItem = seedItemData.ProducedItem;
					CropItemData cropItemData = default(CropItemData);
					if (cropItemData != null)
					{
						CropType cropType_ = cropItemData.cropType_;
					}
					if (num != 0)
					{
						if (num == 0)
						{
							GridAreaData gridAreaData_ = gardenItemData.gridAreaData_;
						}
						if (num != 1)
						{
							goto IL_0061;
						}
					}
					sizeX_ = gardenItemData.gridAreaData_.sizeX_;
					goto IL_0061;
				}
			}
			goto IL_0167;
			IL_011d:
			if ((long)this == 1)
			{
				Types.GardeningBurningState gardeningBurningState = default(Types.GardeningBurningState);
				uint gridID_ = gardeningBurningState.gridID_;
				Types.GardeningBurningState gardeningBurningState2 = default(Types.GardeningBurningState);
				if ((IntPtr)(int)gardeningBurningState2.gridObjectID_ == (IntPtr)gardenItemData)
				{
					Types.GardeningBurningState gardeningBurningState3 = default(Types.GardeningBurningState);
					int slotIndex_ = gardeningBurningState3.slotIndex_;
					Types.GardeningBurningState gardeningBurningState4 = default(Types.GardeningBurningState);
					if ((long)gardeningBurningState4.lastCollect_ != 0)
					{
						Types.GardeningBurningState gardeningBurningState5 = default(Types.GardeningBurningState);
						DateTime dateTime = gardeningBurningState5.lastCollect_.ToDateTime();
						TimeSpan timeSpan = default(TimeSpan);
						TimeSpan timeSpan2 = default(TimeSpan);
						bool flag2 = timeSpan > timeSpan2;
					}
				}
				int num3 = 0;
			}
			goto IL_0167;
			IL_0061:
			if (gardenItemData.name_ != null)
			{
				goto IL_011d;
			}
			if (sizeX_ != 0)
			{
				string displayName_ = gardenItemData.displayName_;
				int seed = default(int);
				Random random = new Random(seed);
				int minValue = 0;
				int num4 = random.Next(minValue, 100);
				string displayName_2 = gardenItemData.displayName_;
				seed = num4;
				if ((long)seed < (long)(IntPtr)random)
				{
					Types.GardeningBurningState gardeningBurningState6 = new Types.GardeningBurningState();
					Timestamp startTime_ = default(Timestamp);
					gardeningBurningState6.startTime_ = startTime_;
					int acceptedFloorTypesFlag_ = gardenItemData.gridAreaData_.acceptedFloorTypesFlag_;
					DateTime dateTime2 = default(DateTime);
					TimeSpan timeSpan3 = default(TimeSpan);
					Timestamp timestamp = (gardeningBurningState6.endTime_ = (dateTime2 + timeSpan3).ToProto());
					gardeningBurningState6.gridID_ = 0u;
					gardeningBurningState6.gridObjectID_ = 0u;
					gardeningBurningState6.slotIndex_ = 0;
					if (gardeningBurningState6 != null)
					{
						gardenItemData.iD_ = (int)gardeningBurningState6;
					}
					if ((object)typeof(Types.GardeningBurningState).TypeHandle != null || gardenItemData.iconAddress_ != null)
					{
					}
					int num5 = 0;
					goto IL_011d;
				}
			}
			goto IL_0167;
			IL_0167:
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004963")]
		[Cpp2IlInjected.Address(RVA = "0x1AC75B0", Offset = "0x1AC5FB0", VA = "0x181AC75B0")]
		private bool ShouldStartBurningState(BurningStateData.Types.ActivityData activityData, out TimeSpan duration)
		{
			//IL_0013: Expected I8, but got O
			TimeSpan timeSpan = activityData.duration_.ToTimeSpan();
			duration._ticks = (long)timeSpan;
			if (!Force)
			{
				World world = this.world;
				int seed = default(int);
				Random random = new Random(seed);
				int minValue = 0;
				int num = random.Next(minValue, 100);
				World world2 = this.world;
				seed = num;
				int probability_ = activityData.probability_;
				return seed < probability_;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004966")]
		[Cpp2IlInjected.Address(RVA = "0x1AC76D0", Offset = "0x1AC60D0", VA = "0x181AC76D0")]
		private void StartBurningState(IBurningState burningState)
		{
			//IL_001a: Expected I4, but got I8
			//IL_003f: Expected O, but got I4
			int num = 0;
			if (burningState != null)
			{
				if (burningState != null)
				{
					burningState_ = burningState;
					burningStateCase_ = BurningStateOneofCase.Gardening;
				}
				if ((object)typeof(Types.GardeningBurningState).TypeHandle == null && world.dispatcher == null)
				{
				}
				return;
			}
			burningStateCase_ = (BurningStateOneofCase)num;
			burningState_ = num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004967")]
		[Cpp2IlInjected.Address(RVA = "0x1AC6760", Offset = "0x1AC5160", VA = "0x181AC6760")]
		internal bool CheckFinishedBurningState(in Player player, DateTime now, bool clear)
		{
			//IL_0050: Expected O, but got I4
			if ((object)typeof(IBurningState).TypeHandle != null)
			{
				int num = 0;
				if ((long)num < (long)(IntPtr)now)
				{
					num += num;
					num++;
				}
				int num2 = 0;
				DateTime dateTime = default(DateTime);
				if (!(now < dateTime))
				{
					if (clear && num < num2)
					{
						num += num;
						num++;
					}
					if (world.dispatcher != null)
					{
					}
					int num3 = 0;
					burningStateCase_ = (BurningStateOneofCase)num;
					burningState_ = num;
					num3 += num3;
					num3 += num3;
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004968")]
		[Cpp2IlInjected.Address(RVA = "0x1AC8060", Offset = "0x1AC6A60", VA = "0x181AC8060")]
		static BurningState()
		{
			Func<BurningState> func = default(Func<BurningState>);
			_parser = (MessageParser<BurningState>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
