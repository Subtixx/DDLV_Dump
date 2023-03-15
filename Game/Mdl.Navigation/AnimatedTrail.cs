using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C1A")]
	internal class AnimatedTrail : Trail
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400437B")]
		public float minSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400437C")]
		public float maxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400437D")]
		public string animatorSpeedFloat = "Speed";

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400437E")]
		private int animatorSpeedFloatHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400437F")]
		public string animatorMoveBool = "Move";

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4004380")]
		private int animatorMoveBoolHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4004381")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4004382")]
		private bool hadPath;

		[Cpp2IlInjected.Token(Token = "0x600370C")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA30", Offset = "0xA3C430", VA = "0x180A3DA30")]
		private void Start()
		{
			int num = Animator.StringToHash(animatorMoveBool);
			string text = animatorSpeedFloat;
			animatorMoveBoolHash = num;
			int num2 = (animatorSpeedFloatHash = Animator.StringToHash(text));
			Animator animator = (this.animator = GetComponentInChildren<Animator>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600370D")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAB0", Offset = "0xA3C4B0", VA = "0x180A3DAB0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0091
			//IL_007b: Expected I4, but got F4
			int num = 0;
			float speed = moverNavMeshAgent.speed;
			float num2 = maxSpeed;
			float num3 = Mathf.Clamp01(speed);
			Animator animator = this.animator;
			int id = animatorSpeedFloatHash;
			num2 = num3;
			animator.SetFloat(id, num2);
			if (!moverNavMeshAgent.hasPath || !hadPath)
			{
			}
			NavMeshAgent navMeshAgent = moverNavMeshAgent;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Animator animator2 = this.animator;
			int id2 = animatorMoveBoolHash;
			animator2.SetBool(id2, (byte)(int)z != 0);
			bool flag = (hadPath = moverNavMeshAgent.hasPath);
		}

		[Cpp2IlInjected.Token(Token = "0x600370E")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAB0", Offset = "0xA3C4B0", VA = "0x180A3DAB0")]
		private void UpdateAnimation()
		{
			//Discarded unreachable code: IL_0091
			//IL_007b: Expected I4, but got F4
			int num = 0;
			float speed = moverNavMeshAgent.speed;
			float num2 = maxSpeed;
			float num3 = Mathf.Clamp01(speed);
			Animator animator = this.animator;
			int id = animatorSpeedFloatHash;
			num2 = num3;
			animator.SetFloat(id, num2);
			if (!moverNavMeshAgent.hasPath || !hadPath)
			{
			}
			NavMeshAgent navMeshAgent = moverNavMeshAgent;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Animator animator2 = this.animator;
			int id2 = animatorMoveBoolHash;
			animator2.SetBool(id2, (byte)(int)z != 0);
			bool flag = (hadPath = moverNavMeshAgent.hasPath);
		}

		[Cpp2IlInjected.Token(Token = "0x600370F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBD0", Offset = "0xA3C5D0", VA = "0x180A3DBD0")]
		public AnimatedTrail()
		{
		}
	}
}
