using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using PlayFab.ClientModels;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007B5")]
	public sealed class RequiredAllNotNullAttribute : ClassValidationAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002BB9")]
		private readonly IEnumerable<RequiredAttribute> nonNull;

		[Cpp2IlInjected.Token(Token = "0x6002245")]
		[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "7")]
		public override IEnumerable<RequiredAttribute> GetRequiredAttributes(Type type)
		{
			return nonNull;
		}

		[Cpp2IlInjected.Token(Token = "0x6002246")]
		[Cpp2IlInjected.Address(RVA = "0xCC16E0", Offset = "0xCC00E0", VA = "0x180CC16E0")]
		public RequiredAllNotNullAttribute()
		{
			//Discarded unreachable code: IL_002b
			NotNullAttribute[] array;
			NotNullAttribute notNullAttribute;
			do
			{
				array = new NotNullAttribute[1];
				notNullAttribute = new NotNullAttribute();
			}
			while (notNullAttribute != null && notNullAttribute == null);
			array[0] = notNullAttribute;
			nonNull = array;
			((LinkNintendoSwitchDeviceIdResult)(object)this)._002Ector();
		}
	}
}
