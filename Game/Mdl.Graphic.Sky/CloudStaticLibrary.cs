using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace Mdl.Graphic.Sky
{
	[Cpp2IlInjected.Token(Token = "0x20004C7")]
	[CreateAssetMenu]
	public class CloudStaticLibrary : CloudLibrary
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20004C8")]
		public struct CloudItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001DFC")]
			public CloudInfos infos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4001DFD")]
			public List<Vector3> posScale;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DF9")]
		public float range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DFA")]
		public List<CloudItem> items = (List<CloudItem>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001DFB")]
		private MaterialPropertyBlock mpb;

		[Cpp2IlInjected.Token(Token = "0x6001517")]
		[Cpp2IlInjected.Address(RVA = "0xA894E0", Offset = "0xA87EE0", VA = "0x180A894E0", Slot = "4")]
		public override void Init(GameObject parent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001518")]
		[Cpp2IlInjected.Address(RVA = "0xA88E70", Offset = "0xA87870", VA = "0x180A88E70", Slot = "6")]
		public override void Draw(CommandBuffer cmd, Matrix4x4 mat)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001519")]
		[Cpp2IlInjected.Address(RVA = "0xA888D0", Offset = "0xA872D0", VA = "0x180A888D0")]
		public void DrawOne(Vector2Int id, float alpha)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600151A")]
		[Cpp2IlInjected.Address(RVA = "0xA89B70", Offset = "0xA88570", VA = "0x180A89B70")]
		public CloudStaticLibrary()
		{
		}
	}
}
