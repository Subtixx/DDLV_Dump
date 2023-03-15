using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000798")]
	public static class Positions
	{
		[Cpp2IlInjected.Token(Token = "0x170004AE")]
		public static int IgnoreRaycastMask
		{
			[Cpp2IlInjected.Token(Token = "0x60021A9")]
			[Cpp2IlInjected.Address(RVA = "0xCB6710", Offset = "0xCB5110", VA = "0x180CB6710")]
			[CompilerGenerated]
			get
			{
				//IL_0006: Expected I4, but got O
				return (int)typeof(Positions).TypeHandle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021AA")]
		[Cpp2IlInjected.Address(RVA = "0xCB3660", Offset = "0xCB2060", VA = "0x180CB3660")]
		public static Vector2 Average(Vector2 pos1, Vector2 pos2)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60021AB")]
		[Cpp2IlInjected.Address(RVA = "0xCB3590", Offset = "0xCB1F90", VA = "0x180CB3590")]
		public unsafe static Vector3 Average(Vector3 pos1, Vector3 pos2)
		{
			//IL_0017: Expected native int or pointer, but got O
			float z = pos2.z;
			float z2 = pos2.z;
			float z3 = pos2.z;
			((Vector3*)(IntPtr)pos1)->z = z2;
			return pos1;
		}

		[Cpp2IlInjected.Token(Token = "0x60021AC")]
		[Cpp2IlInjected.Address(RVA = "0xCB36B0", Offset = "0xCB20B0", VA = "0x180CB36B0")]
		public static Vector3 Average(List<Vector3> positions)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			bool flag = default(bool);
			if (flag)
			{
			}
			float z = Vector3.zero.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021AD")]
		[Cpp2IlInjected.Address(RVA = "0xCB62F0", Offset = "0xCB4CF0", VA = "0x180CB62F0")]
		public static Vector2 ToLocalPos(Vector2 screenPos, RectTransform rect, Camera camera)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60021AE")]
		[Cpp2IlInjected.Address(RVA = "0xCB42C0", Offset = "0xCB2CC0", VA = "0x180CB42C0")]
		public static bool IsHitByRaycast2D(Vector2 screenPos, RectTransform rect)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60021AF")]
		[Cpp2IlInjected.Address(RVA = "0xCB4120", Offset = "0xCB2B20", VA = "0x180CB4120")]
		public static bool IsHitByChildRaycast2D(Vector2 screenPos, RectTransform parentRect)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60021B0")]
		[Cpp2IlInjected.Address(RVA = "0xCB4920", Offset = "0xCB3320", VA = "0x180CB4920")]
		public static RaycastResult? Raycast2D(Vector2 screenPos)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60021B1")]
		[Cpp2IlInjected.Address(RVA = "0xCB5960", Offset = "0xCB4360", VA = "0x180CB5960")]
		public static RaycastHit? Raycast3D(Vector2 screenPos, Camera camera, Collider target, QueryTriggerInteraction triggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021B2")]
		[Cpp2IlInjected.Address(RVA = "0xCB51C0", Offset = "0xCB3BC0", VA = "0x180CB51C0")]
		public static RaycastHit? Raycast3D(Vector3 origin, Vector3 direction, Collider target, float maxDistance = float.MaxValue, QueryTriggerInteraction triggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			int num = 0;
			int num2 = 0;
			float z = direction.z;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60021B3")]
		[Cpp2IlInjected.Address(RVA = "0xCB56A0", Offset = "0xCB40A0", VA = "0x180CB56A0")]
		public unsafe static RaycastHit? Raycast3D(Ray ray, Collider target, float maxDistance, QueryTriggerInteraction triggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			//IL_000f: Expected O, but got I4
			//IL_000a: Expected native int or pointer, but got O
			//IL_001b: Expected F4, but got I4
			//IL_0016: Expected native int or pointer, but got O
			//IL_0022: Expected O, but got I4
			//IL_001d: Expected native int or pointer, but got O
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			if (!flag)
			{
				((Ray*)(IntPtr)ray)->m_Origin = (Vector3)num2;
				((Vector3*)(IntPtr)ray.m_Direction)->y = num2;
			}
			((Ray*)(IntPtr)ray)->m_Origin = (Vector3)num2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021B4")]
		[Cpp2IlInjected.Address(RVA = "0xCB5020", Offset = "0xCB3A20", VA = "0x180CB5020")]
		public unsafe static RaycastHit? Raycast3D(Vector2 screenPos, Camera camera)
		{
			//IL_000d: Expected F4, but got I4
			//IL_0008: Expected native int or pointer, but got O
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
			}
			((Vector2*)(IntPtr)screenPos)->x = num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021B5")]
		[Cpp2IlInjected.Address(RVA = "0xCB5AD0", Offset = "0xCB44D0", VA = "0x180CB5AD0")]
		public unsafe static RaycastHit? Raycast3D(Vector3 origin, Vector3 direction)
		{
			//IL_000d: Expected F4, but got I4
			//IL_0008: Expected native int or pointer, but got O
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
			}
			((Vector3*)(IntPtr)origin)->x = num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60021B6")]
		[Cpp2IlInjected.Address(RVA = "0xCB5870", Offset = "0xCB4270", VA = "0x180CB5870")]
		public unsafe static RaycastHit? Raycast3D(Ray ray)
		{
			//IL_000d: Expected O, but got I4
			//IL_0008: Expected native int or pointer, but got O
			//IL_0019: Expected F4, but got I4
			//IL_0014: Expected native int or pointer, but got O
			//IL_0020: Expected O, but got I4
			//IL_001b: Expected native int or pointer, but got O
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				((Ray*)(IntPtr)ray)->m_Origin = (Vector3)num;
				((Vector3*)(IntPtr)ray.m_Direction)->y = num;
			}
			((Ray*)(IntPtr)ray)->m_Origin = (Vector3)num;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60021B7")]
		[Cpp2IlInjected.Address(RVA = "0xCB5480", Offset = "0xCB3E80", VA = "0x180CB5480")]
		public unsafe static RaycastHit? Raycast3D(Vector2 screenPos, Camera camera, int layerMask)
		{
			//IL_0014: Expected F4, but got I4
			//IL_000f: Expected native int or pointer, but got O
			//IL_001c: Expected F4, but got I4
			//IL_0017: Expected native int or pointer, but got O
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			bool flag = default(bool);
			if (!flag)
			{
				((Vector2*)(IntPtr)screenPos)->x = num3;
			}
			((Vector2*)(IntPtr)screenPos)->x = num3;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021B8")]
		[Cpp2IlInjected.Address(RVA = "0xCB52E0", Offset = "0xCB3CE0", VA = "0x180CB52E0")]
		public unsafe static RaycastHit? Raycast3D(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction triggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			//IL_000d: Expected O, but got I4
			//IL_0008: Expected native int or pointer, but got O
			//IL_0019: Expected F4, but got I4
			//IL_0014: Expected native int or pointer, but got O
			//IL_0020: Expected O, but got I4
			//IL_001b: Expected native int or pointer, but got O
			//IL_0027: Expected native int or pointer, but got O
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				((Ray*)(IntPtr)ray)->m_Origin = (Vector3)num;
				((Vector3*)(IntPtr)ray.m_Direction)->y = num;
			}
			((Ray*)(IntPtr)ray)->m_Origin = (Vector3)num;
			((Vector3*)(IntPtr)ray.m_Direction)->y = maxDistance;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60021B9")]
		[Cpp2IlInjected.Address(RVA = "0xCB5C60", Offset = "0xCB4660", VA = "0x180CB5C60")]
		public static Vector3? RaycastGround(Ray ray)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60021BA")]
		[Cpp2IlInjected.Address(RVA = "0xCB4D30", Offset = "0xCB3730", VA = "0x180CB4D30")]
		public unsafe static RaycastHit[] Raycast3DAll(Vector2 screenPos, Camera camera, int layerMask)
		{
			//Discarded unreachable code: IL_0038
			int num = 0;
			float farClipPlane = camera.farClipPlane;
			Func<RaycastHit, float> _003C_003E9__20_ = _003C_003Ec._003C_003E9__20_0;
			if (_003C_003E9__20_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((RaycastHit x) => ((RaycastHit*)x)->distance);
			}
			RaycastHit[] array = default(RaycastHit[]);
			return ((IEnumerable<>)Enumerable.OrderBy<RaycastHit, float>((IEnumerable<>)(object)array, (Func<, >)(object)_003C_003E9__20_)).ToArray<RaycastHit>();
		}

		[Cpp2IlInjected.Token(Token = "0x60021BB")]
		[Cpp2IlInjected.Address(RVA = "0xCB4B30", Offset = "0xCB3530", VA = "0x180CB4B30")]
		public unsafe static RaycastHit[] Raycast3DAll(Ray ray, float maxDistance, int layerMask)
		{
			Func<RaycastHit, float> _003C_003E9__20_ = _003C_003Ec._003C_003E9__20_0;
			if (_003C_003E9__20_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((RaycastHit x) => ((RaycastHit*)x)->distance);
			}
			RaycastHit[] array = default(RaycastHit[]);
			return ((IEnumerable<>)Enumerable.OrderBy<RaycastHit, float>((IEnumerable<>)(object)array, (Func<, >)(object)_003C_003E9__20_)).ToArray<RaycastHit>();
		}

		[Cpp2IlInjected.Token(Token = "0x60021BC")]
		[Cpp2IlInjected.Address(RVA = "0xCB6150", Offset = "0xCB4B50", VA = "0x180CB6150")]
		public unsafe static RaycastHit? SphereCast(Ray ray, float radius, float maxDistance, int layerMask)
		{
			//IL_000d: Expected O, but got I4
			//IL_0008: Expected native int or pointer, but got O
			//IL_0019: Expected F4, but got I4
			//IL_0014: Expected native int or pointer, but got O
			//IL_0020: Expected O, but got I4
			//IL_001b: Expected native int or pointer, but got O
			//IL_0027: Expected native int or pointer, but got O
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
				((Ray*)(IntPtr)ray)->m_Origin = (Vector3)num;
				((Vector3*)(IntPtr)ray.m_Direction)->y = num;
			}
			((Ray*)(IntPtr)ray)->m_Origin = (Vector3)num;
			((Vector3*)(IntPtr)ray.m_Direction)->y = radius;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60021BD")]
		[Cpp2IlInjected.Address(RVA = "0xCB5F30", Offset = "0xCB4930", VA = "0x180CB5F30")]
		public unsafe static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask)
		{
			Func<RaycastHit, float> _003C_003E9__22_ = _003C_003Ec._003C_003E9__22_0;
			if (_003C_003E9__22_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((RaycastHit x) => ((RaycastHit*)x)->distance);
			}
			RaycastHit[] array = default(RaycastHit[]);
			return ((IEnumerable<>)Enumerable.OrderBy<RaycastHit, float>((IEnumerable<>)(object)array, (Func<, >)(object)_003C_003E9__22_)).ToArray<RaycastHit>();
		}

		[Cpp2IlInjected.Token(Token = "0x60021BE")]
		[Cpp2IlInjected.Address(RVA = "0xCB3880", Offset = "0xCB2280", VA = "0x180CB3880")]
		public unsafe static (Vector2, Vector2) FindViewMinMax(Vector3[] vertices, Camera camera, bool convertToShaderSpace = false)
		{
			//IL_0019: Expected F4, but got I4
			//IL_0014: Expected native int or pointer, but got O
			int num = 0;
			if ((long)num < (long)(IntPtr)typeof(Positions).TypeHandle)
			{
				num++;
			}
			int num2 = 0;
			((Vector3*)(IntPtr)vertices)->x = num2;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021BF")]
		[Cpp2IlInjected.Address(RVA = "0xCB3A80", Offset = "0xCB2480", VA = "0x180CB3A80")]
		public unsafe static (Vector2, Vector2) FindViewMinMax(Bounds bounds, Camera camera, bool convertToShaderSpace = false)
		{
			//IL_001e: Expected O, but got I4
			//IL_0019: Expected native int or pointer, but got O
			int num = 0;
			int num2 = 0;
			Vector3[] array = default(Vector3[]);
			int length = array.Length;
			if (num2 < length)
			{
				num2++;
			}
			int num3 = 0;
			((Bounds*)(IntPtr)bounds)->m_Center = (Vector3)num3;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021C0")]
		[Cpp2IlInjected.Address(RVA = "0xCB6380", Offset = "0xCB4D80", VA = "0x180CB6380")]
		public static Vector2 WorldToView(Vector3 point, Camera camera, bool convertToShaderSpace)
		{
			float z = point.z;
			if (!convertToShaderSpace)
			{
			}
			Vector3 one = Vector3.one;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021C1")]
		[Cpp2IlInjected.Address(RVA = "0xCB3CF0", Offset = "0xCB26F0", VA = "0x180CB3CF0")]
		public static Vector3[] GetVertices(Bounds bounds)
		{
			//Discarded unreachable code: IL_0098
			//IL_0016: Expected O, but got F4
			//IL_0028: Expected O, but got F4
			//IL_003a: Expected O, but got F4
			//IL_004c: Expected O, but got F4
			//IL_005e: Expected O, but got F4
			//IL_0070: Expected O, but got F4
			//IL_0083: Expected O, but got F4
			//IL_0096: Expected O, but got F4
			Vector3[] array = new Vector3[8];
			Vector3 vector = default(Vector3);
			float z = vector.z;
			array[1] = (Vector3)z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			array[2] = (Vector3)z2;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			array[4] = (Vector3)z3;
			Vector3 vector4 = default(Vector3);
			float z4 = vector4.z;
			array[5] = (Vector3)z4;
			Vector3 vector5 = default(Vector3);
			float z5 = vector5.z;
			array[7] = (Vector3)z5;
			Vector3 vector6 = default(Vector3);
			float z6 = vector6.z;
			array[8] = (Vector3)z6;
			Vector3 vector7 = default(Vector3);
			float z7 = vector7.z;
			array[10] = (Vector3)z7;
			Vector3 vector8 = default(Vector3);
			float z8 = vector8.z;
			array[11] = (Vector3)z8;
			return array;
		}

		[Cpp2IlInjected.Token(Token = "0x60021C2")]
		[Cpp2IlInjected.Address(RVA = "0xCB4480", Offset = "0xCB2E80", VA = "0x180CB4480")]
		public static bool IsInView(Camera camera, Vector3 point, ViewMargins margins, float minDistance, float maxDistance)
		{
			Transform transform = camera.transform;
			float z = point.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			float num = default(float);
			if (!(num <= minDistance))
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021C3")]
		[Cpp2IlInjected.Address(RVA = "0xCB45E0", Offset = "0xCB2FE0", VA = "0x180CB45E0")]
		public static bool IsNotHidden(Camera camera, Vector3 point, Collider target, float maxDistance)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60021C4")]
		[Cpp2IlInjected.Address(RVA = "0xCB6440", Offset = "0xCB4E40", VA = "0x180CB6440")]
		static Positions()
		{
			//Discarded unreachable code: IL_00a6
			string[] array4;
			while (true)
			{
				string[] array = new string[1];
				if ("Ignore Raycast" != null && array == null)
				{
					continue;
				}
				array[0] = "Ignore Raycast";
				int mask = LayerMask.GetMask(array);
				string[] array2 = new string[1];
				if ("PostProcessing" != null && array2 == null)
				{
					continue;
				}
				array2[0] = "PostProcessing";
				int mask2 = LayerMask.GetMask(array2);
				string[] array3 = new string[1];
				if ("CookingMiniGame" == null || array3 != null)
				{
					array3[0] = "CookingMiniGame";
					int mask3 = LayerMask.GetMask(array3);
					array4 = new string[1];
					if ("Audio" == null || array4 != null)
					{
						break;
					}
				}
			}
			array4[0] = "Audio";
			int mask4 = LayerMask.GetMask(array4);
		}
	}
}
