using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using ComponentAce.Compression.Libs.zlib;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;
using Gameloft.Tracking.Pipeline.Standard.Serialization.Binary;
using Gameloft.Tracking.Service;
using Gameloft.Tracking.Storage;

namespace Gameloft.Tracking.Pipeline.Standard.Service
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class BinaryHttpRequestCreator : HttpRequestCreator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly MediaTypeHeaderValue contentType = new MediaTypeHeaderValue("application/gl-stream");

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly BinaryFormatter formatter = new BinaryFormatter();

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private ArraySegment<byte> binaryPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private string packageSha1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28BD920", Offset = "0x28BC320", VA = "0x1828BD920")]
		public BinaryHttpRequestCreator(ServiceOptions options)
		{
			//Discarded unreachable code: IL_0034
			int num = (base.MaxEventsPerPackage = options.maxNumberOfEventsPerPackage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28BCF10", Offset = "0x28BB910", VA = "0x1828BCF10", Slot = "8")]
		public override void Build(OnlineEnvironment env, IEventsSelection selection, Session session)
		{
			//Discarded unreachable code: IL_0029, IL_00da, IL_00db, IL_00e1, IL_00e7
			//IL_0021: Expected O, but got I4
			int num = 0;
			EventScope _003CEventScope_003Ek__BackingField = env.EventScope;
			Dictionary<string, object> _003CPayload_003Ek__BackingField = ((Package)base.EventPackage).Payload;
			int num2 = default(int);
			string text = $"Binary/{num2}";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x28BD400", Offset = "0x28BBE00", VA = "0x1828BD400", Slot = "7")]
		public override HttpRequestMessage CreateRequest()
		{
			//Discarded unreachable code: IL_0067
			OnlineEnvironment onlineEnvironment = base.Environment;
			Uri requestUri = default(Uri);
			HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.post_method, requestUri);
			ByteArrayContent _003CContent_003Ek__BackingField = default(ByteArrayContent);
			httpRequestMessage.Content = _003CContent_003Ek__BackingField;
			Version version2 = (httpRequestMessage.Version = HttpVersion.Version11);
			HttpContentHeaders headers = httpRequestMessage.Content.Headers;
			MediaTypeHeaderValue mediaTypeHeaderValue2 = (headers.ContentType = contentType);
			HttpRequestHeaders headers2 = httpRequestMessage.Headers;
			string value = packageSha1;
			headers2.Add("X-ETS-sha1", value);
			return httpRequestMessage;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x28BD7A0", Offset = "0x28BC1A0", VA = "0x1828BD7A0")]
		private ArraySegment<byte> SerializePackage()
		{
			//Discarded unreachable code: IL_002b
			int num = 0;
			MemoryStream memoryStream = new MemoryStream(4096);
			ZOutputStream zOutputStream = new ZOutputStream(memoryStream, 9);
			object obj = zOutputStream.InitializeLifetimeService();
			if (zOutputStream != null)
			{
			}
			if (memoryStream != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x28BD670", Offset = "0x28BC070", VA = "0x1828BD670")]
		private static PlatformID PlatformStringToID(string splatform)
		{
			//Discarded unreachable code: IL_0023
			int num = 0;
			if (!string.IsNullOrEmpty(splatform))
			{
				object obj = Enum.Parse(typeof(PlatformID), splatform, ignoreCase: true);
			}
			throw new NullReferenceException();
		}
	}
}
