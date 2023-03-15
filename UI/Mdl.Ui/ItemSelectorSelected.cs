using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Navigation;
using Mdl.Online;
using Mdl.Systems;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007C5")]
	public class ItemSelectorSelected : InfoGizmo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002D9F")]
		[SerializeField]
		private ItemSelectorItem _itemSelectorItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002DA0")]
		[SerializeField]
		private InteractionInfoGroup _interactionInfoGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002DA1")]
		[SerializeField]
		[Header("Position")]
		private RectTransform _rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002DA2")]
		[SerializeField]
		private float _minYRatio = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002DA3")]
		[SerializeField]
		[Header("Animation config")]
		private BubbleAnimation _bubbleAnim;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002DA4")]
		[SerializeField]
		private float _amountRefreshRate = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002DA5")]
		[SerializeField]
		[Header("SFX")]
		private AK.Wwise.Event _openGizmoSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002DA6")]
		[SerializeField]
		private AK.Wwise.Event _closeGizmoSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002DA7")]
		[HideInInspector]
		public Item ItemSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002DA8")]
		[HideInInspector]
		public InteractPreviewData InteractData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002DA9")]
		private IEnumerable<ProfileWorld.FilterInfo> _quests;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002DAA")]
		private ItemInstance _itemInstance;

		[Cpp2IlInjected.Token(Token = "0x600319E")]
		[Cpp2IlInjected.Address(RVA = "0x1321E30", Offset = "0x1320830", VA = "0x181321E30", Slot = "11")]
		public override void Init(GameObject target, bool followTarget = false, [Optional] CancellationToken? ct, params object[] parameters)
		{
			//IL_005e: Expected O, but got I4
			int num = 0;
			if ((object)this != null)
			{
				ItemSelectorSelected itemSelected = default(ItemSelectorSelected);
				ItemSelected = (Item)itemSelected;
				if ((object)typeof(Item).TypeHandle == null)
				{
				}
				int num2 = 0;
				if ((object)typeof(Item).TypeHandle == null)
				{
					throw new InvalidCastException();
				}
				InteractData = (InteractPreviewData)typeof(Item).TypeHandle;
				Client client = default(Client);
				IEnumerable<ProfileWorld.FilterInfo> enumerable = (_quests = (IEnumerable<ProfileWorld.FilterInfo>)client.Profile.world_.GetFiltersCropInfo());
				InitUI();
			}
			BubbleAnimation bubbleAnimation = base.bubbleAnimation;
			int num3 = 0;
			if (!(bubbleAnimation != (UnityEngine.Object)num3))
			{
				AK.Wwise.Event openGizmoSfx = _openGizmoSfx;
				GameObject gameObject = base.gameObject;
				uint num4 = openGizmoSfx.Post(gameObject);
				return;
			}
			Delegate @delegate = default(Delegate);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600319F")]
		[Cpp2IlInjected.Address(RVA = "0x13224E0", Offset = "0x1320EE0", VA = "0x1813224E0", Slot = "13")]
		protected override void Update()
		{
			//Discarded unreachable code: IL_003f
			base.Update();
			int pixelHeight = SystemRoot.Instance._playerCamera.pixelHeight;
			RectTransform rectTransform = _rectTransform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			RectTransform rectTransform2 = _rectTransform;
			RectTransform rectTransform3 = _rectTransform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60031A0")]
		[Cpp2IlInjected.Address(RVA = "0x1322320", Offset = "0x1320D20", VA = "0x181322320")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0065
			//IL_0049: Expected O, but got I4
			int _003C_003E1__state = default(int);
			_003CRefreshAmount_003Ed__16 _003CRefreshAmount_003Ed__ = new _003CRefreshAmount_003Ed__16(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRefreshAmount_003Ed__._003C_003E4__this = this;
			StopCoroutine(_003CRefreshAmount_003Ed__);
			Action source = onAnimationComplete;
			Action value = OnAnimationComplete;
			Delegate @delegate = Delegate.Remove(source, value);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				onAnimationComplete = (Action)num;
				AK.Wwise.Event closeGizmoSfx = _closeGizmoSfx;
				GameObject gameObject = base.gameObject;
				uint num2 = closeGizmoSfx.Post(gameObject);
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031A1")]
		[Cpp2IlInjected.Address(RVA = "0x1321AC0", Offset = "0x13204C0", VA = "0x181321AC0")]
		private void InitUI()
		{
			//Discarded unreachable code: IL_0104
			//IL_005a: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			ItemInstance itemInstance = (_itemInstance = new ItemInstance());
			ItemInstance itemInstance2 = _itemInstance;
			Item item = (itemInstance2.Item = ItemSelected);
			ItemInstance itemInstance3 = _itemInstance;
			ContainerInventory backpack = SystemRoot.Instance.MetaClient.profile.player_.Backpack;
			Item itemSelected2 = ItemSelected;
			int num = 0;
			int num2 = (itemInstance3.amount_ = backpack.GetItemAmount(itemSelected2, (ItemState)num));
			ItemSelectorItem itemSelectorItem = _itemSelectorItem;
			ItemSelectorItemInstance itemSelectorItemInstance = default(ItemSelectorItemInstance);
			ItemInstance itemInstance4 = (itemSelectorItemInstance._item = _itemInstance);
			ItemInstance item2 = itemSelectorItemInstance._item;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item3 = item2.Item;
			IItemData itemData = default(IItemData);
			itemSelectorItemInstance._itemData = itemData;
			IEnumerable<ProfileWorld.FilterInfo> quests = _quests;
			int num3 = 0;
			itemSelectorItem.Refresh((IItemSelectorItem)itemSelectorItemInstance, true, (Sprite)num3, (IEnumerable<>)quests);
			InteractPreviewData interactData = InteractData;
			InteractionInfoGroup interactionInfoGroup = _interactionInfoGroup;
			bool holdButton = interactData._holdButton;
			string text = interactData._text;
			interactionInfoGroup.Init(text, holdButton);
			int _003C_003E1__state = default(int);
			_003CRefreshAmount_003Ed__16 _003CRefreshAmount_003Ed__ = new _003CRefreshAmount_003Ed__16(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRefreshAmount_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CRefreshAmount_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x60031A2")]
		[Cpp2IlInjected.Address(RVA = "0x1322470", Offset = "0x1320E70", VA = "0x181322470")]
		[IteratorStateMachine(typeof(_003CRefreshAmount_003Ed__16))]
		public IEnumerator RefreshAmount()
		{
			int _003C_003E1__state = default(int);
			_003CRefreshAmount_003Ed__16 _003CRefreshAmount_003Ed__ = new _003CRefreshAmount_003Ed__16(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRefreshAmount_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031A3")]
		[Cpp2IlInjected.Address(RVA = "0x13222E0", Offset = "0x1320CE0", VA = "0x1813222E0")]
		private void OnAnimationComplete()
		{
			//Discarded unreachable code: IL_0017
			AK.Wwise.Event openGizmoSfx = _openGizmoSfx;
			GameObject gameObject = base.gameObject;
			uint num = openGizmoSfx.Post(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60031A4")]
		[Cpp2IlInjected.Address(RVA = "0x1322130", Offset = "0x1320B30", VA = "0x181322130")]
		private void KeepOnScreen()
		{
			//Discarded unreachable code: IL_0039
			int pixelHeight = SystemRoot.Instance._playerCamera.pixelHeight;
			RectTransform rectTransform = _rectTransform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			RectTransform rectTransform2 = _rectTransform;
			RectTransform rectTransform3 = _rectTransform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60031A5")]
		[Cpp2IlInjected.Address(RVA = "0x1322690", Offset = "0x1321090", VA = "0x181322690")]
		public ItemSelectorSelected()
		{
		}
	}
}
