using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ftue
{
	[Cpp2IlInjected.Token(Token = "0x2000586")]
	public interface IWorldHint
	{
		[Cpp2IlInjected.Token(Token = "0x1700034A")]
		string MessageKey
		{
			[Cpp2IlInjected.Token(Token = "0x60018AA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700034B")]
		Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x60018AB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700034C")]
		float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x60018AC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700034D")]
		float Zoom
		{
			[Cpp2IlInjected.Token(Token = "0x60018AD")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700034E")]
		Collider Collider
		{
			[Cpp2IlInjected.Token(Token = "0x60018AE")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700034F")]
		WorldHintCompletion Completion
		{
			[Cpp2IlInjected.Token(Token = "0x60018AF")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000350")]
		BubblePosition BubblePosition
		{
			[Cpp2IlInjected.Token(Token = "0x60018B0")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000351")]
		bool RecenterCamera
		{
			[Cpp2IlInjected.Token(Token = "0x60018B1")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
}
