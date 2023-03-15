using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Gameloft.Localization.Formatter;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BAE")]
	public sealed class UnlockUpgradeResolver : IResolver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004115")]
		private CurrencyCost _cost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004116")]
		private int _playerLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4004117")]
		private int _charactersCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004118")]
		private string _requiredCharacter;

		[Cpp2IlInjected.Token(Token = "0x60035D8")]
		[Cpp2IlInjected.Address(RVA = "0xD39460", Offset = "0xD37E60", VA = "0x180D39460")]
		public UnlockUpgradeResolver([Optional] CurrencyCost cost, int playerLevel = 0, int charactersCount = 0, [Optional] string requiredCharacter)
		{
			//IL_0014: Expected O, but got I4
			_cost = cost;
			_requiredCharacter = (string)0;
			_playerLevel = playerLevel;
			_charactersCount = charactersCount;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60035D9")]
		[Cpp2IlInjected.Address(RVA = "0xD392F0", Offset = "0xD37CF0", VA = "0x180D392F0", Slot = "4")]
		public object Resolve(string key)
		{
			if ("" == null)
			{
				string a = key.ToLower();
				if (!string.Equals(a, "upgradeprice") && !string.Equals(a, "playerlevel") && !string.Equals(a, "charactersunlocked"))
				{
					if (!string.Equals(a, "requiredcharacter"))
					{
						goto IL_0057;
					}
					string requiredCharacter = _requiredCharacter;
				}
				if (_cost == null)
				{
				}
			}
			goto IL_0057;
			IL_0057:
			int num = 0;
			throw new NullReferenceException();
		}
	}
}
