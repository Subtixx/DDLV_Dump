using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using glPlayFab.Disney;
using Steamworks;
using UnityEngine;

namespace Mdl.Platform.Shop
{
	[Cpp2IlInjected.Token(Token = "0x200033F")]
	public class SteamNativeShopManager : NativeShopManagerBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000340")]
		public class SteamNativeShopItem : NativeShopItemBase
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40016B4")]
			public readonly SteamItemDef_t NativeItem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40016B5")]
			private readonly double CurrentPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40016B6")]
			private readonly string CurrencyCode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40016B7")]
			private string ItemName;

			[Cpp2IlInjected.Token(Token = "0x170001C8")]
			public override bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x6000E0C")]
				[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "4")]
				get
				{
					return true;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001C9")]
			public override string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000E0D")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "5")]
				get
				{
					return ItemName;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001CA")]
			public override string FormattedPrice
			{
				[Cpp2IlInjected.Token(Token = "0x6000E0E")]
				[Cpp2IlInjected.Address(RVA = "0x1219DD0", Offset = "0x12187D0", VA = "0x181219DD0", Slot = "6")]
				get
				{
					if (IsValid)
					{
						CultureInfo cultureInfo = NativeShopUtils.FindCultureInfoWithCurrencyCode(CurrencyCode);
						string result = default(string);
						return result;
					}
					return string.Empty;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001CB")]
			public override string Description
			{
				[Cpp2IlInjected.Token(Token = "0x6000E0F")]
				[Cpp2IlInjected.Address(RVA = "0x1219D90", Offset = "0x1218790", VA = "0x181219D90", Slot = "8")]
				get
				{
					return string.Empty;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001CC")]
			public override string NativeItemID
			{
				[Cpp2IlInjected.Token(Token = "0x6000E10")]
				[Cpp2IlInjected.Address(RVA = "0x1219E50", Offset = "0x1218850", VA = "0x181219E50", Slot = "7")]
				get
				{
					SteamItemDef_t nativeItem = NativeItem;
					string result = default(string);
					return result;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000E0B")]
			[Cpp2IlInjected.Address(RVA = "0x1219CA0", Offset = "0x12186A0", VA = "0x181219CA0")]
			public SteamNativeShopItem(SteamItemDef_t nativeOffer, ulong currentPrice, ulong basePrice, string currencyCode)
			{
				//IL_0014: Expected O, but got I4
				//IL_001b: Expected O, but got I4
				int steamItemDef = nativeOffer.m_SteamItemDef;
				((BattlePassReward)(object)this)._002Ector();
				CurrencyCode = (string)0;
				NativeItem = (SteamItemDef_t)steamItemDef;
				bool flag = default(bool);
				if (flag)
				{
				}
				string text = (ItemName = string.Empty);
			}

			[Cpp2IlInjected.Token(Token = "0x6000E11")]
			[Cpp2IlInjected.Address(RVA = "0x1219AE0", Offset = "0x12184E0", VA = "0x181219AE0")]
			public void DEBUG_GiveForFree()
			{
				//Discarded unreachable code: IL_0026
				//IL_0025: Expected I4, but got I8
				SteamItemDef_t[] array = new SteamItemDef_t[1];
				SteamItemDef_t steamItemDef_t = (array[0] = NativeItem);
				(new uint[1])[0] = 1u;
			}

			[Cpp2IlInjected.Token(Token = "0x6000E12")]
			[Cpp2IlInjected.Address(RVA = "0x1219BC0", Offset = "0x12185C0", VA = "0x181219BC0")]
			public void DEBUG_OpenWebLink(bool useOverlay = true)
			{
				//IL_0013: Expected O, but got I4
				//IL_0013: Expected O, but got I4
				SteamItemDef_t nativeItem = NativeItem;
				int num = default(int);
				SteamManager.OpenInventoryStore($"https://store.steampowered.com/buyitem/{num}/{num}/", useOverlay);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40016B1")]
		private readonly Callback<SteamInventoryResultReady_t> callbackHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40016B2")]
		private readonly Callback<GameOverlayActivated_t> callbackHandleGameOverlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40016B3")]
		private List<SteamNativeShopItem> SteamNativeShopItems = (List<SteamNativeShopItem>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public override IEnumerable<NativeShopItemBase> AllShopItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000E06")]
			[Cpp2IlInjected.Address(RVA = "0xF62630", Offset = "0xF61030", VA = "0x180F62630", Slot = "5")]
			get
			{
				List<SteamNativeShopItem> steamNativeShopItems = SteamNativeShopItems;
				Func<SteamNativeShopItem, NativeShopItemBase> _003C_003E9__8_ = _003C_003Ec._003C_003E9__8_0;
				if (_003C_003E9__8_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				return (IEnumerable<NativeShopItemBase>)Enumerable.Select<SteamNativeShopItem, NativeShopItemBase>((IEnumerable<>)steamNativeShopItems, (Func<, >)(object)_003C_003E9__8_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E03")]
		[Cpp2IlInjected.Address(RVA = "0xF624A0", Offset = "0xF60EA0", VA = "0x180F624A0")]
		public SteamNativeShopManager()
		{
			Callback<SteamInventoryResultReady_t> callback = (callbackHandle = (Callback<SteamInventoryResultReady_t>)(object)Callback<T>.Create((Callback<>.DispatchDelegate)(object)(Callback<T>.DispatchDelegate)delegate(SteamInventoryResultReady_t x)
			{
				//Discarded unreachable code: IL_0024
				if ((long)x == 1)
				{
					Debug.Log("SteamNativeShopManager: Steam item have been purchased");
					BackFromNativeStoreResult result = new BackFromNativeStoreResult().WithStatus(BackFromNativeStoreResult.BuyStatus.PurchaseWasMade);
					HandleBackFromNativeShopResult(result);
				}
			}));
			Callback<GameOverlayActivated_t> callback2 = (callbackHandleGameOverlay = (Callback<GameOverlayActivated_t>)(object)Callback<T>.Create((Callback<>.DispatchDelegate)(object)new Callback<T>.DispatchDelegate(OnSteamOverlay)));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E04")]
		[Cpp2IlInjected.Address(RVA = "0xF61E90", Offset = "0xF60890", VA = "0x180F61E90")]
		private void OnSteamPurchaseItem()
		{
			//Discarded unreachable code: IL_001e
			Debug.Log("SteamNativeShopManager: Steam item have been purchased");
			BackFromNativeStoreResult result = new BackFromNativeStoreResult().WithStatus(BackFromNativeStoreResult.BuyStatus.PurchaseWasMade);
			HandleBackFromNativeShopResult(result);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E05")]
		[Cpp2IlInjected.Address(RVA = "0xF61DF0", Offset = "0xF607F0", VA = "0x180F61DF0")]
		private void OnSteamOverlay(GameOverlayActivated_t gameOverlayActivated_T)
		{
			if ((object)gameOverlayActivated_T == null)
			{
			}
			Debug.Log("SteamNativeShopManager OnSteamOverlay Steam Overlay has been " + "activated");
		}

		[Cpp2IlInjected.Token(Token = "0x6000E07")]
		[Cpp2IlInjected.Address(RVA = "0xF622A0", Offset = "0xF60CA0", VA = "0x180F622A0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CRefreshCatalogAsync_003Ed__9))]
		public override Task<InitializeShop.Result> RefreshCatalogAsync(InitializeShop.Request request, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<InitializeShop.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E08")]
		[Cpp2IlInjected.Address(RVA = "0xF61F50", Offset = "0xF60950", VA = "0x180F61F50", Slot = "7")]
		public override Task<OpenShopToBuyItem.Result> OpenShopToBuyItemAsync(OpenShopToBuyItem.Request request, CancellationToken ct)
		{
			OpenShopToBuyItem.Result result = new OpenShopToBuyItem.Result();
			NativeShopItemBase itemToBuy = request.ItemToBuy;
			if (itemToBuy != null)
			{
				int num = 0;
				int num2 = 0;
				if (itemToBuy != null)
				{
					if (itemToBuy.IsValid)
					{
						int num3 = 0;
						if (!PlatformUtils.UseSteam())
						{
							Debug.Log("SteamNativeShopManager.OpenShopToBuyItemAsync has to be called with steam support");
						}
						AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
						Task<> asyncTask = default(Task<>);
						asyncTask.FireAndForgetTask();
					}
					return (Task<OpenShopToBuyItem.Result>)(object)Task.FromResult(result.WithResult(OpenShopToBuyItem.ResultCode.NativeItemInvalid));
				}
			}
			OpenShopToBuyItem.Result result2 = result.WithResult(OpenShopToBuyItem.ResultCode.CannotCastToNativeItem);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E09")]
		[Cpp2IlInjected.Address(RVA = "0xF61C60", Offset = "0xF60660", VA = "0x180F61C60", Slot = "8")]
		public override void DebugTraceDetailedInformation()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
