using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Platform {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']"
	[global::Android.Runtime.Register ("okhttp3/internal/platform/Platform", DoNotGenerateAcw=true)]
	public partial class Platform : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/field[@name='INFO']"
		[Register ("INFO")]
		public const int Info = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/field[@name='WARN']"
		[Register ("WARN")]
		public const int Warn = (int) 5;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/platform/Platform", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Platform); }
		}

		protected Platform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/constructor[@name='Platform' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Platform ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Platform)) {
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

		static IntPtr id_isConscryptPreferred;
		public static unsafe bool IsConscryptPreferred {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='isConscryptPreferred' and count(parameter)=0]"
			[Register ("isConscryptPreferred", "()Z", "")]
			get {
				if (id_isConscryptPreferred == IntPtr.Zero)
					id_isConscryptPreferred = JNIEnv.GetStaticMethodID (class_ref, "isConscryptPreferred", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isConscryptPreferred);
				} finally {
				}
			}
		}

		static Delegate cb_getPrefix;
#pragma warning disable 0169
		static Delegate GetGetPrefixHandler ()
		{
			if (cb_getPrefix == null)
				cb_getPrefix = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrefix);
			return cb_getPrefix;
		}

		static IntPtr n_GetPrefix (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Prefix);
		}
#pragma warning restore 0169

		static IntPtr id_getPrefix;
		public virtual unsafe string Prefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='getPrefix' and count(parameter)=0]"
			[Register ("getPrefix", "()Ljava/lang/String;", "GetGetPrefixHandler")]
			get {
				if (id_getPrefix == IntPtr.Zero)
					id_getPrefix = JNIEnv.GetMethodID (class_ref, "getPrefix", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrefix), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrefix", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSSLContext;
#pragma warning disable 0169
		static Delegate GetGetSSLContextHandler ()
		{
			if (cb_getSSLContext == null)
				cb_getSSLContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSSLContext);
			return cb_getSSLContext;
		}

		static IntPtr n_GetSSLContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SSLContext);
		}
#pragma warning restore 0169

		static IntPtr id_getSSLContext;
		public virtual unsafe global::Javax.Net.Ssl.SSLContext SSLContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='getSSLContext' and count(parameter)=0]"
			[Register ("getSSLContext", "()Ljavax/net/ssl/SSLContext;", "GetGetSSLContextHandler")]
			get {
				if (id_getSSLContext == IntPtr.Zero)
					id_getSSLContext = JNIEnv.GetMethodID (class_ref, "getSSLContext", "()Ljavax/net/ssl/SSLContext;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLContext> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSSLContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLContext> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSSLContext", "()Ljavax/net/ssl/SSLContext;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_afterHandshake_Ljavax_net_ssl_SSLSocket_;
#pragma warning disable 0169
		static Delegate GetAfterHandshake_Ljavax_net_ssl_SSLSocket_Handler ()
		{
			if (cb_afterHandshake_Ljavax_net_ssl_SSLSocket_ == null)
				cb_afterHandshake_Ljavax_net_ssl_SSLSocket_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AfterHandshake_Ljavax_net_ssl_SSLSocket_);
			return cb_afterHandshake_Ljavax_net_ssl_SSLSocket_;
		}

		static void n_AfterHandshake_Ljavax_net_ssl_SSLSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sslSocket)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sslSocket = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocket> (native_sslSocket, JniHandleOwnership.DoNotTransfer);
			__this.AfterHandshake (sslSocket);
		}
