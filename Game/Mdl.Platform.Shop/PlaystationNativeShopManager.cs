using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using PlayFab.ServerModels;

namespace Mdl.Platform.Shop
{
	[Cpp2IlInjected.Token(Token = "0x200033B")]
	public class PlaystationNativeShopManager : NativeShopManagerBase
	{
		[Cpp2IlInjected.Token(Token = "0x200033C")]
		public class PlaystationNativeShopItem : InvalidNativeShopItemImpl
		{
			[Cpp2IlInjected.Token(Token = "0x6000DFD")]
			[Cpp2IlInjected.Address(RVA = "0x8BB8E0", Offset = "0x8BA2E0", VA = "0x1808BB8E0")]
			public PlaystationNativeShopItem()
			{
				((GetCharacterInventoryRequest)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40016AC")]
		private List<PlaystationNativeShopItem> PlaystationNativeShopItems = (List<PlaystationNativeShopItem>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public override IEnumerable<NativeShopItemBase> AllShopItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000DF5")]
			[Cpp2IlInjected.Address(RVA = "0xCB2D10", Offset = "0xCB1710", VA = "0x180CB2D10", Slot = "5")]
			get
			{
				List<PlaystationNativeShopItem> playstationNativeShopItems = PlaystationNativeShopItems;
				Func<PlaystationNativeShopItem, NativeShopItemBase> _003C_003E9__3_ = _003C_003Ec._003C_003E9__3_0;
				if (_003C_003E9__3_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				return (IEnumerable<NativeShopItemBase>)Enumerable.Select<PlaystationNativeShopItem, NativeShopItemBase>((IEnumerable<>)playstationNativeShopItems, (Func<, >)(object)_003C_003E9__3_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF6")]
		[Cpp2IlInjected.Address(RVA = "0xCB2B30", Offset = "0xCB1530", VA = "0x180CB2B30")]
		protected void RegisterOpenShopCB()
		{
			//Discarded unreachable code: IL_002f
			PlaystationNotifications instance = PlaystationNotifications.Instance;
			PlaystationNotifications.SystemUiOverlaid b = HandleBackFromNativeShopWithAppPause;
			PlaystationNotifications.SystemUiOverlaid onSystemUiOverlaid = instance.OnSystemUiOverlaid;
			Delegate @delegate = Delegate.Combine(onSystemUiOverlaid, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onSystemUiOverlaid)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF7")]
		[Cpp2IlInjected.Address(RVA = "0xCB2620", Offset = "0xCB1020", VA = "0x180CB2620")]
		protected void HandleBackFromNativeShopWithAppPause(bool isPaused)
		{
			//Discarded unreachable code: IL_0053
			if (!isPaused)
			{
				BackFromNativeStoreResult backFromNativeStoreResult = new BackFromNativeStoreResult();
				int status = 0;
				BackFromNativeStoreResult result = backFromNativeStoreResult.WithStatus((BackFromNativeStoreResult.BuyStatus)status);
				HandleBackFromNativeShopResult(result);
				PlaystationNotifications instance = PlaystationNotifications.Instance;
				PlaystationNotifications.SystemUiOverlaid value = HandleBackFromNativeShopWithAppPause;
				PlaystationNotifications.SystemUiOverlaid onSystemUiOverlaid = instance.OnSystemUiOverlaid;
				Delegate @delegate = Delegate.Remove(onSystemUiOverlaid, value);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				while ((object)@delegate != onSystemUiOverlaid)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF8")]
		[Cpp2IlInjected.Address(RVA = "0xCB2A40", Offset = "0xCB1440", VA = "0x180CB2A40", Slot = "4")]
		[AsyncStateMachine(typeof(_003CRefreshCatalogAsync_003Ed__6))]
		public override Task<InitializeShop.Result> RefreshCatalogAsync(InitializeShop.Request request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<InitializeShop.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF9")]
		[Cpp2IlInjected.Address(RVA = "0xCB27B0", Offset = "0xCB11B0", VA = "0x180CB27B0", Slot = "7")]
		public override Task<OpenShopToBuyItem.Result> OpenShopToBuyItemAsync(OpenShopToBuyItem.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0065
			OpenShopToBuyItem.Result result = new OpenShopToBuyItem.Result();
			NativeShopItemBase itemToBuy = request.ItemToBuy;
			if (itemToBuy != null)
			{
				int num = 0;
				if (itemToBuy != null && itemToBuy.IsValid)
				{
					PlaystationNotifications instance = PlaystationNotifications.Instance;
					PlaystationNotifications.SystemUiOverlaid b = HandleBackFromNativeShopWithAppPause;
					PlaystationNotifications.SystemUiOverlaid onSystemUiOverlaid = instance.OnSystemUiOverlaid;
					Delegate @delegate = Delegate.Combine(onSystemUiOverlaid, b);
					if ((object)@delegate != null && (object)@delegate == null)
					{
						throw new InvalidCastException();
					}
					while ((object)@delegate != onSystemUiOverlaid)
					{
					}
				}
			}
			return (Task<OpenShopToBuyItem.Result>)(object)Task.FromResult(result.WithResult(OpenShopToBuyItem.ResultCode.CannotCastToNativeItem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnUIShopStatusChanged(bool opened)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
		public override void DebugTraceDetailedInformation()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFC")]
		[Cpp2IlInjected.Address(RVA = "0xCB2C70", Offset = "0xCB1670", VA = "0x180CB2C70")]
		public PlaystationNativeShopManager()
		{
		}
	}
}
