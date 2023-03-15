using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Environments;
using Mdl.Motion;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000723")]
	internal class CharacterLookAtBehaviour : LookAtBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400296A")]
		public float awarenessRadius = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400296B")]
		public float awarenessAngle = 135f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400296C")]
		public float rampUpDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400296D")]
		public float rampDownDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400296E")]
		private readonly List<GameObject> charactersInTheRange = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400296F")]
		private CharacterManager characterManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002970")]
		private GameObject _currentPassiveTargetObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002971")]
		private Transform _currentPassiveTargetLookAt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002972")]
		private float _weight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002973")]
		private Transform _previousTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002974")]
		private Vector3? _previousLookAtPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002975")]
		private Tween<Vector3> _changeTargetTween;

		[Cpp2IlInjected.Token(Token = "0x6001FAD")]
		[Cpp2IlInjected.Address(RVA = "0x12DC2A0", Offset = "0x12DACA0", VA = "0x1812DC2A0", Slot = "4")]
		protected override void Start()
		{
			//Discarded unreachable code: IL_002a
			base.Start();
			CharacterManager characterManager = (this.characterManager = SystemRoot.Instance.GetSystem<CharacterManager>());
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent += AnyEnvironmentEnteredEvent;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FAE")]
		[Cpp2IlInjected.Address(RVA = "0x12DB720", Offset = "0x12DA120", VA = "0x1812DB720", Slot = "5")]
		protected unsafe override void LateUpdate()
		{
			//Discarded unreachable code: IL_0206
			//IL_0077: Expected O, but got I4
			//IL_0077: Expected O, but got I4
			//IL_00a2: Expected O, but got I4
			//IL_00ab: Expected O, but got I4
			//IL_00bf: Invalid comparison between F4 and I4
			//IL_00da: Invalid comparison between F4 and I4
			//IL_0104: Expected O, but got I4
			//IL_0162: Expected O, but got I4
			//IL_01b6: Expected O, but got I4
			//IL_01eb: Expected O, but got I8
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			Transform lookAtTarget = base._target;
			bool flag = default(bool);
			if (flag)
			{
				List<CharacterManager.CharacterInstance> allCharacters = characterManager.allCharacters;
				bool flag2 = default(bool);
				if (flag2)
				{
					Character disneyEntity2 = default(Character);
					CheckGameObject(disneyEntity2);
				}
				PlayerAvatar avatar = SystemRoot.Instance._avatar;
				CheckGameObject(avatar);
				int num5 = 0;
				int num6 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				int num7 = 0;
				bool flag3 = default(bool);
				if (!((UnityEngine.Object)num5 != (UnityEngine.Object)num7) || flag3)
				{
				}
				bool flag4 = default(bool);
				int num8 = default(int);
				if (flag4)
				{
					if (flag3)
					{
						CharacterVisualNodes characterVisualNodes = default(CharacterVisualNodes);
						Transform transform = characterVisualNodes.Head.transform;
					}
					num8 = 0;
					_currentPassiveTargetLookAt = (Transform)num8;
				}
				lookAtTarget = (Transform)num8;
			}
			bool flag5 = default(bool);
			if (!flag5)
			{
				float num9 = rampDownDuration;
				int num10 = 0;
				if (num9 <= (float)num10)
				{
					goto IL_00eb;
				}
				int num11 = 0;
				float deltaTime = Time.deltaTime;
			}
			float num12 = rampUpDuration;
			int num13 = 0;
			if (!(num12 > (float)num13))
			{
			}
			int num14 = 0;
			float weight = Mathf.Clamp01(Time.deltaTime);
			goto IL_00eb;
			IL_00eb:
			_weight = weight;
			bool flag6 = default(bool);
			if (!flag6)
			{
			}
			bool flag7 = _previousTarget != (UnityEngine.Object)num4;
			Tween<Vector3>.UpdateEventHandler updateEventHandler = default(Tween<Vector3>.UpdateEventHandler);
			if (flag7)
			{
				float num15 = rampUpDuration;
				if (flag7)
				{
				}
				Transform transform2 = base.Origin;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform transform3 = base.Origin;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				Vector3 vector3 = default(Vector3);
				float z3 = vector3.z;
				Tween<Vector3>.InterpolationFunction interpolationFunction = (Tween<Vector3>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(Interpolation);
				int num16 = default(int);
				EasingFunction easingFunction = new EasingFunction(num16, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear));
				num16 = 0;
				Tween<Vector3> changeTargetTween = default(Tween<Vector3>);
				_changeTargetTween = changeTargetTween;
				Tween<Vector3> changeTargetTween2 = _changeTargetTween;
				updateEventHandler = (Tween<Vector3>.UpdateEventHandler)(object)(Tween<T>.UpdateEventHandler)delegate(Vector3 value, float _)
				{
					//Discarded unreachable code: IL_0016
					//IL_0015: Expected O, but got I4
					float z8 = value.z;
					int num27 = 0;
					_previousLookAtPosition = (Vector3?)(object)num27;
				};
				((Tween<T>)(object)changeTargetTween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			}
			_previousTarget = (Transform)(object)updateEventHandler;
			int num17 = 0;
			bool flag8 = default(bool);
			if (flag8)
			{
				Vector3 vector4 = default(Vector3);
				float z4 = vector4.z;
				int num18 = 0;
			}
			int num19 = 0;
			_previousLookAtPosition = (Vector3?)(object)num19;
			Tween<Vector3> changeTargetTween3 = _changeTargetTween;
			if (changeTargetTween3 != null)
			{
				int num20 = 0;
				float deltaTime2 = Time.deltaTime;
				int reverse = 0;
				float num15 = deltaTime2;
				if (!((Tween<T>)(object)changeTargetTween3).Play(num15, (byte)reverse != 0))
				{
					_changeTargetTween = (Tween<Vector3>)0;
				}
			}
			Vector3? previousLookAtPosition = _previousLookAtPosition;
			float weight2 = _weight;
			base.UpdateLookAt((Nullable<>)previousLookAtPosition, weight2);
			[Cpp2IlInjected.Token(Token = "0x6001FB4")]
			[Cpp2IlInjected.Address(RVA = "0x13F7150", Offset = "0x13F5B50", VA = "0x1813F7150")]
			void CheckGameObject(IDisneyEntity disneyEntity)
			{
				GameObject gameObject = base.gameObject;
				bool flag9 = default(bool);
				if (!flag9)
				{
					int num21 = 0;
					uint num22 = default(uint);
					if (num21 < (int)num22)
					{
						num21 += num21;
						num21++;
					}
					Transform transform4 = base.transform;
					CharacterLookAtBehaviour characterLookAtBehaviour = this;
					float num23 = characterLookAtBehaviour.awarenessRadius;
					float num24 = default(float);
					if (!(num24 > num23))
					{
						Transform transform5 = characterLookAtBehaviour.transform;
						float num25 = awarenessAngle;
						transform5 = (Transform)(object)((object)transform5 + (object)transform5);
						if (false)
						{
							List<GameObject> list = charactersInTheRange;
							bool flag10;
							while (flag10)
							{
							}
							List<GameObject> list2 = charactersInTheRange;
							throw new NullReferenceException();
						}
					}
					List<GameObject> list3 = charactersInTheRange;
					int num26 = default(int);
					if (num26 != -1)
					{
						((List<T>)(object)charactersInTheRange).RemoveAt(num26);
					}
				}
			}
			[Cpp2IlInjected.Token(Token = "0x6001FB5")]
			[Cpp2IlInjected.Address(RVA = "0x13F7580", Offset = "0x13F5F80", VA = "0x1813F7580")]
			Vector3 Interpolation(Vector3 start, Vector3 _, float scale)
			{
				Vector3 vector5 = default(Vector3);
				float z5 = vector5.z;
				float z6 = _.z;
				float z7 = _.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FAF")]
		[Cpp2IlInjected.Address(RVA = "0x12DC230", Offset = "0x12DAC30", VA = "0x1812DC230")]
		private void OnDestroy()
		{
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= AnyEnvironmentEnteredEvent;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB0")]
		[Cpp2IlInjected.Address(RVA = "0x12DB670", Offset = "0x12DA070", VA = "0x1812DB670")]
		private void AnyEnvironmentEnteredEvent(object sender, EventArgs e)
		{
			//IL_0014: Expected O, but got I4
			//IL_001b: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			((List<T>)(object)charactersInTheRange).Clear();
			int num = 0;
			_currentPassiveTargetLookAt = (Transform)num;
			_currentPassiveTargetObject = (GameObject)num;
			_previousTarget = (Transform)num;
			int num2 = 0;
			_previousLookAtPosition = (Vector3?)(object)num2;
			_changeTargetTween = (Tween<Vector3>)num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FB1")]
		[Cpp2IlInjected.Address(RVA = "0x12DC3D0", Offset = "0x12DADD0", VA = "0x1812DC3D0")]
		public CharacterLookAtBehaviour()
		{
		}
	}
}
