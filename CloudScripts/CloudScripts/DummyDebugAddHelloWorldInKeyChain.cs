using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	public class DummyDebugAddHelloWorldInKeyChain : OnlineProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected override int GetRequiredFragmentCount
		{
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "5")]
			get
			{
				return 1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x116D8E0", Offset = "0x116C2E0", VA = "0x18116D8E0")]
		public DummyDebugAddHelloWorldInKeyChain()
		{
			base.Name = "DummyDebugAddHelloWorldInKeyChain";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x116D620", Offset = "0x116C020", VA = "0x18116D620", Slot = "4")]
		protected override List<PreGameLoad.DataFragments> ListRequiredDataFragments()
		{
			//Discarded unreachable code: IL_002f
			List<PreGameLoad.DataFragments> list = (List<PreGameLoad.DataFragments>)(object)new List<T>();
			PreGameLoad.DataFragments dataFragments = new PreGameLoad.DataFragments();
			OnlineDataFileInfo onlineDataFileInfo = (dataFragments.FileInfo = OnlineDataFileInfo.KeyChainFileInfo);
			string text = (dataFragments.jsonSelectToken = PreGameLoad.DataFragments.AllFileSearchToken);
			((List<T>)(object)list).Add((T)dataFragments);
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x116D760", Offset = "0x116C160", VA = "0x18116D760", Slot = "6")]
		protected override PreGameLoad.DataFragments.ImplProcessingResult ProcessRequiredDataFragments(List<PreGameLoad.DataFragments> dataFragments)
		{
			PreGameLoad.DataFragments dataFragments2 = Enumerable.First<PreGameLoad.DataFragments>((IEnumerable<>)dataFragments);
			if (dataFragments2 != null)
			{
				JToken _003CCachedJToken_003Ek__BackingField = dataFragments2.CachedJToken;
				if (_003CCachedJToken_003Ek__BackingField != null)
				{
					int num = 0;
					if (_003CCachedJToken_003Ek__BackingField != null)
					{
						bool flag = default(bool);
						if (flag)
						{
							return dataFragments2.WithImplProcessResult(PreGameLoad.DataFragments.ImplProcessingResult.NoFixRequired);
						}
						JToken jToken = "Hello";
						JToken _003CCachedJToken_003Ek__BackingField2 = dataFragments2.CachedJToken;
						dataFragments2.FromJToken(_003CCachedJToken_003Ek__BackingField2);
						return dataFragments2.WithImplProcessResult(PreGameLoad.DataFragments.ImplProcessingResult.FixToApply);
					}
					return dataFragments2.WithImplProcessResult(PreGameLoad.DataFragments.ImplProcessingResult.DataError);
				}
			}
			return PreGameLoad.DataFragments.ImplProcessingResult.DataError;
		}
	}
}
