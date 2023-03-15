using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000733")]
	public class CharacterVisualNodes : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000734")]
		[AttributeUsage(AttributeTargets.Property)]
		public class VisualNodeAttribute : Attribute
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40029EC")]
			public readonly bool Mandatory;

			[Cpp2IlInjected.Token(Token = "0x6001FF6")]
			[Cpp2IlInjected.Address(RVA = "0x17960B0", Offset = "0x1794AB0", VA = "0x1817960B0")]
			public VisualNodeAttribute(bool mandatory = true)
			{
				Mandatory = mandatory;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40029E2")]
		private GameObject _headIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40029E3")]
		private GameObject _head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40029E4")]
		private GameObject _chest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40029E5")]
		private GameObject _leftHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40029E6")]
		private GameObject _rightHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40029E7")]
		private GameObject _leftHandItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40029E8")]
		private GameObject _rightHandItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40029E9")]
		private GameObject _leftFoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40029EA")]
		private GameObject _rightFoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40029EB")]
		private GameObject _item_f;

		[Cpp2IlInjected.Token(Token = "0x17000482")]
		[VisualNode(true)]
		public GameObject HeadIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6001FE9")]
			[Cpp2IlInjected.Address(RVA = "0xA7B0E0", Offset = "0xA79AE0", VA = "0x180A7B0E0")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject headIcon = _headIcon;
				int num = 0;
				if (headIcon == (UnityEngine.Object)num)
				{
					Transform transform = base.transform;
					GameObject gameObject = (_headIcon = GetChildGameObject("_anchor_vfx_head_icon", transform));
				}
				return _headIcon;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000483")]
		[VisualNode(true)]
		public GameObject Head
		{
			[Cpp2IlInjected.Token(Token = "0x6001FEA")]
			[Cpp2IlInjected.Address(RVA = "0xA7B190", Offset = "0xA79B90", VA = "0x180A7B190")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject head = _head;
				int num = 0;
				if (head == (UnityEngine.Object)num)
				{
					Transform transform = base.transform;
					GameObject gameObject = (_head = GetChildGameObject("_anchor_vfx_head", transform));
				}
				return _head;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000484")]
		[VisualNode(true)]
		public GameObject Chest
		{
			[Cpp2IlInjected.Token(Token = "0x6001FEB")]
			[Cpp2IlInjected.Address(RVA = "0xA7AE60", Offset = "0xA79860", VA = "0x180A7AE60")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject chest = _chest;
				int num = 0;
				if (chest == (UnityEngine.Object)num)
				{
					Transform transform = base.transform;
					GameObject gameObject = (_chest = GetChildGameObject("_anchor_vfx_chest", transform));
				}
				return _chest;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000485")]
		[VisualNode(true)]
		public GameObject LeftHand
		{
			[Cpp2IlInjected.Token(Token = "0x6001FEC")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA79DA0", VA = "0x180A7B3A0")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject leftHand = _leftHand;
				int num = 0;
				if (leftHand == (UnityEngine.Object)num)
				{
					Transform transform = base.transform;
					GameObject gameObject = (_leftHand = GetChildGameObject("_anchor_vfx_hand_left", transform));
				}
				return _leftHand;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000486")]
		[VisualNode(true)]
		public GameObject RightHand
		{
			[Cpp2IlInjected.Token(Token = "0x6001FED")]
			[Cpp2IlInjected.Address(RVA = "0xA7B5B0", Offset = "0xA79FB0", VA = "0x180A7B5B0")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject rightHand = _rightHand;
				int num = 0;
				if (rightHand == (UnityEngine.Object)num)
				{
					Transform transform = base.transform;
					GameObject gameObject = (_rightHand = GetChildGameObject("_anchor_vfx_hand_right", transform));
				}
				return _rightHand;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000487")]
		[VisualNode(false)]
		public GameObject LeftHandItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001FEE")]
			[Cpp2IlInjected.Address(RVA = "0xA7B2F0", Offset = "0xA79CF0", VA = "0x180A7B2F0")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject leftHandItem = _leftHandItem;
				int num = 0;
				if (leftHandItem == (UnityEngine.Object)num)
				{
					Transform transform = base.transform;
					GameObject gameObject = (_leftHandItem = GetChildGameObject("item_anc_L_01", transform));
				}
				return _leftHandItem;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000488")]
		[VisualNode(false)]
		public GameObject RightHandItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001FEF")]
			[Cpp2IlInjected.Address(RVA = "0xA7B500", Offset = "0xA79F00", VA = "0x180A7B500")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject rightHandItem = _rightHandItem;
				int num = 0;
				if (rightHandItem == (UnityEngine.Object)num)
				{
					Transform transform = base.transform;
					GameObject gameObject = (_rightHandItem = GetChildGameObject("item_anc_R_01", transform));
				}
				return _rightHandItem;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000489")]
		[VisualNode(true)]
		public GameObject LeftFoot
		{
			[Cpp2IlInjected.Token(Token = "0x6001FF0")]
			[Cpp2IlInjected.Address(RVA = "0xA7B240", Offset = "0xA79C40", VA = "0x180A7B240")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject leftFoot = _leftFoot;
				int num = 0;
				if (leftFoot == (UnityEngine.Object)num)
				{
					Transform transform = base.transform;
					GameObject gameObject = (_leftFoot = GetChildGameObject("_anchor_vfx_foot_left", transform));
				}
				return _leftFoot;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048A")]
		[VisualNode(true)]
		public GameObject RightFoot
		{
			[Cpp2IlInjected.Token(Token = "0x6001FF1")]
			[Cpp2IlInjected.Address(RVA = "0xA7B450", Offset = "0xA79E50", VA = "0x180A7B450")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject rightFoot = _rightFoot;
				int num = 0;
				if (rightFoot == (UnityEngine.Object)num)
				{
					Transform transform = base.transform;
					GameObject gameObject = (_rightFoot = GetChildGameObject("_anchor_vfx_foot_right", transform));
				}
				return _rightFoot;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048B")]
		[VisualNode(true)]
		public GameObject GiveItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001FF2")]
			[Cpp2IlInjected.Address(RVA = "0xA7AF10", Offset = "0xA79910", VA = "0x180A7AF10")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject item_f = _item_f;
				int num = 0;
				if (item_f == (UnityEngine.Object)num)
				{
					Transform transform = base.transform;
					GameObject gameObject = (_item_f = GetChildGameObject("_anchor_item_f", transform));
				}
				return _item_f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048C")]
		public GameObject GivePosition
		{
			[Cpp2IlInjected.Token(Token = "0x6001FF3")]
			[Cpp2IlInjected.Address(RVA = "0xA7AFC0", Offset = "0xA799C0", VA = "0x180A7AFC0")]
			get
			{
				//IL_0010: Expected O, but got I4
				//IL_002a: Expected O, but got I4
				GameObject rightHand = RightHand;
				int num = 0;
				if (rightHand != (UnityEngine.Object)num)
				{
					return RightHand;
				}
				GameObject item_f = _item_f;
				int num2 = 0;
				if (item_f == (UnityEngine.Object)num2)
				{
					Transform transform = base.transform;
					GameObject gameObject = (_item_f = GetChildGameObject("_anchor_item_f", transform));
				}
				return _item_f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FF4")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD40", Offset = "0xA79740", VA = "0x180A7AD40")]
		private static GameObject GetChildGameObject(string name, Transform transform)
		{
			//Discarded unreachable code: IL_004d
			//IL_003c: Expected O, but got I4
			if (!string.Equals(transform.gameObject.name, name))
			{
				int childCount = transform.childCount;
				int num = 0;
				if (childCount > 0)
				{
					Transform child = transform.GetChild(num);
					GameObject childGameObject = GetChildGameObject(name, child);
					int num2 = 0;
					if (childGameObject != (UnityEngine.Object)num2)
					{
						goto IL_0046;
					}
					num++;
				}
				int num3 = 0;
			}
			goto IL_0046;
			IL_0046:
			return transform.gameObject;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FF5")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CharacterVisualNodes()
		{
		}
	}
}
