using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.PerformanceMonitor;
using Mdl.Systems;
using Meta;
using Serilog.Core;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class PerformanceMonitoring : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000395")]
	private const float RefreshPeriod = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private float timer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000397")]
	private float fps;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public PerformanceMonitoringConfig performanceMonitoringConfig;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private string QualityLevel
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xCE9040", Offset = "0xCE7A40", VA = "0x180CE9040")]
		get
		{
			//Discarded unreachable code: IL_0018
			int num = 0;
			string[] names = QualitySettings.names;
			int num2 = 0;
			int qualityLevel = QualitySettings.GetQualityLevel();
			return names[qualityLevel];
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private bool Active
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620")]
		get
		{
			return true;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private Monitor PerformanceMonitor
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
		[CompilerGenerated]
		get
		{
			return _003CPerformanceMonitor_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
		[CompilerGenerated]
		set
		{
			_003CPerformanceMonitor_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public static PerformanceMonitoring Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xF0E1E0", Offset = "0xF0CBE0", VA = "0x180F0E1E0")]
		get
		{
			return Enumerable.First<PerformanceMonitoring>((IEnumerable<>)(object)UnityEngine.Object.FindObjectsOfType<PerformanceMonitoring>());
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0xF0D950", Offset = "0xF0C350", VA = "0x180F0D950")]
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xF0E160", Offset = "0xF0CB60", VA = "0x180F0E160")]
	private void Start()
	{
		Monitor monitor = (PerformanceMonitor = CreatePerformanceMonitor());
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0xF0E130", Offset = "0xF0CB30", VA = "0x180F0E130")]
	private void OnDestroy()
	{
		Monitor monitor;
		do
		{
			monitor = PerformanceMonitor;
		}
		while (monitor == null);
		monitor.Dispose();
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0xF0D9B0", Offset = "0xF0C3B0", VA = "0x180F0D9B0")]
	private Monitor CreatePerformanceMonitor()
	{
		//Discarded unreachable code: IL_00f3
		ElasticsearchConfiguration elasticsearchConfiguration;
		ILogEventEnricher[] array;
		KeyValueEnricher keyValueEnricher3;
		while (true)
		{
			elasticsearchConfiguration = new ElasticsearchConfiguration();
			Uri uri = (elasticsearchConfiguration.Uri = new Uri(performanceMonitoringConfig.uri));
			string text = (elasticsearchConfiguration.IndexFormat = performanceMonitoringConfig.indexFormat);
			int num = 0;
			string[] names = QualitySettings.names;
			int num2 = 0;
			int qualityLevel = QualitySettings.GetQualityLevel();
			KeyValueEnricher keyValueEnricher = SettingsEnricher.Create(names[qualityLevel], "Scenario1");
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			Gameloft.Common.Version _003CVersion_003Ek__BackingField = _003CInstance_003Ek__BackingField.Version;
			int build = _003CInstance_003Ek__BackingField.Version.version.build;
			string buildType = _003CInstance_003Ek__BackingField.Version.buildType;
			KeyValueEnricher keyValueEnricher2 = VersionSerilogEnricher.Create(_003CVersion_003Ek__BackingField);
			array = new ILogEventEnricher[3];
			if (keyValueEnricher != null && array == null)
			{
				continue;
			}
			array[0] = keyValueEnricher;
			if (keyValueEnricher2 == null || array != null)
			{
				array[1] = keyValueEnricher2;
				int num3 = 0;
				keyValueEnricher3 = SystemInfoEnricher.Create();
				if (keyValueEnricher3 == null || keyValueEnricher3 != null)
				{
					break;
				}
			}
		}
		array[2] = keyValueEnricher3;
		return new Monitor(elasticsearchConfiguration, array);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0xF0E190", Offset = "0xF0CB90", VA = "0x180F0E190")]
	private void Update()
	{
		int num = 0;
		float num2 = (timer = Time.smoothDeltaTime);
		timer = 0f;
		fps = num2;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0xF0DD00", Offset = "0xF0C700", VA = "0x180F0DD00")]
	public void LogFrameRate(string checkpoint)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0xF0DE50", Offset = "0xF0C850", VA = "0x180F0DE50")]
	public void LogMemory(string checkpoint)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0xF0DFD0", Offset = "0xF0C9D0", VA = "0x180F0DFD0")]
	public void LogSpanDuration(string spanName, TimeSpan duration)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public PerformanceMonitoring()
	{
	}
}
