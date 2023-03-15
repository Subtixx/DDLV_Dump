using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GymAnimation
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class GymCharacterSelect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate void CharacterChanged();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private List<CharacterItemData> charactersData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private GameObject spawnPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private GameObject characterSpawned;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private GameObject audioSetup;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event CharacterChanged OnCharacterChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1E93CC0", Offset = "0x1E926C0", VA = "0x181E93CC0")]
			[CompilerGenerated]
			add
			{
				CharacterChanged onCharacterChanged = this.OnCharacterChanged;
				Delegate @delegate = Delegate.Combine(onCharacterChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onCharacterChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1E93D60", Offset = "0x1E92760", VA = "0x181E93D60")]
			[CompilerGenerated]
			remove
			{
				CharacterChanged onCharacterChanged = this.OnCharacterChanged;
				Delegate @delegate = Delegate.Remove(onCharacterChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onCharacterChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1E93700", Offset = "0x1E92100", VA = "0x181E93700")]
		private unsafe void Start()
		{
			//Discarded unreachable code: IL_0134, IL_0140, IL_0146
			//IL_00a5: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			int num = 0;
			_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = default(_003C_003Ec__DisplayClass8_0);
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			GymAnimationLookAtTarget component = GameObject.Find("LookAtTarget").GetComponent<GymAnimationLookAtTarget>();
			CharacterChanged characterChanged = default(CharacterChanged);
			if ((object)component != null || characterChanged != null)
			{
				((Delegate)characterChanged).method_ptr = (IntPtr)__ldftn(GymAnimationLookAtTarget.OnCharacterChanged);
				((Delegate)characterChanged).method = (IntPtr)__ldftn(GymAnimationLookAtTarget.OnCharacterChanged);
				((Delegate)characterChanged).m_target = component;
				OnCharacterChanged += characterChanged;
				GameObject gameObject = (spawnPoint = GameObject.Find("CharacterSpawnPosition"));
				List<CharacterItemData> list = (charactersData = (List<CharacterItemData>)(object)new List<T>());
				GameObject gameObject2 = (audioSetup = GameObject.Find("AudioSetup"));
				Dropdown dropdown = (CS_0024_003C_003E8__locals0.drop = GetComponent<Dropdown>());
				Dropdown drop = CS_0024_003C_003E8__locals0.drop;
				int num2 = 0;
				if (!(drop != (UnityEngine.Object)num2))
				{
					return;
				}
				Dropdown.DropdownEvent onValueChanged = CS_0024_003C_003E8__locals0.drop.m_OnValueChanged;
				UnityAction<int> unityAction = (UnityAction<int>)(object)(UnityAction<T0>)delegate
				{
				}//Discarded unreachable code: IL_0001
				;
				((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
				CS_0024_003C_003E8__locals0.drop.ClearOptions();
				List<Dropdown.OptionData> list2 = (List<Dropdown.OptionData>)(object)new List<T>();
				int num3 = 0;
				((List<T>)(object)list2).Add((T)num3);
				List<CharacterItemData> list3 = (List<CharacterItemData>)(object)Enumerable.ToList<CharacterItemData>(ItemDatabase.Instance.GetAllByType<CharacterItemData>(ItemType.Character));
				bool flag = default(bool);
				if (flag)
				{
					Dropdown.OptionData optionData = new Dropdown.OptionData();
					if (optionData == null)
					{
					}
					optionData.m_Text = "None";
					((List<T>)(object)list2).Add((T)optionData);
				}
				CS_0024_003C_003E8__locals0.drop.AddOptions((List<>)(object)list2);
				return;
			}
			throw new ArgumentException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void DropdownValueChanged(Dropdown change)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public GymCharacterSelect()
		{
		}
	}
}
