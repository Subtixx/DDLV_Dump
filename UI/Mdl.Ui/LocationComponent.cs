using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000341")]
	public class LocationComponent : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000342")]
		public class VillageAreaComparer : IComparer<ActivityDataLocationFilter>
		{
			[Cpp2IlInjected.Token(Token = "0x4000F45")]
			private static VillageAreaComparer _Instance;

			[Cpp2IlInjected.Token(Token = "0x4000F46")]
			public static readonly VillageAreaType[] SortOrder;

			[Cpp2IlInjected.Token(Token = "0x17000388")]
			public static VillageAreaComparer Instance
			{
				[Cpp2IlInjected.Token(Token = "0x600147F")]
				[Cpp2IlInjected.Address(RVA = "0xB0E9B0", Offset = "0xB0D3B0", VA = "0x180B0E9B0")]
				get
				{
					//Discarded unreachable code: IL_0010
					_Instance = new VillageAreaComparer();
					return _Instance;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6001480")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			private VillageAreaComparer()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6001481")]
			[Cpp2IlInjected.Address(RVA = "0xB0E820", Offset = "0xB0D220", VA = "0x180B0E820", Slot = "4")]
			public int Compare(ActivityDataLocationFilter x, ActivityDataLocationFilter y)
			{
				//Discarded unreachable code: IL_0030
				if (x.locationTypeCase_ == ActivityDataLocationFilter.LocationTypeOneofCase.Scene)
				{
				}
				VillageAreaType[] sortOrder = SortOrder;
				VillageAreaType villageArea = x.VillageArea;
				VillageAreaType[] sortOrder2 = SortOrder;
				VillageAreaType villageArea2 = y.VillageArea;
				int num = default(int);
				int num2 = default(int);
				return num - num2;
			}

			[Cpp2IlInjected.Token(Token = "0x6001482")]
			[Cpp2IlInjected.Address(RVA = "0xB0E920", Offset = "0xB0D320", VA = "0x180B0E920")]
			static VillageAreaComparer()
			{
				VillageAreaType[] array = new VillageAreaType[8];
				RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				_Instance = (VillageAreaComparer)(object)array;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000F41")]
		public Transform Elements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000F42")]
		public TextBase Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000F43")]
		public RecycleBin RecycleBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000F44")]
		public bool IsLarge;

		[Cpp2IlInjected.Token(Token = "0x600147D")]
		[Cpp2IlInjected.Address(RVA = "0x132F2E0", Offset = "0x132DCE0", VA = "0x18132F2E0")]
		public void SetData(List<ActivityDataLocationFilter> areas)
		{
			//Discarded unreachable code: IL_01df, IL_01e5, IL_01eb, IL_01f1, IL_01f7, IL_01fd, IL_0203, IL_0209, IL_020f, IL_0215, IL_021b
			//IL_00d4: Expected I4, but got I8
			//IL_0141: Expected I8, but got I4
			//IL_0148: Expected I4, but got I8
			//IL_018d: Expected I4, but got I8
			int num2;
			bool flag = default(bool);
			ulong num5 = default(ulong);
			uint _003CSceneId_003Ek__BackingField = default(uint);
			Transform transform2 = default(Transform);
			while (true)
			{
				int num = 0;
				int isLarge = 0;
				num2 = 0;
				IsLarge = (byte)isLarge != 0;
				int num3 = Elements.childCount - 1;
				Transform elements = Elements;
				int index = elements.childCount - 1;
				CollectionTooltipElement component = elements.GetChild(index).GetComponent<CollectionTooltipElement>();
				RecycleBin recycleBin = RecycleBin;
				GameObject trash = component.gameObject;
				recycleBin.SendToBin(trash);
				int num4 = 0;
				VillageAreaComparer instance = VillageAreaComparer.Instance;
				((List<T>)(object)areas).Sort((IComparer<>)instance);
				int size = ((List<>)(object)areas)._size;
				string[] names = Enum.GetNames(typeof(VillageAreaType));
				if (size >= names.Length)
				{
					break;
				}
				if (flag)
				{
					int childCount = Elements.childCount;
					RecycleBin recycleBin2 = RecycleBin;
					Type typeFromHandle = typeof(CollectionTooltipElement);
					Transform elements2 = Elements;
					recycleBin2.FindReusableOrNew(typeFromHandle, elements2).SetActive((byte)num5 != 0);
					CollectionTooltipElement component2 = Elements.GetChild(num2).GetComponent<CollectionTooltipElement>();
					CollectionTooltipVillageAreaElementModel collectionTooltipVillageAreaElementModel = new CollectionTooltipVillageAreaElementModel();
					collectionTooltipVillageAreaElementModel.VillageAreaType = (VillageAreaType)num2;
					collectionTooltipVillageAreaElementModel.SceneId = (int)_003CSceneId_003Ek__BackingField;
					component2.Model = collectionTooltipVillageAreaElementModel;
					component2.Model.UpdateDisplay(component2);
					Transform transform = component2.transform;
					num2++;
				}
				int num6 = 0;
				if (num2 == 0)
				{
					if (num2 > 5)
					{
					}
					long num7 = Math.Min(5, num2) * 178;
					num6 = (int)(num6 + num7);
					if ((object)transform2 != null)
					{
					}
					if ((object)transform2 == null)
					{
					}
					break;
				}
			}
			int childCount2 = Elements.childCount;
			RecycleBin recycleBin3 = RecycleBin;
			Type typeFromHandle2 = typeof(CollectionTooltipElement);
			Transform elements3 = Elements;
			ulong num8 = default(ulong);
			recycleBin3.FindReusableOrNew(typeFromHandle2, elements3).SetActive((byte)num8 != 0);
			Transform elements4 = Elements;
			int index2 = 0;
			CollectionTooltipElement component3 = elements4.GetChild(index2).GetComponent<CollectionTooltipElement>();
			CollectionTooltipEverywhereArea collectionTooltipEverywhereArea = (CollectionTooltipEverywhereArea)(component3.Model = new CollectionTooltipEverywhereArea());
			component3.Model.UpdateDisplay(component3);
			Transform transform3 = component3.transform;
			IsLarge = (byte)num2 != 0;
			Transform transform4 = base.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x600147E")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public LocationComponent()
		{
		}
	}
}
