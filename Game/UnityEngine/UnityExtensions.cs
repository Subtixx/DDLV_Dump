using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;

namespace UnityEngine
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public static class UnityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		private class CloneAnimator : MonoBehaviour
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public GameObject OriginalGO;

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x1412040", Offset = "0x1410A40", VA = "0x181412040")]
			protected void Start()
			{
				//Discarded unreachable code: IL_00a2
				//IL_0014: Expected O, but got I4
				int num = 0;
				GameObject originalGO = OriginalGO;
				int num2 = 0;
				int num3 = 0;
				if (originalGO != (Object)num3)
				{
					GameObject originalGO2 = OriginalGO;
					Animator[] array = default(Animator[]);
					if (array != null && Enumerable.Any<Animator>((IEnumerable<>)(object)array))
					{
						Animator[] componentsInChildren = GetComponentsInChildren<Animator>();
						int length = componentsInChildren.Length;
						if (array.Length == length)
						{
							int num4 = 0;
							int length2 = array.Length;
							if (num4 < length2)
							{
								Animator animator = componentsInChildren[num4];
								Animator animator2 = array[num4];
								AnimatorStateInfo animatorStateInfo = default(AnimatorStateInfo);
								float length3 = animatorStateInfo.m_Length;
								int loop = animatorStateInfo.m_Loop;
								int layer = 0;
								animator.Play(loop, layer);
								num4++;
							}
						}
					}
				}
				Object.Destroy(this);
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
			public CloneAnimator()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x35C31E0", Offset = "0x35C1BE0", VA = "0x1835C31E0")]
		public static T GetOrAddComponent<T>(this GameObject P_0) where T : Component
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x35C31B0", Offset = "0x35C1BB0", VA = "0x1835C31B0")]
		public static T GetOrAddComponent<T>(this Component P_0) where T : Component
		{
			GameObject gameObject = P_0.gameObject;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x13E26E0", Offset = "0x13E10E0", VA = "0x1813E26E0")]
		public static void DestroyAllChildrens(this GameObject gameObject)
		{
			//Discarded unreachable code: IL_005a, IL_0066, IL_006c, IL_0072
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			List<Transform> list = (List<Transform>)(object)new List<T>();
			IEnumerator enumerator = gameObject.transform.GetEnumerator();
			int num5 = default(int);
			if (enumerator != null)
			{
				uint num4 = default(uint);
				if (num3 < (int)num4)
				{
					num3 += num3;
					num3++;
				}
				if (enumerator == null)
				{
					num3 += num3;
				}
				num5 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
			}
			if (num5 != 0)
			{
			}
			bool flag = default(bool);
			if (flag)
			{
				int active = 0;
				GameObject gameObject2 = default(GameObject);
				gameObject2.SetActive((byte)active != 0);
				GameObject obj = default(GameObject);
				Object.Destroy(obj);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x13E2D40", Offset = "0x13E1740", VA = "0x1813E2D40")]
		public static bool TryGetItem(this GameObject gameObject, out Item item)
		{
			//IL_000d: Expected I4, but got O
			//IL_0016: Expected O, but got I4
			//IL_0023: Expected O, but got I8
			Item invalid = Item.Invalid;
			item.ItemID = (int)invalid;
			int num = 0;
			if (!(gameObject == (Object)num))
			{
				bool flag = default(bool);
				if (flag)
				{
					ulong num2 = default(ulong);
					int num3 = (item.ItemID = ((BattlePassReward)num2).Price);
				}
				bool result = default(bool);
				return result;
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x13E2A60", Offset = "0x13E1460", VA = "0x1813E2A60")]
		public static string GetFullPath(this Component component)
		{
			//Discarded unreachable code: IL_003b
			//IL_001e: Expected O, but got I4
			Transform transform = component.transform;
			string name = transform.name;
			Transform parent = transform.parent;
			int num = 0;
			if (parent != (Object)num)
			{
				string text = transform.parent.name + "/" + name;
			}
			return name;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x13E2B50", Offset = "0x13E1550", VA = "0x1813E2B50")]
		public static string GetFullPath(this Transform transform)
		{
			//Discarded unreachable code: IL_0033
			//IL_0017: Expected O, but got I4
			string name = transform.name;
			Transform parent = transform.parent;
			int num = 0;
			if (parent != (Object)num)
			{
				string text = transform.parent.name + "/" + name;
			}
			return name;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x13E2C30", Offset = "0x13E1630", VA = "0x1813E2C30")]
		public static bool HasParentNamed(this GameObject go, string name)
		{
			//IL_0009: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			int num = 0;
			if (!(go == (Object)num))
			{
				if (!go.name.Equals(name))
				{
					Transform transform = go.transform;
					if ((object)transform != null)
					{
						Transform parent = transform.parent;
						if ((object)parent != null)
						{
							return parent.gameObject.HasParentNamed(name);
						}
					}
					return ((GameObject)0).HasParentNamed(name);
				}
				return true;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x13E24E0", Offset = "0x13E0EE0", VA = "0x1813E24E0")]
		public static GameObject Clone(this GameObject original, Transform parent)
		{
			//Discarded unreachable code: IL_0081
			GameObject gameObject = Object.Instantiate(original, parent);
			Renderer[] componentsInChildren = original.GetComponentsInChildren<Renderer>();
			if (Enumerable.Any<Renderer>((IEnumerable<>)(object)componentsInChildren))
			{
				Renderer[] componentsInChildren2 = gameObject.GetComponentsInChildren<Renderer>();
				int length = componentsInChildren2.Length;
				if (componentsInChildren.Length == length)
				{
					int num = 0;
					int length2 = componentsInChildren.Length;
					if (num < length2)
					{
						Renderer renderer = componentsInChildren[num];
						Renderer renderer2 = componentsInChildren2[num];
						MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
						renderer.Internal_GetPropertyBlock(materialPropertyBlock);
						renderer2.Internal_SetPropertyBlock(materialPropertyBlock);
						num++;
					}
				}
			}
			gameObject.AddComponent<CloneAnimator>().OriginalGO = original;
			return gameObject;
		}
	}
}
