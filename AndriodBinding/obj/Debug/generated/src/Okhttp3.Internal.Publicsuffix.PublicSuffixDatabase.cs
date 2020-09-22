using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Publicsuffix {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.publicsuffix']/class[@name='PublicSuffixDatabase']"
	[global::Android.Runtime.Register ("okhttp3/internal/publicsuffix/PublicSuffixDatabase", DoNotGenerateAcw=true)]
	public sealed partial class PublicSuffixDatabase : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.publicsuffix']/class[@name='PublicSuffixDatabase']/field[@name='PUBLIC_SUFFIX_RESOURCE']"
		[Register ("PUBLIC_SUFFIX_RESOURCE")]
		public const string PublicSuffixResource = (string) "publicsuffixes.gz";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/publicsuffix/PublicSuffixDatabase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PublicSuffixDatabase); }
		}

		internal PublicSuffixDatabase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.publicsuffix']/class[@name='PublicSuffixDatabase']/constructor[@name='PublicSuffixDatabase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PublicSuffixDatabase ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PublicSuffixDatabase)) {
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

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.publicsuffix']/class[@name='PublicSuffixDatabase']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lokhttp3/internal/publicsuffix/PublicSuffixDatabase;", "")]
		public static unsafe global::Okhttp3.Internal.Publicsuffix.PublicSuffixDatabase Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetStaticMethodID (class_ref, "get", "()Lokhttp3/internal/publicsuffix/PublicSuffixDatabase;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Publicsuffix.PublicSuffixDatabase> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getEffectiveTldPlusOne_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.publicsuffix']/class[@name='PublicSuffixDatabase']/method[@name='getEffectiveTldPlusOne' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEffectiveTldPlusOne", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string GetEffectiveTldPlusOne (string domain)
		{
			if (id_getEffectiveTldPlusOne_Ljava_lang_String_ == IntPtr.Zero)
				id_getEffectiveTldPlusOne_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getEffectiveTldPlusOne", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_domain = JNIEnv.NewString (domain);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_domain);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEffectiveTldPlusOne_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_domain);
			}
		}

	}
}
