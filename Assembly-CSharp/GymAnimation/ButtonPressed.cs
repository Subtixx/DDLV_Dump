using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GymAnimation
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ButtonPressed : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private string trigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float turnFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Animator[] allAnimators;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1E90310", Offset = "0x1E8ED10", VA = "0x181E90310")]
		private unsafe void Start()
		{
			//Discarded unreachable code: IL_0078
			//IL_0030: Expected O, but got I4
			//IL_0030: Expected O, but got I4
			Animator[] array = (allAnimators = UnityEngine.Object.FindObjectsOfType<Animator>());
			GameObject gameObject = GameObject.Find("SceneRoot");
			if ((object)gameObject != null)
			{
				GymCharacterSelect componentInChildren = gameObject.GetComponentInChildren<GymCharacterSelect>();
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				GymCharacterSelect.CharacterChanged characterChanged = default(GymCharacterSelect.CharacterChanged);
				((Delegate)characterChanged).method_ptr = (IntPtr)__ldftn(ButtonPressed.CharacterSelect_OnCharacterChanged);
				((Delegate)characterChanged).method = (IntPtr)__ldftn(ButtonPressed.CharacterSelect_OnCharacterChanged);
				((Delegate)characterChanged).m_target = this;
				GymCharacterSelect.CharacterChanged characterChanged2 = default(GymCharacterSelect.CharacterChanged);
				((Delegate)characterChanged2).method_ptr = (IntPtr)__ldftn(ButtonPressed.CharacterSelect_OnCharacterChanged);
				((Delegate)characterChanged2).method = (IntPtr)__ldftn(ButtonPressed.CharacterSelect_OnCharacterChanged);
				((Delegate)characterChanged2).m_target = this;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1E902A0", Offset = "0x1E8ECA0", VA = "0x181E902A0")]
		private void CharacterSelect_OnCharacterChanged()
		{
			Animator[] array = (allAnimators = UnityEngine.Object.FindObjectsOfType<Animator>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void Update()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1E904B0", Offset = "0x1E8EEB0", VA = "0x181E904B0")]
		public void fnTrigger(string trigger)
		{
			//Discarded unreachable code: IL_0026
			Animator[] array = allAnimators;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				array[num].SetTrigger(trigger);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1E90520", Offset = "0x1E8EF20", VA = "0x181E90520")]
		public void fnTurn(float turnFloat)
		{
			//Discarded unreachable code: IL_002b
			Animator[] array = allAnimators;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				array[num].SetFloat("TurnRatio", turnFloat);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ButtonPressed()
		{
		}
	}
}
