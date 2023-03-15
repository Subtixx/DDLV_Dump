using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000664")]
	public interface ICookingIngredient : IHasTags
	{
		[Cpp2IlInjected.Token(Token = "0x17001342")]
		Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6004A71")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001343")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6004A72")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001344")]
		Item CookingIngredientTypeItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004A73")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001345")]
		bool CanBeUsedAsIngredient
		{
			[Cpp2IlInjected.Token(Token = "0x6004A74")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
}
