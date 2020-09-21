using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Vdireaderimpl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']"
	[global::Android.Runtime.Register ("com/vivalnk/vdireaderimpl/CommonFunction", DoNotGenerateAcw=true)]
	public partial class CommonFunction : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/field[@name='DEFAULT_OFFEST']"
		[Register ("DEFAULT_OFFEST")]
		public const float DefaultOffest = (float) -100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/field[@name='OFFEST_UNIT']"
		[Register ("OFFEST_UNIT")]
		public const float OffestUnit = (float) 0.0001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/field[@name='PREFERENCE_OFFEST_PREFIX']"
		[Register ("PREFERENCE_OFFEST_PREFIX")]
		public const string PreferenceOffestPrefix = (string) "V200OffsetPrefix";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/field[@name='PREFERENCE_PASSWORD_PREFIX']"
		[Register ("PREFERENCE_PASSWORD_PREFIX")]
		public const string PreferencePasswordPrefix = (string) "Password";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/field[@name='PREFERENCE__NONCE']"
		[Register ("PREFERENCE__NONCE")]
		public const string PreferenceNonce = (string) "Nonce";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/vdireaderimpl/CommonFunction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CommonFunction); }
		}

		protected CommonFunction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/constructor[@name='CommonFunction' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CommonFunction ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CommonFunction)) {
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

		static IntPtr id_getApplicationSharedPreference;
		static IntPtr id_setApplicationSharedPreference_Landroid_content_SharedPreferences_;
		public static unsafe global::Android.Content.ISharedPreferences ApplicationSharedPreference {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='getApplicationSharedPreference' and count(parameter)=0]"
			[Register ("getApplicationSharedPreference", "()Landroid/content/SharedPreferences;", "")]
			get {
				if (id_getApplicationSharedPreference == IntPtr.Zero)
					id_getApplicationSharedPreference = JNIEnv.GetStaticMethodID (class_ref, "getApplicationSharedPreference", "()Landroid/content/SharedPreferences;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getApplicationSharedPreference), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='setApplicationSharedPreference' and count(parameter)=1 and parameter[1][@type='android.content.SharedPreferences']]"
			[Register ("setApplicationSharedPreference", "(Landroid/content/SharedPreferences;)V", "")]
			set {
				if (id_setApplicationSharedPreference_Landroid_content_SharedPreferences_ == IntPtr.Zero)
					id_setApplicationSharedPreference_Landroid_content_SharedPreferences_ = JNIEnv.GetStaticMethodID (class_ref, "setApplicationSharedPreference", "(Landroid/content/SharedPreferences;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setApplicationSharedPreference_Landroid_content_SharedPreferences_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_C2F_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='C2F' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("C2F", "(F)F", "")]
		public static unsafe float C2F (float p0)
		{
			if (id_C2F_F == IntPtr.Zero)
				id_C2F_F = JNIEnv.GetStaticMethodID (class_ref, "C2F", "(F)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_C2F_F, __args);
			} finally {
			}
		}

		static IntPtr id_F2C_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='F2C' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("F2C", "(F)F", "")]
		public static unsafe float F2C (float p0)
		{
			if (id_F2C_F == IntPtr.Zero)
				id_F2C_F = JNIEnv.GetStaticMethodID (class_ref, "F2C", "(F)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_F2C_F, __args);
			} finally {
			}
		}

		static IntPtr id_getBooleanPreferenceValue_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='getBooleanPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getBooleanPreferenceValue", "(Ljava/lang/String;Z)Z", "")]
		public static unsafe bool GetBooleanPreferenceValue (string p0, bool p1)
		{
			if (id_getBooleanPreferenceValue_Ljava_lang_String_Z == IntPtr.Zero)
				id_getBooleanPreferenceValue_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "getBooleanPreferenceValue", "(Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_getBooleanPreferenceValue_Ljava_lang_String_Z, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getFloatPreferenceValue_Ljava_lang_String_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='getFloatPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("getFloatPreferenceValue", "(Ljava/lang/String;F)F", "")]
		public static unsafe float GetFloatPreferenceValue (string p0, float p1)
		{
			if (id_getFloatPreferenceValue_Ljava_lang_String_F == IntPtr.Zero)
				id_getFloatPreferenceValue_Ljava_lang_String_F = JNIEnv.GetStaticMethodID (class_ref, "getFloatPreferenceValue", "(Ljava/lang/String;F)F");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getFloatPreferenceValue_Ljava_lang_String_F, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getIntPreferenceValue_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='getIntPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getIntPreferenceValue", "(Ljava/lang/String;I)I", "")]
		public static unsafe int GetIntPreferenceValue (string p0, int p1)
		{
			if (id_getIntPreferenceValue_Ljava_lang_String_I == IntPtr.Zero)
				id_getIntPreferenceValue_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getIntPreferenceValue", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getIntPreferenceValue_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getLongPreferenceValue_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='getLongPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("getLongPreferenceValue", "(Ljava/lang/String;J)J", "")]
		public static unsafe long GetLongPreferenceValue (string p0, long p1)
		{
			if (id_getLongPreferenceValue_Ljava_lang_String_J == IntPtr.Zero)
				id_getLongPreferenceValue_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "getLongPreferenceValue", "(Ljava/lang/String;J)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getLongPreferenceValue_Ljava_lang_String_J, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getStringPreferenceValue_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='getStringPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStringPreferenceValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetStringPreferenceValue (string p0, string p1)
		{
			if (id_getStringPreferenceValue_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getStringPreferenceValue_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStringPreferenceValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStringPreferenceValue_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_saveBooleanPreferenceValue_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='saveBooleanPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("saveBooleanPreferenceValue", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void SaveBooleanPreferenceValue (string p0, bool p1)
		{
			if (id_saveBooleanPreferenceValue_Ljava_lang_String_Z == IntPtr.Zero)
				id_saveBooleanPreferenceValue_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "saveBooleanPreferenceValue", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_saveBooleanPreferenceValue_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_saveFloatPreferenceValue_Ljava_lang_String_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='saveFloatPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("saveFloatPreferenceValue", "(Ljava/lang/String;F)V", "")]
		public static unsafe void SaveFloatPreferenceValue (string p0, float p1)
		{
			if (id_saveFloatPreferenceValue_Ljava_lang_String_F == IntPtr.Zero)
				id_saveFloatPreferenceValue_Ljava_lang_String_F = JNIEnv.GetStaticMethodID (class_ref, "saveFloatPreferenceValue", "(Ljava/lang/String;F)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_saveFloatPreferenceValue_Ljava_lang_String_F, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_saveIntPreferenceValue_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='saveIntPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("saveIntPreferenceValue", "(Ljava/lang/String;I)V", "")]
		public static unsafe void SaveIntPreferenceValue (string p0, int p1)
		{
			if (id_saveIntPreferenceValue_Ljava_lang_String_I == IntPtr.Zero)
				id_saveIntPreferenceValue_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "saveIntPreferenceValue", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_saveIntPreferenceValue_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_saveLongPreferenceValue_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='saveLongPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("saveLongPreferenceValue", "(Ljava/lang/String;J)V", "")]
		public static unsafe void SaveLongPreferenceValue (string p0, long p1)
		{
			if (id_saveLongPreferenceValue_Ljava_lang_String_J == IntPtr.Zero)
				id_saveLongPreferenceValue_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "saveLongPreferenceValue", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_saveLongPreferenceValue_Ljava_lang_String_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_saveStringPreferenceValue_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='saveStringPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("saveStringPreferenceValue", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SaveStringPreferenceValue (string p0, string p1)
		{
			if (id_saveStringPreferenceValue_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_saveStringPreferenceValue_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "saveStringPreferenceValue", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_saveStringPreferenceValue_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
