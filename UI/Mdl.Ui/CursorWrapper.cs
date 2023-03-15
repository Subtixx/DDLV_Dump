using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Platform;
using Mdl.Ui.Widgets;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000835")]
	public class CursorWrapper : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000836")]
		public delegate void CursorChanged(bool visible, CursorLockMode lockState);

		[Cpp2IlInjected.Token(Token = "0x1700074E")]
		public static bool Visible
		{
			[Cpp2IlInjected.Token(Token = "0x6003422")]
			[Cpp2IlInjected.Address(RVA = "0x111BF80", Offset = "0x111A980", VA = "0x18111BF80")]
			get
			{
				int num = 0;
				bool flag = PlatformUtils.HasMouse();
				if (!flag)
				{
					return flag;
				}
				int num2 = 0;
				return Cursor.visible;
			}
			[Cpp2IlInjected.Token(Token = "0x6003423")]
			[Cpp2IlInjected.Address(RVA = "0x111C0F0", Offset = "0x111AAF0", VA = "0x18111C0F0")]
			set
			{
				int num = 0;
				if (Cursor.visible != value)
				{
					Cursor.visible = value;
					int num2 = 0;
					CursorLockMode lockState = Cursor.lockState;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700074F")]
		public static bool Clickable
		{
			[Cpp2IlInjected.Token(Token = "0x6003424")]
			[Cpp2IlInjected.Address(RVA = "0x111BF60", Offset = "0x111A960", VA = "0x18111BF60")]
			get
			{
				int num = 0;
				return Cursor.visible;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000750")]
		public static CursorLockMode LockState
		{
			[Cpp2IlInjected.Token(Token = "0x6003425")]
			[Cpp2IlInjected.Address(RVA = "0x111BF70", Offset = "0x111A970", VA = "0x18111BF70")]
			get
			{
				int num = 0;
				return Cursor.lockState;
			}
			[Cpp2IlInjected.Token(Token = "0x6003426")]
			[Cpp2IlInjected.Address(RVA = "0x111C060", Offset = "0x111AA60", VA = "0x18111C060")]
			set
			{
				int num = 0;
				if (Cursor.lockState != value)
				{
					if (value == CursorLockMode.Locked)
					{
						int num2 = 0;
						ResetPointerHighlight();
					}
					int num3 = 0;
					bool visible = Cursor.visible;
					int num4 = 0;
					CursorLockMode lockState = Cursor.lockState;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000054")]
		public static event CursorChanged OnCursorChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6003420")]
			[Cpp2IlInjected.Address(RVA = "0x111BEA0", Offset = "0x111A8A0", VA = "0x18111BEA0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003421")]
			[Cpp2IlInjected.Address(RVA = "0x111BFA0", Offset = "0x111A9A0", VA = "0x18111BFA0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003427")]
		[Cpp2IlInjected.Address(RVA = "0x111B8E0", Offset = "0x111A2E0", VA = "0x18111B8E0")]
		private unsafe static void ResetPointerHighlight()
		{
			//Discarded unreachable code: IL_011b, IL_0121, IL_0127, IL_012d, IL_0133, IL_0139, IL_013f, IL_0145, IL_014b
			//IL_0024: Expected F4, but got I4
			//IL_001f: Expected native int or pointer, but got O
			//IL_0061: Expected O, but got I4
			//IL_0070: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			//IL_00a3: Expected O, but got I4
			//IL_00b2: Expected O, but got I4
			//IL_00c4: Expected O, but got I4
			//IL_00e5: Expected O, but got I4
			//IL_00f4: Expected O, but got I4
			//IL_0106: Expected O, but got I4
			PointerEventData pointerEventData;
			bool flag = default(bool);
			Transform transform = default(Transform);
			Transform transform2 = default(Transform);
			Transform transform3 = default(Transform);
			do
			{
				IL_0000:
				int num = 0;
				int num2 = 0;
				pointerEventData = new PointerEventData(EventSystem.current);
				int num3 = 0;
				pointerEventData.position = (Vector2)pointerEventData;
				((Vector2*)(IntPtr)pointerEventData.position)->y = 0f;
				List<RaycastResult> list = (List<RaycastResult>)(object)new List<T>();
				int num4 = 0;
				EventSystem.current.RaycastAll(pointerEventData, (List<>)(object)list);
				if (!flag)
				{
					continue;
				}
				BaseButton component = transform.GetComponent<BaseButton>();
				Transform parent = transform.parent;
				int num5 = 0;
				if (component == (UnityEngine.Object)num5)
				{
					int num6 = 0;
					if (parent != (UnityEngine.Object)num6)
					{
						goto IL_0000;
					}
				}
				int num7 = 0;
				if (component != (UnityEngine.Object)num7)
				{
					continue;
				}
				TemplateButton component2 = transform2.GetComponent<TemplateButton>();
				Transform parent2 = transform2.parent;
				int num8 = 0;
				if (component2 == (UnityEngine.Object)num8)
				{
					int num9 = 0;
					if (parent2 != (UnityEngine.Object)num9)
					{
						goto IL_0000;
					}
				}
				int num10 = 0;
				if (component2 != (UnityEngine.Object)num10)
				{
					continue;
				}
				FilterItem component3 = transform3.GetComponent<FilterItem>();
				Transform parent3 = transform3.parent;
				int num11 = 0;
				if (component3 == (UnityEngine.Object)num11)
				{
					int num12 = 0;
					if (parent3 != (UnityEngine.Object)num12)
					{
						goto IL_0000;
					}
				}
				int num13 = 0;
				if (!(component3 != (UnityEngine.Object)num13))
				{
					goto IL_0000;
				}
				component3.RemoveHighlight();
			}
			while (pointerEventData != null);
		}

		[Cpp2IlInjected.Token(Token = "0x6003428")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CursorWrapper()
		{
		}
	}
}
