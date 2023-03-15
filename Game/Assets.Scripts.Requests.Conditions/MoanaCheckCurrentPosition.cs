using Cpp2IlInjected;
using Mdl.Environments;
using Mdl.Navigation;
using Mdl.Systems;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[Description("CheckCurrentPosition")]
	[Icon("Dialogue", false, "")]
	[Category("Mdl")]
	public class MoanaCheckCurrentPosition : MdlConditionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		[RequiredField]
		public int positionIndex;

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0xEFA470", Offset = "0xEF8E70", VA = "0x180EFA470", Slot = "9")]
			get
			{
				//IL_0012: Expected O, but got I4
				int num = positionIndex;
				return $"{num} is Current Position";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0xEFA2E0", Offset = "0xEF8CE0", VA = "0x180EFA2E0", Slot = "15")]
		protected override bool OnCheck()
		{
			//Discarded unreachable code: IL_0051
			//IL_0033: Expected O, but got I4
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			MoanaRealmController component = gameObject.GetComponent<MoanaRealmController>();
			int num = 0;
			bool flag = component != (Object)num;
			if (!flag)
			{
				return flag;
			}
			int num2 = positionIndex;
			return component.currentPosition == num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xA7FCE0", Offset = "0xA7E6E0", VA = "0x180A7FCE0")]
		public MoanaCheckCurrentPosition()
		{
		}
	}
}
