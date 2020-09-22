using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']"
	[global::Android.Runtime.Register ("okhttp3/internal/Internal", DoNotGenerateAcw=true)]
	public abstract partial class Internal : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/field[@name='instance']"
		[Register ("instance")]
		public static global::Okhttp3.Internal.Internal Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lokhttp3/internal/Internal;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lokhttp3/internal/Internal;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, instance_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/Internal", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Internal); }
		}

		protected Internal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/constructor[@name='Internal' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Internal ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Internal)) {
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

		static Delegate cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Handler ()
		{
			if (cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_ == null)
				cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_);
			return cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_;
		}

		static void n_AddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddLenient (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='addLenient' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers.Builder'] and parameter[2][@type='java.lang.String']]"
		[Register ("addLenient", "(Lokhttp3/Headers$Builder;Ljava/lang/String;)V", "GetAddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Handler")]
		public abstract void AddLenient (global::Okhttp3.Headers.Builder p0, string p1);

		static Delegate cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_);
			return cb_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers.Builder> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddLenient (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='addLenient' and count(parameter)=3 and parameter[1][@type='okhttp3.Headers.Builder'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("addLenient", "(Lokhttp3/Headers$Builder;Ljava/lang/String;Ljava/lang/String;)V", "GetAddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void AddLenient (global::Okhttp3.Headers.Builder p0, string p1, string p2);

		static Delegate cb_apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z;
#pragma warning disable 0169
		static Delegate GetApply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_ZHandler ()
		{
			if (cb_apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z == null)
				cb_apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_V) n_Apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z);
			return cb_apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z;
		}

		static void n_Apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionSpec> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocket> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Apply (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='apply' and count(parameter)=3 and parameter[1][@type='okhttp3.ConnectionSpec'] and parameter[2][@type='javax.net.ssl.SSLSocket'] and parameter[3][@type='boolean']]"
		[Register ("apply", "(Lokhttp3/ConnectionSpec;Ljavax/net/ssl/SSLSocket;Z)V", "GetApply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_ZHandler")]
		public abstract void Apply (global::Okhttp3.ConnectionSpec p0, global::Javax.Net.Ssl.SSLSocket p1, bool p2);

		static Delegate cb_code_Lokhttp3_Response_Builder_;
#pragma warning disable 0169
		static Delegate GetCode_Lokhttp3_Response_Builder_Handler ()
		{
			if (cb_code_Lokhttp3_Response_Builder_ == null)
				cb_code_Lokhttp3_Response_Builder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_Code_Lokhttp3_Response_Builder_);
			return cb_code_Lokhttp3_Response_Builder_;
		}

		static int n_Code_Lokhttp3_Response_Builder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Code (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='code' and count(parameter)=1 and parameter[1][@type='okhttp3.Response.Builder']]"
		[Register ("code", "(Lokhttp3/Response$Builder;)I", "GetCode_Lokhttp3_Response_Builder_Handler")]
		public abstract int Code (global::Okhttp3.Response.Builder p0);

		static Delegate cb_equalsNonHost_Lokhttp3_Address_Lokhttp3_Address_;
#pragma warning disable 0169
		static Delegate GetEqualsNonHost_Lokhttp3_Address_Lokhttp3_Address_Handler ()
		{
			if (cb_equalsNonHost_Lokhttp3_Address_Lokhttp3_Address_ == null)
				cb_equalsNonHost_Lokhttp3_Address_Lokhttp3_Address_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_EqualsNonHost_Lokhttp3_Address_Lokhttp3_Address_);
			return cb_equalsNonHost_Lokhttp3_Address_Lokhttp3_Address_;
		}

		static bool n_EqualsNonHost_Lokhttp3_Address_Lokhttp3_Address_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Address> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Address> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EqualsNonHost (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='equalsNonHost' and count(parameter)=2 and parameter[1][@type='okhttp3.Address'] and parameter[2][@type='okhttp3.Address']]"
		[Register ("equalsNonHost", "(Lokhttp3/Address;Lokhttp3/Address;)Z", "GetEqualsNonHost_Lokhttp3_Address_Lokhttp3_Address_Handler")]
		public abstract bool EqualsNonHost (global::Okhttp3.Address p0, global::Okhttp3.Address p1);

		static Delegate cb_exchange_Lokhttp3_Response_;
