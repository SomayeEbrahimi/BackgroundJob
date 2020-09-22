using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/SystemUtils", DoNotGenerateAcw=true)]
	public partial class SystemUtils : global::Java.Lang.Object {


		static IntPtr AWT_TOOLKIT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='AWT_TOOLKIT']"
		[Register ("AWT_TOOLKIT")]
		public static string AwtToolkit {
			get {
				if (AWT_TOOLKIT_jfieldId == IntPtr.Zero)
					AWT_TOOLKIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AWT_TOOLKIT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AWT_TOOLKIT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FILE_ENCODING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='FILE_ENCODING']"
		[Register ("FILE_ENCODING")]
		public static string FileEncoding {
			get {
				if (FILE_ENCODING_jfieldId == IntPtr.Zero)
					FILE_ENCODING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FILE_ENCODING", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FILE_ENCODING_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FILE_SEPARATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='FILE_SEPARATOR']"
		[Register ("FILE_SEPARATOR")]
		[Obsolete ("deprecated")]
		public static string FileSeparator {
			get {
				if (FILE_SEPARATOR_jfieldId == IntPtr.Zero)
					FILE_SEPARATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FILE_SEPARATOR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FILE_SEPARATOR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IS_JAVA_10_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_JAVA_10']"
		[Register ("IS_JAVA_10")]
		public static bool IsJava10 {
			get {
				if (IS_JAVA_10_jfieldId == IntPtr.Zero)
					IS_JAVA_10_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_JAVA_10", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_JAVA_10_jfieldId);
			}
		}

		static IntPtr IS_JAVA_11_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_JAVA_11']"
		[Register ("IS_JAVA_11")]
		public static bool IsJava11 {
			get {
				if (IS_JAVA_11_jfieldId == IntPtr.Zero)
					IS_JAVA_11_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_JAVA_11", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_JAVA_11_jfieldId);
			}
		}

		static IntPtr IS_JAVA_1_2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_JAVA_1_2']"
		[Register ("IS_JAVA_1_2")]
		public static bool IsJava12 {
			get {
				if (IS_JAVA_1_2_jfieldId == IntPtr.Zero)
					IS_JAVA_1_2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_JAVA_1_2", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_JAVA_1_2_jfieldId);
			}
		}

		static IntPtr IS_JAVA_1_3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_JAVA_1_3']"
		[Register ("IS_JAVA_1_3")]
		public static bool IsJava13 {
			get {
				if (IS_JAVA_1_3_jfieldId == IntPtr.Zero)
					IS_JAVA_1_3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_JAVA_1_3", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_JAVA_1_3_jfieldId);
			}
		}

		static IntPtr IS_JAVA_1_4_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_JAVA_1_4']"
		[Register ("IS_JAVA_1_4")]
		public static bool IsJava14 {
			get {
				if (IS_JAVA_1_4_jfieldId == IntPtr.Zero)
					IS_JAVA_1_4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_JAVA_1_4", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_JAVA_1_4_jfieldId);
			}
		}

		static IntPtr IS_JAVA_1_5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_JAVA_1_5']"
		[Register ("IS_JAVA_1_5")]
		public static bool IsJava15 {
			get {
				if (IS_JAVA_1_5_jfieldId == IntPtr.Zero)
					IS_JAVA_1_5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_JAVA_1_5", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_JAVA_1_5_jfieldId);
			}
		}

		static IntPtr IS_JAVA_1_6_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_JAVA_1_6']"
		[Register ("IS_JAVA_1_6")]
		public static bool IsJava16 {
			get {
				if (IS_JAVA_1_6_jfieldId == IntPtr.Zero)
					IS_JAVA_1_6_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_JAVA_1_6", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_JAVA_1_6_jfieldId);
			}
		}

		static IntPtr IS_JAVA_1_7_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_JAVA_1_7']"
		[Register ("IS_JAVA_1_7")]
		public static bool IsJava17 {
			get {
				if (IS_JAVA_1_7_jfieldId == IntPtr.Zero)
					IS_JAVA_1_7_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_JAVA_1_7", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_JAVA_1_7_jfieldId);
			}
		}

		static IntPtr IS_JAVA_1_8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_JAVA_1_8']"
		[Register ("IS_JAVA_1_8")]
		public static bool IsJava18 {
			get {
				if (IS_JAVA_1_8_jfieldId == IntPtr.Zero)
					IS_JAVA_1_8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_JAVA_1_8", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_JAVA_1_8_jfieldId);
			}
		}

		static IntPtr IS_JAVA_1_9_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_JAVA_1_9']"
		[Register ("IS_JAVA_1_9")]
		[Obsolete ("deprecated")]
		public static bool IsJava19 {
			get {
				if (IS_JAVA_1_9_jfieldId == IntPtr.Zero)
					IS_JAVA_1_9_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_JAVA_1_9", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_JAVA_1_9_jfieldId);
			}
		}

		static IntPtr IS_JAVA_9_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_JAVA_9']"
		[Register ("IS_JAVA_9")]
		public static bool IsJava9 {
			get {
				if (IS_JAVA_9_jfieldId == IntPtr.Zero)
					IS_JAVA_9_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_JAVA_9", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_JAVA_9_jfieldId);
			}
		}

		static IntPtr IS_OS_400_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_400']"
		[Register ("IS_OS_400")]
		public static bool IsOs400 {
			get {
				if (IS_OS_400_jfieldId == IntPtr.Zero)
					IS_OS_400_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_400", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_400_jfieldId);
			}
		}

		static IntPtr IS_OS_AIX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_AIX']"
		[Register ("IS_OS_AIX")]
		public static bool IsOsAix {
			get {
				if (IS_OS_AIX_jfieldId == IntPtr.Zero)
					IS_OS_AIX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_AIX", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_AIX_jfieldId);
			}
		}

		static IntPtr IS_OS_FREE_BSD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_FREE_BSD']"
		[Register ("IS_OS_FREE_BSD")]
		public static bool IsOsFreeBsd {
			get {
				if (IS_OS_FREE_BSD_jfieldId == IntPtr.Zero)
					IS_OS_FREE_BSD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_FREE_BSD", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_FREE_BSD_jfieldId);
			}
		}

		static IntPtr IS_OS_HP_UX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_HP_UX']"
		[Register ("IS_OS_HP_UX")]
		public static bool IsOsHpUx {
			get {
				if (IS_OS_HP_UX_jfieldId == IntPtr.Zero)
					IS_OS_HP_UX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_HP_UX", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_HP_UX_jfieldId);
			}
		}

		static IntPtr IS_OS_IRIX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_IRIX']"
		[Register ("IS_OS_IRIX")]
		public static bool IsOsIrix {
			get {
				if (IS_OS_IRIX_jfieldId == IntPtr.Zero)
					IS_OS_IRIX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_IRIX", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_IRIX_jfieldId);
			}
		}

		static IntPtr IS_OS_LINUX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_LINUX']"
		[Register ("IS_OS_LINUX")]
		public static bool IsOsLinux {
			get {
				if (IS_OS_LINUX_jfieldId == IntPtr.Zero)
					IS_OS_LINUX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_LINUX", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_LINUX_jfieldId);
			}
		}

		static IntPtr IS_OS_MAC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_MAC']"
		[Register ("IS_OS_MAC")]
		public static bool IsOsMac {
			get {
				if (IS_OS_MAC_jfieldId == IntPtr.Zero)
					IS_OS_MAC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_MAC", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_MAC_jfieldId);
			}
		}

		static IntPtr IS_OS_MAC_OSX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_MAC_OSX']"
		[Register ("IS_OS_MAC_OSX")]
		public static bool IsOsMacOsx {
			get {
				if (IS_OS_MAC_OSX_jfieldId == IntPtr.Zero)
					IS_OS_MAC_OSX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_MAC_OSX", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_MAC_OSX_jfieldId);
			}
		}

		static IntPtr IS_OS_MAC_OSX_CHEETAH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_MAC_OSX_CHEETAH']"
		[Register ("IS_OS_MAC_OSX_CHEETAH")]
		public static bool IsOsMacOsxCheetah {
			get {
				if (IS_OS_MAC_OSX_CHEETAH_jfieldId == IntPtr.Zero)
					IS_OS_MAC_OSX_CHEETAH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_MAC_OSX_CHEETAH", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_MAC_OSX_CHEETAH_jfieldId);
			}
		}

		static IntPtr IS_OS_MAC_OSX_EL_CAPITAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_MAC_OSX_EL_CAPITAN']"
		[Register ("IS_OS_MAC_OSX_EL_CAPITAN")]
		public static bool IsOsMacOsxElCapitan {
			get {
				if (IS_OS_MAC_OSX_EL_CAPITAN_jfieldId == IntPtr.Zero)
					IS_OS_MAC_OSX_EL_CAPITAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_MAC_OSX_EL_CAPITAN", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_MAC_OSX_EL_CAPITAN_jfieldId);
			}
		}

		static IntPtr IS_OS_MAC_OSX_JAGUAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_MAC_OSX_JAGUAR']"
		[Register ("IS_OS_MAC_OSX_JAGUAR")]
		public static bool IsOsMacOsxJaguar {
			get {
				if (IS_OS_MAC_OSX_JAGUAR_jfieldId == IntPtr.Zero)
					IS_OS_MAC_OSX_JAGUAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_MAC_OSX_JAGUAR", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_MAC_OSX_JAGUAR_jfieldId);
			}
		}

		static IntPtr IS_OS_MAC_OSX_LEOPARD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_MAC_OSX_LEOPARD']"
		[Register ("IS_OS_MAC_OSX_LEOPARD")]
		public static bool IsOsMacOsxLeopard {
			get {
				if (IS_OS_MAC_OSX_LEOPARD_jfieldId == IntPtr.Zero)
					IS_OS_MAC_OSX_LEOPARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_MAC_OSX_LEOPARD", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_MAC_OSX_LEOPARD_jfieldId);
			}
		}

		static IntPtr IS_OS_MAC_OSX_LION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_MAC_OSX_LION']"
		[Register ("IS_OS_MAC_OSX_LION")]
		public static bool IsOsMacOsxLion {
			get {
				if (IS_OS_MAC_OSX_LION_jfieldId == IntPtr.Zero)
					IS_OS_MAC_OSX_LION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_MAC_OSX_LION", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_MAC_OSX_LION_jfieldId);
			}
		}

		static IntPtr IS_OS_MAC_OSX_MAVERICKS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_MAC_OSX_MAVERICKS']"
		[Register ("IS_OS_MAC_OSX_MAVERICKS")]
		public static bool IsOsMacOsxMavericks {
			get {
				if (IS_OS_MAC_OSX_MAVERICKS_jfieldId == IntPtr.Zero)
					IS_OS_MAC_OSX_MAVERICKS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_MAC_OSX_MAVERICKS", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_MAC_OSX_MAVERICKS_jfieldId);
			}
		}

		static IntPtr IS_OS_MAC_OSX_MOUNTAIN_LION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_MAC_OSX_MOUNTAIN_LION']"
		[Register ("IS_OS_MAC_OSX_MOUNTAIN_LION")]
		public static bool IsOsMacOsxMountainLion {
			get {
				if (IS_OS_MAC_OSX_MOUNTAIN_LION_jfieldId == IntPtr.Zero)
					IS_OS_MAC_OSX_MOUNTAIN_LION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_MAC_OSX_MOUNTAIN_LION", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_MAC_OSX_MOUNTAIN_LION_jfieldId);
			}
		}

		static IntPtr IS_OS_MAC_OSX_PANTHER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_MAC_OSX_PANTHER']"
		[Register ("IS_OS_MAC_OSX_PANTHER")]
		public static bool IsOsMacOsxPanther {
			get {
				if (IS_OS_MAC_OSX_PANTHER_jfieldId == IntPtr.Zero)
					IS_OS_MAC_OSX_PANTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_MAC_OSX_PANTHER", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_MAC_OSX_PANTHER_jfieldId);
			}
		}

		static IntPtr IS_OS_MAC_OSX_PUMA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_MAC_OSX_PUMA']"
		[Register ("IS_OS_MAC_OSX_PUMA")]
		public static bool IsOsMacOsxPuma {
			get {
				if (IS_OS_MAC_OSX_PUMA_jfieldId == IntPtr.Zero)
					IS_OS_MAC_OSX_PUMA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_MAC_OSX_PUMA", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_MAC_OSX_PUMA_jfieldId);
			}
		}

		static IntPtr IS_OS_MAC_OSX_SNOW_LEOPARD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_MAC_OSX_SNOW_LEOPARD']"
		[Register ("IS_OS_MAC_OSX_SNOW_LEOPARD")]
		public static bool IsOsMacOsxSnowLeopard {
			get {
				if (IS_OS_MAC_OSX_SNOW_LEOPARD_jfieldId == IntPtr.Zero)
					IS_OS_MAC_OSX_SNOW_LEOPARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_MAC_OSX_SNOW_LEOPARD", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_MAC_OSX_SNOW_LEOPARD_jfieldId);
			}
		}

		static IntPtr IS_OS_MAC_OSX_TIGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_MAC_OSX_TIGER']"
		[Register ("IS_OS_MAC_OSX_TIGER")]
		public static bool IsOsMacOsxTiger {
			get {
				if (IS_OS_MAC_OSX_TIGER_jfieldId == IntPtr.Zero)
					IS_OS_MAC_OSX_TIGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_MAC_OSX_TIGER", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_MAC_OSX_TIGER_jfieldId);
			}
		}

		static IntPtr IS_OS_MAC_OSX_YOSEMITE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_MAC_OSX_YOSEMITE']"
		[Register ("IS_OS_MAC_OSX_YOSEMITE")]
		public static bool IsOsMacOsxYosemite {
			get {
				if (IS_OS_MAC_OSX_YOSEMITE_jfieldId == IntPtr.Zero)
					IS_OS_MAC_OSX_YOSEMITE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_MAC_OSX_YOSEMITE", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_MAC_OSX_YOSEMITE_jfieldId);
			}
		}

		static IntPtr IS_OS_NET_BSD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_NET_BSD']"
		[Register ("IS_OS_NET_BSD")]
		public static bool IsOsNetBsd {
			get {
				if (IS_OS_NET_BSD_jfieldId == IntPtr.Zero)
					IS_OS_NET_BSD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_NET_BSD", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_NET_BSD_jfieldId);
			}
		}

		static IntPtr IS_OS_OPEN_BSD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_OPEN_BSD']"
		[Register ("IS_OS_OPEN_BSD")]
		public static bool IsOsOpenBsd {
			get {
				if (IS_OS_OPEN_BSD_jfieldId == IntPtr.Zero)
					IS_OS_OPEN_BSD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_OPEN_BSD", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_OPEN_BSD_jfieldId);
			}
		}

		static IntPtr IS_OS_OS2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_OS2']"
		[Register ("IS_OS_OS2")]
		public static bool IsOsOs2 {
			get {
				if (IS_OS_OS2_jfieldId == IntPtr.Zero)
					IS_OS_OS2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_OS2", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_OS2_jfieldId);
			}
		}

		static IntPtr IS_OS_SOLARIS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_SOLARIS']"
		[Register ("IS_OS_SOLARIS")]
		public static bool IsOsSolaris {
			get {
				if (IS_OS_SOLARIS_jfieldId == IntPtr.Zero)
					IS_OS_SOLARIS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_SOLARIS", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_SOLARIS_jfieldId);
			}
		}

		static IntPtr IS_OS_SUN_OS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_SUN_OS']"
		[Register ("IS_OS_SUN_OS")]
		public static bool IsOsSunOs {
			get {
				if (IS_OS_SUN_OS_jfieldId == IntPtr.Zero)
					IS_OS_SUN_OS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_SUN_OS", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_SUN_OS_jfieldId);
			}
		}

		static IntPtr IS_OS_UNIX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_UNIX']"
		[Register ("IS_OS_UNIX")]
		public static bool IsOsUnix {
			get {
				if (IS_OS_UNIX_jfieldId == IntPtr.Zero)
					IS_OS_UNIX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_UNIX", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_UNIX_jfieldId);
			}
		}

		static IntPtr IS_OS_WINDOWS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_WINDOWS']"
		[Register ("IS_OS_WINDOWS")]
		public static bool IsOsWindows {
			get {
				if (IS_OS_WINDOWS_jfieldId == IntPtr.Zero)
					IS_OS_WINDOWS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_WINDOWS", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_WINDOWS_jfieldId);
			}
		}

		static IntPtr IS_OS_WINDOWS_10_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_WINDOWS_10']"
		[Register ("IS_OS_WINDOWS_10")]
		public static bool IsOsWindows10 {
			get {
				if (IS_OS_WINDOWS_10_jfieldId == IntPtr.Zero)
					IS_OS_WINDOWS_10_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_WINDOWS_10", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_WINDOWS_10_jfieldId);
			}
		}

		static IntPtr IS_OS_WINDOWS_2000_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_WINDOWS_2000']"
		[Register ("IS_OS_WINDOWS_2000")]
		public static bool IsOsWindows2000 {
			get {
				if (IS_OS_WINDOWS_2000_jfieldId == IntPtr.Zero)
					IS_OS_WINDOWS_2000_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_WINDOWS_2000", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_WINDOWS_2000_jfieldId);
			}
		}

		static IntPtr IS_OS_WINDOWS_2003_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_WINDOWS_2003']"
		[Register ("IS_OS_WINDOWS_2003")]
		public static bool IsOsWindows2003 {
			get {
				if (IS_OS_WINDOWS_2003_jfieldId == IntPtr.Zero)
					IS_OS_WINDOWS_2003_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_WINDOWS_2003", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_WINDOWS_2003_jfieldId);
			}
		}

		static IntPtr IS_OS_WINDOWS_2008_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_WINDOWS_2008']"
		[Register ("IS_OS_WINDOWS_2008")]
		public static bool IsOsWindows2008 {
			get {
				if (IS_OS_WINDOWS_2008_jfieldId == IntPtr.Zero)
					IS_OS_WINDOWS_2008_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_WINDOWS_2008", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_WINDOWS_2008_jfieldId);
			}
		}

		static IntPtr IS_OS_WINDOWS_2012_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_WINDOWS_2012']"
		[Register ("IS_OS_WINDOWS_2012")]
		public static bool IsOsWindows2012 {
			get {
				if (IS_OS_WINDOWS_2012_jfieldId == IntPtr.Zero)
					IS_OS_WINDOWS_2012_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_WINDOWS_2012", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_WINDOWS_2012_jfieldId);
			}
		}

		static IntPtr IS_OS_WINDOWS_7_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_WINDOWS_7']"
		[Register ("IS_OS_WINDOWS_7")]
		public static bool IsOsWindows7 {
			get {
				if (IS_OS_WINDOWS_7_jfieldId == IntPtr.Zero)
					IS_OS_WINDOWS_7_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_WINDOWS_7", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_WINDOWS_7_jfieldId);
			}
		}

		static IntPtr IS_OS_WINDOWS_8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_WINDOWS_8']"
		[Register ("IS_OS_WINDOWS_8")]
		public static bool IsOsWindows8 {
			get {
				if (IS_OS_WINDOWS_8_jfieldId == IntPtr.Zero)
					IS_OS_WINDOWS_8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_WINDOWS_8", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_WINDOWS_8_jfieldId);
			}
		}

		static IntPtr IS_OS_WINDOWS_95_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_WINDOWS_95']"
		[Register ("IS_OS_WINDOWS_95")]
		public static bool IsOsWindows95 {
			get {
				if (IS_OS_WINDOWS_95_jfieldId == IntPtr.Zero)
					IS_OS_WINDOWS_95_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_WINDOWS_95", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_WINDOWS_95_jfieldId);
			}
		}

		static IntPtr IS_OS_WINDOWS_98_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_WINDOWS_98']"
		[Register ("IS_OS_WINDOWS_98")]
		public static bool IsOsWindows98 {
			get {
				if (IS_OS_WINDOWS_98_jfieldId == IntPtr.Zero)
					IS_OS_WINDOWS_98_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_WINDOWS_98", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_WINDOWS_98_jfieldId);
			}
		}

		static IntPtr IS_OS_WINDOWS_ME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_WINDOWS_ME']"
		[Register ("IS_OS_WINDOWS_ME")]
		public static bool IsOsWindowsMe {
			get {
				if (IS_OS_WINDOWS_ME_jfieldId == IntPtr.Zero)
					IS_OS_WINDOWS_ME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_WINDOWS_ME", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_WINDOWS_ME_jfieldId);
			}
		}

		static IntPtr IS_OS_WINDOWS_NT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_WINDOWS_NT']"
		[Register ("IS_OS_WINDOWS_NT")]
		public static bool IsOsWindowsNt {
			get {
				if (IS_OS_WINDOWS_NT_jfieldId == IntPtr.Zero)
					IS_OS_WINDOWS_NT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_WINDOWS_NT", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_WINDOWS_NT_jfieldId);
			}
		}

		static IntPtr IS_OS_WINDOWS_VISTA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_WINDOWS_VISTA']"
		[Register ("IS_OS_WINDOWS_VISTA")]
		public static bool IsOsWindowsVista {
			get {
				if (IS_OS_WINDOWS_VISTA_jfieldId == IntPtr.Zero)
					IS_OS_WINDOWS_VISTA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_WINDOWS_VISTA", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_WINDOWS_VISTA_jfieldId);
			}
		}

		static IntPtr IS_OS_WINDOWS_XP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_WINDOWS_XP']"
		[Register ("IS_OS_WINDOWS_XP")]
		public static bool IsOsWindowsXp {
			get {
				if (IS_OS_WINDOWS_XP_jfieldId == IntPtr.Zero)
					IS_OS_WINDOWS_XP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_WINDOWS_XP", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_WINDOWS_XP_jfieldId);
			}
		}

		static IntPtr IS_OS_ZOS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='IS_OS_ZOS']"
		[Register ("IS_OS_ZOS")]
		public static bool IsOsZos {
			get {
				if (IS_OS_ZOS_jfieldId == IntPtr.Zero)
					IS_OS_ZOS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IS_OS_ZOS", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, IS_OS_ZOS_jfieldId);
			}
		}

		static IntPtr JAVA_AWT_FONTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_AWT_FONTS']"
		[Register ("JAVA_AWT_FONTS")]
		public static string JavaAwtFonts {
			get {
				if (JAVA_AWT_FONTS_jfieldId == IntPtr.Zero)
					JAVA_AWT_FONTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_AWT_FONTS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_AWT_FONTS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_AWT_GRAPHICSENV_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_AWT_GRAPHICSENV']"
		[Register ("JAVA_AWT_GRAPHICSENV")]
		public static string JavaAwtGraphicsenv {
			get {
				if (JAVA_AWT_GRAPHICSENV_jfieldId == IntPtr.Zero)
					JAVA_AWT_GRAPHICSENV_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_AWT_GRAPHICSENV", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_AWT_GRAPHICSENV_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_AWT_HEADLESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_AWT_HEADLESS']"
		[Register ("JAVA_AWT_HEADLESS")]
		public static string JavaAwtHeadless {
			get {
				if (JAVA_AWT_HEADLESS_jfieldId == IntPtr.Zero)
					JAVA_AWT_HEADLESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_AWT_HEADLESS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_AWT_HEADLESS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_AWT_PRINTERJOB_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_AWT_PRINTERJOB']"
		[Register ("JAVA_AWT_PRINTERJOB")]
		public static string JavaAwtPrinterjob {
			get {
				if (JAVA_AWT_PRINTERJOB_jfieldId == IntPtr.Zero)
					JAVA_AWT_PRINTERJOB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_AWT_PRINTERJOB", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_AWT_PRINTERJOB_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_CLASS_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_CLASS_PATH']"
		[Register ("JAVA_CLASS_PATH")]
		public static string JavaClassPath {
			get {
				if (JAVA_CLASS_PATH_jfieldId == IntPtr.Zero)
					JAVA_CLASS_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_CLASS_PATH", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_CLASS_PATH_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_CLASS_VERSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_CLASS_VERSION']"
		[Register ("JAVA_CLASS_VERSION")]
		public static string JavaClassVersion {
			get {
				if (JAVA_CLASS_VERSION_jfieldId == IntPtr.Zero)
					JAVA_CLASS_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_CLASS_VERSION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_CLASS_VERSION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_COMPILER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_COMPILER']"
		[Register ("JAVA_COMPILER")]
		public static string JavaCompiler {
			get {
				if (JAVA_COMPILER_jfieldId == IntPtr.Zero)
					JAVA_COMPILER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_COMPILER", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_COMPILER_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_ENDORSED_DIRS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_ENDORSED_DIRS']"
		[Register ("JAVA_ENDORSED_DIRS")]
		public static string JavaEndorsedDirs {
			get {
				if (JAVA_ENDORSED_DIRS_jfieldId == IntPtr.Zero)
					JAVA_ENDORSED_DIRS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_ENDORSED_DIRS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_ENDORSED_DIRS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_EXT_DIRS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_EXT_DIRS']"
		[Register ("JAVA_EXT_DIRS")]
		public static string JavaExtDirs {
			get {
				if (JAVA_EXT_DIRS_jfieldId == IntPtr.Zero)
					JAVA_EXT_DIRS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_EXT_DIRS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_EXT_DIRS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_IO_TMPDIR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_IO_TMPDIR']"
		[Register ("JAVA_IO_TMPDIR")]
		public static string JavaIoTmpdir {
			get {
				if (JAVA_IO_TMPDIR_jfieldId == IntPtr.Zero)
					JAVA_IO_TMPDIR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_IO_TMPDIR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_IO_TMPDIR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_LIBRARY_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_LIBRARY_PATH']"
		[Register ("JAVA_LIBRARY_PATH")]
		public static string JavaLibraryPath {
			get {
				if (JAVA_LIBRARY_PATH_jfieldId == IntPtr.Zero)
					JAVA_LIBRARY_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_LIBRARY_PATH", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_LIBRARY_PATH_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_RUNTIME_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_RUNTIME_NAME']"
		[Register ("JAVA_RUNTIME_NAME")]
		public static string JavaRuntimeName {
			get {
				if (JAVA_RUNTIME_NAME_jfieldId == IntPtr.Zero)
					JAVA_RUNTIME_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_RUNTIME_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_RUNTIME_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_RUNTIME_VERSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_RUNTIME_VERSION']"
		[Register ("JAVA_RUNTIME_VERSION")]
		public static string JavaRuntimeVersion {
			get {
				if (JAVA_RUNTIME_VERSION_jfieldId == IntPtr.Zero)
					JAVA_RUNTIME_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_RUNTIME_VERSION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_RUNTIME_VERSION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_SPECIFICATION_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_SPECIFICATION_NAME']"
		[Register ("JAVA_SPECIFICATION_NAME")]
		public static string JavaSpecificationName {
			get {
				if (JAVA_SPECIFICATION_NAME_jfieldId == IntPtr.Zero)
					JAVA_SPECIFICATION_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_SPECIFICATION_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_SPECIFICATION_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_SPECIFICATION_VENDOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_SPECIFICATION_VENDOR']"
		[Register ("JAVA_SPECIFICATION_VENDOR")]
		public static string JavaSpecificationVendor {
			get {
				if (JAVA_SPECIFICATION_VENDOR_jfieldId == IntPtr.Zero)
					JAVA_SPECIFICATION_VENDOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_SPECIFICATION_VENDOR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_SPECIFICATION_VENDOR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_SPECIFICATION_VERSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_SPECIFICATION_VERSION']"
		[Register ("JAVA_SPECIFICATION_VERSION")]
		public static string JavaSpecificationVersion {
			get {
				if (JAVA_SPECIFICATION_VERSION_jfieldId == IntPtr.Zero)
					JAVA_SPECIFICATION_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_SPECIFICATION_VERSION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_SPECIFICATION_VERSION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_UTIL_PREFS_PREFERENCES_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_UTIL_PREFS_PREFERENCES_FACTORY']"
		[Register ("JAVA_UTIL_PREFS_PREFERENCES_FACTORY")]
		public static string JavaUtilPrefsPreferencesFactory {
			get {
				if (JAVA_UTIL_PREFS_PREFERENCES_FACTORY_jfieldId == IntPtr.Zero)
					JAVA_UTIL_PREFS_PREFERENCES_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_UTIL_PREFS_PREFERENCES_FACTORY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_UTIL_PREFS_PREFERENCES_FACTORY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_VENDOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_VENDOR']"
		[Register ("JAVA_VENDOR")]
		public static string JavaVendor {
			get {
				if (JAVA_VENDOR_jfieldId == IntPtr.Zero)
					JAVA_VENDOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_VENDOR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_VENDOR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_VENDOR_URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_VENDOR_URL']"
		[Register ("JAVA_VENDOR_URL")]
		public static string JavaVendorUrl {
			get {
				if (JAVA_VENDOR_URL_jfieldId == IntPtr.Zero)
					JAVA_VENDOR_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_VENDOR_URL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_VENDOR_URL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_VERSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_VERSION']"
		[Register ("JAVA_VERSION")]
		public static string JavaVersion {
			get {
				if (JAVA_VERSION_jfieldId == IntPtr.Zero)
					JAVA_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_VERSION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_VERSION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_VM_INFO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_VM_INFO']"
		[Register ("JAVA_VM_INFO")]
		public static string JavaVmInfo {
			get {
				if (JAVA_VM_INFO_jfieldId == IntPtr.Zero)
					JAVA_VM_INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_VM_INFO", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_VM_INFO_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_VM_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_VM_NAME']"
		[Register ("JAVA_VM_NAME")]
		public static string JavaVmName {
			get {
				if (JAVA_VM_NAME_jfieldId == IntPtr.Zero)
					JAVA_VM_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_VM_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_VM_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_VM_SPECIFICATION_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_VM_SPECIFICATION_NAME']"
		[Register ("JAVA_VM_SPECIFICATION_NAME")]
		public static string JavaVmSpecificationName {
			get {
				if (JAVA_VM_SPECIFICATION_NAME_jfieldId == IntPtr.Zero)
					JAVA_VM_SPECIFICATION_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_VM_SPECIFICATION_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_VM_SPECIFICATION_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_VM_SPECIFICATION_VENDOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_VM_SPECIFICATION_VENDOR']"
		[Register ("JAVA_VM_SPECIFICATION_VENDOR")]
		public static string JavaVmSpecificationVendor {
			get {
				if (JAVA_VM_SPECIFICATION_VENDOR_jfieldId == IntPtr.Zero)
					JAVA_VM_SPECIFICATION_VENDOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_VM_SPECIFICATION_VENDOR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_VM_SPECIFICATION_VENDOR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_VM_SPECIFICATION_VERSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_VM_SPECIFICATION_VERSION']"
		[Register ("JAVA_VM_SPECIFICATION_VERSION")]
		public static string JavaVmSpecificationVersion {
			get {
				if (JAVA_VM_SPECIFICATION_VERSION_jfieldId == IntPtr.Zero)
					JAVA_VM_SPECIFICATION_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_VM_SPECIFICATION_VERSION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_VM_SPECIFICATION_VERSION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_VM_VENDOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_VM_VENDOR']"
		[Register ("JAVA_VM_VENDOR")]
		public static string JavaVmVendor {
			get {
				if (JAVA_VM_VENDOR_jfieldId == IntPtr.Zero)
					JAVA_VM_VENDOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_VM_VENDOR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_VM_VENDOR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JAVA_VM_VERSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='JAVA_VM_VERSION']"
		[Register ("JAVA_VM_VERSION")]
		public static string JavaVmVersion {
			get {
				if (JAVA_VM_VERSION_jfieldId == IntPtr.Zero)
					JAVA_VM_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVA_VM_VERSION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JAVA_VM_VERSION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LINE_SEPARATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='LINE_SEPARATOR']"
		[Register ("LINE_SEPARATOR")]
		[Obsolete ("deprecated")]
		public static string LineSeparator {
			get {
				if (LINE_SEPARATOR_jfieldId == IntPtr.Zero)
					LINE_SEPARATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LINE_SEPARATOR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LINE_SEPARATOR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OS_ARCH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='OS_ARCH']"
		[Register ("OS_ARCH")]
		public static string OsArch {
			get {
				if (OS_ARCH_jfieldId == IntPtr.Zero)
					OS_ARCH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OS_ARCH", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OS_ARCH_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OS_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='OS_NAME']"
		[Register ("OS_NAME")]
		public static string OsName {
			get {
				if (OS_NAME_jfieldId == IntPtr.Zero)
					OS_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OS_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OS_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OS_VERSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='OS_VERSION']"
		[Register ("OS_VERSION")]
		public static string OsVersion {
			get {
				if (OS_VERSION_jfieldId == IntPtr.Zero)
					OS_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OS_VERSION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OS_VERSION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PATH_SEPARATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='PATH_SEPARATOR']"
		[Register ("PATH_SEPARATOR")]
		[Obsolete ("deprecated")]
		public static string PathSeparator {
			get {
				if (PATH_SEPARATOR_jfieldId == IntPtr.Zero)
					PATH_SEPARATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PATH_SEPARATOR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PATH_SEPARATOR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr USER_COUNTRY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='USER_COUNTRY']"
		[Register ("USER_COUNTRY")]
		public static string UserCountry {
			get {
				if (USER_COUNTRY_jfieldId == IntPtr.Zero)
					USER_COUNTRY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_COUNTRY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_COUNTRY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr USER_LANGUAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='USER_LANGUAGE']"
		[Register ("USER_LANGUAGE")]
		public static string UserLanguage {
			get {
				if (USER_LANGUAGE_jfieldId == IntPtr.Zero)
					USER_LANGUAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_LANGUAGE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_LANGUAGE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr USER_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='USER_NAME']"
		[Register ("USER_NAME")]
		public static string UserName {
			get {
				if (USER_NAME_jfieldId == IntPtr.Zero)
					USER_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr USER_TIMEZONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/field[@name='USER_TIMEZONE']"
		[Register ("USER_TIMEZONE")]
		public static string UserTimezone {
			get {
				if (USER_TIMEZONE_jfieldId == IntPtr.Zero)
					USER_TIMEZONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_TIMEZONE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_TIMEZONE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/SystemUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SystemUtils); }
		}

		protected SystemUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/constructor[@name='SystemUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SystemUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SystemUtils)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getHostName;
		public static unsafe string HostName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/method[@name='getHostName' and count(parameter)=0]"
			[Register ("getHostName", "()Ljava/lang/String;", "")]
			get {
				if (id_getHostName == IntPtr.Zero)
					id_getHostName = JNIEnv.GetStaticMethodID (class_ref, "getHostName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHostName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isJavaAwtHeadless;
		public static unsafe bool IsJavaAwtHeadless {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/method[@name='isJavaAwtHeadless' and count(parameter)=0]"
			[Register ("isJavaAwtHeadless", "()Z", "")]
			get {
				if (id_isJavaAwtHeadless == IntPtr.Zero)
					id_isJavaAwtHeadless = JNIEnv.GetStaticMethodID (class_ref, "isJavaAwtHeadless", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isJavaAwtHeadless);
				} finally {
				}
			}
		}

		static IntPtr id_getJavaHome;
		public static unsafe global::Java.IO.File JavaHome {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/method[@name='getJavaHome' and count(parameter)=0]"
			[Register ("getJavaHome", "()Ljava/io/File;", "")]
			get {
				if (id_getJavaHome == IntPtr.Zero)
					id_getJavaHome = JNIEnv.GetStaticMethodID (class_ref, "getJavaHome", "()Ljava/io/File;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getJavaHome), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getJavaIoTmpDir;
		public static unsafe global::Java.IO.File JavaIoTmpDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/method[@name='getJavaIoTmpDir' and count(parameter)=0]"
			[Register ("getJavaIoTmpDir", "()Ljava/io/File;", "")]
			get {
				if (id_getJavaIoTmpDir == IntPtr.Zero)
					id_getJavaIoTmpDir = JNIEnv.GetStaticMethodID (class_ref, "getJavaIoTmpDir", "()Ljava/io/File;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getJavaIoTmpDir), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getUserDir;
		public static unsafe global::Java.IO.File UserDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/method[@name='getUserDir' and count(parameter)=0]"
			[Register ("getUserDir", "()Ljava/io/File;", "")]
			get {
				if (id_getUserDir == IntPtr.Zero)
					id_getUserDir = JNIEnv.GetStaticMethodID (class_ref, "getUserDir", "()Ljava/io/File;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUserDir), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getUserHome;
		public static unsafe global::Java.IO.File UserHome {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/method[@name='getUserHome' and count(parameter)=0]"
			[Register ("getUserHome", "()Ljava/io/File;", "")]
			get {
				if (id_getUserHome == IntPtr.Zero)
					id_getUserHome = JNIEnv.GetStaticMethodID (class_ref, "getUserHome", "()Ljava/io/File;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUserHome), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getEnvironmentVariable_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/method[@name='getEnvironmentVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getEnvironmentVariable", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetEnvironmentVariable (string name, string defaultValue)
		{
			if (id_getEnvironmentVariable_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getEnvironmentVariable_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getEnvironmentVariable", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_defaultValue = JNIEnv.NewString (defaultValue);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (native_defaultValue);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEnvironmentVariable_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static IntPtr id_isJavaVersionAtLeast_Lorg_apache_commons_lang3_JavaVersion_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='SystemUtils']/method[@name='isJavaVersionAtLeast' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.JavaVersion']]"
		[Register ("isJavaVersionAtLeast", "(Lorg/apache/commons/lang3/JavaVersion;)Z", "")]
		public static unsafe bool IsJavaVersionAtLeast (global::Org.Apache.Commons.Lang3.JavaVersion requiredVersion)
		{
			if (id_isJavaVersionAtLeast_Lorg_apache_commons_lang3_JavaVersion_ == IntPtr.Zero)
				id_isJavaVersionAtLeast_Lorg_apache_commons_lang3_JavaVersion_ = JNIEnv.GetStaticMethodID (class_ref, "isJavaVersionAtLeast", "(Lorg/apache/commons/lang3/JavaVersion;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (requiredVersion);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isJavaVersionAtLeast_Lorg_apache_commons_lang3_JavaVersion_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
