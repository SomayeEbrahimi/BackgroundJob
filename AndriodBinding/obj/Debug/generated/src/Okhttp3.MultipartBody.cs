using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']"
	[global::Android.Runtime.Register ("okhttp3/MultipartBody", DoNotGenerateAcw=true)]
	public sealed partial class MultipartBody : global::Okhttp3.RequestBody {


		static IntPtr ALTERNATIVE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/field[@name='ALTERNATIVE']"
		[Register ("ALTERNATIVE")]
		public static global::Okhttp3.MediaType Alternative {
			get {
				if (ALTERNATIVE_jfieldId == IntPtr.Zero)
					ALTERNATIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALTERNATIVE", "Lokhttp3/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALTERNATIVE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DIGEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/field[@name='DIGEST']"
		[Register ("DIGEST")]
		public static global::Okhttp3.MediaType Digest {
			get {
				if (DIGEST_jfieldId == IntPtr.Zero)
					DIGEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIGEST", "Lokhttp3/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DIGEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FORM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/field[@name='FORM']"
		[Register ("FORM")]
		public static global::Okhttp3.MediaType Form {
			get {
				if (FORM_jfieldId == IntPtr.Zero)
					FORM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORM", "Lokhttp3/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FORM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MIXED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/field[@name='MIXED']"
		[Register ("MIXED")]
		public static global::Okhttp3.MediaType Mixed {
			get {
				if (MIXED_jfieldId == IntPtr.Zero)
					MIXED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MIXED", "Lokhttp3/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MIXED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PARALLEL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/field[@name='PARALLEL']"
		[Register ("PARALLEL")]
		public static global::Okhttp3.MediaType Parallel {
			get {
				if (PARALLEL_jfieldId == IntPtr.Zero)
					PARALLEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARALLEL", "Lokhttp3/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PARALLEL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']"
		[global::Android.Runtime.Register ("okhttp3/MultipartBody$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/MultipartBody$Builder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/constructor[@name='MultipartBody.Builder' and count(parameter)=0]"
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

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/constructor[@name='MultipartBody.Builder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe Builder (string boundary)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_boundary = JNIEnv.NewString (boundary);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_boundary);
					if (((object) this).GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_boundary);
				}
			}

			static IntPtr id_addFormDataPart_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/method[@name='addFormDataPart' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addFormDataPart", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/MultipartBody$Builder;", "")]
			public unsafe global::Okhttp3.MultipartBody.Builder AddFormDataPart (string name, string value)
			{
				if (id_addFormDataPart_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_addFormDataPart_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addFormDataPart", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/MultipartBody$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (native_value);
					global::Okhttp3.MultipartBody.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addFormDataPart_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_addFormDataPart_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/method[@name='addFormDataPart' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='okhttp3.RequestBody']]"
			[Register ("addFormDataPart", "(Ljava/lang/String;Ljava/lang/String;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Builder;", "")]
			public unsafe global::Okhttp3.MultipartBody.Builder AddFormDataPart (string name, string filename, global::Okhttp3.RequestBody body)
			{
				if (id_addFormDataPart_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_ == IntPtr.Zero)
					id_addFormDataPart_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_ = JNIEnv.GetMethodID (class_ref, "addFormDataPart", "(Ljava/lang/String;Ljava/lang/String;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Builder;");
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_filename = JNIEnv.NewString (filename);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (native_filename);
					__args [2] = new JValue (body);
					global::Okhttp3.MultipartBody.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addFormDataPart_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_filename);
				}
			}

			static IntPtr id_addPart_Lokhttp3_Headers_Lokhttp3_RequestBody_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/method[@name='addPart' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers'] and parameter[2][@type='okhttp3.RequestBody']]"
			[Register ("addPart", "(Lokhttp3/Headers;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Builder;", "")]
			public unsafe global::Okhttp3.MultipartBody.Builder AddPart (global::Okhttp3.Headers headers, global::Okhttp3.RequestBody body)
			{
				if (id_addPart_Lokhttp3_Headers_Lokhttp3_RequestBody_ == IntPtr.Zero)
					id_addPart_Lokhttp3_Headers_Lokhttp3_RequestBody_ = JNIEnv.GetMethodID (class_ref, "addPart", "(Lokhttp3/Headers;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (headers);
					__args [1] = new JValue (body);
					global::Okhttp3.MultipartBody.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addPart_Lokhttp3_Headers_Lokhttp3_RequestBody_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_addPart_Lokhttp3_MultipartBody_Part_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/method[@name='addPart' and count(parameter)=1 and parameter[1][@type='okhttp3.MultipartBody.Part']]"
			[Register ("addPart", "(Lokhttp3/MultipartBody$Part;)Lokhttp3/MultipartBody$Builder;", "")]
			public unsafe global::Okhttp3.MultipartBody.Builder AddPart (global::Okhttp3.MultipartBody.Part part)
			{
				if (id_addPart_Lokhttp3_MultipartBody_Part_ == IntPtr.Zero)
					id_addPart_Lokhttp3_MultipartBody_Part_ = JNIEnv.GetMethodID (class_ref, "addPart", "(Lokhttp3/MultipartBody$Part;)Lokhttp3/MultipartBody$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (part);
					global::Okhttp3.MultipartBody.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addPart_Lokhttp3_MultipartBody_Part_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_addPart_Lokhttp3_RequestBody_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/method[@name='addPart' and count(parameter)=1 and parameter[1][@type='okhttp3.RequestBody']]"
			[Register ("addPart", "(Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Builder;", "")]
			public unsafe global::Okhttp3.MultipartBody.Builder AddPart (global::Okhttp3.RequestBody body)
			{
				if (id_addPart_Lokhttp3_RequestBody_ == IntPtr.Zero)
					id_addPart_Lokhttp3_RequestBody_ = JNIEnv.GetMethodID (class_ref, "addPart", "(Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (body);
					global::Okhttp3.MultipartBody.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addPart_Lokhttp3_RequestBody_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/MultipartBody;", "")]
			public unsafe global::Okhttp3.MultipartBody Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lokhttp3/MultipartBody;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setType_Lokhttp3_MediaType_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Builder']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='okhttp3.MediaType']]"
			[Register ("setType", "(Lokhttp3/MediaType;)Lokhttp3/MultipartBody$Builder;", "")]
			public unsafe global::Okhttp3.MultipartBody.Builder SetType (global::Okhttp3.MediaType type)
			{
				if (id_setType_Lokhttp3_MediaType_ == IntPtr.Zero)
					id_setType_Lokhttp3_MediaType_ = JNIEnv.GetMethodID (class_ref, "setType", "(Lokhttp3/MediaType;)Lokhttp3/MultipartBody$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (type);
					global::Okhttp3.MultipartBody.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setType_Lokhttp3_MediaType_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Part']"
		[global::Android.Runtime.Register ("okhttp3/MultipartBody$Part", DoNotGenerateAcw=true)]
		public sealed partial class Part : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/MultipartBody$Part", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Part); }
			}

			internal Part (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_body;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Part']/method[@name='body' and count(parameter)=0]"
			[Register ("body", "()Lokhttp3/RequestBody;", "")]
			public unsafe global::Okhttp3.RequestBody Body ()
			{
				if (id_body == IntPtr.Zero)
					id_body = JNIEnv.GetMethodID (class_ref, "body", "()Lokhttp3/RequestBody;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.RequestBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_body), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_create_Lokhttp3_Headers_Lokhttp3_RequestBody_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Part']/method[@name='create' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers'] and parameter[2][@type='okhttp3.RequestBody']]"
			[Register ("create", "(Lokhttp3/Headers;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Part;", "")]
			public static unsafe global::Okhttp3.MultipartBody.Part Create (global::Okhttp3.Headers headers, global::Okhttp3.RequestBody body)
			{
				if (id_create_Lokhttp3_Headers_Lokhttp3_RequestBody_ == IntPtr.Zero)
					id_create_Lokhttp3_Headers_Lokhttp3_RequestBody_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lokhttp3/Headers;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Part;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (headers);
					__args [1] = new JValue (body);
					global::Okhttp3.MultipartBody.Part __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Part> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lokhttp3_Headers_Lokhttp3_RequestBody_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_create_Lokhttp3_RequestBody_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Part']/method[@name='create' and count(parameter)=1 and parameter[1][@type='okhttp3.RequestBody']]"
			[Register ("create", "(Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Part;", "")]
			public static unsafe global::Okhttp3.MultipartBody.Part Create (global::Okhttp3.RequestBody body)
			{
				if (id_create_Lokhttp3_RequestBody_ == IntPtr.Zero)
					id_create_Lokhttp3_RequestBody_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Part;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (body);
					global::Okhttp3.MultipartBody.Part __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Part> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lokhttp3_RequestBody_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_createFormData_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Part']/method[@name='createFormData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("createFormData", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/MultipartBody$Part;", "")]
			public static unsafe global::Okhttp3.MultipartBody.Part CreateFormData (string name, string value)
			{
				if (id_createFormData_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_createFormData_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createFormData", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/MultipartBody$Part;");
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (native_value);
					global::Okhttp3.MultipartBody.Part __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Part> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFormData_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr id_createFormData_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Part']/method[@name='createFormData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='okhttp3.RequestBody']]"
			[Register ("createFormData", "(Ljava/lang/String;Ljava/lang/String;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Part;", "")]
			public static unsafe global::Okhttp3.MultipartBody.Part CreateFormData (string name, string filename, global::Okhttp3.RequestBody body)
			{
				if (id_createFormData_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_ == IntPtr.Zero)
					id_createFormData_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_ = JNIEnv.GetStaticMethodID (class_ref, "createFormData", "(Ljava/lang/String;Ljava/lang/String;Lokhttp3/RequestBody;)Lokhttp3/MultipartBody$Part;");
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_filename = JNIEnv.NewString (filename);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_name);
					__args [1] = new JValue (native_filename);
					__args [2] = new JValue (body);
					global::Okhttp3.MultipartBody.Part __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Part> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFormData_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_filename);
				}
			}

			static IntPtr id_headers;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody.Part']/method[@name='headers' and count(parameter)=0]"
			[Register ("headers", "()Lokhttp3/Headers;", "")]
			public unsafe global::Okhttp3.Headers Headers ()
			{
				if (id_headers == IntPtr.Zero)
					id_headers = JNIEnv.GetMethodID (class_ref, "headers", "()Lokhttp3/Headers;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headers), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/MultipartBody", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultipartBody); }
		}

		internal MultipartBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_boundary;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/method[@name='boundary' and count(parameter)=0]"
		[Register ("boundary", "()Ljava/lang/String;", "")]
		public unsafe string Boundary ()
		{
			if (id_boundary == IntPtr.Zero)
				id_boundary = JNIEnv.GetMethodID (class_ref, "boundary", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_boundary), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_contentType;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/method[@name='contentType' and count(parameter)=0]"
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

		static IntPtr id_part_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/method[@name='part' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("part", "(I)Lokhttp3/MultipartBody$Part;", "")]
		public unsafe global::Okhttp3.MultipartBody.Part InvokePart (int index)
		{
			if (id_part_I == IntPtr.Zero)
				id_part_I = JNIEnv.GetMethodID (class_ref, "part", "(I)Lokhttp3/MultipartBody$Part;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MultipartBody.Part> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_part_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_parts;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/method[@name='parts' and count(parameter)=0]"
		[Register ("parts", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Okhttp3.MultipartBody.Part> Parts ()
		{
			if (id_parts == IntPtr.Zero)
				id_parts = JNIEnv.GetMethodID (class_ref, "parts", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Okhttp3.MultipartBody.Part>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parts), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/method[@name='size' and count(parameter)=0]"
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

		static IntPtr id_type;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='MultipartBody']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Lokhttp3/MediaType;", "")]
		public unsafe global::Okhttp3.MediaType Type ()
		{
			if (id_type == IntPtr.Zero)
				id_type = JNIEnv.GetMethodID (class_ref, "type", "()Lokhttp3/MediaType;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.MediaType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_type), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
