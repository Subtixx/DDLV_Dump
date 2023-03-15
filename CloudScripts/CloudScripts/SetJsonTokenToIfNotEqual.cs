using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	public class SetJsonTokenToIfNotEqual : SearchTokenOnlineProfileUpdate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private JToken newValue;

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		protected new bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x1171080", Offset = "0x116FA80", VA = "0x181171080")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x1170FE0", Offset = "0x116F9E0", VA = "0x181170FE0")]
		protected unsafe SetJsonTokenToIfNotEqual(string name, string searchToken, JToken newValue)
		{
			//IL_000b: Expected O, but got I4
			int num = 0;
			((object)this).FieldGetter((string)num, searchToken, ref *(object*)newValue);
			((OnlineProfileUpdate)this).Name = name;
			base.searchToken = searchToken;
			this.newValue = newValue;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x1170F20", Offset = "0x116F920", VA = "0x181170F20", Slot = "6")]
		protected override PreGameLoad.DataFragments.ImplProcessingResult ProcessRequiredDataFragments(List<PreGameLoad.DataFragments> dataFragments)
		{
			if ((long)newValue > 0)
			{
				PreGameLoad.DataFragments dataFragments2 = Enumerable.First<PreGameLoad.DataFragments>((IEnumerable<>)dataFragments);
				if (dataFragments2 != null && dataFragments2.CachedJToken != null)
				{
					if (dataFragments2 != null)
					{
						return dataFragments2.WithImplProcessResult(PreGameLoad.DataFragments.ImplProcessingResult.NoFixRequired);
					}
					JToken token = newValue;
					dataFragments2.FromJToken(token);
					return dataFragments2.WithImplProcessResult(PreGameLoad.DataFragments.ImplProcessingResult.FixToApply);
				}
			}
			return PreGameLoad.DataFragments.ImplProcessingResult.DataError;
		}
	}
}
