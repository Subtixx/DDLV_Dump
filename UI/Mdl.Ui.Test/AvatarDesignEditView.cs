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
using Mdl.Utils;
using Meta.Customization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x20008DB")]
	public class AvatarDesignEditView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20008DC")]
		public delegate void Exit();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40034DB")]
		[SerializeField]
		private DecalEditView _decalView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40034DC")]
		[SerializeField]
		private ColorEditView _colorView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40034DD")]
		[SerializeField]
		private Button _backButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40034DE")]
		[SerializeField]
		private Button _editDecalsButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40034DF")]
		[SerializeField]
		private RectTransform _inputZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40034E2")]
		private AvatarAppearance _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40034E3")]
		private AvatarCustomization _avatarCustomization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40034E4")]
		private Task _startDesignMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40034E5")]
		private MoveGesture _move;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40034E6")]
		private OrbitCamera _orbitCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40034E7")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40034E8")]
		private HistoryStack<DesignWorkingCopy> _designHistory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40034E9")]
		private bool _constructed;

		[Cpp2IlInjected.Token(Token = "0x170007D6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x40034E0")]
		public bool IsShown
		{
			[Cpp2IlInjected.Token(Token = "0x60037B7")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60037B8")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000055")]
		public event Exit OnExit
		{
			[Cpp2IlInjected.Token(Token = "0x60037B9")]
			[Cpp2IlInjected.Address(RVA = "0x887600", Offset = "0x886000", VA = "0x180887600")]
			[CompilerGenerated]
			add
			{
				Exit onExit = this.OnExit;
				Delegate @delegate = Delegate.Combine(onExit, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onExit)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60037BA")]
			[Cpp2IlInjected.Address(RVA = "0x8876A0", Offset = "0x8860A0", VA = "0x1808876A0")]
			[CompilerGenerated]
			remove
			{
				Exit onExit = this.OnExit;
				Delegate @delegate = Delegate.Remove(onExit, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onExit)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037BB")]
		[Cpp2IlInjected.Address(RVA = "0x8865C0", Offset = "0x884FC0", VA = "0x1808865C0")]
		private void Construct()
		{
			//Discarded unreachable code: IL_016b
			//IL_007c: Expected O, but got I4
			//IL_00a0: Expected O, but got I4
			//IL_00f0: Expected O, but got I4
			GameObject gameObject = _decalView.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			Button.ButtonClickedEvent onClick = _backButton.m_OnClick;
			UnityAction call = Back;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _editDecalsButton.m_OnClick;
			UnityAction call2 = EditDecals;
			onClick2.AddListener(call2);
			Camera camera = (_camera = SystemRoot.Instance._playerCamera);
			int allowZoom = default(int);
			int num = default(int);
			OrbitCamera orbitCamera = new OrbitCamera(_camera, (OrbitCameraConfig)num, (byte)allowZoom != 0);
			int num2 = 0;
			allowZoom = 0;
			num = 0;
			_orbitCamera = orbitCamera;
			int automaticRotation = default(int);
			int num3 = default(int);
			MoveGesture move = new MoveGesture(_inputZone, (Camera)num3, (byte)automaticRotation != 0, (byte)num2 != 0);
			automaticRotation = 0;
			num3 = 0;
			_move = move;
			ColorEditView colorView = _colorView;
			ColorEditView.ColorChanged onColorChanged = colorView.OnColorChanged;
			ColorEditView.ColorChanged b = ApplyBaseColor;
			Delegate @delegate = Delegate.Combine(onColorChanged, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				colorView.OnColorChanged = (ColorEditView.ColorChanged)num2;
				ColorEditView colorView2 = _colorView;
				ColorEditView.SaveDesign onSaveDesign = colorView2.OnSaveDesign;
				ColorEditView.SaveDesign b2 = SaveDesign;
				Delegate delegate2 = Delegate.Combine(onSaveDesign, b2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					colorView2.OnSaveDesign = (ColorEditView.SaveDesign)delegate2;
					DecalEditView decalView = _decalView;
					DecalEditView.SaveDesign onSaveDesign2 = decalView.OnSaveDesign;
					DecalEditView.SaveDesign b3 = SaveDesign;
					Delegate delegate3 = Delegate.Combine(onSaveDesign2, b3);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						decalView.OnSaveDesign = (DecalEditView.SaveDesign)delegate3;
						return;
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037BC")]
		[Cpp2IlInjected.Address(RVA = "0x886CF0", Offset = "0x8856F0", VA = "0x180886CF0")]
		public void Init(AvatarAppearance avatar, AvatarCustomization avatarCustomization)
		{
			//Discarded unreachable code: IL_006e
			if (!_constructed)
			{
				Construct();
			}
			_avatar = avatar;
			_avatarCustomization = avatarCustomization;
			OrbitCameraConfig cameraConfig = _avatar.orbitCameraTarget.cameraConfig;
			MoveGesture move = _move;
			float num = (move.MaxForce = cameraConfig.moveMaxForce);
			OrbitCameraConfig cameraConfig2 = _avatar.orbitCameraTarget.cameraConfig;
			MoveGesture move2 = _move;
			float num2 = (move2.Friction = cameraConfig2.moveFriction);
		}

		[Cpp2IlInjected.Token(Token = "0x60037BD")]
		[Cpp2IlInjected.Address(RVA = "0x886C80", Offset = "0x885680", VA = "0x180886C80")]
		private void InitConfig()
		{
			//Discarded unreachable code: IL_0051
			OrbitCameraConfig cameraConfig = _avatar.orbitCameraTarget.cameraConfig;
			MoveGesture move = _move;
			float num = (move.MaxForce = cameraConfig.moveMaxForce);
			OrbitCameraConfig cameraConfig2 = _avatar.orbitCameraTarget.cameraConfig;
			MoveGesture move2 = _move;
			float num2 = (move2.Friction = cameraConfig2.moveFriction);
		}

		[Cpp2IlInjected.Token(Token = "0x60037BE")]
		[Cpp2IlInjected.Address(RVA = "0x887040", Offset = "0x885A40", VA = "0x180887040")]
		public void Show(ClothingItemType clothingType, bool cloneDesign, bool canEditAll)
		{
			//Discarded unreachable code: IL_009e
			HistoryStack<DesignWorkingCopy> historyStack = (_designHistory = (HistoryStack<DesignWorkingCopy>)(object)new HistoryStack<T>((T)_avatarCustomization.GetDesignWorkingCopy(cloneDesign)));
			base.gameObject.SetActive(value: true);
			ColorEditView colorView = _colorView;
			IsShown = true;
			colorView.Hide();
			Button editDecalsButton = _editDecalsButton;
			int num = ((editDecalsButton.interactable = false) ? 1 : 0);
			int num2 = 0;
			int num3 = 0;
			Task startDesignMode = default(Task);
			_startDesignMode = startDesignMode;
			AvatarAppearance avatar = _avatar;
			OrbitCamera orbitCamera = _orbitCamera;
			Transform startCamera = avatar.orbitCameraTarget.startCamera;
			Transform lookAt = _avatar.orbitCameraTarget.lookAt;
			OrbitCameraTarget orbitCameraTarget = _avatar.orbitCameraTarget;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60037BF")]
		[Cpp2IlInjected.Address(RVA = "0x886B80", Offset = "0x885580", VA = "0x180886B80")]
		[AsyncStateMachine(typeof(_003CHide_003Ed__25))]
		public Task Hide()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60037C0")]
		[Cpp2IlInjected.Address(RVA = "0x887550", Offset = "0x885F50", VA = "0x180887550")]
		public void UpdateState(float deltaTime)
		{
			//Discarded unreachable code: IL_0054
			Task startDesignMode = _startDesignMode;
			if ((startDesignMode == null || startDesignMode.IsCompleted || _startDesignMode.IsCanceled) && !_decalView.IsShown)
			{
				_move.Update(deltaTime);
				OrbitCamera orbitCamera = _orbitCamera;
				MoveGesture move = _move;
				orbitCamera.Move(deltaTime, move);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037C1")]
		[Cpp2IlInjected.Address(RVA = "0x887320", Offset = "0x885D20", VA = "0x180887320")]
		[AsyncStateMachine(typeof(_003CStartDesignModeAsync_003Ed__27))]
		private Task StartDesignModeAsync(ClothingItemType clothingType, bool forceEditAll)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60037C2")]
		[Cpp2IlInjected.Address(RVA = "0x8869E0", Offset = "0x8853E0", VA = "0x1808869E0")]
		private void EditDecals()
		{
			//Discarded unreachable code: IL_002b
			GameObject gameObject = _editDecalsButton.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			ClothingItemType _003CClothingType_003Ek__BackingField = _avatarCustomization.ClothingType;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60037C3")]
		[Cpp2IlInjected.Address(RVA = "0x887440", Offset = "0x885E40", VA = "0x180887440")]
		[AsyncStateMachine(typeof(_003CStartEditingDecals_003Ed__29))]
		private Task StartEditingDecals(ClothingItemType clothingType)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60037C4")]
		[Cpp2IlInjected.Address(RVA = "0x886350", Offset = "0x884D50", VA = "0x180886350")]
		private void ApplyBaseColor(Color color)
		{
			//Discarded unreachable code: IL_0015
			AvatarCustomization avatarCustomization = _avatarCustomization;
			AvatarAppearance avatar = _avatar;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60037C5")]
		[Cpp2IlInjected.Address(RVA = "0x886EE0", Offset = "0x8858E0", VA = "0x180886EE0")]
		private void SaveDesign(DesignWorkingCopy design)
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60037C6")]
		[Cpp2IlInjected.Address(RVA = "0x886DC0", Offset = "0x8857C0", VA = "0x180886DC0")]
		[AsyncStateMachine(typeof(_003CSaveDesignAsync_003Ed__32))]
		private Task SaveDesignAsync(DesignWorkingCopy design)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60037C7")]
		[Cpp2IlInjected.Address(RVA = "0x8863F0", Offset = "0x884DF0", VA = "0x1808863F0")]
		private void Back()
		{
			//Discarded unreachable code: IL_00b5
			if (!_decalView.IsShown)
			{
				this.OnExit?.Invoke();
				return;
			}
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
			_avatarCustomization.StopEditingDecals();
			_decalView.Hide();
			((HistoryStack<T>)(object)_designHistory).Flush();
			ColorEditView colorView = _colorView;
			HistoryStack<DesignWorkingCopy> designHistory = _designHistory;
			colorView.Show((HistoryStack<>)(object)designHistory);
			_editDecalsButton.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60037C8")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public AvatarDesignEditView()
		{
		}
	}
}
