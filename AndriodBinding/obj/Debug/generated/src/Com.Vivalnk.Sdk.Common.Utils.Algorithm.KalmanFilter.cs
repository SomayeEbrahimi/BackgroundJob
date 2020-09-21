using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils.Algorithm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.algorithm']/class[@name='KalmanFilter']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/algorithm/KalmanFilter", DoNotGenerateAcw=true)]
	public partial class KalmanFilter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/algorithm/KalmanFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KalmanFilter); }
		}

		protected KalmanFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.algorithm']/class[@name='KalmanFilter']/constructor[@name='KalmanFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KalmanFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (KalmanFilter)) {
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

		static IntPtr id_calculate_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.algorithm']/class[@name='KalmanFilter']/method[@name='calculate' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.Double&gt;']]"
		[Register ("calculate", "(Ljava/util/ArrayList;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Double> Calculate (global::System.Collections.Generic.IList<global::Java.Lang.Double> dataArrayList)
		{
			if (id_calculate_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_calculate_Ljava_util_ArrayList_ = JNIEnv.GetStaticMethodID (class_ref, "calculate", "(Ljava/util/ArrayList;)Ljava/util/ArrayList;");
			IntPtr native_dataArrayList = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (dataArrayList);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_dataArrayList);
				global::System.Collections.Generic.IList<global::Java.Lang.Double> __ret = global::Android.Runtime.JavaList<global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_calculate_Ljava_util_ArrayList_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_dataArrayList);
			}
		}

	}
}
