using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Graphic;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Customization;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000414")]
	[RequiredAllNotNull]
	public class DecalMenu : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000415")]
		public class DecalMenuParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001479")]
			public IItemData itemData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400147A")]
			public AvatarAppearance Avatar;

			[Cpp2IlInjected.Token(Token = "0x6001A92")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public DecalMenuParam()
			{
				((AsymmetricKeyExchangeFormatter)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001470")]
		private DecalMenuParam _decalMenuParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001471")]
		private bool _startNew;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001472")]
		private Mdl.Avatar.AvatarCustomization _avatarCustomization;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001473")]
		private AvatarAppearance _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001474")]
		private OrbitCamera _orbitCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001475")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001476")]
		[SerializeField]
		private DecalEditContent _designEditView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001477")]
		[SerializeField]
		private AsyncMenu shoppingCartPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001478")]
		private HistoryStack<DesignWorkingCopy> _designHistory;

		[Cpp2IlInjected.Token(Token = "0x6001A80")]
		[Cpp2IlInjected.Address(RVA = "0x12B6A40", Offset = "0x12B5440", VA = "0x1812B6A40", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//IL_003c: Expected O, but got I4
			((object)this)._002Ector();
			DecalEditContent designEditView = _designEditView;
			DecalEditContent.SaveDesign onSaveDesign = designEditView.OnSaveDesign;
			DecalEditContent.SaveDesign b = SaveDesign;
			Delegate @delegate = Delegate.Combine(onSaveDesign, b);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				designEditView.OnSaveDesign = (DecalEditContent.SaveDesign)num;
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A81")]
		[Cpp2IlInjected.Address(RVA = "0x12B7260", Offset = "0x12B5C60", VA = "0x1812B7260", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//IL_003c: Expected O, but got I4
			base.UnregisterFocusedListeners();
			DecalEditContent designEditView = _designEditView;
			DecalEditContent.SaveDesign onSaveDesign = designEditView.OnSaveDesign;
			DecalEditContent.SaveDesign value = SaveDesign;
			Delegate @delegate = Delegate.Remove(onSaveDesign, value);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				designEditView.OnSaveDesign = (DecalEditContent.SaveDesign)num;
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A82")]
		[Cpp2IlInjected.Address(RVA = "0x12B6420", Offset = "0x12B4E20", VA = "0x1812B6420", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//IL_0028: Expected O, but got I4
			base.OnPush(stack, param);
			Camera camera = (_camera = SystemRoot.Instance._playerCamera);
			int allowZoom = default(int);
			int num = default(int);
			OrbitCamera orbitCamera = new OrbitCamera(_camera, (OrbitCameraConfig)num, (byte)allowZoom != 0);
			int num2 = 0;
			allowZoom = 0;
			num = 0;
			_orbitCamera = orbitCamera;
			if (param != null)
			{
				int num3 = 0;
				if (param != null)
				{
					_decalMenuParam = (DecalMenuParam)param;
					if ((IntPtr)_decalMenuParam.itemData == (IntPtr)num2)
					{
						_startNew = true;
					}
					int num4 = 0;
					int num5 = 0;
					_avatar = (AvatarAppearance)(object)param;
				}
			}
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			AvatarCustomizationSystemData avatarCustomizationSystemData = new AvatarCustomizationSystemData();
			avatarCustomizationSystemData.SkipLoadAvatarAppearance = true;
			Mdl.Avatar.AvatarCustomization avatarCustomization = (_avatarCustomization = _003CInstance_003Ek__BackingField.StartSystem<Mdl.Avatar.AvatarCustomization>(avatarCustomizationSystemData));
			DecalEditContent designEditView = _designEditView;
			Mdl.Avatar.AvatarCustomization avatarCustomization2 = (designEditView.AvatarCustomization = _avatarCustomization);
			DecalEditContent designEditView2 = _designEditView;
			AvatarAppearance avatarAppearance = (designEditView2.Avatar = _avatar);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A83")]
		[Cpp2IlInjected.Address(RVA = "0x12B6280", Offset = "0x12B4C80", VA = "0x1812B6280", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_004e
			base.OnFocusIn();
			if ((long)_decalMenuParam.itemData != 0)
			{
				IItemData itemData = _decalMenuParam.itemData;
				IItemData itemData2 = _decalMenuParam.itemData;
				StartEdit(itemData2);
				base.IsDataUpToDate = true;
			}
			int num = 0;
			UiRoot.Instance.MenuSectionChange("ToMDecoScreen");
		}

		[Cpp2IlInjected.Token(Token = "0x6001A84")]
		[Cpp2IlInjected.Address(RVA = "0x12B63C0", Offset = "0x12B4DC0", VA = "0x1812B63C0", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_0012
			base.OnPop();
			PostProcessManager.Instance.SetDof(DOFDistance.DEFAULT);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A85")]
		[Cpp2IlInjected.Address(RVA = "0x12B6B30", Offset = "0x12B5530", VA = "0x1812B6B30")]
		[AsyncStateMachine(typeof(_003CSaveDesignAsync_003Ed__15))]
		private Task SaveDesignAsync(DesignWorkingCopy design, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A86")]
		[Cpp2IlInjected.Address(RVA = "0x12B6E00", Offset = "0x12B5800", VA = "0x1812B6E00")]
		public void SetFocus()
		{
			//Discarded unreachable code: IL_000c
			_designEditView.SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A87")]
		[Cpp2IlInjected.Address(RVA = "0x12B6050", Offset = "0x12B4A50", VA = "0x1812B6050")]
		private void OnExitClickHandler()
		{
			//Discarded unreachable code: IL_00ae
			if (_designEditView.IsShown)
			{
				Camera camera = _camera;
				OrbitCamera orbitCamera = _orbitCamera;
				Transform transform = camera.transform;
				UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
				float z = vector.z;
				Transform lookAt = _avatar.orbitCameraTarget.lookAt;
				OrbitCameraTarget orbitCameraTarget = _avatar.orbitCameraTarget;
				int num = 0;
				UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
				float z2 = vector2.z;
				_designEditView.CancelBeforeExit();
				_avatarCustomization.StopEditingDecals();
				_avatarCustomization.ZoomOut();
				_designEditView.Hide();
				_avatarCustomization.StopDesignMode().FireAndForgetTask();
			}
			PostProcessManager.Instance.SetDof(DOFDistance.MID);
			bool isStaticMenu = ((IMenu)this).IsStaticMenu;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A88")]
		[Cpp2IlInjected.Address(RVA = "0x12B67A0", Offset = "0x12B51A0", VA = "0x1812B67A0")]
		private void OnSelectBaseHandler(IItemData selectedItem)
		{
			//Discarded unreachable code: IL_0026
			ProfilePlayer player_ = SystemRoot.Instance.Client.Profile.player_;
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A89")]
		[Cpp2IlInjected.Address(RVA = "0x12B5E10", Offset = "0x12B4810", VA = "0x1812B5E10")]
		[AsyncStateMachine(typeof(_003CBuyMissingClothes_003Ed__19))]
		private Task BuyMissingClothes(IItemData selectedItem, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A8A")]
		[Cpp2IlInjected.Address(RVA = "0x12B6F70", Offset = "0x12B5970", VA = "0x1812B6F70")]
		private void StartEdit(IItemData selectedItem)
		{
			//Discarded unreachable code: IL_001e
			AvatarAppearance avatar = _avatar;
			bool flag = default(bool);
			if (flag)
			{
				CancellationToken cancellationToken = base.CancellationToken;
				int num = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A8B")]
		[Cpp2IlInjected.Address(RVA = "0x12B6E30", Offset = "0x12B5830", VA = "0x1812B6E30")]
		[AsyncStateMachine(typeof(_003CStartEditDecal_003Ed__21))]
		private Task StartEditDecal(ClothingItemType type, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A8C")]
		[Cpp2IlInjected.Address(RVA = "0x12B7150", Offset = "0x12B5B50", VA = "0x1812B7150")]
		[AsyncStateMachine(typeof(_003CStartEditingDecals_003Ed__22))]
		private Task StartEditingDecals(ClothingItemType clothingType)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A8D")]
		[Cpp2IlInjected.Address(RVA = "0x12B6C70", Offset = "0x12B5670", VA = "0x1812B6C70")]
		private void SaveDesign(DesignWorkingCopy design)
		{
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A8E")]
		[Cpp2IlInjected.Address(RVA = "0x12B7350", Offset = "0x12B5D50", VA = "0x1812B7350")]
		private void Update()
		{
			//Discarded unreachable code: IL_0021
			DecalEditContent designEditView = _designEditView;
			if (designEditView.IsShown)
			{
				int num = 0;
				float deltaTime = Time.deltaTime;
				designEditView.UpdateState(deltaTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A8F")]
		[Cpp2IlInjected.Address(RVA = "0x12B5F40", Offset = "0x12B4940", VA = "0x1812B5F40", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0016, IL_0045
			DecalEditContent designEditView;
			do
			{
				if (redirectionType == RedirectionType.ToFilter)
				{
					bool flag = _designEditView.HandleRedirection(redirectionType);
					return;
				}
				while (redirectionType != RedirectionType.MenuNavGoBackward)
				{
				}
				designEditView = _designEditView;
			}
			while (designEditView.IsShown && designEditView.HandleRedirection(redirectionType));
			_designEditView.OnSaveClickHandler();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A90")]
		[Cpp2IlInjected.Address(RVA = "0x12B5FC0", Offset = "0x12B49C0", VA = "0x1812B5FC0", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0057
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				_designEditView.SetFocus();
			}
			DecalEditContent designEditView = _designEditView;
			if (designEditView.IsShown)
			{
				int num2 = 0;
				UiRoot instance2 = UiRoot.Instance;
				int useKeyboardAsController2 = 0;
				bool isControllerConnected = instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0);
				designEditView.ToggleDeleteLayerBtn(isControllerConnected);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A91")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public DecalMenu()
		{
		}
	}
}
