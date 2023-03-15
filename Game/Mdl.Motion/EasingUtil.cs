using System;
using Cpp2IlInjected;

namespace Mdl.Motion
{
	[Cpp2IlInjected.Token(Token = "0x20003AD")]
	public static class EasingUtil
	{
		[Cpp2IlInjected.Token(Token = "0x6000FC3")]
		[Cpp2IlInjected.Address(RVA = "0x19D9750", Offset = "0x19D8150", VA = "0x1819D9750")]
		public unsafe static EasingFunction EasingFunction(EasingType type)
		{
			if (type <= EasingType.SineEaseInOut)
			{
				EasingFunction easingFunction = default(EasingFunction);
				if (easingFunction == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction2 = default(EasingFunction);
				if (easingFunction2 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction3 = default(EasingFunction);
				if (easingFunction3 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction4 = default(EasingFunction);
				if (easingFunction4 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction5 = default(EasingFunction);
				if (easingFunction5 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction6 = default(EasingFunction);
				if (easingFunction6 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction7 = default(EasingFunction);
				if (easingFunction7 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction8 = default(EasingFunction);
				if (easingFunction8 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction9 = default(EasingFunction);
				if (easingFunction9 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction10 = default(EasingFunction);
				if (easingFunction10 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction11 = default(EasingFunction);
				if (easingFunction11 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction12 = default(EasingFunction);
				if (easingFunction12 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction13 = default(EasingFunction);
				if (easingFunction13 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction14 = default(EasingFunction);
				if (easingFunction14 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction15 = default(EasingFunction);
				if (easingFunction15 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction16 = default(EasingFunction);
				if (easingFunction16 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction17 = default(EasingFunction);
				if (easingFunction17 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction18 = default(EasingFunction);
				if (easingFunction18 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction19 = default(EasingFunction);
				if (easingFunction19 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction20 = default(EasingFunction);
				if (easingFunction20 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction21 = default(EasingFunction);
				if (easingFunction21 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction22 = default(EasingFunction);
				if (easingFunction22 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction23 = default(EasingFunction);
				if (easingFunction23 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction24 = default(EasingFunction);
				if (easingFunction24 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction25 = default(EasingFunction);
				if (easingFunction25 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction26 = default(EasingFunction);
				if (easingFunction26 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction27 = default(EasingFunction);
				if (easingFunction27 == null)
				{
					throw new ArgumentException();
				}
				EasingFunction easingFunction28 = default(EasingFunction);
				if (easingFunction28 == null)
				{
					throw new ArgumentException();
				}
			}
			EasingFunction easingFunction29 = default(EasingFunction);
			if (easingFunction29 != null)
			{
				((Delegate)easingFunction29).method_ptr = (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear);
				((Delegate)easingFunction29).method = (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear);
				return easingFunction29;
			}
			throw new ArgumentException();
		}
	}
}
