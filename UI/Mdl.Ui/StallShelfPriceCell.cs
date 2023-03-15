using Cpp2IlInjected;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007E4")]
	[RequiredAllNotNull]
	public class StallShelfPriceCell : InfoGizmo, ICanvasRaycastFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002E62")]
		private GameObject _target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002E63")]
		[SerializeField]
		private AsyncAtlassedIcon _mcCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002E64")]
		[SerializeField]
		private TextBase _tfAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002E65")]
		[SerializeField]
		private GameObject _highlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002E66")]
		private string _icon = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002E67")]
		private string _amount = "";

		[Cpp2IlInjected.Token(Token = "0x17000716")]
		public GameObject Target
		{
			[Cpp2IlInjected.Token(Token = "0x600324B")]
			[Cpp2IlInjected.Address(RVA = "0x70CA80", Offset = "0x70B480", VA = "0x18070CA80")]
			get
			{
				return _target;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000717")]
		public string Icon
		{
			[Cpp2IlInjected.Token(Token = "0x600324C")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			get
			{
				return _icon;
			}
			[Cpp2IlInjected.Token(Token = "0x600324D")]
			[Cpp2IlInjected.Address(RVA = "0x856190", Offset = "0x854B90", VA = "0x180856190")]
			set
			{
				//Discarded unreachable code: IL_001e
				_icon = value;
				AsyncAtlassedIcon mcCurrency = _mcCurrency;
				string icon = _icon;
				bool flag = mcCurrency.SetIcon(icon);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000718")]
		public string Price
		{
			[Cpp2IlInjected.Token(Token = "0x600324E")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			get
			{
				return _amount;
			}
			[Cpp2IlInjected.Token(Token = "0x600324F")]
			[Cpp2IlInjected.Address(RVA = "0x8561E0", Offset = "0x854BE0", VA = "0x1808561E0")]
			set
			{
				//Discarded unreachable code: IL_001d
				_amount = value;
				TextBase tfAmount = _tfAmount;
				string text = (tfAmount.Text = _amount);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000719")]
		public GameObject Highlight
		{
			[Cpp2IlInjected.Token(Token = "0x6003250")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			get
			{
				return _highlight;
			}
			[Cpp2IlInjected.Token(Token = "0x6003251")]
			[Cpp2IlInjected.Address(RVA = "0x824270", Offset = "0x822C70", VA = "0x180824270")]
			set
			{
				_highlight = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003252")]
		[Cpp2IlInjected.Address(RVA = "0x855D50", Offset = "0x854750", VA = "0x180855D50")]
		public void Show(GameObject target)
		{
			//Discarded unreachable code: IL_003e
			//IL_0010: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			Collider component = target.GetComponent<Collider>();
			int num = 0;
			if (component != (Object)num)
			{
				RectTransform component2 = GetComponent<RectTransform>();
				int num2 = 0;
				Vector2 sizeDelta = component2.sizeDelta;
				component2.sizeDelta = (Vector2)num2;
			}
			_target = target;
			int num3 = 0;
			ShortcutIndicatorSetTemplate currentShortcutIndicatorSet = ((IHasShortcutIndicators)this).GetCurrentShortcutIndicatorSet();
		}

		[Cpp2IlInjected.Token(Token = "0x6003253")]
		[Cpp2IlInjected.Address(RVA = "0x855F40", Offset = "0x854940", VA = "0x180855F40", Slot = "13")]
		protected override void Update()
		{
			//Discarded unreachable code: IL_005a
			//IL_0016: Expected O, but got I4
			base.Update();
			GameObject target = _target;
			int num = 0;
			if (!(target == (Object)num))
			{
				int num2 = 0;
				Camera main = Camera.main;
				Transform transform = _target.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				int pixelHeight = SystemRoot.Instance._playerCamera.pixelHeight;
				Transform transform2 = base.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003254")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "20")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003255")]
		[Cpp2IlInjected.Address(RVA = "0x855CD0", Offset = "0x8546D0", VA = "0x180855CD0")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_002d
			//IL_002c: Expected O, but got I4
			if ((long)_mcCurrency.Key == 0)
			{
			}
			RectTransform rectTransform = _tfAmount.RectTransform;
			int num = 0;
			Vector2 anchoredPosition = rectTransform.anchoredPosition;
			rectTransform.anchoredPosition = (Vector2)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003256")]
		[Cpp2IlInjected.Address(RVA = "0x856120", Offset = "0x854B20", VA = "0x180856120")]
		public StallShelfPriceCell()
		{
		}
	}
}
