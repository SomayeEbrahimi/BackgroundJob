using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Android.Support.V18.Scanner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']"
	[global::Android.Runtime.Register ("com/vivalnk/android/support/v18/scanner/ScanRecord", DoNotGenerateAcw=true)]
	public sealed partial class ScanRecord : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/android/support/v18/scanner/ScanRecord", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScanRecord); }
		}

		internal ScanRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAdvertiseFlags;
		public unsafe int AdvertiseFlags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getAdvertiseFlags' and count(parameter)=0]"
			[Register ("getAdvertiseFlags", "()I", "")]
			get {
				if (id_getAdvertiseFlags == IntPtr.Zero)
					id_getAdvertiseFlags = JNIEnv.GetMethodID (class_ref, "getAdvertiseFlags", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdvertiseFlags);
				} finally {
				}
			}
		}

		static IntPtr id_getDeviceName;
		public unsafe string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getDeviceName' and count(parameter)=0]"
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

		static IntPtr id_getManufacturerSpecificData;
		public unsafe global::Android.Util.SparseArray ManufacturerSpecificData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getManufacturerSpecificData' and count(parameter)=0]"
			[Register ("getManufacturerSpecificData", "()Landroid/util/SparseArray;", "")]
			get {
				if (id_getManufacturerSpecificData == IntPtr.Zero)
					id_getManufacturerSpecificData = JNIEnv.GetMethodID (class_ref, "getManufacturerSpecificData", "()Landroid/util/SparseArray;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getManufacturerSpecificData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getServiceData;
		public unsafe global::System.Collections.Generic.IDictionary<global::Android.OS.ParcelUuid, byte[]> ServiceData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getServiceData' and count(parameter)=0]"
			[Register ("getServiceData", "()Ljava/util/Map;", "")]
			get {
				if (id_getServiceData == IntPtr.Zero)
					id_getServiceData = JNIEnv.GetMethodID (class_ref, "getServiceData", "()Ljava/util/Map;");
				try {
					return global::Android.Runtime.JavaDictionary<global::Android.OS.ParcelUuid, byte[]>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getServiceUuids;
		public unsafe global::System.Collections.Generic.IList<global::Android.OS.ParcelUuid> ServiceUuids {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getServiceUuids' and count(parameter)=0]"
			[Register ("getServiceUuids", "()Ljava/util/List;", "")]
			get {
				if (id_getServiceUuids == IntPtr.Zero)
					id_getServiceUuids = JNIEnv.GetMethodID (class_ref, "getServiceUuids", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Android.OS.ParcelUuid>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceUuids), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTxPowerLevel;
		public unsafe int TxPowerLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getTxPowerLevel' and count(parameter)=0]"
			[Register ("getTxPowerLevel", "()I", "")]
			get {
				if (id_getTxPowerLevel == IntPtr.Zero)
					id_getTxPowerLevel = JNIEnv.GetMethodID (class_ref, "getTxPowerLevel", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTxPowerLevel);
				} finally {
				}
			}
		}

		static IntPtr id_getBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getBytes' and count(parameter)=0]"
		[Register ("getBytes", "()[B", "")]
		public unsafe byte[] GetBytes ()
		{
			if (id_getBytes == IntPtr.Zero)
				id_getBytes = JNIEnv.GetMethodID (class_ref, "getBytes", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getManufacturerSpecificData_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getManufacturerSpecificData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getManufacturerSpecificData", "(I)[B", "")]
		public unsafe byte[] GetManufacturerSpecificData (int manufacturerId)
		{
			if (id_getManufacturerSpecificData_I == IntPtr.Zero)
				id_getManufacturerSpecificData_I = JNIEnv.GetMethodID (class_ref, "getManufacturerSpecificData", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (manufacturerId);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getManufacturerSpecificData_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getServiceData_Landroid_os_ParcelUuid_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getServiceData' and count(parameter)=1 and parameter[1][@type='android.os.ParcelUuid']]"
		[Register ("getServiceData", "(Landroid/os/ParcelUuid;)[B", "")]
		public unsafe byte[] GetServiceData (global::Android.OS.ParcelUuid serviceDataUuid)
		{
			if (id_getServiceData_Landroid_os_ParcelUuid_ == IntPtr.Zero)
				id_getServiceData_Landroid_os_ParcelUuid_ = JNIEnv.GetMethodID (class_ref, "getServiceData", "(Landroid/os/ParcelUuid;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (serviceDataUuid);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceData_Landroid_os_ParcelUuid_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

	}
}
