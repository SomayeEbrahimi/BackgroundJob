using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex']/class[@name='Notification']"
	[global::Android.Runtime.Register ("io/reactivex/Notification", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class Notification : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/Notification", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Notification); }
		}

		internal Notification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getError;
		public unsafe global::Java.Lang.Throwable Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Notification']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Ljava/lang/Throwable;", "")]
			get {
				if (id_getError == IntPtr.Zero)
					id_getError = JNIEnv.GetMethodID (class_ref, "getError", "()Ljava/lang/Throwable;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getError), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isOnComplete;
		public unsafe bool IsOnComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Notification']/method[@name='isOnComplete' and count(parameter)=0]"
			[Register ("isOnComplete", "()Z", "")]
			get {
				if (id_isOnComplete == IntPtr.Zero)
					id_isOnComplete = JNIEnv.GetMethodID (class_ref, "isOnComplete", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOnComplete);
				} finally {
				}
			}
		}

		static IntPtr id_isOnError;
		public unsafe bool IsOnError {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Notification']/method[@name='isOnError' and count(parameter)=0]"
			[Register ("isOnError", "()Z", "")]
			get {
				if (id_isOnError == IntPtr.Zero)
					id_isOnError = JNIEnv.GetMethodID (class_ref, "isOnError", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOnError);
				} finally {
				}
			}
		}

		static IntPtr id_isOnNext;
		public unsafe bool IsOnNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Notification']/method[@name='isOnNext' and count(parameter)=0]"
			[Register ("isOnNext", "()Z", "")]
			get {
				if (id_isOnNext == IntPtr.Zero)
					id_isOnNext = JNIEnv.GetMethodID (class_ref, "isOnNext", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOnNext);
				} finally {
				}
			}
		}

		static IntPtr id_getValue;
		public unsafe global::Java.Lang.Object Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Notification']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Object;", "")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Object;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_createOnComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Notification']/method[@name='createOnComplete' and count(parameter)=0]"
		[Register ("createOnComplete", "()Lio/reactivex/Notification;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Notification CreateOnComplete ()
		{
			if (id_createOnComplete == IntPtr.Zero)
				id_createOnComplete = JNIEnv.GetStaticMethodID (class_ref, "createOnComplete", "()Lio/reactivex/Notification;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Notification> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createOnComplete), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createOnError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Notification']/method[@name='createOnError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("createOnError", "(Ljava/lang/Throwable;)Lio/reactivex/Notification;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Notification CreateOnError (global::Java.Lang.Throwable error)
		{
			if (id_createOnError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_createOnError_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "createOnError", "(Ljava/lang/Throwable;)Lio/reactivex/Notification;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (error);
				global::IO.Reactivex.Notification __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Notification> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createOnError_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createOnNext_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='Notification']/method[@name='createOnNext' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("createOnNext", "(Ljava/lang/Object;)Lio/reactivex/Notification;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::IO.Reactivex.Notification CreateOnNext (global::Java.Lang.Object value)
		{
			if (id_createOnNext_Ljava_lang_Object_ == IntPtr.Zero)
				id_createOnNext_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "createOnNext", "(Ljava/lang/Object;)Lio/reactivex/Notification;");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				global::IO.Reactivex.Notification __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Notification> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createOnNext_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