#pragma warning restore 0169

		static IntPtr id_afterHandshake_Ljavax_net_ssl_SSLSocket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='afterHandshake' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocket']]"
		[Register ("afterHandshake", "(Ljavax/net/ssl/SSLSocket;)V", "GetAfterHandshake_Ljavax_net_ssl_SSLSocket_Handler")]
		public virtual unsafe void AfterHandshake (global::Javax.Net.Ssl.SSLSocket sslSocket)
		{
			if (id_afterHandshake_Ljavax_net_ssl_SSLSocket_ == IntPtr.Zero)
				id_afterHandshake_Ljavax_net_ssl_SSLSocket_ = JNIEnv.GetMethodID (class_ref, "afterHandshake", "(Ljavax/net/ssl/SSLSocket;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sslSocket);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_afterHandshake_Ljavax_net_ssl_SSLSocket_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "afterHandshake", "(Ljavax/net/ssl/SSLSocket;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_alpnProtocolNames_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='alpnProtocolNames' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;okhttp3.Protocol&gt;']]"
		[Register ("alpnProtocolNames", "(Ljava/util/List;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> AlpnProtocolNames (global::System.Collections.Generic.IList<global::Okhttp3.Protocol> protocols)
		{
			if (id_alpnProtocolNames_Ljava_util_List_ == IntPtr.Zero)
				id_alpnProtocolNames_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "alpnProtocolNames", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_protocols = global::Android.Runtime.JavaList<global::Okhttp3.Protocol>.ToLocalJniHandle (protocols);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_protocols);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_alpnProtocolNames_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_protocols);
			}
		}

		static Delegate cb_buildCertificateChainCleaner_Ljavax_net_ssl_SSLSocketFactory_;
#pragma warning disable 0169
		static Delegate GetBuildCertificateChainCleaner_Ljavax_net_ssl_SSLSocketFactory_Handler ()
		{
			if (cb_buildCertificateChainCleaner_Ljavax_net_ssl_SSLSocketFactory_ == null)
				cb_buildCertificateChainCleaner_Ljavax_net_ssl_SSLSocketFactory_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_BuildCertificateChainCleaner_Ljavax_net_ssl_SSLSocketFactory_);
			return cb_buildCertificateChainCleaner_Ljavax_net_ssl_SSLSocketFactory_;
		}

		static IntPtr n_BuildCertificateChainCleaner_Ljavax_net_ssl_SSLSocketFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sslSocketFactory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sslSocketFactory = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (native_sslSocketFactory, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildCertificateChainCleaner (sslSocketFactory));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildCertificateChainCleaner_Ljavax_net_ssl_SSLSocketFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='buildCertificateChainCleaner' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocketFactory']]"
		[Register ("buildCertificateChainCleaner", "(Ljavax/net/ssl/SSLSocketFactory;)Lokhttp3/internal/tls/CertificateChainCleaner;", "GetBuildCertificateChainCleaner_Ljavax_net_ssl_SSLSocketFactory_Handler")]
		public virtual unsafe global::Okhttp3.Internal.Tls.CertificateChainCleaner BuildCertificateChainCleaner (global::Javax.Net.Ssl.SSLSocketFactory sslSocketFactory)
		{
			if (id_buildCertificateChainCleaner_Ljavax_net_ssl_SSLSocketFactory_ == IntPtr.Zero)
				id_buildCertificateChainCleaner_Ljavax_net_ssl_SSLSocketFactory_ = JNIEnv.GetMethodID (class_ref, "buildCertificateChainCleaner", "(Ljavax/net/ssl/SSLSocketFactory;)Lokhttp3/internal/tls/CertificateChainCleaner;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sslSocketFactory);

				global::Okhttp3.Internal.Tls.CertificateChainCleaner __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.CertificateChainCleaner> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildCertificateChainCleaner_Ljavax_net_ssl_SSLSocketFactory_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.CertificateChainCleaner> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildCertificateChainCleaner", "(Ljavax/net/ssl/SSLSocketFactory;)Lokhttp3/internal/tls/CertificateChainCleaner;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_buildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_;
#pragma warning disable 0169
		static Delegate GetBuildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_Handler ()
		{
			if (cb_buildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_ == null)
				cb_buildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_BuildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_);
			return cb_buildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_;
		}

		static IntPtr n_BuildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_trustManager)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var trustManager = (global::Javax.Net.Ssl.IX509TrustManager)global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IX509TrustManager> (native_trustManager, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildCertificateChainCleaner (trustManager));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='buildCertificateChainCleaner' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.X509TrustManager']]"
		[Register ("buildCertificateChainCleaner", "(Ljavax/net/ssl/X509TrustManager;)Lokhttp3/internal/tls/CertificateChainCleaner;", "GetBuildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_Handler")]
		public virtual unsafe global::Okhttp3.Internal.Tls.CertificateChainCleaner BuildCertificateChainCleaner (global::Javax.Net.Ssl.IX509TrustManager trustManager)
		{
			if (id_buildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_ == IntPtr.Zero)
				id_buildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_ = JNIEnv.GetMethodID (class_ref, "buildCertificateChainCleaner", "(Ljavax/net/ssl/X509TrustManager;)Lokhttp3/internal/tls/CertificateChainCleaner;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (trustManager);

				global::Okhttp3.Internal.Tls.CertificateChainCleaner __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.CertificateChainCleaner> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildCertificateChainCleaner_Ljavax_net_ssl_X509TrustManager_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.CertificateChainCleaner> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildCertificateChainCleaner", "(Ljavax/net/ssl/X509TrustManager;)Lokhttp3/internal/tls/CertificateChainCleaner;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_buildTrustRootIndex_Ljavax_net_ssl_X509TrustManager_;
#pragma warning disable 0169
		static Delegate GetBuildTrustRootIndex_Ljavax_net_ssl_X509TrustManager_Handler ()
		{
			if (cb_buildTrustRootIndex_Ljavax_net_ssl_X509TrustManager_ == null)
				cb_buildTrustRootIndex_Ljavax_net_ssl_X509TrustManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_BuildTrustRootIndex_Ljavax_net_ssl_X509TrustManager_);
			return cb_buildTrustRootIndex_Ljavax_net_ssl_X509TrustManager_;
		}

		static IntPtr n_BuildTrustRootIndex_Ljavax_net_ssl_X509TrustManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_trustManager)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var trustManager = (global::Javax.Net.Ssl.IX509TrustManager)global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IX509TrustManager> (native_trustManager, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildTrustRootIndex (trustManager));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildTrustRootIndex_Ljavax_net_ssl_X509TrustManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='buildTrustRootIndex' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.X509TrustManager']]"
		[Register ("buildTrustRootIndex", "(Ljavax/net/ssl/X509TrustManager;)Lokhttp3/internal/tls/TrustRootIndex;", "GetBuildTrustRootIndex_Ljavax_net_ssl_X509TrustManager_Handler")]
		public virtual unsafe global::Okhttp3.Internal.Tls.ITrustRootIndex BuildTrustRootIndex (global::Javax.Net.Ssl.IX509TrustManager trustManager)
		{
			if (id_buildTrustRootIndex_Ljavax_net_ssl_X509TrustManager_ == IntPtr.Zero)
				id_buildTrustRootIndex_Ljavax_net_ssl_X509TrustManager_ = JNIEnv.GetMethodID (class_ref, "buildTrustRootIndex", "(Ljavax/net/ssl/X509TrustManager;)Lokhttp3/internal/tls/TrustRootIndex;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (trustManager);

				global::Okhttp3.Internal.Tls.ITrustRootIndex __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.ITrustRootIndex> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildTrustRootIndex_Ljavax_net_ssl_X509TrustManager_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Tls.ITrustRootIndex> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildTrustRootIndex", "(Ljavax/net/ssl/X509TrustManager;)Lokhttp3/internal/tls/TrustRootIndex;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_configureSslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_;
#pragma warning disable 0169
		static Delegate GetConfigureSslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_Handler ()
		{
			if (cb_configureSslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_ == null)
				cb_configureSslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ConfigureSslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_);
			return cb_configureSslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_;
		}

		static void n_ConfigureSslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_socketFactory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var socketFactory = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (native_socketFactory, JniHandleOwnership.DoNotTransfer);
			__this.ConfigureSslSocketFactory (socketFactory);
		}
#pragma warning restore 0169

		static IntPtr id_configureSslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='configureSslSocketFactory' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocketFactory']]"
		[Register ("configureSslSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V", "GetConfigureSslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_Handler")]
		public virtual unsafe void ConfigureSslSocketFactory (global::Javax.Net.Ssl.SSLSocketFactory socketFactory)
		{
			if (id_configureSslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_ == IntPtr.Zero)
				id_configureSslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_ = JNIEnv.GetMethodID (class_ref, "configureSslSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (socketFactory);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_configureSslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "configureSslSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_configureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetConfigureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_configureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_ == null)
				cb_configureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_ConfigureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_);
			return cb_configureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_;
		}

		static void n_ConfigureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sslSocket, IntPtr native_hostname, IntPtr native_protocols)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sslSocket = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocket> (native_sslSocket, JniHandleOwnership.DoNotTransfer);
			var hostname = JNIEnv.GetString (native_hostname, JniHandleOwnership.DoNotTransfer);
			var protocols = global::Android.Runtime.JavaList<global::Okhttp3.Protocol>.FromJniHandle (native_protocols, JniHandleOwnership.DoNotTransfer);
			__this.ConfigureTlsExtensions (sslSocket, hostname, protocols);
		}
