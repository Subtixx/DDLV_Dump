using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;
using Gameloft.Tracking.Service;
using Gameloft.Tracking.Storage;
using Gameloft.Tracking.Utils;

namespace Gameloft.Tracking.Pipeline.Standard.Service
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class JsonHttpRequestCreator : HttpRequestCreator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly MediaTypeHeaderValue contentType = new MediaTypeHeaderValue("application/json");

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private ArraySegment<byte> jsonPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private string packageSha1;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x28C2720", Offset = "0x28C1120", VA = "0x1828C2720")]
		public JsonHttpRequestCreator(ServiceOptions options)
		{
			//Discarded unreachable code: IL_0027
			int num = (base.MaxEventsPerPackage = options.maxNumberOfEventsPerPackage);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x28C2160", Offset = "0x28C0B60", VA = "0x1828C2160", Slot = "8")]
		public override void Build(OnlineEnvironment env, IEventsSelection selection, Session session)
		{
			//Discarded unreachable code: IL_0027, IL_0044
			//IL_001f: Expected O, but got I4
			EventScope _003CEventScope_003Ek__BackingField = env.EventScope;
			Dictionary<string, object> _003CPayload_003Ek__BackingField = ((Package)base.EventPackage).Payload;
			int num = default(int);
			string text = $"HTTP/{num}";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x28C22E0", Offset = "0x28C0CE0", VA = "0x1828C22E0", Slot = "7")]
		public override HttpRequestMessage CreateRequest()
		{
			//Discarded unreachable code: IL_0117
			OnlineEnvironment onlineEnvironment = base.Environment;
			HttpRequestMessage httpRequestMessage = default(HttpRequestMessage);
			ByteArrayContent _003CContent_003Ek__BackingField = default(ByteArrayContent);
			httpRequestMessage.Content = _003CContent_003Ek__BackingField;
			Version version2 = (httpRequestMessage.Version = HttpVersion.Version11);
			HttpContentHeaders headers = httpRequestMessage.Content.Headers;
			MediaTypeHeaderValue mediaTypeHeaderValue2 = (headers.ContentType = contentType);
			HttpRequestHeaders headers2 = httpRequestMessage.Headers;
			headers2.Add("User-Agent", "GLOTv3");
			string value = packageSha1;
			headers2.Add("X-ETS-sha1", value);
			object pthis = ((Dictionary<TKey, TValue>)(object)((Package)base.EventPackage).Payload)[(TKey)"ggid"];
			int defValue = 0;
			uint num = pthis.As((uint)defValue);
			int num2 = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string value2 = default(string);
			headers2.Add("X-ETS-ggi", value2);
			object pthis2 = ((Dictionary<TKey, TValue>)(object)((Package)base.EventPackage).Payload)[(TKey)"ver"];
			string empty = string.Empty;
			string value3 = pthis2.As(empty);
			headers2.Add("X-ETS-ver", value3);
			object pthis3 = ((Dictionary<TKey, TValue>)(object)((Package)base.EventPackage).Payload)[(TKey)"platform"];
			string empty2 = string.Empty;
			string value4 = pthis3.As(empty2);
			headers2.Add("X-ETS-platform", value4);
			return httpRequestMessage;
		}
	}
}
