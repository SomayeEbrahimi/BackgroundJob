using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArchUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/ArchUtils", DoNotGenerateAcw=true)]
	public partial class ArchUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/ArchUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArchUtils); }
		}

		protected ArchUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArchUtils']/constructor[@name='ArchUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ArchUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ArchUtils)) {
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

		static IntPtr id_getProcessor;
		public static unsafe global::Org.Apache.Commons.Lang3.Arch.Processor Processor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArchUtils']/method[@name='getProcessor' and count(parameter)=0]"
			[Register ("getProcessor", "()Lorg/apache/commons/lang3/arch/Processor;", "")]
			get {
				if (id_getProcessor == IntPtr.Zero)
					id_getProcessor = JNIEnv.GetStaticMethodID (class_ref, "getProcessor", "()Lorg/apache/commons/lang3/arch/Processor;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProcessor), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getProcessor_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='ArchUtils']/method[@name='getProcessor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProcessor", "(Ljava/lang/String;)Lorg/apache/commons/lang3/arch/Processor;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Arch.Processor GetProcessor (string value)
		{
			if (id_getProcessor_Ljava_lang_String_ == IntPtr.Zero)
				id_getProcessor_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getProcessor", "(Ljava/lang/String;)Lorg/apache/commons/lang3/arch/Processor;");
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				global::Org.Apache.Commons.Lang3.Arch.Processor __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Arch.Processor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProcessor_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
