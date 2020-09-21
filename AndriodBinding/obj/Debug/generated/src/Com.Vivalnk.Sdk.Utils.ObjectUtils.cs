using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ObjectUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/ObjectUtils", DoNotGenerateAcw=true)]
	public partial class ObjectUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/utils/ObjectUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectUtils); }
		}

		protected ObjectUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ObjectUtils']/constructor[@name='ObjectUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ObjectUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ObjectUtils)) {
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

		static IntPtr id_getFieldsNameList_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ObjectUtils']/method[@name='getFieldsNameList' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("getFieldsNameList", "(Ljava/lang/Class;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> GetFieldsNameList (global::Java.Lang.Class clazz)
		{
			if (id_getFieldsNameList_Ljava_lang_Class_ == IntPtr.Zero)
				id_getFieldsNameList_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getFieldsNameList", "(Ljava/lang/Class;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (clazz);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFieldsNameList_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toMap_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='ObjectUtils']/method[@name='toMap' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toMap", "(Ljava/lang/Object;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ToMap (global::Java.Lang.Object obj)
		{
			if (id_toMap_Ljava_lang_Object_ == IntPtr.Zero)
				id_toMap_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "toMap", "(Ljava/lang/Object;)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_toMap_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
