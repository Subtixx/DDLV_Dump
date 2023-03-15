using Cpp2IlInjected;
using Mdl.Missions;
using Mdl.Systems;
using Meta.Missions;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[Description("(Ctrl-Shift-I) Accept mission\n(Ctrl-Shift-O) Reject mission when accept unchecked")]
	[Icon("Dialogue", false, "")]
	[Category("Mdl")]
	public class AcceptMission : MdlActionTask
	{
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public const string ACCEPT_MISSION = "Accept Mission";

		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public const string REJECT_MISSION = "Reject Mission";

		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public const string SET_FLAG = "SetFlag";

		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public const string GIVE_ITEM = "GiveItem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public BBParameter<bool> accept;

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0xA3A110", Offset = "0xA38B10", VA = "0x180A3A110", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_001f
				//IL_000c: Expected I4, but got O
				bool flag = (byte)(int)((BBParameter<T>)(object)accept).value != 0;
				string result = "Reject Mission";
				if (flag)
				{
					result = "Accept Mission";
				}
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xA39FE0", Offset = "0xA389E0", VA = "0x180A39FE0", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_002e
			//IL_001e: Expected I4, but got O
			MissionManager system = SystemRoot.Instance.GetSystem<MissionManager>();
			MissionSlot missionSlot = base.MissionSlot;
			bool flag = (byte)(int)((BBParameter<T>)(object)accept).value != 0;
			system.AcceptMission(missionSlot, flag);
			EndAction(success: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public AcceptMission()
		{
		}
	}
}
