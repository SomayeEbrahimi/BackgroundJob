using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']"
	[global::Android.Runtime.Register ("com/google/gson/JsonPrimitive", DoNotGenerateAcw=true)]
	public sealed partial class JsonPrimitive : global::Com.Google.Gson.JsonElement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/JsonPrimitive", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonPrimitive); }
		}

		internal JsonPrimitive (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Boolean_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']/constructor[@name='JsonPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register (".ctor", "(Ljava/lang/Boolean;)V", "")]
		public unsafe JsonPrimitive (global::Java.Lang.Boolean @bool)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@bool);
				if (((object) this).GetType () != typeof (JsonPrimitive)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Boolean;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Boolean;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Boolean;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Boolean_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Boolean_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Character_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']/constructor[@name='JsonPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Character']]"
		[Register (".ctor", "(Ljava/lang/Character;)V", "")]
		public unsafe JsonPrimitive (global::Java.Lang.Character c)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (c);
				if (((object) this).GetType () != typeof (JsonPrimitive)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Character;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Character;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Character_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Character_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Character;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Character_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Character_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Number_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']/constructor[@name='JsonPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register (".ctor", "(Ljava/lang/Number;)V", "")]
		public unsafe JsonPrimitive (global::Java.Lang.Number number)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (number);
				if (((object) this).GetType () != typeof (JsonPrimitive)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Number;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Number;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Number_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Number;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Number_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Number_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']/constructor[@name='JsonPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe JsonPrimitive (string @string)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__string);
				if (((object) this).GetType () != typeof (JsonPrimitive)) {
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
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		static IntPtr id_isBoolean;
		public unsafe bool IsBoolean {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']/method[@name='isBoolean' and count(parameter)=0]"
			[Register ("isBoolean", "()Z", "")]
			get {
				if (id_isBoolean == IntPtr.Zero)
					id_isBoolean = JNIEnv.GetMethodID (class_ref, "isBoolean", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBoolean);
				} finally {
				}
			}
		}

		static IntPtr id_isNumber;
		public unsafe bool IsNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']/method[@name='isNumber' and count(parameter)=0]"
			[Register ("isNumber", "()Z", "")]
			get {
				if (id_isNumber == IntPtr.Zero)
					id_isNumber = JNIEnv.GetMethodID (class_ref, "isNumber", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNumber);
				} finally {
				}
			}
		}

		static IntPtr id_isString;
		public unsafe bool IsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']/method[@name='isString' and count(parameter)=0]"
			[Register ("isString", "()Z", "")]
			get {
				if (id_isString == IntPtr.Zero)
					id_isString = JNIEnv.GetMethodID (class_ref, "isString", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isString);
				} finally {
				}
			}
		}

		static IntPtr id_deepCopy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonPrimitive']/method[@name='deepCopy' and count(parameter)=0]"
		[Register ("deepCopy", "()Lcom/google/gson/JsonPrimitive;", "")]
		public unsafe global::Com.Google.Gson.JsonPrimitive DeepCopy ()
		{
			if (id_deepCopy == IntPtr.Zero)
				id_deepCopy = JNIEnv.GetMethodID (class_ref, "deepCopy", "()Lcom/google/gson/JsonPrimitive;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonPrimitive> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deepCopy), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
