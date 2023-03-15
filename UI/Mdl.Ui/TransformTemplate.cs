using System;
using Cpp2IlInjected;
using glPlayFab.Disney;
using UnityEngine;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000892")]
	public class TransformTemplate : ComponentTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40032B5")]
		public Transform Parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40032B6")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40032B7")]
		public Vector3 Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40032B8")]
		public Vector3 Scale;

		[Cpp2IlInjected.Token(Token = "0x6003614")]
		[Cpp2IlInjected.Address(RVA = "0x17F3370", Offset = "0x17F1D70", VA = "0x1817F3370")]
		public void Load(Transform transform, bool ignoreParent = false)
		{
			//Discarded unreachable code: IL_0067
			//IL_0014: Expected O, but got I4
			if (!ignoreParent)
			{
				Transform parent = Parent;
				int num = 0;
				if (parent != (UnityEngine.Object)num)
				{
					Transform parent2 = Parent;
					Transform parent3 = transform.parent;
					if (parent2 != parent3)
					{
						Transform transform2 = (transform.parentInternal = Parent);
					}
				}
			}
			float z = Position.z;
			float z2 = Rotation.z;
			float z3 = Scale.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6003615")]
		[Cpp2IlInjected.Address(RVA = "0x17F34F0", Offset = "0x17F1EF0", VA = "0x1817F34F0")]
		public unsafe void Save(Transform transform)
		{
			//Discarded unreachable code: IL_004e
			//IL_001c: Expected native int or pointer, but got O
			//IL_0032: Expected native int or pointer, but got O
			//IL_0048: Expected native int or pointer, but got O
			Transform transform2 = (Parent = transform.parent);
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)Position)->z = z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			((Vector3*)(IntPtr)Rotation)->z = z2;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			((Vector3*)(IntPtr)Scale)->z = z3;
		}

		[Cpp2IlInjected.Token(Token = "0x6003616")]
		[Cpp2IlInjected.Address(RVA = "0x17F35B0", Offset = "0x17F1FB0", VA = "0x1817F35B0")]
		public unsafe TransformTemplate()
		{
			//IL_0012: Expected native int or pointer, but got O
			//IL_0029: Expected native int or pointer, but got O
			//IL_0040: Expected native int or pointer, but got O
			float z = Vector3.zero.z;
			((Vector3*)(IntPtr)Position)->z = z;
			float z2 = Vector3.zero.z;
			((Vector3*)(IntPtr)Rotation)->z = z2;
			float z3 = Vector3.one.z;
			((Vector3*)(IntPtr)Scale)->z = z3;
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
