using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using AK.Wwise;
using Cpp2IlInjected;
using Gameloft.Localization.Formatter;
using Mdl;
using Mdl.Platform;
using Mdl.Systems;
using Mdl.Ui;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[Cpp2IlInjected.Token(Token = "0x2000058")]
public class StartMenuCredits : Menu, IHasRedirectionHandler
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private enum TextPrefabType
	{
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		Header,
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		Text,
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		WallOfText,
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		None
	}

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const char SquareBracketOpen = '[';

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private const char AngleBracketOpen = '<';

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	[SerializeField]
	[Header("Credits Settings")]
	private float _creditsScrollSpeed = 30f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[SerializeField]
	private ScrollRect _creditsScrollRect;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	[SerializeField]
	private RectTransform _textContainer;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	[SerializeField]
	private ShortcutIndicator _backShortcutIndicator;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	[SerializeField]
	[Header("Prefabs")]
	private TextBase _headerPrefab;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	[SerializeField]
	private TextBase _wallOfTextPrefab;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	[SerializeField]
	[FormerlySerializedAs("_nameTitlePrefab")]
	private TextBase _textPrefab;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	[SerializeField]
	[InfoBox("How to use:\r\n* Limited to one empty line between lines with text (additional lines will be ignored)\r\n* Accepts the following tags:\r\n  - [H] Starts a header section (see 'Header' above)\r\n  - [W] Starts a wall-of-text section (see 'Wall Of Text' above)\r\n  - [T] Starts a text section (see 'Text' above)\r\n  - [L] Adds 2 lines of space\r\n  - [S] Adds 6 lines of space", EInfoBoxType.Normal)]
	private StartMenuCreditsEntry[] _entries;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private bool isSteam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private bool isPlaystation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x112")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private bool isMac;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public StartMenuCreditsEntry[] Entries
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x738AB0", Offset = "0x7374B0", VA = "0x180738AB0")]
		get
		{
			return _entries;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x85B1E0", Offset = "0x859BE0", VA = "0x18085B1E0")]
	public void Start()
	{
		//Discarded unreachable code: IL_0107
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		bool flag = PlatformUtils.UseSteam();
		int num4 = 0;
		isSteam = flag;
		if ((long)typeof(RectTransform).TypeHandle == 25)
		{
		}
		bool flag2 = (isPlaystation = (long)typeof(RectTransform).TypeHandle == 38);
		StartMenuCreditsEntry[] entries = _entries;
		bool flag3 = (isMac = (long)typeof(RectTransform).TypeHandle == 1);
		int length = entries.Length;
		if (num4 < length)
		{
			StartMenuCreditsEntry startMenuCreditsEntry = entries[num4];
			StartMenuCreditsEntry.StartMenuCreditsEntryPlatform platform = startMenuCreditsEntry.Platform;
			if (((isSteam ? 1 : 0) != num4 || platform != StartMenuCreditsEntry.StartMenuCreditsEntryPlatform.Steam) && ((isPlaystation ? 1 : 0) != num4 || platform != StartMenuCreditsEntry.StartMenuCreditsEntryPlatform.Playstation) && ((isMac ? 1 : 0) != num4 || platform != StartMenuCreditsEntry.StartMenuCreditsEntryPlatform.Mac))
			{
				StartMenuCreditsEntry.StartMenuCreditsEntryType type = startMenuCreditsEntry.Type;
				if (type == StartMenuCreditsEntry.StartMenuCreditsEntryType.Text)
				{
					string text = startMenuCreditsEntry.Text;
					ProcessText(text);
					num4++;
				}
				if (type != StartMenuCreditsEntry.StartMenuCreditsEntryType.Image)
				{
				}
			}
			num4++;
		}
		RectTransform content = _creditsScrollRect.m_Content;
		Vector2 anchoredPosition = content.anchoredPosition;
		Transform transform = _creditsScrollRect.m_Viewport.transform;
		Vector2 anchoredPosition2 = default(Vector2);
		content.anchoredPosition = anchoredPosition2;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x85B080", Offset = "0x859A80", VA = "0x18085B080")]
	public void Update()
	{
		//Discarded unreachable code: IL_0053
		int num = 0;
		float deltaTime = Time.deltaTime;
		RectTransform content = _creditsScrollRect.m_Content;
		RectTransform content2 = _creditsScrollRect.m_Content;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		Vector3 vector2 = default(Vector3);
		float z2 = vector2.z;
		Vector2 anchoredPosition = _creditsScrollRect.m_Content.anchoredPosition;
		RectTransform textContainer = _textContainer;
		OnClose();
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x85B080", Offset = "0x859A80", VA = "0x18085B080")]
	private void Scroll()
	{
		//Discarded unreachable code: IL_0053
		int num = 0;
		float deltaTime = Time.deltaTime;
		RectTransform content = _creditsScrollRect.m_Content;
		RectTransform content2 = _creditsScrollRect.m_Content;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		Vector3 vector2 = default(Vector3);
		float z2 = vector2.z;
		Vector2 anchoredPosition = _creditsScrollRect.m_Content.anchoredPosition;
		RectTransform textContainer = _textContainer;
		OnClose();
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x85A9E0", Offset = "0x8593E0", VA = "0x18085A9E0")]
	private void ProcessEntries()
	{
		//Discarded unreachable code: IL_008c
		StartMenuCreditsEntry[] entries = _entries;
		int num = 0;
		int length = entries.Length;
		if (num >= length)
		{
			return;
		}
		StartMenuCreditsEntry startMenuCreditsEntry = entries[num];
		StartMenuCreditsEntry.StartMenuCreditsEntryPlatform platform = startMenuCreditsEntry.Platform;
		if ((isSteam || platform != StartMenuCreditsEntry.StartMenuCreditsEntryPlatform.Steam) && (isPlaystation || platform != StartMenuCreditsEntry.StartMenuCreditsEntryPlatform.Playstation) && (isMac || platform != StartMenuCreditsEntry.StartMenuCreditsEntryPlatform.Mac))
		{
			StartMenuCreditsEntry.StartMenuCreditsEntryType type = startMenuCreditsEntry.Type;
			if (type == StartMenuCreditsEntry.StartMenuCreditsEntryType.Text)
			{
				string text = startMenuCreditsEntry.Text;
				ProcessText(text);
				num++;
			}
			if (type == StartMenuCreditsEntry.StartMenuCreditsEntryType.Image)
			{
				GameObject image = startMenuCreditsEntry.Image;
				ProcessImage(image);
			}
		}
		num++;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x85AAC0", Offset = "0x8594C0", VA = "0x18085AAC0")]
	private void ProcessImage(GameObject prefab)
	{
		//Discarded unreachable code: IL_0019
		RectTransform textContainer = _textContainer;
		Object.Instantiate(prefab, textContainer).GetComponent<ImageHelper>().Load();
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x85AB70", Offset = "0x859570", VA = "0x18085AB70")]
	private void ProcessText(string text)
	{
		//Discarded unreachable code: IL_0191
		//IL_0034: Expected O, but got I4
		Mdl.LocalizationManager.CreditsResolver resolver = new Mdl.LocalizationManager.CreditsResolver();
		string s = text.Replace("\r", "");
		SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
		if ((object)_003CInstance_003Ek__BackingField == null || (object)_003CInstance_003Ek__BackingField._localizationManager != null)
		{
		}
		int num = 0;
		string text2 = Resource.Format(s, resolver, (CultureInfo)num);
		StringBuilder stringBuilder = new StringBuilder(text2.m_stringLength);
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		if (num4 < text2.m_stringLength)
		{
			char c = text2[num3];
			uint num6 = default(uint);
			if (string.Equals(text2.Substring(num3, 4), "<br>"))
			{
				StringBuilder stringBuilder2 = stringBuilder.Append("\n");
				num3 += 3;
				num3++;
				num4 = num3;
				ulong num5 = default(ulong);
				if (num5 != 0)
				{
					int length = 0;
					char c2 = text2[2];
					string text3 = text2.Substring(num3, length);
					if (text3 != null)
					{
						if (string.Equals(text3, "[H]"))
						{
						}
						if (string.Equals(text3, "[W]"))
						{
						}
						if (string.Equals(text3, "[T]"))
						{
						}
						if (string.Equals(text3, "[L]"))
						{
							StringBuilder stringBuilder3 = stringBuilder.Append("\n\n");
						}
						if (string.Equals(text3, "[S]"))
						{
							StringBuilder stringBuilder4 = stringBuilder.Append("\n\n\n\n\n\n");
						}
					}
					Debug.LogWarning("[UI] StartMenuCredits#ProcessText Invalid formatting at " + text3);
					if (num6 != 3)
					{
					}
					if (text2.m_stringLength > 3)
					{
						char c3 = text2[3];
					}
					uint num7 = default(uint);
					num3 += (int)num7;
					num3++;
				}
			}
			if (num6 == 10)
			{
				num2++;
			}
			int num8 = 0;
			StringBuilder stringBuilder5 = stringBuilder.Append((char)num6);
			num3++;
		}
		StringBuilder stringBuilder6 = stringBuilder.Clear();
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x85A780", Offset = "0x859180", VA = "0x18085A780")]
	private void CreateTextfield(TextPrefabType prefabType, StringBuilder text)
	{
		//Discarded unreachable code: IL_0072
		//IL_004e: Expected O, but got I4
		if (text.Length == 0)
		{
			return;
		}
		if (prefabType != 0)
		{
			switch (prefabType)
			{
			}
		}
		TextBase headerPrefab = _headerPrefab;
		RectTransform textContainer = _textContainer;
		TextBase textBase = Object.Instantiate(headerPrefab, textContainer);
		GameObject gameObject = textBase.gameObject;
		int childCount = _textContainer.childCount;
		string text3 = (gameObject.name = $"credits_text_{childCount}");
		string text5 = (textBase.Text = text.ToString());
		StringBuilder stringBuilder = text.Clear();
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x85A750", Offset = "0x859150", VA = "0x18085A750")]
	private bool CheckPlatformSpecificId(StartMenuCreditsEntry.StartMenuCreditsEntryPlatform platform)
	{
		if ((!isSteam && platform == StartMenuCreditsEntry.StartMenuCreditsEntryPlatform.Steam) || (!isPlaystation && platform == StartMenuCreditsEntry.StartMenuCreditsEntryPlatform.Playstation))
		{
			int num = 0;
		}
		if (!isMac)
		{
			while (platform == StartMenuCreditsEntry.StartMenuCreditsEntryPlatform.Mac)
			{
			}
		}
		return true;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x85A9B0", Offset = "0x8593B0", VA = "0x18085A9B0", Slot = "35")]
	internal override void OnControllerChanged()
	{
		//Discarded unreachable code: IL_000c
		_backShortcutIndicator.TransformToPreset();
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x85A920", Offset = "0x859320", VA = "0x18085A920")]
	private void OnClose()
	{
		//Discarded unreachable code: IL_0033
		//IL_000f: Expected O, but got I4
		StartMenu _003CInstance_003Ek__BackingField = StartMenu.Instance;
		int num = 0;
		_003CInstance_003Ek__BackingField.SelectTab((StartTabButton)num);
		AK.Wwise.Event @event = closeSFX;
		if (@event != null)
		{
			GameObject gameObject = base.gameObject;
			uint num2 = @event.Post(gameObject);
		}
		ZEBhdspDAmNZWSwkFOzFgFSrnIY capabilities = ((UQjSmgWfXGzOOVHAqeOSYZFKVQh)this).LkFmzFjdEKcdTHyhlditnDJKdpgK;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x85B050", Offset = "0x859A50", VA = "0x18085B050", Slot = "30")]
	protected override void RegisterBaseListeners()
	{
		//Discarded unreachable code: IL_0012
		((object)this)._002Ector();
		_backShortcutIndicator.TransformToPreset();
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x85A910", Offset = "0x859310", VA = "0x18085A910", Slot = "38")]
	public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
	{
		if (redirectionType == RedirectionType.MenuNavGoBackward)
		{
			OnClose();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x85B3E0", Offset = "0x859DE0", VA = "0x18085B3E0")]
	public StartMenuCredits()
	{
	}
}
