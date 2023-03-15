using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007BB")]
	[CreateAssetMenu]
	public class StoreConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20007BC")]
		public class LengthOption
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002BCE")]
			public ClothingParameterLength Length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002BCF")]
			public string Parameter;

			[Cpp2IlInjected.Token(Token = "0x6002275")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public LengthOption()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20007BD")]
		public class SizeOption
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002BD0")]
			public ClothingParameterSize Size;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002BD1")]
			public string Parameter;

			[Cpp2IlInjected.Token(Token = "0x6002276")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SizeOption()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20007BE")]
		public class ClothingAnimationDefPerItemType
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002BD2")]
			public List<ClothingItemType> ItemTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002BD3")]
			public string[] Parameters = new string[0];

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4002BD4")]
			public LengthOption[] LengthOptions = new LengthOption[0];

			[Cpp2IlInjected.Token(Token = "0x6002277")]
			[Cpp2IlInjected.Address(RVA = "0x1219410", Offset = "0x1217E10", VA = "0x181219410")]
			public ClothingAnimationDefPerItemType()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20007BF")]
		public class ClothingAnimationDefPerApparelType
		{
			[Cpp2IlInjected.Token(Token = "0x20007C0")]
			public enum CustomType
			{
				[Cpp2IlInjected.Token(Token = "0x4002BD9")]
				Gown = 1
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002BD5")]
			public List<int> Ids = (List<int>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002BD6")]
			public string Parameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4002BD7")]
			public SizeOption[] SizeOptions = new SizeOption[0];

			[Cpp2IlInjected.Token(Token = "0x6002278")]
			[Cpp2IlInjected.Address(RVA = "0x1219370", Offset = "0x1217D70", VA = "0x181219370")]
			public ClothingAnimationDefPerApparelType()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20007C1")]
		public class ClothingAnimDefResult
		{
			[Cpp2IlInjected.Token(Token = "0x170004CE")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002BDA")]
			public int Index
			{
				[Cpp2IlInjected.Token(Token = "0x6002279")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600227A")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170004CF")]
			public List<string> Parameters
			{
				[Cpp2IlInjected.Token(Token = "0x600227B")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CParameters_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600227C")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CParameters_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600227D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ClothingAnimDefResult()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002BCC")]
		[SerializeField]
		public ClothingAnimationDefPerItemType[] clothingAnimationDefPerItemTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002BCD")]
		[HideInInspector]
		public ClothingAnimationDefPerApparelType[] clothingAnimationDefPerApparelTypes;

		[Cpp2IlInjected.Token(Token = "0x6002272")]
		[Cpp2IlInjected.Address(RVA = "0xF63CD0", Offset = "0xF626D0", VA = "0x180F63CD0")]
		public bool TryGetClothingAnimParamsByItemType(ClothingItemType clothingItemType, out ClothingAnimDefResult outAnimDefResult, [System.Runtime.InteropServices.Optional] ClothingParameterLength? parameterLength)
		{
			ClothingAnimDefResult clothingAnimDefResult = new ClothingAnimDefResult();
			List<string> list = (clothingAnimDefResult.Parameters = (List<string>)(object)new List<T>());
			ClothingAnimationDefPerItemType[] array = clothingAnimationDefPerItemTypes;
			Func<ClothingItemType, bool> func = default(Func<ClothingItemType, bool>);
			Predicate<ClothingAnimationDefPerItemType> predicate = (Predicate<ClothingAnimationDefPerItemType>)(object)(Predicate<T>)delegate(ClothingAnimationDefPerItemType x)
			{
				//Discarded unreachable code: IL_002e
				List<ClothingItemType> itemTypes = x.ItemTypes;
				Func<ClothingItemType, bool> func2 = func;
				if (func2 == null)
				{
					func = (Func<ClothingItemType, bool>)(object)(Func<T, TResult>)((ClothingItemType y) => y == clothingItemType);
				}
				return ((IEnumerable<>)itemTypes).Any<ClothingItemType>((Func<, >)(object)func2);
			};
			ClothingAnimationDefPerItemType[] array2 = clothingAnimationDefPerItemTypes;
			ClothingAnimationDefPerItemType clothingAnimationDefPerItemType = default(ClothingAnimationDefPerItemType);
			if (clothingAnimationDefPerItemType != null)
			{
				if (clothingAnimationDefPerItemType.LengthOptions.Length != 0)
				{
					ClothingParameterLength clothingParameterLength = default(ClothingParameterLength);
					Predicate<LengthOption> predicate2 = (Predicate<LengthOption>)(object)(Predicate<T>)((LengthOption x) => x.Length == clothingParameterLength);
					LengthOption lengthOption = default(LengthOption);
					if (lengthOption != null)
					{
						string parameter = lengthOption.Parameter;
						return true;
					}
				}
				if (clothingAnimationDefPerItemType.Parameters.Length == 0)
				{
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002273")]
		[Cpp2IlInjected.Address(RVA = "0xF63A10", Offset = "0xF62410", VA = "0x180F63A10")]
		public bool TryGetClothingAnimParamByApparel(IHasTags hasTagsItem, ClothingItemScript clothingItemScript, out string parameter, [System.Runtime.InteropServices.Optional] ClothingParameterSize? parameterSize)
		{
			//IL_0014: Expected O, but got I4
			ClothingParameterSize? parameterSize2 = (ClothingParameterSize?)(object)0;
			IEnumerable<int> itemTags = (IEnumerable<int>)ItemDataExtensions.GetAllTags(hasTagsItem);
			ClothingAnimationDefPerApparelType[] array = clothingAnimationDefPerApparelTypes;
			int num = 0;
			int num2 = 0;
			int length = array.Length;
			if (num < length)
			{
				ClothingAnimationDefPerApparelType clothingAnimationDefPerApparelType = array[num2];
				Func<int, bool> func = default(Func<int, bool>);
				Func<int, bool> func2 = func;
				List<int> ids = clothingAnimationDefPerApparelType.Ids;
				if (func2 == null)
				{
					func = (Func<int, bool>)(object)(Func<T, TResult>)delegate(int x)
					{
						if (Enumerable.Contains<int>((IEnumerable<>)itemTags, x))
						{
							return true;
						}
						Type typeFromHandle = typeof(ClothingAnimationDefPerApparelType.CustomType);
						bool flag = Enum.IsDefined(typeFromHandle, typeFromHandle);
						bool flag2 = default(bool);
						return (!flag) ? flag : flag2;
					};
				}
				int num3 = Enumerable.FirstOrDefault<int>((IEnumerable<>)ids, (Func<, >)(object)func2);
				num2++;
				string parameter2 = clothingAnimationDefPerApparelType.Parameter;
				if (clothingAnimationDefPerApparelType.SizeOptions.Length != 0)
				{
					Predicate<SizeOption> predicate = default(Predicate<SizeOption>);
					if (predicate == null)
					{
						ClothingParameterSize clothingParameterSize = default(ClothingParameterSize);
						predicate = (Predicate<SizeOption>)(object)(Predicate<T>)((SizeOption x) => x.Size == clothingParameterSize);
					}
					SizeOption sizeOption = default(SizeOption);
					if (sizeOption != null)
					{
						string parameter3 = sizeOption.Parameter;
					}
				}
				return true;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002274")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public StoreConfig()
		{
		}
	}
}
