using Cpp2IlInjected;
using UnityEngine;

namespace SoftMasking
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public interface ISoftMask
	{
		[Cpp2IlInjected.Token(Token = "0x17000199")]
		bool isAlive
		{
			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		bool isMaskingEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Material GetReplacement(Material original);

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ReleaseReplacement(Material replacement);

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UpdateTransformChildren(Transform transform);
	}
}
