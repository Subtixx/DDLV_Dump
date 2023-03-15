using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A65")]
	[CreateAssetMenu]
	public class AvatarMakeupColorConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400395A")]
		public List<Color32> makeupColorOptions = (List<Color32>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003036")]
		[Cpp2IlInjected.Address(RVA = "0x151DE70", Offset = "0x151C870", VA = "0x18151DE70")]
		public AvatarMakeupColorConfig()
		{
		}
	}
}
