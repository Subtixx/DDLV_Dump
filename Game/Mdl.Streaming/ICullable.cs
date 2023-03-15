using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Streaming
{
	[Cpp2IlInjected.Token(Token = "0x20007F8")]
	public interface ICullable
	{
		[Cpp2IlInjected.Token(Token = "0x170004FD")]
		bool Visible
		{
			[Cpp2IlInjected.Token(Token = "0x6002383")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002384")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004FE")]
		int LastDistanceIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6002385")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002386")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004FF")]
		bool IsHandleValid
		{
			[Cpp2IlInjected.Token(Token = "0x6002387")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000500")]
		bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6002388")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000501")]
		float CullableHeight
		{
			[Cpp2IlInjected.Token(Token = "0x600238D")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000502")]
		StreamableAssetRefType CullableAssetType
		{
			[Cpp2IlInjected.Token(Token = "0x600238E")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6002382")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string GetDebugName();

		[Cpp2IlInjected.Token(Token = "0x6002389")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Load();

		[Cpp2IlInjected.Token(Token = "0x600238A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Unload(bool fromDisable);

		[Cpp2IlInjected.Token(Token = "0x600238B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Vector3 GetWorldPosition();

		[Cpp2IlInjected.Token(Token = "0x600238C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		float GetRadius();
	}
}
