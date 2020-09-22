using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Android.Support.V18.Scanner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']"
	[global::Android.Runtime.Register ("com/vivalnk/android/support/v18/scanner/ScanFilter", DoNotGenerateAcw=true)]
	public sealed partial class ScanFilter : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']"
		[global::Android.Runtime.Register ("com/vivalnk/android/support/v18/scanner/ScanFilter$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/vivalnk/android/support/v18/scanner/ScanFilter$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/constructor[@name='ScanFilter.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/vivalnk/android/support/v18/scanner/ScanFilter;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/vivalnk/android/support/v18/scanner/ScanFilter;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setDeviceAddress_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setDeviceAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceAddress", "(Ljava/lang/String;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetDeviceAddress (string deviceAddress)
			{
				if (id_setDeviceAddress_Ljava_lang_String_ == IntPtr.Zero)
					id_setDeviceAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceAddress", "(Ljava/lang/String;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;");
				IntPtr native_deviceAddress = JNIEnv.NewString (deviceAddress);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_deviceAddress);
					global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceAddress_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_deviceAddress);
				}
			}

			static IntPtr id_setDeviceName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setDeviceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceName", "(Ljava/lang/String;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetDeviceName (string deviceName)
			{
				if (id_setDeviceName_Ljava_lang_String_ == IntPtr.Zero)
					id_setDeviceName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceName", "(Ljava/lang/String;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;");
				IntPtr native_deviceName = JNIEnv.NewString (deviceName);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_deviceName);
					global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_deviceName);
				}
			}

			static IntPtr id_setManufacturerData_IarrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setManufacturerData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("setManufacturerData", "(I[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetManufacturerData (int manufacturerId, byte[] manufacturerData)
			{
				if (id_setManufacturerData_IarrayB == IntPtr.Zero)
					id_setManufacturerData_IarrayB = JNIEnv.GetMethodID (class_ref, "setManufacturerData", "(I[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;");
				IntPtr native_manufacturerData = JNIEnv.NewArray (manufacturerData);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (manufacturerId);
					__args [1] = new JValue (native_manufacturerData);
					global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setManufacturerData_IarrayB, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (manufacturerData != null) {
						JNIEnv.CopyArray (native_manufacturerData, manufacturerData);
						JNIEnv.DeleteLocalRef (native_manufacturerData);
					}
				}
			}

			static IntPtr id_setManufacturerData_IarrayBarrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setManufacturerData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("setManufacturerData", "(I[B[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetManufacturerData (int manufacturerId, byte[] manufacturerData, byte[] manufacturerDataMask)
			{
				if (id_setManufacturerData_IarrayBarrayB == IntPtr.Zero)
					id_setManufacturerData_IarrayBarrayB = JNIEnv.GetMethodID (class_ref, "setManufacturerData", "(I[B[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;");
				IntPtr native_manufacturerData = JNIEnv.NewArray (manufacturerData);
				IntPtr native_manufacturerDataMask = JNIEnv.NewArray (manufacturerDataMask);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (manufacturerId);
					__args [1] = new JValue (native_manufacturerData);
					__args [2] = new JValue (native_manufacturerDataMask);
					global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setManufacturerData_IarrayBarrayB, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (manufacturerData != null) {
						JNIEnv.CopyArray (native_manufacturerData, manufacturerData);
						JNIEnv.DeleteLocalRef (native_manufacturerData);
					}
					if (manufacturerDataMask != null) {
						JNIEnv.CopyArray (native_manufacturerDataMask, manufacturerDataMask);
						JNIEnv.DeleteLocalRef (native_manufacturerDataMask);
					}
				}
			}

			static IntPtr id_setServiceData_Landroid_os_ParcelUuid_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setServiceData' and count(parameter)=2 and parameter[1][@type='android.os.ParcelUuid'] and parameter[2][@type='byte[]']]"
			[Register ("setServiceData", "(Landroid/os/ParcelUuid;[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetServiceData (global::Android.OS.ParcelUuid serviceDataUuid, byte[] serviceData)
			{
				if (id_setServiceData_Landroid_os_ParcelUuid_arrayB == IntPtr.Zero)
					id_setServiceData_Landroid_os_ParcelUuid_arrayB = JNIEnv.GetMethodID (class_ref, "setServiceData", "(Landroid/os/ParcelUuid;[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;");
				IntPtr native_serviceData = JNIEnv.NewArray (serviceData);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (serviceDataUuid);
					__args [1] = new JValue (native_serviceData);
					global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setServiceData_Landroid_os_ParcelUuid_arrayB, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (serviceData != null) {
						JNIEnv.CopyArray (native_serviceData, serviceData);
						JNIEnv.DeleteLocalRef (native_serviceData);
					}
				}
			}

			static IntPtr id_setServiceData_Landroid_os_ParcelUuid_arrayBarrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setServiceData' and count(parameter)=3 and parameter[1][@type='android.os.ParcelUuid'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("setServiceData", "(Landroid/os/ParcelUuid;[B[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetServiceData (global::Android.OS.ParcelUuid serviceDataUuid, byte[] serviceData, byte[] serviceDataMask)
			{
				if (id_setServiceData_Landroid_os_ParcelUuid_arrayBarrayB == IntPtr.Zero)
					id_setServiceData_Landroid_os_ParcelUuid_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "setServiceData", "(Landroid/os/ParcelUuid;[B[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;");
				IntPtr native_serviceData = JNIEnv.NewArray (serviceData);
				IntPtr native_serviceDataMask = JNIEnv.NewArray (serviceDataMask);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (serviceDataUuid);
					__args [1] = new JValue (native_serviceData);
					__args [2] = new JValue (native_serviceDataMask);
					global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setServiceData_Landroid_os_ParcelUuid_arrayBarrayB, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (serviceData != null) {
						JNIEnv.CopyArray (native_serviceData, serviceData);
						JNIEnv.DeleteLocalRef (native_serviceData);
					}
					if (serviceDataMask != null) {
						JNIEnv.CopyArray (native_serviceDataMask, serviceDataMask);
						JNIEnv.DeleteLocalRef (native_serviceDataMask);
					}
				}
			}

			static IntPtr id_setServiceUuid_Landroid_os_ParcelUuid_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setServiceUuid' and count(parameter)=1 and parameter[1][@type='android.os.ParcelUuid']]"
			[Register ("setServiceUuid", "(Landroid/os/ParcelUuid;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetServiceUuid (global::Android.OS.ParcelUuid serviceUuid)
			{
				if (id_setServiceUuid_Landroid_os_ParcelUuid_ == IntPtr.Zero)
					id_setServiceUuid_Landroid_os_ParcelUuid_ = JNIEnv.GetMethodID (class_ref, "setServiceUuid", "(Landroid/os/ParcelUuid;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (serviceUuid);
					global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setServiceUuid_Landroid_os_ParcelUuid_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_setServiceUuid_Landroid_os_ParcelUuid_Landroid_os_ParcelUuid_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setServiceUuid' and count(parameter)=2 and parameter[1][@type='android.os.ParcelUuid'] and parameter[2][@type='android.os.ParcelUuid']]"
			[Register ("setServiceUuid", "(Landroid/os/ParcelUuid;Landroid/os/ParcelUuid;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetServiceUuid (global::Android.OS.ParcelUuid serviceUuid, global::Android.OS.ParcelUuid uuidMask)
			{
				if (id_setServiceUuid_Landroid_os_ParcelUuid_Landroid_os_ParcelUuid_ == IntPtr.Zero)
					id_setServiceUuid_Landroid_os_ParcelUuid_Landroid_os_ParcelUuid_ = JNIEnv.GetMethodID (class_ref, "setServiceUuid", "(Landroid/os/ParcelUuid;Landroid/os/ParcelUuid;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (serviceUuid);
					__args [1] = new JValue (uuidMask);
					global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setServiceUuid_Landroid_os_ParcelUuid_Landroid_os_ParcelUuid_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/android/support/v18/scanner/ScanFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScanFilter); }
		}

		internal ScanFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDeviceAddress;
		public unsafe string DeviceAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getDeviceAddress' and count(parameter)=0]"
			[Register ("getDeviceAddress", "()Ljava/lang/String;", "")]
			get {
				if (id_getDeviceAddress == IntPtr.Zero)
					id_getDeviceAddress = JNIEnv.GetMethodID (class_ref, "getDeviceAddress", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceAddress), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDeviceName;
		public unsafe string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "")]
			get {
				if (id_getDeviceName == IntPtr.Zero)
					id_getDeviceName = JNIEnv.GetMethodID (class_ref, "getDeviceName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getManufacturerId;
		public unsafe int ManufacturerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getManufacturerId' and count(parameter)=0]"
			[Register ("getManufacturerId", "()I", "")]
			get {
				if (id_getManufacturerId == IntPtr.Zero)
					id_getManufacturerId = JNIEnv.GetMethodID (class_ref, "getManufacturerId", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getManufacturerId);
				} finally {
				}
			}
		}

		static IntPtr id_getServiceDataUuid;
		public unsafe global::Android.OS.ParcelUuid ServiceDataUuid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getServiceDataUuid' and count(parameter)=0]"
			[Register ("getServiceDataUuid", "()Landroid/os/ParcelUuid;", "")]
			get {
				if (id_getServiceDataUuid == IntPtr.Zero)
					id_getServiceDataUuid = JNIEnv.GetMethodID (class_ref, "getServiceDataUuid", "()Landroid/os/ParcelUuid;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelUuid> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceDataUuid), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getServiceUuid;
		public unsafe global::Android.OS.ParcelUuid ServiceUuid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getServiceUuid' and count(parameter)=0]"
			[Register ("getServiceUuid", "()Landroid/os/ParcelUuid;", "")]
			get {
				if (id_getServiceUuid == IntPtr.Zero)
					id_getServiceUuid = JNIEnv.GetMethodID (class_ref, "getServiceUuid", "()Landroid/os/ParcelUuid;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelUuid> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceUuid), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getServiceUuidMask;
		public unsafe global::Android.OS.ParcelUuid ServiceUuidMask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getServiceUuidMask' and count(parameter)=0]"
			[Register ("getServiceUuidMask", "()Landroid/os/ParcelUuid;", "")]
			get {
				if (id_getServiceUuidMask == IntPtr.Zero)
					id_getServiceUuidMask = JNIEnv.GetMethodID (class_ref, "getServiceUuidMask", "()Landroid/os/ParcelUuid;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelUuid> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceUuidMask), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_getManufacturerData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getManufacturerData' and count(parameter)=0]"
		[Register ("getManufacturerData", "()[B", "")]
		public unsafe byte[] GetManufacturerData ()
		{
			if (id_getManufacturerData == IntPtr.Zero)
				id_getManufacturerData = JNIEnv.GetMethodID (class_ref, "getManufacturerData", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getManufacturerData), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getManufacturerDataMask;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getManufacturerDataMask' and count(parameter)=0]"
		[Register ("getManufacturerDataMask", "()[B", "")]
		public unsafe byte[] GetManufacturerDataMask ()
		{
			if (id_getManufacturerDataMask == IntPtr.Zero)
				id_getManufacturerDataMask = JNIEnv.GetMethodID (class_ref, "getManufacturerDataMask", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getManufacturerDataMask), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getServiceData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getServiceData' and count(parameter)=0]"
		[Register ("getServiceData", "()[B", "")]
		public unsafe byte[] GetServiceData ()
		{
			if (id_getServiceData == IntPtr.Zero)
				id_getServiceData = JNIEnv.GetMethodID (class_ref, "getServiceData", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceData), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getServiceDataMask;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getServiceDataMask' and count(parameter)=0]"
		[Register ("getServiceDataMask", "()[B", "")]
		public unsafe byte[] GetServiceDataMask ()
		{
			if (id_getServiceDataMask == IntPtr.Zero)
				id_getServiceDataMask = JNIEnv.GetMethodID (class_ref, "getServiceDataMask", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceDataMask), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_matches_Lcom_vivalnk_android_support_v18_scanner_ScanResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='matches' and count(parameter)=1 and parameter[1][@type='com.vivalnk.android.support.v18.scanner.ScanResult']]"
		[Register ("matches", "(Lcom/vivalnk/android/support/v18/scanner/ScanResult;)Z", "")]
		public unsafe bool Matches (global::Com.Vivalnk.Android.Support.V18.Scanner.ScanResult scanResult)
		{
			if (id_matches_Lcom_vivalnk_android_support_v18_scanner_ScanResult_ == IntPtr.Zero)
				id_matches_Lcom_vivalnk_android_support_v18_scanner_ScanResult_ = JNIEnv.GetMethodID (class_ref, "matches", "(Lcom/vivalnk/android/support/v18/scanner/ScanResult;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scanResult);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_matches_Lcom_vivalnk_android_support_v18_scanner_ScanResult_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
