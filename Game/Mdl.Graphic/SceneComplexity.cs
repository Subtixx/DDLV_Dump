using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace Mdl.Graphic
{
	[Cpp2IlInjected.Token(Token = "0x20004A1")]
	public class SceneComplexity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001D1D")]
		public SceneInstance sceneInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001D1E")]
		public LevelComplexityEnum complexity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001D1F")]
		public SceneData ownerSceneData;

		[Cpp2IlInjected.Token(Token = "0x17000291")]
		public GameObject rootObject
		{
			[Cpp2IlInjected.Token(Token = "0x6001489")]
			[Cpp2IlInjected.Address(RVA = "0xCC9660", Offset = "0xCC8060", VA = "0x180CC9660")]
			get
			{
				return sceneInstance.m_Scene.GetRoot();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600148A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public SceneComplexity()
		{
		}
	}
}
