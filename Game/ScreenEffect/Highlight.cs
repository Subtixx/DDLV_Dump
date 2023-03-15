using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace ScreenEffect
{
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public static class Highlight
	{
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private static int _vfxLayer = (int)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private static List<Renderer> cachedRenderers;

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		private static int vfxLayer
		{
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x154FF10", Offset = "0x154E910", VA = "0x18154FF10")]
			get
			{
				//Discarded unreachable code: IL_0015
				_vfxLayer = LayerMask.NameToLayer("VFX");
				return _vfxLayer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x154F660", Offset = "0x154E060", VA = "0x18154F660")]
		public static void AddHighlightTo(GameObject gameObject, [Optional] AnimationCurve curve)
		{
			//Discarded unreachable code: IL_0032
			((List<T>)(object)cachedRenderers).Clear();
			if (gameObject.GetComponentInChildren<IHighlightRendererOverride>() != null)
			{
			}
			List<Renderer> list = cachedRenderers;
			List<Renderer> list2 = cachedRenderers;
			gameObject.GetComponentsInChildren<Renderer>((List<>)(object)list2);
			Highlight.AddHighlightTo((IEnumerable<>)cachedRenderers, curve);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x154F850", Offset = "0x154E250", VA = "0x18154F850")]
		public static void AddHighlightTo(IEnumerable<Renderer> renderers, [Optional] AnimationCurve curve)
		{
			//Discarded unreachable code: IL_0028, IL_002e, IL_0034, IL_003a
			if ((object)typeof(Object).TypeHandle != null)
			{
				bool flag = default(bool);
				while (flag)
				{
				}
				GameObject gameObject = default(GameObject);
				int layer = gameObject.layer;
				int num = 0;
				int num2 = vfxLayer;
				while (layer == num2)
				{
				}
				uint num3 = default(uint);
				while (num3 == 2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x154FAE0", Offset = "0x154E4E0", VA = "0x18154FAE0")]
		public static void RemoveHighlightFrom(GameObject gameObject, [Optional] AnimationCurve curve)
		{
			//Discarded unreachable code: IL_0033
			((List<T>)(object)cachedRenderers).Clear();
			if (gameObject.GetComponentInChildren<IHighlightRendererOverride>() != null)
			{
			}
			List<Renderer> list = cachedRenderers;
			List<Renderer> list2 = cachedRenderers;
			gameObject.GetComponentsInChildren<Renderer>(true, (List<>)(object)list2);
			Highlight.RemoveHighlightFrom((IEnumerable<>)cachedRenderers, curve);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x154FCD0", Offset = "0x154E6D0", VA = "0x18154FCD0")]
		public static void RemoveHighlightFrom(IEnumerable<Renderer> renderers, [Optional] AnimationCurve curve)
		{
			//Discarded unreachable code: IL_0019, IL_001f, IL_0025
			if ((object)typeof(Object).TypeHandle != null)
			{
				bool flag = default(bool);
				while (!flag)
				{
				}
				uint num = default(uint);
				while (num == 2)
				{
				}
			}
			int num2 = 0;
			HighlightFeature.ResetCurve();
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x154FE80", Offset = "0x154E880", VA = "0x18154FE80")]
		static Highlight()
		{
			//IL_000a: Expected I4, but got O
			/*Error: Unexpected end of block*/;
		}
	}
}
