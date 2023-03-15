using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C94")]
	public class SteerCoroutine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004658")]
		public Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004659")]
		public Vector3 targetPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400465A")]
		public float horizontalDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400465B")]
		public float verticalDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400465C")]
		public Vector2 horizontalOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400465D")]
		public float maxVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400465E")]
		public float maxForce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400465F")]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4004660")]
		public float slowDownRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4004663")]
		private Vector3 _lastTargetPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4004664")]
		private Transform _actor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4004665")]
		private float _time;

		[Cpp2IlInjected.Token(Token = "0x170007CC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x44"), Cpp2IlInjected.Token(Token = "0x4004661")]
		public bool Active
		{
			[Cpp2IlInjected.Token(Token = "0x6003A1F")]
			[Cpp2IlInjected.Address(RVA = "0xAE1E60", Offset = "0xAE0860", VA = "0x180AE1E60")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003A20")]
			[Cpp2IlInjected.Address(RVA = "0xAE1E70", Offset = "0xAE0870", VA = "0x180AE1E70")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007CD")]
		public unsafe Vector3 Velocity
		{
			[Cpp2IlInjected.Token(Token = "0x6003A21")]
			[Cpp2IlInjected.Address(RVA = "0xF63360", Offset = "0xF61D60", VA = "0x180F63360")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6003A22")]
			[Cpp2IlInjected.Address(RVA = "0xF63380", Offset = "0xF61D80", VA = "0x180F63380")]
			[CompilerGenerated]
			private set
			{
				//IL_000e: Expected native int or pointer, but got O
				float z = value.z;
				((Vector3*)(IntPtr)_003CVelocity_003Ek__BackingField)->z = z;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003A23")]
		[Cpp2IlInjected.Address(RVA = "0xF62F00", Offset = "0xF61900", VA = "0x180F62F00")]
		public unsafe void Start(Transform actor, Vector3 velocity)
		{
			//Discarded unreachable code: IL_005d
			//IL_001c: Expected native int or pointer, but got O
			//IL_0035: Expected O, but got I4
			//IL_0050: Expected native int or pointer, but got O
			_actor = actor;
			float z = velocity.z;
			Transform transform = target;
			((Vector3*)(IntPtr)Velocity)->z = z;
			_time = 0f;
			int num = 0;
			if (!(transform != (UnityEngine.Object)num))
			{
			}
			Transform transform2 = target;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			((Vector3*)(IntPtr)_lastTargetPos)->z = z2;
			Active = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A24")]
		[Cpp2IlInjected.Address(RVA = "0xF62FE0", Offset = "0xF619E0", VA = "0x180F62FE0")]
		public void Stop()
		{
			Active = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A25")]
		[Cpp2IlInjected.Address(RVA = "0xF62890", Offset = "0xF61290", VA = "0x180F62890")]
		public unsafe void Move(float elapsed)
		{
			//IL_0031: Expected O, but got I4
			//IL_0051: Expected native int or pointer, but got O
			//IL_00fe: Expected native int or pointer, but got O
			if (!Active)
			{
				return;
			}
			float time = _time;
			float num = delay;
			if (!(num > time))
			{
				Transform transform = target;
				int num2 = 0;
				if (transform != (UnityEngine.Object)num2)
				{
					Transform transform2 = target;
					float z = transform.position.z;
					((Vector3*)(IntPtr)targetPos)->z = z;
				}
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
				num = elapsed;
				Transform actor = _actor;
				bool flag = default(bool);
				if (!flag)
				{
					Transform actor2 = _actor;
					Vector3 vector2 = default(Vector3);
					float z3 = vector2.z;
					num = elapsed;
					Vector3 zero = Vector3.zero;
					float num3 = slowDownRadius;
					Transform actor3 = _actor;
					float num4 = default(float);
					if (!(num3 > num4))
					{
						Vector3 vector3 = default(Vector3);
						float z4 = vector3.z;
						num4 = num3;
						Vector3 vector4 = default(Vector3);
						float z5 = vector4.z;
						num3 = time;
					}
					Vector3 vector5 = default(Vector3);
					float z6 = vector5.z;
					num4 = num3;
					Vector3 vector6 = default(Vector3);
					float z7 = vector6.z;
					num3 = time;
					num4 = num3;
					num3 = time;
					num4 = num3;
					int num5 = 0;
					float z8 = Velocity.z;
					Transform actor4 = _actor;
					((Vector3*)(IntPtr)Velocity)->z = z8;
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A26")]
		[Cpp2IlInjected.Address(RVA = "0xF62E40", Offset = "0xF61840", VA = "0x180F62E40")]
		public unsafe void Reset()
		{
			//Discarded unreachable code: IL_0063
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected native int or pointer, but got O
			//IL_0043: Expected native int or pointer, but got O
			//IL_005d: Expected native int or pointer, but got O
			Transform transform = target;
			int num = 0;
			if (transform != (UnityEngine.Object)num)
			{
				Transform transform2 = target;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				((Vector3*)(IntPtr)targetPos)->z = z;
			}
			float z2 = Vector3.zero.z;
			((Vector3*)(IntPtr)Velocity)->z = z2;
			float z3 = targetPos.z;
			((Vector3*)(IntPtr)_lastTargetPos)->z = z3;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A27")]
		[Cpp2IlInjected.Address(RVA = "0xF62760", Offset = "0xF61160", VA = "0x180F62760")]
		public Vector3 GetTargetPosition()
		{
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
			}
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A28")]
		[Cpp2IlInjected.Address(RVA = "0xF62FF0", Offset = "0xF619F0", VA = "0x180F62FF0")]
		private Vector3 TargetOffset()
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003A29")]
		[Cpp2IlInjected.Address(RVA = "0xF632C0", Offset = "0xF61CC0", VA = "0x180F632C0")]
		public unsafe SteerCoroutine()
		{
			//IL_0016: Expected native int or pointer, but got O
			//IL_004a: Expected F4, but got I4
			//IL_0045: Expected native int or pointer, but got O
			//IL_007f: Expected native int or pointer, but got O
			Vector3 zero = Vector3.zero;
			int num = 0;
			float z = zero.z;
			((Vector3*)(IntPtr)targetPos)->z = z;
			horizontalDistance = 1f;
			verticalDistance = 1f;
			horizontalOffset = Vector2.zero;
			((Vector2*)(IntPtr)horizontalOffset)->y = 0f;
			maxVelocity = 100f;
			maxForce = 20f;
			slowDownRadius = 10f;
			float z2 = Vector3.zero.z;
			((Vector3*)(IntPtr)Velocity)->z = z2;
			base._002Ector();
		}
	}
}
