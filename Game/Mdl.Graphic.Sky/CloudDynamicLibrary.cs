using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Sky
{
	[Cpp2IlInjected.Token(Token = "0x20004C2")]
	public class CloudDynamicLibrary : CloudLibrary
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20004C3")]
		public struct Layer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001DED")]
			public int horizonCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4001DEE")]
			public int midCount;
		}

		[Cpp2IlInjected.Token(Token = "0x20004C4")]
		private struct cloud
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001DEF")]
			public Vector3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4001DF0")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001DF1")]
			public Mesh mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001DF2")]
			public Material opaqueMat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001DF3")]
			public Material transparentMat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4001DF4")]
			public int layer;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DD9")]
		public float range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4001DDA")]
		public float randomVariationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DDB")]
		[Range(0f, 1f)]
		public float midMinHeight = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4001DDC")]
		[Range(0f, 1f)]
		public float midMaxHeight = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001DDD")]
		public float horizonRandom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4001DDE")]
		public float midRandom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001DDF")]
		public float horizonScaleFactor = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4001DE0")]
		public float midScaleFactor = 1.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001DE1")]
		public Vector2 midSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001DE2")]
		public Vector2 horizonSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001DE3")]
		public Layer[] layers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001DE4")]
		public List<CloudInfos> horizonClouds = (List<CloudInfos>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001DE5")]
		public List<CloudInfos> midClouds = (List<CloudInfos>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001DE6")]
		public List<CloudInfos> specialClouds = (List<CloudInfos>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001DE7")]
		public List<CloudInfos> lightningClouds = (List<CloudInfos>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001DE8")]
		private List<cloud> midCachedClouds = (List<cloud>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001DE9")]
		private List<cloud> horizonCachedClouds = (List<cloud>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001DEA")]
		private int layerFarClipBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4001DEB")]
		private float midRotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001DEC")]
		private float horizonRotationSpeed;

		[Cpp2IlInjected.Token(Token = "0x600150E")]
		[Cpp2IlInjected.Address(RVA = "0xA87B30", Offset = "0xA86530", VA = "0x180A87B30", Slot = "4")]
		public override void Init(GameObject parent)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600150F")]
		[Cpp2IlInjected.Address(RVA = "0xA87290", Offset = "0xA85C90", VA = "0x180A87290", Slot = "5")]
		public override void CloudUpdate(GameObject parent, float time, Camera camera)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001510")]
		[Cpp2IlInjected.Address(RVA = "0xA87A60", Offset = "0xA86460", VA = "0x180A87A60")]
		private Vector3 GetFibonnaciSpherePos(int samples, float index, float minHeight, float maxHeight)
		{
			//IL_000a: Expected F4, but got I4
			int num = 0;
			float num2 = Mathf.Clamp(minHeight, num, index) * 2.3999662f;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001511")]
		[Cpp2IlInjected.Address(RVA = "0xA88720", Offset = "0xA87120", VA = "0x180A88720")]
		public CloudDynamicLibrary()
		{
		}
	}
}
