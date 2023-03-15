using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Meta.Missions;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20008DB")]
	public sealed class BattlePassProgress : IMessage<BattlePassProgress>, IMessage, IEquatable<BattlePassProgress>, IDeepCloneable<BattlePassProgress>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40023CA")]
		private static readonly MessageParser<BattlePassProgress> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40023CB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40023CC")]
		public const int TasksProgressFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40023CD")]
		private static readonly FieldCodec<BattlePassTaskProgress> _repeated_tasksProgress_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023CE")]
		private readonly RepeatedField<BattlePassTaskProgress> tasksProgress_;

		[Cpp2IlInjected.Token(Token = "0x40023CF")]
		public const int ActiveTaskCountFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40023D0")]
		private int activeTaskCount_;

		[Cpp2IlInjected.Token(Token = "0x40023D1")]
		public const int CurrencyAmountFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40023D2")]
		private int currencyAmount_;

		[Cpp2IlInjected.Token(Token = "0x40023D3")]
		public const int IsNewFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40023D4")]
		private bool isNew_;

		[Cpp2IlInjected.Token(Token = "0x40023D5")]
		public const int IsPremiumActiveFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40023D6")]
		private bool isPremiumActive_;

		[Cpp2IlInjected.Token(Token = "0x40023D7")]
		public const int IsBundleBoughtFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x40023D8")]
		private bool isBundleBought_;

		[Cpp2IlInjected.Token(Token = "0x40023D9")]
		public const int IsRewardPurchasedFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x40023DA")]
		private static readonly FieldCodec<bool> _repeated_isRewardPurchased_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40023DB")]
		private readonly RepeatedField<bool> isRewardPurchased_;

		[Cpp2IlInjected.Token(Token = "0x40023DC")]
		public const int EndDateFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40023DD")]
		private Timestamp endDate_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40023E3")]
		private bool isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000CEC")]
		[DebuggerNonUserCode]
		public static MessageParser<BattlePassProgress> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004C41")]
			[Cpp2IlInjected.Address(RVA = "0x1ABC1A0", Offset = "0x1ABABA0", VA = "0x181ABC1A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CED")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004C42")]
			[Cpp2IlInjected.Address(RVA = "0x1ABC090", Offset = "0x1ABAA90", VA = "0x181ABC090")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CEE")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004C43")]
			[Cpp2IlInjected.Address(RVA = "0x1ABC200", Offset = "0x1ABAC00", VA = "0x181ABC200", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CEF")]
		[DebuggerNonUserCode]
		public RepeatedField<BattlePassTaskProgress> TasksProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6004C47")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return tasksProgress_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF0")]
		[DebuggerNonUserCode]
		public int ActiveTaskCount
		{
			[Cpp2IlInjected.Token(Token = "0x6004C48")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return activeTaskCount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C49")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				activeTaskCount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF1")]
		[DebuggerNonUserCode]
		public int CurrencyAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6004C4A")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return currencyAmount_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C4B")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				currencyAmount_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF2")]
		[DebuggerNonUserCode]
		public bool IsNew
		{
			[Cpp2IlInjected.Token(Token = "0x6004C4C")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return isNew_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C4D")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				isNew_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF3")]
		[DebuggerNonUserCode]
		public bool IsPremiumActive
		{
			[Cpp2IlInjected.Token(Token = "0x6004C4E")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
			get
			{
				return isPremiumActive_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C4F")]
			[Cpp2IlInjected.Address(RVA = "0xDC79B0", Offset = "0xDC63B0", VA = "0x180DC79B0")]
			set
			{
				isPremiumActive_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF4")]
		[DebuggerNonUserCode]
		public bool IsBundleBought
		{
			[Cpp2IlInjected.Token(Token = "0x6004C50")]
			[Cpp2IlInjected.Address(RVA = "0xDC7980", Offset = "0xDC6380", VA = "0x180DC7980")]
			get
			{
				return isBundleBought_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C51")]
			[Cpp2IlInjected.Address(RVA = "0xDC79A0", Offset = "0xDC63A0", VA = "0x180DC79A0")]
			set
			{
				isBundleBought_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF5")]
		[DebuggerNonUserCode]
		public RepeatedField<bool> IsRewardPurchased
		{
			[Cpp2IlInjected.Token(Token = "0x6004C52")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return isRewardPurchased_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF6")]
		[DebuggerNonUserCode]
		public Timestamp EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x6004C53")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return endDate_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C54")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				endDate_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF7")]
		public Profile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x6004C60")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C61")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF8")]
		public ProfileEventDispatcher Dispatcher
		{
			[Cpp2IlInjected.Token(Token = "0x6004C62")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CDispatcher_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C63")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			private set
			{
				_003CDispatcher_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CF9")]
		public ITransactionContext Context
		{
			[Cpp2IlInjected.Token(Token = "0x6004C64")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CContext_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C65")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			private set
			{
				_003CContext_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CFA")]
		public string OnlineId
		{
			[Cpp2IlInjected.Token(Token = "0x6004C66")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003COnlineId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C67")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			private set
			{
				_003COnlineId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CFB")]
		public int MaxActivateTaskCount
		{
			[Cpp2IlInjected.Token(Token = "0x6004C68")]
			[Cpp2IlInjected.Address(RVA = "0x1ABC160", Offset = "0x1ABAB60", VA = "0x181ABC160")]
			get
			{
				//Discarded unreachable code: IL_001e
				BattlePassSeasonData battlePassSeasonData = Data;
				if (isPremiumActive_)
				{
					return battlePassSeasonData.premiumActiveTaskCount_;
				}
				return battlePassSeasonData.freeActiveTaskCount_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000CFC")]
		public BattlePassSeasonData Data
		{
			[Cpp2IlInjected.Token(Token = "0x6004C6C")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004C6D")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			private set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C44")]
		[Cpp2IlInjected.Address(RVA = "0x1ABBEC0", Offset = "0x1ABA8C0", VA = "0x181ABBEC0")]
		[DebuggerNonUserCode]
		public BattlePassProgress()
		{
			tasksProgress_ = (RepeatedField<BattlePassTaskProgress>)(object)new RepeatedField<T>();
			isRewardPurchased_ = (RepeatedField<bool>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C45")]
		[Cpp2IlInjected.Address(RVA = "0x1ABBF80", Offset = "0x1ABA980", VA = "0x181ABBF80")]
		[DebuggerNonUserCode]
		public BattlePassProgress(BattlePassProgress other)
		{
			//IL_0093: Expected O, but got I4
			RepeatedField<BattlePassTaskProgress> repeatedField = (tasksProgress_ = (RepeatedField<BattlePassTaskProgress>)(object)((RepeatedField<T>)(object)other.tasksProgress_).Clone());
			int num = (activeTaskCount_ = other.activeTaskCount_);
			int num2 = (currencyAmount_ = other.currencyAmount_);
			bool flag = (isNew_ = other.isNew_);
			bool flag2 = (isPremiumActive_ = other.isPremiumActive_);
			bool flag3 = (isBundleBought_ = other.isBundleBought_);
			RepeatedField<bool> repeatedField2 = (isRewardPurchased_ = (RepeatedField<bool>)(object)((RepeatedField<T>)(object)other.isRewardPurchased_).Clone());
			Timestamp timestamp = other.endDate_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num3 = 0;
			endDate_ = (Timestamp)num3;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C46")]
		[Cpp2IlInjected.Address(RVA = "0x1AB9EF0", Offset = "0x1AB88F0", VA = "0x181AB9EF0", Slot = "10")]
		[DebuggerNonUserCode]
		public BattlePassProgress Clone()
		{
			//Discarded unreachable code: IL_00b2
			//IL_009b: Expected O, but got I4
			BattlePassProgress battlePassProgress = new BattlePassProgress();
			RepeatedField<BattlePassTaskProgress> repeatedField = (battlePassProgress.tasksProgress_ = (RepeatedField<BattlePassTaskProgress>)(object)((RepeatedField<T>)(object)tasksProgress_).Clone());
			int num = (battlePassProgress.activeTaskCount_ = activeTaskCount_);
			int num2 = (battlePassProgress.currencyAmount_ = currencyAmount_);
			bool flag = (battlePassProgress.isNew_ = isNew_);
			bool flag2 = (battlePassProgress.isPremiumActive_ = isPremiumActive_);
			bool flag3 = (battlePassProgress.isBundleBought_ = isBundleBought_);
			RepeatedField<bool> repeatedField2 = (battlePassProgress.isRewardPurchased_ = (RepeatedField<bool>)(object)((RepeatedField<T>)(object)isRewardPurchased_).Clone());
			Timestamp timestamp = endDate_;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			int num3 = 0;
			battlePassProgress.endDate_ = (Timestamp)num3;
			UnknownFieldSet unknownFieldSet = (battlePassProgress._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return battlePassProgress;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C55")]
		[Cpp2IlInjected.Address(RVA = "0x1ABA140", Offset = "0x1AB8B40", VA = "0x181ABA140", Slot = "0")]
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
				RepeatedField<BattlePassTaskProgress> repeatedField = tasksProgress_;
				bool flag = default(bool);
				if (flag && activeTaskCount_ == (flag ? 1 : 0) && currencyAmount_ == (flag ? 1 : 0) && isNew_ == flag && isPremiumActive_ == flag && isBundleBought_ == flag)
				{
					RepeatedField<bool> repeatedField2 = isRewardPurchased_;
					bool flag2 = default(bool);
					if (flag2 && object.Equals(endDate_, other))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C56")]
		[Cpp2IlInjected.Address(RVA = "0x1ABA030", Offset = "0x1AB8A30", VA = "0x181ABA030", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattlePassProgress other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<BattlePassTaskProgress> repeatedField = tasksProgress_;
				RepeatedField<BattlePassTaskProgress> repeatedField2 = other.tasksProgress_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					int num = other.activeTaskCount_;
					if (activeTaskCount_ == num)
					{
						int num2 = other.currencyAmount_;
						if (currencyAmount_ == num2)
						{
							bool flag = other.isNew_;
							if (isNew_ == flag)
							{
								bool flag2 = other.isPremiumActive_;
								if (isPremiumActive_ == flag2)
								{
									bool flag3 = other.isBundleBought_;
									if (isBundleBought_ == flag3)
									{
										RepeatedField<bool> repeatedField3 = isRewardPurchased_;
										RepeatedField<bool> repeatedField4 = other.isRewardPurchased_;
										if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
										{
											Timestamp objB = other.endDate_;
											if (object.Equals(endDate_, objB))
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
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C57")]
		[Cpp2IlInjected.Address(RVA = "0x1ABA430", Offset = "0x1AB8E30", VA = "0x181ABA430", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0078
			int hashCode = ((RepeatedField<T>)(object)tasksProgress_).GetHashCode();
			if (activeTaskCount_ != 0)
			{
			}
			if (currencyAmount_ != 0)
			{
			}
			if (isNew_)
			{
			}
			if (isPremiumActive_)
			{
			}
			if (isBundleBought_)
			{
			}
			int hashCode2 = ((RepeatedField<T>)(object)isRewardPurchased_).GetHashCode();
			Timestamp timestamp = endDate_;
			if (timestamp != null)
			{
				int hashCode3 = timestamp.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode4 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C58")]
		[Cpp2IlInjected.Address(RVA = "0x1ABBA10", Offset = "0x1ABA410", VA = "0x181ABBA10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C59")]
		[Cpp2IlInjected.Address(RVA = "0x1ABBAB0", Offset = "0x1ABA4B0", VA = "0x181ABBAB0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00d8
			RepeatedField<BattlePassTaskProgress> repeatedField = tasksProgress_;
			FieldCodec<BattlePassTaskProgress> repeated_tasksProgress_codec = _repeated_tasksProgress_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_tasksProgress_codec);
			if (activeTaskCount_ != 0)
			{
				int value = activeTaskCount_;
				output.WriteInt32(value);
			}
			if (currencyAmount_ != 0)
			{
				int value2 = currencyAmount_;
				output.WriteInt32(value2);
			}
			if (isNew_)
			{
				bool value3 = isNew_;
				output.WriteBool(value3);
			}
			if (isPremiumActive_)
			{
				bool value4 = isPremiumActive_;
				output.WriteBool(value4);
			}
			if (isBundleBought_)
			{
				bool value5 = isBundleBought_;
				output.WriteBool(value5);
			}
			RepeatedField<bool> repeatedField2 = isRewardPurchased_;
			FieldCodec<bool> repeated_isRewardPurchased_codec = _repeated_isRewardPurchased_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_isRewardPurchased_codec);
			if ((long)endDate_ != 0)
			{
				Timestamp value6 = endDate_;
				output.WriteMessage(value6);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C5A")]
		[Cpp2IlInjected.Address(RVA = "0x1AB9C00", Offset = "0x1AB8600", VA = "0x181AB9C00", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Expected O, but got Unknown
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected O, but got Unknown
			RepeatedField<BattlePassTaskProgress> repeatedField = tasksProgress_;
			FieldCodec<BattlePassTaskProgress> repeated_tasksProgress_codec = _repeated_tasksProgress_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_tasksProgress_codec);
			int num2 = activeTaskCount_;
			if (num2 != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num2);
				num3++;
				num += num3;
			}
			int num4 = currencyAmount_;
			int num5 = default(int);
			if (num4 != 0)
			{
				num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num += num5;
			}
			if (!isNew_)
			{
				num5 = num;
			}
			if (!isPremiumActive_)
			{
				num4 = num5;
			}
			RepeatedField<bool> repeatedField2 = isRewardPurchased_;
			FieldCodec<bool> repeated_isRewardPurchased_codec = _repeated_isRewardPurchased_codec;
			int num6 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_isRewardPurchased_codec);
			Timestamp timestamp = endDate_;
			if (timestamp != null)
			{
				int num7 = CodedOutputStream.ComputeMessageSize(timestamp);
				num7++;
				repeatedField2 = (RepeatedField<bool>)(repeatedField2 + num7);
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num8 = unknownFields.CalculateSize();
				repeatedField2 = (RepeatedField<bool>)(repeatedField2 + num8);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C5B")]
		[Cpp2IlInjected.Address(RVA = "0x1ABAB50", Offset = "0x1AB9550", VA = "0x181ABAB50", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattlePassProgress other)
		{
			//Discarded unreachable code: IL_00f4
			if (other == null)
			{
				return;
			}
			RepeatedField<BattlePassTaskProgress> repeatedField = tasksProgress_;
			RepeatedField<BattlePassTaskProgress> repeatedField2 = other.tasksProgress_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			int num = other.activeTaskCount_;
			if (num != 0)
			{
				activeTaskCount_ = num;
			}
			int num2 = other.currencyAmount_;
			if (num2 != 0)
			{
				currencyAmount_ = num2;
			}
			bool flag = other.isNew_;
			if (flag)
			{
				isNew_ = flag;
			}
			bool flag2 = other.isPremiumActive_;
			if (flag2)
			{
				isPremiumActive_ = flag2;
			}
			bool flag3 = other.isBundleBought_;
			if (flag3)
			{
				isBundleBought_ = flag3;
			}
			RepeatedField<bool> repeatedField3 = isRewardPurchased_;
			RepeatedField<bool> repeatedField4 = other.isRewardPurchased_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			if ((long)other.endDate_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (endDate_ == null)
				{
					Timestamp timestamp = (endDate_ = new Timestamp());
					timestamp2 = endDate_;
				}
				Timestamp other2 = other.endDate_;
				timestamp2.MergeFrom(other2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004C5C")]
		[Cpp2IlInjected.Address(RVA = "0x1ABACA0", Offset = "0x1AB96A0", VA = "0x181ABACA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0114
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 32)
			{
				if ((int)num > 48)
				{
					if ((long)input != 4294967293L)
					{
						if (num != 66)
						{
							goto IL_00fd;
						}
						Timestamp timestamp = endDate_;
						if (timestamp == null)
						{
							Timestamp timestamp2 = (endDate_ = new Timestamp());
						}
						input.ReadMessage(timestamp);
					}
					RepeatedField<bool> repeatedField = isRewardPurchased_;
					FieldCodec<bool> repeated_isRewardPurchased_codec = _repeated_isRewardPurchased_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_isRewardPurchased_codec);
				}
				bool flag = default(bool);
				if (num == 40)
				{
					flag = (isPremiumActive_ = input.ReadBool());
				}
				if (!flag)
				{
					goto IL_00fd;
				}
				bool flag2 = (isBundleBought_ = input.ReadBool());
			}
			bool flag3 = default(bool);
			if ((int)num > 16)
			{
				int num2 = default(int);
				if (num == 24)
				{
					num2 = (currencyAmount_ = input.ReadInt32());
				}
				if (num2 != 32)
				{
					goto IL_00fd;
				}
				flag3 = (isNew_ = input.ReadBool());
			}
			if (flag3)
			{
				RepeatedField<BattlePassTaskProgress> repeatedField2 = tasksProgress_;
				FieldCodec<BattlePassTaskProgress> repeated_tasksProgress_codec = _repeated_tasksProgress_codec;
				((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_tasksProgress_codec);
			}
			if (flag3)
			{
				int num3 = (activeTaskCount_ = input.ReadInt32());
			}
			goto IL_00fd;
			IL_00fd:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004C5D")]
		[Cpp2IlInjected.Address(RVA = "0x1ABA290", Offset = "0x1AB8C90", VA = "0x181ABA290", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 7)
			{
				RepeatedField<BattlePassTaskProgress> repeatedField = tasksProgress_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C5E")]
		[Cpp2IlInjected.Address(RVA = "0x1ABB250", Offset = "0x1AB9C50", VA = "0x181ABB250", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012
			//IL_000d: Expected I4, but got O
			//IL_0019: Expected O, but got I4
			if (fieldNumber - 1 <= 7)
			{
				object obj = default(object);
				activeTaskCount_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C5F")]
		[Cpp2IlInjected.Address(RVA = "0x1AB9DE0", Offset = "0x1AB87E0", VA = "0x181AB9DE0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0013
			if (fieldNumber - 1 <= 7)
			{
				RepeatedField<BattlePassTaskProgress> repeatedField = tasksProgress_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C69")]
		[Cpp2IlInjected.Address(RVA = "0x1ABAAE0", Offset = "0x1AB94E0", VA = "0x181ABAAE0")]
		public bool IsValidIndex(int index)
		{
			//Discarded unreachable code: IL_0010
			int num = 0;
			int count = ((RepeatedField<T>)(object)tasksProgress_).Count;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C6A")]
		[Cpp2IlInjected.Address(RVA = "0x1ABAA20", Offset = "0x1AB9420", VA = "0x181ABAA20")]
		public bool IsClaimed(int index)
		{
			//Discarded unreachable code: IL_0015
			return ((BattlePassTaskProgress)((RepeatedField<T>)(object)tasksProgress_)[index]).taskState_ == BattlePassTaskState.CurrencyClaimed;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C6B")]
		[Cpp2IlInjected.Address(RVA = "0x1ABAA80", Offset = "0x1AB9480", VA = "0x181ABAA80")]
		public bool IsReadyToClaim(int index)
		{
			//Discarded unreachable code: IL_0015
			return ((BattlePassTaskProgress)((RepeatedField<T>)(object)tasksProgress_)[index]).taskState_ == BattlePassTaskState.Completed;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C6E")]
		[Cpp2IlInjected.Address(RVA = "0x1ABA870", Offset = "0x1AB9270", VA = "0x181ABA870")]
		internal void Init(string onlineId, BattlePassSeasonData seasonData, Profile profile, ProfileEventDispatcher dispatcher, ITransactionContext context)
		{
			//Discarded unreachable code: IL_009e
			//IL_000e: Expected O, but got I4
			//IL_0015: Expected O, but got I4
			Profile = profile;
			Dispatcher = (ProfileEventDispatcher)0;
			Context = (ITransactionContext)0;
			OnlineId = onlineId;
			Data = seasonData;
			Timestamp timestamp = (endDate_ = Data.endDate_.date_.Clone());
			BattlePassSeasonData battlePassSeasonData = Data;
			int num = 0;
			int count = ((RepeatedField<T>)(object)battlePassSeasonData.taskConfig_.tasks_).Count;
			if (num < count)
			{
				BattlePassTask battlePassTask = (BattlePassTask)((RepeatedField<T>)(object)Data.taskConfig_.tasks_)[num];
				GetOrCreateProgress(battlePassTask, num)?.Init(this, battlePassTask, num);
				BattlePassSeasonData battlePassSeasonData2 = Data;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C6F")]
		[Cpp2IlInjected.Address(RVA = "0x1ABB160", Offset = "0x1AB9B60", VA = "0x181ABB160")]
		internal void Resume()
		{
			//Discarded unreachable code: IL_006e
			if (isStarted)
			{
				return;
			}
			BattlePassSeasonData battlePassSeasonData = Data;
			int num = 0;
			isStarted = true;
			int count = ((RepeatedField<T>)(object)battlePassSeasonData.taskConfig_.tasks_).Count;
			if (num < count)
			{
				BattlePassTaskProgress battlePassTaskProgress = (BattlePassTaskProgress)((RepeatedField<T>)(object)tasksProgress_)[num];
				if (battlePassTaskProgress != null && (long)battlePassTaskProgress.objective_ != 0 && battlePassTaskProgress.taskState_ == BattlePassTaskState.OnGoing)
				{
					battlePassTaskProgress.Resume();
				}
				BattlePassSeasonData battlePassSeasonData2 = Data;
				num++;
			}
			bool flag = StartPendingTasks();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C70")]
		[Cpp2IlInjected.Address(RVA = "0x1ABB930", Offset = "0x1ABA330", VA = "0x181ABB930")]
		internal void Stop()
		{
			//Discarded unreachable code: IL_005d
			if (!isStarted)
			{
				return;
			}
			BattlePassSeasonData battlePassSeasonData = Data;
			int num = 0;
			isStarted = false;
			int count = ((RepeatedField<T>)(object)battlePassSeasonData.taskConfig_.tasks_).Count;
			if (num < count)
			{
				BattlePassTaskProgress battlePassTaskProgress = (BattlePassTaskProgress)((RepeatedField<T>)(object)tasksProgress_)[num];
				if (battlePassTaskProgress != null && (long)battlePassTaskProgress.objective_ != 0)
				{
					battlePassTaskProgress.Stop();
				}
				BattlePassSeasonData battlePassSeasonData2 = Data;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004C71")]
		[Cpp2IlInjected.Address(RVA = "0x1ABAF70", Offset = "0x1AB9970", VA = "0x181ABAF70")]
		internal void RestoreTaskState(IEnumerable<bool> tasksClaimed)
		{
			//Discarded unreachable code: IL_006a, IL_0070, IL_0076, IL_007c, IL_0082
			int num = 0;
			if ((object)typeof(IEnumerator).TypeHandle == null)
			{
				return;
			}
			int count = ((RepeatedField<T>)(object)tasksProgress_).Count;
			if (num >= count)
			{
				return;
			}
			BattlePassTaskProgress battlePassTaskProgress = (BattlePassTaskProgress)((RepeatedField<T>)(object)tasksProgress_)[num];
			bool flag = battlePassTaskProgress.taskState_ == BattlePassTaskState.CurrencyClaimed;
			if ((IntPtr)typeof(IEnumerator).TypeHandle != (IntPtr)(flag ? 1 : 0))
			{
				if ((object)typeof(IEnumerator).TypeHandle == null)
				{
					battlePassTaskProgress.UpdateTaskState(BattlePassTaskState.NotStarted);
					num++;
				}
				if ((long)battlePassTaskProgress == 2 || (long)battlePassTaskProgress == 3)
				{
					battlePassTaskProgress.Stop();
				}
				battlePassTaskProgress.UpdateTaskState(BattlePassTaskState.CurrencyClaimed);
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C72")]
		[Cpp2IlInjected.Address(RVA = "0x1ABAEF0", Offset = "0x1AB98F0", VA = "0x181ABAEF0")]
		internal void RestoreIsRewardPurchased(IEnumerable<bool> rewardPurchased)
		{
			//Discarded unreachable code: IL_0018
			((RepeatedField<T>)(object)isRewardPurchased_).Clear();
			((RepeatedField<T>)(object)isRewardPurchased_).AddRange((IEnumerable<>)rewardPurchased);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C73")]
		[Cpp2IlInjected.Address(RVA = "0x1ABB510", Offset = "0x1AB9F10", VA = "0x181ABB510")]
		internal void SetIsRewardPurchased(int index, bool value)
		{
			//Discarded unreachable code: IL_002c
			//IL_001c: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			int count = ((RepeatedField<T>)(object)isRewardPurchased_).Count;
			RepeatedField<bool> repeatedField = isRewardPurchased_;
			int num = 0;
			((RepeatedField<T>)(object)repeatedField).Add((T)num);
			RepeatedField<bool> repeatedField2 = isRewardPurchased_;
			((RepeatedField<T>)(object)repeatedField)[index] = (T)value;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C74")]
		[Cpp2IlInjected.Address(RVA = "0x1ABB5E0", Offset = "0x1AB9FE0", VA = "0x181ABB5E0")]
		internal bool StartPendingTasks()
		{
			//Discarded unreachable code: IL_00b0, IL_00b6, IL_00bc, IL_00c2
			int num = 0;
			int num2 = 0;
			BattlePassSeasonData battlePassSeasonData = Data;
			if ((isPremiumActive_ ? 1 : 0) != num2)
			{
			}
			int freeActiveTaskCount_ = battlePassSeasonData.freeActiveTaskCount_;
			IEnumerable<BattlePassTaskProgress> enumerable;
			BattlePassSeasonData battlePassSeasonData2 = default(BattlePassSeasonData);
			int num4 = default(int);
			if (activeTaskCount_ < freeActiveTaskCount_)
			{
				RepeatedField<BattlePassTaskProgress> repeatedField = tasksProgress_;
				Func<BattlePassTaskProgress, bool> func = (Func<BattlePassTaskProgress, bool>)(object)(Func<T, TResult>)delegate(BattlePassTaskProgress x)
				{
					if (x != null && x.taskState_ == BattlePassTaskState.NotStarted)
					{
						BattlePassSeasonData battlePassSeasonData3 = Data;
						ITransactionContext context = Context;
						BattlePassTask task = x.Data;
						return battlePassSeasonData3.TaskIsAvailable(task, context);
					}
					int num6 = 0;
					throw new NullReferenceException();
				};
				enumerable = (IEnumerable<BattlePassTaskProgress>)Enumerable.Where<BattlePassTaskProgress>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
				if (enumerable != null)
				{
					uint num3 = default(uint);
					if (num2 < (int)num3)
					{
						num2 += num2;
						if (num2 == (int)num3)
						{
							goto IL_0086;
						}
						num2++;
					}
					num4 = activeTaskCount_;
					num4 = (activeTaskCount_ = num4 + 1);
					battlePassSeasonData2 = Data;
					if (isPremiumActive_)
					{
						goto IL_0086;
					}
					goto IL_008d;
				}
				goto IL_009a;
			}
			goto IL_00aa;
			IL_00aa:
			throw new NullReferenceException();
			IL_008d:
			int freeActiveTaskCount_2 = battlePassSeasonData2.freeActiveTaskCount_;
			num2++;
			goto IL_009a;
			IL_0086:
			num4 += num4;
			goto IL_008d;
			IL_009a:
			num2++;
			if (enumerable != null)
			{
			}
			if (num2 != 0)
			{
			}
			int num5 = 0;
			goto IL_00aa;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C75")]
		[Cpp2IlInjected.Address(RVA = "0x1ABA560", Offset = "0x1AB8F60", VA = "0x181ABA560")]
		private BattlePassTaskProgress GetOrCreateProgress(BattlePassTask taskData, int index)
		{
			//IL_0087: Expected I4, but got I8
			//IL_00bd: Expected O, but got I4
			//IL_00ee: Expected I4, but got I8
			//IL_00fa: Expected O, but got I4
			int count = ((RepeatedField<T>)(object)tasksProgress_).Count;
			int num = 0;
			if ((IntPtr)taskData.objective_ != (IntPtr)num)
			{
				BattlePassTaskProgress battlePassTaskProgress = new BattlePassTaskProgress();
				Random random = new Random(Profile.player_.GetRandomSeed("BattlePassRandomSeed"));
				ObjectiveProgress objectiveProgress = new ObjectiveProgress();
				ItemSelector itemSelector = taskData.objective_.ItemSelector;
				string arg = OnlineId;
				Profile profile = Profile;
				string debugName = $"InitBattlePassTask:{arg}:{profile}";
				int num2 = 0;
				int onlySeedCrop = 0;
				ulong num3 = default(ulong);
				ItemFilter itemFilter = (objectiveProgress.itemFilter_ = ItemFilter.New(itemSelector, profile, random, (byte)onlySeedCrop != 0, (byte)num2 != 0, (byte)num3 != 0, debugName));
				objectiveProgress.curAmount_ = num2;
				StepAmount stepAmount = taskData.objective_.StepAmount;
				if (stepAmount != null)
				{
					int num4 = 0;
					int amount = stepAmount.GetAmount(random, 1, (Func<, >)num4, (byte)num2 != 0);
				}
				objectiveProgress.targetAmount_ = 1;
				battlePassTaskProgress.objective_ = objectiveProgress;
				Profile.player_.AdvanceRandomSeed("BattlePassRandomSeed");
				battlePassTaskProgress.taskState_ = BattlePassTaskState.NotStarted;
			}
			((RepeatedField<T>)(object)tasksProgress_).Add((T)num);
			BattlePassTaskProgress battlePassTaskProgress2 = (BattlePassTaskProgress)((RepeatedField<T>)(object)tasksProgress_)[index];
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004C76")]
		[Cpp2IlInjected.Address(RVA = "0x1ABBCD0", Offset = "0x1ABA6D0", VA = "0x181ABBCD0")]
		static BattlePassProgress()
		{
			Func<BattlePassProgress> func = default(Func<BattlePassProgress>);
			_parser = (MessageParser<BattlePassProgress>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<BattlePassTaskProgress> parser = BattlePassTaskProgress._parser;
			uint num = default(uint);
			_parser = (MessageParser<BattlePassProgress>)(object)FieldCodec.ForMessage<BattlePassTaskProgress>(num, (MessageParser<>)(object)parser);
			_parser = (MessageParser<BattlePassProgress>)(object)FieldCodec.ForBool(58u);
			/*Error: Unexpected end of block*/;
		}
	}
}
