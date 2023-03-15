using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200058F")]
	[ExecuteInEditMode]
	public class RadialToolButton : RadialMenuNavItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001E98")]
		public Toolbox.ToolType ToolType;

		[Cpp2IlInjected.Token(Token = "0x6002462")]
		[Cpp2IlInjected.Address(RVA = "0xF337E0", Offset = "0xF321E0", VA = "0x180F337E0", Slot = "12")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_0071
			int num = 0;
			if (Application.isPlaying)
			{
				UnityEvent onSelected = OnSelected;
				UnityAction call = SelectionHandler;
				onSelected.AddListener(call);
				UnityEvent onDeselected = OnDeselected;
				UnityAction call2 = SelectionHandler;
				onDeselected.AddListener(call2);
			}
			base.OnEnable();
			SpriteAtlasImage spriteAtlasImage = base.View.Background.SpriteAtlasImage;
			AssetAddress[] assetAddresses = AssetAddresses;
			bool flag = ((TemplateButton)this)._isSelected;
		}

		[Cpp2IlInjected.Token(Token = "0x6002463")]
		[Cpp2IlInjected.Address(RVA = "0xF33700", Offset = "0xF32100", VA = "0x180F33700", Slot = "13")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_0049
			int num = 0;
			if (Application.isPlaying)
			{
				UnityEvent onSelected = OnSelected;
				UnityAction call = SelectionHandler;
				onSelected.RemoveListener(call);
				UnityEvent onDeselected = OnDeselected;
				UnityAction call2 = SelectionHandler;
				onDeselected.RemoveListener(call2);
			}
			base.OnDisable();
		}

		[Cpp2IlInjected.Token(Token = "0x6002464")]
		[Cpp2IlInjected.Address(RVA = "0xF33940", Offset = "0xF32340", VA = "0x180F33940", Slot = "19")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_008d, IL_00c9
			//IL_0047: Expected I4, but got O
			int num = 0;
			if (Application.isPlaying)
			{
				PlayerAvatar avatar = SystemRoot.Instance._avatar;
				if (ToolType == Toolbox.ToolType.None)
				{
				}
				IEnumerable<Tool> allTools = (IEnumerable<Tool>)avatar.Toolbox.get_AllTools();
				Func<Tool, bool> func = (Func<Tool, bool>)(object)(Func<T, TResult>)((Tool x) => x.ToolType == ToolType);
				int num2 = MoreLinq.FindIndex<Tool>((IEnumerable<>)allTools, (Func<, >)(object)func);
				base._isAvailable = (byte)(int)allTools != 0;
			}
			base.RefreshDisplay();
			int num3 = 0;
			base.View.Background.SetColorRGBA(-1700281410);
			base.View.DynamicIcon.SetColorRGB(7042191);
			base.View.StaticIcon.SetColorRGBA(-66);
		}

		[Cpp2IlInjected.Token(Token = "0x6002465")]
		[Cpp2IlInjected.Address(RVA = "0xF33BD0", Offset = "0xF325D0", VA = "0x180F33BD0")]
		private void SelectionHandler()
		{
			//Discarded unreachable code: IL_0026
			SpriteAtlasImage spriteAtlasImage = base.View.Background.SpriteAtlasImage;
			AssetAddress[] assetAddresses = AssetAddresses;
			bool flag = ((TemplateButton)this)._isSelected;
		}

		[Cpp2IlInjected.Token(Token = "0x6002466")]
		[Cpp2IlInjected.Address(RVA = "0xF32FD0", Offset = "0xF319D0", VA = "0x180F32FD0")]
		public RadialToolButton()
		{
			//IL_0014: Expected I4, but got I8
			base._isAvailable = true;
			AngleRangeMax = 360;
			((CustomButton)this)._002Ector();
		}
	}
}
