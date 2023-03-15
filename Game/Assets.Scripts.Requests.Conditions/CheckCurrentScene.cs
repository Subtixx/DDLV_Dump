using System;
using Cpp2IlInjected;
using Mdl.Systems;
using NodeCanvas.DialogueTrees.Gameloft.Flux;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[Category("Mdl")]
	[Icon("Dialogue", false, "")]
	[Description("Check that the current active scene is the one specified.")]
	public class CheckCurrentScene : MdlConditionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		[RequiredField]
		public BBParameter<SceneItemFiltering> scene;

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0xA80050", Offset = "0xA7EA50", VA = "0x180A80050", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_0018
				SceneItemFiltering value = (SceneItemFiltering)((BBParameter<T>)(object)scene).value;
				return $"Is current active scene {value}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xA7FF00", Offset = "0xA7E900", VA = "0x180A7FF00", Slot = "15")]
		protected override bool OnCheck()
		{
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneItemFiltering value = (SceneItemFiltering)((BBParameter<T>)(object)scene).value;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xA7FCE0", Offset = "0xA7E6E0", VA = "0x180A7FCE0")]
		public CheckCurrentScene()
		{
		}
	}
}
