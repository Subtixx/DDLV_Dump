using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200079C")]
	internal struct RaycastHitBuffer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4002B6A")]
		private RaycastHit[] hits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4002B6B")]
		private int hitCount;

		[Cpp2IlInjected.Token(Token = "0x170004AF")]
		public int Length
		{
			[Cpp2IlInjected.Token(Token = "0x60021CF")]
			[Cpp2IlInjected.Address(RVA = "0x6E07B0", Offset = "0x6DF1B0", VA = "0x1806E07B0")]
			get
			{
				return hitCount;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B0")]
		public RaycastHit this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60021D0")]
			[Cpp2IlInjected.Address(RVA = "0xCBA390", Offset = "0xCB8D90", VA = "0x180CBA390")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B1")]
		public readonly RaycastHit[] RawHits
		{
			[Cpp2IlInjected.Token(Token = "0x60021D1")]
			[Cpp2IlInjected.Address(RVA = "0x6DDC90", Offset = "0x6DC690", VA = "0x1806DDC90")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021D2")]
		[Cpp2IlInjected.Address(RVA = "0xCBA330", Offset = "0xCB8D30", VA = "0x180CBA330")]
		public RaycastHitBuffer(int startingMaxHits = 32)
		{
			//IL_0017: Expected I4, but got I8
			RaycastHit[] array = (hits = new RaycastHit[startingMaxHits]);
			hitCount = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60021D3")]
		[Cpp2IlInjected.Address(RVA = "0xCBA1F0", Offset = "0xCB8BF0", VA = "0x180CBA1F0")]
		public int SphereCast(Ray ray, float radius, float distance, int layerMask = -1)
		{
			//Discarded unreachable code: IL_0020
			int num = 0;
			int num2 = default(int);
			hitCount = num2;
			RaycastHit[] array = (hits = new RaycastHit[0]);
			int result = default(int);
			hitCount = result;
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60021D4")]
		[Cpp2IlInjected.Address(RVA = "0xCBA070", Offset = "0xCB8A70", VA = "0x180CBA070")]
		public int Raycast(Ray ray, float distance, int layerMask = -1)
		{
			//Discarded unreachable code: IL_0024
			int num = 0;
			int num2 = default(int);
			hitCount = num2;
			RaycastHit[] array = (hits = new RaycastHit[0]);
			int result = default(int);
			hitCount = result;
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60021D5")]
		[Cpp2IlInjected.Address(RVA = "0xCBA190", Offset = "0xCB8B90", VA = "0x180CBA190")]
		public void Sort(IComparer<RaycastHit> comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60021D6")]
		[Cpp2IlInjected.Address(RVA = "0xCB9FF0", Offset = "0xCB89F0", VA = "0x180CB9FF0")]
		private void ExpandBufferSize()
		{
			RaycastHit[] array = (hits = new RaycastHit[0]);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021D7")]
		[Cpp2IlInjected.Address(RVA = "0xCBA050", Offset = "0xCB8A50", VA = "0x180CBA050")]
		private bool NeedToExpandBufferSize()
		{
			//Discarded unreachable code: IL_0002
			bool result = default(bool);
			return result;
		}
	}
}
