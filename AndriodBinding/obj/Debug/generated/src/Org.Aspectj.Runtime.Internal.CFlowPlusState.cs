using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Runtime.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowPlusState']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/CFlowPlusState", DoNotGenerateAcw=true)]
	public partial class CFlowPlusState : global::Org.Aspectj.Runtime.CFlow {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/runtime/internal/CFlowPlusState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CFlowPlusState); }
		}

		protected CFlowPlusState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLjava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowPlusState']/constructor[@name='CFlowPlusState' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register (".ctor", "([Ljava/lang/Object;)V", "")]
		public unsafe CFlowPlusState (global::Java.Lang.Object[] state)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_state = JNIEnv.NewArray (state);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_state);
				if (((object) this).GetType () != typeof (CFlowPlusState)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_ctor_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLjava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLjava_lang_Object_, __args);
			} finally {
				if (state != null) {
					JNIEnv.CopyArray (native_state, state);
					JNIEnv.DeleteLocalRef (native_state);
				}
			}
		}

		static IntPtr id_ctor_arrayLjava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='CFlowPlusState']/constructor[@name='CFlowPlusState' and count(parameter)=2 and parameter[1][@type='java.lang.Object[]'] and parameter[2][@type='java.lang.Object']]"
		[Register (".ctor", "([Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe CFlowPlusState (global::Java.Lang.Object[] state, global::Java.Lang.Object _aspect)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_state = JNIEnv.NewArray (state);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_state);
				__args [1] = new JValue (_aspect);
				if (((object) this).GetType () != typeof (CFlowPlusState)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Ljava/lang/Object;Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Ljava/lang/Object;Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_arrayLjava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_arrayLjava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Ljava/lang/Object;Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLjava_lang_Object_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLjava_lang_Object_Ljava_lang_Object_, __args);
			} finally {
				if (state != null) {
					JNIEnv.CopyArray (native_state, state);
					JNIEnv.DeleteLocalRef (native_state);
				}
			}
		}

	}
}
