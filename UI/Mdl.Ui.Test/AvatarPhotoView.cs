using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Gestures;
using Mdl.Navigation;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x200090F")]
	public class AvatarPhotoView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000910")]
		public delegate void Exit();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400357C")]
		[SerializeField]
		private Button _backButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400357D")]
		[SerializeField]
		private RectTransform _inputZone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003580")]
		private AvatarAppearance _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003581")]
		private AvatarCustomization _avatarCustomization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003582")]
		private MoveGesture _move;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003583")]
		private OrbitCamera _orbitCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003584")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003585")]
		private bool _constructed;

		[Cpp2IlInjected.Token(Token = "0x170007E4")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400357E")]
		public bool IsShown
		{
			[Cpp2IlInjected.Token(Token = "0x60038E2")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60038E3")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400006F")]
		public event Exit OnExit
		{
			[Cpp2IlInjected.Token(Token = "0x60038E4")]
			[Cpp2IlInjected.Address(RVA = "0x88CAF0", Offset = "0x88B4F0", VA = "0x18088CAF0")]
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
			[Cpp2IlInjected.Token(Token = "0x60038E5")]
			[Cpp2IlInjected.Address(RVA = "0x88CB90", Offset = "0x88B590", VA = "0x18088CB90")]
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

		[Cpp2IlInjected.Token(Token = "0x60038E6")]
		[Cpp2IlInjected.Address(RVA = "0x88C490", Offset = "0x88AE90", VA = "0x18088C490")]
		private void Construct()
		{
			//Discarded unreachable code: IL_0078
			//IL_0041: Expected O, but got I4
			//IL_0060: Expected I4, but got I8
			//IL_0060: Expected O, but got I4
			Button.ButtonClickedEvent onClick = _backButton.m_OnClick;
			UnityAction call = Back;
			onClick.AddListener(call);
			Camera camera = (_camera = SystemRoot.Instance._playerCamera);
			int allowZoom = default(int);
			int num = default(int);
			OrbitCamera orbitCamera = new OrbitCamera(_camera, (OrbitCameraConfig)num, (byte)allowZoom != 0);
			allowZoom = 0;
			num = 0;
			_orbitCamera = orbitCamera;
			ulong num3 = default(ulong);
			int automaticRotation = default(int);
			int num2 = default(int);
			MoveGesture move = new MoveGesture(_inputZone, (Camera)num2, (byte)automaticRotation != 0, (byte)num3 != 0);
			automaticRotation = 0;
			num2 = 0;
			_move = move;
			_constructed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60038E7")]
		[Cpp2IlInjected.Address(RVA = "0x88C6E0", Offset = "0x88B0E0", VA = "0x18088C6E0")]
		public void Init(AvatarAppearance avatar, AvatarCustomization avatarCustomization)
		{
			//Discarded unreachable code: IL_00e7
			//IL_004a: Expected O, but got I4
			//IL_0069: Expected I4, but got I8
			//IL_0069: Expected O, but got I4
			if (!_constructed)
			{
				Button.ButtonClickedEvent onClick = _backButton.m_OnClick;
				UnityAction call = Back;
				onClick.AddListener(call);
				Camera camera = (_camera = SystemRoot.Instance._playerCamera);
				int allowZoom = default(int);
				int num = default(int);
				OrbitCamera orbitCamera = new OrbitCamera(_camera, (OrbitCameraConfig)num, (byte)allowZoom != 0);
				allowZoom = 0;
				num = 0;
				_orbitCamera = orbitCamera;
				ulong num3 = default(ulong);
				int automaticRotation = default(int);
				int num2 = default(int);
				MoveGesture move = new MoveGesture(_inputZone, (Camera)num2, (byte)automaticRotation != 0, (byte)num3 != 0);
				automaticRotation = 0;
				num2 = 0;
				_move = move;
				_constructed = true;
			}
			_avatar = avatar;
			_avatarCustomization = avatarCustomization;
			OrbitCameraConfig cameraConfig = _avatar.orbitCameraTarget.cameraConfig;
			MoveGesture move2 = _move;
			float num4 = (move2.MaxForce = cameraConfig.moveMaxForce);
			OrbitCameraConfig cameraConfig2 = _avatar.orbitCameraTarget.cameraConfig;
			MoveGesture move3 = _move;
			float num5 = (move3.Friction = cameraConfig2.moveFriction);
		}

		[Cpp2IlInjected.Token(Token = "0x60038E8")]
		[Cpp2IlInjected.Address(RVA = "0x88C670", Offset = "0x88B070", VA = "0x18088C670")]
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

		[Cpp2IlInjected.Token(Token = "0x60038E9")]
		[Cpp2IlInjected.Address(RVA = "0x88C960", Offset = "0x88B360", VA = "0x18088C960")]
		public void Show()
		{
			//Discarded unreachable code: IL_0061
			base.gameObject.SetActive(value: true);
			AvatarAppearance avatar = _avatar;
			OrbitCamera orbitCamera = _orbitCamera;
			IsShown = true;
			Transform startCamera = avatar.orbitCameraTarget.startCamera;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform lookAt = _avatar.orbitCameraTarget.lookAt;
			OrbitCameraTarget orbitCameraTarget = _avatar.orbitCameraTarget;
			int num = 0;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60038EA")]
		[Cpp2IlInjected.Address(RVA = "0x88BC40", Offset = "0x88A640", VA = "0x18088BC40")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0018
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			IsShown = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60038EB")]
		[Cpp2IlInjected.Address(RVA = "0x88CA90", Offset = "0x88B490", VA = "0x18088CA90")]
		public void UpdateState(float deltaTime)
		{
			//Discarded unreachable code: IL_0014
			_move.Update(deltaTime);
			OrbitCamera orbitCamera = _orbitCamera;
		}

		[Cpp2IlInjected.Token(Token = "0x60038EC")]
		[Cpp2IlInjected.Address(RVA = "0x88C470", Offset = "0x88AE70", VA = "0x18088C470")]
		private void Back()
		{
			this.OnExit?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60038ED")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public AvatarPhotoView()
		{
		}
	}
}