#pragma warning restore 0169

		static IntPtr id_configureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='configureTlsExtensions' and count(parameter)=3 and parameter[1][@type='javax.net.ssl.SSLSocket'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;okhttp3.Protocol&gt;']]"
		[Register ("configureTlsExtensions", "(Ljavax/net/ssl/SSLSocket;Ljava/lang/String;Ljava/util/List;)V", "GetConfigureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe void ConfigureTlsExtensions (global::Javax.Net.Ssl.SSLSocket sslSocket, string hostname, global::System.Collections.Generic.IList<global::Okhttp3.Protocol> protocols)
		{
			if (id_configureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_configureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "configureTlsExtensions", "(Ljavax/net/ssl/SSLSocket;Ljava/lang/String;Ljava/util/List;)V");
			IntPtr native_hostname = JNIEnv.NewString (hostname);
			IntPtr native_protocols = global::Android.Runtime.JavaList<global::Okhttp3.Protocol>.ToLocalJniHandle (protocols);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (sslSocket);
				__args [1] = new JValue (native_hostname);
				__args [2] = new JValue (native_protocols);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_configureTlsExtensions_Ljavax_net_ssl_SSLSocket_Ljava_lang_String_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "configureTlsExtensions", "(Ljavax/net/ssl/SSLSocket;Ljava/lang/String;Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_hostname);
				JNIEnv.DeleteLocalRef (native_protocols);
			}
		}

		static Delegate cb_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I;
#pragma warning disable 0169
		static Delegate GetConnectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_IHandler ()
		{
			if (cb_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I == null)
				cb_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_ConnectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I);
			return cb_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I;
		}

		static void n_ConnectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I (IntPtr jnienv, IntPtr native__this, IntPtr native_socket, IntPtr native_address, int connectTimeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var socket = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_socket, JniHandleOwnership.DoNotTransfer);
			var address = global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (native_address, JniHandleOwnership.DoNotTransfer);
			__this.ConnectSocket (socket, address, connectTimeout);
		}
