using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='AtomicThrowable']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/AtomicThrowable", DoNotGenerateAcw=true)]
	public sealed partial class AtomicThrowable : global::Java.Util.Concurrent.Atomic.AtomicReference {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/AtomicThrowable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AtomicThrowable); }
		}

		internal AtomicThrowable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='AtomicThrowable']/constructor[@name='AtomicThrowable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AtomicThrowable ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AtomicThrowable)) {
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

		static IntPtr id_isTerminated;
		public unsafe bool IsTerminated {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='AtomicThrowable']/method[@name='isTerminated' and count(parameter)=0]"
			[Register ("isTerminated", "()Z", "")]
			get {
				if (id_isTerminated == IntPtr.Zero)
					id_isTerminated = JNIEnv.GetMethodID (class_ref, "isTerminated", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTerminated);
				} finally {
				}
			}
		}

		static IntPtr id_addThrowable_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='AtomicThrowable']/method[@name='addThrowable' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("addThrowable", "(Ljava/lang/Throwable;)Z", "")]
		public unsafe bool AddThrowable (global::Java.Lang.Throwable t)
		{
			if (id_addThrowable_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_addThrowable_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "addThrowable", "(Ljava/lang/Throwable;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addThrowable_Ljava_lang_Throwable_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_terminate;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='AtomicThrowable']/method[@name='terminate' and count(parameter)=0]"
		[Register ("terminate", "()Ljava/lang/Throwable;", "")]
		public unsafe global::Java.Lang.Throwable Terminate ()
		{
			if (id_terminate == IntPtr.Zero)
				id_terminate = JNIEnv.GetMethodID (class_ref, "terminate", "()Ljava/lang/Throwable;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_terminate), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
