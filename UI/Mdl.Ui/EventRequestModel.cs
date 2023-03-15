using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000452")]
	public class EventRequestModel
	{
		[Cpp2IlInjected.Token(Token = "0x2000453")]
		public enum State
		{
			[Cpp2IlInjected.Token(Token = "0x40015DF")]
			Locked,
			[Cpp2IlInjected.Token(Token = "0x40015E0")]
			InProgress,
			[Cpp2IlInjected.Token(Token = "0x40015E1")]
			Completed
		}

		[Cpp2IlInjected.Token(Token = "0x17000498")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40015D9")]
		private int RequestIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6001C01")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001C02")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000499")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x40015DA")]
		public Item MissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001C03")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001C04")]
			[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700049A")]
		public Vector2 NodePosition
		{
			[Cpp2IlInjected.Token(Token = "0x6001C05")]
			[Cpp2IlInjected.Address(RVA = "0x1106770", Offset = "0x1105170", VA = "0x181106770")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6001C06")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
			[CompilerGenerated]
			set
			{
				_003CNodePosition_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049B")]
		public EventChapterModel ChapterModel
		{
			[Cpp2IlInjected.Token(Token = "0x6001C07")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CChapterModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C08")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CChapterModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049C")]
		public EventRequestModel PrevRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6001C09")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CPrevRequest_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C0A")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CPrevRequest_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C0B")]
		[Cpp2IlInjected.Address(RVA = "0x1404CD0", Offset = "0x14036D0", VA = "0x181404CD0")]
		public EventRequestModel(int requestIndex, MegaEventRequestData requestData, EventChapterModel chapterModel, int posX, int posY)
		{
			RequestIndex = requestIndex;
			Item item = (MissionItem = requestData.MissionItem);
			ChapterModel = chapterModel;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C0C")]
		[Cpp2IlInjected.Address(RVA = "0x1404BD0", Offset = "0x14035D0", VA = "0x181404BD0")]
		public State GetState()
		{
			EventChapterModel eventChapterModel = ChapterModel;
			int num = 0;
			EventChapterModel.State state = eventChapterModel.GetState();
			int num2 = (int)state;
			Client client = default(Client);
			if (state == EventChapterModel.State.Locked || (state != 0 && num2 != 1) || client.profile.player_.megaEventProgress_.requestIndex_ != RequestIndex)
			{
			}
			throw new NullReferenceException();
		}
	}
}
