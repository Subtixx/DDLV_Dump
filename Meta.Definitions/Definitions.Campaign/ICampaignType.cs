using Cpp2IlInjected;

namespace Definitions.Campaign
{
	[Cpp2IlInjected.Token(Token = "0x200026B")]
	public interface ICampaignType
	{
		[Cpp2IlInjected.Token(Token = "0x6001705")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnUpdate(CampaignUpdate update, ICampaignManager manager, CampaignData campaign);
	}
}
