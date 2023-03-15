using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AC1")]
	public abstract class ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x17001044")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002AEE")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6005D38")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005D39")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001045")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4002AEF")]
		public bool WasAppliedJson
		{
			[Cpp2IlInjected.Token(Token = "0x6005D3A")]
			[Cpp2IlInjected.Address(RVA = "0xC58490", Offset = "0xC56E90", VA = "0x180C58490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005D3B")]
			[Cpp2IlInjected.Address(RVA = "0xC584C0", Offset = "0xC56EC0", VA = "0x180C584C0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001046")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x15"), Cpp2IlInjected.Token(Token = "0x4002AF0")]
		public bool WasAppliedProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6005D3E")]
			[Cpp2IlInjected.Address(RVA = "0xC584A0", Offset = "0xC56EA0", VA = "0x180C584A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005D3F")]
			[Cpp2IlInjected.Address(RVA = "0xC584D0", Offset = "0xC56ED0", VA = "0x180C584D0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D3C")]
		[Cpp2IlInjected.Address(RVA = "0x14755F0", Offset = "0x1473FF0", VA = "0x1814755F0")]
		public bool TryApplyJson(JObject profile)
		{
			if (WasAppliedJson)
			{
				int num = 0;
			}
			DoApplyJson(profile);
			WasAppliedJson = true;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D3D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		protected virtual void DoApplyJson(JObject profile)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005D40")]
		[Cpp2IlInjected.Address(RVA = "0x1475630", Offset = "0x1474030", VA = "0x181475630")]
		public bool TryApplyProfile(Profile profile)
		{
			if (WasAppliedProfile)
			{
				int num = 0;
			}
			DoApplyProfile(profile);
			WasAppliedProfile = true;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D41")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		protected virtual void DoApplyProfile(Profile profile)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005D42")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected ProfileUpdate()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			DoApplyJson((JObject)num);
		}
	}
}
