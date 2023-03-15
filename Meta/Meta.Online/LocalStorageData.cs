using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F46")]
	public class LocalStorageData
	{
		[Cpp2IlInjected.Token(Token = "0x2000F47")]
		public class OnlineInfo : IEquatable<OnlineInfo>
		{
			[Cpp2IlInjected.Token(Token = "0x170015C3")]
			public string TitleId
			{
				[Cpp2IlInjected.Token(Token = "0x6007D31")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CTitleId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007D32")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CTitleId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170015C4")]
			public string PlayFabId
			{
				[Cpp2IlInjected.Token(Token = "0x6007D33")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007D34")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170015C5")]
			public string EntityId
			{
				[Cpp2IlInjected.Token(Token = "0x6007D35")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CEntityId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007D36")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CEntityId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170015C6")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4003E5E")]
			public bool RequestedProfileReset
			{
				[Cpp2IlInjected.Token(Token = "0x6007D37")]
				[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007D38")]
				[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6007D39")]
			[Cpp2IlInjected.Address(RVA = "0x11EF650", Offset = "0x11EE050", VA = "0x1811EF650", Slot = "4")]
			public bool Equals(OnlineInfo other)
			{
				string b = other.TitleId;
				if (string.Equals(TitleId, b))
				{
					string b2 = other.PlayFabId;
					if (string.Equals(PlayFabId, b2))
					{
						string b3 = other.EntityId;
						return string.Equals(EntityId, b3);
					}
				}
				int num = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6007D3A")]
			[Cpp2IlInjected.Address(RVA = "0x11EF6C0", Offset = "0x11EE0C0", VA = "0x1811EF6C0")]
			public bool NotEquals(OnlineInfo other)
			{
				string b = other.TitleId;
				if (string.Equals(TitleId, b))
				{
					string b2 = other.PlayFabId;
					if (string.Equals(PlayFabId, b2))
					{
						string b3 = other.EntityId;
						return string.Equals(EntityId, b3);
					}
				}
				int num = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6007D3B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public OnlineInfo()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000F48")]
		public class XblInfo : IEquatable<XblInfo>
		{
			[Cpp2IlInjected.Token(Token = "0x170015C7")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4003E5F")]
			public uint TitleId
			{
				[Cpp2IlInjected.Token(Token = "0x6007D3C")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007D3D")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170015C8")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4003E60")]
			public ulong UserId
			{
				[Cpp2IlInjected.Token(Token = "0x6007D3E")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007D3F")]
				[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170015C9")]
			public string GamerTag
			{
				[Cpp2IlInjected.Token(Token = "0x6007D40")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CGamerTag_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007D41")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CGamerTag_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007D42")]
			[Cpp2IlInjected.Address(RVA = "0x12045B0", Offset = "0x1202FB0", VA = "0x1812045B0", Slot = "4")]
			public bool Equals(XblInfo other)
			{
				ulong num = other.UserId;
				if (UserId == num)
				{
					string b = other.GamerTag;
					if (string.Equals(GamerTag, b))
					{
						uint num2 = other.TitleId;
						return TitleId == num2;
					}
				}
				int num3 = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6007D43")]
			[Cpp2IlInjected.Address(RVA = "0x1204610", Offset = "0x1203010", VA = "0x181204610")]
			public bool NotEquals(XblInfo other)
			{
				//Discarded unreachable code: IL_003c
				ulong num = other.UserId;
				if (UserId == num)
				{
					string b = other.GamerTag;
					if (string.Equals(GamerTag, b))
					{
						uint num2 = other.TitleId;
						return TitleId != num2;
					}
				}
				return true;
			}

			[Cpp2IlInjected.Token(Token = "0x6007D44")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public XblInfo()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000F49")]
		public class StoreInfo : IEquatable<StoreInfo>
		{
			[Cpp2IlInjected.Token(Token = "0x170015CA")]
			public Dictionary<string, List<string>> RedeemedPurchases
			{
				[Cpp2IlInjected.Token(Token = "0x6007D45")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CRedeemedPurchases_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007D46")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CRedeemedPurchases_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007D47")]
			[Cpp2IlInjected.Address(RVA = "0x11EF840", Offset = "0x11EE240", VA = "0x1811EF840", Slot = "4")]
			public bool Equals(StoreInfo other)
			{
				//Discarded unreachable code: IL_00b6
				Dictionary<string, List<string>> dictionary = RedeemedPurchases;
				Func<KeyValuePair<string, List<string>>, IEnumerable<string>> _003C_003E9__4_ = _003C_003Ec._003C_003E9__4_0;
				if (_003C_003E9__4_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<string, List<string>> x) => null);
				}
				Func<KeyValuePair<string, List<string>>, string, KeyValuePair<string, string>> func = default(Func<KeyValuePair<string, List<string>>, string, KeyValuePair<string, string>>);
				if (_003C_003Ec._003C_003E9__4_1 == null)
				{
					func = (Func<KeyValuePair<string, List<string>>, string, KeyValuePair<string, string>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T1, T2, TResult>)((KeyValuePair<string, List<string>> x, string y) => default(KeyValuePair<string, string>)));
				}
				IEnumerable<KeyValuePair<string, List<string>>> enumerable = (IEnumerable<KeyValuePair<string, List<string>>>)Enumerable.SelectMany<KeyValuePair<string, List<string>>, string, KeyValuePair<string, string>>((IEnumerable<>)dictionary, (Func<, >)(object)_003C_003E9__4_, (Func<, , >)(object)func);
				Dictionary<string, List<string>> dictionary2 = other.RedeemedPurchases;
				Func<KeyValuePair<string, List<string>>, IEnumerable<string>> func2 = default(Func<KeyValuePair<string, List<string>>, IEnumerable<string>>);
				if (_003C_003Ec._003C_003E9__4_2 == null)
				{
					func2 = (Func<KeyValuePair<string, List<string>>, IEnumerable<string>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<string, List<string>> x) => null));
				}
				Func<KeyValuePair<string, List<string>>, string, KeyValuePair<string, string>> func3 = default(Func<KeyValuePair<string, List<string>>, string, KeyValuePair<string, string>>);
				if (_003C_003Ec._003C_003E9__4_3 == null)
				{
					func3 = (Func<KeyValuePair<string, List<string>>, string, KeyValuePair<string, string>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T1, T2, TResult>)((KeyValuePair<string, List<string>> x, string y) => default(KeyValuePair<string, string>)));
				}
				IEnumerable<KeyValuePair<string, List<string>>> enumerable2 = (IEnumerable<KeyValuePair<string, List<string>>>)Enumerable.SelectMany<KeyValuePair<string, List<string>>, string, KeyValuePair<string, string>>((IEnumerable<>)dictionary2, (Func<, >)(object)func2, (Func<, , >)(object)func3);
				return !Enumerable.Any<KeyValuePair<string, string>>(Enumerable.Except<KeyValuePair<string, string>>((IEnumerable<>)enumerable, (IEnumerable<>)enumerable2));
			}

			[Cpp2IlInjected.Token(Token = "0x6007D48")]
			[Cpp2IlInjected.Address(RVA = "0x11EFC10", Offset = "0x11EE610", VA = "0x1811EFC10")]
			public bool NotEquals(StoreInfo other)
			{
				return !Equals(other);
			}

			[Cpp2IlInjected.Token(Token = "0x6007D49")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public StoreInfo()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000F4B")]
		public class ProfileInfo : IEquatable<ProfileInfo>
		{
			[Cpp2IlInjected.Token(Token = "0x170015CB")]
			[JsonConverter(typeof(ProtobufConverter<MiniProfile>))]
			public MiniProfile MiniProfile
			{
				[Cpp2IlInjected.Token(Token = "0x6007D50")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CMiniProfile_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007D51")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CMiniProfile_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170015CC")]
			public string MiniProfileServerChecksum
			{
				[Cpp2IlInjected.Token(Token = "0x6007D52")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CMiniProfileServerChecksum_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007D53")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CMiniProfileServerChecksum_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170015CD")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4003E6A")]
			public int StartupSceneItemId
			{
				[Cpp2IlInjected.Token(Token = "0x6007D54")]
				[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007D55")]
				[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6007D56")]
			[Cpp2IlInjected.Address(RVA = "0x11EF730", Offset = "0x11EE130", VA = "0x1811EF730", Slot = "4")]
			public bool Equals(ProfileInfo other)
			{
				ProfileGameInfo gameInfo_ = MiniProfile.gameInfo_;
				int version_ = other.MiniProfile.gameInfo_.version_;
				if (gameInfo_.version_ != version_)
				{
					int num = 0;
				}
				string text = MiniProfileServerChecksum;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6007D57")]
			[Cpp2IlInjected.Address(RVA = "0x11EF790", Offset = "0x11EE190", VA = "0x1811EF790")]
			public bool NotEquals(ProfileInfo other)
			{
				ProfileGameInfo gameInfo_ = MiniProfile.gameInfo_;
				int version_ = other.MiniProfile.gameInfo_.version_;
				if (gameInfo_.version_ != version_)
				{
					int num = 0;
				}
				string text = MiniProfileServerChecksum;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6007D58")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ProfileInfo()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000F4C")]
		public class UserInfo
		{
			[Cpp2IlInjected.Token(Token = "0x170015CE")]
			public OnlineInfo OnlineInfo
			{
				[Cpp2IlInjected.Token(Token = "0x6007D59")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003COnlineInfo_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007D5A")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003COnlineInfo_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170015CF")]
			public XblInfo XblInfo
			{
				[Cpp2IlInjected.Token(Token = "0x6007D5B")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CXblInfo_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007D5C")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CXblInfo_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170015D0")]
			public ProfileInfo ProfileInfo
			{
				[Cpp2IlInjected.Token(Token = "0x6007D5D")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CProfileInfo_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007D5E")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CProfileInfo_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007D5F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public UserInfo()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015C1")]
		public UserInfo User
		{
			[Cpp2IlInjected.Token(Token = "0x6007D2C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CUser_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007D2D")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CUser_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015C2")]
		public StoreInfo Store
		{
			[Cpp2IlInjected.Token(Token = "0x6007D2E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CStore_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007D2F")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CStore_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D30")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public LocalStorageData()
		{
		}
	}
}
