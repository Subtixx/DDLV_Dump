using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Platform;
using Mdl.Platform.Shop;
using Mdl.Utils;
using Meta;
using Meta.Online;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000594")]
	public class InGameShopContent : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000595")]
		[RequiredAllNotNull]
		public class InGameShopBattlePassSeasonAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001EE4")]
			[SerializeField]
			[Proto("Definitions.BattlePassSeasonData, Meta.Definitions")]
			public string EventIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001EE5")]
			public AssetReferenceTexture EventPremiumBannerRef;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001EE6")]
			public TMP_SpriteAsset EventCurrencyTextSpriteRef;

			[Cpp2IlInjected.Token(Token = "0x60024B1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public InGameShopBattlePassSeasonAsset()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000596")]
		[RequiredAllNotNull]
		public class InGameShopGameUpgradeAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001EE7")]
			[SerializeField]
			[Proto("Definitions.OnlineBundleData, Meta.Definitions")]
			public string BundleIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001EE8")]
			public string TitleStringId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001EE9")]
			public AssetReferenceTexture BundleImageRef;

			[Cpp2IlInjected.Token(Token = "0x60024B2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public InGameShopGameUpgradeAsset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000597")]
		public delegate void ItemBought(int amount);

		[Cpp2IlInjected.Token(Token = "0x2000598")]
		public struct UIStoreContent
		{
			[Cpp2IlInjected.Token(Token = "0x2000599")]
			public class InitNativeItemResult
			{
				[Cpp2IlInjected.Token(Token = "0x200059A")]
				public enum ItemStatusCode
				{
					[Cpp2IlInjected.Token(Token = "0x4001EEF")]
					NotInit,
					[Cpp2IlInjected.Token(Token = "0x4001EF0")]
					InvalidStoreContent,
					[Cpp2IlInjected.Token(Token = "0x4001EF1")]
					NotNativeItem,
					[Cpp2IlInjected.Token(Token = "0x4001EF2")]
					NativeShopManagerNotFound,
					[Cpp2IlInjected.Token(Token = "0x4001EF3")]
					NativeShopManagerEmpty,
					[Cpp2IlInjected.Token(Token = "0x4001EF4")]
					NativeItemNotFound,
					[Cpp2IlInjected.Token(Token = "0x4001EF5")]
					NativeItemFound
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4001EED")]
				public ItemStatusCode InitStatus;

				[Cpp2IlInjected.Token(Token = "0x60024C1")]
				[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
				public InitNativeItemResult With(ItemStatusCode code)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60024C2")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public InitNativeItemResult()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001EEC")]
			public InitNativeItemResult LastInitNativeItemResult;

			[Cpp2IlInjected.Token(Token = "0x170005AB")]
			public bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x60024B7")]
				[Cpp2IlInjected.Address(RVA = "0xB0E480", Offset = "0xB0CE80", VA = "0x180B0E480")]
				get
				{
					if (LastInitNativeItemResult.InitStatus == InitNativeItemResult.ItemStatusCode.NotNativeItem)
					{
						int num = 0;
						bool result = default(bool);
						return result;
					}
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170005AC")]
			public string FormattedPrice
			{
				[Cpp2IlInjected.Token(Token = "0x60024B8")]
				[Cpp2IlInjected.Address(RVA = "0xB0E360", Offset = "0xB0CD60", VA = "0x180B0E360")]
				get
				{
					//Discarded unreachable code: IL_0034
					NativeShopItemBase nativeShopItemBase = NativeShopItem;
					if (nativeShopItemBase == null)
					{
						if (LastInitNativeItemResult.InitStatus != InitNativeItemResult.ItemStatusCode.NotNativeItem)
						{
							return string.Empty;
						}
						int num = 0;
						int num2 = 0;
						CultureInfo currentCulture = CultureInfo.CurrentCulture;
						string result = default(string);
						return result;
					}
					return nativeShopItemBase.FormattedPrice;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170005AD")]
			public Definitions.StoreContent StoreContent
			{
				[Cpp2IlInjected.Token(Token = "0x60024BA")]
				[Cpp2IlInjected.Address(RVA = "0x6DDC90", Offset = "0x6DC690", VA = "0x1806DDC90")]
				[CompilerGenerated]
				readonly get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				[Cpp2IlInjected.Token(Token = "0x60024BB")]
				[Cpp2IlInjected.Address(RVA = "0x6DDCC0", Offset = "0x6DC6C0", VA = "0x1806DDCC0")]
				[CompilerGenerated]
				private set
				{
					_003CStoreContent_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170005AE")]
			public NativeShopItemBase NativeShopItem
			{
				[Cpp2IlInjected.Token(Token = "0x60024BC")]
				[Cpp2IlInjected.Address(RVA = "0x6DDCA0", Offset = "0x6DC6A0", VA = "0x1806DDCA0")]
				[CompilerGenerated]
				readonly get
				{
					return _003CNativeShopItem_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60024BD")]
				[Cpp2IlInjected.Address(RVA = "0x6DDCD0", Offset = "0x6DC6D0", VA = "0x1806DDCD0")]
				[CompilerGenerated]
				private set
				{
					_003CNativeShopItem_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170005AF")]
			public bool IsNativeShopItem
			{
				[Cpp2IlInjected.Token(Token = "0x60024BE")]
				[Cpp2IlInjected.Address(RVA = "0xB0E460", Offset = "0xB0CE60", VA = "0x180B0E460")]
				get
				{
					//Discarded unreachable code: IL_0012
					return LastInitNativeItemResult.InitStatus != InitNativeItemResult.ItemStatusCode.NotNativeItem;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60024B9")]
			[Cpp2IlInjected.Address(RVA = "0xB0D9A0", Offset = "0xB0C3A0", VA = "0x180B0D9A0")]
			public string GetParsedItemDesc()
			{
				string description = NativeShopItem.Description;
				if (description != null)
				{
					string text = description.Replace("Â", "");
					if (text != null)
					{
						string text2 = text.Replace("â€™", "'");
						if (text2 != null)
						{
							string text3 = text2.Replace("â€œ", "\"");
							if (text3 != null)
							{
								string text4 = text3.Replace("<font color=", "<color=");
								if (text4 != null)
								{
									return text4.Replace("</font>", "</color>");
								}
							}
						}
					}
				}
				int num = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x60024BF")]
			[Cpp2IlInjected.Address(RVA = "0xB0DF50", Offset = "0xB0C950", VA = "0x180B0DF50")]
			public UIStoreContent(Definitions.StoreContent content)
			{
				//Discarded unreachable code: IL_00e5
				//IL_0016: Expected O, but got I4
				//IL_0052: Expected O, but got I4
				//IL_007a: Expected O, but got I4
				//IL_008d: Expected O, but got I4
				//IL_00b1: Expected O, but got I4
				//IL_00d4: Expected O, but got I4
				object[] array;
				StoreContentBundle storeContentBundle = default(StoreContentBundle);
				bool isInAppPurchase = default(bool);
				InitNativeItemResult.ItemStatusCode initStatus;
				while (true)
				{
					InitNativeItemResult initNativeItemResult = (LastInitNativeItemResult = new InitNativeItemResult());
					int num = 0;
					NativeShopItem = (NativeShopItemBase)num;
					StoreContent = content;
					InitNativeItemResult initNativeItemResult2 = InitNativeItem();
					array = new object[0];
					StoreContentBundle bundle = content.Bundle;
					if (bundle != null)
					{
						string name = bundle.Name;
					}
					if (num != 0 && bundle == null)
					{
						continue;
					}
					array[0] = num;
					StoreContentItem item = content.Item;
					if (item != null)
					{
						string name2 = item.Name;
						if (name2 != null && name2 == null)
						{
							continue;
						}
					}
					array[1] = num;
					if (num != 0 && num == 0)
					{
						continue;
					}
					array[2] = num;
					if (storeContentBundle != null)
					{
						isInAppPurchase = storeContentBundle.IsInAppPurchase;
					}
					if (!isInAppPurchase || isInAppPurchase)
					{
						array[3] = isInAppPurchase;
						initStatus = LastInitNativeItemResult.InitStatus;
						if (initStatus == InitNativeItemResult.ItemStatusCode.NotInit || initStatus != 0)
						{
							break;
						}
					}
				}
				array[4] = initStatus;
				Debug.Log(string.Format("UIStoreContent.ctor BundleName={0} ItemName{1} IsBundle={2} IsInAppPurchase={3} LastInitNativeItemResult.InitStatus={4}", array));
			}

			[Cpp2IlInjected.Token(Token = "0x60024C0")]
			[Cpp2IlInjected.Address(RVA = "0xB0DB00", Offset = "0xB0C500", VA = "0x180B0DB00")]
			private InitNativeItemResult InitNativeItem()
			{
				//IL_000f: Expected O, but got I8
				_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
				NativeShopItem = (NativeShopItemBase)0;
				StoreContentBundle storeContentBundle = default(StoreContentBundle);
				if ((LastInitNativeItemResult = new InitNativeItemResult()) != null && storeContentBundle.IsInAppPurchase)
				{
					int num = 0;
					NativeShopManagerBase nativeShopManager = PlatformInterfaceManager.Instance.NativeShopManager;
					if (nativeShopManager != null)
					{
						IEnumerable<NativeShopItemBase> allShopItems = (IEnumerable<NativeShopItemBase>)nativeShopManager.get_AllShopItems();
						if (Enumerable.Count<NativeShopItemBase>((IEnumerable<>)allShopItems) > 0)
						{
							StoreContentBundle storeContentBundle2 = default(StoreContentBundle);
							IAPData iAPData = (CS_0024_003C_003E8__locals0.iapToSearch = storeContentBundle2.BundleIAPData);
							Func<NativeShopItemBase, bool> func = (Func<NativeShopItemBase, bool>)(object)(Func<T, TResult>)((NativeShopItemBase x) => default(bool));
							NativeShopItemBase nativeShopItemBase = (NativeShopItem = Enumerable.FirstOrDefault<NativeShopItemBase>((IEnumerable<>)allShopItems, (Func<, >)(object)func));
							if ((long)NativeShopItem != 0)
							{
							}
							string uniqueName_ = CS_0024_003C_003E8__locals0.iapToSearch.uniqueName_;
							Func<NativeShopItemBase, string> func2 = default(Func<NativeShopItemBase, string>);
							if (_003C_003Ec._003C_003E9__18_1 == null)
							{
								func2 = (Func<NativeShopItemBase, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((NativeShopItemBase x) => null));
							}
							IEnumerable<NativeShopItemBase> enumerable = (IEnumerable<NativeShopItemBase>)Enumerable.Select<NativeShopItemBase, string>((IEnumerable<>)allShopItems, (Func<, >)(object)func2);
							string text = string.Join(", ", (IEnumerable<>)enumerable);
							Debug.LogError("UIStoreContent.InitNativeItem did not find NativeItemShop for Bundle IAPData=" + uniqueName_ + ", nativeShop contains those product ids=" + text);
						}
					}
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200059D")]
		public struct ContentsPerStore
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001EF9")]
			public OnlineStoreData Store;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4001EFA")]
			public List<UIStoreContent> AllContents;

			[Cpp2IlInjected.Token(Token = "0x170005B0")]
			public IEnumerable<UIStoreContent> Contents
			{
				[Cpp2IlInjected.Token(Token = "0x60024C8")]
				[Cpp2IlInjected.Address(RVA = "0xAFC5D0", Offset = "0xAFAFD0", VA = "0x180AFC5D0")]
				get
				{
					List<UIStoreContent> allContents = AllContents;
					if (allContents != null)
					{
						Func<UIStoreContent, bool> _003C_003E9__3_ = _003C_003Ec._003C_003E9__3_0;
						if (_003C_003E9__3_ == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UIStoreContent x) => default(bool));
						}
						return (IEnumerable<UIStoreContent>)Enumerable.Where<UIStoreContent>((IEnumerable<>)allContents, (Func<, >)(object)_003C_003E9__3_);
					}
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170005B1")]
			public IEnumerable<UIStoreContent> InvalidContents
			{
				[Cpp2IlInjected.Token(Token = "0x60024C9")]
				[Cpp2IlInjected.Address(RVA = "0xAFC710", Offset = "0xAFB110", VA = "0x180AFC710")]
				get
				{
					List<UIStoreContent> allContents = AllContents;
					if (allContents != null)
					{
						Func<UIStoreContent, bool> _003C_003E9__5_ = _003C_003Ec._003C_003E9__5_0;
						if (_003C_003E9__5_ == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UIStoreContent x) => default(bool));
						}
						return (IEnumerable<UIStoreContent>)Enumerable.Where<UIStoreContent>((IEnumerable<>)allContents, (Func<, >)(object)_003C_003E9__5_);
					}
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170005B2")]
			public bool ShouldDisplayOfflineMode
			{
				[Cpp2IlInjected.Token(Token = "0x60024CA")]
				[Cpp2IlInjected.Address(RVA = "0xAFC850", Offset = "0xAFB250", VA = "0x180AFC850")]
				get
				{
					int num = Enumerable.Count<UIStoreContent>(this.get_InvalidContents());
					int num2 = 0;
					return Enumerable.Count<UIStoreContent>(this.get_Contents()) == 0;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170005B3")]
			public bool IsEmptyWithInvalidContent
			{
				[Cpp2IlInjected.Token(Token = "0x60024CB")]
				[Cpp2IlInjected.Address(RVA = "0xAFC850", Offset = "0xAFB250", VA = "0x180AFC850")]
				get
				{
					int num = Enumerable.Count<UIStoreContent>(this.get_InvalidContents());
					int num2 = 0;
					return Enumerable.Count<UIStoreContent>(this.get_Contents()) == 0;
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001EAB")]
		[SerializeField]
		private BaseButton _btnNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001EAC")]
		[SerializeField]
		private BaseButton _btnPrevious;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001EAD")]
		[SerializeField]
		private BaseButton _btnPreviewInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001EAE")]
		[SerializeField]
		private HorizontalLayoutGroup _pageIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001EAF")]
		[SerializeField]
		private RectTransform _previewContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001EB0")]
		[SerializeField]
		private RectTransform _previewInfoContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001EB1")]
		[SerializeField]
		private AsyncAtlassedIcon _previewIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001EB2")]
		[SerializeField]
		private AsyncAtlassedIcon[] _previewBundleIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001EB3")]
		[SerializeField]
		private RectTransform _previewBundleIconContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001EB4")]
		[SerializeField]
		private AsyncAtlassedIcon _buyPriceIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001EB5")]
		[SerializeField]
		private AsyncAtlassedIcon _salePriceIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001EB6")]
		[SerializeField]
		private LayoutGroup _itemContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001EB7")]
		[SerializeField]
		private RectTransform _timerContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001EB8")]
		[SerializeField]
		private RectTransform _previewSaleInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001EB9")]
		[SerializeField]
		private RectTransform _mcTaxInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001EBA")]
		[SerializeField]
		private CustomButton _btnBuy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001EBB")]
		[SerializeField]
		private TextBase _tfTaxInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001EBC")]
		[SerializeField]
		private TextBase _tfPreviewInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001EBD")]
		[SerializeField]
		private TextBase _tfPreviewInfoTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001EBE")]
		[SerializeField]
		private TextBase _tfOriginalPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001EBF")]
		[SerializeField]
		private TextBase _tfPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001EC0")]
		[SerializeField]
		private TextBase _tfTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4001EC1")]
		[SerializeField]
		private TextBase _tfPreviewName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001EC2")]
		[SerializeField]
		private TextBase _tfPreviewListItemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001EC3")]
		[SerializeField]
		private TextBase _tfPreviewSale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001EC4")]
		[SerializeField]
		private TextBase _tfHouseSkinWarning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001EC5")]
		[SerializeField]
		private PageIndicator _pagePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001EC6")]
		[SerializeField]
		private InGameShopItem _itemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001EC7")]
		[SerializeField]
		private AK.Wwise.Event _buyItemSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001EC8")]
		[SerializeField]
		private AK.Wwise.Event _buyHardCurrencySuccessSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001EC9")]
		[SerializeField]
		private RecycleBin _recycleBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001ECA")]
		[SerializeField]
		private UnlockPremiumContent _unlockPremiumContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001ECB")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001ECC")]
		[SerializeField]
		private RectTransform _shopUnavailableContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001ECD")]
		[SerializeField]
		private RectTransform _itemsContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001ECE")]
		[SerializeField]
		private RectTransform _gameUpgradesContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001ECF")]
		[SerializeField]
		private VerticalLayoutGroup _contentGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001ED0")]
		[SerializeField]
		private ScrollRect _previewInfoScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001ED1")]
		[SerializeField]
		private List<InGameShopBattlePassSeasonAsset> _battlePassAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4001ED2")]
		[SerializeField]
		private List<InGameShopGameUpgradeAsset> _gameUpgradeAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4001ED3")]
		[SerializeField]
		private InGameShopItem _gameUpgradeItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4001ED4")]
		[SerializeField]
		private AsyncImage _gameUpgradeBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4001ED5")]
		[SerializeField]
		private TextBase _gameUpgradeTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4001ED7")]
		private PageIndicator _currentPage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4001ED8")]
		private InGameShopTab _currentTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4001ED9")]
		private DateTime? _endOfSale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4001EDA")]
		private int _currentPageIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4001EDB")]
		private InGameShopItem _currentItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4001EDC")]
		private bool _pageChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x4001EDD")]
		private int _displayedItemCount = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4001EDE")]
		private int _pageCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4001EDF")]
		private int interval = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4001EE0")]
		private float nextTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4001EE1")]
		private bool shouldTriggerHardCurrencySFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4001EE2")]
		private List<ContentsPerStore> _storeTabContents = (List<ContentsPerStore>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4001EE3")]
		private List<OnlineStoreData> _storesData = (List<OnlineStoreData>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x170005A4")]
		internal string DEBUG_StoresDataAsString
		{
			[Cpp2IlInjected.Token(Token = "0x6002485")]
			[Cpp2IlInjected.Address(RVA = "0x131AE50", Offset = "0x1319850", VA = "0x18131AE50")]
			get
			{
				List<OnlineStoreData> storesData = _storesData;
				Func<OnlineStoreData, string> _003C_003E9__63_ = _003C_003Ec._003C_003E9__63_0;
				if (_003C_003E9__63_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(OnlineStoreData x)
					{
						//Discarded unreachable code: IL_0022
						//IL_0021: Expected O, but got I4
						RepeatedField<Definitions.StoreContent> contents_ = x.contents_;
						string onlineId_ = x.onlineId_;
						int count = ((RepeatedField<T>)(object)contents_).Count;
						return $"(name={onlineId_}, amount={count})";
					};
				}
				IEnumerable<OnlineStoreData> enumerable = (IEnumerable<OnlineStoreData>)Enumerable.Select<OnlineStoreData, string>((IEnumerable<>)storesData, (Func<, >)(object)_003C_003E9__63_);
				string text = string.Join(", ", (IEnumerable<>)enumerable);
				return "[" + text + "]";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A5")]
		public bool IsFeaturedTab
		{
			[Cpp2IlInjected.Token(Token = "0x6002486")]
			[Cpp2IlInjected.Address(RVA = "0x131AFF0", Offset = "0x13199F0", VA = "0x18131AFF0")]
			get
			{
				//Discarded unreachable code: IL_000f
				return _currentTab._type == InGameShopMenu.InGameShopTabType.Featured;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A6")]
		public bool IsOfferTab
		{
			[Cpp2IlInjected.Token(Token = "0x6002487")]
			[Cpp2IlInjected.Address(RVA = "0x131B0B0", Offset = "0x1319AB0", VA = "0x18131B0B0")]
			get
			{
				//Discarded unreachable code: IL_000f
				return _currentTab._type == InGameShopMenu.InGameShopTabType.Bundle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A7")]
		public bool IsTimeLimitedTab
		{
			[Cpp2IlInjected.Token(Token = "0x6002488")]
			[Cpp2IlInjected.Address(RVA = "0x131B0E0", Offset = "0x1319AE0", VA = "0x18131B0E0")]
			get
			{
				//Discarded unreachable code: IL_000f
				return _currentTab._type == InGameShopMenu.InGameShopTabType.TimeLimited;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A8")]
		public bool IsMoonstonePackTab
		{
			[Cpp2IlInjected.Token(Token = "0x6002489")]
			[Cpp2IlInjected.Address(RVA = "0x131B080", Offset = "0x1319A80", VA = "0x18131B080")]
			get
			{
				//Discarded unreachable code: IL_000f
				return _currentTab._type == InGameShopMenu.InGameShopTabType.HardCurrency;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005A9")]
		public bool IsItemShopTab
		{
			[Cpp2IlInjected.Token(Token = "0x600248A")]
			[Cpp2IlInjected.Address(RVA = "0x131B050", Offset = "0x1319A50", VA = "0x18131B050")]
			get
			{
				//Discarded unreachable code: IL_000f
				return _currentTab._type == InGameShopMenu.InGameShopTabType.ItemShop;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005AA")]
		public bool IsGameUpgradesTab
		{
			[Cpp2IlInjected.Token(Token = "0x600248B")]
			[Cpp2IlInjected.Address(RVA = "0x131B020", Offset = "0x1319A20", VA = "0x18131B020")]
			get
			{
				//Discarded unreachable code: IL_000f
				return _currentTab._type == InGameShopMenu.InGameShopTabType.GameUpgrades;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000042")]
		public event ItemBought OnItemBought
		{
			[Cpp2IlInjected.Token(Token = "0x6002483")]
			[Cpp2IlInjected.Address(RVA = "0x131ADB0", Offset = "0x13197B0", VA = "0x18131ADB0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002484")]
			[Cpp2IlInjected.Address(RVA = "0x131B110", Offset = "0x1319B10", VA = "0x18131B110")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600248C")]
		[Cpp2IlInjected.Address(RVA = "0x131A0E0", Offset = "0x1318AE0", VA = "0x18131A0E0")]
		private void Start()
		{
			//Discarded unreachable code: IL_00ff
			UnityEvent onClicked = _btnBuy.OnClicked;
			UnityAction call = OnBuyClick;
			onClicked.AddListener(call);
			UnityEvent onDehighlighted = _btnBuy.OnDehighlighted;
			UnityAction call2 = OnBuyDehighlighted;
			onDehighlighted.AddListener(call2);
			UnityEvent onHighlighted = _btnBuy.OnHighlighted;
			UnityAction call3 = OnBuyHighlighted;
			onHighlighted.AddListener(call3);
			Button.ButtonClickedEvent onClick = _btnNext.ButtonComponent.m_OnClick;
			UnityAction call4 = OnNextPage;
			onClick.AddListener(call4);
			Button.ButtonClickedEvent onClick2 = _btnPrevious.ButtonComponent.m_OnClick;
			UnityAction call5 = OnPreviousPage;
			onClick2.AddListener(call5);
			Button.ButtonClickedEvent onClick3 = _btnPreviewInfo.ButtonComponent.m_OnClick;
			UnityAction call6 = OnBtnInfoClick;
			onClick3.AddListener(call6);
			UnlockPremiumContent unlockPremiumContent = _unlockPremiumContent;
			UnlockPremiumContent.Confirmed value = OnConfirmedUnlockedPremium;
			unlockPremiumContent.OnConfirmed += value;
		}

		[Cpp2IlInjected.Token(Token = "0x600248D")]
		[Cpp2IlInjected.Address(RVA = "0x1314B90", Offset = "0x1313590", VA = "0x181314B90")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_00ff
			UnityEvent onClicked = _btnBuy.OnClicked;
			UnityAction call = OnBuyClick;
			onClicked.RemoveListener(call);
			UnityEvent onDehighlighted = _btnBuy.OnDehighlighted;
			UnityAction call2 = OnBuyDehighlighted;
			onDehighlighted.RemoveListener(call2);
			UnityEvent onHighlighted = _btnBuy.OnHighlighted;
			UnityAction call3 = OnBuyHighlighted;
			onHighlighted.RemoveListener(call3);
			Button.ButtonClickedEvent onClick = _btnNext.ButtonComponent.m_OnClick;
			UnityAction call4 = OnNextPage;
			onClick.RemoveListener(call4);
			Button.ButtonClickedEvent onClick2 = _btnPrevious.ButtonComponent.m_OnClick;
			UnityAction call5 = OnPreviousPage;
			onClick2.RemoveListener(call5);
			Button.ButtonClickedEvent onClick3 = _btnPreviewInfo.ButtonComponent.m_OnClick;
			UnityAction call6 = OnBtnInfoClick;
			onClick3.RemoveListener(call6);
			UnlockPremiumContent unlockPremiumContent = _unlockPremiumContent;
			UnlockPremiumContent.Confirmed value = OnConfirmedUnlockedPremium;
			unlockPremiumContent.OnConfirmed -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x600248E")]
		[Cpp2IlInjected.Address(RVA = "0x1315240", Offset = "0x1313C40", VA = "0x181315240")]
		private unsafe void OnNextPage()
		{
			//Discarded unreachable code: IL_0129
			//IL_001f: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			int num = 0;
			PageIndicator currentPage = _currentPage;
			int num2 = 0;
			if (currentPage == (UnityEngine.Object)num2)
			{
				return;
			}
			HorizontalLayoutGroup pageIndicator = _pageIndicator;
			int currentPageIndex = _currentPageIndex;
			int childCount = pageIndicator.transform.childCount;
			if (currentPageIndex >= childCount)
			{
				return;
			}
			Transform transform = _pageIndicator.transform;
			int currentPageIndex2 = _currentPageIndex;
			currentPageIndex2++;
			Transform child = transform.GetChild(currentPageIndex2);
			int num3 = 0;
			if (child != (UnityEngine.Object)num3)
			{
				Transform transform2 = _pageIndicator.transform;
				int currentPageIndex3 = _currentPageIndex;
				currentPageIndex3++;
				if (transform2.GetChild(currentPageIndex3).TryGetComponent<PageIndicator>(out *(PageIndicator*)num))
				{
					SetPage((PageIndicator)num);
				}
			}
			int num4 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				return;
			}
			int num5 = 0;
			IMenu menuOnTop = UiRoot.Instance.MenuOnTop;
			if (menuOnTop != null)
			{
				int num6 = 0;
			}
			InGameShopMenu shopMenu = (InGameShopMenu)menuOnTop;
			if ((long)shopMenu != 0 && _itemContainer.transform.childCount > 0)
			{
				IEnumerator routine = UIUtil.DelayedActionNextFrame(delegate
				{
					//Discarded unreachable code: IL_0034
					FocusNavigation focusNavigation = shopMenu.FocusNavigation;
					Transform transform3 = _itemContainer.transform;
					int index = 0;
					FocusNavigationElement component = transform3.GetChild(index).GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
				});
				Coroutine coroutine = StartCoroutine(routine);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600248F")]
		[Cpp2IlInjected.Address(RVA = "0x1315570", Offset = "0x1313F70", VA = "0x181315570")]
		private unsafe void OnPreviousPage()
		{
			//Discarded unreachable code: IL_0102
			//IL_001f: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			int num = 0;
			PageIndicator currentPage = _currentPage;
			int num2 = 0;
			if (currentPage == (UnityEngine.Object)num2 || _currentPageIndex == num)
			{
				return;
			}
			Transform transform = _pageIndicator.transform;
			int currentPageIndex = _currentPageIndex;
			Transform child = transform.GetChild(currentPageIndex);
			int num3 = 0;
			if (child != (UnityEngine.Object)num3)
			{
				Transform transform2 = _pageIndicator.transform;
				int currentPageIndex2 = _currentPageIndex;
				if (transform2.GetChild(currentPageIndex2).TryGetComponent<PageIndicator>(out *(PageIndicator*)num))
				{
					SetPage((PageIndicator)num);
				}
			}
			int num4 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				return;
			}
			int num5 = 0;
			IMenu menuOnTop = UiRoot.Instance.MenuOnTop;
			if (menuOnTop != null)
			{
				int num6 = 0;
			}
			InGameShopMenu shopMenu = (InGameShopMenu)menuOnTop;
			if ((long)shopMenu != 0 && _itemContainer.transform.childCount > 0)
			{
				IEnumerator routine = UIUtil.DelayedActionNextFrame(delegate
				{
					//Discarded unreachable code: IL_004a
					FocusNavigation focusNavigation = shopMenu.FocusNavigation;
					Transform transform3 = _itemContainer.transform;
					int index = _itemContainer.transform.childCount - 1;
					FocusNavigationElement component = transform3.GetChild(index).GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
				});
				Coroutine coroutine = StartCoroutine(routine);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002490")]
		[Cpp2IlInjected.Address(RVA = "0x1313DD0", Offset = "0x13127D0", VA = "0x181313DD0")]
		public static List<ContentsPerStore> GetStoreTabContents(List<OnlineStoreData> stores, InGameShopMenu.InGameShopTabType type, bool isDailyContent = false, bool isWeeklyContent = false)
		{
			//Discarded unreachable code: IL_0180, IL_0186, IL_018c, IL_0192, IL_019e, IL_01a4
			//IL_0098: Expected O, but got I4
			//IL_0118: Expected O, but got I4
			bool flag = default(bool);
			int num4 = default(int);
			Func<Definitions.StoreContent, UIStoreContent> func = default(Func<Definitions.StoreContent, UIStoreContent>);
			IEnumerable<Definitions.StoreContent> enumerable = default(IEnumerable<Definitions.StoreContent>);
			uint num5 = default(uint);
			int num6 = default(int);
			Func<Definitions.StoreContent, UIStoreContent> func3 = default(Func<Definitions.StoreContent, UIStoreContent>);
			Func<ContentsPerStore, bool> func4 = default(Func<ContentsPerStore, bool>);
			Func<ContentsPerStore, DateTime?> func5 = default(Func<ContentsPerStore, DateTime?>);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				List<ContentsPerStore> list = (List<ContentsPerStore>)(object)new List<T>();
				if (type == (InGameShopMenu.InGameShopTabType)num3)
				{
					if (flag)
					{
						while (num4 <= 0)
						{
						}
						if (_003C_003Ec._003C_003E9__82_2 == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Definitions.StoreContent x) => x.isFeatured_);
						}
						if (_003C_003Ec._003C_003E9__82_3 == null)
						{
							func = (Func<Definitions.StoreContent, UIStoreContent>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
							{
								int num12 = 0;
								int num13 = 0;
								/*Error: Unexpected end of block*/;
							});
						}
						List<UIStoreContent> list2 = (List<UIStoreContent>)(object)Enumerable.ToList<UIStoreContent>(Enumerable.Select<Definitions.StoreContent, UIStoreContent>((IEnumerable<>)enumerable, (Func<, >)(object)func));
						((List<T>)(object)list).Add((T)num2);
					}
					num3++;
					if (num3 != 0)
					{
						break;
					}
					if (num3 == 0)
					{
					}
				}
				Func<OnlineStoreData, bool> func2 = (Func<OnlineStoreData, bool>)(object)(Func<T, TResult>)delegate(OnlineStoreData x)
				{
					//Discarded unreachable code: IL_00b9
					InGameShopMenu.InGameShopTabType inGameShopTabType = type;
					if ((inGameShopTabType != InGameShopMenu.InGameShopTabType.HardCurrency || x.typeCase_ != OnlineStoreData.TypeOneofCase.InAppPurchase) && (inGameShopTabType != InGameShopMenu.InGameShopTabType.Bundle || x.typeCase_ != OnlineStoreData.TypeOneofCase.Offer))
					{
						if (inGameShopTabType != InGameShopMenu.InGameShopTabType.TimeLimited || x.typeCase_ != OnlineStoreData.TypeOneofCase.Rotation)
						{
							goto IL_0067;
						}
						bool flag2 = x.Rotation.interval_ == StoreTypeRotation.Types.RotationInterval.Daily;
						if (isDailyContent == flag2)
						{
							bool flag3 = x.Rotation.interval_ == StoreTypeRotation.Types.RotationInterval.Weekly;
							if (isWeeklyContent == flag3)
							{
								goto IL_0067;
							}
						}
					}
					goto IL_00a0;
					IL_00a0:
					return true;
					IL_0067:
					if (type != InGameShopMenu.InGameShopTabType.ItemShop || ((x.typeCase_ != OnlineStoreData.TypeOneofCase.Rotation || (x.Rotation.interval_ != 0 && x.Rotation.interval_ != StoreTypeRotation.Types.RotationInterval.Weekly)) && x.typeCase_ != OnlineStoreData.TypeOneofCase.Offer))
					{
						if (type != InGameShopMenu.InGameShopTabType.GameUpgrades)
						{
							int num11 = 0;
						}
						return (long)"{il2cpp field on {'constant26' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0x80}" == 16;
					}
					goto IL_00a0;
				};
				IEnumerable<OnlineStoreData> enumerable2 = (IEnumerable<OnlineStoreData>)Enumerable.Where<OnlineStoreData>((IEnumerable<>)stores, (Func<, >)(object)func2);
				if (enumerable2 != null)
				{
					if (num3 < (int)num5)
					{
						num3 += num3;
						if (num3 == (int)num5)
						{
							goto IL_0118;
						}
						num3++;
					}
					while (num3 == 0)
					{
					}
					while (num6 <= 0)
					{
					}
					if (_003C_003Ec._003C_003E9__82_5 == null)
					{
						func3 = (Func<Definitions.StoreContent, UIStoreContent>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							int num9 = 0;
							int num10 = 0;
							/*Error: Unexpected end of block*/;
						});
					}
					List<UIStoreContent> list3 = (List<UIStoreContent>)(object)Enumerable.ToList<UIStoreContent>(Enumerable.Select<Definitions.StoreContent, UIStoreContent>((IEnumerable<>)stores, (Func<, >)(object)func3));
					((List<T>)(object)list).Add((T)num3);
				}
				goto IL_0118;
				IL_0118:
				if (enumerable2 != null)
				{
				}
				if (num3 != 0)
				{
					continue;
				}
				if (_003C_003Ec._003C_003E9__82_0 == null)
				{
					func4 = (Func<ContentsPerStore, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new NullReferenceException();
					});
				}
				IOrderedEnumerable<ContentsPerStore> orderedEnumerable = (IOrderedEnumerable<ContentsPerStore>)Enumerable.OrderByDescending<ContentsPerStore, bool>((IEnumerable<>)list, (Func<, >)(object)func4);
				if (_003C_003Ec._003C_003E9__82_1 == null)
				{
					func5 = (Func<ContentsPerStore, DateTime?>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ContentsPerStore y)
					{
						if ((object)y != null)
						{
							int num7 = 0;
						}
						int num8 = 0;
						throw new NullReferenceException();
					});
				}
				return (List<ContentsPerStore>)(object)Enumerable.ToList<ContentsPerStore>((IEnumerable<>)Enumerable.ThenBy<ContentsPerStore, DateTime?>((IOrderedEnumerable<>)orderedEnumerable, (Func<, >)(object)func5));
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002491")]
		[Cpp2IlInjected.Address(RVA = "0x1319720", Offset = "0x1318120", VA = "0x181319720")]
		private void SendItemToBin(int amount)
		{
			//Discarded unreachable code: IL_0068
			int childCount = _itemContainer.transform.childCount;
			int num = Mathf.Min(amount, childCount);
			Transform transform = _itemContainer.transform;
			int index = _itemContainer.transform.childCount - 1;
			InGameShopItem component = transform.GetChild(index).GetComponent<InGameShopItem>();
			component.Release();
			RecycleBin recycleBin = _recycleBin;
			GameObject trash = component.gameObject;
			recycleBin.SendToBin(trash);
		}

		[Cpp2IlInjected.Token(Token = "0x6002492")]
		[Cpp2IlInjected.Address(RVA = "0x1317130", Offset = "0x1315B30", VA = "0x181317130")]
		private void RefreshItemDisplay()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002493")]
		[Cpp2IlInjected.Address(RVA = "0x1319BD0", Offset = "0x13185D0", VA = "0x181319BD0")]
		private void SetPage(PageIndicator pageItemCurrent)
		{
			//Discarded unreachable code: IL_0187
			//IL_002e: Expected O, but got I4
			//IL_005e: Expected I4, but got O
			//IL_00d5: Expected O, but got I4
			//IL_00f6: Expected O, but got I4
			//IL_0105: Expected O, but got I4
			//IL_0105: Expected O, but got I4
			//IL_0110: Expected O, but got I4
			bool flag = default(bool);
			if (flag)
			{
				int index = pageItemCurrent._index;
			}
			bool flag2 = default(bool);
			RedDot redDot = default(RedDot);
			GameObject gameObject = default(GameObject);
			if (flag2)
			{
				InGameShopMenu.InGameShopTabType type = _currentTab._type;
				if (type == InGameShopMenu.InGameShopTabType.TimeLimited && type == InGameShopMenu.InGameShopTabType.Featured)
				{
					int num = 0;
					if (redDot != (UnityEngine.Object)num)
					{
						gameObject = redDot.GetComponentInChildren<RedDot>(includeInactive: true).gameObject;
						int active = 0;
						gameObject.SetActive((byte)active != 0);
					}
				}
				int num2 = 0;
			}
			_currentPage = pageItemCurrent;
			_currentPageIndex = (int)gameObject;
			bool flag3 = default(bool);
			if (flag3)
			{
			}
			RefreshItemDisplay();
			if (_currentTab._type == InGameShopMenu.InGameShopTabType.HardCurrency && _itemContainer.transform.childCount > 0)
			{
				Transform transform = _itemContainer.transform;
				int index2 = _itemContainer.transform.childCount - 1;
				if ((object)transform.GetChild(index2).GetComponent<InGameShopItem>() != null)
				{
					goto IL_00c9;
				}
			}
			InGameShopItem componentInChildren = _itemContainer.GetComponentInChildren<InGameShopItem>();
			goto IL_00c9;
			IL_00c9:
			int num3 = 0;
			int num4 = default(int);
			if (!(componentInChildren != (UnityEngine.Object)num3) || !componentInChildren.gameObject.activeInHierarchy)
			{
				num4 = 0;
			}
			int num5 = 0;
			if (redDot != (UnityEngine.Object)num5)
			{
			}
			int num6 = 0;
			if ((UnityEngine.Object)num4 != (UnityEngine.Object)num6)
			{
				_currentItem = (InGameShopItem)num4;
			}
			RefreshItemPreview();
			InGameShopTab currentTab = _currentTab;
			VerticalLayoutGroup contentGroup = _contentGroup;
			bool flag5 = (contentGroup.reverseArrangement = currentTab._type == InGameShopMenu.InGameShopTabType.TimeLimited);
			GameObject gameObject2 = _btnNext.gameObject;
			int pageCount = _pageCount;
			bool active2 = _currentPageIndex < pageCount;
			gameObject2.SetActive(active2);
			GameObject gameObject3 = _btnPrevious.gameObject;
			bool active3 = _currentPageIndex > 0;
			gameObject3.SetActive(active3);
		}

		[Cpp2IlInjected.Token(Token = "0x6002494")]
		[Cpp2IlInjected.Address(RVA = "0x131A610", Offset = "0x1319010", VA = "0x18131A610")]
		private void UpdateMoonstoneDisclaimer(string tax_disclaimer)
		{
			//Discarded unreachable code: IL_0013, IL_0027
			TextBase tfTaxInfo = _tfTaxInfo;
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002495")]
		[Cpp2IlInjected.Address(RVA = "0x1314E80", Offset = "0x1313880", VA = "0x181314E80")]
		public void OnInGameShopMenuPop()
		{
			//Discarded unreachable code: IL_003a
			//IL_0010: Expected O, but got I4
			InGameShopTab currentTab = _currentTab;
			int num = 0;
			if (currentTab != (UnityEngine.Object)num && _currentTab._type == InGameShopMenu.InGameShopTabType.HardCurrency)
			{
				int num2 = 0;
				NativeShopManagerBase nativeShopManager = PlatformInterfaceManager.Instance.NativeShopManager;
				int opened = 0;
				nativeShopManager.OnUIShopStatusChanged((byte)opened != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002496")]
		[Cpp2IlInjected.Address(RVA = "0x131A6F0", Offset = "0x13190F0", VA = "0x18131A6F0")]
		public void UpdateRedDot()
		{
			//Discarded unreachable code: IL_0029
			//IL_0010: Expected O, but got I4
			//IL_001e: Expected I4, but got O
			InGameShopTab currentTab = _currentTab;
			int num = 0;
			if (currentTab != (UnityEngine.Object)num)
			{
				List<ContentsPerStore> list = (List<ContentsPerStore>)(object)new List<T>((int)_storeTabContents);
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002497")]
		[Cpp2IlInjected.Address(RVA = "0x13195E0", Offset = "0x1317FE0", VA = "0x1813195E0")]
		[AsyncStateMachine(typeof(_003CRefresh_003Ed__89))]
		public Task Refresh(List<OnlineStoreData> stores, InGameShopTab tab, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002498")]
		[Cpp2IlInjected.Address(RVA = "0x1313BD0", Offset = "0x13125D0", VA = "0x181313BD0")]
		private void DisplayUnlockPremiumBattlePass(BattlePassSeasonData eventData, InGameShopBattlePassSeasonAsset assets)
		{
			//Discarded unreachable code: IL_00e1
			//IL_00c1: Expected I4, but got I8
			//IL_00e0: Expected I4, but got I8
			BattlePassSeasonData.Types.Price premiumPassPrice_ = eventData.premiumPassPrice_;
			int id_ = premiumPassPrice_.id_;
			ItemType itemType = default(ItemType);
			Item hardCurrencyItem = default(Item);
			if (premiumPassPrice_ != null || itemType != ItemType.Currency)
			{
				int num = 0;
				hardCurrencyItem = CurrencyItem.HardCurrencyItem;
			}
			UnlockPremiumContent.UnlockPremiumParam unlockPremiumParam = new UnlockPremiumContent.UnlockPremiumParam();
			BattlePassSeasonData.Types.Price premiumPassPrice_2 = eventData.premiumPassPrice_;
			int num2 = (unlockPremiumParam.UnlockPlusPrice = eventData.currencyBundlePrice_.amount_);
			int num3 = (unlockPremiumParam.UnlockPrice = eventData.premiumPassPrice_.amount_);
			int num4 = (unlockPremiumParam.Offer = eventData.currencyBundleAmount_);
			unlockPremiumParam.Currency = hardCurrencyItem;
			string text = (unlockPremiumParam.EventCurrency = eventData.currencyName_);
			unlockPremiumParam.BattlePassData = eventData;
			unlockPremiumParam.IsNewestEvent = true;
			AssetReferenceTexture assetReferenceTexture = (unlockPremiumParam.BannerRef = assets.EventPremiumBannerRef);
			TMP_SpriteAsset tMP_SpriteAsset = (unlockPremiumParam.CurrencyIconTextRef = assets.EventCurrencyTextSpriteRef);
			unlockPremiumParam.DisplayState = UnlockPremiumContent.UnlockPremiumParam.UnlockPremiumDisplayState.InGameShopMenu;
			_unlockPremiumContent.Init(unlockPremiumParam);
			ulong num5 = default(ulong);
			_unlockPremiumContent.gameObject.SetActive((byte)num5 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002499")]
		[Cpp2IlInjected.Address(RVA = "0x1316970", Offset = "0x1315370", VA = "0x181316970")]
		private void RefreshGameUpgradeDisplay()
		{
			//Discarded unreachable code: IL_017c, IL_0182, IL_0188, IL_018e
			//IL_0011: Expected O, but got I4
			//IL_0021: Expected I4, but got I8
			//IL_0028: Expected O, but got I4
			//IL_00e5: Expected O, but got I4
			//IL_00f1: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			_currentPage = (PageIndicator)num2;
			_currentPageIndex = -1;
			_currentItem = (InGameShopItem)num2;
			GameObject gameObject = _btnPreviewInfo.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			int childCount = _itemContainer.transform.childCount;
			SendItemToBin(childCount);
			GameObject gameObject2 = _gameUpgradesContent.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			((List<T>)(object)_storeTabContents).Clear();
			InGameShopTab currentTab = _currentTab;
			int num3 = 0;
			int num4 = 0;
			InGameShopMenu.InGameShopTabType type = currentTab._type;
			List<ContentsPerStore> list = (_storeTabContents = (List<ContentsPerStore>)(object)InGameShopContent.GetStoreTabContents((List<>)(object)_storesData, type, (byte)num4 != 0, (byte)num3 != 0));
			if (_storeTabContents != null)
			{
				List<(UIStoreContent, OnlineStoreData)> list2 = (List<(UIStoreContent, OnlineStoreData)>)(object)new List<T>();
				List<ContentsPerStore> storeTabContents = _storeTabContents;
				bool flag = default(bool);
				if (flag)
				{
					IEnumerable<UIStoreContent> enumerable = default(IEnumerable<UIStoreContent>);
					if (enumerable != null)
					{
						StoreContentBundle storeContentBundle = default(StoreContentBundle);
						while (storeContentBundle == null)
						{
						}
						int num5 = 0;
						((List<T>)(object)list2).Add((T)num5);
					}
					if (enumerable == null)
					{
					}
				}
				(UIStoreContent content, OnlineStoreData store) itemToDisplay = ((UIStoreContent content, OnlineStoreData store))0;
				Func<InGameShopGameUpgradeAsset, bool> func = (Func<InGameShopGameUpgradeAsset, bool>)(object)(Func<T, TResult>)delegate(InGameShopGameUpgradeAsset x)
				{
					//Discarded unreachable code: IL_0027
					string text2 = x.BundleIdentifier.ToLower();
					(UIStoreContent, OnlineStoreData) tuple2 = itemToDisplay;
					StoreContentBundle storeContentBundle2 = default(StoreContentBundle);
					string value = storeContentBundle2.id_.ToLower();
					return text2.Equals(value);
				};
				InGameShopGameUpgradeAsset inGameShopGameUpgradeAsset = Enumerable.FirstOrDefault<InGameShopGameUpgradeAsset>(Enumerable.Where<InGameShopGameUpgradeAsset>((IEnumerable<>)list2, (Func<, >)(object)func));
				if (inGameShopGameUpgradeAsset != null)
				{
					GameObject gameObject3 = default(GameObject);
					gameObject3.SetActive(value: true);
					(UIStoreContent, OnlineStoreData) tuple = itemToDisplay;
					string titleStringId = inGameShopGameUpgradeAsset.TitleStringId;
					string assetGUID = inGameShopGameUpgradeAsset.BundleImageRef.AssetGUID;
				}
				else
				{
					GameObject gameObject4 = default(GameObject);
					gameObject4.SetActive(value: true);
				}
			}
			else
			{
				_shopUnavailableContent.gameObject.SetActive(value: true);
				InGameShopMenu.InGameShopTabType type2 = _currentTab._type;
				string dEBUG_StoresDataAsString = DEBUG_StoresDataAsString;
				string text = $"[UI/InGameShopContent] RefreshItemDisplay - failed to find store or content in tab {type2} => stores={dEBUG_StoresDataAsString}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600249A")]
		[Cpp2IlInjected.Address(RVA = "0x1318080", Offset = "0x1316A80", VA = "0x181318080")]
		private unsafe void RefreshItemPage()
		{
			//Discarded unreachable code: IL_014e, IL_0167, IL_0171, IL_018a, IL_0198, IL_019d, IL_01a5, IL_01b4, IL_01bd, IL_01d4, IL_01df, IL_01ea, IL_01f1, IL_01f8, IL_01fb, IL_0202, IL_0207, IL_020e, IL_0213, IL_0230, IL_024a, IL_0269, IL_027b, IL_0280, IL_029a, IL_02b9, IL_02d2, IL_02e9, IL_02f4, IL_02f9, IL_02fe, IL_0305, IL_030b, IL_0310, IL_0318, IL_031e, IL_032c, IL_0345, IL_034a, IL_0350, IL_035f, IL_0368, IL_0374, IL_037a, IL_0380, IL_0386
			//IL_006a: Expected O, but got I4
			//IL_014d: Expected I4, but got I8
			//IL_0195: Expected O, but got I4
			//IL_0195: Expected O, but got I4
			//IL_01b1: Expected O, but got I4
			//IL_0220: Expected O, but got I4
			//IL_0239: Expected I4, but got I8
			//IL_0247: Expected O, but got I4
			//IL_0253: Expected I4, but got I8
			//IL_0289: Expected I4, but got I8
			//IL_0297: Expected O, but got I4
			//IL_02a3: Expected I4, but got I8
			//IL_032a: Expected O, but got I4
			int num = 0;
			InGameShopMenu.InGameShopTabType type = _currentTab._type;
			if (type != InGameShopMenu.InGameShopTabType.TimeLimited && type != InGameShopMenu.InGameShopTabType.HardCurrency)
			{
				int num2 = 0;
				int num3 = 0;
				List<ContentsPerStore> storeTabContents = (List<ContentsPerStore>)(object)InGameShopContent.GetStoreTabContents((List<>)(object)_storesData, type, (byte)num3 != 0, (byte)num2 != 0);
				if (storeTabContents != null)
				{
					Func<ContentsPerStore, float> _003C_003E9__92_ = _003C_003Ec._003C_003E9__92_0;
					if (_003C_003E9__92_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ContentsPerStore x)
						{
							if (((ContentsPerStore*)x)->get_Contents() != null)
							{
								IEnumerable<UIStoreContent> contents = (IEnumerable<UIStoreContent>)((ContentsPerStore*)x)->get_Contents();
								Func<UIStoreContent, bool> _003C_003E9__92_2 = _003C_003Ec._003C_003E9__92_1;
								if (_003C_003E9__92_2 == null)
								{
									_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UIStoreContent y) => ((UIStoreContent*)y)->IsValid);
								}
								int num6 = Enumerable.Count<UIStoreContent>((IEnumerable<>)contents, (Func<, >)(object)_003C_003E9__92_2);
							}
							int num7 = 0;
							/*Error: Unexpected end of block*/;
						};
					}
					float num4 = Enumerable.Sum<ContentsPerStore>((IEnumerable<>)storeTabContents, (Func<, >)(object)_003C_003E9__92_);
				}
			}
			uint pageCount = default(uint);
			_pageCount = (int)pageCount;
			_currentPage = (PageIndicator)num;
			GameObject gameObject = _pageIndicator.gameObject;
			bool active = _pageCount > 1;
			gameObject.SetActive(active);
			GameObject gameObject2 = _btnNext.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			GameObject gameObject3 = _btnPrevious.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			GameObject gameObject4 = _timerContainer.gameObject;
			int active4 = 0;
			gameObject4.SetActive((byte)active4 != 0);
			GameObject gameObject5 = _mcTaxInfo.gameObject;
			int active5 = 0;
			gameObject5.SetActive((byte)active5 != 0);
			GameObject gameObject6 = _previewContainer.gameObject;
			int active6 = 0;
			gameObject6.SetActive((byte)active6 != 0);
			GameObject gameObject7 = _itemContainer.gameObject;
			int active7 = 0;
			gameObject7.SetActive((byte)active7 != 0);
			int childCount = _itemContainer.transform.childCount;
			SendItemToBin(childCount);
			ulong num5 = default(ulong);
			_shopUnavailableContent.gameObject.SetActive((byte)num5 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600249B")]
		[Cpp2IlInjected.Address(RVA = "0x13148A0", Offset = "0x13132A0", VA = "0x1813148A0")]
		private void OnBuyClick()
		{
			//IL_0010: Expected O, but got I4
			InGameShopItem currentItem = _currentItem;
			int num = 0;
			if (!(currentItem == (UnityEngine.Object)num))
			{
				InGameShopItem currentItem2 = _currentItem;
				PurchaseItem(currentItem2).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600249C")]
		[Cpp2IlInjected.Address(RVA = "0x13149F0", Offset = "0x13133F0", VA = "0x1813149F0")]
		private void OnConfirmedUnlockedPremium(UnlockPremiumContent.UnlockPremiumResult answer)
		{
			//Discarded unreachable code: IL_0023
			int num = (int)(answer + 1);
			if (num != 0 && num != 0 && (num == 0 || num == 0 || num == 1) && (object)InGameShopMenu.Instance == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600249D")]
		[Cpp2IlInjected.Address(RVA = "0x1315CA0", Offset = "0x13146A0", VA = "0x181315CA0")]
		private Task PurchaseItem(InGameShopItem item)
		{
			//Discarded unreachable code: IL_001e
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(item == (UnityEngine.Object)num))
			{
				bool flag = default(bool);
				if (!flag)
				{
					int num2 = 0;
				}
				int num3 = 0;
			}
			int num4 = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x600249E")]
		[Cpp2IlInjected.Address(RVA = "0x1314AE0", Offset = "0x13134E0", VA = "0x181314AE0")]
		public void OnCurrencyChanged(Item currencyItem, int gained, AddDetail detail)
		{
			int itemID = currencyItem.ItemID;
			if (!shouldTriggerHardCurrencySFX)
			{
				return;
			}
			int num = 0;
			Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
			if ((IntPtr)itemID == (IntPtr)hardCurrencyItem && gained > 0)
			{
				AK.Wwise.Event buyHardCurrencySuccessSfx = _buyHardCurrencySuccessSfx;
				if (buyHardCurrencySuccessSfx != null)
				{
					GameObject gameObject = base.gameObject;
					uint num2 = buyHardCurrencySuccessSfx.Post(gameObject);
				}
				shouldTriggerHardCurrencySFX = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600249F")]
		[Cpp2IlInjected.Address(RVA = "0x1315F60", Offset = "0x1314960", VA = "0x181315F60")]
		[AsyncStateMachine(typeof(_003CPurchaseNativeItem_003Ed__97))]
		private Task PurchaseNativeItem(InGameShopItem item)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60024A0")]
		[Cpp2IlInjected.Address(RVA = "0x1315B70", Offset = "0x1314570", VA = "0x181315B70")]
		[AsyncStateMachine(typeof(_003CPurchaseGameItem_003Ed__98))]
		private Task PurchaseGameItem(InGameShopItem item)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60024A1")]
		[Cpp2IlInjected.Address(RVA = "0x1315860", Offset = "0x1314260", VA = "0x181315860")]
		private void OnPurchaseGameItem(InGameShopItem item)
		{
			//Discarded unreachable code: IL_0065, IL_006b, IL_0071, IL_0077
			int num = 0;
			UIStoreContent _003CUIStoreContent_003Ek__BackingField = item.UIStoreContent;
			Definitions.StoreContent.Info info = default(Definitions.StoreContent.Info);
			List<Definitions.StoreContent.ItemReward> items = info.Items;
			NewItemPopUp.NewItemPopupParam newItemPopupParam = new NewItemPopUp.NewItemPopupParam();
			List<Definitions.StoreContent.ItemReward> items2 = info.Items;
			bool flag = default(bool);
			if (flag)
			{
				List<NewItemPopUp.NewItem> items3 = newItemPopupParam.Items;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				NewItemPopUp.NewItem newItem = default(NewItemPopUp.NewItem);
				((List<T>)(object)items3).Add((T)newItem);
				newItem = (NewItemPopUp.NewItem)(object)((object)newItem + (object)newItem);
			}
			int num3 = 0;
			newItemPopupParam.UsePopupStack = true;
			int num4 = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
		}

		[Cpp2IlInjected.Token(Token = "0x60024A2")]
		[Cpp2IlInjected.Address(RVA = "0x1319860", Offset = "0x1318260", VA = "0x181319860")]
		public void SetFocus(FocusNavigation focusNav)
		{
			//Discarded unreachable code: IL_0140
			//IL_0026: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			if (!_unlockPremiumContent.gameObject.activeInHierarchy)
			{
				InGameShopItem currentItem = _currentItem;
				int num = 0;
				if (!(currentItem != (UnityEngine.Object)num) || !_currentItem.gameObject.activeInHierarchy || _currentItem.GetComponentInChildren<FocusNavigationElement>().isActiveAndEnabled)
				{
				}
				if (_itemContainer.transform.childCount > 0)
				{
					Transform transform = _itemContainer.transform;
					int index = 0;
					if (transform.GetChild(index).gameObject.activeInHierarchy)
					{
						Transform transform2 = _itemContainer.transform;
						int index2 = 0;
						FocusNavigationElement componentInChildren = transform2.GetChild(index2).GetComponentInChildren<FocusNavigationElement>();
						int num2 = 0;
						if (componentInChildren != (UnityEngine.Object)num2)
						{
							Transform transform3 = _itemContainer.transform;
							int index3 = 0;
							if (transform3.GetChild(index3).GetComponentInChildren<FocusNavigationElement>().isActiveAndEnabled)
							{
								Transform transform4 = _itemContainer.transform;
								int index4 = 0;
								Transform child = transform4.GetChild(index4);
							}
						}
					}
				}
				if (_btnBuy.gameObject.activeInHierarchy && _btnBuy.GetComponentInChildren<FocusNavigationElement>().isActiveAndEnabled)
				{
					FocusNavigationElement componentInChildren2 = _btnBuy.GetComponentInChildren<FocusNavigationElement>();
					focusNav.SetFocus(componentInChildren2);
				}
			}
			else
			{
				_unlockPremiumContent.SetFocus(focusNav);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024A3")]
		[Cpp2IlInjected.Address(RVA = "0x1314960", Offset = "0x1313360", VA = "0x181314960")]
		private void OnBuyDehighlighted()
		{
			//Discarded unreachable code: IL_0028
			_btnBuy.View?.Background?.SetAlpha(1f);
		}

		[Cpp2IlInjected.Token(Token = "0x60024A4")]
		[Cpp2IlInjected.Address(RVA = "0x13149B0", Offset = "0x13133B0", VA = "0x1813149B0")]
		private void OnBuyHighlighted()
		{
			//Discarded unreachable code: IL_0026
			//IL_0024: Expected F4, but got I4
			ButtonViewDefault view = _btnBuy.View;
			if ((object)view != null)
			{
				ImageHelper background = view.Background;
				if ((object)background != null)
				{
					int num = 0;
					background.SetAlpha(num);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024A5")]
		[Cpp2IlInjected.Address(RVA = "0x1315560", Offset = "0x1313F60", VA = "0x181315560")]
		private void OnPageSelected(PageIndicator item)
		{
			SetPage(item);
		}

		[Cpp2IlInjected.Token(Token = "0x60024A6")]
		[Cpp2IlInjected.Address(RVA = "0x1315130", Offset = "0x1313B30", VA = "0x181315130")]
		private void OnItemSelected(InGameShopItem item)
		{
			//Discarded unreachable code: IL_0058
			//IL_0010: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			InGameShopItem currentItem = _currentItem;
			int num = 0;
			if (currentItem != (UnityEngine.Object)num)
			{
				InGameShopItem currentItem2 = _currentItem;
				currentItem2._isSelected = false;
				currentItem2.RefreshDisplay();
			}
			int num2 = 0;
			if (item != (UnityEngine.Object)num2)
			{
				_currentItem = item;
				InGameShopItem currentItem3 = _currentItem;
				currentItem3._isSelected = true;
				currentItem3.RefreshDisplay();
			}
			RefreshItemPreview();
		}

		[Cpp2IlInjected.Token(Token = "0x60024A7")]
		[Cpp2IlInjected.Address(RVA = "0x1314F60", Offset = "0x1313960", VA = "0x181314F60")]
		private void OnItemGamepadClicked(InGameShopItem item)
		{
			//Discarded unreachable code: IL_00ae
			//IL_0010: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			InGameShopItem currentItem = _currentItem;
			int num = 0;
			if (!(currentItem == (UnityEngine.Object)num))
			{
				InGameShopItem currentItem2 = _currentItem;
			}
			if (!item._isSelected)
			{
				item._btn?.PostWwiseEvent();
				item._isSelected = true;
				item.RefreshDisplay();
				item.OnSelected?.Invoke(item);
			}
			if (item.IsRecurrent || (!item._isOwned && CurrencyContent.GetCurrencyBalance(item.CurrencyToBuy) >= item.Price))
			{
				InGameShopItem currentItem3 = _currentItem;
				int num2 = 0;
				if (!(currentItem3 == (UnityEngine.Object)num2))
				{
					InGameShopItem currentItem4 = _currentItem;
					PurchaseItem(currentItem4).FireAndForgetTask();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024A8")]
		[Cpp2IlInjected.Address(RVA = "0x13147E0", Offset = "0x13131E0", VA = "0x1813147E0")]
		private void OnBtnInfoClick()
		{
			//Discarded unreachable code: IL_004d
			GameObject gameObject = _previewInfoContainer.gameObject;
			bool active = !_previewInfoContainer.gameObject.activeSelf;
			gameObject.SetActive(active);
			_tfPreviewInfo.transform.RebuildLayout();
			_tfPreviewInfo.transform.parent.RebuildLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x60024A9")]
		[Cpp2IlInjected.Address(RVA = "0x1318E90", Offset = "0x1317890", VA = "0x181318E90")]
		internal void RefreshItemPreview()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60024AA")]
		[Cpp2IlInjected.Address(RVA = "0x1316090", Offset = "0x1314A90", VA = "0x181316090")]
		private unsafe void RefreshBtnBuy()
		{
			//IL_0010: Expected O, but got I4
			InGameShopItem currentItem = _currentItem;
			int num = 0;
			bool flag = currentItem == (UnityEngine.Object)num;
			CustomButton btnBuy = _btnBuy;
			if (!flag)
			{
				btnBuy.gameObject.SetActive(value: true);
				GameObject gameObject = _previewSaleInfo.gameObject;
				InGameShopItem currentItem2 = _currentItem;
				int num2 = 0;
				if ((currentItem2.IsOnSale ? 1 : 0) == num2)
				{
				}
				bool active = (currentItem2._isOwned ? 1 : 0) == num2;
				gameObject.SetActive(active);
				InGameShopItem currentItem3 = _currentItem;
				TextBase tfPreviewSale = _tfPreviewSale;
				int num3 = 0;
				if ((long)currentItem3 == 1 || (long)currentItem3 != 1 || (long)currentItem3 != 1)
				{
				}
				string text = default(string);
				string text3 = (tfPreviewSale.StringID = text + "%");
				_tfPreviewSale.RectTransform.RebuildLayout();
				_tfPreviewSale.RectTransform.parent.RebuildLayout();
				InGameShopItem currentItem4 = _currentItem;
				TextBase tfOriginalPrice = _tfOriginalPrice;
				int num4 = 0;
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
				string text5 = (tfOriginalPrice.StringID = ((int*)num4)->ToString("N0", currentCulture));
				_tfOriginalPrice.transform.RebuildLayout();
				_tfOriginalPrice.transform.parent.RebuildLayout();
				InGameShopItem currentItem5 = _currentItem;
				string stringID = default(string);
				_tfPrice.StringID = stringID;
				GameObject gameObject2 = _buyPriceIcon.gameObject;
				InGameShopItem currentItem6 = _currentItem;
				bool active2 = default(bool);
				gameObject2.SetActive(active2);
				GameObject gameObject3 = _salePriceIcon.gameObject;
				Item _003CCurrencyToBuy_003Ek__BackingField = _currentItem.CurrencyToBuy;
				bool active3 = default(bool);
				gameObject3.SetActive(active3);
				InGameShopItem currentItem7 = _currentItem;
				bool flag2 = default(bool);
				if (flag2)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					Item _003CCurrencyToBuy_003Ek__BackingField2 = _currentItem.CurrencyToBuy;
					IItemData itemData = _003CInstance_003Ek__BackingField.GetItemData(_003CCurrencyToBuy_003Ek__BackingField2);
					AsyncAtlassedIcon buyPriceIcon = _buyPriceIcon;
					AsyncAtlassedIcon salePriceIcon = _salePriceIcon;
				}
				InGameShopItem currentItem8 = _currentItem;
				CustomButton btnBuy2 = _btnBuy;
				if (!currentItem8.IsRecurrent && !currentItem8._isOwned)
				{
					int currencyBalance = CurrencyContent.GetCurrencyBalance(currentItem8.CurrencyToBuy);
				}
				btnBuy2.IsInteractable = true;
				_tfOriginalPrice.ColorKey = (UIGameColors.GameColorName)num2;
				_tfPrice.ColorKey = (UIGameColors.GameColorName)num2;
				CanvasGroup component = _btnBuy.GetComponent<CanvasGroup>();
				CustomButton btnBuy3 = _btnBuy;
				component.alpha = 0.8f;
				ImageHelper background = _btnBuy.View.Background;
				int num5 = 0;
				UIGameColors gameColors = UiRoot.Instance._gameColors;
				CustomButton btnBuy4 = _btnBuy;
				FocusNavigationElement component2 = _btnBuy.GetComponent<FocusNavigationElement>();
				bool flag3 = (component2.IgnoreThis = !_btnBuy.gameObject.activeInHierarchy);
				Transform transform = _btnBuy.transform;
				Transform transform2 = _btnBuy.transform;
				if (_currentTab._type != InGameShopMenu.InGameShopTabType.GameUpgrades)
				{
				}
				Vector3 vector = default(Vector3);
				float z = vector.z;
				return;
			}
			GameObject gameObject4 = btnBuy.gameObject;
			int active4 = 0;
			gameObject4.SetActive((byte)active4 != 0);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60024AB")]
		[Cpp2IlInjected.Address(RVA = "0x13147B0", Offset = "0x13131B0", VA = "0x1813147B0")]
		private bool IsWeeklyPage(InGameShopTab tab, int pageIndex)
		{
			if (tab._type == InGameShopMenu.InGameShopTabType.TimeLimited)
			{
				return pageIndex > 0;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60024AC")]
		[Cpp2IlInjected.Address(RVA = "0x1314780", Offset = "0x1313180", VA = "0x181314780")]
		private bool IsDailyPage(InGameShopTab tab, int pageIndex)
		{
			if (tab._type == InGameShopMenu.InGameShopTabType.TimeLimited)
			{
				return pageIndex == 0;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60024AD")]
		[Cpp2IlInjected.Address(RVA = "0x131A930", Offset = "0x1319330", VA = "0x18131A930")]
		private void Update()
		{
			//Discarded unreachable code: IL_008a
			//IL_0010: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_00be: Expected O, but got I4
			InGameShopTab currentTab = _currentTab;
			int num = 0;
			if (currentTab != (UnityEngine.Object)num)
			{
				InGameShopTab currentTab2 = _currentTab;
				InGameShopMenu.InGameShopTabType type = currentTab2._type;
				if ((long)currentTab2 == 4294967290L && type != InGameShopMenu.InGameShopTabType.GameUpgrades)
				{
					int num2 = 0;
					float time = Time.time;
					Client client = default(Client);
					DateTime gamePortalTime = client.GamePortalTime;
					_tfTimer.Text = "";
					TextBase tfTimer = _tfTimer;
					int num3 = 0;
					string text2 = (tfTimer.Text = LocalizationManager.FromStringID("menu.common_timer_refreshes_in", (IResolver)num3) + "-");
					nextTime = time;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024AE")]
		[Cpp2IlInjected.Address(RVA = "0x131ACD0", Offset = "0x13196D0", VA = "0x18131ACD0")]
		public InGameShopContent()
		{
		}//IL_0010: Expected I4, but got I8
		//IL_0019: Expected I4, but got I8
		//IL_0022: Expected I4, but got I8

	}
}
