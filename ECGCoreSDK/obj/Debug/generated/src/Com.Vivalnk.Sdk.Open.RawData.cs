using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Open {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='RawData']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/open/RawData", DoNotGenerateAcw=true)]
	public partial class RawData : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='RawData']/field[@name='data']"
		[Register ("data")]
		public global::Com.Vivalnk.Sdk.Model.SampleData Data {
			get {
				const string __id = "data.Lcom/vivalnk/sdk/model/SampleData;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "data.Lcom/vivalnk/sdk/model/SampleData;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='RawData']/field[@name='device']"
		[Register ("device")]
		public global::Com.Vivalnk.Sdk.Model.Device Device {
			get {
				const string __id = "device.Lcom/vivalnk/sdk/model/Device;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Device> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "device.Lcom/vivalnk/sdk/model/Device;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/open/RawData", typeof (RawData));
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

		protected RawData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='RawData']/constructor[@name='RawData' and count(parameter)=2 and parameter[1][@type='com.vivalnk.sdk.model.SampleData'] and parameter[2][@type='com.vivalnk.sdk.model.Device']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/model/SampleData;Lcom/vivalnk/sdk/model/Device;)V", "")]
		public unsafe RawData (global::Com.Vivalnk.Sdk.Model.SampleData p0, global::Com.Vivalnk.Sdk.Model.Device p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/vivalnk/sdk/model/SampleData;Lcom/vivalnk/sdk/model/Device;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
