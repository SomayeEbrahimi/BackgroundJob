using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Text {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrLookup']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/StrLookup", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
	public abstract partial class StrLookup : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/text/StrLookup", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StrLookup); }
		}

		protected StrLookup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrLookup']/constructor[@name='StrLookup' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe StrLookup ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StrLookup)) {
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

		static Delegate cb_lookup_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLookup_Ljava_lang_String_Handler ()
		{
			if (cb_lookup_Ljava_lang_String_ == null)
				cb_lookup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Lookup_Ljava_lang_String_);
			return cb_lookup_Ljava_lang_String_;
		}

		static IntPtr n_Lookup_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrLookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Lookup (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrLookup']/method[@name='lookup' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lookup", "(Ljava/lang/String;)Ljava/lang/String;", "GetLookup_Ljava_lang_String_Handler")]
		public abstract string Lookup (string p0);

		static IntPtr id_mapLookup_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrLookup']/method[@name='mapLookup' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, V&gt;']]"
		[Register ("mapLookup", "(Ljava/util/Map;)Lorg/apache/commons/lang3/text/StrLookup;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrLookup MapLookup (global::System.Collections.IDictionary map)
		{
			if (id_mapLookup_Ljava_util_Map_ == IntPtr.Zero)
				id_mapLookup_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "mapLookup", "(Ljava/util/Map;)Lorg/apache/commons/lang3/text/StrLookup;");
			IntPtr native_map = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (map);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_map);
				global::Org.Apache.Commons.Lang3.Text.StrLookup __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrLookup> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mapLookup_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_map);
			}
		}

		static IntPtr id_noneLookup;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrLookup']/method[@name='noneLookup' and count(parameter)=0]"
		[Register ("noneLookup", "()Lorg/apache/commons/lang3/text/StrLookup;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrLookup NoneLookup ()
		{
			if (id_noneLookup == IntPtr.Zero)
				id_noneLookup = JNIEnv.GetStaticMethodID (class_ref, "noneLookup", "()Lorg/apache/commons/lang3/text/StrLookup;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrLookup> (JNIEnv.CallStaticObjectMethod  (class_ref, id_noneLookup), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_systemPropertiesLookup;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrLookup']/method[@name='systemPropertiesLookup' and count(parameter)=0]"
		[Register ("systemPropertiesLookup", "()Lorg/apache/commons/lang3/text/StrLookup;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Text.StrLookup SystemPropertiesLookup ()
		{
			if (id_systemPropertiesLookup == IntPtr.Zero)
				id_systemPropertiesLookup = JNIEnv.GetStaticMethodID (class_ref, "systemPropertiesLookup", "()Lorg/apache/commons/lang3/text/StrLookup;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Text.StrLookup> (JNIEnv.CallStaticObjectMethod  (class_ref, id_systemPropertiesLookup), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/text/StrLookup", DoNotGenerateAcw=true)]
	internal partial class StrLookupInvoker : StrLookup {

		public StrLookupInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (StrLookupInvoker); }
		}

		static IntPtr id_lookup_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.text']/class[@name='StrLookup']/method[@name='lookup' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lookup", "(Ljava/lang/String;)Ljava/lang/String;", "GetLookup_Ljava_lang_String_Handler")]
		public override unsafe string Lookup (string p0)
		{
			if (id_lookup_Ljava_lang_String_ == IntPtr.Zero)
				id_lookup_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "lookup", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_lookup_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
