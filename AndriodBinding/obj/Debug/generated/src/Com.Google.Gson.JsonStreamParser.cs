using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='JsonStreamParser']"
	[global::Android.Runtime.Register ("com/google/gson/JsonStreamParser", DoNotGenerateAcw=true)]
	public sealed partial class JsonStreamParser : global::Java.Lang.Object, global::Java.Util.IIterator {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/JsonStreamParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonStreamParser); }
		}

		internal JsonStreamParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_Reader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonStreamParser']/constructor[@name='JsonStreamParser' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register (".ctor", "(Ljava/io/Reader;)V", "")]
		public unsafe JsonStreamParser (global::Java.IO.Reader reader)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (reader);
				if (((object) this).GetType () != typeof (JsonStreamParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/Reader;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/Reader;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_Reader_ == IntPtr.Zero)
					id_ctor_Ljava_io_Reader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/Reader;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_Reader_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_Reader_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonStreamParser']/constructor[@name='JsonStreamParser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe JsonStreamParser (string json)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_json);
				if (((object) this).GetType () != typeof (JsonStreamParser)) {
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
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

		static IntPtr id_hasNext;
		public unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonStreamParser']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "")]
			get {
				if (id_hasNext == IntPtr.Zero)
					id_hasNext = JNIEnv.GetMethodID (class_ref, "hasNext", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasNext);
				} finally {
				}
			}
		}

		static IntPtr id_next;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonStreamParser']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Next ()
		{
			if (id_next == IntPtr.Zero)
				id_next = JNIEnv.GetMethodID (class_ref, "next", "()Lcom/google/gson/JsonElement;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_next), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_remove;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonStreamParser']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "")]
		public unsafe void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove);
			} finally {
			}
		}

	}
}
