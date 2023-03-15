using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Characters;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.Playables;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005EA")]
	[RequireComponent(typeof(PlayableDirector))]
	public class TimelineCharacters : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002405")]
		public bool HideCharactersNotInCutscene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002406")]
		private List<Character> hiddenCharacters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002407")]
		private bool hideAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002408")]
		private PlayableDirector playableDirector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002409")]
		private bool hideAvatarMarkerActive;

		[Cpp2IlInjected.Token(Token = "0x6001A45")]
		[Cpp2IlInjected.Address(RVA = "0x13CCCB0", Offset = "0x13CB6B0", VA = "0x1813CCCB0")]
		[AsyncStateMachine(typeof(_003CSetupCharacters_003Ed__5))]
		public void SetupCharacters()
		{
			int num = 0;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A46")]
		[Cpp2IlInjected.Address(RVA = "0x13CD1D0", Offset = "0x13CBBD0", VA = "0x1813CD1D0")]
		[AsyncStateMachine(typeof(_003CWaitForCharacterUpdate_003Ed__6))]
		private Task WaitForCharacterUpdate()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A47")]
		[Cpp2IlInjected.Address(RVA = "0x13CCFB0", Offset = "0x13CB9B0", VA = "0x1813CCFB0")]
		private void ShowCharacters(PlayableDirector obj)
		{
			//Discarded unreachable code: IL_002f, IL_0035, IL_003b
			int num = 0;
			if ((hideAvatar ? 1 : 0) != num)
			{
				SystemRoot.Instance._avatar.gameObject.SetActive(value: true);
			}
			List<Character> list = hiddenCharacters;
			bool flag = default(bool);
			if (flag)
			{
				int num2 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A48")]
		[Cpp2IlInjected.Address(RVA = "0x13CC460", Offset = "0x13CAE60", VA = "0x1813CC460")]
		private void HideCharacters(PlayableDirector obj)
		{
			//Discarded unreachable code: IL_013e, IL_0144, IL_014a, IL_0150, IL_015c, IL_0162, IL_0168
			//IL_0032: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			//IL_00ec: Expected O, but got I4
			uint num9 = default(uint);
			UnityEngine.Object @object = default(UnityEngine.Object);
			TimelineCharacterHolder timelineCharacterHolder = default(TimelineCharacterHolder);
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				hideAvatar = true;
				List<Character> list = (hiddenCharacters = (List<Character>)(object)new List<T>());
				PlayableDirector component = GetComponent<PlayableDirector>();
				int num5 = 0;
				if (component == (UnityEngine.Object)num5)
				{
					return;
				}
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					CharacterManager system = _003CInstance_003Ek__BackingField.GetSystem<CharacterManager>();
					if ((object)system != null)
					{
						int num6 = 0;
						List<Character> list2 = (List<Character>)(object)Enumerable.ToList<Character>(system.GetActiveCharacters((byte)num6 != 0));
					}
				}
				hiddenCharacters = (List<Character>)num4;
				PlayableAsset playableAsset = component.playableAsset;
				int num7 = 0;
				if ((object)playableAsset == null)
				{
					break;
				}
				int num8 = 0;
				if ((object)playableAsset == null)
				{
					break;
				}
				IEnumerable<PlayableBinding> outputs = (IEnumerable<PlayableBinding>)playableAsset.get_outputs();
				if (outputs != null)
				{
					if (num4 < (int)num9)
					{
						num4 += num4;
						if (num4 == (int)num9)
						{
							goto IL_00b3;
						}
						num4++;
					}
					while (outputs == null)
					{
					}
					goto IL_00b3;
				}
				goto IL_012a;
				IL_00b3:
				int num10 = 0;
				while (outputs == null)
				{
				}
				if ((object)@object == null)
				{
				}
				if (num4 != 0)
				{
					TimelineCharacterHolder characterHolder = timelineCharacterHolder;
					TimelineCharacterHolder timelineCharacterHolder2 = characterHolder;
					int num11 = 0;
					if (!(timelineCharacterHolder2 != (UnityEngine.Object)num11))
					{
						continue;
					}
					if (!characterHolder.usePlayerAvatar)
					{
						List<Character> list3 = hiddenCharacters;
						Predicate<Character> predicate = (Predicate<Character>)(object)(Predicate<T>)delegate(Character x)
						{
							//Discarded unreachable code: IL_001a
							TimelineCharacterHolder timelineCharacterHolder3 = characterHolder;
							Item _003CItem_003Ek__BackingField = x.Item;
							int num16 = timelineCharacterHolder3.CharacterID();
							return (IntPtr)_003CItem_003Ek__BackingField == (IntPtr)num16;
						};
						int num12 = ((List<T>)(object)list3).RemoveAll((Predicate<>)(object)predicate);
					}
					hideAvatar = false;
					goto IL_012a;
				}
				throw new InvalidCastException();
				IL_012a:
				if (outputs != null)
				{
				}
				if (flag)
				{
					int num13 = 0;
				}
				int num14 = 0;
				int num15 = 0;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A49")]
		[Cpp2IlInjected.Address(RVA = "0x13CCB80", Offset = "0x13CB580", VA = "0x1813CCB80")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_004e
			//IL_0010: Expected O, but got I4
			PlayableDirector playableDirector = this.playableDirector;
			int num = 0;
			if (!(playableDirector == (UnityEngine.Object)num))
			{
				PlayableDirector playableDirector2 = this.playableDirector;
				Action<PlayableDirector> action = (Action<PlayableDirector>)(object)new Action<T>(HideCharacters);
				playableDirector2.remove_played((Action<>)(object)action);
				PlayableDirector playableDirector3 = this.playableDirector;
				Action<PlayableDirector> action2 = (Action<PlayableDirector>)(object)new Action<T>(ShowCharacters);
				playableDirector3.remove_stopped((Action<>)(object)action2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A4A")]
		[Cpp2IlInjected.Address(RVA = "0x13CC240", Offset = "0x13CAC40", VA = "0x1813CC240")]
		public void HideAvatarReceiver()
		{
			//Discarded unreachable code: IL_0072
			//IL_0010: Expected O, but got I4
			PlayableDirector playableDirector = this.playableDirector;
			int num = 0;
			if (!(playableDirector == (UnityEngine.Object)num))
			{
				PlayableDirector playableDirector2 = this.playableDirector;
				Action<PlayableDirector> action = (Action<PlayableDirector>)(object)new Action<T>(ShowAvatar);
				playableDirector2.remove_stopped((Action<>)(object)action);
				PlayableDirector playableDirector3 = this.playableDirector;
				Action<PlayableDirector> action2 = (Action<PlayableDirector>)(object)new Action<T>(ShowAvatar);
				playableDirector3.add_stopped((Action<>)(object)action2);
				if (SystemRoot.Instance._avatar.gameObject.activeSelf)
				{
					int num2 = 0;
					int num3 = 0;
					hideAvatarMarkerActive = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A4B")]
		[Cpp2IlInjected.Address(RVA = "0x13CCE50", Offset = "0x13CB850", VA = "0x1813CCE50")]
		private void ShowAvatar(PlayableDirector obj)
		{
			//Discarded unreachable code: IL_0041
			PlayableDirector playableDirector = this.playableDirector;
			Action<PlayableDirector> action = (Action<PlayableDirector>)(object)new Action<T>(ShowAvatar);
			playableDirector.remove_stopped((Action<>)(object)action);
			if (hideAvatarMarkerActive)
			{
				hideAvatarMarkerActive = false;
				SystemRoot.Instance._avatar.gameObject.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A4C")]
		[Cpp2IlInjected.Address(RVA = "0x13CCD80", Offset = "0x13CB780", VA = "0x1813CCD80")]
		public void ShowAvatarReceiver()
		{
			//Discarded unreachable code: IL_001d
			hideAvatarMarkerActive = false;
			SystemRoot.Instance._avatar.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A4D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TimelineCharacters()
		{
		}
	}
}
