using System;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Characters;
using Mdl.Environments;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000B17")]
	public class PlayEventWithCharacter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003DB5")]
		[SerializeField]
		private AK.Wwise.Event sfx_event;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003DB6")]
		[SerializeField]
		[ItemID]
		private int characterID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003DB7")]
		[SerializeField]
		private Mdl.Environments.Environment environemnt;

		[Cpp2IlInjected.Token(Token = "0x6003328")]
		[Cpp2IlInjected.Address(RVA = "0x14BA450", Offset = "0x14B8E50", VA = "0x1814BA450")]
		private void Start()
		{
			//Discarded unreachable code: IL_002f
			//IL_0010: Expected O, but got I4
			Mdl.Environments.Environment environment = environemnt;
			int num = 0;
			if (environment != (UnityEngine.Object)num)
			{
				Mdl.Environments.Environment environment2 = environemnt;
				EventHandler value = Environemnt_EnvironmentEnteredEvent;
				environment2.EnvironmentEnteredEvent += value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003329")]
		[Cpp2IlInjected.Address(RVA = "0x14B9DF0", Offset = "0x14B87F0", VA = "0x1814B9DF0")]
		private void Environemnt_EnvironmentEnteredEvent(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0093
			//IL_001b: Expected O, but got I4
			//IL_0070: Expected O, but got I4
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			int num = characterID;
			int num2 = 0;
			Character character = default(Character);
			if (!(character != (UnityEngine.Object)num2))
			{
				CharacterManager system2 = SystemRoot.Instance.GetSystem<CharacterManager>();
				CharacterManager.CharacterLoaded value = PlayEventWithCharacter_OnCharacterLoaded;
				system2.OnCharacterLoaded += value;
			}
			AK.Wwise.Event @event = sfx_event;
			GameObject _003CgameObject_003Ek__BackingField = character.gameObject;
			uint num3 = @event.Post(_003CgameObject_003Ek__BackingField);
			Mdl.Environments.Environment environment = environemnt;
			int num4 = 0;
			if (environment != (UnityEngine.Object)num4)
			{
				Mdl.Environments.Environment environment2 = environemnt;
				EventHandler value2 = Environemnt_EnvironmentEnteredEvent;
				environment2.EnvironmentEnteredEvent -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600332A")]
		[Cpp2IlInjected.Address(RVA = "0x14BA2F0", Offset = "0x14B8CF0", VA = "0x1814BA2F0")]
		private void PlayEventWithCharacter_OnCharacterLoaded(Character character)
		{
			//Discarded unreachable code: IL_004a
			int num = characterID;
			if ((IntPtr)character.Item == (IntPtr)num)
			{
				AK.Wwise.Event @event = sfx_event;
				GameObject _003CgameObject_003Ek__BackingField = character.gameObject;
				uint num2 = @event.Post(_003CgameObject_003Ek__BackingField);
				CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
				CharacterManager.CharacterLoaded value = PlayEventWithCharacter_OnCharacterLoaded;
				system.OnCharacterLoaded -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600332B")]
		[Cpp2IlInjected.Address(RVA = "0x14BA0F0", Offset = "0x14B8AF0", VA = "0x1814BA0F0")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0064
			//IL_001c: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				CharacterManager system = _003CInstance_003Ek__BackingField.GetSystem<CharacterManager>();
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				CharacterManager.CharacterLoaded characterLoaded = PlayEventWithCharacter_OnCharacterLoaded;
			}
			Mdl.Environments.Environment environment = environemnt;
			int num3 = 0;
			if (environment != (UnityEngine.Object)num3)
			{
				Mdl.Environments.Environment environment2 = environemnt;
				EventHandler value = Environemnt_EnvironmentEnteredEvent;
				environment2.EnvironmentEnteredEvent -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600332C")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PlayEventWithCharacter()
		{
		}
	}
}
