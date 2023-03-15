using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000737")]
	public class ComponentCache<ComponentType> where ComponentType : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40029EF")]
		private List<ComponentType> _cachedComponentList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40029F0")]
		private GameObject _monoBehaviour;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40029F1")]
		private int prevChildCount;

		[Cpp2IlInjected.Token(Token = "0x40029F2")]
		private static List<ComponentType> emptyList = (List<ComponentType>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x1700048D")]
		public bool IsDirty
		{
			[Cpp2IlInjected.Token(Token = "0x6002001")]
			[Cpp2IlInjected.Address(RVA = "0x29C7680", Offset = "0x29C6080", VA = "0x1829C7680")]
			get
			{
				//Discarded unreachable code: IL_0020
				int num = ((ComponentCache<>)(object)this).prevChildCount;
				int childCount = ((ComponentCache<>)(object)this)._monoBehaviour.transform.childCount;
				return num != childCount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FFD")]
		[Cpp2IlInjected.Address(RVA = "0x29C75B0", Offset = "0x29C5FB0", VA = "0x1829C75B0")]
		public ComponentCache(MonoBehaviour monoBehaviour)
		{
			//Discarded unreachable code: IL_0032
			//IL_001d: Expected I4, but got I8
			((ComponentCache<>)(object)this)._cachedComponentList = (List<ComponentType>)(object)new List<T>();
			((ComponentCache<>)(object)this).prevChildCount = -1;
			base._002Ector();
			GameObject gameObject = (((ComponentCache<>)(object)this)._monoBehaviour = monoBehaviour.gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FFE")]
		[Cpp2IlInjected.Address(RVA = "0x29C7450", Offset = "0x29C5E50", VA = "0x1829C7450")]
		public void PreCache()
		{
			//Discarded unreachable code: IL_0007
			Dirty();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FFF")]
		[Cpp2IlInjected.Address(RVA = "0x2663670", Offset = "0x2662070", VA = "0x182663670")]
		public void Dirty()
		{
			//IL_0010: Expected I4, but got I8
			((ComponentCache<>)(object)this).prevChildCount = -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002000")]
		[Cpp2IlInjected.Address(RVA = "0x29C72C0", Offset = "0x29C5CC0", VA = "0x1829C72C0")]
		public void Clear()
		{
			//Discarded unreachable code: IL_000c
			((ICollection<T>)((ComponentCache<>)(object)this)._cachedComponentList).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6002002")]
		[Cpp2IlInjected.Address(RVA = "0x29C72F0", Offset = "0x29C5CF0", VA = "0x1829C72F0")]
		private List<ComponentType> GetOrCacheComponentsInChildren()
		{
			//Discarded unreachable code: IL_0048, IL_004e, IL_0054, IL_005a, IL_0060
			if (IsDirty)
			{
				((List<T>)(object)((ComponentCache<>)(object)this)._cachedComponentList).Clear();
				GameObject monoBehaviour = ((ComponentCache<>)(object)this)._monoBehaviour;
				List<> cachedComponentList = (List<>)(object)((ComponentCache<>)(object)this)._cachedComponentList;
				monoBehaviour.GetComponentsInChildren<_0021_00210>(cachedComponentList);
				int num = (((ComponentCache<>)(object)this).prevChildCount = ((ComponentCache<>)(object)this)._monoBehaviour.transform.childCount);
			}
			return ((ComponentCache<>)(object)this)._cachedComponentList;
		}

		[Cpp2IlInjected.Token(Token = "0x6002003")]
		[Cpp2IlInjected.Address(RVA = "0x29C76C0", Offset = "0x29C60C0", VA = "0x1829C76C0")]
		public static implicit operator List<ComponentType>(ComponentCache<ComponentType> t)
		{
			while (t != null)
			{
			}
			return ComponentCache<>.emptyList;
		}

		[Cpp2IlInjected.Token(Token = "0x6002004")]
		[Cpp2IlInjected.Address(RVA = "0x29C74B0", Offset = "0x29C5EB0", VA = "0x1829C74B0")]
		static ComponentCache()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
