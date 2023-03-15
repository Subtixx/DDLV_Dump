using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Furnitures;
using Mdl.Ui.Widgets;
using Meta.Customization;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x200092D")]
	internal class FurnitureMainEditView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200092E")]
		public delegate void SelectFurniture(FurnitureItem furniture);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003620")]
		public TabsContainer tabsContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003621")]
		public FurnitureMainEditTab tabPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003622")]
		public FurnitureSelectionView furnitureSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003623")]
		[SerializeField]
		private Button _newDesignButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003624")]
		[SerializeField]
		private Button _editDesignButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003625")]
		[SerializeField]
		private Button _deleteDesignButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003626")]
		[SerializeField]
		private Button _setDesignButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003627")]
		[SerializeField]
		private Text _currentDesign;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003628")]
		[SerializeField]
		private Button _quitButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400362A")]
		private FurnitureAppearance _furniture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400362B")]
		private FurnitureCustomization _furnitureCustomization;

		[Cpp2IlInjected.Token(Token = "0x170007F6")]
		public Button EditDesignButton
		{
			[Cpp2IlInjected.Token(Token = "0x60039CA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return _editDesignButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007F7")]
		public Button NewDesignButton
		{
			[Cpp2IlInjected.Token(Token = "0x60039CB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _newDesignButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170007F8")]
		public Button QuitButton
		{
			[Cpp2IlInjected.Token(Token = "0x60039CC")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return _quitButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000077")]
		public event SelectFurniture OnFurnitureSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60039CD")]
			[Cpp2IlInjected.Address(RVA = "0x1671A00", Offset = "0x1670400", VA = "0x181671A00")]
			[CompilerGenerated]
			add
			{
				SelectFurniture onFurnitureSelected = this.OnFurnitureSelected;
				Delegate @delegate = Delegate.Combine(onFurnitureSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFurnitureSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60039CE")]
			[Cpp2IlInjected.Address(RVA = "0x1671AA0", Offset = "0x16704A0", VA = "0x181671AA0")]
			[CompilerGenerated]
			remove
			{
				SelectFurniture onFurnitureSelected = this.OnFurnitureSelected;
				Delegate @delegate = Delegate.Remove(onFurnitureSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFurnitureSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039CF")]
		[Cpp2IlInjected.Address(RVA = "0x1670AF0", Offset = "0x166F4F0", VA = "0x181670AF0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_00e2, IL_00e8, IL_00ee, IL_00f4, IL_00fa, IL_0100, IL_0106, IL_010c, IL_0112, IL_0118, IL_011e
			int initialIndex = 0;
			FurnitureSelectionView furnitureSelectionView = furnitureSelection;
			FurnitureSelectionView.FurnitureSelected value = FurnitureSelected;
			furnitureSelectionView.OnFurnitureSelected += value;
			this.tabsContainer.initialIndex = initialIndex;
			this.tabsContainer.Init();
			IEnumerator enumerator = Enum.GetValues(typeof(FurnitureItemType)).GetEnumerator();
			float z2 = default(float);
			if (enumerator != null)
			{
				IEnumerator enumerator2 = enumerator;
				FurnitureMainEditTab original = tabPrefab;
				Transform parent = this.tabsContainer.transform;
				FurnitureMainEditTab furnitureMainEditTab = UnityEngine.Object.Instantiate(original, parent);
				string text = furnitureMainEditTab.ToString();
				FurnitureMainEditTab furnitureMainEditTab2 = furnitureMainEditTab;
				furnitureMainEditTab._label.text = text;
				Transform transform = furnitureMainEditTab.transform;
				float z = UnityEngine.Vector3.zero.z;
				Transform transform2 = furnitureMainEditTab.transform;
				z2 = UnityEngine.Vector3.one.z;
				TabsContainer tabsContainer = this.tabsContainer;
				Tab tab = furnitureMainEditTab._tab;
				tabsContainer.AddTab(tab);
			}
			if (z2 != 0f)
			{
			}
			int num = 0;
			int num2 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60039D0")]
		[Cpp2IlInjected.Address(RVA = "0x1671430", Offset = "0x166FE30", VA = "0x181671430")]
		public void Init(FurnitureAppearance furniture, FurnitureCustomization furnitureCustomization)
		{
			//Discarded unreachable code: IL_0057
			//IL_0028: Expected I4, but got I8
			//IL_0034: Expected I4, but got I8
			_furniture = furniture;
			_furnitureCustomization = furnitureCustomization;
			TabsContainer tabsContainer = this.tabsContainer;
			FurnitureSelectionView furnitureSelectionView = furnitureSelection;
			ulong num = default(ulong);
			_setDesignButton.interactable = (byte)num != 0;
			ulong num2 = default(ulong);
			_deleteDesignButton.interactable = (byte)num2 != 0;
			FurnitureAppearance furniture2 = _furniture;
			Text currentDesign = _currentDesign;
			int currentDesignId = furniture2.GetCurrentDesignId();
			string text = default(string);
			currentDesign.text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x60039D1")]
		[Cpp2IlInjected.Address(RVA = "0x1671810", Offset = "0x1670210", VA = "0x181671810")]
		public void Show()
		{
			//Discarded unreachable code: IL_0049
			base.gameObject.SetActive(value: true);
			TabsContainer tabsContainer = this.tabsContainer;
			FurnitureSelectionView furnitureSelectionView = furnitureSelection;
			FurnitureAppearance furniture = _furniture;
			Text currentDesign = _currentDesign;
			int currentDesignId = furniture.GetCurrentDesignId();
			string text = default(string);
			currentDesign.text = text;
			_furnitureCustomization.Zoom();
		}

		[Cpp2IlInjected.Token(Token = "0x60039D2")]
		[Cpp2IlInjected.Address(RVA = "0x16713F0", Offset = "0x166FDF0", VA = "0x1816713F0")]
		public void Hide()
		{
			//Discarded unreachable code: IL_001c
			furnitureSelection.Clear();
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60039D3")]
		[Cpp2IlInjected.Address(RVA = "0x1671380", Offset = "0x166FD80", VA = "0x181671380")]
		private void FurnitureSelected(FurnitureItem furniture)
		{
			//Discarded unreachable code: IL_0030
			this.OnFurnitureSelected?.Invoke(furniture);
			FurnitureAppearance furniture2 = _furniture;
			Text currentDesign = _currentDesign;
			int currentDesignId = furniture2.GetCurrentDesignId();
			string text = default(string);
			currentDesign.text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x60039D4")]
		[Cpp2IlInjected.Address(RVA = "0x16719A0", Offset = "0x16703A0", VA = "0x1816719A0")]
		private void UpdateCurrentDesignLabel()
		{
			//Discarded unreachable code: IL_001b
			Text currentDesign = _currentDesign;
			int currentDesignId = _furniture.GetCurrentDesignId();
			string text = default(string);
			currentDesign.text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x60039D5")]
		[Cpp2IlInjected.Address(RVA = "0x1671030", Offset = "0x166FA30", VA = "0x181671030")]
		private int CurrentDesignId()
		{
			//Discarded unreachable code: IL_000c
			return _furniture.GetCurrentDesignId();
		}

		[Cpp2IlInjected.Token(Token = "0x60039D6")]
		[Cpp2IlInjected.Address(RVA = "0x1671510", Offset = "0x166FF10", VA = "0x181671510")]
		private void NextDesign()
		{
			//Discarded unreachable code: IL_009f
			int currentId = _furniture.GetCurrentDesignId();
			FurnitureAppearance furniture = _furniture;
			if ((long)furniture.CurrentFurniture == 0)
			{
				return;
			}
			int furnitureItem_ = _furnitureCustomization.furniture.CurrentFurniture.Data.furnitureItem_;
			List<KeyValuePair<int, Design>> allDesigns = (List<KeyValuePair<int, Design>>)(object)furniture.GetAllDesigns(furnitureItem_);
			if (allDesigns != null)
			{
				Predicate<KeyValuePair<int, Design>> predicate = (Predicate<KeyValuePair<int, Design>>)(object)(Predicate<T>)delegate
				{
					int num3 = currentId;
					bool result = default(bool);
					return result;
				};
				int num = ((List<T>)(object)allDesigns).FindIndex((Predicate<>)(object)predicate);
				int size = ((List<>)(object)allDesigns)._size;
				num++;
				if ((IntPtr)predicate != (IntPtr)size)
				{
					int num2 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					num2 += num2;
				}
				uint currentDesignAsync = default(uint);
				SetCurrentDesignAsync((int)currentDesignAsync).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039D7")]
		[Cpp2IlInjected.Address(RVA = "0x1671700", Offset = "0x1670100", VA = "0x181671700")]
		[AsyncStateMachine(typeof(_003CSetCurrentDesignAsync_003Ed__29))]
		private Task SetCurrentDesignAsync(int designId)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60039D8")]
		[Cpp2IlInjected.Address(RVA = "0x1671190", Offset = "0x166FB90", VA = "0x181671190")]
		private void DeleteDesign()
		{
			//Discarded unreachable code: IL_0045
			int currentDesignId = _furniture.GetCurrentDesignId();
			if (_furniture.GetCurrentDesignWorkingCopy() != null)
			{
				int num = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
			FurnitureAppearance furniture = _furniture;
			Text currentDesign = _currentDesign;
			int currentDesignId2 = furniture.GetCurrentDesignId();
			string text = default(string);
			currentDesign.text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x60039D9")]
		[Cpp2IlInjected.Address(RVA = "0x1671070", Offset = "0x166FA70", VA = "0x181671070")]
		[AsyncStateMachine(typeof(_003CDeleteDesignAsync_003Ed__31))]
		private Task DeleteDesignAsync(DesignWorkingCopy design)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60039DA")]
		[Cpp2IlInjected.Address(RVA = "0x1671050", Offset = "0x166FA50", VA = "0x181671050")]
		public FurnitureItemType CurrentFurnitureType()
		{
			int _003CCurrentTabIndex_003Ek__BackingField = tabsContainer.CurrentTabIndex;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039DB")]
		[Cpp2IlInjected.Address(RVA = "0x16718D0", Offset = "0x16702D0", VA = "0x1816718D0")]
		private void SwitchTab(int index)
		{
			//Discarded unreachable code: IL_0044
			//IL_0010: Expected O, but got I4
			FurnitureCustomization furnitureCustomization = _furnitureCustomization;
			int num = 0;
			if (!(furnitureCustomization == (UnityEngine.Object)num))
			{
				TabsContainer tabsContainer = this.tabsContainer;
				FurnitureSelectionView furnitureSelectionView = furnitureSelection;
				FurnitureAppearance furniture = _furniture;
				Text currentDesign = _currentDesign;
				int currentDesignId = furniture.GetCurrentDesignId();
				string text = default(string);
				currentDesign.text = text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039DC")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FurnitureMainEditView()
		{
		}
	}
}
