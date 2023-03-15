using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Meta.Social;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000642")]
	public class FeedItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000643")]
		public delegate void OnLikePost(FeedItem post);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002314")]
		public OnLikePost OnLike;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002315")]
		[SerializeField]
		private HttpImageLoader _mcImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002316")]
		[SerializeField]
		private TextBase _tfName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002317")]
		[SerializeField]
		private TextBase _tfLiked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002318")]
		[SerializeField]
		private TextBase _tfTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002319")]
		[SerializeField]
		private HttpImageLoader _mcAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400231A")]
		[SerializeField]
		private BaseButton _btnLike;

		[Cpp2IlInjected.Token(Token = "0x1700061E")]
		public NewsFeedPost NewsFeedInfo
		{
			[Cpp2IlInjected.Token(Token = "0x60028B5")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CNewsFeedInfo_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60028B6")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			private set
			{
				_003CNewsFeedInfo_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700061F")]
		public NewsFeedUserPost UserPost
		{
			[Cpp2IlInjected.Token(Token = "0x60028B7")]
			[Cpp2IlInjected.Address(RVA = "0x15300B0", Offset = "0x152EAB0", VA = "0x1815300B0")]
			get
			{
				NewsFeedPost newsFeedPost = NewsFeedInfo;
				if (newsFeedPost != null)
				{
					return newsFeedPost.UserPost;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000620")]
		public NewsFeedEventPost EventPost
		{
			[Cpp2IlInjected.Token(Token = "0x60028B8")]
			[Cpp2IlInjected.Address(RVA = "0x1530090", Offset = "0x152EA90", VA = "0x181530090")]
			get
			{
				NewsFeedPost newsFeedPost = NewsFeedInfo;
				if (newsFeedPost != null)
				{
					return newsFeedPost.EventPost;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028B9")]
		[Cpp2IlInjected.Address(RVA = "0x152FFE0", Offset = "0x152E9E0", VA = "0x18152FFE0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0026
			Button.ButtonClickedEvent onClick = _btnLike.ButtonComponent.m_OnClick;
			UnityAction call = OnLikeClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x60028BA")]
		[Cpp2IlInjected.Address(RVA = "0x152F7B0", Offset = "0x152E1B0", VA = "0x18152F7B0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0026
			Button.ButtonClickedEvent onClick = _btnLike.ButtonComponent.m_OnClick;
			UnityAction call = OnLikeClickHandler;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x60028BB")]
		[Cpp2IlInjected.Address(RVA = "0x152F860", Offset = "0x152E260", VA = "0x18152F860")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0037
			NewsFeedPost newsFeedPost = NewsFeedInfo;
			if (newsFeedPost != null && newsFeedPost.UserPost != null)
			{
				NewsFeedPost newsFeedPost2 = NewsFeedInfo;
				if (newsFeedPost2 != null)
				{
					NewsFeedUserPost userPost = newsFeedPost2.UserPost;
				}
				int num = 0;
				NewsFeedUserPost.NewFeedInfoEvent newFeedInfoEvent = OnLikesChanged;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028BC")]
		[Cpp2IlInjected.Address(RVA = "0x152FB50", Offset = "0x152E550", VA = "0x18152FB50")]
		internal void RefreshData(NewsFeedPost newsFeedInfo)
		{
			//Discarded unreachable code: IL_00c2, IL_00e6, IL_00f7, IL_00fb, IL_0100, IL_010a, IL_0155, IL_0156, IL_015b, IL_0176, IL_017f
			//IL_005b: Expected O, but got I4
			//IL_01b3: Expected O, but got I4
			NewsFeedPost newsFeedPost = NewsFeedInfo;
			int num = 0;
			if (newsFeedPost != null && newsFeedPost.UserPost != null)
			{
				NewsFeedPost newsFeedPost2 = NewsFeedInfo;
				if (newsFeedPost2 != null)
				{
					NewsFeedUserPost userPost = newsFeedPost2.UserPost;
				}
				NewsFeedUserPost.NewFeedInfoEvent newFeedInfoEvent = OnLikesChanged;
			}
			NewsFeedInfo = newsFeedInfo;
			HttpImageLoader mcImage = _mcImage;
			string url_ = newsFeedInfo.url_;
			int num2 = 0;
			mcImage.LoadImage(url_, (Action)num2);
			TextBase tfName = _tfName;
			string text = (tfName.Text = newsFeedInfo.displayName_);
			int num3 = 0;
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = newsFeedInfo.date_.ToDateTime();
			TimeSpan timeSpan = utcNow - dateTime;
			int val = 0;
			int num4 = Math.Max(1, val);
			TextBase tfTime = _tfTime;
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			double num5 = default(double);
			string text2 = TextUtilities.FormatAbbrTime((float)num5);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028BD")]
		[Cpp2IlInjected.Address(RVA = "0x152F920", Offset = "0x152E320", VA = "0x18152F920")]
		private void OnLikesChanged(NewsFeedUserPost newsFeedInfo)
		{
			//Discarded unreachable code: IL_0033, IL_0087, IL_0091, IL_00a4, IL_00b1
			TextBase tfLiked = _tfLiked;
			if (!newsFeedInfo.LikesReady)
			{
				tfLiked.Text = "";
				GameObject gameObject = _btnLike.gameObject;
			}
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60028BE")]
		[Cpp2IlInjected.Address(RVA = "0x152FF30", Offset = "0x152E930", VA = "0x18152FF30")]
		public void RefreshLikeButton()
		{
			//Discarded unreachable code: IL_0041
			BaseButton btnLike = _btnLike;
			NewsFeedPost newsFeedPost = NewsFeedInfo;
			SpriteAtlasImage backgroundSpriteAtlas = btnLike.BackgroundSpriteAtlas;
			if (newsFeedPost == null || newsFeedPost.UserPost == null || !NewsFeedInfo.UserPost.likedByMe_)
			{
			}
			backgroundSpriteAtlas.ImageAddress = "phone_icon_news_like";
		}

		[Cpp2IlInjected.Token(Token = "0x60028BF")]
		[Cpp2IlInjected.Address(RVA = "0x9BAC60", Offset = "0x9B9660", VA = "0x1809BAC60")]
		private void OnLikeClickHandler()
		{
			OnLike?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60028C0")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FeedItem()
		{
		}
	}
}
