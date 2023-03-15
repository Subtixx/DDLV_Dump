using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Meta;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007AC")]
	public interface IItemSelectorItem
	{
		[Cpp2IlInjected.Token(Token = "0x170006E3")]
		bool CanHaveAdditionalIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6003110")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170006E4")]
		bool CanHaveCountIndicator
		{
			[Cpp2IlInjected.Token(Token = "0x6003111")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170006E5")]
		bool AlwaysAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6003112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170006E6")]
		int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6003113")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170006E7")]
		ItemType? ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6003114")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170006E8")]
		string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6003115")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6003116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool ShowQuestMarker(IEnumerable<ProfileWorld.FilterInfo> quests);

		[Cpp2IlInjected.Token(Token = "0x6003117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task LoadIcon(AsyncAtlassedIcon icon, CancellationToken ct);
	}
}
