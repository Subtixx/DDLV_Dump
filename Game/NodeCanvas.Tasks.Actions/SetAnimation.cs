using System;
using Cpp2IlInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[Name("Set Animation", 0)]
	[Description("Set Animation.")]
	[Category("Animator")]
	public class SetAnimation : ActionTask<Animator>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		[SerializeField]
		private int selectedAnimationIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		[SerializeField]
		private string animation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		[SerializeField]
		private object value;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		[SerializeField]
		private AnimatorControllerParameterType type;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0xF49D00", Offset = "0xF48700", VA = "0x180F49D00", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_0052
				if (type == AnimatorControllerParameterType.Bool)
				{
					object obj = value;
				}
				AnimatorControllerParameterType animatorControllerParameterType = type;
				string text = animation;
				if (animatorControllerParameterType == AnimatorControllerParameterType.Float)
				{
					object obj2 = value;
				}
				string text2 = default(string);
				if ((long)text2 == 3)
				{
					object obj3 = value;
				}
				string text3 = "Set" + " Animation " + text + "";
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xF49A60", Offset = "0xF48460", VA = "0x180F49A60", Slot = "13")]
		protected override void OnExecute()
		{
			//IL_0020: Expected O, but got I4
			if (!string.IsNullOrEmpty(animation))
			{
				Animator animator = (Animator)(object)((ActionTask<T>)(object)this).agent;
				int num = 0;
				int num2 = 0;
				bool flag = animator != (UnityEngine.Object)num2;
				if (flag)
				{
					AnimatorControllerParameterType animatorControllerParameterType = type;
					if (flag)
					{
						if (flag)
						{
							if (flag)
							{
								if (animatorControllerParameterType == AnimatorControllerParameterType.Float)
								{
									Animator animator2 = (Animator)(object)((ActionTask<T>)(object)this).agent;
									object obj = value;
									goto IL_004e;
								}
							}
							else
							{
								Animator animator3 = (Animator)(object)((ActionTask<T>)(object)this).agent;
								object obj2 = value;
							}
						}
						Animator animator4 = (Animator)(object)((ActionTask<T>)(object)this).agent;
						string trigger = animation;
						int num3 = 0;
						animator4.SetTrigger(trigger);
					}
					Animator animator5 = (Animator)(object)((ActionTask<T>)(object)this).agent;
					object obj3 = value;
					throw new NullReferenceException();
				}
			}
			goto IL_004e;
			IL_004e:
			EndAction();
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xF49CC0", Offset = "0xF486C0", VA = "0x180F49CC0")]
		public SetAnimation()
		{
			((ActionTask<T>)(object)this)._002Ector();
		}
	}
}
