using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000739")]
	public class CountedBool
	{
		[Cpp2IlInjected.Token(Token = "0x200073A")]
		public enum RefState
		{
			[Cpp2IlInjected.Token(Token = "0x40029F7")]
			Referenced,
			[Cpp2IlInjected.Token(Token = "0x40029F8")]
			FirstReference,
			[Cpp2IlInjected.Token(Token = "0x40029F9")]
			LastReference
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40029F5")]
		private int _count;

		[Cpp2IlInjected.Token(Token = "0x6002008")]
		[Cpp2IlInjected.Address(RVA = "0x10FEC90", Offset = "0x10FD690", VA = "0x1810FEC90")]
		public CountedBool(string name = "", bool debug = false)
		{
			//IL_000f: Expected I4, but got I8
			_count = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002009")]
		[Cpp2IlInjected.Address(RVA = "0x10FECB0", Offset = "0x10FD6B0", VA = "0x1810FECB0")]
		public static implicit operator bool(CountedBool b)
		{
			if (b == null)
			{
				int num = 0;
			}
			return b._count > 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600200A")]
		[Cpp2IlInjected.Address(RVA = "0x10FEBB0", Offset = "0x10FD5B0", VA = "0x1810FEBB0")]
		private bool IsTrue()
		{
			return _count > 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600200B")]
		[Cpp2IlInjected.Address(RVA = "0x10FEB80", Offset = "0x10FD580", VA = "0x1810FEB80")]
		public RefState AddReference()
		{
			int count = _count;
			count++;
			bool flag = (_count = Mathf.Max(0, count)) == 1;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600200C")]
		[Cpp2IlInjected.Address(RVA = "0x10FEBC0", Offset = "0x10FD5C0", VA = "0x1810FEBC0")]
		public RefState ReleaseReference()
		{
			int count = _count;
			int num = (_count = Mathf.Max(0, count));
			return RefState.LastReference;
		}

		[Cpp2IlInjected.Token(Token = "0x600200D")]
		[Cpp2IlInjected.Address(RVA = "0x10FEBF0", Offset = "0x10FD5F0", VA = "0x1810FEBF0", Slot = "3")]
		public override string ToString()
		{
			int count = _count;
			return string.Format("{0} ({1})", "{0} ({1})", "{0} ({1})");
		}
	}
}
