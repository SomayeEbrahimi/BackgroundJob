using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Data.Stream.Packagelost {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.packagelost']/class[@name='DisContinuousEvent']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/data/stream/packagelost/DisContinuousEvent", DoNotGenerateAcw=true)]
	public partial class DisContinuousEvent : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.packagelost']/class[@name='DisContinuousEvent']/field[@name='curTime']"
		[Register ("curTime")]
		public long CurTime {
			get {
				const string __id = "curTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "curTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.packagelost']/class[@name='DisContinuousEvent']/field[@name='device']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.packagelost']/class[@name='DisContinuousEvent']/field[@name='flash']"
		[Register ("flash")]
		public bool Flash {
			get {
				const string __id = "flash.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "flash.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.packagelost']/class[@name='DisContinuousEvent']/field[@name='msg']"
		[Register ("msg")]
		public string Msg {
			get {
				const string __id = "msg.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "msg.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.packagelost']/class[@name='DisContinuousEvent']/field[@name='preTime']"
		[Register ("preTime")]
		public long PreTime {
			get {
				const string __id = "preTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "preTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.packagelost']/class[@name='DisContinuousEvent']/field[@name='sOpenEvent']"
		[Register ("sOpenEvent")]
		public static bool SOpenEvent {
			get {
				const string __id = "sOpenEvent.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "sOpenEvent.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/data/stream/packagelost/DisContinuousEvent", typeof (DisContinuousEvent));
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

		protected DisContinuousEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.packagelost']/class[@name='DisContinuousEvent']/constructor[@name='DisContinuousEvent' and count(parameter)=5 and parameter[1][@type='com.vivalnk.sdk.model.Device'] and parameter[2][@type='boolean'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/model/Device;ZJJLjava/lang/String;)V", "")]
		public unsafe DisContinuousEvent (global::Com.Vivalnk.Sdk.Model.Device p0, bool p1, long p2, long p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/vivalnk/sdk/model/Device;ZJJLjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.packagelost']/class[@name='DisContinuousEvent']/method[@name='closeEvent' and count(parameter)=0]"
		[Register ("closeEvent", "()V", "")]
		public static unsafe void CloseEvent ()
		{
			const string __id = "closeEvent.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.data.stream.packagelost']/class[@name='DisContinuousEvent']/method[@name='openEvent' and count(parameter)=0]"
		[Register ("openEvent", "()V", "")]
		public static unsafe void OpenEvent ()
		{
			const string __id = "openEvent.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
