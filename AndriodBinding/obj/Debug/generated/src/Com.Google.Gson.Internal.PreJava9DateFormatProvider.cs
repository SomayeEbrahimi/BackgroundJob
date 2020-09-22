using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='PreJava9DateFormatProvider']"
	[global::Android.Runtime.Register ("com/google/gson/internal/PreJava9DateFormatProvider", DoNotGenerateAcw=true)]
	public partial class PreJava9DateFormatProvider : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/PreJava9DateFormatProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PreJava9DateFormatProvider); }
		}

		protected PreJava9DateFormatProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal']/class[@name='PreJava9DateFormatProvider']/constructor[@name='PreJava9DateFormatProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PreJava9DateFormatProvider ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PreJava9DateFormatProvider)) {
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

		static IntPtr id_getUSDateFormat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='PreJava9DateFormatProvider']/method[@name='getUSDateFormat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUSDateFormat", "(I)Ljava/text/DateFormat;", "")]
		public static unsafe global::Java.Text.DateFormat GetUSDateFormat (int style)
		{
			if (id_getUSDateFormat_I == IntPtr.Zero)
				id_getUSDateFormat_I = JNIEnv.GetStaticMethodID (class_ref, "getUSDateFormat", "(I)Ljava/text/DateFormat;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (style);
				return global::Java.Lang.Object.GetObject<global::Java.Text.DateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUSDateFormat_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getUSDateTimeFormat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='PreJava9DateFormatProvider']/method[@name='getUSDateTimeFormat' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getUSDateTimeFormat", "(II)Ljava/text/DateFormat;", "")]
		public static unsafe global::Java.Text.DateFormat GetUSDateTimeFormat (int dateStyle, int timeStyle)
		{
			if (id_getUSDateTimeFormat_II == IntPtr.Zero)
				id_getUSDateTimeFormat_II = JNIEnv.GetStaticMethodID (class_ref, "getUSDateTimeFormat", "(II)Ljava/text/DateFormat;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dateStyle);
				__args [1] = new JValue (timeStyle);
				return global::Java.Lang.Object.GetObject<global::Java.Text.DateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUSDateTimeFormat_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
