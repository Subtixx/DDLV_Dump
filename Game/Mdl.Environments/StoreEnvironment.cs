using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Utils;
using Meta;
using NodeCanvas.DialogueTrees;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000686")]
	public class StoreEnvironment : Environment
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000687")]
		public class OwnerDialogue
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40026B7")]
			public DialogueTree DialogueTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40026B8")]
			public AssetReference SpecialShopMenu;

			[Cpp2IlInjected.Token(Token = "0x6001CFF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public OwnerDialogue()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40026B1")]
		private GameObject interiorVisual;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40026B2")]
		[SerializeField]
		[ItemID]
		private int _storeOwnerItemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40026B4")]
		[SerializeField]
		public OwnerDialogue OwnerDialogueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40026B5")]
		[SerializeField]
		private StoreConfig storeConfig;

		[Cpp2IlInjected.Token(Token = "0x17000409")]
		public Item StoreOwnerItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001CF0")]
			[Cpp2IlInjected.Address(RVA = "0xF64F00", Offset = "0xF63900", VA = "0x180F64F00")]
			get
			{
				long num = Convert.ToInt64((uint)_storeOwnerItemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040A")]
		public Mdl.Characters.Character StoreOwner
		{
			[Cpp2IlInjected.Token(Token = "0x6001CF1")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			[CompilerGenerated]
			get
			{
				return _003CStoreOwner_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CF2")]
			[Cpp2IlInjected.Address(RVA = "0xAE8630", Offset = "0xAE7030", VA = "0x180AE8630")]
			[CompilerGenerated]
			private set
			{
				_003CStoreOwner_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xA8"), Cpp2IlInjected.Token(Token = "0x40026B6")]
		public Item BuildingItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001CF3")]
			[Cpp2IlInjected.Address(RVA = "0x9D1840", Offset = "0x9D0240", VA = "0x1809D1840")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001CF4")]
			[Cpp2IlInjected.Address(RVA = "0xF64F60", Offset = "0xF63960", VA = "0x180F64F60")]
			private set;
		} = Item.Invalid;


		[Cpp2IlInjected.Token(Token = "0x1700040C")]
		public StoreConfig StoreConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6001CF5")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			get
			{
				return storeConfig;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CF6")]
		[Cpp2IlInjected.Address(RVA = "0xF64850", Offset = "0xF63250", VA = "0x180F64850", Slot = "5")]
		[AsyncStateMachine(typeof(_003CEnterEnvironment_003Ed__17))]
		internal override Task EnterEnvironment(Profile profile, GridCollection gridCollection, BaseEnvironmentDoor door, PlayerAvatar avatar, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CF7")]
		[Cpp2IlInjected.Address(RVA = "0xF649C0", Offset = "0xF633C0", VA = "0x180F649C0", Slot = "7")]
		internal override Task ExitEnvironment(Profile profile, PlayerAvatar avatar, CancellationToken ct)
		{
			return base.ExitEnvironment(profile, avatar, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CF8")]
		[Cpp2IlInjected.Address(RVA = "0xF64B00", Offset = "0xF63500", VA = "0x180F64B00")]
		[AsyncStateMachine(typeof(_003CLoadInterior_003Ed__19))]
		private Task LoadInterior(Profile profile, BaseEnvironmentDoor door, PlayerAvatar avatar, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CF9")]
		[Cpp2IlInjected.Address(RVA = "0xF649D0", Offset = "0xF633D0", VA = "0x180F649D0")]
		[AsyncStateMachine(typeof(_003CInitStore_003Ed__20))]
		private Task InitStore(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CFA")]
		[Cpp2IlInjected.Address(RVA = "0xF64C50", Offset = "0xF63650", VA = "0x180F64C50")]
		[AsyncStateMachine(typeof(_003CRefreshStore_003Ed__21))]
		private Task<StoreRefresh.Types.Response> RefreshStore(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<StoreRefresh.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CFB")]
		[Cpp2IlInjected.Address(RVA = "0xF64D90", Offset = "0xF63790", VA = "0x180F64D90")]
		[AsyncStateMachine(typeof(_003CSetupOwner_003Ed__22))]
		private Task SetupOwner(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CFC")]
		[Cpp2IlInjected.Address(RVA = "0xF64100", Offset = "0xF62B00", VA = "0x180F64100")]
		private void DebugShowLog(StoreInfo store)
		{
			//Discarded unreachable code: IL_0125, IL_012b, IL_0131, IL_0137, IL_013d
			//IL_0093: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			//IL_00dd: Expected O, but got I4
			//IL_0102: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			string[] array;
			IItemData itemData = default(IItemData);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			string text4;
			int num8 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				RepeatedField<StoreInfo.Types.StoreDisplay> displays_ = store.displays_;
				if (flag && flag2)
				{
					num3++;
					int num4 = 0;
					Item hardCurrencyItem = CurrencyItem.HardCurrencyItem;
					num3++;
					num3++;
					num3++;
				}
				array = new string[7];
				if ("StoreInfo[" != null && "StoreInfo[" == null)
				{
					continue;
				}
				array[0] = "StoreInfo[";
				if (itemData != null && itemData == null)
				{
					continue;
				}
				array[1] = (string)(object)itemData;
				if ("] => " != null && "] => " == null)
				{
					continue;
				}
				array[2] = "] => ";
				string text = $"Items({num5}), ";
				if (text != null && text == null)
				{
					continue;
				}
				array[3] = text;
				string text2 = $"HCItems({num6}), ";
				if (text2 != null && text2 == null)
				{
					continue;
				}
				array[4] = text2;
				string text3 = $"NonHCItems({num7}), ";
				if (text3 == null || text3 != null)
				{
					array[5] = text3;
					text4 = $"Unavailable({num8}).";
					if (text4 == null || text4 != null)
					{
						break;
					}
				}
			}
			array[6] = text4;
			string text5 = string.Concat(array);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CFD")]
		[Cpp2IlInjected.Address(RVA = "0xF64E90", Offset = "0xF63890", VA = "0x180F64E90")]
		public StoreEnvironment()
		{
		}
	}
}
