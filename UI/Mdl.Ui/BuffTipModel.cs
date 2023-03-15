using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Campaign;
using Meta;
using Meta.Online;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000573")]
	internal class BuffTipModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001DCA")]
		private List<CampaignData> _campaignDataList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DCB")]
		public List<BuffItemModel> BuffItemModels = (List<BuffItemModel>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DCC")]
		public List<Buff> ActivBuff = (List<Buff>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x60023B4")]
		[Cpp2IlInjected.Address(RVA = "0xA677A0", Offset = "0xA661A0", VA = "0x180A677A0")]
		public BuffTipModel([Optional] List<CampaignData> campaignDataList, [Optional] List<Buff> activBuff)
		{
			_campaignDataList = campaignDataList;
			ActivBuff = activBuff;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023B5")]
		[Cpp2IlInjected.Address(RVA = "0xA673C0", Offset = "0xA65DC0", VA = "0x180A673C0")]
		public void RefreshData()
		{
			//Discarded unreachable code: IL_007e, IL_0084, IL_008a, IL_0090, IL_0096, IL_009c, IL_00a2, IL_00a8, IL_00ae, IL_00b4, IL_00ba, IL_00c0
			//IL_0029: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			bool flag = default(bool);
			if (_campaignDataList != null && flag)
			{
				CampaignMicroEvent campaignMicroEvent = default(CampaignMicroEvent);
				string name_ = campaignMicroEvent.name_;
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				BuffItemModel buffItemModel = new BuffItemModel((MicroEventData)num3, (CampaignData)num2);
				buffItemModel.RefreshData();
				((List<T>)(object)BuffItemModels).Add((T)buffItemModel);
			}
			bool flag3 = default(bool);
			if (ActivBuff != null && flag3)
			{
				int buffPercentage = 0;
				Client client = default(Client);
				ProfilePlayer player_ = client.profile.player_;
				BuffDisplayData buffDisplayData = default(BuffDisplayData);
				BuffItemModel buffItemModel2 = new BuffItemModel(buffPercentage, buffDisplayData);
				buffItemModel2.RefreshData();
				((List<T>)(object)BuffItemModels).Add((T)buffItemModel2);
			}
		}
	}
}
