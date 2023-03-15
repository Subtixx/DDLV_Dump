using System;
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
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000538")]
	[RequiredAllNotNull]
	public class HouseExpansionMainRoomContent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000539")]
		public delegate void OnRefreshRequestedDelegate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001C1E")]
		public OnRefreshRequestedDelegate OnRefreshRequested;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001C1F")]
		[SerializeField]
		private TextBase _tfLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001C20")]
		[SerializeField]
		private ButtonTmProIcon _btnExpand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001C21")]
		[SerializeField]
		private Button _btnEdit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001C22")]
		[SerializeField]
		private House.Types.RoomSlot _roomSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001C23")]
		[SerializeField]
		private SpriteAtlasImage _mcBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001C24")]
		[SerializeField]
		private AsyncMenu _managePopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001C25")]
		[SerializeField]
		[Nulllable]
		private HouseExpansionMenu _houseExpansionMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001C26")]
		[SerializeField]
		private RefreshBuyButton _refreshBuyButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001C27")]
		public CancellationToken CancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001C28")]
		private House.Types.Room _currentRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001C29")]
		private CurrencyCost _expandCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001C2A")]
		public int CurrentFloorIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001C2C")]
		public AK.Wwise.Event acceptSFX;

		[Cpp2IlInjected.Token(Token = "0x17000544")]
		internal ButtonTmProIcon ExpandButton
		{
			[Cpp2IlInjected.Token(Token = "0x60021E5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _btnExpand;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000545")]
		internal Button EditButton
		{
			[Cpp2IlInjected.Token(Token = "0x60021E6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _btnEdit;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000546")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x7C"), Cpp2IlInjected.Token(Token = "0x4001C2B")]
		public bool IsExpandable
		{
			[Cpp2IlInjected.Token(Token = "0x60021E7")]
			[Cpp2IlInjected.Address(RVA = "0x823F10", Offset = "0x822910", VA = "0x180823F10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60021E8")]
			[Cpp2IlInjected.Address(RVA = "0x8242B0", Offset = "0x822CB0", VA = "0x1808242B0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x60021E9")]
		[Cpp2IlInjected.Address(RVA = "0xAEFFC0", Offset = "0xAEE9C0", VA = "0x180AEFFC0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0046
			Button.ButtonClickedEvent onClick = _btnExpand.ButtonComponent.m_OnClick;
			UnityAction call = delegate
			{
				OnExpandClickHandler(withConfirmation: true);
			};
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnEdit.m_OnClick;
			UnityAction call2 = OnEditClickHandler;
			onClick2.AddListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x60021EA")]
		[Cpp2IlInjected.Address(RVA = "0xAEF750", Offset = "0xAEE150", VA = "0x180AEF750")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0036
			_btnExpand.ButtonComponent.m_OnClick.RemoveAllListeners();
			Button.ButtonClickedEvent onClick = _btnEdit.m_OnClick;
			UnityAction call = OnEditClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x60021EB")]
		[Cpp2IlInjected.Address(RVA = "0xAEFB50", Offset = "0xAEE550", VA = "0x180AEFB50")]
		internal void Refresh(House.Types.Room room, HouseExpansion.Types.InteriorExpansion.Types.ExpansionData next)
		{
			//Discarded unreachable code: IL_013e
			//IL_0012: Expected I4, but got O
			//IL_006b: Expected O, but got I4
			_currentRoom = room;
			if (next == null)
			{
				IsExpandable = (byte)(int)next != 0;
				Transform transform = base.transform;
				GameObject gameObject = _btnExpand.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				_btnEdit.gameObject.SetActive(value: true);
				_tfLabel.gameObject.SetActive(value: true);
				TextBase tfLabel = _tfLabel;
				string name_ = room.name_;
				int num = 0;
				string text2 = (tfLabel.Text = LocalizationManager.FromStringID(name_, (IResolver)num));
				return;
			}
			IsExpandable = true;
			Transform transform2 = base.transform;
			RepeatedField<CurrencyCost> price_ = next.price_;
			int index = 0;
			CurrencyCost currencyCost = (_expandCost = (CurrencyCost)((RepeatedField<T>)(object)price_)[index]);
			_btnExpand.gameObject.SetActive(value: true);
			GameObject gameObject2 = _btnEdit.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			TextBase label = _btnExpand.Label;
			CurrencyCost expandCost = _expandCost;
			string text3 = default(string);
			label.Text = text3;
			CurrencyCost expandCost2 = _expandCost;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = expandCost2.Item;
			AsyncAtlassedIcon currencyIcon = _btnExpand._currencyIcon;
			GameObject gameObject3 = _tfLabel.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			RefreshBuyButton refreshBuyButton = _refreshBuyButton;
			while ((object)refreshBuyButton == null)
			{
			}
			refreshBuyButton.RefreshBuy();
		}

		[Cpp2IlInjected.Token(Token = "0x60021EC")]
		[Cpp2IlInjected.Address(RVA = "0xAEFED0", Offset = "0xAEE8D0", VA = "0x180AEFED0")]
		internal void SetBackgroundImage(bool left, bool right, bool top)
		{
			//Discarded unreachable code: IL_003d
			string text = "";
			if (left)
			{
				text = "_left";
			}
			string text2 = text + "_right" + "_top";
			SpriteAtlasImage mcBackground = _mcBackground;
			string text4 = (mcBackground.ImageAddress = "img_room_main_door" + text2);
		}

		[Cpp2IlInjected.Token(Token = "0x60021ED")]
		[Cpp2IlInjected.Address(RVA = "0xAEFEB0", Offset = "0xAEE8B0", VA = "0x180AEFEB0")]
		internal void SetBackgroundImage(string image)
		{
			//Discarded unreachable code: IL_000d
			_mcBackground.ImageAddress = image;
		}

		[Cpp2IlInjected.Token(Token = "0x60021EE")]
		[Cpp2IlInjected.Address(RVA = "0xAEFB40", Offset = "0xAEE540", VA = "0x180AEFB40")]
		private void OnPurchaseSuccessfulHandler(bool purchaseSucceed)
		{
			if (purchaseSucceed)
			{
				int withConfirmation = 0;
				OnExpandClickHandler((byte)withConfirmation != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021EF")]
		[Cpp2IlInjected.Address(RVA = "0xAEF980", Offset = "0xAEE380", VA = "0x180AEF980")]
		private void OnExpandClickHandler(bool withConfirmation)
		{
			//Discarded unreachable code: IL_0026
			if (_btnExpand.gameObject.activeInHierarchy)
			{
				CancellationToken cancellationToken = CancellationToken;
				int num = 0;
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021F0")]
		[Cpp2IlInjected.Address(RVA = "0xAEF310", Offset = "0xAEDD10", VA = "0x180AEF310")]
		[AsyncStateMachine(typeof(_003CExpandRoomTask_003Ed__30))]
		private Task ExpandRoomTask(bool withConfirmation, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60021F1")]
		[Cpp2IlInjected.Address(RVA = "0xAEF810", Offset = "0xAEE210", VA = "0x180AEF810")]
		private void OnEditClickHandler()
		{
			CancellationToken cancellationToken = CancellationToken;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60021F2")]
		[Cpp2IlInjected.Address(RVA = "0xAEF630", Offset = "0xAEE030", VA = "0x180AEF630")]
		[AsyncStateMachine(typeof(_003CManageRoomTask_003Ed__32))]
		private Task ManageRoomTask(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60021F3")]
		[Cpp2IlInjected.Address(RVA = "0xAEF450", Offset = "0xAEDE50", VA = "0x180AEF450")]
		private Task<int> ManageRoomPopupTask(CancellationToken ct)
		{
			//Discarded unreachable code: IL_00af
			TaskCompletionSource<int> tcs = (TaskCompletionSource<int>)(object)new TaskCompletionSource<TResult>();
			ManageRoomPopup.ManageRoomParam manageRoomParam = new ManageRoomPopup.ManageRoomParam();
			House.Types.RoomSlot roomSlot = (manageRoomParam.Slot = _roomSlot);
			int num = (manageRoomParam.CurrentFloorIndex = CurrentFloorIndex);
			House.Types.Room room = (manageRoomParam.CurrentRoom = _currentRoom);
			Action<int> action = (manageRoomParam.AnswerAction = (Action<int>)(object)(Action<T>)delegate(int answer)
			{
				//Discarded unreachable code: IL_001f
				//IL_001d: Expected O, but got I4
				_houseExpansionMenu.UpdateBackShortcutIndicators(active: true);
				bool flag = ((TaskCompletionSource<TResult>)(object)tcs).TrySetResult((TResult)answer);
			});
			GameObject gameObject = _houseExpansionMenu._backShortcutIndicator.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			int num2 = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			AsyncMenu managePopup = _managePopup;
			popupStack.Push(managePopup, manageRoomParam);
			return (Task<int>)(object)((TaskCompletionSource<>)(object)tcs).m_task;
		}

		[Cpp2IlInjected.Token(Token = "0x60021F4")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public HouseExpansionMainRoomContent()
		{
		}
	}
}
