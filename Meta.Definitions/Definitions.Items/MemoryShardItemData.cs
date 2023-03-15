using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Rewards;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20002B3")]
	public sealed class MemoryShardItemData : IMessage<MemoryShardItemData>, IMessage, IEquatable<MemoryShardItemData>, IDeepCloneable<MemoryShardItemData>, IMessageFieldAccessor, IItemData, IHasGlotID, IProtobufDefaultData, IRewardGenerationCondition, IItemStateProvider, IItemConsummableOverride, IDataValidation, ICollectionItem
	{
		[Cpp2IlInjected.Token(Token = "0x20002B4")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20002B5")]
			public sealed class ShardData : IMessage<ShardData>, IMessage, IEquatable<ShardData>, IDeepCloneable<ShardData>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000BBC")]
				private static readonly MessageParser<ShardData> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000BBD")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000BBE")]
				public const int AppearanceConditionFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000BBF")]
				private RewardAppearanceCondition appearanceCondition_;

				[Cpp2IlInjected.Token(Token = "0x4000BC0")]
				public const int AppearanceWeightFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000BC1")]
				private int appearanceWeight_;

				[Cpp2IlInjected.Token(Token = "0x1700065B")]
				[DebuggerNonUserCode]
				public static MessageParser<ShardData> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001C67")]
					[Cpp2IlInjected.Address(RVA = "0x2FF2BD0", Offset = "0x2FF15D0", VA = "0x182FF2BD0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700065C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001C68")]
					[Cpp2IlInjected.Address(RVA = "0x2FF2B50", Offset = "0x2FF1550", VA = "0x182FF2B50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700065D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001C69")]
					[Cpp2IlInjected.Address(RVA = "0x2FF2C30", Offset = "0x2FF1630", VA = "0x182FF2C30", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700065E")]
				[DebuggerNonUserCode]
				public RewardAppearanceCondition AppearanceCondition
				{
					[Cpp2IlInjected.Token(Token = "0x6001C6E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(RewardAppearanceCondition);
					}
					[Cpp2IlInjected.Token(Token = "0x6001C6F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700065F")]
				[DebuggerNonUserCode]
				public int AppearanceWeight
				{
					[Cpp2IlInjected.Token(Token = "0x6001C70")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001C71")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001C6A")]
				[Cpp2IlInjected.Address(RVA = "0x1EE50B0", Offset = "0x1EE3AB0", VA = "0x181EE50B0")]
				[DebuggerNonUserCode]
				public ShardData()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001C6B")]
				[Cpp2IlInjected.Address(RVA = "0x1E30960", Offset = "0x1E2F360", VA = "0x181E30960")]
				private void OnConstruction()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001C6C")]
				[Cpp2IlInjected.Address(RVA = "0x29370F0", Offset = "0x2935AF0", VA = "0x1829370F0")]
				[DebuggerNonUserCode]
				public ShardData(ShardData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001C6D")]
				[Cpp2IlInjected.Address(RVA = "0x2FF2700", Offset = "0x2FF1100", VA = "0x182FF2700", Slot = "10")]
				[DebuggerNonUserCode]
				public ShardData Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001C72")]
				[Cpp2IlInjected.Address(RVA = "0x2FF2790", Offset = "0x2FF1190", VA = "0x182FF2790", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001C73")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ShardData other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001C74")]
				[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001C75")]
				[Cpp2IlInjected.Address(RVA = "0x2FF29E0", Offset = "0x2FF13E0", VA = "0x182FF29E0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001C76")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001C77")]
				[Cpp2IlInjected.Address(RVA = "0x2FF2630", Offset = "0x2FF1030", VA = "0x182FF2630", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001C78")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ShardData other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001C79")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001C7A")]
				[Cpp2IlInjected.Address(RVA = "0x2FF2820", Offset = "0x2FF1220", VA = "0x182FF2820", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001C7B")]
				[Cpp2IlInjected.Address(RVA = "0x2FF2910", Offset = "0x2FF1310", VA = "0x182FF2910", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001C7C")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000B9E")]
		private static readonly MessageParser<MemoryShardItemData> _parser = (MessageParser<MemoryShardItemData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new MemoryShardItemData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000B9F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000BA0")]
		public const int IDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000BA1")]
		private int iD_;

		[Cpp2IlInjected.Token(Token = "0x4000BA2")]
		public const int NameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000BA3")]
		private string name_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BA4")]
		public const int DisplayNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000BA5")]
		private string displayName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BA6")]
		public const int IconAddressFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000BA7")]
		private string iconAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BA8")]
		public const int PrefabAddressFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000BA9")]
		private string prefabAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BAA")]
		public const int ImageAddressFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000BAB")]
		private string imageAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BAC")]
		public const int MaskDataAddressFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000BAD")]
		private string maskDataAddress_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BAE")]
		public const int UniverseTagItemIDFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000BAF")]
		private int universeTagItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000BB0")]
		public const int MemoryShardTagItemIDFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000BB1")]
		private int memoryShardTagItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000BB2")]
		public const int ConsummableOverrideItemIDFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000BB3")]
		private int consummableOverrideItemID_;

		[Cpp2IlInjected.Token(Token = "0x4000BB4")]
		public const int DescriptionTextFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000BB5")]
		private string descriptionText_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000BB6")]
		public const int ShardsFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4000BB7")]
		private static readonly FieldCodec<Types.ShardData> _repeated_shards_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000BB8")]
		private readonly RepeatedField<Types.ShardData> shards_ = (RepeatedField<Types.ShardData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4000BB9")]
		public const int GlotIDFieldNumber = 999;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000BBA")]
		private uint glotID_;

		[Cpp2IlInjected.Token(Token = "0x4000BBB")]
		private const int DefaultNumberOfShardsPerImage = 10;

		[Cpp2IlInjected.Token(Token = "0x17000644")]
		[DebuggerNonUserCode]
		public static MessageParser<MemoryShardItemData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001C2C")]
			[Cpp2IlInjected.Address(RVA = "0x3078460", Offset = "0x3076E60", VA = "0x183078460")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000645")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001C2D")]
			[Cpp2IlInjected.Address(RVA = "0x30782E0", Offset = "0x3076CE0", VA = "0x1830782E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000646")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001C2E")]
			[Cpp2IlInjected.Address(RVA = "0x3078520", Offset = "0x3076F20", VA = "0x183078520", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000647")]
		[DebuggerNonUserCode]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6001C32")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "14")]
			get
			{
				return iD_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C33")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				iD_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000648")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001C34")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return name_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C35")]
			[Cpp2IlInjected.Address(RVA = "0x3078860", Offset = "0x3077260", VA = "0x183078860")]
			set
			{
				string text = (name_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000649")]
		[DebuggerNonUserCode]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6001C36")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "17")]
			get
			{
				return displayName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C37")]
			[Cpp2IlInjected.Address(RVA = "0x30786A0", Offset = "0x30770A0", VA = "0x1830786A0")]
			set
			{
				string text = (displayName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700064A")]
		[DebuggerNonUserCode]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001C38")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "18")]
			get
			{
				return iconAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C39")]
			[Cpp2IlInjected.Address(RVA = "0x3078710", Offset = "0x3077110", VA = "0x183078710")]
			set
			{
				string text = (iconAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700064B")]
		[DebuggerNonUserCode]
		public string PrefabAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001C3A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "19")]
			get
			{
				return prefabAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C3B")]
			[Cpp2IlInjected.Address(RVA = "0x30788D0", Offset = "0x30772D0", VA = "0x1830788D0")]
			set
			{
				string text = (prefabAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700064C")]
		[DebuggerNonUserCode]
		public string ImageAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001C3C")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return imageAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C3D")]
			[Cpp2IlInjected.Address(RVA = "0x3078780", Offset = "0x3077180", VA = "0x183078780")]
			set
			{
				string text = (imageAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700064D")]
		[DebuggerNonUserCode]
		public string MaskDataAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001C3E")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return maskDataAddress_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C3F")]
			[Cpp2IlInjected.Address(RVA = "0x30787F0", Offset = "0x30771F0", VA = "0x1830787F0")]
			set
			{
				string text = (maskDataAddress_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700064E")]
		[DebuggerNonUserCode]
		public int UniverseTagItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6001C40")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return universeTagItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C41")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				universeTagItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700064F")]
		[DebuggerNonUserCode]
		public int MemoryShardTagItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6001C42")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get
			{
				return memoryShardTagItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C43")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				memoryShardTagItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000650")]
		[DebuggerNonUserCode]
		public int ConsummableOverrideItemID
		{
			[Cpp2IlInjected.Token(Token = "0x6001C44")]
			[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
			get
			{
				return consummableOverrideItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C45")]
			[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
			set
			{
				consummableOverrideItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000651")]
		[DebuggerNonUserCode]
		public string DescriptionText
		{
			[Cpp2IlInjected.Token(Token = "0x6001C46")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return descriptionText_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C47")]
			[Cpp2IlInjected.Address(RVA = "0x3078630", Offset = "0x3077030", VA = "0x183078630")]
			set
			{
				string text = (descriptionText_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000652")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.ShardData> Shards
		{
			[Cpp2IlInjected.Token(Token = "0x6001C48")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return shards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000653")]
		[DebuggerNonUserCode]
		public uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6001C49")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050", Slot = "21")]
			get
			{
				return glotID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C4A")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110", Slot = "22")]
			set
			{
				glotID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000654")]
		public int NumberOfShards
		{
			[Cpp2IlInjected.Token(Token = "0x6001C56")]
			[Cpp2IlInjected.Address(RVA = "0x3078410", Offset = "0x3076E10", VA = "0x183078410")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((RepeatedField<T>)(object)shards_).Count;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000655")]
		public int CompletedShardFlag
		{
			[Cpp2IlInjected.Token(Token = "0x6001C57")]
			[Cpp2IlInjected.Address(RVA = "0x30781B0", Offset = "0x3076BB0", VA = "0x1830781B0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((RepeatedField<T>)(object)shards_).Count;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000656")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001C59")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "28")]
			get
			{
				int num = iD_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000657")]
		public Item UniverseTagItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001C5A")]
			[Cpp2IlInjected.Address(RVA = "0x30784C0", Offset = "0x3076EC0", VA = "0x1830784C0")]
			get
			{
				long num = Convert.ToInt64((uint)universeTagItemID_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C5B")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				//IL_0007: Expected I4, but got O
				universeTagItemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000658")]
		public Item MemoryShardTagItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001C5C")]
			[Cpp2IlInjected.Address(RVA = "0x30783B0", Offset = "0x3076DB0", VA = "0x1830783B0")]
			get
			{
				long num = Convert.ToInt64((uint)memoryShardTagItemID_);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C5D")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			set
			{
				//IL_0007: Expected I4, but got O
				memoryShardTagItemID_ = (int)value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000659")]
		public Item? ConsummableOverrideItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001C5E")]
			[Cpp2IlInjected.Address(RVA = "0x3078210", Offset = "0x3076C10", VA = "0x183078210", Slot = "26")]
			get
			{
				int num = consummableOverrideItemID_;
				long num2 = Convert.ToInt64((uint)consummableOverrideItemID_);
				int num3 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700065A")]
		public bool CanBeCollected
		{
			[Cpp2IlInjected.Token(Token = "0x6001C5F")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "29")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C2F")]
		[Cpp2IlInjected.Address(RVA = "0x3077E60", Offset = "0x3076860", VA = "0x183077E60")]
		[DebuggerNonUserCode]
		public MemoryShardItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001C30")]
		[Cpp2IlInjected.Address(RVA = "0x3077F70", Offset = "0x3076970", VA = "0x183077F70")]
		[DebuggerNonUserCode]
		public MemoryShardItemData(MemoryShardItemData other)
		{
			int num = (iD_ = other.iD_);
			string text = (name_ = other.name_);
			string text2 = (displayName_ = other.displayName_);
			string text3 = (iconAddress_ = other.iconAddress_);
			string text4 = (prefabAddress_ = other.prefabAddress_);
			string text5 = (imageAddress_ = other.imageAddress_);
			string text6 = (maskDataAddress_ = other.maskDataAddress_);
			int num2 = (universeTagItemID_ = other.universeTagItemID_);
			int num3 = (memoryShardTagItemID_ = other.memoryShardTagItemID_);
			int num4 = (consummableOverrideItemID_ = other.consummableOverrideItemID_);
			string text7 = (descriptionText_ = other.descriptionText_);
			RepeatedField<Types.ShardData> repeatedField = (shards_ = (RepeatedField<Types.ShardData>)(object)((RepeatedField<T>)(object)other.shards_).Clone());
			uint num5 = (glotID_ = other.glotID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C31")]
		[Cpp2IlInjected.Address(RVA = "0x30761B0", Offset = "0x3074BB0", VA = "0x1830761B0", Slot = "10")]
		[DebuggerNonUserCode]
		public MemoryShardItemData Clone()
		{
			return new MemoryShardItemData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C4B")]
		[Cpp2IlInjected.Address(RVA = "0x3076580", Offset = "0x3074F80", VA = "0x183076580", Slot = "0")]
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
				if ((IntPtr)iD_ == (IntPtr)typeof(MemoryShardItemData).TypeHandle)
				{
					string text = name_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = displayName_;
						bool flag2 = default(bool);
						if (!flag2)
						{
							string text3 = iconAddress_;
							bool flag3 = default(bool);
							if (!flag3)
							{
								string text4 = prefabAddress_;
								bool flag4 = default(bool);
								if (!flag4)
								{
									string text5 = imageAddress_;
									bool flag5 = default(bool);
									if (!flag5)
									{
										string text6 = maskDataAddress_;
										bool flag6 = default(bool);
										if (!flag6 && universeTagItemID_ == (flag6 ? 1 : 0) && memoryShardTagItemID_ == (flag6 ? 1 : 0) && consummableOverrideItemID_ == (flag6 ? 1 : 0))
										{
											string text7 = descriptionText_;
											bool flag7 = default(bool);
											if (!flag7)
											{
												RepeatedField<Types.ShardData> repeatedField = shards_;
												bool flag8 = default(bool);
												if (flag8 && glotID_ == (flag8 ? 1u : 0u))
												{
													return object.Equals(_unknownFields, other);
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
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C4C")]
		[Cpp2IlInjected.Address(RVA = "0x3076410", Offset = "0x3074E10", VA = "0x183076410", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MemoryShardItemData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.iD_;
				if (iD_ == num)
				{
					string text = other.name_;
					if (!(name_ != text))
					{
						string text2 = other.displayName_;
						if (!(displayName_ != text2))
						{
							string text3 = other.iconAddress_;
							if (!(iconAddress_ != text3))
							{
								string text4 = other.prefabAddress_;
								if (!(prefabAddress_ != text4))
								{
									string text5 = other.imageAddress_;
									if (!(imageAddress_ != text5))
									{
										string text6 = other.maskDataAddress_;
										if (!(maskDataAddress_ != text6))
										{
											int num2 = other.universeTagItemID_;
											if (universeTagItemID_ == num2)
											{
												int num3 = other.memoryShardTagItemID_;
												if (memoryShardTagItemID_ == num3)
												{
													int num4 = other.consummableOverrideItemID_;
													if (consummableOverrideItemID_ == num4)
													{
														string text7 = other.descriptionText_;
														if (!(descriptionText_ != text7))
														{
															RepeatedField<Types.ShardData> repeatedField = shards_;
															RepeatedField<Types.ShardData> repeatedField2 = other.shards_;
															if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
															{
																uint num5 = other.glotID_;
																if (glotID_ == num5)
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
			}
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C4D")]
		[Cpp2IlInjected.Address(RVA = "0x30768E0", Offset = "0x30752E0", VA = "0x1830768E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_010b
			int num = 0;
			if (iD_ != 0)
			{
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int hashCode4 = text4.GetHashCode();
			}
			string text5 = imageAddress_;
			if (text5.m_stringLength != 0)
			{
				int hashCode5 = text5.GetHashCode();
			}
			string text6 = maskDataAddress_;
			if (text6.m_stringLength != 0)
			{
				int hashCode6 = text6.GetHashCode();
			}
			if (universeTagItemID_ != 0)
			{
			}
			if (memoryShardTagItemID_ != 0)
			{
			}
			if (consummableOverrideItemID_ != 0)
			{
			}
			string text7 = descriptionText_;
			if (text7.m_stringLength != 0)
			{
				int hashCode7 = text7.GetHashCode();
			}
			int hashCode8 = ((RepeatedField<T>)(object)shards_).GetHashCode();
			if (glotID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode9 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C4E")]
		[Cpp2IlInjected.Address(RVA = "0x3077920", Offset = "0x3076320", VA = "0x183077920", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C4F")]
		[Cpp2IlInjected.Address(RVA = "0x3077980", Offset = "0x3076380", VA = "0x183077980", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0177
			if (iD_ != 0)
			{
				int value = iD_;
				output.WriteInt32(value);
			}
			if (name_.m_stringLength != 0)
			{
				string value2 = name_;
				output.WriteString(value2);
			}
			if (displayName_.m_stringLength != 0)
			{
				string value3 = displayName_;
				output.WriteString(value3);
			}
			if (iconAddress_.m_stringLength != 0)
			{
				string value4 = iconAddress_;
				output.WriteString(value4);
			}
			if (prefabAddress_.m_stringLength != 0)
			{
				string value5 = prefabAddress_;
				output.WriteString(value5);
			}
			if (imageAddress_.m_stringLength != 0)
			{
				string value6 = imageAddress_;
				output.WriteString(value6);
			}
			if (maskDataAddress_.m_stringLength != 0)
			{
				string value7 = maskDataAddress_;
				output.WriteString(value7);
			}
			if (universeTagItemID_ != 0)
			{
				int value8 = universeTagItemID_;
				output.WriteInt32(value8);
			}
			if (consummableOverrideItemID_ != 0)
			{
				int value9 = consummableOverrideItemID_;
				output.WriteInt32(value9);
			}
			RepeatedField<Types.ShardData> repeatedField = shards_;
			FieldCodec<Types.ShardData> repeated_shards_codec = _repeated_shards_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_shards_codec);
			if (memoryShardTagItemID_ != 0)
			{
				int value10 = memoryShardTagItemID_;
				output.WriteInt32(value10);
			}
			if (descriptionText_.m_stringLength != 0)
			{
				string value11 = descriptionText_;
				output.WriteString(value11);
			}
			if (glotID_ != 0)
			{
				uint value12 = glotID_;
				output.WriteUInt32(value12);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C50")]
		[Cpp2IlInjected.Address(RVA = "0x3075A40", Offset = "0x3074440", VA = "0x183075A40", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_01dc
			int num = iD_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = name_;
			if (text.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = displayName_;
			if (text2.m_stringLength != 0)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			string text3 = iconAddress_;
			if (text3.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text3);
				num6++;
				num2 += num6;
			}
			string text4 = prefabAddress_;
			if (text4.m_stringLength != 0)
			{
				int num7 = CodedOutputStream.ComputeStringSize(text4);
				num7++;
				num2 += num7;
			}
			string text5 = imageAddress_;
			if (text5.m_stringLength != 0)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text5);
				num8++;
				num2 += num8;
			}
			string text6 = maskDataAddress_;
			if (text6.m_stringLength != 0)
			{
				int num9 = CodedOutputStream.ComputeStringSize(text6);
				num9++;
				num2 += num9;
			}
			int num10 = universeTagItemID_;
			if (num10 != 0)
			{
				int num11 = CodedOutputStream.ComputeInt32Size(num10);
				num11++;
				num2 += num11;
			}
			int num12 = memoryShardTagItemID_;
			if (num12 != 0)
			{
				int num13 = CodedOutputStream.ComputeInt32Size(num12);
				num13++;
				num2 += num13;
			}
			int num14 = consummableOverrideItemID_;
			if (num14 != 0)
			{
				int num15 = CodedOutputStream.ComputeInt32Size(num14);
				num15++;
				num2 += num15;
			}
			string text7 = descriptionText_;
			if (text7.m_stringLength != 0)
			{
				int num16 = CodedOutputStream.ComputeStringSize(text7);
				num16++;
				num2 += num16;
			}
			RepeatedField<Types.ShardData> repeatedField = shards_;
			FieldCodec<Types.ShardData> repeated_shards_codec = _repeated_shards_codec;
			int num17 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_shards_codec);
			uint num18 = glotID_;
			num2 += num17;
			if (num18 != 0)
			{
				int num19 = CodedOutputStream.ComputeUInt32Size(num18);
				num19 += 2;
				num2 += num19;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num20 = unknownFields.CalculateSize();
				num2 += num20;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C51")]
		[Cpp2IlInjected.Address(RVA = "0x3077060", Offset = "0x3075A60", VA = "0x183077060", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MemoryShardItemData other)
		{
			//Discarded unreachable code: IL_0154
			if (other != null)
			{
				int num = other.iD_;
				if (num != 0)
				{
					iD_ = num;
				}
				string text = other.name_;
				if (text.m_stringLength != 0)
				{
					Name = text;
				}
				string text2 = other.displayName_;
				if (text2.m_stringLength != 0)
				{
					DisplayName = text2;
				}
				string text3 = other.iconAddress_;
				if (text3.m_stringLength != 0)
				{
					IconAddress = text3;
				}
				string text4 = other.prefabAddress_;
				if (text4.m_stringLength != 0)
				{
					PrefabAddress = text4;
				}
				string text5 = other.imageAddress_;
				if (text5.m_stringLength != 0)
				{
					ImageAddress = text5;
				}
				string text6 = other.maskDataAddress_;
				if (text6.m_stringLength != 0)
				{
					MaskDataAddress = text6;
				}
				int num2 = other.universeTagItemID_;
				if (num2 != 0)
				{
					universeTagItemID_ = num2;
				}
				int num3 = other.memoryShardTagItemID_;
				if (num3 != 0)
				{
					memoryShardTagItemID_ = num3;
				}
				int num4 = other.consummableOverrideItemID_;
				if (num4 != 0)
				{
					consummableOverrideItemID_ = num4;
				}
				string text7 = other.descriptionText_;
				if (text7.m_stringLength != 0)
				{
					DescriptionText = text7;
				}
				RepeatedField<Types.ShardData> repeatedField = shards_;
				RepeatedField<Types.ShardData> repeatedField2 = other.shards_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				uint num5 = other.glotID_;
				if (num5 != 0)
				{
					glotID_ = num5;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C52")]
		[Cpp2IlInjected.Address(RVA = "0x30771E0", Offset = "0x3075BE0", VA = "0x1830771E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0177
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 50)
			{
				if ((int)num > 72)
				{
					if ((int)num > 88)
					{
						if (num == 98)
						{
							string text2 = (DescriptionText = input.ReadString());
						}
						if (num != 7992)
						{
							goto IL_0160;
						}
						int num2 = (int)(glotID_ = (uint)input.ReadInt32());
					}
					if (num == 82)
					{
						RepeatedField<Types.ShardData> repeatedField = shards_;
						FieldCodec<Types.ShardData> repeated_shards_codec = _repeated_shards_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_shards_codec);
					}
					if (num != 88)
					{
						goto IL_0160;
					}
					int num3 = (memoryShardTagItemID_ = input.ReadInt32());
				}
				string text4 = default(string);
				if (num == 58)
				{
					text4 = (MaskDataAddress = input.ReadString());
				}
				int num4 = default(int);
				if ((long)text4 == 64)
				{
					num4 = (universeTagItemID_ = input.ReadInt32());
				}
				if (num4 != 72)
				{
					goto IL_0160;
				}
				int num5 = (consummableOverrideItemID_ = input.ReadInt32());
			}
			string text10 = default(string);
			if ((int)num > 26)
			{
				string text6 = default(string);
				if (num == 34)
				{
					text6 = (IconAddress = input.ReadString());
				}
				string text8 = default(string);
				if ((long)text6 == 42)
				{
					text8 = (PrefabAddress = input.ReadString());
				}
				if ((long)text8 != 50)
				{
					goto IL_0160;
				}
				text10 = (ImageAddress = input.ReadString());
			}
			int num6 = default(int);
			if ((long)text10 == 8)
			{
				num6 = (iD_ = input.ReadInt32());
			}
			string text12 = default(string);
			if (num6 == 18)
			{
				text12 = (Name = input.ReadString());
			}
			if ((long)text12 == 26)
			{
				string text14 = (DisplayName = input.ReadString());
			}
			goto IL_0160;
			IL_0160:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6001C53")]
		[Cpp2IlInjected.Address(RVA = "0x3076730", Offset = "0x3075130", VA = "0x183076730", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 11)
			{
				int num = iD_;
			}
			if (fieldNumber == 999)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C54")]
		[Cpp2IlInjected.Address(RVA = "0x30774F0", Offset = "0x3075EF0", VA = "0x1830774F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001e, IL_002b, IL_0033, IL_003b, IL_0043, IL_0054, IL_005a, IL_0060, IL_0066, IL_006c, IL_0072, IL_0078, IL_007e
			//IL_000e: Expected I4, but got O
			//IL_0018: Expected O, but got I4
			//IL_0053: Expected I4, but got O
			if (fieldNumber - 1 <= 11)
			{
				object obj = default(object);
				iD_ = (int)obj;
				return;
			}
			while (fieldNumber != 999)
			{
			}
			object obj2 = default(object);
			glotID_ = (uint)(int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C55")]
		[Cpp2IlInjected.Address(RVA = "0x3075FD0", Offset = "0x30749D0", VA = "0x183075FD0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0019, IL_001a, IL_001b, IL_001c, IL_002f
			//IL_0010: Expected I4, but got I8
			//IL_002e: Expected I4, but got I8
			if (fieldNumber - 1 <= 11)
			{
				iD_ = 0;
			}
			else if (fieldNumber == 999)
			{
				glotID_ = 0u;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C58")]
		[Cpp2IlInjected.Address(RVA = "0x3077460", Offset = "0x3075E60", VA = "0x183077460")]
		public int Progression(int flag)
		{
			//Discarded unreachable code: IL_0018
			int num = 0;
			int count = ((RepeatedField<T>)(object)shards_).Count;
			if (num < count)
			{
				num++;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C60")]
		[Cpp2IlInjected.Address(RVA = "0x3075DC0", Offset = "0x30747C0", VA = "0x183075DC0")]
		public bool CanBeGiven(in PlayerProfile playerProfile, in WorldProfile worldProfile, [Optional] RewardGenerationParameters parameters)
		{
			//Discarded unreachable code: IL_0052
			IProfileWorld section = worldProfile.Section;
			int num = universeTagItemID_;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			if ((object)typeof(Item).TypeHandle != null)
			{
				RepeatedField<Types.ShardData> repeatedField = shards_;
				Predicate<Types.ShardData> predicate = (Predicate<Types.ShardData>)(object)(Predicate<T>)delegate(Types.ShardData x)
				{
					RewardAppearanceCondition appearanceCondition_ = x.appearanceCondition_;
					if (appearanceCondition_ == RewardAppearanceCondition.Anywhere)
					{
						return true;
					}
					RewardGenerationParameters rewardGenerationParameters = parameters;
					if (rewardGenerationParameters != null && (object)rewardGenerationParameters.RewardAppearanceCondition != null)
					{
						RewardAppearanceCondition? _003CRewardAppearanceCondition_003Ek__BackingField = rewardGenerationParameters.RewardAppearanceCondition;
						RewardAppearanceCondition rewardAppearanceCondition = default(RewardAppearanceCondition);
						return appearanceCondition_ == rewardAppearanceCondition;
					}
					int num4 = 0;
					throw new NullReferenceException();
				};
				return ((RepeatedField<>)(object)repeatedField).Any<Types.ShardData>((Predicate<>)(object)predicate);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C61")]
		[Cpp2IlInjected.Address(RVA = "0x3076AD0", Offset = "0x30754D0", VA = "0x183076AD0", Slot = "25")]
		public unsafe ItemState GetItemState(Random random, [Optional] RewardGenerationParameters parameters)
		{
			//IL_007a: Expected O, but got I4
			RewardAppearanceCondition rewardAppearanceCondition = default(RewardAppearanceCondition);
			Func<(int, int), int> func = default(Func<(int, int), int>);
			Func<(int, int), int> func2 = default(Func<(int, int), int>);
			bool flag = default(bool);
			ItemState itemState = default(ItemState);
			int num;
			do
			{
				num = 0;
				int num2 = 0;
				int num3 = 0;
				List<(int, int)> list = (List<(int, int)>)(object)new List<T>();
				int count = ((RepeatedField<T>)(object)shards_).Count;
				if (num < count)
				{
					if (((Types.ShardData)((RepeatedField<T>)(object)shards_)[num]).appearanceCondition_ == (RewardAppearanceCondition)num)
					{
						goto IL_0060;
					}
					if (parameters != null && (object)parameters.RewardAppearanceCondition != null)
					{
						RewardAppearanceCondition appearanceCondition_ = ((Types.ShardData)((RepeatedField<T>)(object)shards_)[num]).appearanceCondition_;
						RewardAppearanceCondition? _003CRewardAppearanceCondition_003Ek__BackingField = parameters.RewardAppearanceCondition;
						if (appearanceCondition_ == rewardAppearanceCondition)
						{
							goto IL_0060;
						}
					}
					goto IL_007a;
				}
				goto IL_0086;
				IL_0086:
				if (_003C_003Ec._003C_003E9__108_0 == null)
				{
					func = (Func<(int, int), int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)(((int index, int weight) x) => (int)((ValueTuple<, >*)(&x))->Item1));
				}
				List<(int, int)> list2 = (List<(int, int)>)(object)Enumerable.ToList<(int, int)>((IEnumerable<>)Enumerable.OrderBy<(int, int), int>((IEnumerable<>)list, (Func<, >)(object)func));
				if (_003C_003Ec._003C_003E9__108_1 == null)
				{
					func2 = (Func<(int, int), int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)(((int index, int weight) x) => (int)((ValueTuple<, >*)(&x))->Item1));
				}
				int maxValue = Enumerable.Sum<(int, int)>((IEnumerable<>)list2, (Func<, >)(object)func2);
				int num4 = random.Next(maxValue);
				if (flag)
				{
					num4 -= num3;
					itemState = new ItemState();
					itemState.MemoryShardIndex = num3;
					num++;
				}
				num++;
				continue;
				IL_0060:
				int appearanceWeight_ = ((Types.ShardData)((RepeatedField<T>)(object)shards_)[num]).appearanceWeight_;
				((List<T>)(object)list).Add((T)num);
				goto IL_007a;
				IL_007a:
				num++;
				RepeatedField<Types.ShardData> repeatedField = shards_;
				goto IL_0086;
			}
			while (num != 0);
			if (num != 0)
			{
				return itemState;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C62")]
		[Cpp2IlInjected.Address(RVA = "0x30761B0", Offset = "0x3074BB0", VA = "0x1830761B0", Slot = "20")]
		IItemData IItemData.Clone()
		{
			MemoryShardItemData memoryShardItemData = new MemoryShardItemData(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C63")]
		[Cpp2IlInjected.Address(RVA = "0x3076360", Offset = "0x3074D60", VA = "0x183076360", Slot = "23")]
		void IProtobufDefaultData.SetDefaultData()
		{
			//Discarded unreachable code: IL_001b
			int num = 0;
			RepeatedField<Types.ShardData> repeatedField = shards_;
			Types.ShardData item = new Types.ShardData();
			((RepeatedField<T>)(object)repeatedField).Add((T)item);
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C64")]
		[Cpp2IlInjected.Address(RVA = "0x3076210", Offset = "0x3074C10", VA = "0x183076210", Slot = "27")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0071
			string text = imageAddress_;
			if ("No mask selected" != null)
			{
				context.AddInvalidMemberError("No image selected", "ImageAddress");
			}
			string text2 = maskDataAddress_;
			if ("No mask selected" != null)
			{
				context.AddInvalidMemberError("No mask selected", "MaskDataAddress");
			}
			if (universeTagItemID_ == 0)
			{
				context.AddInvalidMemberError("No universe selected", "UniverseTagItemID");
			}
			if (consummableOverrideItemID_ == 0)
			{
				context.AddInvalidMemberError("No consummable item selected", "ConsummableOverrideItemID");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C65")]
		[Cpp2IlInjected.Address(RVA = "0x3077C90", Offset = "0x3076690", VA = "0x183077C90")]
		static MemoryShardItemData()
		{
			MessageParser<Types.ShardData> parser = Types.ShardData._parser;
			uint num = default(uint);
			_parser = (MessageParser<MemoryShardItemData>)(object)FieldCodec.ForMessage<Types.ShardData>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C66")]
		[Cpp2IlInjected.Address(RVA = "0x3076350", Offset = "0x3074D50", VA = "0x183076350", Slot = "24")]
		bool IRewardGenerationCondition.CanBeGiven(in PlayerProfile playerProfile, in WorldProfile worldProfile, RewardGenerationParameters parameters)
		{
			return CanBeGiven(in playerProfile, in worldProfile, parameters);
		}
	}
}
