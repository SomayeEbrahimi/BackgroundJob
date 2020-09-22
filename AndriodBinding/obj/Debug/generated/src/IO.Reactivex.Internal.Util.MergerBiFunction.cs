using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='MergerBiFunction']"
	[global::Android.Runtime.Register ("io/reactivex/internal/util/MergerBiFunction", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class MergerBiFunction : global::Java.Lang.Object, global::IO.Reactivex.Functions.IBiFunction {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/util/MergerBiFunction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MergerBiFunction); }
		}

		internal MergerBiFunction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_Comparator_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='MergerBiFunction']/constructor[@name='MergerBiFunction' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;? super T&gt;']]"
		[Register (".ctor", "(Ljava/util/Comparator;)V", "")]
		public unsafe MergerBiFunction (global::Java.Util.IComparator comparator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (comparator);
				if (((object) this).GetType () != typeof (MergerBiFunction)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/Comparator;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/Comparator;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Comparator_ == IntPtr.Zero)
					id_ctor_Ljava_util_Comparator_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Comparator;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Comparator_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_Comparator_, __args);
			} finally {
			}
		}

		static IntPtr id_apply_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/class[@name='MergerBiFunction']/method[@name='apply' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='java.util.List&lt;T&gt;']]"
		[Register ("apply", "(Ljava/util/List;Ljava/util/List;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.IList Apply (global::System.Collections.IList a, global::System.Collections.IList b)
		{
			if (id_apply_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_apply_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "apply", "(Ljava/util/List;Ljava/util/List;)Ljava/util/List;");
			IntPtr native_a = global::Android.Runtime.JavaList.ToLocalJniHandle (a);
			IntPtr native_b = global::Android.Runtime.JavaList.ToLocalJniHandle (b);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_a);
				__args [1] = new JValue (native_b);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Ljava_util_List_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_a);
				JNIEnv.DeleteLocalRef (native_b);
			}
		}

		// This method is explicitly implemented as a member of an instantiated IO.Reactivex.Functions.IBiFunction
		global::Java.Lang.Object global::IO.Reactivex.Functions.IBiFunction.Apply (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<JavaList>(native_Apply (global::Java.Interop.JavaObjectExtensions.JavaCast<JavaList>(p0), global::Java.Interop.JavaObjectExtensions.JavaCast<JavaList>(p1)));
		}

	}
}
