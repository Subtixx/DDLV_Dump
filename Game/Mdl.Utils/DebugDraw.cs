using System;
using System.Diagnostics;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200073C")]
	internal static class DebugDraw
	{
		[Cpp2IlInjected.Token(Token = "0x6002021")]
		[Cpp2IlInjected.Address(RVA = "0x1618730", Offset = "0x1617130", VA = "0x181618730")]
		[Conditional("DEBUG")]
		internal static void Square(Vector3 startPosition, Vector3 endPosition, Color color, bool withCenter = true, float duration = 0.1f)
		{
			int num = 0;
			float z = startPosition.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002022")]
		[Cpp2IlInjected.Address(RVA = "0x1618930", Offset = "0x1617330", VA = "0x181618930")]
		[Conditional("DEBUG")]
		internal static void Square(Vector3 position, Color color, float size = 0.25f, bool withCenter = true, float duration = 0.1f)
		{
			int num = 0;
			float z = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002023")]
		[Cpp2IlInjected.Address(RVA = "0x1617E70", Offset = "0x1616870", VA = "0x181617E70")]
		[Conditional("DEBUG")]
		internal static void Position(Vector3 position, Color color, float rootRadius = 0.1f, float duration = 0.1f)
		{
			Vector3 up = Vector3.up;
			float z = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002024")]
		[Cpp2IlInjected.Address(RVA = "0x1618CC0", Offset = "0x16176C0", VA = "0x181618CC0")]
		[Conditional("DEBUG")]
		internal static void Transform(Transform transform, float duration = 0.1f)
		{
			//Discarded unreachable code: IL_0066
			float z = Vector3.up.z;
			bool flag = default(bool);
			if (!flag)
			{
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
				Color red = Color.red;
				int num = 0;
				Vector3 vector2 = default(Vector3);
				float z3 = vector2.z;
				Color blue = Color.blue;
				Vector3 vector3 = default(Vector3);
				float z4 = vector3.z;
				Color green = Color.green;
			}
			Vector3 vector4 = default(Vector3);
			float z5 = vector4.z;
			Color red2 = Color.red;
			int num2 = 0;
			Vector3 vector5 = default(Vector3);
			float z6 = vector5.z;
			Color blue2 = Color.blue;
		}

		[Cpp2IlInjected.Token(Token = "0x6002025")]
		[Cpp2IlInjected.Address(RVA = "0x1617A70", Offset = "0x1616470", VA = "0x181617A70")]
		[Conditional("DEBUG")]
		internal static void Direction(Vector3 position, Vector3 direction, Color color, float duration = 0.1f)
		{
			float z = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6002026")]
		[Cpp2IlInjected.Address(RVA = "0x1619250", Offset = "0x1617C50", VA = "0x181619250")]
		internal static Vector3 TweakOffset(Transform t, float amount = 0.05f)
		{
			float z = t.position.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			Vector3 vector2 = default(Vector3);
			float z3 = vector2.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002027")]
		[Cpp2IlInjected.Address(RVA = "0x1617560", Offset = "0x1615F60", VA = "0x181617560")]
		[Conditional("DEBUG")]
		internal static void Bool(Vector3 position, bool value, Color color, float duration = 0.1f)
		{
			if (value)
			{
				int num = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002028")]
		[Cpp2IlInjected.Address(RVA = "0x1617790", Offset = "0x1616190", VA = "0x181617790")]
		[Conditional("DEBUG")]
		internal static void Circle(Vector3 position, float radius, Color color, int segments = 12, float duration = 0.1f)
		{
			int num = 0;
			if (segments > 0)
			{
				float z = position.z;
				int num2 = 0;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002029")]
		[Cpp2IlInjected.Address(RVA = "0x16182D0", Offset = "0x1616CD0", VA = "0x1816182D0")]
		[Conditional("DEBUG")]
		internal static void Sphere(Vector3 position, float radius, Color color, int segments = 12, float duration = 0.1f)
		{
			int num = 0;
			if (segments > 0)
			{
				float z = position.z;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600202A")]
		[Cpp2IlInjected.Address(RVA = "0x1617C20", Offset = "0x1616620", VA = "0x181617C20")]
		[Conditional("DEBUG")]
		internal static void Path(NavMeshPath path, Color startColor, Color endColor, float duration = 0.1f)
		{
			//Discarded unreachable code: IL_0038
			if (path.corners.Length > 2)
			{
				int num = 0;
				Vector3[] corners = path.corners;
				if (1 < corners.Length)
				{
					Vector3[] corners2 = path.corners;
					Vector3[] corners3 = path.corners;
					Vector3[] corners4 = path.corners;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600202B")]
		[Cpp2IlInjected.Address(RVA = "0x1618160", Offset = "0x1616B60", VA = "0x181618160")]
		[Conditional("DEBUG")]
		internal static void SphereCast(Ray ray, float radius, float distance, Color color, float duration = 0.1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600202C")]
		[Cpp2IlInjected.Address(RVA = "0x1617FA0", Offset = "0x16169A0", VA = "0x181617FA0")]
		[Conditional("DEBUG")]
		internal static void RayCast(Ray ray, float distance, RaycastHit? hit, Color color, float duration = 0.1f)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600202D")]
		[Cpp2IlInjected.Address(RVA = "0x1618130", Offset = "0x1616B30", VA = "0x181618130")]
		[Conditional("DEBUG")]
		internal static void RaycastHits(Ray ray, int numberOfHits, RaycastHit[] hits, Color color, float duration = 0.1f)
		{
			//Discarded unreachable code: IL_000b
			int num = 0;
			if (numberOfHits > 0)
			{
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600202E")]
		[Cpp2IlInjected.Address(RVA = "0x1617BB0", Offset = "0x16165B0", VA = "0x181617BB0")]
		private static Vector2 OnCircle(int segment, int maxSegments)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600202F")]
		[Cpp2IlInjected.Address(RVA = "0x16193D0", Offset = "0x1617DD0", VA = "0x1816193D0")]
		private unsafe static Vector3 XZ(Vector2 v)
		{
			//IL_0006: Expected native int or pointer, but got O
			((Vector2*)(IntPtr)v)->y = 0f;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002030")]
		[Cpp2IlInjected.Address(RVA = "0x16193A0", Offset = "0x1617DA0", VA = "0x1816193A0")]
		private unsafe static Vector3 XY(Vector2 v)
		{
			//IL_0007: Expected F4, but got I4
			//IL_0002: Expected native int or pointer, but got O
			((Vector2*)(IntPtr)v)->y = 0f;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002031")]
		[Cpp2IlInjected.Address(RVA = "0x1619400", Offset = "0x1617E00", VA = "0x181619400")]
		private unsafe static Vector3 YZ(Vector2 v)
		{
			//IL_0007: Expected F4, but got I4
			//IL_0002: Expected native int or pointer, but got O
			((Vector2*)(IntPtr)v)->y = 0f;
			/*Error: Unexpected end of block*/;
		}
	}
}
