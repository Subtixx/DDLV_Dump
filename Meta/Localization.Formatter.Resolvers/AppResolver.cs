using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Localization.Formatter;

namespace Localization.Formatter.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AppResolver : ScopeResolver
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private string Version
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CVersion_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CVersion_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x18E9F10", Offset = "0x18E8910", VA = "0x1818E9F10")]
		public AppResolver(string version)
			: base("app")
		{
			Version = version;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x18E9E10", Offset = "0x18E8810", VA = "0x1818E9E10", Slot = "5")]
		public override object Resolve(string key)
		{
			while (true)
			{
				if (key != null)
				{
					if (string.Equals(key, "VERSION"))
					{
						string text = Version;
					}
					if (string.Equals(key, "Now"))
					{
						break;
					}
				}
			}
			int num = 0;
			DateTime now = DateTime.Now;
			/*Error: Unexpected end of block*/;
		}
	}
}
