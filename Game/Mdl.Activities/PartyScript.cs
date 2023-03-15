using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Audio;
using Mdl.Characters;
using Mdl.Ftue.Cutscenes;
using Mdl.Missions;
using Mdl.Navigation;
using Mdl.Systems;
using Meta.Missions;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B84")]
	public class PartyScript : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400400B")]
		public float FadeOutDuration = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400400C")]
		public float FadeInDuration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400400D")]
		public GameObject AvatarPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400400E")]
		public List<GameObject> CharacterPositions = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400400F")]
		public List<AK.Wwise.Event> sfxEvents = (List<AK.Wwise.Event>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4004010")]
		private Cutscene cutscene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4004011")]
		[SerializeField]
		private PhotoModeType defaultPhotoMode = PhotoModeType.Avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004012")]
		[SerializeField]
		private Transform overrideFreeStartCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4004013")]
		private List<(Character character, CharacterAnimation animation)> usedCharacters = (List<(Character character, CharacterAnimation animation)>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x600354E")]
		[Cpp2IlInjected.Address(RVA = "0xF0C400", Offset = "0xF0AE00", VA = "0x180F0C400")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0029
			Cutscene cutscene = (this.cutscene = GetComponent<Cutscene>());
			GameObject gameObject = this.cutscene.inputRect.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600354F")]
		[Cpp2IlInjected.Address(RVA = "0xF0C590", Offset = "0xF0AF90", VA = "0x180F0C590")]
		[AsyncStateMachine(typeof(_003CInitAsync_003Ed__9))]
		public Task InitAsync(MissionObjective partyObjective, MissionManager missionManager, CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003550")]
		[Cpp2IlInjected.Address(RVA = "0xF0C9A0", Offset = "0xF0B3A0", VA = "0x180F0C9A0")]
		private void PlayAudio()
		{
			//Discarded unreachable code: IL_001f
			int num = 0;
			GameObject gameObject = SystemRoot.Instance.GetSystem<AudioManager>().gameObject;
			List<AK.Wwise.Event> list = sfxEvents;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003551")]
		[Cpp2IlInjected.Address(RVA = "0xF0C6E0", Offset = "0xF0B0E0", VA = "0x180F0C6E0")]
		private bool IsUsingCharacter(Item characterItem)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003552")]
		[Cpp2IlInjected.Address(RVA = "0xF0C860", Offset = "0xF0B260", VA = "0x180F0C860")]
		[AsyncStateMachine(typeof(_003CPlaceCharacters_003Ed__13))]
		private Task PlaceCharacters(CustomStepParty partyStep, PlayerNavigation playerNavigation)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003553")]
		[Cpp2IlInjected.Address(RVA = "0xF0C480", Offset = "0xF0AE80", VA = "0x180F0C480")]
		private void EnableCharactersAI(bool enabled)
		{
			//Discarded unreachable code: IL_003d
			List<(Character, CharacterAnimation)> list = usedCharacters;
			Action<(Character, CharacterAnimation)> action = (Action<(Character, CharacterAnimation)>)(object)(Action<T>)delegate
			{
				//Discarded unreachable code: IL_0008
				bool flag = enabled;
			};
			((List<T>)(object)list).ForEach((Action<>)(object)action);
			if (enabled)
			{
				((List<T>)(object)usedCharacters).Clear();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003554")]
		[Cpp2IlInjected.Address(RVA = "0xF0C1F0", Offset = "0xF0ABF0", VA = "0x180F0C1F0")]
		private void AnimateCharacters()
		{
			//Discarded unreachable code: IL_0012, IL_0018, IL_001e, IL_0024
			int num = 0;
			List<(Character, CharacterAnimation)> list = usedCharacters;
			bool flag = default(bool);
			if (flag)
			{
				while (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003555")]
		[Cpp2IlInjected.Address(RVA = "0xF0CB60", Offset = "0xF0B560", VA = "0x180F0CB60")]
		private void RotateCharacters(CancellationToken ct)
		{
			//Discarded unreachable code: IL_0012, IL_0018
			List<(Character, CharacterAnimation)> list = usedCharacters;
			bool flag = default(bool);
			if (flag)
			{
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003556")]
		[Cpp2IlInjected.Address(RVA = "0xF0CCE0", Offset = "0xF0B6E0", VA = "0x180F0CCE0")]
		public PartyScript()
		{
		}//IL_0039: Expected I4, but got I8

	}
}
