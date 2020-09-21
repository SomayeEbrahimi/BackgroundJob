using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='RandomUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/RandomUtils", DoNotGenerateAcw=true)]
	public partial class RandomUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/RandomUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RandomUtils); }
		}

		protected RandomUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='RandomUtils']/constructor[@name='RandomUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RandomUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RandomUtils)) {
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

		static IntPtr id_nextDouble;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='RandomUtils']/method[@name='nextDouble' and count(parameter)=0]"
		[Register ("nextDouble", "()D", "")]
		public static unsafe double NextDouble ()
		{
			if (id_nextDouble == IntPtr.Zero)
				id_nextDouble = JNIEnv.GetStaticMethodID (class_ref, "nextDouble", "()D");
			try {
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_nextDouble);
			} finally {
			}
		}

		static IntPtr id_nextInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='RandomUtils']/method[@name='nextInt' and count(parameter)=0]"
		[Register ("nextInt", "()D", "")]
		public static unsafe double NextInt ()
		{
			if (id_nextInt == IntPtr.Zero)
				id_nextInt = JNIEnv.GetStaticMethodID (class_ref, "nextInt", "()D");
			try {
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_nextInt);
			} finally {
			}
		}

		static IntPtr id_nextLong;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='RandomUtils']/method[@name='nextLong' and count(parameter)=0]"
		[Register ("nextLong", "()D", "")]
		public static unsafe double NextLong ()
		{
			if (id_nextLong == IntPtr.Zero)
				id_nextLong = JNIEnv.GetStaticMethodID (class_ref, "nextLong", "()D");
			try {
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_nextLong);
			} finally {
			}
		}

	}
}
