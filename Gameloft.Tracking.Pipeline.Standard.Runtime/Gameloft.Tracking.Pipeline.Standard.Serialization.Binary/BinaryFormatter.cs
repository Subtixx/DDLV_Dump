using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Cpp2IlInjected;
using Gameloft.Tracking.Pipeline.Standard.Events;
using Gameloft.Tracking.Pipeline.Standard.Service;
using Gameloft.Tracking.Serialization;
using Gameloft.Tracking.Service;
using Gameloft.Tracking.Utils;
using Polly;

namespace Gameloft.Tracking.Pipeline.Standard.Serialization.Binary
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class BinaryFormatter : TrackerFormatter
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum Types
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			Unknown = 0,
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			Chksum = 1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			EventData = 2,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Byte = 3,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Boolean = 4,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Short = 5,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			UShort = 6,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			Int = 7,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			UInt = 8,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			Int64 = 9,
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			Uint64 = 10,
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			Long = 11,
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			ULong = 12,
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			LLong = 13,
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			ULLong = 14,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			Float = 15,
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			Double = 16,
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			String = 17,
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			Map = 18,
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			Package = 19,
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			PackageInfo = 20,
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			EventInfo = 31
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private struct Tag
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public ushort ofType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public ushort ofSize;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x26727A0", Offset = "0x26711A0", VA = "0x1826727A0")]
			public Tag(Types type, ushort size)
			{
				ofType = (ushort)type;
				ofSize = size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x28B7FD0", Offset = "0x28B69D0", VA = "0x1828B7FD0", Slot = "4")]
		public override void Deserialize(Stream stream, object graph)
		{
			//Discarded unreachable code: IL_003d, IL_0043
			do
			{
				int num = 0;
			}
			while (graph == null || graph == null);
			NetworkByteOrderBinaryReader networkByteOrderBinaryReader = default(NetworkByteOrderBinaryReader);
			networkByteOrderBinaryReader.Dispose();
			if (stream != null)
			{
				networkByteOrderBinaryReader.stream = stream;
				byte[] array = (networkByteOrderBinaryReader.buffer = new byte[16]);
				if (graph != null)
				{
				}
				if (graph != null)
				{
					if (networkByteOrderBinaryReader == null)
					{
					}
					return;
				}
				throw new NullReferenceException();
			}
			ArgumentNullException ex = new ArgumentNullException("stream");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x28B9FD0", Offset = "0x28B89D0", VA = "0x1828B9FD0", Slot = "5")]
		public override void Serialize(Stream stream, object graph)
		{
			NetworkByteOrderBinaryWriter networkByteOrderBinaryWriter = default(NetworkByteOrderBinaryWriter);
			networkByteOrderBinaryWriter.Dispose();
			if (stream != null)
			{
				networkByteOrderBinaryWriter.stream = stream;
				WriteObject(networkByteOrderBinaryWriter, graph);
				if (networkByteOrderBinaryWriter == null)
				{
				}
				return;
			}
			ArgumentNullException ex = new ArgumentNullException("stream");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x28B7FB0", Offset = "0x28B69B0", VA = "0x1828B7FB0")]
		private static Tag DecodeTag(byte byteToDecode)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28B9050", Offset = "0x28B7A50", VA = "0x1828B9050")]
		public static void ReadEventObject(NetworkByteOrderBinaryReader reader, object graph)
		{
			//Discarded unreachable code: IL_0014, IL_0021
			if (graph != null && (graph != null || graph != null))
			{
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28B96B0", Offset = "0x28B80B0", VA = "0x1828B96B0")]
		public static object ReadObject(NetworkByteOrderBinaryReader reader)
		{
			ulong num4 = default(ulong);
			ulong num8 = default(ulong);
			int num14;
			int num13;
			do
			{
				reader.ReadToCacheBuffer(1);
				byte[] buffer = reader.buffer;
				EventData eventData = ReadEventDataUntagged(reader);
				byte b = reader.ReadByte();
				uint num = reader.ReadUInt32();
				reader.ReadToCacheBuffer(2);
				byte[] buffer2 = reader.buffer;
				int length = buffer2.Length;
				byte b2 = buffer2[0];
				reader.ReadToCacheBuffer(2);
				byte[] buffer3 = reader.buffer;
				int length2 = buffer3.Length;
				byte b3 = buffer3[0];
				int num2 = 0;
				int num3 = 0;
				reader.ReadToCacheBuffer(1);
				byte b4 = reader.buffer[0];
				if (num4 == 0)
				{
					num2 += 7;
				}
				num2 += 6;
				uint num5 = reader.ReadUInt32();
				int num6 = 0;
				int num7 = 0;
				reader.ReadToCacheBuffer(1);
				byte b5 = reader.buffer[0];
				if (num8 == 0)
				{
					num6 += 7;
				}
				num6 += 6;
				int num9 = 0;
				reader.ReadToCacheBuffer(1);
				byte b6 = reader.buffer[0];
				num9 += 7;
				reader.ReadToCacheBuffer(4);
				byte[] buffer4 = reader.buffer;
				int index = 0;
				Array.Reverse((Array)buffer4, index, 4);
				byte[] buffer5 = reader.buffer;
				int startIndex = 0;
				float num10 = BitConverter.ToSingle(buffer5, startIndex);
				reader.ReadToCacheBuffer(8);
				byte[] buffer6 = reader.buffer;
				int index2 = 0;
				Array.Reverse((Array)buffer6, index2, 8);
				byte[] buffer7 = reader.buffer;
				int startIndex2 = 0;
				double num11 = BitConverter.ToDouble(buffer7, startIndex2);
				uint num12 = reader.ReadUInt32();
				num13 = 0;
				byte[] buffer8 = new byte[num12];
				Stream stream = reader.stream;
				num12 -= (uint)num13;
				num14 = stream.Read(buffer8, num13, (int)num12);
			}
			while (num14 == 0);
			num13 += num14;
			IDictionary dictionary = ReadMapUntagged(reader);
			StandardEvent standardEvent = ReadEventInfoUntagged(reader);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28B9EF0", Offset = "0x28B88F0", VA = "0x1828B9EF0")]
		private static uint ReadUInt32(NetworkByteOrderBinaryReader reader)
		{
			//Discarded unreachable code: IL_001b, IL_0021
			reader.ReadToCacheBuffer(1);
			byte b = reader.buffer[0];
			return reader.ReadUInt32();
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28B8A70", Offset = "0x28B7470", VA = "0x1828B8A70")]
		private static StandardEvent ReadEventInfoUntagged(NetworkByteOrderBinaryReader reader)
		{
			//Discarded unreachable code: IL_0057
			//IL_001e: Expected O, but got I4
			//IL_002b: Expected I4, but got O
			//IL_0039: Expected I4, but got O
			IDictionary dictionary = ReadMap(reader);
			StandardEvent standardEvent = new StandardEvent();
			int num = 0;
			if (standardEvent == null || standardEvent != null)
			{
				standardEvent.EventData = (EventData)num;
				int num2 = 0;
				StandardEvent standardEvent2 = standardEvent;
				standardEvent.Priority = (EventPriority)standardEvent2;
				int num3 = 0;
				StandardEvent standardEvent3 = standardEvent;
				standardEvent.BatchSize = (uint)(int)standardEvent3;
				StandardEvent standardEvent4 = standardEvent;
				int num4 = 0;
				Dictionary<, >.ValueCollection valueCollection = default(Dictionary<, >.ValueCollection);
				List<string> list = (standardEvent.SmartBatchProperties = (List<string>)(object)Enumerable.ToList<string>(Enumerable.Cast<string>((IEnumerable)valueCollection)));
				return standardEvent;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28B8D10", Offset = "0x28B7710", VA = "0x1828B8D10")]
		private static void ReadEventInfo(NetworkByteOrderBinaryReader reader, StandardEvent e)
		{
			//IL_002c: Expected O, but got I4
			//IL_0039: Expected I4, but got O
			//IL_0047: Expected I4, but got O
			reader.ReadToCacheBuffer(1);
			byte b = reader.buffer[0];
			IDictionary dictionary = ReadMap(reader);
			int num = 0;
			if (dictionary == null || dictionary != null)
			{
				e.EventData = (EventData)num;
				int num2 = 0;
				IDictionary dictionary2 = dictionary;
				e.Priority = (EventPriority)dictionary2;
				int num3 = 0;
				IDictionary dictionary3 = dictionary;
				e.BatchSize = (uint)(int)dictionary3;
				IDictionary dictionary4 = dictionary;
				int num4 = 0;
				Dictionary<, >.ValueCollection valueCollection = default(Dictionary<, >.ValueCollection);
				List<string> list = (e.SmartBatchProperties = (List<string>)(object)Enumerable.ToList<string>(Enumerable.Cast<string>((IEnumerable)valueCollection)));
				throw new NullReferenceException();
			}
			string message = default(string);
			InvalidDataException ex = new InvalidDataException(message);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28B82C0", Offset = "0x28B6CC0", VA = "0x1828B82C0")]
		private static EventData ReadEventDataUntagged(NetworkByteOrderBinaryReader reader)
		{
			//Discarded unreachable code: IL_006e
			//IL_0046: Expected I4, but got O
			//IL_0055: Expected I4, but got O
			IDictionary dictionary = ReadMap(reader);
			EventData eventData = new EventData();
			if (dictionary == null)
			{
			}
			int num = 0;
			int num2 = 0;
			DateTime dateTime = (eventData.TimeStamp = DateTime.UtcNow);
			DateTime dateTime2 = default(DateTime);
			eventData.TimeStampLocal = dateTime2;
			if (dictionary != null)
			{
				eventData.UserData = (Dictionary<string, object>)dictionary;
				int num3 = 0;
				DateTime dateTime3 = dateTime2;
				eventData.Type = (int)dateTime3;
				int num4 = 0;
				DateTime dateTime4 = dateTime2;
				eventData.Token = (int)dateTime4;
				DateTime dateTime5 = default(DateTime);
				eventData.TimeStamp = dateTime5;
				int num5 = 0;
				DateTime dateTime6 = dateTime5;
				DateTime _003CTimeStampLocal_003Ek__BackingField = default(DateTime);
				eventData.TimeStampLocal = _003CTimeStampLocal_003Ek__BackingField;
				return eventData;
			}
			ArgumentNullException ex = new ArgumentNullException("userData");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28B86A0", Offset = "0x28B70A0", VA = "0x1828B86A0")]
		private static void ReadEventData(NetworkByteOrderBinaryReader reader, EventData data)
		{
			//Discarded unreachable code: IL_005e, IL_0064
			reader.ReadToCacheBuffer(1);
			byte b = reader.buffer[0];
			IDictionary dictionary = ReadMap(reader);
			int num = 0;
			if (dictionary == null)
			{
			}
			int num2 = 0;
			data.UserData = (Dictionary<string, object>)dictionary;
			int num3 = 0;
			int num4 = (data.Type = num2);
			int num5 = 0;
			int num6 = (data.Token = num2);
			DateTime dateTime = default(DateTime);
			data.TimeStamp = dateTime;
			int num7 = 0;
			DateTime dateTime2 = dateTime;
			DateTime _003CTimeStampLocal_003Ek__BackingField = default(DateTime);
			data.TimeStampLocal = _003CTimeStampLocal_003Ek__BackingField;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x28B95D0", Offset = "0x28B7FD0", VA = "0x1828B95D0")]
		private static IDictionary ReadMap(NetworkByteOrderBinaryReader reader)
		{
			//Discarded unreachable code: IL_001b, IL_0021
			reader.ReadToCacheBuffer(1);
			byte b = reader.buffer[0];
			return ReadMapUntagged(reader);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x28B9180", Offset = "0x28B7B80", VA = "0x1828B9180")]
		private static IDictionary ReadMapUntagged(NetworkByteOrderBinaryReader reader)
		{
			reader.ReadToCacheBuffer(1);
			byte b = reader.buffer[0];
			uint num = reader.ReadUInt32();
			int num2 = 0;
			if ((int)num > 0)
			{
				object obj = ReadObject(reader);
				object obj2 = ReadObject(reader);
				if (num2 == 0)
				{
					Type typeFromHandle = typeof(Dictionary<, >);
					Type[] array = new Type[2];
					Type type = obj.GetType();
					if ((object)type == null || (object)type != null)
					{
						array[0] = type;
						Type typeFromHandle2 = typeof(object);
						if ((object)typeFromHandle2 == null || (object)typeFromHandle2 != null)
						{
							array[1] = typeFromHandle2;
							Type type2 = typeFromHandle.MakeGenericType(array);
							object[] array2 = new object[1];
							if (array2 == null || array2 != null)
							{
								array2[0] = array2;
								if (Activator.CreateInstance(type2, array2) != null)
								{
									goto IL_00c1;
								}
							}
						}
					}
					throw new InvalidCastException();
				}
				goto IL_00c1;
			}
			goto IL_00c9;
			IL_00d0:
			throw new NullReferenceException();
			IL_00c1:
			if (num2 + 1 == 0)
			{
				goto IL_00c9;
			}
			goto IL_00d0;
			IL_00c9:
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			goto IL_00d0;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28B82B0", Offset = "0x28B6CB0", VA = "0x1828B82B0")]
		private static byte EncodeTag(Tag tagToEncode)
		{
			ushort ofType = tagToEncode.ofType;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x28BB7A0", Offset = "0x28BA1A0", VA = "0x1828BB7A0")]
		private static void WriteObject(NetworkByteOrderBinaryWriter writer, object asObject)
		{
			//Discarded unreachable code: IL_0174, IL_017a, IL_019c, IL_01a2, IL_01a8, IL_01ae, IL_01b4, IL_01ba, IL_01c0
			//IL_00a6: Expected I4, but got I8
			//IL_00bb: Expected I4, but got I8
			//IL_00cb: Expected I4, but got I8
			//IL_00db: Expected I4, but got I8
			//IL_00ff: Expected I8, but got I4
			//IL_010c: Expected I4, but got I8
			//IL_0121: Expected I4, but got I8
			//IL_0164: Expected I4, but got I8
			if (asObject == null)
			{
				WriteString(writer, "N/A");
				return;
			}
			int num = 0;
			byte[] array2 = default(byte[]);
			if (asObject == null)
			{
				byte[] array = default(byte[]);
				if (asObject == null)
				{
					if (asObject == null && asObject == null)
					{
						if (asObject != null)
						{
						}
						if (asObject == null && asObject == null)
						{
							int num12 = default(int);
							if (asObject == null)
							{
								if (asObject == null)
								{
									if (asObject == null)
									{
										if (asObject == null)
										{
											if (asObject == null)
											{
												if (asObject != null)
												{
												}
												if (asObject != null)
												{
													int num2 = 0;
												}
												if (asObject != null)
												{
													int num3 = 0;
												}
												if (asObject == null)
												{
													int num4 = 0;
													int asObject2 = default(int);
													if (asObject != null)
													{
														int num5 = 0;
														CultureInfo invariantCulture = CultureInfo.InvariantCulture;
														asObject2 = Convert.ToInt32(asObject, invariantCulture);
														WriteInt32(writer, asObject2);
														return;
													}
													if (asObject2 == 0)
													{
													}
												}
											}
											ulong num6 = default(ulong);
											writer.stream.WriteByte((byte)num6);
											bool value = default(bool);
											writer.WriteUInt32(value ? 1u : 0u);
										}
										ulong num7 = default(ulong);
										writer.stream.WriteByte((byte)num7);
										int num8 = 0;
									}
									ulong num9 = default(ulong);
									writer.stream.WriteByte((byte)num9);
									int num10 = 0;
								}
								ulong num11 = default(ulong);
								writer.stream.WriteByte((byte)num11);
								Stream stream = writer.stream;
								Stream stream2 = writer.stream;
								num12 = 0;
								stream2.WriteByte((byte)num12);
							}
							WriteInt64(writer, num12);
						}
						ulong num13 = default(ulong);
						writer.stream.WriteByte((byte)num13);
						Stream stream3 = writer.stream;
					}
					ulong num14 = default(ulong);
					writer.stream.WriteByte((byte)num14);
					Array.Reverse((Array)array);
					Stream stream4 = writer.stream;
					int offset = 0;
					int length = array.Length;
					stream4.Write(array, offset, length);
				}
				byte b = array[4];
				array2 = array;
				ulong num15 = default(ulong);
				writer.stream.WriteByte((byte)num15);
			}
			byte b2 = array2[4];
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x28BCCC0", Offset = "0x28BB6C0", VA = "0x1828BCCC0")]
		private static void WriteTag(NetworkByteOrderBinaryWriter writer, Tag tag)
		{
			//Discarded unreachable code: IL_000d
			bool canRead = writer.stream.CanRead;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x28BA150", Offset = "0x28B8B50", VA = "0x1828BA150")]
		private static void WriteByte(NetworkByteOrderBinaryWriter writer, byte asObject)
		{
			//Discarded unreachable code: IL_0019
			//IL_000c: Expected I4, but got I8
			ulong num = default(ulong);
			writer.stream.WriteByte((byte)num);
			bool canRead = writer.stream.CanRead;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x28BA0F0", Offset = "0x28B8AF0", VA = "0x1828BA0F0")]
		private static void WriteBool(NetworkByteOrderBinaryWriter writer, bool asObject)
		{
			//Discarded unreachable code: IL_0014
			//IL_000c: Expected I4, but got I8
			ulong num = default(ulong);
			writer.stream.WriteByte((byte)num);
			writer.WriteUInt32(asObject ? 1u : 0u);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x28BCA90", Offset = "0x28BB490", VA = "0x1828BCA90")]
		private static void WriteShort(NetworkByteOrderBinaryWriter writer, short asObject)
		{
			//Discarded unreachable code: IL_0035
			//IL_000c: Expected I4, but got I8
			ulong num = default(ulong);
			writer.stream.WriteByte((byte)num);
			byte[] bytes = BitConverter.GetBytes(asObject);
			Array.Reverse((Array)bytes);
			Stream stream = writer.stream;
			int offset = 0;
			int length = bytes.Length;
			stream.Write(bytes, offset, length);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x28BCE30", Offset = "0x28BB830", VA = "0x1828BCE30")]
		private static void WriteUShort(NetworkByteOrderBinaryWriter writer, ushort asObject)
		{
			//Discarded unreachable code: IL_0035
			//IL_000c: Expected I4, but got I8
			ulong num = default(ulong);
			writer.stream.WriteByte((byte)num);
			byte[] bytes = BitConverter.GetBytes(asObject);
			Array.Reverse((Array)bytes);
			Stream stream = writer.stream;
			int offset = 0;
			int length = bytes.Length;
			stream.Write(bytes, offset, length);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x28BB150", Offset = "0x28B9B50", VA = "0x1828BB150")]
		private static void WriteFloat(NetworkByteOrderBinaryWriter writer, float asObject)
		{
			//Discarded unreachable code: IL_0035
			//IL_000c: Expected I4, but got I8
			ulong num = default(ulong);
			writer.stream.WriteByte((byte)num);
			byte[] bytes = BitConverter.GetBytes(asObject);
			Array.Reverse((Array)bytes);
			Stream stream = writer.stream;
			int offset = 0;
			int length = bytes.Length;
			stream.Write(bytes, offset, length);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x28BA5F0", Offset = "0x28B8FF0", VA = "0x1828BA5F0")]
		private static void WriteDouble(NetworkByteOrderBinaryWriter writer, double asObject)
		{
			//Discarded unreachable code: IL_0035
			//IL_000c: Expected I4, but got I8
			ulong num = default(ulong);
			writer.stream.WriteByte((byte)num);
			byte[] bytes = BitConverter.GetBytes(asObject);
			Array.Reverse((Array)bytes);
			Stream stream = writer.stream;
			int offset = 0;
			int length = bytes.Length;
			stream.Write(bytes, offset, length);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x28BB240", Offset = "0x28B9C40", VA = "0x1828BB240")]
		private static void WriteInt32(NetworkByteOrderBinaryWriter writer, int asObject)
		{
			//IL_000c: Expected I4, but got I8
			ulong num = default(ulong);
			writer.stream.WriteByte((byte)num);
			if (asObject != 0)
			{
				if (asObject != int.MinValue)
				{
					if (asObject <= 0)
					{
						return;
					}
					Stream stream = writer.stream;
					if (1L == 0L)
					{
					}
					stream.WriteByte((byte)asObject);
					while (asObject != 0)
					{
					}
				}
				Stream stream2 = writer.stream;
				return;
			}
			Stream stream3 = writer.stream;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x28BCD00", Offset = "0x28BB700", VA = "0x1828BCD00")]
		private static void WriteUInt32(NetworkByteOrderBinaryWriter writer, uint asObject)
		{
			//Discarded unreachable code: IL_0014
			//IL_000c: Expected I4, but got I8
			ulong num = default(ulong);
			writer.stream.WriteByte((byte)num);
			writer.WriteUInt32(asObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x28BB390", Offset = "0x28B9D90", VA = "0x1828BB390")]
		private static void WriteInt64(NetworkByteOrderBinaryWriter writer, long asObject)
		{
			//Discarded unreachable code: IL_0028
			//IL_000c: Expected I4, but got I8
			//IL_0020: Expected I4, but got I8
			ulong num = default(ulong);
			writer.stream.WriteByte((byte)num);
			Stream stream = writer.stream;
			if (1L == 0L)
			{
			}
			stream.WriteByte((byte)asObject);
			Stream stream2 = writer.stream;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x28BCD60", Offset = "0x28BB760", VA = "0x1828BCD60")]
		private static void WriteUInt64(NetworkByteOrderBinaryWriter writer, ulong asObject)
		{
			//Discarded unreachable code: IL_0032
			//IL_000c: Expected I4, but got I8
			//IL_001e: Expected I4, but got I8
			ulong num = default(ulong);
			writer.stream.WriteByte((byte)num);
			if (asObject != 0)
			{
				writer.stream.WriteByte((byte)asObject);
				while (asObject != 0)
				{
				}
			}
			else
			{
				bool canRead = writer.stream.CanRead;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x28BCB70", Offset = "0x28BB570", VA = "0x1828BCB70")]
		private static void WriteString(NetworkByteOrderBinaryWriter writer, string asObject)
		{
			//Discarded unreachable code: IL_0014
			//IL_000c: Expected I4, but got I8
			ulong num = default(ulong);
			writer.stream.WriteByte((byte)num);
			Stream stream = writer.stream;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x28BC740", Offset = "0x28BB140", VA = "0x1828BC740")]
		private static void WritePackage(NetworkByteOrderBinaryWriter writer, EtsPackage asObject)
		{
			//Discarded unreachable code: IL_009e
			//IL_000e: Expected I4, but got I8
			//IL_0037: Expected I4, but got I8
			//IL_0086: Expected O, but got I4
			//IL_0095: Expected I4, but got I8
			ulong num2 = default(ulong);
			uint value = default(uint);
			ulong num3 = default(ulong);
			bool flag = default(bool);
			do
			{
				int num = 0;
				writer.stream.WriteByte((byte)num2);
				writer.stream.WriteByte((byte)value);
				if (asObject == null)
				{
					break;
				}
				int count = ((Dictionary<TKey, TValue>)(object)((Package)asObject).Payload).Count;
				writer.stream.WriteByte((byte)num3);
				int value2 = count + 1;
				writer.WriteUInt32((uint)value2);
				WriteString(writer, "events");
				IReadOnlyCollection<object> _003CEvents_003Ek__BackingField = ((Package)asObject).Events;
				BinaryFormatter.WriteEventsList(writer, (IReadOnlyCollection<>)_003CEvents_003Ek__BackingField);
				Dictionary<string, object> _003CPayload_003Ek__BackingField = ((Package)asObject).Payload;
				if (flag)
				{
				}
			}
			while (num3 != 0);
			int num4 = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			uint num5 = default(uint);
			uint value3 = Convert.ToUInt32(num5, invariantCulture);
			ulong num6 = default(ulong);
			writer.stream.WriteByte((byte)num6);
			writer.WriteUInt32(value3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x28BC1D0", Offset = "0x28BABD0", VA = "0x1828BC1D0")]
		private static void WritePackageInfo(NetworkByteOrderBinaryWriter writer, PackageInfo asObject)
		{
			//Discarded unreachable code: IL_0142
			//IL_000c: Expected I4, but got I8
			//IL_0024: Expected I4, but got I8
			//IL_0038: Expected I4, but got I8
			//IL_0069: Expected I4, but got I8
			//IL_007e: Expected I4, but got I8
			//IL_008b: Expected I4, but got I8
			//IL_00b0: Expected I4, but got I8
			//IL_00c5: Expected I4, but got I8
			//IL_00d2: Expected I4, but got I8
			//IL_00f7: Expected I4, but got I8
			//IL_011c: Expected I4, but got I8
			//IL_0131: Expected I4, but got I8
			ulong num = default(ulong);
			writer.stream.WriteByte((byte)num);
			uint value = default(uint);
			writer.stream.WriteByte((byte)value);
			ulong num2 = default(ulong);
			writer.stream.WriteByte((byte)num2);
			Stream stream = writer.stream;
			ulong num3 = default(ulong);
			writer.stream.WriteByte((byte)num3);
			Stream stream2 = writer.stream;
			int value2 = 0;
			stream2.WriteByte((byte)value2);
			string _003CUserAgent_003Ek__BackingField = asObject.UserAgent;
			WriteString(writer, _003CUserAgent_003Ek__BackingField);
			ulong num4 = default(ulong);
			writer.stream.WriteByte((byte)num4);
			Stream stream3 = writer.stream;
			ulong num5 = default(ulong);
			writer.stream.WriteByte((byte)num5);
			ulong num6 = default(ulong);
			writer.stream.WriteByte((byte)num6);
			Stream stream4 = writer.stream;
			string _003CVersion_003Ek__BackingField = asObject.Version;
			WriteString(writer, _003CVersion_003Ek__BackingField);
			ulong num7 = default(ulong);
			writer.stream.WriteByte((byte)num7);
			Stream stream5 = writer.stream;
			ulong num8 = default(ulong);
			writer.stream.WriteByte((byte)num8);
			ulong num9 = default(ulong);
			writer.stream.WriteByte((byte)num9);
			Stream stream6 = writer.stream;
			string _003CSHA1_003Ek__BackingField = asObject.SHA1;
			WriteString(writer, _003CSHA1_003Ek__BackingField);
			ulong num10 = default(ulong);
			writer.stream.WriteByte((byte)num10);
			Stream stream7 = writer.stream;
			string _003CHost_003Ek__BackingField = asObject.Host;
			WriteString(writer, _003CHost_003Ek__BackingField);
			ulong num11 = default(ulong);
			writer.stream.WriteByte((byte)num11);
			Stream stream8 = writer.stream;
			ulong num12 = default(ulong);
			writer.stream.WriteByte((byte)num12);
			uint _003CGLOTv3Revision_003Ek__BackingField = asObject.GLOTv3Revision;
			writer.WriteUInt32(_003CGLOTv3Revision_003Ek__BackingField);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x28BA9C0", Offset = "0x28B93C0", VA = "0x1828BA9C0")]
		private static void WriteEventInfo(NetworkByteOrderBinaryWriter writer, StandardEvent asObject)
		{
			//Discarded unreachable code: IL_0139
			//IL_000c: Expected I4, but got I8
			//IL_0024: Expected I4, but got I8
			//IL_006b: Expected O, but got I4
			//IL_008f: Expected I4, but got I8
			//IL_0138: Expected O, but got I4
			ulong num = default(ulong);
			writer.stream.WriteByte((byte)num);
			uint value = default(uint);
			writer.stream.WriteByte((byte)value);
			ulong num2 = default(ulong);
			writer.stream.WriteByte((byte)num2);
			uint num3 = default(uint);
			writer.stream.WriteByte((byte)num3);
			while (num3 != 0)
			{
			}
			WriteString(writer, "edata");
			EventData _003CEventData_003Ek__BackingField = asObject.EventData;
			WriteObject(writer, _003CEventData_003Ek__BackingField);
			WriteString(writer, "prio");
			EventPriority _003CPriority_003Ek__BackingField = asObject.Priority;
			WriteObject(writer, _003CPriority_003Ek__BackingField);
			WriteString(writer, "batchsize");
			Stream stream = writer.stream;
			uint _003CBatchSize_003Ek__BackingField = asObject.BatchSize;
			ulong num4 = default(ulong);
			stream.WriteByte((byte)num4);
			writer.WriteUInt32(_003CBatchSize_003Ek__BackingField);
			WriteString(writer, "smartbatch");
			List<string> _003CSmartBatchProperties_003Ek__BackingField = asObject.SmartBatchProperties;
			if (_003CSmartBatchProperties_003Ek__BackingField != null)
			{
				Func<string, int, _003C_003Ef__AnonymousType0<int, string>> func = default(Func<string, int, _003C_003Ef__AnonymousType0<int, string>>);
				if (_003C_003Ec._003C_003E9__32_0 == null)
				{
					func = (Func<string, int, _003C_003Ef__AnonymousType0<int, string>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T1, T2, TResult>)((string name, int i) => (_003C_003Ef__AnonymousType0<int, string>)(object)new
					{
						i = (_003Ci_003Ej__TPar)i,
						name = (_003Cname_003Ej__TPar)name
					}));
				}
				IEnumerable<string> enumerable = (IEnumerable<string>)Enumerable.Select((IEnumerable<>)_003CSmartBatchProperties_003Ek__BackingField, (Func<, , >)(object)func);
				Func<_003C_003Ef__AnonymousType0<int, string>, int> func2 = default(Func<_003C_003Ef__AnonymousType0<int, string>, int>);
				if (_003C_003Ec._003C_003E9__32_1 == null)
				{
					func2 = (Func<_003C_003Ef__AnonymousType0<int, string>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)(a =>
					{
						_00210 _003Ci_003Ei__Field = (_00210)((_003C_003Ef__AnonymousType0<, >)(object)a)._003Ci_003Ei__Field;
						throw new NullReferenceException();
					}));
				}
				Func<_003C_003Ef__AnonymousType0<int, string>, string> func3 = default(Func<_003C_003Ef__AnonymousType0<int, string>, string>);
				if (_003C_003Ec._003C_003E9__32_2 == null)
				{
					func3 = (Func<_003C_003Ef__AnonymousType0<int, string>, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)(a =>
					{
						throw new NullReferenceException();
					}));
				}
				var dictionary = (Dictionary<_003C_003Ef__AnonymousType0<int, string>, int>)(object)Enumerable.ToDictionary((IEnumerable<>)enumerable, (Func<, >)(object)func2, (Func<, >)(object)func3);
			}
			int num5 = 0;
			WriteDictionary(writer, (IDictionary)num5);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x28BA6E0", Offset = "0x28B90E0", VA = "0x1828BA6E0")]
		private static void WriteEventData(NetworkByteOrderBinaryWriter writer, EventData asObject)
		{
			//Discarded unreachable code: IL_00ee
			//IL_000c: Expected I4, but got I8
			//IL_002a: Expected O, but got I4
			//IL_0039: Expected I4, but got I8
			ulong num = default(ulong);
			writer.stream.WriteByte((byte)num);
			uint value = default(uint);
			writer.stream.WriteByte((byte)value);
			int num2 = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			uint num3 = default(uint);
			uint value2 = Convert.ToUInt32(num3, invariantCulture);
			ulong num4 = default(ulong);
			writer.stream.WriteByte((byte)num4);
			writer.WriteUInt32(value2);
			WriteString(writer, "data");
			Dictionary<string, object> _003CUserData_003Ek__BackingField = asObject.UserData;
			WriteDictionary(writer, _003CUserData_003Ek__BackingField);
			WriteString(writer, "type");
			int _003CType_003Ek__BackingField = asObject.Type;
			WriteInt32(writer, _003CType_003Ek__BackingField);
			WriteString(writer, "token");
			int _003CToken_003Ek__BackingField = asObject.Token;
			WriteInt32(writer, _003CToken_003Ek__BackingField);
			WriteString(writer, "uuid");
			string _003CUUID_003Ek__BackingField = asObject.UUID;
			WriteString(writer, _003CUUID_003Ek__BackingField);
			WriteString(writer, "ts");
			long asObject2 = asObject.TimeStamp.ToEpochTime();
			WriteInt64(writer, asObject2);
			WriteString(writer, "ts_local");
			long asObject3 = asObject.TimeStampLocal.ToEpochTime();
			WriteInt64(writer, asObject3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x28BA1D0", Offset = "0x28B8BD0", VA = "0x1828BA1D0")]
		private static void WriteDictionary(NetworkByteOrderBinaryWriter writer, IDictionary asObject)
		{
			//Discarded unreachable code: IL_0099, IL_009f
			//IL_000e: Expected I4, but got I8
			//IL_0027: Expected I4, but got I8
			//IL_003e: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_0081: Expected O, but got I4
			//IL_0090: Expected I4, but got I8
			int num = 0;
			ulong num2 = default(ulong);
			writer.stream.WriteByte((byte)num2);
			if (asObject != null)
			{
				int num3 = 0;
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				ulong num4 = default(ulong);
				writer.stream.WriteByte((byte)num4);
				uint value = default(uint);
				writer.WriteUInt32(value);
				num += num;
				num++;
				WriteObject(writer, num);
				uint num5 = default(uint);
				if (num < (int)num5)
				{
					num += num;
					num++;
				}
				WriteObject(writer, num);
				num += num;
				num += 328;
				num += num;
				if (num + 312 == 0)
				{
				}
			}
			int num6 = 0;
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			uint num7 = default(uint);
			uint value2 = Convert.ToUInt32(num7, invariantCulture2);
			ulong num8 = default(ulong);
			writer.stream.WriteByte((byte)num8);
			writer.WriteUInt32(value2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x28BAEC0", Offset = "0x28B98C0", VA = "0x1828BAEC0")]
		private static void WriteEventsList(NetworkByteOrderBinaryWriter writer, IReadOnlyCollection<object> asObject)
		{
			//Discarded unreachable code: IL_0047
			//IL_000e: Expected I4, but got I8
			//IL_0023: Expected I4, but got I8
			//IL_003a: Expected O, but got I4
			int num = 0;
			ulong num2 = default(ulong);
			writer.stream.WriteByte((byte)num2);
			int num3 = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			ulong num4 = default(ulong);
			writer.stream.WriteByte((byte)num4);
			uint value = default(uint);
			writer.WriteUInt32(value);
			num += num;
			num++;
			WriteObject(writer, num);
			num += num;
			num += 312;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x28BB4F0", Offset = "0x28B9EF0", VA = "0x1828BB4F0")]
		private static void WriteObjectList(NetworkByteOrderBinaryWriter writer, IList asObject)
		{
			//Discarded unreachable code: IL_008f
			//IL_000c: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			//IL_0066: Expected O, but got I4
			ulong num = default(ulong);
			writer.stream.WriteByte((byte)num);
			int num2 = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			ulong num3 = default(ulong);
			writer.stream.WriteByte((byte)num3);
			uint num4 = default(uint);
			writer.WriteUInt32(num4);
			int num5 = 0;
			uint num6 = default(uint);
			if (num5 < (int)num6)
			{
				num5 += num5;
				num5++;
			}
			if (num5 < (int)num4)
			{
				WriteInt32(writer, num5);
				uint num7 = default(uint);
				if (num5 < (int)num7)
				{
					num5 += num5;
					num5++;
				}
				WriteObject(writer, num5);
				num5++;
				num5 += num5;
				num5 += 328;
				num5 += num5;
				num5 += 312;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public BinaryFormatter()
		{
			((AsyncRetrySyntax._003C_003Ec__DisplayClass45_0)(object)this)._002Ector();
		}
	}
}
