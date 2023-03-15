using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Furnitures;
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
	[Cpp2IlInjected.Token(Token = "0x2000925")]
	public class FurnitureDesignEditView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000926")]
		public delegate void Exit();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40035FA")]
		[SerializeField]
		private DecalEditView _decalView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40035FB")]
		[SerializeField]
		private ColorEditView _colorView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40035FC")]
		[SerializeField]
		private Button _backButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40035FD")]
		[SerializeField]
		private Button _editDecalsButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40035FE")]
		[SerializeField]
		private RectTransform _inputZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003601")]
		private FurnitureAppearance _furniture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003602")]
		private FurnitureCustomization _furnitureCustomization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003603")]
		private Task _startDesignMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003604")]
		private MoveGesture _move;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003605")]
		private OrbitCamera _orbitCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003606")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003607")]
		private HistoryStack<DesignWorkingCopy> _designHistory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003608")]
		private bool _constructed;

		[Cpp2IlInjected.Token(Token = "0x170007F3")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x40035FF")]
		public bool IsShown
		{
			[Cpp2IlInjected.Token(Token = "0x6003996")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003997")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000075")]
		public event Exit OnExit
		{
			[Cpp2IlInjected.Token(Token = "0x6003998")]
			[Cpp2IlInjected.Address(RVA = "0x16706E0", Offset = "0x166F0E0", VA = "0x1816706E0")]
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
			[Cpp2IlInjected.Token(Token = "0x6003999")]
			[Cpp2IlInjected.Address(RVA = "0x1670780", Offset = "0x166F180", VA = "0x181670780")]
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

		[Cpp2IlInjected.Token(Token = "0x600399A")]
		[Cpp2IlInjected.Address(RVA = "0x166F7F0", Offset = "0x166E1F0", VA = "0x18166F7F0")]
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
			ColorEditView.ColorChanged b = UpdateBaseColor;
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

		[Cpp2IlInjected.Token(Token = "0x600399B")]
		[Cpp2IlInjected.Address(RVA = "0x166FE40", Offset = "0x166E840", VA = "0x18166FE40")]
		public void Init(FurnitureAppearance furniture, FurnitureCustomization furnitureCustomization)
		{
			//Discarded unreachable code: IL_006e
			if (!_constructed)
			{
				Construct();
			}
			_furniture = furniture;
			_furnitureCustomization = furnitureCustomization;
			OrbitCameraConfig cameraConfig = _furniture.orbitCameraTarget.cameraConfig;
			MoveGesture move = _move;
			float num = (move.MaxForce = cameraConfig.moveMaxForce);
			OrbitCameraConfig cameraConfig2 = _furniture.orbitCameraTarget.cameraConfig;
			MoveGesture move2 = _move;
			float num2 = (move2.Friction = cameraConfig2.moveFriction);
		}

		[Cpp2IlInjected.Token(Token = "0x600399C")]
		[Cpp2IlInjected.Address(RVA = "0x166FDD0", Offset = "0x166E7D0", VA = "0x18166FDD0")]
		private void InitConfig()
		{
			//Discarded unreachable code: IL_0051
			OrbitCameraConfig cameraConfig = _furniture.orbitCameraTarget.cameraConfig;
			MoveGesture move = _move;
			float num = (move.MaxForce = cameraConfig.moveMaxForce);
			OrbitCameraConfig cameraConfig2 = _furniture.orbitCameraTarget.cameraConfig;
			MoveGesture move2 = _move;
			float num2 = (move2.Friction = cameraConfig2.moveFriction);
		}

		[Cpp2IlInjected.Token(Token = "0x600399D")]
		[Cpp2IlInjected.Address(RVA = "0x1670180", Offset = "0x166EB80", VA = "0x181670180")]
		public void Show(bool cloneDesign, bool canEditAll)
		{
			//Discarded unreachable code: IL_009e
			HistoryStack<DesignWorkingCopy> historyStack = (_designHistory = (HistoryStack<DesignWorkingCopy>)(object)new HistoryStack<T>((T)_furnitureCustomization.GetDesignWorkingCopy(cloneDesign)));
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
			FurnitureAppearance furniture = _furniture;
			OrbitCamera orbitCamera = _orbitCamera;
			Transform startCamera = furniture.orbitCameraTarget.startCamera;
			Transform lookAt = _furniture.orbitCameraTarget.lookAt;
			OrbitCameraTarget orbitCameraTarget = _furniture.orbitCameraTarget;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x600399E")]
		[Cpp2IlInjected.Address(RVA = "0x166FD80", Offset = "0x166E780", VA = "0x18166FD80")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0023
			_furnitureCustomization.StopDesignMode();
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			IsShown = false;
		}

		[Cpp2IlInjected.Token(Token = "0x600399F")]
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

		[Cpp2IlInjected.Token(Token = "0x60039A0")]
		[Cpp2IlInjected.Address(RVA = "0x1670450", Offset = "0x166EE50", VA = "0x181670450")]
		[AsyncStateMachine(typeof(_003CStartDesignModeAsync_003Ed__27))]
		private Task StartDesignModeAsync(bool forceEditAll)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60039A1")]
		[Cpp2IlInjected.Address(RVA = "0x166FC10", Offset = "0x166E610", VA = "0x18166FC10")]
		private void EditDecals()
		{
			//Discarded unreachable code: IL_0091
			GameObject gameObject = _editDecalsButton.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			Collider collider = _furnitureCustomization.StartEditingDecals();
			_colorView.Hide();
			((HistoryStack<T>)(object)_designHistory).Flush();
			Camera camera = _camera;
			DecalEditView decalView = _decalView;
			Transform transform = camera.transform;
			FurnitureAppearance furniture = _furniture;
			FurnitureHolder holder = furniture.holder;
			OrbitCameraConfig cameraConfig = furniture.orbitCameraTarget.cameraConfig;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			HistoryStack<DesignWorkingCopy> designHistory = _designHistory;
			float transitionDuration = cameraConfig.transitionDuration;
			IList<IDecal> _003CStaticDecals_003Ek__BackingField = holder.StaticDecals;
		}

		[Cpp2IlInjected.Token(Token = "0x60039A2")]
		[Cpp2IlInjected.Address(RVA = "0x1670560", Offset = "0x166EF60", VA = "0x181670560")]
		private void StartEditingDecals()
		{
			//Discarded unreachable code: IL_007a
			Collider collider = _furnitureCustomization.StartEditingDecals();
			_colorView.Hide();
			((HistoryStack<T>)(object)_designHistory).Flush();
			Camera camera = _camera;
			DecalEditView decalView = _decalView;
			Transform transform = camera.transform;
			FurnitureAppearance furniture = _furniture;
			FurnitureHolder holder = furniture.holder;
			OrbitCameraConfig cameraConfig = furniture.orbitCameraTarget.cameraConfig;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			HistoryStack<DesignWorkingCopy> designHistory = _designHistory;
			float transitionDuration = cameraConfig.transitionDuration;
			IList<IDecal> _003CStaticDecals_003Ek__BackingField = holder.StaticDecals;
		}

		[Cpp2IlInjected.Token(Token = "0x60039A3")]
		[Cpp2IlInjected.Address(RVA = "0x16706B0", Offset = "0x166F0B0", VA = "0x1816706B0")]
		private void UpdateBaseColor(Color color)
		{
			//Discarded unreachable code: IL_0008
			FurnitureAppearance furniture = _furniture;
		}

		[Cpp2IlInjected.Token(Token = "0x60039A4")]
		[Cpp2IlInjected.Address(RVA = "0x1670020", Offset = "0x166EA20", VA = "0x181670020")]
		private void SaveDesign(DesignWorkingCopy design)
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60039A5")]
		[Cpp2IlInjected.Address(RVA = "0x166FF00", Offset = "0x166E900", VA = "0x18166FF00")]
		[AsyncStateMachine(typeof(_003CSaveDesignAsync_003Ed__32))]
		private Task SaveDesignAsync(DesignWorkingCopy design)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60039A6")]
		[Cpp2IlInjected.Address(RVA = "0x166F620", Offset = "0x166E020", VA = "0x18166F620")]
		private void Back()
		{
			//Discarded unreachable code: IL_00be
			//IL_007d: Expected O, but got I4
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
			Transform lookAt = _furniture.orbitCameraTarget.lookAt;
			OrbitCameraTarget orbitCameraTarget = _furniture.orbitCameraTarget;
			int num = 0;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
			FurnitureCustomization furnitureCustomization = _furnitureCustomization;
			int num2 = 0;
			furnitureCustomization.StopEditingDecals((Action)num2);
			_decalView.Hide();
			((HistoryStack<T>)(object)_designHistory).Flush();
			ColorEditView colorView = _colorView;
			HistoryStack<DesignWorkingCopy> designHistory = _designHistory;
			colorView.Show((HistoryStack<>)(object)designHistory);
			_editDecalsButton.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60039A7")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FurnitureDesignEditView()
		{
		}
	}
}
