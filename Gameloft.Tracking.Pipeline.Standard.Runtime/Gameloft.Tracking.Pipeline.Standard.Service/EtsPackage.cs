using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Cpp2IlInjected;
using Gameloft.Tracking.Pipeline.Standard.Events;
using Gameloft.Tracking.Serialization.Json;
using Gameloft.Tracking.Service;
using Newtonsoft.Json;

namespace Gameloft.Tracking.Pipeline.Standard.Service
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[JsonConverter(typeof(JsonPackageConverter))]
	internal sealed class EtsPackage : Package
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x28BFFA0", Offset = "0x28BE9A0", VA = "0x1828BFFA0")]
		public EtsPackage(IEnumerable<StandardEvent> events, Session session, int maxEvents = int.MaxValue)
		{
			//Discarded unreachable code: IL_004f
			IEnumerable<StandardEvent> enumerable = (IEnumerable<StandardEvent>)Enumerable.Take<StandardEvent>((IEnumerable<>)events, maxEvents);
			Func<StandardEvent, EventData> _003C_003E9__2_ = _003C_003Ec._003C_003E9__2_0;
			if (_003C_003E9__2_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((StandardEvent e) => e.EventData);
			}
			List<EventData> list = (List<EventData>)(base.Events = (IReadOnlyCollection<object>)Enumerable.ToList<EventData>(Enumerable.Select<StandardEvent, EventData>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__2_)));
			Initialize();
			InitializeSessionInfo(session);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x28BFCD0", Offset = "0x28BE6D0", VA = "0x1828BFCD0")]
		public EtsPackage SetupPayload(IReadOnlyDictionary<string, object> parameters)
		{
			//Discarded unreachable code: IL_0055, IL_005b
			int num = 0;
			IEnumerable<KeyValuePair<string, object>> enumerable;
			if (parameters != null)
			{
				Func<KeyValuePair<string, object>, bool> _003C_003E9__3_ = _003C_003Ec._003C_003E9__3_0;
				if (_003C_003E9__3_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				enumerable = (IEnumerable<KeyValuePair<string, object>>)Enumerable.Where<KeyValuePair<string, object>>((IEnumerable<>)parameters, (Func<, >)(object)_003C_003E9__3_);
				if (enumerable != null)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							goto IL_004f;
						}
						num++;
					}
					Dictionary<string, object> dictionary = base.Payload;
					throw new NullReferenceException();
				}
				goto IL_004f;
			}
			goto IL_0053;
			IL_0053:
			return this;
			IL_004f:
			if (enumerable == null)
			{
			}
			goto IL_0053;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x28BFA00", Offset = "0x28BE400", VA = "0x1828BFA00")]
		private void Initialize()
		{
			//Discarded unreachable code: IL_0026, IL_0034, IL_0055, IL_006c, IL_006d
			Dictionary<string, object> dictionary = base.Payload;
			Guid guid = Guid.NewGuid();
			int num = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text = default(string);
			string text2 = text.ToUpper(invariantCulture);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28BF7C0", Offset = "0x28BE1C0", VA = "0x1828BF7C0")]
		private void InitializeSessionInfo(Session session)
		{
			//Discarded unreachable code: IL_0019, IL_0035, IL_004b, IL_0066, IL_007c, IL_0092, IL_0093
			Dictionary<string, object> dictionary = base.Payload;
			string clientId = session.ClientVersion.ClientId;
			throw new NullReferenceException();
		}
	}
}
