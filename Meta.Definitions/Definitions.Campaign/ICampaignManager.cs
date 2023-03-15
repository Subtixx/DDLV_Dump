using Cpp2IlInjected;

namespace Definitions.Campaign
{
	[Cpp2IlInjected.Token(Token = "0x200026A")]
	public interface ICampaignManager
	{
		[Cpp2IlInjected.Token(Token = "0x6001701")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnUpdate(CampaignUpdate update, CampaignData campaign, CampaignMegaEvent megaEvent);

		[Cpp2IlInjected.Token(Token = "0x6001702")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnUpdate(CampaignUpdate update, CampaignData campaign, CampaignMiniEvent miniEvent);

		[Cpp2IlInjected.Token(Token = "0x6001703")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OnUpdate(CampaignUpdate update, CampaignData campaign, CampaignMicroEvent microEvent);

		[Cpp2IlInjected.Token(Token = "0x6001704")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnUpdate(CampaignUpdate update, CampaignData campaign, CampaignPhonePromptEvent phonePromptEvent);
	}
}