#pragma warning disable 0169
		static Delegate GetExchange_Lokhttp3_Response_Handler ()
		{
			if (cb_exchange_Lokhttp3_Response_ == null)
				cb_exchange_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Exchange_Lokhttp3_Response_);
			return cb_exchange_Lokhttp3_Response_;
		}

		static IntPtr n_Exchange_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Exchange (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='exchange' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("exchange", "(Lokhttp3/Response;)Lokhttp3/internal/connection/Exchange;", "GetExchange_Lokhttp3_Response_Handler")]
		public abstract global::Okhttp3.Internal.Connection.Exchange Exchange (global::Okhttp3.Response p0);

		static Delegate cb_initExchange_Lokhttp3_Response_Builder_Lokhttp3_internal_connection_Exchange_;
#pragma warning disable 0169
		static Delegate GetInitExchange_Lokhttp3_Response_Builder_Lokhttp3_internal_connection_Exchange_Handler ()
		{
			if (cb_initExchange_Lokhttp3_Response_Builder_Lokhttp3_internal_connection_Exchange_ == null)
				cb_initExchange_Lokhttp3_Response_Builder_Lokhttp3_internal_connection_Exchange_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_InitExchange_Lokhttp3_Response_Builder_Lokhttp3_internal_connection_Exchange_);
			return cb_initExchange_Lokhttp3_Response_Builder_Lokhttp3_internal_connection_Exchange_;
		}

		static void n_InitExchange_Lokhttp3_Response_Builder_Lokhttp3_internal_connection_Exchange_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.Exchange> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InitExchange (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='initExchange' and count(parameter)=2 and parameter[1][@type='okhttp3.Response.Builder'] and parameter[2][@type='okhttp3.internal.connection.Exchange']]"
		[Register ("initExchange", "(Lokhttp3/Response$Builder;Lokhttp3/internal/connection/Exchange;)V", "GetInitExchange_Lokhttp3_Response_Builder_Lokhttp3_internal_connection_Exchange_Handler")]
		public abstract void InitExchange (global::Okhttp3.Response.Builder p0, global::Okhttp3.Internal.Connection.Exchange p1);

		static IntPtr id_initializeInstanceForTests;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='initializeInstanceForTests' and count(parameter)=0]"
		[Register ("initializeInstanceForTests", "()V", "")]
		public static unsafe void InitializeInstanceForTests ()
		{
			if (id_initializeInstanceForTests == IntPtr.Zero)
				id_initializeInstanceForTests = JNIEnv.GetStaticMethodID (class_ref, "initializeInstanceForTests", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initializeInstanceForTests);
			} finally {
			}
		}

		static Delegate cb_newWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_;
#pragma warning disable 0169
		static Delegate GetNewWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_Handler ()
		{
			if (cb_newWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_ == null)
				cb_newWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_NewWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_);
			return cb_newWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_;
		}

		static IntPtr n_NewWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewWebSocketCall (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='newWebSocketCall' and count(parameter)=2 and parameter[1][@type='okhttp3.OkHttpClient'] and parameter[2][@type='okhttp3.Request']]"
		[Register ("newWebSocketCall", "(Lokhttp3/OkHttpClient;Lokhttp3/Request;)Lokhttp3/Call;", "GetNewWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_Handler")]
		public abstract global::Okhttp3.ICall NewWebSocketCall (global::Okhttp3.OkHttpClient p0, global::Okhttp3.Request p1);

		static Delegate cb_realConnectionPool_Lokhttp3_ConnectionPool_;
