using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSetUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/CharSetUtils", DoNotGenerateAcw=true)]
	public partial class CharSetUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/CharSetUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharSetUtils); }
		}

		protected CharSetUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSetUtils']/constructor[@name='CharSetUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CharSetUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CharSetUtils)) {
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

		static IntPtr id_containsAny_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSetUtils']/method[@name='containsAny' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String...']]"
		[Register ("containsAny", "(Ljava/lang/String;[Ljava/lang/String;)Z", "")]
		public static unsafe bool ContainsAny (string str, params string[] set)
		{
			if (id_containsAny_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_containsAny_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "containsAny", "(Ljava/lang/String;[Ljava/lang/String;)Z");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_set = JNIEnv.NewArray (set);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_set);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsAny_Ljava_lang_String_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				if (set != null) {
					JNIEnv.CopyArray (native_set, set);
					JNIEnv.DeleteLocalRef (native_set);
				}
			}
		}

		static IntPtr id_count_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSetUtils']/method[@name='count' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String...']]"
		[Register ("count", "(Ljava/lang/String;[Ljava/lang/String;)I", "")]
		public static unsafe int Count (string str, params string[] set)
		{
			if (id_count_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_count_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "count", "(Ljava/lang/String;[Ljava/lang/String;)I");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_set = JNIEnv.NewArray (set);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_set);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_count_Ljava_lang_String_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				if (set != null) {
					JNIEnv.CopyArray (native_set, set);
					JNIEnv.DeleteLocalRef (native_set);
				}
			}
		}

		static IntPtr id_delete_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSetUtils']/method[@name='delete' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String...']]"
		[Register ("delete", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Delete (string str, params string[] set)
		{
			if (id_delete_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_delete_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "delete", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_set = JNIEnv.NewArray (set);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_set);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_delete_Ljava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				if (set != null) {
					JNIEnv.CopyArray (native_set, set);
					JNIEnv.DeleteLocalRef (native_set);
				}
			}
		}

		static IntPtr id_keep_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSetUtils']/method[@name='keep' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String...']]"
		[Register ("keep", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Keep (string str, params string[] set)
		{
			if (id_keep_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_keep_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "keep", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_set = JNIEnv.NewArray (set);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_set);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_keep_Ljava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				if (set != null) {
					JNIEnv.CopyArray (native_set, set);
					JNIEnv.DeleteLocalRef (native_set);
				}
			}
		}

		static IntPtr id_squeeze_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='CharSetUtils']/method[@name='squeeze' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String...']]"
		[Register ("squeeze", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Squeeze (string str, params string[] set)
		{
			if (id_squeeze_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_squeeze_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "squeeze", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			IntPtr native_set = JNIEnv.NewArray (set);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_set);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_squeeze_Ljava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				if (set != null) {
					JNIEnv.CopyArray (native_set, set);
					JNIEnv.DeleteLocalRef (native_set);
				}
			}
		}

	}
}
