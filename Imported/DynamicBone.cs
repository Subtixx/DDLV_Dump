using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000002")]
[AddComponentMenu("Dynamic Bone/Dynamic Bone")]
public class DynamicBone : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum UpdateMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		AnimatePhysics,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		UnscaledTime,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Default
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum FreezeAxis
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		X,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Z
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class Particle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Transform m_Transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int m_ParentIndex = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float m_Damping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float m_Elasticity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float m_Stiffness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float m_Inert;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float m_Friction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float m_Radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float m_BoneLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool m_isCollide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Vector3 m_Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Vector3 m_PrevPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Vector3 m_EndOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Vector3 m_InitLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Quaternion m_InitLocalRotation;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3DC05E0", Offset = "0x3DBEFE0", VA = "0x183DC05E0")]
		public unsafe Particle()
		{
			//IL_0010: Expected I4, but got I8
			//IL_0022: Expected native int or pointer, but got O
			//IL_0039: Expected native int or pointer, but got O
			//IL_0050: Expected native int or pointer, but got O
			//IL_0067: Expected native int or pointer, but got O
			float z = Vector3.zero.z;
			((Vector3*)(IntPtr)m_Position)->z = z;
			float z2 = Vector3.zero.z;
			((Vector3*)(IntPtr)m_PrevPosition)->z = z2;
			float z3 = Vector3.zero.z;
			((Vector3*)(IntPtr)m_EndOffset)->z = z3;
			float z4 = Vector3.zero.z;
			((Vector3*)(IntPtr)m_InitLocalPosition)->z = z4;
			Quaternion identity = Quaternion.identity;
			base._002Ector();
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[Tooltip("The root of the transform hierarchy to apply physics.")]
	public Transform m_Root;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[Tooltip("Internal physics simulation rate.")]
	public float m_UpdateRate = 60f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public UpdateMode m_UpdateMode = UpdateMode.Default;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[Tooltip("How much the bones slowed down.")]
	[Range(0f, 1f)]
	public float m_Damping = 0.1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public AnimationCurve m_DampingDistrib;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Tooltip("How much the force applied to return each bone to original orientation.")]
	[Range(0f, 1f)]
	public float m_Elasticity = 0.1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public AnimationCurve m_ElasticityDistrib;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[Tooltip("How much bone's original orientation are preserved.")]
	[Range(0f, 1f)]
	public float m_Stiffness = 0.1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public AnimationCurve m_StiffnessDistrib;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Range(0f, 1f)]
	[Tooltip("How much character's position change is ignored in physics simulation.")]
	public float m_Inert;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public AnimationCurve m_InertDistrib;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[Tooltip("How much the bones slowed down when collide.")]
	public float m_Friction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public AnimationCurve m_FrictionDistrib;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Each bone can be a sphere to collide with colliders. Radius describe sphere's size.")]
	public float m_Radius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public AnimationCurve m_RadiusDistrib;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Tooltip("If End Length is not zero, an extra bone is generated at the end of transform hierarchy.")]
	public float m_EndLength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[Tooltip("If End Offset is not zero, an extra bone is generated at the end of transform hierarchy.")]
	public Vector3 m_EndOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[Tooltip("The force apply to bones. Partial force apply to character's initial pose is cancelled out.")]
	public Vector3 m_Gravity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[Tooltip("The force apply to bones.")]
	public Vector3 m_Force;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[Tooltip("Collider objects interact with the bones.")]
	public List<DynamicBoneColliderBase> m_Colliders;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[Tooltip("Bones exclude from physics simulation.")]
	public List<Transform> m_Exclusions;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[Tooltip("Constrain bones to move on specified plane.")]
	public FreezeAxis m_FreezeAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[Tooltip("Disable physics simulation automatically if character is far from camera or player.")]
	public bool m_DistantDisable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Transform m_ReferenceObject;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float m_DistanceToObject;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Vector3 m_LocalGravity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Vector3 m_ObjectMove;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Vector3 m_ObjectPrevPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float m_BoneTotalLength;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private float m_ObjectScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private float m_Time;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private float m_Weight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private bool m_DistantDisabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private List<Particle> m_Particles;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2F0EB50", Offset = "0x2F0D550", VA = "0x182F0EB50")]
	private void Start()
	{
		SetupParticles();
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2F0D910", Offset = "0x2F0C310", VA = "0x182F0D910")]
	private void FixedUpdate()
	{
		//IL_0014: Invalid comparison between F4 and I4
		if (m_UpdateMode == UpdateMode.AnimatePhysics)
		{
			float weight = m_Weight;
			int num = 0;
			if (!(weight <= (float)num) && (!m_DistantDisable || !m_DistantDisabled))
			{
				InitTransforms();
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2F100D0", Offset = "0x2F0EAD0", VA = "0x182F100D0")]
	private void Update()
	{
		//IL_0014: Invalid comparison between F4 and I4
		if (m_UpdateMode != UpdateMode.AnimatePhysics)
		{
			float weight = m_Weight;
			int num = 0;
			if (!(weight <= (float)num) && (!m_DistantDisable || !m_DistantDisabled))
			{
				InitTransforms();
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2F0DAC0", Offset = "0x2F0C4C0", VA = "0x182F0DAC0")]
	private void LateUpdate()
	{
		//IL_001a: Invalid comparison between F4 and I4
		if (m_DistantDisable)
		{
			CheckDistance();
		}
		float weight = m_Weight;
		int num = 0;
		if (!(weight <= (float)num) && (!m_DistantDisable || !m_DistantDisabled))
		{
			int num2 = 0;
			if (m_UpdateMode == UpdateMode.UnscaledTime)
			{
				float unscaledDeltaTime = Time.unscaledDeltaTime;
			}
			weight = Time.deltaTime;
			UpdateDynamicBones(weight);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2F0DF20", Offset = "0x2F0C920", VA = "0x182F0DF20")]
	private void PreUpdate()
	{
		//IL_000b: Invalid comparison between F4 and I4
		float weight = m_Weight;
		int num = 0;
		if (!(weight <= (float)num) && (!m_DistantDisable || !m_DistantDisabled))
		{
			InitTransforms();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2F0D720", Offset = "0x2F0C120", VA = "0x182F0D720")]
	private void CheckDistance()
	{
		//Discarded unreachable code: IL_0083
		//IL_0010: Expected O, but got I4
		//IL_0026: Expected O, but got I4
		//IL_0043: Expected O, but got I4
		//IL_0082: Expected I4, but got O
		Transform referenceObject = m_ReferenceObject;
		int num = 0;
		if (referenceObject == (UnityEngine.Object)num)
		{
			int num2 = 0;
			Camera main = Camera.main;
			int num3 = 0;
			if (main != (UnityEngine.Object)num3)
			{
				int num4 = 0;
				Transform transform = Camera.main.transform;
			}
		}
		int num5 = 0;
		if (!(referenceObject != (UnityEngine.Object)num5))
		{
			return;
		}
		Vector3 vector = default(Vector3);
		float z = vector.z;
		Transform transform2 = base.transform;
		Vector3 vector2 = default(Vector3);
		float z2 = vector2.z;
		float distanceToObject = m_DistanceToObject;
		if ((IntPtr)referenceObject != (IntPtr)(m_DistantDisabled ? 1 : 0))
		{
			if ((object)referenceObject == null)
			{
				ResetParticlesPosition();
			}
			m_DistantDisabled = (byte)(int)referenceObject != 0;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2F0DE50", Offset = "0x2F0C850", VA = "0x182F0DE50")]
	private void OnEnable()
	{
		ResetParticlesPosition();
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2F0DC10", Offset = "0x2F0C610", VA = "0x182F0DC10")]
	private void OnDisable()
	{
		InitTransforms();
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2F0DE60", Offset = "0x2F0C860", VA = "0x182F0DE60")]
	private void OnValidate()
	{
		//IL_0010: Expected F4, but got I4
		//IL_0093: Expected F4, but got I4
		float updateRate = m_UpdateRate;
		int num = 0;
		float num2 = (m_UpdateRate = Mathf.Max(updateRate, num));
		float num3 = (m_Damping = Mathf.Clamp01(m_Damping));
		float num4 = (m_Elasticity = Mathf.Clamp01(m_Elasticity));
		float num5 = (m_Stiffness = Mathf.Clamp01(m_Stiffness));
		float num6 = (m_Inert = Mathf.Clamp01(m_Inert));
		float num7 = (m_Friction = Mathf.Clamp01(m_Friction));
		float radius = m_Radius;
		int num8 = 0;
		float radius2 = Mathf.Max(radius, num8);
		int num9 = 0;
		m_Radius = radius2;
		if (Application.webSecurityEnabled)
		{
			int num10 = 0;
			if (Application.isPlaying)
			{
				InitTransforms();
				SetupParticles();
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2F0DC20", Offset = "0x2F0C620", VA = "0x182F0DC20")]
	private void OnDrawGizmosSelected()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E130", Offset = "0x2F0CB30", VA = "0x182F0E130")]
	public void SetWeight(float w)
	{
		//Discarded unreachable code: IL_000e
		//IL_001b: Expected F4, but got I4
		InitTransforms();
		m_Weight = w;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2F0D950", Offset = "0x2F0C350", VA = "0x182F0D950")]
	public float GetWeight()
	{
		return m_Weight;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2F0EB60", Offset = "0x2F0D560", VA = "0x182F0EB60")]
	private unsafe void UpdateDynamicBones(float t)
	{
		//Discarded unreachable code: IL_00ec
		//IL_0010: Expected O, but got I4
		//IL_0043: Expected native int or pointer, but got O
		//IL_0069: Expected native int or pointer, but got O
		//IL_007e: Invalid comparison between F4 and I4
		//IL_00a6: Invalid comparison between F4 and I4
		//IL_00da: Expected native int or pointer, but got O
		//IL_00e3: Invalid comparison between F4 and I4
		Transform root = m_Root;
		int num = 0;
		if (root == (UnityEngine.Object)num)
		{
			return;
		}
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		float z = m_ObjectPrevPosition.z;
		Vector3 vector = default(Vector3);
		float z2 = vector.z;
		((Vector3*)(IntPtr)m_ObjectMove)->z = z2;
		Transform transform3 = base.transform;
		float updateRate = m_UpdateRate;
		Vector3 vector2 = default(Vector3);
		float z3 = vector2.z;
		((Vector3*)(IntPtr)m_ObjectPrevPosition)->z = z3;
		int num2 = 0;
		if (m_UpdateMode != UpdateMode.Default)
		{
			if (updateRate <= (float)num2)
			{
				goto IL_00b6;
			}
			m_Time = t;
			m_Time = t;
			m_Time = 0f;
			SkipUpdateParticles();
		}
		int num3 = 0;
		if (!(updateRate > (float)num2))
		{
			float deltaTime = Time.deltaTime;
		}
		float deltaTime2 = Time.deltaTime;
		goto IL_00b6;
		IL_00b6:
		UpdateParticles1(updateRate);
		UpdateParticles2(updateRate);
		float z4 = Vector3.zero.z;
		((Vector3*)(IntPtr)m_ObjectMove)->z = z4;
		while (updateRate != (float)num2)
		{
		}
		ApplyParticlesToTransforms();
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E1A0", Offset = "0x2F0CBA0", VA = "0x182F0E1A0")]
	public unsafe void SetupParticles()
	{
		//Discarded unreachable code: IL_00b6
		//IL_001b: Expected O, but got I4
		//IL_0045: Expected native int or pointer, but got O
		//IL_006b: Expected native int or pointer, but got O
		//IL_0093: Expected native int or pointer, but got O
		//IL_00a3: Expected F4, but got I4
		//IL_00ae: Expected F4, but got I4
		((List<T>)(object)m_Particles).Clear();
		Transform root = m_Root;
		int num = 0;
		if (!(root == (UnityEngine.Object)num))
		{
			Transform root2 = m_Root;
			float z = m_Gravity.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			((Vector3*)(IntPtr)m_LocalGravity)->z = z2;
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Vector3 vector2 = default(Vector3);
			float z3 = vector2.z;
			((Vector3*)(IntPtr)m_ObjectPrevPosition)->z = z3;
			Vector3 zero = Vector3.zero;
			Transform root3 = m_Root;
			int num2 = 0;
			float z4 = zero.z;
			((Vector3*)(IntPtr)m_ObjectMove)->z = z4;
			int num3 = 0;
			m_BoneTotalLength = num3;
			AppendParticles(root3, -1, num2);
			UpdateParameters();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2F0CC90", Offset = "0x2F0B690", VA = "0x182F0CC90")]
	private void AppendParticles(Transform b, int parentIndex, float boneLength)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2F0EDD0", Offset = "0x2F0D7D0", VA = "0x182F0EDD0")]
	public void UpdateParameters()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2F0D960", Offset = "0x2F0C360", VA = "0x182F0D960")]
	private void InitTransforms()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2F0DF50", Offset = "0x2F0C950", VA = "0x182F0DF50")]
	private void ResetParticlesPosition()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F1B0", Offset = "0x2F0DBB0", VA = "0x182F0F1B0")]
	private void UpdateParticles1(float timeVar)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2F0F5F0", Offset = "0x2F0DFF0", VA = "0x182F0F5F0")]
	private void UpdateParticles2(float timeVar)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2F0E340", Offset = "0x2F0CD40", VA = "0x182F0E340")]
	private void SkipUpdateParticles()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2F0DB30", Offset = "0x2F0C530", VA = "0x182F0DB30")]
	private unsafe static Vector3 MirrorVector(Vector3 v, Vector3 axis)
	{
		//IL_0009: Expected native int or pointer, but got O
		float num = (((Vector3*)(IntPtr)v)->z = axis.z);
		return v;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2F0D3C0", Offset = "0x2F0BDC0", VA = "0x182F0D3C0")]
	private void ApplyParticlesToTransforms()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2F10110", Offset = "0x2F0EB10", VA = "0x182F10110")]
	public unsafe DynamicBone()
	{
		//IL_0014: Expected I4, but got I8
		//IL_0047: Expected native int or pointer, but got O
		//IL_005e: Expected native int or pointer, but got O
		//IL_0075: Expected native int or pointer, but got O
		//IL_0097: Expected native int or pointer, but got O
		//IL_00b0: Expected native int or pointer, but got O
		//IL_00c9: Expected native int or pointer, but got O
		float z = Vector3.zero.z;
		((Vector3*)(IntPtr)m_EndOffset)->z = z;
		float z2 = Vector3.zero.z;
		((Vector3*)(IntPtr)m_Gravity)->z = z2;
		float z3 = Vector3.zero.z;
		((Vector3*)(IntPtr)m_Force)->z = z3;
		m_DistanceToObject = 20f;
		float z4 = Vector3.zero.z;
		((Vector3*)(IntPtr)m_LocalGravity)->z = z4;
		float z5 = Vector3.zero.z;
		((Vector3*)(IntPtr)m_ObjectMove)->z = z5;
		float z6 = Vector3.zero.z;
		((Vector3*)(IntPtr)m_ObjectPrevPosition)->z = z6;
		m_ObjectScale = 1f;
		m_Weight = 1f;
		m_Particles = (List<Particle>)(object)new List<T>();
		base._002Ector();
	}
}
