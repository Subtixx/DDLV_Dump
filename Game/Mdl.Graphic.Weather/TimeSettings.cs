using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x2000502")]
	[CreateAssetMenu]
	public class TimeSettings : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000503")]
		public class AstralKey : IKey
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001F9C")]
			[SerializeField]
			private float _time;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4001F9D")]
			[SerializeField]
			private float _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001F9E")]
			public Vector3 direction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4001F9F")]
			public Vector3 lightOffset;

			[Cpp2IlInjected.Token(Token = "0x170002E3")]
			public float time
			{
				[Cpp2IlInjected.Token(Token = "0x600164B")]
				[Cpp2IlInjected.Address(RVA = "0x8EDDD0", Offset = "0x8EC7D0", VA = "0x1808EDDD0", Slot = "4")]
				get
				{
					return _time;
				}
				[Cpp2IlInjected.Token(Token = "0x600164C")]
				[Cpp2IlInjected.Address(RVA = "0x8EDDE0", Offset = "0x8EC7E0", VA = "0x1808EDDE0", Slot = "5")]
				set
				{
					_time = value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002E4")]
			public float duration
			{
				[Cpp2IlInjected.Token(Token = "0x600164D")]
				[Cpp2IlInjected.Address(RVA = "0x7F3600", Offset = "0x7F2000", VA = "0x1807F3600", Slot = "6")]
				get
				{
					return _duration;
				}
				[Cpp2IlInjected.Token(Token = "0x600164E")]
				[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F2010", VA = "0x1807F3610", Slot = "7")]
				set
				{
					_duration = value;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600164F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public AstralKey()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F92")]
		public KeyGroup<AstralKey> sunKeys = (KeyGroup<AstralKey>)(object)new KeyGroup<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F93")]
		public KeyGroup<AstralKey> moonKeys = (KeyGroup<AstralKey>)(object)new KeyGroup<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001F94")]
		[TimeField]
		[Header("Day - Night transition")]
		public float canTransitToDay = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4001F95")]
		[TimeField]
		public float forceTransitToDay = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001F96")]
		[TimeField]
		public float canTransitToNight = 0.875f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4001F97")]
		[TimeField]
		public float forceTransitToNight = 0.875f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001F98")]
		[Tooltip("Duration (in seconds) of the transition between sunlight and moonlight.")]
		public int transitionDuration = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4001F99")]
		[TimeField]
		[Header("Artifical lights")]
		public float lightsEnablingTime = 0.875f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001F9A")]
		[TimeField]
		public float lightsDisablingTime = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4001F9B")]
		[TimeField]
		public float lightsStagger = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x6001646")]
		[Cpp2IlInjected.Address(RVA = "0x13C87D0", Offset = "0x13C71D0", VA = "0x1813C87D0")]
		public Vector3 GetSunPosition(float time)
		{
			int num = 0;
			AstralKey astralKey = default(AstralKey);
			float z = astralKey.direction.z;
			AstralKey astralKey2 = default(AstralKey);
			float z2 = astralKey2.direction.z;
			Vector3 vector = default(Vector3);
			float z3 = vector.z;
			Vector3 vector2 = default(Vector3);
			float z4 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001647")]
		[Cpp2IlInjected.Address(RVA = "0x13C8970", Offset = "0x13C7370", VA = "0x1813C8970")]
		public Vector3 GetSunPosition(float time, out Vector3 lightDirection)
		{
			int num = 0;
			AstralKey astralKey = default(AstralKey);
			float z = astralKey.lightOffset.z;
			AstralKey astralKey2 = default(AstralKey);
			float z2 = astralKey2.lightOffset.z;
			Vector3 vector = default(Vector3);
			float z3 = vector.z;
			Vector3 vector2 = default(Vector3);
			float z4 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001648")]
		[Cpp2IlInjected.Address(RVA = "0x13C8310", Offset = "0x13C6D10", VA = "0x1813C8310")]
		public Vector3 GetMoonPosition(float time)
		{
			int num = 0;
			AstralKey astralKey = default(AstralKey);
			float z = astralKey.direction.z;
			AstralKey astralKey2 = default(AstralKey);
			float z2 = astralKey2.direction.z;
			Vector3 vector = default(Vector3);
			float z3 = vector.z;
			Vector3 vector2 = default(Vector3);
			float z4 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001649")]
		[Cpp2IlInjected.Address(RVA = "0x13C84B0", Offset = "0x13C6EB0", VA = "0x1813C84B0")]
		public Vector3 GetMoonPosition(float time, out Vector3 lightDirection)
		{
			int num = 0;
			AstralKey astralKey = default(AstralKey);
			float z = astralKey.lightOffset.z;
			AstralKey astralKey2 = default(AstralKey);
			float z2 = astralKey2.lightOffset.z;
			Vector3 vector = default(Vector3);
			float z3 = vector.z;
			Vector3 vector2 = default(Vector3);
			float z4 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600164A")]
		[Cpp2IlInjected.Address(RVA = "0x13C8C90", Offset = "0x13C7690", VA = "0x1813C8C90")]
		public TimeSettings()
		{
		}//IL_0050: Expected I4, but got I8

	}
}
