using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000455")]
	public class EventContentHome : EventContentBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40015E4")]
		private bool _isInit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40015E5")]
		private EventContentHomeModel _model;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40015E6")]
		[SerializeField]
		private EventProgressNodes _nodes;

		[Cpp2IlInjected.Token(Token = "0x6001C12")]
		[Cpp2IlInjected.Address(RVA = "0xF26750", Offset = "0xF25150", VA = "0x180F26750", Slot = "4")]
		public override void RefreshData(EventContentModelBase model)
		{
			//Discarded unreachable code: IL_0077, IL_007d, IL_0083, IL_0089, IL_008f, IL_0095, IL_009b, IL_00a1
			//IL_0048: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (model == null)
			{
			}
			int num4 = 0;
			_model = (EventContentHomeModel)model;
			if ((_isInit ? 1 : 0) != num3)
			{
				return;
			}
			List<EventChapterModel> _003CChapters_003Ek__BackingField = _model.Chapters;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				if (flag2)
				{
					EventProgressNodeRequest eventProgressNodeRequest = _nodes.AddRequestNode();
					eventProgressNodeRequest.Model = (EventRequestModel)num2;
					eventProgressNodeRequest.RefreshDisplay();
				}
				EventProgressNodeChapter eventProgressNodeChapter = default(EventProgressNodeChapter);
				eventProgressNodeChapter.RefreshDisplay();
				eventProgressNodeChapter.Pivot.RefreshDisplay();
			}
			int _003C_003E1__state = default(int);
			_003COnDelayedCall_003Ed__4 _003COnDelayedCall_003Ed__ = new _003COnDelayedCall_003Ed__4(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnDelayedCall_003Ed__._003C_003E4__this = (EventContentHome)0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C13")]
		[Cpp2IlInjected.Address(RVA = "0xF266E0", Offset = "0xF250E0", VA = "0x180F266E0")]
		[IteratorStateMachine(typeof(_003COnDelayedCall_003Ed__4))]
		private IEnumerator OnDelayedCall()
		{
			int _003C_003E1__state = default(int);
			_003COnDelayedCall_003Ed__4 _003COnDelayedCall_003Ed__ = new _003COnDelayedCall_003Ed__4(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnDelayedCall_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C14")]
		[Cpp2IlInjected.Address(RVA = "0xF26AE0", Offset = "0xF254E0", VA = "0x180F26AE0", Slot = "5")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0016
			if (_isInit)
			{
				_nodes.RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C15")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EventContentHome()
		{
		}
	}
}
