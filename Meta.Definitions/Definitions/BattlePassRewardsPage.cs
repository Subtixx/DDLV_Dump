using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public sealed class BattlePassRewardsPage : IMessage<BattlePassRewardsPage>, IMessage, IEquatable<BattlePassRewardsPage>, IDeepCloneable<BattlePassRewardsPage>, IMessageFieldAccessor, IMessageOneofAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public enum UnlockRequirementOneofCase
		{
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			UnlockRequirementTask = 5,
			[Cpp2IlInjected.Token(Token = "0x4000230")]
			UnlockRequirementReward = 6
		}

		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private static readonly MessageParser<BattlePassRewardsPage> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public const int EditorHeaderNameFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private string editorHeaderName_;

		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public const int IsCurrencyConversionPageFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private bool isCurrencyConversionPage_;

		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public const int UnlockRequirementTaskFieldNumber = 5;

		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public const int UnlockRequirementRewardFieldNumber = 6;

		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public const int RewardsFieldNumber = 10;

		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private static readonly FieldCodec<BattlePassReward> _repeated_rewards_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private readonly RepeatedField<BattlePassReward> rewards_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private object unlockRequirement_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private UnlockRequirementOneofCase unlockRequirementCase_;

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		[DebuggerNonUserCode]
		public static MessageParser<BattlePassRewardsPage> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x26F6960", Offset = "0x26F5360", VA = "0x1826F6960")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x26F6890", Offset = "0x26F5290", VA = "0x1826F6890")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x26F6A80", Offset = "0x26F5480", VA = "0x1826F6A80", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		[DebuggerNonUserCode]
		public string EditorHeaderName
		{
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return editorHeaderName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x26F6B90", Offset = "0x26F5590", VA = "0x1826F6B90")]
			set
			{
				string text = (editorHeaderName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		[DebuggerNonUserCode]
		public bool IsCurrencyConversionPage
		{
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return isCurrencyConversionPage_;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set
			{
				isCurrencyConversionPage_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		[DebuggerNonUserCode]
		public UnlockRequirementTask UnlockRequirementTask
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0x26F6A20", Offset = "0x26F5420", VA = "0x1826F6A20")]
			get
			{
				int num = 0;
				if (unlockRequirementCase_ == UnlockRequirementOneofCase.UnlockRequirementTask)
				{
					object obj = unlockRequirement_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x18AA410", Offset = "0x18A8E10", VA = "0x1818AA410")]
			set
			{
				unlockRequirement_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		[DebuggerNonUserCode]
		public UnlockRequirementReward UnlockRequirementReward
		{
			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x26F69C0", Offset = "0x26F53C0", VA = "0x1826F69C0")]
			get
			{
				int num = 0;
				if (unlockRequirementCase_ == UnlockRequirementOneofCase.UnlockRequirementReward)
				{
					object obj = unlockRequirement_;
					if (obj != null && obj == null)
					{
					}
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x26F6C00", Offset = "0x26F5600", VA = "0x1826F6C00")]
			set
			{
				unlockRequirement_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		[DebuggerNonUserCode]
		public RepeatedField<BattlePassReward> Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return rewards_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		[DebuggerNonUserCode]
		public UnlockRequirementOneofCase UnlockRequirementCase
		{
			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return unlockRequirementCase_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x26F67F0", Offset = "0x26F51F0", VA = "0x1826F67F0")]
		[DebuggerNonUserCode]
		public BattlePassRewardsPage()
		{
			editorHeaderName_ = "";
			rewards_ = (RepeatedField<BattlePassReward>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x26F6640", Offset = "0x26F5040", VA = "0x1826F6640")]
		[DebuggerNonUserCode]
		public BattlePassRewardsPage(BattlePassRewardsPage other)
		{
			//IL_0078: Expected I4, but got O
			string text = (editorHeaderName_ = other.editorHeaderName_);
			bool flag = (isCurrencyConversionPage_ = other.isCurrencyConversionPage_);
			RepeatedField<BattlePassReward> repeatedField = (rewards_ = (RepeatedField<BattlePassReward>)(object)((RepeatedField<T>)(object)other.rewards_).Clone());
			UnlockRequirementOneofCase unlockRequirementOneofCase = other.unlockRequirementCase_;
			if (unlockRequirementOneofCase == UnlockRequirementOneofCase.UnlockRequirementTask)
			{
				UnlockRequirementOneofCase unlockRequirementOneofCase2 = other.unlockRequirementCase_;
				if (other.unlockRequirement_ == null)
				{
					throw new InvalidCastException();
				}
				UnlockRequirementTask unlockRequirementTask = default(UnlockRequirementTask);
				unlockRequirement_ = unlockRequirementTask;
			}
			if (unlockRequirementOneofCase == UnlockRequirementOneofCase.UnlockRequirementReward)
			{
				UnlockRequirementOneofCase unlockRequirementOneofCase3 = other.unlockRequirementCase_;
				if (other.unlockRequirement_ == null)
				{
					throw new InvalidCastException();
				}
				UnlockRequirementReward unlockRequirementReward = default(UnlockRequirementReward);
				unlockRequirement_ = unlockRequirementReward;
				unlockRequirementCase_ = (UnlockRequirementOneofCase)unlockRequirementReward;
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x26F5420", Offset = "0x26F3E20", VA = "0x1826F5420", Slot = "10")]
		[DebuggerNonUserCode]
		public BattlePassRewardsPage Clone()
		{
			return new BattlePassRewardsPage(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x18A7A50", Offset = "0x18A6450", VA = "0x1818A7A50")]
		[DebuggerNonUserCode]
		public void ClearUnlockRequirement()
		{
			//IL_0010: Expected O, but got I4
			unlockRequirement_ = (unlockRequirementCase_ = UnlockRequirementOneofCase.None);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x26F5480", Offset = "0x26F3E80", VA = "0x1826F5480", Slot = "0")]
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
				string text = editorHeaderName_;
				bool flag = default(bool);
				UnlockRequirementTask objB = default(UnlockRequirementTask);
				UnlockRequirementReward objB2 = default(UnlockRequirementReward);
				if (!flag && isCurrencyConversionPage_ == flag && object.Equals(UnlockRequirementTask, objB) && object.Equals(UnlockRequirementReward, objB2))
				{
					RepeatedField<BattlePassReward> repeatedField = rewards_;
					bool flag2 = default(bool);
					if (flag2 && unlockRequirementCase_ == (flag2 ? ((UnlockRequirementOneofCase)1) : UnlockRequirementOneofCase.None))
					{
						return object.Equals(_unknownFields, objB2);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x26F55E0", Offset = "0x26F3FE0", VA = "0x1826F55E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattlePassRewardsPage other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.editorHeaderName_;
				if (!(editorHeaderName_ != text))
				{
					bool flag = other.isCurrencyConversionPage_;
					if (isCurrencyConversionPage_ == flag)
					{
						UnlockRequirementTask unlockRequirementTask = UnlockRequirementTask;
						UnlockRequirementTask unlockRequirementTask2 = other.UnlockRequirementTask;
						if (object.Equals(unlockRequirementTask, unlockRequirementTask2))
						{
							UnlockRequirementReward unlockRequirementReward = UnlockRequirementReward;
							UnlockRequirementReward unlockRequirementReward2 = other.UnlockRequirementReward;
							if (object.Equals(unlockRequirementReward, unlockRequirementReward2))
							{
								RepeatedField<BattlePassReward> repeatedField = rewards_;
								RepeatedField<BattlePassReward> repeatedField2 = other.rewards_;
								if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
								{
									UnlockRequirementOneofCase unlockRequirementOneofCase = other.unlockRequirementCase_;
									if (unlockRequirementCase_ == unlockRequirementOneofCase)
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
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x26F5840", Offset = "0x26F4240", VA = "0x1826F5840", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_008f
			UnlockRequirementOneofCase unlockRequirementOneofCase;
			do
			{
				string text = editorHeaderName_;
				if (text.m_stringLength != 0)
				{
					int hashCode = text.GetHashCode();
				}
				if (isCurrencyConversionPage_)
				{
				}
				unlockRequirementOneofCase = unlockRequirementCase_;
				int num = 0;
			}
			while (unlockRequirementOneofCase != UnlockRequirementOneofCase.UnlockRequirementTask);
			object obj = unlockRequirement_;
			if (obj != null)
			{
				int hashCode2 = obj.GetHashCode();
				if (unlockRequirementCase_ == UnlockRequirementOneofCase.UnlockRequirementReward)
				{
					object obj2 = unlockRequirement_;
					if (obj2 == null)
					{
						throw new InvalidCastException();
					}
					int hashCode3 = obj2.GetHashCode();
				}
				int hashCode4 = ((RepeatedField<T>)(object)rewards_).GetHashCode();
				UnknownFieldSet unknownFields = _unknownFields;
				if (unknownFields != null)
				{
					int hashCode5 = unknownFields.GetHashCode();
				}
				return hashCode4;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x26F6200", Offset = "0x26F4C00", VA = "0x1826F6200", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x26F6260", Offset = "0x26F4C60", VA = "0x1826F6260", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00ae
			UnlockRequirementOneofCase unlockRequirementOneofCase;
			do
			{
				if (editorHeaderName_.m_stringLength != 0)
				{
					string value = editorHeaderName_;
					output.WriteString(value);
				}
				if (isCurrencyConversionPage_)
				{
					bool value2 = isCurrencyConversionPage_;
					output.WriteBool(value2);
				}
				unlockRequirementOneofCase = unlockRequirementCase_;
				int num = 0;
			}
			while (unlockRequirementOneofCase != UnlockRequirementOneofCase.UnlockRequirementTask);
			if (unlockRequirementCase_ == UnlockRequirementOneofCase.UnlockRequirementTask)
			{
				object obj = unlockRequirement_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
			if (unlockRequirementCase_ == UnlockRequirementOneofCase.UnlockRequirementReward && unlockRequirementCase_ == UnlockRequirementOneofCase.UnlockRequirementReward)
			{
				object obj2 = unlockRequirement_;
				if (obj2 != null && obj2 == null)
				{
					throw new InvalidCastException();
				}
			}
			RepeatedField<BattlePassReward> repeatedField = rewards_;
			FieldCodec<BattlePassReward> repeated_rewards_codec = _repeated_rewards_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_rewards_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x26F50B0", Offset = "0x26F3AB0", VA = "0x1826F50B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00b3
			string text = editorHeaderName_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
				num2++;
			}
			if (unlockRequirementCase_ == UnlockRequirementOneofCase.UnlockRequirementTask)
			{
				if (unlockRequirementCase_ != UnlockRequirementOneofCase.UnlockRequirementTask)
				{
				}
				object obj = unlockRequirement_;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				num++;
				int num3 = default(int);
				num += num3;
			}
			if (unlockRequirementCase_ == UnlockRequirementOneofCase.UnlockRequirementReward)
			{
				if (unlockRequirementCase_ == UnlockRequirementOneofCase.UnlockRequirementReward)
				{
					object obj2 = unlockRequirement_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				num++;
				int num4 = default(int);
				num += num4;
			}
			RepeatedField<BattlePassReward> repeatedField = rewards_;
			FieldCodec<BattlePassReward> repeated_rewards_codec = _repeated_rewards_codec;
			int num5 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_rewards_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num5;
			if (unknownFields != null)
			{
				int num6 = unknownFields.CalculateSize();
				num += num6;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x26F5A80", Offset = "0x26F4480", VA = "0x1826F5A80", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattlePassRewardsPage other)
		{
			//Discarded unreachable code: IL_0131
			//IL_00f8: Expected I4, but got O
			if (other == null)
			{
				return;
			}
			string text = other.editorHeaderName_;
			if (text.m_stringLength != 0)
			{
				EditorHeaderName = text;
			}
			bool flag = other.isCurrencyConversionPage_;
			if (flag)
			{
				isCurrencyConversionPage_ = flag;
			}
			RepeatedField<BattlePassReward> repeatedField = rewards_;
			RepeatedField<BattlePassReward> repeatedField2 = other.rewards_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if (other.unlockRequirementCase_ == UnlockRequirementOneofCase.UnlockRequirementTask)
			{
				UnlockRequirementOneofCase unlockRequirementOneofCase = unlockRequirementCase_;
				object obj = default(object);
				if (unlockRequirementOneofCase == UnlockRequirementOneofCase.UnlockRequirementTask)
				{
					obj = unlockRequirement_;
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				if (obj == null)
				{
					UnlockRequirementTask unlockRequirementTask = (UnlockRequirementTask)(unlockRequirement_ = new UnlockRequirementTask());
					unlockRequirementCase_ = unlockRequirementOneofCase;
				}
				if (unlockRequirementCase_ == UnlockRequirementOneofCase.UnlockRequirementTask)
				{
					object obj2 = unlockRequirement_;
					if (obj2 != null && obj2 == null)
					{
						throw new InvalidCastException();
					}
				}
				if (1L == 0L)
				{
				}
				if (other.unlockRequirementCase_ == UnlockRequirementOneofCase.UnlockRequirementTask)
				{
					object obj3 = other.unlockRequirement_;
					if (obj3 != null && obj3 == null)
					{
						throw new InvalidCastException();
					}
				}
			}
			if ((long)typeof(UnlockRequirementTask).TypeHandle == 6)
			{
				if (UnlockRequirementReward == null)
				{
					unlockRequirementCase_ = (UnlockRequirementOneofCase)(unlockRequirement_ = new UnlockRequirementReward());
				}
				UnlockRequirementReward unlockRequirementReward = UnlockRequirementReward;
				UnlockRequirementReward unlockRequirementReward2 = other.UnlockRequirementReward;
				unlockRequirementReward.MergeFrom(unlockRequirementReward2);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x26F5D20", Offset = "0x26F4720", VA = "0x1826F5D20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//IL_005d: Expected I4, but got O
			//IL_00a9: Expected I4, but got O
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 42)
				{
					UnlockRequirementTask unlockRequirementTask = new UnlockRequirementTask();
					if (unlockRequirementCase_ == UnlockRequirementOneofCase.UnlockRequirementTask)
					{
						if (unlockRequirementCase_ != UnlockRequirementOneofCase.UnlockRequirementTask)
						{
						}
						object obj = unlockRequirement_;
						if (obj != null && obj == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(unlockRequirementTask);
					unlockRequirement_ = unlockRequirementTask;
					unlockRequirementCase_ = (UnlockRequirementOneofCase)unlockRequirementTask;
				}
				if (num == 50)
				{
					UnlockRequirementReward builder = new UnlockRequirementReward();
					if (unlockRequirementCase_ == UnlockRequirementOneofCase.UnlockRequirementReward)
					{
						if (unlockRequirementCase_ != UnlockRequirementOneofCase.UnlockRequirementReward)
						{
						}
						object obj2 = unlockRequirement_;
						if (obj2 != null && obj2 == null)
						{
							throw new InvalidCastException();
						}
					}
					input.ReadMessage(builder);
					unlockRequirement_ = builder;
					unlockRequirementCase_ = (UnlockRequirementOneofCase)typeof(UnlockRequirementReward).TypeHandle;
				}
				if ((long)typeof(UnlockRequirementReward).TypeHandle != 82)
				{
					goto IL_00fb;
				}
				RepeatedField<BattlePassReward> repeatedField = rewards_;
				FieldCodec<BattlePassReward> repeated_rewards_codec = _repeated_rewards_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_rewards_codec);
			}
			string text2 = default(string);
			if (num == 10)
			{
				text2 = (EditorHeaderName = input.ReadString());
			}
			if ((long)text2 == 16)
			{
				bool flag = (isCurrencyConversionPage_ = input.ReadBool());
			}
			goto IL_00fb;
			IL_00fb:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x26F5710", Offset = "0x26F4110", VA = "0x1826F5710", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 5)
			{
				string text = editorHeaderName_;
			}
			if (fieldNumber == 10)
			{
				RepeatedField<BattlePassReward> repeatedField = rewards_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x26F5FF0", Offset = "0x26F49F0", VA = "0x1826F5FF0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018, IL_0019, IL_001d, IL_0021, IL_0022, IL_0026, IL_002a, IL_0041, IL_0047
			//IL_0017: Expected O, but got I4
			if (fieldNumber - 1 <= 5)
			{
				int num = 0;
				if (value == null || value != null)
				{
					EditorHeaderName = (string)num;
					return;
				}
			}
			else
			{
				while (fieldNumber != 10)
				{
				}
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x26F52C0", Offset = "0x26F3CC0", VA = "0x1826F52C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0012, IL_0013
			if (fieldNumber - 1 <= 5)
			{
				EditorHeaderName = "";
				return;
			}
			while (fieldNumber != 10)
			{
			}
			RepeatedField<BattlePassReward> repeatedField = rewards_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x26F59D0", Offset = "0x26F43D0", VA = "0x1826F59D0", Slot = "14")]
		[DebuggerNonUserCode]
		public int GetOneofCase(string oneofName)
		{
			if (oneofName != null && string.Equals(oneofName, "UnlockRequirement"))
			{
				UnlockRequirementOneofCase unlockRequirementOneofCase = unlockRequirementCase_;
			}
			ArgumentException ex = new ArgumentException("Invalid oneof name", "oneofName");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x26F53B0", Offset = "0x26F3DB0", VA = "0x1826F53B0", Slot = "15")]
		[DebuggerNonUserCode]
		public void ClearOneOf(string oneofName)
		{
			//IL_0022: Expected O, but got I4
			if (oneofName != null && string.Equals(oneofName, "UnlockRequirement"))
			{
				unlockRequirement_ = (unlockRequirementCase_ = UnlockRequirementOneofCase.None);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x26F6470", Offset = "0x26F4E70", VA = "0x1826F6470")]
		static BattlePassRewardsPage()
		{
			Func<BattlePassRewardsPage> func = default(Func<BattlePassRewardsPage>);
			_parser = (MessageParser<BattlePassRewardsPage>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<BattlePassReward> parser = BattlePassReward._parser;
			uint num = default(uint);
			_parser = (MessageParser<BattlePassRewardsPage>)(object)FieldCodec.ForMessage<BattlePassReward>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
