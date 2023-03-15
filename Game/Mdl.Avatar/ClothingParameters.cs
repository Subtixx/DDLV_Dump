using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A5A")]
	[CreateAssetMenu]
	public class ClothingParameters : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400393C")]
		[HideInInspector]
		public ClothingOptions[] clothingOptions = new ClothingOptions[Enum.GetValues(typeof(ClothingItemType)).System_002ECollections_002EICollection_002ECount];

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400393D")]
		[HideInInspector]
		public List<ConditionalBlendShape> conditionalBlendShapes = (List<ConditionalBlendShape>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400393E")]
		public List<string> optionalAnimLayers = (List<string>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x600302A")]
		[Cpp2IlInjected.Address(RVA = "0xA87110", Offset = "0xA85B10", VA = "0x180A87110")]
		public ClothingParameters()
		{
		}//Discarded unreachable code: IL_0042

	}
}
