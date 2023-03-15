using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using Mdl.Activities;
using Mdl.Items;
using Mdl.Navigation;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007E6")]
	public class TaskInfo : InfoGizmo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002E69")]
		[SerializeField]
		private TextBase _tfLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002E6A")]
		[SerializeField]
		private ButtonTmProIcon _btnSkip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002E6B")]
		[SerializeField]
		private WateringGauge _mcWateringGauge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002E6C")]
		[SerializeField]
		private ProgressBar _mcProgression;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002E6D")]
		[SerializeField]
		private UITimer mc_timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002E6E")]
		[SerializeField]
		private Sprite _disableProgressBk;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002E6F")]
		[SerializeField]
		private Sprite _enableProgressBk;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002E70")]
		public bool HasSkipButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002E71")]
		private WaterStateDisplay _waterState;

		[Cpp2IlInjected.Token(Token = "0x1700071A")]
		public Button SkipButtonAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6003258")]
			[Cpp2IlInjected.Address(RVA = "0x17E74A0", Offset = "0x17E5EA0", VA = "0x1817E74A0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _btnSkip.ButtonComponent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003259")]
		[Cpp2IlInjected.Address(RVA = "0x17E6870", Offset = "0x17E5270", VA = "0x1817E6870", Slot = "11")]
		public override void Init(GameObject target, bool followTarget = false, [Optional] CancellationToken? ct, params object[] parameters)
		{
			//IL_0020: Expected O, but got I4
			//IL_003d: Expected I4, but got I8
			int num = 0;
			WaterStateDisplay waterStateDisplay = (_waterState = target.GetComponentInChildren<WaterStateDisplay>());
			WaterStateDisplay waterState = _waterState;
			int num2 = 0;
			bool flag = waterState == (UnityEngine.Object)num2;
			WateringGauge mcWateringGauge = _mcWateringGauge;
			if (!flag)
			{
				ulong num3 = default(ulong);
				mcWateringGauge.gameObject.SetActive((byte)num3 != 0);
				WateringGauge mcWateringGauge2 = _mcWateringGauge;
				(WateringState, float) wateringStateAndRatio = ((WateringState, float))waterState.GetWateringStateAndRatio();
				mcWateringGauge2.RefreshDisplay((ValueTuple<, >)wateringStateAndRatio);
			}
			GameObject gameObject = mcWateringGauge.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			ItemScript component = target.GetComponent<ItemScript>();
			RefreshItemInfo(component);
			ISkippableTimerProvider componentInChildren = target.GetComponentInChildren<ISkippableTimerProvider>();
			if (componentInChildren == null)
			{
				GameObject gameObject2 = _mcProgression.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
				GameObject gameObject3 = _btnSkip.gameObject;
				int active3 = 0;
				gameObject3.SetActive((byte)active3 != 0);
				return;
			}
			(Item, int) priceToSkip = ((Item, int))SkippableTimerProviderExtensions.GetPriceToSkip(componentInChildren);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600325A")]
		[Cpp2IlInjected.Address(RVA = "0x17E6DA0", Offset = "0x17E57A0", VA = "0x1817E6DA0")]
		internal void RefreshTimerAndPrice(TimeSpan time, (Item currency, int amount) price)
		{
			//Discarded unreachable code: IL_0124
			//IL_0089: Expected F4, but got I4
			//IL_0123: Expected F4, but got I4
			bool flag = default(bool);
			if (!flag)
			{
				GameObject gameObject = _btnSkip._currencyIcon.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			AsyncAtlassedIcon currencyIcon = _btnSkip._currencyIcon;
			string text = default(string);
			_btnSkip.Label.Text = text;
			_btnSkip.RefreshLayout();
			if ((object)_btnSkip.transform != null)
			{
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				_mcProgression.gameObject.SetActive(value: true);
				UITimer uITimer = mc_timer;
				int num = 0;
				uITimer.StartTimer(num);
				TextMeshProUGUI textComponent = mc_timer._tfTimer.TextComponent;
				if (_mcWateringGauge.WateringState != WateringState.Dying)
				{
				}
				ProgressBar mcProgression = _mcProgression;
				WateringGauge mcWateringGauge = _mcWateringGauge;
				Image mc_background = mcProgression.mc_background;
				if (mcWateringGauge.WateringState == WateringState.Dying)
				{
				}
				Sprite sprite = (mc_background.sprite = _enableProgressBk);
				if (_mcWateringGauge.WateringState != WateringState.Dying)
				{
					goto IL_010f;
				}
				mc_timer.PauseTimer();
			}
			GameObject gameObject2 = _mcProgression.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			goto IL_010f;
			IL_010f:
			ProgressBar mcProgression2 = _mcProgression;
			int num2 = 0;
			mcProgression2.FillAmount = num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600325B")]
		[Cpp2IlInjected.Address(RVA = "0x17E6B80", Offset = "0x17E5580", VA = "0x1817E6B80")]
		internal void RefreshItemInfo(ItemScript tagetItem)
		{
			//Discarded unreachable code: IL_0069
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(tagetItem == (UnityEngine.Object)num))
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = tagetItem.Item;
				TextBase tfLabel = _tfLabel;
				IItemData itemData = default(IItemData);
				if (itemData == null)
				{
					string stringID = tfLabel._stringID;
					if (itemData == null)
					{
						tfLabel._stringID = (string)(object)itemData;
						tfLabel.RefreshText();
					}
				}
				else
				{
					tfLabel.Text = "";
				}
			}
			else
			{
				GameObject gameObject = _tfLabel.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600325C")]
		[Cpp2IlInjected.Address(RVA = "0x17E7330", Offset = "0x17E5D30", VA = "0x1817E7330", Slot = "13")]
		protected override void Update()
		{
			//Discarded unreachable code: IL_0050
			//IL_0010: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			GameObject targetObject = _targetObject;
			int num = 0;
			if (!(targetObject == (UnityEngine.Object)num))
			{
				base.Update();
				WaterStateDisplay waterState = _waterState;
				int num2 = 0;
				if (waterState != (UnityEngine.Object)num2)
				{
					WaterStateDisplay waterState2 = _waterState;
					WateringGauge mcWateringGauge = _mcWateringGauge;
					(WateringState, float) wateringStateAndRatio = ((WateringState, float))waterState2.GetWateringStateAndRatio();
					mcWateringGauge.RefreshDisplay((ValueTuple<, >)wateringStateAndRatio);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600325D")]
		[Cpp2IlInjected.Address(RVA = "0x17E7230", Offset = "0x17E5C30", VA = "0x1817E7230")]
		internal void RefreshWaterState(WaterStateDisplay waterState)
		{
			//Discarded unreachable code: IL_004e
			//IL_0009: Expected O, but got I4
			int num = 0;
			bool flag = waterState == (UnityEngine.Object)num;
			WateringGauge mcWateringGauge = _mcWateringGauge;
			if (!flag)
			{
				mcWateringGauge.gameObject.SetActive(value: true);
				WateringGauge mcWateringGauge2 = _mcWateringGauge;
				(WateringState, float) wateringStateAndRatio = ((WateringState, float))waterState.GetWateringStateAndRatio();
				mcWateringGauge2.RefreshDisplay((ValueTuple<, >)wateringStateAndRatio);
			}
			else
			{
				GameObject gameObject = mcWateringGauge.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600325E")]
		[Cpp2IlInjected.Address(RVA = "0x17E7420", Offset = "0x17E5E20", VA = "0x1817E7420")]
		[IteratorStateMachine(typeof(_003CcloseCoroutine_003Ed__16))]
		private IEnumerator closeCoroutine(float time = 3f)
		{
			int _003C_003E1__state = default(int);
			_003CcloseCoroutine_003Ed__16 _003CcloseCoroutine_003Ed__ = new _003CcloseCoroutine_003Ed__16(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CcloseCoroutine_003Ed__._003C_003E4__this = this;
			_003CcloseCoroutine_003Ed__.time = time;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600325F")]
		[Cpp2IlInjected.Address(RVA = "0x87D270", Offset = "0x87BC70", VA = "0x18087D270")]
		public TaskInfo()
		{
		}
	}
}
