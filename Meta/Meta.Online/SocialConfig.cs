using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000E37")]
	public sealed class SocialConfig : IMessage<SocialConfig>, IMessage, IEquatable<SocialConfig>, IDeepCloneable<SocialConfig>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400397E")]
		private static readonly MessageParser<SocialConfig> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400397F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4003980")]
		public const int MaxFollowersFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003981")]
		private int maxFollowers_;

		[Cpp2IlInjected.Token(Token = "0x4003982")]
		public const int MaxFolloweesFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4003983")]
		private int maxFollowees_;

		[Cpp2IlInjected.Token(Token = "0x4003984")]
		public const int AddConnectionMaxRetriesFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003985")]
		private int addConnectionMaxRetries_;

		[Cpp2IlInjected.Token(Token = "0x4003986")]
		public const int BakeNewsFeedMaxFolloweesFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003987")]
		private int bakeNewsFeedMaxFollowees_;

		[Cpp2IlInjected.Token(Token = "0x4003988")]
		public const int ListConnectionsMaxProfilesToFetchFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003989")]
		private int listConnectionsMaxProfilesToFetch_;

		[Cpp2IlInjected.Token(Token = "0x400398A")]
		public const int MaxStoredPicturesFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400398B")]
		private int maxStoredPictures_;

		[Cpp2IlInjected.Token(Token = "0x400398C")]
		public const int MaxUploadPicturePerDayFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400398D")]
		private int maxUploadPicturePerDay_;

		[Cpp2IlInjected.Token(Token = "0x400398E")]
		public const int MaxLikePerDayFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400398F")]
		private int maxLikePerDay_;

		[Cpp2IlInjected.Token(Token = "0x4003990")]
		public const int MaxAddRemoveFolloweePerDayFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003991")]
		private int maxAddRemoveFolloweePerDay_;

		[Cpp2IlInjected.Token(Token = "0x170014DD")]
		[DebuggerNonUserCode]
		public static MessageParser<SocialConfig> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60077BF")]
			[Cpp2IlInjected.Address(RVA = "0x1818CD0", Offset = "0x18176D0", VA = "0x181818CD0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014DE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60077C0")]
			[Cpp2IlInjected.Address(RVA = "0x1818C00", Offset = "0x1817600", VA = "0x181818C00")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014DF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60077C1")]
			[Cpp2IlInjected.Address(RVA = "0x1818D30", Offset = "0x1817730", VA = "0x181818D30", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E0")]
		[DebuggerNonUserCode]
		public int MaxFollowers
		{
			[Cpp2IlInjected.Token(Token = "0x60077C5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return maxFollowers_;
			}
			[Cpp2IlInjected.Token(Token = "0x60077C6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				maxFollowers_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E1")]
		[DebuggerNonUserCode]
		public int MaxFollowees
		{
			[Cpp2IlInjected.Token(Token = "0x60077C7")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return maxFollowees_;
			}
			[Cpp2IlInjected.Token(Token = "0x60077C8")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				maxFollowees_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E2")]
		[DebuggerNonUserCode]
		public int AddConnectionMaxRetries
		{
			[Cpp2IlInjected.Token(Token = "0x60077C9")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return addConnectionMaxRetries_;
			}
			[Cpp2IlInjected.Token(Token = "0x60077CA")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				addConnectionMaxRetries_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E3")]
		[DebuggerNonUserCode]
		public int BakeNewsFeedMaxFollowees
		{
			[Cpp2IlInjected.Token(Token = "0x60077CB")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return bakeNewsFeedMaxFollowees_;
			}
			[Cpp2IlInjected.Token(Token = "0x60077CC")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set
			{
				bakeNewsFeedMaxFollowees_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E4")]
		[DebuggerNonUserCode]
		public int ListConnectionsMaxProfilesToFetch
		{
			[Cpp2IlInjected.Token(Token = "0x60077CD")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return listConnectionsMaxProfilesToFetch_;
			}
			[Cpp2IlInjected.Token(Token = "0x60077CE")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				listConnectionsMaxProfilesToFetch_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E5")]
		[DebuggerNonUserCode]
		public int MaxStoredPictures
		{
			[Cpp2IlInjected.Token(Token = "0x60077CF")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return maxStoredPictures_;
			}
			[Cpp2IlInjected.Token(Token = "0x60077D0")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set
			{
				maxStoredPictures_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E6")]
		[DebuggerNonUserCode]
		public int MaxUploadPicturePerDay
		{
			[Cpp2IlInjected.Token(Token = "0x60077D1")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return maxUploadPicturePerDay_;
			}
			[Cpp2IlInjected.Token(Token = "0x60077D2")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				maxUploadPicturePerDay_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E7")]
		[DebuggerNonUserCode]
		public int MaxLikePerDay
		{
			[Cpp2IlInjected.Token(Token = "0x60077D3")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get
			{
				return maxLikePerDay_;
			}
			[Cpp2IlInjected.Token(Token = "0x60077D4")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set
			{
				maxLikePerDay_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170014E8")]
		[DebuggerNonUserCode]
		public int MaxAddRemoveFolloweePerDay
		{
			[Cpp2IlInjected.Token(Token = "0x60077D5")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return maxAddRemoveFolloweePerDay_;
			}
			[Cpp2IlInjected.Token(Token = "0x60077D6")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				maxAddRemoveFolloweePerDay_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60077C2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SocialConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60077C3")]
		[Cpp2IlInjected.Address(RVA = "0x1818B80", Offset = "0x1817580", VA = "0x181818B80")]
		[DebuggerNonUserCode]
		public SocialConfig(SocialConfig other)
		{
			int num = (maxFollowers_ = other.maxFollowers_);
			int num2 = (maxFollowees_ = other.maxFollowees_);
			int num3 = (addConnectionMaxRetries_ = other.addConnectionMaxRetries_);
			int num4 = (bakeNewsFeedMaxFollowees_ = other.bakeNewsFeedMaxFollowees_);
			int num5 = (listConnectionsMaxProfilesToFetch_ = other.listConnectionsMaxProfilesToFetch_);
			int num6 = (maxStoredPictures_ = other.maxStoredPictures_);
			int num7 = (maxUploadPicturePerDay_ = other.maxUploadPicturePerDay_);
			int num8 = (maxLikePerDay_ = other.maxLikePerDay_);
			int num9 = (maxAddRemoveFolloweePerDay_ = other.maxAddRemoveFolloweePerDay_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60077C4")]
		[Cpp2IlInjected.Address(RVA = "0x1817F30", Offset = "0x1816930", VA = "0x181817F30", Slot = "10")]
		[DebuggerNonUserCode]
		public SocialConfig Clone()
		{
			//Discarded unreachable code: IL_00a7
			SocialConfig socialConfig = new SocialConfig();
			int num = (socialConfig.maxFollowers_ = maxFollowers_);
			int num2 = (socialConfig.maxFollowees_ = maxFollowees_);
			int num3 = (socialConfig.addConnectionMaxRetries_ = addConnectionMaxRetries_);
			int num4 = (socialConfig.bakeNewsFeedMaxFollowees_ = bakeNewsFeedMaxFollowees_);
			int num5 = (socialConfig.listConnectionsMaxProfilesToFetch_ = listConnectionsMaxProfilesToFetch_);
			int num6 = (socialConfig.maxStoredPictures_ = maxStoredPictures_);
			int num7 = (socialConfig.maxUploadPicturePerDay_ = maxUploadPicturePerDay_);
			int num8 = (socialConfig.maxLikePerDay_ = maxLikePerDay_);
			int num9 = (socialConfig.maxAddRemoveFolloweePerDay_ = maxAddRemoveFolloweePerDay_);
			UnknownFieldSet unknownFieldSet = (socialConfig._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return socialConfig;
		}

		[Cpp2IlInjected.Token(Token = "0x60077D7")]
		[Cpp2IlInjected.Address(RVA = "0x1817FE0", Offset = "0x18169E0", VA = "0x181817FE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)maxFollowers_ == (IntPtr)typeof(SocialConfig).TypeHandle && (IntPtr)maxFollowees_ == (IntPtr)typeof(SocialConfig).TypeHandle && (IntPtr)addConnectionMaxRetries_ == (IntPtr)typeof(SocialConfig).TypeHandle && (IntPtr)bakeNewsFeedMaxFollowees_ == (IntPtr)typeof(SocialConfig).TypeHandle && (IntPtr)listConnectionsMaxProfilesToFetch_ == (IntPtr)typeof(SocialConfig).TypeHandle && (IntPtr)maxStoredPictures_ == (IntPtr)typeof(SocialConfig).TypeHandle && (IntPtr)maxUploadPicturePerDay_ == (IntPtr)typeof(SocialConfig).TypeHandle && (IntPtr)maxLikePerDay_ == (IntPtr)typeof(SocialConfig).TypeHandle && (IntPtr)maxAddRemoveFolloweePerDay_ == (IntPtr)typeof(SocialConfig).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60077D8")]
		[Cpp2IlInjected.Address(RVA = "0x18180B0", Offset = "0x1816AB0", VA = "0x1818180B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SocialConfig other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.maxFollowers_;
				if (maxFollowers_ == num)
				{
					int num2 = other.maxFollowees_;
					if (maxFollowees_ == num2)
					{
						int num3 = other.addConnectionMaxRetries_;
						if (addConnectionMaxRetries_ == num3)
						{
							int num4 = other.bakeNewsFeedMaxFollowees_;
							if (bakeNewsFeedMaxFollowees_ == num4)
							{
								int num5 = other.listConnectionsMaxProfilesToFetch_;
								if (listConnectionsMaxProfilesToFetch_ == num5)
								{
									int num6 = other.maxStoredPictures_;
									if (maxStoredPictures_ == num6)
									{
										int num7 = other.maxUploadPicturePerDay_;
										if (maxUploadPicturePerDay_ == num7)
										{
											int num8 = other.maxLikePerDay_;
											if (maxLikePerDay_ == num8)
											{
												int num9 = other.maxAddRemoveFolloweePerDay_;
												if (maxAddRemoveFolloweePerDay_ == num9)
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
			int num10 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60077D9")]
		[Cpp2IlInjected.Address(RVA = "0x1818240", Offset = "0x1816C40", VA = "0x181818240", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (maxFollowers_ != 0)
				{
				}
				if (maxFollowees_ != 0)
				{
				}
				if (addConnectionMaxRetries_ != 0)
				{
				}
				if (bakeNewsFeedMaxFollowees_ != 0)
				{
				}
				if (listConnectionsMaxProfilesToFetch_ != 0)
				{
				}
				if (maxStoredPictures_ != 0)
				{
				}
				if (maxUploadPicturePerDay_ != 0)
				{
				}
				if (maxLikePerDay_ != 0)
				{
				}
				if (maxAddRemoveFolloweePerDay_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60077DA")]
		[Cpp2IlInjected.Address(RVA = "0x1818860", Offset = "0x1817260", VA = "0x181818860", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60077DB")]
		[Cpp2IlInjected.Address(RVA = "0x18188C0", Offset = "0x18172C0", VA = "0x1818188C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_00ef
			if (maxFollowers_ != 0)
			{
				int value = maxFollowers_;
				output.WriteInt32(value);
			}
			if (maxFollowees_ != 0)
			{
				int value2 = maxFollowees_;
				output.WriteInt32(value2);
			}
			if (addConnectionMaxRetries_ != 0)
			{
				int value3 = addConnectionMaxRetries_;
				output.WriteInt32(value3);
			}
			if (bakeNewsFeedMaxFollowees_ != 0)
			{
				int value4 = bakeNewsFeedMaxFollowees_;
				output.WriteInt32(value4);
			}
			if (listConnectionsMaxProfilesToFetch_ != 0)
			{
				int value5 = listConnectionsMaxProfilesToFetch_;
				output.WriteInt32(value5);
			}
			if (maxStoredPictures_ != 0)
			{
				int value6 = maxStoredPictures_;
				output.WriteInt32(value6);
			}
			if (maxUploadPicturePerDay_ != 0)
			{
				int value7 = maxUploadPicturePerDay_;
				output.WriteInt32(value7);
			}
			if (maxLikePerDay_ != 0)
			{
				int value8 = maxLikePerDay_;
				output.WriteInt32(value8);
			}
			if (maxAddRemoveFolloweePerDay_ != 0)
			{
				int value9 = maxAddRemoveFolloweePerDay_;
				output.WriteInt32(value9);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60077DC")]
		[Cpp2IlInjected.Address(RVA = "0x1817C70", Offset = "0x1816670", VA = "0x181817C70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = maxFollowers_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = maxFollowees_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				int num6 = addConnectionMaxRetries_;
				if (num6 != 0)
				{
					int num7 = CodedOutputStream.ComputeInt32Size(num6);
					num7++;
					num2 += num7;
				}
				int num8 = bakeNewsFeedMaxFollowees_;
				if (num8 != 0)
				{
					int num9 = CodedOutputStream.ComputeInt32Size(num8);
					num9++;
					num2 += num9;
				}
				int num10 = listConnectionsMaxProfilesToFetch_;
				if (num10 != 0)
				{
					int num11 = CodedOutputStream.ComputeInt32Size(num10);
					num11++;
					num2 += num11;
				}
				int num12 = maxStoredPictures_;
				if (num12 != 0)
				{
					int num13 = CodedOutputStream.ComputeInt32Size(num12);
					num13++;
					num2 += num13;
				}
				int num14 = maxUploadPicturePerDay_;
				if (num14 != 0)
				{
					int num15 = CodedOutputStream.ComputeInt32Size(num14);
					num15++;
					num2 += num15;
				}
				int num16 = maxLikePerDay_;
				if (num16 != 0)
				{
					int num17 = CodedOutputStream.ComputeInt32Size(num16);
					num17++;
					num2 += num17;
				}
				int num18 = maxAddRemoveFolloweePerDay_;
				if (num18 != 0)
				{
					int num19 = CodedOutputStream.ComputeInt32Size(num18);
					num19++;
					num2 += num19;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num20 = unknownFields.CalculateSize();
			return num20 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60077DD")]
		[Cpp2IlInjected.Address(RVA = "0x1818380", Offset = "0x1816D80", VA = "0x181818380", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SocialConfig other)
		{
			if (other != null)
			{
				int num = other.maxFollowers_;
				if (num != 0)
				{
					maxFollowers_ = num;
				}
				int num2 = other.maxFollowees_;
				if (num2 != 0)
				{
					maxFollowees_ = num2;
				}
				int num3 = other.addConnectionMaxRetries_;
				if (num3 != 0)
				{
					addConnectionMaxRetries_ = num3;
				}
				int num4 = other.bakeNewsFeedMaxFollowees_;
				if (num4 != 0)
				{
					bakeNewsFeedMaxFollowees_ = num4;
				}
				int num5 = other.listConnectionsMaxProfilesToFetch_;
				if (num5 != 0)
				{
					listConnectionsMaxProfilesToFetch_ = num5;
				}
				int num6 = other.maxStoredPictures_;
				if (num6 != 0)
				{
					maxStoredPictures_ = num6;
				}
				int num7 = other.maxUploadPicturePerDay_;
				if (num7 != 0)
				{
					maxUploadPicturePerDay_ = num7;
				}
				int num8 = other.maxLikePerDay_;
				if (num8 != 0)
				{
					maxLikePerDay_ = num8;
				}
				int num9 = other.maxAddRemoveFolloweePerDay_;
				if (num9 != 0)
				{
					maxAddRemoveFolloweePerDay_ = num9;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60077DE")]
		[Cpp2IlInjected.Address(RVA = "0x1818430", Offset = "0x1816E30", VA = "0x181818430", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_00f9
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 32)
			{
				if ((int)num > 48)
				{
					if (num == 56)
					{
						int num2 = (maxUploadPicturePerDay_ = input.ReadInt32());
					}
					int num3 = default(int);
					if (num == 64)
					{
						num3 = (maxLikePerDay_ = input.ReadInt32());
					}
					if (num3 != 72)
					{
						goto IL_00e2;
					}
					int num4 = (maxAddRemoveFolloweePerDay_ = input.ReadInt32());
				}
				int num5 = default(int);
				if (num == 40)
				{
					num5 = (listConnectionsMaxProfilesToFetch_ = input.ReadInt32());
				}
				if (num5 != 48)
				{
					goto IL_00e2;
				}
				int num6 = (maxStoredPictures_ = input.ReadInt32());
			}
			int num8 = default(int);
			if ((int)num > 16)
			{
				int num7 = default(int);
				if (num == 24)
				{
					num7 = (addConnectionMaxRetries_ = input.ReadInt32());
				}
				if (num7 != 32)
				{
					goto IL_00e2;
				}
				num8 = (bakeNewsFeedMaxFollowees_ = input.ReadInt32());
			}
			int num9 = default(int);
			if (num8 == 8)
			{
				num9 = (maxFollowers_ = input.ReadInt32());
			}
			if (num9 == 16)
			{
				int num10 = (maxFollowees_ = input.ReadInt32());
			}
			goto IL_00e2;
			IL_00e2:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60077DF")]
		[Cpp2IlInjected.Address(RVA = "0x1818120", Offset = "0x1816B20", VA = "0x181818120", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 8)
			{
				int num = maxFollowers_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60077E0")]
		[Cpp2IlInjected.Address(RVA = "0x1818580", Offset = "0x1816F80", VA = "0x181818580", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000e, IL_000f, IL_0010, IL_0011, IL_0012, IL_0013, IL_0014, IL_0015, IL_0016
			//IL_000d: Expected I4, but got O
			if (fieldNumber - 1 <= 8)
			{
				object obj = default(object);
				maxFollowers_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60077E1")]
		[Cpp2IlInjected.Address(RVA = "0x1817EA0", Offset = "0x18168A0", VA = "0x181817EA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000e, IL_0018, IL_0022, IL_002c, IL_0036, IL_0040, IL_004a, IL_0054, IL_005e, IL_0062, IL_0066, IL_006a, IL_006e, IL_0072, IL_0076, IL_007a, IL_007e, IL_0082, IL_0086
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			//IL_002b: Expected I4, but got I8
			//IL_0035: Expected I4, but got I8
			//IL_003f: Expected I4, but got I8
			//IL_0049: Expected I4, but got I8
			//IL_0053: Expected I4, but got I8
			//IL_005d: Expected I4, but got I8
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected I4, but got Unknown
			if (fieldNumber <= 8)
			{
				maxFollowers_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60077E2")]
		[Cpp2IlInjected.Address(RVA = "0x1818A70", Offset = "0x1817470", VA = "0x181818A70")]
		static SocialConfig()
		{
			Func<SocialConfig> func = default(Func<SocialConfig>);
			_parser = (MessageParser<SocialConfig>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
