using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Navigation;
using Mdl.RewiredConsts;
using Mdl.Systems;
using Rewired;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000279")]
	public class RadialMenuNavigation : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000B34")]
		protected PlayerNavigation.TemporaryOverrideScope OverrideAllScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000B35")]
		private float _axisX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000B36")]
		private float _axisY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000B37")]
		private float _axisXAlt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000B38")]
		private float _axisYAlt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000B3A")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisX = 144;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000B3B")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisY = 145;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000B3C")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisXAlt = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000B3D")]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredAxisYAlt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000B3F")]
		public RectTransform Container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000B40")]
		public MenuNavigation MenuNavigation;

		[Cpp2IlInjected.Token(Token = "0x170002EB")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4000B39")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000FB6")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000FB7")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002EC")]
		public RadialMenuNavItem SelectedItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000FB8")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CSelectedItem_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000FB9")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			set
			{
				_003CSelectedItem_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBA")]
		[Cpp2IlInjected.Address(RVA = "0xF33060", Offset = "0xF31A60", VA = "0x180F33060", Slot = "4")]
		protected virtual void OnEnable()
		{
			//Discarded unreachable code: IL_001f
			StopAllCoroutines();
			int _003C_003E1__state = default(int);
			_003COnRefresh_003Ed__22 _003COnRefresh_003Ed__ = new _003COnRefresh_003Ed__22(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnRefresh_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003COnRefresh_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBB")]
		[Cpp2IlInjected.Address(RVA = "0x8B48F0", Offset = "0x8B32F0", VA = "0x1808B48F0", Slot = "5")]
		protected virtual void OnDisable()
		{
			StopAllCoroutines();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBC")]
		[Cpp2IlInjected.Address(RVA = "0xF33060", Offset = "0xF31A60", VA = "0x180F33060")]
		public void StartCoroutine()
		{
			//Discarded unreachable code: IL_001f
			StopAllCoroutines();
			int _003C_003E1__state = default(int);
			_003COnRefresh_003Ed__22 _003COnRefresh_003Ed__ = new _003COnRefresh_003Ed__22(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnRefresh_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003COnRefresh_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBD")]
		[Cpp2IlInjected.Address(RVA = "0xF330E0", Offset = "0xF31AE0", VA = "0x180F330E0")]
		[IteratorStateMachine(typeof(_003COnRefresh_003Ed__22))]
		public IEnumerator OnRefresh()
		{
			int _003C_003E1__state = default(int);
			_003COnRefresh_003Ed__22 _003COnRefresh_003Ed__ = new _003COnRefresh_003Ed__22(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnRefresh_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBE")]
		[Cpp2IlInjected.Address(RVA = "0xF33150", Offset = "0xF31B50", VA = "0x180F33150", Slot = "6")]
		public virtual void RefreshDisplay()
		{
			//Discarded unreachable code: IL_014c, IL_0152, IL_0164
			//IL_0012: Expected O, but got I4
			//IL_00e1: Invalid comparison between I4 and F4
			//IL_0129: Invalid comparison between I4 and F4
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected O, but got Unknown
			int num = 0;
			RectTransform container = Container;
			int num2 = 0;
			if (container == (UnityEngine.Object)num2)
			{
				return;
			}
			int num3 = 0;
			if (Application.isPlaying)
			{
				float num4 = (_axisX = Input.GetAxis(RewiredAxisX));
				float num5 = (_axisY = Input.GetAxis(RewiredAxisY));
				float num6 = (_axisXAlt = Input.GetAxis(RewiredAxisXAlt));
				float num7 = (_axisYAlt = Input.GetAxis(RewiredAxisYAlt));
			}
			float num8 = _axisX;
			float axisY = _axisY;
			float axisXAlt = _axisXAlt;
			axisY = axisXAlt;
			float axisYAlt = _axisYAlt;
			if (num != 0)
			{
				return;
			}
			if (num != 0 && num == 0)
			{
				num8 = axisXAlt;
				_axisX = axisXAlt;
				float num9 = (_axisY = _axisYAlt);
			}
			float axisY2 = _axisY;
			axisYAlt = num8;
			float num10 = axisYAlt * 57.29578f;
			int num11 = 0;
			if (!((float)num11 <= num10))
			{
			}
			IEnumerator enumerator = Container.GetEnumerator();
			if (enumerator != null)
			{
				uint num12 = default(uint);
				if (num < (int)num12)
				{
					num += num;
					num++;
				}
				int num13 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num14 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				RadialMenuNavItem radialMenuNavItem = default(RadialMenuNavItem);
				if (radialMenuNavItem._isAvailable)
				{
					int angleRangeMin = radialMenuNavItem.AngleRangeMin;
					if (!((float)num11 <= axisY2))
					{
						enumerator = (IEnumerator)(enumerator - angleRangeMin);
					}
				}
				int num15 = ((radialMenuNavItem.IsSelected = false) ? 1 : 0);
				SelectedItem = radialMenuNavItem;
			}
			if (enumerator == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBF")]
		[Cpp2IlInjected.Address(RVA = "0xF335C0", Offset = "0xF31FC0", VA = "0x180F335C0", Slot = "7")]
		public virtual void Show()
		{
			//Discarded unreachable code: IL_0030
			IsVisible = true;
			bool flag = default(bool);
			if (!flag)
			{
				PlayerNavigation.TemporaryOverrideScope temporaryOverrideScope = (OverrideAllScope = SystemRoot.Instance.GetSystem<PlayerNavigation>().OverrideAllScope());
			}
			base.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6000FC0")]
		[Cpp2IlInjected.Address(RVA = "0xF33010", Offset = "0xF31A10", VA = "0x180F33010", Slot = "8")]
		public virtual void Hide()
		{
			//Discarded unreachable code: IL_0021
			//IL_0020: Expected O, but got I4
			IsVisible = false;
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			int num = 0;
			OverrideAllScope = (PlayerNavigation.TemporaryOverrideScope)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FC1")]
		[Cpp2IlInjected.Address(RVA = "0xF336E0", Offset = "0xF320E0", VA = "0x180F336E0")]
		public RadialMenuNavigation()
		{
		}//IL_000d: Expected I4, but got I8
		//IL_001a: Expected I4, but got I8
		//IL_0023: Expected I4, but got I8

	}
}
