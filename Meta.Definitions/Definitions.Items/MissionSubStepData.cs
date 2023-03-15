using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000524")]
	public sealed class MissionSubStepData : IMessage<MissionSubStepData>, IMessage, IEquatable<MissionSubStepData>, IDeepCloneable<MissionSubStepData>, IMessageFieldAccessor, IMessageOneofAccessor, IMissionStepName, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000525")]
		public enum ExtraOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x4001B8B")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4001B8C")]
			BringItem = 10
		}

		[Cpp2IlInjected.Token(Token = "0x2000526")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000527")]
			public sealed class ExtraBringItem : IMessage<ExtraBringItem>, IMessage, IEquatable<ExtraBringItem>, IDeepCloneable<ExtraBringItem>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4001B8D")]
				private static readonly MessageParser<ExtraBringItem> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001B8E")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4001B8F")]
				public const int ReadyDescriptionFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001B90")]
				private string readyDescription_;

				[Cpp2IlInjected.Token(Token = "0x4001B91")]
				public const int KeepItemsFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4001B92")]
				private bool keepItems_;

				[Cpp2IlInjected.Token(Token = "0x4001B93")]
				public const int SkipAvatarGiveAnimationFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
				[Cpp2IlInjected.Token(Token = "0x4001B94")]
				private bool skipAvatarGiveAnimation_;

				[Cpp2IlInjected.Token(Token = "0x4001B95")]
				public const int BringDialogueTypeFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4001B96")]
				private BringDialogueTypeOptions bringDialogueType_;

				[Cpp2IlInjected.Token(Token = "0x4001B97")]
				public const int BringDialogueFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4001B98")]
				private string bringDialogue_;

				[Cpp2IlInjected.Token(Token = "0x4001B99")]
				public const int ItemsToGiveFieldNumber = 8;

				[Cpp2IlInjected.Token(Token = "0x4001B9A")]
				private static readonly FieldCodec<ItemToGiveAmount> _repeated_itemsToGive_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4001B9B")]
				private readonly RepeatedField<ItemToGiveAmount> itemsToGive_;

				[Cpp2IlInjected.Token(Token = "0x17001064")]
				[DebuggerNonUserCode]
				public static MessageParser<ExtraBringItem> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6003FE0")]
					[Cpp2IlInjected.Address(RVA = "0x2FEAC00", Offset = "0x2FE9600", VA = "0x182FEAC00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001065")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003FE1")]
					[Cpp2IlInjected.Address(RVA = "0x2FEAB80", Offset = "0x2FE9580", VA = "0x182FEAB80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001066")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6003FE2")]
					[Cpp2IlInjected.Address(RVA = "0x2FEAC60", Offset = "0x2FE9660", VA = "0x182FEAC60", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001067")]
				[DebuggerNonUserCode]
				public string ReadyDescription
				{
					[Cpp2IlInjected.Token(Token = "0x6003FE6")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003FE7")]
					[Cpp2IlInjected.Address(RVA = "0x2FEAD90", Offset = "0x2FE9790", VA = "0x182FEAD90")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001068")]
				[DebuggerNonUserCode]
				public bool KeepItems
				{
					[Cpp2IlInjected.Token(Token = "0x6003FE8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6003FE9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001069")]
				[DebuggerNonUserCode]
				public bool SkipAvatarGiveAnimation
				{
					[Cpp2IlInjected.Token(Token = "0x6003FEA")]
					[Cpp2IlInjected.Address(RVA = "0xBA1880", Offset = "0xBA0280", VA = "0x180BA1880")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6003FEB")]
					[Cpp2IlInjected.Address(RVA = "0xBA18C0", Offset = "0xBA02C0", VA = "0x180BA18C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700106A")]
				[DebuggerNonUserCode]
				public BringDialogueTypeOptions BringDialogueType
				{
					[Cpp2IlInjected.Token(Token = "0x6003FEC")]
					[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
					get
					{
						return default(BringDialogueTypeOptions);
					}
					[Cpp2IlInjected.Token(Token = "0x6003FED")]
					[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700106B")]
				[DebuggerNonUserCode]
				public string BringDialogue
				{
					[Cpp2IlInjected.Token(Token = "0x6003FEE")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003FEF")]
					[Cpp2IlInjected.Address(RVA = "0x2FEAD20", Offset = "0x2FE9720", VA = "0x182FEAD20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700106C")]
				[DebuggerNonUserCode]
				public RepeatedField<ItemToGiveAmount> ItemsToGive
				{
					[Cpp2IlInjected.Token(Token = "0x6003FF0")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003FE3")]
				[Cpp2IlInjected.Address(RVA = "0x2FEA960", Offset = "0x2FE9360", VA = "0x182FEA960")]
				[DebuggerNonUserCode]
				public ExtraBringItem()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003FE4")]
				[Cpp2IlInjected.Address(RVA = "0x2FEAA10", Offset = "0x2FE9410", VA = "0x182FEAA10")]
				[DebuggerNonUserCode]
				public ExtraBringItem(ExtraBringItem other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003FE5")]
				[Cpp2IlInjected.Address(RVA = "0x2FE9B00", Offset = "0x2FE8500", VA = "0x182FE9B00", Slot = "10")]
				[DebuggerNonUserCode]
				public ExtraBringItem Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003FF1")]
				[Cpp2IlInjected.Address(RVA = "0x2FE9CA0", Offset = "0x2FE86A0", VA = "0x182FE9CA0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003FF2")]
				[Cpp2IlInjected.Address(RVA = "0x2FE9DC0", Offset = "0x2FE87C0", VA = "0x182FE9DC0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(ExtraBringItem other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6003FF3")]
				[Cpp2IlInjected.Address(RVA = "0x2FE9FF0", Offset = "0x2FE89F0", VA = "0x182FE9FF0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003FF4")]
				[Cpp2IlInjected.Address(RVA = "0x2FEA580", Offset = "0x2FE8F80", VA = "0x182FEA580", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003FF5")]
				[Cpp2IlInjected.Address(RVA = "0x2FEA5E0", Offset = "0x2FE8FE0", VA = "0x182FEA5E0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003FF6")]
				[Cpp2IlInjected.Address(RVA = "0x2FE9870", Offset = "0x2FE8270", VA = "0x182FE9870", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6003FF7")]
				[Cpp2IlInjected.Address(RVA = "0x2FEA270", Offset = "0x2FE8C70", VA = "0x182FEA270", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(ExtraBringItem other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003FF8")]
				[Cpp2IlInjected.Address(RVA = "0x2FEA0F0", Offset = "0x2FE8AF0", VA = "0x182FEA0F0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003FF9")]
				[Cpp2IlInjected.Address(RVA = "0x2FE9EA0", Offset = "0x2FE88A0", VA = "0x182FE9EA0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6003FFA")]
				[Cpp2IlInjected.Address(RVA = "0x2FEA350", Offset = "0x2FE8D50", VA = "0x182FEA350", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6003FFB")]
				[Cpp2IlInjected.Address(RVA = "0x2FE99F0", Offset = "0x2FE83F0", VA = "0x182FE99F0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001B70")]
		private static readonly MessageParser<MissionSubStepData> _parser = (MessageParser<MissionSubStepData>)(object)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new MissionSubStepData()));

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001B71")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001B72")]
		public const int SubStepIDFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001B73")]
		private int subStepID_;

		[Cpp2IlInjected.Token(Token = "0x4001B74")]
		public const int StepNameFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001B75")]
		private string stepName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001B76")]
		public const int StepDescriptionFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001B77")]
		private string stepDescription_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001B78")]
		public const int ShowProgressionCountFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001B79")]
		private bool showProgressionCount_;

		[Cpp2IlInjected.Token(Token = "0x4001B7A")]
		public const int IsOwnerFollowingFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4001B7B")]
		private bool isOwnerFollowing_;

		[Cpp2IlInjected.Token(Token = "0x4001B7C")]
		public const int FollowerFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4001B7D")]
		private int follower_;

		[Cpp2IlInjected.Token(Token = "0x4001B7E")]
		public const int FollowingBarkDialogueFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001B7F")]
		private string followingBarkDialogue_ = "";

		[Cpp2IlInjected.Token(Token = "0x4001B80")]
		public const int SkipStepWhenCompletedFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001B81")]
		private bool skipStepWhenCompleted_;

		[Cpp2IlInjected.Token(Token = "0x4001B82")]
		public const int BringItemFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4001B83")]
		public const int ObjectivesFieldNumber = 50;

		[Cpp2IlInjected.Token(Token = "0x4001B84")]
		private static readonly FieldCodec<MissionObjectiveData> _repeated_objectives_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001B85")]
		private readonly RepeatedField<MissionObjectiveData> objectives_ = (RepeatedField<MissionObjectiveData>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x4001B86")]
		public const int NextObjectiveIDFieldNumber = 51;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001B87")]
		private int nextObjectiveID_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001B88")]
		private object extra_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001B89")]
		private ExtraOneofCase extraCase_;

		[Cpp2IlInjected.Token(Token = "0x17001054")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionSubStepData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003FB1")]
			[Cpp2IlInjected.Address(RVA = "0x29EEAE0", Offset = "0x29ED4E0", VA = "0x1829EEAE0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001055")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003FB2")]
			[Cpp2IlInjected.Address(RVA = "0x29EE9B0", Offset = "0x29ED3B0", VA = "0x1829EE9B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001056")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003FB3")]
			[Cpp2IlInjected.Address(RVA = "0x29EEB40", Offset = "0x29ED540", VA = "0x1829EEB40", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001057")]
		[DebuggerNonUserCode]
		public int SubStepID
		{
			[Cpp2IlInjected.Token(Token = "0x6003FB7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return subStepID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003FB8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				subStepID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001058")]
		[DebuggerNonUserCode]
		public string StepName
		{
			[Cpp2IlInjected.Token(Token = "0x6003FB9")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				return stepName_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003FBA")]
			[Cpp2IlInjected.Address(RVA = "0x29EED30", Offset = "0x29ED730", VA = "0x1829EED30", Slot = "17")]
			set
			{
				string text = (stepName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001059")]
		[DebuggerNonUserCode]
		public string StepDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6003FBB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return stepDescription_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003FBC")]
			[Cpp2IlInjected.Address(RVA = "0x29EECC0", Offset = "0x29ED6C0", VA = "0x1829EECC0")]
			set
			{
				string text = (stepDescription_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700105A")]
		[DebuggerNonUserCode]
		public bool ShowProgressionCount
		{
			[Cpp2IlInjected.Token(Token = "0x6003FBD")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get
			{
				return showProgressionCount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003FBE")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			set
			{
				showProgressionCount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700105B")]
		[DebuggerNonUserCode]
		public bool IsOwnerFollowing
		{
			[Cpp2IlInjected.Token(Token = "0x6003FBF")]
			[Cpp2IlInjected.Address(RVA = "0x997D90", Offset = "0x996790", VA = "0x180997D90")]
			get
			{
				return isOwnerFollowing_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003FC0")]
			[Cpp2IlInjected.Address(RVA = "0x997DC0", Offset = "0x9967C0", VA = "0x180997DC0")]
			set
			{
				isOwnerFollowing_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700105C")]
		[DebuggerNonUserCode]
		public int Follower
		{
			[Cpp2IlInjected.Token(Token = "0x6003FC1")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return follower_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003FC2")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				follower_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700105D")]
		[DebuggerNonUserCode]
		public string FollowingBarkDialogue
		{
			[Cpp2IlInjected.Token(Token = "0x6003FC3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return followingBarkDialogue_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003FC4")]
			[Cpp2IlInjected.Address(RVA = "0x29EEC50", Offset = "0x29ED650", VA = "0x1829EEC50")]
			set
			{
				string text = (followingBarkDialogue_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700105E")]
		[DebuggerNonUserCode]
		public bool SkipStepWhenCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6003FC5")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get
			{
				return skipStepWhenCompleted_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003FC6")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set
			{
				skipStepWhenCompleted_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700105F")]
		[DebuggerNonUserCode]
		public Types.ExtraBringItem BringItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003FC7")]
			[Cpp2IlInjected.Address(RVA = "0x29EE950", Offset = "0x29ED350", VA = "0x1829EE950")]
			get
			{
				int num = 0;
				if (extraCase_ == ExtraOneofCase.BringItem)
				{
					object obj = extra_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003FC8")]
			[Cpp2IlInjected.Address(RVA = "0x1D38150", Offset = "0x1D36B50", VA = "0x181D38150")]
			set
			{
				extra_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001060")]
		[DebuggerNonUserCode]
		public RepeatedField<MissionObjectiveData> Objectives
		{
			[Cpp2IlInjected.Token(Token = "0x6003FC9")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return objectives_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001061")]
		[DebuggerNonUserCode]
		public int NextObjectiveID
		{
			[Cpp2IlInjected.Token(Token = "0x6003FCA")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get
			{
				return nextObjectiveID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003FCB")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set
			{
				nextObjectiveID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001062")]
		[DebuggerNonUserCode]
		public ExtraOneofCase ExtraCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003FCC")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return extraCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001063")]
		public Item FollowerItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003FDB")]
			[Cpp2IlInjected.Address(RVA = "0x29EEA80", Offset = "0x29ED480", VA = "0x1829EEA80")]
			get
			{
				long num = Convert.ToInt64((uint)follower_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003FB4")]
		[Cpp2IlInjected.Address(RVA = "0x29EE890", Offset = "0x29ED290", VA = "0x1829EE890")]
		[DebuggerNonUserCode]
		public MissionSubStepData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003FB5")]
		[Cpp2IlInjected.Address(RVA = "0x29EE660", Offset = "0x29ED060", VA = "0x1829EE660")]
		[DebuggerNonUserCode]
		public MissionSubStepData(MissionSubStepData other)
		{
			//IL_00f6: Expected I4, but got O
			int num = (subStepID_ = other.subStepID_);
			string text = (stepName_ = other.stepName_);
			string text2 = (stepDescription_ = other.stepDescription_);
			bool flag = (showProgressionCount_ = other.showProgressionCount_);
			bool flag2 = (isOwnerFollowing_ = other.isOwnerFollowing_);
			int num2 = (follower_ = other.follower_);
			string text3 = (followingBarkDialogue_ = other.followingBarkDialogue_);
			bool flag3 = (skipStepWhenCompleted_ = other.skipStepWhenCompleted_);
			RepeatedField<MissionObjectiveData> repeatedField = (objectives_ = (RepeatedField<MissionObjectiveData>)(object)((RepeatedField<T>)(object)other.objectives_).Clone());
			int num3 = (nextObjectiveID_ = other.nextObjectiveID_);
			if (other.extraCase_ == ExtraOneofCase.BringItem)
			{
				if (other.extra_ == null)
				{
					throw new InvalidCastException();
				}
				Types.ExtraBringItem extraBringItem = default(Types.ExtraBringItem);
				extra_ = extraBringItem;
				extraCase_ = (ExtraOneofCase)extraBringItem;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003FB6")]
		[Cpp2IlInjected.Address(RVA = "0x29EC080", Offset = "0x29EAA80", VA = "0x1829EC080", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionSubStepData Clone()
		{
			return new MissionSubStepData(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003FCD")]
		[Cpp2IlInjected.Address(RVA = "0x1D36160", Offset = "0x1D34B60", VA = "0x181D36160")]
		[DebuggerNonUserCode]
		public void ClearExtra()
		{
			//IL_0010: Expected O, but got I4
			extra_ = (extraCase_ = ExtraOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003FCE")]
		[Cpp2IlInjected.Address(RVA = "0x29ECFF0", Offset = "0x29EB9F0", VA = "0x1829ECFF0", Slot = "0")]
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
				if ((IntPtr)subStepID_ == (IntPtr)typeof(MissionSubStepData).TypeHandle)
				{
					string text = stepName_;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = stepDescription_;
						bool flag2 = default(bool);
						if (!flag2 && showProgressionCount_ == flag2 && isOwnerFollowing_ == flag2 && follower_ == (flag2 ? 1 : 0))
						{
							string text3 = followingBarkDialogue_;
							bool flag3 = default(bool);
							Types.ExtraBringItem objB = default(Types.ExtraBringItem);
							if (!flag3 && skipStepWhenCompleted_ == flag3 && object.Equals(BringItem, objB))
							{
								RepeatedField<MissionObjectiveData> repeatedField = objectives_;
								bool flag4 = default(bool);
								if (flag4 && nextObjectiveID_ == (flag4 ? 1 : 0) && extraCase_ == (flag4 ? ((ExtraOneofCase)1) : ExtraOneofCase.None))
								{
									return object.Equals(_unknownFields, objB);
								}
							}
						}
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003FCF")]
		[Cpp2IlInjected.Address(RVA = "0x29ED190", Offset = "0x29EBB90", VA = "0x1829ED190", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionSubStepData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.subStepID_;
				if (subStepID_ == num)
				{
					string text = other.stepName_;
					if (!(stepName_ != text))
					{
						string text2 = other.stepDescription_;
						if (!(stepDescription_ != text2))
						{
							bool flag = other.showProgressionCount_;
							if (showProgressionCount_ == flag)
							{
								bool flag2 = other.isOwnerFollowing_;
								if (isOwnerFollowing_ == flag2)
								{
									int num2 = other.follower_;
									if (follower_ == num2)
									{
										string text3 = other.followingBarkDialogue_;
										if (!(followingBarkDialogue_ != text3))
										{
											bool flag3 = other.skipStepWhenCompleted_;
											if (skipStepWhenCompleted_ == flag3)
											{
												Types.ExtraBringItem bringItem = BringItem;
												Types.ExtraBringItem bringItem2 = other.BringItem;
												if (object.Equals(bringItem, bringItem2))
												{
													RepeatedField<MissionObjectiveData> repeatedField = objectives_;
													RepeatedField<MissionObjectiveData> repeatedField2 = other.objectives_;
													if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
													{
														int num3 = other.nextObjectiveID_;
														if (nextObjectiveID_ == num3)
														{
															ExtraOneofCase extraOneofCase = other.extraCase_;
															if (extraCase_ == extraOneofCase)
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

		[Cpp2IlInjected.Token(Token = "0x6003FD0")]
		[Cpp2IlInjected.Address(RVA = "0x29ED490", Offset = "0x29EBE90", VA = "0x1829ED490", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00cc
			int num = subStepID_;
			int num2 = 0;
			if (num != 0)
			{
			}
			string text = stepName_;
			if (text.m_stringLength != num2)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = stepDescription_;
			if (text2.m_stringLength != num2)
			{
				int hashCode2 = text2.GetHashCode();
			}
			if (showProgressionCount_)
			{
			}
			if (isOwnerFollowing_)
			{
			}
			if (follower_ != 0)
			{
			}
			string text3 = followingBarkDialogue_;
			if (text3.m_stringLength != num2)
			{
				int hashCode3 = text3.GetHashCode();
			}
			if (skipStepWhenCompleted_)
			{
			}
			if (extraCase_ == ExtraOneofCase.BringItem)
			{
				object obj = extra_;
				if (obj == null)
				{
					throw new InvalidCastException();
				}
				int hashCode4 = obj.GetHashCode();
			}
			int hashCode5 = ((RepeatedField<T>)(object)objectives_).GetHashCode();
			if (nextObjectiveID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode6 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003FD1")]
		[Cpp2IlInjected.Address(RVA = "0x29EE040", Offset = "0x29ECA40", VA = "0x1829EE040", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003FD2")]
		[Cpp2IlInjected.Address(RVA = "0x29EE1B0", Offset = "0x29ECBB0", VA = "0x1829EE1B0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_013d
			if (subStepID_ != 0)
			{
				int value = subStepID_;
				output.WriteInt32(value);
			}
			if (stepName_.m_stringLength != 0)
			{
				string value2 = stepName_;
				output.WriteString(value2);
			}
			if (stepDescription_.m_stringLength != 0)
			{
				string value3 = stepDescription_;
				output.WriteString(value3);
			}
			if (showProgressionCount_)
			{
				bool value4 = showProgressionCount_;
				output.WriteBool(value4);
			}
			if (isOwnerFollowing_)
			{
				bool value5 = isOwnerFollowing_;
				output.WriteBool(value5);
			}
			if (follower_ != 0)
			{
				int value6 = follower_;
				output.WriteInt32(value6);
			}
			if (followingBarkDialogue_.m_stringLength != 0)
			{
				string value7 = followingBarkDialogue_;
				output.WriteString(value7);
			}
			if (skipStepWhenCompleted_)
			{
				bool value8 = skipStepWhenCompleted_;
				output.WriteBool(value8);
			}
			if (extraCase_ == ExtraOneofCase.BringItem && extraCase_ == ExtraOneofCase.BringItem)
			{
				object obj = extra_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			RepeatedField<MissionObjectiveData> repeatedField = objectives_;
			FieldCodec<MissionObjectiveData> repeated_objectives_codec = _repeated_objectives_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_objectives_codec);
			if (nextObjectiveID_ != 0)
			{
				int value9 = nextObjectiveID_;
				output.WriteInt32(value9);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003FD3")]
		[Cpp2IlInjected.Address(RVA = "0x29EBBD0", Offset = "0x29EA5D0", VA = "0x1829EBBD0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0130
			int num = subStepID_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			string text = stepName_;
			if (text.m_stringLength != num2)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text);
				num4++;
				num2 += num4;
			}
			string text2 = stepDescription_;
			if (text2.m_stringLength != num2)
			{
				int num5 = CodedOutputStream.ComputeStringSize(text2);
				num5++;
				num2 += num5;
			}
			int num6 = follower_;
			if (num6 != 0)
			{
				int num7 = CodedOutputStream.ComputeInt32Size(num6);
				num7++;
				num2 += num7;
			}
			string text3 = followingBarkDialogue_;
			if (text3.m_stringLength != num2)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text3);
				num8++;
				num2 += num8;
			}
			if (extraCase_ == ExtraOneofCase.BringItem)
			{
				if (extraCase_ == ExtraOneofCase.BringItem)
				{
					object obj = extra_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				num2++;
				int num9 = default(int);
				num2 += num9;
			}
			RepeatedField<MissionObjectiveData> repeatedField = objectives_;
			FieldCodec<MissionObjectiveData> repeated_objectives_codec = _repeated_objectives_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_objectives_codec);
			int num11 = nextObjectiveID_;
			num2 += num10;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12 += 2;
				num2 += num12;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num13 = unknownFields.CalculateSize();
				num2 += num13;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003FD4")]
		[Cpp2IlInjected.Address(RVA = "0x29ED730", Offset = "0x29EC130", VA = "0x1829ED730", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionSubStepData other)
		{
			//Discarded unreachable code: IL_018a
			if (other == null)
			{
				return;
			}
			int num = other.subStepID_;
			if (num != 0)
			{
				subStepID_ = num;
			}
			string text = other.stepName_;
			if (text.m_stringLength != 0)
			{
				StepName = text;
			}
			string text2 = other.stepDescription_;
			if (text2.m_stringLength != 0)
			{
				StepDescription = text2;
			}
			bool flag = other.showProgressionCount_;
			if (flag)
			{
				showProgressionCount_ = flag;
			}
			bool flag2 = other.isOwnerFollowing_;
			if (flag2)
			{
				isOwnerFollowing_ = flag2;
			}
			int num2 = other.follower_;
			if (num2 != 0)
			{
				follower_ = num2;
			}
			string text3 = other.followingBarkDialogue_;
			if (text3.m_stringLength != 0)
			{
				FollowingBarkDialogue = text3;
			}
			bool flag3 = other.skipStepWhenCompleted_;
			if (flag3)
			{
				skipStepWhenCompleted_ = flag3;
			}
			RepeatedField<MissionObjectiveData> repeatedField = objectives_;
			RepeatedField<MissionObjectiveData> repeatedField2 = other.objectives_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			int num3 = other.nextObjectiveID_;
			if (num3 != 0)
			{
				nextObjectiveID_ = num3;
			}
			if (other.extraCase_ == ExtraOneofCase.BringItem)
			{
				ExtraOneofCase extraOneofCase = extraCase_;
				object obj = default(object);
				if (extraOneofCase == ExtraOneofCase.BringItem)
				{
					obj = extra_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					Types.ExtraBringItem extraBringItem = (Types.ExtraBringItem)(extra_ = new Types.ExtraBringItem());
					extraCase_ = extraOneofCase;
				}
				if (extraCase_ == ExtraOneofCase.BringItem)
				{
					object obj2 = extra_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.extraCase_ == ExtraOneofCase.BringItem)
				{
					object obj3 = other.extra_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003FD5")]
		[Cpp2IlInjected.Address(RVA = "0x29ED9B0", Offset = "0x29EC3B0", VA = "0x1829ED9B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_0068: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 40)
			{
				if ((int)num > 64)
				{
					if (num == 82)
					{
						Types.ExtraBringItem extraBringItem = new Types.ExtraBringItem();
						if (extraCase_ == ExtraOneofCase.BringItem)
						{
							if (extraCase_ != ExtraOneofCase.BringItem)
							{
							}
							object obj = extra_;
							if (obj != null && obj == null)
							{
								throw new InvalidCastException();
							}
						}
						input.ReadMessage(extraBringItem);
						extra_ = extraBringItem;
						extraCase_ = (ExtraOneofCase)extraBringItem;
					}
					if (num == 402)
					{
						RepeatedField<MissionObjectiveData> repeatedField = objectives_;
						FieldCodec<MissionObjectiveData> repeated_objectives_codec = _repeated_objectives_codec;
						((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_objectives_codec);
					}
					if (num != 408)
					{
						goto IL_015f;
					}
					int num2 = (nextObjectiveID_ = input.ReadInt32());
				}
				int num3 = default(int);
				if (num == 48)
				{
					num3 = (follower_ = input.ReadInt32());
				}
				string text2 = default(string);
				if (num3 == 58)
				{
					text2 = (FollowingBarkDialogue = input.ReadString());
				}
				if ((long)text2 != 64)
				{
					goto IL_015f;
				}
				bool flag = (skipStepWhenCompleted_ = input.ReadBool());
			}
			bool flag3 = default(bool);
			if ((int)num > 18)
			{
				string text4 = default(string);
				if (num == 26)
				{
					text4 = (StepDescription = input.ReadString());
				}
				bool flag2 = default(bool);
				if ((long)text4 == 32)
				{
					flag2 = (showProgressionCount_ = input.ReadBool());
				}
				if (!flag2)
				{
					goto IL_015f;
				}
				flag3 = (isOwnerFollowing_ = input.ReadBool());
			}
			int num4 = default(int);
			if (flag3)
			{
				num4 = (subStepID_ = input.ReadInt32());
			}
			if (num4 == 18)
			{
				string text6 = (StepName = input.ReadString());
			}
			goto IL_015f;
			IL_015f:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003FD6")]
		[Cpp2IlInjected.Address(RVA = "0x29ED2F0", Offset = "0x29EBCF0", VA = "0x1829ED2F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 9)
			{
				int num = subStepID_;
			}
			if (fieldNumber == 50)
			{
				RepeatedField<MissionObjectiveData> repeatedField = objectives_;
			}
			if (fieldNumber == 51)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003FD7")]
		[Cpp2IlInjected.Address(RVA = "0x29EDC80", Offset = "0x29EC680", VA = "0x1829EDC80", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_002b, IL_0031, IL_0037, IL_003d, IL_0043, IL_0049, IL_004f
			//IL_000e: Expected I4, but got O
			//IL_002a: Expected I4, but got O
			if (fieldNumber - 1 <= 9)
			{
				object obj = default(object);
				subStepID_ = (int)obj;
				return;
			}
			if (fieldNumber != 50)
			{
				while (fieldNumber != 51)
				{
				}
				object obj2 = default(object);
				nextObjectiveID_ = (int)obj2;
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003FD8")]
		[Cpp2IlInjected.Address(RVA = "0x29EBE80", Offset = "0x29EA880", VA = "0x1829EBE80", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016, IL_0017, IL_0018, IL_002b
			if (fieldNumber - 1 <= 9)
			{
				int num = (subStepID_ = 0);
				return;
			}
			if (fieldNumber == 50)
			{
				RepeatedField<MissionObjectiveData> repeatedField = objectives_;
			}
			if (fieldNumber != 51)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003FD9")]
		[Cpp2IlInjected.Address(RVA = "0x29ED680", Offset = "0x29EC080", VA = "0x1829ED680", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Extra"))
			{
				ExtraOneofCase extraOneofCase = extraCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003FDA")]
		[Cpp2IlInjected.Address(RVA = "0x29EC010", Offset = "0x29EAA10", VA = "0x1829EC010", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Extra"))
			{
				extra_ = (extraCase_ = ExtraOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003FDC")]
		[Cpp2IlInjected.Address(RVA = "0x29EC0E0", Offset = "0x29EAAE0", VA = "0x1829EC0E0", Slot = "18")]
		public void DataValidation(DataValidation.Context context)
		{
			//IL_01c7: Expected O, but got I4
			//IL_01f0: Expected O, but got I4
			//IL_03b5: Expected O, but got I4
			int num = 0;
			string arg = default(string);
			if ((isOwnerFollowing_ ? 1 : 0) != num)
			{
				int num2 = follower_;
				if ((object)typeof(Item).TypeHandle != null)
				{
					MissionItemData parentOfType = context.GetParentOfType<MissionItemData>();
					if (parentOfType != null)
					{
						int ownerCharacter = parentOfType.OwnerCharacter;
					}
				}
				long num3 = Convert.ToInt64((uint)follower_);
				bool flag = default(bool);
				if (flag)
				{
					goto IL_0099;
				}
				long num4 = Convert.ToInt64((uint)follower_);
				bool flag2 = default(bool);
				if (flag2)
				{
					long num5 = Convert.ToInt64((uint)follower_);
					MissionItemData parentOfType2 = context.GetParentOfType<MissionItemData>();
					if (parentOfType2 != null)
					{
						int ownerCharacter2 = parentOfType2.OwnerCharacter;
					}
					if (num != 0 && num != 0)
					{
						string text = stepName_;
						arg = "Should be at (None) in " + text + " (do not manually select current owner)";
						goto IL_0099;
					}
				}
				goto IL_00be;
			}
			goto IL_011d;
			IL_0099:
			string arg2 = stepName_;
			string message = $"{arg2} cannot use HasFollower with AQUATIC npc ({arg})";
			context.AddInvalidMemberError(message, "IsOwnerFollowing");
			goto IL_00be;
			IL_00be:
			int num6 = follower_;
			if ((object)typeof(Item).TypeHandle != null)
			{
				RepeatedField<MissionObjectiveData> repeatedField = objectives_;
				Predicate<MissionObjectiveData> predicate = default(Predicate<MissionObjectiveData>);
				if (_003C_003Ec._003C_003E9__88_2 == null)
				{
					predicate = (Predicate<MissionObjectiveData>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((MissionObjectiveData obj) => obj.customStepCase_ == MissionObjectiveData.CustomStepOneofCase.FollowCharacter));
				}
				if (((RepeatedField<>)(object)repeatedField).Any<MissionObjectiveData>((Predicate<>)(object)predicate))
				{
					string error = stepName_ + " cannot contain mix FollowCharacter and HasFollower";
					context.AddError(error);
				}
			}
			goto IL_011d;
			IL_033b:
			if (BringItem.bringDialogueType_ == BringDialogueTypeOptions.Dialogue)
			{
				Types.ExtraBringItem bringItem = BringItem;
				string bringDialogue_ = bringItem.bringDialogue_;
				if (bringItem != null)
				{
					string text2 = stepName_;
					string error2 = "BringDialogue is missing in " + text2;
					context.AddError(error2);
				}
			}
			goto IL_037d;
			IL_037d:
			RepeatedField<MissionObjectiveData> repeatedField2 = objectives_;
			int num7 = nextObjectiveID_;
			int count = ((RepeatedField<T>)(object)repeatedField2).Count;
			if (num7 < count)
			{
				int count2 = ((RepeatedField<T>)(object)objectives_).Count;
				string message2 = $"Something went wrong, cannot be lower than {count2}";
				context.AddInvalidMemberError(message2, "NextObjectiveID");
			}
			RepeatedField<MissionObjectiveData> repeatedField3 = objectives_;
			Predicate<MissionObjectiveData> predicate2 = (Predicate<MissionObjectiveData>)(object)(Predicate<T>)delegate(MissionObjectiveData x)
			{
				//Discarded unreachable code: IL_0014
				int num12 = nextObjectiveID_;
				return x.objectiveID_ >= num12;
			};
			if (((RepeatedField<>)(object)repeatedField3).Any<MissionObjectiveData>((Predicate<>)(object)predicate2))
			{
				context.AddInvalidMemberError("Something went wrong, ids must be lower than NextObjectiveID", "ObjectiveID");
			}
			RepeatedField<MissionObjectiveData> repeatedField4 = objectives_;
			Predicate<MissionObjectiveData> predicate3 = (Predicate<MissionObjectiveData>)(object)(Predicate<T>)delegate(MissionObjectiveData x)
			{
				//Discarded unreachable code: IL_002c
				RepeatedField<MissionObjectiveData> repeatedField11 = objectives_;
				Func<MissionObjectiveData, bool> func = (Func<MissionObjectiveData, bool>)(object)(Func<T, TResult>)delegate(MissionObjectiveData y)
				{
					//Discarded unreachable code: IL_0016
					int objectiveID_ = x.objectiveID_;
					return y.objectiveID_ == objectiveID_;
				};
				return Enumerable.Count<MissionObjectiveData>((IEnumerable<>)(object)repeatedField11, (Func<, >)(object)func) > 1;
			};
			if (((RepeatedField<>)(object)repeatedField4).Any<MissionObjectiveData>((Predicate<>)(object)predicate3))
			{
				context.AddInvalidMemberError("Something went wrong, ids are not unique", "ObjectiveID");
			}
			string error3 = default(string);
			if (((RepeatedField<T>)(object)objectives_).Count == 1)
			{
				RepeatedField<MissionObjectiveData> repeatedField5 = objectives_;
				int index = 0;
				if (((MissionObjectiveData)((RepeatedField<T>)(object)repeatedField5)[index]).skipSubStepWhenCompleted_)
				{
					RepeatedField<MissionObjectiveData> repeatedField6 = objectives_;
					int index2 = 0;
					string text3 = ((MissionObjectiveData)((RepeatedField<T>)(object)repeatedField6)[index2]).stepName_;
					error3 = "[SkipStepWhenDone] Cannot be used in " + text3 + " (require multiple objectives)";
					context.AddError(error3);
				}
			}
			return;
			IL_011d:
			if (showProgressionCount_)
			{
				string text4 = stepDescription_;
				if ("Cannot be empty in " != null)
				{
					context.AddInvalidMemberError("Cannot be enable without StepDescription", "ShowProgressionCount");
				}
			}
			if (((RepeatedField<T>)(object)objectives_).Count < 1)
			{
			}
			MissionObjectiveData.CustomStepOneofCase customStepCase = Enumerable.First<MissionObjectiveData>((IEnumerable<>)(object)objectives_).customStepCase_;
			RepeatedField<MissionObjectiveData> repeatedField7 = objectives_;
			Predicate<MissionObjectiveData> predicate4 = (Predicate<MissionObjectiveData>)(object)(Predicate<T>)delegate(MissionObjectiveData x)
			{
				//Discarded unreachable code: IL_0014
				MissionObjectiveData.CustomStepOneofCase customStepOneofCase3 = customStepCase;
				return x.customStepCase_ != customStepOneofCase3;
			};
			bool flag3 = ((RepeatedField<>)(object)repeatedField7).Any<MissionObjectiveData>((Predicate<>)(object)predicate4);
			MissionObjectiveData.CustomStepOneofCase customStepOneofCase = customStepCase;
			OptionalField firstTarget;
			if (!flag3)
			{
				if (customStepOneofCase != MissionObjectiveData.CustomStepOneofCase.BringItem)
				{
					if (extraCase_ == ExtraOneofCase.None)
					{
						goto IL_037d;
					}
					string text5 = $"ExtraCase is incorrectly set for a {customStepOneofCase}, should be None (Editor Error)";
				}
				if (extraCase_ != ExtraOneofCase.BringItem)
				{
					string arg3 = stepName_;
					MissionObjectiveData.CustomStepOneofCase customStepOneofCase2 = default(MissionObjectiveData.CustomStepOneofCase);
					string error4 = $"ExtraCase is incorrectly set for a {customStepOneofCase2} in {arg3} (Editor Error)";
					context.AddError(error4);
				}
				int count3 = ((RepeatedField<T>)(object)objectives_).Count;
				RepeatedField<MissionObjectiveData> repeatedField8 = objectives_;
				Predicate<MissionObjectiveData> predicate5 = default(Predicate<MissionObjectiveData>);
				if (_003C_003Ec._003C_003E9__88_4 == null)
				{
					predicate5 = (Predicate<MissionObjectiveData>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(MissionObjectiveData x)
					{
						//Discarded unreachable code: IL_006f
						CustomStepBringItem bringItem3 = x.BringItem;
						int num11 = 0;
						if (bringItem3 != null)
						{
							AnyItemSelector targetItem_ = bringItem3.targetItem_;
							if (targetItem_ != null)
							{
								ItemSelector itemToGive_ = targetItem_.itemToGive_;
								if (itemToGive_ != null)
								{
									bool isVariableSelected = itemToGive_.IsVariableSelected;
								}
							}
							if (num11 != 1)
							{
								return true;
							}
						}
						CustomStepBringItem bringItem4 = x.BringItem;
						if (bringItem4 != null)
						{
							AnyItemSelector targetItem_2 = bringItem4.targetItem_;
							if (targetItem_2 != null)
							{
								ItemSelector itemToGive_2 = targetItem_2.itemToGive_;
								if (itemToGive_2 != null)
								{
									bool isItemGeneratorSelected = itemToGive_2.IsItemGeneratorSelected;
								}
							}
							return num11 == 1;
						}
						bool result = default(bool);
						return result;
					});
				}
				if (((RepeatedField<>)(object)repeatedField8).Any<MissionObjectiveData>((Predicate<>)(object)predicate5))
				{
					string text6 = stepName_;
					string error5 = "BringItem rules: Can only use 'ItemGenerator' when using multiple objectives in " + text6;
					context.AddError(error5);
				}
				firstTarget = Enumerable.First<MissionObjectiveData>((IEnumerable<>)(object)objectives_).BringItem.targetIsNotOwner_;
				RepeatedField<MissionObjectiveData> repeatedField9 = objectives_;
				Predicate<MissionObjectiveData> predicate6 = (Predicate<MissionObjectiveData>)(object)(Predicate<T>)delegate(MissionObjectiveData x)
				{
					//Discarded unreachable code: IL_0014
					OptionalField targetIsNotOwner_ = x.BringItem.targetIsNotOwner_;
					return IsDifferentTarget(targetIsNotOwner_);
				};
				if (((RepeatedField<>)(object)repeatedField9).Any<MissionObjectiveData>((Predicate<>)(object)predicate6))
				{
					string text7 = stepName_;
					string error6 = "BringItem rules: All TargetIsNotOwner should have same value in " + text7;
					context.AddError(error6);
				}
				Types.ExtraBringItem bringItem2 = BringItem;
				string readyDescription_ = bringItem2.readyDescription_;
				if (bringItem2 != null)
				{
					string text8 = stepDescription_;
					if (bringItem2 != null)
					{
						RepeatedField<MissionObjectiveData> repeatedField10 = objectives_;
						Predicate<MissionObjectiveData> predicate7 = default(Predicate<MissionObjectiveData>);
						if (_003C_003Ec._003C_003E9__88_7 == null)
						{
							predicate7 = (Predicate<MissionObjectiveData>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(MissionObjectiveData x)
							{
								//Discarded unreachable code: IL_000c
								string text11 = x.stepDescription_;
								return x == null;
							});
						}
						if (!((RepeatedField<>)(object)repeatedField10).Any<MissionObjectiveData>((Predicate<>)(object)predicate7))
						{
							goto IL_033b;
						}
					}
					string text9 = stepName_;
					string message3 = "Cannot be empty in " + text9 + ". Exception: When all other Step/BringItem descriptions are empty too";
					context.AddInvalidMemberError(message3, "ReadyDescription");
				}
				goto IL_033b;
			}
			string arg4 = stepName_;
			string text10 = $"All objectives of {arg4} must be {error3} (Editor Error)";
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6004003")]
			[Cpp2IlInjected.Address(RVA = "0x9EC9D0", Offset = "0x9EB3D0", VA = "0x1809EC9D0")]
			unsafe bool IsDifferentTarget(OptionalField other)
			{
				OptionalField optionalField = firstTarget;
				bool useField_ = other.useField_;
				if (useField_ == optionalField.useField_)
				{
					if (useField_)
					{
						bool random_ = other.random_;
						if (random_ != optionalField.random_)
						{
							goto IL_0076;
						}
						if (!random_)
						{
							CharacterList character = other.Character;
							if (character != null)
							{
								int targetCharacter = character.TargetCharacter;
								int num8 = 0;
							}
							int num9 = 0;
							CharacterList character2 = firstTarget.Character;
							if (character2 != null)
							{
								int targetCharacter2 = character2.TargetCharacter;
							}
							if (num9 != 0)
							{
								goto IL_0076;
							}
							if (num9 != 0)
							{
								return *(Item*)num9 != *(Item*)num9;
							}
						}
					}
					int num10 = 0;
					throw new NullReferenceException();
				}
				goto IL_0076;
				IL_0076:
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003FDD")]
		[Cpp2IlInjected.Address(RVA = "0x29EE490", Offset = "0x29ECE90", VA = "0x1829EE490")]
		static MissionSubStepData()
		{
			MessageParser<MissionObjectiveData> parser = MissionObjectiveData._parser;
			uint num = default(uint);
			_parser = (MessageParser<MissionSubStepData>)(object)FieldCodec.ForMessage<MissionObjectiveData>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
