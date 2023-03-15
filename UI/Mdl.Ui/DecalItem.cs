using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.ImageRendering;
using Mdl.Navigation;
using Mdl.Utils;
using Meta.Customization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200034E")]
	[RequiredAllNotNull]
	public class DecalItem : BaseWardrobeItem
	{
		[Cpp2IlInjected.Token(Token = "0x200034F")]
		public delegate void DecalItemInteractDelegate(DecalItem itemData);

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000FA7")]
		[SerializeField]
		private Button _btnInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000FA8")]
		[SerializeField]
		private Button _btnDelete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000FA9")]
		[SerializeField]
		private Button _btnEdit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000FAA")]
		[SerializeField]
		private DesignIcon _mcDesignIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000FAB")]
		[SerializeField]
		private RectTransform _mcAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000FAD")]
		public IItemData ItemData;

		[Cpp2IlInjected.Token(Token = "0x17000399")]
		public Button BtnDelete
		{
			[Cpp2IlInjected.Token(Token = "0x60014E2")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			get
			{
				return _btnDelete;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039A")]
		public Button BtnEdit
		{
			[Cpp2IlInjected.Token(Token = "0x60014E3")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return _btnEdit;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xA0"), Cpp2IlInjected.Token(Token = "0x4000FAC")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60014E4")]
			[Cpp2IlInjected.Address(RVA = "0x975DB0", Offset = "0x9747B0", VA = "0x180975DB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60014E5")]
			[Cpp2IlInjected.Address(RVA = "0x976580", Offset = "0x974F80", VA = "0x180976580")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event DecalItemInteractDelegate OnItemDelete
		{
			[Cpp2IlInjected.Token(Token = "0x60014DE")]
			[Cpp2IlInjected.Address(RVA = "0x12AC1B0", Offset = "0x12AABB0", VA = "0x1812AC1B0")]
			[CompilerGenerated]
			add
			{
				DecalItemInteractDelegate onItemDelete = this.OnItemDelete;
				Delegate @delegate = Delegate.Combine(onItemDelete, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemDelete)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60014DF")]
			[Cpp2IlInjected.Address(RVA = "0x12AC2F0", Offset = "0x12AACF0", VA = "0x1812AC2F0")]
			[CompilerGenerated]
			remove
			{
				DecalItemInteractDelegate onItemDelete = this.OnItemDelete;
				Delegate @delegate = Delegate.Remove(onItemDelete, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemDelete)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event DecalItemInteractDelegate OnItemEdit
		{
			[Cpp2IlInjected.Token(Token = "0x60014E0")]
			[Cpp2IlInjected.Address(RVA = "0x12AC250", Offset = "0x12AAC50", VA = "0x1812AC250")]
			[CompilerGenerated]
			add
			{
				DecalItemInteractDelegate onItemEdit = this.OnItemEdit;
				Delegate @delegate = Delegate.Combine(onItemEdit, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemEdit)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60014E1")]
			[Cpp2IlInjected.Address(RVA = "0x12AC390", Offset = "0x12AAD90", VA = "0x1812AC390")]
			[CompilerGenerated]
			remove
			{
				DecalItemInteractDelegate onItemEdit = this.OnItemEdit;
				Delegate @delegate = Delegate.Remove(onItemEdit, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onItemEdit)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014E6")]
		[Cpp2IlInjected.Address(RVA = "0x12ABA10", Offset = "0x12AA410", VA = "0x1812ABA10")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0065
			Button.ButtonClickedEvent onClick = _btnInfo.m_OnClick;
			UnityAction call = OnInfoClickHandler;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnEdit.m_OnClick;
			UnityAction call2 = OnEditClickHandler;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnDelete.m_OnClick;
			UnityAction call3 = OnDeleteClickHandler;
			onClick3.AddListener(call3);
		}

		[Cpp2IlInjected.Token(Token = "0x60014E7")]
		[Cpp2IlInjected.Address(RVA = "0x12ABB80", Offset = "0x12AA580", VA = "0x1812ABB80")]
		private void OnDestroy()
		{
			//IL_006f: Expected O, but got I4
			//IL_0077: Expected O, but got I4
			Button.ButtonClickedEvent onClick = _btnInfo.m_OnClick;
			UnityAction call = OnInfoClickHandler;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnEdit.m_OnClick;
			UnityAction call2 = OnEditClickHandler;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnDelete.m_OnClick;
			UnityAction call3 = OnDeleteClickHandler;
			onClick3.RemoveListener(call3);
			int num = 0;
			this.OnItemDelete = (DecalItemInteractDelegate)num;
			this.OnItemEdit = (DecalItemInteractDelegate)num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60014E8")]
		[Cpp2IlInjected.Address(RVA = "0x12ABE00", Offset = "0x12AA800", VA = "0x1812ABE00")]
		internal void RefreshDisplay()
		{
			//Discarded unreachable code: IL_00e7
			if (ItemData != null && (object)typeof(IItemData).TypeHandle == null)
			{
				GameObject gameObject = _btnInfo.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				_btnEdit.gameObject.SetActive(value: true);
				bool active2 = default(bool);
				_btnDelete.gameObject.SetActive(active2);
				_mcDesignIcon.gameObject.SetActive(value: true);
				GameObject gameObject2 = _mcAdd.gameObject;
				int active3 = 0;
				gameObject2.SetActive((byte)active3 != 0);
			}
			else
			{
				GameObject gameObject3 = _btnInfo.gameObject;
				int active4 = 0;
				gameObject3.SetActive((byte)active4 != 0);
				GameObject gameObject4 = _btnEdit.gameObject;
				int active5 = 0;
				gameObject4.SetActive((byte)active5 != 0);
				GameObject gameObject5 = _btnDelete.gameObject;
				int active6 = 0;
				gameObject5.SetActive((byte)active6 != 0);
				GameObject gameObject6 = _mcDesignIcon.gameObject;
				int active7 = 0;
				gameObject6.SetActive((byte)active7 != 0);
				_mcAdd.gameObject.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014E9")]
		[Cpp2IlInjected.Address(RVA = "0x12ABB60", Offset = "0x12AA560", VA = "0x1812ABB60")]
		private void OnDeleteClickHandler()
		{
			this.OnItemDelete?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60014EA")]
		[Cpp2IlInjected.Address(RVA = "0x12ABD00", Offset = "0x12AA700", VA = "0x1812ABD00")]
		private void OnEditClickHandler()
		{
			this.OnItemEdit?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60014EB")]
		[Cpp2IlInjected.Address(RVA = "0x12ABD20", Offset = "0x12AA720", VA = "0x1812ABD20")]
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

		[Cpp2IlInjected.Token(Token = "0x60014EC")]
		[Cpp2IlInjected.Address(RVA = "0x12AC020", Offset = "0x12AAA20", VA = "0x1812AC020")]
		internal void UpdateDeleteBtnActive()
		{
			//Discarded unreachable code: IL_0012
			bool active = default(bool);
			_btnDelete.gameObject.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x60014ED")]
		[Cpp2IlInjected.Address(RVA = "0x12AC060", Offset = "0x12AAA60", VA = "0x1812AC060")]
		[AsyncStateMachine(typeof(_003CUpdateIcon_003Ed__28))]
		internal Task UpdateIcon(Design design, ClothingDesignsRenderer renderer)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60014EE")]
		[Cpp2IlInjected.Address(RVA = "0x88CCA0", Offset = "0x88B6A0", VA = "0x18088CCA0")]
		public DecalItem()
		{
		}
	}
}
