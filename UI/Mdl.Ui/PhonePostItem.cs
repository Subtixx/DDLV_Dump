using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Meta.Social;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000654")]
	public class PhonePostItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400236A")]
		[SerializeField]
		private HttpImageLoader _mcImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400236D")]
		public Button ButtonAsset;

		[Cpp2IlInjected.Token(Token = "0x17000628")]
		public NewsFeedPost NewsFeedInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6002920")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CNewsFeedInfo_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002921")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CNewsFeedInfo_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000629")]
		public FollowData SuggestedPost
		{
			[Cpp2IlInjected.Token(Token = "0x6002922")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CSuggestedPost_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002923")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CSuggestedPost_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002924")]
		[Cpp2IlInjected.Address(RVA = "0x9BB120", Offset = "0x9B9B20", VA = "0x1809BB120")]
		public void RefreshDisplay(FollowData followData)
		{
			//Discarded unreachable code: IL_0020
			//IL_001f: Expected O, but got I4
			SuggestedPost = followData;
			HttpImageLoader mcImage = _mcImage;
			string url_ = followData.url_;
			int num = 0;
			mcImage.LoadImage(url_, (Action)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002925")]
		[Cpp2IlInjected.Address(RVA = "0x9BB170", Offset = "0x9B9B70", VA = "0x1809BB170")]
		internal void RefreshDisplay(NewsFeedPost post)
		{
			//Discarded unreachable code: IL_0020
			//IL_001f: Expected O, but got I4
			NewsFeedInfo = post;
			HttpImageLoader mcImage = _mcImage;
			string url_ = post.url_;
			int num = 0;
			mcImage.LoadImage(url_, (Action)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002926")]
		[Cpp2IlInjected.Address(RVA = "0x9BB0F0", Offset = "0x9B9AF0", VA = "0x1809BB0F0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0011
			ButtonAsset.m_OnClick.RemoveAllListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x6002927")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PhonePostItem()
		{
		}
	}
}
