using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Mdl.Systems;
using PlayFab.ServerModels;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Mdl.Platform.Shop
{
	[Cpp2IlInjected.Token(Token = "0x2000335")]
	public class AppleNativeShopManager : NativeShopManagerBase, IStoreListener
	{
		[Cpp2IlInjected.Token(Token = "0x2000336")]
		public class AppleNativeShopItem : NativeShopItemBase
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400169F")]
			public Product product;

			[Cpp2IlInjected.Token(Token = "0x170001C1")]
			public override bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x6000DE7")]
				[Cpp2IlInjected.Address(RVA = "0xAE6160", Offset = "0xAE4B60", VA = "0x180AE6160", Slot = "4")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001C2")]
			public override string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000DE8")]
				[Cpp2IlInjected.Address(RVA = "0x156AA10", Offset = "0x1569410", VA = "0x18156AA10", Slot = "5")]
				get
				{
					//Discarded unreachable code: IL_0011
					return product.metadata.localizedTitle;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001C3")]
			public override string FormattedPrice
			{
				[Cpp2IlInjected.Token(Token = "0x6000DE9")]
				[Cpp2IlInjected.Address(RVA = "0x156A9E0", Offset = "0x15693E0", VA = "0x18156A9E0", Slot = "6")]
				get
				{
					//Discarded unreachable code: IL_0011
					return product.metadata.localizedPriceString;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001C4")]
			public override string Description
			{
				[Cpp2IlInjected.Token(Token = "0x6000DEA")]
				[Cpp2IlInjected.Address(RVA = "0x156A9A0", Offset = "0x15693A0", VA = "0x18156A9A0", Slot = "8")]
				get
				{
					return string.Empty;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001C5")]
			public override string NativeItemID
			{
				[Cpp2IlInjected.Token(Token = "0x6000DEB")]
				[Cpp2IlInjected.Address(RVA = "0x156AA40", Offset = "0x1569440", VA = "0x18156AA40", Slot = "7")]
				get
				{
					//Discarded unreachable code: IL_0011
					return product.definition.id;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000DEC")]
			[Cpp2IlInjected.Address(RVA = "0xA281E0", Offset = "0xA26BE0", VA = "0x180A281E0")]
			public AppleNativeShopItem(Product product)
			{
				((GetPlayerCombinedInfoRequestParams)(object)this)._002Ector();
				this.product = product;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000337")]
		private class ReceiptJSON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40016A0")]
			public string Payload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40016A1")]
			public string Store;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40016A2")]
			public string TransactionID;

			[Cpp2IlInjected.Token(Token = "0x6000DED")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ReceiptJSON()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400169B")]
		private List<AppleNativeShopItem> AppleNativeShopItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400169C")]
		private IStoreController m_StoreController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400169D")]
		private PurchaseEventArgs storedArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400169E")]
		private string storedReceipt;

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public override IEnumerable<NativeShopItemBase> AllShopItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000DDD")]
			[Cpp2IlInjected.Address(RVA = "0xA419E0", Offset = "0xA403E0", VA = "0x180A419E0", Slot = "5")]
			get
			{
				List<AppleNativeShopItem> appleNativeShopItems = AppleNativeShopItems;
				Func<AppleNativeShopItem, NativeShopItemBase> _003C_003E9__4_ = _003C_003Ec._003C_003E9__4_0;
				if (_003C_003E9__4_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				return (IEnumerable<NativeShopItemBase>)Enumerable.Select<AppleNativeShopItem, NativeShopItemBase>((IEnumerable<>)appleNativeShopItems, (Func<, >)(object)_003C_003E9__4_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDE")]
		[Cpp2IlInjected.Address(RVA = "0xA41600", Offset = "0xA40000", VA = "0x180A41600")]
		public AppleNativeShopManager()
		{
			//Discarded unreachable code: IL_00a5, IL_00ab, IL_00b1, IL_00b7, IL_00bd, IL_00c3
			//IL_007c: Expected O, but got I4
			//IL_0096: Expected O, but got I4
			int num = 0;
			AppleNativeShopItems = (List<AppleNativeShopItem>)(object)new List<T>();
			storedReceipt = "";
			base._002Ector();
			object[] args = Array.Empty<object>();
			GameLog.Info("[Apple] IAP AppleNativeShopManager", args);
			int num2 = 0;
			StandardPurchasingModule first = StandardPurchasingModule.Instance();
			IPurchasingModule[] rest = Array.Empty<IPurchasingModule>();
			ConfigurationBuilder configurationBuilder = ConfigurationBuilder.Instance(first, rest);
			int num3 = 0;
			IEnumerable<IAPData> all = (IEnumerable<IAPData>)IAPData.GetAll();
			int num5 = default(int);
			if (all != null)
			{
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					if (num == (int)num4)
					{
						goto IL_0098;
					}
					num++;
				}
				while (num == 0)
				{
				}
				string message = "[Apple] IAP Add: " + (string)num;
				num5 = 0;
				Debug.Log(message);
				int type = 0;
				ConfigurationBuilder configurationBuilder2 = configurationBuilder.AddProduct((string)num5, (ProductType)type);
				goto IL_0098;
			}
			goto IL_009f;
			IL_0098:
			num5 += num5;
			goto IL_009f;
			IL_009f:
			if (all == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDF")]
		[Cpp2IlInjected.Address(RVA = "0xA414E0", Offset = "0xA3FEE0", VA = "0x180A414E0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CRefreshCatalogAsync_003Ed__9))]
		public override Task<InitializeShop.Result> RefreshCatalogAsync(InitializeShop.Request request, CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<InitializeShop.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE0")]
		[Cpp2IlInjected.Address(RVA = "0xA40B40", Offset = "0xA3F540", VA = "0x180A40B40", Slot = "7")]
		public override Task<OpenShopToBuyItem.Result> OpenShopToBuyItemAsync(OpenShopToBuyItem.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0110
			OpenShopToBuyItem.Result result;
			uint num3 = default(uint);
			while (true)
			{
				result = new OpenShopToBuyItem.Result();
				NativeShopItemBase itemToBuy = request.ItemToBuy;
				if (itemToBuy == null)
				{
					break;
				}
				int num = 0;
				int num2 = 0;
				if (itemToBuy == null)
				{
					break;
				}
				string[] array = new string[0];
				if ("[Apple] IAP OpenShopToBuyItemAsync " != null && "[Apple] IAP OpenShopToBuyItemAsync " == null)
				{
					continue;
				}
				array[0] = "[Apple] IAP OpenShopToBuyItemAsync ";
				string nativeItemID = itemToBuy.NativeItemID;
				if (nativeItemID != null && nativeItemID == null)
				{
					continue;
				}
				array[1] = nativeItemID;
				if (" Title: " != null && " Title: " == null)
				{
					continue;
				}
				array[2] = " Title: ";
				string name = itemToBuy.Name;
				if (name != null && name == null)
				{
					continue;
				}
				array[3] = name;
				if (" Price " != null && " Price " == null)
				{
					continue;
				}
				array[4] = " Price ";
				string formattedPrice = itemToBuy.FormattedPrice;
				if (formattedPrice == null || formattedPrice != null)
				{
					array[5] = formattedPrice;
					string msg = string.Concat(array);
					object[] args = Array.Empty<object>();
					GameLog.Info(msg, args);
					IStoreController storeController = m_StoreController;
					if (num2 < (int)num3)
					{
						num2 += num2;
						num2++;
					}
					return (Task<OpenShopToBuyItem.Result>)(object)Task.FromResult(result);
				}
			}
			OpenShopToBuyItem.Result result2 = result.WithResult(OpenShopToBuyItem.ResultCode.CannotCastToNativeItem);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE1")]
		[Cpp2IlInjected.Address(RVA = "0xA40A10", Offset = "0xA3F410", VA = "0x180A40A10", Slot = "14")]
		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
			object[] args = Array.Empty<object>();
			GameLog.Info("[Apple] IAP initialized", args);
			m_StoreController = controller;
			InitAppleNativeShopItems();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE2")]
		[Cpp2IlInjected.Address(RVA = "0xA40420", Offset = "0xA3EE20", VA = "0x180A40420")]
		public void InitAppleNativeShopItems()
		{
			uint num2 = default(uint);
			AppleNativeShopItem appleNativeShopItem = default(AppleNativeShopItem);
			while (true)
			{
				((List<T>)(object)AppleNativeShopItems).Clear();
				IStoreController storeController = m_StoreController;
				int num = 0;
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if ((long)num >= (long)(IntPtr)" Desc: ")
				{
					break;
				}
				string[] array = new string[8];
				if ("[Apple] IAP transactionID: " != null && "[Apple] IAP transactionID: " == null)
				{
					continue;
				}
				array[0] = "[Apple] IAP transactionID: ";
				if ("[Apple] IAP transactionID: " == null || (" Title: " != null && " Title: " == null))
				{
					continue;
				}
				array[2] = " Title: ";
				if (" Title: " == null || (" Price " != null && " Price " == null))
				{
					continue;
				}
				array[4] = " Price ";
				if (" Price " != null && (" Desc: " == null || " Desc: " != null))
				{
					array[6] = " Desc: ";
					if (" Desc: " != null)
					{
						string msg = string.Concat(array);
						object[] args = Array.Empty<object>();
						GameLog.Info(msg, args);
						((List<T>)(object)AppleNativeShopItems).Add((T)appleNativeShopItem);
						num++;
						appleNativeShopItem = (AppleNativeShopItem)(object)((object)appleNativeShopItem + (object)appleNativeShopItem);
						break;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE3")]
		[Cpp2IlInjected.Address(RVA = "0xA40980", Offset = "0xA3F380", VA = "0x180A40980", Slot = "11")]
		public void OnInitializeFailed(InitializationFailureReason error)
		{
			string msg = string.Format("[Apple] IAP initialize failed: {0}", "[Apple] IAP initialize failed: {0}");
			object[] args = Array.Empty<object>();
			GameLog.Info(msg, args);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE4")]
		[Cpp2IlInjected.Address(RVA = "0xA41020", Offset = "0xA3FA20", VA = "0x180A41020", Slot = "12")]
		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
		{
			ReceiptJSON receiptJSON;
			string[] array;
			string payload;
			while (true)
			{
				Product _003CpurchasedProduct_003Ek__BackingField = args.purchasedProduct;
				receiptJSON = JsonUtility.FromJson<ReceiptJSON>(_003CpurchasedProduct_003Ek__BackingField.receipt);
				array = new string[6];
				if ("[Apple] IAP ProcessPurchase Id: " != null && array == null)
				{
					continue;
				}
				array[0] = "[Apple] IAP ProcessPurchase Id: ";
				string _003Cid_003Ek__BackingField = _003CpurchasedProduct_003Ek__BackingField.definition.id;
				if (_003Cid_003Ek__BackingField != null && array == null)
				{
					continue;
				}
				array[1] = _003Cid_003Ek__BackingField;
				if (" TransactionID: " != null && " TransactionID: " == null)
				{
					continue;
				}
				array[2] = " TransactionID: ";
				string transactionID = receiptJSON.TransactionID;
				if (transactionID != null && " TransactionID: " == null)
				{
					continue;
				}
				array[3] = transactionID;
				if (" Receipt: " == null || " Receipt: " != null)
				{
					array[4] = " Receipt: ";
					payload = receiptJSON.Payload;
					if (payload == null || " Receipt: " != null)
					{
						break;
					}
				}
			}
			array[5] = payload;
			string msg = string.Concat(array);
			object[] args2 = Array.Empty<object>();
			GameLog.Info(msg, args2);
			storedArgs = args;
			string text = (storedReceipt = receiptJSON.Payload);
			BackFromNativeStoreResult result = new BackFromNativeStoreResult().WithStatus(BackFromNativeStoreResult.BuyStatus.PurchaseWasMade);
			HandleBackFromNativeShopResult(result);
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE5")]
		[Cpp2IlInjected.Address(RVA = "0xA413E0", Offset = "0xA3FDE0", VA = "0x180A413E0")]
		[AsyncStateMachine(typeof(_003CRedeemIAP_003Ed__15))]
		public Task RedeemIAP()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DE6")]
		[Cpp2IlInjected.Address(RVA = "0xA40A90", Offset = "0xA3F490", VA = "0x180A40A90", Slot = "13")]
		public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
		{
			//Discarded unreachable code: IL_002d
			string _003Cid_003Ek__BackingField = product.definition.id;
			string msg = string.Format("[Apple] IAP Purchase failed - Product: '{0}', PurchaseFailureReason: {1}", _003Cid_003Ek__BackingField, "[Apple] IAP Purchase failed - Product: '{0}', PurchaseFailureReason: {1}");
			object[] args = Array.Empty<object>();
			GameLog.Info(msg, args);
		}
	}
}
