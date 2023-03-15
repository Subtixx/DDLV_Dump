using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Online;
using Meta.Social;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000652")]
	public class PhonePlayerItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000653")]
		public delegate void SearchPlayerActionDelegate(PhonePlayerItem item);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002366")]
		[SerializeField]
		private HttpImageLoader _mcAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002367")]
		[SerializeField]
		private TextBase _tfName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002368")]
		[SerializeField]
		private BaseButton _btnAddRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002369")]
		public FollowData PlayerData;

		[Cpp2IlInjected.Token(Token = "0x14000049")]
		public event SearchPlayerActionDelegate OnSearchPlayerActionClicked
		{
			[Cpp2IlInjected.Token(Token = "0x6002914")]
			[Cpp2IlInjected.Address(RVA = "0x9BAFB0", Offset = "0x9B99B0", VA = "0x1809BAFB0")]
			[CompilerGenerated]
			add
			{
				SearchPlayerActionDelegate onSearchPlayerActionClicked = this.OnSearchPlayerActionClicked;
				Delegate @delegate = Delegate.Combine(onSearchPlayerActionClicked, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSearchPlayerActionClicked)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002915")]
			[Cpp2IlInjected.Address(RVA = "0x9BB050", Offset = "0x9B9A50", VA = "0x1809BB050")]
			[CompilerGenerated]
			remove
			{
				SearchPlayerActionDelegate onSearchPlayerActionClicked = this.OnSearchPlayerActionClicked;
				Delegate @delegate = Delegate.Remove(onSearchPlayerActionClicked, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onSearchPlayerActionClicked)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002916")]
		[Cpp2IlInjected.Address(RVA = "0x9BAF00", Offset = "0x9B9900", VA = "0x1809BAF00")]
		private void Start()
		{
			//Discarded unreachable code: IL_0026
			Button.ButtonClickedEvent onClick = _btnAddRemove.ButtonComponent.m_OnClick;
			UnityAction call = OnActionClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6002917")]
		[Cpp2IlInjected.Address(RVA = "0x9BAC80", Offset = "0x9B9680", VA = "0x1809BAC80")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0026
			Button.ButtonClickedEvent onClick = _btnAddRemove.ButtonComponent.m_OnClick;
			UnityAction call = OnActionClickHandler;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6002918")]
		[Cpp2IlInjected.Address(RVA = "0x9BAC60", Offset = "0x9B9660", VA = "0x1809BAC60")]
		private void OnActionClickHandler()
		{
			this.OnSearchPlayerActionClicked?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002919")]
		[Cpp2IlInjected.Address(RVA = "0x9BADE0", Offset = "0x9B97E0", VA = "0x1809BADE0")]
		internal void RefreshDisplay(FollowData followData)
		{
			//Discarded unreachable code: IL_009a
			//IL_0028: Expected O, but got I4
			PlayerData = followData;
			HttpImageLoader mcAvatar = _mcAvatar;
			if ((object)mcAvatar != null)
			{
				string avatar_ = PlayerData.avatar_;
				int num = 0;
				mcAvatar.LoadImage(avatar_, (Action)num);
			}
			FollowData playerData = PlayerData;
			TextBase tfName = _tfName;
			string text = (tfName.Text = playerData.displayName_);
			int num2 = 0;
			FriendManager instance = FriendManager.Instance;
			string playfabId_ = PlayerData.playfabId_;
			bool flag = instance.IsFollowing(playfabId_);
			BaseButton btnAddRemove = _btnAddRemove;
			if (!flag)
			{
				SpriteAtlasImage backgroundSpriteAtlas = btnAddRemove.BackgroundSpriteAtlas;
				backgroundSpriteAtlas.ImageAddress = "icon_friend_add";
			}
			else
			{
				SpriteAtlasImage backgroundSpriteAtlas = default(SpriteAtlasImage);
				backgroundSpriteAtlas.ImageAddress = "icon_friend_added";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600291A")]
		[Cpp2IlInjected.Address(RVA = "0x9BAD30", Offset = "0x9B9730", VA = "0x1809BAD30")]
		public void RefreshButton()
		{
			//Discarded unreachable code: IL_004c
			int num = 0;
			FriendManager instance = FriendManager.Instance;
			string playfabId_ = PlayerData.playfabId_;
			bool flag = instance.IsFollowing(playfabId_);
			BaseButton btnAddRemove = _btnAddRemove;
			if (!flag)
			{
				btnAddRemove.BackgroundSpriteAtlas.ImageAddress = "icon_friend_add";
			}
			else
			{
				btnAddRemove.BackgroundSpriteAtlas.ImageAddress = "icon_friend_added";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600291B")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PhonePlayerItem()
		{
		}
	}
}