#pragma warning restore 0169

		static IntPtr id_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='connectSocket' and count(parameter)=3 and parameter[1][@type='java.net.Socket'] and parameter[2][@type='java.net.InetSocketAddress'] and parameter[3][@type='int']]"
		[Register ("connectSocket", "(Ljava/net/Socket;Ljava/net/InetSocketAddress;I)V", "GetConnectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_IHandler")]
		public virtual unsafe void ConnectSocket (global::Java.Net.Socket socket, global::Java.Net.InetSocketAddress address, int connectTimeout)
		{
			if (id_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I == IntPtr.Zero)
				id_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I = JNIEnv.GetMethodID (class_ref, "connectSocket", "(Ljava/net/Socket;Ljava/net/InetSocketAddress;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (socket);
				__args [1] = new JValue (address);
				__args [2] = new JValue (connectTimeout);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectSocket_Ljava_net_Socket_Ljava_net_InetSocketAddress_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectSocket", "(Ljava/net/Socket;Ljava/net/InetSocketAddress;I)V"), __args);
			} finally {
			}
		}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lokhttp3/internal/platform/Platform;", "")]
		public static unsafe global::Okhttp3.Internal.Platform.Platform Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetStaticMethodID (class_ref, "get", "()Lokhttp3/internal/platform/Platform;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSelectedProtocol_Ljavax_net_ssl_SSLSocket_;
#pragma warning disable 0169
		static Delegate GetGetSelectedProtocol_Ljavax_net_ssl_SSLSocket_Handler ()
		{
			if (cb_getSelectedProtocol_Ljavax_net_ssl_SSLSocket_ == null)
				cb_getSelectedProtocol_Ljavax_net_ssl_SSLSocket_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetSelectedProtocol_Ljavax_net_ssl_SSLSocket_);
			return cb_getSelectedProtocol_Ljavax_net_ssl_SSLSocket_;
		}

		static IntPtr n_GetSelectedProtocol_Ljavax_net_ssl_SSLSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_socket)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var socket = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocket> (native_socket, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetSelectedProtocol (socket));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedProtocol_Ljavax_net_ssl_SSLSocket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='getSelectedProtocol' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocket']]"
		[Register ("getSelectedProtocol", "(Ljavax/net/ssl/SSLSocket;)Ljava/lang/String;", "GetGetSelectedProtocol_Ljavax_net_ssl_SSLSocket_Handler")]
		public virtual unsafe string GetSelectedProtocol (global::Javax.Net.Ssl.SSLSocket socket)
		{
			if (id_getSelectedProtocol_Ljavax_net_ssl_SSLSocket_ == IntPtr.Zero)
				id_getSelectedProtocol_Ljavax_net_ssl_SSLSocket_ = JNIEnv.GetMethodID (class_ref, "getSelectedProtocol", "(Ljavax/net/ssl/SSLSocket;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (socket);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedProtocol_Ljavax_net_ssl_SSLSocket_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedProtocol", "(Ljavax/net/ssl/SSLSocket;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getStackTraceForCloseable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetStackTraceForCloseable_Ljava_lang_String_Handler ()
		{
			if (cb_getStackTraceForCloseable_Ljava_lang_String_ == null)
				cb_getStackTraceForCloseable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetStackTraceForCloseable_Ljava_lang_String_);
			return cb_getStackTraceForCloseable_Ljava_lang_String_;
		}

		static IntPtr n_GetStackTraceForCloseable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_closer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var closer = JNIEnv.GetString (native_closer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetStackTraceForCloseable (closer));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStackTraceForCloseable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='getStackTraceForCloseable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStackTraceForCloseable", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetStackTraceForCloseable_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object GetStackTraceForCloseable (string closer)
		{
			if (id_getStackTraceForCloseable_Ljava_lang_String_ == IntPtr.Zero)
				id_getStackTraceForCloseable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getStackTraceForCloseable", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_closer = JNIEnv.NewString (closer);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_closer);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStackTraceForCloseable_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStackTraceForCloseable", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_closer);
			}
		}

		static Delegate cb_isCleartextTrafficPermitted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsCleartextTrafficPermitted_Ljava_lang_String_Handler ()
		{
			if (cb_isCleartextTrafficPermitted_Ljava_lang_String_ == null)
				cb_isCleartextTrafficPermitted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsCleartextTrafficPermitted_Ljava_lang_String_);
			return cb_isCleartextTrafficPermitted_Ljava_lang_String_;
		}

		static bool n_IsCleartextTrafficPermitted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hostname)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var hostname = JNIEnv.GetString (native_hostname, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsCleartextTrafficPermitted (hostname);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isCleartextTrafficPermitted_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='isCleartextTrafficPermitted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isCleartextTrafficPermitted", "(Ljava/lang/String;)Z", "GetIsCleartextTrafficPermitted_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsCleartextTrafficPermitted (string hostname)
		{
			if (id_isCleartextTrafficPermitted_Ljava_lang_String_ == IntPtr.Zero)
				id_isCleartextTrafficPermitted_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isCleartextTrafficPermitted", "(Ljava/lang/String;)Z");
			IntPtr native_hostname = JNIEnv.NewString (hostname);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_hostname);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCleartextTrafficPermitted_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCleartextTrafficPermitted", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_hostname);
			}
		}

		static Delegate cb_log_ILjava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetLog_ILjava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_log_ILjava_lang_String_Ljava_lang_Throwable_ == null)
				cb_log_ILjava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILL_V) n_Log_ILjava_lang_String_Ljava_lang_Throwable_);
			return cb_log_ILjava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Log_ILjava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, int level, IntPtr native_message, IntPtr native_t)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			var t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.Log (level, message, t);
		}
