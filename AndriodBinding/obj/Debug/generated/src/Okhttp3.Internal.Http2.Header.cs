using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']"
	[global::Android.Runtime.Register ("okhttp3/internal/http2/Header", DoNotGenerateAcw=true)]
	public sealed partial class Header : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']/field[@name='RESPONSE_STATUS_UTF8']"
		[Register ("RESPONSE_STATUS_UTF8")]
		public const string ResponseStatusUtf8 = (string) ":status";

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']/field[@name='TARGET_AUTHORITY_UTF8']"
		[Register ("TARGET_AUTHORITY_UTF8")]
		public const string TargetAuthorityUtf8 = (string) ":authority";

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']/field[@name='TARGET_METHOD_UTF8']"
		[Register ("TARGET_METHOD_UTF8")]
		public const string TargetMethodUtf8 = (string) ":method";

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']/field[@name='TARGET_PATH_UTF8']"
		[Register ("TARGET_PATH_UTF8")]
		public const string TargetPathUtf8 = (string) ":path";

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']/field[@name='TARGET_SCHEME_UTF8']"
		[Register ("TARGET_SCHEME_UTF8")]
		public const string TargetSchemeUtf8 = (string) ":scheme";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/http2/Header", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Header); }
		}

		internal Header (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']/constructor[@name='Header' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Header (string name, string value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (native_value);
				if (((object) this).GetType () != typeof (Header)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
