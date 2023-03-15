using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Motion;
using Mdl.Navigation;
using Mdl.Social;
using Mdl.Ui.Photo;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000668")]
	[RequiredAllNotNull]
	public class FishingPhotoMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000669")]
		public class FishingPhotoMenuParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40023EF")]
			public Vector3 PositionTransition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40023F0")]
			public Quaternion RotationTransition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40023F1")]
			public float NearClippingTransition = 2.2f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40023F2")]
			public bool AutoPicture;

			[Cpp2IlInjected.Token(Token = "0x6002999")]
			[Cpp2IlInjected.Address(RVA = "0xC263F0", Offset = "0xC24DF0", VA = "0x180C263F0")]
			public FishingPhotoMenuParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40023E1")]
		[SerializeField]
		private PlayerNavigationConfig _playerConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40023E2")]
		[SerializeField]
		private Button _closeButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40023E3")]
		[SerializeField]
		private Button _btnTakePicture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40023E4")]
		[SerializeField]
		private BaseButton _btnSavePicture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40023E5")]
		[SerializeField]
		private BaseButton _btnSharePicture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40023E6")]
		[SerializeField]
		private Button _btnRetakePicture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40023E7")]
		public RawImage picture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40023E8")]
		public RectTransform frame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40023E9")]
		private bool _saved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
		[Cpp2IlInjected.Token(Token = "0x40023EA")]
		private bool _shared;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x40023EB")]
		private Vector3 _positionBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40023EC")]
		private Quaternion _rotationBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40023ED")]
		private float _nearClippingBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40023EE")]
		private FishingPhotoMenuParam _cameraParam;

		[Cpp2IlInjected.Token(Token = "0x6002985")]
		[Cpp2IlInjected.Address(RVA = "0x165E300", Offset = "0x165CD00", VA = "0x18165E300", Slot = "30")]
		protected unsafe override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_00bd
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _closeButton.m_OnClick;
			UnityAction call = Close;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnTakePicture.m_OnClick;
			UnityAction call2 = TakePicture;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnSavePicture.ButtonComponent.m_OnClick;
			UnityAction call3 = new UnityAction(this, (IntPtr)__ldftn(FishingPhotoMenu.SavePicture));
			onClick3.AddListener(call3);
			Button.ButtonClickedEvent onClick4 = _btnSharePicture.ButtonComponent.m_OnClick;
			UnityAction call4 = SharePicture;
			onClick4.AddListener(call4);
			Button.ButtonClickedEvent onClick5 = _btnRetakePicture.m_OnClick;
			UnityAction call5 = ResetState;
			onClick5.AddListener(call5);
		}

		[Cpp2IlInjected.Token(Token = "0x6002986")]
		[Cpp2IlInjected.Address(RVA = "0x165F100", Offset = "0x165DB00", VA = "0x18165F100", Slot = "31")]
		protected unsafe override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_00bd
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _closeButton.m_OnClick;
			UnityAction call = Close;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnTakePicture.m_OnClick;
			UnityAction call2 = TakePicture;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnSavePicture.ButtonComponent.m_OnClick;
			UnityAction call3 = new UnityAction(this, (IntPtr)__ldftn(FishingPhotoMenu.SavePicture));
			onClick3.RemoveListener(call3);
			Button.ButtonClickedEvent onClick4 = _btnSharePicture.ButtonComponent.m_OnClick;
			UnityAction call4 = SharePicture;
			onClick4.RemoveListener(call4);
			Button.ButtonClickedEvent onClick5 = _btnRetakePicture.m_OnClick;
			UnityAction call5 = ResetState;
			onClick5.RemoveListener(call5);
		}

		[Cpp2IlInjected.Token(Token = "0x6002987")]
		[Cpp2IlInjected.Address(RVA = "0x165EC10", Offset = "0x165D610", VA = "0x18165EC10")]
		private void Start()
		{
			//Discarded unreachable code: IL_002c
			RectTransform rectTransform = frame;
			RectTransform rectTransform2 = frame;
			RectTransform rectTransform3 = frame;
			RectTransform rectTransform4 = frame;
			RectTransform component = picture.GetComponent<RectTransform>();
		}

		[Cpp2IlInjected.Token(Token = "0x6002988")]
		[Cpp2IlInjected.Address(RVA = "0x165DD10", Offset = "0x165C710", VA = "0x18165DD10", Slot = "27")]
		public override void OnFocusIn()
		{
			base.OnFocusIn();
			MenuParam menuParam = _menuParam;
			if (menuParam != null)
			{
				int num = 0;
				int num2 = 0;
				if (menuParam != null)
				{
					_cameraParam = (FishingPhotoMenuParam)menuParam;
					CancellationToken cancellationToken = base.CancellationToken;
					int num3 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
					int num4 = 0;
					Camera main = Camera.main;
					Action<Texture2D> action = (Action<Texture2D>)(object)(Action<T>)delegate(Texture2D result)
					{
						//Discarded unreachable code: IL_00ed
						//IL_00a6: Expected O, but got I4
						//IL_00a6: Expected O, but got I4
						//IL_00ec: Expected O, but got I4
						//IL_00ec: Expected O, but got I4
						//IL_00ec: Expected O, but got I4
						picture.texture = result;
						picture.gameObject.SetActive(value: true);
						GameObject gameObject = _btnTakePicture.gameObject;
						int active = 0;
						gameObject.SetActive((byte)active != 0);
						GameObject gameObject2 = _btnSavePicture.gameObject;
						int num5 = 0;
						bool isSavingScreenshotToSystemSupported = PhotoView.IsSavingScreenshotToSystemSupported;
						gameObject2.SetActive(isSavingScreenshotToSystemSupported);
						_btnSharePicture.gameObject.SetActive(value: true);
						_btnRetakePicture.gameObject.SetActive(value: true);
						int num6 = 0;
						UiRoot instance = UiRoot.Instance;
						int useKeyboardAsController = 0;
						bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
						int num7 = 0;
						if (flag)
						{
							if ((object)GetComponentInParent<MenuNavigation>() != null)
							{
							}
							int num8 = 0;
							if ((UnityEngine.Object)num7 != (UnityEngine.Object)num8)
							{
								FocusNavigationElement component = _btnRetakePicture.GetComponent<FocusNavigationElement>();
							}
						}
						int num9 = 0;
						FadeEffect fadeEffect = UiRoot.Instance._fadeEffect;
						int num10 = 0;
						int num11 = 0;
						int num12 = 0;
						EasingFunction easingFunction = EasingUtil.EasingFunction(EasingType.QuadEaseOut);
						fadeEffect.Fade(1f, (Color)num10, (Color)num12, easingFunction, (byte)num7 != 0, (Tween<>.FinishEventHandler)num7);
					};
					IEnumerator routine = PhotoUtil.TakeSquareScreenCapture(main, (Action<>)(object)action);
					Coroutine coroutine = StartCoroutine(routine);
				}
			}
			base.IsDataUpToDate = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6002989")]
		[Cpp2IlInjected.Address(RVA = "0x165D850", Offset = "0x165C250", VA = "0x18165D850")]
		[AsyncStateMachine(typeof(_003CAnimateCamera_003Ed__19))]
		private Task AnimateCamera(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600298A")]
		[Cpp2IlInjected.Address(RVA = "0x165ED40", Offset = "0x165D740", VA = "0x18165ED40")]
		private void TakePicture()
		{
			int num = 0;
			Camera main = Camera.main;
			Action<Texture2D> action = (Action<Texture2D>)(object)(Action<T>)delegate(Texture2D result)
			{
				//Discarded unreachable code: IL_00ed
				//IL_00a6: Expected O, but got I4
				//IL_00a6: Expected O, but got I4
				//IL_00ec: Expected O, but got I4
				//IL_00ec: Expected O, but got I4
				//IL_00ec: Expected O, but got I4
				picture.texture = result;
				picture.gameObject.SetActive(value: true);
				GameObject gameObject = _btnTakePicture.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				GameObject gameObject2 = _btnSavePicture.gameObject;
				int num2 = 0;
				bool isSavingScreenshotToSystemSupported = PhotoView.IsSavingScreenshotToSystemSupported;
				gameObject2.SetActive(isSavingScreenshotToSystemSupported);
				_btnSharePicture.gameObject.SetActive(value: true);
				_btnRetakePicture.gameObject.SetActive(value: true);
				int num3 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
				int num4 = 0;
				if (flag)
				{
					if ((object)GetComponentInParent<MenuNavigation>() != null)
					{
					}
					int num5 = 0;
					if ((UnityEngine.Object)num4 != (UnityEngine.Object)num5)
					{
						FocusNavigationElement component = _btnRetakePicture.GetComponent<FocusNavigationElement>();
					}
				}
				int num6 = 0;
				FadeEffect fadeEffect = UiRoot.Instance._fadeEffect;
				int num7 = 0;
				int num8 = 0;
				int num9 = 0;
				EasingFunction easingFunction = EasingUtil.EasingFunction(EasingType.QuadEaseOut);
				fadeEffect.Fade(1f, (Color)num7, (Color)num9, easingFunction, (byte)num4 != 0, (Tween<>.FinishEventHandler)num4);
			};
			IEnumerator routine = PhotoUtil.TakeSquareScreenCapture(main, (Action<>)(object)action);
			Coroutine coroutine = StartCoroutine(routine);
		}

		[Cpp2IlInjected.Token(Token = "0x600298B")]
		[Cpp2IlInjected.Address(RVA = "0x165EA70", Offset = "0x165D470", VA = "0x18165EA70")]
		private void ShowConfirmationPrompt(Texture2D texture, bool share)
		{
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600298C")]
		[Cpp2IlInjected.Address(RVA = "0x165DFE0", Offset = "0x165C9E0", VA = "0x18165DFE0")]
		[AsyncStateMachine(typeof(_003COnSendPictureTask_003Ed__22))]
		private Task OnSendPictureTask(Texture2D texture, bool share, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600298D")]
		[Cpp2IlInjected.Address(RVA = "0x165E7C0", Offset = "0x165D1C0", VA = "0x18165E7C0")]
		private void SavePicture(Texture2D picture, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0087
			//IL_003a: Expected O, but got I4
			//IL_0064: Expected I4, but got I8
			byte[] mediaBytes = picture.EncodeToJPG();
			int num = 0;
			DateTime now = DateTime.Now;
			CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("en-US");
			string text = default(string);
			string filename = text + ".jpg";
			int num2 = 0;
			if (NativeGallery.SaveImageToGallery(mediaBytes, "Disney Superstar", filename, (NativeGallery.MediaSaveCallback)num2) != NativeGallery.Permission.Granted)
			{
				int num3 = 0;
				GenericAlert genericAlert = UiRoot.Instance._genericAlert;
				int showCloseButton = 0;
				ulong num4 = default(ulong);
				genericAlert.Alert("menu.save_picture_premission_denied", "", (byte)showCloseButton != 0, (byte)num4 != 0);
				return;
			}
			int num5 = 0;
			if ((_shared ? 1 : 0) == num5)
			{
				_saved = true;
				RefreshButtons();
			}
			else
			{
				Close();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600298E")]
		[Cpp2IlInjected.Address(RVA = "0x165F340", Offset = "0x165DD40", VA = "0x18165F340")]
		[AsyncStateMachine(typeof(_003CsendToPlayfab_003Ed__24))]
		private Task sendToPlayfab(Texture2D picture, [System.Runtime.InteropServices.Optional] CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600298F")]
		[Cpp2IlInjected.Address(RVA = "0x165E130", Offset = "0x165CB30", VA = "0x18165E130")]
		private void RefreshButtons()
		{
			//Discarded unreachable code: IL_008a
			Image image = _btnSavePicture.BackgroundSpriteAtlas.Image;
			if (_saved)
			{
				int num = 0;
			}
			Color white = Color.white;
			Image image2 = _btnSharePicture.BackgroundSpriteAtlas.Image;
			if (_shared)
			{
				int num2 = 0;
			}
			Color white2 = Color.white;
			Button buttonComponent = _btnSavePicture.ButtonComponent;
			bool flag2 = (buttonComponent.interactable = !_saved);
			Button buttonComponent2 = _btnSharePicture.ButtonComponent;
			bool flag4 = (buttonComponent2.interactable = !_shared);
		}

		[Cpp2IlInjected.Token(Token = "0x6002990")]
		[Cpp2IlInjected.Address(RVA = "0x165E540", Offset = "0x165CF40", VA = "0x18165E540")]
		private void ResetState()
		{
			//Discarded unreachable code: IL_00fc
			//IL_007a: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_00eb: Expected O, but got I4
			//IL_00eb: Expected O, but got I4
			_saved = false;
			RefreshButtons();
			_btnTakePicture.gameObject.SetActive(value: true);
			GameObject gameObject = _btnSavePicture.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _btnSharePicture.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			GameObject gameObject3 = _btnRetakePicture.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			Texture texture = picture.m_Texture;
			int num = 0;
			if (texture != (UnityEngine.Object)num)
			{
				UnityEngine.Object.Destroy(picture.m_Texture);
				RawImage rawImage = picture;
				int num2 = 0;
				rawImage.texture = (Texture)num2;
			}
			GameObject gameObject4 = picture.gameObject;
			int active4 = 0;
			gameObject4.SetActive((byte)active4 != 0);
			int num3 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				if ((object)GetComponentInParent<MenuNavigation>() != null)
				{
				}
				int num4 = 0;
				int num5 = 0;
				if ((UnityEngine.Object)num4 != (UnityEngine.Object)num5)
				{
					FocusNavigationElement component = _btnTakePicture.GetComponent<FocusNavigationElement>();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002991")]
		[Cpp2IlInjected.Address(RVA = "0x165D970", Offset = "0x165C370", VA = "0x18165D970")]
		private void Close()
		{
			FishingPhotoMenuParam cameraParam = _cameraParam;
			if (cameraParam != null && !cameraParam.AutoPicture)
			{
				ResetState();
				CancellationToken cancellationToken = base.CancellationToken;
				int num = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
			else
			{
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002992")]
		[Cpp2IlInjected.Address(RVA = "0x165D730", Offset = "0x165C130", VA = "0x18165D730")]
		[AsyncStateMachine(typeof(_003CAnimateCameraOriginalPosition_003Ed__28))]
		private Task AnimateCameraOriginalPosition(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002993")]
		[Cpp2IlInjected.Address(RVA = "0x165E990", Offset = "0x165D390", VA = "0x18165E990")]
		private void SavePicture()
		{
			//Discarded unreachable code: IL_001d
			//IL_001c: Expected O, but got I4
			Texture texture = picture.m_Texture;
			int num = 0;
			if ((object)texture != null)
			{
			}
			int share = 0;
			ShowConfirmationPrompt((Texture2D)num, (byte)share != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002994")]
		[Cpp2IlInjected.Address(RVA = "0x165EA00", Offset = "0x165D400", VA = "0x18165EA00")]
		private void SharePicture()
		{
			//Discarded unreachable code: IL_001b
			//IL_001a: Expected O, but got I4
			Texture texture = picture.m_Texture;
			int num = 0;
			if ((object)texture != null)
			{
			}
			ShowConfirmationPrompt((Texture2D)num, share: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6002995")]
		[Cpp2IlInjected.Address(RVA = "0x165DB30", Offset = "0x165C530", VA = "0x18165DB30", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//IL_0034: Expected O, but got I4
			//IL_0034: Expected O, but got I4
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				return;
			}
			MenuNavigation component = GetComponent<MenuNavigation>();
			int num2 = 0;
			if ((object)component != null)
			{
			}
			int num3 = 0;
			if (!((UnityEngine.Object)num2 != (UnityEngine.Object)num3))
			{
				return;
			}
			if (num3 != 0)
			{
				int num4 = 0;
				GameObject gameObject = default(GameObject);
				if (num3 != 0 && gameObject.activeSelf)
				{
					return;
				}
			}
			if (!_btnTakePicture.gameObject.activeSelf)
			{
				if (_btnRetakePicture.gameObject.activeSelf)
				{
					FocusNavigationElement component2 = _btnRetakePicture.GetComponent<FocusNavigationElement>();
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002996")]
		[Cpp2IlInjected.Address(RVA = "0x165DB20", Offset = "0x165C520", VA = "0x18165DB20", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			if (redirectionType == RedirectionType.MenuNavGoBackward)
			{
				Close();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002997")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public FishingPhotoMenu()
		{
		}
	}
}
