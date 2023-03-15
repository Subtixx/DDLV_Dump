using System;
using Cpp2IlInjected;

namespace Gameloft.Tracking.Device
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class DataProviderAdapter<T> : IDataProvider<T> where T : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Func<T> handler;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x188BEB0", Offset = "0x188A8B0", VA = "0x18188BEB0")]
		public DataProviderAdapter(Func<T> handler)
		{
			((DataProviderAdapter<>)(object)this).handler = handler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1C7C700", Offset = "0x1C7B100", VA = "0x181C7C700", Slot = "4")]
		public T GetData()
		{
			Func<> func = (Func<>)(object)((DataProviderAdapter<>)(object)this).handler;
			if (func != null)
			{
				object obj = ((ICloneable)func).Clone();
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
