using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public class UISkin : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private int m_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		[SerializeField]
		private Font m_font;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		[SerializeField]
		private int m_fontSize = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		[SerializeField]
		private int m_lineHeight = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		[SerializeField]
		private int m_indentAmount = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		[SerializeField]
		private float m_labelWidthPercentage = 0.4f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		[SerializeField]
		private Color m_windowColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		[SerializeField]
		private Color m_backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		[SerializeField]
		private Color m_textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		[SerializeField]
		private Color m_scrollbarColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		[SerializeField]
		private Color m_expandArrowColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		[SerializeField]
		private Color m_inputFieldNormalBackgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		[SerializeField]
		private Color m_inputFieldInvalidBackgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		[SerializeField]
		private Color m_inputFieldTextColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		[SerializeField]
		private Color m_toggleCheckmarkColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		[SerializeField]
		private Color m_sliderBackgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		[SerializeField]
		private Color m_sliderThumbColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		[SerializeField]
		private Color m_buttonBackgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		[SerializeField]
		private Color m_buttonTextColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		[SerializeField]
		private Color m_selectedItemBackgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		[SerializeField]
		private Color m_selectedItemTextColor;

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return m_version;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public Font Font
		{
			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return m_font;
			}
			[Cpp2IlInjected.Token(Token = "0x600069E")]
			[Cpp2IlInjected.Address(RVA = "0xC99BB0", Offset = "0xC985B0", VA = "0x180C99BB0")]
			set
			{
				if (m_font != value)
				{
					m_font = value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public int FontSize
		{
			[Cpp2IlInjected.Token(Token = "0x600069F")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return m_fontSize;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A0")]
			[Cpp2IlInjected.Address(RVA = "0xC99BA0", Offset = "0xC985A0", VA = "0x180C99BA0")]
			set
			{
				if (m_fontSize != value)
				{
					m_fontSize = value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public int LineHeight
		{
			[Cpp2IlInjected.Token(Token = "0x60006A1")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return m_lineHeight;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A2")]
			[Cpp2IlInjected.Address(RVA = "0xC99DA0", Offset = "0xC987A0", VA = "0x180C99DA0")]
			set
			{
				if (m_lineHeight != value)
				{
					m_lineHeight = value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public int IndentAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return m_indentAmount;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0xC99C50", Offset = "0xC98650", VA = "0x180C99C50")]
			set
			{
				if (m_indentAmount != value)
				{
					m_indentAmount = value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public float LabelWidthPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0xBC59C0", Offset = "0xBC43C0", VA = "0x180BC59C0")]
			get
			{
				return m_labelWidthPercentage;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A6")]
			[Cpp2IlInjected.Address(RVA = "0xC99D80", Offset = "0xC98780", VA = "0x180C99D80")]
			set
			{
				m_labelWidthPercentage = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public Color WindowColor
		{
			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0xC99A30", Offset = "0xC98430", VA = "0x180C99A30")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0xC9A030", Offset = "0xC98A30", VA = "0x180C9A030")]
			set
			{
				Color windowColor = m_windowColor;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public Color BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0x8BB8C0", Offset = "0x8BA2C0", VA = "0x1808BB8C0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0xC99A40", Offset = "0xC98440", VA = "0x180C99A40")]
			set
			{
				Color backgroundColor = m_backgroundColor;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public Color TextColor
		{
			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0xC99A10", Offset = "0xC98410", VA = "0x180C99A10")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0xC99F80", Offset = "0xC98980", VA = "0x180C99F80")]
			set
			{
				Color textColor = m_textColor;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public Color ScrollbarColor
		{
			[Cpp2IlInjected.Token(Token = "0x60006AD")]
			[Cpp2IlInjected.Address(RVA = "0xC999C0", Offset = "0xC983C0", VA = "0x180C999C0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0xC99DB0", Offset = "0xC987B0", VA = "0x180C99DB0")]
			set
			{
				Color scrollbarColor = m_scrollbarColor;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public Color ExpandArrowColor
		{
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0xC99980", Offset = "0xC98380", VA = "0x180C99980")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0xC99B50", Offset = "0xC98550", VA = "0x180C99B50")]
			set
			{
				Color expandArrowColor = m_expandArrowColor;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public Color InputFieldNormalBackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0xC999A0", Offset = "0xC983A0", VA = "0x180C999A0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0xC99CC0", Offset = "0xC986C0", VA = "0x180C99CC0")]
			set
			{
				Color inputFieldNormalBackgroundColor = m_inputFieldNormalBackgroundColor;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public Color InputFieldInvalidBackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0xC99990", Offset = "0xC98390", VA = "0x180C99990")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006B4")]
			[Cpp2IlInjected.Address(RVA = "0xC99C60", Offset = "0xC98660", VA = "0x180C99C60")]
			set
			{
				Color inputFieldInvalidBackgroundColor = m_inputFieldInvalidBackgroundColor;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public Color InputFieldTextColor
		{
			[Cpp2IlInjected.Token(Token = "0x60006B5")]
			[Cpp2IlInjected.Address(RVA = "0xC999B0", Offset = "0xC983B0", VA = "0x180C999B0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006B6")]
			[Cpp2IlInjected.Address(RVA = "0xC99D20", Offset = "0xC98720", VA = "0x180C99D20")]
			set
			{
				Color inputFieldTextColor = m_inputFieldTextColor;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public Color ToggleCheckmarkColor
		{
			[Cpp2IlInjected.Token(Token = "0x60006B7")]
			[Cpp2IlInjected.Address(RVA = "0xC99A20", Offset = "0xC98420", VA = "0x180C99A20")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006B8")]
			[Cpp2IlInjected.Address(RVA = "0xC99FD0", Offset = "0xC989D0", VA = "0x180C99FD0")]
			set
			{
				Color toggleCheckmarkColor = m_toggleCheckmarkColor;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public Color SliderBackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60006B9")]
			[Cpp2IlInjected.Address(RVA = "0xC999F0", Offset = "0xC983F0", VA = "0x180C999F0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006BA")]
			[Cpp2IlInjected.Address(RVA = "0xC99EC0", Offset = "0xC988C0", VA = "0x180C99EC0")]
			set
			{
				Color sliderBackgroundColor = m_sliderBackgroundColor;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public Color SliderThumbColor
		{
			[Cpp2IlInjected.Token(Token = "0x60006BB")]
			[Cpp2IlInjected.Address(RVA = "0xC99A00", Offset = "0xC98400", VA = "0x180C99A00")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006BC")]
			[Cpp2IlInjected.Address(RVA = "0xC99F20", Offset = "0xC98920", VA = "0x180C99F20")]
			set
			{
				Color sliderThumbColor = m_sliderThumbColor;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public Color ButtonBackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0xC99960", Offset = "0xC98360", VA = "0x180C99960")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0xC99A90", Offset = "0xC98490", VA = "0x180C99A90")]
			set
			{
				Color buttonBackgroundColor = m_buttonBackgroundColor;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public Color ButtonTextColor
		{
			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0xC99970", Offset = "0xC98370", VA = "0x180C99970")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0xC99AF0", Offset = "0xC984F0", VA = "0x180C99AF0")]
			set
			{
				Color buttonTextColor = m_buttonTextColor;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public Color SelectedItemBackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0xC999D0", Offset = "0xC983D0", VA = "0x180C999D0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0xC99E00", Offset = "0xC98800", VA = "0x180C99E00")]
			set
			{
				Color selectedItemBackgroundColor = m_selectedItemBackgroundColor;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public Color SelectedItemTextColor
		{
			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0xC999E0", Offset = "0xC983E0", VA = "0x180C999E0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0xC99E60", Offset = "0xC98860", VA = "0x180C99E60")]
			set
			{
				Color selectedItemTextColor = m_selectedItemTextColor;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0xC997C0", Offset = "0xC981C0", VA = "0x180C997C0")]
		[ContextMenu("Refresh UI")]
		private void Invalidate()
		{
			int num = (m_version = Random.Range(int.MinValue, int.MaxValue));
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xC997F0", Offset = "0xC981F0", VA = "0x180C997F0")]
		public UISkin()
		{
			//IL_000a: Expected I4, but got I8
			//IL_0014: Expected I4, but got I8
			//IL_001e: Expected I4, but got I8
			Color black = Color.black;
			Color black2 = Color.black;
			Color black3 = Color.black;
			Color white = Color.white;
			Color red = Color.red;
			Color black4 = Color.black;
			Color black5 = Color.black;
			Color white2 = Color.white;
			Color black6 = Color.black;
			Color white3 = Color.white;
			Color black7 = Color.black;
			Color blue = Color.blue;
			Color black8 = Color.black;
			base._002Ector();
		}
	}
}
