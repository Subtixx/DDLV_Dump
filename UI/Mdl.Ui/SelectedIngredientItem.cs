using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003BE")]
	[RequiredAllNotNull]
	public class SelectedIngredientItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20003BF")]
		public delegate void OnRemoveDelegate(SelectedIngredientItem item, bool animate = true);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001256")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001257")]
		[SerializeField]
		private Button _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001258")]
		[SerializeField]
		private AsyncAtlassedIcon _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001259")]
		[SerializeField]
		public SpriteAtlasImage FilledBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400125A")]
		public Item Item = Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400125B")]
		public OnRemoveDelegate OnRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400125C")]
		public UnityEvent OnRefreshDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400125D")]
		[SerializeField]
		private AK.Wwise.Event _removeIngredientSfx;

		[Cpp2IlInjected.Token(Token = "0x170003FB")]
		public RectTransform Content
		{
			[Cpp2IlInjected.Token(Token = "0x60017CB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _content;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FC")]
		public Button BtnClose
		{
			[Cpp2IlInjected.Token(Token = "0x60017CC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _btnClose;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017CD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void Awake()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60017CE")]
		[Cpp2IlInjected.Address(RVA = "0x125D240", Offset = "0x125BC40", VA = "0x18125D240")]
		private void Start()
		{
			//Discarded unreachable code: IL_003b
			Transform transform = _btnClose.transform;
			int num = 0;
			Vector2 zero = Vector2.zero;
			int num2 = 0;
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnRemoveClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x60017CF")]
		[Cpp2IlInjected.Address(RVA = "0x125D110", Offset = "0x125BB10", VA = "0x18125D110")]
		internal void OnRemoveClickHandler()
		{
			AK.Wwise.Event removeIngredientSfx = _removeIngredientSfx;
			if (removeIngredientSfx != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = removeIngredientSfx.Post(gameObject);
			}
			OnRemove?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60017D0")]
		[Cpp2IlInjected.Address(RVA = "0x125CE20", Offset = "0x125B820", VA = "0x18125CE20")]
		public void Init(Item item, bool isSignature = false)
		{
			//Discarded unreachable code: IL_00b7
			//IL_0015: Expected O, but got I4
			//IL_0021: Expected I4, but got I8
			int itemID = item.ItemID;
			SpriteAtlasImage filledBg = FilledBg;
			Item = (Item)itemID;
			ulong num = default(ulong);
			filledBg.gameObject.SetActive((byte)num != 0);
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item2 = Item;
			IItemData itemData = _003CInstance_003Ek__BackingField.GetItemData<IItemData>(item2);
			AsyncAtlassedIcon mcIcon = _mcIcon;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			Transform transform = _btnClose.transform;
			int num4 = 0;
			Vector2 zero = Vector2.zero;
			GameObject gameObject = _btnClose.gameObject;
			int num5 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool active = !instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			gameObject.SetActive(active);
			Transform transform2 = _btnClose.transform;
			int num6 = 0;
			Vector2 one = Vector2.one;
		}

		[Cpp2IlInjected.Token(Token = "0x60017D1")]
		[Cpp2IlInjected.Address(RVA = "0x125D160", Offset = "0x125BB60", VA = "0x18125D160")]
		public void Refresh()
		{
			//Discarded unreachable code: IL_0047
			bool flag = default(bool);
			if (!flag)
			{
				GameObject gameObject = FilledBg.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				GameObject gameObject2 = _btnClose.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
			}
			else
			{
				Item item = Item;
				int isSignature = 0;
				Init(item, (byte)isSignature != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017D2")]
		[Cpp2IlInjected.Address(RVA = "0x125D350", Offset = "0x125BD50", VA = "0x18125D350")]
		public SelectedIngredientItem()
		{
		}
	}
}
