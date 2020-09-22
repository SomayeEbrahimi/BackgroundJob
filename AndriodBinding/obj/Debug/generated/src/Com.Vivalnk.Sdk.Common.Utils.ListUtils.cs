using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ListUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/ListUtils", DoNotGenerateAcw=true)]
	public partial class ListUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/ListUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ListUtils); }
		}

		protected ListUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ListUtils']/constructor[@name='ListUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ListUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ListUtils)) {
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

		static IntPtr id_getEmptyList;
		[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
		public static unsafe global::System.Collections.IList EmptyList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ListUtils']/method[@name='getEmptyList' and count(parameter)=0]"
			[Register ("getEmptyList", "()Ljava/util/List;", "")]
			get {
				if (id_getEmptyList == IntPtr.Zero)
					id_getEmptyList = JNIEnv.GetStaticMethodID (class_ref, "getEmptyList", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEmptyList), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isEmpty_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ListUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;?&gt;']]"
		[Register ("isEmpty", "(Ljava/util/List;)Z", "")]
		public static unsafe bool IsEmpty (global::System.Collections.Generic.IList<object> list)
		{
			if (id_isEmpty_Ljava_util_List_ == IntPtr.Zero)
				id_isEmpty_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "(Ljava/util/List;)Z");
			IntPtr native_list = global::Android.Runtime.JavaList<object>.ToLocalJniHandle (list);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_list);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_Ljava_util_List_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
			}
		}

		static IntPtr id_isEmpty_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='ListUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("isEmpty", "([Ljava/lang/Object;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe bool IsEmpty (params global::Java.Lang.Object[] array)
		{
			if (id_isEmpty_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_isEmpty_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "([Ljava/lang/Object;)Z");
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_array);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_arrayLjava_lang_Object_, __args);
				return __ret;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

	}
}
