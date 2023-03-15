using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using Gameloft.Localization.Formatter;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000460")]
	public class EventLeaderboardRewardItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001622")]
		[SerializeField]
		private TextBase _tfRank;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001623")]
		[SerializeField]
		private GameObject _mcAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001624")]
		[SerializeField]
		private TextBase _tfAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001625")]
		[SerializeField]
		private AsyncAtlassedIcon _mcImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001626")]
		[SerializeField]
		private Image _mcBackgroundBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001627")]
		[SerializeField]
		private Image _mcBackgroundGlow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001628")]
		[SerializeField]
		private ButtonTmPro _btnClaim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001629")]
		[SerializeField]
		private Transform _mcLayout1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400162A")]
		[SerializeField]
		private Transform _mcLayout2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400162B")]
		[SerializeField]
		private Transform _mcLayout3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400162C")]
		public EventLeaderboardRewardModel Model;

		[Cpp2IlInjected.Token(Token = "0x170004A5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x70"), Cpp2IlInjected.Token(Token = "0x400162D")]
		public bool IsFinished
		{
			[Cpp2IlInjected.Token(Token = "0x6001C40")]
			[Cpp2IlInjected.Address(RVA = "0x975C90", Offset = "0x974690", VA = "0x180975C90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001C41")]
			[Cpp2IlInjected.Address(RVA = "0x976530", Offset = "0x974F30", VA = "0x180976530")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004A6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x74"), Cpp2IlInjected.Token(Token = "0x400162E")]
		public int PlayerRank
		{
			[Cpp2IlInjected.Token(Token = "0x6001C42")]
			[Cpp2IlInjected.Address(RVA = "0xDD7040", Offset = "0xDD5A40", VA = "0x180DD7040")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001C43")]
			[Cpp2IlInjected.Address(RVA = "0xDD7100", Offset = "0xDD5B00", VA = "0x180DD7100")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C44")]
		[Cpp2IlInjected.Address(RVA = "0x13FD310", Offset = "0x13FBD10", VA = "0x1813FD310")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0172
			//IL_002b: Expected O, but got I4
			//IL_0054: Expected O, but got I4
			//IL_013a: Expected O, but got I4
			if ((long)Model != 0)
			{
				Color white = Color.white;
				int backgroundGradientStart = Model.BackgroundGradientStart;
				string text = $"#{backgroundGradientStart:X2}";
				Image mcBackgroundGlow = _mcBackgroundGlow;
				Color white2 = Color.white;
				int backgroundGradientEnd = Model.BackgroundGradientEnd;
				string text2 = $"#{backgroundGradientEnd:X2}";
				Image mcBackgroundBase = _mcBackgroundBase;
				EventLeaderboardRewardModel model = Model;
				if ((long)model.Reward != 0)
				{
					DebugDoVisualTweak();
				}
				int amount_ = model.Reward.amount_;
				GameObject mcAmount = _mcAmount;
				TextBase tfAmount = _tfAmount;
				string text3 = default(string);
				string text5 = (tfAmount.Text = "x" + text3);
				_mcAmount.SetActive(value: true);
				GameObject gameObject = _btnClaim.gameObject;
				if (IsFinished)
				{
					EventLeaderboardRewardModel model2 = Model;
					int num = PlayerRank;
				}
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				if (_btnClaim.gameObject.activeSelf)
				{
					EventLeaderboardRewardModel model3 = Model;
					ButtonTmPro btnClaim = _btnClaim;
					bool flag2 = (btnClaim.IsActive = !model3.HasClaimed);
				}
				TextBase tfRank = _tfRank;
				int num2 = 0;
				string text6 = LocalizationManager.FromStringID("event.leaderboard_rank_label", (IResolver)num2);
				int rankRangeMin = Model.RankRangeMin;
				int rankRangeMax = Model.RankRangeMax;
				string text8 = (tfRank.Text = $"{text6} {text6}-{text6}");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C45")]
		[Cpp2IlInjected.Address(RVA = "0x13FCA40", Offset = "0x13FB440", VA = "0x1813FCA40")]
		private void DebugDoVisualTweak()
		{
			//Discarded unreachable code: IL_010f, IL_0115, IL_011b, IL_0121, IL_0127, IL_012d, IL_0133, IL_013f
			float f = default(float);
			GameObject gameObject2 = default(GameObject);
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				EventLeaderboardRewardModel model = Model;
				if (model == null)
				{
					break;
				}
				ItemReward reward = model.Reward;
				if (reward == null)
				{
					break;
				}
				int b = Mathf.FloorToInt(f);
				int num2 = Mathf.Min(2, b);
				Item item = reward.Item;
				switch (num2)
				{
				}
				Transform mcLayout = _mcLayout1;
				int childCount = _mcImage.transform.parent.childCount;
				GameObject original = _mcImage.gameObject;
				Transform parent = _mcImage.transform.parent;
				GameObject gameObject = UnityEngine.Object.Instantiate(original, parent);
				childCount++;
				while (childCount <= num2)
				{
				}
				mcLayout.gameObject.SetActive(value: true);
				IEnumerator enumerator = _mcImage.transform.parent.GetEnumerator();
				if (enumerator != null)
				{
					if (enumerator == null)
					{
					}
					int num3 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					UnityEngine.Object.Destroy(gameObject2);
					num++;
					if ((object)mcLayout.GetChild(num) != null)
					{
					}
					if ((object)gameObject2 != null)
					{
					}
					num++;
				}
				if (flag)
				{
				}
				if (num2 == 0)
				{
					GameObject gameObject3 = mcLayout.gameObject;
					int active = 0;
					gameObject3.SetActive((byte)active != 0);
					return;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C46")]
		[Cpp2IlInjected.Address(RVA = "0x13FCF30", Offset = "0x13FB930", VA = "0x1813FCF30")]
		public void OnClaimClicked()
		{
			//Discarded unreachable code: IL_00d5, IL_00db, IL_00e7
			int num = 0;
			ButtonTmPro btnClaim = _btnClaim;
			Model.HasClaimed = true;
			ButtonTmPro btnClaim2 = _btnClaim;
			bool flag2 = (btnClaim2.IsActive = (Model.HasClaimed ? 1 : 0) == num);
			EventLeaderboardRewardModel model = Model;
			FakeEventLeaderboardRewardModel rawFakeData = model.RawFakeData;
			if (rawFakeData != null)
			{
				bool flag3 = (rawFakeData.HasClaimed = model.HasClaimed);
			}
			ItemReward reward = model.Reward;
			IEnumerator enumerator = _mcImage.transform.parent.GetEnumerator();
			Coroutine coroutine = default(Coroutine);
			if (enumerator != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int _003C_003E1__state = default(int);
				_003COnDelayedCall_003Ed__22 _003COnDelayedCall_003Ed__ = new _003COnDelayedCall_003Ed__22(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003COnDelayedCall_003Ed__.itemReward = reward;
				GameObject imageObj = default(GameObject);
				_003COnDelayedCall_003Ed__.imageObj = imageObj;
				bool flag4 = (_003COnDelayedCall_003Ed__.doTransaction = num == 0);
				coroutine = StartCoroutine(_003COnDelayedCall_003Ed__);
				num++;
			}
			if (coroutine == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C47")]
		[Cpp2IlInjected.Address(RVA = "0x13FD260", Offset = "0x13FBC60", VA = "0x1813FD260")]
		[IteratorStateMachine(typeof(_003COnDelayedCall_003Ed__22))]
		private IEnumerator OnDelayedCall(float delay, ItemReward itemReward, GameObject imageObj, bool doTransaction)
		{
			int _003C_003E1__state = default(int);
			_003COnDelayedCall_003Ed__22 _003COnDelayedCall_003Ed__ = new _003COnDelayedCall_003Ed__22(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnDelayedCall_003Ed__.itemReward = itemReward;
			_003COnDelayedCall_003Ed__.delay = delay;
			_003COnDelayedCall_003Ed__.imageObj = imageObj;
			_003COnDelayedCall_003Ed__.doTransaction = false;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C48")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EventLeaderboardRewardItem()
		{
		}
	}
}
