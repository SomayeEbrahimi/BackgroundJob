using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ErrorMode']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/ErrorMode", DoNotGenerateAcw=true)]
	public sealed partial class ErrorMode : global::Java.Lang.Enum {


		static IntPtr BOUNDARY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ErrorMode']/field[@name='BOUNDARY']"
		[Register ("BOUNDARY")]
		public static global::IO.Reactivex.Internal.Util.ErrorMode Boundary {
			get {
				if (BOUNDARY_jfieldId == IntPtr.Zero)
					BOUNDARY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOUNDARY", "Lio/reactivex/internal/util/ErrorMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOUNDARY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.ErrorMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr END_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ErrorMode']/field[@name='END']"
		[Register ("END")]
		public static global::IO.Reactivex.Internal.Util.ErrorMode End {
			get {
				if (END_jfieldId == IntPtr.Zero)
					END_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "END", "Lio/reactivex/internal/util/ErrorMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, END_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.ErrorMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IMMEDIATE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ErrorMode']/field[@name='IMMEDIATE']"
		[Register ("IMMEDIATE")]
		public static global::IO.Reactivex.Internal.Util.ErrorMode Immediate {
			get {
				if (IMMEDIATE_jfieldId == IntPtr.Zero)
					IMMEDIATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMMEDIATE", "Lio/reactivex/internal/util/ErrorMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IMMEDIATE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.ErrorMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/ErrorMode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorMode); }
		}

		internal ErrorMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ErrorMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/reactivex/internal/util/ErrorMode;", "")]
		public static unsafe global::IO.Reactivex.Internal.Util.ErrorMode ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/reactivex/internal/util/ErrorMode;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::IO.Reactivex.Internal.Util.ErrorMode __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.ErrorMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='ErrorMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/reactivex/internal/util/ErrorMode;", "")]
		public static unsafe global::IO.Reactivex.Internal.Util.ErrorMode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/reactivex/internal/util/ErrorMode;");
			try {
				return (global::IO.Reactivex.Internal.Util.ErrorMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Reactivex.Internal.Util.ErrorMode));
			} finally {
			}
		}

	}
}
