using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000751")]
	public class GymAnimationLookAtTarget : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600208C")]
		[Cpp2IlInjected.Address(RVA = "0x154A710", Offset = "0x1549110", VA = "0x18154A710")]
		public void Start()
		{
			Setup();
		}

		[Cpp2IlInjected.Token(Token = "0x600208D")]
		[Cpp2IlInjected.Address(RVA = "0x154A710", Offset = "0x1549110", VA = "0x18154A710")]
		public void OnCharacterChanged()
		{
			Setup();
		}

		[Cpp2IlInjected.Token(Token = "0x600208E")]
		[Cpp2IlInjected.Address(RVA = "0x154A720", Offset = "0x1549120", VA = "0x18154A720")]
		private void Setup()
		{
			//Discarded unreachable code: IL_0078
			//IL_0059: Expected O, but got I4
			Scene scene = base.gameObject.scene;
			int num = 0;
			int num2 = 0;
			GameObject[] array = default(GameObject[]);
			int length = array.Length;
			if (num >= length)
			{
				return;
			}
			CharacterLookAtBehaviour[] componentsInChildren = array[num2].GetComponentsInChildren<CharacterLookAtBehaviour>();
			int num3 = 0;
			if (num3 < componentsInChildren.Length)
			{
				CharacterLookAtBehaviour characterLookAtBehaviour = componentsInChildren[num3];
				Transform target = ((LookAtBehaviour)characterLookAtBehaviour)._target;
				int num4 = 0;
				if (target == (Object)num4)
				{
					Transform transform2 = (characterLookAtBehaviour.Target = base.transform);
				}
				num3++;
			}
			num2++;
		}

		[Cpp2IlInjected.Token(Token = "0x600208F")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public GymAnimationLookAtTarget()
		{
		}
	}
}
