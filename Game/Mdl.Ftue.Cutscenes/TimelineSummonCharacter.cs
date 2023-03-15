using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Characters;
using Mdl.Ui;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005E0")]
	public class TimelineSummonCharacter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023D5")]
		[SerializeField]
		public TimelineCharacterHolder characterHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40023D6")]
		public GameObject summonEffect;

		[Cpp2IlInjected.Token(Token = "0x6001A18")]
		[Cpp2IlInjected.Address(RVA = "0x13D0C30", Offset = "0x13CF630", VA = "0x1813D0C30")]
		public void PlaySummonCharacter()
		{
			//Discarded unreachable code: IL_0030
			//IL_0015: Expected O, but got I4
			Character character = characterHolder.GetCharacter();
			int num = 0;
			if (character != (Object)num)
			{
				BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
				GameObject gameObject = summonEffect;
				Task task = _003CInstance_003Ek__BackingField.PlayCharacterSummon(character, gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A19")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TimelineSummonCharacter()
		{
		}
	}
}
