using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20004D5")]
	public sealed class CustomStepFeedCritter : IMessage<CustomStepFeedCritter>, IMessage, IEquatable<CustomStepFeedCritter>, IDeepCloneable<CustomStepFeedCritter>, IMessageFieldAccessor, IMessageOneofAccessor, IStringTag, IItemSelector, IStepAmount, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x20004D6")]
		public enum ConditionOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x40019D0")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40019D1")]
			Location = 2
		}

		[Cpp2IlInjected.Token(Token = "0x20004D7")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20004D8")]
			public enum FeedAction
			{
				[Cpp2IlInjected.Token(Token = "0x40019D3")]
				[OriginalName("LikedItem")]
				LikedItem,
				[Cpp2IlInjected.Token(Token = "0x40019D4")]
				[OriginalName("FavoriteItem")]
				FavoriteItem,
				[Cpp2IlInjected.Token(Token = "0x40019D5")]
				[OriginalName("SpecificItem")]
				SpecificItem
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40019C4")]
		private static readonly MessageParser<CustomStepFeedCritter> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40019C5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40019C6")]
		public const int LocationFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40019C7")]
		public const int ActionFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40019C8")]
		private Types.FeedAction action_;

		[Cpp2IlInjected.Token(Token = "0x40019C9")]
		public const int FeedItemFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40019CA")]
		private AnyItemSelector feedItem_;

		[Cpp2IlInjected.Token(Token = "0x40019CB")]
		public const int TargetAmountFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40019CC")]
		private StepAmount targetAmount_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40019CD")]
		private object condition_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40019CE")]
		private ConditionOneofCase conditionCase_;

		[Cpp2IlInjected.Token(Token = "0x17000F3B")]
		[DebuggerNonUserCode]
		public static MessageParser<CustomStepFeedCritter> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003B81")]
			[Cpp2IlInjected.Address(RVA = "0x34E3020", Offset = "0x34E1A20", VA = "0x1834E3020")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F3C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003B82")]
			[Cpp2IlInjected.Address(RVA = "0x34E2EE0", Offset = "0x34E18E0", VA = "0x1834E2EE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F3D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003B83")]
			[Cpp2IlInjected.Address(RVA = "0x34E3300", Offset = "0x34E1D00", VA = "0x1834E3300", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F3E")]
		[DebuggerNonUserCode]
		public VillageAreaType Location
		{
			[Cpp2IlInjected.Token(Token = "0x6003B88")]
			[Cpp2IlInjected.Address(RVA = "0x34E2FB0", Offset = "0x34E19B0", VA = "0x1834E2FB0")]
			get
			{
				if (conditionCase_ == ConditionOneofCase.Location)
				{
					object obj = condition_;
				}
				int num = 0;
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003B89")]
			[Cpp2IlInjected.Address(RVA = "0x34E3410", Offset = "0x34E1E10", VA = "0x1834E3410")]
			set
			{
				//IL_0016: Expected I4, but got I8
				condition_ = typeof(VillageAreaType).TypeHandle;
				conditionCase_ = ConditionOneofCase.Location;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F3F")]
		[DebuggerNonUserCode]
		public Types.FeedAction Action
		{
			[Cpp2IlInjected.Token(Token = "0x6003B8A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return action_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B8B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				action_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F40")]
		[DebuggerNonUserCode]
		public AnyItemSelector FeedItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003B8C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return feedItem_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B8D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				feedItem_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F41")]
		[DebuggerNonUserCode]
		public StepAmount TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003B8E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return targetAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003B8F")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				targetAmount_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F42")]
		[DebuggerNonUserCode]
		public ConditionOneofCase ConditionCase
		{
			[Cpp2IlInjected.Token(Token = "0x6003B90")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return conditionCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F43")]
		public string[] StringVariableNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003B9F")]
			[Cpp2IlInjected.Address(RVA = "0x34E3080", Offset = "0x34E1A80", VA = "0x1834E3080", Slot = "16")]
			get
			{
				//Discarded unreachable code: IL_0098
				string[] array;
				while (true)
				{
					array = new string[5];
					if ("ItemName" != null && "ItemName" == null)
					{
						continue;
					}
					array[0] = "ItemName";
					if ("CritterName" != null && "CritterName" == null)
					{
						continue;
					}
					array[1] = "CritterName";
					if ("TargetAmount" != null && "TargetAmount" == null)
					{
						continue;
					}
					array[2] = "TargetAmount";
					if ("CurrentAmount" == null || "CurrentAmount" != null)
					{
						array[3] = "CurrentAmount";
						if ("Location" == null || "Location" != null)
						{
							break;
						}
					}
				}
				array[4] = "Location";
				return array;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F44")]
		public ItemSelector ItemSelector
		{
			[Cpp2IlInjected.Token(Token = "0x6003BA0")]
			[Cpp2IlInjected.Address(RVA = "0x2D4AD40", Offset = "0x2D49740", VA = "0x182D4AD40", Slot = "17")]
			get
			{
				//Discarded unreachable code: IL_000c
				return feedItem_.itemToGive_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000F45")]
		public StepAmount StepAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6003BA1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "18")]
			get
			{
				return targetAmount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B84")]
		[Cpp2IlInjected.Address(RVA = "0x34E2CC0", Offset = "0x34E16C0", VA = "0x1834E2CC0")]
		[DebuggerNonUserCode]
		public CustomStepFeedCritter()
		{
			AnyItemSelector anyItemSelector = (feedItem_ = new AnyItemSelector());
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B85")]
		[Cpp2IlInjected.Address(RVA = "0x34E2820", Offset = "0x34E1220", VA = "0x1834E2820")]
		private void OnConstruction()
		{
			AnyItemSelector anyItemSelector = (feedItem_ = new AnyItemSelector());
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B86")]
		[Cpp2IlInjected.Address(RVA = "0x34E2D60", Offset = "0x34E1760", VA = "0x1834E2D60")]
		[DebuggerNonUserCode]
		public CustomStepFeedCritter(CustomStepFeedCritter other)
		{
			//IL_004d: Expected O, but got I4
			//IL_0090: Expected I4, but got I8
			AnyItemSelector anyItemSelector = (feedItem_ = new AnyItemSelector());
			StepAmount stepAmount = (targetAmount_ = new StepAmount());
			Types.FeedAction feedAction = other.action_;
			int num = 0;
			action_ = feedAction;
			AnyItemSelector anyItemSelector2 = other.feedItem_;
			if (anyItemSelector2 != null)
			{
				AnyItemSelector anyItemSelector3 = anyItemSelector2.Clone();
			}
			feedItem_ = (AnyItemSelector)num;
			StepAmount stepAmount2 = other.targetAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			targetAmount_ = stepAmount3;
			if (other.conditionCase_ == ConditionOneofCase.Location)
			{
				int location = (int)other.Location;
				condition_ = typeof(VillageAreaType).TypeHandle;
				conditionCase_ = ConditionOneofCase.Location;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B87")]
		[Cpp2IlInjected.Address(RVA = "0x34E1E60", Offset = "0x34E0860", VA = "0x1834E1E60", Slot = "10")]
		[DebuggerNonUserCode]
		public CustomStepFeedCritter Clone()
		{
			//Discarded unreachable code: IL_00a9
			//IL_004f: Expected O, but got I4
			//IL_0092: Expected I4, but got I8
			CustomStepFeedCritter customStepFeedCritter = new CustomStepFeedCritter();
			AnyItemSelector anyItemSelector = (customStepFeedCritter.feedItem_ = new AnyItemSelector());
			StepAmount stepAmount = (customStepFeedCritter.targetAmount_ = new StepAmount());
			Types.FeedAction feedAction = action_;
			int num = 0;
			customStepFeedCritter.action_ = feedAction;
			AnyItemSelector anyItemSelector2 = feedItem_;
			if (anyItemSelector2 != null)
			{
				AnyItemSelector anyItemSelector3 = anyItemSelector2.Clone();
			}
			customStepFeedCritter.feedItem_ = (AnyItemSelector)num;
			StepAmount stepAmount2 = targetAmount_;
			StepAmount stepAmount3 = default(StepAmount);
			if (stepAmount2 != null)
			{
				stepAmount3 = stepAmount2.Clone();
			}
			customStepFeedCritter.targetAmount_ = stepAmount3;
			if (conditionCase_ == ConditionOneofCase.Location)
			{
				int location = (int)Location;
				customStepFeedCritter.condition_ = typeof(VillageAreaType).TypeHandle;
				customStepFeedCritter.conditionCase_ = ConditionOneofCase.Location;
			}
			UnknownFieldSet unknownFieldSet = (customStepFeedCritter._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return customStepFeedCritter;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B91")]
		[Cpp2IlInjected.Address(RVA = "0x18A7A50", Offset = "0x18A6450", VA = "0x1818A7A50")]
		[DebuggerNonUserCode]
		public void ClearCondition()
		{
			//IL_0010: Expected O, but got I4
			condition_ = (conditionCase_ = ConditionOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B92")]
		[Cpp2IlInjected.Address(RVA = "0x34E2160", Offset = "0x34E0B60", VA = "0x1834E2160", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_002e: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				VillageAreaType location = Location;
				int num = 0;
				VillageAreaType villageAreaType = default(VillageAreaType);
				if (location == villageAreaType && action_ == (Types.FeedAction)villageAreaType && object.Equals(feedItem_, num))
				{
					bool flag = object.Equals(targetAmount_, num);
					if (flag && conditionCase_ == (flag ? ((ConditionOneofCase)1) : ConditionOneofCase.None))
					{
						return object.Equals(_unknownFields, num);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B93")]
		[Cpp2IlInjected.Address(RVA = "0x34E20B0", Offset = "0x34E0AB0", VA = "0x1834E20B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CustomStepFeedCritter other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int location = (int)Location;
				VillageAreaType location2 = other.Location;
				if (location == (int)location2)
				{
					Types.FeedAction feedAction = other.action_;
					if (action_ == feedAction)
					{
						AnyItemSelector objB = other.feedItem_;
						if (object.Equals(feedItem_, objB))
						{
							StepAmount objB2 = other.targetAmount_;
							if (object.Equals(targetAmount_, objB2))
							{
								ConditionOneofCase conditionOneofCase = other.conditionCase_;
								if (conditionCase_ == conditionOneofCase)
								{
									UnknownFieldSet unknownFields = other._unknownFields;
									return object.Equals(_unknownFields, unknownFields);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B94")]
		[Cpp2IlInjected.Address(RVA = "0x34E2350", Offset = "0x34E0D50", VA = "0x1834E2350", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_006c
			//IL_0021: Expected O, but got I4
			int num = 0;
			if (conditionCase_ == ConditionOneofCase.Location)
			{
				if (conditionCase_ == ConditionOneofCase.Location)
				{
					object obj = condition_;
				}
				System.Net.Http.Headers.Token.Type type = (System.Net.Http.Headers.Token)num;
			}
			if (action_ != 0)
			{
			}
			AnyItemSelector anyItemSelector = feedItem_;
			if (anyItemSelector != null)
			{
				int hashCode = anyItemSelector.GetHashCode();
			}
			StepAmount stepAmount = targetAmount_;
			if (stepAmount != null)
			{
				int hashCode2 = stepAmount.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B95")]
		[Cpp2IlInjected.Address(RVA = "0x34E2A60", Offset = "0x34E1460", VA = "0x1834E2A60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B96")]
		[Cpp2IlInjected.Address(RVA = "0x34E2AC0", Offset = "0x34E14C0", VA = "0x1834E2AC0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0065
			if (conditionCase_ == ConditionOneofCase.Location)
			{
				int location = (int)Location;
				output.WriteInt32(location);
			}
			if (action_ != 0)
			{
			}
			if ((long)feedItem_ != 0)
			{
				AnyItemSelector value = feedItem_;
				output.WriteMessage(value);
			}
			if ((long)targetAmount_ != 0)
			{
				StepAmount value2 = targetAmount_;
				output.WriteMessage(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B97")]
		[Cpp2IlInjected.Address(RVA = "0x34E1BC0", Offset = "0x34E05C0", VA = "0x1834E1BC0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_009f
			int num = 0;
			if (conditionCase_ == ConditionOneofCase.Location)
			{
				if (conditionCase_ == ConditionOneofCase.Location)
				{
					object obj = condition_;
				}
				int num2 = CodedOutputStream.ComputeEnumSize(num);
			}
			Types.FeedAction feedAction = action_;
			if (feedAction != 0)
			{
				int num3 = CodedOutputStream.ComputeEnumSize((int)feedAction);
				num3++;
				num += num3;
			}
			AnyItemSelector anyItemSelector = feedItem_;
			if (anyItemSelector != null)
			{
				int num4 = CodedOutputStream.ComputeMessageSize(anyItemSelector);
				num4++;
				num += num4;
			}
			StepAmount stepAmount = targetAmount_;
			if (stepAmount != null)
			{
				int num5 = CodedOutputStream.ComputeMessageSize(stepAmount);
				num5++;
				num += num5;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B98")]
		[Cpp2IlInjected.Address(RVA = "0x34E2520", Offset = "0x34E0F20", VA = "0x1834E2520", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CustomStepFeedCritter other)
		{
			//Discarded unreachable code: IL_00bc
			if (other == null)
			{
				return;
			}
			Types.FeedAction feedAction = other.action_;
			if (feedAction != 0)
			{
				action_ = feedAction;
			}
			if ((long)other.feedItem_ != 0)
			{
				AnyItemSelector anyItemSelector2 = default(AnyItemSelector);
				if (feedItem_ == null)
				{
					AnyItemSelector anyItemSelector = (feedItem_ = new AnyItemSelector());
					anyItemSelector2 = feedItem_;
				}
				AnyItemSelector other2 = other.feedItem_;
				anyItemSelector2.MergeFrom(other2);
			}
			if ((long)other.targetAmount_ != 0)
			{
				StepAmount stepAmount2 = default(StepAmount);
				if (targetAmount_ == null)
				{
					StepAmount stepAmount = (targetAmount_ = new StepAmount());
					stepAmount2 = targetAmount_;
				}
				StepAmount other3 = other.targetAmount_;
				stepAmount2.MergeFrom(other3);
			}
			if (other.conditionCase_ == ConditionOneofCase.Location)
			{
				VillageAreaType location = other.Location;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6003B99")]
		[Cpp2IlInjected.Address(RVA = "0x34E2670", Offset = "0x34E1070", VA = "0x1834E2670", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00b2
			//IL_007c: Expected O, but got I4
			//IL_0085: Expected I4, but got I8
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 80)
			{
				if (num == 90)
				{
					AnyItemSelector anyItemSelector = feedItem_;
					if (anyItemSelector == null)
					{
						AnyItemSelector anyItemSelector2 = (feedItem_ = new AnyItemSelector());
					}
					input.ReadMessage(anyItemSelector);
				}
				if (num != 98)
				{
					goto IL_009b;
				}
				StepAmount builder = default(StepAmount);
				if (targetAmount_ == null)
				{
					StepAmount stepAmount = (targetAmount_ = new StepAmount());
					builder = targetAmount_;
				}
				input.ReadMessage(builder);
			}
			int num2 = default(int);
			if (num == 16)
			{
				num2 = input.ReadInt32();
				condition_ = num2;
				conditionCase_ = ConditionOneofCase.Location;
			}
			if (num2 == 80)
			{
				int num3 = (int)(action_ = (Types.FeedAction)input.ReadInt32());
			}
			goto IL_009b;
			IL_009b:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6003B9A")]
		[Cpp2IlInjected.Address(RVA = "0x34E2250", Offset = "0x34E0C50", VA = "0x1834E2250", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 2)
			{
				VillageAreaType location = Location;
			}
			if ((object)typeof(VillageAreaType).TypeHandle != null)
			{
				if ((object)typeof(VillageAreaType).TypeHandle != null)
				{
					if ((long)typeof(VillageAreaType).TypeHandle != 1)
					{
						goto IL_003a;
					}
					StepAmount stepAmount = targetAmount_;
				}
				AnyItemSelector anyItemSelector = feedItem_;
			}
			Types.FeedAction feedAction = action_;
			goto IL_003a;
			IL_003a:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B9B")]
		[Cpp2IlInjected.Address(RVA = "0x34E28B0", Offset = "0x34E12B0", VA = "0x1834E28B0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_004b, IL_0057
			//IL_0018: Expected I4, but got I8
			if (fieldNumber == 2)
			{
				condition_ = typeof(VillageAreaType).TypeHandle;
				conditionCase_ = ConditionOneofCase.Location;
			}
			else if ((object)typeof(VillageAreaType).TypeHandle != null && (object)typeof(VillageAreaType).TypeHandle != null)
			{
				if ((long)typeof(VillageAreaType).TypeHandle == 1)
				{
					if (value != null && value == null)
					{
						throw new InvalidCastException();
					}
					targetAmount_ = (StepAmount)value;
				}
			}
			else
			{
				action_ = Types.FeedAction.LikedItem;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B9C")]
		[Cpp2IlInjected.Address(RVA = "0x34E1D40", Offset = "0x34E0740", VA = "0x1834E1D40", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000b: Expected O, but got I4
			//IL_0014: Expected I4, but got I8
			//IL_002c: Expected I4, but got I8
			if (fieldNumber == 2)
			{
				VillageAreaType villageAreaType = default(VillageAreaType);
				condition_ = villageAreaType;
				conditionCase_ = ConditionOneofCase.Location;
			}
			else if (this == null || this == null || (long)this == 1)
			{
				action_ = Types.FeedAction.LikedItem;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B9D")]
		[Cpp2IlInjected.Address(RVA = "0x34E2470", Offset = "0x34E0E70", VA = "0x1834E2470", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "Condition"))
			{
				ConditionOneofCase conditionOneofCase = conditionCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B9E")]
		[Cpp2IlInjected.Address(RVA = "0x34E1DF0", Offset = "0x34E07F0", VA = "0x1834E1DF0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "Condition"))
			{
				condition_ = (conditionCase_ = ConditionOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BA2")]
		[Cpp2IlInjected.Address(RVA = "0x34E2010", Offset = "0x34E0A10", VA = "0x1834E2010", Slot = "19")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_002f
			if (targetAmount_.IsValueSmallerThen(1))
			{
				string missionStepName = context.MissionStepName;
				string message = "Should be 1+ in " + missionStepName;
				context.AddInvalidMemberError(message, "TargetAmount");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BA3")]
		[Cpp2IlInjected.Address(RVA = "0x34E2BB0", Offset = "0x34E15B0", VA = "0x1834E2BB0")]
		static CustomStepFeedCritter()
		{
			Func<CustomStepFeedCritter> func = default(Func<CustomStepFeedCritter>);
			_parser = (MessageParser<CustomStepFeedCritter>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
