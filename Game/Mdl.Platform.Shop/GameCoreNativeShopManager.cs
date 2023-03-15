using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab.ServerModels;
using UnityEngine;

namespace Mdl.Platform.Shop
{
	[Cpp2IlInjected.Token(Token = "0x2000330")]
	public class GameCoreNativeShopManager : NativeShopManagerBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000331")]
		public class GameCoreNativeShopItem : InvalidNativeShopItemImpl
		{
			[Cpp2IlInjected.Token(Token = "0x6000DD5")]
			[Cpp2IlInjected.Address(RVA = "0x8BB8E0", Offset = "0x8BA2E0", VA = "0x1808BB8E0")]
			public GameCoreNativeShopItem()
			{
				((GetCharacterInventoryRequest)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001693")]
		private List<GameCoreNativeShopItem> gcNativeShopItems = (List<GameCoreNativeShopItem>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public override IEnumerable<NativeShopItemBase> AllShopItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000DD0")]
			[Cpp2IlInjected.Address(RVA = "0x8BCBF0", Offset = "0x8BB5F0", VA = "0x1808BCBF0", Slot = "5")]
			get
			{
				List<GameCoreNativeShopItem> list = gcNativeShopItems;
				Func<GameCoreNativeShopItem, NativeShopItemBase> _003C_003E9__3_ = _003C_003Ec._003C_003E9__3_0;
				if (_003C_003E9__3_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				return (IEnumerable<NativeShopItemBase>)Enumerable.Select<GameCoreNativeShopItem, NativeShopItemBase>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__3_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD1")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA60", Offset = "0x8BB460", VA = "0x1808BCA60", Slot = "4")]
		[AsyncStateMachine(typeof(_003CRefreshCatalogAsync_003Ed__4))]
		public override Task<InitializeShop.Result> RefreshCatalogAsync(InitializeShop.Request request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<InitializeShop.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD2")]
		[Cpp2IlInjected.Address(RVA = "0x8BC940", Offset = "0x8BB340", VA = "0x1808BC940", Slot = "7")]
		[AsyncStateMachine(typeof(_003COpenShopToBuyItemAsync_003Ed__5))]
		public override Task<OpenShopToBuyItem.Result> OpenShopToBuyItemAsync(OpenShopToBuyItem.Request request, CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<OpenShopToBuyItem.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD3")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8E0", Offset = "0x8BB2E0", VA = "0x1808BC8E0", Slot = "8")]
		public override void DebugTraceDetailedInformation()
		{
			Debug.Log("[GameCoreNativeShopManager] - DebugTraceDetailedInformation");
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD4")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB50", Offset = "0x8BB550", VA = "0x1808BCB50")]
		public GameCoreNativeShopManager()
		{
		}
	}
}
