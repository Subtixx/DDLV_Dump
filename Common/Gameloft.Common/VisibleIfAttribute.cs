using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Gameloft.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public class VisibleIfAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CPropertyName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA281E0", Offset = "0xA26BE0", VA = "0x180A281E0")]
		public VisibleIfAttribute(string propertyName)
		{
			_003CPropertyName_003Ek__BackingField = propertyName;
			/*Error: Unexpected end of block*/;
		}
	}
}
