using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ArrayUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/ArrayUtils", DoNotGenerateAcw=true)]
	public partial class ArrayUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/ArrayUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArrayUtils); }
		}

		protected ArrayUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ArrayUtils']/constructor[@name='ArrayUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ArrayUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ArrayUtils)) {
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

		static IntPtr id_spliceArrays_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ArrayUtils']/method[@name='spliceArrays' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("spliceArrays", "([BI)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<byte[]> SpliceArrays (byte[] datas, int splitSize)
		{
			if (id_spliceArrays_arrayBI == IntPtr.Zero)
				id_spliceArrays_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "spliceArrays", "([BI)Ljava/util/List;");
			IntPtr native_datas = JNIEnv.NewArray (datas);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_datas);
				__args [1] = new JValue (splitSize);
				global::System.Collections.Generic.IList<byte[]> __ret = global::Android.Runtime.JavaList<byte[]>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_spliceArrays_arrayBI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (datas != null) {
					JNIEnv.CopyArray (native_datas, datas);
					JNIEnv.DeleteLocalRef (native_datas);
				}
			}
		}

		static IntPtr id_spliceArrays_arrayCI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ArrayUtils']/method[@name='spliceArrays' and count(parameter)=2 and parameter[1][@type='char[]'] and parameter[2][@type='int']]"
		[Register ("spliceArrays", "([CI)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<char[]> SpliceArrays (char[] datas, int splitSize)
		{
			if (id_spliceArrays_arrayCI == IntPtr.Zero)
				id_spliceArrays_arrayCI = JNIEnv.GetStaticMethodID (class_ref, "spliceArrays", "([CI)Ljava/util/List;");
			IntPtr native_datas = JNIEnv.NewArray (datas);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_datas);
				__args [1] = new JValue (splitSize);
				global::System.Collections.Generic.IList<char[]> __ret = global::Android.Runtime.JavaList<char[]>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_spliceArrays_arrayCI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (datas != null) {
					JNIEnv.CopyArray (native_datas, datas);
					JNIEnv.DeleteLocalRef (native_datas);
				}
			}
		}

		static IntPtr id_spliceArrays_Ljava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ArrayUtils']/method[@name='spliceArrays' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='int']]"
		[Register ("spliceArrays", "(Ljava/util/List;I)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.Generic.IList<global::System.Collections.IList> SpliceArrays (global::System.Collections.IList datas, int splitSize)
		{
			if (id_spliceArrays_Ljava_util_List_I == IntPtr.Zero)
				id_spliceArrays_Ljava_util_List_I = JNIEnv.GetStaticMethodID (class_ref, "spliceArrays", "(Ljava/util/List;I)Ljava/util/List;");
			IntPtr native_datas = global::Android.Runtime.JavaList.ToLocalJniHandle (datas);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_datas);
				__args [1] = new JValue (splitSize);
				global::System.Collections.Generic.IList<global::System.Collections.IList> __ret = global::Android.Runtime.JavaList<global::System.Collections.IList>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_spliceArrays_Ljava_util_List_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_datas);
			}
		}

		static IntPtr id_spliceArrays_arrayLjava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ArrayUtils']/method[@name='spliceArrays' and count(parameter)=2 and parameter[1][@type='T[]'] and parameter[2][@type='int']]"
		[Register ("spliceArrays", "([Ljava/lang/Object;I)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Object[]> SpliceArrays (global::Java.Lang.Object[] datas, int splitSize)
		{
			if (id_spliceArrays_arrayLjava_lang_Object_I == IntPtr.Zero)
				id_spliceArrays_arrayLjava_lang_Object_I = JNIEnv.GetStaticMethodID (class_ref, "spliceArrays", "([Ljava/lang/Object;I)Ljava/util/List;");
			IntPtr native_datas = JNIEnv.NewArray (datas);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_datas);
				__args [1] = new JValue (splitSize);
				global::System.Collections.Generic.IList<global::Java.Lang.Object[]> __ret = global::Android.Runtime.JavaList<global::Java.Lang.Object[]>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_spliceArrays_arrayLjava_lang_Object_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (datas != null) {
					JNIEnv.CopyArray (native_datas, datas);
					JNIEnv.DeleteLocalRef (native_datas);
				}
			}
		}

	}
}
