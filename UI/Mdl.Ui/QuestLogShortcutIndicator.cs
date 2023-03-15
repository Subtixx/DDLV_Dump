using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200068F")]
	public class QuestLogShortcutIndicator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024DE")]
		[SerializeField]
		private QuestLogDetails _questLogDetails;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024DF")]
		[SerializeField]
		private Button _trackButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40024E0")]
		[SerializeField]
		private ShortcutIndicator _shortcutIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40024E1")]
		[SerializeField]
		private bool _enableTrackButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40024E2")]
		private Item _lastMissionItem = Item.Invalid;

		[Cpp2IlInjected.Token(Token = "0x6002A57")]
		[Cpp2IlInjected.Address(RVA = "0xF320A0", Offset = "0xF30AA0", VA = "0x180F320A0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0027
			Refresh();
			UnityEvent currentSelectedMissionChanged = _questLogDetails.CurrentSelectedMissionChanged;
			UnityAction call = Refresh;
			currentSelectedMissionChanged.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A58")]
		[Cpp2IlInjected.Address(RVA = "0xF32000", Offset = "0xF30A00", VA = "0x180F32000")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0021
			UnityEvent currentSelectedMissionChanged = _questLogDetails.CurrentSelectedMissionChanged;
			UnityAction call = Refresh;
			currentSelectedMissionChanged.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A59")]
		[Cpp2IlInjected.Address(RVA = "0xF32150", Offset = "0xF30B50", VA = "0x180F32150")]
		private void Refresh()
		{
			//Discarded unreachable code: IL_0089
			MissionItemData missionItemData = _questLogDetails.MissionItemData;
			if (missionItemData != null)
			{
				int iD = missionItemData.ID;
			}
			Item invalid = Item.Invalid;
			if ((object)invalid == null)
			{
				_lastMissionItem = invalid;
				if (SystemRoot.Instance.MetaClient.profile.world_.IsMissionAvailable(invalid))
				{
				}
				Client client = default(Client);
				bool active = client.profile.world_.IsMissionStarted(invalid);
				_shortcutIndicator.gameObject.SetActive(active);
				GameObject gameObject = _trackButton.gameObject;
				bool enableTrackButton = _enableTrackButton;
				gameObject.SetActive(enableTrackButton);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A5A")]
		[Cpp2IlInjected.Address(RVA = "0xF323A0", Offset = "0xF30DA0", VA = "0x180F323A0")]
		public QuestLogShortcutIndicator()
		{
		}
	}
}
