using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class Snapshot : IMessage<Snapshot>, IMessage, IEquatable<Snapshot>, IDeepCloneable<Snapshot>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly MessageParser<Snapshot> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public const int FedIdFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private string fedId_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public const int AliasFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private string alias_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public const int PlayerNameFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private string playerName_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public const int PlayerLevelFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int playerLevel_;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public const int GuildFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private GuildSnapshot guild_;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public const int AvatarUrlFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private string avatarUrl_ = "";

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public const int FirstLoginFieldNumber = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private long firstLogin_;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public const int LastLoginFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private long lastLogin_;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public const int LastSnapshotUpdateFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private long lastSnapshotUpdate_;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public const int IsDevFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private bool isDev_;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public const int VersionFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private string version_ = "";

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public const int FollowStatusFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private FollowStatus followStatus_;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		[DebuggerNonUserCode]
		public static MessageParser<Snapshot> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x18178D0", Offset = "0x18162D0", VA = "0x1818178D0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x1817800", Offset = "0x1816200", VA = "0x181817800")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1817930", Offset = "0x1816330", VA = "0x181817930", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		[DebuggerNonUserCode]
		public string FedId
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return fedId_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x1817B20", Offset = "0x1816520", VA = "0x181817B20")]
			set
			{
				string text = (fedId_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		[DebuggerNonUserCode]
		public string Alias
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return alias_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x1817A40", Offset = "0x1816440", VA = "0x181817A40")]
			set
			{
				string text = (alias_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		[DebuggerNonUserCode]
		public string PlayerName
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return playerName_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1817B90", Offset = "0x1816590", VA = "0x181817B90")]
			set
			{
				string text = (playerName_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		[DebuggerNonUserCode]
		public int PlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return playerLevel_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set
			{
				playerLevel_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		[DebuggerNonUserCode]
		public GuildSnapshot Guild
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return guild_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				guild_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		[DebuggerNonUserCode]
		public string AvatarUrl
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return avatarUrl_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x1817AB0", Offset = "0x18164B0", VA = "0x181817AB0")]
			set
			{
				string text = (avatarUrl_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		[DebuggerNonUserCode]
		public long FirstLogin
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return firstLogin_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x70BFD0", Offset = "0x70A9D0", VA = "0x18070BFD0")]
			set
			{
				firstLogin_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		[DebuggerNonUserCode]
		public long LastLogin
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return lastLogin_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x70BA20", Offset = "0x70A420", VA = "0x18070BA20")]
			set
			{
				lastLogin_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		[DebuggerNonUserCode]
		public long LastSnapshotUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return lastSnapshotUpdate_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B00", Offset = "0x7F5500", VA = "0x1807F6B00")]
			set
			{
				lastSnapshotUpdate_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		[DebuggerNonUserCode]
		public bool IsDev
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0")]
			get
			{
				return isDev_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x63FD00", Offset = "0x63E700", VA = "0x18063FD00")]
			set
			{
				isDev_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		[DebuggerNonUserCode]
		public string Version
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			get
			{
				return version_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x1817C00", Offset = "0x1816600", VA = "0x181817C00")]
			set
			{
				string text = (version_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		[DebuggerNonUserCode]
		public FollowStatus FollowStatus
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xDD7050", Offset = "0xDD5A50", VA = "0x180DD7050")]
			get
			{
				return followStatus_;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xDD7110", Offset = "0xDD5B10", VA = "0x180DD7110")]
			set
			{
				followStatus_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x18175C0", Offset = "0x1815FC0", VA = "0x1818175C0")]
		[DebuggerNonUserCode]
		public Snapshot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1817660", Offset = "0x1816060", VA = "0x181817660")]
		[DebuggerNonUserCode]
		public Snapshot(Snapshot other)
		{
			//IL_0096: Expected O, but got I4
			string text = (fedId_ = other.fedId_);
			string text2 = (alias_ = other.alias_);
			string text3 = (playerName_ = other.playerName_);
			int num = (playerLevel_ = other.playerLevel_);
			GuildSnapshot guildSnapshot = other.guild_;
			if (guildSnapshot != null)
			{
				GuildSnapshot guildSnapshot2 = guildSnapshot.Clone();
			}
			int num2 = 0;
			guild_ = (GuildSnapshot)num2;
			string text4 = (avatarUrl_ = other.avatarUrl_);
			long num3 = (firstLogin_ = other.firstLogin_);
			long num4 = (lastLogin_ = other.lastLogin_);
			long num5 = (lastSnapshotUpdate_ = other.lastSnapshotUpdate_);
			bool flag = (isDev_ = other.isDev_);
			string text5 = (version_ = other.version_);
			FollowStatus followStatus = (followStatus_ = other.followStatus_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x18161E0", Offset = "0x1814BE0", VA = "0x1818161E0", Slot = "10")]
		[DebuggerNonUserCode]
		public Snapshot Clone()
		{
			//Discarded unreachable code: IL_011f
			//IL_0098: Expected O, but got I4
			Snapshot snapshot = new Snapshot();
			snapshot.fedId_ = "";
			snapshot.alias_ = "";
			snapshot.playerName_ = "";
			snapshot.avatarUrl_ = "";
			snapshot.version_ = "";
			string text = (snapshot.fedId_ = fedId_);
			string text2 = (snapshot.alias_ = alias_);
			string text3 = (snapshot.playerName_ = playerName_);
			int num = (snapshot.playerLevel_ = playerLevel_);
			GuildSnapshot guildSnapshot = guild_;
			if (guildSnapshot != null)
			{
				GuildSnapshot guildSnapshot2 = guildSnapshot.Clone();
			}
			int num2 = 0;
			snapshot.guild_ = (GuildSnapshot)num2;
			string text4 = (snapshot.avatarUrl_ = avatarUrl_);
			long num3 = (snapshot.firstLogin_ = firstLogin_);
			long num4 = (snapshot.lastLogin_ = lastLogin_);
			long num5 = (snapshot.lastSnapshotUpdate_ = lastSnapshotUpdate_);
			bool flag = (snapshot.isDev_ = isDev_);
			string text5 = (snapshot.version_ = version_);
			FollowStatus followStatus = (snapshot.followStatus_ = followStatus_);
			UnknownFieldSet unknownFieldSet = (snapshot._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return snapshot;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x18163B0", Offset = "0x1814DB0", VA = "0x1818163B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = fedId_;
				bool flag = default(bool);
				if (!flag)
				{
					string text2 = alias_;
					bool flag2 = default(bool);
					if (!flag2)
					{
						string text3 = playerName_;
						bool flag3 = default(bool);
						if (!flag3 && playerLevel_ == (flag3 ? 1 : 0) && object.Equals(guild_, other))
						{
							string text4 = avatarUrl_;
							bool flag4 = default(bool);
							if (!flag4 && firstLogin_ == (flag4 ? 1 : 0) && lastLogin_ == (flag4 ? 1 : 0) && lastSnapshotUpdate_ == (flag4 ? 1 : 0) && isDev_ == flag4)
							{
								string text5 = version_;
								bool flag5 = default(bool);
								if (!flag5 && followStatus_ == (flag5 ? FollowStatus.NotFollowing : FollowStatus.Unknown))
								{
									return object.Equals(_unknownFields, other);
								}
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1816520", Offset = "0x1814F20", VA = "0x181816520", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Snapshot other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				string text = other.fedId_;
				if (!(fedId_ != text))
				{
					string text2 = other.alias_;
					if (!(alias_ != text2))
					{
						string text3 = other.playerName_;
						if (!(playerName_ != text3))
						{
							int num = other.playerLevel_;
							if (playerLevel_ == num)
							{
								GuildSnapshot objB = other.guild_;
								if (object.Equals(guild_, objB))
								{
									string text4 = other.avatarUrl_;
									if (!(avatarUrl_ != text4))
									{
										long num2 = other.firstLogin_;
										if (firstLogin_ == num2)
										{
											long num3 = other.lastLogin_;
											if (lastLogin_ == num3)
											{
												long num4 = other.lastSnapshotUpdate_;
												if (lastSnapshotUpdate_ == num4)
												{
													bool flag = other.isDev_;
													if (isDev_ == flag)
													{
														string text5 = other.version_;
														if (!(version_ != text5))
														{
															FollowStatus followStatus = other.followStatus_;
															if (followStatus_ == followStatus)
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
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1816830", Offset = "0x1815230", VA = "0x181816830", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_00e3
			int num = 0;
			string text = fedId_;
			if (text.m_stringLength != num)
			{
				int hashCode = text.GetHashCode();
			}
			string text2 = alias_;
			if (text2.m_stringLength != 0)
			{
				int hashCode2 = text2.GetHashCode();
			}
			string text3 = playerName_;
			if (text3.m_stringLength != 0)
			{
				int hashCode3 = text3.GetHashCode();
			}
			if (playerLevel_ != 0)
			{
			}
			GuildSnapshot guildSnapshot = guild_;
			if (guildSnapshot != null)
			{
				int hashCode4 = guildSnapshot.GetHashCode();
			}
			string text4 = avatarUrl_;
			if (text4.m_stringLength != 0)
			{
				int hashCode5 = text4.GetHashCode();
			}
			long num2 = firstLogin_;
			long num3 = lastLogin_;
			long num4 = lastSnapshotUpdate_;
			if (isDev_)
			{
			}
			string text5 = version_;
			if (text5.m_stringLength != 0)
			{
				int hashCode6 = text5.GetHashCode();
			}
			if (followStatus_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode7 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x18171E0", Offset = "0x1815BE0", VA = "0x1818171E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1817240", Offset = "0x1815C40", VA = "0x181817240", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_012a
			if (fedId_.m_stringLength != 0)
			{
				string value = fedId_;
				output.WriteString(value);
			}
			if (alias_.m_stringLength != 0)
			{
				string value2 = alias_;
				output.WriteString(value2);
			}
			if (playerName_.m_stringLength != 0)
			{
				string value3 = playerName_;
				output.WriteString(value3);
			}
			if (playerLevel_ != 0)
			{
				int value4 = playerLevel_;
				output.WriteInt32(value4);
			}
			if ((long)guild_ != 0)
			{
				GuildSnapshot value5 = guild_;
				output.WriteMessage(value5);
			}
			if (avatarUrl_.m_stringLength != 0)
			{
				string value6 = avatarUrl_;
				output.WriteString(value6);
			}
			long value7 = firstLogin_;
			output.WriteUInt64((ulong)value7);
			long value8 = lastLogin_;
			output.WriteUInt64((ulong)value8);
			long value9 = lastSnapshotUpdate_;
			output.WriteUInt64((ulong)value9);
			if (isDev_)
			{
				bool value10 = isDev_;
				output.WriteBool(value10);
			}
			if (version_.m_stringLength != 0)
			{
				string value11 = version_;
				output.WriteString(value11);
			}
			if (followStatus_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1815D70", Offset = "0x1814770", VA = "0x181815D70", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0176
			string text = fedId_;
			int num = 0;
			if (text.m_stringLength != num)
			{
				int num2 = CodedOutputStream.ComputeStringSize(text);
			}
			string text2 = alias_;
			if (text2.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text2);
				num3++;
				num += num3;
			}
			string text3 = playerName_;
			if (text3.m_stringLength != 0)
			{
				int num4 = CodedOutputStream.ComputeStringSize(text3);
				num4++;
				num += num4;
			}
			int num5 = playerLevel_;
			if (num5 != 0)
			{
				int num6 = CodedOutputStream.ComputeInt32Size(num5);
				num6++;
				num += num6;
			}
			GuildSnapshot guildSnapshot = guild_;
			if (guildSnapshot != null)
			{
				int num7 = CodedOutputStream.ComputeMessageSize(guildSnapshot);
				num7++;
				num += num7;
			}
			string text4 = avatarUrl_;
			if (text4.m_stringLength != 0)
			{
				int num8 = CodedOutputStream.ComputeStringSize(text4);
				num8++;
				num += num8;
			}
			int num9 = CodedOutputStream.ComputeInt64Size(firstLogin_);
			num9++;
			num += num9;
			int num10 = CodedOutputStream.ComputeInt64Size(lastLogin_);
			num10++;
			num += num10;
			int num11 = CodedOutputStream.ComputeInt64Size(lastSnapshotUpdate_);
			num11++;
			num += num11;
			string text5 = version_;
			if (text5.m_stringLength != 0)
			{
				int num12 = CodedOutputStream.ComputeStringSize(text5);
				num12++;
				num += num12;
			}
			FollowStatus followStatus = followStatus_;
			if (followStatus != 0)
			{
				int num13 = CodedOutputStream.ComputeEnumSize((int)followStatus);
				num13++;
				num += num13;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num14 = unknownFields.CalculateSize();
				num += num14;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x1816A00", Offset = "0x1815400", VA = "0x181816A00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Snapshot other)
		{
			//Discarded unreachable code: IL_0148
			if (other == null)
			{
				return;
			}
			string text = other.fedId_;
			if (text.m_stringLength != 0)
			{
				FedId = text;
			}
			string text2 = other.alias_;
			if (text2.m_stringLength != 0)
			{
				Alias = text2;
			}
			string text3 = other.playerName_;
			if (text3.m_stringLength != 0)
			{
				PlayerName = text3;
			}
			int num = other.playerLevel_;
			if (num != 0)
			{
				playerLevel_ = num;
			}
			if ((long)other.guild_ != 0)
			{
				GuildSnapshot guildSnapshot2 = default(GuildSnapshot);
				if (guild_ == null)
				{
					GuildSnapshot guildSnapshot = (guild_ = new GuildSnapshot());
					guildSnapshot2 = guild_;
				}
				GuildSnapshot other2 = other.guild_;
				guildSnapshot2.MergeFrom(other2);
			}
			string text4 = other.avatarUrl_;
			if (text4.m_stringLength != 0)
			{
				AvatarUrl = text4;
			}
			long num2 = (firstLogin_ = other.firstLogin_);
			long num3 = (lastLogin_ = other.lastLogin_);
			long num4 = (lastSnapshotUpdate_ = other.lastSnapshotUpdate_);
			bool flag = other.isDev_;
			if (flag)
			{
				isDev_ = flag;
			}
			string text5 = other.version_;
			if (text5.m_stringLength != 0)
			{
				Version = text5;
			}
			FollowStatus followStatus = other.followStatus_;
			if (followStatus != 0)
			{
				followStatus_ = followStatus;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1816BB0", Offset = "0x18155B0", VA = "0x181816BB0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0169
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			ulong num5 = default(ulong);
			if ((int)num > 50)
			{
				int num2 = default(int);
				if ((int)num > 72)
				{
					bool flag = default(bool);
					if (num == 80)
					{
						flag = (isDev_ = input.ReadBool());
					}
					string text2 = default(string);
					if (flag)
					{
						text2 = (Version = input.ReadString());
					}
					if ((long)text2 != 96)
					{
						goto IL_0152;
					}
					num2 = (int)(followStatus_ = (FollowStatus)input.ReadInt32());
				}
				ulong num3 = default(ulong);
				if (num2 == 56)
				{
					num3 = (ulong)(firstLogin_ = (long)input.ReadUInt64());
				}
				ulong num4 = default(ulong);
				if (num3 == 64)
				{
					num4 = (ulong)(lastLogin_ = (long)input.ReadUInt64());
				}
				if (num4 != 72)
				{
					goto IL_0152;
				}
				num5 = (ulong)(lastSnapshotUpdate_ = (long)input.ReadUInt64());
			}
			string text4 = default(string);
			if ((long)num5 > 26L)
			{
				int num6 = default(int);
				if (num5 == 32)
				{
					num6 = (playerLevel_ = input.ReadInt32());
				}
				GuildSnapshot guildSnapshot = default(GuildSnapshot);
				if (num6 == 42)
				{
					GuildSnapshot builder = default(GuildSnapshot);
					if (guild_ == null)
					{
						guildSnapshot = (guild_ = new GuildSnapshot());
						builder = guild_;
					}
					input.ReadMessage(builder);
				}
				if ((long)guildSnapshot != 50)
				{
					goto IL_0152;
				}
				text4 = (AvatarUrl = input.ReadString());
			}
			string text6 = default(string);
			if ((long)text4 == 10)
			{
				text6 = (FedId = input.ReadString());
			}
			string text8 = default(string);
			if ((long)text6 == 18)
			{
				text8 = (Alias = input.ReadString());
			}
			if ((long)text8 == 26)
			{
				string text10 = (PlayerName = input.ReadString());
			}
			goto IL_0152;
			IL_0152:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1816640", Offset = "0x1815040", VA = "0x181816640", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 11)
			{
				string text = fedId_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1816DE0", Offset = "0x18157E0", VA = "0x181816DE0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0019, IL_001a, IL_001b, IL_0028, IL_0030, IL_0038, IL_0045, IL_004d, IL_0055, IL_005d, IL_0065, IL_0066, IL_0073, IL_007b, IL_0087, IL_008d, IL_0093, IL_0099, IL_009f, IL_00a5, IL_00ab, IL_00b1
			//IL_0018: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			//IL_004c: Expected I8, but got I4
			//IL_0054: Expected I8, but got I4
			//IL_005c: Expected I8, but got I4
			if (fieldNumber - 1 <= 11)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				FedId = (string)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1816050", Offset = "0x1814A50", VA = "0x181816050", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_001a, IL_001b, IL_001c, IL_001d, IL_001f
			int num = fieldNumber - 1;
			if (num <= 11)
			{
				FedId = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x18174B0", Offset = "0x1815EB0", VA = "0x1818174B0")]
		static Snapshot()
		{
			Func<Snapshot> func = default(Func<Snapshot>);
			_parser = (MessageParser<Snapshot>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
