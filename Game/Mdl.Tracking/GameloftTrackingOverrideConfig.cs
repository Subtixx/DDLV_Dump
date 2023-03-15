using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Tracking.Pipeline.Standard;
using Gameloft.Tracking.Service;
using Mdl.Systems;
using Meta.Online;

namespace Mdl.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x20002A8")]
	public class GameloftTrackingOverrideConfig : IOnlineConfigOverrider
	{
		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public GameloftTrackingOverrideConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x8C38C0", Offset = "0x8C22C0", VA = "0x1808C38C0", Slot = "4")]
		public Task<OnlineConfiguration> OverrideConfigAsync(OnlineConfiguration onlineConfiguration, CancellationToken cancellationToken)
		{
			//Discarded unreachable code: IL_0054
			//IL_004b: Expected O, but got I4
			OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
			int num = default(int);
			if (metaOnlineClient == null || metaOnlineClient.PlayFabId == null)
			{
				LocalStorage _003CLocalStorage_003Ek__BackingField = SystemRoot.Instance.MetaClient.LocalStorage;
				if (_003CLocalStorage_003Ek__BackingField != null)
				{
					LocalStorageData.OnlineInfo _003COnlineInfo_003Ek__BackingField = ((LocalStorageData)((BaseStorage<DataType>)(object)_003CLocalStorage_003Ek__BackingField).Data).User.OnlineInfo;
				}
				num = 0;
			}
			OnlineConfiguration onlineConfiguration2 = onlineConfiguration.WithCustomField("playfab_id", (string)num);
			return (Task<OnlineConfiguration>)(object)Task.FromResult(onlineConfiguration);
		}
	}
}
