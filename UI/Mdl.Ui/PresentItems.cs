using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Rewards;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000500")]
	public class PresentItems : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001AF4")]
		public PresentItem PresentItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001AF5")]
		[Space]
		public float IntroParam1_Duration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4001AF6")]
		public float IntroParam1_Delay = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001AF7")]
		public float IntroParam1_ScaleX = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4001AF8")]
		public float IntroParam1_ScaleY = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001AF9")]
		public float IntroParam1_Y = 25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4001AFA")]
		public eEaseType IntroParam1_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001AFB")]
		[Space]
		public float ThrowItAwayParam1_Duration = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4001AFC")]
		public float ThrowItAwayParam1_ScaleX = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001AFD")]
		public float ThrowItAwayParam1_ScaleY = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4001AFE")]
		public float ThrowItAwayParam1_X_Range = 1000f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001AFF")]
		public float ThrowItAwayParam1_Y = 500f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4001B00")]
		public float ThrowItAwayParam1_RotationX_Range = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001B01")]
		public float ThrowItAwayParam1_RotationY_Range = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4001B02")]
		public float ThrowItAwayParam1_RotationZ_Range = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001B03")]
		public float ThrowItAwayParam1_Alpha = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4001B04")]
		public eEaseType ThrowItAwayParam1_Ease;

		[Cpp2IlInjected.Token(Token = "0x600208C")]
		[Cpp2IlInjected.Address(RVA = "0xE19D40", Offset = "0xE18740", VA = "0x180E19D40")]
		public void RefreshData(List<ItemReward> rewards)
		{
			//Discarded unreachable code: IL_0046, IL_004c, IL_0052, IL_0058
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				PresentItem presentItemPrefab = PresentItemPrefab;
				Transform parent = base.transform;
				PresentItem presentItem = UnityEngine.Object.Instantiate(presentItemPrefab, parent);
				presentItem.gameObject.transform.SetAsFirstSibling();
				if ((object)presentItem.transform != null)
				{
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600208D")]
		[Cpp2IlInjected.Address(RVA = "0xE199E0", Offset = "0xE183E0", VA = "0x180E199E0")]
		public void PlayIntro()
		{
			//Discarded unreachable code: IL_0055, IL_005b, IL_0067
			//IL_0049: Expected O, but got I4
			int num = 0;
			int childCount = base.transform.childCount;
			IEnumerator enumerator = base.transform.GetEnumerator();
			TweenMax tweenMax = default(TweenMax);
			if (enumerator != null)
			{
				if (enumerator == null)
				{
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				float introParam1_Duration = IntroParam1_Duration;
				eEaseType introParam1_Ease = IntroParam1_Ease;
				GameObject target = default(GameObject);
				_003C_003Ef__AnonymousType26<float, float, float, float, eEaseType> vars = default(_003C_003Ef__AnonymousType26<float, float, float, float, eEaseType>);
				tweenMax = TweenMax.To(target, introParam1_Duration, vars, int.MinValue, num);
				if (childCount >= 4)
				{
				}
			}
			if (tweenMax == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600208E")]
		[Cpp2IlInjected.Address(RVA = "0xE1A0B0", Offset = "0xE18AB0", VA = "0x180E1A0B0")]
		public void ThrowFirstItemAway()
		{
			//Discarded unreachable code: IL_00cb, IL_00d1, IL_00dd, IL_00e3
			GameObject target = default(GameObject);
			_003C_003Ef__AnonymousType26<float, float, float, float, eEaseType> CS_0024_003C_003E8__locals0 = default(_003C_003Ef__AnonymousType26<float, float, float, float, eEaseType>);
			uint tagNum = default(uint);
			GameObject target2 = default(GameObject);
			_003C_003Ef__AnonymousType27<float, float, float, float, float, float, float, float, eEaseType, TweenDelegate> vars = default(_003C_003Ef__AnonymousType27<float, float, float, float, float, float, float, float, eEaseType, TweenDelegate>);
			uint tagNum2 = default(uint);
			while (true)
			{
				int num = 0;
				if (base.transform.childCount <= 0)
				{
					return;
				}
				int childCount = base.transform.childCount;
				if (base.transform.GetEnumerator() == null)
				{
					continue;
				}
				_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
				if (_003C_003Ec__DisplayClass19_ == null)
				{
				}
				int num2 = 0;
				if (_003C_003Ec__DisplayClass19_ == null)
				{
					break;
				}
				_003C_003Ec__DisplayClass19_.child = (Transform)(object)_003C_003Ec__DisplayClass19_;
				if (_003C_003Ec__DisplayClass19_ != null)
				{
					float introParam1_Duration = IntroParam1_Duration;
					eEaseType introParam1_Ease = IntroParam1_Ease;
					TweenMax tweenMax = TweenMax.To(target, introParam1_Duration, CS_0024_003C_003E8__locals0, (int)tagNum, this);
					if (tweenMax != null)
					{
					}
					if (childCount < 4 && tweenMax == null)
					{
					}
				}
				float throwItAwayParam1_ScaleY = ThrowItAwayParam1_ScaleY;
				int num3 = 0;
				int num4 = 0;
				float throwItAwayParam1_RotationZ_Range = ThrowItAwayParam1_RotationZ_Range;
				int num5 = 0;
				float throwItAwayParam1_Alpha = ThrowItAwayParam1_Alpha;
				eEaseType throwItAwayParam1_Ease = ThrowItAwayParam1_Ease;
				TweenDelegate tweenDelegate = delegate
				{
					//Discarded unreachable code: IL_002a
					//IL_0015: Expected O, but got I4
					GameObject gameObject = ((_003C_003Ec__DisplayClass19_0)(object)CS_0024_003C_003E8__locals0).child.gameObject;
					int num6 = 0;
					if (gameObject != (UnityEngine.Object)num6)
					{
						UnityEngine.Object.Destroy(((_003C_003Ec__DisplayClass19_0)(object)CS_0024_003C_003E8__locals0).child.gameObject);
					}
				};
				if (TweenMax.To(target2, throwItAwayParam1_RotationZ_Range, vars, (int)tagNum2, this) != null)
				{
				}
				if (childCount == 0)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600208F")]
		[Cpp2IlInjected.Address(RVA = "0xE1A630", Offset = "0xE19030", VA = "0x180E1A630")]
		public PresentItems()
		{
		}
	}
}
