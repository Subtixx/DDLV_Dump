using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

[Cpp2IlInjected.Token(Token = "0x200003B")]
public class RootMotionController : MonoBehaviour
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class configuration
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public enum TranslationType
		{
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			transform,
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			rigidbody
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[ExtendLabel(64f, 32f)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[ExtendLabel(122f, 32f)]
		public Transform transformAffected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[ExtendLabel(107f, 32f)]
		public TranslationType translationType = TranslationType.rigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[ReadOnly]
		public Rigidbody2D rigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public bool relativeByHorizontalFacing;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3D88E90", Offset = "0x3D87890", VA = "0x183D88E90")]
		public configuration()
		{
		}//IL_0009: Expected I4, but got I8

	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class status
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[ReadOnly]
		public Vector3 DeltaPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[ReadOnly]
		public Quaternion DeltaRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[ReadOnly]
		public Vector3 TotalDisplacement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[HideInInspector]
		public bool _animatorSimulatedBkp;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public status()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[Tooltip("Toogle this to enable or disable root movement")]
	public bool EnableRootMovement;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public bool defaultEnableRootMovement;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public configuration Configuration;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public status Status;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public UnityEvent _ev;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	public void teste(GameObject obj)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	public void teste2(GameObject obj, float ints)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1120", Offset = "0x3DBFB20", VA = "0x183DC1120")]
	private void Start()
	{
		bool flag = (defaultEnableRootMovement = EnableRootMovement);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0E60", Offset = "0x3DBF860", VA = "0x183DC0E60")]
	private unsafe void OnAnimatorMove()
	{
		//Discarded unreachable code: IL_0094
		//IL_0055: Expected native int or pointer, but got O
		//IL_008e: Expected native int or pointer, but got O
		if (EnableRootMovement)
		{
			Animator animator = Configuration.animator;
			Transform transformAffected = Configuration.transformAffected;
			Transform transform = transformAffected.transform;
			Vector3 localScale = transformAffected.localScale;
			int num = 0;
			status status = Status;
			float z = status.DeltaPosition.z;
			((Vector3*)(IntPtr)status.DeltaPosition)->z = z;
			status status2 = Status;
			Animator animator2 = Configuration.animator;
			status status3 = Status;
			float z2 = status3.TotalDisplacement.z;
			((Vector3*)(IntPtr)status3.TotalDisplacement)->z = z2;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0CC0", Offset = "0x3DBF6C0", VA = "0x183DC0CC0")]
	private unsafe void FixedUpdate()
	{
		//Discarded unreachable code: IL_00b6
		//IL_0084: Expected O, but got I4
		//IL_00a1: Expected native int or pointer, but got O
		configuration configuration = Configuration;
		if (configuration.translationType == configuration.TranslationType.rigidbody && EnableRootMovement)
		{
			configuration.rigidbody.simulated = true;
			Rigidbody2D rigidbody = Configuration.rigidbody;
			int num = 0;
			Vector2 position = rigidbody.position;
			configuration configuration2 = Configuration;
			if (configuration2.relativeByHorizontalFacing)
			{
				Transform transform = configuration2.animator.transform;
				int num2 = 0;
				status status = Status;
			}
			float z = Status.DeltaPosition.z;
			rigidbody.MovePosition((Vector2)num);
			status status2 = Status;
			float z2 = Vector3.zero.z;
			((Vector3*)(IntPtr)status2.DeltaPosition)->z = z2;
			status status3 = Status;
			Quaternion identity = Quaternion.identity;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1130", Offset = "0x3DBFB30", VA = "0x183DC1130")]
	private unsafe void Update()
	{
		//Discarded unreachable code: IL_00ba
		//IL_002f: Expected O, but got I4
		//IL_00a5: Expected native int or pointer, but got O
		configuration configuration = Configuration;
		if (configuration.translationType == configuration.TranslationType.transform && EnableRootMovement)
		{
			Rigidbody2D rigidbody = configuration.rigidbody;
			int num = 0;
			if (rigidbody != (UnityEngine.Object)num)
			{
				Rigidbody2D rigidbody2 = Configuration.rigidbody;
				int num2 = ((rigidbody2.simulated = false) ? 1 : 0);
			}
			Transform transform = Configuration.transformAffected.transform;
			status status = Status;
			float z = status.DeltaPosition.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			float z3 = status.DeltaPosition.z;
			status status2 = Status;
			float z4 = Vector3.zero.z;
			((Vector3*)(IntPtr)status2.DeltaPosition)->z = z4;
			status status3 = Status;
			Quaternion identity = Quaternion.identity;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1310", Offset = "0x3DBFD10", VA = "0x183DC1310")]
	public unsafe void enableRootMovement()
	{
		//Discarded unreachable code: IL_0026
		//IL_0020: Expected native int or pointer, but got O
		status status = Status;
		EnableRootMovement = true;
		float z = Vector3.zero.z;
		((Vector3*)(IntPtr)status.TotalDisplacement)->z = z;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0CB0", Offset = "0x3DBF6B0", VA = "0x183DC0CB0")]
	public void DisableRootMovement()
	{
		EnableRootMovement = false;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1070", Offset = "0x3DBFA70", VA = "0x183DC1070")]
	public void ResetVelocity()
	{
		//Discarded unreachable code: IL_0037
		//IL_0015: Expected O, but got I4
		Rigidbody2D rigidbody = Configuration.rigidbody;
		int num = 0;
		if (rigidbody != (UnityEngine.Object)num)
		{
			Rigidbody2D rigidbody2 = Configuration.rigidbody;
			int num2 = 0;
			Vector2 vector = (rigidbody2.velocity = Vector2.zero);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public RootMotionController()
	{
	}
}
