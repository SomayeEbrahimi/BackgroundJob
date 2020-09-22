using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.exceptions']/class[@name='CompositeException']"
	[global::Android.Runtime.Register ("io/reactivex/exceptions/CompositeException", DoNotGenerateAcw=true)]
	public sealed partial class CompositeException : global::Java.Lang.RuntimeException {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/exceptions/CompositeException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompositeException); }
		}

		internal CompositeException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Iterable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.exceptions']/class[@name='CompositeException']/constructor[@name='CompositeException' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends java.lang.Throwable&gt;']]"
		[Register (".ctor", "(Ljava/lang/Iterable;)V", "")]
		public unsafe CompositeException (global::Java.Lang.IIterable errors)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (errors);
				if (((object) this).GetType () != typeof (CompositeException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Iterable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/Iterable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Iterable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Iterable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Iterable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_Iterable_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_arrayLjava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.exceptions']/class[@name='CompositeException']/constructor[@name='CompositeException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable...']]"
		[Register (".ctor", "([Ljava/lang/Throwable;)V", "")]
		public unsafe CompositeException (params global::Java.Lang.Throwable[] exceptions)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_exceptions = JNIEnv.NewArray (exceptions);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_exceptions);
				if (((object) this).GetType () != typeof (CompositeException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "([Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_arrayLjava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_arrayLjava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLjava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_arrayLjava_lang_Throwable_, __args);
			} finally {
				if (exceptions != null) {
					JNIEnv.CopyArray (native_exceptions, exceptions);
					JNIEnv.DeleteLocalRef (native_exceptions);
				}
			}
		}

		static IntPtr id_getExceptions;
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Throwable> Exceptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.exceptions']/class[@name='CompositeException']/method[@name='getExceptions' and count(parameter)=0]"
			[Register ("getExceptions", "()Ljava/util/List;", "")]
			get {
				if (id_getExceptions == IntPtr.Zero)
					id_getExceptions = JNIEnv.GetMethodID (class_ref, "getExceptions", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Java.Lang.Throwable>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getExceptions), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.exceptions']/class[@name='CompositeException']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Throwable) this).Handle, id_size);
			} finally {
			}
		}

	}
}
