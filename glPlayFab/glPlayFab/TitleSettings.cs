using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public class TitleSettings
	{
		[Cpp2IlInjected.Token(Token = "0x17000136")]
		[JsonConverter(typeof(StringEnumConverter))]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000363")]
		public OnlineEnvironment? Environment
		{
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AB0", Offset = "0x6E44B0", VA = "0x1806E5AB0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		public string LatestGameVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CLatestGameVersion_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CLatestGameVersion_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public string VersionMandatory
		{
			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CVersionMandatory_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CVersionMandatory_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public string VersionOptional
		{
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CVersionOptional_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CVersionOptional_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4000367")]
		public bool? Maintenance
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x14F8C90", Offset = "0x14F7690", VA = "0x1814F8C90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x14F8CA0", Offset = "0x14F76A0", VA = "0x1814F8CA0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		public string MaintenanceTitle
		{
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CMaintenanceTitle_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CMaintenanceTitle_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		public string MaintenanceDesc
		{
			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CMaintenanceDesc_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			set
			{
				_003CMaintenanceDesc_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		public string UpdateTitle
		{
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CUpdateTitle_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			set
			{
				_003CUpdateTitle_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		public string UpdateMandatoryDesc
		{
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CUpdateMandatoryDesc_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			set
			{
				_003CUpdateMandatoryDesc_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		public string UpdateOptionalDesc
		{
			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CUpdateOptionalDesc_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			set
			{
				_003CUpdateOptionalDesc_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		public List<string> KillVersions
		{
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CKillVersions_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			set
			{
				_003CKillVersions_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public List<OverrideEntry> Override
		{
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			[CompilerGenerated]
			get
			{
				return _003COverride_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			[CompilerGenerated]
			set
			{
				_003COverride_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x14F8490", Offset = "0x14F6E90", VA = "0x1814F8490")]
		public TitleSettings Clone()
		{
			//Discarded unreachable code: IL_00b2
			TitleSettings titleSettings = new TitleSettings();
			OnlineEnvironment? onlineEnvironment = (titleSettings.Environment = Environment);
			string text = (titleSettings.VersionMandatory = VersionMandatory);
			string text2 = (titleSettings.VersionOptional = VersionOptional);
			bool? flag = (titleSettings.Maintenance = Maintenance);
			string text3 = (titleSettings.MaintenanceTitle = MaintenanceTitle);
			string text4 = (titleSettings.MaintenanceDesc = MaintenanceDesc);
			string text5 = (titleSettings.UpdateTitle = UpdateTitle);
			string text6 = (titleSettings.UpdateMandatoryDesc = UpdateMandatoryDesc);
			string text7 = (titleSettings.UpdateOptionalDesc = UpdateOptionalDesc);
			List<string> list = (titleSettings.KillVersions = KillVersions);
			List<OverrideEntry> list2 = (titleSettings.Override = Override);
			return titleSettings;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x14F89F0", Offset = "0x14F73F0", VA = "0x1814F89F0")]
		public TitleSettings Resolve(List<TitleParam> titleInfo)
		{
			//Discarded unreachable code: IL_013b
			//IL_0137: Expected O, but got I4
			if ((long)Override != 0)
			{
				TitleSettings titleSettings = new TitleSettings();
				OnlineEnvironment? onlineEnvironment = (titleSettings.Environment = Environment);
				string text = (titleSettings.VersionMandatory = VersionMandatory);
				string text2 = (titleSettings.VersionOptional = VersionOptional);
				bool? flag = (titleSettings.Maintenance = Maintenance);
				string text3 = (titleSettings.MaintenanceTitle = MaintenanceTitle);
				string text4 = (titleSettings.MaintenanceDesc = MaintenanceDesc);
				string text5 = (titleSettings.UpdateTitle = UpdateTitle);
				string text6 = (titleSettings.UpdateMandatoryDesc = UpdateMandatoryDesc);
				string text7 = (titleSettings.UpdateOptionalDesc = UpdateOptionalDesc);
				List<string> list = (titleSettings.KillVersions = KillVersions);
				List<OverrideEntry> list2 = (titleSettings.Override = Override);
				PropertyInfo[] properties = typeof(TitleSettings).GetProperties();
				int num = 0;
				int length = properties.Length;
				if (num < length)
				{
					PropertyInfo propertyInfo = properties[num];
					if (!string.Equals(propertyInfo.Name, "Override"))
					{
						string name = propertyInfo.Name;
						object overrideValue = this.GetOverrideValue((object)this, "Override", name, (List<>)(object)titleInfo);
						if (overrideValue != null)
						{
							propertyInfo.SetValue(titleSettings, overrideValue);
						}
					}
					num++;
				}
				titleSettings.Override = (List<OverrideEntry>)num;
				return titleSettings;
			}
			return this;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x14F8590", Offset = "0x14F6F90", VA = "0x1814F8590")]
		private object GetOverrideValue(object curObj, string overridePropName, string propName, List<TitleParam> overrideKeys)
		{
			//Discarded unreachable code: IL_00c2, IL_00c8
			//IL_000f: Expected O, but got I4
			int num = 0;
			List<TitleParam> overrideKeys2 = (List<TitleParam>)0;
			if (curObj != null)
			{
				PropertyInfo property = curObj.GetType().GetProperty(propName);
				if ((object)property != null)
				{
					object value = property.GetValue(curObj);
				}
			}
			IEnumerable<OverrideEntry> enumerable2;
			object obj = default(object);
			if (curObj != null)
			{
				PropertyInfo property2 = curObj.GetType().GetProperty(overridePropName);
				if ((object)property2 != null)
				{
					object value2 = property2.GetValue(curObj);
					if (value2 != null)
					{
						int num2 = 0;
						if (value2 != null)
						{
							Func<OverrideEntry, bool> func = (Func<OverrideEntry, bool>)(object)(Func<T, TResult>)delegate(OverrideEntry x)
							{
								//Discarded unreachable code: IL_0029
								List<TitleParam> cpp2il__autoParamName__idx_ = overrideKeys2;
								Func<TitleParam, bool> cpp2il__autoParamName__idx_2 = (Func<TitleParam, bool>)(object)(Func<T, TResult>)delegate(TitleParam y)
								{
									//IL_002d: Expected O, but got I4
									string _003CMatcherType_003Ek__BackingField = x.MatcherType;
									if ((object)typeof(MatcherType).TypeHandle == null)
									{
										string _003CMatcherType_003Ek__BackingField2 = x.MatcherType;
										MatcherType matcherType = y.MatcherType;
										string b = ((Enum)matcherType).ToString();
										MatcherType matcherType2 = matcherType;
										if (string.Equals(_003CMatcherType_003Ek__BackingField2, b))
										{
											string _003CMatcher_003Ek__BackingField = x.Matcher;
											return y.IsMatch(_003CMatcher_003Ek__BackingField);
										}
									}
									int num4 = 0;
									throw new NullReferenceException();
								};
								return ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<TitleParam>((Func<, >)(object)cpp2il__autoParamName__idx_2);
							};
							Func<OverrideEntry, TitleSettings> func2 = default(Func<OverrideEntry, TitleSettings>);
							if (_003C_003Ec._003C_003E9__50_1 == null)
							{
								func2 = (Func<OverrideEntry, TitleSettings>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((OverrideEntry x) => x.Settings));
							}
							IEnumerable<OverrideEntry> enumerable = default(IEnumerable<OverrideEntry>);
							enumerable2 = (IEnumerable<OverrideEntry>)Enumerable.Select<OverrideEntry, TitleSettings>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
							if (enumerable2 != null)
							{
								uint num3 = default(uint);
								if (num < (int)num3)
								{
									num += num;
									if (num == (int)num3)
									{
										goto IL_00b6;
									}
									num++;
								}
								while (obj == null)
								{
								}
								goto IL_00b6;
							}
							goto IL_00ba;
						}
					}
				}
			}
			goto IL_00bf;
			IL_00bf:
			return obj;
			IL_00ba:
			if (enumerable2 == null)
			{
			}
			goto IL_00bf;
			IL_00b6:
			num += num;
			goto IL_00ba;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TitleSettings()
		{
		}
	}
}
