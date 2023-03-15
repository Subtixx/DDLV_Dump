using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006CD")]
	public class FakePurchaseHistory
	{
		[Cpp2IlInjected.Token(Token = "0x17000664")]
		public List<KeyValuePair<int, DateTime>> PurchaseHistoryList
		{
			[Cpp2IlInjected.Token(Token = "0x6002BBC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CPurchaseHistoryList_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002BBD")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CPurchaseHistoryList_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (List<KeyValuePair<int, DateTime>>)(object)new List<T>();


		[Cpp2IlInjected.Token(Token = "0x6002BBE")]
		[Cpp2IlInjected.Address(RVA = "0x152E940", Offset = "0x152D340", VA = "0x18152E940")]
		public FakePurchaseHistory()
		{
		}
	}
}
