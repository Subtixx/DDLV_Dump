using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class FOVKick
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public Camera Camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[HideInInspector]
		public float originalFov;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public float FOVIncrease = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float TimeToIncrease = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public float TimeToDecrease = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public AnimationCurve IncreaseCurve;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2F10CE0", Offset = "0x2F0F6E0", VA = "0x182F10CE0")]
		public void Setup(Camera camera)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(camera == (UnityEngine.Object)num))
			{
				if ((long)IncreaseCurve != 0)
				{
					Camera = camera;
					float num2 = (originalFov = camera.fieldOfView);
					return;
				}
			}
			else
			{
				Exception ex = new Exception("FOVKick camera is null, please supply the camera to the constructor");
			}
			Exception ex2 = new Exception("FOVKick Increase curve is null, please define the curve for the field of view kicks");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2F10B00", Offset = "0x2F0F500", VA = "0x182F10B00")]
		private void CheckStatus(Camera camera)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(camera == (UnityEngine.Object)num))
			{
				if ((long)IncreaseCurve != 0)
				{
					return;
				}
				Exception ex = new Exception("FOVKick Increase curve is null, please define the curve for the field of view kicks");
			}
			Exception ex2 = new Exception("FOVKick camera is null, please supply the camera to the constructor");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
		public void ChangeCamera(Camera camera)
		{
			Camera = camera;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2F10C70", Offset = "0x2F0F670", VA = "0x182F10C70")]
		[IteratorStateMachine(typeof(_003CFOVKickUp_003Ed__9))]
		public IEnumerator FOVKickUp()
		{
			int _003C_003E1__state = default(int);
			_003CFOVKickUp_003Ed__9 _003CFOVKickUp_003Ed__ = new _003CFOVKickUp_003Ed__9(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CFOVKickUp_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2F10C00", Offset = "0x2F0F600", VA = "0x182F10C00")]
		[IteratorStateMachine(typeof(_003CFOVKickDown_003Ed__10))]
		public IEnumerator FOVKickDown()
		{
			int _003C_003E1__state = default(int);
			_003CFOVKickDown_003Ed__10 _003CFOVKickDown_003Ed__ = new _003CFOVKickDown_003Ed__10(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CFOVKickDown_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2F10E10", Offset = "0x2F0F810", VA = "0x182F10E10")]
		public FOVKick()
		{
		}
	}
}
