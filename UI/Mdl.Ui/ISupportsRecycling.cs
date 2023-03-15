using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000862")]
	public interface ISupportsRecycling
	{
		[Cpp2IlInjected.Token(Token = "0x17000780")]
		Transform TrashBin
		{
			[Cpp2IlInjected.Token(Token = "0x6003509")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600350A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600350B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SendToBin(GameObject trash);

		[Cpp2IlInjected.Token(Token = "0x600350C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Kill(GameObject trash);

		[Cpp2IlInjected.Token(Token = "0x600350D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Clear();

		[Cpp2IlInjected.Token(Token = "0x600350E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		GameObject FindReusable(Type type);

		[Cpp2IlInjected.Token(Token = "0x600350F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Delegate(ITrashSeeker trashSeeker, object param);

		[Cpp2IlInjected.Token(Token = "0x6003510")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Delegate(ITrashSeeker trashSeeker, Transform container, object param);
	}
}
