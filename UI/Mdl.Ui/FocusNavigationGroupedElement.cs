using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000258")]
	public class FocusNavigationGroupedElement : FocusNavigationElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000A93")]
		public LayoutGroup[] GroupLinks = new LayoutGroup[4];

		[Cpp2IlInjected.Token(Token = "0x6000EFA")]
		[Cpp2IlInjected.Address(RVA = "0x1668B50", Offset = "0x1667550", VA = "0x181668B50", Slot = "16")]
		public override ISupportsFocusNavigation FindNext(FocusDirection direction, int input)
		{
			//Discarded unreachable code: IL_00b0, IL_00c2
			//IL_004c: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_00ab: Expected O, but got I4
			ISupportsFocusNavigation supportsFocusNavigation = default(ISupportsFocusNavigation);
			bool flag = default(bool);
			Transform transform = default(Transform);
			FocusNavigationElement focusNavigationElement = default(FocusNavigationElement);
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			Vector2 vector3 = default(Vector2);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if (supportsFocusNavigation == null && direction != FocusDirection.DefaultOrFirst && flag)
				{
					IEnumerator enumerator = transform.GetEnumerator();
					if (enumerator != null)
					{
						int num3 = 0;
						if (enumerator == null)
						{
							break;
						}
						int num4 = 0;
						if (enumerator == null)
						{
							throw new InvalidCastException();
						}
						int num5 = 0;
						if (!(focusNavigationElement != (UnityEngine.Object)num5) || !focusNavigationElement.gameObject.activeInHierarchy)
						{
							continue;
						}
						while (focusNavigationElement.IgnoreThis)
						{
						}
						float z = vector.z;
						int num6 = 0;
						Transform transform2 = focusNavigationElement.transform;
						float z2 = vector2.z;
						float num7 = Vector2.Distance((Vector2)0, vector3);
						while ((long)(IntPtr)vector3 >= 2147483647L)
						{
						}
					}
					if ((object)vector3 != null)
					{
					}
					int num8 = 0;
					if (!(focusNavigationElement != (UnityEngine.Object)num8))
					{
					}
				}
				return supportsFocusNavigation;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000EFB")]
		[Cpp2IlInjected.Address(RVA = "0x1668AC0", Offset = "0x16674C0", VA = "0x181668AC0")]
		public void AssignGroupLink(FocusDirection direction, LayoutGroup layoutGroup)
		{
			//Discarded unreachable code: IL_0010
			if (direction != FocusDirection.DefaultOrFirst)
			{
				LayoutGroup[] groupLinks = GroupLinks;
				if ((object)layoutGroup == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EFC")]
		[Cpp2IlInjected.Address(RVA = "0x1661340", Offset = "0x165FD40", VA = "0x181661340")]
		public FocusNavigationGroupedElement()
		{
		}
	}
}
