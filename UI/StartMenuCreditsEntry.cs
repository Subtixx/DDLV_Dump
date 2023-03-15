using System;
using Cpp2IlInjected;
using NaughtyAttributes;
using UnityEngine;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class StartMenuCreditsEntry
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum StartMenuCreditsEntryPlatform
	{
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		All,
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		Playstation,
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		Steam,
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		Mac
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum StartMenuCreditsEntryType
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		Text,
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		Image
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[SerializeField]
	private string _name;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public StartMenuCreditsEntryType Type;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public StartMenuCreditsEntryPlatform Platform;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	[ResizableTextArea]
	[Tooltip("Change the following content with [H] for header text, [W] for wall of text (like copyright infos) or [T] back to normal text for names and titles.\nUse {Curly braces} for localization IDs. Localization arameters work like: {thanks_to:name:Everyone who likes it!}")]
	[HideIf("showImage")]
	public string Text;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	[AllowNesting]
	[ShowIf("showImage")]
	public GameObject Image;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool showImage
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x85A740", Offset = "0x859140", VA = "0x18085A740")]
		get
		{
			return Type == StartMenuCreditsEntryType.Image;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
	public StartMenuCreditsEntry()
	{
	}
}
