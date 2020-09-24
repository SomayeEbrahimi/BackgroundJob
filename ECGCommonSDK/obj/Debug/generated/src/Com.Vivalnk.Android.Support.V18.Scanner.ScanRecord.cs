using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Android.Support.V18.Scanner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']"
	[global::Android.Runtime.Register ("com/vivalnk/android/support/v18/scanner/ScanRecord", DoNotGenerateAcw=true)]
	public sealed partial class ScanRecord : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/android/support/v18/scanner/ScanRecord", typeof (ScanRecord));
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

		internal ScanRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int AdvertiseFlags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getAdvertiseFlags' and count(parameter)=0]"
			[Register ("getAdvertiseFlags", "()I", "")]
			get {
				const string __id = "getAdvertiseFlags.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getDeviceName' and count(parameter)=0]"
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

		public unsafe global::Android.Util.SparseArray ManufacturerSpecificData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getManufacturerSpecificData' and count(parameter)=0]"
			[Register ("getManufacturerSpecificData", "()Landroid/util/SparseArray;", "")]
			get {
				const string __id = "getManufacturerSpecificData.()Landroid/util/SparseArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IDictionary<global::Android.OS.ParcelUuid, byte[]> ServiceData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getServiceData' and count(parameter)=0]"
			[Register ("getServiceData", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getServiceData.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<global::Android.OS.ParcelUuid, byte[]>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Android.OS.ParcelUuid> ServiceUuids {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getServiceUuids' and count(parameter)=0]"
			[Register ("getServiceUuids", "()Ljava/util/List;", "")]
			get {
				const string __id = "getServiceUuids.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Android.OS.ParcelUuid>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int TxPowerLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getTxPowerLevel' and count(parameter)=0]"
			[Register ("getTxPowerLevel", "()I", "")]
			get {
				const string __id = "getTxPowerLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getBytes' and count(parameter)=0]"
		[Register ("getBytes", "()[B", "")]
		public unsafe byte[] GetBytes ()
		{
			const string __id = "getBytes.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getManufacturerSpecificData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getManufacturerSpecificData", "(I)[B", "")]
		public unsafe byte[] GetManufacturerSpecificData (int manufacturerId)
		{
			const string __id = "getManufacturerSpecificData.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (manufacturerId);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.android.support.v18.scanner']/class[@name='ScanRecord']/method[@name='getServiceData' and count(parameter)=1 and parameter[1][@type='android.os.ParcelUuid']]"
		[Register ("getServiceData", "(Landroid/os/ParcelUuid;)[B", "")]
		public unsafe byte[] GetServiceData (global::Android.OS.ParcelUuid serviceDataUuid)
		{
			const string __id = "getServiceData.(Landroid/os/ParcelUuid;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((serviceDataUuid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serviceDataUuid).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
