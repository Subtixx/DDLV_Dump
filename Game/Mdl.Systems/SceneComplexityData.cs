using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Graphic;
using UnityEngine;

namespace Mdl.Systems
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000963")]
	[CreateAssetMenu]
	public class SceneComplexityData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003410")]
		public List<SceneComplexityNode> ComplexityData = (List<SceneComplexityNode>)(object)new List<T>
		{
			(T)new SceneComplexityNode
			{
				complexityLevel = LevelComplexityEnum.COMPLEXITY_MEDIUM,
				scenes = (List<string>)(object)new List<T>()
			},
			(T)new SceneComplexityNode
			{
				complexityLevel = LevelComplexityEnum.COMPLEXITY_HIGH,
				scenes = (List<string>)(object)new List<T>()
			}
		};

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003411")]
		public List<LevelComplexityBoundary> Anchors;

		[Cpp2IlInjected.Token(Token = "0x6002BA2")]
		[Cpp2IlInjected.Address(RVA = "0xCC94C0", Offset = "0xCC7EC0", VA = "0x180CC94C0")]
		public SceneComplexityData()
		{
		}//Discarded unreachable code: IL_005c
		//IL_0015: Expected I4, but got I8
		//IL_0038: Expected I4, but got I8

	}
}
