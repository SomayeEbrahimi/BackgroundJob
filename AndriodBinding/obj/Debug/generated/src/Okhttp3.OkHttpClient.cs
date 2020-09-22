using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']"
	[global::Android.Runtime.Register ("okhttp3/OkHttpClient", DoNotGenerateAcw=true)]
	public partial class OkHttpClient : global::Java.Lang.Object, global::Java.Lang.ICloneable, global::Okhttp3.ICallFactory, global::Okhttp3.IWebSocketFactory {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']"
		[global::Android.Runtime.Register ("okhttp3/OkHttpClient$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/OkHttpClient$Builder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/constructor[@name='OkHttpClient.Builder' and count(parameter)=0]"
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

			static IntPtr id_addInterceptor_Lokhttp3_Interceptor_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='addInterceptor' and count(parameter)=1 and parameter[1][@type='okhttp3.Interceptor']]"
			[Register ("addInterceptor", "(Lokhttp3/Interceptor;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder AddInterceptor (global::Okhttp3.IInterceptor interceptor)
			{
				if (id_addInterceptor_Lokhttp3_Interceptor_ == IntPtr.Zero)
					id_addInterceptor_Lokhttp3_Interceptor_ = JNIEnv.GetMethodID (class_ref, "addInterceptor", "(Lokhttp3/Interceptor;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (interceptor);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addInterceptor_Lokhttp3_Interceptor_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_addNetworkInterceptor_Lokhttp3_Interceptor_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='addNetworkInterceptor' and count(parameter)=1 and parameter[1][@type='okhttp3.Interceptor']]"
			[Register ("addNetworkInterceptor", "(Lokhttp3/Interceptor;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder AddNetworkInterceptor (global::Okhttp3.IInterceptor interceptor)
			{
				if (id_addNetworkInterceptor_Lokhttp3_Interceptor_ == IntPtr.Zero)
					id_addNetworkInterceptor_Lokhttp3_Interceptor_ = JNIEnv.GetMethodID (class_ref, "addNetworkInterceptor", "(Lokhttp3/Interceptor;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (interceptor);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addNetworkInterceptor_Lokhttp3_Interceptor_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_authenticator_Lokhttp3_Authenticator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='authenticator' and count(parameter)=1 and parameter[1][@type='okhttp3.Authenticator']]"
			[Register ("authenticator", "(Lokhttp3/Authenticator;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder Authenticator (global::Okhttp3.IAuthenticator authenticator)
			{
				if (id_authenticator_Lokhttp3_Authenticator_ == IntPtr.Zero)
					id_authenticator_Lokhttp3_Authenticator_ = JNIEnv.GetMethodID (class_ref, "authenticator", "(Lokhttp3/Authenticator;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (authenticator);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_authenticator_Lokhttp3_Authenticator_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/OkHttpClient;", "")]
			public unsafe global::Okhttp3.OkHttpClient Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lokhttp3/OkHttpClient;");
				try {
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_cache_Lokhttp3_Cache_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='cache' and count(parameter)=1 and parameter[1][@type='okhttp3.Cache']]"
			[Register ("cache", "(Lokhttp3/Cache;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder Cache (global::Okhttp3.Cache cache)
			{
				if (id_cache_Lokhttp3_Cache_ == IntPtr.Zero)
					id_cache_Lokhttp3_Cache_ = JNIEnv.GetMethodID (class_ref, "cache", "(Lokhttp3/Cache;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (cache);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cache_Lokhttp3_Cache_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_callTimeout_JLjava_util_concurrent_TimeUnit_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='callTimeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("callTimeout", "(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder CallTimeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
			{
				if (id_callTimeout_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_callTimeout_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "callTimeout", "(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (timeout);
					__args [1] = new JValue (unit);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_callTimeout_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_certificatePinner_Lokhttp3_CertificatePinner_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='certificatePinner' and count(parameter)=1 and parameter[1][@type='okhttp3.CertificatePinner']]"
			[Register ("certificatePinner", "(Lokhttp3/CertificatePinner;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder CertificatePinner (global::Okhttp3.CertificatePinner certificatePinner)
			{
				if (id_certificatePinner_Lokhttp3_CertificatePinner_ == IntPtr.Zero)
					id_certificatePinner_Lokhttp3_CertificatePinner_ = JNIEnv.GetMethodID (class_ref, "certificatePinner", "(Lokhttp3/CertificatePinner;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (certificatePinner);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_certificatePinner_Lokhttp3_CertificatePinner_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_connectTimeout_JLjava_util_concurrent_TimeUnit_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='connectTimeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("connectTimeout", "(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder ConnectTimeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
			{
				if (id_connectTimeout_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_connectTimeout_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "connectTimeout", "(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (timeout);
					__args [1] = new JValue (unit);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connectTimeout_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_connectionPool_Lokhttp3_ConnectionPool_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='connectionPool' and count(parameter)=1 and parameter[1][@type='okhttp3.ConnectionPool']]"
			[Register ("connectionPool", "(Lokhttp3/ConnectionPool;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder ConnectionPool (global::Okhttp3.ConnectionPool connectionPool)
			{
				if (id_connectionPool_Lokhttp3_ConnectionPool_ == IntPtr.Zero)
					id_connectionPool_Lokhttp3_ConnectionPool_ = JNIEnv.GetMethodID (class_ref, "connectionPool", "(Lokhttp3/ConnectionPool;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (connectionPool);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connectionPool_Lokhttp3_ConnectionPool_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_connectionSpecs_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='connectionSpecs' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;okhttp3.ConnectionSpec&gt;']]"
			[Register ("connectionSpecs", "(Ljava/util/List;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder ConnectionSpecs (global::System.Collections.Generic.IList<global::Okhttp3.ConnectionSpec> connectionSpecs)
			{
				if (id_connectionSpecs_Ljava_util_List_ == IntPtr.Zero)
					id_connectionSpecs_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "connectionSpecs", "(Ljava/util/List;)Lokhttp3/OkHttpClient$Builder;");
				IntPtr native_connectionSpecs = global::Android.Runtime.JavaList<global::Okhttp3.ConnectionSpec>.ToLocalJniHandle (connectionSpecs);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_connectionSpecs);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connectionSpecs_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_connectionSpecs);
				}
			}

			static IntPtr id_cookieJar_Lokhttp3_CookieJar_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='cookieJar' and count(parameter)=1 and parameter[1][@type='okhttp3.CookieJar']]"
			[Register ("cookieJar", "(Lokhttp3/CookieJar;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder CookieJar (global::Okhttp3.ICookieJar cookieJar)
			{
				if (id_cookieJar_Lokhttp3_CookieJar_ == IntPtr.Zero)
					id_cookieJar_Lokhttp3_CookieJar_ = JNIEnv.GetMethodID (class_ref, "cookieJar", "(Lokhttp3/CookieJar;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (cookieJar);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cookieJar_Lokhttp3_CookieJar_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_dispatcher_Lokhttp3_Dispatcher_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='dispatcher' and count(parameter)=1 and parameter[1][@type='okhttp3.Dispatcher']]"
			[Register ("dispatcher", "(Lokhttp3/Dispatcher;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder Dispatcher (global::Okhttp3.Dispatcher dispatcher)
			{
				if (id_dispatcher_Lokhttp3_Dispatcher_ == IntPtr.Zero)
					id_dispatcher_Lokhttp3_Dispatcher_ = JNIEnv.GetMethodID (class_ref, "dispatcher", "(Lokhttp3/Dispatcher;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (dispatcher);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dispatcher_Lokhttp3_Dispatcher_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_dns_Lokhttp3_Dns_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='dns' and count(parameter)=1 and parameter[1][@type='okhttp3.Dns']]"
			[Register ("dns", "(Lokhttp3/Dns;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder Dns (global::Okhttp3.IDns dns)
			{
				if (id_dns_Lokhttp3_Dns_ == IntPtr.Zero)
					id_dns_Lokhttp3_Dns_ = JNIEnv.GetMethodID (class_ref, "dns", "(Lokhttp3/Dns;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (dns);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dns_Lokhttp3_Dns_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_eventListener_Lokhttp3_EventListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='eventListener' and count(parameter)=1 and parameter[1][@type='okhttp3.EventListener']]"
			[Register ("eventListener", "(Lokhttp3/EventListener;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder EventListener (global::Okhttp3.EventListener eventListener)
			{
				if (id_eventListener_Lokhttp3_EventListener_ == IntPtr.Zero)
					id_eventListener_Lokhttp3_EventListener_ = JNIEnv.GetMethodID (class_ref, "eventListener", "(Lokhttp3/EventListener;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (eventListener);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_eventListener_Lokhttp3_EventListener_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_eventListenerFactory_Lokhttp3_EventListener_Factory_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='eventListenerFactory' and count(parameter)=1 and parameter[1][@type='okhttp3.EventListener.Factory']]"
			[Register ("eventListenerFactory", "(Lokhttp3/EventListener$Factory;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder EventListenerFactory (global::Okhttp3.EventListener.IFactory eventListenerFactory)
			{
				if (id_eventListenerFactory_Lokhttp3_EventListener_Factory_ == IntPtr.Zero)
					id_eventListenerFactory_Lokhttp3_EventListener_Factory_ = JNIEnv.GetMethodID (class_ref, "eventListenerFactory", "(Lokhttp3/EventListener$Factory;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (eventListenerFactory);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_eventListenerFactory_Lokhttp3_EventListener_Factory_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_followRedirects_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='followRedirects' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("followRedirects", "(Z)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder FollowRedirects (bool followRedirects)
			{
				if (id_followRedirects_Z == IntPtr.Zero)
					id_followRedirects_Z = JNIEnv.GetMethodID (class_ref, "followRedirects", "(Z)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (followRedirects);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_followRedirects_Z, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_followSslRedirects_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='followSslRedirects' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("followSslRedirects", "(Z)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder FollowSslRedirects (bool followProtocolRedirects)
			{
				if (id_followSslRedirects_Z == IntPtr.Zero)
					id_followSslRedirects_Z = JNIEnv.GetMethodID (class_ref, "followSslRedirects", "(Z)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (followProtocolRedirects);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_followSslRedirects_Z, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_hostnameVerifier_Ljavax_net_ssl_HostnameVerifier_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='hostnameVerifier' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.HostnameVerifier']]"
			[Register ("hostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder HostnameVerifier (global::Javax.Net.Ssl.IHostnameVerifier hostnameVerifier)
			{
				if (id_hostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ == IntPtr.Zero)
					id_hostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ = JNIEnv.GetMethodID (class_ref, "hostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (hostnameVerifier);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hostnameVerifier_Ljavax_net_ssl_HostnameVerifier_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_interceptors;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='interceptors' and count(parameter)=0]"
			[Register ("interceptors", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Okhttp3.IInterceptor> Interceptors ()
			{
				if (id_interceptors == IntPtr.Zero)
					id_interceptors = JNIEnv.GetMethodID (class_ref, "interceptors", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Okhttp3.IInterceptor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_interceptors), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_networkInterceptors;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='networkInterceptors' and count(parameter)=0]"
			[Register ("networkInterceptors", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Okhttp3.IInterceptor> NetworkInterceptors ()
			{
				if (id_networkInterceptors == IntPtr.Zero)
					id_networkInterceptors = JNIEnv.GetMethodID (class_ref, "networkInterceptors", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Okhttp3.IInterceptor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_networkInterceptors), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_pingInterval_JLjava_util_concurrent_TimeUnit_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='pingInterval' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("pingInterval", "(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder PingInterval (long interval, global::Java.Util.Concurrent.TimeUnit unit)
			{
				if (id_pingInterval_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_pingInterval_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "pingInterval", "(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (interval);
					__args [1] = new JValue (unit);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pingInterval_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_protocols_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='protocols' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;okhttp3.Protocol&gt;']]"
			[Register ("protocols", "(Ljava/util/List;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder Protocols (global::System.Collections.Generic.IList<global::Okhttp3.Protocol> protocols)
			{
				if (id_protocols_Ljava_util_List_ == IntPtr.Zero)
					id_protocols_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "protocols", "(Ljava/util/List;)Lokhttp3/OkHttpClient$Builder;");
				IntPtr native_protocols = global::Android.Runtime.JavaList<global::Okhttp3.Protocol>.ToLocalJniHandle (protocols);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_protocols);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_protocols_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_protocols);
				}
			}

			static IntPtr id_proxy_Ljava_net_Proxy_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='proxy' and count(parameter)=1 and parameter[1][@type='java.net.Proxy']]"
			[Register ("proxy", "(Ljava/net/Proxy;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder Proxy (global::Java.Net.Proxy proxy)
			{
				if (id_proxy_Ljava_net_Proxy_ == IntPtr.Zero)
					id_proxy_Ljava_net_Proxy_ = JNIEnv.GetMethodID (class_ref, "proxy", "(Ljava/net/Proxy;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (proxy);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proxy_Ljava_net_Proxy_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_proxyAuthenticator_Lokhttp3_Authenticator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='proxyAuthenticator' and count(parameter)=1 and parameter[1][@type='okhttp3.Authenticator']]"
			[Register ("proxyAuthenticator", "(Lokhttp3/Authenticator;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder ProxyAuthenticator (global::Okhttp3.IAuthenticator proxyAuthenticator)
			{
				if (id_proxyAuthenticator_Lokhttp3_Authenticator_ == IntPtr.Zero)
					id_proxyAuthenticator_Lokhttp3_Authenticator_ = JNIEnv.GetMethodID (class_ref, "proxyAuthenticator", "(Lokhttp3/Authenticator;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (proxyAuthenticator);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proxyAuthenticator_Lokhttp3_Authenticator_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_proxySelector_Ljava_net_ProxySelector_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='proxySelector' and count(parameter)=1 and parameter[1][@type='java.net.ProxySelector']]"
			[Register ("proxySelector", "(Ljava/net/ProxySelector;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder ProxySelector (global::Java.Net.ProxySelector proxySelector)
			{
				if (id_proxySelector_Ljava_net_ProxySelector_ == IntPtr.Zero)
					id_proxySelector_Ljava_net_ProxySelector_ = JNIEnv.GetMethodID (class_ref, "proxySelector", "(Ljava/net/ProxySelector;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (proxySelector);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proxySelector_Ljava_net_ProxySelector_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_readTimeout_JLjava_util_concurrent_TimeUnit_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='readTimeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("readTimeout", "(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder ReadTimeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
			{
				if (id_readTimeout_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_readTimeout_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "readTimeout", "(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (timeout);
					__args [1] = new JValue (unit);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readTimeout_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_retryOnConnectionFailure_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='retryOnConnectionFailure' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("retryOnConnectionFailure", "(Z)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder RetryOnConnectionFailure (bool retryOnConnectionFailure)
			{
				if (id_retryOnConnectionFailure_Z == IntPtr.Zero)
					id_retryOnConnectionFailure_Z = JNIEnv.GetMethodID (class_ref, "retryOnConnectionFailure", "(Z)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (retryOnConnectionFailure);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_retryOnConnectionFailure_Z, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_socketFactory_Ljavax_net_SocketFactory_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='socketFactory' and count(parameter)=1 and parameter[1][@type='javax.net.SocketFactory']]"
			[Register ("socketFactory", "(Ljavax/net/SocketFactory;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder SocketFactory (global::Javax.Net.SocketFactory socketFactory)
			{
				if (id_socketFactory_Ljavax_net_SocketFactory_ == IntPtr.Zero)
					id_socketFactory_Ljavax_net_SocketFactory_ = JNIEnv.GetMethodID (class_ref, "socketFactory", "(Ljavax/net/SocketFactory;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (socketFactory);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_socketFactory_Ljavax_net_SocketFactory_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_sslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='sslSocketFactory' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocketFactory']]"
			[Obsolete (@"deprecated")]
			[Register ("sslSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder SslSocketFactory (global::Javax.Net.Ssl.SSLSocketFactory sslSocketFactory)
			{
				if (id_sslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_ == IntPtr.Zero)
					id_sslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_ = JNIEnv.GetMethodID (class_ref, "sslSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (sslSocketFactory);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_sslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_X509TrustManager_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='sslSocketFactory' and count(parameter)=2 and parameter[1][@type='javax.net.ssl.SSLSocketFactory'] and parameter[2][@type='javax.net.ssl.X509TrustManager']]"
			[Register ("sslSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;Ljavax/net/ssl/X509TrustManager;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder SslSocketFactory (global::Javax.Net.Ssl.SSLSocketFactory sslSocketFactory, global::Javax.Net.Ssl.IX509TrustManager trustManager)
			{
				if (id_sslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_X509TrustManager_ == IntPtr.Zero)
					id_sslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_X509TrustManager_ = JNIEnv.GetMethodID (class_ref, "sslSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;Ljavax/net/ssl/X509TrustManager;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (sslSocketFactory);
					__args [1] = new JValue (trustManager);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sslSocketFactory_Ljavax_net_ssl_SSLSocketFactory_Ljavax_net_ssl_X509TrustManager_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_writeTimeout_JLjava_util_concurrent_TimeUnit_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient.Builder']/method[@name='writeTimeout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
			[Register ("writeTimeout", "(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;", "")]
			public unsafe global::Okhttp3.OkHttpClient.Builder WriteTimeout (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
			{
				if (id_writeTimeout_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_writeTimeout_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "writeTimeout", "(JLjava/util/concurrent/TimeUnit;)Lokhttp3/OkHttpClient$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (timeout);
					__args [1] = new JValue (unit);
					global::Okhttp3.OkHttpClient.Builder __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeTimeout_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/OkHttpClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OkHttpClient); }
		}

		protected OkHttpClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/constructor[@name='OkHttpClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OkHttpClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (OkHttpClient)) {
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

		static Delegate cb_authenticator;
#pragma warning disable 0169
		static Delegate GetAuthenticatorHandler ()
		{
			if (cb_authenticator == null)
				cb_authenticator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Authenticator);
			return cb_authenticator;
		}

		static IntPtr n_Authenticator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Authenticator ());
		}
#pragma warning restore 0169

		static IntPtr id_authenticator;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='authenticator' and count(parameter)=0]"
		[Register ("authenticator", "()Lokhttp3/Authenticator;", "GetAuthenticatorHandler")]
		public virtual unsafe global::Okhttp3.IAuthenticator Authenticator ()
		{
			if (id_authenticator == IntPtr.Zero)
				id_authenticator = JNIEnv.GetMethodID (class_ref, "authenticator", "()Lokhttp3/Authenticator;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okhttp3.IAuthenticator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_authenticator), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okhttp3.IAuthenticator> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authenticator", "()Lokhttp3/Authenticator;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_cache;
#pragma warning disable 0169
		static Delegate GetCacheHandler ()
		{
			if (cb_cache == null)
				cb_cache = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Cache);
			return cb_cache;
		}

		static IntPtr n_Cache (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cache ());
		}
#pragma warning restore 0169

		static IntPtr id_cache;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='cache' and count(parameter)=0]"
		[Register ("cache", "()Lokhttp3/Cache;", "GetCacheHandler")]
		public virtual unsafe global::Okhttp3.Cache Cache ()
		{
			if (id_cache == IntPtr.Zero)
				id_cache = JNIEnv.GetMethodID (class_ref, "cache", "()Lokhttp3/Cache;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Cache> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cache), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Cache> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cache", "()Lokhttp3/Cache;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_callTimeoutMillis;
#pragma warning disable 0169
		static Delegate GetCallTimeoutMillisHandler ()
		{
			if (cb_callTimeoutMillis == null)
				cb_callTimeoutMillis = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_CallTimeoutMillis);
			return cb_callTimeoutMillis;
		}

		static int n_CallTimeoutMillis (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CallTimeoutMillis ();
		}
#pragma warning restore 0169

		static IntPtr id_callTimeoutMillis;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='callTimeoutMillis' and count(parameter)=0]"
		[Register ("callTimeoutMillis", "()I", "GetCallTimeoutMillisHandler")]
		public virtual unsafe int CallTimeoutMillis ()
		{
			if (id_callTimeoutMillis == IntPtr.Zero)
				id_callTimeoutMillis = JNIEnv.GetMethodID (class_ref, "callTimeoutMillis", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_callTimeoutMillis);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "callTimeoutMillis", "()I"));
			} finally {
			}
		}

		static Delegate cb_certificatePinner;
#pragma warning disable 0169
		static Delegate GetCertificatePinnerHandler ()
		{
			if (cb_certificatePinner == null)
				cb_certificatePinner = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CertificatePinner);
			return cb_certificatePinner;
		}

		static IntPtr n_CertificatePinner (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CertificatePinner ());
		}
#pragma warning restore 0169

		static IntPtr id_certificatePinner;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='certificatePinner' and count(parameter)=0]"
		[Register ("certificatePinner", "()Lokhttp3/CertificatePinner;", "GetCertificatePinnerHandler")]
		public virtual unsafe global::Okhttp3.CertificatePinner CertificatePinner ()
		{
			if (id_certificatePinner == IntPtr.Zero)
				id_certificatePinner = JNIEnv.GetMethodID (class_ref, "certificatePinner", "()Lokhttp3/CertificatePinner;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CertificatePinner> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_certificatePinner), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okhttp3.CertificatePinner> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "certificatePinner", "()Lokhttp3/CertificatePinner;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_connectTimeoutMillis;
#pragma warning disable 0169
		static Delegate GetConnectTimeoutMillisHandler ()
		{
			if (cb_connectTimeoutMillis == null)
				cb_connectTimeoutMillis = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_ConnectTimeoutMillis);
			return cb_connectTimeoutMillis;
		}

		static int n_ConnectTimeoutMillis (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectTimeoutMillis ();
		}
#pragma warning restore 0169

		static IntPtr id_connectTimeoutMillis;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='connectTimeoutMillis' and count(parameter)=0]"
		[Register ("connectTimeoutMillis", "()I", "GetConnectTimeoutMillisHandler")]
		public virtual unsafe int ConnectTimeoutMillis ()
		{
			if (id_connectTimeoutMillis == IntPtr.Zero)
				id_connectTimeoutMillis = JNIEnv.GetMethodID (class_ref, "connectTimeoutMillis", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectTimeoutMillis);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectTimeoutMillis", "()I"));
			} finally {
			}
		}

		static Delegate cb_connectionPool;
#pragma warning disable 0169
		static Delegate GetConnectionPoolHandler ()
		{
			if (cb_connectionPool == null)
				cb_connectionPool = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ConnectionPool);
			return cb_connectionPool;
		}

		static IntPtr n_ConnectionPool (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectionPool ());
		}
#pragma warning restore 0169

		static IntPtr id_connectionPool;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='connectionPool' and count(parameter)=0]"
		[Register ("connectionPool", "()Lokhttp3/ConnectionPool;", "GetConnectionPoolHandler")]
		public virtual unsafe global::Okhttp3.ConnectionPool ConnectionPool ()
		{
			if (id_connectionPool == IntPtr.Zero)
				id_connectionPool = JNIEnv.GetMethodID (class_ref, "connectionPool", "()Lokhttp3/ConnectionPool;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionPool> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connectionPool), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ConnectionPool> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectionPool", "()Lokhttp3/ConnectionPool;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_connectionSpecs;
#pragma warning disable 0169
		static Delegate GetConnectionSpecsHandler ()
		{
			if (cb_connectionSpecs == null)
				cb_connectionSpecs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ConnectionSpecs);
			return cb_connectionSpecs;
		}

		static IntPtr n_ConnectionSpecs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Okhttp3.ConnectionSpec>.ToLocalJniHandle (__this.ConnectionSpecs ());
		}
#pragma warning restore 0169

		static IntPtr id_connectionSpecs;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='connectionSpecs' and count(parameter)=0]"
		[Register ("connectionSpecs", "()Ljava/util/List;", "GetConnectionSpecsHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Okhttp3.ConnectionSpec> ConnectionSpecs ()
		{
			if (id_connectionSpecs == IntPtr.Zero)
				id_connectionSpecs = JNIEnv.GetMethodID (class_ref, "connectionSpecs", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Okhttp3.ConnectionSpec>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connectionSpecs), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Okhttp3.ConnectionSpec>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectionSpecs", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_cookieJar;
#pragma warning disable 0169
		static Delegate GetCookieJarHandler ()
		{
			if (cb_cookieJar == null)
				cb_cookieJar = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CookieJar);
			return cb_cookieJar;
		}

		static IntPtr n_CookieJar (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CookieJar ());
		}
#pragma warning restore 0169

		static IntPtr id_cookieJar;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='cookieJar' and count(parameter)=0]"
		[Register ("cookieJar", "()Lokhttp3/CookieJar;", "GetCookieJarHandler")]
		public virtual unsafe global::Okhttp3.ICookieJar CookieJar ()
		{
			if (id_cookieJar == IntPtr.Zero)
				id_cookieJar = JNIEnv.GetMethodID (class_ref, "cookieJar", "()Lokhttp3/CookieJar;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ICookieJar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cookieJar), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okhttp3.ICookieJar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cookieJar", "()Lokhttp3/CookieJar;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dispatcher;
#pragma warning disable 0169
		static Delegate GetDispatcherHandler ()
		{
			if (cb_dispatcher == null)
				cb_dispatcher = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Dispatcher);
			return cb_dispatcher;
		}

		static IntPtr n_Dispatcher (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Dispatcher ());
		}
#pragma warning restore 0169

		static IntPtr id_dispatcher;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='dispatcher' and count(parameter)=0]"
		[Register ("dispatcher", "()Lokhttp3/Dispatcher;", "GetDispatcherHandler")]
		public virtual unsafe global::Okhttp3.Dispatcher Dispatcher ()
		{
			if (id_dispatcher == IntPtr.Zero)
				id_dispatcher = JNIEnv.GetMethodID (class_ref, "dispatcher", "()Lokhttp3/Dispatcher;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Dispatcher> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dispatcher), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Dispatcher> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatcher", "()Lokhttp3/Dispatcher;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dns;
#pragma warning disable 0169
		static Delegate GetDnsHandler ()
		{
			if (cb_dns == null)
				cb_dns = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Dns);
			return cb_dns;
		}

		static IntPtr n_Dns (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Dns ());
		}
#pragma warning restore 0169

		static IntPtr id_dns;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='dns' and count(parameter)=0]"
		[Register ("dns", "()Lokhttp3/Dns;", "GetDnsHandler")]
		public virtual unsafe global::Okhttp3.IDns Dns ()
		{
			if (id_dns == IntPtr.Zero)
				id_dns = JNIEnv.GetMethodID (class_ref, "dns", "()Lokhttp3/Dns;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okhttp3.IDns> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dns), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okhttp3.IDns> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dns", "()Lokhttp3/Dns;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_eventListenerFactory;
#pragma warning disable 0169
		static Delegate GetEventListenerFactoryHandler ()
		{
			if (cb_eventListenerFactory == null)
				cb_eventListenerFactory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_EventListenerFactory);
			return cb_eventListenerFactory;
		}

		static IntPtr n_EventListenerFactory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventListenerFactory ());
		}
#pragma warning restore 0169

		static IntPtr id_eventListenerFactory;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='eventListenerFactory' and count(parameter)=0]"
		[Register ("eventListenerFactory", "()Lokhttp3/EventListener$Factory;", "GetEventListenerFactoryHandler")]
		public virtual unsafe global::Okhttp3.EventListener.IFactory EventListenerFactory ()
		{
			if (id_eventListenerFactory == IntPtr.Zero)
				id_eventListenerFactory = JNIEnv.GetMethodID (class_ref, "eventListenerFactory", "()Lokhttp3/EventListener$Factory;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener.IFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_eventListenerFactory), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okhttp3.EventListener.IFactory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "eventListenerFactory", "()Lokhttp3/EventListener$Factory;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_followRedirects;
#pragma warning disable 0169
		static Delegate GetFollowRedirectsHandler ()
		{
			if (cb_followRedirects == null)
				cb_followRedirects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_FollowRedirects);
			return cb_followRedirects;
		}

		static bool n_FollowRedirects (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FollowRedirects ();
		}
#pragma warning restore 0169

		static IntPtr id_followRedirects;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='followRedirects' and count(parameter)=0]"
		[Register ("followRedirects", "()Z", "GetFollowRedirectsHandler")]
		public virtual unsafe bool FollowRedirects ()
		{
			if (id_followRedirects == IntPtr.Zero)
				id_followRedirects = JNIEnv.GetMethodID (class_ref, "followRedirects", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_followRedirects);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "followRedirects", "()Z"));
			} finally {
			}
		}

		static Delegate cb_followSslRedirects;
#pragma warning disable 0169
		static Delegate GetFollowSslRedirectsHandler ()
		{
			if (cb_followSslRedirects == null)
				cb_followSslRedirects = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_FollowSslRedirects);
			return cb_followSslRedirects;
		}

		static bool n_FollowSslRedirects (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FollowSslRedirects ();
		}
#pragma warning restore 0169

		static IntPtr id_followSslRedirects;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='followSslRedirects' and count(parameter)=0]"
		[Register ("followSslRedirects", "()Z", "GetFollowSslRedirectsHandler")]
		public virtual unsafe bool FollowSslRedirects ()
		{
			if (id_followSslRedirects == IntPtr.Zero)
				id_followSslRedirects = JNIEnv.GetMethodID (class_ref, "followSslRedirects", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_followSslRedirects);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "followSslRedirects", "()Z"));
			} finally {
			}
		}

		static Delegate cb_hostnameVerifier;
#pragma warning disable 0169
		static Delegate GetHostnameVerifierHandler ()
		{
			if (cb_hostnameVerifier == null)
				cb_hostnameVerifier = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_HostnameVerifier);
			return cb_hostnameVerifier;
		}

		static IntPtr n_HostnameVerifier (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HostnameVerifier ());
		}
#pragma warning restore 0169

		static IntPtr id_hostnameVerifier;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='hostnameVerifier' and count(parameter)=0]"
		[Register ("hostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;", "GetHostnameVerifierHandler")]
		public virtual unsafe global::Javax.Net.Ssl.IHostnameVerifier HostnameVerifier ()
		{
			if (id_hostnameVerifier == IntPtr.Zero)
				id_hostnameVerifier = JNIEnv.GetMethodID (class_ref, "hostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IHostnameVerifier> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hostnameVerifier), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IHostnameVerifier> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_interceptors;
#pragma warning disable 0169
		static Delegate GetInterceptorsHandler ()
		{
			if (cb_interceptors == null)
				cb_interceptors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Interceptors);
			return cb_interceptors;
		}

		static IntPtr n_Interceptors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Okhttp3.IInterceptor>.ToLocalJniHandle (__this.Interceptors ());
		}
#pragma warning restore 0169

		static IntPtr id_interceptors;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='interceptors' and count(parameter)=0]"
		[Register ("interceptors", "()Ljava/util/List;", "GetInterceptorsHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Okhttp3.IInterceptor> Interceptors ()
		{
			if (id_interceptors == IntPtr.Zero)
				id_interceptors = JNIEnv.GetMethodID (class_ref, "interceptors", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Okhttp3.IInterceptor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_interceptors), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Okhttp3.IInterceptor>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "interceptors", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_networkInterceptors;
#pragma warning disable 0169
		static Delegate GetNetworkInterceptorsHandler ()
		{
			if (cb_networkInterceptors == null)
				cb_networkInterceptors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NetworkInterceptors);
			return cb_networkInterceptors;
		}

		static IntPtr n_NetworkInterceptors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Okhttp3.IInterceptor>.ToLocalJniHandle (__this.NetworkInterceptors ());
		}
#pragma warning restore 0169

		static IntPtr id_networkInterceptors;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='networkInterceptors' and count(parameter)=0]"
		[Register ("networkInterceptors", "()Ljava/util/List;", "GetNetworkInterceptorsHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Okhttp3.IInterceptor> NetworkInterceptors ()
		{
			if (id_networkInterceptors == IntPtr.Zero)
				id_networkInterceptors = JNIEnv.GetMethodID (class_ref, "networkInterceptors", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Okhttp3.IInterceptor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_networkInterceptors), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Okhttp3.IInterceptor>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "networkInterceptors", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_newBuilder;
#pragma warning disable 0169
		static Delegate GetNewBuilderHandler ()
		{
			if (cb_newBuilder == null)
				cb_newBuilder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_NewBuilder);
			return cb_newBuilder;
		}

		static IntPtr n_NewBuilder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewBuilder ());
		}
#pragma warning restore 0169

		static IntPtr id_newBuilder;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lokhttp3/OkHttpClient$Builder;", "GetNewBuilderHandler")]
		public virtual unsafe global::Okhttp3.OkHttpClient.Builder NewBuilder ()
		{
			if (id_newBuilder == IntPtr.Zero)
				id_newBuilder = JNIEnv.GetMethodID (class_ref, "newBuilder", "()Lokhttp3/OkHttpClient$Builder;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newBuilder), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newBuilder", "()Lokhttp3/OkHttpClient$Builder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_newCall_Lokhttp3_Request_;
#pragma warning disable 0169
		static Delegate GetNewCall_Lokhttp3_Request_Handler ()
		{
			if (cb_newCall_Lokhttp3_Request_ == null)
				cb_newCall_Lokhttp3_Request_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NewCall_Lokhttp3_Request_);
			return cb_newCall_Lokhttp3_Request_;
		}

		static IntPtr n_NewCall_Lokhttp3_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var request = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewCall (request));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newCall_Lokhttp3_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='newCall' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("newCall", "(Lokhttp3/Request;)Lokhttp3/Call;", "GetNewCall_Lokhttp3_Request_Handler")]
		public virtual unsafe global::Okhttp3.ICall NewCall (global::Okhttp3.Request request)
		{
			if (id_newCall_Lokhttp3_Request_ == IntPtr.Zero)
				id_newCall_Lokhttp3_Request_ = JNIEnv.GetMethodID (class_ref, "newCall", "(Lokhttp3/Request;)Lokhttp3/Call;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (request);

				global::Okhttp3.ICall __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newCall_Lokhttp3_Request_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newCall", "(Lokhttp3/Request;)Lokhttp3/Call;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_;
#pragma warning disable 0169
		static Delegate GetNewWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_Handler ()
		{
			if (cb_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_ == null)
				cb_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_NewWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_);
			return cb_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_;
		}

		static IntPtr n_NewWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var request = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_request, JniHandleOwnership.DoNotTransfer);
			var listener = global::Java.Lang.Object.GetObject<global::Okhttp3.WebSocketListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewWebSocket (request, listener));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='newWebSocket' and count(parameter)=2 and parameter[1][@type='okhttp3.Request'] and parameter[2][@type='okhttp3.WebSocketListener']]"
		[Register ("newWebSocket", "(Lokhttp3/Request;Lokhttp3/WebSocketListener;)Lokhttp3/WebSocket;", "GetNewWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_Handler")]
		public virtual unsafe global::Okhttp3.IWebSocket NewWebSocket (global::Okhttp3.Request request, global::Okhttp3.WebSocketListener listener)
		{
			if (id_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_ == IntPtr.Zero)
				id_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_ = JNIEnv.GetMethodID (class_ref, "newWebSocket", "(Lokhttp3/Request;Lokhttp3/WebSocketListener;)Lokhttp3/WebSocket;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (request);
				__args [1] = new JValue (listener);

				global::Okhttp3.IWebSocket __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newWebSocket_Lokhttp3_Request_Lokhttp3_WebSocketListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.IWebSocket> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newWebSocket", "(Lokhttp3/Request;Lokhttp3/WebSocketListener;)Lokhttp3/WebSocket;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_pingIntervalMillis;
#pragma warning disable 0169
		static Delegate GetPingIntervalMillisHandler ()
		{
			if (cb_pingIntervalMillis == null)
				cb_pingIntervalMillis = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_PingIntervalMillis);
			return cb_pingIntervalMillis;
		}

		static int n_PingIntervalMillis (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PingIntervalMillis ();
		}
#pragma warning restore 0169

		static IntPtr id_pingIntervalMillis;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='pingIntervalMillis' and count(parameter)=0]"
		[Register ("pingIntervalMillis", "()I", "GetPingIntervalMillisHandler")]
		public virtual unsafe int PingIntervalMillis ()
		{
			if (id_pingIntervalMillis == IntPtr.Zero)
				id_pingIntervalMillis = JNIEnv.GetMethodID (class_ref, "pingIntervalMillis", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_pingIntervalMillis);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pingIntervalMillis", "()I"));
			} finally {
			}
		}

		static Delegate cb_protocols;
#pragma warning disable 0169
		static Delegate GetProtocolsHandler ()
		{
			if (cb_protocols == null)
				cb_protocols = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Protocols);
			return cb_protocols;
		}

		static IntPtr n_Protocols (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Okhttp3.Protocol>.ToLocalJniHandle (__this.Protocols ());
		}
#pragma warning restore 0169

		static IntPtr id_protocols;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='protocols' and count(parameter)=0]"
		[Register ("protocols", "()Ljava/util/List;", "GetProtocolsHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Okhttp3.Protocol> Protocols ()
		{
			if (id_protocols == IntPtr.Zero)
				id_protocols = JNIEnv.GetMethodID (class_ref, "protocols", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Okhttp3.Protocol>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_protocols), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Okhttp3.Protocol>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "protocols", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_proxy;
#pragma warning disable 0169
		static Delegate GetProxyHandler ()
		{
			if (cb_proxy == null)
				cb_proxy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Proxy);
			return cb_proxy;
		}

		static IntPtr n_Proxy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Proxy ());
		}
#pragma warning restore 0169

		static IntPtr id_proxy;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='proxy' and count(parameter)=0]"
		[Register ("proxy", "()Ljava/net/Proxy;", "GetProxyHandler")]
		public virtual unsafe global::Java.Net.Proxy Proxy ()
		{
			if (id_proxy == IntPtr.Zero)
				id_proxy = JNIEnv.GetMethodID (class_ref, "proxy", "()Ljava/net/Proxy;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Net.Proxy> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proxy), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Net.Proxy> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "proxy", "()Ljava/net/Proxy;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_proxyAuthenticator;
#pragma warning disable 0169
		static Delegate GetProxyAuthenticatorHandler ()
		{
			if (cb_proxyAuthenticator == null)
				cb_proxyAuthenticator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ProxyAuthenticator);
			return cb_proxyAuthenticator;
		}

		static IntPtr n_ProxyAuthenticator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProxyAuthenticator ());
		}
#pragma warning restore 0169

		static IntPtr id_proxyAuthenticator;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='proxyAuthenticator' and count(parameter)=0]"
		[Register ("proxyAuthenticator", "()Lokhttp3/Authenticator;", "GetProxyAuthenticatorHandler")]
		public virtual unsafe global::Okhttp3.IAuthenticator ProxyAuthenticator ()
		{
			if (id_proxyAuthenticator == IntPtr.Zero)
				id_proxyAuthenticator = JNIEnv.GetMethodID (class_ref, "proxyAuthenticator", "()Lokhttp3/Authenticator;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Okhttp3.IAuthenticator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proxyAuthenticator), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Okhttp3.IAuthenticator> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "proxyAuthenticator", "()Lokhttp3/Authenticator;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_proxySelector;
#pragma warning disable 0169
		static Delegate GetProxySelectorHandler ()
		{
			if (cb_proxySelector == null)
				cb_proxySelector = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ProxySelector);
			return cb_proxySelector;
		}

		static IntPtr n_ProxySelector (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProxySelector ());
		}
#pragma warning restore 0169

		static IntPtr id_proxySelector;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='proxySelector' and count(parameter)=0]"
		[Register ("proxySelector", "()Ljava/net/ProxySelector;", "GetProxySelectorHandler")]
		public virtual unsafe global::Java.Net.ProxySelector ProxySelector ()
		{
			if (id_proxySelector == IntPtr.Zero)
				id_proxySelector = JNIEnv.GetMethodID (class_ref, "proxySelector", "()Ljava/net/ProxySelector;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Net.ProxySelector> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proxySelector), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Net.ProxySelector> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "proxySelector", "()Ljava/net/ProxySelector;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readTimeoutMillis;
#pragma warning disable 0169
		static Delegate GetReadTimeoutMillisHandler ()
		{
			if (cb_readTimeoutMillis == null)
				cb_readTimeoutMillis = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_ReadTimeoutMillis);
			return cb_readTimeoutMillis;
		}

		static int n_ReadTimeoutMillis (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadTimeoutMillis ();
		}
#pragma warning restore 0169

		static IntPtr id_readTimeoutMillis;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='readTimeoutMillis' and count(parameter)=0]"
		[Register ("readTimeoutMillis", "()I", "GetReadTimeoutMillisHandler")]
		public virtual unsafe int ReadTimeoutMillis ()
		{
			if (id_readTimeoutMillis == IntPtr.Zero)
				id_readTimeoutMillis = JNIEnv.GetMethodID (class_ref, "readTimeoutMillis", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readTimeoutMillis);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readTimeoutMillis", "()I"));
			} finally {
			}
		}

		static Delegate cb_retryOnConnectionFailure;
#pragma warning disable 0169
		static Delegate GetRetryOnConnectionFailureHandler ()
		{
			if (cb_retryOnConnectionFailure == null)
				cb_retryOnConnectionFailure = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_RetryOnConnectionFailure);
			return cb_retryOnConnectionFailure;
		}

		static bool n_RetryOnConnectionFailure (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryOnConnectionFailure ();
		}
#pragma warning restore 0169

		static IntPtr id_retryOnConnectionFailure;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='retryOnConnectionFailure' and count(parameter)=0]"
		[Register ("retryOnConnectionFailure", "()Z", "GetRetryOnConnectionFailureHandler")]
		public virtual unsafe bool RetryOnConnectionFailure ()
		{
			if (id_retryOnConnectionFailure == IntPtr.Zero)
				id_retryOnConnectionFailure = JNIEnv.GetMethodID (class_ref, "retryOnConnectionFailure", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_retryOnConnectionFailure);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "retryOnConnectionFailure", "()Z"));
			} finally {
			}
		}

		static Delegate cb_socketFactory;
#pragma warning disable 0169
		static Delegate GetSocketFactoryHandler ()
		{
			if (cb_socketFactory == null)
				cb_socketFactory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SocketFactory);
			return cb_socketFactory;
		}

		static IntPtr n_SocketFactory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SocketFactory ());
		}
#pragma warning restore 0169

		static IntPtr id_socketFactory;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='socketFactory' and count(parameter)=0]"
		[Register ("socketFactory", "()Ljavax/net/SocketFactory;", "GetSocketFactoryHandler")]
		public virtual unsafe global::Javax.Net.SocketFactory SocketFactory ()
		{
			if (id_socketFactory == IntPtr.Zero)
				id_socketFactory = JNIEnv.GetMethodID (class_ref, "socketFactory", "()Ljavax/net/SocketFactory;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Javax.Net.SocketFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_socketFactory), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Javax.Net.SocketFactory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "socketFactory", "()Ljavax/net/SocketFactory;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sslSocketFactory;
#pragma warning disable 0169
		static Delegate GetSslSocketFactoryHandler ()
		{
			if (cb_sslSocketFactory == null)
				cb_sslSocketFactory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SslSocketFactory);
			return cb_sslSocketFactory;
		}

		static IntPtr n_SslSocketFactory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SslSocketFactory ());
		}
#pragma warning restore 0169

		static IntPtr id_sslSocketFactory;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='sslSocketFactory' and count(parameter)=0]"
		[Register ("sslSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", "GetSslSocketFactoryHandler")]
		public virtual unsafe global::Javax.Net.Ssl.SSLSocketFactory SslSocketFactory ()
		{
			if (id_sslSocketFactory == IntPtr.Zero)
				id_sslSocketFactory = JNIEnv.GetMethodID (class_ref, "sslSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sslSocketFactory), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sslSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_writeTimeoutMillis;
#pragma warning disable 0169
		static Delegate GetWriteTimeoutMillisHandler ()
		{
			if (cb_writeTimeoutMillis == null)
				cb_writeTimeoutMillis = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_WriteTimeoutMillis);
			return cb_writeTimeoutMillis;
		}

		static int n_WriteTimeoutMillis (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.OkHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WriteTimeoutMillis ();
		}
#pragma warning restore 0169

		static IntPtr id_writeTimeoutMillis;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='OkHttpClient']/method[@name='writeTimeoutMillis' and count(parameter)=0]"
		[Register ("writeTimeoutMillis", "()I", "GetWriteTimeoutMillisHandler")]
		public virtual unsafe int WriteTimeoutMillis ()
		{
			if (id_writeTimeoutMillis == IntPtr.Zero)
				id_writeTimeoutMillis = JNIEnv.GetMethodID (class_ref, "writeTimeoutMillis", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_writeTimeoutMillis);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeTimeoutMillis", "()I"));
			} finally {
			}
		}

	}
}
