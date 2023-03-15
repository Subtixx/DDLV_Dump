using System.Diagnostics;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000031")]
public class CameraCollisionModifier : CameraModifier
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[SerializeField]
	private float sphereCastCollisionRadius = 0.1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[SerializeField]
	private float sphereCastCollisionOverlapRadius = 0.3f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private int sphereCastMask = -1;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x16496A0", Offset = "0x16480A0", VA = "0x1816496A0")]
	private void Start()
	{
		//Discarded unreachable code: IL_0058
		//IL_0057: Expected I4, but got O
		string[] array2;
		while (true)
		{
			string[] array = new string[1];
			if ("Ground" == null || array != null)
			{
				array[0] = "Ground";
				int mask = LayerMask.GetMask(array);
				array2 = new string[1];
				if ("CameraCollision" == null || array2 != null)
				{
					break;
				}
			}
		}
		array2[0] = "CameraCollision";
		int mask2 = LayerMask.GetMask(array2);
		sphereCastMask = (int)typeof(Positions).TypeHandle;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	private void OnDisable()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1649100", Offset = "0x1647B00", VA = "0x181649100")]
	private void LateUpdate()
	{
		//Discarded unreachable code: IL_00d6
		//IL_0010: Expected O, but got I4
		//IL_00bc: Expected O, but got I4
		//IL_00d5: Expected O, but got I4
		GameObject gameObject = base.targetObject;
		int num = 0;
		if (gameObject != (Object)num)
		{
			Transform transform = base.Camera.transform;
			Transform transform2 = base.targetObject.transform;
			Transform transform3 = base.Camera.transform;
			Transform transform4 = base.Camera.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			bool flag = default(bool);
			if (flag)
			{
				Transform transform5 = base.Camera.transform;
				Transform transform6 = base.Camera.transform;
				Transform transform7 = base.Camera.transform;
				Transform transform8 = base.Camera.transform;
				float num2 = sphereCastCollisionRadius;
				float num3 = sphereCastCollisionOverlapRadius;
				int num4 = sphereCastMask;
				Camera camera = base.Camera;
				int num5 = 0;
				camera.transform.position = (Vector3)num5;
				Camera camera2 = base.Camera;
				int num6 = 0;
				camera2.transform.LookAt((Vector3)num6);
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1649040", Offset = "0x1647A40", VA = "0x181649040")]
	[Conditional("DEBUG_CAMERA_COLLISION_MODIFIER")]
	private void DebugDrawClippedCameraPosition(Vector3 cameraPosition, Vector3 clippedPosition)
	{
		Color white = Color.white;
		float z = clippedPosition.z;
		float z2 = cameraPosition.z;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1649620", Offset = "0x1648020", VA = "0x181649620")]
	[Conditional("DEBUG_CAMERA_COLLISION_MODIFIER")]
	private void LogDebug(string message)
	{
		UnityEngine.Debug.Log("CameraCollisionModifier:  " + message);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	[Conditional("DEBUG_CAMERA_COLLISION_MODIFIER")]
	private void OnscreenDebug<T>(string field, T value)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	[Conditional("DEBUG_CAMERA_COLLISION_MODIFIER")]
	private void ResetOnscreenDebug()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x16498A0", Offset = "0x16482A0", VA = "0x1816498A0")]
	public CameraCollisionModifier()
	{
		//IL_0026: Expected I4, but got I8
		int debug = default(int);
		CountedBool countedBool = new CountedBool("", (byte)debug != 0);
		debug = 0;
		base.shouldBeActive = countedBool;
		((MonoBehaviour)this)._002Ector();
	}
}
