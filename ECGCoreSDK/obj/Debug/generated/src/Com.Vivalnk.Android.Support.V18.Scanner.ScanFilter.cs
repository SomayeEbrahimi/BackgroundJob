using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Android.Support.V18.Scanner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']"
	[global::Android.Runtime.Register ("com/vivalnk/android/support/v18/scanner/ScanFilter", DoNotGenerateAcw=true)]
	public sealed partial class ScanFilter : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']"
		[global::Android.Runtime.Register ("com/vivalnk/android/support/v18/scanner/ScanFilter$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/android/support/v18/scanner/ScanFilter$Builder", typeof (Builder));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/constructor[@name='ScanFilter.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/vivalnk/android/support/v18/scanner/ScanFilter;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter Build ()
			{
				const string __id = "build.()Lcom/vivalnk/android/support/v18/scanner/ScanFilter;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setDeviceAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceAddress", "(Ljava/lang/String;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetDeviceAddress (string deviceAddress)
			{
				const string __id = "setDeviceAddress.(Ljava/lang/String;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;";
				IntPtr native_deviceAddress = JNIEnv.NewString (deviceAddress);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_deviceAddress);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_deviceAddress);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setDeviceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceName", "(Ljava/lang/String;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetDeviceName (string deviceName)
			{
				const string __id = "setDeviceName.(Ljava/lang/String;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;";
				IntPtr native_deviceName = JNIEnv.NewString (deviceName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_deviceName);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_deviceName);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setManufacturerData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register ("setManufacturerData", "(I[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetManufacturerData (int manufacturerId, byte[] manufacturerData)
			{
				const string __id = "setManufacturerData.(I[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;";
				IntPtr native_manufacturerData = JNIEnv.NewArray (manufacturerData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (manufacturerId);
					__args [1] = new JniArgumentValue (native_manufacturerData);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (manufacturerData != null) {
						JNIEnv.CopyArray (native_manufacturerData, manufacturerData);
						JNIEnv.DeleteLocalRef (native_manufacturerData);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setManufacturerData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("setManufacturerData", "(I[B[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetManufacturerData (int manufacturerId, byte[] manufacturerData, byte[] manufacturerDataMask)
			{
				const string __id = "setManufacturerData.(I[B[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;";
				IntPtr native_manufacturerData = JNIEnv.NewArray (manufacturerData);
				IntPtr native_manufacturerDataMask = JNIEnv.NewArray (manufacturerDataMask);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (manufacturerId);
					__args [1] = new JniArgumentValue (native_manufacturerData);
					__args [2] = new JniArgumentValue (native_manufacturerDataMask);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setServiceData' and count(parameter)=2 and parameter[1][@type='android.os.ParcelUuid'] and parameter[2][@type='byte[]']]"
			[Register ("setServiceData", "(Landroid/os/ParcelUuid;[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetServiceData (global::Android.OS.ParcelUuid serviceDataUuid, byte[] serviceData)
			{
				const string __id = "setServiceData.(Landroid/os/ParcelUuid;[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;";
				IntPtr native_serviceData = JNIEnv.NewArray (serviceData);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((serviceDataUuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serviceDataUuid).Handle);
					__args [1] = new JniArgumentValue (native_serviceData);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (serviceData != null) {
						JNIEnv.CopyArray (native_serviceData, serviceData);
						JNIEnv.DeleteLocalRef (native_serviceData);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setServiceData' and count(parameter)=3 and parameter[1][@type='android.os.ParcelUuid'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
			[Register ("setServiceData", "(Landroid/os/ParcelUuid;[B[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetServiceData (global::Android.OS.ParcelUuid serviceDataUuid, byte[] serviceData, byte[] serviceDataMask)
			{
				const string __id = "setServiceData.(Landroid/os/ParcelUuid;[B[B)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;";
				IntPtr native_serviceData = JNIEnv.NewArray (serviceData);
				IntPtr native_serviceDataMask = JNIEnv.NewArray (serviceDataMask);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((serviceDataUuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serviceDataUuid).Handle);
					__args [1] = new JniArgumentValue (native_serviceData);
					__args [2] = new JniArgumentValue (native_serviceDataMask);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setServiceUuid' and count(parameter)=1 and parameter[1][@type='android.os.ParcelUuid']]"
			[Register ("setServiceUuid", "(Landroid/os/ParcelUuid;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetServiceUuid (global::Android.OS.ParcelUuid serviceUuid)
			{
				const string __id = "setServiceUuid.(Landroid/os/ParcelUuid;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((serviceUuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serviceUuid).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter.Builder']/method[@name='setServiceUuid' and count(parameter)=2 and parameter[1][@type='android.os.ParcelUuid'] and parameter[2][@type='android.os.ParcelUuid']]"
			[Register ("setServiceUuid", "(Landroid/os/ParcelUuid;Landroid/os/ParcelUuid;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;", "")]
			public unsafe global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder SetServiceUuid (global::Android.OS.ParcelUuid serviceUuid, global::Android.OS.ParcelUuid uuidMask)
			{
				const string __id = "setServiceUuid.(Landroid/os/ParcelUuid;Landroid/os/ParcelUuid;)Lcom/vivalnk/android/support/v18/scanner/ScanFilter$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((serviceUuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serviceUuid).Handle);
					__args [1] = new JniArgumentValue ((uuidMask == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uuidMask).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Android.Support.V18.Scanner.ScanFilter.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/android/support/v18/scanner/ScanFilter", typeof (ScanFilter));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal ScanFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe string DeviceAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getDeviceAddress' and count(parameter)=0]"
			[Register ("getDeviceAddress", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDeviceAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDeviceName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int ManufacturerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getManufacturerId' and count(parameter)=0]"
			[Register ("getManufacturerId", "()I", "")]
			get {
				const string __id = "getManufacturerId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.OS.ParcelUuid ServiceDataUuid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getServiceDataUuid' and count(parameter)=0]"
			[Register ("getServiceDataUuid", "()Landroid/os/ParcelUuid;", "")]
			get {
				const string __id = "getServiceDataUuid.()Landroid/os/ParcelUuid;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelUuid> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.OS.ParcelUuid ServiceUuid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getServiceUuid' and count(parameter)=0]"
			[Register ("getServiceUuid", "()Landroid/os/ParcelUuid;", "")]
			get {
				const string __id = "getServiceUuid.()Landroid/os/ParcelUuid;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelUuid> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.OS.ParcelUuid ServiceUuidMask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getServiceUuidMask' and count(parameter)=0]"
			[Register ("getServiceUuidMask", "()Landroid/os/ParcelUuid;", "")]
			get {
				const string __id = "getServiceUuidMask.()Landroid/os/ParcelUuid;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelUuid> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getManufacturerData' and count(parameter)=0]"
		[Register ("getManufacturerData", "()[B", "")]
		public unsafe byte[] GetManufacturerData ()
		{
			const string __id = "getManufacturerData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getManufacturerDataMask' and count(parameter)=0]"
		[Register ("getManufacturerDataMask", "()[B", "")]
		public unsafe byte[] GetManufacturerDataMask ()
		{
			const string __id = "getManufacturerDataMask.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getServiceData' and count(parameter)=0]"
		[Register ("getServiceData", "()[B", "")]
		public unsafe byte[] GetServiceData ()
		{
			const string __id = "getServiceData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='getServiceDataMask' and count(parameter)=0]"
		[Register ("getServiceDataMask", "()[B", "")]
		public unsafe byte[] GetServiceDataMask ()
		{
			const string __id = "getServiceDataMask.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='matches' and count(parameter)=1 and parameter[1][@type='com.vivalnk.android.support.v18.scanner.ScanResult']]"
		[Register ("matches", "(Lcom/vivalnk/android/support/v18/scanner/ScanResult;)Z", "")]
		public unsafe bool Matches (global::Com.Vivalnk.Android.Support.V18.Scanner.ScanResult scanResult)
		{
			const string __id = "matches.(Lcom/vivalnk/android/support/v18/scanner/ScanResult;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((scanResult == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scanResult).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanFilter']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
