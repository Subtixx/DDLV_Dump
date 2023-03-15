using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Gameloft.Localization.Formatter
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class MultiResolver : IResolver
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000004")]
		private IReadOnlyCollection<IResolver> Resolvers
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public MultiResolver(IReadOnlyCollection<IResolver> list)
		{
			Resolvers = list;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x408FEB0", Offset = "0x408E8B0", VA = "0x18408FEB0", Slot = "4")]
		object IResolver.Resolve(string key)
		{
			//Discarded unreachable code: IL_0040, IL_0046
			int num = 0;
			IReadOnlyCollection<IResolver> readOnlyCollection = Resolvers;
			if ((object)typeof(Resolver).TypeHandle != null)
			{
				while ((object)typeof(Resolver).TypeHandle == null)
				{
				}
				int num2 = 0;
				if ((object)typeof(Resolver).TypeHandle == null || (object)typeof(Resolver).TypeHandle != null)
				{
				}
				num++;
			}
			num++;
			int num3 = 0;
			if (num != 0)
			{
			}
			throw new NullReferenceException();
		}
	}
}
