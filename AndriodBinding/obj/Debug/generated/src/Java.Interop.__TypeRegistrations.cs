using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/vivalnk/sdk/common/eventbus",
					},
					new Converter<string, Type>[]{
						lookup_com_vivalnk_sdk_common_eventbus_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_vivalnk_sdk_common_eventbus_mappings;
		static Type lookup_com_vivalnk_sdk_common_eventbus_package (string klass)
		{
			if (package_com_vivalnk_sdk_common_eventbus_mappings == null) {
				package_com_vivalnk_sdk_common_eventbus_mappings = new string[]{
					"com/vivalnk/sdk/common/eventbus/Logger$JavaLogger:Com.Vivalnk.Sdk.Common.Eventbus.LoggerJavaLogger",
					"com/vivalnk/sdk/common/eventbus/Logger$SystemOutLogger:Com.Vivalnk.Sdk.Common.Eventbus.LoggerSystemOutLogger",
					"com/vivalnk/sdk/common/eventbus/MainThreadSupport$AndroidHandlerMainThreadSupport:Com.Vivalnk.Sdk.Common.Eventbus.MainThreadSupportAndroidHandlerMainThreadSupport",
				};
			}

			return Lookup (package_com_vivalnk_sdk_common_eventbus_mappings, klass);
		}
	}
}
