using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Streaming
{
	[Cpp2IlInjected.Token(Token = "0x200080E")]
	[CreateAssetMenu]
	public class StreamingManagerConfig : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x200080F")]
		public enum StreamingLimitMethod
		{
			[Cpp2IlInjected.Token(Token = "0x4002D05")]
			Concurrent,
			[Cpp2IlInjected.Token(Token = "0x4002D06")]
			LoadsPerSecond
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000810")]
		public class Data
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002D07")]
			public string debugname = string.Empty;

			[Cpp2IlInjected.Token(Token = "0x4002D08")]
			public static readonly float INFINITE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002D09")]
			public float MaximumObjectHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4002D0A")]
			public StreamableAssetRefType type = StreamableAssetRefType.Any;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4002D0B")]
			public StreamingLimitMethod LimitMethod = StreamingLimitMethod.LoadsPerSecond;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4002D0C")]
			public float MustBeLoadedDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4002D0D")]
			public float UnloadDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4002D0E")]
			public int LoadsPerSecond;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4002D0F")]
			public int MaxConcurrentLoads = 5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4002D10")]
			public int BoostedMaxConcurrentLoads = 20;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4002D11")]
			public bool SyncWithFarClip;

			[Cpp2IlInjected.Token(Token = "0x6002435")]
			[Cpp2IlInjected.Address(RVA = "0x1219600", Offset = "0x1218000", VA = "0x181219600")]
			public Data()
			{
			}//IL_001a: Expected I4, but got I8
			//IL_0023: Expected I4, but got I8
			//IL_002c: Expected I4, but got I8
			//IL_0036: Expected I4, but got I8

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002CEF")]
		public bool IsStreamingNonGridObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4002CF0")]
		public bool IsStreamingLevelComplexity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x4002CF1")]
		public bool IsStreamingAreaLocksBigThorns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
		[Cpp2IlInjected.Token(Token = "0x4002CF2")]
		public bool IsUsingCompositionDistanceCulling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002CF3")]
		public bool UseDynamicFarClipCulling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002CF4")]
		public float LoadDistanceFarClipOffset = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002CF5")]
		public float UnLoadDistanceFarClipOffset = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002CF6")]
		public float ForcedFarClipLoadDistance = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002CF7")]
		public float ForcedFarClipUnloadDistance = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002CF8")]
		public bool IsStreamableCulledWithFrustum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4002CF9")]
		public bool IsDistanceCullingCulledWithFrustum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002CFA")]
		public List<Data> configs = (List<Data>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002CFB")]
		public float DistanceCullingFirstBand = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4002CFC")]
		public float DistanceCullingSecondBand = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002CFD")]
		public float TallDistanceCullingFirstBand = 40f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4002CFE")]
		public float TallDistanceCullingSecondBand = 80f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002CFF")]
		public StreamingLimitMethod DistanceCullingLimitMethod = StreamingLimitMethod.LoadsPerSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4002D00")]
		public int DistanceCullingLoadsPerSecond = 60;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002D01")]
		public int DistanceCullingMaxConcurrentLoads = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4002D02")]
		public int DistanceCullingBoostedMaxConcurrentLoads = 20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002D03")]
		public int MemoryCleanTriggerThreshold = 100;

		[Cpp2IlInjected.Token(Token = "0x17000527")]
		public int ConfigCounts
		{
			[Cpp2IlInjected.Token(Token = "0x6002433")]
			[Cpp2IlInjected.Address(RVA = "0x10640C0", Offset = "0x1062AC0", VA = "0x1810640C0")]
			get
			{
				List<Data> list;
				do
				{
					list = configs;
				}
				while (list == null);
				return ((List<>)(object)list)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002434")]
		[Cpp2IlInjected.Address(RVA = "0x1063FE0", Offset = "0x10629E0", VA = "0x181063FE0")]
		public StreamingManagerConfig()
		{
		}//IL_006e: Expected I4, but got I8
		//IL_0078: Expected I4, but got I8
		//IL_0081: Expected I4, but got I8
		//IL_008b: Expected I4, but got I8
		//IL_0095: Expected I4, but got I8

	}
}
