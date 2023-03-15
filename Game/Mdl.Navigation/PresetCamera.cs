using Cpp2IlInjected;
using Mdl.Gestures;
using Mdl.Motion;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C3C")]
	internal class PresetCamera
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400444F")]
		private CameraNavigationConfig _config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004450")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004451")]
		private Transform _target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004452")]
		private Vector3 _currentOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4004453")]
		private Quaternion _currentRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4004454")]
		private int _currentIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004455")]
		private Tween<Vector3> _offsetTween;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4004456")]
		private Tween<Quaternion> _rotationTween;

		[Cpp2IlInjected.Token(Token = "0x6003804")]
		[Cpp2IlInjected.Address(RVA = "0xCB77E0", Offset = "0xCB61E0", VA = "0x180CB77E0")]
		public void Init(Camera camera, Transform target, CameraNavigationConfig config)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003805")]
		[Cpp2IlInjected.Address(RVA = "0xCB79F0", Offset = "0xCB63F0", VA = "0x180CB79F0")]
		public void Move(float deltaTime, MoveGesture move)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003806")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PresetCamera()
		{
		}
	}
}
