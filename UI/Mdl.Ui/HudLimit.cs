using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Grid;
using Mdl.Grid;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000579")]
	public class HudLimit : InfoGizmo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001DDB")]
		[SerializeField]
		private SimpleSlide _simpleSlide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001DDC")]
		[SerializeField]
		private TextBase _tfObjectCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001DDD")]
		[SerializeField]
		private Image _mcObjectIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001DDE")]
		[SerializeField]
		private TextBase _tfObjectCounterTotal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001DDF")]
		[SerializeField]
		private Image _mcObjectIconTotal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001DE0")]
		[SerializeField]
		private Transform _mcObjectContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001DE1")]
		private IVillageObjectLimitProvider VillageObjectLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001DE2")]
		private Color32 _disableColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4001DE3")]
		public Color32 _enabledColor = (Color32)0;

		[Cpp2IlInjected.Token(Token = "0x60023C7")]
		[Cpp2IlInjected.Address(RVA = "0xAF6DC0", Offset = "0xAF57C0", VA = "0x180AF6DC0", Slot = "11")]
		public override void Init(GameObject target, bool followTarget = false, [Optional] CancellationToken? ct, params object[] parameters)
		{
			//Discarded unreachable code: IL_0056
			int num = 0;
			int num2 = 0;
			UIGameColors gameColors = UiRoot.Instance._gameColors;
			Color32 color = default(Color32);
			_disableColor = color;
			CancellationToken? cancellationToken = _cancellationToken;
			bool flag = default(bool);
			if (!flag)
			{
				Hide();
			}
			if ((object)color != null && (object)color != null)
			{
				VillageObjectLimit = (IVillageObjectLimitProvider)color;
				IVillageObjectLimitProvider villageObjectLimit = VillageObjectLimit;
				VillageObjectLimitChangedDelegate villageObjectLimitChangedDelegate = OnLimitChangeHandler;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023C8")]
		[Cpp2IlInjected.Address(RVA = "0xAF6FA0", Offset = "0xAF59A0", VA = "0x180AF6FA0")]
		private void OnDestroy()
		{
			if (VillageObjectLimit != null)
			{
				VillageObjectLimitChangedDelegate villageObjectLimitChangedDelegate = OnLimitChangeHandler;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60023C9")]
		[Cpp2IlInjected.Address(RVA = "0xAF7040", Offset = "0xAF5A40", VA = "0x180AF7040")]
		private void OnLimitChangeHandler(VillageObjectLimit currentAmount, VillageObjectLimitData limits)
		{
			//Discarded unreachable code: IL_00a5
			//IL_0021: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			TextBase tfObjectCounter = _tfObjectCounter;
			int uniqueCount = currentAmount.UniqueCount;
			int uniqueLimit_ = limits.uniqueLimit_;
			string text2 = (tfObjectCounter.Text = $"{uniqueCount}/{uniqueCount}");
			TextMeshProUGUI textComponent = _tfObjectCounter.TextComponent;
			int uniqueCount2 = currentAmount.UniqueCount;
			Image mcObjectIcon = _mcObjectIcon;
			int uniqueCount3 = currentAmount.UniqueCount;
			TextBase tfObjectCounterTotal = _tfObjectCounterTotal;
			int allCount = currentAmount.AllCount;
			int instanceLimit_ = limits.instanceLimit_;
			string text4 = (tfObjectCounterTotal.Text = $"{allCount}/{allCount}");
			TextMeshProUGUI textComponent2 = _tfObjectCounterTotal.TextComponent;
			int allCount2 = currentAmount.AllCount;
			Image mcObjectIconTotal = _mcObjectIconTotal;
			int allCount3 = currentAmount.AllCount;
		}

		[Cpp2IlInjected.Token(Token = "0x60023CA")]
		[Cpp2IlInjected.Address(RVA = "0xAF7320", Offset = "0xAF5D20", VA = "0x180AF7320", Slot = "14")]
		public override Task Show(CancellationToken ct)
		{
			//Discarded unreachable code: IL_007a
			//IL_0066: Expected O, but got I4
			base.gameObject.SetActive(value: true);
			Transform transform = base.transform;
			int num = 0;
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
			int index = 0;
			Transform transform4 = transform3.GetChild(index).transform;
			int num2 = 0;
			Vector2 zero = Vector2.zero;
			Transform transform5 = base.transform;
			int index2 = 0;
			if ((object)transform5.GetChild(index2).transform != null)
			{
			}
			((RectTransform)num).SetAnchorPreset(AnchorPresetType.StretchAll);
			_simpleSlide.DoSlideIn();
			int num3 = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x60023CB")]
		[Cpp2IlInjected.Address(RVA = "0x9BB7F0", Offset = "0x9BA1F0", VA = "0x1809BB7F0", Slot = "16")]
		protected override void HideImpl()
		{
			//Discarded unreachable code: IL_0011
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60023CC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "17")]
		protected override void UpdatePosition()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60023CD")]
		[Cpp2IlInjected.Address(RVA = "0xAF7590", Offset = "0xAF5F90", VA = "0x180AF7590")]
		public HudLimit()
		{
		}//IL_0009: Expected O, but got I4

	}
}
