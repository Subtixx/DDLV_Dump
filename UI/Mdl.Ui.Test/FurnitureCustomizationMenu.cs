using System;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Furnitures;
using Mdl.Gestures;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x2000929")]
	internal class FurnitureCustomizationMenu : Menu
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4003613")]
		[SerializeField]
		private FurnitureMainEditView _mainEditView;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4003614")]
		[SerializeField]
		private FurnitureDesignEditView _designEditView;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4003615")]
		public bool canEditAll = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4003616")]
		private FurnitureAppearance _furniture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4003617")]
		private FurnitureCustomization _furnitureCustomization;

		[Cpp2IlInjected.Token(Token = "0x60039B0")]
		[Cpp2IlInjected.Address(RVA = "0x166EF60", Offset = "0x166D960", VA = "0x18166EF60")]
		private void Start()
		{
			//Discarded unreachable code: IL_015c
			//IL_0019: Expected O, but got I4
			SystemRoot.Instance.PauseSystem<PlayerNavigation>();
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			FurnitureCustomization furnitureCustomization = (_furnitureCustomization = _003CInstance_003Ek__BackingField.StartSystem<FurnitureCustomization>((ISystemData)num));
			FurnitureAppearance furnitureAppearance = (_furniture = _furnitureCustomization.furniture);
			GameObject gameObject = _designEditView.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			Button.ButtonClickedEvent onClick = _mainEditView._quitButton.m_OnClick;
			UnityAction call = Quit;
			onClick.AddListener(call);
			Button quitButton = _mainEditView._quitButton;
			int num2 = ((quitButton.interactable = false) ? 1 : 0);
			Button.ButtonClickedEvent onClick2 = _mainEditView._newDesignButton.m_OnClick;
			UnityAction call2 = delegate
			{
				StartDecalEdit(cloneDesign: true);
			};
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _mainEditView._editDesignButton.m_OnClick;
			UnityAction call3 = delegate
			{
				int cloneDesign = 0;
				StartDecalEdit((byte)cloneDesign != 0);
			};
			onClick3.AddListener(call3);
			FurnitureDesignEditView designEditView = _designEditView;
			FurnitureDesignEditView.Exit b = StopDecalEdit;
			FurnitureDesignEditView.Exit onExit = designEditView.OnExit;
			Delegate @delegate = Delegate.Combine(onExit, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onExit)
				{
				}
				FurnitureMainEditView mainEditView = _mainEditView;
				FurnitureMainEditView.SelectFurniture b2 = SelectFurniture;
				FurnitureMainEditView.SelectFurniture onFurnitureSelected = mainEditView.OnFurnitureSelected;
				Delegate delegate2 = Delegate.Combine(onFurnitureSelected, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != onFurnitureSelected)
					{
					}
					Init();
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039B1")]
		[Cpp2IlInjected.Address(RVA = "0x166EB00", Offset = "0x166D500", VA = "0x18166EB00")]
		private void Init()
		{
			//Discarded unreachable code: IL_0100
			FurnitureMainEditView mainEditView = _mainEditView;
			FurnitureCustomization furnitureCustomization = _furnitureCustomization;
			FurnitureAppearance furnitureAppearance = (mainEditView._furniture = _furniture);
			mainEditView._furnitureCustomization = furnitureCustomization;
			TabsContainer tabsContainer = mainEditView.tabsContainer;
			FurnitureSelectionView furnitureSelection = mainEditView.furnitureSelection;
			mainEditView._setDesignButton.interactable = true;
			mainEditView._deleteDesignButton.interactable = true;
			string text = default(string);
			mainEditView._currentDesign.text = text;
			FurnitureDesignEditView designEditView = _designEditView;
			FurnitureAppearance furniture = _furniture;
			FurnitureCustomization furnitureCustomization2 = _furnitureCustomization;
			if (!designEditView._constructed)
			{
				designEditView.Construct();
			}
			designEditView._furniture = furniture;
			designEditView._furnitureCustomization = furnitureCustomization2;
			OrbitCameraConfig cameraConfig = designEditView._furniture.orbitCameraTarget.cameraConfig;
			MoveGesture move = designEditView._move;
			float num = (move.MaxForce = cameraConfig.moveMaxForce);
			OrbitCameraConfig cameraConfig2 = designEditView._furniture.orbitCameraTarget.cameraConfig;
			MoveGesture move2 = designEditView._move;
			float num2 = (move2.Friction = cameraConfig2.moveFriction);
			_mainEditView._quitButton.interactable = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60039B2")]
		[Cpp2IlInjected.Address(RVA = "0x166ECD0", Offset = "0x166D6D0", VA = "0x18166ECD0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0011
			SystemRoot.Instance.ResumeSystem<PlayerNavigation>();
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x60039B3")]
		[Cpp2IlInjected.Address(RVA = "0x166F560", Offset = "0x166DF60", VA = "0x18166F560")]
		private void Update()
		{
			//Discarded unreachable code: IL_0070
			FurnitureDesignEditView designEditView = _designEditView;
			if (designEditView.IsShown)
			{
				int num = 0;
				float deltaTime = Time.deltaTime;
				Task startDesignMode = designEditView._startDesignMode;
				if ((startDesignMode == null || startDesignMode.IsCompleted || designEditView._startDesignMode.IsCanceled) && !designEditView._decalView.IsShown)
				{
					designEditView._move.Update(deltaTime);
					OrbitCamera orbitCamera = designEditView._orbitCamera;
					MoveGesture move = designEditView._move;
					orbitCamera.Move(deltaTime, move);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039B4")]
		[Cpp2IlInjected.Address(RVA = "0x166EEB0", Offset = "0x166D8B0", VA = "0x18166EEB0")]
		private void StartDecalEdit(bool cloneDesign)
		{
			//Discarded unreachable code: IL_005c
			FurnitureAppearance furniture = _furnitureCustomization.furniture;
			bool force = canEditAll;
			if (furniture.CanEditDecals(force))
			{
				FurnitureMainEditView mainEditView = _mainEditView;
				mainEditView.furnitureSelection.Clear();
				GameObject gameObject = mainEditView.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				FurnitureDesignEditView designEditView = _designEditView;
				bool flag = canEditAll;
				designEditView.Show(cloneDesign, flag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039B5")]
		[Cpp2IlInjected.Address(RVA = "0x166F420", Offset = "0x166DE20", VA = "0x18166F420")]
		private void StopDecalEdit()
		{
			//Discarded unreachable code: IL_0083
			FurnitureMainEditView mainEditView = _mainEditView;
			mainEditView.gameObject.SetActive(value: true);
			TabsContainer tabsContainer = mainEditView.tabsContainer;
			FurnitureSelectionView furnitureSelection = mainEditView.furnitureSelection;
			FurnitureAppearance furniture = mainEditView._furniture;
			Text currentDesign = mainEditView._currentDesign;
			int currentDesignId = furniture.GetCurrentDesignId();
			string text = default(string);
			currentDesign.text = text;
			mainEditView._furnitureCustomization.Zoom();
			FurnitureDesignEditView designEditView = _designEditView;
			designEditView._furnitureCustomization.StopDesignMode();
			GameObject gameObject = designEditView.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			designEditView.IsShown = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60039B6")]
		[Cpp2IlInjected.Address(RVA = "0x166EE80", Offset = "0x166D880", VA = "0x18166EE80")]
		private void SelectFurniture(FurnitureItem furniture)
		{
			//Discarded unreachable code: IL_000d
			_furnitureCustomization.SelectFurniture(furniture);
		}

		[Cpp2IlInjected.Token(Token = "0x60039B7")]
		[Cpp2IlInjected.Address(RVA = "0x166EDA0", Offset = "0x166D7A0", VA = "0x18166EDA0")]
		private void Quit()
		{
			//Discarded unreachable code: IL_001c
			SystemRoot.Instance.StopSystem<FurnitureCustomization>();
			int num = 0;
			UiRoot.Instance._menuStack.Pop();
		}

		[Cpp2IlInjected.Token(Token = "0x60039B8")]
		[Cpp2IlInjected.Address(RVA = "0xCAC210", Offset = "0xCAAC10", VA = "0x180CAC210")]
		public FurnitureCustomizationMenu()
		{
		}
	}
}
