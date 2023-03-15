using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class BattlePassRewardsSetup : IMessage<BattlePassRewardsSetup>, IMessage, IEquatable<BattlePassRewardsSetup>, IDeepCloneable<BattlePassRewardsSetup>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private static readonly MessageParser<BattlePassRewardsSetup> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public const int PagesNumFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private int pagesNum_;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public const int RewardsNumPerPageFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private int rewardsNumPerPage_;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public const int MainRewardFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private string mainReward_ = "";

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public const int TotalFreeSCNumFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private int totalFreeSCNum_;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public const int TotalPremiumSCNumFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private int totalPremiumSCNum_;

		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public const int TotalFreeHCNumFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private int totalFreeHCNum_;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public const int TotalPremiumHCNumFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private int totalPremiumHCNum_;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		[DebuggerNonUserCode]
		public static MessageParser<BattlePassRewardsSetup> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x26F7F10", Offset = "0x26F6910", VA = "0x1826F7F10")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x26F7D50", Offset = "0x26F6750", VA = "0x1826F7D50")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x26F7F70", Offset = "0x26F6970", VA = "0x1826F7F70", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		[DebuggerNonUserCode]
		public int PagesNum
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return pagesNum_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				pagesNum_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		[DebuggerNonUserCode]
		public int RewardsNumPerPage
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return rewardsNumPerPage_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				rewardsNumPerPage_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		[DebuggerNonUserCode]
		public string MainReward
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return mainReward_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x26F8080", Offset = "0x26F6A80", VA = "0x1826F8080")]
			set
			{
				string text = (mainReward_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		[DebuggerNonUserCode]
		public int TotalFreeSCNum
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return totalFreeSCNum_;
			}
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				totalFreeSCNum_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		[DebuggerNonUserCode]
		public int TotalPremiumSCNum
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return totalPremiumSCNum_;
			}
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				totalPremiumSCNum_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		[DebuggerNonUserCode]
		public int TotalFreeHCNum
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return totalFreeHCNum_;
			}
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				totalFreeHCNum_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		[DebuggerNonUserCode]
		public int TotalPremiumHCNum
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return totalPremiumHCNum_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				totalPremiumHCNum_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		public int MainRewardPage
		{
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0x26F7E90", Offset = "0x26F6890", VA = "0x1826F7E90")]
			get
			{
				//Discarded unreachable code: IL_0027
				string text = mainReward_;
				int num = default(int);
				if (num > 0)
				{
					string text2 = mainReward_;
					int startIndex = 0;
					string text3 = text2.Substring(startIndex, num);
					bool flag = default(bool);
					if (!flag)
					{
					}
				}
				return -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public int MainRewardIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x26F7E20", Offset = "0x26F6820", VA = "0x1826F7E20")]
			get
			{
				//Discarded unreachable code: IL_0024
				string text = mainReward_;
				string text2 = mainReward_;
				int num = default(int);
				int startIndex = num + 1;
				string text3 = text2.Substring(startIndex);
				bool flag = default(bool);
				if (flag)
				{
				}
				return -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x26F7CF0", Offset = "0x26F66F0", VA = "0x1826F7CF0")]
		[DebuggerNonUserCode]
		public BattlePassRewardsSetup()
		{
			//IL_001a: Expected I4, but got I8
			//IL_0023: Expected I4, but got I8
			pagesNum_ = 1;
			rewardsNumPerPage_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x26F76E0", Offset = "0x26F60E0", VA = "0x1826F76E0")]
		private void OnConstruction()
		{
			//IL_0009: Expected I4, but got I8
			//IL_0012: Expected I4, but got I8
			pagesNum_ = 1;
			rewardsNumPerPage_ = 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x26F7C20", Offset = "0x26F6620", VA = "0x1826F7C20")]
		[DebuggerNonUserCode]
		public BattlePassRewardsSetup(BattlePassRewardsSetup other)
		{
			//IL_001a: Expected I4, but got I8
			//IL_0023: Expected I4, but got I8
			pagesNum_ = 1;
			rewardsNumPerPage_ = 1;
			int num = (pagesNum_ = other.pagesNum_);
			int num2 = (rewardsNumPerPage_ = other.rewardsNumPerPage_);
			string text = (mainReward_ = other.mainReward_);
			int num3 = (totalFreeSCNum_ = other.totalFreeSCNum_);
			int num4 = (totalPremiumSCNum_ = other.totalPremiumSCNum_);
			int num5 = (totalFreeHCNum_ = other.totalFreeHCNum_);
			int num6 = (totalPremiumHCNum_ = other.totalPremiumHCNum_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x26F6F00", Offset = "0x26F5900", VA = "0x1826F6F00", Slot = "10")]
		[DebuggerNonUserCode]
		public BattlePassRewardsSetup Clone()
		{
			//Discarded unreachable code: IL_00a4
			//IL_001a: Expected I4, but got I8
			//IL_0023: Expected I4, but got I8
			BattlePassRewardsSetup battlePassRewardsSetup = new BattlePassRewardsSetup();
			battlePassRewardsSetup.mainReward_ = "";
			battlePassRewardsSetup.pagesNum_ = 1;
			battlePassRewardsSetup.rewardsNumPerPage_ = 1;
			int num = (battlePassRewardsSetup.pagesNum_ = pagesNum_);
			int num2 = (battlePassRewardsSetup.rewardsNumPerPage_ = rewardsNumPerPage_);
			string text = (battlePassRewardsSetup.mainReward_ = mainReward_);
			int num3 = (battlePassRewardsSetup.totalFreeSCNum_ = totalFreeSCNum_);
			int num4 = (battlePassRewardsSetup.totalPremiumSCNum_ = totalPremiumSCNum_);
			int num5 = (battlePassRewardsSetup.totalFreeHCNum_ = totalFreeHCNum_);
			int num6 = (battlePassRewardsSetup.totalPremiumHCNum_ = totalPremiumHCNum_);
			UnknownFieldSet unknownFieldSet = (battlePassRewardsSetup._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return battlePassRewardsSetup;
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x26F7220", Offset = "0x26F5C20", VA = "0x1826F7220", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)pagesNum_ == (IntPtr)typeof(BattlePassRewardsSetup).TypeHandle && (IntPtr)rewardsNumPerPage_ == (IntPtr)typeof(BattlePassRewardsSetup).TypeHandle)
				{
					string text = mainReward_;
					bool flag = default(bool);
					if (!flag && totalFreeSCNum_ == (flag ? 1 : 0) && totalPremiumSCNum_ == (flag ? 1 : 0) && totalFreeHCNum_ == (flag ? 1 : 0) && totalPremiumHCNum_ == (flag ? 1 : 0))
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x26F7180", Offset = "0x26F5B80", VA = "0x1826F7180", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(BattlePassRewardsSetup other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.pagesNum_;
				if (pagesNum_ == num)
				{
					int num2 = other.rewardsNumPerPage_;
					if (rewardsNumPerPage_ == num2)
					{
						string text = other.mainReward_;
						if (!(mainReward_ != text))
						{
							int num3 = other.totalFreeSCNum_;
							if (totalFreeSCNum_ == num3)
							{
								int num4 = other.totalPremiumSCNum_;
								if (totalPremiumSCNum_ == num4)
								{
									int num5 = other.totalFreeHCNum_;
									if (totalFreeHCNum_ == num5)
									{
										int num6 = other.totalPremiumHCNum_;
										if (totalPremiumHCNum_ == num6)
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
			int num7 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x26F7410", Offset = "0x26F5E10", VA = "0x1826F7410", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0062
			if (pagesNum_ != 0)
			{
			}
			if (rewardsNumPerPage_ != 0)
			{
			}
			string text = mainReward_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (totalFreeSCNum_ != 0)
			{
			}
			if (totalPremiumSCNum_ != 0)
			{
			}
			if (totalFreeHCNum_ != 0)
			{
			}
			if (totalPremiumHCNum_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x26F7940", Offset = "0x26F6340", VA = "0x1826F7940", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x26F79A0", Offset = "0x26F63A0", VA = "0x1826F79A0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00c2
			if (pagesNum_ != 0)
			{
				int value = pagesNum_;
				output.WriteInt32(value);
			}
			if (rewardsNumPerPage_ != 0)
			{
				int value2 = rewardsNumPerPage_;
				output.WriteInt32(value2);
			}
			if (mainReward_.m_stringLength != 0)
			{
				string value3 = mainReward_;
				output.WriteString(value3);
			}
			if (totalFreeSCNum_ != 0)
			{
				int value4 = totalFreeSCNum_;
				output.WriteInt32(value4);
			}
			if (totalPremiumSCNum_ != 0)
			{
				int value5 = totalPremiumSCNum_;
				output.WriteInt32(value5);
			}
			if (totalFreeHCNum_ != 0)
			{
				int value6 = totalFreeHCNum_;
				output.WriteInt32(value6);
			}
			if (totalPremiumHCNum_ != 0)
			{
				int value7 = totalPremiumHCNum_;
				output.WriteInt32(value7);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x26F6C40", Offset = "0x26F5640", VA = "0x1826F6C40", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_00f9
			int num = pagesNum_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = rewardsNumPerPage_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			string text = mainReward_;
			if (text.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text);
				num6++;
				num2 += num6;
			}
			int num7 = totalFreeSCNum_;
			if (num7 != 0)
			{
				int num8 = CodedOutputStream.ComputeInt32Size(num7);
				num8++;
				num2 += num8;
			}
			int num9 = totalPremiumSCNum_;
			if (num9 != 0)
			{
				int num10 = CodedOutputStream.ComputeInt32Size(num9);
				num10++;
				num2 += num10;
			}
			int num11 = totalFreeHCNum_;
			if (num11 != 0)
			{
				int num12 = CodedOutputStream.ComputeInt32Size(num11);
				num12++;
				num2 += num12;
			}
			int num13 = totalPremiumHCNum_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeInt32Size(num13);
				num14++;
				num2 += num14;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num15 = unknownFields.CalculateSize();
				num2 += num15;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x26F7640", Offset = "0x26F6040", VA = "0x1826F7640", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(BattlePassRewardsSetup other)
		{
			//Discarded unreachable code: IL_00b3
			if (other != null)
			{
				int num = other.pagesNum_;
				if (num != 0)
				{
					pagesNum_ = num;
				}
				int num2 = other.rewardsNumPerPage_;
				if (num2 != 0)
				{
					rewardsNumPerPage_ = num2;
				}
				string text = other.mainReward_;
				if (text.m_stringLength != 0)
				{
					MainReward = text;
				}
				int num3 = other.totalFreeSCNum_;
				if (num3 != 0)
				{
					totalFreeSCNum_ = num3;
				}
				int num4 = other.totalPremiumSCNum_;
				if (num4 != 0)
				{
					totalPremiumSCNum_ = num4;
				}
				int num5 = other.totalFreeHCNum_;
				if (num5 != 0)
				{
					totalFreeHCNum_ = num5;
				}
				int num6 = other.totalPremiumHCNum_;
				if (num6 != 0)
				{
					totalPremiumHCNum_ = num6;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x26F7520", Offset = "0x26F5F20", VA = "0x1826F7520", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00c7
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 26)
			{
				if ((int)num > 40)
				{
					if (num == 48)
					{
						int num2 = (totalFreeHCNum_ = input.ReadInt32());
					}
					if (num != 56)
					{
						goto IL_00b0;
					}
					int num3 = (totalPremiumHCNum_ = input.ReadInt32());
				}
				int num4 = default(int);
				if (num == 32)
				{
					num4 = (totalFreeSCNum_ = input.ReadInt32());
				}
				if (num4 != 40)
				{
					goto IL_00b0;
				}
				int num5 = (totalPremiumSCNum_ = input.ReadInt32());
			}
			int num6 = default(int);
			if (num == 8)
			{
				num6 = (pagesNum_ = input.ReadInt32());
			}
			int num7 = default(int);
			if (num6 == 16)
			{
				num7 = (rewardsNumPerPage_ = input.ReadInt32());
			}
			if (num7 == 26)
			{
				string text2 = (MainReward = input.ReadString());
			}
			goto IL_00b0;
			IL_00b0:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x26F7300", Offset = "0x26F5D00", VA = "0x1826F7300", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 6)
			{
				int num = pagesNum_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x26F76F0", Offset = "0x26F60F0", VA = "0x1826F76F0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0018, IL_0020, IL_0028, IL_0030, IL_0036, IL_003c
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 6)
			{
				object obj = default(object);
				pagesNum_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x26F6E10", Offset = "0x26F5810", VA = "0x1826F6E10", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0010, IL_0011, IL_0012, IL_0013, IL_0014
			//IL_000f: Expected I4, but got I8
			if (fieldNumber - 1 <= 6)
			{
				pagesNum_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x26F7000", Offset = "0x26F5A00", VA = "0x1826F7000", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0069
			//IL_0021: Expected O, but got I4
			//IL_0048: Expected O, but got I4
			string text = mainReward_;
			bool flag = default(bool);
			if (flag)
			{
				int mainRewardPage = MainRewardPage;
				mainRewardPage++;
				string message = $"{mainRewardPage} is not a valid reward page number";
				context.AddInvalidMemberError(message, "MainReward");
				int mainRewardIndex = MainRewardIndex;
				mainRewardIndex++;
				string message2 = $"{mainRewardIndex} is not a valid reward index";
				context.AddInvalidMemberError(message2, "MainReward");
			}
			else
			{
				context.AddInvalidMemberError("Invalid format, must contain a . to separate the page and reward index (e.g. 1.1)", "MainReward");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x26F7B10", Offset = "0x26F6510", VA = "0x1826F7B10")]
		static BattlePassRewardsSetup()
		{
			Func<BattlePassRewardsSetup> func = default(Func<BattlePassRewardsSetup>);
			_parser = (MessageParser<BattlePassRewardsSetup>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
