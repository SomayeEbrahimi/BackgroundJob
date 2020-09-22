using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Ble.Connect.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='BluetoothStateEvent']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/ble/connect/event/BluetoothStateEvent", DoNotGenerateAcw=true)]
	public partial class BluetoothStateEvent : global::Java.Lang.Object {


		static IntPtr state_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='BluetoothStateEvent']/field[@name='state']"
		[Register ("state")]
		public int State {
			get {
				if (state_jfieldId == IntPtr.Zero)
					state_jfieldId = JNIEnv.GetFieldID (class_ref, "state", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, state_jfieldId);
			}
			set {
				if (state_jfieldId == IntPtr.Zero)
					state_jfieldId = JNIEnv.GetFieldID (class_ref, "state", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, state_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/ble/connect/event/BluetoothStateEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BluetoothStateEvent); }
		}

		protected BluetoothStateEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.ble.connect.event']/class[@name='BluetoothStateEvent']/constructor[@name='BluetoothStateEvent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe BluetoothStateEvent (int state)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (state);
				if (((object) this).GetType () != typeof (BluetoothStateEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

	}
}
