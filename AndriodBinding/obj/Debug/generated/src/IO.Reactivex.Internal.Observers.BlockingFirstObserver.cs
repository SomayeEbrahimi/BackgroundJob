using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Observers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BlockingFirstObserver']"
	[global::Android.Runtime.Register ("io/reactivex/internal/observers/BlockingFirstObserver", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class BlockingFirstObserver : global::IO.Reactivex.Internal.Observers.BlockingBaseObserver {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/observers/BlockingFirstObserver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlockingFirstObserver); }
		}

		internal BlockingFirstObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BlockingFirstObserver']/constructor[@name='BlockingFirstObserver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BlockingFirstObserver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BlockingFirstObserver)) {
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

		static IntPtr id_onError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BlockingFirstObserver']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "")]
		public override unsafe void OnError (global::Java.Lang.Throwable t)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_onNext_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.observers']/class[@name='BlockingFirstObserver']/method[@name='onNext' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onNext", "(Ljava/lang/Object;)V", "")]
		public unsafe void OnNext (global::Java.Lang.Object t)
		{
			if (id_onNext_Ljava_lang_Object_ == IntPtr.Zero)
				id_onNext_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onNext", "(Ljava/lang/Object;)V");
			IntPtr native_t = JNIEnv.ToLocalJniHandle (t);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_t);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNext_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_t);
			}
		}

	}
}
