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
using Mdl.Avatar;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000788")]
	[RequiredAllNotNull]
	public class WardrobeMakeupContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002BD7")]
		private bool _constructed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002BD8")]
		[SerializeField]
		private LoopVerticalScrollRect _listMakeup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002BD9")]
		private bool _isMale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002BDA")]
		private List<MakeupItemData> _allItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002BDB")]
		private List<MakeupItemData> _ownedItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002BDC")]
		private List<MakeupItemData> _currentItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002BE0")]
		public bool showOwned;

		[Cpp2IlInjected.Token(Token = "0x170006CC")]
		public AvatarAppearance Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x600301F")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CAvatar_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003020")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			internal set
			{
				_003CAvatar_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006CD")]
		public Mdl.Avatar.AvatarCustomization AvatarCustomization
		{
			[Cpp2IlInjected.Token(Token = "0x6003021")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CAvatarCustomization_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003022")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			internal set
			{
				_003CAvatarCustomization_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006CE")]
		public CancellationToken CancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x6003023")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CCancellationToken_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003024")]
			[Cpp2IlInjected.Address(RVA = "0x14E5960", Offset = "0x14E4360", VA = "0x1814E5960")]
			[CompilerGenerated]
			internal set
			{
				_003CCancellationToken_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003025")]
		[Cpp2IlInjected.Address(RVA = "0x14E5810", Offset = "0x14E4210", VA = "0x1814E5810")]
		public void Show()
		{
			//Discarded unreachable code: IL_0067
			if (!_constructed)
			{
				LoopVerticalScrollRect listMakeup = _listMakeup;
				_constructed = true;
				LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)listMakeup).m_OnItemData;
				UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
				((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
				LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listMakeup).m_OnItemTap;
				UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemTapHandler);
				((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction2);
			}
			base.gameObject.SetActive(value: true);
			Populate();
		}

		[Cpp2IlInjected.Token(Token = "0x6003026")]
		[Cpp2IlInjected.Address(RVA = "0x14E4280", Offset = "0x14E2C80", VA = "0x1814E4280")]
		private void Construct()
		{
			//Discarded unreachable code: IL_004c
			LoopVerticalScrollRect listMakeup = _listMakeup;
			_constructed = true;
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)listMakeup).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listMakeup).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6003027")]
		[Cpp2IlInjected.Address(RVA = "0x9BB7F0", Offset = "0x9BA1F0", VA = "0x1809BB7F0")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0011
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003028")]
		[Cpp2IlInjected.Address(RVA = "0x14E4980", Offset = "0x14E3380", VA = "0x1814E4980")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0041
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listMakeup).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemTap = ((LoopScrollRect)_listMakeup).m_OnItemTap;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemTapHandler);
			((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6003029")]
		[Cpp2IlInjected.Address(RVA = "0x14E50B0", Offset = "0x14E3AB0", VA = "0x1814E50B0")]
		public void Populate()
		{
			//Discarded unreachable code: IL_010b
			//IL_000e: Expected I4, but got I8
			_listMakeup.totalCount = 0;
			LoopVerticalScrollRect listMakeup = _listMakeup;
			int offset = 0;
			listMakeup.RefillCells(offset);
			RectTransform content = ((LoopScrollRect)_listMakeup).m_Content;
			int num = 0;
			Vector2 vector = (content.anchoredPosition = Vector2.zero);
			bool flag = (_isMale = Avatar.IsMale);
			IEnumerable<> allByType = ItemDatabase.Instance.GetAllByType<MakeupItemData>(ItemType.Makeup);
			bool isMale = _isMale;
			List<MakeupItemData> list = (_allItems = (List<MakeupItemData>)(object)this.FilterGender(allByType, isMale));
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			ListInventory makeup = Avatar.CurrentProfile.Makeup;
			IEnumerable<MakeupItemData> ownedMakeup = (IEnumerable<MakeupItemData>)ItemDatabaseExtensions.GetOwnedMakeup(_003CInstance_003Ek__BackingField, makeup);
			bool isMale2 = _isMale;
			List<MakeupItemData> list2 = (_ownedItems = (List<MakeupItemData>)(object)this.FilterGender((IEnumerable<>)ownedMakeup, isMale2));
			if (!showOwned)
			{
			}
			List<MakeupItemData> list3 = (_currentItems = _ownedItems);
			List<MakeupItemData> currentItems = _currentItems;
			LoopVerticalScrollRect listMakeup2 = _listMakeup;
			int num2 = (listMakeup2.totalCount = ((List<>)(object)currentItems)._size);
			LoopVerticalScrollRect listMakeup3 = _listMakeup;
			int offset2 = 0;
			listMakeup3.RefillCells(offset2);
		}

		[Cpp2IlInjected.Token(Token = "0x600302A")]
		[Cpp2IlInjected.Address(RVA = "0x14E43A0", Offset = "0x14E2DA0", VA = "0x1814E43A0")]
		private List<MakeupItemData> FilterGender(IEnumerable<MakeupItemData> items, bool isMale)
		{
			if (!isMale)
			{
				if (_003C_003Ec._003C_003E9__24_1 != null)
				{
					goto IL_003c;
				}
				Func<MakeupItemData, bool> func = (Func<MakeupItemData, bool>)(object)(Func<T, TResult>)delegate(MakeupItemData m)
				{
					//Discarded unreachable code: IL_000c
					string femaleMakeupAddress_ = m.femaleMakeupAddress_;
					return m == null;
				};
			}
			Func<MakeupItemData, bool> func2 = default(Func<MakeupItemData, bool>);
			if (_003C_003Ec._003C_003E9__24_0 == null)
			{
				func2 = (Func<MakeupItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MakeupItemData m)
				{
					//Discarded unreachable code: IL_000c
					string maleMakeupAddress_ = m.maleMakeupAddress_;
					return m == null;
				});
			}
			goto IL_003c;
			IL_003c:
			return (List<MakeupItemData>)(object)Enumerable.ToList<MakeupItemData>(Enumerable.Where<MakeupItemData>((IEnumerable<>)items, (Func<, >)(object)func2));
		}

		[Cpp2IlInjected.Token(Token = "0x600302B")]
		[Cpp2IlInjected.Address(RVA = "0x14E4220", Offset = "0x14E2C20", VA = "0x1814E4220")]
		private void Clear()
		{
			//Discarded unreachable code: IL_003c
			//IL_000e: Expected I4, but got I8
			_listMakeup.totalCount = 0;
			LoopVerticalScrollRect listMakeup = _listMakeup;
			int offset = 0;
			listMakeup.RefillCells(offset);
			RectTransform content = ((LoopScrollRect)_listMakeup).m_Content;
			int num = 0;
			Vector2 vector = (content.anchoredPosition = Vector2.zero);
		}

		[Cpp2IlInjected.Token(Token = "0x600302C")]
		[Cpp2IlInjected.Address(RVA = "0x14E4590", Offset = "0x14E2F90", VA = "0x1814E4590")]
		private void FilterItems()
		{
			//Discarded unreachable code: IL_0048
			if (!showOwned)
			{
			}
			List<MakeupItemData> list = (_currentItems = _ownedItems);
			List<MakeupItemData> currentItems = _currentItems;
			LoopVerticalScrollRect listMakeup = _listMakeup;
			int num = (listMakeup.totalCount = ((List<>)(object)currentItems)._size);
			LoopVerticalScrollRect listMakeup2 = _listMakeup;
			int offset = 0;
			listMakeup2.RefillCells(offset);
		}

		[Cpp2IlInjected.Token(Token = "0x600302D")]
		[Cpp2IlInjected.Address(RVA = "0x14E4AA0", Offset = "0x14E34A0", VA = "0x1814E4AA0")]
		private void OnItemDataHandler(ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600302E")]
		[Cpp2IlInjected.Address(RVA = "0x14E4F30", Offset = "0x14E3930", VA = "0x1814E4F30")]
		private void OnPurchaseHandler(WardrobeMakeupItem item)
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600302F")]
		[Cpp2IlInjected.Address(RVA = "0x14E5340", Offset = "0x14E3D40", VA = "0x1814E5340")]
		[AsyncStateMachine(typeof(_003CPurchaseTask_003Ed__29))]
		private Task PurchaseTask(WardrobeMakeupItem item, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003030")]
		[Cpp2IlInjected.Address(RVA = "0x14E4CE0", Offset = "0x14E36E0", VA = "0x1814E4CE0")]
		private void OnItemTapHandler(ListEventData args)
		{
			//Discarded unreachable code: IL_003d
			//IL_0015: Expected O, but got I4
			WardrobeMakeupItem component = args.DisplayObject.GetComponent<WardrobeMakeupItem>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				int iD = component.ItemData.ID;
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
				Mdl.Avatar.AvatarCustomization avatarCustomization = AvatarCustomization;
				RefreshSelected();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003031")]
		[Cpp2IlInjected.Address(RVA = "0x14E5700", Offset = "0x14E4100", VA = "0x1814E5700")]
		[AsyncStateMachine(typeof(_003CSelectMakeupAsync_003Ed__31))]
		private Task SelectMakeupAsync(MakeupItem makeupItem)
		{
			int makeupItemID = makeupItem.MakeupItemID;
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003032")]
		[Cpp2IlInjected.Address(RVA = "0x14E5480", Offset = "0x14E3E80", VA = "0x1814E5480")]
		public void RefreshSelected()
		{
			//Discarded unreachable code: IL_0065, IL_006b, IL_0071, IL_0077, IL_0089
			//IL_003d: Expected O, but got I4
			WardrobeMakeupItem wardrobeMakeupItem = default(WardrobeMakeupItem);
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				if (!base.gameObject.activeInHierarchy)
				{
					return;
				}
				IEnumerator enumerator = ((LoopScrollRect)_listMakeup).m_Content.GetEnumerator();
				if (enumerator != null)
				{
					int num2 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num3 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					int num4 = 0;
					if (!(wardrobeMakeupItem != (UnityEngine.Object)num4))
					{
						continue;
					}
					int iD = wardrobeMakeupItem.ItemData.ID;
					AvatarAppearance avatarAppearance = Avatar;
					wardrobeMakeupItem.IsSelected = flag;
				}
				if (!flag)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003033")]
		[Cpp2IlInjected.Address(RVA = "0x14E4620", Offset = "0x14E3020", VA = "0x1814E4620")]
		private void NotifyMakeupColor(MakeupItem item)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003034")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public WardrobeMakeupContent()
		{
		}
	}
}
