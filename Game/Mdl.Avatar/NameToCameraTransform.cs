using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A6B")]
	internal class NameToCameraTransform : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000A6C")]
		public class NameToCameraMapping
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003971")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003972")]
			public GameObject CameraObject;

			[Cpp2IlInjected.Token(Token = "0x6003045")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public NameToCameraMapping()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400396F")]
		[SerializeField]
		private GameObject DefaultCameraObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003970")]
		[SerializeField]
		private List<NameToCameraMapping> NameToCameraMappings = (List<NameToCameraMapping>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003042")]
		[Cpp2IlInjected.Address(RVA = "0xF01090", Offset = "0xEFFA90", VA = "0x180F01090")]
		public (Vector3, Quaternion) GetDefaultCameraPositionAndRotation()
		{
			//IL_001d: Expected O, but got I4
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num = 0;
			int num2 = 0;
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num2;
			DefaultCameraObject = (GameObject)num2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003043")]
		[Cpp2IlInjected.Address(RVA = "0xF00CA0", Offset = "0xEFF6A0", VA = "0x180F00CA0")]
		public (Vector3, Quaternion) FindCameraPositionAndRotationForName(string name)
		{
			//Discarded unreachable code: IL_0045, IL_004b, IL_0051, IL_0057, IL_005d
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			bool flag = default(bool);
			if (flag)
			{
				while (!flag)
				{
				}
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				Vector3 vector = default(Vector3);
				float z = vector.z;
				int num4 = 0;
				int num5 = 0;
				num3++;
			}
			if (num3 + 1 != 0)
			{
			}
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			int num6 = 0;
			int num7 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003044")]
		[Cpp2IlInjected.Address(RVA = "0xF01180", Offset = "0xEFFB80", VA = "0x180F01180")]
		public NameToCameraTransform()
		{
		}
	}
}
