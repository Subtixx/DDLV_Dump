using System;
using Cpp2IlInjected;

namespace Gameloft.Federation.Client
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class ExceptionFactories
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public unsafe static ExceptionFactory Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x4033600", Offset = "0x4032000", VA = "0x184033600")]
			get
			{
				ExceptionFactory _003C_003E9__1_ = _003C_003Ec._003C_003E9__1_0;
				if (_003C_003E9__1_ == null)
				{
					_003C_003Ec _003C_003E = _003C_003Ec._003C_003E9;
					ExceptionFactory exceptionFactory = default(ExceptionFactory);
					if (_003C_003E == null && exceptionFactory == null)
					{
						throw new ArgumentException();
					}
					((Delegate)exceptionFactory).method_ptr = (IntPtr)__ldftn(_003C_003Ec._003Cget_Default_003Eb__1_0);
					((Delegate)exceptionFactory).m_target = _003C_003E;
					((Delegate)exceptionFactory).method = (IntPtr)__ldftn(_003C_003Ec._003Cget_Default_003Eb__1_0);
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)exceptionFactory;
				}
				return _003C_003E9__1_;
			}
		}
	}
}
