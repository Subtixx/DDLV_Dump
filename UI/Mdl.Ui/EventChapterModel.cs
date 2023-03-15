using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000450")]
	public class EventChapterModel
	{
		[Cpp2IlInjected.Token(Token = "0x2000451")]
		public enum State
		{
			[Cpp2IlInjected.Token(Token = "0x40015D6")]
			Locked,
			[Cpp2IlInjected.Token(Token = "0x40015D7")]
			InProgress,
			[Cpp2IlInjected.Token(Token = "0x40015D8")]
			Completed
		}

		[Cpp2IlInjected.Token(Token = "0x17000491")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6001BF1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BF2")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000492")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40015CF")]
		public Item CharacterItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001BF3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001BF4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000493")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x40015D0")]
		public DateTime ChapterOpenTime
		{
			[Cpp2IlInjected.Token(Token = "0x6001BF5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001BF6")]
			[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000494")]
		public List<EventRequestModel> Requests
		{
			[Cpp2IlInjected.Token(Token = "0x6001BF7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CRequests_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BF8")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CRequests_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000495")]
		public Vector2 NodePosition
		{
			[Cpp2IlInjected.Token(Token = "0x6001BF9")]
			[Cpp2IlInjected.Address(RVA = "0xF266C0", Offset = "0xF250C0", VA = "0x180F266C0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6001BFA")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AD0", Offset = "0x6E44D0", VA = "0x1806E5AD0")]
			[CompilerGenerated]
			set
			{
				_003CNodePosition_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000496")]
		public EventChapterModel PrevChapter
		{
			[Cpp2IlInjected.Token(Token = "0x6001BFB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CPrevChapter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BFC")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CPrevChapter_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000497")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x40015D4")]
		public bool IsPremium
		{
			[Cpp2IlInjected.Token(Token = "0x6001BFD")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001BFE")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BFF")]
		[Cpp2IlInjected.Address(RVA = "0xF26440", Offset = "0xF24E40", VA = "0x180F26440")]
		public EventChapterModel(MegaEventChapterData chapterData, DateTime chapterOpenTime, ref int posX)
		{
			//Discarded unreachable code: IL_0093
			string text = (Name = chapterData.name_);
			Item item = (CharacterItem = chapterData.CharacterItem);
			ChapterOpenTime = chapterOpenTime;
			List<EventRequestModel> list = (Requests = (List<EventRequestModel>)(object)new List<T>());
			RepeatedField<MegaEventRequestData> requests_ = chapterData.requests_;
			if (requests_ != null)
			{
				int count = ((RepeatedField<T>)(object)requests_).Count;
				int num = 0;
				if (count > 0)
				{
					int num2 = EventMenu.MegaEventNodePosToY(((MegaEventRequestData)((RepeatedField<T>)(object)chapterData.requests_)[num]).nodePos_);
					if (num == 0)
					{
					}
					num++;
					int value = default(int);
					posX.m_value = value;
				}
			}
			int num3 = EventMenu.MegaEventNodePosToY(chapterData.nodePos_);
			int value2 = default(int);
			posX.m_value = value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C00")]
		[Cpp2IlInjected.Address(RVA = "0xF26230", Offset = "0xF24C30", VA = "0x180F26230")]
		public State GetState()
		{
			DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
			DateTime dateTime = ChapterOpenTime;
			if (!(serverTime < dateTime))
			{
				ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
				Item item = CharacterItem;
				Character character = world_.GetCharacter(item);
				if (character != null && character.IsUnlocked)
				{
					return State.Completed;
				}
				EventChapterModel eventChapterModel = PrevChapter;
				if (eventChapterModel == null || eventChapterModel.GetState() == State.Completed)
				{
					return State.InProgress;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}
	}
}
