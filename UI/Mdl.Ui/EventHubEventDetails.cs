using System;
using System.Threading;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000479")]
	public class EventHubEventDetails : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40016B7")]
		private MiniEventProgress _miniEventProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40016B8")]
		[SerializeField]
		private AsyncImage _banner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40016B9")]
		[SerializeField]
		private TextBase _title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40016BA")]
		[SerializeField]
		private UITimer _timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40016BB")]
		[SerializeField]
		private TextBase _description;

		[Cpp2IlInjected.Token(Token = "0x6001CF8")]
		[Cpp2IlInjected.Address(RVA = "0x13FA870", Offset = "0x13F9270", VA = "0x1813FA870")]
		public void Refresh(MiniEventProgress miniEvent)
		{
			_miniEventProgress = miniEvent;
			TextBase title = _title;
			string text = (title.StringID = miniEvent.Data.name_);
			TextBase description = _description;
			string text2 = (description.StringID = miniEvent.Data.description_);
			if (!string.IsNullOrEmpty(miniEvent.Data.bannerAddress_))
			{
				AsyncImage banner = _banner;
				string bannerAddress_ = miniEvent.Data.bannerAddress_;
				banner.SetSpriteKey(bannerAddress_);
			}
			UITimer timer = _timer;
			UITimer.TimerEventDelegate value = OnTimerCompletedHandler;
			timer.TimerComplete -= value;
			_timer.StopTimer();
			DateTime _003CEndDate_003Ek__BackingField = miniEvent.EndDate;
			DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
			TimeSpan timeSpan = _003CEndDate_003Ek__BackingField - serverTime;
			TimeSpan zero = TimeSpan.Zero;
			bool flag = timeSpan > zero;
			UITimer timer2 = _timer;
			if (!flag)
			{
				timer2._tfTimer.StringID = "menu.event_hub_event_ended";
				return;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CF9")]
		[Cpp2IlInjected.Address(RVA = "0x13FA7B0", Offset = "0x13F91B0", VA = "0x1813FA7B0")]
		private void OnTimerCompletedHandler(object sender, object param)
		{
			//Discarded unreachable code: IL_0031
			UITimer timer = _timer;
			UITimer.TimerEventDelegate value = OnTimerCompletedHandler;
			timer.TimerComplete -= value;
			_timer._tfTimer.StringID = "menu.event_hub_event_ended";
		}

		[Cpp2IlInjected.Token(Token = "0x6001CFA")]
		[Cpp2IlInjected.Address(RVA = "0x13FA5E0", Offset = "0x13F8FE0", VA = "0x1813FA5E0")]
		public void OnGoClicked()
		{
			//Discarded unreachable code: IL_005f
			//IL_0059: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			int num = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int num2 = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num3 = 0;
			IMenu top = menuStack.Top;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			MiniEventMenuParam menuParam = new MiniEventMenuParam(_miniEventProgress);
			CancellationToken ct = default(CancellationToken);
			redirection.RedirectTask(ct, RedirectionType.MenuMiniEvent, menuParam, (PlayerTaskCollider)num5, (ItemFilterData)num5, (string)num5, (Action)num5, (byte)num5 != 0, (byte)num5 != 0, (byte)num5 != 0).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CFB")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EventHubEventDetails()
		{
		}
	}
}
