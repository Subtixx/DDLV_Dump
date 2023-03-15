using Cpp2IlInjected;
using Gameloft.Localization.Formatter;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002F4")]
	internal class SortItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000E60")]
		private string localizedString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000E61")]
		public string StringId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000E62")]
		public CollectionItemModel ItemModel;

		[Cpp2IlInjected.Token(Token = "0x600132C")]
		[Cpp2IlInjected.Address(RVA = "0x15FDFB0", Offset = "0x15FC9B0", VA = "0x1815FDFB0")]
		public string GetLocalizedString()
		{
			//IL_001b: Expected O, but got I4
			string text = localizedString;
			if (text == null)
			{
				string stringId = StringId;
				int num = 0;
				string text2 = (localizedString = LocalizationManager.FromStringID(stringId, (IResolver)num));
			}
			return text;
		}

		[Cpp2IlInjected.Token(Token = "0x600132D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public SortItem()
		{
		}
	}
}
