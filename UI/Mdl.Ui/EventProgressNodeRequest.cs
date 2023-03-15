using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Missions;
using Mdl.Systems;
using Meta;
using Meta.Missions;
using Meta.Online;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200046D")]
	[ExecuteInEditMode]
	public class EventProgressNodeRequest : EventProgressNodeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001676")]
		[SerializeField]
		private Image _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001677")]
		[SerializeField]
		private Image _mcOutline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001678")]
		[SerializeField]
		private GameObject _mcCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001679")]
		[SerializeField]
		private GameObject _mcCheat;

		[Cpp2IlInjected.Token(Token = "0x170004AF")]
		public EventRequestModel Model
		{
			[Cpp2IlInjected.Token(Token = "0x6001C8E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C8F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C90")]
		[Cpp2IlInjected.Address(RVA = "0x1402560", Offset = "0x1400F60", VA = "0x181402560", Slot = "5")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0108
			//IL_0065: Expected O, but got I4
			int num = 0;
			if (!Application.isPlaying || (long)Model == 0)
			{
				return;
			}
			Transform transform = base.transform;
			EventRequestModel eventRequestModel = Model;
			Vector2 _003CNodePosition_003Ek__BackingField = eventRequestModel.NodePosition;
			float y = eventRequestModel.NodePosition.y;
			int state = (int)Model.GetState();
			Client client = default(Client);
			ProfileWorld world_ = client.profile.world_;
			int num2 = 0;
			bool flag = Enumerable.Any<MissionSlot>(world_.GetValidMissionSlot(MissionSlotClass.TimeLimitedEvent, (Func<, >)num2));
			GameObject mcCheat = _mcCheat;
			if (!flag)
			{
				EventChapterModel _003CChapterModel_003Ek__BackingField = Model.ChapterModel;
				if (_003CChapterModel_003Ek__BackingField != null && _003CChapterModel_003Ek__BackingField.GetState() == EventChapterModel.State.Locked)
				{
					EventChapterModel _003CPrevChapter_003Ek__BackingField = Model.ChapterModel.PrevChapter;
					if (_003CPrevChapter_003Ek__BackingField != null)
					{
						EventChapterModel.State state2 = _003CPrevChapter_003Ek__BackingField.GetState();
					}
				}
			}
			int active = 0;
			mcCheat.SetActive((byte)active != 0);
			Image mcIcon = _mcIcon;
			if (state == 0)
			{
				int num3 = 0;
			}
			Color white = Color.white;
			Image mcOutline = _mcOutline;
			if (state == 0)
			{
				int num4 = 0;
			}
			Color white2 = Color.white;
			GameObject mcCompleted = _mcCompleted;
			bool active2 = state == 2;
			mcCompleted.SetActive(active2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C91")]
		[Cpp2IlInjected.Address(RVA = "0x1402320", Offset = "0x1400D20", VA = "0x181402320", Slot = "4")]
		public override int GetStateValue()
		{
			EventRequestModel eventRequestModel = Model;
			if (eventRequestModel != null)
			{
				EventRequestModel.State state = eventRequestModel.GetState();
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C92")]
		[Cpp2IlInjected.Address(RVA = "0x1402340", Offset = "0x1400D40", VA = "0x181402340")]
		public void OnClicked()
		{
			//Discarded unreachable code: IL_00a2
			//IL_009f: Expected O, but got I4
			EventRequestModel eventRequestModel = Model;
			if (eventRequestModel == null || eventRequestModel.GetState() != EventRequestModel.State.InProgress)
			{
				return;
			}
			Client client = default(Client);
			Profile profile = client.profile;
			EventChapterModel _003CChapterModel_003Ek__BackingField = Model.ChapterModel;
			ProfileWorld world_ = profile.world_;
			Item _003CCharacterItem_003Ek__BackingField = _003CChapterModel_003Ek__BackingField.CharacterItem;
			Character character = world_.GetCharacter(_003CCharacterItem_003Ek__BackingField);
			if ((long)character != 0)
			{
				int num = 0;
				UiRoot.Instance._menuStack.Pop();
				var vars = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
				{
					OnComplete = (_003COnComplete_003Ej__TPar)(TweenDelegate)delegate
					{
						//Discarded unreachable code: IL_0023
						//IL_0022: Expected O, but got I4
						//IL_0022: Expected O, but got I4
						GoBehaviourSystem system = SystemRoot.Instance.GetSystem<GoBehaviourSystem>();
						int num3 = 0;
						Character character2 = character;
						int num4 = 0;
						system.GoRedirect(GoBehavior.TalkToCharacter, character2, (byte)num4 != 0, (MissionSlot)num3, (Nullable<>)num3);
					}
				};
				int num2 = 0;
				TweenMax tweenMax = TweenMax.To(this, 1f, vars, int.MinValue, num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C93")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EventProgressNodeRequest()
		{
		}
	}
}
