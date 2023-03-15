using System;
using Cpp2IlInjected;
using Meta;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000474")]
	public class MiniEventMenuParam : MenuParam
	{
		[Cpp2IlInjected.Token(Token = "0x170004BC")]
		public MiniEventProgress MiniEventProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6001CC0")]
			[Cpp2IlInjected.Address(RVA = "0x1291710", Offset = "0x1290110", VA = "0x181291710")]
			get
			{
				object[] @params;
				do
				{
					@params = Params;
					if (@params.Length == 0)
					{
						int num = 0;
					}
				}
				while (@params[0] == null);
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001CC1")]
			[Cpp2IlInjected.Address(RVA = "0x1291790", Offset = "0x1290190", VA = "0x181291790")]
			internal set
			{
				object[] @params;
				do
				{
					IL_0000:
					@params = Params;
					if (@params.Length == 0)
					{
						object[] array = new object[1];
						if (value != null && array == null)
						{
							goto IL_0000;
						}
						array[0] = value;
						Params = array;
					}
				}
				while (value != null && (object)typeof(object[]).TypeHandle == null);
				@params[0] = value;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CC2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public MiniEventMenuParam()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001CC3")]
		[Cpp2IlInjected.Address(RVA = "0x1291640", Offset = "0x1290040", VA = "0x181291640")]
		public MiniEventMenuParam(MiniEventProgress MiniEventProgress)
		{
			object[] array;
			do
			{
				((object)this)._002Ector();
				array = new object[1];
			}
			while (MiniEventProgress != null && array == null);
			array[0] = MiniEventProgress;
			Params = array;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CC4")]
		[Cpp2IlInjected.Address(RVA = "0x1291610", Offset = "0x1290010", VA = "0x181291610")]
		public void CopyFrom(MenuParam menuParam)
		{
			object[] array = (Params = menuParam.Params);
			throw new NullReferenceException();
		}
	}
}
