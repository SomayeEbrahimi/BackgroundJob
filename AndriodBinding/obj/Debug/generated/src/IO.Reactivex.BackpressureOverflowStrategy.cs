using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex']/class[@name='BackpressureOverflowStrategy']"
	[global::Android.Runtime.Register ("io/reactivex/BackpressureOverflowStrategy", DoNotGenerateAcw=true)]
	public sealed partial class BackpressureOverflowStrategy : global::Java.Lang.Enum {


		static IntPtr DROP_LATEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex']/class[@name='BackpressureOverflowStrategy']/field[@name='DROP_LATEST']"
		[Register ("DROP_LATEST")]
		public static global::IO.Reactivex.BackpressureOverflowStrategy DropLatest {
			get {
				if (DROP_LATEST_jfieldId == IntPtr.Zero)
					DROP_LATEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DROP_LATEST", "Lio/reactivex/BackpressureOverflowStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DROP_LATEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.BackpressureOverflowStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DROP_OLDEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex']/class[@name='BackpressureOverflowStrategy']/field[@name='DROP_OLDEST']"
		[Register ("DROP_OLDEST")]
		public static global::IO.Reactivex.BackpressureOverflowStrategy DropOldest {
			get {
				if (DROP_OLDEST_jfieldId == IntPtr.Zero)
					DROP_OLDEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DROP_OLDEST", "Lio/reactivex/BackpressureOverflowStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DROP_OLDEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.BackpressureOverflowStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex']/class[@name='BackpressureOverflowStrategy']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::IO.Reactivex.BackpressureOverflowStrategy Error {
			get {
				if (ERROR_jfieldId == IntPtr.Zero)
					ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lio/reactivex/BackpressureOverflowStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.BackpressureOverflowStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/BackpressureOverflowStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackpressureOverflowStrategy); }
		}

		internal BackpressureOverflowStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='BackpressureOverflowStrategy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/reactivex/BackpressureOverflowStrategy;", "")]
		public static unsafe global::IO.Reactivex.BackpressureOverflowStrategy ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/reactivex/BackpressureOverflowStrategy;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::IO.Reactivex.BackpressureOverflowStrategy __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.BackpressureOverflowStrategy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='BackpressureOverflowStrategy']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/reactivex/BackpressureOverflowStrategy;", "")]
		public static unsafe global::IO.Reactivex.BackpressureOverflowStrategy[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/reactivex/BackpressureOverflowStrategy;");
			try {
				return (global::IO.Reactivex.BackpressureOverflowStrategy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Reactivex.BackpressureOverflowStrategy));
			} finally {
			}
		}

	}
}
