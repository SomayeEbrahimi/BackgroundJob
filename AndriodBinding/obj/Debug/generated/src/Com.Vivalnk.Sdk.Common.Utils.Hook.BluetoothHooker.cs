using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Hook {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook']/class[@name='BluetoothHooker']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/hook/BluetoothHooker", DoNotGenerateAcw=true)]
	public partial class BluetoothHooker : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/hook/BluetoothHooker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BluetoothHooker); }
		}

		protected BluetoothHooker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook']/class[@name='BluetoothHooker']/constructor[@name='BluetoothHooker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BluetoothHooker ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BluetoothHooker)) {
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

		static IntPtr id_hook;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.hook']/class[@name='BluetoothHooker']/method[@name='hook' and count(parameter)=0]"
		[Register ("hook", "()V", "")]
		public static unsafe void Hook ()
		{
			if (id_hook == IntPtr.Zero)
				id_hook = JNIEnv.GetStaticMethodID (class_ref, "hook", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_hook);
			} finally {
			}
		}

	}
}
