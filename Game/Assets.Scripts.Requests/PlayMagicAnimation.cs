using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Systems;
using Mdl.Utils;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[Description("Plays magic hands animation")]
	[Category("Mdl/Request")]
	[Icon("Dialogue", false, "")]
	public class PlayMagicAnimation : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		[RequiredField]
		public BBParameter<GameObject> handVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		[RequiredField]
		public BBParameter<GameObject> rootVFXPrefab;

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x14BA520", Offset = "0x14B8F20", VA = "0x1814BA520", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_001a
			PlayerAvatar avatar = SystemRoot.Instance._avatar;
			PlayAnimation(avatar);
			EndAction(success: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x14BA5F0", Offset = "0x14B8FF0", VA = "0x1814BA5F0")]
		public void PlayAnimation(PlayerAvatar avatar)
		{
			//Discarded unreachable code: IL_00a3
			BBParameter<GameObject> bBParameter = handVFXPrefab;
			if (bBParameter != null)
			{
				GameObject value = (GameObject)((BBParameter<T>)(object)bBParameter).value;
				Transform transform = avatar.CharacterVisualNodes.LeftHand.transform;
				DestroyOnEnable destroyOnEnable = Object.Instantiate(value, transform).AddComponent<DestroyOnEnable>();
				GameObject value2 = (GameObject)((BBParameter<T>)(object)handVFXPrefab).value;
				Transform transform2 = avatar.CharacterVisualNodes.RightHand.transform;
				DestroyOnEnable destroyOnEnable2 = Object.Instantiate(value2, transform2).AddComponent<DestroyOnEnable>();
			}
			BBParameter<GameObject> bBParameter2 = rootVFXPrefab;
			if (bBParameter2 != null)
			{
				GameObject value3 = (GameObject)((BBParameter<T>)(object)bBParameter2).value;
				Transform _003Ctransform_003Ek__BackingField = avatar.transform;
				DestroyOnEnable destroyOnEnable3 = Object.Instantiate(value3, _003Ctransform_003Ek__BackingField).AddComponent<DestroyOnEnable>();
			}
			avatar.appearance.Animator.SetTrigger("Removal");
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public PlayMagicAnimation()
		{
		}
	}
}