#pragma warning restore 0169

		static IntPtr id_log_ILjava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='log' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("log", "(ILjava/lang/String;Ljava/lang/Throwable;)V", "GetLog_ILjava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Log (int level, string message, global::Java.Lang.Throwable t)
		{
			if (id_log_ILjava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_log_ILjava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "log", "(ILjava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (level);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (t);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_ILjava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "log", "(ILjava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_logCloseableLeak_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetLogCloseableLeak_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_logCloseableLeak_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_logCloseableLeak_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_LogCloseableLeak_Ljava_lang_String_Ljava_lang_Object_);
			return cb_logCloseableLeak_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_LogCloseableLeak_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_stackTrace)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			var stackTrace = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_stackTrace, JniHandleOwnership.DoNotTransfer);
			__this.LogCloseableLeak (message, stackTrace);
		}
#pragma warning restore 0169

		static IntPtr id_logCloseableLeak_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='logCloseableLeak' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("logCloseableLeak", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetLogCloseableLeak_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void LogCloseableLeak (string message, global::Java.Lang.Object stackTrace)
		{
			if (id_logCloseableLeak_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_logCloseableLeak_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "logCloseableLeak", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_message);
				__args [1] = new JValue (stackTrace);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logCloseableLeak_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logCloseableLeak", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_trustManager_Ljavax_net_ssl_SSLSocketFactory_;
#pragma warning disable 0169
		static Delegate GetTrustManager_Ljavax_net_ssl_SSLSocketFactory_Handler ()
		{
			if (cb_trustManager_Ljavax_net_ssl_SSLSocketFactory_ == null)
				cb_trustManager_Ljavax_net_ssl_SSLSocketFactory_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_TrustManager_Ljavax_net_ssl_SSLSocketFactory_);
			return cb_trustManager_Ljavax_net_ssl_SSLSocketFactory_;
		}

		static IntPtr n_TrustManager_Ljavax_net_ssl_SSLSocketFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sslSocketFactory)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Platform.Platform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sslSocketFactory = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (native_sslSocketFactory, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TrustManager (sslSocketFactory));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_trustManager_Ljavax_net_ssl_SSLSocketFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.platform']/class[@name='Platform']/method[@name='trustManager' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocketFactory']]"
		[Register ("trustManager", "(Ljavax/net/ssl/SSLSocketFactory;)Ljavax/net/ssl/X509TrustManager;", "GetTrustManager_Ljavax_net_ssl_SSLSocketFactory_Handler")]
		protected virtual unsafe global::Javax.Net.Ssl.IX509TrustManager TrustManager (global::Javax.Net.Ssl.SSLSocketFactory sslSocketFactory)
		{
			if (id_trustManager_Ljavax_net_ssl_SSLSocketFactory_ == IntPtr.Zero)
				id_trustManager_Ljavax_net_ssl_SSLSocketFactory_ = JNIEnv.GetMethodID (class_ref, "trustManager", "(Ljavax/net/ssl/SSLSocketFactory;)Ljavax/net/ssl/X509TrustManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sslSocketFactory);

				global::Javax.Net.Ssl.IX509TrustManager __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IX509TrustManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_trustManager_Ljavax_net_ssl_SSLSocketFactory_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IX509TrustManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trustManager", "(Ljavax/net/ssl/SSLSocketFactory;)Ljavax/net/ssl/X509TrustManager;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
