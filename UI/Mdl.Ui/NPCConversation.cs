using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Util;
using Mdl.Dialogues;
using NodeCanvas.DialogueTrees;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007D0")]
	public class NPCConversation : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002DD6")]
		private DialogueInstance _dialogueInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002DD7")]
		private SubtitlesRequestInfo _currentSubtitleInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002DD8")]
		private List<NPCConversationCell> conversationList = (List<NPCConversationCell>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002DD9")]
		[SerializeField]
		private RectTransform _rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002DDA")]
		[SerializeField]
		private NPCConversationCell _conversationPrefab;

		[Cpp2IlInjected.Token(Token = "0x60031D5")]
		[Cpp2IlInjected.Address(RVA = "0x1297970", Offset = "0x1296370", VA = "0x181297970")]
		internal void Init(DialogueInstance e)
		{
			//Discarded unreachable code: IL_003e
			_dialogueInstance = e;
			DialogueInstance dialogueInstance = _dialogueInstance;
			AsyncEventHandler value = OnDialogueFinished;
			dialogueInstance.OnDialogueFinished += value;
			DialogueInstance dialogueInstance2 = _dialogueInstance;
			EventHandler<SubtitlesRequestInfo> eventHandler = (EventHandler<SubtitlesRequestInfo>)(object)new EventHandler<TEventArgs>(OnSubtitlesRequest);
			dialogueInstance2.add_OnSubtitleRequest((EventHandler<>)(object)eventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x60031D6")]
		[Cpp2IlInjected.Address(RVA = "0x1297A80", Offset = "0x1296480", VA = "0x181297A80")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0037
			DialogueInstance dialogueInstance = _dialogueInstance;
			AsyncEventHandler value = OnDialogueFinished;
			dialogueInstance.OnDialogueFinished -= value;
			DialogueInstance dialogueInstance2 = _dialogueInstance;
			EventHandler<SubtitlesRequestInfo> eventHandler = (EventHandler<SubtitlesRequestInfo>)(object)new EventHandler<TEventArgs>(OnSubtitlesRequest);
			dialogueInstance2.remove_OnSubtitleRequest((EventHandler<>)(object)eventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x60031D7")]
		[Cpp2IlInjected.Address(RVA = "0x1297C00", Offset = "0x1296600", VA = "0x181297C00")]
		private void OnSubtitlesRequest(object sender, SubtitlesRequestInfo info)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60031D8")]
		[Cpp2IlInjected.Address(RVA = "0x12976B0", Offset = "0x12960B0", VA = "0x1812976B0")]
		private ConversationSide GetDialogueSide(SubtitlesRequestInfo Info)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60031D9")]
		[Cpp2IlInjected.Address(RVA = "0x1297B70", Offset = "0x1296570", VA = "0x181297B70")]
		private Task OnDialogueFinished(object sender, EventArgs e)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x60031DA")]
		[Cpp2IlInjected.Address(RVA = "0x1298110", Offset = "0x1296B10", VA = "0x181298110")]
		private void Update()
		{
			//Discarded unreachable code: IL_000c
			List<NPCConversationCell> list = conversationList;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031DB")]
		[Cpp2IlInjected.Address(RVA = "0x1298220", Offset = "0x1296C20", VA = "0x181298220")]
		public NPCConversation()
		{
		}
	}
}
