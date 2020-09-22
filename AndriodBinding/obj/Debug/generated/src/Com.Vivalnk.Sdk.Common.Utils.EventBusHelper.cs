using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='EventBusHelper']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/EventBusHelper", DoNotGenerateAcw=true)]
	public partial class EventBusHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/EventBusHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventBusHelper); }
		}

		protected EventBusHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='EventBusHelper']/constructor[@name='EventBusHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventBusHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EventBusHelper)) {
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

		static IntPtr id_getDefault;
		public static unsafe global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus Default {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='EventBusHelper']/method[@name='getDefault' and count(parameter)=0]"
			[Register ("getDefault", "()Lcom/vivalnk/sdk/common/eventbus/EventBus;", "")]
			get {
				if (id_getDefault == IntPtr.Zero)
					id_getDefault = JNIEnv.GetStaticMethodID (class_ref, "getDefault", "()Lcom/vivalnk/sdk/common/eventbus/EventBus;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Common.Eventbus.EventBus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefault), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_register_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='EventBusHelper']/method[@name='register' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("register", "(Ljava/lang/Object;)V", "")]
		public static unsafe void Register (global::Java.Lang.Object obj)
		{
			if (id_register_Ljava_lang_Object_ == IntPtr.Zero)
				id_register_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "register", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_register_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_unregister_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='EventBusHelper']/method[@name='unregister' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("unregister", "(Ljava/lang/Object;)V", "")]
		public static unsafe void Unregister (global::Java.Lang.Object obj)
		{
			if (id_unregister_Ljava_lang_Object_ == IntPtr.Zero)
				id_unregister_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "unregister", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unregister_Ljava_lang_Object_, __args);
			} finally {
			}
		}

	}
}
