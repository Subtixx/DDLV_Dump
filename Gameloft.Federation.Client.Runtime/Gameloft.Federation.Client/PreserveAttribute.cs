using System;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public PreserveAttribute()
		{
		}
	}
}
