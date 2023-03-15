using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Gestures;
using Mdl.InputSystem;
using Mdl.Motion;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C2E")]
	public class FollowCamera : OrbitCamera
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40043E6")]
		private FollowCameraConfig followCameraConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40043E7")]
		private float yawInputIdleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40043E8")]
		private float yawInputActiveTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40043E9")]
		private float pitchInputIdleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40043EA")]
		private float pitchInputActiveTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40043EB")]
		private float currentDistance;

		[Cpp2IlInjected.Token(Token = "0x40043EC")]
		private static readonly float kinda_small_number;

		[Cpp2IlInjected.Token(Token = "0x17000760")]
		private float desiredDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6003768")]
			[Cpp2IlInjected.Address(RVA = "0x1461420", Offset = "0x145FE20", VA = "0x181461420")]
			get
			{
				//Discarded unreachable code: IL_000c
				return followCameraConfig.DesiredCameraDistance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003769")]
		[Cpp2IlInjected.Address(RVA = "0x145FE80", Offset = "0x145E880", VA = "0x18145FE80")]
		public float GetIdleYawModifier()
		{
			//Discarded unreachable code: IL_001b
			AnimationCurve inputIdleCurve = followCameraConfig.InputIdleCurve;
			float time = yawInputIdleTime;
			return inputIdleCurve.Evaluate(time);
		}

		[Cpp2IlInjected.Token(Token = "0x600376A")]
		[Cpp2IlInjected.Address(RVA = "0x145FDB0", Offset = "0x145E7B0", VA = "0x18145FDB0")]
		public float GetActiveYawModifier()
		{
			//Discarded unreachable code: IL_001b
			AnimationCurve inputActiveCurve = followCameraConfig.InputActiveCurve;
			float time = yawInputActiveTime;
			return inputActiveCurve.Evaluate(time);
		}

		[Cpp2IlInjected.Token(Token = "0x600376B")]
		[Cpp2IlInjected.Address(RVA = "0x1461370", Offset = "0x145FD70", VA = "0x181461370")]
		public FollowCamera(Camera camera)
		{
			//IL_0025: Expected O, but got I4
			followCameraConfig = ScriptableObject.CreateInstance<FollowCameraConfig>();
			currentDistance = 7f;
			base._002Ector(camera, (OrbitCameraConfig)0);
		}

		[Cpp2IlInjected.Token(Token = "0x600376C")]
		[Cpp2IlInjected.Address(RVA = "0x1461170", Offset = "0x145FB70", VA = "0x181461170")]
		public FollowCamera(Camera camera, Transform targetTransform, OrbitCameraConfig config, bool allowZoom = true)
		{
			float z = Vector3.zero.z;
		}

		[Cpp2IlInjected.Token(Token = "0x600376D")]
		[Cpp2IlInjected.Address(RVA = "0x1461120", Offset = "0x145FB20", VA = "0x181461120")]
		public FollowCamera(Camera camera, Vector3 targetPosition, OrbitCameraConfig config, bool allowZoom = true)
		{
			float z = targetPosition.z;
		}

		[Cpp2IlInjected.Token(Token = "0x600376E")]
		[Cpp2IlInjected.Address(RVA = "0x1461200", Offset = "0x145FC00", VA = "0x181461200")]
		private FollowCamera(Camera camera, Transform targetTransform, Vector3 targetPosition, OrbitCameraConfig config, bool allowZoom)
		{
			//Discarded unreachable code: IL_0047
			//IL_0031: Expected O, but got I4
			FollowCameraConfig followCameraConfig = (this.followCameraConfig = ScriptableObject.CreateInstance<FollowCameraConfig>());
			currentDistance = 7f;
			float z = targetPosition.z;
			int num = 0;
			if ((bool)targetTransform)
			{
				this.followCameraConfig = (FollowCameraConfig)num;
				float num2 = (currentDistance = this.followCameraConfig.DesiredCameraDistance);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600376F")]
		[Cpp2IlInjected.Address(RVA = "0x145FCC0", Offset = "0x145E6C0", VA = "0x18145FCC0")]
		private NavMeshAgent FindNavAgent()
		{
			//IL_0010: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			Transform targetTransform = _targetTransform;
			int num = 0;
			if (!(targetTransform == (UnityEngine.Object)num))
			{
				PlayerAvatar componentInParent = _targetTransform.gameObject.GetComponentInParent<PlayerAvatar>(includeInactive: true);
				int num2 = 0;
				if (!(componentInParent == (UnityEngine.Object)num2))
				{
					return componentInParent.Agent;
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003770")]
		[Cpp2IlInjected.Address(RVA = "0x14608E0", Offset = "0x145F2E0", VA = "0x1814608E0", Slot = "6")]
		public override void Reset([System.Runtime.InteropServices.Optional] float? offsetYaw, [System.Runtime.InteropServices.Optional] float? offsetPitch, [System.Runtime.InteropServices.Optional] float? transitionDuration)
		{
			//Discarded unreachable code: IL_02cf
			//IL_0020: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_0069: Expected I4, but got O
			//IL_008a: Expected F4, but got I4
			//IL_00b2: Expected O, but got I4
			//IL_0123: Expected I4, but got O
			//IL_0144: Expected F4, but got I4
			//IL_01b6: Expected O, but got I4
			//IL_01c1: Expected F4, but got I4
			//IL_01d5: Expected O, but got I4
			//IL_01f7: Expected O, but got I4
			//IL_021e: Expected I4, but got O
			//IL_023f: Expected F4, but got I4
			//IL_0260: Expected I4, but got O
			//IL_02a7: Expected O, but got I4
			NavMeshAgent navMeshAgent = FindNavAgent();
			int num = 0;
			if ((IntPtr)0 != (IntPtr)transitionDuration)
			{
				Transform targetTransform = _targetTransform;
				int num2 = 0;
				if (targetTransform != (UnityEngine.Object)num2 && followCameraConfig.Enabled)
				{
					int num3 = 0;
					if (navMeshAgent != (UnityEngine.Object)num3)
					{
						OrbitCameraConfig orbitCameraConfig = base.Config;
						LaggedAngle laggedAngle = base.Yaw;
						if ((object)orbitCameraConfig != null)
						{
						}
						int num4 = 0;
						laggedAngle.UseInterpolation = (byte)(int)orbitCameraConfig != 0;
						OrbitCameraConfig orbitCameraConfig2 = base.Config;
						LaggedAngle laggedAngle2 = base.Yaw;
						if ((object)orbitCameraConfig2 != null)
						{
						}
						int num5 = 0;
						laggedAngle2.InterpolationSpeed = num5;
						LaggedAngle laggedAngle3 = base.Yaw;
						if ((object)offsetYaw != null)
						{
						}
						Vector2 facingDirection = GetFacingDirection(navMeshAgent);
						int num6 = 0;
						Vector2 up = Vector2.up;
						float angle = Vector2.SignedAngle((Vector2)num6, up);
						laggedAngle3.Reset(angle);
						if ((object)offsetPitch != null)
						{
						}
						float targetPitch = followCameraConfig.TargetPitch;
						if (!(targetPitch <= 180f))
						{
						}
						OrbitCameraConfig orbitCameraConfig3 = base.Config;
						float maxPitch = orbitCameraConfig3.maxPitch;
						float minPitch = orbitCameraConfig3.minPitch;
						float num7 = Mathf.Clamp(targetPitch, minPitch, maxPitch);
						OrbitCameraConfig orbitCameraConfig4 = base.Config;
						maxPitch = num7;
						LaggedAngle laggedAngle4 = base.Pitch;
						if ((object)orbitCameraConfig4 != null)
						{
						}
						int num8 = 0;
						laggedAngle4.UseInterpolation = (byte)(int)orbitCameraConfig4 != 0;
						OrbitCameraConfig orbitCameraConfig5 = base.Config;
						LaggedAngle laggedAngle5 = base.Pitch;
						if ((object)orbitCameraConfig5 != null)
						{
						}
						int num9 = 0;
						laggedAngle5.InterpolationSpeed = num9;
						base.Pitch.Reset(maxPitch);
						Transform transform = base.Camera.transform;
						LaggedAngle laggedAngle6 = base.Pitch;
						LaggedAngle laggedAngle7 = base.Yaw;
						OrbitCameraConfig orbitCameraConfig6 = base.Config;
						float num10 = default(float);
						if (!(num10 <= orbitCameraConfig6.maxYaw))
						{
							LaggedAngle laggedAngle8 = base.Yaw;
							OrbitCameraConfig orbitCameraConfig7 = base.Config;
							Camera camera = base.Camera;
							int num11 = 0;
							Transform transform2 = camera.transform;
							LaggedAngle laggedAngle9 = base.Pitch;
							transform2.eulerAngles = (Vector3)num11;
						}
						int num12 = 0;
						InternalMove(num12);
					}
				}
			}
			Transform targetTransform2 = _targetTransform;
			int num13 = 0;
			if (targetTransform2 != (UnityEngine.Object)num13 && followCameraConfig.Enabled)
			{
				int num14 = 0;
				if (navMeshAgent != (UnityEngine.Object)num14)
				{
					OrbitCameraConfig orbitCameraConfig8 = base.Config;
					LaggedAngle laggedAngle10 = base.Yaw;
					if ((object)orbitCameraConfig8 != null)
					{
					}
					int num15 = 0;
					laggedAngle10.UseInterpolation = (byte)(int)orbitCameraConfig8 != 0;
					OrbitCameraConfig orbitCameraConfig9 = base.Config;
					LaggedAngle laggedAngle11 = base.Yaw;
					if ((object)orbitCameraConfig9 != null)
					{
					}
					int num16 = 0;
					laggedAngle11.InterpolationSpeed = num16;
					OrbitCameraConfig orbitCameraConfig10 = base.Config;
					LaggedAngle laggedAngle12 = base.Pitch;
					if ((object)orbitCameraConfig10 != null)
					{
					}
					int num17 = 0;
					laggedAngle12.UseInterpolation = (byte)(int)orbitCameraConfig10 != 0;
					OrbitCameraConfig orbitCameraConfig11 = base.Config;
					LaggedAngle laggedAngle13 = base.Pitch;
					float rotationLagPitch = default(float);
					if ((object)orbitCameraConfig11 != null)
					{
						rotationLagPitch = orbitCameraConfig11.rotationLagPitch;
					}
					laggedAngle13.InterpolationSpeed = rotationLagPitch;
					if ((object)offsetYaw != null)
					{
					}
					Vector2 facingDirection2 = GetFacingDirection(navMeshAgent);
					int num18 = 0;
					Vector2 up2 = Vector2.up;
					float num19 = Vector2.SignedAngle((Vector2)num18, up2);
					if ((object)offsetPitch != null)
					{
					}
					float targetPitch2 = followCameraConfig.TargetPitch;
					base.Transition(num19, targetPitch2, (Nullable<>)transitionDuration);
				}
			}
			base.Reset((Nullable<>)offsetYaw, (Nullable<>)offsetPitch, (Nullable<>)transitionDuration);
		}

		[Cpp2IlInjected.Token(Token = "0x6003771")]
		[Cpp2IlInjected.Address(RVA = "0x145FEC0", Offset = "0x145E8C0", VA = "0x18145FEC0")]
		protected Vector2 GetMovementDirection(NavMeshAgent navAgent)
		{
			//Discarded unreachable code: IL_0023, IL_0025
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform = navAgent.transform;
			Transform transform2 = navAgent.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Vector2 result = default(Vector2);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003772")]
		[Cpp2IlInjected.Address(RVA = "0x14600D0", Offset = "0x145EAD0", VA = "0x1814600D0")]
		protected Vector2 GetVelocityDirection(NavMeshAgent navAgent)
		{
			//Discarded unreachable code: IL_0009
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector2 result = default(Vector2);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003773")]
		[Cpp2IlInjected.Address(RVA = "0x145FDF0", Offset = "0x145E7F0", VA = "0x18145FDF0")]
		protected Vector2 GetFacingDirection(NavMeshAgent navAgent)
		{
			//Discarded unreachable code: IL_0019
			Transform transform = navAgent.transform;
			Transform transform2 = navAgent.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector2 result = default(Vector2);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003774")]
		[Cpp2IlInjected.Address(RVA = "0x1460030", Offset = "0x145EA30", VA = "0x181460030")]
		protected Vector2 GetRearDirection(NavMeshAgent navAgent)
		{
			//Discarded unreachable code: IL_0019
			Transform transform = navAgent.transform;
			Transform transform2 = navAgent.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector2 result = default(Vector2);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003775")]
		[Cpp2IlInjected.Address(RVA = "0x1460820", Offset = "0x145F220", VA = "0x181460820", Slot = "4")]
		public override void Move(float deltaTime, MoveGesture move)
		{
			//Discarded unreachable code: IL_0029
			//IL_0028: Expected O, but got I8
			Tween<float> transition = _transition;
			if (transition == null)
			{
				InternalMove(deltaTime);
			}
			int reverse = 0;
			if (!((Tween<T>)(object)transition).Play(deltaTime, (byte)reverse != 0))
			{
				_transition = (Tween<float>)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003776")]
		[Cpp2IlInjected.Address(RVA = "0x1460760", Offset = "0x145F160", VA = "0x181460760", Slot = "5")]
		public override void Move(float deltaTime, InputAction inputPan, InputAction inputRotation, InputAction inputZoom)
		{
			//Discarded unreachable code: IL_0038
			//IL_0037: Expected O, but got I8
			Tween<float> transition = _transition;
			if (transition == null)
			{
				Vector2 valueVector = inputRotation.GetValueVector2();
				ApplyCameraRotation(deltaTime, valueVector);
				InternalMove(deltaTime);
			}
			int reverse = 0;
			if (!((Tween<T>)(object)transition).Play(deltaTime, (byte)reverse != 0))
			{
				_transition = (Tween<float>)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003777")]
		[Cpp2IlInjected.Address(RVA = "0x1460140", Offset = "0x145EB40", VA = "0x181460140")]
		private void InternalMove(float deltaTime)
		{
			//Discarded unreachable code: IL_0143
			float desiredCameraDistance = followCameraConfig.DesiredCameraDistance;
			LaggedAngle laggedAngle = base.Pitch;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			LaggedAngle laggedAngle2 = base.Yaw;
			int num = 0;
			float _003CCurrent_003Ek__BackingField = laggedAngle2.Current;
			float z2 = Vector3.forward.z;
			Vector3 vector2 = default(Vector3);
			float z3 = vector2.z;
			Camera camera = base.Camera;
			Vector3 vector3 = default(Vector3);
			float z4 = vector3.z;
			Transform transform = camera.transform;
			Vector3 vector4 = default(Vector3);
			float z5 = vector4.z;
			OrbitCameraConfig orbitCameraConfig = base.Config;
			float sphereCastCollisionRadius = orbitCameraConfig.sphereCastCollisionRadius;
			float sphereCastCollisionOverlapRadius = orbitCameraConfig.sphereCastCollisionOverlapRadius;
			int num2 = OrbitCamera.sphereCastMask;
			(bool, Vector3) tuple = default((bool, Vector3));
			if ((object)tuple == null)
			{
				float num3 = currentDistance;
				if (!(desiredCameraDistance > num3))
				{
					if (num3 <= desiredCameraDistance)
					{
						goto IL_010b;
					}
					float num4 = followCameraConfig.returnSpeed.Evaluate(num3);
					float num5 = currentDistance;
					num3 = desiredCameraDistance;
					num4 = num5;
					float num6 = Mathf.Clamp(num4, num3, num5);
				}
				float value = followCameraConfig.returnSpeed.Evaluate(num3);
				float min = currentDistance;
				_003CCurrent_003Ek__BackingField = desiredCameraDistance;
				float num7 = Mathf.Clamp(value, min, _003CCurrent_003Ek__BackingField);
			}
			Vector3 vector5 = default(Vector3);
			float z6 = vector5.z;
			float num8 = default(float);
			currentDistance = num8;
			goto IL_010b;
			IL_010b:
			LaggedAngle laggedAngle3 = base.Pitch;
			Vector3 vector6 = default(Vector3);
			float z7 = vector6.z;
			LaggedAngle laggedAngle4 = base.Yaw;
			float z8 = Vector3.forward.z;
			Vector3 vector7 = default(Vector3);
			float z9 = vector7.z;
			Vector3 vector8 = default(Vector3);
			float z10 = vector8.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6003778")]
		[Cpp2IlInjected.Address(RVA = "0x145F240", Offset = "0x145DC40", VA = "0x18145F240", Slot = "7")]
		protected override float CalculateYaw(float deltaTime, float currentYaw, Vector2 deltaAngle)
		{
			//Discarded unreachable code: IL_0206
			//IL_0020: Expected O, but got I4
			//IL_0059: Expected F4, but got I4
			//IL_0070: Expected F4, but got I4
			//IL_0105: Expected O, but got F4
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Expected F4, but got Unknown
			//IL_01aa: Expected O, but got F4
			//IL_01c9: Expected O, but got F4
			//IL_01e8: Expected O, but got F4
			float degrees;
			PlayerNavigation playerNavigation = default(PlayerNavigation);
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			Vector3 vector3 = default(Vector3);
			float num7 = default(float);
			Vector3 vector4 = default(Vector3);
			Vector3 vector5 = default(Vector3);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				degrees = base.CalculateYaw(deltaTime, currentYaw, deltaAngle);
				Transform targetTransform = _targetTransform;
				int num3 = 0;
				if (!(targetTransform != (UnityEngine.Object)num3) || (this.followCameraConfig.Enabled ? 1 : 0) == num2)
				{
					break;
				}
				PlayerNavigationConfig playerConfig = playerNavigation._playerConfig;
				int num4 = 0;
				Vector2 zero = Vector2.zero;
				FollowCameraConfig followCameraConfig = this.followCameraConfig;
				yawInputIdleTime = num2;
				yawInputActiveTime = deltaTime;
				AnimationCurve inputActiveCurve = followCameraConfig.InputActiveCurve;
				yawInputActiveTime = num2;
				yawInputIdleTime = deltaTime;
				float num5 = inputActiveCurve.Evaluate(deltaTime);
				NavMeshAgent navMeshAgent = FindNavAgent();
				float num6 = this.followCameraConfig.VelocityCurve.Evaluate(deltaTime);
				float z = vector.z;
				Transform transform = navMeshAgent.transform;
				Transform transform2 = navMeshAgent.transform;
				float z2 = vector2.z;
				Transform transform3 = base.Camera.transform;
				Transform transform4 = base.Camera.transform;
				float z3 = vector3.z;
				float num8 = this.followCameraConfig.AngleCurve.Evaluate(num7);
				FollowCameraConfig followCameraConfig2 = this.followCameraConfig;
				float baseYawRotationInDegreesPerSecond = ((FollowCameraConfig)currentYaw).BaseYawRotationInDegreesPerSecond;
				float alpha = ((FollowCameraConfig)(/*Error near IL_0106: Stack underflow*/ * baseYawRotationInDegreesPerSecond)).Alpha;
				float num9 = /*Error near IL_010c: Stack underflow*/* alpha;
				num8 = num7;
				float num10 = Mathf.Sign(num8);
				if ((this.followCameraConfig.DrawDebug ? 1 : 0) == num2)
				{
					break;
				}
				Transform transform5 = navMeshAgent.transform;
				float z4 = vector4.z;
				Color green = Color.green;
				Color cyan = Color.cyan;
				object[] array = new object[5];
				if (array != null && array == null)
				{
					continue;
				}
				array[0] = array;
				if (array != null && array == null)
				{
					continue;
				}
				array[1] = array;
				float z5 = vector5.z;
				if (z5 != 0f && z5 == 0f)
				{
					continue;
				}
				array[2] = z5;
				if (z5 == 0f || z5 != 0f)
				{
					array[3] = z5;
					if (z5 == 0f || z5 != 0f)
					{
						array[4] = z5;
						string text = string.Format("speed: {0}, normalizedSpeed: {1}, velocity: {2}, velocityModifier: {3}, p: {4}", array);
						break;
					}
				}
			}
			float _003CRadians_003Ek__BackingField = Angle.FromDegrees(degrees).Radians;
			float result = default(float);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003779")]
		[Cpp2IlInjected.Address(RVA = "0x145EEC0", Offset = "0x145D8C0", VA = "0x18145EEC0", Slot = "8")]
		protected override float CalculatePitch(float deltaTime, float currentPitch, Vector2 deltaAngle)
		{
			//Discarded unreachable code: IL_00e7
			//IL_001c: Expected O, but got I4
			//IL_00cb: Expected O, but got F4
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected F4, but got Unknown
			int num = 0;
			float degrees = base.CalculatePitch(deltaTime, currentPitch, deltaAngle);
			Transform targetTransform = _targetTransform;
			int num2 = 0;
			if (targetTransform != (UnityEngine.Object)num2 && this.followCameraConfig.Enabled)
			{
				PlayerNavigation playerNavigation = default(PlayerNavigation);
				PlayerNavigationConfig playerConfig = playerNavigation._playerConfig;
				int num3 = 0;
				Vector2 zero = Vector2.zero;
				FollowCameraConfig followCameraConfig = this.followCameraConfig;
				pitchInputIdleTime = 0f;
				pitchInputActiveTime = deltaTime;
				AnimationCurve inputActiveCurve = followCameraConfig.InputActiveCurve;
				pitchInputActiveTime = 0f;
				pitchInputIdleTime = deltaTime;
				float num4 = inputActiveCurve.Evaluate(deltaTime);
				NavMeshAgent navMeshAgent = FindNavAgent();
				Vector3 vector = default(Vector3);
				float z = vector.z;
				float num5 = this.followCameraConfig.VelocityCurve.Evaluate(deltaTime);
				float f = this.followCameraConfig.AngleCurve.Evaluate(deltaTime);
				FollowCameraConfig followCameraConfig2 = this.followCameraConfig;
				float basePitchRotationInDegreesPerSecond = ((FollowCameraConfig)num4).BasePitchRotationInDegreesPerSecond;
				float num6 = /*Error near IL_00cc: Stack underflow*/* basePitchRotationInDegreesPerSecond;
				float num7 = Mathf.Sign(f);
			}
			float _003CRadians_003Ek__BackingField = Angle.FromDegrees(degrees).Radians;
			float result = default(float);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600377A")]
		[Cpp2IlInjected.Address(RVA = "0x1460FA0", Offset = "0x145F9A0", VA = "0x181460FA0", Slot = "9")]
		protected override Vector3 Zoom(float deltaScale)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float z2 = Vector3.forward.z;
			Vector3 vector2 = default(Vector3);
			float z3 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600377B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_FOLLOW_CAMERA")]
		private static void OnscreenDebug(string key, Vector3 value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600377C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_FOLLOW_CAMERA")]
		private static void OnscreenDebug(string key, float value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600377D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG_ONSCREEN_FOLLOW_CAMERA")]
		private static void OnscreenDebug(string key, bool value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
