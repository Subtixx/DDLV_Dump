using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200075D")]
	[RequiredAllNotNull]
	public class PetsContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B1E")]
		[SerializeField]
		private LoopVerticalScrollRect _listPetsItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002B1F")]
		private RepeatedField<Pet> _allPets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002B20")]
		[Tooltip("List of new pets that just got unlocked.")]
		public RepeatedField<Pet> FilteredNewPets = (RepeatedField<Pet>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002B21")]
		private List<Pet> _currentPets = (List<Pet>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002B22")]
		public CancellationToken CancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002B23")]
		private bool _constructed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002B24")]
		private IItemData _lastSelected;

		[Cpp2IlInjected.Token(Token = "0x170006B7")]
		public RepeatedField<Pet> AllPets
		{
			[Cpp2IlInjected.Token(Token = "0x6002F26")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _allPets;
			}
			[Cpp2IlInjected.Token(Token = "0x6002F27")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			set
			{
				_allPets = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006B8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x50"), Cpp2IlInjected.Token(Token = "0x4002B25")]
		public int PetBeforeChange
		{
			[Cpp2IlInjected.Token(Token = "0x6002F28")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002F29")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F2A")]
		[Cpp2IlInjected.Address(RVA = "0x9B6380", Offset = "0x9B4D80", VA = "0x1809B6380")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0041
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listPetsItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnPetsItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listPetsItems).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnPetsItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F2B")]
		[Cpp2IlInjected.Address(RVA = "0x9B6210", Offset = "0x9B4C10", VA = "0x1809B6210")]
		private void OnAssignClickHandler()
		{
			CancellationToken cancellationToken = CancellationToken;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F2C")]
		[Cpp2IlInjected.Address(RVA = "0x9B5BA0", Offset = "0x9B45A0", VA = "0x1809B5BA0")]
		[AsyncStateMachine(typeof(_003CChangePetTask_003Ed__16))]
		private Task ChangePetTask(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F2D")]
		[Cpp2IlInjected.Address(RVA = "0x9B6760", Offset = "0x9B5160", VA = "0x1809B6760")]
		private void RefreshCurrentSelected()
		{
			//Discarded unreachable code: IL_0051, IL_0057, IL_0069
			//IL_002c: Expected O, but got I4
			PetItem petItem = default(PetItem);
			IItemData _003CItemData_003Ek__BackingField = default(IItemData);
			while (true)
			{
				IEnumerator enumerator = ((LoopScrollRect)_listPetsItems).m_Content.GetEnumerator();
				if (enumerator != null)
				{
					int num = 0;
					if (enumerator == null)
					{
						break;
					}
					int num2 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					int num3 = 0;
					if (!(petItem != (UnityEngine.Object)num3))
					{
						continue;
					}
					_003CItemData_003Ek__BackingField = petItem.ItemData;
					bool flag2 = (petItem.IsSelected = _003CItemData_003Ek__BackingField == _lastSelected);
				}
				if (_003CItemData_003Ek__BackingField == null)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002F2E")]
		[Cpp2IlInjected.Address(RVA = "0x9B6980", Offset = "0x9B5380", VA = "0x1809B6980")]
		public void RefreshDisplay(HashSet<Filter> filters, bool showNewPetsOnly = false)
		{
			//Discarded unreachable code: IL_0067
			if (!_constructed)
			{
				Construct();
			}
			if (showNewPetsOnly)
			{
			}
			RepeatedField<Pet> allPets = _allPets;
			int num = 0;
			List<Pet> list = (_currentPets = (List<Pet>)(object)Enumerable.ToList<Pet>((IEnumerable<>)FilterUtil.Filter<Pet>((IEnumerable<>)(object)allPets, (IEnumerable<>)filters, FilterUtil.FilterCombineMode.Intersection, (FilterUtil.FilterCombineMode)num)));
			List<Pet> currentPets = _currentPets;
			LoopVerticalScrollRect listPetsItems = _listPetsItems;
			int num2 = (listPetsItems.totalCount = ((List<>)(object)currentPets)._size);
			LoopVerticalScrollRect listPetsItems2 = _listPetsItems;
			int offset = 0;
			listPetsItems2.RefillCells(offset);
		}

		[Cpp2IlInjected.Token(Token = "0x6002F2F")]
		[Cpp2IlInjected.Address(RVA = "0x9B5CD0", Offset = "0x9B46D0", VA = "0x1809B5CD0")]
		private void Construct()
		{
			//Discarded unreachable code: IL_00e2
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listPetsItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnPetsItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listPetsItems).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnPetsItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction2);
			RepeatedField<Pet> repeatedField = (_allPets = SystemRoot.Instance.MetaClient.profile.player_.pets_);
			int currentPetId = SystemRoot.Instance.MetaClient.profile.player_.currentPet_;
			RepeatedField<Pet> allPets = _allPets;
			Func<Pet, bool> func = (Func<Pet, bool>)(object)(Func<T, TResult>)delegate(Pet x)
			{
				//Discarded unreachable code: IL_0011
				int num = currentPetId;
				return x.petItemID_ == num;
			};
			Pet pet = Enumerable.FirstOrDefault<Pet>((IEnumerable<>)(object)allPets, (Func<, >)(object)func);
			if (pet != null)
			{
				Item petItem = pet.PetItem;
				bool flag = default(bool);
				if (flag)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					Item petItem2 = pet.PetItem;
					IItemData lastSelected = default(IItemData);
					_lastSelected = lastSelected;
				}
			}
			_constructed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F30")]
		[Cpp2IlInjected.Address(RVA = "0x9B64A0", Offset = "0x9B4EA0", VA = "0x1809B64A0")]
		private void OnPetsItemDataHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_0080
			//IL_0015: Expected O, but got I4
			PetItem component = args.DisplayObject.GetComponent<PetItem>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				int itemIndex = args.ItemIndex;
				Pet pet = Enumerable.ElementAt<Pet>((IEnumerable<>)_currentPets, itemIndex);
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item petItem = pet.PetItem;
				IItemData itemData = default(IItemData);
				component.ItemData = itemData;
				GameObject mc_selectedBackground = component.mc_selectedBackground;
				bool flag = (component._isSelected = itemData == _lastSelected);
				GameObject gameObject = mc_selectedBackground.gameObject;
				bool isSelected = component._isSelected;
				gameObject.SetActive(isSelected);
				component.RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F31")]
		[Cpp2IlInjected.Address(RVA = "0x9B6690", Offset = "0x9B5090", VA = "0x1809B6690")]
		private void OnPetsItemTapHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_0038
			//IL_0015: Expected O, but got I4
			PetItem component = args.DisplayObject.GetComponent<PetItem>();
			int num = 0;
			bool flag = component == (UnityEngine.Object)num;
			if (!flag)
			{
				if (component._isSelected == flag)
				{
					IItemData itemData = (_lastSelected = component.ItemData);
				}
				OnAssignClickHandler();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F32")]
		[Cpp2IlInjected.Address(RVA = "0x9B6130", Offset = "0x9B4B30", VA = "0x1809B6130")]
		public bool IsPetChanged()
		{
			//Discarded unreachable code: IL_0029
			int num = PetBeforeChange;
			ProfilePlayer player_ = SystemRoot.Instance.MetaClient.profile.player_;
			return num != player_.currentPet_;
		}

		[Cpp2IlInjected.Token(Token = "0x6002F33")]
		[Cpp2IlInjected.Address(RVA = "0x9B6A70", Offset = "0x9B5470", VA = "0x1809B6A70")]
		internal void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_0042
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(focusNavigation == (UnityEngine.Object)num) && ((LoopScrollRect)_listPetsItems).m_Content.childCount > 0)
			{
				RectTransform content = ((LoopScrollRect)_listPetsItems).m_Content;
				int index = 0;
				FocusNavigationElement component = content.GetChild(index).GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002F34")]
		[Cpp2IlInjected.Address(RVA = "0x9B6B50", Offset = "0x9B5550", VA = "0x1809B6B50")]
		public PetsContent()
		{
		}
	}
}
