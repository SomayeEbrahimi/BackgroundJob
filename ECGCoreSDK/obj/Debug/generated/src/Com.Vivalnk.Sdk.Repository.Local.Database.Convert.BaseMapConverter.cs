using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Local.Database.Convert {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.convert']/class[@name='BaseMapConverter']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/local/database/convert/BaseMapConverter", DoNotGenerateAcw=true)]
	public partial class BaseMapConverter : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.convert']/class[@name='BaseMapConverter']/field[@name='mapType']"
		[Register ("mapType")]
		public static global::Java.Lang.Reflect.IType MapType {
			get {
				const string __id = "mapType.Ljava/lang/reflect/Type;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mapType.Ljava/lang/reflect/Type;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/local/database/convert/BaseMapConverter", typeof (BaseMapConverter));
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

		protected BaseMapConverter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.convert']/class[@name='BaseMapConverter']/constructor[@name='BaseMapConverter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseMapConverter ()
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

		static Delegate cb_convertToDatabaseValue_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetConvertToDatabaseValue_Ljava_util_Map_Handler ()
		{
			if (cb_convertToDatabaseValue_Ljava_util_Map_ == null)
				cb_convertToDatabaseValue_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ConvertToDatabaseValue_Ljava_util_Map_);
			return cb_convertToDatabaseValue_Ljava_util_Map_;
		}

		static IntPtr n_ConvertToDatabaseValue_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Convert.BaseMapConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ConvertToDatabaseValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.convert']/class[@name='BaseMapConverter']/method[@name='convertToDatabaseValue' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("convertToDatabaseValue", "(Ljava/util/Map;)Ljava/lang/String;", "GetConvertToDatabaseValue_Ljava_util_Map_Handler")]
		public virtual unsafe string ConvertToDatabaseValue (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			const string __id = "convertToDatabaseValue.(Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_convertToEntityProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConvertToEntityProperty_Ljava_lang_String_Handler ()
		{
			if (cb_convertToEntityProperty_Ljava_lang_String_ == null)
				cb_convertToEntityProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ConvertToEntityProperty_Ljava_lang_String_);
			return cb_convertToEntityProperty_Ljava_lang_String_;
		}

		static IntPtr n_ConvertToEntityProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Convert.BaseMapConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.ConvertToEntityProperty (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.convert']/class[@name='BaseMapConverter']/method[@name='convertToEntityProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("convertToEntityProperty", "(Ljava/lang/String;)Ljava/util/Map;", "GetConvertToEntityProperty_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ConvertToEntityProperty (string p0)
		{
			const string __id = "convertToEntityProperty.(Ljava/lang/String;)Ljava/util/Map;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
