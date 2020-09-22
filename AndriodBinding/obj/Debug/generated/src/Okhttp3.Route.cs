using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Route']"
	[global::Android.Runtime.Register ("okhttp3/Route", DoNotGenerateAcw=true)]
	public sealed partial class Route : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/Route", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Route); }
		}

		internal Route (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lokhttp3_Address_Ljava_net_Proxy_Ljava_net_InetSocketAddress_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Route']/constructor[@name='Route' and count(parameter)=3 and parameter[1][@type='okhttp3.Address'] and parameter[2][@type='java.net.Proxy'] and parameter[3][@type='java.net.InetSocketAddress']]"
		[Register (".ctor", "(Lokhttp3/Address;Ljava/net/Proxy;Ljava/net/InetSocketAddress;)V", "")]
		public unsafe Route (global::Okhttp3.Address address, global::Java.Net.Proxy proxy, global::Java.Net.InetSocketAddress inetSocketAddress)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (address);
				__args [1] = new JValue (proxy);
				__args [2] = new JValue (inetSocketAddress);
				if (((object) this).GetType () != typeof (Route)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lokhttp3/Address;Ljava/net/Proxy;Ljava/net/InetSocketAddress;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lokhttp3/Address;Ljava/net/Proxy;Ljava/net/InetSocketAddress;)V", __args);
					return;
				}

				if (id_ctor_Lokhttp3_Address_Ljava_net_Proxy_Ljava_net_InetSocketAddress_ == IntPtr.Zero)
					id_ctor_Lokhttp3_Address_Ljava_net_Proxy_Ljava_net_InetSocketAddress_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lokhttp3/Address;Ljava/net/Proxy;Ljava/net/InetSocketAddress;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lokhttp3_Address_Ljava_net_Proxy_Ljava_net_InetSocketAddress_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lokhttp3_Address_Ljava_net_Proxy_Ljava_net_InetSocketAddress_, __args);
			} finally {
			}
		}

		static IntPtr id_address;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Route']/method[@name='address' and count(parameter)=0]"
		[Register ("address", "()Lokhttp3/Address;", "")]
		public unsafe global::Okhttp3.Address Address ()
		{
			if (id_address == IntPtr.Zero)
				id_address = JNIEnv.GetMethodID (class_ref, "address", "()Lokhttp3/Address;");
			try {
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Address> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_address), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_proxy;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Route']/method[@name='proxy' and count(parameter)=0]"
		[Register ("proxy", "()Ljava/net/Proxy;", "")]
		public unsafe global::Java.Net.Proxy Proxy ()
		{
			if (id_proxy == IntPtr.Zero)
				id_proxy = JNIEnv.GetMethodID (class_ref, "proxy", "()Ljava/net/Proxy;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Net.Proxy> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proxy), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_requiresTunnel;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Route']/method[@name='requiresTunnel' and count(parameter)=0]"
		[Register ("requiresTunnel", "()Z", "")]
		public unsafe bool RequiresTunnel ()
		{
			if (id_requiresTunnel == IntPtr.Zero)
				id_requiresTunnel = JNIEnv.GetMethodID (class_ref, "requiresTunnel", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_requiresTunnel);
			} finally {
			}
		}

		static IntPtr id_socketAddress;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Route']/method[@name='socketAddress' and count(parameter)=0]"
		[Register ("socketAddress", "()Ljava/net/InetSocketAddress;", "")]
		public unsafe global::Java.Net.InetSocketAddress SocketAddress ()
		{
			if (id_socketAddress == IntPtr.Zero)
				id_socketAddress = JNIEnv.GetMethodID (class_ref, "socketAddress", "()Ljava/net/InetSocketAddress;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_socketAddress), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
