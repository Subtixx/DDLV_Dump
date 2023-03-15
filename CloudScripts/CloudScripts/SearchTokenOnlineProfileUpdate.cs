using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	public abstract class SearchTokenOnlineProfileUpdate : OnlineProfileUpdate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private string searchToken;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		protected bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x1170F10", Offset = "0x116F910", VA = "0x181170F10")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		protected override int GetRequiredFragmentCount
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "5")]
			get
			{
				return 1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x1170E80", Offset = "0x116F880", VA = "0x181170E80")]
		protected SearchTokenOnlineProfileUpdate(string name, string searchToken)
		{
			base.Name = name;
			this.searchToken = searchToken;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x1170D50", Offset = "0x116F750", VA = "0x181170D50", Slot = "4")]
		protected override List<PreGameLoad.DataFragments> ListRequiredDataFragments()
		{
			if ((long)searchToken > 0)
			{
				List<PreGameLoad.DataFragments> list = (List<PreGameLoad.DataFragments>)(object)new List<T>();
				PreGameLoad.DataFragments dataFragments = new PreGameLoad.DataFragments();
				OnlineDataFileInfo onlineDataFileInfo = (dataFragments.FileInfo = OnlineDataFileInfo.ClientProfileFileInfo);
				string text = (dataFragments.jsonSelectToken = searchToken);
				((List<T>)(object)list).Add((T)dataFragments);
				return list;
			}
			int num = 0;
			throw new NullReferenceException();
		}
	}
}
