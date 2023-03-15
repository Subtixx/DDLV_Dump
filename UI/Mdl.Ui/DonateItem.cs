using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Navigation;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004DE")]
	public class DonateItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20004DF")]
		public delegate void ItemPurchased();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40019C0")]
		public IItemData ItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40019C1")]
		[SerializeField]
		private AsyncAtlassedIcon _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40019C2")]
		[SerializeField]
		private Button _btnInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40019C3")]
		[SerializeField]
		private Button _btnPurchase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40019C4")]
		[SerializeField]
		private StarComponent _mcStar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40019C5")]
		[SerializeField]
		private RectTransform _mcPriceContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40019C6")]
		[SerializeField]
		private CurrencyItemView _mcPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40019C7")]
		[SerializeField]
		private RectTransform _mcOwnedIcon;

		[Cpp2IlInjected.Token(Token = "0x1700050F")]
		public CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x6001FC2")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CCancellationToken_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001FC3")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E60", Offset = "0x8E7860", VA = "0x1808E8E60")]
			[CompilerGenerated]
			set
			{
				_003CCancellationToken_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003B")]
		public event ItemPurchased OnItemPurchased
		{
			[Cpp2IlInjected.Token(Token = "0x6001FC0")]
			[Cpp2IlInjected.Address(RVA = "0xF17B30", Offset = "0xF16530", VA = "0x180F17B30")]
			[CompilerGenerated]
			add
			{
				ItemPurchased onItemPurchased = this.OnItemPurchased;
				Delegate @delegate = Delegate.Combine(onItemPurchased, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemPurchased)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001FC1")]
			[Cpp2IlInjected.Address(RVA = "0xF17BD0", Offset = "0xF165D0", VA = "0x180F17BD0")]
			[CompilerGenerated]
			remove
			{
				ItemPurchased onItemPurchased = this.OnItemPurchased;
				Delegate @delegate = Delegate.Remove(onItemPurchased, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemPurchased)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC4")]
		[Cpp2IlInjected.Address(RVA = "0xF17A40", Offset = "0xF16440", VA = "0x180F17A40")]
		private void Start()
		{
			//Discarded unreachable code: IL_0041
			Button.ButtonClickedEvent onClick = _btnInfo.m_OnClick;
			UnityAction call = OnInfoClickHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnPurchase.m_OnClick;
			UnityAction call2 = OnPurchaseClickHandler;
			onClick2.AddListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC5")]
		[Cpp2IlInjected.Address(RVA = "0xF17110", Offset = "0xF15B10", VA = "0x180F17110")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0041
			Button.ButtonClickedEvent onClick = _btnInfo.m_OnClick;
			UnityAction call = OnInfoClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnPurchase.m_OnClick;
			UnityAction call2 = OnPurchaseClickHandler;
			onClick2.RemoveListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC6")]
		[Cpp2IlInjected.Address(RVA = "0xF176B0", Offset = "0xF160B0", VA = "0x180F176B0")]
		public void RefreshDisplay(IItemData itemData)
		{
			//Discarded unreachable code: IL_0030
			ItemData = itemData;
			AsyncAtlassedIcon mcIcon = _mcIcon;
			bool flag = default(bool);
			if (flag)
			{
				StarComponent mcStar = _mcStar;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				mcStar.Star = (flag ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC7")]
		[Cpp2IlInjected.Address(RVA = "0xF17200", Offset = "0xF15C00", VA = "0x180F17200")]
		private void OnInfoClickHandler()
		{
			//Discarded unreachable code: IL_0040
			//IL_001c: Expected O, but got I4
			//IL_003f: Expected I4, but got I8
			//IL_003f: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			int num = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int isRedirectedFromCatalog = default(int);
			int num2 = default(int);
			ItemInfoPopUp.ItemInfoPopupParam menuParam = new ItemInfoPopUp.ItemInfoPopupParam(ItemData, (ItemState)num2, (byte)isRedirectedFromCatalog != 0);
			int num3 = 0;
			isRedirectedFromCatalog = 0;
			num2 = 0;
			int num4 = 0;
			ulong num5 = default(ulong);
			redirection.Redirect(RedirectionType.MenuItemInfo, menuParam, (PlayerTaskCollider)num4, (ItemFilterData)num3, (string)num3, (Action)num3, (byte)num3 != 0, (byte)num3 != 0, (byte)num3 != 0, (byte)num5 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC8")]
		[Cpp2IlInjected.Address(RVA = "0xF173C0", Offset = "0xF15DC0", VA = "0x180F173C0")]
		private void OnPurchaseClickHandler()
		{
			if ((long)ItemData != 0)
			{
				int num = 0;
				VibrationsManager.TriggerSelection();
				CancellationToken cancellationToken = CancellationToken;
				int num2 = 0;
				int num3 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FC9")]
		[Cpp2IlInjected.Address(RVA = "0xF17580", Offset = "0xF15F80", VA = "0x180F17580")]
		[AsyncStateMachine(typeof(_003CPurchaseTask_003Ed__21))]
		private Task PurchaseTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FCA")]
		[Cpp2IlInjected.Address(RVA = "0xF17550", Offset = "0xF15F50", VA = "0x180F17550")]
		private void OnPurchaseSuccessfulHandler(bool purchaseSucceed)
		{
			if (purchaseSucceed)
			{
				RefreshPurchase(isOwned: true);
				this.OnItemPurchased?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FCB")]
		[Cpp2IlInjected.Address(RVA = "0xF172E0", Offset = "0xF15CE0", VA = "0x180F172E0")]
		public void OnItemInfoClicked()
		{
			//Discarded unreachable code: IL_0040
			//IL_001c: Expected O, but got I4
			//IL_003f: Expected I4, but got I8
			//IL_003f: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			int num = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int isRedirectedFromCatalog = default(int);
			int num2 = default(int);
			ItemInfoPopUp.ItemInfoPopupParam menuParam = new ItemInfoPopUp.ItemInfoPopupParam(ItemData, (ItemState)num2, (byte)isRedirectedFromCatalog != 0);
			int num3 = 0;
			isRedirectedFromCatalog = 0;
			num2 = 0;
			int num4 = 0;
			ulong num5 = default(ulong);
			redirection.Redirect(RedirectionType.MenuItemInfo, menuParam, (PlayerTaskCollider)num4, (ItemFilterData)num3, (string)num3, (Action)num3, (byte)num3 != 0, (byte)num3 != 0, (byte)num3 != 0, (byte)num5 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FCC")]
		[Cpp2IlInjected.Address(RVA = "0xF17810", Offset = "0xF16210", VA = "0x180F17810")]
		internal void RefreshPurchase(bool isOwned)
		{
			//Discarded unreachable code: IL_0045
			_mcOwnedIcon.gameObject.SetActive(isOwned);
			_btnPurchase.gameObject.SetActive(isOwned);
			IItemData itemData = ItemData;
			bool flag = default(bool);
			if (flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				IItemData currencyItemData = default(IItemData);
				string amount = default(string);
				_mcPrice.RefreshData(currencyItemData, amount, forceLayoutUpdate: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FCD")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DonateItem()
		{
		}
	}
}
