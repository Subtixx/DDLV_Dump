using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils.EQ
{
	[Cpp2IlInjected.Token(Token = "0x20007E3")]
	internal class TestDirectionToQuerier : TestDirection
	{
		[Cpp2IlInjected.Token(Token = "0x60022F2")]
		[Cpp2IlInjected.Address(RVA = "0x1071DC0", Offset = "0x10707C0", VA = "0x181071DC0", Slot = "6")]
		protected unsafe override (bool, float) FilterAndScore(GameObject queryObject, Vector3 queryPosition, Vector3 position)
		{
			//IL_0015: Expected native int or pointer, but got O
			Transform transform = queryObject.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)DesiredDirection)->z = z;
			float z2 = DesiredDirection.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60022F3")]
		[Cpp2IlInjected.Address(RVA = "0x1072020", Offset = "0x1070A20", VA = "0x181072020")]
		public unsafe TestDirectionToQuerier()
		{
			//IL_0012: Expected native int or pointer, but got O
			float z = Vector3.forward.z;
			((Vector3*)(IntPtr)DesiredDirection)->z = z;
			((EnvironmentQuery.Test)this)._002Ector();
		}
	}
}
