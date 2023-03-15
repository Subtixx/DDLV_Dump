using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C25")]
	public static class CameraUtil
	{
		[Cpp2IlInjected.Token(Token = "0x1700075E")]
		public static Plane FloorPlane
		{
			[Cpp2IlInjected.Token(Token = "0x6003748")]
			[Cpp2IlInjected.Address(RVA = "0x12D7820", Offset = "0x12D6220", VA = "0x1812D7820")]
			get
			{
				float z = Vector3.up.z;
				Vector3 zero = Vector3.zero;
				int num = 0;
				float z2 = zero.z;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700075F")]
		public static bool IsInTransition
		{
			[Cpp2IlInjected.Token(Token = "0x6003752")]
			[Cpp2IlInjected.Address(RVA = "0x12D78A0", Offset = "0x12D62A0", VA = "0x1812D78A0")]
			[CompilerGenerated]
			get
			{
				//IL_0006: Expected I4, but got O
				return (byte)(int)typeof(CameraUtil).TypeHandle != 0;
			}
			[Cpp2IlInjected.Token(Token = "0x6003753")]
			[Cpp2IlInjected.Address(RVA = "0x12D7900", Offset = "0x12D6300", VA = "0x1812D7900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003749")]
		[Cpp2IlInjected.Address(RVA = "0x12D7490", Offset = "0x12D5E90", VA = "0x1812D7490")]
		public static Vector3 PosOnPlaneFromViewport(Vector2 viewPortPos, Plane plane, Camera camera)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600374A")]
		[Cpp2IlInjected.Address(RVA = "0x12D7390", Offset = "0x12D5D90", VA = "0x1812D7390")]
		public static Vector3 PosOnPlaneFromScreen(Vector2 screenPos, Plane plane, Camera camera)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600374B")]
		[Cpp2IlInjected.Address(RVA = "0x12D7250", Offset = "0x12D5C50", VA = "0x1812D7250")]
		public static Vector3 PosOnPlaneFromCamera(Plane plane, Camera camera)
		{
			int num = 0;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600374C")]
		[Cpp2IlInjected.Address(RVA = "0x12D77F0", Offset = "0x12D61F0", VA = "0x1812D77F0")]
		public static float ZoomModifier(float zoom, float minZoom, float maxZoom, float zoomModifierAtMin)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600374D")]
		[Cpp2IlInjected.Address(RVA = "0x12D6D70", Offset = "0x12D5770", VA = "0x1812D6D70")]
		public static Vector3 FlatForward(Camera camera)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600374E")]
		[Cpp2IlInjected.Address(RVA = "0x12D6E80", Offset = "0x12D5880", VA = "0x1812D6E80")]
		public static Vector3 FlatRight(Camera camera)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600374F")]
		[Cpp2IlInjected.Address(RVA = "0x12D6CC0", Offset = "0x12D56C0", VA = "0x1812D6CC0")]
		public static Vector3 FlatForward(Transform transform)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003750")]
		[Cpp2IlInjected.Address(RVA = "0x12D6F90", Offset = "0x12D5990", VA = "0x1812D6F90")]
		public static Vector3 FlatRight(Transform transform)
		{
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003751")]
		[Cpp2IlInjected.Address(RVA = "0x12D7590", Offset = "0x12D5F90", VA = "0x1812D7590")]
		public static Vector3 PositionInBoundaries(Transform cameraTransform, Vector3 position, Boundaries boundaries)
		{
			int num = 0;
			Vector3 up = Vector3.up;
			float z = Vector3.zero.z;
			int num2 = 0;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (!flag || !flag2)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003754")]
		[Cpp2IlInjected.Address(RVA = "0x12D6B40", Offset = "0x12D5540", VA = "0x1812D6B40")]
		[AsyncStateMachine(typeof(_003CCameraTransition_003Ed__15))]
		public static Task CameraTransition(Transform cameraTransform, Vector3 position, Quaternion rotation, CancellationToken ct, float duration = 1f, [Optional] bool? fadeOut, [Optional] Boundaries boundaries)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003755")]
		[Cpp2IlInjected.Address(RVA = "0x12D71A0", Offset = "0x12D5BA0", VA = "0x1812D71A0")]
		public static bool IsCameraInDesiredPlacement(Transform cameraTransform, Vector3 desiredPosition, Quaternion desiredRotation)
		{
			//Discarded unreachable code: IL_0017
			float z = desiredPosition.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003756")]
		[Cpp2IlInjected.Address(RVA = "0x12D7040", Offset = "0x12D5A40", VA = "0x1812D7040")]
		public static Boundaries GetCurrentBoundaries()
		{
			//Discarded unreachable code: IL_0033
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			SceneItemData sceneItemData = sceneData.sceneItemData;
			int includeInactive = 0;
			GameObject gameObject = default(GameObject);
			return gameObject.GetComponentInChildren<Boundaries>((byte)includeInactive != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003757")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		static CameraUtil()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
