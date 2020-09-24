using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

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
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/vdireaderimpl/CommonFunction", typeof (CommonFunction));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected CommonFunction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/constructor[@name='CommonFunction' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CommonFunction ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe global::Android.Content.ISharedPreferences ApplicationSharedPreference {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='getApplicationSharedPreference' and count(parameter)=0]"
			[Register ("getApplicationSharedPreference", "()Landroid/content/SharedPreferences;", "")]
			get {
				const string __id = "getApplicationSharedPreference.()Landroid/content/SharedPreferences;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='setApplicationSharedPreference' and count(parameter)=1 and parameter[1][@type='android.content.SharedPreferences']]"
			[Register ("setApplicationSharedPreference", "(Landroid/content/SharedPreferences;)V", "")]
			set {
				const string __id = "setApplicationSharedPreference.(Landroid/content/SharedPreferences;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='C2F' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("C2F", "(F)F", "")]
		public static unsafe float C2F (float p0)
		{
			const string __id = "C2F.(F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='F2C' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("F2C", "(F)F", "")]
		public static unsafe float F2C (float p0)
		{
			const string __id = "F2C.(F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='getBooleanPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getBooleanPreferenceValue", "(Ljava/lang/String;Z)Z", "")]
		public static unsafe bool GetBooleanPreferenceValue (string p0, bool p1)
		{
			const string __id = "getBooleanPreferenceValue.(Ljava/lang/String;Z)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='getFloatPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("getFloatPreferenceValue", "(Ljava/lang/String;F)F", "")]
		public static unsafe float GetFloatPreferenceValue (string p0, float p1)
		{
			const string __id = "getFloatPreferenceValue.(Ljava/lang/String;F)F";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='getIntPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getIntPreferenceValue", "(Ljava/lang/String;I)I", "")]
		public static unsafe int GetIntPreferenceValue (string p0, int p1)
		{
			const string __id = "getIntPreferenceValue.(Ljava/lang/String;I)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='getLongPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("getLongPreferenceValue", "(Ljava/lang/String;J)J", "")]
		public static unsafe long GetLongPreferenceValue (string p0, long p1)
		{
			const string __id = "getLongPreferenceValue.(Ljava/lang/String;J)J";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='getStringPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStringPreferenceValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetStringPreferenceValue (string p0, string p1)
		{
			const string __id = "getStringPreferenceValue.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='saveBooleanPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("saveBooleanPreferenceValue", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void SaveBooleanPreferenceValue (string p0, bool p1)
		{
			const string __id = "saveBooleanPreferenceValue.(Ljava/lang/String;Z)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='saveFloatPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("saveFloatPreferenceValue", "(Ljava/lang/String;F)V", "")]
		public static unsafe void SaveFloatPreferenceValue (string p0, float p1)
		{
			const string __id = "saveFloatPreferenceValue.(Ljava/lang/String;F)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='saveIntPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("saveIntPreferenceValue", "(Ljava/lang/String;I)V", "")]
		public static unsafe void SaveIntPreferenceValue (string p0, int p1)
		{
			const string __id = "saveIntPreferenceValue.(Ljava/lang/String;I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='saveLongPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("saveLongPreferenceValue", "(Ljava/lang/String;J)V", "")]
		public static unsafe void SaveLongPreferenceValue (string p0, long p1)
		{
			const string __id = "saveLongPreferenceValue.(Ljava/lang/String;J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='CommonFunction']/method[@name='saveStringPreferenceValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("saveStringPreferenceValue", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SaveStringPreferenceValue (string p0, string p1)
		{
			const string __id = "saveStringPreferenceValue.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
