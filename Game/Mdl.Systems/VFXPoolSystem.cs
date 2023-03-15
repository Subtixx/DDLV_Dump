using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200097B")]
	public class VFXPoolSystem : System
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400345F")]
		private readonly Dictionary<GameObject, IVFXPool> pools = (Dictionary<GameObject, IVFXPool>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x6002C2B")]
		[Cpp2IlInjected.Address(RVA = "0xD415A0", Offset = "0xD3FFA0", VA = "0x180D415A0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0037, IL_0040
			IVFXPool[] componentsInChildren = GetComponentsInChildren<IVFXPool>();
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				Dictionary<GameObject, IVFXPool> dictionary = pools;
				IVFXPool iVFXPool = componentsInChildren[num];
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C2C")]
		[Cpp2IlInjected.Address(RVA = "0xD41500", Offset = "0xD3FF00", VA = "0x180D41500")]
		public void RequestEffect(GameObject prefab, Transform parent)
		{
			//Discarded unreachable code: IL_000c
			Dictionary<GameObject, IVFXPool> dictionary = pools;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C2D")]
		[Cpp2IlInjected.Address(RVA = "0xD41350", Offset = "0xD3FD50", VA = "0x180D41350")]
		public void EndEffects(Transform parent)
		{
			//Discarded unreachable code: IL_0023
			int num = 0;
			Dictionary<GameObject, IVFXPool>.ValueCollection values = (Dictionary<GameObject, IVFXPool>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)pools).get_Values();
			bool flag = default(bool);
			if (flag)
			{
				num += num;
				num++;
				num += 344;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C2E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002C2F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002C30")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002C31")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		public override void OnSystemStop()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002C32")]
		[Cpp2IlInjected.Address(RVA = "0xD41700", Offset = "0xD40100", VA = "0x180D41700")]
		public VFXPoolSystem()
		{
		}
	}
}
