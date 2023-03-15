using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Gestures;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using Meta.Customization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x20008D4")]
	internal class AvatarCustomizationMenu : Menu
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40034B0")]
		[SerializeField]
		private AvatarMainEditView _mainEditView;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40034B1")]
		[SerializeField]
		private AvatarDesignEditView _designEditView;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40034B2")]
		[SerializeField]
		private AvatarMakeupEditView _makeupEditView;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40034B3")]
		[SerializeField]
		private AvatarPhotoView _photoView;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40034B4")]
		public bool canEditAll = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40034B5")]
		private AvatarAppearance _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40034B6")]
		private AvatarCustomization _avatarCustomization;

		[Cpp2IlInjected.Token(Token = "0x6003785")]
		[Cpp2IlInjected.Address(RVA = "0x884A40", Offset = "0x883440", VA = "0x180884A40")]
		private void Start()
		{
			//Discarded unreachable code: IL_065d
			//IL_0019: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_0251: Expected O, but got I4
			//IL_0346: Expected O, but got I4
			Button editMakeupButton = default(Button);
			GameObject gameObject4 = default(GameObject);
			while (true)
			{
				SystemRoot.Instance.PauseSystem<PlayerNavigation>();
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				int num = 0;
				AvatarCustomization avatarCustomization = (_avatarCustomization = _003CInstance_003Ek__BackingField.StartSystem<AvatarCustomization>((ISystemData)num));
				AvatarCustomization avatarCustomization2 = _avatarCustomization;
				AvatarCustomization.AvatarReady value = Init;
				avatarCustomization2.OnAvatarReady += value;
				_mainEditView.gameObject.SetActive(value: true);
				GameObject gameObject = _designEditView.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				GameObject gameObject2 = _photoView.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
				AvatarMakeupEditView makeupEditView = _makeupEditView;
				int num2 = 0;
				if (makeupEditView != (UnityEngine.Object)num2)
				{
					GameObject gameObject3 = _makeupEditView.gameObject;
					int active3 = 0;
					gameObject3.SetActive((byte)active3 != 0);
				}
				Button.ButtonClickedEvent onClick = _mainEditView._saveButton.m_OnClick;
				UnityAction call = Save;
				onClick.AddListener(call);
				Button saveButton = _mainEditView._saveButton;
				int num3 = ((saveButton.interactable = false) ? 1 : 0);
				Button.ButtonClickedEvent onClick2 = _mainEditView._cancelButton.m_OnClick;
				UnityAction call2 = Cancel;
				onClick2.AddListener(call2);
				Button cancelButton = _mainEditView._cancelButton;
				int num4 = ((cancelButton.interactable = false) ? 1 : 0);
				Button.ButtonClickedEvent onClick3 = _mainEditView._undoButton.m_OnClick;
				UnityAction call3 = Undo;
				onClick3.AddListener(call3);
				Button undoButton = _mainEditView._undoButton;
				int num5 = ((undoButton.interactable = false) ? 1 : 0);
				Button.ButtonClickedEvent onClick4 = _mainEditView._redoButton.m_OnClick;
				UnityAction call4 = Redo;
				onClick4.AddListener(call4);
				Button redoButton = _mainEditView._redoButton;
				int num6 = ((redoButton.interactable = false) ? 1 : 0);
				Button.ButtonClickedEvent onClick5 = _mainEditView._newDesignButton.m_OnClick;
				UnityAction call5 = delegate
				{
					StartEditingDesign(cloneDesign: true);
				};
				onClick5.AddListener(call5);
				Button newDesignButton = _mainEditView._newDesignButton;
				int num7 = ((newDesignButton.interactable = false) ? 1 : 0);
				Button.ButtonClickedEvent onClick6 = _mainEditView._editDesignButton.m_OnClick;
				UnityAction call6 = delegate
				{
					int cloneDesign = 0;
					StartEditingDesign((byte)cloneDesign != 0);
				};
				onClick6.AddListener(call6);
				Button editDesignButton = _mainEditView._editDesignButton;
				int num8 = ((editDesignButton.interactable = false) ? 1 : 0);
				AvatarMakeupEditView makeupEditView2 = _makeupEditView;
				int num9 = 0;
				bool flag7 = makeupEditView2 == (UnityEngine.Object)num9;
				AvatarMainEditView mainEditView = _mainEditView;
				if (!flag7)
				{
					Button.ButtonClickedEvent onClick7 = mainEditView._editMakeupButton.m_OnClick;
					UnityAction call7 = delegate
					{
						//Discarded unreachable code: IL_0062
						AvatarMainEditView mainEditView13 = _mainEditView;
						mainEditView13.clothingSelection.Clear();
						mainEditView13.makeupSelection.Clear();
						GameObject gameObject5 = mainEditView13.gameObject;
						int active5 = 0;
						gameObject5.SetActive((byte)active5 != 0);
						AvatarMakeupEditView makeupEditView5 = _makeupEditView;
						HistoryStack<DesignWorkingCopy> historyStack = (makeupEditView5._designHistory = (HistoryStack<DesignWorkingCopy>)(object)new HistoryStack<T>((T)new DesignWorkingCopy()));
						makeupEditView5.gameObject.SetActive(value: true);
						makeupEditView5.IsShown = true;
						makeupEditView5.StartEditingDecals();
					};
					onClick7.AddListener(call7);
					editMakeupButton = _mainEditView._editMakeupButton;
					int num10 = ((editMakeupButton.interactable = false) ? 1 : 0);
				}
				SpriteState spriteState = ((Selectable)editMakeupButton).m_SpriteState;
				int active4 = 0;
				gameObject4.SetActive((byte)active4 != 0);
				Button.ButtonClickedEvent onClick8 = _mainEditView._photoViewButton.m_OnClick;
				UnityAction call8 = StartPhotoView;
				onClick8.AddListener(call8);
				Button photoViewButton = _mainEditView._photoViewButton;
				int num11 = ((photoViewButton.interactable = false) ? 1 : 0);
				AvatarDesignEditView designEditView = _designEditView;
				AvatarDesignEditView.Exit b = StopEditingDesign;
				AvatarDesignEditView.Exit onExit = designEditView.OnExit;
				Delegate @delegate = Delegate.Combine(onExit, b);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					continue;
				}
				while ((object)@delegate != onExit)
				{
				}
				AvatarMakeupEditView makeupEditView3 = _makeupEditView;
				int num12 = 0;
				if (makeupEditView3 != (UnityEngine.Object)num12)
				{
					AvatarMakeupEditView makeupEditView4 = _makeupEditView;
					AvatarMakeupEditView.Exit b2 = StopEditingMakeup;
					AvatarMakeupEditView.Exit onExit2 = makeupEditView4.OnExit;
					Delegate delegate2 = Delegate.Combine(onExit2, b2);
					if ((object)delegate2 != null && (object)delegate2 == null)
					{
						break;
					}
					while ((object)delegate2 != onExit2)
					{
					}
				}
				AvatarPhotoView photoView = _photoView;
				AvatarPhotoView.Exit b3 = StopPhotoView;
				AvatarPhotoView.Exit onExit3 = photoView.OnExit;
				Delegate delegate3 = Delegate.Combine(onExit3, b3);
				if ((object)delegate3 != null && (object)delegate3 == null)
				{
					continue;
				}
				while ((object)delegate3 != onExit3)
				{
				}
				AvatarMainEditView mainEditView2 = _mainEditView;
				AvatarMainEditView.SelectClothes b4 = SelectClothes;
				AvatarMainEditView.SelectClothes onClothesSelected = mainEditView2.OnClothesSelected;
				Delegate delegate4 = Delegate.Combine(onClothesSelected, b4);
				if ((object)delegate4 != null && (object)delegate4 == null)
				{
					continue;
				}
				while ((object)delegate4 != onClothesSelected)
				{
				}
				AvatarMainEditView mainEditView3 = _mainEditView;
				AvatarMainEditView.RemoveClothes b5 = RemoveClothes;
				AvatarMainEditView.RemoveClothes onClothesRemoved = mainEditView3.OnClothesRemoved;
				Delegate delegate5 = Delegate.Combine(onClothesRemoved, b5);
				if ((object)delegate5 != null && (object)delegate5 == null)
				{
					continue;
				}
				while ((object)delegate5 != onClothesRemoved)
				{
				}
				AvatarMainEditView mainEditView4 = _mainEditView;
				AvatarMainEditView.SelectMakeup b6 = SelectMakeup;
				AvatarMainEditView.SelectMakeup onMakeupSelected = mainEditView4.OnMakeupSelected;
				Delegate delegate6 = Delegate.Combine(onMakeupSelected, b6);
				if ((object)delegate6 != null && (object)delegate6 == null)
				{
					continue;
				}
				while ((object)delegate6 != onMakeupSelected)
				{
				}
				AvatarMainEditView mainEditView5 = _mainEditView;
				AvatarMainEditView.RemoveMakeup b7 = RemoveMakeup;
				AvatarMainEditView.RemoveMakeup onMakeupRemoved = mainEditView5.OnMakeupRemoved;
				Delegate delegate7 = Delegate.Combine(onMakeupRemoved, b7);
				if ((object)delegate7 != null && (object)delegate7 == null)
				{
					continue;
				}
				while ((object)delegate7 != onMakeupRemoved)
				{
				}
				AvatarMainEditView mainEditView6 = _mainEditView;
				AvatarMainEditView.SetGender b8 = SetGender;
				AvatarMainEditView.SetGender onGenderSet = mainEditView6.OnGenderSet;
				Delegate delegate8 = Delegate.Combine(onGenderSet, b8);
				if ((object)delegate8 != null && (object)delegate8 == null)
				{
					continue;
				}
				while ((object)delegate8 != onGenderSet)
				{
				}
				AvatarMainEditView mainEditView7 = _mainEditView;
				AvatarMainEditView.SetBodyType b9 = SetBodyType;
				AvatarMainEditView.SetBodyType onBodyTypeSet = mainEditView7.OnBodyTypeSet;
				Delegate delegate9 = Delegate.Combine(onBodyTypeSet, b9);
				if ((object)delegate9 != null && (object)delegate9 == null)
				{
					continue;
				}
				while ((object)delegate9 != onBodyTypeSet)
				{
				}
				AvatarMainEditView mainEditView8 = _mainEditView;
				AvatarMainEditView.SetSkinColor b10 = SetSkinColor;
				AvatarMainEditView.SetSkinColor onSkinColorSet = mainEditView8.OnSkinColorSet;
				Delegate delegate10 = Delegate.Combine(onSkinColorSet, b10);
				if ((object)delegate10 == null || (object)delegate10 != null)
				{
					while ((object)delegate10 != onSkinColorSet)
					{
					}
					AvatarMainEditView mainEditView9 = _mainEditView;
					AvatarMainEditView.SetHairColor b11 = SetHairColor;
					AvatarMainEditView.SetHairColor onHairColorSet = mainEditView9.OnHairColorSet;
					Delegate delegate11 = Delegate.Combine(onHairColorSet, b11);
					if ((object)delegate11 == null || (object)delegate11 != null)
					{
						while ((object)delegate11 != onHairColorSet)
						{
						}
						AvatarMainEditView mainEditView10 = _mainEditView;
						AvatarMainEditView.SetHairColor b12 = SetHighlightColor;
						AvatarMainEditView.SetHairColor onHighlightColorSet = mainEditView10.OnHighlightColorSet;
						Delegate delegate12 = Delegate.Combine(onHighlightColorSet, b12);
						if ((object)delegate12 == null || (object)delegate12 != null)
						{
							while ((object)delegate12 != onHighlightColorSet)
							{
							}
							AvatarMainEditView mainEditView11 = _mainEditView;
							AvatarMainEditView.SetEyeColor b13 = SetEyeColor;
							AvatarMainEditView.SetEyeColor onEyeColorSet = mainEditView11.OnEyeColorSet;
							Delegate delegate13 = Delegate.Combine(onEyeColorSet, b13);
							if ((object)delegate13 == null || (object)delegate13 != null)
							{
								while ((object)delegate13 != onEyeColorSet)
								{
								}
								AvatarMainEditView mainEditView12 = _mainEditView;
								AvatarMainEditView.SelectFaceType b14 = SelectFaceType;
								AvatarMainEditView.SelectFaceType onFaceTypeSelected = mainEditView12.OnFaceTypeSelected;
								Delegate delegate14 = Delegate.Combine(onFaceTypeSelected, b14);
								if ((object)delegate14 == null || (object)delegate14 != null)
								{
									while ((object)delegate14 != onFaceTypeSelected)
									{
									}
									return;
								}
							}
						}
					}
				}
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003786")]
		[Cpp2IlInjected.Address(RVA = "0x8839A0", Offset = "0x8823A0", VA = "0x1808839A0", Slot = "24")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_0054
			//IL_002b: Expected O, but got I4
			AvatarCustomization avatarCustomization = _avatarCustomization;
			AvatarCustomization.AvatarReady value = Init;
			avatarCustomization.OnAvatarReady -= value;
			AvatarAppearance avatar = _avatar;
			int num = 0;
			if (avatar != (UnityEngine.Object)num)
			{
				AvatarAppearance avatar2 = _avatar;
				AvatarAppearance.AvatarChanged value2 = Refresh;
				avatar2.OnAvatarChanged -= value2;
			}
			base.OnDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x6003787")]
		[Cpp2IlInjected.Address(RVA = "0x883AE0", Offset = "0x8824E0", VA = "0x180883AE0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0011
			SystemRoot.Instance.ResumeSystem<PlayerNavigation>();
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6003788")]
		[Cpp2IlInjected.Address(RVA = "0x8832A0", Offset = "0x881CA0", VA = "0x1808832A0")]
		private void Init(AvatarAppearance avatar)
		{
			//Discarded unreachable code: IL_01bd
			//IL_00b2: Expected O, but got I4
			_avatar = avatar;
			AvatarAppearance.AvatarChanged avatarChanged = Refresh;
			avatar.OnAvatarChanged += avatarChanged;
			AvatarMainEditView mainEditView = _mainEditView;
			AvatarDesignEditView designEditView = _designEditView;
			AvatarCustomization avatarCustomization = _avatarCustomization;
			if (!designEditView._constructed)
			{
				designEditView.Construct();
			}
			designEditView._avatarCustomization = avatarCustomization;
			OrbitCameraConfig cameraConfig = designEditView._avatar.orbitCameraTarget.cameraConfig;
			MoveGesture move = designEditView._move;
			float num = (move.MaxForce = cameraConfig.moveMaxForce);
			OrbitCameraConfig cameraConfig2 = designEditView._avatar.orbitCameraTarget.cameraConfig;
			MoveGesture move2 = designEditView._move;
			float num2 = (move2.Friction = cameraConfig2.moveFriction);
			AvatarMakeupEditView makeupEditView = _makeupEditView;
			int num3 = 0;
			if (makeupEditView != (UnityEngine.Object)num3)
			{
				AvatarMakeupEditView makeupEditView2 = _makeupEditView;
				if (!makeupEditView2._constructed)
				{
					GameObject gameObject = makeupEditView2._decalView.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					Button.ButtonClickedEvent onClick = makeupEditView2._backButton.m_OnClick;
					UnityAction call = makeupEditView2.Back;
					onClick.AddListener(call);
					Camera camera = (makeupEditView2._camera = SystemRoot.Instance._playerCamera);
					makeupEditView2._constructed = true;
				}
				makeupEditView2._avatar = (AvatarAppearance)(object)avatarChanged;
			}
			AvatarPhotoView photoView = _photoView;
			_mainEditView._newDesignButton.interactable = true;
			_mainEditView._editDesignButton.interactable = true;
			_mainEditView._editMakeupButton.interactable = true;
			_mainEditView._saveButton.interactable = true;
			_mainEditView._cancelButton.interactable = true;
			_mainEditView._undoButton.interactable = true;
			_mainEditView._redoButton.interactable = true;
			_mainEditView._photoViewButton.interactable = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003789")]
		[Cpp2IlInjected.Address(RVA = "0x886170", Offset = "0x884B70", VA = "0x180886170")]
		private void Update()
		{
			//Discarded unreachable code: IL_00ec
			//IL_0023: Expected O, but got I4
			AvatarDesignEditView designEditView;
			float deltaTime3;
			Task startDesignMode;
			do
			{
				designEditView = _designEditView;
				if (!designEditView.IsShown)
				{
					AvatarMakeupEditView makeupEditView = _makeupEditView;
					int num = 0;
					if (makeupEditView != (UnityEngine.Object)num)
					{
						AvatarMakeupEditView makeupEditView2 = _makeupEditView;
						if (makeupEditView2.IsShown)
						{
							int num2 = 0;
							float deltaTime = Time.deltaTime;
							makeupEditView2._decalView.UpdateState(deltaTime);
							return;
						}
					}
					AvatarPhotoView photoView = _photoView;
					if (photoView.IsShown)
					{
						int num3 = 0;
						float deltaTime2 = Time.deltaTime;
						photoView._move.Update(deltaTime2);
						OrbitCamera orbitCamera = photoView._orbitCamera;
						MoveGesture move = photoView._move;
						orbitCamera.Move(deltaTime2, move);
					}
					return;
				}
				int num4 = 0;
				deltaTime3 = Time.deltaTime;
				startDesignMode = designEditView._startDesignMode;
			}
			while (startDesignMode != null && !startDesignMode.IsCompleted && !designEditView._startDesignMode.IsCanceled);
			if (!designEditView._decalView.IsShown)
			{
				designEditView._move.Update(deltaTime3);
				OrbitCamera orbitCamera2 = designEditView._orbitCamera;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600378A")]
		[Cpp2IlInjected.Address(RVA = "0x883C20", Offset = "0x882620", VA = "0x180883C20")]
		private void Refresh(AvatarAppearance avatar)
		{
			//Discarded unreachable code: IL_0044
			AvatarMainEditView mainEditView = _mainEditView;
			TabsContainer genderTabs = mainEditView._genderTabs;
			bool index = avatar.IsMale;
			genderTabs.SelectTab(index ? 1 : 0);
			Text currentDesign = mainEditView._currentDesign;
			ClothingItemType? clothingItemType = (ClothingItemType?)mainEditView.CurrentClothingType();
			int num = mainEditView.CurrentDesignId((Nullable<>)clothingItemType);
			string text = default(string);
			currentDesign.text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x600378B")]
		[Cpp2IlInjected.Address(RVA = "0x884620", Offset = "0x883020", VA = "0x180884620")]
		private void StartEditingDesign(bool cloneDesign)
		{
			//Discarded unreachable code: IL_0066
			ClothingItemType? clothingItemType = (ClothingItemType?)_mainEditView.CurrentClothingType();
			AvatarAppearance avatar = _avatar;
			bool flag = default(bool);
			if (flag)
			{
				AvatarMainEditView mainEditView = _mainEditView;
				mainEditView.clothingSelection.Clear();
				mainEditView.makeupSelection.Clear();
				GameObject gameObject = mainEditView.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				AvatarMainEditView mainEditView2 = _mainEditView;
				AvatarDesignEditView designEditView = _designEditView;
				ClothingItemType? clothingItemType2 = (ClothingItemType?)mainEditView2.CurrentClothingType();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600378C")]
		[Cpp2IlInjected.Address(RVA = "0x885D20", Offset = "0x884720", VA = "0x180885D20")]
		private void StopEditingDesign()
		{
			//Discarded unreachable code: IL_002a
			AvatarMainEditView mainEditView = _mainEditView;
			mainEditView.gameObject.SetActive(value: true);
			mainEditView.PopulateCurrent();
			AvatarDesignEditView designEditView = _designEditView;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600378D")]
		[Cpp2IlInjected.Address(RVA = "0x884770", Offset = "0x883170", VA = "0x180884770")]
		private void StartEditingMakeup()
		{
			//Discarded unreachable code: IL_0062
			AvatarMainEditView mainEditView = _mainEditView;
			mainEditView.clothingSelection.Clear();
			mainEditView.makeupSelection.Clear();
			GameObject gameObject = mainEditView.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			AvatarMakeupEditView makeupEditView = _makeupEditView;
			HistoryStack<DesignWorkingCopy> historyStack = (makeupEditView._designHistory = (HistoryStack<DesignWorkingCopy>)(object)new HistoryStack<T>((T)new DesignWorkingCopy()));
			makeupEditView.gameObject.SetActive(value: true);
			makeupEditView.IsShown = true;
			makeupEditView.StartEditingDecals();
		}

		[Cpp2IlInjected.Token(Token = "0x600378E")]
		[Cpp2IlInjected.Address(RVA = "0x885EC0", Offset = "0x8848C0", VA = "0x180885EC0")]
		private void StopEditingMakeup()
		{
			//Discarded unreachable code: IL_0038
			AvatarMainEditView mainEditView = _mainEditView;
			mainEditView.gameObject.SetActive(value: true);
			mainEditView.PopulateCurrent();
			AvatarMakeupEditView makeupEditView = _makeupEditView;
			GameObject gameObject = makeupEditView.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			makeupEditView.IsShown = false;
		}

		[Cpp2IlInjected.Token(Token = "0x600378F")]
		[Cpp2IlInjected.Address(RVA = "0x8848B0", Offset = "0x8832B0", VA = "0x1808848B0")]
		private void StartPhotoView()
		{
			//Discarded unreachable code: IL_009a
			AvatarMainEditView mainEditView = _mainEditView;
			mainEditView.clothingSelection.Clear();
			mainEditView.makeupSelection.Clear();
			GameObject gameObject = mainEditView.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			AvatarPhotoView photoView = _photoView;
			photoView.gameObject.SetActive(value: true);
			AvatarAppearance avatar = photoView._avatar;
			OrbitCamera orbitCamera = photoView._orbitCamera;
			photoView.IsShown = true;
			Transform startCamera = avatar.orbitCameraTarget.startCamera;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			Transform lookAt = photoView._avatar.orbitCameraTarget.lookAt;
			OrbitCameraTarget orbitCameraTarget = photoView._avatar.orbitCameraTarget;
			int num = 0;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6003790")]
		[Cpp2IlInjected.Address(RVA = "0x885F40", Offset = "0x884940", VA = "0x180885F40")]
		private void StopPhotoView()
		{
			//Discarded unreachable code: IL_0038
			AvatarMainEditView mainEditView = _mainEditView;
			mainEditView.gameObject.SetActive(value: true);
			mainEditView.PopulateCurrent();
			AvatarPhotoView photoView = _photoView;
			GameObject gameObject = photoView.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			photoView.IsShown = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6003791")]
		[Cpp2IlInjected.Address(RVA = "0x8843E0", Offset = "0x882DE0", VA = "0x1808843E0")]
		private void SetGender(bool isMale)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6003792")]
		[Cpp2IlInjected.Address(RVA = "0x884330", Offset = "0x882D30", VA = "0x180884330")]
		private void SetBodyType(int bodyTypeIndex)
		{
			//Discarded unreachable code: IL_0012
			_avatarCustomization.SetBodyType(bodyTypeIndex).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6003793")]
		[Cpp2IlInjected.Address(RVA = "0x883FB0", Offset = "0x8829B0", VA = "0x180883FB0")]
		private void SelectClothes(Item item)
		{
			//Discarded unreachable code: IL_000e
			AvatarCustomization avatarCustomization = _avatarCustomization;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6003794")]
		[Cpp2IlInjected.Address(RVA = "0x883CC0", Offset = "0x8826C0", VA = "0x180883CC0")]
		private void RemoveClothes(ClothingItemType clothingType)
		{
			//Discarded unreachable code: IL_000e
			AvatarCustomization avatarCustomization = _avatarCustomization;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6003795")]
		[Cpp2IlInjected.Address(RVA = "0x8841E0", Offset = "0x882BE0", VA = "0x1808841E0")]
		private void SelectMakeup(MakeupItem makeupItem)
		{
			int makeupItemID = makeupItem.MakeupItemID;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6003796")]
		[Cpp2IlInjected.Address(RVA = "0x8840D0", Offset = "0x882AD0", VA = "0x1808840D0")]
		[AsyncStateMachine(typeof(_003CSelectMakeupAsync_003Ed__24))]
		private Task SelectMakeupAsync(MakeupItem makeupItem)
		{
			int makeupItemID = makeupItem.MakeupItemID;
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003797")]
		[Cpp2IlInjected.Address(RVA = "0x883D40", Offset = "0x882740", VA = "0x180883D40")]
		private void RemoveMakeup(MakeupItemType makeupType)
		{
			//Discarded unreachable code: IL_000d
			_avatarCustomization.RemoveMakeup(makeupType);
		}

		[Cpp2IlInjected.Token(Token = "0x6003798")]
		[Cpp2IlInjected.Address(RVA = "0x884040", Offset = "0x882A40", VA = "0x180884040")]
		public void SelectFaceType(FacePartType facePartType, int index)
		{
			//Discarded unreachable code: IL_000e
			AvatarCustomization avatarCustomization = _avatarCustomization;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6003799")]
		[Cpp2IlInjected.Address(RVA = "0x8845A0", Offset = "0x882FA0", VA = "0x1808845A0")]
		private void SetSkinColor(int skinColorIndex)
		{
			//Discarded unreachable code: IL_0017
			AvatarCustomization avatarCustomization = _avatarCustomization;
			int forceSave = 0;
			avatarCustomization.SetSkinColor(skinColorIndex, (byte)forceSave != 0).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600379A")]
		[Cpp2IlInjected.Address(RVA = "0x884540", Offset = "0x882F40", VA = "0x180884540")]
		private void SetHairColor(int hairColorIndex)
		{
			//Discarded unreachable code: IL_0012
			AvatarCustomization avatarCustomization = _avatarCustomization;
			int forceSave = 0;
			avatarCustomization.SetHairColor(hairColorIndex, (byte)forceSave != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600379B")]
		[Cpp2IlInjected.Address(RVA = "0x884570", Offset = "0x882F70", VA = "0x180884570")]
		private void SetHighlightColor(int highlightColorIndex)
		{
			//Discarded unreachable code: IL_0012
			AvatarCustomization avatarCustomization = _avatarCustomization;
			int forceSave = 0;
			avatarCustomization.SetHairHightlightColor(highlightColorIndex, (byte)forceSave != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600379C")]
		[Cpp2IlInjected.Address(RVA = "0x8843B0", Offset = "0x882DB0", VA = "0x1808843B0")]
		private void SetEyeColor(int color)
		{
			//Discarded unreachable code: IL_0012
			AvatarCustomization avatarCustomization = _avatarCustomization;
			int forceSave = 0;
			avatarCustomization.SetEyeColor(color, (byte)forceSave != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600379D")]
		[Cpp2IlInjected.Address(RVA = "0x886100", Offset = "0x884B00", VA = "0x180886100")]
		private void Undo()
		{
			//Discarded unreachable code: IL_0011
			_avatarCustomization.Undo().FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600379E")]
		[Cpp2IlInjected.Address(RVA = "0x883BB0", Offset = "0x8825B0", VA = "0x180883BB0")]
		private void Redo()
		{
			//Discarded unreachable code: IL_0011
			_avatarCustomization.Redo().FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600379F")]
		[Cpp2IlInjected.Address(RVA = "0x883E70", Offset = "0x882870", VA = "0x180883E70")]
		private void Save()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60037A0")]
		[Cpp2IlInjected.Address(RVA = "0x883D70", Offset = "0x882770", VA = "0x180883D70")]
		[AsyncStateMachine(typeof(_003CSaveAsync_003Ed__34))]
		private Task SaveAsync()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60037A1")]
		[Cpp2IlInjected.Address(RVA = "0x882F20", Offset = "0x881920", VA = "0x180882F20")]
		[AsyncStateMachine(typeof(_003CBuyMakeup_003Ed__35))]
		private Task<bool> BuyMakeup()
		{
			int num = 0;
			int num2 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60037A2")]
		[Cpp2IlInjected.Address(RVA = "0x882DE0", Offset = "0x8817E0", VA = "0x180882DE0")]
		[AsyncStateMachine(typeof(_003CBuyClothes_003Ed__36))]
		private Task<bool> BuyClothes()
		{
			int num = 0;
			int num2 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60037A3")]
		[Cpp2IlInjected.Address(RVA = "0x883160", Offset = "0x881B60", VA = "0x180883160")]
		private void Cancel()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60037A4")]
		[Cpp2IlInjected.Address(RVA = "0x883060", Offset = "0x881A60", VA = "0x180883060")]
		[AsyncStateMachine(typeof(_003CCancelAsync_003Ed__38))]
		private Task CancelAsync()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60037A5")]
		[Cpp2IlInjected.Address(RVA = "0x883750", Offset = "0x882150", VA = "0x180883750")]
		private void NotifyMakeupColor(MakeupItem item)
		{
			//Discarded unreachable code: IL_007b
			//IL_001b: Expected O, but got I4
			int num = 0;
			WardrobeMenu menu = UiRoot.Instance._menuStack.GetMenu<WardrobeMenu>();
			int num2 = 0;
			if (menu != (UnityEngine.Object)num2)
			{
				AvatarCustomization avatarCustomization = _avatarCustomization;
				WardrobeAppearanceContent mcAppearanceContent = menu._mcAppearanceContent;
				int num3 = 0;
				WardrobeAppearanceContent mcAppearanceContent2 = menu._mcAppearanceContent;
				int num4 = default(int);
				if (num4 != -1)
				{
					AvatarCustomization avatarCustomization2 = _avatarCustomization;
					WardrobeAppearanceContent mcAppearanceContent3 = menu._mcAppearanceContent;
				}
				WardrobeAppearanceContent mcAppearanceContent4 = menu._mcAppearanceContent;
				int num5 = default(int);
				if (num5 != -1)
				{
					AvatarCustomization avatarCustomization3 = _avatarCustomization;
					WardrobeAppearanceContent mcAppearanceContent5 = menu._mcAppearanceContent;
				}
				AvatarCustomization avatarCustomization4 = _avatarCustomization;
				WardrobeAppearanceContent mcAppearanceContent6 = menu._mcAppearanceContent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037A6")]
		[Cpp2IlInjected.Address(RVA = "0x886340", Offset = "0x884D40", VA = "0x180886340")]
		public AvatarCustomizationMenu()
		{
		}
	}
}
