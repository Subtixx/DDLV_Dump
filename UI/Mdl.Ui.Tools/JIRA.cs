using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Networking;

namespace Mdl.Ui.Tools
{
	[Cpp2IlInjected.Token(Token = "0x20008C9")]
	public static class JIRA
	{
		[Cpp2IlInjected.Token(Token = "0x20008CA")]
		private class Issue
		{
			[Cpp2IlInjected.Token(Token = "0x20008CB")]
			public class Fields
			{
				[Cpp2IlInjected.Token(Token = "0x20008CC")]
				public class ProjectField
				{
					[Cpp2IlInjected.Token(Token = "0x170007CD")]
					public string key
					{
						[Cpp2IlInjected.Token(Token = "0x6003761")]
						[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
						[CompilerGenerated]
						get
						{
							return null;
						}
						[Cpp2IlInjected.Token(Token = "0x6003762")]
						[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
						[CompilerGenerated]
						set
						{
						}
					}

					[Cpp2IlInjected.Token(Token = "0x6003763")]
					[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
					public ProjectField()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x20008CD")]
				public class SeverityField
				{
					[Cpp2IlInjected.Token(Token = "0x170007CE")]
					public string id
					{
						[Cpp2IlInjected.Token(Token = "0x6003764")]
						[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
						[CompilerGenerated]
						get
						{
							return null;
						}
						[Cpp2IlInjected.Token(Token = "0x6003765")]
						[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
						[CompilerGenerated]
						set
						{
						}
					}

					[Cpp2IlInjected.Token(Token = "0x6003766")]
					[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
					public SeverityField()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x20008CE")]
				public class ProbabilityField
				{
					[Cpp2IlInjected.Token(Token = "0x170007CF")]
					public string id
					{
						[Cpp2IlInjected.Token(Token = "0x6003767")]
						[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
						[CompilerGenerated]
						get
						{
							return null;
						}
						[Cpp2IlInjected.Token(Token = "0x6003768")]
						[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
						[CompilerGenerated]
						set
						{
						}
					}

					[Cpp2IlInjected.Token(Token = "0x6003769")]
					[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
					public ProbabilityField()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x20008CF")]
				public class IssueTypeField
				{
					[Cpp2IlInjected.Token(Token = "0x170007D0")]
					public string name
					{
						[Cpp2IlInjected.Token(Token = "0x600376A")]
						[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
						[CompilerGenerated]
						get
						{
							return null;
						}
						[Cpp2IlInjected.Token(Token = "0x600376B")]
						[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
						[CompilerGenerated]
						set
						{
						}
					}

					[Cpp2IlInjected.Token(Token = "0x600376C")]
					[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
					public IssueTypeField()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007C7")]
				public ProjectField project
				{
					[Cpp2IlInjected.Token(Token = "0x6003754")]
					[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003755")]
					[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007C8")]
				public string summary
				{
					[Cpp2IlInjected.Token(Token = "0x6003756")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003757")]
					[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007C9")]
				public string description
				{
					[Cpp2IlInjected.Token(Token = "0x6003758")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6003759")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007CA")]
				public SeverityField customfield_16934
				{
					[Cpp2IlInjected.Token(Token = "0x600375A")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600375B")]
					[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007CB")]
				public ProbabilityField customfield_16933
				{
					[Cpp2IlInjected.Token(Token = "0x600375C")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600375D")]
					[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170007CC")]
				public IssueTypeField issuetype
				{
					[Cpp2IlInjected.Token(Token = "0x600375E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
					[CompilerGenerated]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600375F")]
					[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
					[CompilerGenerated]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6003760")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public Fields()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170007C6")]
			public Fields fields
			{
				[Cpp2IlInjected.Token(Token = "0x6003751")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003Cfields_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6003752")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003Cfields_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6003753")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Issue()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20008D0")]
		public enum Priority
		{
			[Cpp2IlInjected.Token(Token = "0x4003495")]
			P0 = 1,
			[Cpp2IlInjected.Token(Token = "0x4003496")]
			P1,
			[Cpp2IlInjected.Token(Token = "0x4003497")]
			P2,
			[Cpp2IlInjected.Token(Token = "0x4003498")]
			P3,
			[Cpp2IlInjected.Token(Token = "0x4003499")]
			P4
		}

		[Cpp2IlInjected.Token(Token = "0x4003481")]
		private static Uri baseUri = new Uri("https://jira.gameloft.org/rest/api/2/");

		[Cpp2IlInjected.Token(Token = "0x4003482")]
		private static Uri createIssueUri;

		[Cpp2IlInjected.Token(Token = "0x4003483")]
		private static string username;

		[Cpp2IlInjected.Token(Token = "0x4003484")]
		private static string password;

		[Cpp2IlInjected.Token(Token = "0x4003485")]
		private static string projectKey;

		[Cpp2IlInjected.Token(Token = "0x4003486")]
		private static string issueType;

		[Cpp2IlInjected.Token(Token = "0x4003487")]
		public static readonly Dictionary<string, string> Probability;

		[Cpp2IlInjected.Token(Token = "0x4003488")]
		public static readonly Dictionary<string, string> Severity;

		[Cpp2IlInjected.Token(Token = "0x600374B")]
		[Cpp2IlInjected.Address(RVA = "0x1327760", Offset = "0x1326160", VA = "0x181327760")]
		private static UnityWebRequest CreateGetRequest(Uri url)
		{
			//Discarded unreachable code: IL_0053
			UnityWebRequest unityWebRequest = UnityWebRequest.Get(url);
			unityWebRequest.SetRequestHeader("Content-Type", "application/json");
			unityWebRequest.SetRequestHeader("Accept", "application/json");
			string text = password;
			string text2 = EncodeTo64(username, text);
			string value = "Basic " + text2;
			unityWebRequest.SetRequestHeader("Authorization", value);
			return unityWebRequest;
		}

		[Cpp2IlInjected.Token(Token = "0x600374C")]
		[Cpp2IlInjected.Address(RVA = "0x1327960", Offset = "0x1326360", VA = "0x181327960")]
		private static UnityWebRequest CreatePostRequest(Uri url, string content)
		{
			//Discarded unreachable code: IL_0071
			int num = 0;
			byte[] bytes = Encoding.UTF8.GetBytes(content);
			UnityWebRequest unityWebRequest = UnityWebRequest.Put(url, bytes);
			unityWebRequest.method = "POST";
			unityWebRequest.SetRequestHeader("Content-Type", "application/json");
			unityWebRequest.SetRequestHeader("Accept", "application/json");
			string text = password;
			string text2 = EncodeTo64(username, text);
			string value = "Basic " + text2;
			unityWebRequest.SetRequestHeader("Authorization", value);
			return unityWebRequest;
		}

		[Cpp2IlInjected.Token(Token = "0x600374D")]
		[Cpp2IlInjected.Address(RVA = "0x1327AE0", Offset = "0x13264E0", VA = "0x181327AE0")]
		private static UnityWebRequest CreatePostRequest(Uri url, byte[] content, byte[] boundary)
		{
			//Discarded unreachable code: IL_008b
			UnityWebRequest unityWebRequest = UnityWebRequest.Put(url, content);
			unityWebRequest.method = "POST";
			unityWebRequest.SetRequestHeader("X-Atlassian-Token", "no-check");
			int num = 0;
			string @string = Encoding.UTF8.GetString(boundary);
			string value = "multipart/form-data; boundary=" + @string;
			unityWebRequest.SetRequestHeader("Content-Type", value);
			unityWebRequest.SetRequestHeader("Accept", "application/json");
			string text = password;
			string text2 = EncodeTo64(username, text);
			string value2 = "Basic " + text2;
			unityWebRequest.SetRequestHeader("Authorization", value2);
			return unityWebRequest;
		}

		[Cpp2IlInjected.Token(Token = "0x600374E")]
		[Cpp2IlInjected.Address(RVA = "0x1327880", Offset = "0x1326280", VA = "0x181327880")]
		[IteratorStateMachine(typeof(_003CCreateIssueCoroutine_003Ed__13))]
		public static IEnumerator CreateIssueCoroutine(string inSummary, string inDescription, Texture2D texture, string inSeverity, string inProbability)
		{
			//IL_002c: Expected O, but got I4
			int _003C_003E1__state = default(int);
			_003CCreateIssueCoroutine_003Ed__13 _003CCreateIssueCoroutine_003Ed__ = new _003CCreateIssueCoroutine_003Ed__13(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCreateIssueCoroutine_003Ed__.inSummary = inSummary;
			_003CCreateIssueCoroutine_003Ed__.inDescription = inDescription;
			_003CCreateIssueCoroutine_003Ed__.texture = texture;
			_003CCreateIssueCoroutine_003Ed__.inSeverity = inSeverity;
			_003CCreateIssueCoroutine_003Ed__.inProbability = (string)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600374F")]
		[Cpp2IlInjected.Address(RVA = "0x1327CB0", Offset = "0x13266B0", VA = "0x181327CB0")]
		private static string EncodeTo64(string username, string password)
		{
			//Discarded unreachable code: IL_0025
			Encoding encoding = Encoding.GetEncoding("UTF-8");
			string s = username + ":" + password;
			return Convert.ToBase64String(encoding.GetBytes(s));
		}

		[Cpp2IlInjected.Token(Token = "0x6003750")]
		[Cpp2IlInjected.Address(RVA = "0x1327D80", Offset = "0x1326780", VA = "0x181327D80")]
		static JIRA()
		{
			//Discarded unreachable code: IL_0069, IL_006f, IL_0075, IL_007b, IL_008d, IL_0093, IL_0099, IL_009f, IL_00a5, IL_00ab
			//IL_002b: Expected O, but got I4
			Uri uri = baseUri;
			if ((object)uri != null)
			{
				string text = uri.ToString();
			}
			baseUri = new Uri((string)0 + "issue/");
			baseUri = (Uri)(object)"MDL-Jira-Robot";
			baseUri = (Uri)(object)"toboR-ariJ-LDM";
			baseUri = (Uri)(object)"MDL";
			baseUri = (Uri)(object)"Bug";
			Dictionary<string, string> dictionary = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}
	}
}
