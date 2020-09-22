using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='BlockingIgnoringReceiver']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/BlockingIgnoringReceiver", DoNotGenerateAcw=true)]
	public sealed partial class BlockingIgnoringReceiver : global::Java.Util.Concurrent.CountDownLatch, global::IO.Reactivex.Functions.IAction, global::IO.Reactivex.Functions.IConsumer {


		static IntPtr error_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='BlockingIgnoringReceiver']/field[@name='error']"
		[Register ("error")]
		public global::Java.Lang.Throwable Error {
			get {
				if (error_jfieldId == IntPtr.Zero)
					error_jfieldId = JNIEnv.GetFieldID (class_ref, "error", "Ljava/lang/Throwable;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, error_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (error_jfieldId == IntPtr.Zero)
					error_jfieldId = JNIEnv.GetFieldID (class_ref, "error", "Ljava/lang/Throwable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, error_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/BlockingIgnoringReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlockingIgnoringReceiver); }
		}

		internal BlockingIgnoringReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='BlockingIgnoringReceiver']/constructor[@name='BlockingIgnoringReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BlockingIgnoringReceiver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BlockingIgnoringReceiver)) {
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

		static IntPtr id_accept_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='BlockingIgnoringReceiver']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("accept", "(Ljava/lang/Throwable;)V", "")]
		public unsafe void Accept (global::Java.Lang.Throwable e)
		{
			if (id_accept_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_accept_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "accept", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='BlockingIgnoringReceiver']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "")]
		public unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated IO.Reactivex.Functions.IConsumer
		void global::IO.Reactivex.Functions.IConsumer.Accept (global::Java.Lang.Object p0)
		{
			Accept (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Throwable>(p0));
		}

	}
}
