using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Motion;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Cameras
{
	[Cpp2IlInjected.Token(Token = "0x2000937")]
	public class TemporaryCameraTransition : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003332")]
		private CountedBool temporaryTransitionInProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003333")]
		private CountedBool isCameraAnimating;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003334")]
		private Quaternion cameraAngleOnPause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003335")]
		private Vector3 cameraPositionOnPause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003336")]
		private Tween<Vector3> cameraPositionTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003337")]
		private Tween<Quaternion> cameraRotationTransition;

		[Cpp2IlInjected.Token(Token = "0x1700060D")]
		private Transform playerCameraTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6002A5A")]
			[Cpp2IlInjected.Address(RVA = "0xCBB870", Offset = "0xCBA270", VA = "0x180CBB870")]
			get
			{
				return base.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700060E")]
		public bool IsTransitionAnimating
		{
			[Cpp2IlInjected.Token(Token = "0x6002A5F")]
			[Cpp2IlInjected.Address(RVA = "0x1070840", Offset = "0x106F240", VA = "0x181070840")]
			get
			{
				return isCameraAnimating;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700060F")]
		public bool IsTemporaryTransitionActive
		{
			[Cpp2IlInjected.Token(Token = "0x6002A60")]
			[Cpp2IlInjected.Address(RVA = "0x1070830", Offset = "0x106F230", VA = "0x181070830")]
			get
			{
				return temporaryTransitionInProgress;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000060")]
		public event Action OnStartCameraTransition
		{
			[Cpp2IlInjected.Token(Token = "0x6002A5B")]
			[Cpp2IlInjected.Address(RVA = "0x1070790", Offset = "0x106F190", VA = "0x181070790")]
			[CompilerGenerated]
			add
			{
				Action onStartCameraTransition = this.OnStartCameraTransition;
				Delegate @delegate = Delegate.Combine(onStartCameraTransition, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onStartCameraTransition)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002A5C")]
			[Cpp2IlInjected.Address(RVA = "0x10708F0", Offset = "0x106F2F0", VA = "0x1810708F0")]
			[CompilerGenerated]
			remove
			{
				Action onStartCameraTransition = this.OnStartCameraTransition;
				Delegate @delegate = Delegate.Remove(onStartCameraTransition, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onStartCameraTransition)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000061")]
		public event Action OnEndCameraTransition
		{
			[Cpp2IlInjected.Token(Token = "0x6002A5D")]
			[Cpp2IlInjected.Address(RVA = "0x10706F0", Offset = "0x106F0F0", VA = "0x1810706F0")]
			[CompilerGenerated]
			add
			{
				Action onEndCameraTransition = this.OnEndCameraTransition;
				Delegate @delegate = Delegate.Combine(onEndCameraTransition, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onEndCameraTransition)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002A5E")]
			[Cpp2IlInjected.Address(RVA = "0x1070850", Offset = "0x106F250", VA = "0x181070850")]
			[CompilerGenerated]
			remove
			{
				Action onEndCameraTransition = this.OnEndCameraTransition;
				Delegate @delegate = Delegate.Remove(onEndCameraTransition, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onEndCameraTransition)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A61")]
		[Cpp2IlInjected.Address(RVA = "0x1070420", Offset = "0x106EE20", VA = "0x181070420")]
		public unsafe void StartTransition(bool force = false)
		{
			//Discarded unreachable code: IL_0032
			//IL_002c: Expected native int or pointer, but got O
			if (temporaryTransitionInProgress.AddReference() == CountedBool.RefState.FirstReference)
			{
				Transform transform = base.transform;
				Transform transform2 = base.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				((Vector3*)(IntPtr)cameraPositionOnPause)->z = z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A62")]
		[Cpp2IlInjected.Address(RVA = "0x10701A0", Offset = "0x106EBA0", VA = "0x1810701A0")]
		public void EndTransition(float transitionDuration)
		{
			//Discarded unreachable code: IL_00d2
			//IL_0052: Expected O, but got I8
			//IL_0096: Expected O, but got I8
			if (temporaryTransitionInProgress.ReleaseReference() != CountedBool.RefState.LastReference)
			{
				return;
			}
			Transform transform = base.transform;
			float z = cameraPositionOnPause.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			bool flag = default(bool);
			if (!flag)
			{
				Tween<Vector3> tween = cameraPositionTransition;
				if (tween != null)
				{
					int reverse = 0;
					((Tween<T>)(object)tween).Cancel((byte)reverse != 0);
				}
				cameraPositionTransition = (Tween<Vector3>)0;
			}
			float z3 = cameraPositionOnPause.z;
			Transform transform2 = base.transform;
			Quaternion quaternion = cameraAngleOnPause;
			bool flag2 = default(bool);
			if (!flag2)
			{
				Tween<Quaternion> tween2 = cameraRotationTransition;
				if (tween2 != null)
				{
					int reverse2 = 0;
					((Tween<T>)(object)tween2).Cancel((byte)reverse2 != 0);
				}
				cameraRotationTransition = (Tween<Quaternion>)0;
			}
			Quaternion desiredAngle = cameraAngleOnPause;
			DoCameraRotationTransition(desiredAngle, transitionDuration);
			if ((long)cameraPositionTransition == 0 && (long)cameraRotationTransition == 0)
			{
				this.OnEndCameraTransition?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A63")]
		[Cpp2IlInjected.Address(RVA = "0x1070070", Offset = "0x106EA70", VA = "0x181070070")]
		[AsyncStateMachine(typeof(_003CEndTransitionAndWait_003Ed__20))]
		public Task EndTransitionAndWait(float transitionDuration, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A64")]
		[Cpp2IlInjected.Address(RVA = "0x1070570", Offset = "0x106EF70", VA = "0x181070570")]
		private void Update()
		{
			//IL_0029: Expected O, but got I8
			//IL_004f: Expected O, but got I8
			int num = 0;
			float deltaTime = Time.deltaTime;
			Tween<Vector3> tween = cameraPositionTransition;
			if (tween != null)
			{
				int reverse = 0;
				if (!((Tween<T>)(object)tween).Play(deltaTime, (byte)reverse != 0))
				{
					cameraPositionTransition = (Tween<Vector3>)0;
				}
			}
			Tween<Quaternion> tween2 = cameraRotationTransition;
			if (tween2 != null)
			{
				int reverse2 = 0;
				if (!((Tween<T>)(object)tween2).Play(deltaTime, (byte)reverse2 != 0))
				{
					cameraRotationTransition = (Tween<Quaternion>)0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A65")]
		[Cpp2IlInjected.Address(RVA = "0x106F9B0", Offset = "0x106E3B0", VA = "0x18106F9B0")]
		private unsafe void DoCameraPositionTransition(Vector3 desiredPosition, float duration)
		{
			//Discarded unreachable code: IL_00d6
			//IL_0030: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			Tween<Vector3> tween = cameraPositionTransition;
			if (tween != null)
			{
				int reverse = 0;
				((Tween<T>)(object)tween).Cancel((byte)reverse != 0);
			}
			Transform transform = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num = default(int);
			Tween<Vector3>.InterpolationFunction interpolationFunction = (Tween<Vector3>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Vector3, Vector3, float, Vector3>*/)(&Vector3.Lerp));
			num = 0;
			int num2 = default(int);
			EasingFunction easingFunction = new EasingFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
			num2 = 0;
			float z2 = desiredPosition.z;
			Tween<Vector3> tween2 = default(Tween<Vector3>);
			cameraPositionTransition = tween2;
			CountedBool.RefState refState = isCameraAnimating.AddReference();
			this.OnStartCameraTransition?.Invoke();
			Tween<Vector3> tween3 = cameraPositionTransition;
			Tween<Vector3>.UpdateEventHandler updateEventHandler = (Tween<Vector3>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdateCameraPosition);
			((Tween<T>)(object)tween3).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			Tween<Vector3> tween4 = cameraPositionTransition;
			Tween<Vector3>.FinishEventHandler finishEventHandler = (Tween<Vector3>.FinishEventHandler)(object)(Tween<T>.FinishEventHandler)delegate
			{
				//Discarded unreachable code: IL_001f
				CountedBool.RefState refState3 = isCameraAnimating.ReleaseReference();
				this.OnEndCameraTransition?.Invoke();
			};
			((Tween<T>)(object)tween4).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
			Tween<Vector3> tween5 = cameraPositionTransition;
			Tween<Vector3>.CancelEventHandler cancelEventHandler = (Tween<Vector3>.CancelEventHandler)(object)(Tween<T>.CancelEventHandler)delegate
			{
				//Discarded unreachable code: IL_001f
				CountedBool.RefState refState2 = isCameraAnimating.ReleaseReference();
				this.OnEndCameraTransition?.Invoke();
			};
			((Tween<T>)(object)tween5).add_OnCancel((Tween<>.CancelEventHandler)(object)cancelEventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A66")]
		[Cpp2IlInjected.Address(RVA = "0x106FD20", Offset = "0x106E720", VA = "0x18106FD20")]
		private unsafe void DoCameraRotationTransition(Quaternion desiredAngle, float duration)
		{
			//Discarded unreachable code: IL_00c6
			//IL_0028: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			Tween<Quaternion> tween = cameraRotationTransition;
			if (tween != null)
			{
				int reverse = 0;
				((Tween<T>)(object)tween).Cancel((byte)reverse != 0);
			}
			Transform transform = base.transform;
			int num = default(int);
			Tween<Quaternion>.InterpolationFunction interpolationFunction = (Tween<Quaternion>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Quaternion, Quaternion, float, Quaternion>*/)(&Quaternion.Slerp));
			num = 0;
			int num2 = default(int);
			EasingFunction easingFunction = new EasingFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.QuadEaseInOut));
			num2 = 0;
			Tween<Quaternion> tween2 = default(Tween<Quaternion>);
			cameraRotationTransition = tween2;
			CountedBool.RefState refState = isCameraAnimating.AddReference();
			this.OnStartCameraTransition?.Invoke();
			Tween<Quaternion> tween3 = cameraRotationTransition;
			Tween<Quaternion>.UpdateEventHandler updateEventHandler = (Tween<Quaternion>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdateCameraRotation);
			((Tween<T>)(object)tween3).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			Tween<Quaternion> tween4 = cameraRotationTransition;
			Tween<Quaternion>.FinishEventHandler finishEventHandler = (Tween<Quaternion>.FinishEventHandler)(object)(Tween<T>.FinishEventHandler)delegate
			{
				//Discarded unreachable code: IL_001f
				CountedBool.RefState refState3 = isCameraAnimating.ReleaseReference();
				this.OnEndCameraTransition?.Invoke();
			};
			((Tween<T>)(object)tween4).add_OnFinish((Tween<>.FinishEventHandler)(object)finishEventHandler);
			Tween<Quaternion> tween5 = cameraRotationTransition;
			Tween<Quaternion>.CancelEventHandler cancelEventHandler = (Tween<Quaternion>.CancelEventHandler)(object)(Tween<T>.CancelEventHandler)delegate
			{
				//Discarded unreachable code: IL_001f
				CountedBool.RefState refState2 = isCameraAnimating.ReleaseReference();
				this.OnEndCameraTransition?.Invoke();
			};
			((Tween<T>)(object)tween5).add_OnCancel((Tween<>.CancelEventHandler)(object)cancelEventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A67")]
		[Cpp2IlInjected.Address(RVA = "0x10703B0", Offset = "0x106EDB0", VA = "0x1810703B0")]
		internal unsafe void ResetStartTransform()
		{
			//Discarded unreachable code: IL_0024
			//IL_001e: Expected native int or pointer, but got O
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)cameraPositionOnPause)->z = z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A68")]
		[Cpp2IlInjected.Address(RVA = "0x1070530", Offset = "0x106EF30", VA = "0x181070530")]
		private void UpdateCameraRotation(Quaternion rotation, float progress)
		{
			//Discarded unreachable code: IL_0008
			Transform transform = base.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A69")]
		[Cpp2IlInjected.Address(RVA = "0x10704E0", Offset = "0x106EEE0", VA = "0x1810704E0")]
		private void UpdateCameraPosition(Vector3 position, float progress)
		{
			//Discarded unreachable code: IL_000f
			Transform transform = base.transform;
			float z = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A6A")]
		[Cpp2IlInjected.Address(RVA = "0x1070390", Offset = "0x106ED90", VA = "0x181070390")]
		private void RaiseOnStartCameraTransition()
		{
			this.OnStartCameraTransition?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A6B")]
		[Cpp2IlInjected.Address(RVA = "0x1070370", Offset = "0x106ED70", VA = "0x181070370")]
		private void RaiseOnEndCameraTransition()
		{
			this.OnEndCameraTransition?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A6C")]
		[Cpp2IlInjected.Address(RVA = "0x1070630", Offset = "0x106F030", VA = "0x181070630")]
		public TemporaryCameraTransition()
		{
			int debug = default(int);
			CountedBool countedBool = new CountedBool("inCameraTransition", (byte)debug != 0);
			debug = 0;
			temporaryTransitionInProgress = countedBool;
			int debug2 = default(int);
			CountedBool countedBool2 = new CountedBool("isCameraAnimating", (byte)debug2 != 0);
			debug2 = 0;
			isCameraAnimating = countedBool2;
			base._002Ector();
		}
	}
}
