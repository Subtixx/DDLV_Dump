using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20008A1")]
	public interface IHasTween
	{
		[Cpp2IlInjected.Token(Token = "0x6003639")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PlayTween(int index);

		[Cpp2IlInjected.Token(Token = "0x600363A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PlayTweens(string indexes);

		[Cpp2IlInjected.Token(Token = "0x600363B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PlayTweenAll();

		[Cpp2IlInjected.Token(Token = "0x600363C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PlayTweenSequence(string indexes);

		[Cpp2IlInjected.Token(Token = "0x600363D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OnComplete(int index);

		[Cpp2IlInjected.Token(Token = "0x600363E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Kill(int index);
	}
}
