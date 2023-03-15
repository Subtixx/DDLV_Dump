using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200050D")]
	public class KeyGroup<T> where T : IKey
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4001FCA")]
		[SerializeField]
		private List<T> keys;

		[Cpp2IlInjected.Token(Token = "0x170002EC")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6001687")]
			[Cpp2IlInjected.Address(RVA = "0x1C2A830", Offset = "0x1C29230", VA = "0x181C2A830")]
			get
			{
				((ICollection<T>)((KeyGroup<>)(object)this).keys).Clear();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002ED")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6001688")]
			[Cpp2IlInjected.Address(RVA = "0x1C2A860", Offset = "0x1C29260", VA = "0x181C2A860")]
			get
			{
				((ICollection<T>)((KeyGroup<>)(object)this).keys).Clear();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001680")]
		[Cpp2IlInjected.Address(RVA = "0x13BC500", Offset = "0x13BAF00", VA = "0x1813BC500")]
		public void Add(T key)
		{
			//Discarded unreachable code: IL_000c
			((ICollection<T>)((KeyGroup<>)(object)this).keys).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6001681")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A530", Offset = "0x1C28F30", VA = "0x181C2A530")]
		public void Remove(T key)
		{
			//Discarded unreachable code: IL_000c
			((ICollection<T>)((KeyGroup<>)(object)this).keys).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6001682")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A500", Offset = "0x1C28F00", VA = "0x181C2A500")]
		public void RemoveAt(int index)
		{
			//Discarded unreachable code: IL_000c
			((ICollection<T>)((KeyGroup<>)(object)this).keys).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6001683")]
		[Cpp2IlInjected.Address(RVA = "0x1C29EB0", Offset = "0x1C288B0", VA = "0x181C29EB0")]
		public void Clear()
		{
			//Discarded unreachable code: IL_000c
			((ICollection<T>)((KeyGroup<>)(object)this).keys).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6001684")]
		[Cpp2IlInjected.Address(RVA = "0x1C1B250", Offset = "0x1C19C50", VA = "0x181C1B250")]
		public int IndexOf(T key)
		{
			((ICollection<T>)((KeyGroup<>)(object)this).keys).Clear();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001685")]
		[Cpp2IlInjected.Address(RVA = "0x1C29EE0", Offset = "0x1C288E0", VA = "0x181C29EE0")]
		public void Evaluate(float time, out int previous, out int next, out float t)
		{
			//Discarded unreachable code: IL_00f9
			//IL_00f6: Expected F4, but got I4
			int num = (next.m_value = (previous.m_value = 0));
			List<> list = (List<>)(object)((KeyGroup<>)(object)this).keys;
			if ((long)num < (long)(IntPtr)typeof(IKey).TypeHandle)
			{
				List<> list2 = (List<>)(object)((KeyGroup<>)(object)this).keys;
				if ((long)num < (long)(IntPtr)typeof(IKey).TypeHandle)
				{
					num += num;
					num++;
				}
				List<> list3 = (List<>)(object)((KeyGroup<>)(object)this).keys;
				if ((long)num < (long)(IntPtr)typeof(IKey).TypeHandle)
				{
					num += num;
					num++;
				}
				List<> list4 = (List<>)(object)((KeyGroup<>)(object)this).keys;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				List<> list5 = (List<>)(object)((KeyGroup<>)(object)this).keys;
				previous.m_value = num;
				List<> list6 = (List<>)(object)((KeyGroup<>)(object)this).keys;
				num += 312;
				num += 344;
				num += 312;
				List<> list7 = (List<>)(object)((KeyGroup<>)(object)this).keys;
				List<> list8 = (List<>)(object)((KeyGroup<>)(object)this).keys;
				previous.m_value = num;
				List<> list9 = (List<>)(object)((KeyGroup<>)(object)this).keys;
				next.m_value = num;
				List<> list10 = (List<>)(object)((KeyGroup<>)(object)this).keys;
				next.m_value = num;
				List<> list11 = (List<>)(object)((KeyGroup<>)(object)this).keys;
				List<> list12 = (List<>)(object)((KeyGroup<>)(object)this).keys;
				num++;
			}
			List<> list13 = (List<>)(object)((KeyGroup<>)(object)this).keys;
			List<> list14 = (List<>)(object)((KeyGroup<>)(object)this).keys;
			uint num3 = default(uint);
			float num4 = Mathf.InverseLerp((int)num3, time, time);
		}

		[Cpp2IlInjected.Token(Token = "0x6001686")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A560", Offset = "0x1C28F60", VA = "0x181C2A560")]
		public void Reorder()
		{
			if ((object)typeof(_003C_003Ec).TypeHandle == null)
			{
			}
			IOrderedEnumerable<> orderedEnumerable = default(IOrderedEnumerable<>);
			List<> list = (List<>)(object)(((KeyGroup<>)(object)this).keys = (List<T>)(object)Enumerable.ToList<_0021_00210>((IEnumerable<>)orderedEnumerable));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001689")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A7B0", Offset = "0x1C291B0", VA = "0x181C2A7B0")]
		public KeyGroup()
		{
			((KeyGroup<>)(object)this).keys = (List<T>)(object)new List<T>();
			base._002Ector();
		}
	}
}
