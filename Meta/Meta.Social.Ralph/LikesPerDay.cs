using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Social.Ralph
{
	[Cpp2IlInjected.Token(Token = "0x2000DDE")]
	public sealed class LikesPerDay : IMessage<LikesPerDay>, IMessage, IEquatable<LikesPerDay>, IDeepCloneable<LikesPerDay>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4003816")]
		private static readonly MessageParser<LikesPerDay> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003817")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4003818")]
		public const int LikesOthersFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003819")]
		private int likesOthers_;

		[Cpp2IlInjected.Token(Token = "0x400381A")]
		public const int LikesDay1FieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400381B")]
		private int likesDay1_;

		[Cpp2IlInjected.Token(Token = "0x400381C")]
		public const int LikesDay2FieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400381D")]
		private int likesDay2_;

		[Cpp2IlInjected.Token(Token = "0x400381E")]
		public const int LikesDay3FieldNumber = 13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400381F")]
		private int likesDay3_;

		[Cpp2IlInjected.Token(Token = "0x4003820")]
		public const int LikesDay4FieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003821")]
		private int likesDay4_;

		[Cpp2IlInjected.Token(Token = "0x4003822")]
		public const int LikesDay5FieldNumber = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4003823")]
		private int likesDay5_;

		[Cpp2IlInjected.Token(Token = "0x4003824")]
		public const int LikesDay6FieldNumber = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003825")]
		private int likesDay6_;

		[Cpp2IlInjected.Token(Token = "0x4003826")]
		public const int LikesDay7FieldNumber = 17;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4003827")]
		private int likesDay7_;

		[Cpp2IlInjected.Token(Token = "0x4003828")]
		public const int LikesDay8FieldNumber = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003829")]
		private int likesDay8_;

		[Cpp2IlInjected.Token(Token = "0x400382A")]
		public const int LikesDay9FieldNumber = 19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400382B")]
		private int likesDay9_;

		[Cpp2IlInjected.Token(Token = "0x400382C")]
		public const int LikesDay10FieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400382D")]
		private int likesDay10_;

		[Cpp2IlInjected.Token(Token = "0x170013F7")]
		[DebuggerNonUserCode]
		public static MessageParser<LikesPerDay> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6007396")]
			[Cpp2IlInjected.Address(RVA = "0x18A39F0", Offset = "0x18A23F0", VA = "0x1818A39F0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013F8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007397")]
			[Cpp2IlInjected.Address(RVA = "0x18A3920", Offset = "0x18A2320", VA = "0x1818A3920")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013F9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6007398")]
			[Cpp2IlInjected.Address(RVA = "0x18A3A50", Offset = "0x18A2450", VA = "0x1818A3A50", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013FA")]
		[DebuggerNonUserCode]
		public int LikesOthers
		{
			[Cpp2IlInjected.Token(Token = "0x600739C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return likesOthers_;
			}
			[Cpp2IlInjected.Token(Token = "0x600739D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				likesOthers_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013FB")]
		[DebuggerNonUserCode]
		public int LikesDay1
		{
			[Cpp2IlInjected.Token(Token = "0x600739E")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return likesDay1_;
			}
			[Cpp2IlInjected.Token(Token = "0x600739F")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				likesDay1_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013FC")]
		[DebuggerNonUserCode]
		public int LikesDay2
		{
			[Cpp2IlInjected.Token(Token = "0x60073A0")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return likesDay2_;
			}
			[Cpp2IlInjected.Token(Token = "0x60073A1")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				likesDay2_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013FD")]
		[DebuggerNonUserCode]
		public int LikesDay3
		{
			[Cpp2IlInjected.Token(Token = "0x60073A2")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return likesDay3_;
			}
			[Cpp2IlInjected.Token(Token = "0x60073A3")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				likesDay3_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013FE")]
		[DebuggerNonUserCode]
		public int LikesDay4
		{
			[Cpp2IlInjected.Token(Token = "0x60073A4")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return likesDay4_;
			}
			[Cpp2IlInjected.Token(Token = "0x60073A5")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				likesDay4_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013FF")]
		[DebuggerNonUserCode]
		public int LikesDay5
		{
			[Cpp2IlInjected.Token(Token = "0x60073A6")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return likesDay5_;
			}
			[Cpp2IlInjected.Token(Token = "0x60073A7")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				likesDay5_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001400")]
		[DebuggerNonUserCode]
		public int LikesDay6
		{
			[Cpp2IlInjected.Token(Token = "0x60073A8")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return likesDay6_;
			}
			[Cpp2IlInjected.Token(Token = "0x60073A9")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				likesDay6_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001401")]
		[DebuggerNonUserCode]
		public int LikesDay7
		{
			[Cpp2IlInjected.Token(Token = "0x60073AA")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return likesDay7_;
			}
			[Cpp2IlInjected.Token(Token = "0x60073AB")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				likesDay7_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001402")]
		[DebuggerNonUserCode]
		public int LikesDay8
		{
			[Cpp2IlInjected.Token(Token = "0x60073AC")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return likesDay8_;
			}
			[Cpp2IlInjected.Token(Token = "0x60073AD")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				likesDay8_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001403")]
		[DebuggerNonUserCode]
		public int LikesDay9
		{
			[Cpp2IlInjected.Token(Token = "0x60073AE")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get
			{
				return likesDay9_;
			}
			[Cpp2IlInjected.Token(Token = "0x60073AF")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			set
			{
				likesDay9_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001404")]
		[DebuggerNonUserCode]
		public int LikesDay10
		{
			[Cpp2IlInjected.Token(Token = "0x60073B0")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return likesDay10_;
			}
			[Cpp2IlInjected.Token(Token = "0x60073B1")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				likesDay10_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007399")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LikesPerDay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600739A")]
		[Cpp2IlInjected.Address(RVA = "0x18A3890", Offset = "0x18A2290", VA = "0x1818A3890")]
		[DebuggerNonUserCode]
		public LikesPerDay(LikesPerDay other)
		{
			int num = (likesOthers_ = other.likesOthers_);
			int num2 = (likesDay1_ = other.likesDay1_);
			int num3 = (likesDay2_ = other.likesDay2_);
			int num4 = (likesDay3_ = other.likesDay3_);
			int num5 = (likesDay4_ = other.likesDay4_);
			int num6 = (likesDay5_ = other.likesDay5_);
			int num7 = (likesDay6_ = other.likesDay6_);
			int num8 = (likesDay7_ = other.likesDay7_);
			int num9 = (likesDay8_ = other.likesDay8_);
			int num10 = (likesDay9_ = other.likesDay9_);
			int num11 = (likesDay10_ = other.likesDay10_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600739B")]
		[Cpp2IlInjected.Address(RVA = "0x18A2A90", Offset = "0x18A1490", VA = "0x1818A2A90", Slot = "10")]
		[DebuggerNonUserCode]
		public LikesPerDay Clone()
		{
			//Discarded unreachable code: IL_00c7
			LikesPerDay likesPerDay = new LikesPerDay();
			int num = (likesPerDay.likesOthers_ = likesOthers_);
			int num2 = (likesPerDay.likesDay1_ = likesDay1_);
			int num3 = (likesPerDay.likesDay2_ = likesDay2_);
			int num4 = (likesPerDay.likesDay3_ = likesDay3_);
			int num5 = (likesPerDay.likesDay4_ = likesDay4_);
			int num6 = (likesPerDay.likesDay5_ = likesDay5_);
			int num7 = (likesPerDay.likesDay6_ = likesDay6_);
			int num8 = (likesPerDay.likesDay7_ = likesDay7_);
			int num9 = (likesPerDay.likesDay8_ = likesDay8_);
			int num10 = (likesPerDay.likesDay9_ = likesDay9_);
			int num11 = (likesPerDay.likesDay10_ = likesDay10_);
			UnknownFieldSet unknownFieldSet = (likesPerDay._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return likesPerDay;
		}

		[Cpp2IlInjected.Token(Token = "0x60073B2")]
		[Cpp2IlInjected.Address(RVA = "0x18A2B50", Offset = "0x18A1550", VA = "0x1818A2B50", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)likesOthers_ == (IntPtr)typeof(LikesPerDay).TypeHandle && (IntPtr)likesDay1_ == (IntPtr)typeof(LikesPerDay).TypeHandle && (IntPtr)likesDay2_ == (IntPtr)typeof(LikesPerDay).TypeHandle && (IntPtr)likesDay3_ == (IntPtr)typeof(LikesPerDay).TypeHandle && (IntPtr)likesDay4_ == (IntPtr)typeof(LikesPerDay).TypeHandle && (IntPtr)likesDay5_ == (IntPtr)typeof(LikesPerDay).TypeHandle && (IntPtr)likesDay6_ == (IntPtr)typeof(LikesPerDay).TypeHandle && (IntPtr)likesDay7_ == (IntPtr)typeof(LikesPerDay).TypeHandle && (IntPtr)likesDay8_ == (IntPtr)typeof(LikesPerDay).TypeHandle && (IntPtr)likesDay9_ == (IntPtr)typeof(LikesPerDay).TypeHandle && (IntPtr)likesDay10_ == (IntPtr)typeof(LikesPerDay).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60073B3")]
		[Cpp2IlInjected.Address(RVA = "0x18A2C30", Offset = "0x18A1630", VA = "0x1818A2C30", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LikesPerDay other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.likesOthers_;
				if (likesOthers_ == num)
				{
					int num2 = other.likesDay1_;
					if (likesDay1_ == num2)
					{
						int num3 = other.likesDay2_;
						if (likesDay2_ == num3)
						{
							int num4 = other.likesDay3_;
							if (likesDay3_ == num4)
							{
								int num5 = other.likesDay4_;
								if (likesDay4_ == num5)
								{
									int num6 = other.likesDay5_;
									if (likesDay5_ == num6)
									{
										int num7 = other.likesDay6_;
										if (likesDay6_ == num7)
										{
											int num8 = other.likesDay7_;
											if (likesDay7_ == num8)
											{
												int num9 = other.likesDay8_;
												if (likesDay8_ == num9)
												{
													int num10 = other.likesDay9_;
													if (likesDay9_ == num10)
													{
														int num11 = other.likesDay10_;
														if (likesDay10_ == num11)
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
			int num12 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60073B4")]
		[Cpp2IlInjected.Address(RVA = "0x18A2DE0", Offset = "0x18A17E0", VA = "0x1818A2DE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (likesOthers_ != 0)
				{
				}
				if (likesDay1_ != 0)
				{
				}
				if (likesDay2_ != 0)
				{
				}
				if (likesDay3_ != 0)
				{
				}
				if (likesDay4_ != 0)
				{
				}
				if (likesDay5_ != 0)
				{
				}
				if (likesDay6_ != 0)
				{
				}
				if (likesDay7_ != 0)
				{
				}
				if (likesDay8_ != 0)
				{
				}
				if (likesDay9_ != 0)
				{
				}
				if (likesDay10_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60073B5")]
		[Cpp2IlInjected.Address(RVA = "0x18A3510", Offset = "0x18A1F10", VA = "0x1818A3510", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60073B6")]
		[Cpp2IlInjected.Address(RVA = "0x18A3570", Offset = "0x18A1F70", VA = "0x1818A3570", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0121
			if (likesOthers_ != 0)
			{
				int value = likesOthers_;
				output.WriteInt32(value);
			}
			if (likesDay1_ != 0)
			{
				int value2 = likesDay1_;
				output.WriteInt32(value2);
			}
			if (likesDay2_ != 0)
			{
				int value3 = likesDay2_;
				output.WriteInt32(value3);
			}
			if (likesDay3_ != 0)
			{
				int value4 = likesDay3_;
				output.WriteInt32(value4);
			}
			if (likesDay4_ != 0)
			{
				int value5 = likesDay4_;
				output.WriteInt32(value5);
			}
			if (likesDay5_ != 0)
			{
				int value6 = likesDay5_;
				output.WriteInt32(value6);
			}
			if (likesDay6_ != 0)
			{
				int value7 = likesDay6_;
				output.WriteInt32(value7);
			}
			if (likesDay7_ != 0)
			{
				int value8 = likesDay7_;
				output.WriteInt32(value8);
			}
			if (likesDay8_ != 0)
			{
				int value9 = likesDay8_;
				output.WriteInt32(value9);
			}
			if (likesDay9_ != 0)
			{
				int value10 = likesDay9_;
				output.WriteInt32(value10);
			}
			if (likesDay10_ != 0)
			{
				int value11 = likesDay10_;
				output.WriteInt32(value11);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60073B7")]
		[Cpp2IlInjected.Address(RVA = "0x18A2750", Offset = "0x18A1150", VA = "0x1818A2750", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = likesOthers_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = likesDay1_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				int num6 = likesDay2_;
				if (num6 != 0)
				{
					int num7 = CodedOutputStream.ComputeInt32Size(num6);
					num7++;
					num2 += num7;
				}
				int num8 = likesDay3_;
				if (num8 != 0)
				{
					int num9 = CodedOutputStream.ComputeInt32Size(num8);
					num9++;
					num2 += num9;
				}
				int num10 = likesDay4_;
				if (num10 != 0)
				{
					int num11 = CodedOutputStream.ComputeInt32Size(num10);
					num11++;
					num2 += num11;
				}
				int num12 = likesDay5_;
				if (num12 != 0)
				{
					int num13 = CodedOutputStream.ComputeInt32Size(num12);
					num13++;
					num2 += num13;
				}
				int num14 = likesDay6_;
				if (num14 != 0)
				{
					int num15 = CodedOutputStream.ComputeInt32Size(num14);
					num15 += 2;
					num2 += num15;
				}
				int num16 = likesDay7_;
				if (num16 != 0)
				{
					int num17 = CodedOutputStream.ComputeInt32Size(num16);
					num17 += 2;
					num2 += num17;
				}
				int num18 = likesDay8_;
				if (num18 != 0)
				{
					int num19 = CodedOutputStream.ComputeInt32Size(num18);
					num19 += 2;
					num2 += num19;
				}
				int num20 = likesDay9_;
				if (num20 != 0)
				{
					int num21 = CodedOutputStream.ComputeInt32Size(num20);
					num21 += 2;
					num2 += num21;
				}
				int num22 = likesDay10_;
				if (num22 != 0)
				{
					int num23 = CodedOutputStream.ComputeInt32Size(num22);
					num23 += 2;
					num2 += num23;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num24 = unknownFields.CalculateSize();
			return num24 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60073B8")]
		[Cpp2IlInjected.Address(RVA = "0x18A30E0", Offset = "0x18A1AE0", VA = "0x1818A30E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LikesPerDay other)
		{
			if (other != null)
			{
				int num = other.likesOthers_;
				if (num != 0)
				{
					likesOthers_ = num;
				}
				int num2 = other.likesDay1_;
				if (num2 != 0)
				{
					likesDay1_ = num2;
				}
				int num3 = other.likesDay2_;
				if (num3 != 0)
				{
					likesDay2_ = num3;
				}
				int num4 = other.likesDay3_;
				if (num4 != 0)
				{
					likesDay3_ = num4;
				}
				int num5 = other.likesDay4_;
				if (num5 != 0)
				{
					likesDay4_ = num5;
				}
				int num6 = other.likesDay5_;
				if (num6 != 0)
				{
					likesDay5_ = num6;
				}
				int num7 = other.likesDay6_;
				if (num7 != 0)
				{
					likesDay6_ = num7;
				}
				int num8 = other.likesDay7_;
				if (num8 != 0)
				{
					likesDay7_ = num8;
				}
				int num9 = other.likesDay8_;
				if (num9 != 0)
				{
					likesDay8_ = num9;
				}
				int num10 = other.likesDay9_;
				if (num10 != 0)
				{
					likesDay9_ = num10;
				}
				int num11 = other.likesDay10_;
				if (num11 != 0)
				{
					likesDay10_ = num11;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60073B9")]
		[Cpp2IlInjected.Address(RVA = "0x18A2F50", Offset = "0x18A1950", VA = "0x1818A2F50", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_013e
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 112)
			{
				if ((int)num > 136)
				{
					if (num == 144)
					{
						int num2 = (likesDay8_ = input.ReadInt32());
					}
					int num3 = default(int);
					if (num == 152)
					{
						num3 = (likesDay9_ = input.ReadInt32());
					}
					if (num3 != 160)
					{
						goto IL_0127;
					}
					int num4 = (likesDay10_ = input.ReadInt32());
				}
				int num5 = default(int);
				if (num == 120)
				{
					num5 = (likesDay5_ = input.ReadInt32());
				}
				int num6 = default(int);
				if (num5 == 128)
				{
					num6 = (likesDay6_ = input.ReadInt32());
				}
				if (num6 != 136)
				{
					goto IL_0127;
				}
				int num7 = (likesDay7_ = input.ReadInt32());
			}
			int num10 = default(int);
			if ((int)num > 88)
			{
				int num8 = default(int);
				if (num == 96)
				{
					num8 = (likesDay2_ = input.ReadInt32());
				}
				int num9 = default(int);
				if (num8 == 104)
				{
					num9 = (likesDay3_ = input.ReadInt32());
				}
				if (num9 != 112)
				{
					goto IL_0127;
				}
				num10 = (likesDay4_ = input.ReadInt32());
			}
			int num11 = default(int);
			if (num10 == 80)
			{
				num11 = (likesOthers_ = input.ReadInt32());
			}
			if (num11 == 88)
			{
				int num12 = (likesDay1_ = input.ReadInt32());
			}
			goto IL_0127;
			IL_0127:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60073BA")]
		[Cpp2IlInjected.Address(RVA = "0x18A2CB0", Offset = "0x18A16B0", VA = "0x1818A2CB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if ((long)typeof(int).TypeHandle <= 10)
			{
				int num = likesOthers_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60073BB")]
		[Cpp2IlInjected.Address(RVA = "0x18A31A0", Offset = "0x18A1BA0", VA = "0x1818A31A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0013, IL_001b, IL_0023, IL_002b, IL_0033, IL_003b, IL_0043, IL_004b, IL_0053, IL_005b, IL_0063
			//IL_0012: Expected I4, but got O
			if ((long)typeof(int).TypeHandle <= 10)
			{
				object obj = default(object);
				likesOthers_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60073BC")]
		[Cpp2IlInjected.Address(RVA = "0x18A29E0", Offset = "0x18A13E0", VA = "0x1818A29E0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000f, IL_0019, IL_0023, IL_002d, IL_0037, IL_0041, IL_004b, IL_0055, IL_005f, IL_0069, IL_0073
			//IL_000e: Expected I4, but got I8
			//IL_0018: Expected I4, but got I8
			//IL_0022: Expected I4, but got I8
			//IL_002c: Expected I4, but got I8
			//IL_0036: Expected I4, but got I8
			//IL_0040: Expected I4, but got I8
			//IL_004a: Expected I4, but got I8
			//IL_0054: Expected I4, but got I8
			//IL_005e: Expected I4, but got I8
			//IL_0068: Expected I4, but got I8
			//IL_0072: Expected I4, but got I8
			if (fieldNumber <= 10)
			{
				likesOthers_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60073BD")]
		[Cpp2IlInjected.Address(RVA = "0x18A3780", Offset = "0x18A2180", VA = "0x1818A3780")]
		static LikesPerDay()
		{
			Func<LikesPerDay> func = default(Func<LikesPerDay>);
			_parser = (MessageParser<LikesPerDay>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
