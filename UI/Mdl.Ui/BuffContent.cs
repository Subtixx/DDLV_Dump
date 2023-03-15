using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Campaign;
using Definitions.Items;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200056F")]
	[RequiredAllNotNull]
	public class BuffContent : MonoBehaviour, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DB1")]
		public BaseButton BuffButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DB2")]
		public BuffTip BuffTip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001DB3")]
		private List<Buff> _activBuff = (List<Buff>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001DB4")]
		[SerializeField]
		private GameObject _buffDetailList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001DB5")]
		private bool buffUpdated;

		[Cpp2IlInjected.Token(Token = "0x6002393")]
		[Cpp2IlInjected.Address(RVA = "0xA659A0", Offset = "0xA643A0", VA = "0x180A659A0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0078
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.PlayerBuffAdded value = OnPlayerBuffAdded;
			_003CDispatcher_003Ek__BackingField.OnPlayerBuffAdded += value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.PlayerBuffRemoved value2 = OnPlayerBuffRemoved;
			_003CDispatcher_003Ek__BackingField2.OnPlayerBuffRemoved += value2;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.PlayerBuffUpdated value3 = OnPlayerBuffUpdated;
			_003CDispatcher_003Ek__BackingField3.OnPlayerBuffUpdated += value3;
			buffUpdated = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002394")]
		[Cpp2IlInjected.Address(RVA = "0xA64C60", Offset = "0xA63660", VA = "0x180A64C60")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_009b
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.PlayerBuffAdded value = OnPlayerBuffAdded;
					_003CDispatcher_003Ek__BackingField.OnPlayerBuffAdded -= value;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.PlayerBuffRemoved value2 = OnPlayerBuffRemoved;
					_003CDispatcher_003Ek__BackingField2.OnPlayerBuffRemoved -= value2;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.PlayerBuffUpdated value3 = OnPlayerBuffUpdated;
					_003CDispatcher_003Ek__BackingField3.OnPlayerBuffUpdated -= value3;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002395")]
		[Cpp2IlInjected.Address(RVA = "0xA64FB0", Offset = "0xA639B0", VA = "0x180A64FB0")]
		private void OnPlayerBuffAdded(BuffOrigin buffOrigin, BuffType buffType, int percentageEffect)
		{
			buffUpdated = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002396")]
		[Cpp2IlInjected.Address(RVA = "0xA64FB0", Offset = "0xA639B0", VA = "0x180A64FB0")]
		private void OnPlayerBuffRemoved(BuffOrigin buffOrigin, BuffType buffType)
		{
			buffUpdated = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002397")]
		[Cpp2IlInjected.Address(RVA = "0xA64FB0", Offset = "0xA639B0", VA = "0x180A64FB0")]
		private void OnPlayerBuffUpdated(BuffOrigin buffOrigin, BuffType buffType)
		{
			buffUpdated = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002398")]
		[Cpp2IlInjected.Address(RVA = "0xA64FC0", Offset = "0xA639C0", VA = "0x180A64FC0")]
		public void OnRefresh()
		{
			//Discarded unreachable code: IL_0177, IL_017d, IL_0183, IL_0189, IL_018f, IL_0195, IL_019b, IL_01a1, IL_01a7, IL_01ad, IL_01b3, IL_01b9, IL_01bf, IL_01c5, IL_01cb
			//IL_0038: Expected O, but got I4
			//IL_008e: Expected I4, but got O
			//IL_0097: Expected I4, but got O
			List<CampaignData> list;
			bool flag = default(bool);
			bool flag2 = default(bool);
			Dictionary<(BuffOrigin, BuffType, Buff.EndConditionOneofCase), Buff> dictionary;
			Client client = default(Client);
			uint num3 = default(uint);
			bool flag3 = default(bool);
			Buff buff = default(Buff);
			Timestamp timestamp2 = default(Timestamp);
			Timestamp timestamp3 = default(Timestamp);
			Timestamp timestamp4 = default(Timestamp);
			do
			{
				int num = 0;
				MapField<string, CampaignState> states_ = SystemRoot.Instance.MetaClient.profile.player_.campaignHistory_.states_;
				list = (List<CampaignData>)(object)new List<T>();
				if (flag)
				{
					while (!flag2)
					{
					}
					((List<T>)(object)list).Add((T)num);
				}
				int num2 = 0;
				dictionary = (Dictionary<(BuffOrigin, BuffType, Buff.EndConditionOneofCase), Buff>)(object)new Dictionary<TKey, TValue>();
				IEnumerable<Buff> allBuffs = (IEnumerable<Buff>)client.profile.player_.GetAllBuffs();
				if (allBuffs != null)
				{
					if (num2 < (int)num3)
					{
						num2 += num2;
						if (num2 == (int)num3)
						{
							goto IL_00ae;
						}
						num2++;
					}
					int num4 = 0;
					if (!flag3)
					{
						buff = new Buff();
						buff.origin_ = (BuffOrigin)buff;
						buff.type_ = (BuffType)buff;
						if ((long)buff == 4)
						{
							timestamp2 = (buff.EndTime = new Timestamp());
							goto IL_00ae;
						}
						goto IL_00b5;
					}
					goto IL_00cb;
				}
				goto IL_0126;
				IL_00b5:
				if ((long)timestamp2 == 5)
				{
					int num6 = (buff.NumberOfUsesLeft = 0);
				}
				int num7 = 0;
				goto IL_00cb;
				IL_00cb:
				if (buff.endConditionCase_ == Buff.EndConditionOneofCase.EndTime)
				{
					DateTime dateTime = buff.EndTime.ToDateTime();
					DateTime dateTime2 = timestamp3.ToDateTime();
					if (dateTime > dateTime2)
					{
						Timestamp endTime = buff.EndTime;
					}
					buff.EndTime = timestamp4;
				}
				while ((long)timestamp4 != 5)
				{
				}
				int numberOfUsesLeft = buff.NumberOfUsesLeft;
				int num9 = (buff.NumberOfUsesLeft = 0);
				goto IL_0126;
				IL_00ae:
				timestamp2 = (Timestamp)(object)((object)timestamp2 + (object)timestamp2);
				goto IL_00b5;
				IL_0126:
				if (allBuffs != null)
				{
				}
			}
			while (dictionary != null);
			if (Enumerable.Any<CampaignData>((IEnumerable<>)list))
			{
			}
			GameObject gameObject = default(GameObject);
			bool flag4 = default(bool);
			gameObject.SetActive(flag4);
			BuffTip buffTip = BuffTip;
			if (!flag4)
			{
				GameObject gameObject2 = buffTip.gameObject;
				int active = 0;
				gameObject2.SetActive((byte)active != 0);
				return;
			}
			BuffTipModel model = default(BuffTipModel);
			buffTip.Model = model;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002399")]
		[Cpp2IlInjected.Address(RVA = "0xA65C50", Offset = "0xA64650", VA = "0x180A65C50")]
		public void ToggleBuffTip()
		{
			//Discarded unreachable code: IL_0046
			GameObject gameObject = BuffTip.gameObject;
			bool active = !BuffTip.gameObject.activeSelf;
			gameObject.SetActive(active);
			if (BuffTip.gameObject.activeSelf)
			{
				BuffTip.RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600239A")]
		[Cpp2IlInjected.Address(RVA = "0xA64C00", Offset = "0xA63600", VA = "0x180A64C00", Slot = "4")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_001f
			if (redirectionType == (RedirectionType)1 && BuffButton.gameObject.activeSelf)
			{
				ToggleBuffTip();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600239B")]
		[Cpp2IlInjected.Address(RVA = "0xA65CF0", Offset = "0xA646F0", VA = "0x180A65CF0")]
		public BuffContent()
		{
		}
	}
}
