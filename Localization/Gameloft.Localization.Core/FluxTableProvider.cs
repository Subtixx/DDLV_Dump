using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Gameloft.Localization.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class FluxTableProvider : ITableProvider
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		internal class StringTable : IStringTable
		{
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			internal class Entry
			{
				[Cpp2IlInjected.Token(Token = "0x17000015")]
				public string Text
				{
					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				public DateTime LastEdited
				{
					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					[CompilerGenerated]
					get
					{
						return default(DateTime);
					}
					[Cpp2IlInjected.Token(Token = "0x6000055")]
					[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public Entry()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400001F")]
			internal string Name
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000020")]
			internal Dictionary<string, Entry> Strings
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				get;
			} = (Dictionary<string, Entry>)(object)new Dictionary<TKey, TValue>();


			[Cpp2IlInjected.Token(Token = "0x17000013")]
			string IStringTable.Name
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "4")]
				get
				{
					return Name;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			IEnumerable<KeyValuePair<string, string>> IStringTable.Strings
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0x40908C0", Offset = "0x408F2C0", VA = "0x1840908C0", Slot = "5")]
				get
				{
					Dictionary<string, Entry> dictionary = Strings;
					Func<KeyValuePair<string, Entry>, KeyValuePair<string, string>> func = default(Func<KeyValuePair<string, Entry>, KeyValuePair<string, string>>);
					if (_003C_003Ec._003C_003E9__10_0 == null)
					{
						func = (Func<KeyValuePair<string, Entry>, KeyValuePair<string, string>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<string, Entry> kv) => default(KeyValuePair<string, string>)));
					}
					return (IEnumerable<KeyValuePair<string, string>>)Enumerable.Select<KeyValuePair<string, Entry>, KeyValuePair<string, string>>((IEnumerable<>)dictionary, (Func<, >)(object)func);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4090820", Offset = "0x408F220", VA = "0x184090820", Slot = "6")]
			unsafe bool IStringTable.TryGetValue(string key, out string value)
			{
				//Discarded unreachable code: IL_0018
				Dictionary<string, Entry> dictionary = Strings;
				int num = 0;
				bool flag = ((Dictionary<TKey, TValue>)(object)dictionary).TryGetValue((TKey)key, out *(TValue*)num);
				if (flag)
				{
				}
				return flag;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4090C50", Offset = "0x408F650", VA = "0x184090C50")]
			public StringTable(string name)
			{
				Name = name;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private struct LocalizationEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public string dId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public string Id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public string Text;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int CharacterLimit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public string Category;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public string Comment;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public string LastEdited;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400001D")]
		internal string Path
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400001E")]
		internal IFileSystem FileSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x408F190", Offset = "0x408DB90", VA = "0x18408F190")]
		public FluxTableProvider(string path, [Optional] IFileSystem fileSystem)
		{
			Path = path;
			if (fileSystem == null)
			{
				DefaultFileSystem defaultFileSystem = new DefaultFileSystem();
			}
			FileSystem = fileSystem;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x408E9F0", Offset = "0x408D3F0", VA = "0x18408E9F0")]
		internal StringTable GetTable(string tableName, CultureInfo culture)
		{
			//Discarded unreachable code: IL_0117, IL_013f
			StringTable stringTable;
			bool flag = default(bool);
			DateTime minValue = default(DateTime);
			LocalizationEntry _003CText_003Ek__BackingField = default(LocalizationEntry);
			while (true)
			{
				int num = 0;
				stringTable = new StringTable(tableName);
				string[] array = new string[0];
				string text = Path;
				if (text != null && array == null)
				{
					continue;
				}
				array[0] = text;
				if (tableName != null && array == null)
				{
					continue;
				}
				array[1] = tableName;
				if ("_" != null && "_" == null)
				{
					continue;
				}
				array[2] = "_";
				string name = culture.Name;
				if (name != null && name == null)
				{
					continue;
				}
				array[3] = name;
				if (".json" != null && ".json" == null)
				{
					continue;
				}
				array[4] = ".json";
				string text2 = string.Concat(array);
				IFileSystem fileSystem = FileSystem;
				if (text2 == null)
				{
					break;
				}
				StreamReader streamReader = new StreamReader(text2);
				JsonTextReader jsonTextReader = new JsonTextReader(streamReader);
				int num2 = 0;
				LocalizationEntry[] array2 = JsonSerializer.CreateDefault().Deserialize<LocalizationEntry[]>(jsonTextReader);
				if (num < array2.Length)
				{
					long num3 = (long)num * 56L;
					int num4 = 0;
					DateTimeFormatInfo invariantInfo = DateTimeFormatInfo.InvariantInfo;
					if (!flag)
					{
						minValue = DateTime.MinValue;
					}
					Dictionary<string, StringTable.Entry> _003CStrings_003Ek__BackingField = stringTable.Strings;
					StringTable.Entry entry = new StringTable.Entry();
					entry.Text = (string)_003CText_003Ek__BackingField;
					entry.LastEdited = minValue;
					throw new NullReferenceException();
				}
				num++;
				if (jsonTextReader != null)
				{
				}
				if (jsonTextReader == null)
				{
					if (num != 0)
					{
					}
					if (streamReader != null)
					{
					}
					if (jsonTextReader == null)
					{
						break;
					}
				}
			}
			return stringTable;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x408D550", Offset = "0x408BF50", VA = "0x18408D550", Slot = "4")]
		IStringTable ITableProvider.GetTable(string tableName, CultureInfo culture)
		{
			StringTable table = GetTable(tableName, culture);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1BB5C80", Offset = "0x1BB4680", VA = "0x181BB5C80")]
		private string SerializeObject<T>(T value)
		{
			//Discarded unreachable code: IL_0053, IL_0059
			int num = 0;
			StringBuilder sb = new StringBuilder(256);
			int num2 = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			StringWriter stringWriter = new StringWriter(sb, invariantCulture);
			int num3 = 0;
			JsonSerializer jsonSerializer = JsonSerializer.CreateDefault();
			JsonTextWriter jsonTextWriter = new JsonTextWriter(stringWriter);
			jsonTextWriter.Formatting = Formatting.Indented;
			jsonTextWriter.Indentation = 1;
			if (jsonTextWriter != null)
			{
			}
			((IDisposable)stringWriter).Dispose();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x408C020", Offset = "0x408AA20", VA = "0x18408C020")]
		private JArray FluxOrderBy(JArray array)
		{
			Func<JToken, string> _003C_003E9__12_ = _003C_003Ec._003C_003E9__12_0;
			if (_003C_003E9__12_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(JToken o)
				{
					//Discarded unreachable code: IL_0017
					string text3 = (string?)o["dId"];
					if (text3 == null)
					{
					}
					return text3;
				};
			}
			IOrderedEnumerable<JToken> orderedEnumerable = (IOrderedEnumerable<JToken>)Enumerable.OrderBy<JToken, string>((IEnumerable<>)array, (Func<, >)(object)_003C_003E9__12_);
			Func<JToken, string> func = default(Func<JToken, string>);
			if (_003C_003Ec._003C_003E9__12_1 == null)
			{
				func = (Func<JToken, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(JToken o)
				{
					//Discarded unreachable code: IL_0017
					string text2 = (string?)o["Category"];
					if (text2 == null)
					{
					}
					return text2;
				});
			}
			IOrderedEnumerable<JToken> orderedEnumerable2 = (IOrderedEnumerable<JToken>)Enumerable.ThenBy<JToken, string>((IOrderedEnumerable<>)orderedEnumerable, (Func<, >)(object)func);
			Func<JToken, string> func2 = default(Func<JToken, string>);
			if (_003C_003Ec._003C_003E9__12_2 == null)
			{
				func2 = (Func<JToken, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(JToken o)
				{
					//Discarded unreachable code: IL_0017
					string text = (string?)o["Id"];
					if (text == null)
					{
					}
					return text;
				});
			}
			IOrderedEnumerable<JToken> orderedEnumerable3 = (IOrderedEnumerable<JToken>)Enumerable.ThenBy<JToken, string>((IOrderedEnumerable<>)orderedEnumerable2, (Func<, >)(object)func2);
			JArray result = default(JArray);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x408DD40", Offset = "0x408C740", VA = "0x18408DD40", Slot = "5")]
		void ITableProvider.SetJsonValue(LocId locId, CultureInfo culture, string newValue, string comment, string dId, string category, bool forceChangeDate)
		{
			//Discarded unreachable code: IL_01b4, IL_01ba, IL_01db, IL_01e1, IL_01f3, IL_01f9, IL_01ff, IL_0205
			IEnumerator<JToken> enumerator = default(IEnumerator<JToken>);
			JProperty jProperty = default(JProperty);
			string text2 = default(string);
			while (true)
			{
				int num = 0;
				string[] array = new string[0];
				string text = Path;
				StringReader stringReader;
				JsonTextReader jsonTextReader;
				if (text == null || array != null)
				{
					array[0] = text;
					if (array != null && ("_" == null || "_" != null))
					{
						array[2] = "_";
						string name = culture.Name;
						if (name == null || name != null)
						{
							array[3] = name;
							if (".json" == null || ".json" != null)
							{
								array[4] = ".json";
								string s = string.Concat(array);
								IFileSystem fileSystem = FileSystem;
								stringReader = new StringReader(s);
								jsonTextReader = new JsonTextReader(stringReader);
								JToken jToken = JToken.Load(jsonTextReader);
								int num2 = 0;
								if (enumerator == null)
								{
									goto IL_017a;
								}
								int num3 = 0;
								if (enumerator == null)
								{
									break;
								}
								int num4 = 0;
								if (enumerator == null)
								{
									throw new InvalidCastException();
								}
								int num5 = 0;
								string a = jProperty.Value.ToString();
								int num6 = 0;
								string _003CStringName_003Ek__BackingField = locId.StringName;
								if (!string.Equals(a, _003CStringName_003Ek__BackingField))
								{
									continue;
								}
								int num7 = 0;
								if (enumerator == null)
								{
									throw new InvalidCastException();
								}
								int num8 = 0;
								if (enumerator == null)
								{
									throw new InvalidCastException();
								}
								int num9 = 0;
								if (enumerator != null)
								{
									int num10 = 0;
									if (enumerator != null)
									{
										int num11 = 0;
										if (enumerator != null)
										{
											int num12 = 0;
											if (enumerator != null)
											{
												int num13 = 0;
												if (enumerator != null)
												{
													int num14 = 0;
													if (enumerator != null)
													{
														if (enumerator != null)
														{
															int num15 = 0;
															DateTime today = DateTime.Today;
															int num16 = 0;
															CultureInfo invariantCulture = CultureInfo.InvariantCulture;
															JToken jToken2 = text2;
															int num17 = 0;
															if (enumerator == null)
															{
																throw new InvalidCastException();
															}
															int num18 = 0;
															if (enumerator == null)
															{
																throw new InvalidCastException();
															}
														}
														goto IL_017a;
													}
													throw new InvalidCastException();
												}
												throw new InvalidCastException();
											}
											throw new InvalidCastException();
										}
										throw new InvalidCastException();
									}
								}
							}
						}
					}
				}
				throw new InvalidCastException();
				IL_017a:
				if (enumerator != null)
				{
				}
				if (jsonTextReader != null)
				{
				}
				if (stringReader == null)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x408C310", Offset = "0x408AD10", VA = "0x18408C310", Slot = "6")]
		void ITableProvider.AddJsonValue(LocId locId, CultureInfo culture, string newValue, string comment, string dId, string category)
		{
			//Discarded unreachable code: IL_0188, IL_01a3
			int num = 0;
			string[] array = new string[0];
			string text = Path;
			if (text == null || array != null)
			{
				array[0] = text;
				if (array != null && ("_" == null || "_" != null))
				{
					array[2] = "_";
					string name = culture.Name;
					if (name == null || name != null)
					{
						array[3] = name;
						if (".json" == null || ".json" != null)
						{
							array[4] = ".json";
							string text2 = string.Concat(array);
							JObject jObject = new JObject();
							JToken value = "";
							jObject.Add("dId", value);
							JToken value2 = locId.StringName;
							jObject.Add("Id", value2);
							JToken value3 = default(JToken);
							jObject.Add("Text", value3);
							JToken value4 = 0;
							jObject.Add("CharacterLimit", value4);
							JToken value5 = "";
							jObject.Add("Category", value5);
							JToken value6 = "";
							jObject.Add("Comment", value6);
							int num2 = 0;
							DateTime today = DateTime.Today;
							int num3 = 0;
							CultureInfo invariantCulture = CultureInfo.InvariantCulture;
							string text3 = default(string);
							JToken value7 = text3;
							jObject.Add("LastEdited", value7);
							IFileSystem fileSystem = FileSystem;
							StringReader stringReader = default(StringReader);
							JsonTextReader jsonTextReader = new JsonTextReader(stringReader);
							JArray.Load(jsonTextReader).Add(jObject);
							if (jsonTextReader != null)
							{
							}
							if (stringReader != null)
							{
							}
							new JArray().Add(jObject);
							int num4 = 0;
							return;
						}
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x408D560", Offset = "0x408BF60", VA = "0x18408D560", Slot = "7")]
		void ITableProvider.RemoveJsonValue(LocId locId, CultureInfo culture)
		{
			StringReader stringReader;
			JsonTextReader jsonTextReader;
			IEnumerator<JToken> enumerator;
			JProperty jProperty = default(JProperty);
			while (true)
			{
				int num = 0;
				string[] array = new string[0];
				string text = Path;
				if (text != null && array == null)
				{
					continue;
				}
				array[0] = text;
				if (array == null || ("_" != null && "_" == null))
				{
					continue;
				}
				array[2] = "_";
				string name = culture.Name;
				if (name != null && name == null)
				{
					continue;
				}
				array[3] = name;
				if (".json" != null && ".json" == null)
				{
					continue;
				}
				array[4] = ".json";
				string s = string.Concat(array);
				IFileSystem fileSystem = FileSystem;
				stringReader = new StringReader(s);
				jsonTextReader = new JsonTextReader(stringReader);
				JArray array2 = JArray.Load(jsonTextReader);
				JArray jArray = FluxOrderBy(array2);
				enumerator = (IEnumerator<JToken>)jArray.GetEnumerator();
				if (enumerator == null)
				{
					break;
				}
				int num2 = 0;
				if (enumerator == null)
				{
					continue;
				}
				int num3 = 0;
				if (enumerator == null)
				{
					continue;
				}
				int num4 = 0;
				string a = jProperty.Value.ToString();
				int num5 = 0;
				string _003CStringName_003Ek__BackingField = locId.StringName;
				if (!string.Equals(a, _003CStringName_003Ek__BackingField))
				{
					continue;
				}
				int num6 = 0;
				if (enumerator == null)
				{
					continue;
				}
				int num7 = 0;
				if (enumerator != null)
				{
					if (jArray.Count != 0)
					{
						string text2 = SerializeObject(jArray);
						IFileSystem fileSystem2 = FileSystem;
					}
					IFileSystem fileSystem3 = FileSystem;
					break;
				}
			}
			if (enumerator != null)
			{
			}
			if (jsonTextReader != null)
			{
			}
			if (stringReader == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x408CB40", Offset = "0x408B540", VA = "0x18408CB40", Slot = "8")]
		List<string> ITableProvider.GetJsonFileNames()
		{
			//Discarded unreachable code: IL_005f
			//IL_003b: Expected O, but got I4
			IFileSystem fileSystem = FileSystem;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			Func<string, bool> func = default(Func<string, bool>);
			if (_003C_003Ec._003C_003E9__16_0 == null)
			{
				func = (Func<string, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(string s)
				{
					//Discarded unreachable code: IL_0035
					List<string> list = (List<string>)(object)new List<T> { (T)".json" };
					string extension = System.IO.Path.GetExtension(s);
					bool flag = ((List<T>)(object)list).Contains((T)extension);
					return (!flag) ? flag : (!s.Contains("History"));
				});
			}
			IEnumerable<string> enumerable = (IEnumerable<string>)Enumerable.Where<string>((IEnumerable<>)num, (Func<, >)(object)func);
			Func<string, string> func2 = (Func<string, string>)(object)(Func<T, TResult>)delegate(string file)
			{
				//Discarded unreachable code: IL_0058
				string oldValue = Path;
				string text = file.Replace(oldValue, "");
				char[] array = new char[1];
				array[0] = '_';
				IEnumerable<string> enumerable2 = (IEnumerable<string>)Enumerable.Reverse<string>(Enumerable.Skip<string>(Enumerable.Reverse<string>((IEnumerable<>)(object)text.Split(array)), 1));
				return string.Join("_", (IEnumerable<>)enumerable2).Replace("\\", "/");
			};
			return (List<string>)(object)Enumerable.ToList<string>(Enumerable.Distinct<string>(Enumerable.Select<string, string>((IEnumerable<>)enumerable, (Func<, >)(object)func2)));
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x408CDE0", Offset = "0x408B7E0", VA = "0x18408CDE0", Slot = "9")]
		List<string> ITableProvider.GetJsonLocIds(string tableName, CultureInfo culture)
		{
			//Discarded unreachable code: IL_013a, IL_0146, IL_014c
			int num = 0;
			StringTable stringTable = new StringTable(tableName);
			string[] array = new string[0];
			string text = Path;
			List<string> list;
			JsonTextReader jsonTextReader;
			StringReader stringReader = default(StringReader);
			IEnumerator<JToken> enumerator = default(IEnumerator<JToken>);
			if (text == null || array != null)
			{
				array[0] = text;
				if (tableName == null || array != null)
				{
					array[1] = tableName;
					if ("_" == null || "_" != null)
					{
						array[2] = "_";
						string name = culture.Name;
						if (name == null || name != null)
						{
							array[3] = name;
							if (".json" == null || ".json" != null)
							{
								array[4] = ".json";
								string text2 = string.Concat(array);
								list = (List<string>)(object)new List<T>();
								IFileSystem fileSystem = FileSystem;
								if (list == null)
								{
									goto IL_0137;
								}
								IFileSystem fileSystem2 = FileSystem;
								jsonTextReader = new JsonTextReader(stringReader);
								int num2 = 0;
								JToken jToken = JToken.Load(jsonTextReader);
								int num3 = 0;
								int num4 = 0;
								if (enumerator == null)
								{
									goto IL_011c;
								}
								uint num5 = default(uint);
								if (num < (int)num5)
								{
									num += num;
									if (num != (int)num5)
									{
										num++;
									}
								}
								int num6 = 0;
								if (enumerator != null)
								{
									int num7 = 0;
									if (enumerator != null)
									{
										int num8 = 0;
										JProperty jProperty = default(JProperty);
										string item = jProperty.Value.ToString();
										((List<T>)(object)list).Add((T)item);
										goto IL_011c;
									}
								}
							}
						}
					}
				}
			}
			throw new InvalidCastException();
			IL_0137:
			return list;
			IL_011c:
			num++;
			if (enumerator != null)
			{
			}
			if (num != 0)
			{
			}
			if (jsonTextReader != null)
			{
			}
			if (num != 0)
			{
			}
			if (stringReader == null)
			{
			}
			goto IL_0137;
		}
	}
}
