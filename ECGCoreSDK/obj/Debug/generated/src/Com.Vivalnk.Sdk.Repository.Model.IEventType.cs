using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Model {

	[Register ("com/vivalnk/sdk/repository/model/EventType", DoNotGenerateAcw=true)]
	public abstract class EventType : Java.Lang.Object {

		internal EventType ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/interface[@name='EventType']/field[@name='EcgDeviceStatus']"
		[Register ("EcgDeviceStatus")]
		public const string EcgDeviceStatus = (string) "EcgDeviceStatus";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/interface[@name='EventType']/field[@name='EcgProcessed']"
		[Register ("EcgProcessed")]
		public const string EcgProcessed = (string) "EcgProcessed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/interface[@name='EventType']/field[@name='EcgRaw']"
		[Register ("EcgRaw")]
		public const string EcgRaw = (string) "EcgRaw";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/interface[@name='EventType']/field[@name='TemperatureDeviceStatus']"
		[Register ("TemperatureDeviceStatus")]
		public const string TemperatureDeviceStatus = (string) "TemperatureDeviceStatus";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/interface[@name='EventType']/field[@name='TemperatureProcessed']"
		[Register ("TemperatureProcessed")]
		public const string TemperatureProcessed = (string) "TemperatureProcessed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/interface[@name='EventType']/field[@name='TemperatureRaw']"
		[Register ("TemperatureRaw")]
		public const string TemperatureRaw = (string) "TemperatureRaw";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/interface[@name='EventType']/field[@name='WellnessDailyStats']"
		[Register ("WellnessDailyStats")]
		public const string WellnessDailyStats = (string) "WellnessDailyStats";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/interface[@name='EventType']/field[@name='WellnessDeviceStatus']"
		[Register ("WellnessDeviceStatus")]
		public const string WellnessDeviceStatus = (string) "WellnessDeviceStatus";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/interface[@name='EventType']/field[@name='WellnessProcessed']"
		[Register ("WellnessProcessed")]
		public const string WellnessProcessed = (string) "WellnessProcessed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/interface[@name='EventType']/field[@name='WellnessRaw']"
		[Register ("WellnessRaw")]
		public const string WellnessRaw = (string) "WellnessRaw";
	}

	[Register ("com/vivalnk/sdk/repository/model/EventType", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'EventType' type. This type will be removed in a future release.", error: true)]
	public abstract class EventTypeConsts : EventType {

		private EventTypeConsts ()
		{
		}
	}

}
