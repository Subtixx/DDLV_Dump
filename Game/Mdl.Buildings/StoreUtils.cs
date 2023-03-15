using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x20009D6")]
	public class StoreUtils
	{
		[Cpp2IlInjected.Token(Token = "0x6002E03")]
		[Cpp2IlInjected.Address(RVA = "0x105FD40", Offset = "0x105E740", VA = "0x18105FD40")]
		public unsafe static void RefreshSlotsVisual(List<Display> displays, StoreConfig storeConfig, float scaleToApply = -1f)
		{
			//Discarded unreachable code: IL_0155, IL_015b, IL_0161, IL_0167, IL_016d, IL_0173, IL_0179, IL_017f, IL_0185, IL_018b, IL_0191, IL_0197, IL_019d, IL_01a3, IL_01a9, IL_01af, IL_01b5, IL_01bb, IL_01c1, IL_01c7, IL_01cd, IL_01d3, IL_01d9, IL_01df, IL_01e5, IL_01eb, IL_01f1, IL_01f7, IL_01fd, IL_0203, IL_0209, IL_020f, IL_0215, IL_021b, IL_0221, IL_0227, IL_022d, IL_0233, IL_0239, IL_023f
			//IL_0038: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			//IL_0070: Expected O, but got I4
			//IL_0070: Expected O, but got I4
			//IL_00cf: Expected O, but got I4
			//IL_00cf: Expected O, but got I4
			//IL_00e3: Invalid comparison between F4 and I4
			//IL_011e: Expected O, but got I4
			//IL_0146: Expected O, but got I4
			//IL_0146: Expected O, but got I4
			int num = 0;
			int[] array = new int[storeConfig.clothingAnimationDefPerItemTypes.Length];
			int num2 = 0;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			ItemType itemType = default(ItemType);
			if (num != 0 && itemType == ItemType.Clothing)
			{
				int num3 = 0;
				GameObject gameObject = default(GameObject);
				if (gameObject != (UnityEngine.Object)num3)
				{
					GameObject gameObject2 = default(GameObject);
					ClothingItemScript component = gameObject2.GetComponent<ClothingItemScript>();
				}
				int num4 = 0;
				if ((UnityEngine.Object)num != (UnityEngine.Object)num4)
				{
				}
				IHasTags hasTags = default(IHasTags);
				if (hasTags == null || !storeConfig.TryGetClothingAnimParamByApparel(hasTags, (ClothingItemScript)num, ref *(string*)num, (Nullable<>)num))
				{
					int num5 = 0;
					if ((UnityEngine.Object)num != (UnityEngine.Object)num5)
					{
						bool flag2 = default(bool);
						if (!flag2)
						{
							goto IL_0092;
						}
						int num6 = 0;
					}
					ClothingItemType clothingItemType = default(ClothingItemType);
					int num7 = (int)clothingItemType;
					bool flag3 = default(bool);
					if (flag3)
					{
						if ((long)storeConfig.clothingAnimationDefPerItemTypes != 1)
						{
							goto IL_0092;
						}
						goto IL_0126;
					}
				}
				goto IL_00c4;
			}
			goto IL_0150;
			IL_0092:
			int num8 = 0;
			int num9 = array[num8];
			int num10 = (array[0] = num9 + 1);
			num9 = num10;
			int num11 = array[num10];
			array[0] = num;
			goto IL_00c4;
			IL_0126:
			int num12 = 0;
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			if (flag4 && flag5)
			{
				int num13 = 0;
			}
			bool flag6 = default(bool);
			if (!flag6)
			{
				int num14 = 0;
				if (!((UnityEngine.Object)num != (UnityEngine.Object)num14))
				{
					goto IL_0150;
				}
			}
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			goto IL_0150;
			IL_0150:
			num++;
			return;
			IL_00c4:
			int num15 = 0;
			bool flag7 = (UnityEngine.Object)num != (UnityEngine.Object)num15;
			if (flag7 && !flag7)
			{
				if (!(scaleToApply <= (float)num2))
				{
					Transform transform = default(Transform);
					Transform parent = transform.parent;
					Transform transform2 = default(Transform);
					Transform parent2 = transform2.parent;
					Transform transform3 = default(Transform);
					Transform parent3 = transform3.parent;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
				}
				int num16 = 0;
				Animator animator = default(Animator);
				if (animator != (UnityEngine.Object)num16)
				{
					Renderer renderer = default(Renderer);
					if ((object)renderer != null)
					{
					}
					goto IL_0126;
				}
			}
			goto IL_0150;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E04")]
		[Cpp2IlInjected.Address(RVA = "0x1060830", Offset = "0x105F230", VA = "0x181060830")]
		[AsyncStateMachine(typeof(_003CUpdateObjectAndSupport_003Ed__1))]
		private static Task UpdateObjectAndSupport(Animator animator, SkinnedMeshRenderer objectSkinMeshRenderer, SkinnedMeshRenderer supportSkinMeshRenderer)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E05")]
		[Cpp2IlInjected.Address(RVA = "0x1060980", Offset = "0x105F380", VA = "0x181060980")]
		public static void UpdateSkinnedMeshRendererBounds(SkinnedMeshRenderer skinnedMeshRenderer)
		{
			//Discarded unreachable code: IL_001d
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(skinnedMeshRenderer == (UnityEngine.Object)num))
			{
				skinnedMeshRenderer.updateWhenOffscreen = true;
				int num2 = ((skinnedMeshRenderer.updateWhenOffscreen = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E06")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public StoreUtils()
		{
		}
	}
}
