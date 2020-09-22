using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='FormBody']"
	[global::Android.Runtime.Register ("okhttp3/FormBody", DoNotGenerateAcw=true)]
	public sealed partial class FormBody : global::Okhttp3.RequestBody {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='FormBody.Builder']"
		[global::Android.Runtime.Register ("okhttp3/FormBody$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/FormBody$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='FormBody.Builder']/constructor[@name='FormBody.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static IntPtr id_ctor_Ljava_nio_charset_Charset_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='FormBody.Builder']/constructor[@name='FormBody.Builder' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
			[Register (".ctor", "(Ljava/nio/charset/Charset;)V", "")]
			public unsafe Builder (global::Java.Nio.Charset.Charset charset)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (charset);
					if (((object) this).GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/charset/Charset;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/charset/Charset;)V", __args);
						return;
					}

					if (id_ctor_Ljava_nio_charset_Charset_ == IntPtr.Zero)
						id_ctor_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/charset/Charset;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_charset_Charset_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_charset_Charset_, __args);
				} finally {
				}
			}

			static IntPtr id_add_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody.Builder']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("add", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/FormBody$Builder;", "")]
			public unsafe global::Okhttp3.FormBody.Builder Add (string name, string value)
			{
				if (id_add_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_add_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/FormBody$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (native_value);
					global::Okhttp3.FormBody.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.FormBody.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_addEncoded_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody.Builder']/method[@name='addEncoded' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addEncoded", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/FormBody$Builder;", "")]
			public unsafe global::Okhttp3.FormBody.Builder AddEncoded (string name, string value)
			{
				if (id_addEncoded_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_addEncoded_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addEncoded", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/FormBody$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (native_value);
					global::Okhttp3.FormBody.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.FormBody.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addEncoded_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/FormBody;", "")]
			public unsafe global::Okhttp3.FormBody Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lokhttp3/FormBody;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.FormBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/FormBody", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FormBody); }
		}

		internal FormBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_contentType;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()Lokhttp3/MediaType;", "")]
		public override unsafe global::Okhttp3.MediaType ContentType ()
		{
			if (id_contentType == IntPtr.Zero)
				id_contentType = JNIEnv.GetMethodID (class_ref, "contentType", "()Lokhttp3/MediaType;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_contentType), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_encodedName_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody']/method[@name='encodedName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("encodedName", "(I)Ljava/lang/String;", "")]
		public unsafe string EncodedName (int index)
		{
			if (id_encodedName_I == IntPtr.Zero)
				id_encodedName_I = JNIEnv.GetMethodID (class_ref, "encodedName", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodedName_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_encodedValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody']/method[@name='encodedValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("encodedValue", "(I)Ljava/lang/String;", "")]
		public unsafe string EncodedValue (int index)
		{
			if (id_encodedValue_I == IntPtr.Zero)
				id_encodedValue_I = JNIEnv.GetMethodID (class_ref, "encodedValue", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodedValue_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_name_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody']/method[@name='name' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("name", "(I)Ljava/lang/String;", "")]
		public unsafe string Name (int index)
		{
			if (id_name_I == IntPtr.Zero)
				id_name_I = JNIEnv.GetMethodID (class_ref, "name", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_name_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
			} finally {
			}
		}

		static IntPtr id_value_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='FormBody']/method[@name='value' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("value", "(I)Ljava/lang/String;", "")]
		public unsafe string Value (int index)
		{
			if (id_value_I == IntPtr.Zero)
				id_value_I = JNIEnv.GetMethodID (class_ref, "value", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_value_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
