using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Definitions.Util;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F4D")]
	public class LocalStorage : BaseStorage<LocalStorageData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000F4E")]
		public delegate void LocalStorageInfoChanged(string playFabId);

		[Cpp2IlInjected.Token(Token = "0x4003E6E")]
		public static string FileName = "local_storage.json";

		[Cpp2IlInjected.Token(Token = "0x170015D1")]
		private OnlineClient onlineClient
		{
			[Cpp2IlInjected.Token(Token = "0x6007D60")]
			[Cpp2IlInjected.Address(RVA = "0x18B04D0", Offset = "0x18AEED0", VA = "0x1818B04D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D2")]
		public override string Path
		{
			[Cpp2IlInjected.Token(Token = "0x6007D61")]
			[Cpp2IlInjected.Address(RVA = "0x18B0340", Offset = "0x18AED40", VA = "0x1818B0340", Slot = "4")]
			get
			{
				return FileName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D3")]
		public LocalStorageData.ProfileInfo LocalProfileInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6007D64")]
			[Cpp2IlInjected.Address(RVA = "0x18B0220", Offset = "0x18AEC20", VA = "0x1818B0220")]
			get
			{
				//Discarded unreachable code: IL_0011
				return ((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.ProfileInfo;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D4")]
		public MiniProfile MiniProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6007D65")]
			[Cpp2IlInjected.Address(RVA = "0x18B02E0", Offset = "0x18AECE0", VA = "0x1818B02E0")]
			get
			{
				//Discarded unreachable code: IL_0016
				return ((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.ProfileInfo.MiniProfile;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D5")]
		public ProfileGameInfo ProfileGameInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6007D66")]
			[Cpp2IlInjected.Address(RVA = "0x18B03A0", Offset = "0x18AEDA0", VA = "0x1818B03A0")]
			get
			{
				MiniProfile _003CMiniProfile_003Ek__BackingField = ((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.ProfileInfo.MiniProfile;
				if (_003CMiniProfile_003Ek__BackingField != null)
				{
					return _003CMiniProfile_003Ek__BackingField.gameInfo_;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D6")]
		public string MiniProfileChecksum
		{
			[Cpp2IlInjected.Token(Token = "0x6007D67")]
			[Cpp2IlInjected.Address(RVA = "0x18B0280", Offset = "0x18AEC80", VA = "0x1818B0280")]
			get
			{
				//Discarded unreachable code: IL_0016
				return ((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.ProfileInfo.MiniProfileServerChecksum;
			}
			[Cpp2IlInjected.Token(Token = "0x6007D68")]
			[Cpp2IlInjected.Address(RVA = "0x18B0590", Offset = "0x18AEF90", VA = "0x1818B0590")]
			set
			{
				//Discarded unreachable code: IL_003e
				//IL_003d: Expected I4, but got I8
				string _003CMiniProfileServerChecksum_003Ek__BackingField = ((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.ProfileInfo.MiniProfileServerChecksum;
				if (value != _003CMiniProfileServerChecksum_003Ek__BackingField)
				{
					((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.ProfileInfo.MiniProfileServerChecksum = value;
					ulong num = default(ulong);
					((BaseStorage<DataType>)(object)this).Save((byte)num != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D7")]
		public int StartupSceneItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6007D69")]
			[Cpp2IlInjected.Address(RVA = "0x18B0470", Offset = "0x18AEE70", VA = "0x1818B0470")]
			get
			{
				//Discarded unreachable code: IL_0016
				return ((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.ProfileInfo.StartupSceneItemId;
			}
			[Cpp2IlInjected.Token(Token = "0x6007D6A")]
			[Cpp2IlInjected.Address(RVA = "0x18B0690", Offset = "0x18AF090", VA = "0x1818B0690")]
			set
			{
				//Discarded unreachable code: IL_0038
				LocalStorageData.ProfileInfo _003CProfileInfo_003Ek__BackingField = ((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.ProfileInfo;
				if (value != _003CProfileInfo_003Ek__BackingField.StartupSceneItemId)
				{
					((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.ProfileInfo.StartupSceneItemId = value;
					((BaseStorage<DataType>)(object)this).Save(isForced: true);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015D8")]
		public bool RequestedRemoteProfileReset
		{
			[Cpp2IlInjected.Token(Token = "0x6007D71")]
			[Cpp2IlInjected.Address(RVA = "0x18B0410", Offset = "0x18AEE10", VA = "0x1818B0410")]
			get
			{
				//Discarded unreachable code: IL_0016
				return ((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.OnlineInfo.RequestedProfileReset;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x140000A1")]
		public event LocalStorageInfoChanged OnLocalStorageInfoChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6007D62")]
			[Cpp2IlInjected.Address(RVA = "0x18B0180", Offset = "0x18AEB80", VA = "0x1818B0180")]
			[CompilerGenerated]
			add
			{
				LocalStorageInfoChanged onLocalStorageInfoChanged = this.OnLocalStorageInfoChanged;
				Delegate @delegate = Delegate.Combine(onLocalStorageInfoChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLocalStorageInfoChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007D63")]
			[Cpp2IlInjected.Address(RVA = "0x18B04F0", Offset = "0x18AEEF0", VA = "0x1818B04F0")]
			[CompilerGenerated]
			remove
			{
				LocalStorageInfoChanged onLocalStorageInfoChanged = this.OnLocalStorageInfoChanged;
				Delegate @delegate = Delegate.Remove(onLocalStorageInfoChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onLocalStorageInfoChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D6B")]
		[Cpp2IlInjected.Address(RVA = "0x18B0000", Offset = "0x18AEA00", VA = "0x1818B0000")]
		public LocalStorage(Client client)
		{
			//Discarded unreachable code: IL_0031
			((BaseStorage<DataType>)(object)this)._002Ector(FileSystem.Save, client);
			if ((object)typeof(FileSystem).TypeHandle != null)
			{
				OnlineClient.OnlineConnectionChanged onlineConnectionChanged = OnOnlineConnectionChanged;
			}
			OnlineClient.OnlineConnectionChanged onlineConnectionChanged2 = OnOnlineConnectionChanged;
		}

		[Cpp2IlInjected.Token(Token = "0x6007D6C")]
		[Cpp2IlInjected.Address(RVA = "0x18AFB10", Offset = "0x18AE510", VA = "0x1818AFB10", Slot = "6")]
		protected override void PostLoad()
		{
			//Discarded unreachable code: IL_0020
			LocalStorageData.UserInfo userInfo = new LocalStorageData.UserInfo();
			LocalStorageData.OnlineInfo onlineInfo = new LocalStorageData.OnlineInfo();
			LocalStorageData.XblInfo xblInfo = new LocalStorageData.XblInfo();
			LocalStorageData.ProfileInfo profileInfo = new LocalStorageData.ProfileInfo();
			LocalStorageData.StoreInfo storeInfo = new LocalStorageData.StoreInfo();
		}

		[Cpp2IlInjected.Token(Token = "0x6007D6D")]
		[Cpp2IlInjected.Address(RVA = "0x18AFCE0", Offset = "0x18AE6E0", VA = "0x1818AFCE0", Slot = "7")]
		protected override void PostSave()
		{
			//Discarded unreachable code: IL_0029
			LocalStorageInfoChanged onLocalStorageInfoChanged = this.OnLocalStorageInfoChanged;
			if (onLocalStorageInfoChanged != null)
			{
				string _003CPlayFabId_003Ek__BackingField = ((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.OnlineInfo.PlayFabId;
				onLocalStorageInfoChanged(_003CPlayFabId_003Ek__BackingField);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D6E")]
		[Cpp2IlInjected.Address(RVA = "0x18AF810", Offset = "0x18AE210", VA = "0x1818AF810")]
		private void OnOnlineConnectionChanged(Profile profile, bool isLoggedIn, CancellationToken ct)
		{
			//Discarded unreachable code: IL_00aa
			//IL_00a9: Expected I4, but got I8
			if (isLoggedIn)
			{
				int num = 0;
				string titleId = default(string);
				string playFabId = default(string);
				GlobalStorage.Instance.SetOnlineIds(titleId, playFabId);
				LocalStorageData.OnlineInfo onlineInfo = new LocalStorageData.OnlineInfo();
				string _003CTitleId_003Ek__BackingField = default(string);
				onlineInfo.TitleId = _003CTitleId_003Ek__BackingField;
				string _003CPlayFabId_003Ek__BackingField = default(string);
				onlineInfo.PlayFabId = _003CPlayFabId_003Ek__BackingField;
				string _003CEntityId_003Ek__BackingField = default(string);
				onlineInfo.EntityId = _003CEntityId_003Ek__BackingField;
				LocalStorageData.XblInfo xblInfo = new LocalStorageData.XblInfo();
				string _003CGamerTag_003Ek__BackingField = default(string);
				xblInfo.GamerTag = _003CGamerTag_003Ek__BackingField;
				int num2 = 0;
				if (((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.OnlineInfo.NotEquals(onlineInfo))
				{
					((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.OnlineInfo = onlineInfo;
				}
				if (((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.XblInfo.NotEquals(xblInfo))
				{
					((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.XblInfo = xblInfo;
				}
				if (num2 != 0)
				{
					ulong num3 = default(ulong);
					((BaseStorage<DataType>)(object)this).Save((byte)num3 != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D6F")]
		[Cpp2IlInjected.Address(RVA = "0x18AFEE0", Offset = "0x18AE8E0", VA = "0x1818AFEE0")]
		public void SetMiniProfile(MiniProfile miniProfile)
		{
			//Discarded unreachable code: IL_0042
			//IL_0041: Expected I4, but got I8
			MiniProfile _003CMiniProfile_003Ek__BackingField = ((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.ProfileInfo.MiniProfile;
			if (_003CMiniProfile_003Ek__BackingField == null || !_003CMiniProfile_003Ek__BackingField.Equals(miniProfile))
			{
				((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.ProfileInfo.MiniProfile = miniProfile;
				ulong num = default(ulong);
				((BaseStorage<DataType>)(object)this).Save((byte)num != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D70")]
		[Cpp2IlInjected.Address(RVA = "0x18AFDE0", Offset = "0x18AE7E0", VA = "0x1818AFDE0")]
		public void ResetMiniProfile()
		{
			//Discarded unreachable code: IL_0045
			//IL_0043: Expected I4, but got I8
			if ((long)((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.ProfileInfo.MiniProfile != 0)
			{
				LocalStorageData.ProfileInfo _003CProfileInfo_003Ek__BackingField = ((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.ProfileInfo;
				LocalStorageData.ProfileInfo _003CProfileInfo_003Ek__BackingField2 = ((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.ProfileInfo;
				ulong num = default(ulong);
				((BaseStorage<DataType>)(object)this).Save((byte)num != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D72")]
		[Cpp2IlInjected.Address(RVA = "0x18AFD60", Offset = "0x18AE760", VA = "0x1818AFD60")]
		public void RequestDelayedProfileReset()
		{
			//Discarded unreachable code: IL_001e
			((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.OnlineInfo.RequestedProfileReset = true;
			((BaseStorage<DataType>)(object)this).Save(isForced: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6007D73")]
		[Cpp2IlInjected.Address(RVA = "0x18AF740", Offset = "0x18AE140", VA = "0x1818AF740")]
		public void ClearDelayedProfileReset()
		{
			//Discarded unreachable code: IL_0037
			if (((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.OnlineInfo.RequestedProfileReset)
			{
				((LocalStorageData)((BaseStorage<DataType>)(object)this).Data).User.OnlineInfo.RequestedProfileReset = false;
				((BaseStorage<DataType>)(object)this).Save(isForced: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007D74")]
		[Cpp2IlInjected.Address(RVA = "0x18AFFB0", Offset = "0x18AE9B0", VA = "0x1818AFFB0")]
		static LocalStorage()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
