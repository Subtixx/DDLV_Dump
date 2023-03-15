using System.Collections.Generic;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	public interface IDataReport
	{
		[Cpp2IlInjected.Token(Token = "0x17000191")]
		string UniqueKey
		{
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		string Output
		{
			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006CB")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006CD")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Build(BaseDataReport.Context ctx);
	}
}
