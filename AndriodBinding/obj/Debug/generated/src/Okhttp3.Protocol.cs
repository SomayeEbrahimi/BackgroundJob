using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']"
	[global::Android.Runtime.Register ("okhttp3/Protocol", DoNotGenerateAcw=true)]
	public sealed partial class Protocol : global::Java.Lang.Enum {


		static IntPtr H2_PRIOR_KNOWLEDGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/field[@name='H2_PRIOR_KNOWLEDGE']"
		[Register ("H2_PRIOR_KNOWLEDGE")]
		public static global::Okhttp3.Protocol H2PriorKnowledge {
			get {
				if (H2_PRIOR_KNOWLEDGE_jfieldId == IntPtr.Zero)
					H2_PRIOR_KNOWLEDGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "H2_PRIOR_KNOWLEDGE", "Lokhttp3/Protocol;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, H2_PRIOR_KNOWLEDGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HTTP_1_0_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/field[@name='HTTP_1_0']"
		[Register ("HTTP_1_0")]
		public static global::Okhttp3.Protocol Http10 {
			get {
				if (HTTP_1_0_jfieldId == IntPtr.Zero)
					HTTP_1_0_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP_1_0", "Lokhttp3/Protocol;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTTP_1_0_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HTTP_1_1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/field[@name='HTTP_1_1']"
		[Register ("HTTP_1_1")]
		public static global::Okhttp3.Protocol Http11 {
			get {
				if (HTTP_1_1_jfieldId == IntPtr.Zero)
					HTTP_1_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP_1_1", "Lokhttp3/Protocol;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTTP_1_1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HTTP_2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/field[@name='HTTP_2']"
		[Register ("HTTP_2")]
		public static global::Okhttp3.Protocol Http2 {
			get {
				if (HTTP_2_jfieldId == IntPtr.Zero)
					HTTP_2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP_2", "Lokhttp3/Protocol;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTTP_2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr QUIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/field[@name='QUIC']"
		[Register ("QUIC")]
		public static global::Okhttp3.Protocol Quic {
			get {
				if (QUIC_jfieldId == IntPtr.Zero)
					QUIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QUIC", "Lokhttp3/Protocol;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QUIC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SPDY_3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/field[@name='SPDY_3']"
		[Register ("SPDY_3")]
		[Obsolete ("deprecated")]
		public static global::Okhttp3.Protocol Spdy3 {
			get {
				if (SPDY_3_jfieldId == IntPtr.Zero)
					SPDY_3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_3", "Lokhttp3/Protocol;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_3_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/Protocol", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Protocol); }
		}

		internal Protocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lokhttp3/Protocol;", "")]
		public static unsafe global::Okhttp3.Protocol Get (string protocol)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/lang/String;)Lokhttp3/Protocol;");
			IntPtr native_protocol = JNIEnv.NewString (protocol);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_protocol);
				global::Okhttp3.Protocol __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_protocol);
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lokhttp3/Protocol;", "")]
		public static unsafe global::Okhttp3.Protocol ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lokhttp3/Protocol;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Okhttp3.Protocol __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lokhttp3/Protocol;", "")]
		public static unsafe global::Okhttp3.Protocol[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lokhttp3/Protocol;");
			try {
				return (global::Okhttp3.Protocol[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Okhttp3.Protocol));
			} finally {
			}
		}

	}
}
