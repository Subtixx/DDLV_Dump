using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Epic.OnlineServices;
using Epic.OnlineServices.Ecom;
using EpicSdk.Service;
using glPlayFab.Disney;
using Newtonsoft.Json;
using UnityEngine;

namespace Mdl.Platform.Shop
{
	[Cpp2IlInjected.Token(Token = "0x200032C")]
	public class EpicNativeShopManager : NativeShopManagerBase
	{
		[Cpp2IlInjected.Token(Token = "0x200032D")]
		protected class EpicNativeShopItem : NativeShopItemBase
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400168A")]
			private CatalogOffer nativeOffer;

			[Cpp2IlInjected.Token(Token = "0x170001B9")]
			private double CurrentPrice
			{
				[Cpp2IlInjected.Token(Token = "0x6000DC2")]
				[Cpp2IlInjected.Address(RVA = "0x137D650", Offset = "0x137C050", VA = "0x18137D650")]
				get
				{
					while (true)
					{
						uint _003CDecimalPoint_003Ek__BackingField = nativeOffer.DecimalPoint;
						ulong _003CCurrentPrice64_003Ek__BackingField = nativeOffer.CurrentPrice64;
						int num = 0;
						if (_003CDecimalPoint_003Ek__BackingField != 0)
						{
							/*Error: Could not find block for branch target IL_001f*/;
						}
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001BA")]
			public override bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x6000DC4")]
				[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "4")]
				get
				{
					return true;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001BB")]
			public override string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000DC5")]
				[Cpp2IlInjected.Address(RVA = "0x137D870", Offset = "0x137C270", VA = "0x18137D870", Slot = "5")]
				get
				{
					//Discarded unreachable code: IL_0020
					if (IsValid)
					{
						bool flag = ((IJsonLineInfo)(object)nativeOffer.TitleText).HasLineInfo();
					}
					return string.Empty;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001BC")]
			public override string FormattedPrice
			{
				[Cpp2IlInjected.Token(Token = "0x6000DC6")]
				[Cpp2IlInjected.Address(RVA = "0x137D740", Offset = "0x137C140", VA = "0x18137D740", Slot = "6")]
				get
				{
					//IL_0047: Expected F8, but got I4
					if (IsValid)
					{
						ulong _003CCurrentPrice64_003Ek__BackingField = nativeOffer.CurrentPrice64;
						uint _003CDecimalPoint_003Ek__BackingField = nativeOffer.DecimalPoint;
						int num = 0;
						if (_003CDecimalPoint_003Ek__BackingField != 0)
						{
						}
						CultureInfo culture = NativeShopUtils.FindCultureInfoWithCurrencyCode(nativeOffer.CurrencyCode);
						return NativeShopUtils.ToFormattedPrice(num, culture);
					}
					return string.Empty;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001BD")]
			public override string Description
			{
				[Cpp2IlInjected.Token(Token = "0x6000DC7")]
				[Cpp2IlInjected.Address(RVA = "0x137D700", Offset = "0x137C100", VA = "0x18137D700", Slot = "8")]
				get
				{
					return string.Empty;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001BE")]
			public override string NativeItemID
			{
				[Cpp2IlInjected.Token(Token = "0x6000DC8")]
				[Cpp2IlInjected.Address(RVA = "0x137D8F0", Offset = "0x137C2F0", VA = "0x18137D8F0", Slot = "7")]
				get
				{
					bool flag = ((IJsonLineInfo)(object)nativeOffer.Id).HasLineInfo();
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000DC1")]
			[Cpp2IlInjected.Address(RVA = "0x137D5D0", Offset = "0x137BFD0", VA = "0x18137D5D0")]
			public unsafe EpicNativeShopItem(CatalogOffer nativeOffer)
			{
				//IL_001b: Expected native int or pointer, but got O
				//IL_002e: Expected native int or pointer, but got O
				//IL_0041: Expected native int or pointer, but got O
				//IL_0055: Expected native int or pointer, but got O
				//IL_006a: Expected native int or pointer, but got O
				//IL_007f: Expected native int or pointer, but got O
				//IL_0094: Expected native int or pointer, but got O
				//IL_00a1: Expected native int or pointer, but got O
				((BattlePassReward)(object)this)._002Ector();
				Utf8String _003CId_003Ek__BackingField = nativeOffer.Id;
				Utf8String _003CDescriptionText_003Ek__BackingField = nativeOffer.DescriptionText;
				((CatalogOffer*)(IntPtr)this.nativeOffer)->Id = _003CId_003Ek__BackingField;
				Utf8String _003CTechnicalDetailsText_DEPRECATED_003Ek__BackingField = nativeOffer.TechnicalDetailsText_DEPRECATED;
				((CatalogOffer*)(IntPtr)this.nativeOffer)->DescriptionText = _003CDescriptionText_003Ek__BackingField;
				Result _003CPriceResult_003Ek__BackingField = nativeOffer.PriceResult;
				((CatalogOffer*)(IntPtr)this.nativeOffer)->TechnicalDetailsText_DEPRECATED = _003CTechnicalDetailsText_DEPRECATED_003Ek__BackingField;
				long _003CExpirationTimestamp_003Ek__BackingField = nativeOffer.ExpirationTimestamp;
				((CatalogOffer*)(IntPtr)this.nativeOffer)->PriceResult = _003CPriceResult_003Ek__BackingField;
				bool _003CAvailableForPurchase_003Ek__BackingField = nativeOffer.AvailableForPurchase;
				((CatalogOffer*)(IntPtr)this.nativeOffer)->ExpirationTimestamp = _003CExpirationTimestamp_003Ek__BackingField;
				ulong _003CCurrentPrice64_003Ek__BackingField = nativeOffer.CurrentPrice64;
				((CatalogOffer*)(IntPtr)this.nativeOffer)->AvailableForPurchase = _003CAvailableForPurchase_003Ek__BackingField;
				long _003CReleaseDateTimestamp_003Ek__BackingField = nativeOffer.ReleaseDateTimestamp;
				((CatalogOffer*)(IntPtr)this.nativeOffer)->CurrentPrice64 = _003CCurrentPrice64_003Ek__BackingField;
				((CatalogOffer*)(IntPtr)this.nativeOffer)->ReleaseDateTimestamp = _003CReleaseDateTimestamp_003Ek__BackingField;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6000DC3")]
			[Cpp2IlInjected.Address(RVA = "0x137D4C0", Offset = "0x137BEC0", VA = "0x18137D4C0")]
			private static double EpicPriceToDouble(ulong price, uint decimalpoint)
			{
				while (true)
				{
					int num = 0;
					if (decimalpoint != 0)
					{
						/*Error: Could not find block for branch target IL_0007*/;
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000DC9")]
			[Cpp2IlInjected.Address(RVA = "0x137D570", Offset = "0x137BF70", VA = "0x18137D570")]
			public CatalogOffer GetNativeItem()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001689")]
		private List<EpicNativeShopItem> EpicNativeShopItems = (List<EpicNativeShopItem>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public override IEnumerable<NativeShopItemBase> AllShopItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000DBB")]
			[Cpp2IlInjected.Address(RVA = "0x1364B60", Offset = "0x1363560", VA = "0x181364B60", Slot = "5")]
			get
			{
				List<EpicNativeShopItem> epicNativeShopItems = EpicNativeShopItems;
				Func<EpicNativeShopItem, NativeShopItemBase> _003C_003E9__3_ = _003C_003Ec._003C_003E9__3_0;
				if (_003C_003E9__3_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				return (IEnumerable<NativeShopItemBase>)Enumerable.Select<EpicNativeShopItem, NativeShopItemBase>((IEnumerable<>)epicNativeShopItems, (Func<, >)(object)_003C_003E9__3_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBC")]
		[Cpp2IlInjected.Address(RVA = "0x13649A0", Offset = "0x13633A0", VA = "0x1813649A0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CRefreshCatalogAsync_003Ed__4))]
		public override Task<InitializeShop.Result> RefreshCatalogAsync(InitializeShop.Request request, CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<InitializeShop.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBD")]
		[Cpp2IlInjected.Address(RVA = "0x13645F0", Offset = "0x1362FF0", VA = "0x1813645F0", Slot = "7")]
		public override Task<OpenShopToBuyItem.Result> OpenShopToBuyItemAsync(OpenShopToBuyItem.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_00cb
			//IL_006d: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			OpenShopToBuyItem.Result result = new OpenShopToBuyItem.Result();
			NativeShopItemBase itemToBuy = request.ItemToBuy;
			if (itemToBuy != null)
			{
				int num = 0;
				if (itemToBuy != null && itemToBuy.IsValid)
				{
					int num2 = 0;
					if (!PlatformUtils.UseEpic())
					{
						Debug.Log("EpicNativeShopManager.OpenShopToBuyItemAsync has to be called with epic support");
					}
					string message = default(string);
					Debug.Log(message);
					int num3 = 0;
					if (Application.platform != 0)
					{
						int num4 = 0;
						if (Application.platform != RuntimePlatform.OSXPlayer)
						{
							EpicSdkService instance = EpicSdkService._instance;
							int num5 = 0;
							if (instance == (UnityEngine.Object)num5)
							{
								int num6 = 0;
								if (EpicSdkService.UseEpic())
								{
									bool flag = EpicSdkService.InitInstance(new GameObject("Epic SDK").AddComponent<EpicSdkService>());
								}
							}
							EpicSdkService instance2 = EpicSdkService._instance;
							OnCheckoutCallback myCheckoutCB = HandleCheckoutCB;
							string offerId = default(string);
							instance2.CheckoutOffer(offerId, myCheckoutCB);
						}
					}
					PlatformUtils.OpenEpicMacMoonstoneStore((Utf8String)num3);
				}
			}
			return (Task<OpenShopToBuyItem.Result>)(object)Task.FromResult(result.WithResult(OpenShopToBuyItem.ResultCode.CannotCastToNativeItem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBE")]
		[Cpp2IlInjected.Address(RVA = "0x13644E0", Offset = "0x1362EE0", VA = "0x1813644E0")]
		private void HandleCheckoutCB(ref CheckoutCallbackInfo data)
		{
			//Discarded unreachable code: IL_0020
			string message = default(string);
			Debug.Log(message);
			BackFromNativeStoreResult backFromNativeStoreResult = new BackFromNativeStoreResult();
			int status = 0;
			BackFromNativeStoreResult result = backFromNativeStoreResult.WithStatus((BackFromNativeStoreResult.BuyStatus)status);
			HandleBackFromNativeShopResult(result);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBF")]
		[Cpp2IlInjected.Address(RVA = "0x13639C0", Offset = "0x13623C0", VA = "0x1813639C0", Slot = "8")]
		public override void DebugTraceDetailedInformation()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC0")]
		[Cpp2IlInjected.Address(RVA = "0x1364AC0", Offset = "0x13634C0", VA = "0x181364AC0")]
		public EpicNativeShopManager()
		{
		}
	}
}
