using System;
using Cpp2IlInjected;
using Gameloft.Localization.Formatter;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000471")]
	[ExecuteInEditMode]
	public class EventProgressPivot : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001687")]
		public EventProgressNodeBase Node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001688")]
		[Space]
		public GameObject _mcTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001689")]
		public TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400168A")]
		public GameObject _mcLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400168B")]
		public UITimer _mcTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400168C")]
		public Image _mcPivot;

		[Cpp2IlInjected.Token(Token = "0x170004B0")]
		private RectTransform _rt
		{
			[Cpp2IlInjected.Token(Token = "0x6001CA1")]
			[Cpp2IlInjected.Address(RVA = "0x1404B70", Offset = "0x1403570", VA = "0x181404B70")]
			get
			{
				while (true)
				{
					if ((object)base.transform == null)
					{
						/*Error: Could not find block for branch target IL_0009*/;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x400168D")]
		public bool IsUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6001CA2")]
			[Cpp2IlInjected.Address(RVA = "0x951C70", Offset = "0x950670", VA = "0x180951C70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001CA3")]
			[Cpp2IlInjected.Address(RVA = "0x951E90", Offset = "0x950890", VA = "0x180951E90")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CA4")]
		[Cpp2IlInjected.Address(RVA = "0x1404B60", Offset = "0x1403560", VA = "0x181404B60")]
		private void Start()
		{
			RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CA5")]
		[Cpp2IlInjected.Address(RVA = "0x14042E0", Offset = "0x1402CE0", VA = "0x1814042E0")]
		internal void RefreshDisplay()
		{
			//IL_0010: Expected O, but got I4
			//IL_011c: Expected O, but got I4
			//IL_0153: Expected F4, but got I4
			//IL_01fb: Expected O, but got I4
			EventProgressNodeBase node = Node;
			int num = 0;
			if (!(node != (UnityEngine.Object)num))
			{
				return;
			}
			Transform transform = Node.transform;
			if ((object)base.transform.parent != null)
			{
			}
			if ((object)transform != null)
			{
			}
			if ((object)base.transform != null)
			{
			}
			Transform transform2 = base.transform;
			int num2 = 0;
			if (!Application.isPlaying)
			{
				return;
			}
			bool flag = (IsUnlocked = Node.GetStateValue() > 0);
			Client client = default(Client);
			DateTime serverTime = client.ServerTime;
			GameObject gameObject = _mcTimer.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject mcTitle = _mcTitle;
			int num3 = 0;
			int active2 = 0;
			mcTitle.SetActive((byte)active2 != 0);
			EventProgressNodeBase node2 = Node;
			if ((object)node2 == null)
			{
				return;
			}
			int num4 = 0;
			if ((object)node2 != null)
			{
				if (false)
				{
					_mcTitle.SetActive(value: true);
					string stringID = _tfTitle._stringID;
					EventChapterModel.State state;
					if (state != 0)
					{
						GameObject mcLocked = _mcLocked;
					}
					bool flag2;
					if (flag2)
					{
						_mcTimer.gameObject.SetActive(value: true);
						UITimer mcTimer = _mcTimer;
						int num5 = 0;
						string text = (mcTimer.Prefix = LocalizationManager.FromStringID("event.time_start_in", (IResolver)num5) + " ");
						UITimer mcTimer2 = _mcTimer;
						bool callsDirty = ((UnityEventBase)mcTimer.OnTimerCompleted).m_CallsDirty;
						int num6 = 0;
						mcTimer2.StartTimer(num6);
						UITimer mcTimer3 = _mcTimer;
						UITimer.TimerEventDelegate value = OnTimerCompleted;
						mcTimer3.TimerComplete -= value;
						UITimer mcTimer4 = _mcTimer;
						UITimer.TimerEventDelegate value2 = OnTimerCompleted;
						mcTimer4.TimerComplete += value2;
						if ((object)_mcTimer._tfTimer.transform != null)
						{
						}
						if ((object)_mcTimer.transform == null)
						{
						}
					}
					GameObject mcLocked2 = _mcLocked;
					int num7 = 0;
					mcLocked2.SetActive(value: true);
				}
				Image mcPivot = _mcPivot;
				if (IsUnlocked)
				{
					goto IL_01fc;
				}
				int num8 = 0;
			}
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			Image mcPivot2 = _mcPivot;
			EventChapterModel.State state2 = default(EventChapterModel.State);
			if (state2 != EventChapterModel.State.Completed)
			{
				int num12 = 0;
				mcPivot2.color = (Color)num12;
				return;
			}
			goto IL_01fc;
			IL_01fc:
			Color white = Color.white;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CA6")]
		[Cpp2IlInjected.Address(RVA = "0x14041E0", Offset = "0x1402BE0", VA = "0x1814041E0")]
		private void OnTimerCompleted(object sender, object param)
		{
			//Discarded unreachable code: IL_0035
			//IL_002b: Expected O, but got I4
			UITimer mcTimer = _mcTimer;
			UITimer.TimerEventDelegate value = OnTimerCompleted;
			mcTimer.TimerComplete -= value;
			EventContentHome componentInParent = GetComponentInParent<EventContentHome>();
			int num = 0;
			if (componentInParent != (UnityEngine.Object)num)
			{
				componentInParent.RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CA7")]
		[Cpp2IlInjected.Address(RVA = "0x1404150", Offset = "0x1402B50", VA = "0x181404150")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_001c
			UITimer mcTimer = _mcTimer;
			UITimer.TimerEventDelegate value = OnTimerCompleted;
			mcTimer.TimerComplete -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CA8")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EventProgressPivot()
		{
		}
	}
}
