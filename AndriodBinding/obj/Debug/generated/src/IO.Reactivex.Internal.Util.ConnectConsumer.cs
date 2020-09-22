using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ConnectConsumer']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/ConnectConsumer", DoNotGenerateAcw=true)]
	public sealed partial class ConnectConsumer : global::Java.Lang.Object, global::IO.Reactivex.Functions.IConsumer {


		static IntPtr disposable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ConnectConsumer']/field[@name='disposable']"
		[Register ("disposable")]
		public global::IO.Reactivex.Disposables.IDisposable Disposable {
			get {
				if (disposable_jfieldId == IntPtr.Zero)
					disposable_jfieldId = JNIEnv.GetFieldID (class_ref, "disposable", "Lio/reactivex/disposables/Disposable;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, disposable_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Disposables.IDisposable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (disposable_jfieldId == IntPtr.Zero)
					disposable_jfieldId = JNIEnv.GetFieldID (class_ref, "disposable", "Lio/reactivex/disposables/Disposable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, disposable_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/ConnectConsumer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectConsumer); }
		}

		internal ConnectConsumer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ConnectConsumer']/constructor[@name='ConnectConsumer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectConsumer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConnectConsumer)) {
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

		static IntPtr id_accept_Lio_reactivex_disposables_Disposable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ConnectConsumer']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='io.reactivex.disposables.Disposable']]"
		[Register ("accept", "(Lio/reactivex/disposables/Disposable;)V", "")]
		public unsafe void Accept (global::IO.Reactivex.Disposables.IDisposable t)
		{
			if (id_accept_Lio_reactivex_disposables_Disposable_ == IntPtr.Zero)
				id_accept_Lio_reactivex_disposables_Disposable_ = JNIEnv.GetMethodID (class_ref, "accept", "(Lio/reactivex/disposables/Disposable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Lio_reactivex_disposables_Disposable_, __args);
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated IO.Reactivex.Functions.IConsumer
		void global::IO.Reactivex.Functions.IConsumer.Accept (global::Java.Lang.Object p0)
		{
			Accept (global::Java.Interop.JavaObjectExtensions.JavaCast<global::IO.Reactivex.Disposables.IDisposable>(p0));
		}

	}
}
