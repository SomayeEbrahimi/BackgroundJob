using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex']/class[@name='BackpressureStrategy']"
	[global::Android.Runtime.Register ("io/reactivex/BackpressureStrategy", DoNotGenerateAcw=true)]
	public sealed partial class BackpressureStrategy : global::Java.Lang.Enum {


		static IntPtr BUFFER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex']/class[@name='BackpressureStrategy']/field[@name='BUFFER']"
		[Register ("BUFFER")]
		public static global::IO.Reactivex.BackpressureStrategy Buffer {
			get {
				if (BUFFER_jfieldId == IntPtr.Zero)
					BUFFER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUFFER", "Lio/reactivex/BackpressureStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUFFER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.BackpressureStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DROP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex']/class[@name='BackpressureStrategy']/field[@name='DROP']"
		[Register ("DROP")]
		public static global::IO.Reactivex.BackpressureStrategy Drop {
			get {
				if (DROP_jfieldId == IntPtr.Zero)
					DROP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DROP", "Lio/reactivex/BackpressureStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DROP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.BackpressureStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex']/class[@name='BackpressureStrategy']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::IO.Reactivex.BackpressureStrategy Error {
			get {
				if (ERROR_jfieldId == IntPtr.Zero)
					ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lio/reactivex/BackpressureStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.BackpressureStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LATEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex']/class[@name='BackpressureStrategy']/field[@name='LATEST']"
		[Register ("LATEST")]
		public static global::IO.Reactivex.BackpressureStrategy Latest {
			get {
				if (LATEST_jfieldId == IntPtr.Zero)
					LATEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LATEST", "Lio/reactivex/BackpressureStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LATEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.BackpressureStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MISSING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex']/class[@name='BackpressureStrategy']/field[@name='MISSING']"
		[Register ("MISSING")]
		public static global::IO.Reactivex.BackpressureStrategy Missing {
			get {
				if (MISSING_jfieldId == IntPtr.Zero)
					MISSING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MISSING", "Lio/reactivex/BackpressureStrategy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MISSING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.BackpressureStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/BackpressureStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackpressureStrategy); }
		}

		internal BackpressureStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='BackpressureStrategy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/reactivex/BackpressureStrategy;", "")]
		public static unsafe global::IO.Reactivex.BackpressureStrategy ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/reactivex/BackpressureStrategy;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::IO.Reactivex.BackpressureStrategy __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.BackpressureStrategy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/class[@name='BackpressureStrategy']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/reactivex/BackpressureStrategy;", "")]
		public static unsafe global::IO.Reactivex.BackpressureStrategy[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/reactivex/BackpressureStrategy;");
			try {
				return (global::IO.Reactivex.BackpressureStrategy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Reactivex.BackpressureStrategy));
			} finally {
			}
		}

	}
}
