using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using glPlayFab.Disney;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	public class EmbedLiveopsGameData : ServerLiveopsDataFilesLoader
	{
		[Cpp2IlInjected.Token(Token = "0x170002D3")]
		public override bool IsDebug
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAB")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "7")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B930", Offset = "0x2C9A330", VA = "0x182C9B930", Slot = "10")]
		protected override ServerDataResult LoadBattlePasses()
		{
			int cpp2il__autoParamName__idx_ = 0;
			return LoadEmbedLiveopsData<BattlePassSeasonData, BattlePassConfigV2>((ServerDataType)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B970", Offset = "0x2C9A370", VA = "0x182C9B970", Slot = "11")]
		protected override ServerDataResult LoadBundles()
		{
			return LoadEmbedLiveopsData<OnlineBundleData, BundleConfig>(ServerDataType.Bundles);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B9B0", Offset = "0x2C9A3B0", VA = "0x182C9B9B0", Slot = "12")]
		protected override ServerDataResult LoadStores()
		{
			return LoadEmbedLiveopsData<OnlineStoreData, StoreConfig>(ServerDataType.Stores);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x16504C0", Offset = "0x164EEC0", VA = "0x1816504C0")]
		private ServerDataResult LoadEmbedLiveopsData<CLIENTTYPE, SERVERTYPE>(ServerDataType cpp2il__autoParamName__idx_0) where CLIENTTYPE : IClientLiveopsConfig<SERVERTYPE> where SERVERTYPE : IOnlineLiveopsConfig
		{
			//Discarded unreachable code: IL_0068, IL_006e, IL_0074
			//IL_003a: Expected O, but got I4
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected I4, but got Unknown
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected I4, but got Unknown
			int num = 0;
			List<IServerDataConfig> list = (List<IServerDataConfig>)(object)new List<T>();
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			string validPath = ProtoDatabase.ValidPath;
			num += num;
			num++;
			int num2 = 0;
			string validPath2 = ProtoDatabase.ValidPath;
			if (num < num2)
			{
				num += num;
				num++;
			}
			((List<T>)(object)list).Add((T)num);
			num += num;
			num += 312;
			num = (int)(num + validPath2);
			num += num;
			num += 312;
			num = (int)(num + validPath2);
			int num3 = 0;
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public EmbedLiveopsGameData()
		{
			((MarshalByRefObject)(object)this)._002Ector();
		}
	}
}
