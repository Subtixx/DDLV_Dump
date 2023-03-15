using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A50")]
	public class ClothingItemScript : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003917")]
		public Color defaultTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003918")]
		public AssetReferenceMaterial materialRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003919")]
		public AssetReferenceTexture socksRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400391A")]
		public AssetReferenceTexture socksGlossRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400391B")]
		public TextAsset staticDecals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400391C")]
		public ClothingItemType clothingType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400391D")]
		public bool isDark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400391E")]
		[HideInInspector]
		public List<int> animLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400391F")]
		[HideInInspector]
		public List<int> options;

		[Cpp2IlInjected.Token(Token = "0x6003018")]
		[Cpp2IlInjected.Address(RVA = "0xA862E0", Offset = "0xA84CE0", VA = "0x180A862E0")]
		public void GetHiddenMaterials(HashSet<string> hiddenMaterials)
		{
			//Discarded unreachable code: IL_0052, IL_0058, IL_005e, IL_0064, IL_006a
			int num = 0;
			ClothingItemType clothingItemType = clothingType;
			bool flag = default(bool);
			if (flag)
			{
				string text = default(string);
				while (text == null)
				{
				}
				bool flag2 = ((HashSet<T>)(object)hiddenMaterials).Add((T)text);
			}
			int num2 = 0;
			if ((long)num2 >= (long)(IntPtr)defaultTint)
			{
				return;
			}
			int num3 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			int num4 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			int num5 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			bool flag3 = default(bool);
			if (flag3)
			{
				string text2 = default(string);
				while (text2 == null)
				{
				}
			}
			num2++;
		}

		[Cpp2IlInjected.Token(Token = "0x6003019")]
		[Cpp2IlInjected.Address(RVA = "0xA867A0", Offset = "0xA851A0", VA = "0x180A867A0")]
		public void UnhideMaterials(HashSet<string> hiddenMaterials)
		{
			//Discarded unreachable code: IL_0052, IL_0058, IL_005e, IL_0064, IL_006a
			int num = 0;
			ClothingItemType clothingItemType = clothingType;
			bool flag = default(bool);
			if (flag)
			{
				string text = default(string);
				while (text == null)
				{
				}
				bool flag2 = ((HashSet<T>)(object)hiddenMaterials).Remove((T)text);
			}
			int num2 = 0;
			if ((long)num2 >= (long)(IntPtr)defaultTint)
			{
				return;
			}
			int num3 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			int num4 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			int num5 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			bool flag3 = default(bool);
			if (flag3)
			{
				string text2 = default(string);
				while (text2 == null)
				{
				}
			}
			num2++;
		}

		[Cpp2IlInjected.Token(Token = "0x600301A")]
		[Cpp2IlInjected.Address(RVA = "0xA86720", Offset = "0xA85120", VA = "0x180A86720")]
		public ClothingParameterLength? GetParamLength()
		{
			int cpp2il__autoParamName__idx_ = 0;
			return (ClothingParameterLength?)GetParam<ClothingParameterLength>((ClothingOptionType)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x600301B")]
		[Cpp2IlInjected.Address(RVA = "0xA86760", Offset = "0xA85160", VA = "0x180A86760")]
		public ClothingParameterSize? GetParamSize()
		{
			return (ClothingParameterSize?)GetParam<ClothingParameterSize>(ClothingOptionType.Size);
		}

		[Cpp2IlInjected.Token(Token = "0x600301C")]
		[Cpp2IlInjected.Address(RVA = "0xA866B0", Offset = "0xA850B0", VA = "0x180A866B0")]
		public bool GetParamForceLongHandMannequin()
		{
			Nullable<> param = GetParam<YesNoOptionType>(ClothingOptionType.ForceLongHandMannequin);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600301D")]
		[Cpp2IlInjected.Address(RVA = "0x16CAE40", Offset = "0x16C9840", VA = "0x1816CAE40")]
		private Nullable<> GetParam<OptionSubType>(ClothingOptionType cpp2il__autoParamName__idx_0) where OptionSubType : struct
		{
			ClothingItemType clothingItemType = clothingType;
			int num = 0;
			if (ClothingItemType.CloTopInner < clothingItemType)
			{
				int num2 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				int num3 = 0;
				if ((object)typeof(ClothingOptionType).TypeHandle != null)
				{
					List<int> list = options;
					if ((object)typeof(ClothingOptionType).TypeHandle != null && (object)typeof(ClothingOptionType).TypeHandle != null)
					{
						goto IL_003b;
					}
				}
				num++;
			}
			goto IL_003b;
			IL_003b:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600301E")]
		[Cpp2IlInjected.Address(RVA = "0xA86B70", Offset = "0xA85570", VA = "0x180A86B70")]
		public ClothingItemScript()
		{
			Color white = Color.white;
			animLayers = (List<int>)(object)new List<T>();
			options = (List<int>)(object)new List<T>();
			base._002Ector();
		}
	}
}