#pragma warning disable 0169
		static Delegate GetRealConnectionPool_Lokhttp3_ConnectionPool_Handler ()
		{
			if (cb_realConnectionPool_Lokhttp3_ConnectionPool_ == null)
				cb_realConnectionPool_Lokhttp3_ConnectionPool_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_RealConnectionPool_Lokhttp3_ConnectionPool_);
			return cb_realConnectionPool_Lokhttp3_ConnectionPool_;
		}

		static IntPtr n_RealConnectionPool_Lokhttp3_ConnectionPool_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Internal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionPool> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RealConnectionPool (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='realConnectionPool' and count(parameter)=1 and parameter[1][@type='okhttp3.ConnectionPool']]"
		[Register ("realConnectionPool", "(Lokhttp3/ConnectionPool;)Lokhttp3/internal/connection/RealConnectionPool;", "GetRealConnectionPool_Lokhttp3_ConnectionPool_Handler")]
		public abstract global::Okhttp3.Internal.Connection.RealConnectionPool RealConnectionPool (global::Okhttp3.ConnectionPool p0);

	}

	[global::Android.Runtime.Register ("okhttp3/internal/Internal", DoNotGenerateAcw=true)]
	internal partial class InternalInvoker : Internal {

		public InternalInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (InternalInvoker); }
		}

		static IntPtr id_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='addLenient' and count(parameter)=2 and parameter[1][@type='okhttp3.Headers.Builder'] and parameter[2][@type='java.lang.String']]"
		[Register ("addLenient", "(Lokhttp3/Headers$Builder;Ljava/lang/String;)V", "GetAddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Handler")]
		public override unsafe void AddLenient (global::Okhttp3.Headers.Builder p0, string p1)
		{
			if (id_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_ == IntPtr.Zero)
				id_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addLenient", "(Lokhttp3/Headers$Builder;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='addLenient' and count(parameter)=3 and parameter[1][@type='okhttp3.Headers.Builder'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("addLenient", "(Lokhttp3/Headers$Builder;Ljava/lang/String;Ljava/lang/String;)V", "GetAddLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void AddLenient (global::Okhttp3.Headers.Builder p0, string p1, string p2)
		{
			if (id_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addLenient", "(Lokhttp3/Headers$Builder;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addLenient_Lokhttp3_Headers_Builder_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='apply' and count(parameter)=3 and parameter[1][@type='okhttp3.ConnectionSpec'] and parameter[2][@type='javax.net.ssl.SSLSocket'] and parameter[3][@type='boolean']]"
		[Register ("apply", "(Lokhttp3/ConnectionSpec;Ljavax/net/ssl/SSLSocket;Z)V", "GetApply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_ZHandler")]
		public override unsafe void Apply (global::Okhttp3.ConnectionSpec p0, global::Javax.Net.Ssl.SSLSocket p1, bool p2)
		{
			if (id_apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z == IntPtr.Zero)
				id_apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z = JNIEnv.GetMethodID (class_ref, "apply", "(Lokhttp3/ConnectionSpec;Ljavax/net/ssl/SSLSocket;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lokhttp3_ConnectionSpec_Ljavax_net_ssl_SSLSocket_Z, __args);
			} finally {
			}
		}

		static IntPtr id_code_Lokhttp3_Response_Builder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='code' and count(parameter)=1 and parameter[1][@type='okhttp3.Response.Builder']]"
		[Register ("code", "(Lokhttp3/Response$Builder;)I", "GetCode_Lokhttp3_Response_Builder_Handler")]
		public override unsafe int Code (global::Okhttp3.Response.Builder p0)
		{
			if (id_code_Lokhttp3_Response_Builder_ == IntPtr.Zero)
				id_code_Lokhttp3_Response_Builder_ = JNIEnv.GetMethodID (class_ref, "code", "(Lokhttp3/Response$Builder;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_code_Lokhttp3_Response_Builder_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_equalsNonHost_Lokhttp3_Address_Lokhttp3_Address_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='equalsNonHost' and count(parameter)=2 and parameter[1][@type='okhttp3.Address'] and parameter[2][@type='okhttp3.Address']]"
		[Register ("equalsNonHost", "(Lokhttp3/Address;Lokhttp3/Address;)Z", "GetEqualsNonHost_Lokhttp3_Address_Lokhttp3_Address_Handler")]
		public override unsafe bool EqualsNonHost (global::Okhttp3.Address p0, global::Okhttp3.Address p1)
		{
			if (id_equalsNonHost_Lokhttp3_Address_Lokhttp3_Address_ == IntPtr.Zero)
				id_equalsNonHost_Lokhttp3_Address_Lokhttp3_Address_ = JNIEnv.GetMethodID (class_ref, "equalsNonHost", "(Lokhttp3/Address;Lokhttp3/Address;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equalsNonHost_Lokhttp3_Address_Lokhttp3_Address_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_exchange_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='exchange' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("exchange", "(Lokhttp3/Response;)Lokhttp3/internal/connection/Exchange;", "GetExchange_Lokhttp3_Response_Handler")]
		public override unsafe global::Okhttp3.Internal.Connection.Exchange Exchange (global::Okhttp3.Response p0)
		{
			if (id_exchange_Lokhttp3_Response_ == IntPtr.Zero)
				id_exchange_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "exchange", "(Lokhttp3/Response;)Lokhttp3/internal/connection/Exchange;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Okhttp3.Internal.Connection.Exchange __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.Exchange> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_exchange_Lokhttp3_Response_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initExchange_Lokhttp3_Response_Builder_Lokhttp3_internal_connection_Exchange_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='initExchange' and count(parameter)=2 and parameter[1][@type='okhttp3.Response.Builder'] and parameter[2][@type='okhttp3.internal.connection.Exchange']]"
		[Register ("initExchange", "(Lokhttp3/Response$Builder;Lokhttp3/internal/connection/Exchange;)V", "GetInitExchange_Lokhttp3_Response_Builder_Lokhttp3_internal_connection_Exchange_Handler")]
		public override unsafe void InitExchange (global::Okhttp3.Response.Builder p0, global::Okhttp3.Internal.Connection.Exchange p1)
		{
			if (id_initExchange_Lokhttp3_Response_Builder_Lokhttp3_internal_connection_Exchange_ == IntPtr.Zero)
				id_initExchange_Lokhttp3_Response_Builder_Lokhttp3_internal_connection_Exchange_ = JNIEnv.GetMethodID (class_ref, "initExchange", "(Lokhttp3/Response$Builder;Lokhttp3/internal/connection/Exchange;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initExchange_Lokhttp3_Response_Builder_Lokhttp3_internal_connection_Exchange_, __args);
			} finally {
			}
		}

		static IntPtr id_newWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='newWebSocketCall' and count(parameter)=2 and parameter[1][@type='okhttp3.OkHttpClient'] and parameter[2][@type='okhttp3.Request']]"
		[Register ("newWebSocketCall", "(Lokhttp3/OkHttpClient;Lokhttp3/Request;)Lokhttp3/Call;", "GetNewWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_Handler")]
		public override unsafe global::Okhttp3.ICall NewWebSocketCall (global::Okhttp3.OkHttpClient p0, global::Okhttp3.Request p1)
		{
			if (id_newWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_ == IntPtr.Zero)
				id_newWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_ = JNIEnv.GetMethodID (class_ref, "newWebSocketCall", "(Lokhttp3/OkHttpClient;Lokhttp3/Request;)Lokhttp3/Call;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Okhttp3.ICall __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newWebSocketCall_Lokhttp3_OkHttpClient_Lokhttp3_Request_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_realConnectionPool_Lokhttp3_ConnectionPool_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal']/class[@name='Internal']/method[@name='realConnectionPool' and count(parameter)=1 and parameter[1][@type='okhttp3.ConnectionPool']]"
		[Register ("realConnectionPool", "(Lokhttp3/ConnectionPool;)Lokhttp3/internal/connection/RealConnectionPool;", "GetRealConnectionPool_Lokhttp3_ConnectionPool_Handler")]
		public override unsafe global::Okhttp3.Internal.Connection.RealConnectionPool RealConnectionPool (global::Okhttp3.ConnectionPool p0)
		{
			if (id_realConnectionPool_Lokhttp3_ConnectionPool_ == IntPtr.Zero)
				id_realConnectionPool_Lokhttp3_ConnectionPool_ = JNIEnv.GetMethodID (class_ref, "realConnectionPool", "(Lokhttp3/ConnectionPool;)Lokhttp3/internal/connection/RealConnectionPool;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Okhttp3.Internal.Connection.RealConnectionPool __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.RealConnectionPool> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_realConnectionPool_Lokhttp3_ConnectionPool_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
