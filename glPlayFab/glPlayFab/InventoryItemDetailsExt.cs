using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using PlayFab.EconomyModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public static class InventoryItemDetailsExt
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1030750", Offset = "0x102F150", VA = "0x181030750")]
		public static string GetProperty(this InventoryItemDetails self, string propName)
		{
			bool flag = default(bool);
			if (self.Properties == null || flag)
			{
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x10308D0", Offset = "0x102F2D0", VA = "0x1810308D0")]
		public static void SetProperty(this InventoryItemDetails self, string propName, string propValue)
		{
			//Discarded unreachable code: IL_0016
			if ((object)typeof(Dictionary<string, string>).TypeHandle == null)
			{
				Dictionary<string, string> dictionary = (self.Properties = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x10307E0", Offset = "0x102F1E0", VA = "0x1810307E0")]
		public static void SetProperty(this InventoryItemDetails self, string propName, DateTime propValue)
		{
			//Discarded unreachable code: IL_0023, IL_0024
			if (self.Properties == null)
			{
				Dictionary<string, string> dictionary = (self.Properties = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>());
				Dictionary<string, string> properties = self.Properties;
			}
			throw new NullReferenceException();
		}
	}
}
