using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001F3")]
	public class StarComponent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000883")]
		[SerializeField]
		private int _starCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000884")]
		[SerializeField]
		private ListBase list_star;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000885")]
		[SerializeField]
		public bool ShowMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000886")]
		[SerializeField]
		private Vector2 _starSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000887")]
		public Color Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000888")]
		public Color ColorOff;

		[Cpp2IlInjected.Token(Token = "0x17000270")]
		public int Star
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return _starCount;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0x856530", Offset = "0x854F30", VA = "0x180856530")]
			set
			{
				//Discarded unreachable code: IL_0016
				ListBase listBase = list_star;
				_starCount = value;
				listBase.TotalCount = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0x8564C0", Offset = "0x854EC0", VA = "0x1808564C0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0018
			ListBase listBase = list_star;
			if (!ShowMax)
			{
			}
			listBase.TotalCount = 5;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x8564C0", Offset = "0x854EC0", VA = "0x1808564C0")]
		private void Refresh()
		{
			//Discarded unreachable code: IL_0018
			ListBase listBase = list_star;
			if (!ShowMax)
			{
			}
			listBase.TotalCount = 5;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x856230", Offset = "0x854C30", VA = "0x180856230")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0021
			ListBase.ListEvents onItemData = list_star.m_OnItemData;
			UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnStarHandler);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0x8562F0", Offset = "0x854CF0", VA = "0x1808562F0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0011
			list_star.m_OnItemData.RemoveAllListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C92")]
		[Cpp2IlInjected.Address(RVA = "0x856320", Offset = "0x854D20", VA = "0x180856320")]
		private void OnStarHandler(ListBase.ListEventData arg0)
		{
			//Discarded unreachable code: IL_0075
			//IL_0015: Expected O, but got I4
			SpriteAtlasImage component = arg0.DisplayObject.GetComponent<SpriteAtlasImage>();
			int num = 0;
			if (component == (Object)num)
			{
				return;
			}
			Transform transform = component.transform;
			Vector2 starSize = _starSize;
			float y = _starSize.y;
			int num2 = 0;
			if ((ShowMax ? 1 : 0) != num2)
			{
				Image image = component.Image;
				int starCount = _starCount;
				if (arg0.ItemIndex < starCount)
				{
				}
				Color color = (image.color = ColorOff);
			}
			else
			{
				Image image2 = component.Image;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C93")]
		[Cpp2IlInjected.Address(RVA = "0x8564F0", Offset = "0x854EF0", VA = "0x1808564F0")]
		public StarComponent()
		{
			Color white = Color.white;
			Color white2 = Color.white;
			base._002Ector();
		}
	}
}
