using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Proxy {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.proxy']/class[@name='NullProxySelector']"
	[global::Android.Runtime.Register ("okhttp3/internal/proxy/NullProxySelector", DoNotGenerateAcw=true)]
	public partial class NullProxySelector : global::Java.Net.ProxySelector {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/proxy/NullProxySelector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NullProxySelector); }
		}

		protected NullProxySelector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.proxy']/class[@name='NullProxySelector']/constructor[@name='NullProxySelector' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NullProxySelector ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NullProxySelector)) {
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

		static Delegate cb_connectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_;
#pragma warning disable 0169
		static Delegate GetConnectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_Handler ()
		{
			if (cb_connectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_ == null)
				cb_connectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_ConnectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_);
			return cb_connectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_;
		}

		static void n_ConnectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_sa, IntPtr native_ioe)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Proxy.NullProxySelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (native_uri, JniHandleOwnership.DoNotTransfer);
			var sa = global::Java.Lang.Object.GetObject<global::Java.Net.SocketAddress> (native_sa, JniHandleOwnership.DoNotTransfer);
			var ioe = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_ioe, JniHandleOwnership.DoNotTransfer);
			__this.ConnectFailed (uri, sa, ioe);
		}
#pragma warning restore 0169

		static IntPtr id_connectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.proxy']/class[@name='NullProxySelector']/method[@name='connectFailed' and count(parameter)=3 and parameter[1][@type='java.net.URI'] and parameter[2][@type='java.net.SocketAddress'] and parameter[3][@type='java.io.IOException']]"
		[Register ("connectFailed", "(Ljava/net/URI;Ljava/net/SocketAddress;Ljava/io/IOException;)V", "GetConnectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_Handler")]
		public override unsafe void ConnectFailed (global::Java.Net.URI uri, global::Java.Net.SocketAddress sa, global::Java.IO.IOException ioe)
		{
			if (id_connectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_ == IntPtr.Zero)
				id_connectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "connectFailed", "(Ljava/net/URI;Ljava/net/SocketAddress;Ljava/io/IOException;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (uri);
				__args [1] = new JValue (sa);
				__args [2] = new JValue (ioe);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectFailed_Ljava_net_URI_Ljava_net_SocketAddress_Ljava_io_IOException_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectFailed", "(Ljava/net/URI;Ljava/net/SocketAddress;Ljava/io/IOException;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_select_Ljava_net_URI_;
#pragma warning disable 0169
		static Delegate GetSelect_Ljava_net_URI_Handler ()
		{
			if (cb_select_Ljava_net_URI_ == null)
				cb_select_Ljava_net_URI_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Select_Ljava_net_URI_);
			return cb_select_Ljava_net_URI_;
		}

		static IntPtr n_Select_Ljava_net_URI_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Proxy.NullProxySelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var uri = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Net.Proxy>.ToLocalJniHandle (__this.Select (uri));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_select_Ljava_net_URI_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.proxy']/class[@name='NullProxySelector']/method[@name='select' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
		[Register ("select", "(Ljava/net/URI;)Ljava/util/List;", "GetSelect_Ljava_net_URI_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Java.Net.Proxy> Select (global::Java.Net.URI uri)
		{
			if (id_select_Ljava_net_URI_ == IntPtr.Zero)
				id_select_Ljava_net_URI_ = JNIEnv.GetMethodID (class_ref, "select", "(Ljava/net/URI;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (uri);

				global::System.Collections.Generic.IList<global::Java.Net.Proxy> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Java.Net.Proxy>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_select_Ljava_net_URI_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Java.Net.Proxy>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "select", "(Ljava/net/URI;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
