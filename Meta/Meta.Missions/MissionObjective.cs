using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Conditions;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Rewards;
using Definitions.Scene;
using Definitions.Util;
using Gameloft.Common;
using Gameloft.FileSystem.Abstraction;
using Gameloft.Localization.Core;
using Gameloft.Localization.Formatter;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Mdl.Utils;
using Meta.Customization;
using Meta.Grids;
using Meta.Util;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2001005")]
	public sealed class MissionObjective : IMessage<MissionObjective>, IMessage, IEquatable<MissionObjective>, IDeepCloneable<MissionObjective>, IMessageFieldAccessor, IMissionIdentifier, IEquationKeyProvider
	{
		[Cpp2IlInjected.Token(Token = "0x2001006")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2001007")]
			public sealed class GridObjectInfo : IMessage<GridObjectInfo>, IMessage, IEquatable<GridObjectInfo>, IDeepCloneable<GridObjectInfo>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4004204")]
				private static readonly MessageParser<GridObjectInfo> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4004205")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4004206")]
				public const int GridIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4004207")]
				private uint gridId_;

				[Cpp2IlInjected.Token(Token = "0x4004208")]
				public const int GridObjectIdFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4004209")]
				private uint gridObjectId_;

				[Cpp2IlInjected.Token(Token = "0x170016AE")]
				[DebuggerNonUserCode]
				public static MessageParser<GridObjectInfo> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6008250")]
					[Cpp2IlInjected.Address(RVA = "0x25C4170", Offset = "0x25C2B70", VA = "0x1825C4170")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170016AF")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6008251")]
					[Cpp2IlInjected.Address(RVA = "0x25C40F0", Offset = "0x25C2AF0", VA = "0x1825C40F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170016B0")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6008252")]
					[Cpp2IlInjected.Address(RVA = "0x25C41D0", Offset = "0x25C2BD0", VA = "0x1825C41D0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170016B1")]
				[DebuggerNonUserCode]
				public uint GridId
				{
					[Cpp2IlInjected.Token(Token = "0x6008256")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6008257")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170016B2")]
				[DebuggerNonUserCode]
				public uint GridObjectId
				{
					[Cpp2IlInjected.Token(Token = "0x6008258")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(uint);
					}
					[Cpp2IlInjected.Token(Token = "0x6008259")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6008253")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public GridObjectInfo()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6008254")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public GridObjectInfo(GridObjectInfo other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6008255")]
				[Cpp2IlInjected.Address(RVA = "0x25C3CE0", Offset = "0x25C26E0", VA = "0x1825C3CE0", Slot = "10")]
				[DebuggerNonUserCode]
				public GridObjectInfo Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600825A")]
				[Cpp2IlInjected.Address(RVA = "0x25C3D70", Offset = "0x25C2770", VA = "0x1825C3D70", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600825B")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(GridObjectInfo other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600825C")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600825D")]
				[Cpp2IlInjected.Address(RVA = "0x25C3F80", Offset = "0x25C2980", VA = "0x1825C3F80", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600825E")]
				[Cpp2IlInjected.Address(RVA = "0x108E870", Offset = "0x108D270", VA = "0x18108E870", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600825F")]
				[Cpp2IlInjected.Address(RVA = "0x25C3C10", Offset = "0x25C2610", VA = "0x1825C3C10", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6008260")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(GridObjectInfo other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6008261")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6008262")]
				[Cpp2IlInjected.Address(RVA = "0x25C3E00", Offset = "0x25C2800", VA = "0x1825C3E00", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6008263")]
				[Cpp2IlInjected.Address(RVA = "0x25C3EC0", Offset = "0x25C28C0", VA = "0x1825C3EC0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6008264")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2001009")]
		internal delegate void StepCompletionChangedDelegate(MissionObjective missionStep, bool completed);

		[Cpp2IlInjected.Token(Token = "0x200100A")]
		internal delegate void StepStatusChangedDelegate(MissionObjective objective, MissionStepStatus previousStatus, MissionStepStatus newStatus);

		[Cpp2IlInjected.Token(Token = "0x40041CD")]
		private static readonly MessageParser<MissionObjective> _parser = (MessageParser<MissionObjective>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new MissionObjective()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40041CE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40041CF")]
		public const int ItemFilterFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40041D0")]
		private ItemFilter itemFilter_;

		[Cpp2IlInjected.Token(Token = "0x40041D1")]
		public const int TargetAmountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40041D2")]
		private float targetAmount_;

		[Cpp2IlInjected.Token(Token = "0x40041D3")]
		public const int ProgressKeysFieldNumber = 3;

		[Cpp2IlInjected.Token(Token = "0x40041D4")]
		private static readonly MapField<string, string>.Codec _map_progressKeys_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40041D5")]
		private readonly MapField<string, string> progressKeys_;

		[Cpp2IlInjected.Token(Token = "0x40041D6")]
		public const int StatusFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40041D7")]
		private MissionStepStatus status_;

		[Cpp2IlInjected.Token(Token = "0x40041D8")]
		public const int GoBehaviorIntFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40041D9")]
		private int goBehaviorInt_;

		[Cpp2IlInjected.Token(Token = "0x40041DA")]
		public const int StepTypeFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40041DB")]
		private MissionStepType stepType_;

		[Cpp2IlInjected.Token(Token = "0x40041DC")]
		public const int MinWeightRequiredFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40041DD")]
		private float minWeightRequired_;

		[Cpp2IlInjected.Token(Token = "0x40041DE")]
		public const int MaxWeightRequiredFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40041DF")]
		private float maxWeightRequired_;

		[Cpp2IlInjected.Token(Token = "0x40041E0")]
		public const int ItemIdsCollectedFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x40041E1")]
		private static readonly FieldCodec<int> _repeated_itemIdsCollected_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40041E2")]
		private readonly RepeatedField<int> itemIdsCollected_;

		[Cpp2IlInjected.Token(Token = "0x40041E3")]
		public const int GridObjectIdsCollectedFieldNumber = 11;

		[Cpp2IlInjected.Token(Token = "0x40041E4")]
		private static readonly FieldCodec<Types.GridObjectInfo> _repeated_gridObjectIdsCollected_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40041E5")]
		private readonly RepeatedField<Types.GridObjectInfo> gridObjectIdsCollected_;

		[Cpp2IlInjected.Token(Token = "0x40041E6")]
		public const int TargetCharacterItemIDFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40041E7")]
		private int targetCharacterItemID_;

		[Cpp2IlInjected.Token(Token = "0x40041E8")]
		public const int ChallengeTypeFieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40041E9")]
		private ChallengeType challengeType_;

		[Cpp2IlInjected.Token(Token = "0x40041EA")]
		public const int AmountToSpawnFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40041EB")]
		private float amountToSpawn_;

		[Cpp2IlInjected.Token(Token = "0x40041EC")]
		public const int SpawnRadiusFieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40041ED")]
		private float spawnRadius_;

		[Cpp2IlInjected.Token(Token = "0x40041EE")]
		public const int ItemAmountFieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40041EF")]
		private float itemAmount_;

		[Cpp2IlInjected.Token(Token = "0x40041F0")]
		public const int ItemFiltersWithAmountFieldNumber = 17;

		[Cpp2IlInjected.Token(Token = "0x40041F1")]
		private static readonly FieldCodec<ItemFilterWithAmount> _repeated_itemFiltersWithAmount_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40041F2")]
		private readonly RepeatedField<ItemFilterWithAmount> itemFiltersWithAmount_;

		[Cpp2IlInjected.Token(Token = "0x40041F3")]
		public const int MinStarRatingRequiredFieldNumber = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40041F4")]
		private int minStarRatingRequired_;

		[Cpp2IlInjected.Token(Token = "0x40041F5")]
		public const int WasSkippedFieldNumber = 25;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40041F6")]
		private bool wasSkipped_;

		[Cpp2IlInjected.Token(Token = "0x40041F8")]
		private static readonly string CurrentAmountKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40041F9")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.Token(Token = "0x40041FA")]
		private static readonly string DiscussionKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40041FF")]
		private Profile Profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4004200")]
		private ProfileEventDispatcher Dispatcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4004201")]
		private ITransactionContext Context;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4004202")]
		private bool stepStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4004203")]
		private MissionSlotStringResolver _stringResolver;

		[Cpp2IlInjected.Token(Token = "0x17001687")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionObjective> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60080FB")]
			[Cpp2IlInjected.Address(RVA = "0x823D30", Offset = "0x822730", VA = "0x180823D30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001688")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60080FC")]
			[Cpp2IlInjected.Address(RVA = "0x823BE0", Offset = "0x8225E0", VA = "0x180823BE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001689")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60080FD")]
			[Cpp2IlInjected.Address(RVA = "0x823F20", Offset = "0x822920", VA = "0x180823F20", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700168A")]
		[DebuggerNonUserCode]
		public ItemFilter ItemFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6008102")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return itemFilter_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008103")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				itemFilter_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700168B")]
		[DebuggerNonUserCode]
		public float TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6008104")]
			[Cpp2IlInjected.Address(RVA = "0x823EA0", Offset = "0x8228A0", VA = "0x180823EA0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008105")]
			[Cpp2IlInjected.Address(RVA = "0x8242A0", Offset = "0x822CA0", VA = "0x1808242A0")]
			set
			{
				targetAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700168C")]
		[DebuggerNonUserCode]
		public MapField<string, string> ProgressKeys
		{
			[Cpp2IlInjected.Token(Token = "0x6008106")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return progressKeys_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700168D")]
		[DebuggerNonUserCode]
		public MissionStepStatus Status
		{
			[Cpp2IlInjected.Token(Token = "0x6008107")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return status_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008108")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				status_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700168E")]
		[DebuggerNonUserCode]
		public int GoBehaviorInt
		{
			[Cpp2IlInjected.Token(Token = "0x6008109")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return goBehaviorInt_;
			}
			[Cpp2IlInjected.Token(Token = "0x600810A")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				goBehaviorInt_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700168F")]
		[DebuggerNonUserCode]
		public MissionStepType StepType
		{
			[Cpp2IlInjected.Token(Token = "0x600810B")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return stepType_;
			}
			[Cpp2IlInjected.Token(Token = "0x600810C")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				stepType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001690")]
		[DebuggerNonUserCode]
		public float MinWeightRequired
		{
			[Cpp2IlInjected.Token(Token = "0x600810D")]
			[Cpp2IlInjected.Address(RVA = "0x823CD0", Offset = "0x8226D0", VA = "0x180823CD0")]
			get
			{
				return minWeightRequired_;
			}
			[Cpp2IlInjected.Token(Token = "0x600810E")]
			[Cpp2IlInjected.Address(RVA = "0x824260", Offset = "0x822C60", VA = "0x180824260")]
			set
			{
				minWeightRequired_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001691")]
		[DebuggerNonUserCode]
		public float MaxWeightRequired
		{
			[Cpp2IlInjected.Token(Token = "0x600810F")]
			[Cpp2IlInjected.Address(RVA = "0x823CC0", Offset = "0x8226C0", VA = "0x180823CC0")]
			get
			{
				return maxWeightRequired_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008110")]
			[Cpp2IlInjected.Address(RVA = "0x824250", Offset = "0x822C50", VA = "0x180824250")]
			set
			{
				maxWeightRequired_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001692")]
		[DebuggerNonUserCode]
		public RepeatedField<int> ItemIdsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6008111")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return itemIdsCollected_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001693")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.GridObjectInfo> GridObjectIdsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6008112")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return gridObjectIdsCollected_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001694")]
		[DebuggerNonUserCode]
		public int TargetCharacterItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6008113")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return targetCharacterItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008114")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				targetCharacterItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001695")]
		[DebuggerNonUserCode]
		public ChallengeType ChallengeType
		{
			[Cpp2IlInjected.Token(Token = "0x6008115")]
			[Cpp2IlInjected.Address(RVA = "0x63F820", Offset = "0x63E220", VA = "0x18063F820")]
			get
			{
				return challengeType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008116")]
			[Cpp2IlInjected.Address(RVA = "0x63FC00", Offset = "0x63E600", VA = "0x18063FC00")]
			set
			{
				challengeType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001696")]
		[DebuggerNonUserCode]
		public float AmountToSpawn
		{
			[Cpp2IlInjected.Token(Token = "0x6008117")]
			[Cpp2IlInjected.Address(RVA = "0x8239B0", Offset = "0x8223B0", VA = "0x1808239B0")]
			get
			{
				return amountToSpawn_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008118")]
			[Cpp2IlInjected.Address(RVA = "0x824170", Offset = "0x822B70", VA = "0x180824170")]
			set
			{
				amountToSpawn_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001697")]
		[DebuggerNonUserCode]
		public float SpawnRadius
		{
			[Cpp2IlInjected.Token(Token = "0x6008119")]
			[Cpp2IlInjected.Address(RVA = "0x823E70", Offset = "0x822870", VA = "0x180823E70")]
			get
			{
				return spawnRadius_;
			}
			[Cpp2IlInjected.Token(Token = "0x600811A")]
			[Cpp2IlInjected.Address(RVA = "0x824290", Offset = "0x822C90", VA = "0x180824290")]
			set
			{
				spawnRadius_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001698")]
		[DebuggerNonUserCode]
		public float ItemAmount
		{
			[Cpp2IlInjected.Token(Token = "0x600811B")]
			[Cpp2IlInjected.Address(RVA = "0x823CB0", Offset = "0x8226B0", VA = "0x180823CB0")]
			get
			{
				return itemAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x600811C")]
			[Cpp2IlInjected.Address(RVA = "0x824240", Offset = "0x822C40", VA = "0x180824240")]
			set
			{
				itemAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001699")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemFilterWithAmount> ItemFiltersWithAmount
		{
			[Cpp2IlInjected.Token(Token = "0x600811D")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return itemFiltersWithAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700169A")]
		[DebuggerNonUserCode]
		public int MinStarRatingRequired
		{
			[Cpp2IlInjected.Token(Token = "0x600811E")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0")]
			get
			{
				return minStarRatingRequired_;
			}
			[Cpp2IlInjected.Token(Token = "0x600811F")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0")]
			set
			{
				minStarRatingRequired_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700169B")]
		[DebuggerNonUserCode]
		public bool WasSkipped
		{
			[Cpp2IlInjected.Token(Token = "0x6008120")]
			[Cpp2IlInjected.Address(RVA = "0x823F10", Offset = "0x822910", VA = "0x180823F10")]
			get
			{
				return wasSkipped_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008121")]
			[Cpp2IlInjected.Address(RVA = "0x8242B0", Offset = "0x822CB0", VA = "0x1808242B0")]
			set
			{
				wasSkipped_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700169C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x7D"), Cpp2IlInjected.Token(Token = "0x40041F7")]
		private bool Paused
		{
			[Cpp2IlInjected.Token(Token = "0x600812D")]
			[Cpp2IlInjected.Address(RVA = "0x823D90", Offset = "0x822790", VA = "0x180823D90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600812E")]
			[Cpp2IlInjected.Address(RVA = "0x824280", Offset = "0x822C80", VA = "0x180824280")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700169D")]
		public GoBehavior GoBehavior
		{
			[Cpp2IlInjected.Token(Token = "0x600812F")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				int num = goBehaviorInt_;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6008130")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				goBehaviorInt_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700169E")]
		public Item TargetCharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x6008131")]
			[Cpp2IlInjected.Address(RVA = "0x823EB0", Offset = "0x8228B0", VA = "0x180823EB0")]
			get
			{
				long num = Convert.ToInt64((uint)targetCharacterItemID_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6008132")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				//IL_0007: Expected I4, but got O
				targetCharacterItemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700169F")]
		public float ProgressCurrentAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6008133")]
			[Cpp2IlInjected.Address(RVA = "0x823DA0", Offset = "0x8227A0", VA = "0x180823DA0")]
			get
			{
				if (status_ > MissionStepStatus.Ongoing)
				{
				}
				int num = 0;
				float currentAmount = CurrentAmount;
				float val = targetAmount_;
				return Math.Min(currentAmount, val);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A0")]
		public float ProgressTargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6008134")]
			[Cpp2IlInjected.Address(RVA = "0x823E50", Offset = "0x822850", VA = "0x180823E50")]
			get
			{
				return targetAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A1")]
		public float CurrentAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6008135")]
			[Cpp2IlInjected.Address(RVA = "0x823AD0", Offset = "0x8224D0", VA = "0x180823AD0")]
			get
			{
				MapField<string, string> mapField = progressKeys_;
				string currentAmountKey = CurrentAmountKey;
				if (((MapField<TKey, TValue>)(object)mapField).ContainsKey((TKey)currentAmountKey))
				{
					MapField<string, string> mapField2 = progressKeys_;
					string currentAmountKey2 = CurrentAmountKey;
					return float.Parse((string)((MapField<TKey, TValue>)(object)mapField2)[(TKey)currentAmountKey2]);
				}
				int num = 0;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6008136")]
			[Cpp2IlInjected.Address(RVA = "0x824180", Offset = "0x822B80", VA = "0x180824180")]
			private set
			{
				//Discarded unreachable code: IL_0016
				MapField<string, string> mapField = progressKeys_;
				string currentAmountKey = CurrentAmountKey;
				string value2 = default(string);
				((MapField<TKey, TValue>)(object)mapField)[(TKey)currentAmountKey] = (TValue)value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A2")]
		public MissionObjectiveData Data
		{
			[Cpp2IlInjected.Token(Token = "0x600821E")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600821F")]
			[Cpp2IlInjected.Address(RVA = "0x824230", Offset = "0x822C30", VA = "0x180824230")]
			[CompilerGenerated]
			private set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A3")]
		public MissionSlot MissionSlot
		{
			[Cpp2IlInjected.Token(Token = "0x6008220")]
			[Cpp2IlInjected.Address(RVA = "0x823CE0", Offset = "0x8226E0", VA = "0x180823CE0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return MissionSubStep.MissionSlot;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A4")]
		public MissionStep MissionStep
		{
			[Cpp2IlInjected.Token(Token = "0x6008221")]
			[Cpp2IlInjected.Address(RVA = "0x823D10", Offset = "0x822710", VA = "0x180823D10")]
			get
			{
				//Discarded unreachable code: IL_000c
				return MissionSubStep.MissionStep;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A5")]
		public MissionSubStep MissionSubStep
		{
			[Cpp2IlInjected.Token(Token = "0x6008222")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			[CompilerGenerated]
			get
			{
				return _003CMissionSubStep_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6008223")]
			[Cpp2IlInjected.Address(RVA = "0x824270", Offset = "0x822C70", VA = "0x180824270")]
			[CompilerGenerated]
			private set
			{
				_003CMissionSubStep_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A6")]
		private IWorldEventDispatcher WorldDispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x6008224")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			get
			{
				ProfileEventDispatcher dispatcher = Dispatcher;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A7")]
		IMissionIdentifier IMissionIdentifier.IdentifierParent
		{
			[Cpp2IlInjected.Token(Token = "0x6008225")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80", Slot = "15")]
			get
			{
				MissionSubStep missionSubStep = MissionSubStep;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A8")]
		int IMissionIdentifier.IdentifierID
		{
			[Cpp2IlInjected.Token(Token = "0x6008226")]
			[Cpp2IlInjected.Address(RVA = "0x80CE40", Offset = "0x80B840", VA = "0x18080CE40", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_000c
				return Data.objectiveID_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016A9")]
		string IMissionIdentifier.IdentifierName
		{
			[Cpp2IlInjected.Token(Token = "0x6008227")]
			[Cpp2IlInjected.Address(RVA = "0x80CE60", Offset = "0x80B860", VA = "0x18080CE60", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_000c
				return Data.stepName_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016AA")]
		public string FullIdentifierName
		{
			[Cpp2IlInjected.Token(Token = "0x6008228")]
			[Cpp2IlInjected.Address(RVA = "0x8002D0", Offset = "0x7FECD0", VA = "0x1808002D0", Slot = "19")]
			get
			{
				//Discarded unreachable code: IL_0049
				MissionIdentifier._003CEnumerateSelfAndParents_003Ed__2 _003CEnumerateSelfAndParents_003Ed__ = new MissionIdentifier._003CEnumerateSelfAndParents_003Ed__2(-2);
				_003CEnumerateSelfAndParents_003Ed__._003C_003E3__value = this;
				IEnumerable<IMissionIdentifier> enumerable = (IEnumerable<IMissionIdentifier>)Enumerable.Reverse<IMissionIdentifier>((IEnumerable<>)(object)_003CEnumerateSelfAndParents_003Ed__);
				Func<IMissionIdentifier, string> _003C_003E9__1_ = MissionIdentifier._003C_003Ec._003C_003E9__1_0;
				if (_003C_003E9__1_ == null)
				{
					MissionIdentifier._003C_003Ec._003C_003E9 = (MissionIdentifier._003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new NullReferenceException();
					};
				}
				IEnumerable<IMissionIdentifier> enumerable2 = (IEnumerable<IMissionIdentifier>)Enumerable.Select<IMissionIdentifier, string>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__1_);
				return string.Join("!", (IEnumerable<>)enumerable2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016AB")]
		public string FullIdentifierID
		{
			[Cpp2IlInjected.Token(Token = "0x6008229")]
			[Cpp2IlInjected.Address(RVA = "0x8000F0", Offset = "0x7FEAF0", VA = "0x1808000F0", Slot = "18")]
			get
			{
				//Discarded unreachable code: IL_0049
				MissionIdentifier._003CEnumerateSelfAndParents_003Ed__2 _003CEnumerateSelfAndParents_003Ed__ = new MissionIdentifier._003CEnumerateSelfAndParents_003Ed__2(-2);
				_003CEnumerateSelfAndParents_003Ed__._003C_003E3__value = this;
				IEnumerable<IMissionIdentifier> enumerable = (IEnumerable<IMissionIdentifier>)Enumerable.Reverse<IMissionIdentifier>((IEnumerable<>)(object)_003CEnumerateSelfAndParents_003Ed__);
				Func<IMissionIdentifier, int> _003C_003E9__0_ = MissionIdentifier._003C_003Ec._003C_003E9__0_0;
				if (_003C_003E9__0_ == null)
				{
					MissionIdentifier._003C_003Ec._003C_003E9 = (MissionIdentifier._003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new NullReferenceException();
					};
				}
				IEnumerable<IMissionIdentifier> enumerable2 = (IEnumerable<IMissionIdentifier>)Enumerable.Select<IMissionIdentifier, int>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__0_);
				return string.Join<int>("!", (IEnumerable<>)enumerable2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016AC")]
		public int TargetAmountInt
		{
			[Cpp2IlInjected.Token(Token = "0x600822A")]
			[Cpp2IlInjected.Address(RVA = "0x823E80", Offset = "0x822880", VA = "0x180823E80")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016AD")]
		public bool AutoConfirmOnCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x6008235")]
			[Cpp2IlInjected.Address(RVA = "0x8239C0", Offset = "0x8223C0", VA = "0x1808239C0")]
			get
			{
				//Discarded unreachable code: IL_00a5
				bool flag = default(bool);
				while (true)
				{
					MissionObjectiveData missionObjectiveData = Data;
					MissionObjectiveData.CustomStepOneofCase customStepCase_ = missionObjectiveData.customStepCase_;
					if (customStepCase_ > MissionObjectiveData.CustomStepOneofCase.FollowCharacter)
					{
						if (customStepCase_ > MissionObjectiveData.CustomStepOneofCase.PlaceBuilding)
						{
							switch (customStepCase_)
							{
							case MissionObjectiveData.CustomStepOneofCase.Possess:
								return missionObjectiveData.Possess.autoConfirm_;
							case MissionObjectiveData.CustomStepOneofCase.VisitArea:
								return missionObjectiveData.VisitArea.autoConfirm_;
							}
						}
						else
						{
							if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.MakeGarden)
							{
								return missionObjectiveData.MakeGarden.autoConfirm_;
							}
							if (flag)
							{
								goto IL_0072;
							}
						}
						return true;
					}
					if (customStepCase_ <= MissionObjectiveData.CustomStepOneofCase.Decorate)
					{
						break;
					}
					if (customStepCase_ != MissionObjectiveData.CustomStepOneofCase.DressUp)
					{
						continue;
					}
					goto IL_0072;
					IL_0072:
					if (0 == 175)
					{
						return missionObjectiveData.FollowCharacter.AutoConfirm;
					}
				}
				bool flag2 = default(bool);
				CustomStepConditional customStepConditional = default(CustomStepConditional);
				if (flag2)
				{
					return customStepConditional.autoConfirm_;
				}
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
				CustomStepDecorate customStepDecorate = default(CustomStepDecorate);
				return customStepDecorate.autoConfirm_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000AC")]
		internal event StepCompletionChangedDelegate StepCompletionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600821A")]
			[Cpp2IlInjected.Address(RVA = "0x823870", Offset = "0x822270", VA = "0x180823870")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600821B")]
			[Cpp2IlInjected.Address(RVA = "0x824030", Offset = "0x822A30", VA = "0x180824030")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000AD")]
		internal event StepStatusChangedDelegate StepStatusChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600821C")]
			[Cpp2IlInjected.Address(RVA = "0x823910", Offset = "0x822310", VA = "0x180823910")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600821D")]
			[Cpp2IlInjected.Address(RVA = "0x8240D0", Offset = "0x822AD0", VA = "0x1808240D0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60080FE")]
		[Cpp2IlInjected.Address(RVA = "0x8236E0", Offset = "0x8220E0", VA = "0x1808236E0")]
		[DebuggerNonUserCode]
		public MissionObjective()
		{
			MapField<string, string> mapField = (progressKeys_ = (MapField<string, string>)(object)new MapField<TKey, TValue>());
			RepeatedField<int> repeatedField = (itemIdsCollected_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<Types.GridObjectInfo> repeatedField2 = (gridObjectIdsCollected_ = (RepeatedField<Types.GridObjectInfo>)(object)new RepeatedField<T>());
			RepeatedField<ItemFilterWithAmount> repeatedField3 = (itemFiltersWithAmount_ = (RepeatedField<ItemFilterWithAmount>)(object)new RepeatedField<T>());
			StopTalkToCharacter();
			ItemFilter itemFilter = (itemFilter_ = new ItemFilter());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60080FF")]
		[Cpp2IlInjected.Address(RVA = "0x80D7C0", Offset = "0x80C1C0", VA = "0x18080D7C0")]
		private void OnConstruction()
		{
			ItemFilter itemFilter = (itemFilter_ = new ItemFilter());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008100")]
		[Cpp2IlInjected.Address(RVA = "0x823230", Offset = "0x821C30", VA = "0x180823230")]
		[DebuggerNonUserCode]
		public MissionObjective(MissionObjective other)
		{
			//IL_006a: Expected O, but got I4
			MapField<string, string> mapField = (progressKeys_ = (MapField<string, string>)(object)new MapField<TKey, TValue>());
			RepeatedField<int> repeatedField = (itemIdsCollected_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<Types.GridObjectInfo> repeatedField2 = (gridObjectIdsCollected_ = (RepeatedField<Types.GridObjectInfo>)(object)new RepeatedField<T>());
			RepeatedField<ItemFilterWithAmount> repeatedField3 = (itemFiltersWithAmount_ = (RepeatedField<ItemFilterWithAmount>)(object)new RepeatedField<T>());
			StopTalkToCharacter();
			ItemFilter itemFilter = (itemFilter_ = new ItemFilter());
			ItemFilter itemFilter2 = other.itemFilter_;
			if (itemFilter2 != null)
			{
				ItemFilter itemFilter3 = itemFilter2.Clone();
			}
			int num = 0;
			itemFilter_ = (ItemFilter)num;
			float num2 = (targetAmount_ = other.targetAmount_);
			MapField<string, string> mapField2 = (progressKeys_ = (MapField<string, string>)(object)((MapField<TKey, TValue>)(object)other.progressKeys_).Clone());
			MissionStepStatus missionStepStatus = (status_ = other.status_);
			int num3 = (goBehaviorInt_ = other.goBehaviorInt_);
			MissionStepType missionStepType = (stepType_ = other.stepType_);
			float num4 = (minWeightRequired_ = other.minWeightRequired_);
			float num5 = (maxWeightRequired_ = other.maxWeightRequired_);
			RepeatedField<int> repeatedField4 = (itemIdsCollected_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.itemIdsCollected_).Clone());
			RepeatedField<Types.GridObjectInfo> repeatedField5 = (gridObjectIdsCollected_ = (RepeatedField<Types.GridObjectInfo>)(object)((RepeatedField<T>)(object)other.gridObjectIdsCollected_).Clone());
			int num6 = (targetCharacterItemID_ = other.targetCharacterItemID_);
			ChallengeType challengeType = (challengeType_ = other.challengeType_);
			float num7 = (amountToSpawn_ = other.amountToSpawn_);
			float num8 = (spawnRadius_ = other.spawnRadius_);
			float num9 = (itemAmount_ = other.itemAmount_);
			RepeatedField<ItemFilterWithAmount> repeatedField6 = (itemFiltersWithAmount_ = (RepeatedField<ItemFilterWithAmount>)(object)((RepeatedField<T>)(object)other.itemFiltersWithAmount_).Clone());
			int num10 = (minStarRatingRequired_ = other.minStarRatingRequired_);
			bool flag = (wasSkipped_ = other.wasSkipped_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008101")]
		[Cpp2IlInjected.Address(RVA = "0x803D40", Offset = "0x802740", VA = "0x180803D40", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionObjective Clone()
		{
			return new MissionObjective(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008122")]
		[Cpp2IlInjected.Address(RVA = "0x805BB0", Offset = "0x8045B0", VA = "0x180805BB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008123")]
		[Cpp2IlInjected.Address(RVA = "0x805820", Offset = "0x804220", VA = "0x180805820", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionObjective other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemFilter objB = other.itemFilter_;
				if (object.Equals(itemFilter_, objB))
				{
					MapField<string, string> mapField = progressKeys_;
					MapField<string, string> mapField2 = other.progressKeys_;
					if (((MapField<TKey, TValue>)(object)mapField).Equals((MapField<, >)(object)mapField2))
					{
						MissionStepStatus missionStepStatus = other.status_;
						if (status_ == missionStepStatus)
						{
							int num = other.goBehaviorInt_;
							if (goBehaviorInt_ == num)
							{
								MissionStepType missionStepType = other.stepType_;
								if (stepType_ == missionStepType)
								{
									RepeatedField<int> repeatedField = itemIdsCollected_;
									RepeatedField<int> repeatedField2 = other.itemIdsCollected_;
									if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
									{
										RepeatedField<Types.GridObjectInfo> repeatedField3 = gridObjectIdsCollected_;
										RepeatedField<Types.GridObjectInfo> repeatedField4 = other.gridObjectIdsCollected_;
										if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
										{
											int num2 = other.targetCharacterItemID_;
											if (targetCharacterItemID_ == num2)
											{
												ChallengeType challengeType = other.challengeType_;
												if (challengeType_ == challengeType)
												{
													RepeatedField<ItemFilterWithAmount> repeatedField5 = itemFiltersWithAmount_;
													RepeatedField<ItemFilterWithAmount> repeatedField6 = other.itemFiltersWithAmount_;
													if (((RepeatedField<T>)(object)repeatedField5).Equals((RepeatedField<>)(object)repeatedField6))
													{
														int num3 = other.minStarRatingRequired_;
														if (minStarRatingRequired_ == num3)
														{
															bool flag = other.wasSkipped_;
															if (wasSkipped_ == flag)
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
					}
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008124")]
		[Cpp2IlInjected.Address(RVA = "0x806DB0", Offset = "0x8057B0", VA = "0x180806DB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0127
			//IL_0062: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_00bf: Expected O, but got I4
			//IL_00d6: Expected O, but got I4
			//IL_00e9: Expected O, but got I4
			ItemFilter itemFilter = itemFilter_;
			int num = 0;
			if (itemFilter != null)
			{
				int hashCode = itemFilter.GetHashCode();
			}
			if (itemFilter != null)
			{
				EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
			}
			int hashCode2 = ((MapField<TKey, TValue>)(object)progressKeys_).GetHashCode();
			if (status_ != 0)
			{
			}
			if (goBehaviorInt_ != 0)
			{
			}
			MissionStepType missionStepType = stepType_;
			int num2 = default(int);
			if (missionStepType != 0)
			{
				num2 = 0;
			}
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField2 = default(EqualityComparer<float>);
			if (missionStepType != 0)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField2 = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode3 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField2).GetHashCode((T)num2);
			}
			if (_003CBitwiseSingleEqualityComparer_003Ek__BackingField2 != null)
			{
				int hashCode4 = ((EqualityComparer<T>)(object)ProtobufEqualityComparers.BitwiseSingleEqualityComparer).GetHashCode((T)num2);
			}
			int hashCode5 = ((RepeatedField<T>)(object)itemIdsCollected_).GetHashCode();
			int hashCode6 = ((RepeatedField<T>)(object)gridObjectIdsCollected_).GetHashCode();
			if (targetCharacterItemID_ != 0)
			{
			}
			ChallengeType challengeType = challengeType_;
			int num3 = default(int);
			if (challengeType != 0)
			{
				num3 = 0;
			}
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField3 = default(EqualityComparer<float>);
			if (challengeType != 0)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField3 = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode7 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField3).GetHashCode((T)num3);
			}
			EqualityComparer<float> _003CBitwiseSingleEqualityComparer_003Ek__BackingField4 = default(EqualityComparer<float>);
			if (_003CBitwiseSingleEqualityComparer_003Ek__BackingField3 != null)
			{
				_003CBitwiseSingleEqualityComparer_003Ek__BackingField4 = ProtobufEqualityComparers.BitwiseSingleEqualityComparer;
				int hashCode8 = ((EqualityComparer<T>)(object)_003CBitwiseSingleEqualityComparer_003Ek__BackingField4).GetHashCode((T)num3);
			}
			if (_003CBitwiseSingleEqualityComparer_003Ek__BackingField4 != null)
			{
				int hashCode9 = ((EqualityComparer<T>)(object)ProtobufEqualityComparers.BitwiseSingleEqualityComparer).GetHashCode((T)num3);
			}
			int hashCode10 = ((RepeatedField<T>)(object)itemFiltersWithAmount_).GetHashCode();
			if (minStarRatingRequired_ != 0)
			{
			}
			if (wasSkipped_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode11 = unknownFields.GetHashCode();
			}
			return hashCode6;
		}

		[Cpp2IlInjected.Token(Token = "0x6008125")]
		[Cpp2IlInjected.Address(RVA = "0x820700", Offset = "0x81F100", VA = "0x180820700", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008126")]
		[Cpp2IlInjected.Address(RVA = "0x822A40", Offset = "0x821440", VA = "0x180822A40", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0184
			if ((long)itemFilter_ != 0)
			{
				ItemFilter value = itemFilter_;
				output.WriteMessage(value);
			}
			if (output != null)
			{
				float value2 = targetAmount_;
				output.WriteFloat(value2);
			}
			MapField<string, string> mapField = progressKeys_;
			MapField<string, string>.Codec map_progressKeys_codec = _map_progressKeys_codec;
			((MapField<TKey, TValue>)(object)mapField).WriteTo(output, (MapField<, >.Codec)(object)map_progressKeys_codec);
			if (status_ != 0)
			{
			}
			if (goBehaviorInt_ != 0)
			{
				int value3 = goBehaviorInt_;
				output.WriteInt32(value3);
			}
			if (stepType_ != 0)
			{
			}
			if (output != null)
			{
				float value4 = minWeightRequired_;
				output.WriteFloat(value4);
			}
			if (output != null)
			{
				float value5 = maxWeightRequired_;
				output.WriteFloat(value5);
			}
			RepeatedField<int> repeatedField = itemIdsCollected_;
			FieldCodec<int> repeated_itemIdsCollected_codec = _repeated_itemIdsCollected_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_itemIdsCollected_codec);
			RepeatedField<Types.GridObjectInfo> repeatedField2 = gridObjectIdsCollected_;
			FieldCodec<Types.GridObjectInfo> repeated_gridObjectIdsCollected_codec = _repeated_gridObjectIdsCollected_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_gridObjectIdsCollected_codec);
			if (targetCharacterItemID_ != 0)
			{
				int value6 = targetCharacterItemID_;
				output.WriteInt32(value6);
			}
			if (challengeType_ != 0)
			{
			}
			if (output != null)
			{
				float value7 = amountToSpawn_;
				output.WriteFloat(value7);
			}
			if (output != null)
			{
				float value8 = spawnRadius_;
				output.WriteFloat(value8);
			}
			if (output != null)
			{
				float value9 = itemAmount_;
				output.WriteFloat(value9);
			}
			RepeatedField<ItemFilterWithAmount> repeatedField3 = itemFiltersWithAmount_;
			FieldCodec<ItemFilterWithAmount> repeated_itemFiltersWithAmount_codec = _repeated_itemFiltersWithAmount_codec;
			((RepeatedField<T>)(object)repeatedField3).WriteTo(output, (FieldCodec<>)(object)repeated_itemFiltersWithAmount_codec);
			if (minStarRatingRequired_ != 0)
			{
				int value10 = minStarRatingRequired_;
				output.WriteInt32(value10);
			}
			if (wasSkipped_)
			{
				bool value11 = wasSkipped_;
				output.WriteBool(value11);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008127")]
		[Cpp2IlInjected.Address(RVA = "0x802350", Offset = "0x800D50", VA = "0x180802350", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_017f
			ItemFilter itemFilter = itemFilter_;
			int num = 0;
			if (itemFilter != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(itemFilter);
			}
			num += 5;
			MapField<string, string> mapField = progressKeys_;
			MapField<string, string>.Codec map_progressKeys_codec = _map_progressKeys_codec;
			int num3 = ((MapField<TKey, TValue>)(object)mapField).CalculateSize((MapField<, >.Codec)(object)map_progressKeys_codec);
			MissionStepStatus missionStepStatus = status_;
			num += num3;
			if (missionStepStatus != 0)
			{
				int num4 = CodedOutputStream.ComputeEnumSize((int)missionStepStatus);
				num4++;
				num += num4;
			}
			int num5 = goBehaviorInt_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				num += num6;
			}
			MissionStepType missionStepType = stepType_;
			if (missionStepType != 0)
			{
				int num7 = CodedOutputStream.ComputeEnumSize((int)missionStepType);
				num7++;
				num += num7;
			}
			num += 5;
			num += 5;
			RepeatedField<int> repeatedField = itemIdsCollected_;
			FieldCodec<int> repeated_itemIdsCollected_codec = _repeated_itemIdsCollected_codec;
			int num8 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_itemIdsCollected_codec);
			RepeatedField<Types.GridObjectInfo> repeatedField2 = gridObjectIdsCollected_;
			FieldCodec<Types.GridObjectInfo> repeated_gridObjectIdsCollected_codec = _repeated_gridObjectIdsCollected_codec;
			int num9 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_gridObjectIdsCollected_codec);
			int num10 = targetCharacterItemID_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num += num11;
			}
			ChallengeType challengeType = challengeType_;
			if (challengeType != 0)
			{
				int num12 = CodedOutputStream.ComputeEnumSize((int)challengeType);
				num12++;
				num += num12;
			}
			num += 5;
			num += 5;
			num += 6;
			RepeatedField<ItemFilterWithAmount> repeatedField3 = itemFiltersWithAmount_;
			FieldCodec<ItemFilterWithAmount> repeated_itemFiltersWithAmount_codec = _repeated_itemFiltersWithAmount_codec;
			int num13 = ((RepeatedField<T>)(object)repeatedField3).CalculateSize((FieldCodec<>)(object)repeated_itemFiltersWithAmount_codec);
			int num14 = minStarRatingRequired_;
			num += num13;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeInt32Size(num14);
				num15 += 2;
				num += num15;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num16 = unknownFields.CalculateSize();
				num += num16;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6008128")]
		[Cpp2IlInjected.Address(RVA = "0x80CC10", Offset = "0x80B610", VA = "0x18080CC10", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionObjective other)
		{
			//Discarded unreachable code: IL_01ca
			if (other == null)
			{
				return;
			}
			ItemFilter itemFilter = default(ItemFilter);
			if ((long)other.itemFilter_ != 0)
			{
				itemFilter = itemFilter_;
				if (itemFilter == null)
				{
					ItemFilter itemFilter2 = (itemFilter_ = new ItemFilter());
				}
				ItemFilter other2 = other.itemFilter_;
				itemFilter.MergeFrom(other2);
			}
			float num = other.targetAmount_;
			if (itemFilter != null)
			{
				targetAmount_ = num;
			}
			MapField<string, string> mapField = progressKeys_;
			MapField<string, string> mapField2 = other.progressKeys_;
			((MapField<TKey, TValue>)(object)mapField).Add((IDictionary<, >)(object)mapField2);
			MissionStepStatus missionStepStatus = other.status_;
			if (missionStepStatus != 0)
			{
				status_ = missionStepStatus;
			}
			int num2 = other.goBehaviorInt_;
			if (num2 != 0)
			{
				goBehaviorInt_ = num2;
			}
			MissionStepType missionStepType = other.stepType_;
			if (missionStepType != 0)
			{
				stepType_ = missionStepType;
			}
			float num3 = other.minWeightRequired_;
			if (missionStepType != 0)
			{
				minWeightRequired_ = num3;
			}
			float num4 = other.maxWeightRequired_;
			if (missionStepType != 0)
			{
				maxWeightRequired_ = num4;
			}
			RepeatedField<int> repeatedField = itemIdsCollected_;
			RepeatedField<int> repeatedField2 = other.itemIdsCollected_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			RepeatedField<Types.GridObjectInfo> repeatedField3 = gridObjectIdsCollected_;
			RepeatedField<Types.GridObjectInfo> repeatedField4 = other.gridObjectIdsCollected_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			int num5 = other.targetCharacterItemID_;
			if (num5 != 0)
			{
				targetCharacterItemID_ = num5;
			}
			ChallengeType challengeType = other.challengeType_;
			if (challengeType != 0)
			{
				challengeType_ = challengeType;
			}
			float num6 = other.amountToSpawn_;
			if (challengeType != 0)
			{
				amountToSpawn_ = num6;
			}
			float num7 = other.spawnRadius_;
			if (challengeType != 0)
			{
				spawnRadius_ = num7;
			}
			float num8 = other.itemAmount_;
			if (challengeType != 0)
			{
				itemAmount_ = num8;
			}
			RepeatedField<ItemFilterWithAmount> repeatedField5 = itemFiltersWithAmount_;
			RepeatedField<ItemFilterWithAmount> repeatedField6 = other.itemFiltersWithAmount_;
			((RepeatedField<T>)(object)repeatedField5).Add((IEnumerable<>)(object)repeatedField6);
			int num9 = other.minStarRatingRequired_;
			if (num9 != 0)
			{
				minStarRatingRequired_ = num9;
			}
			bool flag = other.wasSkipped_;
			if (flag)
			{
				wasSkipped_ = flag;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6008129")]
		[Cpp2IlInjected.Address(RVA = "0x80C7E0", Offset = "0x80B1E0", VA = "0x18080C7E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0243
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 80)
			{
				if ((int)num > 117)
				{
					if ((int)num > 133)
					{
						if (num == 138)
						{
							RepeatedField<ItemFilterWithAmount> repeatedField = itemFiltersWithAmount_;
							FieldCodec<ItemFilterWithAmount> repeated_itemFiltersWithAmount_codec = _repeated_itemFiltersWithAmount_codec;
							((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemFiltersWithAmount_codec);
						}
						int num2 = default(int);
						if (num == 144)
						{
							num2 = (minStarRatingRequired_ = input.ReadInt32());
						}
						if (num2 != 200)
						{
							goto IL_022c;
						}
						bool flag = (wasSkipped_ = input.ReadBool());
					}
					if (num == 125)
					{
						float num3 = (spawnRadius_ = input.ReadFloat());
					}
					if (num != 133)
					{
						goto IL_022c;
					}
					float num4 = (itemAmount_ = input.ReadFloat());
				}
				int num6 = default(int);
				if ((int)num > 90)
				{
					int num5 = default(int);
					if (num == 96)
					{
						num5 = (targetCharacterItemID_ = input.ReadInt32());
					}
					if (num5 == 104)
					{
						num6 = (int)(challengeType_ = (ChallengeType)input.ReadInt32());
					}
					if (num6 != 117)
					{
						goto IL_022c;
					}
					float num7 = (amountToSpawn_ = input.ReadFloat());
				}
				if (num6 == 82)
				{
					goto IL_0163;
				}
				if (num6 != 90)
				{
					goto IL_022c;
				}
				RepeatedField<Types.GridObjectInfo> repeatedField2 = gridObjectIdsCollected_;
				FieldCodec<Types.GridObjectInfo> repeated_gridObjectIdsCollected_codec = _repeated_gridObjectIdsCollected_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_gridObjectIdsCollected_codec);
			}
			if ((int)num <= 32)
			{
				goto IL_01ab;
			}
			if ((int)num <= 48)
			{
				goto IL_017c;
			}
			if (num == 69)
			{
				float num8 = (minWeightRequired_ = input.ReadFloat());
			}
			if (num == 77)
			{
				float num9 = (maxWeightRequired_ = input.ReadFloat());
			}
			if (num == 80)
			{
				goto IL_0163;
			}
			goto IL_022c;
			IL_017c:
			int num10 = default(int);
			if (num == 40)
			{
				num10 = (goBehaviorInt_ = input.ReadInt32());
			}
			int num11 = default(int);
			if (num10 == 48)
			{
				num11 = (int)(stepType_ = (MissionStepType)input.ReadInt32());
				goto IL_01ab;
			}
			goto IL_022c;
			IL_01ab:
			int num12 = default(int);
			if (num11 > 21)
			{
				if (num11 == 26)
				{
					MapField<string, string> mapField = progressKeys_;
					MapField<string, string>.Codec map_progressKeys_codec = _map_progressKeys_codec;
					((MapField<TKey, TValue>)(object)mapField).AddEntriesFrom(input, (MapField<, >.Codec)(object)map_progressKeys_codec);
				}
				if (num11 != 32)
				{
					goto IL_022c;
				}
				num12 = (int)(status_ = (MissionStepStatus)input.ReadInt32());
			}
			ItemFilter itemFilter = default(ItemFilter);
			if (num12 == 10)
			{
				ItemFilter builder = default(ItemFilter);
				if (itemFilter_ == null)
				{
					itemFilter = (itemFilter_ = new ItemFilter());
					builder = itemFilter_;
				}
				input.ReadMessage(builder);
			}
			if ((long)itemFilter == 21)
			{
				float num13 = (targetAmount_ = input.ReadFloat());
			}
			goto IL_022c;
			IL_0163:
			RepeatedField<int> repeatedField3 = itemIdsCollected_;
			FieldCodec<int> repeated_itemIdsCollected_codec = _repeated_itemIdsCollected_codec;
			((RepeatedField<T>)(object)repeatedField3).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_itemIdsCollected_codec);
			goto IL_017c;
			IL_022c:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600812A")]
		[Cpp2IlInjected.Address(RVA = "0x806A90", Offset = "0x805490", VA = "0x180806A90", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 24)
			{
				ItemFilter itemFilter = itemFilter_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600812B")]
		[Cpp2IlInjected.Address(RVA = "0x815500", Offset = "0x813F00", VA = "0x180815500", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_001f, IL_0020, IL_0021, IL_0022, IL_0023, IL_0024, IL_0025, IL_0026
			//IL_0018: Expected O, but got I4
			if (fieldNumber - 1 <= 24)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				itemFilter_ = (ItemFilter)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600812C")]
		[Cpp2IlInjected.Address(RVA = "0x803B10", Offset = "0x802510", VA = "0x180803B10", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0008, IL_0009, IL_000a, IL_000b, IL_000c, IL_000d, IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0014
			if (fieldNumber - 1 > 24)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008137")]
		[Cpp2IlInjected.Address(RVA = "0x80A930", Offset = "0x809330", VA = "0x18080A930")]
		private unsafe float IncCurrentAmount(float delta)
		{
			float currentAmount = CurrentAmount;
			int num = 0;
			return SetCurrentAmount(delta, out *(float*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6008138")]
		[Cpp2IlInjected.Address(RVA = "0x80A980", Offset = "0x809380", VA = "0x18080A980")]
		private unsafe float IncCurrentAmount(float delta, out float previousValue)
		{
			float currentAmount = CurrentAmount;
			previousValue.m_value = delta;
			int num = 0;
			return SetCurrentAmount(delta, out *(float*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6008139")]
		[Cpp2IlInjected.Address(RVA = "0x815340", Offset = "0x813D40", VA = "0x180815340")]
		private unsafe float SetCurrentAmount(float value)
		{
			int num = 0;
			return SetCurrentAmount(value, out *(float*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600813A")]
		[Cpp2IlInjected.Address(RVA = "0x815140", Offset = "0x813B40", VA = "0x180815140")]
		private unsafe int SetCurrentAmountInt(int value, out int previousValue)
		{
			//IL_000a: Expected F4, but got I4
			int num = 0;
			float num2 = SetCurrentAmount(value, out *(float*)num);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600813B")]
		[Cpp2IlInjected.Address(RVA = "0x815180", Offset = "0x813B80", VA = "0x180815180")]
		private float SetCurrentAmount(float value, out float previousValue)
		{
			//IL_0002: Invalid comparison between I4 and F4
			if (!(0f <= value))
			{
			}
			if (!((previousValue.m_value = CurrentAmount) > float.Epsilon))
			{
			}
			MissionSlot missionSlot = default(MissionSlot);
			MissionSlotClass class_ = missionSlot.class_;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			int num3 = (int)class_;
			num3 += num3;
			num += 1096;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600813C")]
		[Cpp2IlInjected.Address(RVA = "0x815360", Offset = "0x813D60", VA = "0x180815360")]
		private bool SetCurrentProgression(int newAmount, bool canChangeState = true)
		{
			//IL_0017: Expected O, but got I4
			//IL_0017: Expected O, but got I4
			//IL_0017: Expected F4, but got I4
			int num = 0;
			float currentAmount = CurrentAmount;
			int num2 = 0;
			int num3 = 0;
			return UpdateCurrentProgression(num, canChangeState, (IGrid)num2, (GridObject)num3);
		}

		[Cpp2IlInjected.Token(Token = "0x600813D")]
		[Cpp2IlInjected.Address(RVA = "0x822140", Offset = "0x820B40", VA = "0x180822140")]
		private bool UpdateCurrentProgression(float amountToAdd, bool canChangeState = true, [System.Runtime.InteropServices.Optional] IGrid uniqueGrid, [System.Runtime.InteropServices.Optional] GridObject uniqueGridObject)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600813E")]
		[Cpp2IlInjected.Address(RVA = "0x822200", Offset = "0x820C00", VA = "0x180822200")]
		private bool UpdateCurrentProgression(Item item, float amountToAdd, bool canChangeState = true, bool mustUseDifferentItem = false, [System.Runtime.InteropServices.Optional] IGrid uniqueGrid, [System.Runtime.InteropServices.Optional] GridObject uniqueGridObject)
		{
			//Discarded unreachable code: IL_00aa
			//IL_000b: Invalid comparison between F4 and I4
			//IL_000f: Invalid comparison between I4 and F4
			//IL_0026: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			//IL_0082: Expected I4, but got O
			int num = 0;
			int itemID = item.ItemID;
			if (!(amountToAdd > (float)num))
			{
				if (!((float)num <= amountToAdd))
				{
					int num2 = 0;
					bool flag = default(bool);
					if (!flag)
					{
						goto IL_00a0;
					}
					bool flag2 = ((RepeatedField<T>)(object)itemIdsCollected_).Remove((T)itemID);
					bool flag3 = default(bool);
					if (flag3)
					{
						bool flag4 = ((RepeatedField<T>)(object)gridObjectIdsCollected_).Remove((T)num2);
					}
				}
				float currentAmount = CurrentAmount;
				float num3 = default(float);
				if (num3 >= targetAmount_)
				{
					goto IL_0093;
				}
				if (canChangeState)
				{
					bool flag5 = ChangeStatus(MissionStepStatus.Ongoing);
				}
			}
			int num4 = 0;
			bool flag6 = default(bool);
			if (!flag6)
			{
				bool flag7 = default(bool);
				while (flag7)
				{
				}
				RepeatedField<Types.GridObjectInfo> repeatedField = gridObjectIdsCollected_;
				Types.GridObjectInfo gridObjectInfo = new Types.GridObjectInfo();
				gridObjectInfo.gridId_ = (uint)(int)typeof(IGrid).TypeHandle;
				gridObjectInfo.gridObjectId_ = 0u;
				((RepeatedField<T>)(object)repeatedField).Add((T)gridObjectInfo);
				goto IL_0093;
			}
			goto IL_00a0;
			IL_00a0:
			float currentAmount2 = CurrentAmount;
			return true;
			IL_0093:
			if (canChangeState)
			{
				bool flag8 = ChangeStatus(MissionStepStatus.Completed);
			}
			goto IL_00a0;
		}

		[Cpp2IlInjected.Token(Token = "0x600813F")]
		[Cpp2IlInjected.Address(RVA = "0x800D60", Offset = "0x7FF760", VA = "0x180800D60")]
		internal bool AddItemCollected(Item item)
		{
			bool flag = default(bool);
			if (flag)
			{
				RepeatedField<int> repeatedField = itemIdsCollected_;
				bool flag2 = default(bool);
				if (!flag2)
				{
					RepeatedField<int> repeatedField2 = itemIdsCollected_;
					return true;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008140")]
		[Cpp2IlInjected.Address(RVA = "0x811640", Offset = "0x810040", VA = "0x180811640")]
		internal bool RemoveItemCollected(Item item)
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected O, but got I4
			int itemID = item.ItemID;
			return ((RepeatedField<T>)(object)itemIdsCollected_).Remove((T)itemID);
		}

		[Cpp2IlInjected.Token(Token = "0x6008141")]
		[Cpp2IlInjected.Address(RVA = "0x811A10", Offset = "0x810410", VA = "0x180811A10")]
		internal void ResetItemCollected()
		{
			//Discarded unreachable code: IL_000c
			((RepeatedField<T>)(object)itemIdsCollected_).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6008142")]
		[Cpp2IlInjected.Address(RVA = "0x800E70", Offset = "0x7FF870", VA = "0x180800E70")]
		public bool AnyItemCollected()
		{
			return Enumerable.Any<int>((IEnumerable<>)(object)itemIdsCollected_);
		}

		[Cpp2IlInjected.Token(Token = "0x6008143")]
		[Cpp2IlInjected.Address(RVA = "0x800B60", Offset = "0x7FF560", VA = "0x180800B60")]
		internal bool AddGridObjectCollected(IGrid grid, GridObject gridObject)
		{
			//IL_0032: Expected I4, but got O
			if (grid != null && gridObject != null)
			{
				uint iD_ = gridObject.iD_;
				int num = 0;
				bool flag = default(bool);
				if (flag)
				{
					int num2 = 0;
				}
				RepeatedField<Types.GridObjectInfo> repeatedField = gridObjectIdsCollected_;
				Types.GridObjectInfo gridObjectInfo = new Types.GridObjectInfo();
				gridObjectInfo.gridId_ = (uint)(int)typeof(IGrid).TypeHandle;
				gridObjectInfo.gridObjectId_ = iD_;
				((RepeatedField<T>)(object)repeatedField).Add((T)gridObjectInfo);
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008144")]
		[Cpp2IlInjected.Address(RVA = "0x800C80", Offset = "0x7FF680", VA = "0x180800C80")]
		private unsafe bool AddGridObjectCollected(uint gridId, uint gridObjectId)
		{
			//Discarded unreachable code: IL_0034
			int num = 0;
			if (TryGetGridObjectCollected(gridId, gridObjectId, out *(Types.GridObjectInfo*)num))
			{
				int num2 = 0;
			}
			RepeatedField<Types.GridObjectInfo> repeatedField = gridObjectIdsCollected_;
			Types.GridObjectInfo gridObjectInfo = new Types.GridObjectInfo();
			gridObjectInfo.gridId_ = gridId;
			gridObjectInfo.gridObjectId_ = gridObjectId;
			((RepeatedField<T>)(object)repeatedField).Add((T)gridObjectInfo);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6008145")]
		[Cpp2IlInjected.Address(RVA = "0x811560", Offset = "0x80FF60", VA = "0x180811560")]
		internal bool RemoveGridObjectCollected(IGrid grid, GridObject gridObject)
		{
			//IL_001a: Expected O, but got I4
			if (grid != null && gridObject != null)
			{
				int num = 0;
				bool flag = default(bool);
				if (flag)
				{
					return ((RepeatedField<T>)(object)gridObjectIdsCollected_).Remove((T)num);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008146")]
		[Cpp2IlInjected.Address(RVA = "0x8114C0", Offset = "0x80FEC0", VA = "0x1808114C0")]
		private unsafe bool RemoveGridObjectCollected(uint gridId, uint gridObjectId)
		{
			//Discarded unreachable code: IL_001f
			//IL_001e: Expected O, but got I4
			int num = 0;
			bool flag = TryGetGridObjectCollected(gridId, gridObjectId, out *(Types.GridObjectInfo*)num);
			if (!flag)
			{
				return flag;
			}
			return ((RepeatedField<T>)(object)gridObjectIdsCollected_).Remove((T)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6008147")]
		[Cpp2IlInjected.Address(RVA = "0x80C020", Offset = "0x80AA20", VA = "0x18080C020")]
		internal bool IsGridObjectCollected(IGrid grid, GridObject gridObject)
		{
			bool result = default(bool);
			if (grid != null && gridObject != null)
			{
				return result;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008148")]
		[Cpp2IlInjected.Address(RVA = "0x820B20", Offset = "0x81F520", VA = "0x180820B20")]
		private bool TryGetGridObjectCollected(uint gridId, uint gridObjectId, out Types.GridObjectInfo info)
		{
			RepeatedField<Types.GridObjectInfo> repeatedField = gridObjectIdsCollected_;
			Predicate<Types.GridObjectInfo> predicate = (Predicate<Types.GridObjectInfo>)(object)(Predicate<T>)delegate(Types.GridObjectInfo x)
			{
				//Discarded unreachable code: IL_0023
				uint num = gridId;
				if (x.gridId_ != num)
				{
					int num2 = 0;
				}
				uint num3 = gridObjectId;
				return x.gridObjectId_ == num3;
			};
			Types.GridObjectInfo gridObjectInfo = ((RepeatedField<>)(object)repeatedField).Find<Types.GridObjectInfo>((Predicate<>)(object)predicate);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008149")]
		[Cpp2IlInjected.Address(RVA = "0x8119C0", Offset = "0x8103C0", VA = "0x1808119C0")]
		internal void ResetGridObjectCollected()
		{
			//Discarded unreachable code: IL_000c
			((RepeatedField<T>)(object)gridObjectIdsCollected_).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x600814A")]
		[Cpp2IlInjected.Address(RVA = "0x800E30", Offset = "0x7FF830", VA = "0x180800E30")]
		public bool AnyGridObjectCollected()
		{
			return Enumerable.Any<Types.GridObjectInfo>((IEnumerable<>)(object)gridObjectIdsCollected_);
		}

		[Cpp2IlInjected.Token(Token = "0x600814B")]
		[Cpp2IlInjected.Address(RVA = "0x806A30", Offset = "0x805430", VA = "0x180806A30")]
		public string GetDialogForCharacter()
		{
			bool flag = default(bool);
			if (Data == null || flag)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600814C")]
		[Cpp2IlInjected.Address(RVA = "0x820930", Offset = "0x81F330", VA = "0x180820930")]
		public bool TryGetDialogForCharacter(out string dialog)
		{
			MissionObjectiveData missionObjectiveData = Data;
			if (missionObjectiveData != null)
			{
				MissionStepStatus status = status_;
				return missionObjectiveData.TryGetITargetCharacterDialog(status, out dialog);
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600814D")]
		[Cpp2IlInjected.Address(RVA = "0x80C1B0", Offset = "0x80ABB0", VA = "0x18080C1B0")]
		public bool IsOverAfterCharacterDialog()
		{
			MissionObjectiveData missionObjectiveData;
			do
			{
				missionObjectiveData = Data;
			}
			while (missionObjectiveData == null);
			MissionStepStatus status = status_;
			return missionObjectiveData.IsOverAfterCharacterDialog(status);
		}

		[Cpp2IlInjected.Token(Token = "0x600814E")]
		[Cpp2IlInjected.Address(RVA = "0x808D40", Offset = "0x807740", VA = "0x180808D40")]
		public Dictionary<string, object> GetStepBBVariables()
		{
			MissionObjectiveData missionObjectiveData = Data;
			int num = 0;
			if (missionObjectiveData != null)
			{
				MissionObjectiveData.CustomStepOneofCase customStepCase_ = missionObjectiveData.customStepCase_;
			}
			switch (num)
			{
			case 100:
				return (Dictionary<string, object>)(object)this.GetBringItemStepBBVars();
			default:
			{
				Dictionary<string, object> dictionary = default(Dictionary<string, object>);
				if ((long)dictionary == 175)
				{
				}
				if ((long)dictionary == 270)
				{
					return (Dictionary<string, object>)(object)this.GetTalkToCharStepBBVars();
				}
				break;
			}
			case 0:
				break;
			}
			return (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
		}

		[Cpp2IlInjected.Token(Token = "0x600814F")]
		[Cpp2IlInjected.Address(RVA = "0x803AE0", Offset = "0x8024E0", VA = "0x180803AE0")]
		private MissionStepType ChooseItemStepType()
		{
			MissionObjectiveData missionObjectiveData = Data;
			int num = 0;
			bool flag = (missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008150")]
		[Cpp2IlInjected.Address(RVA = "0x8040C0", Offset = "0x802AC0", VA = "0x1808040C0")]
		private void CreateEventHandler(ConditionListener mask, ProfileEventDispatcher.AnyConditionChanged callback)
		{
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			if (Dispatcher != null)
			{
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008151")]
		[Cpp2IlInjected.Address(RVA = "0x805730", Offset = "0x804130", VA = "0x180805730")]
		private void DisposeEventHandler()
		{
			while (true)
			{
				if (this != null)
				{
					/*Error: Could not find block for branch target IL_0004*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008152")]
		[Cpp2IlInjected.Address(RVA = "0x81AA70", Offset = "0x819470", VA = "0x18081AA70")]
		private void StartTalkToCharacter()
		{
			//IL_000a: Expected I4, but got I8
			goBehaviorInt_ = 32;
		}

		[Cpp2IlInjected.Token(Token = "0x6008153")]
		[Cpp2IlInjected.Address(RVA = "0x808E30", Offset = "0x807830", VA = "0x180808E30")]
		internal Dictionary<string, object> GetTalkToCharStepBBVars()
		{
			//Discarded unreachable code: IL_0057, IL_005d, IL_0063, IL_006b
			Dictionary<string, object> result = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			if (((RepeatedField<T>)(object)itemFiltersWithAmount_).Count > 0)
			{
				MultiItemInstance itemlist = new MultiItemInstance();
				RepeatedField<ItemFilterWithAmount> repeatedField = itemFiltersWithAmount_;
				Action<ItemFilterWithAmount> action = (Action<ItemFilterWithAmount>)(object)(Action<T>)delegate(ItemFilterWithAmount item)
				{
					//Discarded unreachable code: IL_0025
					RepeatedField<ItemInstance> items_ = itemlist.items_;
					int item_ = item.itemFilter_.data_.item_;
					ItemInstance item3 = default(ItemInstance);
					((RepeatedField<T>)(object)items_).Add((T)item3);
				};
				((RepeatedField<>)(object)repeatedField).ForEach<ItemFilterWithAmount>((Action<>)(object)action);
				Item item2 = Enumerable.First<ItemInstance>((IEnumerable<>)(object)repeatedField).Item;
				throw new NullReferenceException();
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008154")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void StopTalkToCharacter()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6008155")]
		[Cpp2IlInjected.Address(RVA = "0x818460", Offset = "0x816E60", VA = "0x180818460")]
		private void StartFollowCharacter()
		{
			//IL_000d: Expected I4, but got I8
			goBehaviorInt_ = 16388;
		}

		[Cpp2IlInjected.Token(Token = "0x6008156")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void StopFollowCharacter()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6008157")]
		[Cpp2IlInjected.Address(RVA = "0x8188B0", Offset = "0x8172B0", VA = "0x1808188B0")]
		private void StartListen()
		{
			//IL_000d: Expected I4, but got I8
			goBehaviorInt_ = 32772;
		}

		[Cpp2IlInjected.Token(Token = "0x6008158")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void StopListen()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6008159")]
		[Cpp2IlInjected.Address(RVA = "0x815C40", Offset = "0x814640", VA = "0x180815C40")]
		private unsafe NpcDiscussionItemData SetupDiscussionToListen(ITransactionContext context)
		{
			//IL_019d: Expected O, but got I4
			int num = 0;
			int num3 = default(int);
			if (!TryGetDiscussionToListen(out *(NpcDiscussionItemData*)num))
			{
				if ((Data.Listen.randomDiscussion_ ? 1 : 0) == num)
				{
					int npcDiscussion_ = Data.Listen.npcDiscussion_;
					MissionObjectiveData missionObjectiveData = Data;
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					long num2 = Convert.ToInt64((uint)missionObjectiveData.Listen.npcDiscussion_);
					NpcDiscussionItemData npcDiscussionItemData = default(NpcDiscussionItemData);
					if (npcDiscussionItemData != null)
					{
						goto IL_01f0;
					}
					CustomStepListen listen = Data.Listen;
					int npcDiscussion_2 = listen.npcDiscussion_;
					string text = $"ListenStep: Failed to load discussion id={listen}";
				}
				ITransactionContext transactionContext = context;
				_003C_003Ec__DisplayClass167_0 _003C_003Ec__DisplayClass167_;
				DateTime localTime = (DateTime)_003C_003Ec__DisplayClass167_;
				Season season2 = default(Season);
				Season season = season2;
				string weather = Profile.world_.currentWeather_;
				RepeatedField<DiscussionRecord> lastDiscussions_ = Profile.world_.lastDiscussions_;
				Func<DiscussionRecord, int> _003C_003E9__167_ = _003C_003Ec._003C_003E9__167_0;
				if (_003C_003E9__167_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((DiscussionRecord x) => x.discussionItemID_);
				}
				HashSet<int> lastDiscussions = (HashSet<int>)(object)new HashSet<T>((IEqualityComparer<>)Enumerable.Select<DiscussionRecord, int>((IEnumerable<>)(object)lastDiscussions_, (Func<, >)(object)_003C_003E9__167_));
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				Func<NpcDiscussionItemData, bool> func2 = (Func<NpcDiscussionItemData, bool>)(object)(Func<T, TResult>)delegate(NpcDiscussionItemData x)
				{
					//IL_025e: Expected O, but got I4
					int num4 = 0;
					if (Data.Listen.includeOwner_)
					{
						int character1ItemID_ = x.character1ItemID_;
						MissionSlot missionSlot = MissionSlot;
						if ((IntPtr)character1ItemID_ != (IntPtr)MissionSlot._repeated_itemsToGive_codec)
						{
							int character2ItemID_ = x.character2ItemID_;
							MissionSlot missionSlot2 = MissionSlot;
							if ((IntPtr)character2ItemID_ != (IntPtr)MissionSlot._repeated_itemsToGive_codec)
							{
								goto IL_02f9;
							}
						}
					}
					if (Data.Listen.targetNPC_ != 0)
					{
						int character1ItemID_2 = x.character1ItemID_;
						CustomStepListen listen4 = Data.Listen;
						if (character1ItemID_2 != listen4.targetNPC_)
						{
							int character2ItemID_2 = x.character2ItemID_;
							CustomStepListen listen5 = Data.Listen;
							if (character2ItemID_2 != listen5.targetNPC_)
							{
								goto IL_02f9;
							}
						}
					}
					ProfileWorld world_ = Profile.world_;
					int character1ItemID = x.Character1ItemID;
					bool flag = default(bool);
					if (flag)
					{
						bool flag2 = default(bool);
						bool flag3 = default(bool);
						if (flag2 || flag3)
						{
							goto IL_0167;
						}
						if (Data.Listen.includeOwner_)
						{
							int character1ItemID_3 = x.character1ItemID_;
							MissionSlot missionSlot3 = MissionSlot;
							if ((IntPtr)character1ItemID_3 == (IntPtr)MissionSlot._repeated_itemsToGive_codec)
							{
								goto IL_0167;
							}
						}
					}
					goto IL_02f9;
					IL_01e4:
					Season season_ = x.season_;
					if (season_ == Season.Any || season_ == season)
					{
						string timeOfDay_ = x.timeOfDay_;
						if (season_ == Season.Any)
						{
							ProtoDatabase _003CInstance_003Ek__BackingField3 = ProtoDatabase.Instance;
							string timeOfDay_2 = x.timeOfDay_;
							TimeOfDay timeOfDay = _003CInstance_003Ek__BackingField3.Get<TimeOfDay>(timeOfDay_2);
							DateTime time = localTime;
							if (!timeOfDay.IsTimeWithinInterval(time))
							{
								goto IL_02f9;
							}
						}
						if (x.PreviousDiscussionID == 0)
						{
							HashSet<int> hashSet = lastDiscussions;
							int previousDiscussionID_ = x.previousDiscussionID_;
							if (!((HashSet<T>)(object)hashSet).Contains((T)previousDiscussionID_))
							{
								goto IL_02f9;
							}
						}
						if (x.location_ == (CharacterLocation)(-3))
						{
							string weather2 = weather;
							if (x.IsValidInWeather(weather2))
							{
								RepeatedField<int> necessaryCharactersInVillage_ = x.necessaryCharactersInVillage_;
								Func<int, bool> func = default(Func<int, bool>);
								Func<int, bool> func3 = default(Func<int, bool>);
								if (func == null)
								{
									func3 = (func = (Func<int, bool>)(object)(Func<T, TResult>)delegate
									{
										//Discarded unreachable code: IL_0020
										ProfileWorld world_3 = Profile.world_;
										bool flag7 = default(bool);
										if (!flag7)
										{
											return flag7;
										}
										bool flag8 = default(bool);
										bool flag9 = default(bool);
										return flag8 || flag9;
									});
								}
								if (((IEnumerable<>)(object)necessaryCharactersInVillage_).All<int>((Func<, >)(object)func3))
								{
									MissionObjective missionObjective = this;
									ConditionsList conditions_ = x.conditions_;
									ITransactionContext context2 = context;
									Profile profile = missionObjective.Profile;
									return conditions_.Evaluate(profile, context2);
								}
							}
						}
					}
					goto IL_02f9;
					IL_02f9:
					throw new NullReferenceException();
					IL_0167:
					ProfileWorld world_2 = Profile.world_;
					int character2ItemID = x.Character2ItemID;
					bool flag4 = default(bool);
					if (flag4)
					{
						bool flag5 = default(bool);
						bool flag6 = default(bool);
						if (flag5 || flag6)
						{
							goto IL_01e4;
						}
						if (Data.Listen.includeOwner_)
						{
							int character2ItemID_3 = x.character2ItemID_;
							MissionSlot missionSlot4 = MissionSlot;
							if ((IntPtr)character2ItemID_3 == (IntPtr)MissionSlot._repeated_itemsToGive_codec)
							{
								goto IL_01e4;
							}
						}
					}
					goto IL_02f9;
				};
				IEnumerable<> enumerable = default(IEnumerable<>);
				CustomStepListen listen2 = default(CustomStepListen);
				if (!Enumerable.Any<NpcDiscussionItemData>((IEnumerable<>)Enumerable.ToList<NpcDiscussionItemData>(Enumerable.Where<NpcDiscussionItemData>(enumerable, (Func<, >)(object)func2))))
				{
					listen2 = Data.Listen;
					bool randomDiscussion_ = listen2.randomDiscussion_;
					if (Context != null)
					{
					}
					CustomStepListen listen3 = Data.Listen;
					int targetNPC_ = listen3.targetNPC_;
					string text2 = $"ListenStep: No valid discussion, rand:{listen2}, owner: {num}, npc={listen3}";
				}
				int randomSeed = Profile.player_.GetRandomSeed("mission_slot_init");
				Random random = new Random(randomSeed);
				bool randomDiscussion_2 = listen2.randomDiscussion_;
				randomSeed = random.Next(randomDiscussion_2 ? 1 : 0);
				num3 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				Profile.player_.AdvanceRandomSeed("mission_slot_init");
				goto IL_01f0;
			}
			goto IL_020f;
			IL_01f0:
			if (num3 != 0)
			{
				MapField<string, string> mapField = progressKeys_;
				string discussionKey = DiscussionKey;
				string value = default(string);
				((MapField<TKey, TValue>)(object)mapField)[(TKey)discussionKey] = (TValue)value;
			}
			goto IL_020f;
			IL_020f:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600815A")]
		[Cpp2IlInjected.Address(RVA = "0x815440", Offset = "0x813E40", VA = "0x180815440")]
		private void SetDiscussionToListen(NpcDiscussionItemData data)
		{
			//Discarded unreachable code: IL_0021
			if (data != null)
			{
				MapField<string, string> mapField = progressKeys_;
				string discussionKey = DiscussionKey;
				int iD_ = data.iD_;
				string value = default(string);
				((MapField<TKey, TValue>)(object)mapField)[(TKey)discussionKey] = (TValue)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600815B")]
		[Cpp2IlInjected.Address(RVA = "0x820990", Offset = "0x81F390", VA = "0x180820990")]
		public unsafe bool TryGetDiscussionToListen(out NpcDiscussionItemData data)
		{
			//Discarded unreachable code: IL_0028
			//IL_0023: Expected O, but got I4
			int num = 0;
			MapField<string, string> mapField = progressKeys_;
			string discussionKey = DiscussionKey;
			bool flag = ((MapField<TKey, TValue>)(object)mapField).TryGetValue((TKey)discussionKey, out *(TValue*)num);
			if (!flag || int.TryParse((string)num, out *(int*)num))
			{
			}
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x600815C")]
		[Cpp2IlInjected.Address(RVA = "0x80BF00", Offset = "0x80A900", VA = "0x18080BF00")]
		public bool IsCharacterToListen(Item characterItem)
		{
			MissionObjectiveData missionObjectiveData = Data;
			bool flag = default(bool);
			if (missionObjectiveData != null && missionObjectiveData.Listen != null && flag)
			{
				if (flag)
				{
					return true;
				}
				return flag;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600815D")]
		[Cpp2IlInjected.Address(RVA = "0x817930", Offset = "0x816330", VA = "0x180817930")]
		private void StartDecorate()
		{
			//Discarded unreachable code: IL_007e
			MissionStepStatus decorGoBehaviour = status_;
			SetDecorGoBehaviour(decorGoBehaviour);
			CustomStepDecorate decorate = Data.Decorate;
			bool flag = default(bool);
			if (!flag)
			{
				ProfileEventDispatcher dispatcher = Dispatcher;
				ProfileEventDispatcher.GridChanged value = Dispatcher_OnGridChanged;
				dispatcher.OnGridChanged += value;
				return;
			}
			ProfileEventDispatcher dispatcher2 = Dispatcher;
			ProfileEventDispatcher.PlayerHouseRoomWallpaperChanged value2 = Dispatcher_OnWallpaperChanged;
			dispatcher2.OnPlayerHouseRoomWallpaperChanged += value2;
			ProfileEventDispatcher dispatcher3 = Dispatcher;
			ProfileEventDispatcher.PlayerHouseRoomFlooringChanged value3 = Dispatcher_OnFlooringChanged;
			dispatcher3.OnPlayerHouseRoomFlooringChanged += value3;
		}

		[Cpp2IlInjected.Token(Token = "0x600815E")]
		[Cpp2IlInjected.Address(RVA = "0x81D5E0", Offset = "0x81BFE0", VA = "0x18081D5E0")]
		private void StopDecorate()
		{
			//Discarded unreachable code: IL_005a
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.GridChanged value = Dispatcher_OnGridChanged;
				dispatcher.OnGridChanged -= value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.PlayerHouseRoomWallpaperChanged value2 = Dispatcher_OnWallpaperChanged;
				dispatcher2.OnPlayerHouseRoomWallpaperChanged -= value2;
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.PlayerHouseRoomFlooringChanged value3 = Dispatcher_OnFlooringChanged;
				dispatcher3.OnPlayerHouseRoomFlooringChanged -= value3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600815F")]
		[Cpp2IlInjected.Address(RVA = "0x8153C0", Offset = "0x813DC0", VA = "0x1808153C0")]
		private void SetDecorGoBehaviour(MissionStepStatus missionStepStatus)
		{
			//Discarded unreachable code: IL_0051
			//IL_0015: Expected I4, but got I8
			//IL_0050: Expected I4, but got I8
			if (missionStepStatus != MissionStepStatus.Completed && missionStepStatus != MissionStepStatus.Confirmed)
			{
				goBehaviorInt_ = 130;
				GridLocationFilter location_ = Data.Decorate.location_;
				int num = goBehaviorInt_;
				if (location_.locationTypeCase_ != GridLocationFilter.LocationTypeOneofCase.PlayerHouse)
				{
					goBehaviorInt_ = num;
				}
				else
				{
					goBehaviorInt_ = num;
				}
			}
			else
			{
				goBehaviorInt_ = 32;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008160")]
		[Cpp2IlInjected.Address(RVA = "0x805110", Offset = "0x803B10", VA = "0x180805110")]
		private void Dispatcher_OnWallpaperChanged(int floorIndex, House.Types.RoomSlot roomSlot, House.Types.WallPosition? wallPosition, Item wallpaperItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008161")]
		[Cpp2IlInjected.Address(RVA = "0x804470", Offset = "0x802E70", VA = "0x180804470")]
		private void Dispatcher_OnFlooringChanged(int floorIndex, House.Types.RoomSlot roomSlot, Item flooringItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008162")]
		[Cpp2IlInjected.Address(RVA = "0x8225E0", Offset = "0x820FE0", VA = "0x1808225E0")]
		private void UpdateDecorateWallpaperFloringProgression(Item item)
		{
			//Discarded unreachable code: IL_002f
			//IL_001c: Expected I4, but got I8
			//IL_002b: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			ItemFilter itemFilter = itemFilter_;
			ItemFilterData data_ = itemFilter.data_;
			if (data_ != null)
			{
				data_.type_ = ItemType.Trimming;
			}
			int num = 0;
			int num2 = 0;
			if (!itemFilter.ApplyFilter(item, (ItemState)num2, (IProfile)num))
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008163")]
		[Cpp2IlInjected.Address(RVA = "0x8046E0", Offset = "0x8030E0", VA = "0x1808046E0")]
		private void Dispatcher_OnGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [System.Runtime.InteropServices.Optional] GridAddObjectOptions options)
		{
			int num = 0;
			if (gridObject != null)
			{
				int itemID = gridObject.ItemID;
				ItemType itemType = default(ItemType);
				if (itemType == ItemType.Furniture)
				{
					MissionObjectiveData missionObjectiveData = Data;
					if (missionObjectiveData != null)
					{
						ItemSelector itemSelector = missionObjectiveData.ItemSelector;
						if (itemSelector != null)
						{
							ItemSelector.ItemSelectorOneofCase itemSelectorCase_ = itemSelector.itemSelectorCase_;
						}
						if (num != 4)
						{
							int itemID2 = gridObject.ItemID;
							FurnitureItemType furnitureItemType = default(FurnitureItemType);
							if (furnitureItemType == FurnitureItemType.Blocker || furnitureItemType == FurnitureItemType.Door)
							{
								return;
							}
						}
					}
				}
			}
			SetDecorGoBehaviour(MissionStepStatus.Completed);
			bool flag = ChangeStatus(MissionStepStatus.Completed);
		}

		[Cpp2IlInjected.Token(Token = "0x6008164")]
		[Cpp2IlInjected.Address(RVA = "0x800EB0", Offset = "0x7FF8B0", VA = "0x180800EB0")]
		public static bool ApplyGridLocationFilter(GridLocationFilter filter, IGrid grid, GridObject gridObject, Profile profile)
		{
			//Discarded unreachable code: IL_0021, IL_0046, IL_006d, IL_0094, IL_00a1, IL_00ae, IL_00d5, IL_00dd, IL_00e2, IL_00f2, IL_00f7, IL_00fb, IL_00ff, IL_0103, IL_0115, IL_011b, IL_0121, IL_0127
			//IL_006a: Expected O, but got I4
			//IL_0091: Expected O, but got I4
			//IL_010d: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (filter.locationTypeCase_ <= GridLocationFilter.LocationTypeOneofCase.VillageArea)
			{
				Village village = profile.Village;
				ProfileWorld world_ = profile.world_;
				bool result = default(bool);
				return result;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008165")]
		[Cpp2IlInjected.Address(RVA = "0x820760", Offset = "0x81F160", VA = "0x180820760")]
		private static bool TryGetCenterOfSpecificLocationFilter(LocationSourceWithRadius specificLocation, in World world, out Item centerItem)
		{
			//IL_000d: Expected I4, but got O
			//IL_004c: Expected I4, but got O
			bool flag = default(bool);
			ProfileWorld profileWorld = default(ProfileWorld);
			while (true)
			{
				Item invalid = Item.Invalid;
				centerItem.ItemID = (int)invalid;
				int num = 0;
				if (specificLocation != null)
				{
					LocationSource location_ = specificLocation.location_;
					if (location_ != null)
					{
						LocationSource.LocationOneofCase locationCase_ = location_.locationCase_;
					}
				}
				if (num != 0)
				{
					if (num != 10)
					{
						if (flag && (long)profileWorld.playerHouse_.HouseItem == 18)
						{
							break;
						}
						continue;
					}
					LocationBuilding building = specificLocation.location_.Building;
					int building_ = building.building_;
					centerItem.ItemID = (int)building;
				}
				return flag;
			}
			LocationNearUniqueItem locationNearUniqueItem = default(LocationNearUniqueItem);
			Item item = locationNearUniqueItem.Item;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008166")]
		[Cpp2IlInjected.Address(RVA = "0x80BE40", Offset = "0x80A840", VA = "0x18080BE40")]
		public static bool IsCenterOfSpecificLocationFilter(LocationSourceWithRadius specificLocation, Item item, in World world)
		{
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6008167")]
		[Cpp2IlInjected.Address(RVA = "0x805770", Offset = "0x804170", VA = "0x180805770")]
		[IteratorStateMachine(typeof(_003CEnumSpecificLocationGridObjects_003Ed__182))]
		private static IEnumerable<(IGrid, GridObject)> EnumSpecificLocationGridObjects(LocationSourceWithRadius specificLocation, Profile profile, Func<GridObject, bool> isValidGridObject)
		{
			_003CEnumSpecificLocationGridObjects_003Ed__182 _003CEnumSpecificLocationGridObjects_003Ed__ = new _003CEnumSpecificLocationGridObjects_003Ed__182(-2);
			_003CEnumSpecificLocationGridObjects_003Ed__._003C_003E3__specificLocation = specificLocation;
			_003CEnumSpecificLocationGridObjects_003Ed__._003C_003E3__profile = profile;
			_003CEnumSpecificLocationGridObjects_003Ed__._003C_003E3__isValidGridObject = isValidGridObject;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008168")]
		[Cpp2IlInjected.Address(RVA = "0x805EC0", Offset = "0x8048C0", VA = "0x180805EC0")]
		[IteratorStateMachine(typeof(_003CGetAllCustomLocationPositions_003Ed__183))]
		private static IEnumerable<(CustomLocationPositions, IEnumerable<uint>)> GetAllCustomLocationPositions(Profile profile)
		{
			new _003CGetAllCustomLocationPositions_003Ed__183(-2)._003C_003E3__profile = profile;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008169")]
		[Cpp2IlInjected.Address(RVA = "0x801520", Offset = "0x7FFF20", VA = "0x180801520")]
		private static bool ApplySpecificLocationFilter(LocationSourceWithRadius specificLocation, IGrid grid, GridObject gridObject, Profile profile)
		{
			//IL_021c: Expected O, but got I4
			int num = 0;
			_003C_003Ec__DisplayClass184_0 _003C_003Ec__DisplayClass184_ = new _003C_003Ec__DisplayClass184_0();
			_003C_003Ec__DisplayClass184_.grid = grid;
			_003C_003Ec__DisplayClass184_.specificLocation = specificLocation;
			_003C_003Ec__DisplayClass184_.profile = profile;
			_003C_003Ec__DisplayClass184_.gridObject = gridObject;
			LocationSource location_ = _003C_003Ec__DisplayClass184_.specificLocation.location_;
			LocationSource.LocationOneofCase locationCase_ = location_.locationCase_;
			if ((long)location_ > 2 && locationCase_ != LocationSource.LocationOneofCase.AnywhereInScene)
			{
				Profile profile2 = _003C_003Ec__DisplayClass184_.profile;
				IGrid grid2 = _003C_003Ec__DisplayClass184_.grid;
				ProfileWorld world_ = _003C_003Ec__DisplayClass184_.profile.world_;
				bool flag = default(bool);
				if (!flag)
				{
					goto IL_02bf;
				}
			}
			new _003C_003Ec__DisplayClass184_1().CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass184_;
			List<uint> list3 = default(List<uint>);
			if (_003C_003Ec__DisplayClass184_.specificLocation.location_.locationCase_ <= LocationSource.LocationOneofCase.NearUniqueItem)
			{
				GridObject gridObject2 = _003C_003Ec__DisplayClass184_.gridObject;
				IGrid grid3 = _003C_003Ec__DisplayClass184_.grid;
				ProfileGameInfo gameInfo_ = profile.gameInfo_;
				Func<GridPosition, bool> func = (Func<GridPosition, bool>)(object)(Func<T, TResult>)delegate
				{
					IGrid grid5 = ((_003C_003Ec__DisplayClass184_0)(object)profile).grid;
					LocationSourceWithRadius specificLocation3 = ((_003C_003Ec__DisplayClass184_0)(object)profile).specificLocation;
					GridFloorType gridFloorType = default(GridFloorType);
					int num7 = (int)gridFloorType;
					GridFloorType type_ = specificLocation3.location_.AnywhereFloorType.type_;
					throw new NullReferenceException();
				};
				IEnumerable<GridPosition> enumerable = default(IEnumerable<GridPosition>);
				bool flag2 = Enumerable.Any<GridPosition>((IEnumerable<>)enumerable);
				LocationAnywhereVillageArea locationAnywhereVillageArea = default(LocationAnywhereVillageArea);
				VillageAreaType location_2 = locationAnywhereVillageArea.location_;
				LocationAnywhereScene locationAnywhereScene = default(LocationAnywhereScene);
				int scene_ = locationAnywhereScene.scene_;
				_003C_003Ec _003C_003E = default(_003C_003Ec);
				Func<IGrid, uint> func2 = default(Func<IGrid, uint>);
				if (_003C_003Ec._003C_003E9__184_1 == null)
				{
					_003C_003E = _003C_003Ec._003C_003E9;
					func2 = (Func<IGrid, uint>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)new Func<T, TResult>(_003C_003E._003CApplySpecificLocationFilter_003Eb__184_1));
				}
				List<IGrid> list = default(List<IGrid>);
				List<uint> CS_0024_003C_003E8__locals0 = (List<uint>)(object)Enumerable.ToList<uint>(Enumerable.Select<IGrid, uint>((IEnumerable<>)list, (Func<, >)(object)func2));
				bool flag3 = default(bool);
				while (flag3)
				{
				}
				Func<uint, bool> cpp2il__autoParamName__idx_ = (Func<uint, bool>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass184_0)(object)_003C_003E)._003CApplySpecificLocationFilter_003Eb__2);
				bool flag4 = ((IEnumerable<>)CS_0024_003C_003E8__locals0).Any<uint>((Func<, >)(object)cpp2il__autoParamName__idx_);
				object syncRoot = ((List<>)(object)CS_0024_003C_003E8__locals0)._syncRoot;
				Predicate<GridObject> predicate = (Predicate<GridObject>)(object)new Predicate<T>(((_003C_003Ec__DisplayClass184_0)(object)_003C_003E)._003CApplySpecificLocationFilter_003Eb__3);
				Item items = default(Item);
				((List<>)(object)CS_0024_003C_003E8__locals0)._items = (T[])items;
				int num2 = 0;
				Predicate<GridObject> predicate2 = (Predicate<GridObject>)(object)(Predicate<T>)delegate(GridObject x)
				{
					int itemID = x.ItemID;
					throw new NullReferenceException();
				};
				_003C_003Ec__DisplayClass184_1 _003C_003Ec__DisplayClass184_2 = (_003C_003Ec__DisplayClass184_1)(object)CS_0024_003C_003E8__locals0;
				_003C_003Ec__DisplayClass184_0 cS_0024_003C_003E8__locals = _003C_003Ec__DisplayClass184_2.CS_0024_003C_003E8__locals1;
				(CustomLocationPositions, IGrid) tuple = default((CustomLocationPositions, IGrid));
				if ((object)tuple != null)
				{
					Func<CustomLocationPositions.Types.CustomLocationPosition, bool> func3 = (Func<CustomLocationPositions.Types.CustomLocationPosition, bool>)(object)(Func<T, TResult>)delegate(CustomLocationPositions.Types.CustomLocationPosition x)
					{
						//Discarded unreachable code: IL_0027
						LocationSourceWithRadius specificLocation2 = _003C_003Ec__DisplayClass184_2.CS_0024_003C_003E8__locals1.specificLocation;
						string gUID_ = x.gUID_;
						string gUID_2 = specificLocation2.location_.Custom.gUID_;
						return string.Equals(gUID_, gUID_2);
					};
					CustomLocationPositions.Types.CustomLocationPosition[] array = Enumerable.Where<CustomLocationPositions.Types.CustomLocationPosition>((IEnumerable<>)CS_0024_003C_003E8__locals0, (Func<, >)(object)func3).ToArray<CustomLocationPositions.Types.CustomLocationPosition>();
					int radius_ = _003C_003Ec__DisplayClass184_2.CS_0024_003C_003E8__locals1.specificLocation.radius_;
					int radiusSq = radius_ * radius_;
					Func<GridObject, bool> func4 = (Func<GridObject, bool>)(object)(Func<T, TResult>)delegate(GridObject y)
					{
						//Discarded unreachable code: IL_0034
						GridState state_ = y.state_;
						if (state_ != null)
						{
							SubGrid subGrid = state_.SubGrid;
							int num5 = 0;
							if (subGrid == null)
							{
								goto IL_0022;
							}
							uint gridID_ = subGrid.gridID_;
						}
						int num6 = 0;
						goto IL_0022;
						IL_0022:
						IGrid grid4 = _003C_003Ec__DisplayClass184_2.CS_0024_003C_003E8__locals1.grid;
						return (IntPtr)num6 == (IntPtr)typeof(IGrid).TypeHandle;
					};
					Func<CustomLocationPositions.Types.CustomLocationPosition, bool> func5 = default(Func<CustomLocationPositions.Types.CustomLocationPosition, bool>);
					if (Enumerable.FirstOrDefault<GridObject>((IEnumerable<>)(object)array, (Func<, >)(object)func4) != null)
					{
						GridObject gridObject3 = _003C_003Ec__DisplayClass184_2.CS_0024_003C_003E8__locals1.gridObject;
						GridPosition projectedPos = (GridPosition)num;
						int num4 = default(int);
						func5 = (Func<CustomLocationPositions.Types.CustomLocationPosition, bool>)(object)(Func<T, TResult>)((CustomLocationPositions.Types.CustomLocationPosition x) => num4 <= radiusSq);
						bool flag5 = ((IEnumerable<>)(object)array).Any<CustomLocationPositions.Types.CustomLocationPosition>((Func<, >)(object)func5);
					}
					Func<Realm, bool> func6 = (Func<Realm, bool>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass184_0)(object)func5)._003CApplySpecificLocationFilter_003Eb__12);
					ICollection<> collection = default(ICollection<>);
					Realm realm = Enumerable.FirstOrDefault<Realm>((IEnumerable<>)collection, (Func<, >)(object)func6);
					LocationRealm locationRealm = default(LocationRealm);
					string realm_ = locationRealm.realm_;
					string text = default(string);
					bool flag6 = text == realm;
					LocationNearUniqueItem locationNearUniqueItem = default(LocationNearUniqueItem);
					Item sceneItem = locationNearUniqueItem.SceneItem;
					_003C_003Ec _003C_003E2 = default(_003C_003Ec);
					Func<IGrid, uint> func7 = default(Func<IGrid, uint>);
					if (_003C_003Ec._003C_003E9__184_4 == null)
					{
						_003C_003E2 = _003C_003Ec._003C_003E9;
						func7 = (Func<IGrid, uint>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)new Func<T, TResult>(_003C_003E2._003CApplySpecificLocationFilter_003Eb__184_4));
					}
					List<IGrid> list2 = default(List<IGrid>);
					list3 = (List<uint>)(object)Enumerable.ToList<uint>(Enumerable.Select<IGrid, uint>((IEnumerable<>)list2, (Func<, >)(object)func7));
					bool flag7 = default(bool);
					if (!flag7)
					{
						Func<uint, bool> cpp2il__autoParamName__idx_2 = (Func<uint, bool>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass184_0)(object)_003C_003E2)._003CApplySpecificLocationFilter_003Eb__5);
						if (!((IEnumerable<>)list3).Any<uint>((Func<, >)(object)cpp2il__autoParamName__idx_2))
						{
							goto IL_02bf;
						}
					}
					goto IL_02c2;
				}
			}
			goto IL_02bf;
			IL_02bf:
			int num3 = 0;
			goto IL_02c2;
			IL_02c2:
			object syncRoot2 = ((List<>)(object)list3)._syncRoot;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600816A")]
		[Cpp2IlInjected.Address(RVA = "0x806340", Offset = "0x804D40", VA = "0x180806340")]
		private static (CustomLocationPositions, IGrid) GetCustomLocationPositions(IGrid grid, Profile profile)
		{
			//IL_00e8: Expected O, but got I4
			//IL_013f: Expected O, but got I4
			//IL_017c: Expected O, but got I4
			IGrid grid2 = (IGrid)(object)profile;
			int num = 0;
			IGrid grid3 = grid2;
			bool flag = default(bool);
			if (!flag)
			{
				Func<Realm, bool> func = (Func<Realm, bool>)(object)(Func<T, TResult>)delegate(Realm x)
				{
					//Discarded unreachable code: IL_0010
					IGrid grid7 = grid2;
					RepeatedField<uint> gridIDs_ = x.gridIDs_;
					bool result3 = default(bool);
					return result3;
				};
				ICollection<> collection = default(ICollection<>);
				Realm realm = Enumerable.FirstOrDefault<Realm>((IEnumerable<>)collection, (Func<, >)(object)func);
				if (realm == null)
				{
					Func<BuildingInfo, bool> func2 = (Func<BuildingInfo, bool>)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_0009
						IGrid grid6 = grid2;
						bool result2 = default(bool);
						return result2;
					};
					BuildingInfo buildingInfo;
					ICollection<> collection2 = default(ICollection<>);
					BuildingInfo buildingInfo2 = (buildingInfo = Enumerable.FirstOrDefault<BuildingInfo>((IEnumerable<>)collection2, (Func<, >)(object)func2));
					BuildingInfo buildingInfo3 = buildingInfo;
					if (buildingInfo3 == null)
					{
						Func<OffGridBuilding, bool> func3 = (Func<OffGridBuilding, bool>)(object)(Func<T, TResult>)delegate
						{
							//Discarded unreachable code: IL_0009
							IGrid grid5 = grid2;
							bool result = default(bool);
							return result;
						};
						OffGridBuilding offGridBuilding;
						ICollection<> collection3 = default(ICollection<>);
						OffGridBuilding offGridBuilding2 = (offGridBuilding = Enumerable.FirstOrDefault<OffGridBuilding>((IEnumerable<>)collection3, (Func<, >)(object)func3));
						OffGridBuilding offGridBuilding3 = offGridBuilding;
						if (offGridBuilding3 == null)
						{
							goto IL_0183;
						}
						string customLocationPositionsPath_ = offGridBuilding3.customLocationPositionsPath_;
						if (offGridBuilding2 == null)
						{
							Gameloft.FileSystem.Abstraction.IFileSystem binaryLocalizationFs = LocalizationProtoBufTableProvider.GetBinaryLocalizationFs((CultureInfo)0);
							string customLocationPositionsPath_2 = offGridBuilding.customLocationPositionsPath_;
							CustomLocationPositions customLocationPositions = ProtoParser.Parse<CustomLocationPositions>(binaryLocalizationFs.ReadAllBytes(customLocationPositionsPath_2));
						}
						RepeatedField<MiningRock> miningRocks_ = offGridBuilding2.miningRocks_;
						_003C_003Ec__DisplayClass185_0 CS_0024_003C_003E8__locals0;
						Func<IGrid, bool> func4 = (Func<IGrid, bool>)(object)(Func<T, TResult>)delegate
						{
							OffGridBuilding offGridBuilding4 = offGridBuilding;
							bool flag2 = default(bool);
							if (!flag2)
							{
								return flag2;
							}
							_003C_003Ec__DisplayClass185_0 _003C_003Ec__DisplayClass185_ = CS_0024_003C_003E8__locals0;
							throw new NullReferenceException();
						};
						IEnumerable<IGrid> enumerable = default(IEnumerable<IGrid>);
						IGrid grid4 = Enumerable.FirstOrDefault<IGrid>((IEnumerable<>)enumerable, (Func<, >)(object)func4);
					}
					string customLocationPositionsPath_3 = buildingInfo3.customLocationPositionsPath_;
					if (buildingInfo2 == null)
					{
						Gameloft.FileSystem.Abstraction.IFileSystem binaryLocalizationFs2 = LocalizationProtoBufTableProvider.GetBinaryLocalizationFs((CultureInfo)0);
						string customLocationPositionsPath_4 = buildingInfo.customLocationPositionsPath_;
						CustomLocationPositions customLocationPositions2 = ProtoParser.Parse<CustomLocationPositions>(binaryLocalizationFs2.ReadAllBytes(customLocationPositionsPath_4));
					}
				}
				string customLocationPositionsPath_5 = realm.customLocationPositionsPath_;
				if (realm != null)
				{
					goto IL_0183;
				}
			}
			int num2 = 0;
			CustomLocationPositions customLocationPositions3 = ProtoParser.Parse<CustomLocationPositions>(FileSystem.Data.ReadAllBytes((string)num2));
			goto IL_0183;
			IL_0183:
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600816B")]
		[Cpp2IlInjected.Address(RVA = "0x809C20", Offset = "0x808620", VA = "0x180809C20")]
		private bool HasCorrectDecor(IGrid grid, GridChangedOperation operation, GridObject gridObject)
		{
			//Discarded unreachable code: IL_0213, IL_0219, IL_021f, IL_0225
			//IL_011b: Expected O, but got I4
			//IL_011b: Expected O, but got I4
			//IL_012b: Expected O, but got I4
			bool flag = default(bool);
			uint amount = default(uint);
			bool flag2 = default(bool);
			Func<Types.GridObjectInfo, bool> func = default(Func<Types.GridObjectInfo, bool>);
			Func<Types.GridObjectInfo, bool> func2 = default(Func<Types.GridObjectInfo, bool>);
			bool flag3 = default(bool);
			uint num5 = default(uint);
			CustomStepDecorate customStepDecorate = default(CustomStepDecorate);
			IEnumerable<GridObject> enumerable = default(IEnumerable<GridObject>);
			uint num8 = default(uint);
			bool flag5 = default(bool);
			uint num9 = default(uint);
			bool flag6 = default(bool);
			int num10 = default(int);
			int num11 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				if (operation == GridChangedOperation.UpdateState)
				{
					goto IL_01af;
				}
				if (operation != GridChangedOperation.UpdateTransform)
				{
					GridObject gridObject2 = gridObject;
					if (flag)
					{
						GridObject gridObject3 = gridObject;
						return DecorProgression((int)amount, gridObject3);
					}
				}
				GridLocationFilter location_ = Data.Decorate.location_;
				if (location_ != null)
				{
					LocationSourceWithRadius specificLocation = location_.SpecificLocation;
				}
				int itemID = gridObject.ItemID;
				if (flag2 && flag2)
				{
					if (operation != 0)
					{
						RepeatedField<Types.GridObjectInfo> repeatedField = gridObjectIdsCollected_;
						if (func == null)
						{
							func2 = (func = (Func<Types.GridObjectInfo, bool>)(object)(Func<T, TResult>)delegate(Types.GridObjectInfo x)
							{
								//Discarded unreachable code: IL_0015
								IGrid grid4 = grid;
								return (IntPtr)(int)x.gridId_ == (IntPtr)typeof(IGrid).TypeHandle;
							});
						}
						List<Types.GridObjectInfo> list = (List<Types.GridObjectInfo>)(object)Enumerable.ToList<Types.GridObjectInfo>(Enumerable.Where<Types.GridObjectInfo>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func2));
						if (flag3)
						{
							if (num4 < (int)num5)
							{
								num4 += num4;
								num4++;
							}
							while (num4 == 0)
							{
							}
							GridLocationFilter location_2 = Data.Decorate.location_;
							Profile profile = Profile;
							if (ApplyGridLocationFilter(location_2, (IGrid)num4, (GridObject)num4, profile))
							{
								continue;
							}
							bool flag4 = DecorProgression(-1, (GridObject)num4);
						}
						num3++;
						int num6 = 0;
						if (num3 != 0)
						{
							break;
						}
						if (num3 != 0)
						{
						}
						IGrid grid2 = grid;
						GridPosition position = gridObject.Position;
						LocationSourceWithRadius specificLocation2 = customStepDecorate.location_.SpecificLocation;
						int num7 = GetGridObjectRadius();
						if (enumerable == null)
						{
							goto IL_0197;
						}
						if (num6 < (int)num8)
						{
							num6 += num6;
							if (num6 == (int)num8)
							{
								goto IL_0190;
							}
							num6++;
						}
						while (!flag5)
						{
						}
					}
					goto IL_0190;
				}
				goto IL_01b7;
				IL_0190:
				num9 += num9;
				goto IL_0197;
				IL_01b7:
				ItemFilter itemFilter = itemFilter_;
				int itemID2 = gridObject.ItemID;
				while (!flag6)
				{
				}
				GridLocationFilter location_3 = Data.Decorate.location_;
				IGrid grid3 = grid;
				GridObject gridObject4 = gridObject;
				Profile profile2 = Profile;
				bool flag7 = ApplyGridLocationFilter(location_3, grid3, gridObject4, profile2);
				throw new NullReferenceException();
				IL_01af:
				float currentAmount = CurrentAmount;
				goto IL_01b7;
				IL_0197:
				num10++;
				if (enumerable != null)
				{
				}
				if (num11 != 0)
				{
					continue;
				}
				if (num10 != 0)
				{
					goto IL_01af;
				}
				goto IL_01b7;
				MissionObjective missionObjective;
				IGrid uniqueGrid;
				int canChangeState;
				[Cpp2IlInjected.Token(Token = "0x60082EB")]
				[Cpp2IlInjected.Address(RVA = "0x1303C30", Offset = "0x1302630", VA = "0x181303C30")]
				bool DecorProgression(int _amount, GridObject _gridObject)
				{
					//Discarded unreachable code: IL_001b
					//IL_001a: Expected F4, but got I4
					missionObjective = this;
					uniqueGrid = grid;
					canChangeState = 0;
					return missionObjective.UpdateCurrentProgression(_amount, (byte)canChangeState != 0, uniqueGrid, _gridObject);
				}
				GridObject gridObject5;
				ItemDatabase _003CInstance_003Ek__BackingField;
				int itemID3;
				IGridPlaceableItemData gridPlaceableItemData = default(IGridPlaceableItemData);
				uint num13 = default(uint);
				int num12;
				[Cpp2IlInjected.Token(Token = "0x60082EC")]
				[Cpp2IlInjected.Address(RVA = "0x1303C70", Offset = "0x1302670", VA = "0x181303C70")]
				int GetGridObjectRadius()
				{
					gridObject5 = gridObject;
					_003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					itemID3 = gridObject5.ItemID;
					if (gridPlaceableItemData != null)
					{
						num12 = 0;
						if (num12 < (int)num13)
						{
							num12 += num12;
							num12++;
						}
						if (gridPlaceableItemData == null)
						{
						}
					}
					throw new NullReferenceException();
				}
				[Cpp2IlInjected.Token(Token = "0x60082EB")]
				[Cpp2IlInjected.Address(RVA = "0x1303C30", Offset = "0x1302630", VA = "0x181303C30")]
				bool DecorProgression(int _amount, GridObject _gridObject)
				{
					//Discarded unreachable code: IL_001b
					//IL_001a: Expected F4, but got I4
					missionObjective = this;
					uniqueGrid = grid;
					canChangeState = 0;
					return missionObjective.UpdateCurrentProgression(_amount, (byte)canChangeState != 0, uniqueGrid, _gridObject);
				}
				[Cpp2IlInjected.Token(Token = "0x60082EC")]
				[Cpp2IlInjected.Address(RVA = "0x1303C70", Offset = "0x1302670", VA = "0x181303C70")]
				int GetGridObjectRadius()
				{
					gridObject5 = gridObject;
					_003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					itemID3 = gridObject5.ItemID;
					if (gridPlaceableItemData != null)
					{
						num12 = 0;
						if (num12 < (int)num13)
						{
							num12 += num12;
							num12++;
						}
						if (gridPlaceableItemData == null)
						{
						}
					}
					throw new NullReferenceException();
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600816C")]
		[Cpp2IlInjected.Address(RVA = "0x817150", Offset = "0x815B50", VA = "0x180817150")]
		private void StartCancel()
		{
			//Discarded unreachable code: IL_0073
			ConditionListener listener = Data.Cancel.cancelMissionWhen_.Listener;
			ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnCancelConditionChange;
			if (status_ == MissionStepStatus.Ongoing)
			{
				ConditionsList cancelMissionWhen_ = Data.Cancel.cancelMissionWhen_;
				ITransactionContext context = Context;
				Profile profile = Profile;
				if (cancelMissionWhen_.Evaluate(profile, context))
				{
					MissionSlot missionSlot = MissionSubStep.MissionSlot;
					int success = 0;
					missionSlot.EndMission((byte)success != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600816D")]
		[Cpp2IlInjected.Address(RVA = "0x805730", Offset = "0x804130", VA = "0x180805730")]
		private void StopCancel()
		{
			while (true)
			{
				if (this != null)
				{
					/*Error: Could not find block for branch target IL_0004*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600816E")]
		[Cpp2IlInjected.Address(RVA = "0x80D740", Offset = "0x80C140", VA = "0x18080D740")]
		private void OnCancelConditionChange(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_004c
			if (status_ == MissionStepStatus.Ongoing)
			{
				ConditionsList cancelMissionWhen_ = Data.Cancel.cancelMissionWhen_;
				ITransactionContext context = Context;
				Profile profile = Profile;
				if (cancelMissionWhen_.Evaluate(profile, context))
				{
					MissionSlot missionSlot = MissionSubStep.MissionSlot;
					int success = 0;
					missionSlot.EndMission((byte)success != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600816F")]
		[Cpp2IlInjected.Address(RVA = "0x817280", Offset = "0x815C80", VA = "0x180817280")]
		private void StartCatchFish()
		{
			//Discarded unreachable code: IL_0059
			//IL_0010: Expected I4, but got I8
			Profile profile = Profile;
			goBehaviorInt_ = 2;
			if (!profile.player_.IsToolUnlocked(ToolItemType.Fishing))
			{
			}
			MissionObjectiveData missionObjectiveData = Data;
			ProfileEventDispatcher dispatcher = Dispatcher;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.FishingResultReceived value = OnFishingResultReceived;
			dispatcher.OnFishingResultReceived += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6008170")]
		[Cpp2IlInjected.Address(RVA = "0x80D820", Offset = "0x80C220", VA = "0x18080D820")]
		private void OnFishingResultReceived(bool success, Item fishItem, int amount, float? fishMass, ActivityDataLocationFilter locationFilter, Item spectator, int? criticalSuccessMinigameID)
		{
			//Discarded unreachable code: IL_00bc, IL_00d4, IL_00da, IL_00f1, IL_00f6, IL_0103, IL_0108, IL_011a, IL_0123, IL_012d, IL_0174
			//IL_0014: Expected O, but got I4
			//IL_0069: Invalid comparison between F4 and I4
			//IL_0077: Invalid comparison between F4 and I4
			//IL_00d2: Invalid comparison between F4 and I4
			//IL_00d8: Invalid comparison between I4 and F4
			//IL_00e6: Expected O, but got I4
			int itemID = fishItem.ItemID;
			int? criticalSuccessMinigameID2 = (int?)(object)0;
			HangoutWithCharacter with_ = Data.CatchFish.with_;
			Profile profile = Profile;
			if (!with_.CurrentHangoutCharacterIsValid(profile) || !success)
			{
				return;
			}
			ItemFilter itemFilter = itemFilter_;
			int num = 0;
			int num2 = default(int);
			if (num2 != 0)
			{
				float num3 = minWeightRequired_;
				int num4 = 0;
				if (!(num3 <= (float)num4))
				{
				}
				float num5 = maxWeightRequired_;
				if (!(num5 <= (float)num4))
				{
				}
				if (Data.CatchFish.conditionType_.typesCase_ == CatchFishConditionType.TypesOneofCase.Amount)
				{
				}
				MissionSubStep missionSubStep = MissionSubStep;
				ProfileEventDispatcher dispatcher = Dispatcher;
				MissionItemData data = missionSubStep.MissionSlot.Data;
				Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008171")]
		[Cpp2IlInjected.Address(RVA = "0x81D310", Offset = "0x81BD10", VA = "0x18081D310")]
		private void StopCatchFish()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.FishingResultReceived value = OnFishingResultReceived;
				dispatcher.OnFishingResultReceived -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008172")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void StartChase()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6008173")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void StopChase()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6008174")]
		[Cpp2IlInjected.Address(RVA = "0x817AE0", Offset = "0x8164E0", VA = "0x180817AE0")]
		private void StartDiscussion()
		{
			//Discarded unreachable code: IL_001c
			ProfileEventDispatcher dispatcher = Dispatcher;
			ProfileEventDispatcher.DiscussionEnded value = Discussion_OnDiscussionEnded;
			dispatcher.OnDiscussionEnded += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6008175")]
		[Cpp2IlInjected.Address(RVA = "0x81D720", Offset = "0x81C120", VA = "0x18081D720")]
		private void StopDiscussion()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.DiscussionEnded value = Discussion_OnDiscussionEnded;
				dispatcher.OnDiscussionEnded -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008176")]
		[Cpp2IlInjected.Address(RVA = "0x804160", Offset = "0x802B60", VA = "0x180804160")]
		private unsafe void Discussion_OnDiscussionEnded(Item characterItem)
		{
			//Discarded unreachable code: IL_005d
			CustomStepStartDiscussion startDiscussion = Data.StartDiscussion;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			bool useDifferentCharacter_ = Data.StartDiscussion.useDifferentCharacter_;
			bool flag2 = default(bool);
			bool flag3 = !flag2;
			if (useDifferentCharacter_ == flag3)
			{
				float currentAmount = CurrentAmount;
				int num = 0;
				if (!(SetCurrentAmount(currentAmount, out *(float*)num) >= targetAmount_))
				{
					bool flag4 = ChangeStatus(MissionStepStatus.Ongoing);
				}
			}
			else
			{
				float currentAmount2 = CurrentAmount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008177")]
		[Cpp2IlInjected.Address(RVA = "0x817B70", Offset = "0x816570", VA = "0x180817B70")]
		private void StartDressUp()
		{
			//Discarded unreachable code: IL_002f
			//IL_0028: Expected I4, but got I8
			ProfileEventDispatcher dispatcher = Dispatcher;
			ProfileEventDispatcher.AvatarCustomizationChanged value = OnAvatarCustomizationChanged;
			dispatcher.OnAvatarCustomizationChanged += value;
			goBehaviorInt_ = 130;
			UpdateDressupProgress();
		}

		[Cpp2IlInjected.Token(Token = "0x6008178")]
		[Cpp2IlInjected.Address(RVA = "0x822660", Offset = "0x821060", VA = "0x180822660")]
		private void UpdateDressupProgress()
		{
			//Discarded unreachable code: IL_005e
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected I4, but got Unknown
			//IL_005b: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			//IL_005b: Expected I4, but got I8
			//IL_005b: Expected F4, but got I4
			ProfilePlayer player_ = Profile.player_;
			if ((long)ProfilePlayer._map_furnitureData_codec != 0)
			{
			}
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)Meta.Util.InventoryUtil.ExtractClothes((IAvatar)player_.femaleAvatar_);
			ItemFilter itemFilter = itemFilter_;
			int num = 0;
			int itemsQuantity = itemFilter.GetItemsQuantity((Dictionary<, >)(object)dictionary, (byte)num != 0);
			int num2 = 0;
			float currentAmount = CurrentAmount;
			int num3 = 0;
			int num4 = 0;
			itemsQuantity -= this;
			ulong num5 = default(ulong);
			bool flag = UpdateCurrentProgression(num2, (byte)num5 != 0, (IGrid)num4, (GridObject)num3);
		}

		[Cpp2IlInjected.Token(Token = "0x6008179")]
		[Cpp2IlInjected.Address(RVA = "0x80D300", Offset = "0x80BD00", VA = "0x18080D300")]
		private void OnAvatarCustomizationChanged(bool success, List<ClothingInfo> newEquippedClothes, List<Item> newEquippedFeatures)
		{
			UpdateDressupProgress();
		}

		[Cpp2IlInjected.Token(Token = "0x600817A")]
		[Cpp2IlInjected.Address(RVA = "0x81D7B0", Offset = "0x81C1B0", VA = "0x18081D7B0")]
		private void StopDressUp()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.AvatarCustomizationChanged value = OnAvatarCustomizationChanged;
				dispatcher.OnAvatarCustomizationChanged -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600817B")]
		[Cpp2IlInjected.Address(RVA = "0x818670", Offset = "0x817070", VA = "0x180818670")]
		private void StartGardeningPlant()
		{
			//Discarded unreachable code: IL_0062
			//IL_0011: Expected I4, but got I8
			Profile profile = Profile;
			goBehaviorInt_ = 66;
			ProfilePlayer player_ = profile.player_;
			int toolItemType = 0;
			if (!player_.IsToolUnlocked((ToolItemType)toolItemType))
			{
			}
			MissionObjectiveData missionObjectiveData = Data;
			ProfileEventDispatcher dispatcher = Dispatcher;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.GardeningEvent value = OnGardeningPlantResultReceived;
			dispatcher.OnGardeningEvent += value;
		}

		[Cpp2IlInjected.Token(Token = "0x600817C")]
		[Cpp2IlInjected.Address(RVA = "0x80E330", Offset = "0x80CD30", VA = "0x18080E330")]
		private void OnGardeningPlantResultReceived(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//IL_007c: Expected O, but got I4
			//IL_00ae: Expected O, but got I4
			if (gridObject == null)
			{
				return;
			}
			GridLocationFilter filter_ = Data.GardeningPlant.filter_;
			Profile profile = Profile;
			int num = 0;
			if (!ApplyGridLocationFilter(filter_, grid, gridObject, profile))
			{
				return;
			}
			Item plantedSeedItem = ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gridObject.state_.GardenData.slots_)[slotIndex]).PlantedSeedItem;
			SeedItemData seedItemData = default(SeedItemData);
			if (seedItemData == null)
			{
				return;
			}
			Item producedItem = seedItemData.ProducedItem;
			if ((object)producedItem != null)
			{
				return;
			}
			ItemFilter itemFilter = itemFilter_;
			int num2 = 0;
			if (itemFilter.GetItemQuantity(producedItem, 1, (ItemState)num2) == 0)
			{
				return;
			}
			bool useDifferentItem_ = Data.GardeningPlant.useDifferentItem_;
			int num3 = 0;
			RepeatedField<int> repeatedField = itemIdsCollected_;
			int itemID = producedItem.ItemID;
			bool flag = !((RepeatedField<T>)(object)repeatedField).Remove((T)itemID);
			if (useDifferentItem_ == flag)
			{
				if (useDifferentItem_)
				{
				}
				bool flag2 = default(bool);
				bool flag3 = !flag2;
				if (useDifferentItem_ == flag3)
				{
					if (useDifferentItem_)
					{
					}
					float currentAmount = CurrentAmount;
					float num4 = default(float);
					if (!(num4 >= targetAmount_))
					{
						bool flag4 = ChangeStatus(MissionStepStatus.Ongoing);
						return;
					}
				}
			}
			float currentAmount2 = CurrentAmount;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600817D")]
		[Cpp2IlInjected.Address(RVA = "0x81DDF0", Offset = "0x81C7F0", VA = "0x18081DDF0")]
		private void StopGardeningPlant()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.GardeningEvent value = OnGardeningPlantResultReceived;
				dispatcher.OnGardeningEvent -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600817E")]
		[Cpp2IlInjected.Address(RVA = "0x818590", Offset = "0x816F90", VA = "0x180818590")]
		private void StartGardeningHarvest()
		{
			//Discarded unreachable code: IL_0061
			//IL_0010: Expected I4, but got I8
			Profile profile = Profile;
			goBehaviorInt_ = 2;
			ProfilePlayer player_ = profile.player_;
			int toolItemType = 0;
			if (!player_.IsToolUnlocked((ToolItemType)toolItemType))
			{
			}
			MissionObjectiveData missionObjectiveData = Data;
			ProfileEventDispatcher dispatcher = Dispatcher;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.GardeningEvent value = OnGardeningHarvestResultReceived;
			dispatcher.OnGardeningEvent += value;
		}

		[Cpp2IlInjected.Token(Token = "0x600817F")]
		[Cpp2IlInjected.Address(RVA = "0x80DD40", Offset = "0x80C740", VA = "0x18080DD40")]
		private void OnGardeningHarvestResultReceived(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//Discarded unreachable code: IL_00fc, IL_0136, IL_013b, IL_0148, IL_014d, IL_015f, IL_0168, IL_0172, IL_01c1
			//IL_000d: Expected O, but got I4
			//IL_00c3: Expected O, but got I4
			//IL_012b: Expected O, but got I4
			GardeningDetail detail2 = (GardeningDetail)0;
			if (gridObject == null)
			{
				return;
			}
			HangoutWithCharacter with_ = Data.GardeningHarvest.with_;
			Profile profile = Profile;
			if (!with_.CurrentHangoutCharacterIsValid(profile))
			{
				return;
			}
			GridLocationFilter filter_ = Data.GardeningHarvest.filter_;
			Profile profile2 = Profile;
			int num = 0;
			if (!ApplyGridLocationFilter(filter_, grid, gridObject, profile2))
			{
				return;
			}
			Item plantedSeedItem = ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gridObject.state_.GardenData.slots_)[slotIndex]).PlantedSeedItem;
			SeedItemData seedItemData = default(SeedItemData);
			if (seedItemData == null)
			{
				return;
			}
			Item producedItem = seedItemData.ProducedItem;
			if ((object)producedItem == null)
			{
				ItemFilter itemFilter = itemFilter_;
				int producedAmount_ = seedItemData.producedAmount_;
				int num2 = 0;
				int itemQuantity = itemFilter.GetItemQuantity(producedItem, producedAmount_, (ItemState)num2);
				if (itemQuantity != 0)
				{
					MissionSubStep missionSubStep = MissionSubStep;
					ProfileEventDispatcher dispatcher = Dispatcher;
					MissionItemData data = missionSubStep.MissionSlot.Data;
					Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
					producedAmount_ = itemQuantity;
					throw new NullReferenceException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008180")]
		[Cpp2IlInjected.Address(RVA = "0x81DD60", Offset = "0x81C760", VA = "0x18081DD60")]
		private void StopGardeningHarvest()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.GardeningEvent value = OnGardeningHarvestResultReceived;
				dispatcher.OnGardeningEvent -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008181")]
		[Cpp2IlInjected.Address(RVA = "0x818750", Offset = "0x817150", VA = "0x180818750")]
		private void StartGiftToCharacter()
		{
			//Discarded unreachable code: IL_0038
			MissionObjectiveData missionObjectiveData = Data;
			ProfileEventDispatcher dispatcher = Dispatcher;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.ItemsGivenToCharacter value = GiftToCharacter_OnItemsGivenToCharacter;
			dispatcher.OnItemsGivenToCharacter += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6008182")]
		[Cpp2IlInjected.Address(RVA = "0x809170", Offset = "0x807B70", VA = "0x180809170")]
		private unsafe void GiftToCharacter_OnItemsGivenToCharacter(Item characterItem, Dictionary<(Item item, ItemState state), int> itemsGiven, Item missionItem, bool keepItems = false, bool alreadyGifted = false)
		{
			//IL_0022: Expected O, but got I4
			int itemID = characterItem.ItemID;
			bool alreadyGifted2 = false;
			Item characterItem2 = (Item)itemID;
			bool flag = default(bool);
			if (flag)
			{
				return;
			}
			CustomStepGiftToCharacterItem giftToCharacter = Data.GiftToCharacter;
			Item characterItem3 = characterItem2;
			if (!giftToCharacter.IsValid(characterItem3))
			{
				return;
			}
			Func<KeyValuePair<(Item, ItemState), int>, Item> _003C_003E9__209_ = _003C_003Ec._003C_003E9__209_0;
			if (_003C_003E9__209_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<KeyValuePair<(Item, ItemState), int>, Item>((IEnumerable<>)itemsGiven, (Func<, >)(object)_003C_003E9__209_));
			if (Data.GiftToCharacter.mustBeFavoriteThing_)
			{
				Func<Item, bool> func = (Func<Item, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0021
					ProfileWorld world_ = Profile.world_;
					bool flag5 = default(bool);
					return (!flag5) ? flag5 : (!alreadyGifted2);
				};
				List<Item> list2 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Where<Item>((IEnumerable<>)list, (Func<, >)(object)func));
			}
			if (Data.GiftToCharacter.targetItem_.itemSelectorCase_ != 0)
			{
				ItemFilter itemFilter = itemFilter_;
				int num = 0;
				if (itemFilter.GetItemsQuantity((Dictionary<, >)(object)itemsGiven, (byte)num != 0) == 0)
				{
					return;
				}
			}
			MissionObjectiveData missionObjectiveData = Data;
			Item item = characterItem2;
			bool useDifferentCharacter_ = missionObjectiveData.GiftToCharacter.useDifferentCharacter_;
			bool flag2 = default(bool);
			bool flag3 = !flag2;
			if (useDifferentCharacter_ == flag3)
			{
				float currentAmount = CurrentAmount;
				int num2 = 0;
				if (!(SetCurrentAmount(currentAmount, out *(float*)num2) >= targetAmount_))
				{
					bool flag4 = ChangeStatus(MissionStepStatus.Ongoing);
					return;
				}
			}
			float currentAmount2 = CurrentAmount;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008183")]
		[Cpp2IlInjected.Address(RVA = "0x81DE80", Offset = "0x81C880", VA = "0x18081DE80")]
		private void StopGiftToCharacter()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.ItemsGivenToCharacter value = GiftToCharacter_OnItemsGivenToCharacter;
				dispatcher.OnItemsGivenToCharacter -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008184")]
		[Cpp2IlInjected.Address(RVA = "0x818800", Offset = "0x817200", VA = "0x180818800")]
		private void StartInteraction()
		{
			//Discarded unreachable code: IL_0038
			MissionObjectiveData missionObjectiveData = Data;
			ProfileEventDispatcher dispatcher = Dispatcher;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.ItemInteraction value = OnItemInteraction;
			dispatcher.OnItemInteraction += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6008185")]
		[Cpp2IlInjected.Address(RVA = "0x81DF10", Offset = "0x81C910", VA = "0x18081DF10")]
		private void StopInteraction()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.ItemInteraction value = OnItemInteraction;
				dispatcher.OnItemInteraction -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008186")]
		[Cpp2IlInjected.Address(RVA = "0x80E820", Offset = "0x80D220", VA = "0x18080E820")]
		private unsafe void OnItemInteraction(Item item)
		{
			//Discarded unreachable code: IL_0068
			//IL_0016: Expected O, but got I4
			//IL_0016: Expected O, but got I4
			ItemFilter itemFilter = itemFilter_;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (!itemFilter.ApplyFilter(item, (ItemState)num3, (IProfile)num2))
			{
				return;
			}
			bool useDifferentItem_ = Data.Interaction.useDifferentItem_;
			bool flag = default(bool);
			bool flag2 = !flag;
			if (useDifferentItem_ == flag2)
			{
				float currentAmount = CurrentAmount;
				int num4 = 0;
				if (!(SetCurrentAmount(currentAmount, out *(float*)num4) >= targetAmount_))
				{
					bool flag3 = ChangeStatus(MissionStepStatus.Ongoing);
					return;
				}
			}
			float currentAmount2 = CurrentAmount;
		}

		[Cpp2IlInjected.Token(Token = "0x6008187")]
		[Cpp2IlInjected.Address(RVA = "0x81B5F0", Offset = "0x819FF0", VA = "0x18081B5F0")]
		private void StartWaterPlant()
		{
			//Discarded unreachable code: IL_0077
			//IL_0010: Expected I4, but got I8
			MissionObjectiveData missionObjectiveData = Data;
			goBehaviorInt_ = 2;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			CustomStepWaterPlant.PlantTypesOneofCase plantTypesCase_ = missionObjectiveData.WaterPlant.plantTypesCase_;
			if (plantTypesCase_ == CustomStepWaterPlant.PlantTypesOneofCase.FlowerItem)
			{
				ProfileEventDispatcher dispatcher = Dispatcher;
				ProfileEventDispatcher.FlowerEvent value = OnWaterFlowerResultReceived;
				dispatcher.OnFlowerEvent += value;
				return;
			}
			while (plantTypesCase_ != CustomStepWaterPlant.PlantTypesOneofCase.CropItem)
			{
			}
			ProfileEventDispatcher dispatcher2 = Dispatcher;
			ProfileEventDispatcher.GardeningEvent value2 = OnWaterCropResultReceived;
			dispatcher2.OnGardeningEvent += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6008188")]
		[Cpp2IlInjected.Address(RVA = "0x80C300", Offset = "0x80AD00", VA = "0x18080C300")]
		private bool IsValidWaterPlantLocation(IGrid grid, GridObject gridObject)
		{
			//Discarded unreachable code: IL_0022
			CustomStepWaterPlant waterPlant = Data.WaterPlant;
			Profile profile = Profile;
			return ApplyGridLocationFilter(waterPlant.filter_, grid, gridObject, profile);
		}

		[Cpp2IlInjected.Token(Token = "0x6008189")]
		[Cpp2IlInjected.Address(RVA = "0x8106F0", Offset = "0x80F0F0", VA = "0x1808106F0")]
		private void OnWaterFlowerResultReceived(IGrid grid, GridObject gridObject, FlowerOperation operation, bool automatic, bool wasDry)
		{
			//Discarded unreachable code: IL_0042
			if (operation != 0 || gridObject == null || !IsValidWaterPlantLocation(grid, gridObject))
			{
				return;
			}
			int itemID = gridObject.ItemID;
			ItemType itemType = default(ItemType);
			ActivityItemType activityItemType = default(ActivityItemType);
			if (itemType == ItemType.ActivityItem && activityItemType == ActivityItemType.Flower)
			{
				ItemFilter itemFilter = itemFilter_;
				int num = default(int);
				if (num != 0)
				{
					bool useDifferentItem_ = Data.WaterPlant.useDifferentItem_;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600818A")]
		[Cpp2IlInjected.Address(RVA = "0x810520", Offset = "0x80EF20", VA = "0x180810520")]
		private void OnWaterCropResultReceived(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//Discarded unreachable code: IL_005b
			if (gridObject != null)
			{
				GridState state_ = gridObject.state_;
				if (state_ != null)
				{
					GardenData gardenData = state_.GardenData;
					if (gardenData != null)
					{
						GardenData.Types.GardeningSlot gardeningSlot = Enumerable.ElementAtOrDefault<GardenData.Types.GardeningSlot>((IEnumerable<>)(object)gardenData.slots_, slotIndex);
					}
				}
			}
			bool flag;
			if (false && flag && IsValidWaterPlantLocation(grid, gridObject))
			{
				ItemFilter itemFilter = itemFilter_;
				int num;
				if (num != 0)
				{
					bool useDifferentItem_ = Data.WaterPlant.useDifferentItem_;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600818B")]
		[Cpp2IlInjected.Address(RVA = "0x81EEC0", Offset = "0x81D8C0", VA = "0x18081EEC0")]
		private void StopWaterPlant()
		{
			//Discarded unreachable code: IL_003b
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.FlowerEvent value = OnWaterFlowerResultReceived;
				dispatcher.OnFlowerEvent -= value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.GardeningEvent value2 = OnWaterCropResultReceived;
				dispatcher2.OnGardeningEvent -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600818C")]
		[Cpp2IlInjected.Address(RVA = "0x8026E0", Offset = "0x8010E0", VA = "0x1808026E0")]
		private void ChangeBringItemStatus(MissionStepStatus newStatus)
		{
			//Discarded unreachable code: IL_0010
			goBehaviorInt_ = 2;
			bool flag = ChangeStatus(newStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x600818D")]
		[Cpp2IlInjected.Address(RVA = "0x816CC0", Offset = "0x8156C0", VA = "0x180816CC0")]
		private void StartBringItem()
		{
			//Discarded unreachable code: IL_01d6
			if (Enumerable.Any<int>((IEnumerable<>)(object)itemIdsCollected_))
			{
				MissionSubStepData missionSubStepData = MissionSubStep.Data;
				int newStepStatus = 0;
				MissionSubStepData.Types.ExtraBringItem bringItem = missionSubStepData.BringItem;
				if (bringItem != null && bringItem.bringDialogueType_ == BringDialogueTypeOptions.Dialogue)
				{
					uint num = default(uint);
					goBehaviorInt_ = (int)num;
					bool flag = ChangeStatus((MissionStepStatus)newStepStatus);
					return;
				}
				uint num2 = default(uint);
				goBehaviorInt_ = (int)num2;
			}
			ItemFilter itemFilter = itemFilter_;
			if (itemFilter.data_.type_ <= ItemType.Clothing)
			{
				Dictionary<(Item, ItemState), int> allItems = (Dictionary<(Item, ItemState), int>)(object)Profile.Backpack.GetAllItems();
				int num3 = 0;
				int itemsQuantity = itemFilter.GetItemsQuantity((Dictionary<, >)(object)allItems, (byte)num3 != 0);
				Dictionary<(Item, ItemState), int> allItems2 = (Dictionary<(Item, ItemState), int>)(object)Profile.Catalog.GetAllItems();
				Dictionary<(Item, ItemState), int> allItems3 = (Dictionary<(Item, ItemState), int>)(object)Profile.Wardrobe.GetAllItems();
				Dictionary<Item, int> currencies = (Dictionary<Item, int>)(object)Profile.player_.GetCurrencies();
				int num4 = 0;
				int itemsQuantity2 = itemFilter.GetItemsQuantity((Dictionary<, >)(object)currencies, (byte)num4 != 0);
			}
			float currentAmount = CurrentAmount;
			int num5 = 0;
			num5++;
			uint num6 = default(uint);
			goBehaviorInt_ = (int)num6;
			bool flag2 = ChangeStatus((MissionStepStatus)num5);
			MissionObjectiveData missionObjectiveData = Data;
			ItemFilter itemFilter2 = itemFilter_;
			bool flag3 = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num5) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ItemFilterData data_ = itemFilter2.data_;
			ProfileEventDispatcher dispatcher = Dispatcher;
			ProfileEventDispatcher dispatcher3 = default(ProfileEventDispatcher);
			if (data_.type_ != ItemType.Currency)
			{
				ProfileEventDispatcher.ItemAdded value = OnBringItemInventoryItemAdded;
				dispatcher.OnItemAdded += value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.ItemRemoved value2 = OnBringItemInventoryRemoved;
				dispatcher2.OnItemRemoved += value2;
				dispatcher3 = Dispatcher;
				ProfileEventDispatcher.ItemMoved value3 = OnBringItemInventoryMoved;
				dispatcher3.OnItemMoved += value3;
			}
			ProfileEventDispatcher.CurrencyChanged value4 = OnBringItemCurrencyChanged;
			dispatcher3.OnCurrencyChanged += value4;
			ProfileEventDispatcher dispatcher4 = Dispatcher;
			ProfileEventDispatcher.RaiseBringItemPreGifted value5 = OnRaiseBringItemPreGifted;
			dispatcher4.OnRaiseBringItemPreGifted += value5;
			ProfileEventDispatcher dispatcher5 = Dispatcher;
			ProfileEventDispatcher.ItemsGivenToCharacter value6 = OnItemsGivenToCharacter;
			dispatcher5.OnItemsGivenToCharacter += value6;
		}

		[Cpp2IlInjected.Token(Token = "0x600818E")]
		[Cpp2IlInjected.Address(RVA = "0x81D0C0", Offset = "0x81BAC0", VA = "0x18081D0C0")]
		private void StopBringItem()
		{
			//Discarded unreachable code: IL_00ba
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.CurrencyChanged value = OnBringItemCurrencyChanged;
				dispatcher.OnCurrencyChanged -= value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.ItemAdded value2 = OnBringItemInventoryItemAdded;
				dispatcher2.OnItemAdded -= value2;
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.ItemRemoved value3 = OnBringItemInventoryRemoved;
				dispatcher3.OnItemRemoved -= value3;
				ProfileEventDispatcher dispatcher4 = Dispatcher;
				ProfileEventDispatcher.ItemMoved value4 = OnBringItemInventoryMoved;
				dispatcher4.OnItemMoved -= value4;
				ProfileEventDispatcher dispatcher5 = Dispatcher;
				ProfileEventDispatcher.RaiseBringItemPreGifted value5 = OnRaiseBringItemPreGifted;
				dispatcher5.OnRaiseBringItemPreGifted -= value5;
				ProfileEventDispatcher dispatcher6 = Dispatcher;
				ProfileEventDispatcher.ItemsGivenToCharacter value6 = OnItemsGivenToCharacter;
				dispatcher6.OnItemsGivenToCharacter -= value6;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600818F")]
		[Cpp2IlInjected.Address(RVA = "0x80D3E0", Offset = "0x80BDE0", VA = "0x18080D3E0")]
		private void OnBringItemInventoryItemAdded(IInventory inventory, Item item, int amount, ItemState state, [System.Runtime.InteropServices.Optional] AddDetail detail)
		{
			//Discarded unreachable code: IL_0032
			//IL_0028: Expected I4, but got I8
			if (!Enumerable.Any<int>((IEnumerable<>)(object)itemIdsCollected_))
			{
				ItemFilter itemFilter = itemFilter_;
				int num = default(int);
				bool flag = default(bool);
				if (num != 0 && flag)
				{
					goBehaviorInt_ = 34;
					bool flag2 = ChangeStatus(MissionStepStatus.ReadyToBeCompleted);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008190")]
		[Cpp2IlInjected.Address(RVA = "0x80D670", Offset = "0x80C070", VA = "0x18080D670")]
		private void OnBringItemInventoryRemoved(IInventory inventory, Item item, int amount, ItemState state, InvActionType reason = InvActionType.None)
		{
			//Discarded unreachable code: IL_0031
			//IL_0027: Expected I4, but got I8
			if (!Enumerable.Any<int>((IEnumerable<>)(object)itemIdsCollected_))
			{
				ItemFilter itemFilter = itemFilter_;
				int num = default(int);
				bool flag = default(bool);
				if (num != 0 && !flag)
				{
					goBehaviorInt_ = 2;
					bool flag2 = ChangeStatus(MissionStepStatus.Ongoing);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008191")]
		[Cpp2IlInjected.Address(RVA = "0x80D4B0", Offset = "0x80BEB0", VA = "0x18080D4B0")]
		private void OnBringItemInventoryMoved(ContainerInventory source, int sourcePosition, ContainerInventory destination, int[] destinationPositions, Item item, ItemState state, int amountMoved, ContainerInventoryMoveAction action)
		{
			//IL_0060: Expected I4, but got I8
			if (source == destination)
			{
				return;
			}
			ContainerInventory backpack = Profile.Backpack;
			if (source != backpack)
			{
				ContainerInventory backpack2 = Profile.Backpack;
				if (destination != backpack2)
				{
					return;
				}
			}
			ContainerInventory backpack3 = Profile.Backpack;
			if (source != backpack3)
			{
				if (!Enumerable.Any<int>((IEnumerable<>)(object)itemIdsCollected_))
				{
					ItemFilter itemFilter = itemFilter_;
					int num = 0;
					int num2 = default(int);
					bool flag = default(bool);
					if (num2 != 0 && flag)
					{
						goBehaviorInt_ = 34;
						bool flag2 = ChangeStatus(MissionStepStatus.ReadyToBeCompleted);
					}
				}
				return;
			}
			bool flag3 = default(bool);
			while (flag3)
			{
			}
			int num3 = 0;
			int num4 = default(int);
			while (num4 == 0)
			{
			}
			bool flag4 = default(bool);
			while (flag4)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008192")]
		[Cpp2IlInjected.Address(RVA = "0x80D310", Offset = "0x80BD10", VA = "0x18080D310")]
		private void OnBringItemCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			//Discarded unreachable code: IL_0044
			//IL_0034: Expected O, but got I4
			//IL_0034: Expected O, but got I4
			//IL_0034: Expected F4, but got I4
			int itemID = currencyItem.ItemID;
			if (!Enumerable.Any<int>((IEnumerable<>)(object)itemIdsCollected_))
			{
				ItemFilter itemFilter = itemFilter_;
				int num = 0;
				bool flag = default(bool);
				if (flag)
				{
					int num2 = 0;
					int canChangeState = 0;
					bool flag2 = UpdateCurrentProgression(itemID, (byte)canChangeState != 0, (IGrid)num2, (GridObject)num);
					goBehaviorInt_ = 1;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008193")]
		[Cpp2IlInjected.Address(RVA = "0x8103C0", Offset = "0x80EDC0", VA = "0x1808103C0")]
		private void OnRaiseBringItemPreGifted(MissionSubStep subStep)
		{
			//Discarded unreachable code: IL_002f
			string fullIdentifierID = MissionSubStep.FullIdentifierID;
			string fullIdentifierID2 = subStep.FullIdentifierID;
			if (string.Equals(fullIdentifierID, fullIdentifierID2))
			{
				Item characterItem = MissionSubStep.MissionSlot.CharacterItem;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008194")]
		[Cpp2IlInjected.Address(RVA = "0x80E960", Offset = "0x80D360", VA = "0x18080E960")]
		private void OnItemsGivenToCharacter(Item characterItem, Dictionary<(Item item, ItemState state), int> itemsGiven, Item missionItem, bool keepItems = false, bool isGifted = false)
		{
			//Discarded unreachable code: IL_013e
			int num = targetCharacterItemID_;
			if ((object)typeof(Item).TypeHandle == null || MissionSubStep.MissionSlot.Data.ID == 0)
			{
				return;
			}
			ItemFilter itemFilter = itemFilter_;
			int num2 = 0;
			int itemsQuantity = itemFilter.GetItemsQuantity((Dictionary<, >)(object)itemsGiven, (byte)num2 != 0);
			ItemFilter itemFilter2 = itemFilter_;
			Func<KeyValuePair<(Item, ItemState), int>, (Item, ItemState)> _003C_003E9__227_ = _003C_003Ec._003C_003E9__227_0;
			if (_003C_003E9__227_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			IEnumerable<KeyValuePair<(Item, ItemState), int>> enumerable = (IEnumerable<KeyValuePair<(Item, ItemState), int>>)Enumerable.Select<KeyValuePair<(Item, ItemState), int>, (Item, ItemState)>((IEnumerable<>)itemsGiven, (Func<, >)(object)_003C_003E9__227_);
			List<(Item item, ItemState state)> itemListFilter = (List<(Item item, ItemState state)>)(object)itemFilter2.ApplyFilter((IEnumerable<>)enumerable);
			ProfileEventDispatcher dispatcher = Dispatcher;
			Func<KeyValuePair<(Item, ItemState), int>, bool> func = (Func<KeyValuePair<(Item, ItemState), int>, bool>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_0009
				List<(Item, ItemState)> list = itemListFilter;
				bool result = default(bool);
				return result;
			};
			IEnumerable<KeyValuePair<(Item, ItemState), int>> enumerable2 = (IEnumerable<KeyValuePair<(Item, ItemState), int>>)Enumerable.Where<KeyValuePair<(Item, ItemState), int>>((IEnumerable<>)itemsGiven, (Func<, >)(object)func);
			Func<KeyValuePair<(Item, ItemState), int>, (Item, ItemState)> func2 = default(Func<KeyValuePair<(Item, ItemState), int>, (Item, ItemState)>);
			if (_003C_003Ec._003C_003E9__227_2 == null)
			{
				func2 = (Func<KeyValuePair<(Item, ItemState), int>, (Item, ItemState)>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Func<KeyValuePair<(Item, ItemState), int>, int> func3 = default(Func<KeyValuePair<(Item, ItemState), int>, int>);
			if (_003C_003Ec._003C_003E9__227_3 == null)
			{
				func3 = (Func<KeyValuePair<(Item, ItemState), int>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Dictionary<KeyValuePair<(Item, ItemState), int>, (Item, ItemState)> dictionary = (Dictionary<KeyValuePair<(Item, ItemState), int>, (Item, ItemState)>)(object)Enumerable.ToDictionary<KeyValuePair<(Item, ItemState), int>, (Item, ItemState), int>((IEnumerable<>)enumerable2, (Func<, >)(object)func2, (Func<, >)(object)func3);
			int num3 = 0;
			uint num4 = default(uint);
			if (num3 < (int)num4)
			{
				num3 += num3;
				num3++;
			}
			MissionSubStepData.Types.ExtraBringItem bringItem = MissionSubStep.Data.BringItem;
			if (bringItem == null || bringItem.bringDialogueType_ != BringDialogueTypeOptions.Dialogue)
			{
				bool flag = ChangeStatus(MissionStepStatus.Completed);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008195")]
		[Cpp2IlInjected.Address(RVA = "0x805F30", Offset = "0x804930", VA = "0x180805F30")]
		private Dictionary<string, object> GetBringItemStepBBVars()
		{
			//Discarded unreachable code: IL_0075, IL_007b, IL_0081, IL_0089
			Dictionary<string, object> result = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			if (((RepeatedField<T>)(object)MissionSubStep.Data.BringItem.itemsToGive_).Count > 0)
			{
				MultiItemInstance itemlist = new MultiItemInstance();
				RepeatedField<ItemToGiveAmount> itemsToGive_ = MissionSubStep.Data.BringItem.itemsToGive_;
				Action<ItemToGiveAmount> action = (Action<ItemToGiveAmount>)(object)(Action<T>)delegate(ItemToGiveAmount itemToGive)
				{
					//Discarded unreachable code: IL_002a
					RepeatedField<ItemInstance> items_ = itemlist.items_;
					int itemToGive_ = itemToGive.itemToGive_;
					int amount_ = itemToGive.amount_;
					ItemInstance item2 = MissionSlot.NewItemToGive(itemToGive_, amount_);
					((RepeatedField<T>)(object)items_).Add((T)item2);
				};
				((RepeatedField<>)(object)itemsToGive_).ForEach<ItemToGiveAmount>((Action<>)(object)action);
				Item item = Enumerable.First<ItemInstance>((IEnumerable<>)(object)itemsToGive_).Item;
				throw new NullReferenceException();
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6008196")]
		[Cpp2IlInjected.Address(RVA = "0x819620", Offset = "0x818020", VA = "0x180819620")]
		private void StartPickUp()
		{
			//Discarded unreachable code: IL_00a0
			//IL_0012: Expected I4, but got I8
			//IL_003e: Invalid comparison between F4 and I4
			MissionObjectiveData missionObjectiveData = Data;
			int num = 0;
			goBehaviorInt_ = 2;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			if (missionObjectiveData.PickUp.pickUpTypesCase_ != CustomStepPickUp.PickUpTypesOneofCase.QuestItem)
			{
				float num2 = amountToSpawn_;
				int num3 = 0;
				if (!(num2 <= (float)num3))
				{
					SpawnItemsForPickUp(isFindMode: true);
				}
				ProfileEventDispatcher dispatcher = Dispatcher;
				ProfileEventDispatcher.GridChanged value = PickUp_OnGridChanged;
				dispatcher.OnGridChanged += value;
			}
			else
			{
				if (((MapField<TKey, TValue>)(object)progressKeys_).Count == 0)
				{
					int isFindMode = 0;
					SpawnItemsForPickUp((byte)isFindMode != 0);
				}
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.ItemAdded value2 = PickUp_OnItemAdded;
				dispatcher2.OnItemAdded += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008197")]
		[Cpp2IlInjected.Address(RVA = "0x81E0C0", Offset = "0x81CAC0", VA = "0x18081E0C0")]
		private void StopPickUp()
		{
			//Discarded unreachable code: IL_006d
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.GridChanged value = PickUp_OnGridChanged;
				dispatcher.OnGridChanged -= value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.ItemAdded value2 = PickUp_OnItemAdded;
				dispatcher2.OnItemAdded -= value2;
			}
			MissionObjectiveData missionObjectiveData = Data;
			if (missionObjectiveData != null)
			{
				CustomStepPickUp pickUp = missionObjectiveData.PickUp;
				int num = 0;
				if (pickUp != null)
				{
					CustomStepPickUp.PickUpTypesOneofCase pickUpTypesCase_ = pickUp.pickUpTypesCase_;
				}
				if (num != 4)
				{
					RemovePickUpSpawnedObjects();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008198")]
		[Cpp2IlInjected.Address(RVA = "0x8166B0", Offset = "0x8150B0", VA = "0x1808166B0")]
		private void SpawnItemsForPickUp(bool isFindMode)
		{
			//Discarded unreachable code: IL_0141, IL_0147, IL_014d, IL_0153
			//IL_010f: Expected O, but got I4
			List<PlaceOnGrid.Types.Response> list = default(List<PlaceOnGrid.Types.Response>);
			bool flag = default(bool);
			int num4 = default(int);
			while (true)
			{
				int num = 0;
				Random random = new Random(Profile.player_.GetRandomSeed("MetaMission_StartPickup_SpawnMissingItems"));
				float currentAmount = CurrentAmount;
				Profile profile = Profile;
				ProfileEventDispatcher dispatcher = Dispatcher;
				ITransactionContext context = Context;
				ISpawnHelper getISpawnHelper = Data.GetISpawnHelper;
				ItemFilter itemFilter = itemFilter_;
				MissionIdentifier._003CEnumerateSelfAndParents_003Ed__2 _003CEnumerateSelfAndParents_003Ed__ = new MissionIdentifier._003CEnumerateSelfAndParents_003Ed__2(-2);
				_003CEnumerateSelfAndParents_003Ed__._003C_003E3__value = this;
				IEnumerable<IMissionIdentifier> enumerable = (IEnumerable<IMissionIdentifier>)Enumerable.Reverse<IMissionIdentifier>((IEnumerable<>)(object)_003CEnumerateSelfAndParents_003Ed__);
				Func<IMissionIdentifier, string> _003C_003E9__1_ = MissionIdentifier._003C_003Ec._003C_003E9__1_0;
				if (_003C_003E9__1_ == null)
				{
					MissionIdentifier._003C_003Ec._003C_003E9 = (MissionIdentifier._003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new NullReferenceException();
					};
				}
				IEnumerable<IMissionIdentifier> enumerable2 = (IEnumerable<IMissionIdentifier>)Enumerable.Select<IMissionIdentifier, string>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__1_);
				string debugName = string.Join("!", (IEnumerable<>)enumerable2);
				SpawnHelper spawnHelper = new SpawnHelper(profile, dispatcher, context, getISpawnHelper, itemFilter, debugName);
				float num2 = (spawnHelper.TargetAmount = targetAmount_);
				if (list == null)
				{
					break;
				}
				float num3 = (targetAmount_ = spawnHelper.TargetAmount);
				Profile.player_.AdvanceRandomSeed("MetaMission_StartPickup_SpawnMissingItems");
				if (!isFindMode)
				{
					if (flag)
					{
						MapField<string, string> mapField = progressKeys_;
						string text = $"spawn_{num4}";
						string value = $"{text}-{text}";
						((MapField<TKey, TValue>)(object)mapField).Add((TKey)text, (TValue)value);
						num++;
					}
					if (num == 0)
					{
						bool flag2 = ChangeStatus(MissionStepStatus.Completed);
						break;
					}
					continue;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008199")]
		[Cpp2IlInjected.Address(RVA = "0x810C70", Offset = "0x80F670", VA = "0x180810C70")]
		private unsafe void PickUp_OnItemAdded(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail)
		{
			//Discarded unreachable code: IL_007f, IL_0089
			//IL_0046: Expected F4, but got I4
			//IL_0052: Expected F4, but got I4
			HangoutWithCharacter with_ = Data.PickUp.with_;
			Profile profile = Profile;
			if (with_.CurrentHangoutCharacterIsValid(profile))
			{
				float val = targetAmount_;
				List<(uint, uint)> list = default(List<(uint, uint)>);
				int size = ((List<>)(object)list)._size;
				ulong num = num - (ulong)size;
				int num2 = 0;
				int num3 = 0;
				float num4 = Math.Min(val, num3);
				float num5 = SetCurrentAmount(num3, out *(float*)num3);
				MissionSubStep missionSubStep = MissionSubStep;
				ProfileEventDispatcher dispatcher = Dispatcher;
				MissionItemData data = missionSubStep.MissionSlot.Data;
				Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600819A")]
		[Cpp2IlInjected.Address(RVA = "0x806D00", Offset = "0x805700", VA = "0x180806D00")]
		private int GetFindItemCurrentItems()
		{
			//Discarded unreachable code: IL_0027
			//IL_0019: Expected I4, but got I8
			//IL_0022: Expected F4, but got I8
			float val = targetAmount_;
			List<(uint, uint)> list = default(List<(uint, uint)>);
			int size = ((List<>)(object)list)._size;
			ulong num = num - (ulong)size;
			int result = Math.Max(0, (int)num);
			float num2 = Math.Min(val, (long)num);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600819B")]
		[Cpp2IlInjected.Address(RVA = "0x810850", Offset = "0x80F250", VA = "0x180810850")]
		private void PickUp_OnGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [System.Runtime.InteropServices.Optional] GridAddObjectOptions options)
		{
			//Discarded unreachable code: IL_00b4, IL_00e9, IL_00ee, IL_00fb, IL_0100, IL_0112, IL_011c
			//IL_00de: Expected O, but got I4
			if (operation != GridChangedOperation.Remove || gridObject == null || gridObject.ItemID != 0)
			{
				return;
			}
			HangoutWithCharacter with_ = Data.PickUp.with_;
			Profile profile = Profile;
			if (!with_.CurrentHangoutCharacterIsValid(profile))
			{
				return;
			}
			GridLocationFilter pickupLocation_ = Data.PickUp.pickupLocation_;
			Profile profile2 = Profile;
			int num = 0;
			if (ApplyGridLocationFilter(pickupLocation_, grid, gridObject, profile2))
			{
				ItemFilter itemFilter = itemFilter_;
				int itemID = gridObject.ItemID;
				int num2 = default(int);
				if (num2 != 0)
				{
					MissionSubStep missionSubStep = MissionSubStep;
					ProfileEventDispatcher dispatcher = Dispatcher;
					MissionItemData data = missionSubStep.MissionSlot.Data;
					Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
					int itemID2 = gridObject.ItemID;
					throw new NullReferenceException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600819C")]
		[Cpp2IlInjected.Address(RVA = "0x807C90", Offset = "0x806690", VA = "0x180807C90")]
		public List<(uint, uint)> GetPickUpSpawnedItems()
		{
			List<(uint, uint)> result = default(List<(uint, uint)>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600819D")]
		[Cpp2IlInjected.Address(RVA = "0x807CB0", Offset = "0x8066B0", VA = "0x180807CB0")]
		public unsafe List<(uint, uint)> GetPickUpSpawnedItems(out int spawnCount)
		{
			//Discarded unreachable code: IL_007a, IL_0080, IL_0086, IL_008c, IL_0092, IL_0098, IL_009e, IL_00a4, IL_00aa, IL_00b0, IL_00b6, IL_00bc, IL_00c2
			//IL_0078: Expected O, but got I4
			List<(uint, uint)> list;
			bool flag = default(bool);
			string[] array = default(string[]);
			bool flag2 = default(bool);
			while (true)
			{
				int num = (spawnCount.m_value = 0);
				list = (List<(uint, uint)>)(object)new List<T>();
				MapField<string, string> mapField = progressKeys_;
				if (!flag)
				{
					break;
				}
				(new char[1])[0] = '-';
				while (array.Length != 2)
				{
				}
				while (!flag2)
				{
				}
				uint gridID = Convert.ToUInt32(array[0]);
				uint num2 = Convert.ToUInt32(array[1]);
				if (Profile.world_.gridCollection_.TryGetGrid(gridID, out *(IGrid*)num))
				{
					((List<T>)(object)list).Add((T)num);
					break;
				}
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x600819E")]
		[Cpp2IlInjected.Address(RVA = "0x8116A0", Offset = "0x8100A0", VA = "0x1808116A0")]
		private unsafe void RemovePickUpSpawnedObjects()
		{
			//Discarded unreachable code: IL_002d, IL_0033, IL_0039, IL_003f, IL_0045, IL_004b
			int num;
			bool flag = default(bool);
			bool flag2 = default(bool);
			do
			{
				num = 0;
				int num2 = 0;
				List<(uint, uint)> pickUpSpawnedItems = (List<(uint, uint)>)(object)this.GetPickUpSpawnedItems(ref *(int*)num);
				if (flag)
				{
					GridCollection gridCollection_ = Profile.world_.gridCollection_;
					while (!flag2)
					{
					}
				}
			}
			while (num != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600819F")]
		[Cpp2IlInjected.Address(RVA = "0x81ABA0", Offset = "0x8195A0", VA = "0x18081ABA0")]
		private void StartUnlock()
		{
			//Discarded unreachable code: IL_0074, IL_009f, IL_00ca, IL_0149, IL_018f, IL_0194, IL_019e
			//IL_0148: Expected O, but got I4
			if (Data.Unlock.typeCase_ <= CustomStepUnlock.TypeOneofCase.MemoryShard)
			{
				ProfileEventDispatcher dispatcher = Dispatcher;
				ProfileEventDispatcher.BuildingUnlocked value = Unlock_OnBuildingUnlocked;
				dispatcher.OnBuildingUnlocked += value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.BuildingBuilt value2 = Unlock_OnBuildingBuilt;
				dispatcher2.OnBuildingBuilt += value2;
				CustomStepUnlock unlock = Data.Unlock;
				MissionItemData data = MissionSubStep.MissionSlot.Data;
				Item targetBuildingItem = unlock.GetTargetBuildingItem(data);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081A0")]
		[Cpp2IlInjected.Address(RVA = "0x81EA40", Offset = "0x81D440", VA = "0x18081EA40")]
		private void StopUnlock()
		{
			//Discarded unreachable code: IL_00d9
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.BuildingUnlocked value = Unlock_OnBuildingUnlocked;
				dispatcher.OnBuildingUnlocked -= value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.BuildingBuilt value2 = Unlock_OnBuildingBuilt;
				dispatcher2.OnBuildingBuilt -= value2;
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.VillageAreaUnlocked value3 = Unlock_OnVillageAreaUnlocked;
				dispatcher3.OnVillageAreaUnlocked -= value3;
				ProfileEventDispatcher dispatcher4 = Dispatcher;
				ProfileEventDispatcher.RealmUnlocked value4 = Unlock_OnRealmUnlocked;
				dispatcher4.OnRealmUnlocked -= value4;
				ProfileEventDispatcher dispatcher5 = Dispatcher;
				ProfileEventDispatcher.ToolAdded value5 = Unlock_OnToolAdded;
				dispatcher5.OnToolAdded -= value5;
				ProfileEventDispatcher dispatcher6 = Dispatcher;
				ProfileEventDispatcher.MemoryShardAdded value6 = Unlock_OnMemoryShardAdded;
				dispatcher6.OnMemoryShardAdded -= value6;
				ProfileEventDispatcher dispatcher7 = Dispatcher;
				ProfileEventDispatcher.RecipeAdded value7 = Unlock_OnRecipeAdded;
				dispatcher7.OnRecipeAdded -= value7;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081A1")]
		[Cpp2IlInjected.Address(RVA = "0x821D30", Offset = "0x820730", VA = "0x180821D30")]
		private void Unlock_OnBuildingUnlocked(Item item, [System.Runtime.InteropServices.Optional] List<CurrencyCost> costs)
		{
			CheckBuildingUnlockedCompletion(item);
		}

		[Cpp2IlInjected.Token(Token = "0x60081A2")]
		[Cpp2IlInjected.Address(RVA = "0x821D30", Offset = "0x820730", VA = "0x180821D30")]
		private void Unlock_OnBuildingBuilt(Item item)
		{
			CheckBuildingUnlockedCompletion(item);
		}

		[Cpp2IlInjected.Token(Token = "0x60081A3")]
		[Cpp2IlInjected.Address(RVA = "0x802C20", Offset = "0x801620", VA = "0x180802C20")]
		private unsafe void CheckBuildingUnlockedCompletion(Item item)
		{
			//Discarded unreachable code: IL_0119
			int itemID = item.ItemID;
			int num = 0;
			ItemType itemType = default(ItemType);
			if (itemType != ItemType.Building)
			{
				return;
			}
			TargetBuildingType building = Data.Unlock.Building;
			if (building.buildingTypeCase_ != TargetBuildingType.BuildingTypeOneofCase.Any)
			{
				if (building.TargetBuilding == null)
				{
					return;
				}
				BuildingItemType buildingItemType = default(BuildingItemType);
				int num2 = (int)buildingItemType;
				BuildingItemType targetBuildingItemType = building.TargetBuildingItemType;
				if (num2 != (int)targetBuildingItemType)
				{
					return;
				}
				if (building.TargetBuilding.targetCase_ == TargetBuilding.TargetOneofCase.ItemID)
				{
					MissionItemData data = MissionSubStep.MissionSlot.Data;
					Item targetBuildingItem = building.GetTargetBuildingItem(data);
					bool flag = default(bool);
					if (flag)
					{
						return;
					}
				}
				ProfileWorld world_ = Profile.world_;
				bool flag2 = default(bool);
				if (flag2)
				{
					ProfileWorld world_2 = Profile.world_;
					bool flag3 = default(bool);
					if (flag3)
					{
						float currentAmount = CurrentAmount;
						int num3 = 0;
						float num4 = SetCurrentAmount(currentAmount, out *(float*)num3);
						bool flag4 = ChangeStatus(MissionStepStatus.Ongoing);
					}
				}
			}
			else
			{
				ProfileWorld world_3 = Profile.world_;
				bool flag5 = default(bool);
				while (!flag5)
				{
				}
				ProfileWorld world_4 = Profile.world_;
				bool flag6 = default(bool);
				while (!flag6)
				{
				}
				float currentAmount2 = CurrentAmount;
				int num5 = 0;
				if (!(SetCurrentAmount(currentAmount2, out *(float*)num5) >= targetAmount_))
				{
					bool flag7 = ChangeStatus(MissionStepStatus.Ongoing);
				}
				else
				{
					bool flag8 = ChangeStatus(MissionStepStatus.Completed);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081A4")]
		[Cpp2IlInjected.Address(RVA = "0x822130", Offset = "0x820B30", VA = "0x180822130")]
		private void Unlock_OnVillageAreaUnlocked(VillageAreaType areaType, [System.Runtime.InteropServices.Optional] List<CurrencyCost> costs)
		{
			CheckVillageAreaUnlockedCompletion(anyAllowed: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60081A5")]
		[Cpp2IlInjected.Address(RVA = "0x8039A0", Offset = "0x8023A0", VA = "0x1808039A0")]
		private void CheckVillageAreaUnlockedCompletion(bool anyAllowed)
		{
			//Discarded unreachable code: IL_004d
			if (Data.Unlock.Area.targetCase_ != TargetArea.TargetOneofCase.Area)
			{
			}
			Profile profile = Profile;
			MissionObjectiveData missionObjectiveData = Data;
			ProfileWorld world_ = profile.world_;
			VillageAreaType area = missionObjectiveData.Unlock.Area.Area;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = ChangeStatus(MissionStepStatus.Completed);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081A6")]
		[Cpp2IlInjected.Address(RVA = "0x821FE0", Offset = "0x8209E0", VA = "0x180821FE0")]
		private void Unlock_OnRealmUnlocked(string realmName, bool unlockedByFlag)
		{
			CheckRealmUnlockedCompletion(anyAllowed: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60081A7")]
		[Cpp2IlInjected.Address(RVA = "0x822070", Offset = "0x820A70", VA = "0x180822070")]
		private void Unlock_OnToolAdded(Item toolItem)
		{
			//Discarded unreachable code: IL_0030
			Profile profile = Profile;
			MissionObjectiveData missionObjectiveData = Data;
			ProfilePlayer player_ = profile.player_;
			Item toolItem2 = missionObjectiveData.Unlock.ToolItem;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = ChangeStatus(MissionStepStatus.Completed);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081A8")]
		[Cpp2IlInjected.Address(RVA = "0x821D40", Offset = "0x820740", VA = "0x180821D40")]
		private void Unlock_OnMemoryShardAdded(Item memoryShardItem, int shardIndex, AddDetail detail)
		{
			//Discarded unreachable code: IL_00cd
			if (Data.Unlock.MemoryShard.completed_)
			{
				MapField<int, int> memoryShards_ = Profile.player_.memoryShards_;
				Item memoryShardItem2 = Data.Unlock.MemoryShard.MemoryShardItem;
				bool flag = default(bool);
				if (flag)
				{
					Item memoryShardItem3 = Data.Unlock.MemoryShard.MemoryShardItem;
					MemoryShardItemData memoryShardItemData = default(MemoryShardItemData);
					int completedShardFlag = memoryShardItemData.CompletedShardFlag;
					ulong num = default(ulong);
					if (num == (ulong)completedShardFlag)
					{
						goto IL_00c3;
					}
				}
			}
			if (!Data.Unlock.MemoryShard.completed_)
			{
				Profile profile = Profile;
				MissionObjectiveData missionObjectiveData = Data;
				ProfilePlayer player_ = profile.player_;
				Item memoryShardItem4 = missionObjectiveData.Unlock.MemoryShard.MemoryShardItem;
				TargetMemoryShard memoryShard = Data.Unlock.MemoryShard;
				bool flag2 = default(bool);
				if (!flag2)
				{
					return;
				}
				goto IL_00c3;
			}
			return;
			IL_00c3:
			bool flag3 = ChangeStatus(MissionStepStatus.Completed);
		}

		[Cpp2IlInjected.Token(Token = "0x60081A9")]
		[Cpp2IlInjected.Address(RVA = "0x821FF0", Offset = "0x8209F0", VA = "0x180821FF0")]
		private void Unlock_OnRecipeAdded(Item recipe, InvActionType reason)
		{
			//Discarded unreachable code: IL_0030
			Profile profile = Profile;
			MissionObjectiveData missionObjectiveData = Data;
			ProfilePlayer player_ = profile.player_;
			Item recipeItem = missionObjectiveData.Unlock.RecipeItem;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = ChangeStatus(MissionStepStatus.Completed);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081AA")]
		[Cpp2IlInjected.Address(RVA = "0x8038D0", Offset = "0x8022D0", VA = "0x1808038D0")]
		private void CheckRealmUnlockedCompletion(bool anyAllowed)
		{
			//Discarded unreachable code: IL_004d
			if (Data.Unlock.Realm.targetCase_ != TargetRealm.TargetOneofCase.RealmID)
			{
			}
			Profile profile = Profile;
			MissionObjectiveData missionObjectiveData = Data;
			ProfileWorld world_ = profile.world_;
			Item realmItem = missionObjectiveData.Unlock.Realm.RealmItem;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = ChangeStatus(MissionStepStatus.Completed);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081AB")]
		[Cpp2IlInjected.Address(RVA = "0x81AA80", Offset = "0x819480", VA = "0x18081AA80")]
		private void StartUnlockCharacter()
		{
			//Discarded unreachable code: IL_004e
			if (!Data.UnlockCharacter.skipCinematic_)
			{
				ProfileWorld world_ = Profile.world_;
				long num = Convert.ToInt64((uint)targetCharacterItemID_);
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (!flag || (!flag2 && Data.UnlockCharacter.nextState_ != CustomStepUnlockCharacter.Types.UnlockType.LockedInVillage))
				{
					return;
				}
			}
			UnlockCharacterCompleted();
		}

		[Cpp2IlInjected.Token(Token = "0x60081AC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void StopUnlockCharacter()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60081AD")]
		[Cpp2IlInjected.Address(RVA = "0x80C1D0", Offset = "0x80ABD0", VA = "0x18080C1D0")]
		public bool IsUnlockCharacterAlreadyAccomplished()
		{
			//Discarded unreachable code: IL_004c
			if (!Data.UnlockCharacter.skipCinematic_)
			{
				ProfileWorld world_ = Profile.world_;
				long num = Convert.ToInt64((uint)targetCharacterItemID_);
				bool flag = default(bool);
				if (flag)
				{
					bool flag2 = default(bool);
					if (flag2)
					{
						goto IL_004a;
					}
					if (Data.UnlockCharacter.nextState_ != CustomStepUnlockCharacter.Types.UnlockType.LockedInVillage)
					{
					}
				}
				int num2 = 0;
			}
			goto IL_004a;
			IL_004a:
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60081AE")]
		[Cpp2IlInjected.Address(RVA = "0x821BF0", Offset = "0x8205F0", VA = "0x180821BF0")]
		private void UnlockCharacterCompleted()
		{
			//Discarded unreachable code: IL_004d
			int num = 0;
			long num2 = Convert.ToInt64((uint)targetCharacterItemID_);
			CustomStepUnlockCharacter.Types.UnlockType nextState_ = Data.UnlockCharacter.nextState_;
			if (nextState_ == CustomStepUnlockCharacter.Types.UnlockType.Unlocked)
			{
				Profile profile = Profile;
			}
			if (nextState_ == CustomStepUnlockCharacter.Types.UnlockType.LockedInVillage)
			{
				ProfileWorld world_ = Profile.world_;
				ITransactionContext context = Context;
			}
			bool flag = ChangeStatus(MissionStepStatus.Completed);
		}

		[Cpp2IlInjected.Token(Token = "0x60081AF")]
		[Cpp2IlInjected.Address(RVA = "0x81B100", Offset = "0x819B00", VA = "0x18081B100")]
		private void StartUpgrade()
		{
			//Discarded unreachable code: IL_00c5
			CustomStepUpgrade upgrade = Data.Upgrade;
			MissionObjectiveData missionObjectiveData = Data;
			if (upgrade.targetTypeCase_ == CustomStepUpgrade.TargetTypeOneofCase.AmountOfUpgrade)
			{
				int num = 0;
			}
			int num2 = (int)(stepType_ = MissionStepType.StepGameplay);
			CustomStepUpgrade.TargetOneofCase targetCase_ = missionObjectiveData.Upgrade.targetCase_;
			if (targetCase_ == CustomStepUpgrade.TargetOneofCase.Any || Data.Upgrade.targetCase_ == CustomStepUpgrade.TargetOneofCase.BuildingID)
			{
				ProfileEventDispatcher dispatcher = Dispatcher;
				ProfileEventDispatcher.BuidingUpgraded value = Upgrade_OnBuidingUpgraded;
				dispatcher.OnBuidingUpgraded += value;
				if (targetCase_ == CustomStepUpgrade.TargetOneofCase.Any)
				{
				}
				Item buildingItem = Data.Upgrade.BuildingItem;
			}
			if (targetCase_ == CustomStepUpgrade.TargetOneofCase.Any || Data.Upgrade.targetCase_ == CustomStepUpgrade.TargetOneofCase.PlayerLevel)
			{
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.PlayerLevelGained value2 = Upgrade_OnPlayerLevelGained;
				dispatcher2.OnPlayerLevelGained += value2;
				int levelGained = 0;
				CheckPlayerLevelCompletion(levelGained);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081B0")]
		[Cpp2IlInjected.Address(RVA = "0x81ECF0", Offset = "0x81D6F0", VA = "0x18081ECF0")]
		private void StopUpgrade()
		{
			//Discarded unreachable code: IL_003b
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.BuidingUpgraded value = Upgrade_OnBuidingUpgraded;
				dispatcher.OnBuidingUpgraded -= value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.PlayerLevelGained value2 = Upgrade_OnPlayerLevelGained;
				dispatcher2.OnPlayerLevelGained -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081B1")]
		[Cpp2IlInjected.Address(RVA = "0x822990", Offset = "0x821390", VA = "0x180822990")]
		private void Upgrade_OnBuidingUpgraded(GridObject gridObj, UpgradeData upData)
		{
			//Discarded unreachable code: IL_0008
			int itemID = gridObj.ItemID;
		}

		[Cpp2IlInjected.Token(Token = "0x60081B2")]
		[Cpp2IlInjected.Address(RVA = "0x802990", Offset = "0x801390", VA = "0x180802990")]
		private unsafe void CheckBuidingUpgradedCompletion(bool isUpgradeEvent, Item item, int level)
		{
			MissionObjectiveData missionObjectiveData = Data;
			int num = 0;
			if (missionObjectiveData.Upgrade.targetCase_ == CustomStepUpgrade.TargetOneofCase.BuildingID)
			{
				Item buildingItem = Data.Upgrade.BuildingItem;
				bool flag = default(bool);
				if (flag)
				{
					if ((object)Data.Upgrade.BuildingItem == null)
					{
						return;
					}
					ProfileWorld world_ = Profile.world_;
				}
			}
			if (isUpgradeEvent)
			{
				if (Data.Upgrade.targetTypeCase_ == CustomStepUpgrade.TargetTypeOneofCase.TargetLevel)
				{
					throw new NullReferenceException();
				}
				if (isUpgradeEvent && level > 1)
				{
					float currentAmount = CurrentAmount;
					int num2 = 0;
					float num3 = SetCurrentAmount(currentAmount, out *(float*)num2);
					bool flag2 = ChangeStatus(MissionStepStatus.Ongoing);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081B3")]
		[Cpp2IlInjected.Address(RVA = "0x8229F0", Offset = "0x8213F0", VA = "0x1808229F0")]
		private void Upgrade_OnPlayerLevelGained(int gained)
		{
			CheckPlayerLevelCompletion(gained);
		}

		[Cpp2IlInjected.Token(Token = "0x60081B4")]
		[Cpp2IlInjected.Address(RVA = "0x803830", Offset = "0x802230", VA = "0x180803830")]
		private void CheckPlayerLevelCompletion(int levelGained)
		{
			//Discarded unreachable code: IL_003f
			//IL_0025: Expected O, but got I4
			//IL_0025: Expected O, but got I4
			//IL_0025: Expected F4, but got I4
			MissionObjectiveData missionObjectiveData = Data;
			int num = 0;
			if (missionObjectiveData.Upgrade.targetTypeCase_ != CustomStepUpgrade.TargetTypeOneofCase.TargetLevel)
			{
				int num2 = 0;
				int num3 = 0;
				bool flag = UpdateCurrentProgression(num, canChangeState: true, (IGrid)num3, (GridObject)num2);
			}
			else
			{
				ProfilePlayer player_ = Profile.player_;
				bool flag2 = ChangeStatus(MissionStepStatus.Completed);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081B5")]
		[Cpp2IlInjected.Address(RVA = "0x818470", Offset = "0x816E70", VA = "0x180818470")]
		private void StartFriend()
		{
			//Discarded unreachable code: IL_0049
			ProfileEventDispatcher dispatcher = Dispatcher;
			ProfileEventDispatcher.CharacterUnlocked value = Friend_OnCharacterUnlocked;
			dispatcher.OnCharacterUnlocked += value;
			ProfileEventDispatcher dispatcher2 = Dispatcher;
			ProfileEventDispatcher.CharacterFriendshipLevelChanged value2 = Friend_OnCharacterFriendshipLevelChanged;
			dispatcher2.OnCharacterFriendshipLevelChanged += value2;
			Item characterItem = Data.Friend.CharacterItem;
		}

		[Cpp2IlInjected.Token(Token = "0x60081B6")]
		[Cpp2IlInjected.Address(RVA = "0x81DC70", Offset = "0x81C670", VA = "0x18081DC70")]
		private void StopFriend()
		{
			//Discarded unreachable code: IL_003b
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.CharacterUnlocked value = Friend_OnCharacterUnlocked;
				dispatcher.OnCharacterUnlocked -= value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.CharacterFriendshipLevelChanged value2 = Friend_OnCharacterFriendshipLevelChanged;
				dispatcher2.OnCharacterFriendshipLevelChanged -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081B7")]
		[Cpp2IlInjected.Address(RVA = "0x805EB0", Offset = "0x8048B0", VA = "0x180805EB0")]
		private void Friend_OnCharacterUnlocked(Item characterItem)
		{
			CheckFriendCompletion(characterItem);
		}

		[Cpp2IlInjected.Token(Token = "0x60081B8")]
		[Cpp2IlInjected.Address(RVA = "0x805EB0", Offset = "0x8048B0", VA = "0x180805EB0")]
		private void Friend_OnCharacterFriendshipLevelChanged(Item characterItem, int levelsGained)
		{
			CheckFriendCompletion(characterItem);
		}

		[Cpp2IlInjected.Token(Token = "0x60081B9")]
		[Cpp2IlInjected.Address(RVA = "0x803110", Offset = "0x801B10", VA = "0x180803110")]
		private void CheckFriendCompletion(Item characterItem)
		{
			//Discarded unreachable code: IL_00b6
			//IL_00b3: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_00b3: Expected F4, but got I4
			if (Data.Friend.characterCase_ != CustomStepFriend.CharacterOneofCase.Any)
			{
				if ((object)Data.Friend.CharacterItem != null)
				{
					ProfileWorld world_ = Profile.world_;
					int num = 0;
					Character character = default(Character);
					if (character != null)
					{
						int friendshipLevel_ = character.friendshipLevel_;
					}
					CustomStepFriend friend = Data.Friend;
					bool flag = num >= friend.minimumFriendshipLevel_;
					if (num != (flag ? 1 : 0))
					{
						bool flag2 = ChangeStatus(MissionStepStatus.Completed);
					}
				}
				return;
			}
			RepeatedField<Character> characters_ = Profile.world_.characters_;
			Func<Character, bool> func = (Func<Character, bool>)(object)(Func<T, TResult>)delegate(Character x)
			{
				//Discarded unreachable code: IL_002f
				bool isUnlocked = x.IsUnlocked;
				if (!isUnlocked)
				{
					return isUnlocked;
				}
				MissionObjectiveData missionObjectiveData = Data;
				int friendshipLevel_2 = x.friendshipLevel_;
				CustomStepFriend friend2 = missionObjectiveData.Friend;
				return friendshipLevel_2 >= friend2.minimumFriendshipLevel_;
			};
			int num2 = Enumerable.Count<Character>((IEnumerable<>)(object)characters_, (Func<, >)(object)func);
			int num3 = 0;
			float currentAmount = CurrentAmount;
			int num4 = 0;
			int num5 = 0;
			bool flag3 = UpdateCurrentProgression(num3, canChangeState: true, (IGrid)num5, (GridObject)num4);
		}

		[Cpp2IlInjected.Token(Token = "0x60081BA")]
		[Cpp2IlInjected.Address(RVA = "0x81B340", Offset = "0x819D40", VA = "0x18081B340")]
		private void StartVisitArea()
		{
			//Discarded unreachable code: IL_00c5
			//IL_0010: Expected I4, but got I8
			MissionObjectiveData missionObjectiveData = Data;
			goBehaviorInt_ = 4;
			CustomStepVisitArea visitArea = missionObjectiveData.VisitArea;
			CustomStepVisitArea.LocationTypeOneofCase locationTypeCase_ = visitArea.locationTypeCase_;
			if (visitArea != null && visitArea != null && visitArea != null && locationTypeCase_ == CustomStepVisitArea.LocationTypeOneofCase.VillageArea)
			{
				Item inSceneItem = Data.VisitArea.InSceneItem;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
			bool flag2 = ChangeStatus(MissionStepStatus.Ongoing);
			if (Data.VisitArea.IsPerformedServerSide && Data.VisitArea.locationTypeCase_ <= CustomStepVisitArea.LocationTypeOneofCase.InPlayerHouse)
			{
				ProfileEventDispatcher dispatcher = Dispatcher;
				ProfileEventDispatcher.CurrentSceneChanged value = VisitAreaBeforeSceneChange;
				dispatcher.OnCurrentSceneChanged += value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.CurrentSceneChanged value2 = VisitAreaAfterSceneChange;
				dispatcher2.OnCurrentSceneChangedAfterLoading += value2;
				Item _003CCurrentScene_003Ek__BackingField = Profile.player_.CurrentScene;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081BB")]
		[Cpp2IlInjected.Address(RVA = "0x815AE0", Offset = "0x8144E0", VA = "0x180815AE0")]
		private void SetVisitAreaGoBehavior()
		{
			//Discarded unreachable code: IL_0049
			//IL_0010: Expected I4, but got I8
			MissionObjectiveData missionObjectiveData = Data;
			goBehaviorInt_ = 4;
			CustomStepVisitArea visitArea = missionObjectiveData.VisitArea;
			CustomStepVisitArea.LocationTypeOneofCase locationTypeCase_ = visitArea.locationTypeCase_;
			if (visitArea != null && visitArea != null && visitArea != null && locationTypeCase_ == CustomStepVisitArea.LocationTypeOneofCase.VillageArea)
			{
				Item inSceneItem = Data.VisitArea.InSceneItem;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081BC")]
		[Cpp2IlInjected.Address(RVA = "0x822A20", Offset = "0x821420", VA = "0x180822A20")]
		private void VisitAreaBeforeSceneChange(Item previousScene, Item currentScene)
		{
			int isAfterLoading = 0;
			OnVisitAreaSceneChange(previousScene, currentScene, (byte)isAfterLoading != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60081BD")]
		[Cpp2IlInjected.Address(RVA = "0x822A00", Offset = "0x821400", VA = "0x180822A00")]
		private void VisitAreaAfterSceneChange(Item previousScene, Item currentScene)
		{
			OnVisitAreaSceneChange(previousScene, currentScene, isAfterLoading: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60081BE")]
		[Cpp2IlInjected.Address(RVA = "0x810460", Offset = "0x80EE60", VA = "0x180810460")]
		private void OnVisitAreaSceneChange(Item previousScene, Item currentScene, bool isAfterLoading)
		{
			//Discarded unreachable code: IL_0035
			int num = 0;
			int itemID = currentScene.ItemID;
			if (status_ == MissionStepStatus.Ongoing == isAfterLoading && (long)this != 5 && (long)this == 6 && Data.VisitArea.autoConfirm_)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081BF")]
		[Cpp2IlInjected.Address(RVA = "0x803A70", Offset = "0x802470", VA = "0x180803A70")]
		private bool CheckVisitAreaManualCompletion(MissionCompleteStep.Types.Condition condition)
		{
			//Discarded unreachable code: IL_0024
			if (condition == MissionCompleteStep.Types.Condition.VisitEnterLocation || condition != MissionCompleteStep.Types.Condition.VisitExitLocation || !Data.VisitArea.autoConfirm_)
			{
			}
			return ChangeStatus(MissionStepStatus.Completed);
		}

		[Cpp2IlInjected.Token(Token = "0x60081C0")]
		[Cpp2IlInjected.Address(RVA = "0x81EDE0", Offset = "0x81D7E0", VA = "0x18081EDE0")]
		private void StopVisitArea()
		{
			//Discarded unreachable code: IL_003b
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.CurrentSceneChanged value = VisitAreaBeforeSceneChange;
				dispatcher.OnCurrentSceneChanged -= value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.CurrentSceneChanged value2 = VisitAreaAfterSceneChange;
				dispatcher2.OnCurrentSceneChangedAfterLoading -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081C1")]
		[Cpp2IlInjected.Address(RVA = "0x81A580", Offset = "0x818F80", VA = "0x18081A580")]
		private void StartSellItem()
		{
			//Discarded unreachable code: IL_00ae
			//IL_0034: Expected I4, but got I8
			//IL_003d: Expected I4, but got I8
			if (!Data.SellItem.mustSellSpecificItems_)
			{
				ItemFilter itemFilter = itemFilter_;
				if ((long)itemFilter.data_ == 0)
				{
					ItemFilterData itemFilterData = new ItemFilterData();
					itemFilterData.type_ = ItemType.ActivityItem;
					itemFilterData.activityItemType_ = ActivityItemType.Flower;
					itemFilter.data_ = itemFilterData;
				}
			}
			UpdatedSellItemGoBehavior();
			MissionObjectiveData missionObjectiveData = Data;
			ProfileEventDispatcher dispatcher = Dispatcher;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.ShopItemsSold value = Dispatcher_SellItem_OnShopItemsSold;
			dispatcher.OnShopItemsSold += value;
			ProfileEventDispatcher dispatcher2 = Dispatcher;
			ProfileEventDispatcher.ItemAdded value2 = Dispatcher_SellItem_OnItemAdded;
			dispatcher2.OnItemAdded += value2;
			bool flag2 = ChangeStatus(MissionStepStatus.Ongoing);
		}

		[Cpp2IlInjected.Token(Token = "0x60081C2")]
		[Cpp2IlInjected.Address(RVA = "0x8165D0", Offset = "0x814FD0", VA = "0x1808165D0")]
		private void SetupSellItemStep()
		{
			//Discarded unreachable code: IL_0067
			//IL_0034: Expected I4, but got I8
			//IL_003d: Expected I4, but got I8
			if (!Data.SellItem.mustSellSpecificItems_)
			{
				ItemFilter itemFilter = itemFilter_;
				if ((long)itemFilter.data_ == 0)
				{
					ItemFilterData itemFilterData = new ItemFilterData();
					itemFilterData.type_ = ItemType.ActivityItem;
					itemFilterData.activityItemType_ = ActivityItemType.Flower;
					itemFilter.data_ = itemFilterData;
				}
			}
			UpdatedSellItemGoBehavior();
			MissionObjectiveData missionObjectiveData = Data;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60081C3")]
		[Cpp2IlInjected.Address(RVA = "0x805310", Offset = "0x803D10", VA = "0x180805310")]
		private void Dispatcher_SellItem_OnShopItemsSold(string shopName, IInventory inventory, IEnumerable<ItemInstance> items, IEnumerable<CurrencyCost> costs)
		{
			//Discarded unreachable code: IL_005c, IL_0062, IL_0068, IL_006e, IL_0074, IL_007a, IL_0080
			int num = 0;
			Func<Item, int, bool> func = (Func<Item, int, bool>)(object)(Func<T1, T2, TResult>)delegate(Item item, int amount)
			{
				bool flag3 = default(bool);
				if (flag3 && amount > 0)
				{
					int num3 = 0;
					RepeatedField<int> repeatedField = itemIdsCollected_;
					float currentAmount = CurrentAmount;
					float num4 = default(float);
					if (!(num4 >= targetAmount_))
					{
					}
					bool flag4 = ChangeStatus(MissionStepStatus.Completed);
					return true;
				}
				int num5 = 0;
				throw new NullReferenceException();
			};
			int itemID = default(int);
			if (func != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_004b;
					}
					num++;
				}
				Item item2 = default(Item);
				itemID = item2.ItemID;
				if (Data.SellItem.mustSellSpecificItems_)
				{
					ItemFilter itemFilter = itemFilter_;
					bool flag = default(bool);
					while (!flag)
					{
					}
					goto IL_004b;
				}
				goto IL_0052;
			}
			goto IL_0057;
			IL_0052:
			bool flag2 = default(bool);
			while (!flag2)
			{
			}
			goto IL_0057;
			IL_0057:
			if (func == null)
			{
			}
			return;
			IL_004b:
			itemID += itemID;
			goto IL_0052;
		}

		[Cpp2IlInjected.Token(Token = "0x60081C4")]
		[Cpp2IlInjected.Address(RVA = "0x8052B0", Offset = "0x803CB0", VA = "0x1808052B0")]
		private void Dispatcher_SellItem_OnItemAdded(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail)
		{
			if (inventory != null && inventory != null)
			{
				UpdatedSellItemGoBehavior();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081C5")]
		[Cpp2IlInjected.Address(RVA = "0x822780", Offset = "0x821180", VA = "0x180822780")]
		private void UpdatedSellItemGoBehavior()
		{
			//Discarded unreachable code: IL_008b
			//IL_007c: Expected I4, but got I8
			//IL_008a: Expected I4, but got I8
			Dictionary<(Item, ItemState), int> allItems = (Dictionary<(Item, ItemState), int>)(object)Profile.Backpack.GetAllItems();
			Dictionary<(Item, ItemState), int> itemsQuantityByItem = (Dictionary<(Item, ItemState), int>)(object)itemFilter_.GetItemsQuantityByItem((Dictionary<, >)(object)allItems);
			if (!Data.SellItem.mustSellSpecificItems_)
			{
				Func<KeyValuePair<(Item, ItemState), int>, int> func = default(Func<KeyValuePair<(Item, ItemState), int>, int>);
				if (_003C_003Ec._003C_003E9__276_0 == null)
				{
					func = (Func<KeyValuePair<(Item, ItemState), int>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				int num = Enumerable.Sum<KeyValuePair<(Item, ItemState), int>>((IEnumerable<>)allItems, (Func<, >)(object)func);
			}
			ItemFilter itemFilter = itemFilter_;
			if (Data.SellItem.mustSellSpecificItems_)
			{
				goBehaviorInt_ = 2;
			}
			else
			{
				goBehaviorInt_ = 65540;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081C6")]
		[Cpp2IlInjected.Address(RVA = "0x81E830", Offset = "0x81D230", VA = "0x18081E830")]
		private void StopSellItem()
		{
			//Discarded unreachable code: IL_003b
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.ShopItemsSold value = Dispatcher_SellItem_OnShopItemsSold;
				dispatcher.OnShopItemsSold -= value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.ItemAdded value2 = Dispatcher_SellItem_OnItemAdded;
				dispatcher2.OnItemAdded -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081C7")]
		[Cpp2IlInjected.Address(RVA = "0x81A730", Offset = "0x819130", VA = "0x18081A730")]
		private void StartServeRestaurantOrder()
		{
			//Discarded unreachable code: IL_0038
			MissionObjectiveData missionObjectiveData = Data;
			ProfileEventDispatcher dispatcher = Dispatcher;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.RestaurantOrderFulfilled value = Dispatcher_ServeRestaurantOrder_OnRestaurantOrderFulfilled;
			dispatcher.OnRestaurantOrderFulfilled += value;
		}

		[Cpp2IlInjected.Token(Token = "0x60081C8")]
		[Cpp2IlInjected.Address(RVA = "0x8055B0", Offset = "0x803FB0", VA = "0x1808055B0")]
		private void Dispatcher_ServeRestaurantOrder_OnRestaurantOrderFulfilled(CharacterRestaurantOrder order, ItemWithState mealServed)
		{
			//Discarded unreachable code: IL_0050
			//IL_004d: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			if (order.fulfilled_)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = mealServed.Item;
				MissionObjectiveData missionObjectiveData = Data;
				MealItemData mealItemData = default(MealItemData);
				int starRating_ = mealItemData.starRating_;
				ScalableValue value = missionObjectiveData.ServeRestaurantOrder.MinimumStarRating.Value;
				int num = 0;
				int num2 = 0;
				bool flag = UpdateCurrentProgression(1f, canChangeState: true, (IGrid)num2, (GridObject)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081C9")]
		[Cpp2IlInjected.Address(RVA = "0x81E920", Offset = "0x81D320", VA = "0x18081E920")]
		private void StopServeRestaurantOrder()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.RestaurantOrderFulfilled value = Dispatcher_ServeRestaurantOrder_OnRestaurantOrderFulfilled;
				dispatcher.OnRestaurantOrderFulfilled -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081CA")]
		[Cpp2IlInjected.Address(RVA = "0x81A180", Offset = "0x818B80", VA = "0x18081A180")]
		private void StartPurchaseItem()
		{
			//Discarded unreachable code: IL_00c3
			//IL_0016: Expected I4, but got I8
			//IL_005b: Expected I4, but got I8
			//IL_0068: Expected I4, but got I8
			MissionObjectiveData missionObjectiveData = Data;
			int num = 0;
			goBehaviorInt_ = 65540;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			if (missionObjectiveData.PurchaseItem.mustPurchaseSpecificItems_)
			{
				ItemType type_ = itemFilter_.data_.type_;
				if (type_ != ItemType.ActivityItem && type_ <= ItemType.Character)
				{
					goBehaviorInt_ = 130;
				}
				goBehaviorInt_ = 65668;
			}
			if (Data.PurchaseItem.locationCase_ == CustomStepPurchaseItem.LocationOneofCase.Store)
			{
				ProfileEventDispatcher dispatcher = Dispatcher;
				ProfileEventDispatcher.StoreItemBought value = Dispatcher_PurchaseItem_OnStoreItemBought;
				dispatcher.OnStoreItemBought += value;
			}
			ProfileEventDispatcher dispatcher2 = Dispatcher;
			ProfileEventDispatcher.ShopItemBought value2 = Dispatcher_PurchaseItem_OnShopItemBought;
			dispatcher2.OnShopItemBought += value2;
			bool flag2 = ChangeStatus(MissionStepStatus.Ongoing);
		}

		[Cpp2IlInjected.Token(Token = "0x60081CB")]
		[Cpp2IlInjected.Address(RVA = "0x810FD0", Offset = "0x80F9D0", VA = "0x180810FD0")]
		private void PurchaseItemProgress(Item item, int amount)
		{
			//Discarded unreachable code: IL_006e
			if ((object)typeof(Item).TypeHandle != null)
			{
				return;
			}
			if (Data.PurchaseItem.mustPurchaseSpecificItems_)
			{
				ItemFilter itemFilter = itemFilter_;
				bool flag = default(bool);
				if (!flag)
				{
					return;
				}
			}
			int num = 0;
			RepeatedField<int> repeatedField = itemIdsCollected_;
			float currentAmount = CurrentAmount;
			bool flag2 = ChangeStatus(MissionStepStatus.Ongoing);
			MissionSubStep missionSubStep = MissionSubStep;
			ProfileEventDispatcher dispatcher = Dispatcher;
			MissionItemData data = missionSubStep.MissionSlot.Data;
			Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60081CC")]
		[Cpp2IlInjected.Address(RVA = "0x805120", Offset = "0x803B20", VA = "0x180805120")]
		private void Dispatcher_PurchaseItem_OnShopItemBought(string shopName, Item item, int amount, CurrencyCost cost, bool isDelivery)
		{
			do
			{
				CustomStepPurchaseItem.LocationOneofCase locationCase_ = Data.PurchaseItem.locationCase_;
				if (locationCase_ == CustomStepPurchaseItem.LocationOneofCase.Store)
				{
					return;
				}
				if (locationCase_ != CustomStepPurchaseItem.LocationOneofCase.Shop)
				{
					break;
				}
				while (locationCase_ != CustomStepPurchaseItem.LocationOneofCase.Shop)
				{
				}
			}
			while (Data.PurchaseItem.Shop == null && Data.PurchaseItem.Shop != shopName);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60081CD")]
		[Cpp2IlInjected.Address(RVA = "0x805220", Offset = "0x803C20", VA = "0x180805220")]
		private void Dispatcher_PurchaseItem_OnStoreItemBought(Item building, Item item, int displayIdx)
		{
			//Discarded unreachable code: IL_0030
			MissionObjectiveData missionObjectiveData = Data;
			int itemID = building.ItemID;
			if (missionObjectiveData.PurchaseItem.Store != 0 && Data.PurchaseItem.Store != itemID)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081CE")]
		[Cpp2IlInjected.Address(RVA = "0x81E620", Offset = "0x81D020", VA = "0x18081E620")]
		private void StopPurchaseItem()
		{
			//Discarded unreachable code: IL_003b
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.ShopItemBought value = Dispatcher_PurchaseItem_OnShopItemBought;
				dispatcher.OnShopItemBought -= value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.StoreItemBought value2 = Dispatcher_PurchaseItem_OnStoreItemBought;
				dispatcher2.OnStoreItemBought -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081CF")]
		[Cpp2IlInjected.Address(RVA = "0x8199A0", Offset = "0x8183A0", VA = "0x1808199A0")]
		private void StartPossess()
		{
			//Discarded unreachable code: IL_0184, IL_01a0, IL_01af, IL_01be, IL_01c4, IL_01d2, IL_01e3, IL_01e9, IL_01ef, IL_01fd, IL_020c, IL_0212, IL_0220, IL_022f, IL_0235
			//IL_0149: Expected I4, but got I8
			//IL_017b: Expected F4, but got I4
			ProfileEventDispatcher dispatcher = Dispatcher;
			ProfileEventDispatcher.TransactionStateChanged value = OnPossessTransactionScopeStateChanged;
			dispatcher.OnTransactionStateChanged += value;
			ItemFilterData data_ = itemFilter_.data_;
			ItemType type_ = data_.type_;
			if ((long)data_ <= 12)
			{
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.CharacterUnlocked value2 = OnPossessCharacterUnlocked;
				dispatcher2.OnCharacterUnlocked += value2;
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.ItemAdded value3 = OnPossessInventoryItemAdded;
				dispatcher3.OnItemAdded += value3;
				ProfileEventDispatcher dispatcher4 = Dispatcher;
				ProfileEventDispatcher.ItemRemoved value4 = OnPossessInventoryRemoved;
				dispatcher4.OnItemRemoved += value4;
				ProfileEventDispatcher dispatcher5 = Dispatcher;
				ProfileEventDispatcher.ItemMoved value5 = OnPossessInventoryMoved;
				dispatcher5.OnItemMoved += value5;
				ProfileEventDispatcher dispatcher6 = Dispatcher;
				ProfileEventDispatcher.CurrencyChanged value6 = OnPossessCurrencyChanged;
				dispatcher6.OnCurrencyChanged += value6;
				ProfileEventDispatcher dispatcher7 = Dispatcher;
				ProfileEventDispatcher.ToolAdded value7 = OnPossessToolUnlocked;
				dispatcher7.OnToolAdded += value7;
				ProfileEventDispatcher dispatcher8 = Dispatcher;
				ProfileEventDispatcher.MemoryShardAdded value8 = OnPossessMemoryShardAdded;
				dispatcher8.OnMemoryShardAdded += value8;
			}
			if (type_ == ItemType.Dialogue)
			{
				ProfileEventDispatcher dispatcher9 = Dispatcher;
				ProfileEventDispatcher.DialogueFlagChange value9 = OnPossessDialogueFlagChanged;
				dispatcher9.OnDialogueFlagChange += value9;
				MissionObjectiveData missionObjectiveData = Data;
				goBehaviorInt_ = 2;
				int num = 0;
				Paused = false;
				bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
				int num2 = 0;
				int possessCurrentAmount = GetPossessCurrentAmount();
				CurrentAmount = num2;
				float currentAmount = CurrentAmount;
				return;
			}
			object[] array = new object[4];
			ItemFilter itemFilter = ItemFilter;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60081D0")]
		[Cpp2IlInjected.Address(RVA = "0x822700", Offset = "0x821100", VA = "0x180822700")]
		private unsafe void UpdatePossessStatus(bool withCallback = false)
		{
			//IL_001b: Expected F4, but got I4
			//IL_002f: Expected F4, but got I4
			Paused = false;
			if (!withCallback)
			{
				int num = 0;
				int possessCurrentAmount = GetPossessCurrentAmount();
				CurrentAmount = num;
			}
			int num2 = 0;
			int num3 = 0;
			int possessCurrentAmount2 = GetPossessCurrentAmount();
			float num4 = SetCurrentAmount(num3, out *(float*)num2);
			float currentAmount = CurrentAmount;
			bool flag = ChangeStatus(MissionStepStatus.Completed);
		}

		[Cpp2IlInjected.Token(Token = "0x60081D1")]
		[Cpp2IlInjected.Address(RVA = "0x808080", Offset = "0x806A80", VA = "0x180808080")]
		private int GetPossessCurrentAmount()
		{
			//Discarded unreachable code: IL_00e8, IL_00f9, IL_010e, IL_012e, IL_0143, IL_014b, IL_0160, IL_016b, IL_0180, IL_0188, IL_01a1, IL_01a9, IL_01c2
			ItemFilter itemFilter = itemFilter_;
			ItemFilterData data_ = itemFilter.data_;
			ItemType type_ = data_.type_;
			if ((long)data_ <= 12)
			{
				RepeatedField<Character> characters_ = Profile.world_.characters_;
				Func<Character, bool> _003C_003E9__288_ = _003C_003Ec._003C_003E9__288_0;
				if (_003C_003E9__288_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Character x) => x.InVillage);
				}
				IEnumerable<Character> enumerable = (IEnumerable<Character>)Enumerable.Where<Character>((IEnumerable<>)(object)characters_, (Func<, >)(object)_003C_003E9__288_);
				Func<Character, Item> func = default(Func<Character, Item>);
				if (_003C_003Ec._003C_003E9__288_1 == null)
				{
					func = (Func<Character, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Character x) => x.base_.Item));
				}
				Func<Character, int> func2 = default(Func<Character, int>);
				if (_003C_003Ec._003C_003E9__288_2 == null)
				{
					func2 = (Func<Character, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Character x) => 1));
				}
				Dictionary<Character, Item> dictionary = (Dictionary<Character, Item>)(object)Enumerable.ToDictionary<Character, Item, int>((IEnumerable<>)enumerable, (Func<, >)(object)func, (Func<, >)(object)func2);
				int num = 0;
				int itemsQuantity = itemFilter.GetItemsQuantity((Dictionary<, >)(object)dictionary, (byte)num != 0);
				CustomStepPossess customStepPossess = default(CustomStepPossess);
				bool useDifferentItem_ = customStepPossess.useDifferentItem_;
				CustomStepPossess customStepPossess2 = default(CustomStepPossess);
				bool includeStorage_ = customStepPossess2.includeStorage_;
				ListInventory listInventory = default(ListInventory);
				Dictionary<(Item, ItemState), int> allItems = (Dictionary<(Item, ItemState), int>)(object)listInventory.GetAllItems();
				CustomStepPossess customStepPossess3 = default(CustomStepPossess);
				bool useDifferentItem_2 = customStepPossess3.useDifferentItem_;
				return itemFilter.GetItemsQuantity((Dictionary<, >)(object)allItems, useDifferentItem_2);
			}
			if (type_ == ItemType.Dialogue)
			{
				RepeatedField<int> dialogueFlags_ = Profile.world_.dialogueFlags_;
				Func<int, Item> func3 = default(Func<int, Item>);
				if (_003C_003Ec._003C_003E9__288_5 == null)
				{
					func3 = (Func<int, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => (Item)typeof(Item).TypeHandle));
				}
				Func<int, int> func4 = default(Func<int, int>);
				if (_003C_003Ec._003C_003E9__288_6 == null)
				{
					func4 = (Func<int, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => 1));
				}
				Dictionary<int, Item> dictionary2 = (Dictionary<int, Item>)(object)Enumerable.ToDictionary<int, Item, int>((IEnumerable<>)(object)dialogueFlags_, (Func<, >)(object)func3, (Func<, >)(object)func4);
				throw new NullReferenceException();
			}
			Exception ex = new Exception("GetPossesCurrentAmount() implementation is incomplet");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60081D2")]
		[Cpp2IlInjected.Address(RVA = "0x810350", Offset = "0x80ED50", VA = "0x180810350")]
		private void OnPossessTransactionScopeStateChanged(bool isActive)
		{
			//IL_0034: Expected F4, but got I4
			if (status_ <= MissionStepStatus.ReadyToBeCompleted && Paused != isActive)
			{
				Paused = isActive;
				if (!isActive)
				{
					Paused = isActive;
					int num = 0;
					int possessCurrentAmount = GetPossessCurrentAmount();
					CurrentAmount = num;
					float currentAmount = CurrentAmount;
					bool flag = ChangeStatus(MissionStepStatus.Completed);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081D3")]
		[Cpp2IlInjected.Address(RVA = "0x80FA50", Offset = "0x80E450", VA = "0x18080FA50")]
		private unsafe void OnPossessInventoryItemAdded(IInventory inventory, Item item, int amount, ItemState state, [System.Runtime.InteropServices.Optional] AddDetail detail)
		{
			//IL_0057: Expected O, but got I4
			//IL_00b5: Expected F4, but got I4
			int itemID = item.ItemID;
			if (Paused)
			{
				return;
			}
			ItemFilter itemFilter = itemFilter_;
			int num = 0;
			int num2 = default(int);
			if (num2 == 0)
			{
				return;
			}
			if ((Data.Possess.useDifferentItem_ ? 1 : 0) == num)
			{
				bool useDifferentItem_ = Data.Possess.useDifferentItem_;
				int num3 = 0;
				bool flag = !((RepeatedField<T>)(object)itemIdsCollected_).Remove((T)itemID);
				if (useDifferentItem_ == flag)
				{
					if (useDifferentItem_)
					{
					}
					bool flag2 = default(bool);
					bool flag3 = !flag2;
					if (useDifferentItem_ == flag3)
					{
						if (useDifferentItem_)
						{
						}
						float currentAmount = CurrentAmount;
						float num4 = default(float);
						if (!(num4 >= targetAmount_))
						{
							bool flag4 = ChangeStatus(MissionStepStatus.Ongoing);
							return;
						}
					}
				}
				float currentAmount2 = CurrentAmount;
			}
			int num5 = 0;
			int num6 = 0;
			int possessCurrentAmount = GetPossessCurrentAmount();
			float num7 = SetCurrentAmount(num6, out *(float*)num5);
			float currentAmount3 = CurrentAmount;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60081D4")]
		[Cpp2IlInjected.Address(RVA = "0x80FE30", Offset = "0x80E830", VA = "0x18080FE30")]
		private unsafe void OnPossessInventoryRemoved(IInventory inventory, Item item, int amount, ItemState state, InvActionType reason = InvActionType.None)
		{
			//IL_0057: Expected O, but got I4
			//IL_00b5: Expected F4, but got I4
			int itemID = item.ItemID;
			if (Paused)
			{
				return;
			}
			ItemFilter itemFilter = itemFilter_;
			int num = 0;
			int num2 = default(int);
			if (num2 == 0)
			{
				return;
			}
			if ((Data.Possess.useDifferentItem_ ? 1 : 0) == num)
			{
				bool useDifferentItem_ = Data.Possess.useDifferentItem_;
				int num3 = 0;
				bool flag = !((RepeatedField<T>)(object)itemIdsCollected_).Remove((T)itemID);
				if (useDifferentItem_ == flag)
				{
					if (useDifferentItem_)
					{
					}
					bool flag2 = default(bool);
					bool flag3 = !flag2;
					if (useDifferentItem_ == flag3)
					{
						if (useDifferentItem_)
						{
						}
						float currentAmount = CurrentAmount;
						float num4 = default(float);
						if (!(num4 >= targetAmount_))
						{
							bool flag4 = ChangeStatus(MissionStepStatus.Ongoing);
							return;
						}
					}
				}
				float currentAmount2 = CurrentAmount;
			}
			int num5 = 0;
			int num6 = 0;
			int possessCurrentAmount = GetPossessCurrentAmount();
			float num7 = SetCurrentAmount(num6, out *(float*)num5);
			float currentAmount3 = CurrentAmount;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60081D5")]
		[Cpp2IlInjected.Address(RVA = "0x80FCB0", Offset = "0x80E6B0", VA = "0x18080FCB0")]
		private void OnPossessInventoryMoved(ContainerInventory source, int sourcePosition, ContainerInventory destination, int[] destinationPositions, Item item, ItemState state, int amountMoved, ContainerInventoryMoveAction action)
		{
			//Discarded unreachable code: IL_007c
			if (Paused)
			{
				return;
			}
			if (Data.Possess.includeStorage_)
			{
				bool belongsToPlayer_ = destination.belongsToPlayer_;
			}
			if (source == destination)
			{
				return;
			}
			ContainerInventory backpack = Profile.Backpack;
			if (source != backpack)
			{
				ContainerInventory backpack2 = Profile.Backpack;
				if (destination != backpack2)
				{
					return;
				}
			}
			if (Data.Possess.includeStorage_)
			{
			}
			ContainerInventory backpack3 = Profile.Backpack;
			bool flag = source == backpack3;
			int num = 0;
			if (flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081D6")]
		[Cpp2IlInjected.Address(RVA = "0x80F660", Offset = "0x80E060", VA = "0x18080F660")]
		private unsafe void OnPossessCharacterUnlocked(Item characterItem)
		{
			//Discarded unreachable code: IL_004f
			//IL_001b: Expected O, but got I4
			if (Paused)
			{
				return;
			}
			ItemFilter itemFilter = itemFilter_;
			int num = 0;
			if (itemFilter.GetItemQuantity(characterItem, 1, (ItemState)num) != 0)
			{
				bool flag = default(bool);
				if (flag)
				{
					float currentAmount = CurrentAmount;
					int num2 = 0;
					float num3 = SetCurrentAmount(currentAmount, out *(float*)num2);
				}
				float currentAmount2 = CurrentAmount;
				if (flag)
				{
					bool flag2 = ChangeStatus(MissionStepStatus.Completed);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081D7")]
		[Cpp2IlInjected.Address(RVA = "0x810270", Offset = "0x80EC70", VA = "0x180810270")]
		private unsafe void OnPossessToolUnlocked(Item toolItem)
		{
			//Discarded unreachable code: IL_003f
			//IL_001b: Expected O, but got I4
			if (!Paused)
			{
				ItemFilter itemFilter = itemFilter_;
				int num = 0;
				if (itemFilter.GetItemQuantity(toolItem, 1, (ItemState)num) != 0)
				{
					float currentAmount = CurrentAmount;
					int num2 = 0;
					float num3 = SetCurrentAmount(currentAmount, out *(float*)num2);
					bool flag = ChangeStatus(MissionStepStatus.Completed);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081D8")]
		[Cpp2IlInjected.Address(RVA = "0x80F8C0", Offset = "0x80E2C0", VA = "0x18080F8C0")]
		private unsafe void OnPossessDialogueFlagChanged(Item flagItem, bool active)
		{
			//Discarded unreachable code: IL_0070
			//IL_0022: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			int itemID = flagItem.ItemID;
			if (Paused)
			{
				return;
			}
			ItemFilter itemFilter = itemFilter_;
			int num = 0;
			if (itemFilter.GetItemQuantity(flagItem, active ? 1 : 0, (ItemState)num) != 0)
			{
				if (!active)
				{
					bool flag = ((RepeatedField<T>)(object)itemIdsCollected_).Remove((T)itemID);
					float currentAmount = CurrentAmount;
					int num2 = 0;
					float num3 = SetCurrentAmount(currentAmount, out *(float*)num2);
				}
				else
				{
					float currentAmount2 = CurrentAmount;
					int num4 = 0;
					float num5 = SetCurrentAmount(currentAmount2, out *(float*)num4);
					bool flag2 = ChangeStatus(MissionStepStatus.Completed);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081D9")]
		[Cpp2IlInjected.Address(RVA = "0x810090", Offset = "0x80EA90", VA = "0x180810090")]
		private unsafe void OnPossessMemoryShardAdded(Item memoryShardItem, int memoryShardIndex, AddDetail detail)
		{
			//Discarded unreachable code: IL_005b
			//IL_0026: Expected O, but got I4
			//IL_0027: Expected I4, but got O
			int itemID = memoryShardItem.ItemID;
			if (!Paused)
			{
				int num = (int)((MapField<TKey, TValue>)(object)Profile.player_.memoryShards_)[(TKey)itemID];
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				MemoryShardItemData memoryShardItemData = default(MemoryShardItemData);
				int completedShardFlag = memoryShardItemData.CompletedShardFlag;
				if (num == completedShardFlag)
				{
					float currentAmount = CurrentAmount;
					int num2 = 0;
					float num3 = SetCurrentAmount(currentAmount, out *(float*)num2);
					bool flag = ChangeStatus(MissionStepStatus.Completed);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081DA")]
		[Cpp2IlInjected.Address(RVA = "0x80F760", Offset = "0x80E160", VA = "0x18080F760")]
		private void OnPossessCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			//Discarded unreachable code: IL_004d
			//IL_0026: Expected O, but got I4
			//IL_0038: Expected O, but got I4
			int itemID = currencyItem.ItemID;
			if (!Paused && gained != 0)
			{
				ItemFilter itemFilter = itemFilter_;
				int num = 0;
				if (itemFilter.GetItemQuantity(currencyItem, gained, (ItemState)num) != 0)
				{
					int num2 = 0;
					bool flag = ((RepeatedField<T>)(object)itemIdsCollected_).Remove((T)itemID);
					float currentAmount = CurrentAmount;
					bool flag2 = ChangeStatus(MissionStepStatus.Ongoing);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081DB")]
		[Cpp2IlInjected.Address(RVA = "0x81E2C0", Offset = "0x81CCC0", VA = "0x18081E2C0")]
		private void StopPossess()
		{
			//Discarded unreachable code: IL_0117
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.TransactionStateChanged value = OnPossessTransactionScopeStateChanged;
				dispatcher.OnTransactionStateChanged -= value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.ItemAdded value2 = OnPossessInventoryItemAdded;
				dispatcher2.OnItemAdded -= value2;
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.ItemRemoved value3 = OnPossessInventoryRemoved;
				dispatcher3.OnItemRemoved -= value3;
				ProfileEventDispatcher dispatcher4 = Dispatcher;
				ProfileEventDispatcher.ItemMoved value4 = OnPossessInventoryMoved;
				dispatcher4.OnItemMoved -= value4;
				ProfileEventDispatcher dispatcher5 = Dispatcher;
				ProfileEventDispatcher.CharacterUnlocked value5 = OnPossessCharacterUnlocked;
				dispatcher5.OnCharacterUnlocked -= value5;
				ProfileEventDispatcher dispatcher6 = Dispatcher;
				ProfileEventDispatcher.ToolAdded value6 = OnPossessToolUnlocked;
				dispatcher6.OnToolAdded -= value6;
				ProfileEventDispatcher dispatcher7 = Dispatcher;
				ProfileEventDispatcher.DialogueFlagChange value7 = OnPossessDialogueFlagChanged;
				dispatcher7.OnDialogueFlagChange -= value7;
				ProfileEventDispatcher dispatcher8 = Dispatcher;
				ProfileEventDispatcher.MemoryShardAdded value8 = OnPossessMemoryShardAdded;
				dispatcher8.OnMemoryShardAdded -= value8;
				ProfileEventDispatcher dispatcher9 = Dispatcher;
				ProfileEventDispatcher.CurrencyChanged value9 = OnPossessCurrencyChanged;
				dispatcher9.OnCurrencyChanged -= value9;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081DC")]
		[Cpp2IlInjected.Address(RVA = "0x817530", Offset = "0x815F30", VA = "0x180817530")]
		private void StartConsumeItem()
		{
			//Discarded unreachable code: IL_0038
			MissionObjectiveData missionObjectiveData = Data;
			ProfileEventDispatcher dispatcher = Dispatcher;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.ItemConsumed value = OnItemConsumed;
			dispatcher.OnItemConsumed += value;
		}

		[Cpp2IlInjected.Token(Token = "0x60081DD")]
		[Cpp2IlInjected.Address(RVA = "0x81D430", Offset = "0x81BE30", VA = "0x18081D430")]
		private void StopConsumeItem()
		{
			//Discarded unreachable code: IL_001c
			ProfileEventDispatcher dispatcher = Dispatcher;
			ProfileEventDispatcher.ItemConsumed value = OnItemConsumed;
			dispatcher.OnItemConsumed -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x60081DE")]
		[Cpp2IlInjected.Address(RVA = "0x80E6E0", Offset = "0x80D0E0", VA = "0x18080E6E0")]
		private unsafe void OnItemConsumed(Item consumedItem, MultiItemInstance generatedItems)
		{
			//Discarded unreachable code: IL_0068
			//IL_0016: Expected O, but got I4
			//IL_0016: Expected O, but got I4
			ItemFilter itemFilter = itemFilter_;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (!itemFilter.ApplyFilter(consumedItem, (ItemState)num3, (IProfile)num2))
			{
				return;
			}
			bool useDifferentItem_ = Data.ConsumeItem.useDifferentItem_;
			bool flag = default(bool);
			bool flag2 = !flag;
			if (useDifferentItem_ == flag2)
			{
				float currentAmount = CurrentAmount;
				int num4 = 0;
				if (!(SetCurrentAmount(currentAmount, out *(float*)num4) >= targetAmount_))
				{
					bool flag3 = ChangeStatus(MissionStepStatus.Ongoing);
					return;
				}
			}
			float currentAmount2 = CurrentAmount;
		}

		[Cpp2IlInjected.Token(Token = "0x60081DF")]
		[Cpp2IlInjected.Address(RVA = "0x80BDD0", Offset = "0x80A7D0", VA = "0x18080BDD0")]
		private bool IsBlockerItem(Item item)
		{
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			FurnitureItemType furnitureItemType = default(FurnitureItemType);
			return furnitureItemType == FurnitureItemType.Blocker;
		}

		[Cpp2IlInjected.Token(Token = "0x60081E0")]
		[Cpp2IlInjected.Address(RVA = "0x81A310", Offset = "0x818D10", VA = "0x18081A310")]
		private void StartRemoveBlocker()
		{
			//Discarded unreachable code: IL_0095
			MissionObjectiveData missionObjectiveData = Data;
			ProfileEventDispatcher dispatcher = Dispatcher;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.AvatarRemoveBlocker value = RemoveBlocker_OnAvatarRemoveBlocker;
			dispatcher.OnAvatarRemoveBlocker += value;
			if (status_ == MissionStepStatus.NotStarted && !Data.RemoveBlocker.disableAutoSkip_)
			{
				GridCollection gridCollection_ = Profile.world_.gridCollection_;
				Func<IGrid, GridObject, bool> func = (Func<IGrid, GridObject, bool>)(object)(Func<T1, T2, TResult>)((IGrid grid, GridObject gridObject) => ApplyRemoveBlockerFilter(grid, gridObject));
				IEnumerable<(IGrid, GridObject)> allGridObjectsFor = (IEnumerable<(IGrid, GridObject)>)gridCollection_.GetAllGridObjectsFor((Func<, , >)(object)func);
				IEnumerable<(IGrid, GridObject)> enumerable = default(IEnumerable<(IGrid, GridObject)>);
				int num2 = Enumerable.Count<(IGrid, GridObject)>((IEnumerable<>)enumerable);
				float num3 = targetAmount_;
				if (num2 != 0)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081E1")]
		[Cpp2IlInjected.Address(RVA = "0x802FC0", Offset = "0x8019C0", VA = "0x180802FC0")]
		private void CheckForMissingBlockers()
		{
			//Discarded unreachable code: IL_0058
			if (status_ == MissionStepStatus.NotStarted && !Data.RemoveBlocker.disableAutoSkip_)
			{
				GridCollection gridCollection_ = Profile.world_.gridCollection_;
				Func<IGrid, GridObject, bool> func = (Func<IGrid, GridObject, bool>)(object)(Func<T1, T2, TResult>)((IGrid grid, GridObject gridObject) => ApplyRemoveBlockerFilter(grid, gridObject));
				IEnumerable<(IGrid, GridObject)> allGridObjectsFor = (IEnumerable<(IGrid, GridObject)>)gridCollection_.GetAllGridObjectsFor((Func<, , >)(object)func);
				IEnumerable<(IGrid, GridObject)> enumerable = default(IEnumerable<(IGrid, GridObject)>);
				int num = Enumerable.Count<(IGrid, GridObject)>((IEnumerable<>)enumerable);
				float num2 = targetAmount_;
				if (num != 0)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081E2")]
		[Cpp2IlInjected.Address(RVA = "0x8013C0", Offset = "0x7FFDC0", VA = "0x1808013C0")]
		private bool ApplyRemoveBlockerFilter(IGrid grid, GridObject gridObject)
		{
			int itemID = gridObject.ItemID;
			bool flag = default(bool);
			FurnitureItemType furnitureItemType = default(FurnitureItemType);
			if (flag && furnitureItemType == FurnitureItemType.Blocker)
			{
				ItemFilter itemFilter = itemFilter_;
				int itemID2 = gridObject.ItemID;
				bool flag2 = default(bool);
				if (flag2)
				{
					GridLocationFilter filter_ = Data.RemoveBlocker.filter_;
					Profile profile = Profile;
					return ApplyGridLocationFilter(filter_, grid, gridObject, profile);
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60081E3")]
		[Cpp2IlInjected.Address(RVA = "0x811480", Offset = "0x80FE80", VA = "0x180811480")]
		private void RemoveBlocker_OnAvatarRemoveBlocker(IGrid grid, GridObject gridObject)
		{
			//IL_001d: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			if (ApplyRemoveBlockerFilter(grid, gridObject))
			{
				int num = 0;
				int num2 = 0;
				bool flag = UpdateCurrentProgression(1f, canChangeState: true, (IGrid)num2, (GridObject)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081E4")]
		[Cpp2IlInjected.Address(RVA = "0x81E710", Offset = "0x81D110", VA = "0x18081E710")]
		private void StopRemoveBlocker()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.AvatarRemoveBlocker value = RemoveBlocker_OnAvatarRemoveBlocker;
				dispatcher.OnAvatarRemoveBlocker -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081E5")]
		[Cpp2IlInjected.Address(RVA = "0x8175E0", Offset = "0x815FE0", VA = "0x1808175E0")]
		private void StartCookMeal()
		{
			//Discarded unreachable code: IL_00b7
			//IL_0012: Expected I4, but got I8
			MissionSubStep missionSubStep = MissionSubStep;
			int num = 0;
			goBehaviorInt_ = 2;
			long num2 = Convert.ToInt64((uint)missionSubStep.MissionSlot.characterId_);
			if ((object)ItemDatabase.Instance.GetItem(ItemType.Character, "Ratatouille!Remy") != null)
			{
				Profile profile = Profile;
				MissionSubStep missionSubStep2 = MissionSubStep;
				ProfileWorld world_ = profile.world_;
				long num3 = Convert.ToInt64((uint)missionSubStep2.MissionSlot.characterId_);
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (flag && flag2)
				{
				}
			}
			MissionObjectiveData missionObjectiveData = Data;
			ProfileEventDispatcher dispatcher = Dispatcher;
			bool flag3 = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.MealCooked value = Dispatcher_OnMealCooked;
			dispatcher.OnMealCooked += value;
			float currentAmount = CurrentAmount;
			bool flag4 = ChangeStatus(MissionStepStatus.Completed);
		}

		[Cpp2IlInjected.Token(Token = "0x60081E6")]
		[Cpp2IlInjected.Address(RVA = "0x81D4C0", Offset = "0x81BEC0", VA = "0x18081D4C0")]
		private void StopCookMeal()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.MealCooked value = Dispatcher_OnMealCooked;
				dispatcher.OnMealCooked -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081E7")]
		[Cpp2IlInjected.Address(RVA = "0x804890", Offset = "0x803290", VA = "0x180804890")]
		private void Dispatcher_OnMealCooked(Item recipeItem, Item mealItem, Dictionary<Item, int> ingredients, Dictionary<Item, int> fuelUsed, bool newRecipe, bool mealRestrictedToScene)
		{
			//Discarded unreachable code: IL_008a, IL_00a4, IL_00af
			//IL_0018: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_00a1: Expected I4, but got I8
			//IL_00ae: Expected I4, but got I8
			int itemID = mealItem.ItemID;
			List<(Item, ItemState)> list = (List<(Item, ItemState)>)(object)new List<T>();
			int num = 0;
			int num2 = 0;
			((List<T>)(object)list).Add((T)num);
			Func<KeyValuePair<Item, int>, (Item, ItemState)> _003C_003E9__310_ = _003C_003Ec._003C_003E9__310_0;
			if (_003C_003E9__310_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					int num3 = 0;
					/*Error: Unexpected end of block*/;
				};
			}
			IEnumerable<KeyValuePair<Item, int>> enumerable = (IEnumerable<KeyValuePair<Item, int>>)Enumerable.Select<KeyValuePair<Item, int>, (Item, ItemState)>((IEnumerable<>)ingredients, (Func<, >)(object)_003C_003E9__310_);
			((List<T>)(object)list).AddRange((IEnumerable<>)enumerable);
			if (Enumerable.Any<(Item, ItemState)>((IEnumerable<>)itemFilter_.ApplyFilter((IEnumerable<>)list)))
			{
				MissionSubStep missionSubStep = MissionSubStep;
				ProfileEventDispatcher dispatcher = Dispatcher;
				MissionItemData data = missionSubStep.MissionSlot.Data;
				Dictionary<Item, int> dictionary = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081E8")]
		[Cpp2IlInjected.Address(RVA = "0x817410", Offset = "0x815E10", VA = "0x180817410")]
		private void StartConditional()
		{
			//Discarded unreachable code: IL_0066
			//IL_0010: Expected I4, but got I8
			MissionObjectiveData missionObjectiveData = Data;
			stepType_ = MissionStepType.StepGameplay;
			ConditionListener listener = missionObjectiveData.Conditional.conditions_.Listener;
			ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = Conditional_OnAnyConditionChanged;
			ConditionsList conditions_ = Data.Conditional.conditions_;
			ITransactionContext context = Context;
			Profile profile = Profile;
			bool flag = conditions_.Evaluate(profile, context);
			bool flag2 = ChangeStatus(MissionStepStatus.Completed);
		}

		[Cpp2IlInjected.Token(Token = "0x60081E9")]
		[Cpp2IlInjected.Address(RVA = "0x805730", Offset = "0x804130", VA = "0x180805730")]
		private void StopConditional()
		{
			while (true)
			{
				if (this != null)
				{
					/*Error: Could not find block for branch target IL_0004*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081EA")]
		[Cpp2IlInjected.Address(RVA = "0x803E00", Offset = "0x802800", VA = "0x180803E00")]
		private void Conditional_OnAnyConditionChanged(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_0033
			ConditionsList conditions_ = Data.Conditional.conditions_;
			ITransactionContext context = Context;
			Profile profile = Profile;
			bool flag = conditions_.Evaluate(profile, context);
			bool flag2 = ChangeStatus(MissionStepStatus.Completed);
		}

		[Cpp2IlInjected.Token(Token = "0x60081EB")]
		[Cpp2IlInjected.Address(RVA = "0x81A7E0", Offset = "0x8191E0", VA = "0x18081A7E0")]
		private void StartTakePicture()
		{
			//Discarded unreachable code: IL_00fa
			//IL_0010: Expected I4, but got I8
			//IL_004c: Expected I4, but got I8
			//IL_0059: Expected I4, but got I8
			//IL_0066: Expected I4, but got I8
			//IL_0073: Expected I4, but got I8
			//IL_0080: Expected I4, but got I8
			//IL_00a1: Expected O, but got I4
			//IL_00af: Expected I4, but got I8
			//IL_00bc: Expected I4, but got I8
			MissionObjectiveData missionObjectiveData = Data;
			goBehaviorInt_ = 1;
			if (missionObjectiveData.TakePicture.location_.useField_ && Data.TakePicture.location_.Scene <= SceneType.Cave)
			{
				goBehaviorInt_ = 516;
				goBehaviorInt_ = 2052;
				goBehaviorInt_ = 260;
				goBehaviorInt_ = 1028;
				goBehaviorInt_ = 4100;
				SceneType scene = Data.TakePicture.location_.Scene;
				string text = $"TakePictureStep.Location not supported yet: {scene}";
				goBehaviorInt_ = 131076;
				goBehaviorInt_ = 2097156;
			}
			MissionObjectiveData missionObjectiveData2 = Data;
			ProfileEventDispatcher dispatcher = Dispatcher;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData2.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.PictureTaken value = Dispatcher_OnPictureTaken;
			dispatcher.OnPictureTaken += value;
		}

		[Cpp2IlInjected.Token(Token = "0x60081EC")]
		[Cpp2IlInjected.Address(RVA = "0x804BD0", Offset = "0x8035D0", VA = "0x180804BD0")]
		private void Dispatcher_OnPictureTaken(PhotoModeType photoMode, List<int> itemIds, List<int> gardenItemIds, SceneType sceneType)
		{
			//IL_0108: Expected O, but got I4
			//IL_0108: Expected O, but got I4
			//IL_0108: Expected I4, but got I8
			Func<int, Item> func = default(Func<int, Item>);
			List<Item> list2 = default(List<Item>);
			bool flag = default(bool);
			bool flag2 = default(bool);
			float num2 = default(float);
			bool flag3 = default(bool);
			ulong num3 = default(ulong);
			ulong num5 = default(ulong);
			while (true)
			{
				int num = 0;
				if ((Data.TakePicture.location_.useField_ ? 1 : 0) != num)
				{
					SceneType scene = Data.TakePicture.location_.Scene;
				}
				if (Data.TakePicture.itemCase_ != (CustomStepTakePicture.ItemOneofCase)num)
				{
					CustomStepTakePicture takePicture = Data.TakePicture;
					if (_003C_003Ec._003C_003E9__315_0 == null)
					{
						func = (Func<int, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => (Item)typeof(Item).TypeHandle));
					}
					List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Select<int, Item>((IEnumerable<>)itemIds, (Func<, >)(object)func));
					if (Data.TakePicture.IsReallyUsingDifferentItem())
					{
						List<Item> list3 = (List<Item>)(object)itemFilter_.ApplyFilter((IEnumerable<>)list2);
						if (flag)
						{
							if (flag2)
							{
								float currentAmount = CurrentAmount;
								if (num2 >= targetAmount_)
								{
								}
							}
							float currentAmount2 = CurrentAmount;
							while (!flag3)
							{
							}
						}
						if (num3 == 0)
						{
							break;
						}
						continue;
					}
					CustomStepTakePicture takePicture2 = Data.TakePicture;
					MissionObjectiveData missionObjectiveData = Data;
					if (takePicture2.itemCase_ == CustomStepTakePicture.ItemOneofCase.TargetGroup || missionObjectiveData.TakePicture.itemCase_ == CustomStepTakePicture.ItemOneofCase.TargetItem)
					{
						int count = ((RepeatedField<T>)(object)missionObjectiveData.TakePicture.TargetGroup.items_).Count;
						list2 = (List<Item>)(object)Enumerable.ToList<Item>(Enumerable.Distinct<Item>((IEnumerable<>)list));
					}
					List<Item> list4 = (List<Item>)(object)itemFilter_.ApplyFilter((IEnumerable<>)list2);
				}
				int num4 = 0;
				bool flag4 = UpdateCurrentProgression(1f, (byte)num5 != 0, (IGrid)num4, (GridObject)num);
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60081ED")]
		[Cpp2IlInjected.Address(RVA = "0x81E9B0", Offset = "0x81D3B0", VA = "0x18081E9B0")]
		private void StopTakePicture()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.PictureTaken value = Dispatcher_OnPictureTaken;
				dispatcher.OnPictureTaken -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081EE")]
		[Cpp2IlInjected.Address(RVA = "0x817360", Offset = "0x815D60", VA = "0x180817360")]
		private void StartCollectCurrency()
		{
			//Discarded unreachable code: IL_0041
			//IL_0010: Expected I4, but got I8
			MissionObjectiveData missionObjectiveData = Data;
			goBehaviorInt_ = 2;
			ProfileEventDispatcher dispatcher = Dispatcher;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.CurrencyChanged value = CollectCurrency_OnCurrencyChanged;
			dispatcher.OnCurrencyChanged += value;
		}

		[Cpp2IlInjected.Token(Token = "0x60081EF")]
		[Cpp2IlInjected.Address(RVA = "0x803DA0", Offset = "0x8027A0", VA = "0x180803DA0")]
		private void CollectCurrency_OnCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			//Discarded unreachable code: IL_002a
			//IL_0029: Expected I4, but got I8
			if (gained <= 0)
			{
				return;
			}
			ItemFilterData data_ = itemFilter_.data_;
			if ((IntPtr)currencyItem == (IntPtr)data_.item_)
			{
				int num = 0;
				bool flag = default(bool);
				if (flag)
				{
					goBehaviorInt_ = 32;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081F0")]
		[Cpp2IlInjected.Address(RVA = "0x81D3A0", Offset = "0x81BDA0", VA = "0x18081D3A0")]
		private void StopCollectCurrency()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.CurrencyChanged value = CollectCurrency_OnCurrencyChanged;
				dispatcher.OnCurrencyChanged -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081F1")]
		[Cpp2IlInjected.Address(RVA = "0x8194D0", Offset = "0x817ED0", VA = "0x1808194D0")]
		private void StartMineMineral()
		{
			//Discarded unreachable code: IL_0038
			MissionObjectiveData missionObjectiveData = Data;
			ProfileEventDispatcher dispatcher = Dispatcher;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.MiningRockEmptied value = MineMineral_OnMiningRockEmptied;
			dispatcher.OnMiningRockEmptied += value;
		}

		[Cpp2IlInjected.Token(Token = "0x60081F2")]
		[Cpp2IlInjected.Address(RVA = "0x81E030", Offset = "0x81CA30", VA = "0x18081E030")]
		private void StopMineMineral()
		{
			//Discarded unreachable code: IL_001c
			ProfileEventDispatcher dispatcher = Dispatcher;
			ProfileEventDispatcher.MiningRockEmptied value = MineMineral_OnMiningRockEmptied;
			dispatcher.OnMiningRockEmptied -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x60081F3")]
		[Cpp2IlInjected.Address(RVA = "0x80CE90", Offset = "0x80B890", VA = "0x18080CE90")]
		private void MineMineral_OnMiningRockEmptied(ActivityDataLocationFilter location, int index, bool success, List<ItemWithState> rewards, int? criticalSuccessMinigameID)
		{
			//Discarded unreachable code: IL_0164
			//IL_001b: Expected O, but got I4
			//IL_0123: Expected O, but got I4
			//IL_0123: Expected O, but got I4
			int? criticalSuccessMinigameID2 = (int?)(object)0;
			HangoutWithCharacter with_ = Data.MineMineral.with_;
			Profile profile = Profile;
			if (!with_.CurrentHangoutCharacterIsValid(profile))
			{
				return;
			}
			if (Enumerable.Any<ActivityDataLocationFilter>((IEnumerable<>)(object)Data.MineMineral.locations_) && location.locationTypeCase_ == ActivityDataLocationFilter.LocationTypeOneofCase.Scene)
			{
				RepeatedField<ActivityDataLocationFilter> locations_ = Data.MineMineral.locations_;
				Predicate<ActivityDataLocationFilter> predicate = (Predicate<ActivityDataLocationFilter>)(object)(Predicate<T>)delegate(ActivityDataLocationFilter x)
				{
					//Discarded unreachable code: IL_0018
					int scene = x.Scene;
					int scene2 = location.Scene;
					return scene == scene2;
				};
				if (!((RepeatedField<>)(object)locations_).Any<ActivityDataLocationFilter>((Predicate<>)(object)predicate))
				{
					return;
				}
			}
			if (Enumerable.Any<ActivityDataLocationFilter>((IEnumerable<>)(object)Data.MineMineral.locations_) && location.locationTypeCase_ == ActivityDataLocationFilter.LocationTypeOneofCase.VillageArea)
			{
				RepeatedField<ActivityDataLocationFilter> locations_2 = Data.MineMineral.locations_;
				Predicate<ActivityDataLocationFilter> predicate2 = (Predicate<ActivityDataLocationFilter>)(object)(Predicate<T>)delegate(ActivityDataLocationFilter x)
				{
					//Discarded unreachable code: IL_001c
					VillageAreaType villageArea = x.VillageArea;
					ActivityDataLocationFilter activityDataLocationFilter = location;
					int num6 = (int)villageArea;
					VillageAreaType villageArea2 = activityDataLocationFilter.VillageArea;
					return num6 == (int)villageArea2;
				};
				if (!((RepeatedField<>)(object)locations_2).Any<ActivityDataLocationFilter>((Predicate<>)(object)predicate2))
				{
					return;
				}
			}
			if (!Data.MineMineral.acceptMiningFailure_)
			{
				if (!success)
				{
					goto IL_0125;
				}
				Func<ItemWithState, int> func = (Func<ItemWithState, int>)(object)(Func<T, TResult>)delegate(ItemWithState r)
				{
					//Discarded unreachable code: IL_0015
					ItemFilter itemFilter = itemFilter_;
					Item item2 = r.Item;
					int result = default(int);
					return result;
				};
			}
			int num = 0;
			int num2 = 0;
			bool flag = UpdateCurrentProgression(1f, canChangeState: true, (IGrid)num2, (GridObject)num);
			goto IL_0125;
			IL_0125:
			ProfileEventDispatcher dispatcher = Dispatcher;
			ProfileEventDispatcher.MinigameEventHandler value = MinigameStopped;
			dispatcher.OnItemCollectMinigameEnded += value;
			ProfileEventDispatcher dispatcher2 = Dispatcher;
			ProfileEventDispatcher.MinigameItemsCollected value2 = MinigameItemsCollected;
			dispatcher2.OnMinigameItemsCollected += value2;
			[Cpp2IlInjected.Token(Token = "0x6008300")]
			[Cpp2IlInjected.Address(RVA = "0x13052D0", Offset = "0x1303CD0", VA = "0x1813052D0")]
			void MinigameItemsCollected(Profile.ItemCollectMinigame minigame, MultiItemInstance items)
			{
				int num3 = default(int);
				if (minigame.ID == num3)
				{
					if (status_ >= MissionStepStatus.Completed)
					{
						ProfileEventDispatcher dispatcher3 = Dispatcher;
						ProfileEventDispatcher.MinigameEventHandler value3 = MinigameStopped;
						dispatcher3.OnItemCollectMinigameEnded -= value3;
						ProfileEventDispatcher dispatcher4 = Dispatcher;
						ProfileEventDispatcher.MinigameItemsCollected value4 = MinigameItemsCollected;
						dispatcher4.OnMinigameItemsCollected -= value4;
						throw new NullReferenceException();
					}
					RepeatedField<ItemInstance> items_ = items.items_;
					Action<ItemInstance> action = (Action<ItemInstance>)(object)(Action<T>)delegate(ItemInstance x)
					{
						//Discarded unreachable code: IL_0011
						MissionObjective missionObjective = this;
						Item item = x.Item;
						int num4 = 0;
					};
					((RepeatedField<>)(object)items_).ForEach<ItemInstance>((Action<>)(object)action);
				}
			}
			[Cpp2IlInjected.Token(Token = "0x60082FF")]
			[Cpp2IlInjected.Address(RVA = "0x1305500", Offset = "0x1303F00", VA = "0x181305500")]
			void MinigameStopped(Profile.ItemCollectMinigame minigame)
			{
				//Discarded unreachable code: IL_004c
				int num5 = default(int);
				if (minigame.ID == num5)
				{
					ProfileEventDispatcher dispatcher5 = Dispatcher;
					ProfileEventDispatcher.MinigameEventHandler value5 = MinigameStopped;
					dispatcher5.OnItemCollectMinigameEnded -= value5;
					ProfileEventDispatcher dispatcher6 = Dispatcher;
					ProfileEventDispatcher.MinigameItemsCollected value6 = MinigameItemsCollected;
					dispatcher6.OnMinigameItemsCollected -= value6;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081F4")]
		[Cpp2IlInjected.Address(RVA = "0x819580", Offset = "0x817F80", VA = "0x180819580")]
		private void StartParty()
		{
			//Discarded unreachable code: IL_002c
			ProfileWorld world_ = Profile.world_;
			MissionObjectiveData missionObjectiveData = Data;
			GridCollection gridCollection_ = world_.gridCollection_;
			Item partyItem = missionObjectiveData.Party.PartyItem;
			(IGrid, GridObject) tuple = default((IGrid, GridObject));
			if ((object)tuple != null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081F5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void StopParty()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60081F6")]
		[Cpp2IlInjected.Address(RVA = "0x80F2E0", Offset = "0x80DCE0", VA = "0x18080F2E0")]
		private void OnPartyStepCompleted()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60081F7")]
		[Cpp2IlInjected.Address(RVA = "0x8197A0", Offset = "0x8181A0", VA = "0x1808197A0")]
		private void StartPlaceBuilding()
		{
			//Discarded unreachable code: IL_00bc
			//IL_0014: Expected I4, but got I8
			ProfileEventDispatcher dispatcher = Dispatcher;
			goBehaviorInt_ = 642;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.GridChanged value = Dispatcher_OnGridChanged_PlaceBuilding;
				dispatcher.OnGridChanged += value;
			}
			CustomStepPlaceBuilding placeBuilding = Data.PlaceBuilding;
			MissionItemData data = MissionSubStep.MissionSlot.Data;
			int itemID = placeBuilding.GetBuildingToPlace(data).ItemID;
			ItemFilter itemFilter = itemFilter_;
			if (itemFilter != null)
			{
				ItemFilterData data_ = itemFilter.data_;
				if (data_ != null)
				{
					int item_ = data_.item_;
				}
			}
			int num = 0;
			bool flag = num == itemID;
			if (num == (flag ? 1 : 0))
			{
				ItemFilter itemFilter2 = default(ItemFilter);
				itemFilter_ = itemFilter2;
			}
			MissionObjectiveData missionObjectiveData = Data;
			Profile profile = Profile;
			CustomStepPlaceBuilding placeBuilding2 = missionObjectiveData.PlaceBuilding;
			bool flag2 = default(bool);
			if (!flag2)
			{
				bool flag3 = ChangeStatus(MissionStepStatus.Completed);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081F8")]
		[Cpp2IlInjected.Address(RVA = "0x8062D0", Offset = "0x804CD0", VA = "0x1808062D0")]
		private Item GetBuildingToPlace()
		{
			//Discarded unreachable code: IL_0025
			CustomStepPlaceBuilding placeBuilding = Data.PlaceBuilding;
			MissionItemData data = MissionSubStep.MissionSlot.Data;
			return placeBuilding.GetBuildingToPlace(data);
		}

		[Cpp2IlInjected.Token(Token = "0x60081F9")]
		[Cpp2IlInjected.Address(RVA = "0x804560", Offset = "0x802F60", VA = "0x180804560")]
		private void Dispatcher_OnGridChanged_PlaceBuilding(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [System.Runtime.InteropServices.Optional] GridAddObjectOptions options)
		{
			//IL_002b: Expected I4, but got I8
			//IL_0064: Expected I4, but got I8
			ItemType itemType = default(ItemType);
			ItemType itemType2 = default(ItemType);
			do
			{
				if (operation == GridChangedOperation.Add)
				{
					int itemID = gridObject.ItemID;
					if (itemType == ItemType.Building)
					{
						int itemID2 = gridObject.ItemID;
						if ((object)GetBuildingToPlace() != null)
						{
							goBehaviorInt_ = 32;
							bool flag = ChangeStatus(MissionStepStatus.Completed);
						}
					}
					return;
				}
				while (operation != GridChangedOperation.Remove)
				{
				}
				int itemID3 = gridObject.ItemID;
				while (itemType2 != ItemType.Building)
				{
				}
				int itemID4 = gridObject.ItemID;
			}
			while ((object)GetBuildingToPlace() == null);
			goBehaviorInt_ = 642;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60081FA")]
		[Cpp2IlInjected.Address(RVA = "0x81E230", Offset = "0x81CC30", VA = "0x18081E230")]
		private void StopPlaceBuilding()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.GridChanged value = Dispatcher_OnGridChanged_PlaceBuilding;
				dispatcher.OnGridChanged -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081FB")]
		[Cpp2IlInjected.Address(RVA = "0x8181A0", Offset = "0x816BA0", VA = "0x1808181A0")]
		private void StartFinishHouse()
		{
			//Discarded unreachable code: IL_00c8
			//IL_000f: Expected I4, but got I8
			int num = 0;
			goBehaviorInt_ = 1028;
			RefreshRequiredFurnituresAmount();
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.ItemAdded value = Dispatcher_OnItemAdded_FinishHouse;
				dispatcher.OnItemAdded += value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.ItemRemoved value2 = Dispatcher_OnItemRemoved_FinishHouse;
				dispatcher2.OnItemRemoved += value2;
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.GridChanged value3 = Dispatcher_OnGridChanged_FinishHouse;
				dispatcher3.OnGridChanged += value3;
			}
			Profile profile = Profile;
			MissionObjectiveData missionObjectiveData = Data;
			ProfileWorld world_ = profile.world_;
			Item houseItem = missionObjectiveData.FinishHouse.HouseItem;
			bool flag = default(bool);
			if (flag && num != 0)
			{
				HouseData houseData = default(HouseData);
				if (world_ != null && houseData != null)
				{
					bool built_ = houseData.built_;
				}
				bool flag2 = num == 1;
				if (num != (flag2 ? 1 : 0))
				{
					bool flag3 = ChangeStatus(MissionStepStatus.Completed);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081FC")]
		[Cpp2IlInjected.Address(RVA = "0x804860", Offset = "0x803260", VA = "0x180804860")]
		private void Dispatcher_OnItemAdded_FinishHouse(IInventory inventory, Item item, int amount, ItemState state, AddDetail detail)
		{
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Furniture)
			{
				RefreshRequiredFurnituresAmount();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081FD")]
		[Cpp2IlInjected.Address(RVA = "0x804860", Offset = "0x803260", VA = "0x180804860")]
		private void Dispatcher_OnItemRemoved_FinishHouse(IInventory inventory, Item item, int amount, ItemState state, InvActionType reason = InvActionType.None)
		{
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Furniture)
			{
				RefreshRequiredFurnituresAmount();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60081FE")]
		[Cpp2IlInjected.Address(RVA = "0x811290", Offset = "0x80FC90", VA = "0x180811290")]
		private unsafe void RefreshRequiredFurnituresAmount()
		{
			//Discarded unreachable code: IL_0044
			int num = 0;
			MissionObjectiveData missionObjectiveData = Data;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IUniqueItem getIUniqueItem = missionObjectiveData.GetIUniqueItem;
			ListInventory catalog = Profile.Catalog;
			BuildingItemData buildingItemData = default(BuildingItemData);
			List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>((IEnumerable<>)(object)buildingItemData.RequiredItems);
			bool flag = catalog.HasAllItems((List<>)(object)list, ref *(int*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60081FF")]
		[Cpp2IlInjected.Address(RVA = "0x804480", Offset = "0x802E80", VA = "0x180804480")]
		private void Dispatcher_OnGridChanged_FinishHouse(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [System.Runtime.InteropServices.Optional] GridAddObjectOptions options)
		{
			//Discarded unreachable code: IL_0051
			//IL_0047: Expected I4, but got I8
			if (operation != GridChangedOperation.UpdateState)
			{
				return;
			}
			int itemID = gridObject.ItemID;
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Building)
			{
				MissionObjectiveData missionObjectiveData = Data;
				int itemID_ = gridObject.itemID_;
				IUniqueItem getIUniqueItem = missionObjectiveData.GetIUniqueItem;
				if ((IntPtr)itemID_ == (IntPtr)getIUniqueItem && gridObject.state_.HouseData.built_)
				{
					goBehaviorInt_ = 32;
					bool flag = ChangeStatus(MissionStepStatus.Completed);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008200")]
		[Cpp2IlInjected.Address(RVA = "0x81DB30", Offset = "0x81C530", VA = "0x18081DB30")]
		private void StopFinishHouse()
		{
			//Discarded unreachable code: IL_005a
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.ItemAdded value = Dispatcher_OnItemAdded_FinishHouse;
				dispatcher.OnItemAdded -= value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.ItemRemoved value2 = Dispatcher_OnItemRemoved_FinishHouse;
				dispatcher2.OnItemRemoved -= value2;
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.GridChanged value3 = Dispatcher_OnGridChanged_FinishHouse;
				dispatcher3.OnGridChanged -= value3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008201")]
		[Cpp2IlInjected.Address(RVA = "0x817CE0", Offset = "0x8166E0", VA = "0x180817CE0")]
		private void StartExpandHouse()
		{
			//Discarded unreachable code: IL_008b
			//IL_001a: Expected O, but got I4
			//IL_001a: Expected O, but got I4
			ExpandHouseEventType eventToListen = Data.ExpandHouse.EventToListen;
			int num = (int)eventToListen;
			ExpandHouseEventType expandHouseEventType = default(ExpandHouseEventType);
			if (((Enum)eventToListen).HasFlag(expandHouseEventType))
			{
				ProfileEventDispatcher dispatcher = Dispatcher;
				ProfileEventDispatcher.PlayerHouseRoomExpanded value = ExpandHouse_OnPlayerHouseRoomExpanded;
				dispatcher.OnPlayerHouseRoomExpanded += value;
			}
			bool flag = default(bool);
			if (flag)
			{
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.PlayerHouseRoomAdded value2 = ExpandHouse_OnPlayerHouseRoomAdded;
				dispatcher2.OnPlayerHouseRoomAdded += value2;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.PlayerHouseFloorAdded value3 = ExpandHouse_OnPlayerHouseFloorAdded;
				dispatcher3.OnPlayerHouseFloorAdded += value3;
			}
			InitExpandHouse();
		}

		[Cpp2IlInjected.Token(Token = "0x6008202")]
		[Cpp2IlInjected.Address(RVA = "0x81D8D0", Offset = "0x81C2D0", VA = "0x18081D8D0")]
		private void StopExpandHouse()
		{
			//Discarded unreachable code: IL_005a
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.PlayerHouseRoomExpanded value = ExpandHouse_OnPlayerHouseRoomExpanded;
				dispatcher.OnPlayerHouseRoomExpanded -= value;
				ProfileEventDispatcher dispatcher2 = Dispatcher;
				ProfileEventDispatcher.PlayerHouseRoomAdded value2 = ExpandHouse_OnPlayerHouseRoomAdded;
				dispatcher2.OnPlayerHouseRoomAdded -= value2;
				ProfileEventDispatcher dispatcher3 = Dispatcher;
				ProfileEventDispatcher.PlayerHouseFloorAdded value3 = ExpandHouse_OnPlayerHouseFloorAdded;
				dispatcher3.OnPlayerHouseFloorAdded -= value3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008203")]
		[Cpp2IlInjected.Address(RVA = "0x80A9E0", Offset = "0x8093E0", VA = "0x18080A9E0")]
		private void InitExpandHouse()
		{
			//Discarded unreachable code: IL_0021, IL_0062, IL_00d5
			//IL_005f: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			//IL_005f: Expected I4, but got I8
			float currentAmount = CurrentAmount;
			if (Data.ExpandHouse.actionType_ <= CustomStepExpandHouse.Types.ExpandType.ReachNumberOfFloor)
			{
				InitExpandHouseAny();
			}
			[Cpp2IlInjected.Token(Token = "0x600824A")]
			[Cpp2IlInjected.Address(RVA = "0x8215F0", Offset = "0x81FFF0", VA = "0x1808215F0")]
			static HouseExpansion GetHouseExpansion()
			{
				ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x600824B")]
			[Cpp2IlInjected.Address(RVA = "0x8216E0", Offset = "0x8200E0", VA = "0x1808216E0")]
			void InitExpandHouseAny()
			{
				//Discarded unreachable code: IL_00d3
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Expected O, but got Unknown
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bf: Expected I4, but got Unknown
				//IL_00d0: Expected O, but got I4
				//IL_00d0: Expected O, but got I4
				//IL_00d0: Expected I4, but got I8
				//IL_00d0: Expected F4, but got I4
				int num = 0;
				HouseExpansion houseExpansion = GetHouseExpansion();
				int floorMax = houseExpansion.FloorMax;
				int count = ((RepeatedField<T>)(object)Profile.world_.playerHouse_.floors_).Count;
				floorMax -= count;
				int roomMax = houseExpansion.RoomMax;
				int roomCount = Profile.world_.playerHouse_.RoomCount;
				floorMax += roomMax;
				floorMax -= roomCount;
				int roomExpansionMax = houseExpansion.RoomExpansionMax;
				Profile profile = Profile;
				roomMax = roomExpansionMax;
				int num2 = profile.world_.playerHouse_.RoomExpansionCount(profile, houseExpansion);
				MissionObjectiveData missionObjectiveData = Data;
				houseExpansion = (HouseExpansion)(houseExpansion - num2);
				if ((long)missionObjectiveData.ExpandHouse.amount_ > (long)(IntPtr)houseExpansion)
				{
					MissionObjectiveData missionObjectiveData2 = Data;
					int num3 = 0;
					int amount_ = missionObjectiveData2.ExpandHouse.amount_;
					int num4 = 0;
					amount_ -= houseExpansion;
					int num5 = 0;
					ulong num6 = default(ulong);
					bool flag = UpdateCurrentProgression(num3, (byte)num6 != 0, (IGrid)num4, (GridObject)num5);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008204")]
		[Cpp2IlInjected.Address(RVA = "0x805C40", Offset = "0x804640", VA = "0x180805C40")]
		private void ExpandHouse_OnPlayerHouseRoomExpanded(int sizeX, int sizeY, int floorIndex, House.Types.RoomSlot roomSlot, [System.Runtime.InteropServices.Optional] List<CurrencyCost> cost)
		{
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6008205")]
		[Cpp2IlInjected.Address(RVA = "0x805C10", Offset = "0x804610", VA = "0x180805C10")]
		private void ExpandHouse_OnPlayerHouseRoomAdded(int floorIndex, House.Types.RoomSlot roomSlot, List<CurrencyCost> cost)
		{
			//IL_0012: Expected O, but got I4
			//IL_0012: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			bool flag = UpdateCurrentProgression(1f, canChangeState: true, (IGrid)num2, (GridObject)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6008206")]
		[Cpp2IlInjected.Address(RVA = "0x805C10", Offset = "0x804610", VA = "0x180805C10")]
		private void ExpandHouse_OnPlayerHouseFloorAdded([System.Runtime.InteropServices.Optional] CurrencyCost cost)
		{
			//IL_0012: Expected O, but got I4
			//IL_0012: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			bool flag = UpdateCurrentProgression(1f, canChangeState: true, (IGrid)num2, (GridObject)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6008207")]
		[Cpp2IlInjected.Address(RVA = "0x817F60", Offset = "0x816960", VA = "0x180817F60")]
		private void StartFeedCritter()
		{
			//IL_0014: Expected I4, but got I8
			ProfileEventDispatcher dispatcher = Dispatcher;
			goBehaviorInt_ = 512;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.CritterFed value = FeedCritter_OnFed;
				dispatcher.OnCritterFed += value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008208")]
		[Cpp2IlInjected.Address(RVA = "0x81DA10", Offset = "0x81C410", VA = "0x18081DA10")]
		private void StopFeedCritter()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.CritterFed value = FeedCritter_OnFed;
				dispatcher.OnCritterFed -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008209")]
		[Cpp2IlInjected.Address(RVA = "0x805C60", Offset = "0x804660", VA = "0x180805C60")]
		private unsafe void FeedCritter_OnFed(Critter critter, FeedCritterDetails details)
		{
			//IL_00a7: Expected O, but got I4
			if (critter == null)
			{
				return;
			}
			CritterItemData data = critter.Data;
			if (data == null || data != null || (Data.FeedCritter.conditionCase_ == CustomStepFeedCritter.ConditionOneofCase.Location && Data.FeedCritter.Location != data.location_) || !details.FirstFeedingToday || (Data.FeedCritter.action_ == CustomStepFeedCritter.Types.FeedAction.FavoriteItem && details.Reaction != FeedCritter.Types.CritterReaction.Favorite) || (Data.FeedCritter.action_ == CustomStepFeedCritter.Types.FeedAction.LikedItem && details.Reaction == FeedCritter.Types.CritterReaction.Hate))
			{
				return;
			}
			ItemFilter itemFilter = itemFilter_;
			Item item = details.Item;
			int num = 0;
			if (itemFilter.GetItemQuantity(item, 1, (ItemState)num) != 0)
			{
				Item item2 = details.Item;
				float currentAmount = CurrentAmount;
				int num2 = 0;
				if (SetCurrentAmount(currentAmount, out *(float*)num2) >= targetAmount_)
				{
					throw new NullReferenceException();
				}
				bool flag = ChangeStatus(MissionStepStatus.Ongoing);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600820A")]
		[Cpp2IlInjected.Address(RVA = "0x81A4F0", Offset = "0x818EF0", VA = "0x18081A4F0")]
		private void StartRoyalDuties()
		{
			//IL_0014: Expected I4, but got I8
			ProfileEventDispatcher dispatcher = Dispatcher;
			goBehaviorInt_ = 1048576;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.DutyAchRewardCollected value = Dispatcher_OnDutyAchRewardCollected_RoyalDuties;
				dispatcher.OnDutyAchRewardCollected += value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600820B")]
		[Cpp2IlInjected.Address(RVA = "0x81E7A0", Offset = "0x81D1A0", VA = "0x18081E7A0")]
		private void StopRoyalDuties()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.DutyAchRewardCollected value = Dispatcher_OnDutyAchRewardCollected_RoyalDuties;
				dispatcher.OnDutyAchRewardCollected -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600820C")]
		[Cpp2IlInjected.Address(RVA = "0x8042A0", Offset = "0x802CA0", VA = "0x1808042A0")]
		private unsafe void Dispatcher_OnDutyAchRewardCollected_RoyalDuties(List<AnyReward> rewards, DutyAchItemType dutyAchtype, Item royalDutyItem)
		{
			//Discarded unreachable code: IL_005b
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			RoyalDutyItemData royalDutyItemData = default(RoyalDutyItemData);
			if (royalDutyItemData == null)
			{
				return;
			}
			if (Data.RoyalDuties.type_ != 0)
			{
				CustomStepRoyalDuties royalDuties = Data.RoyalDuties;
				DutyType type_ = royalDutyItemData.type_;
				if (royalDuties.type_ != type_)
				{
					return;
				}
			}
			float currentAmount = CurrentAmount;
			int num = 0;
			float num2 = SetCurrentAmount(currentAmount, out *(float*)num);
			bool flag = ChangeStatus(MissionStepStatus.Ongoing);
		}

		[Cpp2IlInjected.Token(Token = "0x600820D")]
		[Cpp2IlInjected.Address(RVA = "0x8188C0", Offset = "0x8172C0", VA = "0x1808188C0")]
		private unsafe void StartMakeGarden()
		{
			//Discarded unreachable code: IL_022d, IL_0233, IL_0239
			//IL_01ec: Expected O, but got I4
			bool flag2 = default(bool);
			int num3 = default(int);
			CustomStepMakeGarden customStepMakeGarden = default(CustomStepMakeGarden);
			bool flag3 = default(bool);
			IEnumerable<uint> enumerable = default(IEnumerable<uint>);
			uint num4 = default(uint);
			CustomStepMakeGarden customStepMakeGarden2 = default(CustomStepMakeGarden);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			ICollection<> collection = default(ICollection<>);
			CustomStepMakeGarden customStepMakeGarden3 = default(CustomStepMakeGarden);
			Func<Village.Types.VillageArea, bool> func = default(Func<Village.Types.VillageArea, bool>);
			IEnumerable<Village.Types.VillageArea> enumerable2 = default(IEnumerable<Village.Types.VillageArea>);
			uint num5 = default(uint);
			int num6 = default(int);
			CustomStepMakeGarden customStepMakeGarden4 = default(CustomStepMakeGarden);
			bool flag6 = default(bool);
			CustomStepMakeGarden customStepMakeGarden5 = default(CustomStepMakeGarden);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int gridID2 = 0;
				bool flag = (byte)(stepType_ = (((Data.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
				ProfileEventDispatcher dispatcher = Dispatcher;
				ProfileEventDispatcher.GardeningEvent value = OnMakeGardenGardeningEvent;
				dispatcher.OnGardeningEvent += value;
				int amount = num;
				CustomStepMakeGarden.LocationOneofCase locationCase_ = Data.MakeGarden.locationCase_;
				if (locationCase_ != CustomStepMakeGarden.LocationOneofCase.Building)
				{
					if (locationCase_ == CustomStepMakeGarden.LocationOneofCase.Building)
					{
						goto IL_00fd;
					}
					if (locationCase_ != CustomStepMakeGarden.LocationOneofCase.Building && locationCase_ == (CustomStepMakeGarden.LocationOneofCase)1)
					{
						goto IL_01d6;
					}
					MapField<string, Realm> realms_ = Profile.world_.realms_;
					string realm = Data.MakeGarden.Realm;
					if (!((MapField<TKey, TValue>)(object)realms_).TryGetValue((TKey)realm, out *(TValue*)num))
					{
						return;
					}
					if (flag2)
					{
						CheckGrid((uint)gridID2);
					}
					num++;
					num3 = 0;
					if (num == 0)
					{
					}
				}
				int building = customStepMakeGarden.Building;
				if (flag3)
				{
					if (enumerable != null)
					{
						if (num3 < (int)num4)
						{
							num3 += num3;
							if (num3 == (int)num4)
							{
								goto IL_0188;
							}
							num3++;
						}
						goto IL_00fd;
					}
					goto IL_0197;
				}
				goto IL_01ac;
				IL_01ac:
				int building2 = customStepMakeGarden2.Building;
				if (flag4)
				{
					if (flag5)
					{
						CheckGrid((uint)gridID2);
					}
					num++;
					if (collection != null)
					{
						continue;
					}
					if (num == 0)
					{
					}
					goto IL_01d6;
				}
				return;
				IL_00fd:
				bool useField_ = customStepMakeGarden3.VillageArea.useField_;
				if (_003C_003Ec._003C_003E9__348_5 == null)
				{
					func = (Func<Village.Types.VillageArea, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Village.Types.VillageArea x) => x.unlocked_));
				}
				enumerable2 = (IEnumerable<Village.Types.VillageArea>)Enumerable.Where<Village.Types.VillageArea>((IEnumerable<>)collection, (Func<, >)(object)func);
				if (enumerable2 != null && num3 < (int)num5)
				{
					num3 += num3;
					if (num3 != (int)num5)
					{
						num3++;
					}
				}
				num++;
				if (enumerable2 != null)
				{
				}
				if (collection != null)
				{
					break;
				}
				if (num != 0)
				{
				}
				num6 = (int)customStepMakeGarden4.VillageArea.VillageArea;
				if (flag6)
				{
					CheckGrid((uint)num6);
					goto IL_0188;
				}
				return;
				IL_01d6:
				LocationSourceWithRadius specificLocation = customStepMakeGarden5.SpecificLocation;
				Func<GridObject, bool> _003C_003E3__isValidGridObject = (Func<GridObject, bool>)(object)new Func<T, TResult>(IsValidGridObject);
				int num7 = 0;
				_003CEnumSpecificLocationGridObjects_003Ed__182 _003CEnumSpecificLocationGridObjects_003Ed__ = new _003CEnumSpecificLocationGridObjects_003Ed__182(-2);
				_003CEnumSpecificLocationGridObjects_003Ed__._003C_003E3__specificLocation = specificLocation;
				_003CEnumSpecificLocationGridObjects_003Ed__._003C_003E3__profile = (Profile)(object)func;
				_003CEnumSpecificLocationGridObjects_003Ed__._003C_003E3__isValidGridObject = _003C_003E3__isValidGridObject;
				Action<(IGrid, GridObject)> action = (Action<(IGrid, GridObject)>)(object)(Action<T>)delegate
				{
					//Discarded unreachable code: IL_0017
					Village village_ = Profile.world_.village_;
				};
				MoreLinq.ForEach<(IGrid, GridObject)>((IEnumerable<>)(object)_003CEnumSpecificLocationGridObjects_003Ed__, (Action<>)(object)action);
				return;
				IL_0188:
				num6 += num6;
				num += 312;
				goto IL_0197;
				IL_0197:
				num++;
				if (enumerable2 != null)
				{
				}
				if (collection != null)
				{
					continue;
				}
				if (num == 0)
				{
				}
				goto IL_01ac;
				GridCollection gridCollection_;
				bool flag7 = default(bool);
				bool inVillage2;
				Action<GridObject> action2;
				bool inVillage3;
				int num8;
				RepeatedField<GardenData.Types.GardeningSlot> slots_;
				bool flag8 = default(bool);
				TreeAndBushData treeAndBushData = default(TreeAndBushData);
				MissionObjective missionObjective;
				Profile profile;
				ITransactionContext context;
				ProfileWorld world_;
				int num9;
				DateTime endOfGrowthTime;
				TreeAndBushData growable = default(TreeAndBushData);
				ITransactionContext context2;
				bool flag9 = default(bool);
				int num10;
				ItemFilter itemFilter;
				int num11 = default(int);
				[Cpp2IlInjected.Token(Token = "0x6008303")]
				[Cpp2IlInjected.Address(RVA = "0x1305990", Offset = "0x1304390", VA = "0x181305990")]
				void CheckGrid(uint gridID)
				{
					//Discarded unreachable code: IL_005b
					gridCollection_ = Profile.world_.gridCollection_;
					if (flag7)
					{
						inVillage2 = Profile.world_.village_.IsVillageGridID(gridID);
						action2 = (Action<GridObject>)(object)(Action<T>)delegate(GridObject x)
						{
							//Discarded unreachable code: IL_0017
							inVillage3 = inVillage2;
							CheckGridObject(x, inVillage3);
							[Cpp2IlInjected.Token(Token = "0x6008304")]
							[Cpp2IlInjected.Address(RVA = "0x13056E0", Offset = "0x13040E0", VA = "0x1813056E0")]
							void CheckGridObject(GridObject gridObject, bool inVillage)
							{
								//Discarded unreachable code: IL_0095, IL_009b, IL_00a1, IL_00a7, IL_00ad, IL_00b3, IL_00b9
								//IL_005c: Expected O, but got I4
								num8 = 0;
								if (IsValidGridObject(gridObject))
								{
									slots_ = gridObject.state_.GardenData.slots_;
									if (flag8)
									{
										while (treeAndBushData == null)
										{
										}
										missionObjective = this;
										profile = missionObjective.Profile;
										context = missionObjective.Context;
										world_ = profile.world_;
										num9 = 0;
										endOfGrowthTime = growable.GetEndOfGrowthTime((SeedItemData)num9, world_, context, inVillage);
										context2 = Context;
										while (!flag9)
										{
										}
										num10 = amount;
										itemFilter = itemFilter_;
										amount = num11 + num10;
									}
								}
							}
						};
					}
				}
				[Cpp2IlInjected.Token(Token = "0x6008303")]
				[Cpp2IlInjected.Address(RVA = "0x1305990", Offset = "0x1304390", VA = "0x181305990")]
				void CheckGrid(uint gridID)
				{
					//Discarded unreachable code: IL_005b
					gridCollection_ = Profile.world_.gridCollection_;
					if (flag7)
					{
						inVillage2 = Profile.world_.village_.IsVillageGridID(gridID);
						action2 = (Action<GridObject>)(object)(Action<T>)delegate(GridObject x)
						{
							//Discarded unreachable code: IL_0017
							inVillage3 = inVillage2;
							CheckGridObject(x, inVillage3);
							[Cpp2IlInjected.Token(Token = "0x6008304")]
							[Cpp2IlInjected.Address(RVA = "0x13056E0", Offset = "0x13040E0", VA = "0x1813056E0")]
							void CheckGridObject(GridObject gridObject, bool inVillage)
							{
								//Discarded unreachable code: IL_0095, IL_009b, IL_00a1, IL_00a7, IL_00ad, IL_00b3, IL_00b9
								//IL_005c: Expected O, but got I4
								num8 = 0;
								if (IsValidGridObject(gridObject))
								{
									slots_ = gridObject.state_.GardenData.slots_;
									if (flag8)
									{
										while (treeAndBushData == null)
										{
										}
										missionObjective = this;
										profile = missionObjective.Profile;
										context = missionObjective.Context;
										world_ = profile.world_;
										num9 = 0;
										endOfGrowthTime = growable.GetEndOfGrowthTime((SeedItemData)num9, world_, context, inVillage);
										context2 = Context;
										while (!flag9)
										{
										}
										num10 = amount;
										itemFilter = itemFilter_;
										amount = num11 + num10;
									}
								}
							}
						};
					}
				}
			}
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x600824C")]
			[Cpp2IlInjected.Address(RVA = "0x821B90", Offset = "0x820590", VA = "0x180821B90")]
			static bool IsValidGridObject(GridObject gridObject)
			{
				//Discarded unreachable code: IL_0020
				GridState state_ = gridObject.state_;
				if (state_ != null)
				{
					return state_.GardenData != null;
				}
				return 0 != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600820E")]
		[Cpp2IlInjected.Address(RVA = "0x80F050", Offset = "0x80DA50", VA = "0x18080F050")]
		private void OnMakeGardenGardeningEvent(IGrid grid, GridObject gridObject, int slotIndex, GardeningOperation operation, GardeningDetail detail)
		{
			//Discarded unreachable code: IL_004d
			//IL_004a: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			//IL_004a: Expected F4, but got I4
			if (MakeGarden_IsValidLocation(grid, gridObject))
			{
				ItemFilter itemFilter = itemFilter_;
				Item plantedSeedItem = ((GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)gridObject.state_.GardenData.slots_)[slotIndex]).PlantedSeedItem;
				int num = 0;
				int itemID = plantedSeedItem.ItemID;
				int num2 = default(int);
				if (num2 != 0)
				{
					int num3 = 0;
					bool flag = UpdateCurrentProgression(itemID, canChangeState: true, (IGrid)num3, (GridObject)num);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600820F")]
		[Cpp2IlInjected.Address(RVA = "0x80C3B0", Offset = "0x80ADB0", VA = "0x18080C3B0")]
		private unsafe bool MakeGarden_IsValidLocation(IGrid grid, GridObject gridObject)
		{
			//IL_0045: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			MissionObjectiveData missionObjectiveData = Data;
			int num = 0;
			CustomStepMakeGarden.LocationOneofCase locationCase_ = missionObjectiveData.MakeGarden.locationCase_;
			if (locationCase_ == CustomStepMakeGarden.LocationOneofCase.Building)
			{
				MapField<int, BuildingInfo> buildingInfos_ = Profile.world_.buildingInfos_;
				int building = Data.MakeGarden.Building;
				if (!((MapField<TKey, TValue>)(object)buildingInfos_).TryGetValue((TKey)building, out *(TValue*)num))
				{
					MapField<int, OffGridBuilding> offGridBuildings_ = Profile.world_.offGridBuildings_;
					int building2 = Data.MakeGarden.Building;
					bool result = default(bool);
					if (((MapField<TKey, TValue>)(object)offGridBuildings_).TryGetValue((TKey)building2, out *(TValue*)num))
					{
						return result;
					}
					goto IL_00dd;
				}
			}
			Profile profile = default(Profile);
			if (num != 0)
			{
				if (num != 0)
				{
					if (locationCase_ != (CustomStepMakeGarden.LocationOneofCase)1)
					{
						goto IL_00dd;
					}
					LocationSourceWithRadius specificLocation = Data.MakeGarden.SpecificLocation;
					profile = Profile;
					bool flag = ApplySpecificLocationFilter(specificLocation, grid, gridObject, profile);
				}
				bool _003CIsSaveRequested_003Ek__BackingField = profile.IsSaveRequested;
				Profile.HangoutSystemState hangoutState = profile.HangoutState;
				CustomStepMakeGarden customStepMakeGarden = default(CustomStepMakeGarden);
				string realm = customStepMakeGarden.Realm;
				bool flag2 = default(bool);
				if (!flag2)
				{
					goto IL_00dd;
				}
			}
			bool _003CIsSaveRequested_003Ek__BackingField2 = profile.IsSaveRequested;
			bool flag3 = default(bool);
			if (flag3)
			{
			}
			goto IL_00dd;
			IL_00dd:
			Profile.HangoutSystemState hangoutState2 = profile.HangoutState;
			CustomStepMakeGarden customStepMakeGarden2 = default(CustomStepMakeGarden);
			if ((customStepMakeGarden2.VillageArea.useField_ ? 1 : 0) == num)
			{
			}
			Profile.HangoutSystemState hangoutState3 = profile.HangoutState;
			CustomStepMakeGarden customStepMakeGarden3 = default(CustomStepMakeGarden);
			VillageAreaType villageArea = customStepMakeGarden3.VillageArea.VillageArea;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008210")]
		[Cpp2IlInjected.Address(RVA = "0x81DFA0", Offset = "0x81C9A0", VA = "0x18081DFA0")]
		private void StopMakeGarden()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.GardeningEvent value = OnMakeGardenGardeningEvent;
				dispatcher.OnGardeningEvent -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008211")]
		[Cpp2IlInjected.Address(RVA = "0x817FF0", Offset = "0x8169F0", VA = "0x180817FF0")]
		private unsafe void StartFillKeyhole()
		{
			MissionObjectiveData missionObjectiveData = Data;
			int num = 0;
			ProfileEventDispatcher dispatcher = Dispatcher;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.KeyholeLevelCompleted value = OnKeyholeLevelCompleted;
			dispatcher.OnKeyholeLevelCompleted += value;
			ProfileWorld world_ = Profile.world_;
			MissionObjectiveData missionObjectiveData2 = Data;
			MapField<string, Keyhole> keyholes_ = world_.keyholes_;
			string keyhole_ = missionObjectiveData2.FillKeyhole.keyhole_;
			if (((MapField<TKey, TValue>)(object)keyholes_).TryGetValue((TKey)keyhole_, out *(TValue*)num) && Data.FillKeyhole != null)
			{
				CustomStepFillKeyhole fillKeyhole = Data.FillKeyhole;
				if ((long)(IntPtr)keyholes_ > (long)fillKeyhole.levelIndexToComplete_)
				{
					bool flag2 = ChangeStatus(MissionStepStatus.Completed);
					return;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008212")]
		[Cpp2IlInjected.Address(RVA = "0x80EFC0", Offset = "0x80D9C0", VA = "0x18080EFC0")]
		private void OnKeyholeLevelCompleted(Keyhole keyhole, int levelCompleted)
		{
			//Discarded unreachable code: IL_0033
			if (Data.FillKeyhole.levelIndexToComplete_ == levelCompleted)
			{
				MissionObjectiveData missionObjectiveData = Data;
				string gUID_ = keyhole.gUID_;
				if (missionObjectiveData.FillKeyhole != null)
				{
					bool flag = ChangeStatus(MissionStepStatus.Completed);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008213")]
		[Cpp2IlInjected.Address(RVA = "0x81DAA0", Offset = "0x81C4A0", VA = "0x18081DAA0")]
		private void StopFillKeyhole()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.KeyholeLevelCompleted value = OnKeyholeLevelCompleted;
				dispatcher.OnKeyholeLevelCompleted -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008214")]
		[Cpp2IlInjected.Address(RVA = "0x817C10", Offset = "0x816610", VA = "0x180817C10")]
		private void StartEatMeal()
		{
			//Discarded unreachable code: IL_004a
			MissionObjectiveData missionObjectiveData = Data;
			ProfileEventDispatcher dispatcher = Dispatcher;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.ItemRemoved value = OnMealEaten;
			dispatcher.OnItemRemoved += value;
			float currentAmount = CurrentAmount;
			bool flag2 = ChangeStatus(MissionStepStatus.Completed);
		}

		[Cpp2IlInjected.Token(Token = "0x6008215")]
		[Cpp2IlInjected.Address(RVA = "0x80F180", Offset = "0x80DB80", VA = "0x18080F180")]
		private void OnMealEaten(IInventory inventory, Item item, int amount, ItemState state, InvActionType reason)
		{
			//Discarded unreachable code: IL_0036
			//IL_0021: Expected O, but got I4
			int itemID = item.ItemID;
			ItemFilter itemFilter = itemFilter_;
			int num = default(int);
			if (num != 0)
			{
				int num2 = 0;
				bool flag = ((RepeatedField<T>)(object)itemIdsCollected_).Remove((T)itemID);
				float currentAmount = CurrentAmount;
				bool flag2 = ChangeStatus(MissionStepStatus.Ongoing);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008216")]
		[Cpp2IlInjected.Address(RVA = "0x81D840", Offset = "0x81C240", VA = "0x18081D840")]
		private void StopEatMeal()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.ItemRemoved value = OnMealEaten;
				dispatcher.OnItemRemoved -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008217")]
		[Cpp2IlInjected.Address(RVA = "0x817880", Offset = "0x816280", VA = "0x180817880")]
		private void StartCraftItem()
		{
			//Discarded unreachable code: IL_0038
			MissionObjectiveData missionObjectiveData = Data;
			ProfileEventDispatcher dispatcher = Dispatcher;
			int num = 0;
			bool flag = (byte)(stepType_ = (((missionObjectiveData.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
			ProfileEventDispatcher.CraftingCompleted value = CraftItem_OnCraftingCompleted;
			dispatcher.OnCraftingCompleted += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6008218")]
		[Cpp2IlInjected.Address(RVA = "0x81D550", Offset = "0x81BF50", VA = "0x18081D550")]
		private void StopCraftItem()
		{
			ProfileEventDispatcher dispatcher = Dispatcher;
			if (dispatcher != null)
			{
				ProfileEventDispatcher.CraftingCompleted value = CraftItem_OnCraftingCompleted;
				dispatcher.OnCraftingCompleted -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008219")]
		[Cpp2IlInjected.Address(RVA = "0x803E70", Offset = "0x802870", VA = "0x180803E70")]
		private void CraftItem_OnCraftingCompleted(Item craftingRecipeItem, int amountOfCraftingDone)
		{
			//IL_002d: Expected O, but got I4
			int itemID = craftingRecipeItem.ItemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			ItemFilter itemFilter = itemFilter_;
			int num = default(int);
			if (num != 0)
			{
				int num2 = 0;
				bool flag2 = ((RepeatedField<T>)(object)itemIdsCollected_).Remove((T)itemID);
				float currentAmount = CurrentAmount;
				float num3 = default(float);
				if (num3 >= targetAmount_)
				{
					throw new NullReferenceException();
				}
				bool flag3 = ChangeStatus(MissionStepStatus.Ongoing);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600822B")]
		[Cpp2IlInjected.Address(RVA = "0x823570", Offset = "0x821F70", VA = "0x180823570")]
		public MissionObjective(MissionObjectiveData missionData)
		{
			MapField<string, string> mapField = (progressKeys_ = (MapField<string, string>)(object)new MapField<TKey, TValue>());
			RepeatedField<int> repeatedField = (itemIdsCollected_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<Types.GridObjectInfo> repeatedField2 = (gridObjectIdsCollected_ = (RepeatedField<Types.GridObjectInfo>)(object)new RepeatedField<T>());
			RepeatedField<ItemFilterWithAmount> repeatedField3 = (itemFiltersWithAmount_ = (RepeatedField<ItemFilterWithAmount>)(object)new RepeatedField<T>());
			StopTalkToCharacter();
			Data = missionData;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600822C")]
		[Cpp2IlInjected.Address(RVA = "0x810EE0", Offset = "0x80F8E0", VA = "0x180810EE0")]
		internal void PreInit(in World world, ITransactionContext context, MissionObjectiveData data, MissionSubStep subParent)
		{
			//IL_0029: Expected O, but got I4
			IWorldEventDispatcher dispatcher = world.dispatcher;
			if (dispatcher == null)
			{
			}
			int num = 0;
			Dispatcher = (ProfileEventDispatcher)dispatcher;
			Context = context;
			Data = data;
			MissionSubStep = (MissionSubStep)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600822D")]
		[Cpp2IlInjected.Address(RVA = "0x80ACE0", Offset = "0x8096E0", VA = "0x18080ACE0")]
		internal void Init(Random random)
		{
			//Discarded unreachable code: IL_0338, IL_033e, IL_0344, IL_034a, IL_0350, IL_0356, IL_035c
			//IL_0070: Expected O, but got I4
			//IL_0070: Expected O, but got I4
			//IL_009e: Expected I4, but got I8
			//IL_009e: Expected O, but got I4
			//IL_00f2: Expected I4, but got O
			//IL_0186: Expected I4, but got I8
			//IL_0186: Expected O, but got I4
			//IL_01ee: Expected O, but got I4
			//IL_0207: Expected O, but got I4
			//IL_0217: Expected F4, but got I4
			//IL_022e: Expected O, but got I4
			//IL_023e: Expected F4, but got I4
			//IL_025b: Expected O, but got I4
			//IL_02a5: Expected O, but got I4
			//IL_032d: Expected O, but got I4
			//IL_0337: Expected F4, but got I4
			bool verifyCanReachItem = default(bool);
			ulong num2 = default(ulong);
			bool flag = default(bool);
			ItemType type_ = default(ItemType);
			ItemType itemType = default(ItemType);
			string text2 = default(string);
			ulong num4 = default(ulong);
			int num6 = default(int);
			do
			{
				int num = 0;
				MissionObjectiveData missionObjectiveData = Data;
				MissionObjectiveData.CustomStepOneofCase customStepCase_ = missionObjectiveData.customStepCase_;
				if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.GardeningHarvest)
				{
				}
				bool onlySeedCrop = customStepCase_ == MissionObjectiveData.CustomStepOneofCase.GardeningPlant;
				if (customStepCase_ != MissionObjectiveData.CustomStepOneofCase.CatchFish)
				{
					verifyCanReachItem = customStepCase_ == MissionObjectiveData.CustomStepOneofCase.CookMeal;
				}
				IItemSelector getIItemSelector = missionObjectiveData.GetIItemSelector;
				MissionItemData data = MissionSubStep.MissionSlot.Data;
				if (data != null)
				{
					string debugName = data.DebugName;
				}
				if (Data != null)
				{
				}
				string text = "Mission:" + (string)num + ", Step:" + (string)num;
				if (getIItemSelector != null)
				{
				}
				Profile profile = Profile;
				string debugName2 = "Init " + text;
				ItemFilter itemFilter = (itemFilter_ = ItemFilter.New((ItemSelector)num, profile, random, onlySeedCrop, verifyCanReachItem, (byte)num2 != 0, debugName2));
				ItemFilter itemFilter2 = itemFilter_;
				if ((IntPtr)itemFilter2.data_ == (IntPtr)num)
				{
					if (getIItemSelector != null)
					{
						if (itemFilter2 != null)
						{
						}
						if (((num == 5) ? 1 : 0) != num)
						{
							goto IL_0115;
						}
					}
					IUniqueItem getIUniqueItem = Data.GetIUniqueItem;
					if (getIUniqueItem != null && flag)
					{
						ItemFilterData itemFilterData = new ItemFilterData();
						itemFilterData.item_ = (int)getIUniqueItem;
						itemFilterData.type_ = type_;
						if (itemType == ItemType.ActivityItem)
						{
						}
						itemFilterData.activityItemType_ = (ActivityItemType)num;
						itemFilter_.data_ = itemFilterData;
					}
				}
				goto IL_0115;
				IL_0115:
				IStepAmount getIStepAmount = Data.GetIStepAmount;
				if (getIStepAmount != null && getIStepAmount != null)
				{
					Func<IScalableValue, int> func = (Func<IScalableValue, int>)(object)new Func<T, TResult>(ScaleFunc);
					int num3 = 0;
				}
				((RepeatedField<T>)(object)itemFiltersWithAmount_).Clear();
				IItemSelectorsWithAmount getIItemSelectorsWithAmount = Data.GetIItemSelectorsWithAmount;
				if (getIItemSelectorsWithAmount == null)
				{
					break;
				}
				if (getIItemSelectorsWithAmount != null)
				{
					Profile profile2 = Profile;
					text2 = "InitItemToGive " + text;
					ItemFilter itemFilter3 = ItemFilter.New((ItemSelector)num, profile2, random, onlySeedCrop, verifyCanReachItem, (byte)num4 != 0, text2);
					Func<IScalableValue, int> func2 = (Func<IScalableValue, int>)(object)new Func<T, TResult>(ScaleFunc);
					int num5 = 0;
					RepeatedField<ItemFilterWithAmount> repeatedField = itemFiltersWithAmount_;
					ItemFilterWithAmount itemFilterWithAmount = new ItemFilterWithAmount();
					itemFilterWithAmount.itemFilter_ = itemFilter3;
					((RepeatedField<T>)(object)repeatedField).Add((T)itemFilterWithAmount);
				}
				num6 = 0;
				if (getIItemSelectorsWithAmount != null)
				{
					int num7 = 0;
				}
			}
			while (text2 != null);
			ISpawnHelper spawnHelper = default(ISpawnHelper);
			if (spawnHelper == null || spawnHelper != null)
			{
			}
			ISpawnHelper spawnHelper2 = default(ISpawnHelper);
			if (spawnHelper2 != null && spawnHelper2 != null)
			{
				Func<IScalableValue, int> func3 = (Func<IScalableValue, int>)(object)new Func<T, TResult>(ScaleFunc);
			}
			IMinWeightReq minWeightReq = default(IMinWeightReq);
			if (minWeightReq != null && minWeightReq != null)
			{
				Func<IScalableValue, int> func4 = (Func<IScalableValue, int>)(object)new Func<T, TResult>(ScaleFunc);
			}
			int num8 = 0;
			int num9 = 0;
			minWeightRequired_ = num9;
			IMaxWeightReq maxWeightReq = default(IMaxWeightReq);
			if (maxWeightReq != null && maxWeightReq != null)
			{
				Func<IScalableValue, int> func5 = (Func<IScalableValue, int>)(object)new Func<T, TResult>(ScaleFunc);
			}
			if (num8 <= num9)
			{
			}
			maxWeightRequired_ = num9;
			if (num9 > num9)
			{
			}
			IMinStarRatingReq minStarRatingReq = default(IMinStarRatingReq);
			if (minStarRatingReq != null && minStarRatingReq != null)
			{
				Func<IScalableValue, int> func6 = (Func<IScalableValue, int>)(object)new Func<T, TResult>(ScaleFunc);
			}
			int num10 = 0;
			int num11 = default(int);
			minStarRatingRequired_ = num11;
			MissionSlot missionSlot = default(MissionSlot);
			Item characterItem = missionSlot.CharacterItem;
			ITargetCharacterOverride targetCharacterOverride = default(ITargetCharacterOverride);
			MissionObjective missionObjective;
			bool acceptSleep;
			if (targetCharacterOverride != null)
			{
				uint num12 = default(uint);
				if (num6 < (int)num12)
				{
					num6 += num6;
					num6++;
				}
				bool flag2 = default(bool);
				if (this == null || flag2)
				{
				}
				missionObjective = (MissionObjective)num6;
				acceptSleep = false;
				Func<Character, bool> func7 = (Func<Character, bool>)(object)new Func<T, TResult>(FilterCharacter);
				IEnumerable<Character> cpp2il__autoParamName__idx_ = default(IEnumerable<Character>);
				Character[] array = default(Character[]);
				if (!Enumerable.Any<Character>((IEnumerable<>)(object)((IEnumerable<>)cpp2il__autoParamName__idx_).ToArray<Character>()))
				{
					acceptSleep = true;
					Func<Character, bool> func8 = (Func<Character, bool>)(object)new Func<T, TResult>(FilterCharacter);
					IEnumerable<Character> cpp2il__autoParamName__idx_2 = default(IEnumerable<Character>);
					array = ((IEnumerable<>)cpp2il__autoParamName__idx_2).ToArray<Character>();
				}
				bool flag3 = Enumerable.Any<Character>((IEnumerable<>)(object)array);
				if (!flag3)
				{
				}
				int iD = array[flag3 ? 1u : 0u].Data.ID;
			}
			IChallengeType challengeType = default(IChallengeType);
			if (challengeType != null)
			{
				int num13 = 0;
			}
			IItemAmount itemAmount = default(IItemAmount);
			if (itemAmount != null && itemAmount != null)
			{
				Func<IScalableValue, int> func9 = (Func<IScalableValue, int>)(object)new Func<T, TResult>(ScaleFunc);
			}
			itemAmount_ = num9;
			[Cpp2IlInjected.Token(Token = "0x6008309")]
			[Cpp2IlInjected.Address(RVA = "0x1305B60", Offset = "0x1304560", VA = "0x181305B60")]
			bool FilterCharacter(Character character)
			{
				if (character.InVillage)
				{
					BaseItem base_ = character.base_;
					MissionObjective missionObjective2 = missionObjective;
					int id_ = base_.id_;
					MissionSlot missionSlot2 = missionObjective2.MissionSlot;
					if ((IntPtr)id_ != (IntPtr)MissionSlot._repeated_itemsToGive_codec)
					{
						if (acceptSleep)
						{
							return true;
						}
						CharacterItemData data2 = character.Data;
						MissionObjective missionObjective3 = missionObjective;
						MissionObjective missionObjective4 = missionObjective;
						MissionObjective missionObjective5 = missionObjective;
						ScheduleType scheduleType = default(ScheduleType);
						return scheduleType != ScheduleType.Sleep;
					}
				}
				int num14 = 0;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x600824D")]
			[Cpp2IlInjected.Address(RVA = "0x8218B0", Offset = "0x8202B0", VA = "0x1808218B0")]
			int ScaleFunc(IScalableValue value)
			{
				//Discarded unreachable code: IL_0019
				int level_ = Profile.player_.level_;
				return MissionUtil.ResolveScalableValue(value, level_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600822E")]
		[Cpp2IlInjected.Address(RVA = "0x81B730", Offset = "0x81A130", VA = "0x18081B730")]
		internal void Start(MissionSubStep parent, StepCompletionChangedDelegate onCompletionChanged, StepStatusChangedDelegate onStatusChanged)
		{
			//IL_0182: Expected I4, but got I8
			//IL_0202: Expected I4, but got I8
			//IL_031e: Expected I4, but got I8
			//IL_0383: Expected I4, but got I8
			//IL_042a: Expected I4, but got I8
			//IL_0477: Expected I4, but got I8
			//IL_0484: Expected I4, but got I8
			//IL_0508: Expected I4, but got I8
			//IL_053b: Invalid comparison between F4 and I4
			//IL_0545: Expected I4, but got I8
			//IL_069b: Expected I4, but got I8
			//IL_06e1: Expected I4, but got I8
			//IL_074e: Expected I4, but got I8
			//IL_080d: Expected I4, but got I8
			//IL_08a7: Expected I4, but got I8
			//IL_0911: Expected I4, but got I8
			bool autoConfirm_ = default(bool);
			CustomStepConditional customStepConditional = default(CustomStepConditional);
			CustomStepDecorate customStepDecorate = default(CustomStepDecorate);
			ProfileEventDispatcher.FlowerEvent flowerEvent = default(ProfileEventDispatcher.FlowerEvent);
			ProfileEventDispatcher dispatcher2 = default(ProfileEventDispatcher);
			ProfileEventDispatcher.GardeningEvent gardeningEvent = default(ProfileEventDispatcher.GardeningEvent);
			CustomStepUnlockCharacter customStepUnlockCharacter = default(CustomStepUnlockCharacter);
			ProfileWorld world_ = default(ProfileWorld);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			ProfileEventDispatcher.RestaurantOrderFulfilled restaurantOrderFulfilled = default(ProfileEventDispatcher.RestaurantOrderFulfilled);
			ProfileEventDispatcher.DiscussionEnded discussionEnded = default(ProfileEventDispatcher.DiscussionEnded);
			ProfileEventDispatcher.DutyAchRewardCollected dutyAchRewardCollected = default(ProfileEventDispatcher.DutyAchRewardCollected);
			uint type_ = default(uint);
			ProfileEventDispatcher dispatcher7 = default(ProfileEventDispatcher);
			bool flag6 = default(bool);
			ProfileEventDispatcher dispatcher9 = default(ProfileEventDispatcher);
			ProfileEventDispatcher.ShopItemBought shopItemBought = default(ProfileEventDispatcher.ShopItemBought);
			ulong num5 = default(ulong);
			ProfileEventDispatcher dispatcher11 = default(ProfileEventDispatcher);
			ProfileEventDispatcher.ItemAdded itemAdded = default(ProfileEventDispatcher.ItemAdded);
			ProfileEventDispatcher.MiningRockEmptied miningRockEmptied = default(ProfileEventDispatcher.MiningRockEmptied);
			GridCollection gridCollection_ = default(GridCollection);
			CustomStepParty customStepParty = default(CustomStepParty);
			(IGrid, GridObject) tuple = default((IGrid, GridObject));
			bool flag10 = default(bool);
			ProfileEventDispatcher dispatcher13 = default(ProfileEventDispatcher);
			ProfileEventDispatcher.ItemInteraction itemInteraction = default(ProfileEventDispatcher.ItemInteraction);
			ProfileEventDispatcher dispatcher14 = default(ProfileEventDispatcher);
			ProfileEventDispatcher.GardeningEvent gardeningEvent2 = default(ProfileEventDispatcher.GardeningEvent);
			ProfileEventDispatcher dispatcher15 = default(ProfileEventDispatcher);
			ProfileEventDispatcher.GardeningEvent gardeningEvent3 = default(ProfileEventDispatcher.GardeningEvent);
			ProfileEventDispatcher.ItemsGivenToCharacter itemsGivenToCharacter = default(ProfileEventDispatcher.ItemsGivenToCharacter);
			Item characterItem = default(Item);
			ProfileEventDispatcher.CritterFed critterFed = default(ProfileEventDispatcher.CritterFed);
			ProfileEventDispatcher dispatcher20 = default(ProfileEventDispatcher);
			ProfileEventDispatcher.AvatarCustomizationChanged avatarCustomizationChanged = default(ProfileEventDispatcher.AvatarCustomizationChanged);
			ProfileEventDispatcher dispatcher21 = default(ProfileEventDispatcher);
			bool flag16 = default(bool);
			ProfileEventDispatcher.CraftingCompleted craftingCompleted = default(ProfileEventDispatcher.CraftingCompleted);
			while (true)
			{
				if (stepStarted)
				{
					continue;
				}
				stepStarted = true;
				StepCompletionChangedDelegate stepCompletionChanged = this.StepCompletionChanged;
				int num = 0;
				Delegate @delegate = Delegate.Combine(stepCompletionChanged, onCompletionChanged);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					continue;
				}
				while ((object)@delegate != stepCompletionChanged)
				{
				}
				StepStatusChangedDelegate stepStatusChanged = this.StepStatusChanged;
				Delegate delegate2 = Delegate.Combine(stepStatusChanged, onStatusChanged);
				if ((object)delegate2 != null && (object)delegate2 == null)
				{
					continue;
				}
				while ((object)delegate2 != stepStatusChanged)
				{
				}
				MissionSubStep = parent;
				switch (status_)
				{
				case MissionStepStatus.Confirmed:
					continue;
				case MissionStepStatus.Completed:
				{
					MissionObjectiveData missionObjectiveData = Data;
					MissionObjectiveData.CustomStepOneofCase customStepCase_ = missionObjectiveData.customStepCase_;
					if (customStepCase_ > MissionObjectiveData.CustomStepOneofCase.FollowCharacter)
					{
						if (customStepCase_ <= MissionObjectiveData.CustomStepOneofCase.PlaceBuilding || customStepCase_ != MissionObjectiveData.CustomStepOneofCase.Possess || !missionObjectiveData.Possess.autoConfirm_)
						{
							continue;
						}
						if (missionObjectiveData.VisitArea.autoConfirm_)
						{
							autoConfirm_ = missionObjectiveData.MakeGarden.autoConfirm_;
						}
					}
					if ((autoConfirm_ ? 1 : 0) <= (true ? 1 : 0) || (!autoConfirm_ && (!autoConfirm_ || !missionObjectiveData.FollowCharacter.AutoConfirm || !customStepConditional.autoConfirm_ || customStepDecorate.autoConfirm_)))
					{
						continue;
					}
					break;
				}
				}
				MissionObjectiveData.CustomStepOneofCase customStepCase_2 = Data.customStepCase_;
				if (customStepCase_2 > MissionObjectiveData.CustomStepOneofCase.GiftToCharacter)
				{
					if (customStepCase_2 > MissionObjectiveData.CustomStepOneofCase.RemoveBlocker)
					{
						if (customStepCase_2 > MissionObjectiveData.CustomStepOneofCase.TakePicture)
						{
							if (customStepCase_2 > MissionObjectiveData.CustomStepOneofCase.UnlockCharacter)
							{
								if (customStepCase_2 == MissionObjectiveData.CustomStepOneofCase.Upgrade)
								{
									StartUpgrade();
								}
								if (customStepCase_2 == MissionObjectiveData.CustomStepOneofCase.VisitArea)
								{
									StartVisitArea();
								}
								if (customStepCase_2 != MissionObjectiveData.CustomStepOneofCase.WaterPlant)
								{
									continue;
								}
								MissionObjectiveData missionObjectiveData2 = Data;
								goBehaviorInt_ = 2;
								bool flag = (byte)(stepType_ = (((missionObjectiveData2.hideProgressionCount_ ? 1 : 0) == num) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
								if (missionObjectiveData2.WaterPlant.plantTypesCase_ == CustomStepWaterPlant.PlantTypesOneofCase.FlowerItem)
								{
									ProfileEventDispatcher dispatcher = Dispatcher;
									flowerEvent = OnWaterFlowerResultReceived;
									dispatcher.OnFlowerEvent += flowerEvent;
								}
								if ((long)flowerEvent != 2)
								{
									continue;
								}
								dispatcher2 = Dispatcher;
								gardeningEvent = OnWaterCropResultReceived;
								dispatcher2.OnGardeningEvent += gardeningEvent;
							}
							if ((long)gardeningEvent == 270)
							{
								goBehaviorInt_ = 32;
							}
							if ((long)gardeningEvent == 275)
							{
								StartUnlock();
							}
							if ((long)gardeningEvent != 280)
							{
								continue;
							}
							if ((IntPtr)(customStepUnlockCharacter.skipCinematic_ ? 1 : 0) == (IntPtr)dispatcher2)
							{
								world_ = Profile.world_;
								long num2 = Convert.ToInt64((uint)targetCharacterItemID_);
								if (!flag2 || (!flag3 && Data.UnlockCharacter.nextState_ != CustomStepUnlockCharacter.Types.UnlockType.LockedInVillage))
								{
									continue;
								}
							}
							UnlockCharacterCompleted();
						}
						if ((long)dispatcher2 > 250)
						{
							if ((long)dispatcher2 == 255)
							{
								bool flag4 = (byte)(stepType_ = (((IntPtr)(Data.hideProgressionCount_ ? 1 : 0) == (IntPtr)world_) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
								ProfileEventDispatcher dispatcher3 = Dispatcher;
								restaurantOrderFulfilled = Dispatcher_ServeRestaurantOrder_OnRestaurantOrderFulfilled;
								dispatcher3.OnRestaurantOrderFulfilled += restaurantOrderFulfilled;
							}
							if ((long)restaurantOrderFulfilled == 260)
							{
								ProfileEventDispatcher dispatcher4 = Dispatcher;
								discussionEnded = Discussion_OnDiscussionEnded;
								dispatcher4.OnDiscussionEnded += discussionEnded;
							}
							if ((long)discussionEnded != 265)
							{
								continue;
							}
							StartTakePicture();
						}
						if ((long)discussionEnded == 245)
						{
							ProfileEventDispatcher dispatcher5 = Dispatcher;
							goBehaviorInt_ = 1048576;
							if (dispatcher5 == null)
							{
								continue;
							}
							dutyAchRewardCollected = Dispatcher_OnDutyAchRewardCollected_RoyalDuties;
							dispatcher5.OnDutyAchRewardCollected += dutyAchRewardCollected;
						}
						if ((long)dutyAchRewardCollected != 250)
						{
							continue;
						}
						if ((IntPtr)(Data.SellItem.mustSellSpecificItems_ ? 1 : 0) == (IntPtr)dutyAchRewardCollected)
						{
							ItemFilter itemFilter = itemFilter_;
							if (itemFilter.data_ == dutyAchRewardCollected)
							{
								ItemFilterData itemFilterData = new ItemFilterData();
								itemFilterData.activityItemType_ = ActivityItemType.Flower;
								itemFilterData.type_ = (ItemType)type_;
								itemFilter.data_ = itemFilterData;
							}
						}
						UpdatedSellItemGoBehavior();
						bool flag5 = (byte)(stepType_ = (((IntPtr)(Data.hideProgressionCount_ ? 1 : 0) == (IntPtr)dutyAchRewardCollected) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
						ProfileEventDispatcher dispatcher6 = Dispatcher;
						ProfileEventDispatcher.ShopItemsSold value = Dispatcher_SellItem_OnShopItemsSold;
						dispatcher6.OnShopItemsSold += value;
						dispatcher7 = Dispatcher;
						ProfileEventDispatcher.ItemAdded value2 = Dispatcher_SellItem_OnItemAdded;
						dispatcher7.OnItemAdded += value2;
					}
					if ((flag6 ? 1 : 0) > (true ? 1 : 0))
					{
						if ((flag6 ? 1 : 0) > (true ? 1 : 0))
						{
							if (flag6)
							{
								StartPossess();
							}
							if (flag6)
							{
								MissionObjectiveData missionObjectiveData3 = Data;
								goBehaviorInt_ = 65540;
								bool flag7 = (byte)(stepType_ = (((IntPtr)(missionObjectiveData3.hideProgressionCount_ ? 1 : 0) == (IntPtr)dispatcher7) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
								if (missionObjectiveData3.PurchaseItem.mustPurchaseSpecificItems_)
								{
									ItemType type_2 = itemFilter_.data_.type_;
									if (type_2 != ItemType.ActivityItem && type_2 <= ItemType.Character)
									{
										goBehaviorInt_ = 130;
									}
									goBehaviorInt_ = 65668;
								}
								if (Data.PurchaseItem.locationCase_ == CustomStepPurchaseItem.LocationOneofCase.Store)
								{
									ProfileEventDispatcher dispatcher8 = Dispatcher;
									ProfileEventDispatcher.StoreItemBought value3 = Dispatcher_PurchaseItem_OnStoreItemBought;
									dispatcher8.OnStoreItemBought += value3;
								}
								dispatcher9 = Dispatcher;
								shopItemBought = Dispatcher_PurchaseItem_OnShopItemBought;
								dispatcher9.OnShopItemBought += shopItemBought;
							}
							if ((long)shopItemBought != 240)
							{
								continue;
							}
							StartRemoveBlocker();
						}
						if ((long)shopItemBought == 220)
						{
							MissionObjectiveData missionObjectiveData4 = Data;
							goBehaviorInt_ = 2;
							bool flag8 = (byte)(stepType_ = (((IntPtr)(missionObjectiveData4.hideProgressionCount_ ? 1 : 0) == (IntPtr)dispatcher9) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
							if (missionObjectiveData4.PickUp.pickUpTypesCase_ != CustomStepPickUp.PickUpTypesOneofCase.QuestItem)
							{
								float num3 = amountToSpawn_;
								int num4 = 0;
								if (!(num3 <= (float)num4))
								{
									SpawnItemsForPickUp((byte)num5 != 0);
								}
								ProfileEventDispatcher dispatcher10 = Dispatcher;
								ProfileEventDispatcher.GridChanged value4 = PickUp_OnGridChanged;
								dispatcher10.OnGridChanged += value4;
							}
							if (((MapField<TKey, TValue>)(object)progressKeys_).Count == 0)
							{
								int isFindMode = 0;
								SpawnItemsForPickUp((byte)isFindMode != 0);
							}
							dispatcher11 = Dispatcher;
							itemAdded = PickUp_OnItemAdded;
							dispatcher11.OnItemAdded += itemAdded;
						}
						if ((long)itemAdded != 225)
						{
							continue;
						}
						StartPlaceBuilding();
					}
					if ((long)itemAdded > 200)
					{
						if ((long)itemAdded == 205)
						{
							StartMakeGarden();
						}
						if ((long)itemAdded == 210)
						{
							bool flag9 = (byte)(stepType_ = (((IntPtr)(Data.hideProgressionCount_ ? 1 : 0) == (IntPtr)dispatcher11) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
							ProfileEventDispatcher dispatcher12 = Dispatcher;
							miningRockEmptied = MineMineral_OnMiningRockEmptied;
							dispatcher12.OnMiningRockEmptied += miningRockEmptied;
						}
						if ((long)miningRockEmptied != 215)
						{
							continue;
						}
						gridCollection_ = Profile.world_.gridCollection_;
						Item partyItem = customStepParty.PartyItem;
						if ((object)tuple != null)
						{
							continue;
						}
					}
					if (flag10)
					{
						bool flag11 = (byte)(stepType_ = (((IntPtr)(Data.hideProgressionCount_ ? 1 : 0) == (IntPtr)gridCollection_) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
						dispatcher13 = Dispatcher;
						itemInteraction = OnItemInteraction;
						dispatcher13.OnItemInteraction += itemInteraction;
					}
					if ((long)itemInteraction != 200)
					{
						continue;
					}
					goBehaviorInt_ = 32772;
				}
				if ((long)itemInteraction > 135)
				{
					if ((long)itemInteraction > 165)
					{
						if ((long)itemInteraction > 180)
						{
							if ((long)itemInteraction == 185)
							{
								Profile profile = Profile;
								goBehaviorInt_ = 2;
								ProfilePlayer player_ = profile.player_;
								int toolItemType = 0;
								if (!player_.IsToolUnlocked((ToolItemType)toolItemType))
								{
								}
								bool flag12 = (byte)(stepType_ = (((IntPtr)(Data.hideProgressionCount_ ? 1 : 0) == (IntPtr)dispatcher13) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
								dispatcher14 = Dispatcher;
								gardeningEvent2 = OnGardeningHarvestResultReceived;
								dispatcher14.OnGardeningEvent += gardeningEvent2;
							}
							if ((long)gardeningEvent2 == 190)
							{
								Profile profile2 = Profile;
								goBehaviorInt_ = 66;
								ProfilePlayer player_2 = profile2.player_;
								int toolItemType2 = 0;
								if (!player_2.IsToolUnlocked((ToolItemType)toolItemType2))
								{
								}
								bool flag13 = (byte)(stepType_ = (((IntPtr)(Data.hideProgressionCount_ ? 1 : 0) == (IntPtr)dispatcher14) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
								dispatcher15 = Dispatcher;
								gardeningEvent3 = OnGardeningPlantResultReceived;
								dispatcher15.OnGardeningEvent += gardeningEvent3;
							}
							if ((long)gardeningEvent3 != 195)
							{
								continue;
							}
							bool flag14 = (byte)(stepType_ = (((IntPtr)(Data.hideProgressionCount_ ? 1 : 0) == (IntPtr)dispatcher15) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
							ProfileEventDispatcher dispatcher16 = Dispatcher;
							itemsGivenToCharacter = GiftToCharacter_OnItemsGivenToCharacter;
							dispatcher16.OnItemsGivenToCharacter += itemsGivenToCharacter;
						}
						if ((long)itemsGivenToCharacter == 170)
						{
							StartFinishHouse();
						}
						if ((long)itemsGivenToCharacter == 175)
						{
							goBehaviorInt_ = 16388;
						}
						if ((long)itemsGivenToCharacter != 180)
						{
							continue;
						}
						ProfileEventDispatcher dispatcher17 = Dispatcher;
						ProfileEventDispatcher.CharacterUnlocked value5 = Friend_OnCharacterUnlocked;
						dispatcher17.OnCharacterUnlocked += value5;
						ProfileEventDispatcher dispatcher18 = Dispatcher;
						ProfileEventDispatcher.CharacterFriendshipLevelChanged value6 = Friend_OnCharacterFriendshipLevelChanged;
						dispatcher18.OnCharacterFriendshipLevelChanged += value6;
						characterItem = Data.Friend.CharacterItem;
					}
					if ((long)characterItem > 150)
					{
						if ((long)characterItem == 155)
						{
							StartExpandHouse();
						}
						if ((long)characterItem == 160)
						{
							ProfileEventDispatcher dispatcher19 = Dispatcher;
							goBehaviorInt_ = 512;
							if (dispatcher19 == null)
							{
								continue;
							}
							critterFed = FeedCritter_OnFed;
							dispatcher19.OnCritterFed += critterFed;
						}
						if ((long)critterFed != 165)
						{
							continue;
						}
						StartFillKeyhole();
					}
					if ((long)critterFed == 145)
					{
						dispatcher20 = Dispatcher;
						avatarCustomizationChanged = OnAvatarCustomizationChanged;
						dispatcher20.OnAvatarCustomizationChanged += avatarCustomizationChanged;
						goBehaviorInt_ = 130;
						UpdateDressupProgress();
					}
					if ((long)avatarCustomizationChanged != 150)
					{
						continue;
					}
					bool flag15 = (byte)(stepType_ = (((IntPtr)(Data.hideProgressionCount_ ? 1 : 0) == (IntPtr)dispatcher20) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
					dispatcher21 = Dispatcher;
					ProfileEventDispatcher.ItemRemoved value7 = OnMealEaten;
					dispatcher21.OnItemRemoved += value7;
					float currentAmount = CurrentAmount;
				}
				if ((flag16 ? 1 : 0) > (true ? 1 : 0) && (flag16 ? 1 : 0) > (true ? 1 : 0))
				{
					if (flag16)
					{
						StartCookMeal();
					}
					if (flag16)
					{
						bool flag17 = (byte)(stepType_ = (((IntPtr)(Data.hideProgressionCount_ ? 1 : 0) == (IntPtr)dispatcher21) ? MissionStepType.StepItem : MissionStepType.StepGameplay)) != 0;
						ProfileEventDispatcher dispatcher22 = Dispatcher;
						craftingCompleted = CraftItem_OnCraftingCompleted;
						dispatcher22.OnCraftingCompleted += craftingCompleted;
					}
					if ((long)craftingCompleted == 135)
					{
						/*Error: Could not find block for branch target IL_09cb*/;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600822F")]
		[Cpp2IlInjected.Address(RVA = "0x81EFB0", Offset = "0x81D9B0", VA = "0x18081EFB0")]
		internal void Stop(StepCompletionChangedDelegate onCompletionChanged, StepStatusChangedDelegate onStatusChanged)
		{
			ProfileEventDispatcher.PlayerLevelGained playerLevelGained = default(ProfileEventDispatcher.PlayerLevelGained);
			ProfileEventDispatcher.CurrentSceneChanged currentSceneChanged = default(ProfileEventDispatcher.CurrentSceneChanged);
			ProfileEventDispatcher.GardeningEvent gardeningEvent = default(ProfileEventDispatcher.GardeningEvent);
			ProfileEventDispatcher.RestaurantOrderFulfilled restaurantOrderFulfilled = default(ProfileEventDispatcher.RestaurantOrderFulfilled);
			ProfileEventDispatcher.DiscussionEnded discussionEnded = default(ProfileEventDispatcher.DiscussionEnded);
			ProfileEventDispatcher.PictureTaken pictureTaken = default(ProfileEventDispatcher.PictureTaken);
			ProfileEventDispatcher.DutyAchRewardCollected dutyAchRewardCollected = default(ProfileEventDispatcher.DutyAchRewardCollected);
			ProfileEventDispatcher.ItemAdded itemAdded = default(ProfileEventDispatcher.ItemAdded);
			ProfileEventDispatcher.StoreItemBought storeItemBought = default(ProfileEventDispatcher.StoreItemBought);
			ProfileEventDispatcher dispatcher15 = default(ProfileEventDispatcher);
			ProfileEventDispatcher.AvatarRemoveBlocker avatarRemoveBlocker = default(ProfileEventDispatcher.AvatarRemoveBlocker);
			ProfileEventDispatcher.GridChanged gridChanged = default(ProfileEventDispatcher.GridChanged);
			ProfileEventDispatcher.GardeningEvent gardeningEvent2 = default(ProfileEventDispatcher.GardeningEvent);
			ProfileEventDispatcher.MiningRockEmptied miningRockEmptied = default(ProfileEventDispatcher.MiningRockEmptied);
			ProfileEventDispatcher.ItemInteraction itemInteraction = default(ProfileEventDispatcher.ItemInteraction);
			ProfileEventDispatcher.GardeningEvent gardeningEvent3 = default(ProfileEventDispatcher.GardeningEvent);
			ProfileEventDispatcher.GardeningEvent gardeningEvent4 = default(ProfileEventDispatcher.GardeningEvent);
			ProfileEventDispatcher.ItemsGivenToCharacter itemsGivenToCharacter = default(ProfileEventDispatcher.ItemsGivenToCharacter);
			ProfileEventDispatcher.GridChanged gridChanged2 = default(ProfileEventDispatcher.GridChanged);
			ProfileEventDispatcher.CharacterFriendshipLevelChanged characterFriendshipLevelChanged = default(ProfileEventDispatcher.CharacterFriendshipLevelChanged);
			ProfileEventDispatcher.PlayerHouseFloorAdded playerHouseFloorAdded = default(ProfileEventDispatcher.PlayerHouseFloorAdded);
			ProfileEventDispatcher.CritterFed critterFed = default(ProfileEventDispatcher.CritterFed);
			ProfileEventDispatcher.KeyholeLevelCompleted keyholeLevelCompleted = default(ProfileEventDispatcher.KeyholeLevelCompleted);
			ProfileEventDispatcher.AvatarCustomizationChanged avatarCustomizationChanged = default(ProfileEventDispatcher.AvatarCustomizationChanged);
			ProfileEventDispatcher.ItemRemoved itemRemoved = default(ProfileEventDispatcher.ItemRemoved);
			ProfileEventDispatcher.MealCooked mealCooked = default(ProfileEventDispatcher.MealCooked);
			ProfileEventDispatcher.CraftingCompleted craftingCompleted = default(ProfileEventDispatcher.CraftingCompleted);
			while (true)
			{
				StepCompletionChangedDelegate stepCompletionChanged = this.StepCompletionChanged;
				int num = 0;
				Delegate @delegate = Delegate.Remove(stepCompletionChanged, onCompletionChanged);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					continue;
				}
				while ((object)@delegate != stepCompletionChanged)
				{
				}
				StepStatusChangedDelegate stepStatusChanged = this.StepStatusChanged;
				Delegate delegate2 = Delegate.Remove(stepStatusChanged, onStatusChanged);
				if ((object)delegate2 != null && (object)delegate2 == null)
				{
					continue;
				}
				while ((object)delegate2 != stepStatusChanged)
				{
				}
				if ((stepStarted ? 1 : 0) == num)
				{
					continue;
				}
				if (status_ == MissionStepStatus.Ongoing)
				{
					int newStepStatus = 0;
					bool flag = ChangeStatus((MissionStepStatus)newStepStatus);
				}
				MissionObjectiveData missionObjectiveData = Data;
				if (missionObjectiveData != null)
				{
					MissionObjectiveData.CustomStepOneofCase customStepCase_ = missionObjectiveData.customStepCase_;
				}
				if (num == 0)
				{
					continue;
				}
				if (num > 195)
				{
					if (num > 240)
					{
						if (num > 265)
						{
							if (num > 280)
							{
								if (num == 285)
								{
									ProfileEventDispatcher dispatcher = Dispatcher;
									if (dispatcher == null)
									{
										continue;
									}
									ProfileEventDispatcher.BuidingUpgraded value = Upgrade_OnBuidingUpgraded;
									dispatcher.OnBuidingUpgraded -= value;
									ProfileEventDispatcher dispatcher2 = Dispatcher;
									playerLevelGained = Upgrade_OnPlayerLevelGained;
									dispatcher2.OnPlayerLevelGained -= playerLevelGained;
								}
								if ((long)playerLevelGained == 290)
								{
									ProfileEventDispatcher dispatcher3 = Dispatcher;
									if (dispatcher3 == null)
									{
										continue;
									}
									ProfileEventDispatcher.CurrentSceneChanged value2 = VisitAreaBeforeSceneChange;
									dispatcher3.OnCurrentSceneChanged -= value2;
									ProfileEventDispatcher dispatcher4 = Dispatcher;
									currentSceneChanged = VisitAreaAfterSceneChange;
									dispatcher4.OnCurrentSceneChangedAfterLoading -= currentSceneChanged;
								}
								if ((long)currentSceneChanged != 295)
								{
									continue;
								}
								ProfileEventDispatcher dispatcher5 = Dispatcher;
								if (dispatcher5 == null)
								{
									continue;
								}
								ProfileEventDispatcher.FlowerEvent value3 = OnWaterFlowerResultReceived;
								dispatcher5.OnFlowerEvent -= value3;
								ProfileEventDispatcher dispatcher6 = Dispatcher;
								gardeningEvent = OnWaterCropResultReceived;
								dispatcher6.OnGardeningEvent -= gardeningEvent;
							}
							if ((long)gardeningEvent != 275)
							{
								continue;
							}
							StopUnlock();
						}
						if ((long)gardeningEvent > 250)
						{
							if ((long)gardeningEvent == 255)
							{
								ProfileEventDispatcher dispatcher7 = Dispatcher;
								if (dispatcher7 == null)
								{
									continue;
								}
								restaurantOrderFulfilled = Dispatcher_ServeRestaurantOrder_OnRestaurantOrderFulfilled;
								dispatcher7.OnRestaurantOrderFulfilled -= restaurantOrderFulfilled;
							}
							if ((long)restaurantOrderFulfilled == 260)
							{
								ProfileEventDispatcher dispatcher8 = Dispatcher;
								if (dispatcher8 == null)
								{
									continue;
								}
								discussionEnded = Discussion_OnDiscussionEnded;
								dispatcher8.OnDiscussionEnded -= discussionEnded;
							}
							if ((long)discussionEnded != 265)
							{
								continue;
							}
							ProfileEventDispatcher dispatcher9 = Dispatcher;
							if (dispatcher9 == null)
							{
								continue;
							}
							pictureTaken = Dispatcher_OnPictureTaken;
							dispatcher9.OnPictureTaken -= pictureTaken;
						}
						if ((long)pictureTaken == 245)
						{
							ProfileEventDispatcher dispatcher10 = Dispatcher;
							if (dispatcher10 == null)
							{
								continue;
							}
							dutyAchRewardCollected = Dispatcher_OnDutyAchRewardCollected_RoyalDuties;
							dispatcher10.OnDutyAchRewardCollected -= dutyAchRewardCollected;
						}
						if ((long)dutyAchRewardCollected != 250)
						{
							continue;
						}
						ProfileEventDispatcher dispatcher11 = Dispatcher;
						if (dispatcher11 == null)
						{
							continue;
						}
						ProfileEventDispatcher.ShopItemsSold value4 = Dispatcher_SellItem_OnShopItemsSold;
						dispatcher11.OnShopItemsSold -= value4;
						ProfileEventDispatcher dispatcher12 = Dispatcher;
						itemAdded = Dispatcher_SellItem_OnItemAdded;
						dispatcher12.OnItemAdded -= itemAdded;
					}
					if ((long)itemAdded > 215)
					{
						if ((long)itemAdded > 225)
						{
							if ((long)itemAdded == 230)
							{
								StopPossess();
							}
							if ((long)itemAdded == 235)
							{
								ProfileEventDispatcher dispatcher13 = Dispatcher;
								if (dispatcher13 == null)
								{
									continue;
								}
								ProfileEventDispatcher.ShopItemBought value5 = Dispatcher_PurchaseItem_OnShopItemBought;
								dispatcher13.OnShopItemBought -= value5;
								ProfileEventDispatcher dispatcher14 = Dispatcher;
								storeItemBought = Dispatcher_PurchaseItem_OnStoreItemBought;
								dispatcher14.OnStoreItemBought -= storeItemBought;
							}
							if ((long)storeItemBought != 240)
							{
								continue;
							}
							dispatcher15 = Dispatcher;
							if (dispatcher15 == null)
							{
								continue;
							}
							avatarRemoveBlocker = RemoveBlocker_OnAvatarRemoveBlocker;
							dispatcher15.OnAvatarRemoveBlocker -= avatarRemoveBlocker;
						}
						if ((long)avatarRemoveBlocker == 220)
						{
							ProfileEventDispatcher dispatcher16 = Dispatcher;
							if (dispatcher16 != null)
							{
								ProfileEventDispatcher.GridChanged value6 = PickUp_OnGridChanged;
								dispatcher16.OnGridChanged -= value6;
								ProfileEventDispatcher dispatcher17 = Dispatcher;
								ProfileEventDispatcher.ItemAdded value7 = PickUp_OnItemAdded;
								dispatcher17.OnItemAdded -= value7;
							}
							MissionObjectiveData missionObjectiveData2 = Data;
							if (missionObjectiveData2 == null)
							{
								continue;
							}
							CustomStepPickUp pickUp = missionObjectiveData2.PickUp;
							if (pickUp != null)
							{
								CustomStepPickUp.PickUpTypesOneofCase pickUpTypesCase_ = pickUp.pickUpTypesCase_;
							}
							bool flag2 = (long)dispatcher15 == 4;
							if ((long)dispatcher15 == 4)
							{
								continue;
							}
							RemovePickUpSpawnedObjects();
						}
						if ((long)dispatcher15 != 225)
						{
							continue;
						}
						ProfileEventDispatcher dispatcher18 = Dispatcher;
						if (dispatcher18 == null)
						{
							continue;
						}
						gridChanged = Dispatcher_OnGridChanged_PlaceBuilding;
						dispatcher18.OnGridChanged -= gridChanged;
					}
					if ((long)gridChanged > 200)
					{
						if ((long)gridChanged == 205)
						{
							ProfileEventDispatcher dispatcher19 = Dispatcher;
							if (dispatcher19 == null)
							{
								continue;
							}
							gardeningEvent2 = OnMakeGardenGardeningEvent;
							dispatcher19.OnGardeningEvent -= gardeningEvent2;
						}
						if ((long)gardeningEvent2 != 210)
						{
							continue;
						}
						ProfileEventDispatcher dispatcher20 = Dispatcher;
						miningRockEmptied = MineMineral_OnMiningRockEmptied;
						dispatcher20.OnMiningRockEmptied -= miningRockEmptied;
					}
					if ((long)miningRockEmptied != 197)
					{
						continue;
					}
					ProfileEventDispatcher dispatcher21 = Dispatcher;
					if (dispatcher21 == null)
					{
						continue;
					}
					itemInteraction = OnItemInteraction;
					dispatcher21.OnItemInteraction -= itemInteraction;
				}
				if ((long)itemInteraction > 135)
				{
					if ((long)itemInteraction > 165)
					{
						if ((long)itemInteraction > 180)
						{
							if ((long)itemInteraction == 185)
							{
								ProfileEventDispatcher dispatcher22 = Dispatcher;
								if (dispatcher22 == null)
								{
									continue;
								}
								gardeningEvent3 = OnGardeningHarvestResultReceived;
								dispatcher22.OnGardeningEvent -= gardeningEvent3;
							}
							if ((long)gardeningEvent3 == 190)
							{
								ProfileEventDispatcher dispatcher23 = Dispatcher;
								if (dispatcher23 == null)
								{
									continue;
								}
								gardeningEvent4 = OnGardeningPlantResultReceived;
								dispatcher23.OnGardeningEvent -= gardeningEvent4;
							}
							if ((long)gardeningEvent4 != 195)
							{
								continue;
							}
							ProfileEventDispatcher dispatcher24 = Dispatcher;
							if (dispatcher24 == null)
							{
								continue;
							}
							itemsGivenToCharacter = GiftToCharacter_OnItemsGivenToCharacter;
							dispatcher24.OnItemsGivenToCharacter -= itemsGivenToCharacter;
						}
						if ((long)itemsGivenToCharacter == 170)
						{
							ProfileEventDispatcher dispatcher25 = Dispatcher;
							if (dispatcher25 == null)
							{
								continue;
							}
							ProfileEventDispatcher.ItemAdded value8 = Dispatcher_OnItemAdded_FinishHouse;
							dispatcher25.OnItemAdded -= value8;
							ProfileEventDispatcher dispatcher26 = Dispatcher;
							ProfileEventDispatcher.ItemRemoved value9 = Dispatcher_OnItemRemoved_FinishHouse;
							dispatcher26.OnItemRemoved -= value9;
							ProfileEventDispatcher dispatcher27 = Dispatcher;
							gridChanged2 = Dispatcher_OnGridChanged_FinishHouse;
							dispatcher27.OnGridChanged -= gridChanged2;
						}
						if ((long)gridChanged2 != 180)
						{
							continue;
						}
						ProfileEventDispatcher dispatcher28 = Dispatcher;
						if (dispatcher28 == null)
						{
							continue;
						}
						ProfileEventDispatcher.CharacterUnlocked value10 = Friend_OnCharacterUnlocked;
						dispatcher28.OnCharacterUnlocked -= value10;
						ProfileEventDispatcher dispatcher29 = Dispatcher;
						characterFriendshipLevelChanged = Friend_OnCharacterFriendshipLevelChanged;
						dispatcher29.OnCharacterFriendshipLevelChanged -= characterFriendshipLevelChanged;
					}
					if ((long)characterFriendshipLevelChanged > 150)
					{
						if ((long)characterFriendshipLevelChanged == 155)
						{
							ProfileEventDispatcher dispatcher30 = Dispatcher;
							if (dispatcher30 == null)
							{
								continue;
							}
							ProfileEventDispatcher.PlayerHouseRoomExpanded value11 = ExpandHouse_OnPlayerHouseRoomExpanded;
							dispatcher30.OnPlayerHouseRoomExpanded -= value11;
							ProfileEventDispatcher dispatcher31 = Dispatcher;
							ProfileEventDispatcher.PlayerHouseRoomAdded value12 = ExpandHouse_OnPlayerHouseRoomAdded;
							dispatcher31.OnPlayerHouseRoomAdded -= value12;
							ProfileEventDispatcher dispatcher32 = Dispatcher;
							playerHouseFloorAdded = ExpandHouse_OnPlayerHouseFloorAdded;
							dispatcher32.OnPlayerHouseFloorAdded -= playerHouseFloorAdded;
						}
						if ((long)playerHouseFloorAdded == 160)
						{
							ProfileEventDispatcher dispatcher33 = Dispatcher;
							if (dispatcher33 == null)
							{
								continue;
							}
							critterFed = FeedCritter_OnFed;
							dispatcher33.OnCritterFed -= critterFed;
						}
						if ((long)critterFed != 165)
						{
							continue;
						}
						ProfileEventDispatcher dispatcher34 = Dispatcher;
						if (dispatcher34 == null)
						{
							continue;
						}
						keyholeLevelCompleted = OnKeyholeLevelCompleted;
						dispatcher34.OnKeyholeLevelCompleted -= keyholeLevelCompleted;
					}
					if ((long)keyholeLevelCompleted == 145)
					{
						ProfileEventDispatcher dispatcher35 = Dispatcher;
						if (dispatcher35 == null)
						{
							continue;
						}
						avatarCustomizationChanged = OnAvatarCustomizationChanged;
						dispatcher35.OnAvatarCustomizationChanged -= avatarCustomizationChanged;
					}
					if ((long)avatarCustomizationChanged != 150)
					{
						continue;
					}
					ProfileEventDispatcher dispatcher36 = Dispatcher;
					if (dispatcher36 == null)
					{
						continue;
					}
					itemRemoved = OnMealEaten;
					dispatcher36.OnItemRemoved -= itemRemoved;
				}
				if ((long)itemRemoved <= 110 || (long)itemRemoved <= 120)
				{
					continue;
				}
				if ((long)itemRemoved == 125)
				{
					ProfileEventDispatcher dispatcher37 = Dispatcher;
					if (dispatcher37 == null)
					{
						continue;
					}
					mealCooked = Dispatcher_OnMealCooked;
					dispatcher37.OnMealCooked -= mealCooked;
				}
				if ((long)mealCooked == 130)
				{
					ProfileEventDispatcher dispatcher38 = Dispatcher;
					if (dispatcher38 == null)
					{
						continue;
					}
					craftingCompleted = CraftItem_OnCraftingCompleted;
					dispatcher38.OnCraftingCompleted -= craftingCompleted;
				}
				if ((long)craftingCompleted == 135)
				{
					/*Error: Could not find block for branch target IL_0845*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008230")]
		[Cpp2IlInjected.Address(RVA = "0x814520", Offset = "0x812F20", VA = "0x180814520")]
		public string ResolveString(Localizator localizator, string locId, [System.Runtime.InteropServices.Optional] IResolver extraResolver)
		{
			//Discarded unreachable code: IL_0067
			//IL_0046: Expected O, but got I4
			if ((object)typeof(string).TypeHandle == null)
			{
				MissionSlot missionSlot = MissionSubStep.MissionSlot;
				List<IResolver> list = (List<IResolver>)(object)new List<T>();
				((List<T>)(object)list).Add((T)extraResolver);
				if (locId == null)
				{
					MissionSlot missionSlot2 = MissionSubStep.MissionSlot;
					if (Data != null)
					{
					}
					int num = 0;
					MissionSlotStringResolver missionSlotStringResolver = (_stringResolver = new MissionSlotStringResolver(missionSlot2, localizator, (string)num));
				}
				MultiResolver multiResolver = new MultiResolver((IReadOnlyCollection<>)list);
				string text = default(string);
				return missionSlot.ResolveXml(text);
			}
			return string.Empty;
		}

		[Cpp2IlInjected.Token(Token = "0x6008231")]
		[Cpp2IlInjected.Address(RVA = "0x8009C0", Offset = "0x7FF3C0", VA = "0x1808009C0")]
		internal void AddDescriptions(List<DescriptionInfo> desc, int indentation, Localizator localizator)
		{
			//Discarded unreachable code: IL_009d
			//IL_005e: Expected O, but got I4
			//IL_0092: Expected O, but got I4
			//IL_0092: Expected O, but got I4
			if (wasSkipped_)
			{
				return;
			}
			CustomStepFollowCharacter followCharacter = Data.FollowCharacter;
			if (followCharacter != null && followCharacter.TalkTo != null && status_ == MissionStepStatus.ReadyToBeCompleted)
			{
				CustomStepFollowCharacter.Types.FollowTalkTo talkTo = Data.FollowCharacter.TalkTo;
			}
			string stepDescription_ = Data.stepDescription_;
			if (followCharacter == null)
			{
				int num = 0;
				int num2 = 0;
				string text = ResolveString(localizator, stepDescription_, (IResolver)num2);
				MissionObjectiveData missionObjectiveData = Data;
				MissionStepStatus missionStepStatus = status_;
				if (missionObjectiveData.customStepCase_ == MissionObjectiveData.CustomStepOneofCase.BringItem)
				{
				}
				bool flag = missionStepStatus >= MissionStepStatus.Completed;
				DescriptionInfo item = new DescriptionInfo(text, flag, indentation, this, (Nullable<>)num, (Nullable<>)num);
				((List<T>)(object)desc).Add((T)item);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008232")]
		[Cpp2IlInjected.Address(RVA = "0x802710", Offset = "0x801110", VA = "0x180802710")]
		internal bool ChangeStatus(MissionStepStatus newStepStatus)
		{
			MissionStepStatus missionStepStatus = status_;
			if (missionStepStatus == newStepStatus)
			{
				int num = 0;
			}
			ProfileEventDispatcher dispatcher = Dispatcher;
			int num2 = 0;
			status_ = newStepStatus;
			uint num3 = default(uint);
			if (dispatcher != null && num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			if (this.StepStatusChanged != null)
			{
			}
			int num5 = default(int);
			if (Dispatcher != null)
			{
				MissionSlot missionSlot = MissionSubStep.MissionSlot;
				MissionSubStep missionSubStep = MissionSubStep;
				MissionSlotClass class_ = missionSlot.class_;
				MissionSlot missionSlot2 = missionSubStep.MissionSlot;
				MissionItemData data = MissionSubStep.MissionSlot.Data;
				uint num4 = default(uint);
				if (num2 < (int)num4)
				{
					num2 += num2;
					num2++;
				}
				num5 = (int)class_;
			}
			MissionStepStatus missionStepStatus2 = status_;
			if (missionStepStatus < MissionStepStatus.Completed)
			{
				if (this.StepCompletionChanged == null)
				{
					goto IL_00db;
				}
				num5 += num5;
				num5 += num5;
			}
			if (missionStepStatus2 == MissionStepStatus.Ongoing)
			{
				StepCompletionChangedDelegate stepCompletionChanged = this.StepCompletionChanged;
				if (stepCompletionChanged != null)
				{
					int completed = 0;
					stepCompletionChanged(this, (byte)completed != 0);
				}
			}
			goto IL_00db;
			IL_00db:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008233")]
		[Cpp2IlInjected.Address(RVA = "0x803370", Offset = "0x801D70", VA = "0x180803370")]
		internal bool CheckManualCompletion(MissionCompleteStep.Types.Condition condition, InventoryFullResolution inventoryFullResolution, out InventoryFullDetails inventoryFullDetails)
		{
			Func<ItemToGiveAmount, (int, int)> func = default(Func<ItemToGiveAmount, (int, int)>);
			while (true)
			{
				MissionObjectiveData missionObjectiveData = Data;
				MissionObjectiveData.CustomStepOneofCase customStepCase_ = missionObjectiveData.customStepCase_;
				if (customStepCase_ > MissionObjectiveData.CustomStepOneofCase.Listen)
				{
					if (customStepCase_ > MissionObjectiveData.CustomStepOneofCase.TalkToCharacter)
					{
						if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.UnlockCharacter)
						{
							if (condition != MissionCompleteStep.Types.Condition.UnlockCharacterEnd)
							{
								goto IL_0075;
							}
							UnlockCharacterCompleted();
						}
						if (customStepCase_ != MissionObjectiveData.CustomStepOneofCase.VisitArea)
						{
							goto IL_0075;
						}
					}
					if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.Party && condition == MissionCompleteStep.Types.Condition.PartyEnd)
					{
						OnPartyStepCompleted();
					}
					if (customStepCase_ != MissionObjectiveData.CustomStepOneofCase.TalkToCharacter)
					{
						goto IL_0075;
					}
				}
				if (customStepCase_ > MissionObjectiveData.CustomStepOneofCase.Chase)
				{
					if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.FollowCharacter)
					{
						if (condition == MissionCompleteStep.Types.Condition.DialogueEnd && status_ == MissionStepStatus.ReadyToBeCompleted)
						{
							break;
						}
						goto IL_0075;
					}
					goto IL_00c4;
				}
				goto IL_00d9;
				IL_00d9:
				if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.BringItem)
				{
					while (condition != MissionCompleteStep.Types.Condition.BringItemDialogueEnd)
					{
					}
					if (!AnyItemCollected())
					{
						continue;
					}
					MissionSubStepData.Types.ExtraBringItem bringItem = MissionSubStep.Data.BringItem;
					while (bringItem == null)
					{
					}
					while (bringItem.bringDialogueType_ != BringDialogueTypeOptions.Dialogue)
					{
					}
					string stepName_ = Data.stepName_;
					MissionObjectiveData missionObjectiveData2 = Enumerable.FirstOrDefault<MissionObjectiveData>((IEnumerable<>)(object)MissionSubStep.Data.objectives_);
					if (missionObjectiveData2 != null)
					{
					}
					while (missionObjectiveData2 == null)
					{
					}
					RepeatedField<ItemToGiveAmount> itemsToGive_ = MissionSubStep.Data.BringItem.itemsToGive_;
					if (_003C_003Ec._003C_003E9__407_0 == null)
					{
						func = (Func<ItemToGiveAmount, (int, int)>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ItemToGiveAmount x)
						{
							int amount_ = x.amount_;
							int itemToGive_ = x.itemToGive_;
							throw new NullReferenceException();
						});
					}
					IEnumerable<ItemToGiveAmount> enumerable = (IEnumerable<ItemToGiveAmount>)Enumerable.Select<ItemToGiveAmount, (int, int)>((IEnumerable<>)(object)itemsToGive_, (Func<, >)(object)func);
					return this.GiveStepItems((IEnumerable<>)enumerable, inventoryFullResolution, ref inventoryFullDetails);
				}
				while (customStepCase_ != MissionObjectiveData.CustomStepOneofCase.Chase)
				{
				}
				while (condition != MissionCompleteStep.Types.Condition.ChaseEnd)
				{
				}
				break;
				IL_00c4:
				while (customStepCase_ != MissionObjectiveData.CustomStepOneofCase.Listen)
				{
				}
				while (condition != MissionCompleteStep.Types.Condition.ListenEnd)
				{
				}
				bool flag = ChangeStatus(MissionStepStatus.Completed);
				goto IL_00d9;
				IL_0075:
				if (condition != MissionCompleteStep.Types.Condition.FollowEnd)
				{
					while (condition != MissionCompleteStep.Types.Condition.FollowRestart)
					{
					}
					if (status_ != MissionStepStatus.ReadyToBeCompleted && missionObjectiveData.FollowCharacter.AutoConfirm)
					{
						continue;
					}
					bool flag2 = ChangeStatus(MissionStepStatus.Ongoing);
				}
				CustomStepFollowCharacter followCharacter = missionObjectiveData.FollowCharacter;
				int num = 0;
				CustomStepFollowCharacter.Types.FollowTalkTo talkTo = followCharacter.TalkTo;
				num += 3;
				bool flag3 = ChangeStatus((MissionStepStatus)num);
				goto IL_00c4;
			}
			if (_003C_003Ec._003C_003E9__407_1 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ItemFilterWithAmount x)
				{
					ItemFilterData data_ = x.itemFilter_.data_;
					throw new NullReferenceException();
				};
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008234")]
		[Cpp2IlInjected.Address(RVA = "0x809580", Offset = "0x807F80", VA = "0x180809580")]
		private bool GiveStepItems(IEnumerable<(int itemID, int amount)> stepItems, InventoryFullResolution inventoryFullResolution, out InventoryFullDetails inventoryFullDetails)
		{
			//Discarded unreachable code: IL_00ef, IL_00f5, IL_00fb
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			MultiItemInstance multiItemInstance;
			ItemInstance itemInstance = default(ItemInstance);
			if (Enumerable.Any<(int, int)>((IEnumerable<>)stepItems) && status_ < MissionStepStatus.Completed)
			{
				ContainerInventory backpack = Profile.Backpack;
				bool flag = default(bool);
				if (flag)
				{
					ContainerInventory backpack2 = Profile.Backpack;
					ITransactionContext context = Context;
					ProfileEventDispatcher dispatcher = Dispatcher;
					Profile profile = Profile;
					bool flag2 = InventoryFullFlow.CompleteFlow(backpack2, inventoryFullResolution, profile, dispatcher, context);
				}
				multiItemInstance = new MultiItemInstance();
				if (multiItemInstance != null)
				{
					uint num5 = default(uint);
					if (num4 < (int)num5)
					{
						num4 += num4;
						if (num4 == (int)num5)
						{
							goto IL_00a0;
						}
						num4++;
					}
					RepeatedField<ItemInstance> items_ = multiItemInstance.items_;
					itemInstance = MissionSlot.NewItemToGive(num4, num4);
					((RepeatedField<T>)(object)items_).Add((T)itemInstance);
					goto IL_00a0;
				}
				goto IL_00a7;
			}
			goto IL_00d4;
			IL_00a0:
			itemInstance = (ItemInstance)(object)((object)itemInstance + (object)itemInstance);
			goto IL_00a7;
			IL_00d4:
			bool flag3 = ChangeStatus(MissionStepStatus.Completed);
			goto IL_00dd;
			IL_00a7:
			int num6 = 0;
			if (multiItemInstance != null)
			{
			}
			MultiItemInstance multiItemInstance2 = multiItemInstance.Clone();
			ContainerInventory containerInventory = default(ContainerInventory);
			ContainerInventory containerInventory2 = containerInventory.Clone();
			bool flag4 = default(bool);
			if (flag4)
			{
				MissionSlot missionSlot = default(MissionSlot);
				string name_ = missionSlot.Data.name_;
				goto IL_00d4;
			}
			goto IL_00dd;
			IL_00dd:
			InventoryFullDetails inventoryFullDetails2 = new InventoryFullDetails();
			bool flag5 = default(bool);
			if (flag5)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008236")]
		[Cpp2IlInjected.Address(RVA = "0x814760", Offset = "0x813160", VA = "0x180814760")]
		private void ResolveVariables()
		{
			//Discarded unreachable code: IL_02c9, IL_02cf, IL_02d5, IL_02db, IL_02e1, IL_02e7, IL_02ed, IL_02f3, IL_02f9, IL_02ff, IL_0305, IL_030b, IL_0311, IL_0317, IL_031d, IL_0323, IL_0329, IL_032f, IL_0335, IL_033b, IL_0341, IL_0347, IL_034d, IL_0353, IL_0359, IL_035f, IL_0365, IL_036b, IL_0371, IL_0377, IL_037d, IL_0383
			int num = 0;
			IItemSelector getIItemSelector = Data.GetIItemSelector;
			if (getIItemSelector != null)
			{
				if (getIItemSelector != null)
				{
					string name = default(string);
					MissionVariable missionVariable = MissionSubStep.MissionSlot.GetMissionVariable(MissionVariable.VariableOneofCase.ItemFilter, name);
					if (missionVariable != null)
					{
						ItemFilter itemFilter = itemFilter_;
						ItemFilterData itemFilterData = (itemFilter.data_ = missionVariable.ItemFilter);
					}
				}
				MissionObjectiveData missionObjectiveData = Data;
				MissionVariable missionVariable2 = new MissionVariable();
				string name2 = default(string);
				missionVariable2.Name = name2;
				ItemFilterData itemFilterData2 = (missionVariable2.ItemFilter = itemFilter_.data_);
				MissionSubStep.MissionSlot.SetMissionVariable(MissionVariable.VariableOneofCase.ItemFilter, missionVariable2);
			}
			IStepAmount getIStepAmount = Data.GetIStepAmount;
			if (getIStepAmount != null)
			{
				if (getIStepAmount != null)
				{
					string name3 = default(string);
					MissionVariable missionVariable3 = MissionSubStep.MissionSlot.GetMissionVariable(MissionVariable.VariableOneofCase.TargetAmount, name3);
					if (missionVariable3 != null)
					{
						float num2 = (targetAmount_ = missionVariable3.TargetAmount);
					}
				}
				MissionObjectiveData missionObjectiveData2 = Data;
				MissionVariable missionVariable4 = new MissionVariable();
				string name4 = default(string);
				missionVariable4.Name = name4;
				float num4 = (missionVariable4.TargetAmount = targetAmount_);
				MissionSubStep.MissionSlot.SetMissionVariable(MissionVariable.VariableOneofCase.TargetAmount, missionVariable4);
			}
			IItemSelectorsWithAmount getIItemSelectorsWithAmount = Data.GetIItemSelectorsWithAmount;
			float num8 = default(float);
			if (getIItemSelectorsWithAmount != null)
			{
				if (getIItemSelectorsWithAmount != null)
				{
					uint num5 = default(uint);
					if (num < (int)num5)
					{
						num += num;
						if (num == (int)num5)
						{
							goto IL_025e;
						}
						num++;
					}
					MissionSlot missionSlot = MissionSubStep.MissionSlot;
					int currentStepIndex_ = missionSlot.currentStepIndex_;
					string name5 = default(string);
					MissionVariable missionVariable5 = missionSlot.GetMissionVariable(MissionVariable.VariableOneofCase.ItemFilter, name5);
					ItemFilterData itemFilterData3 = default(ItemFilterData);
					if (missionVariable5 != null)
					{
						ItemFilter itemFilter2 = ((ItemFilterWithAmount)((RepeatedField<T>)(object)itemFiltersWithAmount_)[num]).itemFilter_;
						itemFilterData3 = (itemFilter2.data_ = missionVariable5.ItemFilter);
					}
					if (itemFilterData3.set_ == 3)
					{
						string name6 = default(string);
						MissionVariable missionVariable6 = MissionSubStep.MissionSlot.GetMissionVariable(MissionVariable.VariableOneofCase.TargetAmount, name6);
						if (missionVariable6 != null)
						{
							ItemFilterWithAmount itemFilterWithAmount = (ItemFilterWithAmount)((RepeatedField<T>)(object)itemFiltersWithAmount_)[num];
							float num6 = (itemFilterWithAmount.targetAmount_ = missionVariable6.TargetAmount);
						}
					}
					MissionObjectiveData missionObjectiveData3 = Data;
					MissionVariable missionVariable7 = new MissionVariable();
					string name7 = default(string);
					missionVariable7.Name = name7;
					ItemFilterData itemFilterData4 = (missionVariable7.ItemFilter = ((ItemFilterWithAmount)((RepeatedField<T>)(object)itemFiltersWithAmount_)[num]).itemFilter_.data_);
					MissionSubStep.MissionSlot.SetMissionVariable(MissionVariable.VariableOneofCase.ItemFilter, missionVariable7);
					MissionObjectiveData missionObjectiveData4 = Data;
					MissionVariable missionVariable8 = new MissionVariable();
					string name8 = default(string);
					missionVariable8.Name = name8;
					num8 = (missionVariable8.TargetAmount = ((ItemFilterWithAmount)((RepeatedField<T>)(object)itemFiltersWithAmount_)[num]).targetAmount_);
					MissionSubStep.MissionSlot.SetMissionVariable(MissionVariable.VariableOneofCase.TargetAmount, missionVariable8);
					num++;
				}
				goto IL_025e;
			}
			goto IL_0266;
			IL_0266:
			IMinWeightReq minWeightReq = default(IMinWeightReq);
			if (minWeightReq != null)
			{
				MissionVariable missionVariable9 = new MissionVariable();
				MissionVariable.VariableOneofCase variableCase_ = missionVariable9.variableCase_;
				string name9 = default(string);
				missionVariable9.Name = name9;
				missionVariable9.MinWeightRequired = num8;
				MissionSlot missionSlot2 = default(MissionSlot);
				missionSlot2.SetMissionVariable(MissionVariable.VariableOneofCase.MinWeightRequired, missionVariable9);
			}
			IMaxWeightReq maxWeightReq = default(IMaxWeightReq);
			if (maxWeightReq != null)
			{
				MissionVariable missionVariable10 = new MissionVariable();
				MissionVariable.VariableOneofCase variableCase_2 = missionVariable10.variableCase_;
				string name10 = default(string);
				missionVariable10.Name = name10;
				missionVariable10.MaxWeightRequired = num8;
				MissionSlot missionSlot3 = default(MissionSlot);
				missionSlot3.SetMissionVariable(MissionVariable.VariableOneofCase.MaxWeightRequired, missionVariable10);
			}
			return;
			IL_025e:
			if (getIItemSelectorsWithAmount != null)
			{
				int num9 = 0;
			}
			goto IL_0266;
		}

		[Cpp2IlInjected.Token(Token = "0x6008237")]
		[Cpp2IlInjected.Address(RVA = "0x80C0C0", Offset = "0x80AAC0", VA = "0x18080C0C0")]
		public bool IsMealTargetedByCookMealStep(Item item)
		{
			MissionObjectiveData missionObjectiveData = Data;
			if (missionObjectiveData != null)
			{
				CustomStepCookMeal cookMeal = missionObjectiveData.CookMeal;
				int num = 0;
				if (cookMeal != null)
				{
					CustomStepCookMeal.ConditionTypeOneofCase conditionTypeCase_ = cookMeal.conditionTypeCase_;
				}
				if (num != 2)
				{
					IEnumerable<Item> enumerable = (IEnumerable<Item>)itemFilter_.SelectedItems();
					bool result = default(bool);
					return result;
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008238")]
		[Cpp2IlInjected.Address(RVA = "0x820630", Offset = "0x81F030", VA = "0x180820630")]
		public MissionSlotStringResolver StringResolver(Localizator localizator)
		{
			//Discarded unreachable code: IL_002a
			if ((object)typeof(MissionSlotStringResolver).TypeHandle == null)
			{
				MissionSlot missionSlot = MissionSubStep.MissionSlot;
				if (Data != null)
				{
				}
				MissionSlotStringResolver stringResolver = default(MissionSlotStringResolver);
				_stringResolver = stringResolver;
			}
			return (MissionSlotStringResolver)typeof(MissionSlotStringResolver).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x6008239")]
		[Cpp2IlInjected.Address(RVA = "0x811A60", Offset = "0x810460", VA = "0x180811A60", Slot = "14")]
		public unsafe object ResolveKey(Localizator localizator, string key)
		{
			//IL_014f: Expected O, but got I4
			//IL_015c: Expected O, but got I4
			//IL_01cb: Expected O, but got I4
			//IL_0207: Expected O, but got I4
			//IL_034a: Expected O, but got I4
			//IL_0552: Expected O, but got I4
			//IL_091a: Expected O, but got I4
			//IL_0a65: Expected O, but got I4
			//IL_0bd4: Expected O, but got I4
			//IL_0c78: Expected O, but got I4
			bool flag = default(bool);
			CustomStepRemoveBlocker customStepRemoveBlocker = default(CustomStepRemoveBlocker);
			CustomStepRemoveBlocker customStepRemoveBlocker2 = default(CustomStepRemoveBlocker);
			CustomStepRemoveBlocker customStepRemoveBlocker3 = default(CustomStepRemoveBlocker);
			bool flag2 = default(bool);
			string text = default(string);
			LocId locId = default(LocId);
			IEnumerable<> enumerable2 = default(IEnumerable<>);
			string text3 = default(string);
			Func<int, bool> func3 = default(Func<int, bool>);
			TagItemType tagItemType7 = default(TagItemType);
			IMinStarRatingReq minStarRatingReq = default(IMinStarRatingReq);
			string text5 = default(string);
			CustomStepDecorate customStepDecorate = default(CustomStepDecorate);
			GridLocationFilter.LocationTypeOneofCase locationTypeOneofCase = default(GridLocationFilter.LocationTypeOneofCase);
			CustomStepDecorate customStepDecorate2 = default(CustomStepDecorate);
			bool flag3 = default(bool);
			MissionItemData data = default(MissionItemData);
			Item item2 = default(Item);
			Item characterItem = default(Item);
			CustomStepStartDiscussion customStepStartDiscussion = default(CustomStepStartDiscussion);
			CustomStepListen customStepListen = default(CustomStepListen);
			bool flag4 = default(bool);
			Func<string, bool> func6 = default(Func<string, bool>);
			bool result = default(bool);
			IEnumerable<int> enumerable3 = default(IEnumerable<int>);
			Item universeTagItem = default(Item);
			string text8 = default(string);
			ItemType itemType = default(ItemType);
			LocId arg = default(LocId);
			Mood mood2 = default(Mood);
			TargetBuildingType building = default(TargetBuildingType);
			bool flag6 = default(bool);
			string text14 = default(string);
			Complexity complexity2 = default(Complexity);
			string text16 = default(string);
			string text17 = default(string);
			LocId locId5 = default(LocId);
			TagItemType tagItemType6 = default(TagItemType);
			TagItemType tagItemType5 = default(TagItemType);
			Func<int, bool> func9 = default(Func<int, bool>);
			TagItemType tagItemType4 = default(TagItemType);
			List<int> list2 = default(List<int>);
			IEnumerable<int> enumerable4 = default(IEnumerable<int>);
			CustomStepFollowCharacter customStepFollowCharacter = default(CustomStepFollowCharacter);
			bool flag7 = default(bool);
			string text19 = default(string);
			Normality normality2 = default(Normality);
			LocId locId6 = default(LocId);
			CustomStepVisitArea customStepVisitArea = default(CustomStepVisitArea);
			MissionSlot missionSlot = default(MissionSlot);
			CustomStepVisitArea customStepVisitArea2 = default(CustomStepVisitArea);
			CustomStepVisitArea customStepVisitArea3 = default(CustomStepVisitArea);
			CustomStepVisitArea customStepVisitArea4 = default(CustomStepVisitArea);
			CustomStepVisitArea customStepVisitArea5 = default(CustomStepVisitArea);
			bool flag8 = default(bool);
			CustomStepVisitArea customStepVisitArea6 = default(CustomStepVisitArea);
			CustomStepVisitArea customStepVisitArea7 = default(CustomStepVisitArea);
			CustomStepFriend customStepFriend = default(CustomStepFriend);
			CustomStepFriend customStepFriend2 = default(CustomStepFriend);
			CustomStepUpgrade customStepUpgrade = default(CustomStepUpgrade);
			CustomStepUpgrade customStepUpgrade2 = default(CustomStepUpgrade);
			CustomStepUnlock customStepUnlock = default(CustomStepUnlock);
			CustomStepUnlock customStepUnlock2 = default(CustomStepUnlock);
			CustomStepUnlock customStepUnlock3 = default(CustomStepUnlock);
			CustomStepUnlock customStepUnlock4 = default(CustomStepUnlock);
			CustomStepUnlock customStepUnlock5 = default(CustomStepUnlock);
			VillageAreaType villageAreaType = default(VillageAreaType);
			CustomStepUnlock customStepUnlock6 = default(CustomStepUnlock);
			CustomStepUnlock customStepUnlock7 = default(CustomStepUnlock);
			CustomStepUnlock customStepUnlock8 = default(CustomStepUnlock);
			MissionSlot missionSlot2 = default(MissionSlot);
			TagItemType tagItemType3 = default(TagItemType);
			string text23 = default(string);
			Sturdiness sturdiness = default(Sturdiness);
			LocId locId8 = default(LocId);
			TagItemType tagItemType2 = default(TagItemType);
			string text25 = default(string);
			Func<int, bool> func12 = default(Func<int, bool>);
			TagItemType tagItemType = default(TagItemType);
			string text26 = default(string);
			LocId locId9 = default(LocId);
			CustomStepFeedCritter customStepFeedCritter = default(CustomStepFeedCritter);
			CustomStepFeedCritter customStepFeedCritter2 = default(CustomStepFeedCritter);
			VillageAreaType villageAreaType2 = default(VillageAreaType);
			string text28 = default(string);
			string text29 = default(string);
			while (true)
			{
				int num = 0;
				_003C_003Ec__DisplayClass415_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass415_0();
				CS_0024_003C_003E8__locals0.localizator = localizator;
				CS_0024_003C_003E8__locals0._003C_003E4__this = this;
				if ((IntPtr)Data != (IntPtr)num && CS_0024_003C_003E8__locals0 == null && key != null)
				{
					if ((long)CS_0024_003C_003E8__locals0 <= 2028718070)
					{
						goto IL_074d;
					}
					if ((long)CS_0024_003C_003E8__locals0 <= 3429440371L)
					{
						goto IL_0366;
					}
					if ((long)CS_0024_003C_003E8__locals0 <= 3878067943L)
					{
						goto IL_0209;
					}
					if ((long)CS_0024_003C_003E8__locals0 <= 4095142816L)
					{
						goto IL_016a;
					}
					if ((long)CS_0024_003C_003E8__locals0 != 4141960578L)
					{
						goto IL_00c9;
					}
					if (CS_0024_003C_003E8__locals0 != null)
					{
						MissionObjectiveData missionObjectiveData = Data;
						if (missionObjectiveData.customStepCase_ == MissionObjectiveData.CustomStepOneofCase.TalkToCharacter)
						{
							AnyItemSelectorWithAmount anyItemSelectorWithAmount = Enumerable.FirstOrDefault<AnyItemSelectorWithAmount>((IEnumerable<>)(object)missionObjectiveData.TalkToCharacter.itemsToGive_);
							if (anyItemSelectorWithAmount != null)
							{
								int item = anyItemSelectorWithAmount.itemToGive_.itemToGive_.Item.item_.Item;
							}
							goto IL_00c9;
						}
					}
				}
				goto IL_0797;
				IL_0b44:
				while (!flag)
				{
				}
				goto IL_0b49;
				IL_0c16:
				GridLocationFilter.LocationTypeOneofCase locationTypeCase_ = customStepRemoveBlocker.filter_.locationTypeCase_;
				if (locationTypeCase_ != GridLocationFilter.LocationTypeOneofCase.VillageArea)
				{
					switch (locationTypeCase_)
					{
					default:
					{
						LocationInHouse inHouse = customStepRemoveBlocker2.filter_.InHouse;
						break;
					}
					case GridLocationFilter.LocationTypeOneofCase.SpecificLocation:
						break;
					}
					LocationSource location_ = customStepRemoveBlocker3.filter_.SpecificLocation.location_;
					while (!flag2)
					{
					}
				}
				goto IL_0c59;
				IL_0bd6:
				string text2 = "MissionStep.VillageArea_" + text;
				locId = LocId.From("MissionStep.VillageArea_");
				goto IL_0bf0;
				IL_0b36:
				if ((long)typeof(_003C_003Ec).TypeHandle == 200)
				{
					goto IL_0b44;
				}
				goto IL_0b49;
				IL_0209:
				if ((long)CS_0024_003C_003E8__locals0 <= 3820942345L)
				{
					goto IL_02c1;
				}
				if ((long)CS_0024_003C_003E8__locals0 == 3839757516L)
				{
					if (CS_0024_003C_003E8__locals0 == null)
					{
						goto IL_0797;
					}
					RepeatedField<int> repeatedField = itemIdsCollected_;
					Func<int, string> func = (Func<int, string>)(object)(Func<T, TResult>)delegate(int x)
					{
						Localizator localizator3 = CS_0024_003C_003E8__locals0.localizator;
						return GetItemDisplayName(x, localizator3);
					};
					IEnumerable<int> enumerable = (IEnumerable<int>)Enumerable.Select<int, string>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
				}
				if ((long)CS_0024_003C_003E8__locals0 != 3863795003L)
				{
					goto IL_02aa;
				}
				if (CS_0024_003C_003E8__locals0 != null)
				{
					MissionObjectiveData missionObjectiveData2 = Data;
					if (missionObjectiveData2.customStepCase_ == MissionObjectiveData.CustomStepOneofCase.FeedCritter && missionObjectiveData2.FeedCritter.conditionCase_ == CustomStepFeedCritter.ConditionOneofCase.Location)
					{
						Func<CritterItemData, bool> func2 = (Func<CritterItemData, bool>)(object)(Func<T, TResult>)delegate(CritterItemData x)
						{
							//Discarded unreachable code: IL_0024
							MissionObjective _003C_003E4__this = CS_0024_003C_003E8__locals0._003C_003E4__this;
							VillageAreaType location_4 = x.location_;
							VillageAreaType location2 = _003C_003E4__this.Data.FeedCritter.Location;
							return location_4 == location2;
						};
						if (Enumerable.FirstOrDefault<CritterItemData>(enumerable2, (Func<, >)(object)func2) != null)
						{
							goto IL_02aa;
						}
					}
				}
				goto IL_0797;
				IL_09aa:
				string text4 = text3;
				if (_003C_003Ec._003C_003E9__415_2 != null)
				{
					continue;
				}
				func3 = (Func<int, bool>)(object)(Func<T, TResult>)((int x) => tagItemType7 == TagItemType.ApparelType);
				if ((long)typeof(_003C_003Ec).TypeHandle == 1427870450)
				{
					while ((object)typeof(_003C_003Ec).TypeHandle == null)
					{
					}
					if (minStarRatingReq == null && minStarRatingReq != null && func3 == null)
					{
					}
				}
				while ((long)text5 != 1509397908)
				{
				}
				if (text5 == null)
				{
					if ((long)text5 == 1103681518)
					{
						while (text5 == null)
						{
						}
					}
					while ((long)text5 != 1320592388)
					{
					}
					while (text5 == null)
					{
					}
					goto IL_0a23;
				}
				goto IL_0bf0;
				IL_0c59:
				GridLocationFilter.LocationTypeOneofCase locationTypeCase_2 = customStepDecorate.location_.locationTypeCase_;
				if (locationTypeCase_2 != GridLocationFilter.LocationTypeOneofCase.VillageArea)
				{
					if (locationTypeCase_2 != GridLocationFilter.LocationTypeOneofCase.SpecificLocation)
					{
						string text6 = ((Enum)locationTypeOneofCase).ToString();
					}
					LocationSource location_2 = customStepDecorate2.location_.SpecificLocation.location_;
					while (!flag3)
					{
					}
				}
				Func<VillageAreaType, string> func4 = (Func<VillageAreaType, string>)(object)new Func<T, TResult>(((_003C_003Ec__DisplayClass415_0)(object)data)._003CResolveKey_003Eb__10);
				break;
				IL_0b49:
				if (!flag)
				{
					int itemID = item2.ItemID;
				}
				characterItem = customStepStartDiscussion.CharacterItem;
				goto IL_0b60;
				IL_0bfa:
				LocationSource targetLocation_ = customStepListen.targetLocation_;
				while (!flag4)
				{
				}
				goto IL_0c08;
				IL_057a:
				ItemFilter itemFilter = itemFilter_;
				Func<int, string> func5 = (Func<int, string>)(object)(Func<T, TResult>)delegate(int x)
				{
					Localizator localizator2 = CS_0024_003C_003E8__locals0.localizator;
					return GetItemDisplayName(x, localizator2);
				};
				if (_003C_003Ec._003C_003E9__415_9 == null)
				{
					func6 = (Func<string, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((string x) => result));
				}
				List<string> list = (List<string>)(object)Enumerable.ToList<string>(Enumerable.Where<string>((IEnumerable<>)enumerable3, (Func<, >)(object)func6));
				if (Enumerable.Any<string>((IEnumerable<>)list))
				{
					string text7 = string.Join(", ", (IEnumerable<>)list);
					goto IL_05dc;
				}
				goto IL_0797;
				IL_03e1:
				if ((long)universeTagItem != 3429440371L)
				{
					goto IL_0797;
				}
				if ((object)universeTagItem == null)
				{
					goto IL_03fa;
				}
				goto IL_0b44;
				IL_00c9:
				if ((long)CS_0024_003C_003E8__locals0 != 4194784217L)
				{
					goto IL_00ff;
				}
				if (CS_0024_003C_003E8__locals0 != null)
				{
					MissionObjectiveData missionObjectiveData3 = Data;
					if (missionObjectiveData3.customStepCase_ == MissionObjectiveData.CustomStepOneofCase.Friend)
					{
						CustomStepFriend friend = missionObjectiveData3.Friend;
						goto IL_00ff;
					}
				}
				goto IL_0797;
				IL_0bf0:
				while ((object)locId == null)
				{
				}
				while ((object)locId == null)
				{
				}
				goto IL_0bfa;
				IL_03fa:
				if (((long)universeTagItem != 2889752756L || (object)universeTagItem != null) && (long)text8 == 3191456325L && text8 != null)
				{
					ItemFilter itemFilter2 = itemFilter_;
					if (itemFilter2 != null)
					{
						ItemFilterData data_ = itemFilter2.data_;
						if (data_ != null)
						{
							if (data_.item_ != 0)
							{
								goto IL_05dc;
							}
							bool flag5 = Enumerable.Any<int>((IEnumerable<>)(object)data_.itemList_);
							ItemFilter itemFilter3 = itemFilter_;
							if (flag5)
							{
								goto IL_057a;
							}
							ItemFilterData data_2 = itemFilter3.data_;
							if (data_2.cropType_ != (CropTypeCondition)num)
							{
								goto IL_0991;
							}
							if ((data_2.complexity_.useField_ ? 1 : 0) == num && (data_2.mood_.useField_ ? 1 : 0) == num && (data_2.sturdiness_.useField_ ? 1 : 0) == num && (data_2.normality_.useField_ ? 1 : 0) == num)
							{
								int count = ((RepeatedField<T>)(object)data_2.tags_).Count;
								ItemFilterData data_3 = itemFilter_.data_;
								OptionalField fishLocation_ = data_3.fishLocation_;
								if ((fishLocation_.useField_ ? 1 : 0) == num)
								{
									string constraint_ = data_3.constraint_;
									if (fishLocation_ != null)
									{
										ItemFilterData data_4 = itemFilter_.data_;
										if ((data_4.onlySeedCrop_ ? 1 : 0) == num && data_4.cropType_ == (CropTypeCondition)num)
										{
											if (data_4.type_ != ItemType.ActivityItem)
											{
												string text9 = $"MissionStep.Any_{itemType}";
												arg = LocId.From("MissionStep.Any_{0}");
											}
											string text10 = $"MissionStep.Any_{arg}";
											LocId locId2 = LocId.From("MissionStep.Any_{0}");
											goto IL_057a;
										}
									}
								}
							}
						}
					}
				}
				goto IL_0797;
				IL_02aa:
				if ((long)CS_0024_003C_003E8__locals0 != 3878067943L)
				{
					goto IL_0797;
				}
				if (CS_0024_003C_003E8__locals0 == null)
				{
					goto IL_02c1;
				}
				goto IL_0b36;
				IL_00ff:
				if ((long)CS_0024_003C_003E8__locals0 == 4219780606L && CS_0024_003C_003E8__locals0 != null)
				{
					ItemFilter itemFilter4 = itemFilter_;
					if (itemFilter4 != null)
					{
						ItemFilterData data_5 = itemFilter4.data_;
						if (data_5 != null)
						{
							OptionalField mood_ = data_5.mood_;
							if (mood_ != null)
							{
								Mood mood = mood_.Mood;
								string text11 = ((Enum)mood2).ToString();
							}
						}
					}
					string text12 = "MissionStep.TargetItem_Mood_" + (string)num;
					LocId locId3 = LocId.From("MissionStep.TargetItem_Mood_");
					goto IL_016a;
				}
				goto IL_0797;
				IL_0991:
				if (text3 != null && building != null)
				{
					string text13 = text3.ToString();
					goto IL_09aa;
				}
				goto IL_0bd6;
				IL_02c1:
				if ((long)CS_0024_003C_003E8__locals0 == 3446217990L)
				{
					if (CS_0024_003C_003E8__locals0 == null || Data.customStepCase_ != MissionObjectiveData.CustomStepOneofCase.Listen || !flag6)
					{
						goto IL_0797;
					}
					MissionStepStatus status = Status;
				}
				if ((long)CS_0024_003C_003E8__locals0 == 3820942345L && CS_0024_003C_003E8__locals0 != null)
				{
					ItemFilter itemFilter5 = itemFilter_;
					if (itemFilter5 != null)
					{
						ItemFilterData data_6 = itemFilter5.data_;
						if (data_6 != null)
						{
							OptionalField complexity_ = data_6.complexity_;
							if (complexity_ != null)
							{
								Complexity complexity = complexity_.Complexity;
								text14 = ((Enum)complexity2).ToString();
							}
						}
					}
					string text15 = "MissionStep.TargetItem_Complexity_" + text14;
					LocId locId4 = LocId.From("MissionStep.TargetItem_Complexity_");
					goto IL_0366;
				}
				goto IL_0797;
				IL_05e4:
				if ((long)text16 <= 2447884758L)
				{
					goto IL_06ee;
				}
				if ((long)text16 == 2647827104L)
				{
					if (text16 == null)
					{
						goto IL_0797;
					}
					if (func6 != null && func6 != null)
					{
						text17 = func6.ToString();
					}
					string text18 = "MissionStep.TargetItem_FishConstraint_" + text17;
					locId5 = LocId.From("MissionStep.TargetItem_FishConstraint_");
				}
				if ((long)locId5 == 2664841801L)
				{
					if ((object)locId5 == null)
					{
						goto IL_0797;
					}
					if (_003C_003Ec._003C_003E9__415_3 != null)
					{
						goto IL_06e5;
					}
					Func<int, bool> func7 = (Func<int, bool>)(object)(Func<T, TResult>)((int x) => tagItemType6 == TagItemType.FurnitureFunction);
				}
				if ((long)typeof(_003C_003Ec).TypeHandle == 2888859350L && (object)typeof(_003C_003Ec).TypeHandle != null)
				{
					if ((long)typeof(_003C_003Ec).TypeHandle != 135)
					{
						if ((long)typeof(_003C_003Ec).TypeHandle == 100)
						{
						}
						if (_003C_003Ec._003C_003E9__415_1 != null)
						{
							goto IL_06e5;
						}
						Func<int, bool> func8 = (Func<int, bool>)(object)(Func<T, TResult>)((int x) => tagItemType5 == TagItemType.ApparelStyle);
					}
					Func<int, int> _003C_003E9__288_ = _003C_003Ec._003C_003E9__288_6;
					if (_003C_003Ec._003C_003E9__415_0 == null)
					{
						func9 = (Func<int, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((int x) => tagItemType4 == TagItemType.FurnitureStyle));
					}
					goto IL_06e5;
				}
				goto IL_0797;
				IL_06e5:
				list2 = (List<int>)(object)Enumerable.ToList<int>((IEnumerable<>)enumerable4);
				goto IL_06ee;
				IL_0c08:
				LocationSource targetLocation_2 = customStepFollowCharacter.targetLocation_;
				while (!flag7)
				{
				}
				goto IL_0c16;
				IL_05dc:
				if (text16 == null)
				{
					goto IL_05e4;
				}
				goto IL_0797;
				IL_016a:
				if ((long)CS_0024_003C_003E8__locals0 != 3907107962L || CS_0024_003C_003E8__locals0 != null)
				{
					if ((long)CS_0024_003C_003E8__locals0 == 3999945026L)
					{
						if (CS_0024_003C_003E8__locals0 == null)
						{
							goto IL_0797;
						}
						ItemFilter itemFilter6 = itemFilter_;
						if (itemFilter6 != null)
						{
							ItemFilterData data_7 = itemFilter6.data_;
							if (data_7 != null)
							{
								OptionalField normality_ = data_7.normality_;
								if (normality_ != null)
								{
									Normality normality = normality_.Normality;
									text19 = ((Enum)normality2).ToString();
								}
							}
						}
						string text20 = "MissionStep.TargetItem_Normality_" + text19;
						locId6 = LocId.From("MissionStep.TargetItem_Normality_");
					}
					if ((long)locId6 == 4095142816L && (object)locId6 != null)
					{
						List<int> list3 = (List<int>)(object)Enumerable.ToList<int>((IEnumerable<>)normality2);
						goto IL_0209;
					}
				}
				goto IL_0797;
				IL_07d4:
				if ((long)typeof(_003C_003Ec).TypeHandle == 1629956843)
				{
					while ((object)typeof(_003C_003Ec).TypeHandle == null)
					{
					}
					if ((long)typeof(_003C_003Ec).TypeHandle != 275)
					{
						if ((long)typeof(_003C_003Ec).TypeHandle != 285)
						{
							if ((long)typeof(_003C_003Ec).TypeHandle != 180)
							{
								while ((long)typeof(_003C_003Ec).TypeHandle != 290)
								{
								}
								if (customStepVisitArea.locationTypeCase_ != CustomStepVisitArea.LocationTypeOneofCase.VillageArea)
								{
									data = missionSlot.Data;
									int num2 = 0;
									int num3 = 0;
									if (!customStepVisitArea2.TryGetSceneItemBuilding(data, in *(WorldProfile*)num3, out *(Item*)num2))
									{
										if (customStepVisitArea3.locationTypeCase_ != CustomStepVisitArea.LocationTypeOneofCase.Character)
										{
											while (customStepVisitArea4.locationTypeCase_ != CustomStepVisitArea.LocationTypeOneofCase.SpecificLocation)
											{
											}
											LocationSource location_3 = customStepVisitArea5.SpecificLocation.location_;
											while (!flag8)
											{
											}
										}
										int character_ = customStepVisitArea6.Character.character_;
									}
								}
								VillageAreaType villageArea = customStepVisitArea7.VillageArea;
							}
							while (customStepFriend.characterCase_ != CustomStepFriend.CharacterOneofCase.CharacterID)
							{
							}
							Item characterItem2 = customStepFriend2.CharacterItem;
						}
						while (customStepUpgrade.targetCase_ != CustomStepUpgrade.TargetOneofCase.BuildingID)
						{
						}
						Item buildingItem = customStepUpgrade2.BuildingItem;
					}
					CustomStepUnlock.TypeOneofCase typeCase_ = customStepUnlock.typeCase_;
					if (customStepUnlock != null)
					{
						if (customStepUnlock != null)
						{
							while (typeCase_ != CustomStepUnlock.TypeOneofCase.Building)
							{
							}
							if (customStepUnlock2.Realm.targetCase_ != TargetRealm.TargetOneofCase.RealmID)
							{
								continue;
							}
							Item realmItem = customStepUnlock3.Realm.RealmItem;
						}
						if (customStepUnlock4.Area.targetCase_ != TargetArea.TargetOneofCase.Area)
						{
							continue;
						}
						VillageAreaType area = customStepUnlock5.Area.Area;
						string text21 = ((Enum)villageAreaType).ToString();
						string text22 = "MissionStep.VillageArea_" + text21;
						LocId locId7 = LocId.From("MissionStep.VillageArea_");
					}
					if (customStepUnlock6.Building.buildingTypeCase_ == TargetBuildingType.BuildingTypeOneofCase.Any || customStepUnlock7.Building.TargetBuilding.targetCase_ != TargetBuilding.TargetOneofCase.ItemID)
					{
						continue;
					}
					building = customStepUnlock8.Building;
					MissionItemData data2 = missionSlot2.Data;
					int itemID2 = building.GetTargetBuildingItem(data2).ItemID;
				}
				while ((long)text3 != 1635549519)
				{
				}
				while (text3 == null)
				{
				}
				goto IL_0991;
				IL_0797:
				while ((long)CS_0024_003C_003E8__locals0 != 2028718070)
				{
				}
				while (CS_0024_003C_003E8__locals0 == null)
				{
				}
				RepeatedField<int> tags_ = itemFilter_.data_.tags_;
				if (_003C_003Ec._003C_003E9__415_5 != null)
				{
					continue;
				}
				Func<int, bool> func10 = (Func<int, bool>)(object)(Func<T, TResult>)((int x) => tagItemType3 == TagItemType.Universe);
				goto IL_07d4;
				IL_0a23:
				if ((long)text5 > 200649126)
				{
					if ((long)text5 > 811577636)
					{
						if ((long)text5 == 890580885)
						{
							while (text5 == null)
							{
							}
							if (text5 != null && text5 != null && func3 != null)
							{
								text23 = ((Enum)sturdiness).ToString();
							}
							string text24 = "MissionStep.TargetItem_Sturdiness_" + text23;
							locId8 = LocId.From("MissionStep.TargetItem_Sturdiness_");
						}
						if ((long)locId8 == 1009319937)
						{
						}
						while ((long)locId8 != 1031692888)
						{
						}
						while ((object)locId8 == null)
						{
						}
						if (_003C_003Ec._003C_003E9__415_6 != null)
						{
							continue;
						}
						Func<int, bool> func11 = (Func<int, bool>)(object)(Func<T, TResult>)((int x) => tagItemType2 == TagItemType.DominantColor);
					}
					if ((long)typeof(_003C_003Ec).TypeHandle == 628650808)
					{
						while ((object)typeof(_003C_003Ec).TypeHandle == null)
						{
						}
					}
					while ((long)typeof(_003C_003Ec).TypeHandle != 811577636)
					{
					}
					while ((object)typeof(_003C_003Ec).TypeHandle == null)
					{
					}
				}
				if ((long)text25 <= 5388517)
				{
					break;
				}
				if ((long)text25 == 59825223)
				{
					while (text25 == null)
					{
					}
					if (_003C_003Ec._003C_003E9__415_4 != null)
					{
						continue;
					}
					func12 = (Func<int, bool>)(object)(Func<T, TResult>)((int x) => tagItemType == TagItemType.FurnitureZone);
				}
				if ((long)typeof(_003C_003Ec).TypeHandle == 103290623)
				{
					while ((object)typeof(_003C_003Ec).TypeHandle == null)
					{
					}
					goto IL_0b36;
				}
				goto IL_0b60;
				IL_06ee:
				if ((long)list2 == 2205273681L)
				{
					if (list2 == null)
					{
						goto IL_0797;
					}
					int size = ((List<>)(object)list2)._size;
					if (size != 0 && func9 != null)
					{
						text26 = ((int*)size)->ToString();
					}
					string text27 = "MissionStep.TargetItem_FlowerRarity_" + text26;
					locId9 = LocId.From("MissionStep.TargetItem_FlowerRarity_");
				}
				if ((long)locId9 == 2447884758L && (object)locId9 != null)
				{
					goto IL_074d;
				}
				goto IL_0797;
				IL_0b60:
				while ((long)characterItem != 200649126)
				{
				}
				while ((object)characterItem == null)
				{
				}
				if ((long)characterItem != 135)
				{
					if ((long)characterItem != 240)
					{
						if ((long)characterItem != 175)
						{
							if ((long)characterItem != 200)
							{
								if ((long)characterItem == 160 && customStepFeedCritter.conditionCase_ == CustomStepFeedCritter.ConditionOneofCase.Location)
								{
									if (func12 != null && customStepFeedCritter2 != null)
									{
										VillageAreaType location = customStepFeedCritter2.Location;
										text = ((Enum)villageAreaType2).ToString();
									}
									goto IL_0bd6;
								}
								goto IL_0bf0;
							}
							goto IL_0bfa;
						}
						goto IL_0c08;
					}
					goto IL_0c16;
				}
				goto IL_0c59;
				IL_0366:
				if ((long)CS_0024_003C_003E8__locals0 <= 2888859350L)
				{
					goto IL_05e4;
				}
				if ((long)CS_0024_003C_003E8__locals0 <= 3191456325L)
				{
					goto IL_03fa;
				}
				if ((long)CS_0024_003C_003E8__locals0 == 3271417359L)
				{
					if (CS_0024_003C_003E8__locals0 == null)
					{
						goto IL_0797;
					}
					ItemFilterData data_8 = itemFilter_.data_;
				}
				if ((long)text28 != 3350260102L)
				{
					goto IL_03e1;
				}
				if (text28 != null)
				{
					MissionObjectiveData missionObjectiveData4 = Data;
					if (missionObjectiveData4.customStepCase_ == MissionObjectiveData.CustomStepOneofCase.StartDiscussion)
					{
						universeTagItem = missionObjectiveData4.StartDiscussion.UniverseTagItem;
						goto IL_03e1;
					}
				}
				goto IL_0797;
				IL_074d:
				if ((long)CS_0024_003C_003E8__locals0 > 1031692888)
				{
					if ((long)CS_0024_003C_003E8__locals0 > 1509397908)
					{
						if ((long)CS_0024_003C_003E8__locals0 > 1635549519)
						{
							if ((long)CS_0024_003C_003E8__locals0 == 1785851830)
							{
								if (CS_0024_003C_003E8__locals0 == null)
								{
									goto IL_0797;
								}
								ItemFilterData data_9 = itemFilter_.data_;
							}
							if ((long)text29 != 1929936635)
							{
							}
							goto IL_0797;
						}
						goto IL_07d4;
					}
					goto IL_09aa;
				}
				goto IL_0a23;
			}
			IEnumerable<VillageAreaType> enumerable5 = default(IEnumerable<VillageAreaType>);
			if ((long)enumerable5 == 1374545)
			{
				while (enumerable5 == null)
				{
				}
			}
			string text30 = default(string);
			while ((long)text30 != 5388517)
			{
			}
			while (text30 == null)
			{
			}
			int num4 = default(int);
			while (num4 <= 0)
			{
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600823A")]
		[Cpp2IlInjected.Address(RVA = "0x807370", Offset = "0x805D70", VA = "0x180807370")]
		public static string GetItemDisplayName(Item item, Localizator localizator)
		{
			return item.GetLocalizedDisplayName(localizator);
		}

		[Cpp2IlInjected.Token(Token = "0x600823B")]
		[Cpp2IlInjected.Address(RVA = "0x807380", Offset = "0x805D80", VA = "0x180807380")]
		public static string GetItemDisplayName(int id, Localizator localizator)
		{
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600823C")]
		[Cpp2IlInjected.Address(RVA = "0x8073F0", Offset = "0x805DF0", VA = "0x1808073F0")]
		public static string GetItemsDisplayName(List<int> listId, Localizator localizator)
		{
			//Discarded unreachable code: IL_0057
			Func<int, string> func = (Func<int, string>)(object)(Func<T, TResult>)delegate(int id)
			{
				Localizator localizator2 = localizator;
				return GetItemDisplayName(id, localizator2);
			};
			IEnumerable<int> enumerable = (IEnumerable<int>)Enumerable.Select<int, string>((IEnumerable<>)listId, (Func<, >)(object)func);
			Func<string, bool> _003C_003E9__418_ = _003C_003Ec._003C_003E9__418_1;
			if (_003C_003E9__418_ == null)
			{
				bool result = default(bool);
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((string x) => result);
			}
			IEnumerable<string> enumerable2 = (IEnumerable<string>)Enumerable.Where<string>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__418_);
			return string.Join(", ", (IEnumerable<>)enumerable2);
		}

		[Cpp2IlInjected.Token(Token = "0x600823D")]
		[Cpp2IlInjected.Address(RVA = "0x807600", Offset = "0x806000", VA = "0x180807600")]
		public static string GetItemsDisplayName(RepeatedField<int> listId, Localizator localizator)
		{
			return MissionObjective.GetItemsDisplayName(Enumerable.ToList<int>((IEnumerable<>)(object)listId), localizator);
		}

		[Cpp2IlInjected.Token(Token = "0x600823E")]
		[Cpp2IlInjected.Address(RVA = "0x820C60", Offset = "0x81F660", VA = "0x180820C60")]
		private static bool TryGetLocationDisplayName(LocationSource location, Localizator localizator, out string displayName)
		{
			//IL_0044: Expected O, but got I4
			//IL_0068: Expected O, but got I4
			//IL_00dc: Expected O, but got I4
			int num = 0;
			LocationSource locationSource = location;
			if (locationSource != null)
			{
				LocationSource.LocationOneofCase locationCase_ = locationSource.locationCase_;
			}
			if (num != 0 && num <= 18)
			{
				LocationAnywhereFloorType anywhereFloorType = location.AnywhereFloorType;
				GridFloorType gridFloorType = default(GridFloorType);
				string text = ((Enum)gridFloorType).ToString();
				string text2 = "MissionStep.FloorType_" + text;
				LocationAnywhereVillageArea anywhereVillageArea = location.AnywhereVillageArea;
				VillageAreaType villageAreaType = default(VillageAreaType);
				string text3 = ((Enum)villageAreaType).ToString();
				string text4 = "MissionStep.VillageArea_" + text3;
				LocationFishingSpot fishingSpot = location.FishingSpot;
				string itemDisplayName = GetItemDisplayName(location.Building.building_, localizator);
				string location_ = location.Other.location_;
				int num2 = 0;
				string text5 = "MissionStep.Location_Other_" + location_;
				bool flag = default(bool);
				if (flag)
				{
					Func<GUIDNameCollection.Types.GUIDName, bool> func = (Func<GUIDNameCollection.Types.GUIDName, bool>)(object)(Func<T, TResult>)delegate(GUIDNameCollection.Types.GUIDName x)
					{
						//Discarded unreachable code: IL_0022
						LocationSource locationSource2 = location;
						string gUID_ = x.gUID_;
						string gUID_2 = locationSource2.Custom.gUID_;
						return string.Equals(gUID_, gUID_2);
					};
					GUIDNameCollection.Types.GUIDName gUIDName = Enumerable.FirstOrDefault<GUIDNameCollection.Types.GUIDName>((IEnumerable<>)villageAreaType, (Func<, >)(object)func);
					if (gUIDName == null || gUIDName.name_ != null)
					{
					}
					int itemID = location.NearUniqueItem.Item.ItemID;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600823F")]
		[Cpp2IlInjected.Address(RVA = "0x80A4B0", Offset = "0x808EB0", VA = "0x18080A4B0", Slot = "21")]
		public bool HasFieldName(string fieldName)
		{
			MissionObjectiveData.CustomStepOneofCase customStepCase_ = Data.customStepCase_;
			if (customStepCase_ > MissionObjectiveData.CustomStepOneofCase.GardeningHarvest)
			{
				if (customStepCase_ > MissionObjectiveData.CustomStepOneofCase.PickUp)
				{
					if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.PlaceBuilding)
					{
					}
					if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.TakePicture)
					{
					}
					if (customStepCase_ != MissionObjectiveData.CustomStepOneofCase.WaterPlant)
					{
						goto IL_01e3;
					}
				}
				if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.GardeningPlant)
				{
					if (string.Equals(fieldName, "Amount"))
					{
						goto IL_01e1;
					}
					if (Data.GardeningPlant.targetItem_.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.None)
					{
						goto IL_01e3;
					}
				}
				if (customStepCase_ != MissionObjectiveData.CustomStepOneofCase.PickUp)
				{
					goto IL_01e3;
				}
			}
			MissionObjectiveData missionObjectiveData = default(MissionObjectiveData);
			CustomStepGardeningHarvest gardeningHarvest = default(CustomStepGardeningHarvest);
			if (customStepCase_ > MissionObjectiveData.CustomStepOneofCase.CookMeal)
			{
				if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.Decorate)
				{
					if (string.Equals(fieldName, "AmountToPlace"))
					{
						goto IL_01e1;
					}
					CustomStepDecorate decorate = Data.Decorate;
				}
				if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.DressUp)
				{
					if (string.Equals(fieldName, "AmountToWear"))
					{
						goto IL_01e1;
					}
					CustomStepDressUp dressUp = Data.DressUp;
				}
				if (customStepCase_ != MissionObjectiveData.CustomStepOneofCase.GardeningHarvest)
				{
					goto IL_01e3;
				}
				if (string.Equals(fieldName, "Amount"))
				{
					goto IL_01e1;
				}
				missionObjectiveData = Data;
				gardeningHarvest = missionObjectiveData.GardeningHarvest;
			}
			if ((long)gardeningHarvest == 105)
			{
				if (missionObjectiveData.CatchFish.conditionType_.typesCase_ == CatchFishConditionType.TypesOneofCase.Amount)
				{
					if (!string.Equals(fieldName, "ConditionType.Amount.AmountToCatch") && !string.Equals(fieldName, "ConditionType.Amount.MinWeightRequired"))
					{
						return string.Equals(fieldName, "ConditionType.Amount.MaxWeightRequired");
					}
					goto IL_01e1;
				}
				if (Data.CatchFish.conditionType_.typesCase_ == CatchFishConditionType.TypesOneofCase.TotalWeight)
				{
					return string.Equals(fieldName, "ConditionType.TotalWeight.TotalWeightToCatch");
				}
				if (Data.CatchFish.targetItem_.itemSelectorCase_ != 0)
				{
					return string.Equals(fieldName, "TargetItem.Item.MinRarity");
				}
			}
			else if ((long)gardeningHarvest == 125)
			{
				if (!string.Equals(fieldName, "AmountToCook"))
				{
					if (Data.CookMeal.conditionTypeCase_ == CustomStepCookMeal.ConditionTypeOneofCase.TargetIngredientItem)
					{
						bool result = default(bool);
						return result;
					}
					if (Data.CookMeal.conditionTypeCase_ != CustomStepCookMeal.ConditionTypeOneofCase.TargetMealItem)
					{
						goto IL_01e3;
					}
					if (!string.Equals(fieldName, "TargetMealItem"))
					{
						return string.Equals(fieldName, "TargetMealItem.Item.MinMealStarRating");
					}
				}
				goto IL_01e1;
			}
			goto IL_01e3;
			IL_01e3:
			int num = 0;
			throw new NullReferenceException();
			IL_01e1:
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6008240")]
		[Cpp2IlInjected.Address(RVA = "0x807680", Offset = "0x806080", VA = "0x180807680", Slot = "20")]
		public string GetKeyValue(string fieldName)
		{
			//Discarded unreachable code: IL_0211
			string result = default(string);
			string text = default(string);
			string text2 = default(string);
			CustomStepCookMeal customStepCookMeal = default(CustomStepCookMeal);
			CustomStepCookMeal customStepCookMeal2 = default(CustomStepCookMeal);
			string text3 = default(string);
			string result2 = default(string);
			while (true)
			{
				MissionObjectiveData.CustomStepOneofCase customStepCase_ = Data.customStepCase_;
				if (customStepCase_ > MissionObjectiveData.CustomStepOneofCase.GardeningHarvest)
				{
					if (customStepCase_ > MissionObjectiveData.CustomStepOneofCase.PickUp)
					{
						if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.PlaceBuilding)
						{
							if (!string.Equals(fieldName, "Building"))
							{
								break;
							}
							CustomStepPlaceBuilding placeBuilding = Data.PlaceBuilding;
							return result;
						}
						if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.TakePicture)
						{
						}
						if (customStepCase_ != MissionObjectiveData.CustomStepOneofCase.WaterPlant)
						{
							break;
						}
					}
					if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.GardeningPlant)
					{
						if (string.Equals(fieldName, "Amount"))
						{
							goto IL_01ac;
						}
						if (Data.GardeningPlant.targetItem_.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.None)
						{
							break;
						}
					}
					if (customStepCase_ != MissionObjectiveData.CustomStepOneofCase.PickUp)
					{
						break;
					}
				}
				if (customStepCase_ <= MissionObjectiveData.CustomStepOneofCase.CookMeal)
				{
					continue;
				}
				if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.Decorate)
				{
					if (string.Equals(fieldName, "AmountToPlace"))
					{
						goto IL_01ac;
					}
					CustomStepDecorate decorate = Data.Decorate;
				}
				if (customStepCase_ == MissionObjectiveData.CustomStepOneofCase.DressUp)
				{
					if (string.Equals(fieldName, "AmountToWear"))
					{
						goto IL_01ac;
					}
					CustomStepDressUp dressUp = Data.DressUp;
				}
				if (customStepCase_ != MissionObjectiveData.CustomStepOneofCase.GardeningHarvest)
				{
					break;
				}
				if (string.Equals(fieldName, "Amount"))
				{
					goto IL_01ac;
				}
				MissionObjectiveData missionObjectiveData = Data;
				if ((long)missionObjectiveData.GardeningHarvest == 105)
				{
					if (missionObjectiveData.CatchFish.conditionType_.typesCase_ != CatchFishConditionType.TypesOneofCase.Amount)
					{
						if (Data.CatchFish.conditionType_.typesCase_ != CatchFishConditionType.TypesOneofCase.TotalWeight)
						{
							if (Data.CatchFish.targetItem_.itemSelectorCase_ == ItemSelector.ItemSelectorOneofCase.None || !string.Equals(fieldName, "TargetItem.Item.MinRarity"))
							{
								break;
							}
							ItemFilter itemFilter = itemFilter_;
							if (itemFilter != null)
							{
								int minRarity = itemFilter.MinRarity;
								if (text != null)
								{
								}
							}
							return "0";
						}
						if (!string.Equals(fieldName, "ConditionType.TotalWeight.TotalWeightToCatch"))
						{
							break;
						}
						goto IL_01ac;
					}
					while (text2 != null)
					{
					}
					if (text2 == null && text2 == null)
					{
						break;
					}
				}
				if ((long)text2 != 125)
				{
					break;
				}
				while (text2 != null)
				{
				}
				if (customStepCookMeal.conditionTypeCase_ != CustomStepCookMeal.ConditionTypeOneofCase.TargetIngredientItem)
				{
					if (customStepCookMeal2.conditionTypeCase_ != CustomStepCookMeal.ConditionTypeOneofCase.TargetMealItem)
					{
						break;
					}
					if (customStepCookMeal2 != null)
					{
						goto IL_01fc;
					}
					if (customStepCookMeal2 == null)
					{
						break;
					}
					while (customStepCookMeal2 == null)
					{
					}
					StepAmount amountToCook_ = customStepCookMeal2.amountToCook_;
				}
				if (customStepCookMeal2 == null)
				{
					break;
				}
				goto IL_01fc;
				IL_01ac:
				return text2;
				IL_01fc:
				while (text3 != null)
				{
				}
				Item invalid = Item.Invalid;
				return result2;
			}
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x6008241")]
		[Cpp2IlInjected.Address(RVA = "0x822E90", Offset = "0x821890", VA = "0x180822E90")]
		static MissionObjective()
		{
			FieldCodec<string> fieldCodec = (FieldCodec<string>)(object)FieldCodec.ForString(10u);
			FieldCodec<string> fieldCodec2 = (FieldCodec<string>)(object)FieldCodec.ForString(18u);
			uint num = default(uint);
			_parser = (MessageParser<MissionObjective>)(object)new MapField<TKey, TValue>.Codec((FieldCodec<>)(object)fieldCodec, (FieldCodec<>)(object)fieldCodec2, num);
			_parser = (MessageParser<MissionObjective>)(object)FieldCodec.ForInt32(82u);
			MessageParser<Types.GridObjectInfo> parser = Types.GridObjectInfo._parser;
			uint num2 = default(uint);
			_parser = (MessageParser<MissionObjective>)(object)FieldCodec.ForMessage<Types.GridObjectInfo>(num2, (MessageParser<>)(object)parser);
			MessageParser<ItemFilterWithAmount> parser2 = ItemFilterWithAmount._parser;
			uint num3 = default(uint);
			_parser = (MessageParser<MissionObjective>)(object)FieldCodec.ForMessage<ItemFilterWithAmount>(num3, (MessageParser<>)(object)parser2);
			_parser = (MessageParser<MissionObjective>)(object)"CurrentAmount";
			_parser = (MessageParser<MissionObjective>)(object)"Discussion";
			/*Error: Unexpected end of block*/;
		}
	}
}
