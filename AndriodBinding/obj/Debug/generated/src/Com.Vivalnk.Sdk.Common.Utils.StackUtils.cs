using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Sdk.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='StackUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/StackUtils", DoNotGenerateAcw=true)]
	public partial class StackUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/sdk/common/utils/StackUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StackUtils); }
		}

		protected StackUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='StackUtils']/constructor[@name='StackUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StackUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StackUtils)) {
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

		static IntPtr id_getClassName;
		public static unsafe string ClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='StackUtils']/method[@name='getClassName' and count(parameter)=0]"
			[Register ("getClassName", "()Ljava/lang/String;", "")]
			get {
				if (id_getClassName == IntPtr.Zero)
					id_getClassName = JNIEnv.GetStaticMethodID (class_ref, "getClassName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getClassName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getFileName;
		public static unsafe string FileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='StackUtils']/method[@name='getFileName' and count(parameter)=0]"
			[Register ("getFileName", "()Ljava/lang/String;", "")]
			get {
				if (id_getFileName == IntPtr.Zero)
					id_getFileName = JNIEnv.GetStaticMethodID (class_ref, "getFileName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFileName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getLineNumber;
		public static unsafe int LineNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='StackUtils']/method[@name='getLineNumber' and count(parameter)=0]"
			[Register ("getLineNumber", "()I", "")]
			get {
				if (id_getLineNumber == IntPtr.Zero)
					id_getLineNumber = JNIEnv.GetStaticMethodID (class_ref, "getLineNumber", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getLineNumber);
				} finally {
				}
			}
		}

		static IntPtr id_getMethodName;
		public static unsafe string MethodName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils']/class[@name='StackUtils']/method[@name='getMethodName' and count(parameter)=0]"
			[Register ("getMethodName", "()Ljava/lang/String;", "")]
			get {
				if (id_getMethodName == IntPtr.Zero)
					id_getMethodName = JNIEnv.GetStaticMethodID (class_ref, "getMethodName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMethodName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
