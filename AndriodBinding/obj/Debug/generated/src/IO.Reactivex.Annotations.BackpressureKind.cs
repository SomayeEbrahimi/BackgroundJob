using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Annotations {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.annotations']/class[@name='BackpressureKind']"
	[global::Android.Runtime.Register ("io/reactivex/annotations/BackpressureKind", DoNotGenerateAcw=true)]
	public sealed partial class BackpressureKind : global::Java.Lang.Enum {


		static IntPtr ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.annotations']/class[@name='BackpressureKind']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::IO.Reactivex.Annotations.BackpressureKind Error {
			get {
				if (ERROR_jfieldId == IntPtr.Zero)
					ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lio/reactivex/annotations/BackpressureKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Annotations.BackpressureKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FULL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.annotations']/class[@name='BackpressureKind']/field[@name='FULL']"
		[Register ("FULL")]
		public static global::IO.Reactivex.Annotations.BackpressureKind Full {
			get {
				if (FULL_jfieldId == IntPtr.Zero)
					FULL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FULL", "Lio/reactivex/annotations/BackpressureKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FULL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Annotations.BackpressureKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.annotations']/class[@name='BackpressureKind']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::IO.Reactivex.Annotations.BackpressureKind None {
			get {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lio/reactivex/annotations/BackpressureKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Annotations.BackpressureKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PASS_THROUGH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.annotations']/class[@name='BackpressureKind']/field[@name='PASS_THROUGH']"
		[Register ("PASS_THROUGH")]
		public static global::IO.Reactivex.Annotations.BackpressureKind PassThrough {
			get {
				if (PASS_THROUGH_jfieldId == IntPtr.Zero)
					PASS_THROUGH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PASS_THROUGH", "Lio/reactivex/annotations/BackpressureKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PASS_THROUGH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Annotations.BackpressureKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SPECIAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.annotations']/class[@name='BackpressureKind']/field[@name='SPECIAL']"
		[Register ("SPECIAL")]
		public static global::IO.Reactivex.Annotations.BackpressureKind Special {
			get {
				if (SPECIAL_jfieldId == IntPtr.Zero)
					SPECIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPECIAL", "Lio/reactivex/annotations/BackpressureKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPECIAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Annotations.BackpressureKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNBOUNDED_IN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.annotations']/class[@name='BackpressureKind']/field[@name='UNBOUNDED_IN']"
		[Register ("UNBOUNDED_IN")]
		public static global::IO.Reactivex.Annotations.BackpressureKind UnboundedIn {
			get {
				if (UNBOUNDED_IN_jfieldId == IntPtr.Zero)
					UNBOUNDED_IN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNBOUNDED_IN", "Lio/reactivex/annotations/BackpressureKind;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNBOUNDED_IN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Annotations.BackpressureKind> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/annotations/BackpressureKind", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackpressureKind); }
		}

		internal BackpressureKind (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.annotations']/class[@name='BackpressureKind']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/reactivex/annotations/BackpressureKind;", "")]
		public static unsafe global::IO.Reactivex.Annotations.BackpressureKind ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/reactivex/annotations/BackpressureKind;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::IO.Reactivex.Annotations.BackpressureKind __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Annotations.BackpressureKind> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.annotations']/class[@name='BackpressureKind']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/reactivex/annotations/BackpressureKind;", "")]
		public static unsafe global::IO.Reactivex.Annotations.BackpressureKind[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/reactivex/annotations/BackpressureKind;");
			try {
				return (global::IO.Reactivex.Annotations.BackpressureKind[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Reactivex.Annotations.BackpressureKind));
			} finally {
			}
		}

	}
}
