using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Gameloft.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000926")]
	public sealed class ProfileGameInfo : IMessage<ProfileGameInfo>, IMessage, IEquatable<ProfileGameInfo>, IDeepCloneable<ProfileGameInfo>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400251D")]
		private static readonly MessageParser<ProfileGameInfo> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400251E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400251F")]
		public const int InitialVersionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002520")]
		private int initialVersion_;

		[Cpp2IlInjected.Token(Token = "0x4002521")]
		public const int VersionFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002522")]
		private int version_;

		[Cpp2IlInjected.Token(Token = "0x4002523")]
		public const int HighestGameVersionFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002524")]
		private string highestGameVersion_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002525")]
		public const int CreatedFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002526")]
		private Timestamp created_;

		[Cpp2IlInjected.Token(Token = "0x4002527")]
		public const int ModifiedFieldNumber = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002528")]
		private Timestamp modified_;

		[Cpp2IlInjected.Token(Token = "0x4002529")]
		public const int LastLoginFieldNumber = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400252A")]
		private Timestamp lastLogin_;

		[Cpp2IlInjected.Token(Token = "0x400252B")]
		public const int AccountLinkingInfosFieldNumber = 7;

		[Cpp2IlInjected.Token(Token = "0x400252C")]
		private static readonly FieldCodec<AccountLinkingInfo> _repeated_accountLinkingInfos_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400252D")]
		private readonly RepeatedField<AccountLinkingInfo> accountLinkingInfos_ = (RepeatedField<AccountLinkingInfo>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400252E")]
		public const int LastSaveDeviceInfoFieldNumber = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400252F")]
		private DeviceInfo lastSaveDeviceInfo_;

		[Cpp2IlInjected.Token(Token = "0x4002530")]
		public const int ProfileUIDFieldNumber = 9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002531")]
		private string profileUID_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002532")]
		public const int RevisionFieldNumber = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002533")]
		private ulong revision_;

		[Cpp2IlInjected.Token(Token = "0x4002534")]
		public const int LastCustomIdOwnerFieldNumber = 11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002535")]
		private string lastCustomIdOwner_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002536")]
		public const int OnlineVersionFieldNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002537")]
		private int onlineVersion_;

		[Cpp2IlInjected.Token(Token = "0x4002538")]
		public const int SessionFieldNumber = 14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4002539")]
		private int session_;

		[Cpp2IlInjected.Token(Token = "0x400253A")]
		public const int HistorysFieldNumber = 16;

		[Cpp2IlInjected.Token(Token = "0x400253B")]
		private static readonly FieldCodec<string> _repeated_historys_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400253C")]
		private readonly RepeatedField<string> historys_ = (RepeatedField<string>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400253D")]
		public const int LastUploadTimeFieldNumber = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400253E")]
		private Timestamp lastUploadTime_;

		[Cpp2IlInjected.Token(Token = "0x400253F")]
		private static List<string> CreatedPUIds;

		[Cpp2IlInjected.Token(Token = "0x17000D98")]
		[DebuggerNonUserCode]
		public static MessageParser<ProfileGameInfo> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004FA2")]
			[Cpp2IlInjected.Address(RVA = "0x960480", Offset = "0x95EE80", VA = "0x180960480")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D99")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004FA3")]
			[Cpp2IlInjected.Address(RVA = "0x960320", Offset = "0x95ED20", VA = "0x180960320")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D9A")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004FA4")]
			[Cpp2IlInjected.Address(RVA = "0x9604F0", Offset = "0x95EEF0", VA = "0x1809604F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D9B")]
		[DebuggerNonUserCode]
		public int InitialVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6004FA9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return initialVersion_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FAA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				initialVersion_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D9C")]
		[DebuggerNonUserCode]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6004FAB")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return version_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FAC")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				version_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D9D")]
		[DebuggerNonUserCode]
		public string HighestGameVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6004FAD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return highestGameVersion_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FAE")]
			[Cpp2IlInjected.Address(RVA = "0x960600", Offset = "0x95F000", VA = "0x180960600")]
			set
			{
				string text = (highestGameVersion_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D9E")]
		[DebuggerNonUserCode]
		public Timestamp Created
		{
			[Cpp2IlInjected.Token(Token = "0x6004FAF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return created_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FB0")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				created_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D9F")]
		[DebuggerNonUserCode]
		public Timestamp Modified
		{
			[Cpp2IlInjected.Token(Token = "0x6004FB1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return modified_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FB2")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				modified_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA0")]
		[DebuggerNonUserCode]
		public Timestamp LastLogin
		{
			[Cpp2IlInjected.Token(Token = "0x6004FB3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return lastLogin_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FB4")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				lastLogin_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA1")]
		[DebuggerNonUserCode]
		public RepeatedField<AccountLinkingInfo> AccountLinkingInfos
		{
			[Cpp2IlInjected.Token(Token = "0x6004FB5")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return accountLinkingInfos_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA2")]
		[DebuggerNonUserCode]
		public DeviceInfo LastSaveDeviceInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6004FB6")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return lastSaveDeviceInfo_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FB7")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				lastSaveDeviceInfo_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA3")]
		[DebuggerNonUserCode]
		public string ProfileUID
		{
			[Cpp2IlInjected.Token(Token = "0x6004FB8")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return profileUID_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FB9")]
			[Cpp2IlInjected.Address(RVA = "0x9606E0", Offset = "0x95F0E0", VA = "0x1809606E0")]
			set
			{
				string text = (profileUID_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA4")]
		[DebuggerNonUserCode]
		public ulong Revision
		{
			[Cpp2IlInjected.Token(Token = "0x6004FBA")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return revision_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FBB")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B00", Offset = "0x7F5500", VA = "0x1807F6B00")]
			set
			{
				revision_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA5")]
		[DebuggerNonUserCode]
		public string LastCustomIdOwner
		{
			[Cpp2IlInjected.Token(Token = "0x6004FBC")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return lastCustomIdOwner_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FBD")]
			[Cpp2IlInjected.Address(RVA = "0x960670", Offset = "0x95F070", VA = "0x180960670")]
			set
			{
				string text = (lastCustomIdOwner_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA6")]
		[DebuggerNonUserCode]
		public int OnlineVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6004FBE")]
			[Cpp2IlInjected.Address(RVA = "0x724F70", Offset = "0x723970", VA = "0x180724F70")]
			get
			{
				return onlineVersion_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FBF")]
			[Cpp2IlInjected.Address(RVA = "0x7252F0", Offset = "0x723CF0", VA = "0x1807252F0")]
			set
			{
				onlineVersion_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA7")]
		[DebuggerNonUserCode]
		public int Session
		{
			[Cpp2IlInjected.Token(Token = "0x6004FC0")]
			[Cpp2IlInjected.Address(RVA = "0x9604E0", Offset = "0x95EEE0", VA = "0x1809604E0")]
			get
			{
				return session_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FC1")]
			[Cpp2IlInjected.Address(RVA = "0x960750", Offset = "0x95F150", VA = "0x180960750")]
			set
			{
				session_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA8")]
		[DebuggerNonUserCode]
		public RepeatedField<string> Historys
		{
			[Cpp2IlInjected.Token(Token = "0x6004FC2")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return historys_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DA9")]
		[DebuggerNonUserCode]
		public Timestamp LastUploadTime
		{
			[Cpp2IlInjected.Token(Token = "0x6004FC3")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return lastUploadTime_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FC4")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			set
			{
				lastUploadTime_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DAA")]
		public DeviceInfo DeviceInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6004FD0")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			[CompilerGenerated]
			get
			{
				return _003CDeviceInfo_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6004FD1")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000DAB")]
		public bool IsProfileCreatedInThisSession
		{
			[Cpp2IlInjected.Token(Token = "0x6004FD3")]
			[Cpp2IlInjected.Address(RVA = "0x9603F0", Offset = "0x95EDF0", VA = "0x1809603F0")]
			get
			{
				//Discarded unreachable code: IL_0015
				List<string> createdPUIds = CreatedPUIds;
				string item = profileUID_;
				return ((List<T>)(object)createdPUIds).Contains((T)item);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FA5")]
		[Cpp2IlInjected.Address(RVA = "0x9601C0", Offset = "0x95EBC0", VA = "0x1809601C0")]
		[DebuggerNonUserCode]
		public ProfileGameInfo()
		{
			initialVersion_ = (version_ = Profile.CurrentVersion);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FA6")]
		[Cpp2IlInjected.Address(RVA = "0x95EF40", Offset = "0x95D940", VA = "0x18095EF40")]
		private void OnConstruction()
		{
			initialVersion_ = (version_ = Profile.CurrentVersion);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FA7")]
		[Cpp2IlInjected.Address(RVA = "0x95FE90", Offset = "0x95E890", VA = "0x18095FE90")]
		[DebuggerNonUserCode]
		public ProfileGameInfo(ProfileGameInfo other)
		{
			//IL_00a4: Expected O, but got I4
			//IL_00c2: Expected O, but got I4
			//IL_00e0: Expected O, but got I4
			//IL_0113: Expected O, but got I4
			initialVersion_ = (version_ = Profile.CurrentVersion);
			int num = (initialVersion_ = other.initialVersion_);
			int num2 = (version_ = other.version_);
			string text = (highestGameVersion_ = other.highestGameVersion_);
			Timestamp timestamp = other.created_;
			int num3 = 0;
			if (timestamp != null)
			{
				Timestamp timestamp2 = timestamp.Clone();
			}
			created_ = (Timestamp)num3;
			Timestamp timestamp3 = other.modified_;
			if (timestamp3 != null)
			{
				Timestamp timestamp4 = timestamp3.Clone();
			}
			modified_ = (Timestamp)num3;
			Timestamp timestamp5 = other.lastLogin_;
			if (timestamp5 != null)
			{
				Timestamp timestamp6 = timestamp5.Clone();
			}
			lastLogin_ = (Timestamp)num3;
			RepeatedField<AccountLinkingInfo> repeatedField = (accountLinkingInfos_ = (RepeatedField<AccountLinkingInfo>)(object)((RepeatedField<T>)(object)other.accountLinkingInfos_).Clone());
			DeviceInfo deviceInfo = other.lastSaveDeviceInfo_;
			if (deviceInfo != null)
			{
				DeviceInfo deviceInfo2 = deviceInfo.Clone();
			}
			lastSaveDeviceInfo_ = (DeviceInfo)num3;
			string text2 = (profileUID_ = other.profileUID_);
			ulong num4 = (revision_ = other.revision_);
			string text3 = (lastCustomIdOwner_ = other.lastCustomIdOwner_);
			int num5 = (onlineVersion_ = other.onlineVersion_);
			int num6 = (session_ = other.session_);
			RepeatedField<string> repeatedField2 = (historys_ = (RepeatedField<string>)(object)((RepeatedField<T>)(object)other.historys_).Clone());
			Timestamp timestamp7 = other.lastUploadTime_;
			Timestamp timestamp8 = default(Timestamp);
			if (timestamp7 != null)
			{
				timestamp8 = timestamp7.Clone();
			}
			lastUploadTime_ = timestamp8;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004FA8")]
		[Cpp2IlInjected.Address(RVA = "0x95E170", Offset = "0x95CB70", VA = "0x18095E170", Slot = "10")]
		[DebuggerNonUserCode]
		public ProfileGameInfo Clone()
		{
			return new ProfileGameInfo(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FC5")]
		[Cpp2IlInjected.Address(RVA = "0x95E1D0", Offset = "0x95CBD0", VA = "0x18095E1D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			if (other != null)
			{
			}
			return Equals((ProfileGameInfo)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FC6")]
		[Cpp2IlInjected.Address(RVA = "0x95E230", Offset = "0x95CC30", VA = "0x18095E230", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ProfileGameInfo other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.initialVersion_;
				if ((IntPtr)CreatedPUIds == (IntPtr)num)
				{
					int num2 = other.version_;
					if (version_ == num2)
					{
						string text = other.highestGameVersion_;
						if (!(highestGameVersion_ != text))
						{
							Timestamp objB = other.created_;
							if (object.Equals(created_, objB))
							{
								Timestamp objB2 = other.modified_;
								if (object.Equals(modified_, objB2))
								{
									Timestamp objB3 = other.lastLogin_;
									if (object.Equals(lastLogin_, objB3))
									{
										RepeatedField<AccountLinkingInfo> repeatedField = accountLinkingInfos_;
										RepeatedField<AccountLinkingInfo> repeatedField2 = other.accountLinkingInfos_;
										if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
										{
											DeviceInfo objB4 = other.lastSaveDeviceInfo_;
											if (object.Equals(lastSaveDeviceInfo_, objB4))
											{
												string text2 = other.profileUID_;
												if (!(profileUID_ != text2))
												{
													ulong num3 = other.revision_;
													if (revision_ == num3)
													{
														string text3 = other.lastCustomIdOwner_;
														if (!(lastCustomIdOwner_ != text3))
														{
															int num4 = other.onlineVersion_;
															if (onlineVersion_ == num4)
															{
																int num5 = other.session_;
																if (session_ == num5)
																{
																	RepeatedField<string> repeatedField3 = historys_;
																	RepeatedField<string> repeatedField4 = other.historys_;
																	if (((RepeatedField<T>)(object)repeatedField3).Equals((RepeatedField<>)(object)repeatedField4))
																	{
																		Timestamp objB5 = other.lastUploadTime_;
																		if (object.Equals(lastUploadTime_, objB5))
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
				}
			}
			int num6 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004FC7")]
		[Cpp2IlInjected.Address(RVA = "0x95E5E0", Offset = "0x95CFE0", VA = "0x18095E5E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_011b
			int num = 0;
			if (initialVersion_ != 0)
			{
			}
			if (version_ != 0)
			{
			}
			string text = highestGameVersion_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			Timestamp timestamp = created_;
			if (timestamp != null)
			{
				int hashCode2 = timestamp.GetHashCode();
			}
			Timestamp timestamp2 = modified_;
			if (timestamp2 != null)
			{
				int hashCode3 = timestamp2.GetHashCode();
			}
			Timestamp timestamp3 = lastLogin_;
			if (timestamp3 != null)
			{
				int hashCode4 = timestamp3.GetHashCode();
			}
			int hashCode5 = ((RepeatedField<T>)(object)accountLinkingInfos_).GetHashCode();
			DeviceInfo deviceInfo = lastSaveDeviceInfo_;
			if (deviceInfo != null)
			{
				int hashCode6 = deviceInfo.GetHashCode();
			}
			string text2 = profileUID_;
			if (text2.m_stringLength != 0)
			{
				int hashCode7 = text2.GetHashCode();
			}
			if (revision_ != 0)
			{
			}
			string text3 = lastCustomIdOwner_;
			if (text3.m_stringLength != 0)
			{
				int hashCode8 = text3.GetHashCode();
			}
			if (onlineVersion_ != 0)
			{
			}
			if (session_ != 0)
			{
			}
			int hashCode9 = ((RepeatedField<T>)(object)historys_).GetHashCode();
			Timestamp timestamp4 = lastUploadTime_;
			if (timestamp4 != null)
			{
				int hashCode10 = timestamp4.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode11 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FC8")]
		[Cpp2IlInjected.Address(RVA = "0x95F450", Offset = "0x95DE50", VA = "0x18095F450", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FC9")]
		[Cpp2IlInjected.Address(RVA = "0x95F8D0", Offset = "0x95E2D0", VA = "0x18095F8D0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_01a2
			if ((long)CreatedPUIds != 0)
			{
				int value = initialVersion_;
				output.WriteInt32(value);
			}
			if (version_ != 0)
			{
				int value2 = version_;
				output.WriteInt32(value2);
			}
			if (highestGameVersion_.m_stringLength != 0)
			{
				string value3 = highestGameVersion_;
				output.WriteString(value3);
			}
			if ((long)created_ != 0)
			{
				Timestamp value4 = created_;
				output.WriteMessage(value4);
			}
			if ((long)modified_ != 0)
			{
				Timestamp value5 = modified_;
				output.WriteMessage(value5);
			}
			if ((long)lastLogin_ != 0)
			{
				Timestamp value6 = lastLogin_;
				output.WriteMessage(value6);
			}
			RepeatedField<AccountLinkingInfo> repeatedField = accountLinkingInfos_;
			FieldCodec<AccountLinkingInfo> repeated_accountLinkingInfos_codec = _repeated_accountLinkingInfos_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_accountLinkingInfos_codec);
			if ((long)lastSaveDeviceInfo_ != 0)
			{
				DeviceInfo value7 = lastSaveDeviceInfo_;
				output.WriteMessage(value7);
			}
			if (profileUID_.m_stringLength != 0)
			{
				string value8 = profileUID_;
				output.WriteString(value8);
			}
			if (revision_ != 0)
			{
				ulong value9 = revision_;
				output.WriteUInt64(value9);
			}
			if (lastCustomIdOwner_.m_stringLength != 0)
			{
				string value10 = lastCustomIdOwner_;
				output.WriteString(value10);
			}
			if (onlineVersion_ != 0)
			{
				int value11 = onlineVersion_;
				output.WriteInt32(value11);
			}
			if (session_ != 0)
			{
				int value12 = session_;
				output.WriteInt32(value12);
			}
			RepeatedField<string> repeatedField2 = historys_;
			FieldCodec<string> repeated_historys_codec = _repeated_historys_codec;
			((RepeatedField<T>)(object)repeatedField2).WriteTo(output, (FieldCodec<>)(object)repeated_historys_codec);
			if ((long)lastUploadTime_ != 0)
			{
				Timestamp value13 = lastUploadTime_;
				output.WriteMessage(value13);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FCA")]
		[Cpp2IlInjected.Address(RVA = "0x95DBC0", Offset = "0x95C5C0", VA = "0x18095DBC0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0209
			int num = initialVersion_;
			int num2 = 0;
			if (num != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num);
			}
			int num4 = version_;
			if (num4 != 0)
			{
				int num5 = CodedOutputStream.ComputeInt32Size(num4);
				num5++;
				num2 += num5;
			}
			string text = highestGameVersion_;
			if (text.m_stringLength != 0)
			{
				int num6 = CodedOutputStream.ComputeStringSize(text);
				num6++;
				num2 += num6;
			}
			Timestamp timestamp = created_;
			if (timestamp != null)
			{
				int num7 = CodedOutputStream.ComputeMessageSize(timestamp);
				num7++;
				num2 += num7;
			}
			Timestamp timestamp2 = modified_;
			if (timestamp2 != null)
			{
				int num8 = CodedOutputStream.ComputeMessageSize(timestamp2);
				num8++;
				num2 += num8;
			}
			Timestamp timestamp3 = lastLogin_;
			if (timestamp3 != null)
			{
				int num9 = CodedOutputStream.ComputeMessageSize(timestamp3);
				num9++;
				num2 += num9;
			}
			RepeatedField<AccountLinkingInfo> repeatedField = accountLinkingInfos_;
			FieldCodec<AccountLinkingInfo> repeated_accountLinkingInfos_codec = _repeated_accountLinkingInfos_codec;
			int num10 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_accountLinkingInfos_codec);
			DeviceInfo deviceInfo = lastSaveDeviceInfo_;
			num2 += num10;
			if (deviceInfo != null)
			{
				int num11 = CodedOutputStream.ComputeMessageSize(deviceInfo);
				num11++;
				num2 += num11;
			}
			string text2 = profileUID_;
			if (text2.m_stringLength != 0)
			{
				int num12 = CodedOutputStream.ComputeStringSize(text2);
				num12++;
				num2 += num12;
			}
			ulong num13 = revision_;
			if (num13 != 0)
			{
				int num14 = CodedOutputStream.ComputeUInt64Size(num13);
				num14++;
				num2 += num14;
			}
			string text3 = lastCustomIdOwner_;
			if (text3.m_stringLength != 0)
			{
				int num15 = CodedOutputStream.ComputeStringSize(text3);
				num15++;
				num2 += num15;
			}
			int num16 = onlineVersion_;
			if (num16 != 0)
			{
				int num17 = CodedOutputStream.ComputeInt32Size(num16);
				num17++;
				num2 += num17;
			}
			int num18 = session_;
			if (num18 != 0)
			{
				int num19 = CodedOutputStream.ComputeInt32Size(num18);
				num19++;
				num2 += num19;
			}
			RepeatedField<string> repeatedField2 = historys_;
			FieldCodec<string> repeated_historys_codec = _repeated_historys_codec;
			int num20 = ((RepeatedField<T>)(object)repeatedField2).CalculateSize((FieldCodec<>)(object)repeated_historys_codec);
			Timestamp timestamp4 = lastUploadTime_;
			num2 += num20;
			if (timestamp4 != null)
			{
				int num21 = CodedOutputStream.ComputeMessageSize(timestamp4);
				num21 += 2;
				num2 += num21;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num22 = unknownFields.CalculateSize();
				num2 += num22;
			}
			return num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FCB")]
		[Cpp2IlInjected.Address(RVA = "0x95E820", Offset = "0x95D220", VA = "0x18095E820", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ProfileGameInfo other)
		{
			//Discarded unreachable code: IL_0233
			if (other == null)
			{
				return;
			}
			int num = other.initialVersion_;
			if (num != 0)
			{
				initialVersion_ = num;
			}
			int num2 = other.version_;
			if (num2 != 0)
			{
				version_ = num2;
			}
			string text = other.highestGameVersion_;
			if (text.m_stringLength != 0)
			{
				HighestGameVersion = text;
			}
			if ((long)other.created_ != 0)
			{
				Timestamp timestamp2 = default(Timestamp);
				if (created_ == null)
				{
					Timestamp timestamp = (created_ = new Timestamp());
					timestamp2 = created_;
				}
				Timestamp other2 = other.created_;
				timestamp2.MergeFrom(other2);
			}
			if ((long)other.modified_ != 0)
			{
				Timestamp timestamp4 = default(Timestamp);
				if (modified_ == null)
				{
					Timestamp timestamp3 = (modified_ = new Timestamp());
					timestamp4 = modified_;
				}
				Timestamp other3 = other.modified_;
				timestamp4.MergeFrom(other3);
			}
			if ((long)other.lastLogin_ != 0)
			{
				Timestamp timestamp6 = default(Timestamp);
				if (lastLogin_ == null)
				{
					Timestamp timestamp5 = (lastLogin_ = new Timestamp());
					timestamp6 = lastLogin_;
				}
				Timestamp other4 = other.lastLogin_;
				timestamp6.MergeFrom(other4);
			}
			RepeatedField<AccountLinkingInfo> repeatedField = accountLinkingInfos_;
			RepeatedField<AccountLinkingInfo> repeatedField2 = other.accountLinkingInfos_;
			((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
			if ((long)other.lastSaveDeviceInfo_ != 0)
			{
				DeviceInfo deviceInfo2 = default(DeviceInfo);
				if (lastSaveDeviceInfo_ == null)
				{
					DeviceInfo deviceInfo = (lastSaveDeviceInfo_ = new DeviceInfo());
					deviceInfo2 = lastSaveDeviceInfo_;
				}
				DeviceInfo other5 = other.lastSaveDeviceInfo_;
				deviceInfo2.MergeFrom(other5);
			}
			string text2 = other.profileUID_;
			if (text2.m_stringLength != 0)
			{
				ProfileUID = text2;
			}
			ulong num3 = other.revision_;
			if (num3 != 0)
			{
				revision_ = num3;
			}
			string text3 = other.lastCustomIdOwner_;
			if (text3.m_stringLength != 0)
			{
				LastCustomIdOwner = text3;
			}
			int num4 = other.onlineVersion_;
			if (num4 != 0)
			{
				onlineVersion_ = num4;
			}
			int num5 = other.session_;
			if (num5 != 0)
			{
				session_ = num5;
			}
			RepeatedField<string> repeatedField3 = historys_;
			RepeatedField<string> repeatedField4 = other.historys_;
			((RepeatedField<T>)(object)repeatedField3).Add((IEnumerable<>)(object)repeatedField4);
			if ((long)other.lastUploadTime_ != 0)
			{
				Timestamp timestamp8 = default(Timestamp);
				if (lastUploadTime_ == null)
				{
					Timestamp timestamp7 = (lastUploadTime_ = new Timestamp());
					timestamp8 = lastUploadTime_;
				}
				Timestamp other6 = other.lastUploadTime_;
				timestamp8.MergeFrom(other6);
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x6004FCC")]
		[Cpp2IlInjected.Address(RVA = "0x95EB20", Offset = "0x95D520", VA = "0x18095EB20", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0243
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 58)
			{
				if ((int)num > 90)
				{
					if ((int)num > 112)
					{
						if (num == 130)
						{
							RepeatedField<string> repeatedField = historys_;
							FieldCodec<string> repeated_historys_codec = _repeated_historys_codec;
							((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_historys_codec);
						}
						if (num != 162)
						{
							goto IL_022c;
						}
						Timestamp builder = default(Timestamp);
						if (lastUploadTime_ == null)
						{
							Timestamp timestamp = (lastUploadTime_ = new Timestamp());
							builder = lastUploadTime_;
						}
						input.ReadMessage(builder);
					}
					int num2 = default(int);
					if (num == 96)
					{
						num2 = (onlineVersion_ = input.ReadInt32());
					}
					if (num2 != 112)
					{
						goto IL_022c;
					}
					int num3 = (session_ = input.ReadInt32());
				}
				string text2 = default(string);
				if ((int)num > 74)
				{
					ulong num4 = default(ulong);
					if (num == 80)
					{
						num4 = (revision_ = input.ReadUInt64());
					}
					if (num4 != 90)
					{
						goto IL_022c;
					}
					text2 = (LastCustomIdOwner = input.ReadString());
				}
				DeviceInfo deviceInfo = default(DeviceInfo);
				if ((long)text2 == 66)
				{
					DeviceInfo builder2 = default(DeviceInfo);
					if (lastSaveDeviceInfo_ == null)
					{
						deviceInfo = (lastSaveDeviceInfo_ = new DeviceInfo());
						builder2 = lastSaveDeviceInfo_;
					}
					input.ReadMessage(builder2);
				}
				if ((long)deviceInfo != 74)
				{
					goto IL_022c;
				}
				string text4 = (ProfileUID = input.ReadString());
			}
			Timestamp timestamp4 = default(Timestamp);
			if ((int)num > 26)
			{
				Timestamp timestamp2 = default(Timestamp);
				if ((int)num > 42)
				{
					if (num == 50)
					{
						Timestamp builder3 = default(Timestamp);
						if (lastLogin_ == null)
						{
							timestamp2 = (lastLogin_ = new Timestamp());
							builder3 = lastLogin_;
						}
						input.ReadMessage(builder3);
					}
					if ((long)timestamp2 != 58)
					{
						goto IL_022c;
					}
					RepeatedField<AccountLinkingInfo> repeatedField2 = accountLinkingInfos_;
					FieldCodec<AccountLinkingInfo> repeated_accountLinkingInfos_codec = _repeated_accountLinkingInfos_codec;
					((RepeatedField<T>)(object)repeatedField2).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_accountLinkingInfos_codec);
				}
				Timestamp timestamp3 = default(Timestamp);
				if ((long)timestamp2 == 34)
				{
					Timestamp builder4 = default(Timestamp);
					if (created_ == null)
					{
						timestamp3 = (created_ = new Timestamp());
						builder4 = created_;
					}
					input.ReadMessage(builder4);
				}
				if ((long)timestamp3 != 42)
				{
					goto IL_022c;
				}
				Timestamp builder5 = default(Timestamp);
				if (modified_ == null)
				{
					timestamp4 = (modified_ = new Timestamp());
					builder5 = modified_;
				}
				input.ReadMessage(builder5);
			}
			int num5 = default(int);
			if ((long)timestamp4 == 8)
			{
				num5 = (initialVersion_ = input.ReadInt32());
			}
			int num6 = default(int);
			if (num5 == 16)
			{
				num6 = (version_ = input.ReadInt32());
			}
			if (num6 == 26)
			{
				string text6 = (HighestGameVersion = input.ReadString());
			}
			goto IL_022c;
			IL_022c:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6004FCD")]
		[Cpp2IlInjected.Address(RVA = "0x95E3E0", Offset = "0x95CDE0", VA = "0x18095E3E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber - 1 <= 19)
			{
				int num = initialVersion_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FCE")]
		[Cpp2IlInjected.Address(RVA = "0x95EFB0", Offset = "0x95D9B0", VA = "0x18095EFB0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000f, IL_0017, IL_0021, IL_0029, IL_002a, IL_0037, IL_003f, IL_0040, IL_004d, IL_0055, IL_005d, IL_0063, IL_0069, IL_006f, IL_0075, IL_007b
			//IL_000e: Expected I4, but got O
			//IL_0016: Expected I4, but got O
			//IL_0020: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_003e: Expected I8, but got I4
			if (fieldNumber - 1 <= 19)
			{
				object obj = default(object);
				initialVersion_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FCF")]
		[Cpp2IlInjected.Address(RVA = "0x95DFA0", Offset = "0x95C9A0", VA = "0x18095DFA0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0011, IL_0012, IL_0015, IL_0016, IL_0017, IL_0018, IL_0019, IL_001b
			//IL_0010: Expected I4, but got I8
			if (fieldNumber - 1 <= 19)
			{
				initialVersion_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FD2")]
		[Cpp2IlInjected.Address(RVA = "0x95F4B0", Offset = "0x95DEB0", VA = "0x18095F4B0")]
		public bool TryAddProfileUID()
		{
			if (string.IsNullOrEmpty(profileUID_))
			{
				Guid arg = Guid.NewGuid();
				string text = (profileUID_ = ProtoPreconditions.CheckNotNull($"puid_{arg}", "value"));
				List<string> createdPUIds = CreatedPUIds;
				string item = profileUID_;
				((List<T>)(object)createdPUIds).Add((T)item);
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004FD4")]
		[Cpp2IlInjected.Address(RVA = "0x95E7E0", Offset = "0x95D1E0", VA = "0x18095E7E0")]
		public bool IsLastSaveFrom(DeviceInfo info)
		{
			//Discarded unreachable code: IL_0021
			DeviceInfo deviceInfo = lastSaveDeviceInfo_;
			if (deviceInfo == null)
			{
				return true;
			}
			string deviceID_ = info.deviceID_;
			return string.Equals(deviceInfo.deviceID_, deviceID_);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FD5")]
		[Cpp2IlInjected.Address(RVA = "0x95F620", Offset = "0x95E020", VA = "0x18095F620")]
		public void UpdateAccountLinkingInfo(AccountLinkingInfo acInfo)
		{
			//Discarded unreachable code: IL_0082
			_003C_003Ec__DisplayClass107_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass107_0();
			CS_0024_003C_003E8__locals0.acInfo = acInfo;
			AccountLinkingInfo acInfo2 = CS_0024_003C_003E8__locals0.acInfo;
			DeviceInfo deviceInfo = default(DeviceInfo);
			string deviceID_ = deviceInfo.deviceID_;
			if (CS_0024_003C_003E8__locals0 == null)
			{
				RepeatedField<AccountLinkingInfo> repeatedField = accountLinkingInfos_;
				Func<AccountLinkingInfo, bool> func = (Func<AccountLinkingInfo, bool>)(object)(Func<T, TResult>)delegate(AccountLinkingInfo T)
				{
					//Discarded unreachable code: IL_0025
					DeviceInfo loggedDevice_ = T.loggedDevice_;
					string deviceID_2 = CS_0024_003C_003E8__locals0.acInfo.loggedDevice_.deviceID_;
					return string.Equals(loggedDevice_.deviceID_, deviceID_2);
				};
				int index = MoreLinq.FindIndex<AccountLinkingInfo>((IEnumerable<>)(object)repeatedField, (Func<, >)(object)func);
				RepeatedField<AccountLinkingInfo> repeatedField2 = accountLinkingInfos_;
				AccountLinkingInfo acInfo3 = CS_0024_003C_003E8__locals0.acInfo;
				((RepeatedField<T>)(object)repeatedField2).Add((T)acInfo3);
				AccountLinkingInfo accountLinkingInfo = (AccountLinkingInfo)(((RepeatedField<T>)(object)repeatedField2)[index] = (T)CS_0024_003C_003E8__locals0.acInfo);
				DeviceInfo deviceInfo2 = (lastSaveDeviceInfo_ = CS_0024_003C_003E8__locals0.acInfo.loggedDevice_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FD6")]
		[Cpp2IlInjected.Address(RVA = "0x95FC40", Offset = "0x95E640", VA = "0x18095FC40")]
		static ProfileGameInfo()
		{
			Func<ProfileGameInfo> func = default(Func<ProfileGameInfo>);
			_parser = (MessageParser<ProfileGameInfo>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<AccountLinkingInfo> parser = AccountLinkingInfo._parser;
			uint num = default(uint);
			_parser = (MessageParser<ProfileGameInfo>)(object)FieldCodec.ForMessage<AccountLinkingInfo>(num, (MessageParser<>)(object)parser);
			uint num2 = default(uint);
			_parser = (MessageParser<ProfileGameInfo>)(object)FieldCodec.ForString(num2);
			_parser = (MessageParser<ProfileGameInfo>)(object)new List<T>();
			/*Error: Unexpected end of block*/;
		}
	}
}
