using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x20004E0")]
	public class WeatherProperty : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20004E1")]
		public struct FloatProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001E8F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4001E90")]
			public AnimationCurve curve;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20004E2")]
		public struct ColorProperty
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001E91")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4001E92")]
			[GradientUsage(true)]
			public Gradient gradient;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001E88")]
		[SerializeField]
		[Tooltip("The floats and colors will be sent to all renderers listed here when the modifier is activated. ")]
		private Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E89")]
		[Tooltip("The identifier must also be present on a PropertyModifier. This component will be activated at the same time as the Modifier.")]
		public string identifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E8A")]
		[Tooltip("Add here the floats you want to edit in the renderer listed above.")]
		public FloatProperty[] floatProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E8B")]
		[Tooltip("Add here the colors you want to edit in the renderer listed above.")]
		public ColorProperty[] colorProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001E8C")]
		private MaterialPropertyBlock mpb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001E8D")]
		private float previousWeight;

		[Cpp2IlInjected.Token(Token = "0x4001E8E")]
		private static Dictionary<string, HashSet<WeatherProperty>> components = (Dictionary<string, HashSet<WeatherProperty>>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x600157D")]
		[Cpp2IlInjected.Address(RVA = "0x8391E0", Offset = "0x837BE0", VA = "0x1808391E0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_001a, IL_001e, IL_0037
			if (!string.IsNullOrWhiteSpace(identifier))
			{
				Dictionary<string, HashSet<WeatherProperty>> dictionary = components;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600157E")]
		[Cpp2IlInjected.Address(RVA = "0x838F90", Offset = "0x837990", VA = "0x180838F90")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_001a, IL_001e, IL_003b, IL_0077, IL_0092
			if (!string.IsNullOrWhiteSpace(identifier))
			{
				Dictionary<string, HashSet<WeatherProperty>> dictionary = components;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600157F")]
		[Cpp2IlInjected.Address(RVA = "0x839650", Offset = "0x838050", VA = "0x180839650")]
		public static void SetWeight(string identifier, float weight)
		{
			//Discarded unreachable code: IL_0017, IL_001b, IL_002d
			int num = 0;
			if (!string.IsNullOrWhiteSpace(identifier))
			{
				Dictionary<string, HashSet<WeatherProperty>> dictionary = components;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001580")]
		[Cpp2IlInjected.Address(RVA = "0x8393D0", Offset = "0x837DD0", VA = "0x1808393D0")]
		private void SetWeight(float weight)
		{
			//Discarded unreachable code: IL_00cc
			//IL_0049: Expected O, but got I4
			float num = previousWeight;
			if ((long)mpb == 0)
			{
				MaterialPropertyBlock materialPropertyBlock = (mpb = new MaterialPropertyBlock());
			}
			FloatProperty[] array = floatProperties;
			int num2 = 0;
			if (num2 < array.Length)
			{
				MaterialPropertyBlock materialPropertyBlock2 = mpb;
				num2 += num2;
				float num3 = default(float);
				num = num3;
				materialPropertyBlock2.SetFloat((string)num2, num);
				FloatProperty[] array2 = floatProperties;
				num2++;
			}
			ColorProperty[] array3 = colorProperties;
			if (num2 < array3.Length)
			{
				MaterialPropertyBlock materialPropertyBlock3 = mpb;
				num2 += num2;
				num = weight;
				ColorProperty[] array4 = colorProperties;
				num2++;
				while (array4 != null)
				{
				}
			}
			Renderer[] array5 = renderers;
			if (num2 < array5.Length)
			{
				Renderer renderer = array5[num2];
				MaterialPropertyBlock properties = mpb;
				renderer.Internal_SetPropertyBlock(properties);
				Renderer[] array6 = renderers;
				num2++;
				while (array6 != null)
				{
				}
			}
			previousWeight = weight;
		}

		[Cpp2IlInjected.Token(Token = "0x6001581")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public WeatherProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001582")]
		[Cpp2IlInjected.Address(RVA = "0x839830", Offset = "0x838230", VA = "0x180839830")]
		static WeatherProperty()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
