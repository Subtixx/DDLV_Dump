using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using glPlayFab.Disney;
using UnityEngine;

namespace Mdl.Platform.Shop
{
	[Cpp2IlInjected.Token(Token = "0x2000344")]
	public class SwitchNativeShopManager : NativeShopManagerBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000345")]
		protected class NativeData
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000346")]
			public class Consumable
			{
				[Serializable]
				[Cpp2IlInjected.Token(Token = "0x2000347")]
				public class Item
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40016C9")]
					public string consumable_id;

					[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
					[Cpp2IlInjected.Token(Token = "0x40016CA")]
					public string name;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40016CB")]
					public string description;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40016CC")]
					public string disclaimer;

					[Cpp2IlInjected.Token(Token = "0x6000E2E")]
					[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
					public Item()
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40016C7")]
				public string lang;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40016C8")]
				public Item[] consumables;

				[Cpp2IlInjected.Token(Token = "0x170001D1")]
				public int ItemCount
				{
					[Cpp2IlInjected.Token(Token = "0x6000E2A")]
					[Cpp2IlInjected.Address(RVA = "0x1935240", Offset = "0x1933C40", VA = "0x181935240")]
					get
					{
						return default(int);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000E2B")]
				[Cpp2IlInjected.Address(RVA = "0x1935200", Offset = "0x1933C00", VA = "0x181935200")]
				public static Consumable ParseJson(string json)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000E2C")]
				[Cpp2IlInjected.Address(RVA = "0x19351E0", Offset = "0x1933BE0", VA = "0x1819351E0")]
				public string ToJson()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000E2D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public Consumable()
				{
				}
			}

			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000348")]
			public class ConsumableItem
			{
				[Serializable]
				[Cpp2IlInjected.Token(Token = "0x2000349")]
				public class Item
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40016D4")]
					public string item_id;

					[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
					[Cpp2IlInjected.Token(Token = "0x40016D5")]
					public string name;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40016D6")]
					public ulong ns_uid;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40016D7")]
					public Price price;

					[Cpp2IlInjected.Token(Token = "0x170001D3")]
					public string EffectiveFormattedPrice
					{
						[Cpp2IlInjected.Token(Token = "0x6000E33")]
						[Cpp2IlInjected.Address(RVA = "0x1935250", Offset = "0x1933C50", VA = "0x181935250")]
						get
						{
							return null;
						}
					}

					[Cpp2IlInjected.Token(Token = "0x6000E34")]
					[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
					public Item()
					{
					}
				}

				[Serializable]
				[Cpp2IlInjected.Token(Token = "0x200034A")]
				public class Price
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40016D8")]
					public string sales_status;

					[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
					[Cpp2IlInjected.Token(Token = "0x40016D9")]
					public RegularPrice regular_price;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40016DA")]
					public DiscountPrice discount_price;

					[Cpp2IlInjected.Token(Token = "0x6000E35")]
					[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
					public Price()
					{
					}
				}

				[Serializable]
				[Cpp2IlInjected.Token(Token = "0x200034B")]
				public class RegularPrice
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40016DB")]
					public string currency;

					[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
					[Cpp2IlInjected.Token(Token = "0x40016DC")]
					public string formatted_value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40016DD")]
					public int raw_value;

					[Cpp2IlInjected.Token(Token = "0x6000E36")]
					[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
					public RegularPrice()
					{
					}
				}

				[Serializable]
				[Cpp2IlInjected.Token(Token = "0x200034C")]
				public class DiscountPrice
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40016DE")]
					public string currency;

					[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
					[Cpp2IlInjected.Token(Token = "0x40016DF")]
					public string formatted_value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40016E0")]
					public int raw_value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40016E1")]
					public string start_datetime;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40016E2")]
					public string end_datetime;

					[Cpp2IlInjected.Token(Token = "0x6000E37")]
					[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
					public DiscountPrice()
					{
					}
				}

				[NonSerialized]
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40016CD")]
				public string consumable_id;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40016CE")]
				public string lang;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40016CF")]
				public string inc_tax_message;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40016D0")]
				public int length;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40016D1")]
				public int offset;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40016D2")]
				public int total;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40016D3")]
				public Item[] consumable_items;

				[Cpp2IlInjected.Token(Token = "0x170001D2")]
				public int ItemCount
				{
					[Cpp2IlInjected.Token(Token = "0x6000E2F")]
					[Cpp2IlInjected.Address(RVA = "0x19351F0", Offset = "0x1933BF0", VA = "0x1819351F0")]
					get
					{
						return default(int);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000E30")]
				[Cpp2IlInjected.Address(RVA = "0x19351A0", Offset = "0x1933BA0", VA = "0x1819351A0")]
				public static ConsumableItem ParseJson(string json)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000E31")]
				[Cpp2IlInjected.Address(RVA = "0x19351E0", Offset = "0x1933BE0", VA = "0x1819351E0")]
				public string ToJson()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000E32")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public ConsumableItem()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000E29")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public NativeData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200034D")]
		private enum InitStatus
		{
			[Cpp2IlInjected.Token(Token = "0x40016E4")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x40016E5")]
			NoNativeUserLogged,
			[Cpp2IlInjected.Token(Token = "0x40016E6")]
			FailedInitConsumableGroups,
			[Cpp2IlInjected.Token(Token = "0x40016E7")]
			FailedInitConsumableItems,
			[Cpp2IlInjected.Token(Token = "0x40016E8")]
			ConsumableGroupNotInit,
			[Cpp2IlInjected.Token(Token = "0x40016E9")]
			NetworkNotAvailable,
			[Cpp2IlInjected.Token(Token = "0x40016EA")]
			InitializeForShopServiceAccessorsFailed,
			[Cpp2IlInjected.Token(Token = "0x40016EB")]
			FinalizeForShopServiceAccessorsFailed,
			[Cpp2IlInjected.Token(Token = "0x40016EC")]
			NotRunningOnNativePlatform
		}

		[Cpp2IlInjected.Token(Token = "0x200034E")]
		protected class SwitchNativeShopItem : NativeShopItemBase
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40016ED")]
			private NativeData.ConsumableItem items;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40016EE")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x170001D4")]
			public override bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x6000E39")]
				[Cpp2IlInjected.Address(RVA = "0x121A4B0", Offset = "0x1218EB0", VA = "0x18121A4B0", Slot = "4")]
				get
				{
					NativeData.ConsumableItem consumableItem = items;
					if (consumableItem != null)
					{
						int num = index;
						NativeData.ConsumableItem.Item[] consumable_items = consumableItem.consumable_items;
						return num < consumable_items.Length;
					}
					int num2 = 0;
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001D5")]
			public override string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000E3A")]
				[Cpp2IlInjected.Address(RVA = "0x121A510", Offset = "0x1218F10", VA = "0x18121A510", Slot = "5")]
				get
				{
					//Discarded unreachable code: IL_0036
					if (IsValid)
					{
						bool isValid = IsValid;
						NativeData.ConsumableItem.Item[] consumable_items = items.consumable_items;
						int num = index;
						return consumable_items[num].name;
					}
					return string.Empty;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001D6")]
			public override string FormattedPrice
			{
				[Cpp2IlInjected.Token(Token = "0x6000E3B")]
				[Cpp2IlInjected.Address(RVA = "0x121A3F0", Offset = "0x1218DF0", VA = "0x18121A3F0", Slot = "6")]
				get
				{
					//Discarded unreachable code: IL_0036
					if (IsValid)
					{
						bool isValid = IsValid;
						NativeData.ConsumableItem.Item[] consumable_items = items.consumable_items;
						int num = index;
						return consumable_items[num].EffectiveFormattedPrice;
					}
					return string.Empty;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001D7")]
			public override string Description
			{
				[Cpp2IlInjected.Token(Token = "0x6000E3C")]
				[Cpp2IlInjected.Address(RVA = "0x121A3B0", Offset = "0x1218DB0", VA = "0x18121A3B0", Slot = "8")]
				get
				{
					return string.Empty;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001D8")]
			public override string NativeItemID
			{
				[Cpp2IlInjected.Token(Token = "0x6000E3D")]
				[Cpp2IlInjected.Address(RVA = "0x121A5C0", Offset = "0x1218FC0", VA = "0x18121A5C0", Slot = "7")]
				get
				{
					//Discarded unreachable code: IL_0027
					bool isValid = IsValid;
					NativeData.ConsumableItem.Item[] consumable_items = items.consumable_items;
					int num = index;
					return consumable_items[num].item_id;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001D9")]
			public string ItemConsumableId
			{
				[Cpp2IlInjected.Token(Token = "0x6000E3F")]
				[Cpp2IlInjected.Address(RVA = "0x121A4F0", Offset = "0x1218EF0", VA = "0x18121A4F0")]
				get
				{
					//Discarded unreachable code: IL_000c
					return items.consumable_id;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000E38")]
			[Cpp2IlInjected.Address(RVA = "0xA28250", Offset = "0xA26C50", VA = "0x180A28250")]
			public SwitchNativeShopItem(NativeData.ConsumableItem items, int index)
			{
				((BattlePassReward)(object)this)._002Ector();
				this.items = items;
				this.index = index;
			}

			[Cpp2IlInjected.Token(Token = "0x6000E3E")]
			[Cpp2IlInjected.Address(RVA = "0x121A340", Offset = "0x1218D40", VA = "0x18121A340")]
			public NativeData.ConsumableItem.Item GetNativeItem()
			{
				if (IsValid)
				{
					NativeData.ConsumableItem.Item[] consumable_items = items.consumable_items;
					int num = index;
					return consumable_items[num];
				}
				int num2 = 0;
				throw new IndexOutOfRangeException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40016C1")]
		public static readonly ulong DDVApplicationID = 72290209781358592uL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40016C2")]
		private ulong ApplicationID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40016C3")]
		private NativeData.Consumable ConsumableGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40016C4")]
		private NativeData.ConsumableItem[] ConsumableItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40016C5")]
		private List<SwitchNativeShopItem> SwitchShopItems = (List<SwitchNativeShopItem>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40016C6")]
		private SharedTask<InitStatus> SharedInitShopImplTask;

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public string TaxDisclaimerNotFoundError
		{
			[Cpp2IlInjected.Token(Token = "0x6000E1B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return base.TaxDisclaimer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public override string TaxDisclaimer
		{
			[Cpp2IlInjected.Token(Token = "0x6000E1C")]
			[Cpp2IlInjected.Address(RVA = "0x1069E40", Offset = "0x1068840", VA = "0x181069E40", Slot = "9")]
			get
			{
				NativeData.ConsumableItem consumableItem;
				do
				{
					NativeData.ConsumableItem[] consumableItems = ConsumableItems;
					if (consumableItems == null)
					{
						break;
					}
					consumableItem = Enumerable.FirstOrDefault<NativeData.ConsumableItem>((IEnumerable<>)(object)consumableItems);
				}
				while (consumableItem != null && consumableItem.inc_tax_message != null);
				return base.TaxDisclaimer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public override string StoreName
		{
			[Cpp2IlInjected.Token(Token = "0x6000E1D")]
			[Cpp2IlInjected.Address(RVA = "0x1069DD0", Offset = "0x10687D0", VA = "0x181069DD0", Slot = "10")]
			get
			{
				//IL_0010: Expected O, but got I4
				//IL_0010: Expected O, but got I4
				int num = 0;
				int num2 = 0;
				return LocalizationManager.FromStringID("menu.shop_native_storename_nintendo_switch", (IResolver)num2, (string)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public override IEnumerable<NativeShopItemBase> AllShopItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000E1E")]
			[Cpp2IlInjected.Address(RVA = "0x1069CA0", Offset = "0x10686A0", VA = "0x181069CA0", Slot = "5")]
			get
			{
				List<SwitchNativeShopItem> switchShopItems = SwitchShopItems;
				Func<SwitchNativeShopItem, NativeShopItemBase> _003C_003E9__16_ = _003C_003Ec._003C_003E9__16_0;
				if (_003C_003E9__16_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				return (IEnumerable<NativeShopItemBase>)Enumerable.Select<SwitchNativeShopItem, NativeShopItemBase>((IEnumerable<>)switchShopItems, (Func<, >)(object)_003C_003E9__16_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1A")]
		[Cpp2IlInjected.Address(RVA = "0x1069BE0", Offset = "0x10685E0", VA = "0x181069BE0")]
		public SwitchNativeShopManager(ulong applicationID)
		{
			ApplicationID = applicationID;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1F")]
		[Cpp2IlInjected.Address(RVA = "0x10698E0", Offset = "0x10682E0", VA = "0x1810698E0")]
		protected void RegisterOpenShopCB()
		{
			//Discarded unreachable code: IL_0050
			SwitchNotifications instance = SwitchNotifications.Instance;
			SwitchNotifications.ApplicationFocusCB value = HandleBackFromNativeShopWithAppFocus;
			instance.OnApplicationFocus -= value;
			SwitchNotifications instance2 = SwitchNotifications.Instance;
			SwitchNotifications.ApplicationFocusCB b = HandleBackFromNativeShopWithAppFocus;
			SwitchNotifications.ApplicationFocusCB onApplicationFocus = instance2.OnApplicationFocus;
			Delegate @delegate = Delegate.Combine(onApplicationFocus, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onApplicationFocus)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E20")]
		[Cpp2IlInjected.Address(RVA = "0x10691D0", Offset = "0x1067BD0", VA = "0x1810691D0")]
		protected void HandleBackFromNativeShopWithAppFocus(bool isFocus)
		{
			//Discarded unreachable code: IL_0038
			if (isFocus)
			{
				BackFromNativeStoreResult backFromNativeStoreResult = new BackFromNativeStoreResult();
				int status = 0;
				BackFromNativeStoreResult result = backFromNativeStoreResult.WithStatus((BackFromNativeStoreResult.BuyStatus)status);
				HandleBackFromNativeShopResult(result);
				SwitchNotifications instance = SwitchNotifications.Instance;
				SwitchNotifications.ApplicationFocusCB value = HandleBackFromNativeShopWithAppFocus;
				instance.OnApplicationFocus -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E21")]
		[Cpp2IlInjected.Address(RVA = "0x1069780", Offset = "0x1068180", VA = "0x181069780", Slot = "4")]
		[AsyncStateMachine(typeof(_003CRefreshCatalogAsync_003Ed__20))]
		public override Task<InitializeShop.Result> RefreshCatalogAsync(InitializeShop.Request request, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<InitializeShop.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E22")]
		[Cpp2IlInjected.Address(RVA = "0x1069410", Offset = "0x1067E10", VA = "0x181069410", Slot = "7")]
		public override Task<OpenShopToBuyItem.Result> OpenShopToBuyItemAsync(OpenShopToBuyItem.Request request, CancellationToken ct)
		{
			//Discarded unreachable code: IL_00bc
			//IL_0017: Expected O, but got I4
			OpenShopToBuyItem.Result result = new OpenShopToBuyItem.Result();
			int num = 0;
			SwitchUserAccount instance = SwitchUserAccount.Instance;
			int num2 = 0;
			if (!(instance == (UnityEngine.Object)num2) && (long)instance.nsaTokenBuffer > 0)
			{
				NativeShopItemBase itemToBuy = request.ItemToBuy;
				if (itemToBuy != null)
				{
					int num3 = 0;
					if (itemToBuy != null && itemToBuy.IsValid)
					{
						SwitchNotifications instance2 = SwitchNotifications.Instance;
						SwitchNotifications.ApplicationFocusCB value = HandleBackFromNativeShopWithAppFocus;
						instance2.OnApplicationFocus -= value;
						SwitchNotifications instance3 = SwitchNotifications.Instance;
						SwitchNotifications.ApplicationFocusCB b = HandleBackFromNativeShopWithAppFocus;
						SwitchNotifications.ApplicationFocusCB onApplicationFocus = instance3.OnApplicationFocus;
						Delegate @delegate = Delegate.Combine(onApplicationFocus, b);
						if ((object)@delegate != null && (object)@delegate == null)
						{
							throw new InvalidCastException();
						}
						while ((object)@delegate != onApplicationFocus)
						{
						}
						Debug.Log("SwitchNativeShopManager.OpenShopToBuyItemAsync has to be called on a devkit");
					}
				}
			}
			return (Task<OpenShopToBuyItem.Result>)(object)Task.FromResult(result.WithResult(OpenShopToBuyItem.ResultCode.NoNativeUserLogged));
		}

		[Cpp2IlInjected.Token(Token = "0x6000E23")]
		[Cpp2IlInjected.Address(RVA = "0x10692F0", Offset = "0x1067CF0", VA = "0x1810692F0")]
		[AsyncStateMachine(typeof(_003CInitializeShopImpl_003Ed__22))]
		private Task<InitStatus> InitializeShopImpl(InitializeShop.Request request, CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<InitStatus>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E24")]
		[Cpp2IlInjected.Address(RVA = "0x1069A60", Offset = "0x1068460", VA = "0x181069A60")]
		private void SyncSwitchNativeItems()
		{
			//Discarded unreachable code: IL_0067
			((List<T>)(object)SwitchShopItems).Clear();
			NativeData.ConsumableItem[] consumableItems = ConsumableItems;
			if (consumableItems == null)
			{
				return;
			}
			int num = 0;
			int num2 = 0;
			int length = consumableItems.Length;
			if (num2 < length)
			{
				int num3 = 0;
				NativeData.ConsumableItem consumableItem = consumableItems[num];
				int itemCount = consumableItem.ItemCount;
				if (num3 < itemCount)
				{
					List<SwitchNativeShopItem> switchShopItems = SwitchShopItems;
					SwitchNativeShopItem item = new SwitchNativeShopItem(consumableItem, num3);
					((List<T>)(object)switchShopItems).Add((T)item);
					num3++;
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E25")]
		[Cpp2IlInjected.Address(RVA = "0x10691B0", Offset = "0x1067BB0", VA = "0x1810691B0", Slot = "8")]
		public override void DebugTraceDetailedInformation()
		{
			DebugTraceConsumableGroups();
			DebugTraceConsumableItems();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E26")]
		[Cpp2IlInjected.Address(RVA = "0x1068840", Offset = "0x1067240", VA = "0x181068840")]
		public void DebugTraceConsumableGroups()
		{
			//IL_004d: Expected O, but got I4
			//IL_008d: Expected O, but got I4
			StringBuilder stringBuilder;
			object[] array;
			int num4 = default(int);
			string disclaimer;
			int num3;
			while (true)
			{
				stringBuilder = new StringBuilder();
				int num2 = (stringBuilder.Length = 0);
				if ((long)ConsumableItems == 0)
				{
					StringBuilder stringBuilder2 = stringBuilder.Append("DebugTraceConsumableGroups ConsumableGroups is null");
					string text = stringBuilder.ToString();
					return;
				}
				int length = ConsumableGroups.consumables.Length;
				StringBuilder stringBuilder3 = stringBuilder.AppendFormat("SwitchNativeShopManager.DebugTraceConsumableGroups Count = {0} :", length);
				NativeData.Consumable consumableGroups = ConsumableGroups;
				num3 = 0;
				NativeData.Consumable.Item[] consumables = consumableGroups.consumables;
				while (num3 >= consumables.Length)
				{
				}
				array = new object[4];
				if (num4 != 0 && num4 == 0)
				{
					continue;
				}
				array[0] = num4;
				NativeData.Consumable.Item[] consumables2 = ConsumableGroups.consumables;
				string name = consumables2[num3].name;
				if (name != null && consumables2 == null)
				{
					continue;
				}
				array[1] = name;
				NativeData.Consumable.Item[] consumables3 = ConsumableGroups.consumables;
				string description = consumables3[num3].description;
				if (description == null || consumables3 != null)
				{
					array[2] = description;
					NativeData.Consumable.Item[] consumables4 = ConsumableGroups.consumables;
					disclaimer = consumables4[num3].disclaimer;
					if (disclaimer == null || consumables4 != null)
					{
						break;
					}
				}
			}
			array[3] = disclaimer;
			StringBuilder stringBuilder4 = stringBuilder.AppendFormat("\n{0}\n\tname: {1}\n\tdescription: {2}\n\tdisclaimer: {3}", array);
			NativeData.Consumable consumableGroups2 = ConsumableGroups;
			num3++;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E27")]
		[Cpp2IlInjected.Address(RVA = "0x1068C60", Offset = "0x1067660", VA = "0x181068C60")]
		public void DebugTraceConsumableItems()
		{
			//Discarded unreachable code: IL_0180, IL_0193, IL_019d, IL_01a5, IL_01ab
			//IL_00a8: Expected O, but got I4
			//IL_012c: Expected O, but got I8
			int num7 = default(int);
			int num5;
			while (true)
			{
				StringBuilder stringBuilder = new StringBuilder();
				int num2 = (stringBuilder.Length = 0);
				int num3 = 0;
				if ((IntPtr)ConsumableItems == (IntPtr)num3)
				{
					StringBuilder stringBuilder2 = stringBuilder.Append("DebugTraceConsumableItems ConsumableItems is null");
					string text = stringBuilder.ToString();
					return;
				}
				StringBuilder stringBuilder3 = stringBuilder.Append("SwitchNativeShopManager.DebugTraceConsumableItems");
				NativeData.ConsumableItem[] consumableItems = ConsumableItems;
				int num4 = 0;
				num5 = 0;
				int length = consumableItems.Length;
				while (num4 >= length)
				{
				}
				int num6 = 0;
				NativeData.ConsumableItem consumableItem = consumableItems[num5];
				int itemCount = consumableItem.ItemCount;
				if (num6 >= itemCount)
				{
					break;
				}
				NativeData.ConsumableItem.Item item = consumableItem.consumable_items[num6];
				object[] array = new object[8];
				if (num7 != 0 && num7 == 0)
				{
					continue;
				}
				array[0] = num7;
				string consumable_id = consumableItem.consumable_id;
				if (consumable_id != null && num7 == 0)
				{
					continue;
				}
				array[1] = consumable_id;
				string name = item.name;
				if (name != null && num7 == 0)
				{
					continue;
				}
				array[2] = name;
				string item_id = item.item_id;
				if (item_id != null && num7 == 0)
				{
					continue;
				}
				array[3] = item_id;
				ulong ns_uid = item.ns_uid;
				if (ns_uid != 0 && ns_uid == 0)
				{
					continue;
				}
				array[4] = ns_uid;
				string sales_status = item.price.sales_status;
				if (sales_status == null || ns_uid != 0)
				{
					array[5] = sales_status;
					NativeData.ConsumableItem.RegularPrice regular_price = item.price.regular_price;
					if (regular_price == null || regular_price.formatted_value == null || ns_uid != 0)
					{
						throw new IndexOutOfRangeException();
					}
				}
			}
			num5++;
			throw new NullReferenceException();
		}
	}
}
