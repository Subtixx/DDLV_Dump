using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	public class DummyDebugReplaceSettingsWithPotatoes : SearchTokenOnlineProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x116DBE0", Offset = "0x116C5E0", VA = "0x18116DBE0")]
		public DummyDebugReplaceSettingsWithPotatoes()
		{
			((OnlineProfileUpdate)this).Name = "DummyDebugReplaceSettingsWithPotatoes";
			base.searchToken = "Settings";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x116D970", Offset = "0x116C370", VA = "0x18116D970", Slot = "6")]
		protected override PreGameLoad.DataFragments.ImplProcessingResult ProcessRequiredDataFragments(List<PreGameLoad.DataFragments> dataFragments)
		{
			//Discarded unreachable code: IL_0030, IL_006a
			int num = 0;
			PreGameLoad.DataFragments dataFragments2 = Enumerable.First<PreGameLoad.DataFragments>((IEnumerable<>)dataFragments);
			if (dataFragments2 != null)
			{
				JToken _003CCachedJToken_003Ek__BackingField = dataFragments2.CachedJToken;
				if (_003CCachedJToken_003Ek__BackingField != null)
				{
					int num2 = 0;
					bool flag = default(bool);
					bool flag2 = default(bool);
					if (_003CCachedJToken_003Ek__BackingField != null && flag && flag2)
					{
						return dataFragments2.WithImplProcessResult(PreGameLoad.DataFragments.ImplProcessingResult.NoFixRequired);
					}
					return dataFragments2.WithImplProcessResult(PreGameLoad.DataFragments.ImplProcessingResult.DataError);
				}
			}
			return PreGameLoad.DataFragments.ImplProcessingResult.DataError;
		}
	}
}
