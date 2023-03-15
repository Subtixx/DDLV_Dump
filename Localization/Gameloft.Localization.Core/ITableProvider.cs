using System.Collections.Generic;
using System.Globalization;
using Cpp2IlInjected;

namespace Gameloft.Localization.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface ITableProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IStringTable GetTable(string tableName, CultureInfo culture);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SetJsonValue(LocId locId, CultureInfo culture, string newValue, string comment, string dId, string category, bool forceChangeDate);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AddJsonValue(LocId locId, CultureInfo culture, string newValue, string comment, string dId, string category);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RemoveJsonValue(LocId locId, CultureInfo culture);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		List<string> GetJsonFileNames();

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		List<string> GetJsonLocIds(string tableName, CultureInfo culture);
	}
}
