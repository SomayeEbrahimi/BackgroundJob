using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']"
	[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Connection", DoNotGenerateAcw=true)]
	public sealed partial class Http2Connection : global::Java.Lang.Object, global::Java.IO.ICloseable {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Builder']"
		[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Connection$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/internal/http2/Http2Connection$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Z;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Builder']/constructor[@name='Http2Connection.Builder' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register (".ctor", "(Z)V", "")]
			public unsafe Builder (bool client)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (client);
					if (((object) this).GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Z)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Z)V", __args);
						return;
					}

					if (id_ctor_Z == IntPtr.Zero)
						id_ctor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Z)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Z, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Z, __args);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/internal/http2/Http2Connection;", "GetBuildHandler")]
			public virtual unsafe global::Okhttp3.Internal.Http2.Http2Connection Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lokhttp3/internal/http2/Http2Connection;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lokhttp3/internal/http2/Http2Connection;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_listener_Lokhttp3_internal_http2_Http2Connection_Listener_;
#pragma warning disable 0169
			static Delegate GetListener_Lokhttp3_internal_http2_Http2Connection_Listener_Handler ()
			{
				if (cb_listener_Lokhttp3_internal_http2_Http2Connection_Listener_ == null)
					cb_listener_Lokhttp3_internal_http2_Http2Connection_Listener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Listener_Lokhttp3_internal_http2_Http2Connection_Listener_);
				return cb_listener_Lokhttp3_internal_http2_Http2Connection_Listener_;
			}

			static IntPtr n_Listener_Lokhttp3_internal_http2_Http2Connection_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var listener = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Listener> (native_listener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Listener (listener));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_listener_Lokhttp3_internal_http2_Http2Connection_Listener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Builder']/method[@name='listener' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.Http2Connection.Listener']]"
			[Register ("listener", "(Lokhttp3/internal/http2/Http2Connection$Listener;)Lokhttp3/internal/http2/Http2Connection$Builder;", "GetListener_Lokhttp3_internal_http2_Http2Connection_Listener_Handler")]
			public virtual unsafe global::Okhttp3.Internal.Http2.Http2Connection.Builder Listener (global::Okhttp3.Internal.Http2.Http2Connection.Listener listener)
			{
				if (id_listener_Lokhttp3_internal_http2_Http2Connection_Listener_ == IntPtr.Zero)
					id_listener_Lokhttp3_internal_http2_Http2Connection_Listener_ = JNIEnv.GetMethodID (class_ref, "listener", "(Lokhttp3/internal/http2/Http2Connection$Listener;)Lokhttp3/internal/http2/Http2Connection$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (listener);

					global::Okhttp3.Internal.Http2.Http2Connection.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_listener_Lokhttp3_internal_http2_Http2Connection_Listener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listener", "(Lokhttp3/internal/http2/Http2Connection$Listener;)Lokhttp3/internal/http2/Http2Connection$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_pingIntervalMillis_I;
#pragma warning disable 0169
			static Delegate GetPingIntervalMillis_IHandler ()
			{
				if (cb_pingIntervalMillis_I == null)
					cb_pingIntervalMillis_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_PingIntervalMillis_I);
				return cb_pingIntervalMillis_I;
			}

			static IntPtr n_PingIntervalMillis_I (IntPtr jnienv, IntPtr native__this, int pingIntervalMillis)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.PingIntervalMillis (pingIntervalMillis));
			}
#pragma warning restore 0169

			static IntPtr id_pingIntervalMillis_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Builder']/method[@name='pingIntervalMillis' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("pingIntervalMillis", "(I)Lokhttp3/internal/http2/Http2Connection$Builder;", "GetPingIntervalMillis_IHandler")]
			public virtual unsafe global::Okhttp3.Internal.Http2.Http2Connection.Builder PingIntervalMillis (int pingIntervalMillis)
			{
				if (id_pingIntervalMillis_I == IntPtr.Zero)
					id_pingIntervalMillis_I = JNIEnv.GetMethodID (class_ref, "pingIntervalMillis", "(I)Lokhttp3/internal/http2/Http2Connection$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (pingIntervalMillis);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pingIntervalMillis_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pingIntervalMillis", "(I)Lokhttp3/internal/http2/Http2Connection$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_pushObserver_Lokhttp3_internal_http2_PushObserver_;
#pragma warning disable 0169
			static Delegate GetPushObserver_Lokhttp3_internal_http2_PushObserver_Handler ()
			{
				if (cb_pushObserver_Lokhttp3_internal_http2_PushObserver_ == null)
					cb_pushObserver_Lokhttp3_internal_http2_PushObserver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_PushObserver_Lokhttp3_internal_http2_PushObserver_);
				return cb_pushObserver_Lokhttp3_internal_http2_PushObserver_;
			}

			static IntPtr n_PushObserver_Lokhttp3_internal_http2_PushObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pushObserver)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var pushObserver = (global::Okhttp3.Internal.Http2.IPushObserver)global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.IPushObserver> (native_pushObserver, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PushObserver (pushObserver));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_pushObserver_Lokhttp3_internal_http2_PushObserver_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Builder']/method[@name='pushObserver' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.PushObserver']]"
			[Register ("pushObserver", "(Lokhttp3/internal/http2/PushObserver;)Lokhttp3/internal/http2/Http2Connection$Builder;", "GetPushObserver_Lokhttp3_internal_http2_PushObserver_Handler")]
			public virtual unsafe global::Okhttp3.Internal.Http2.Http2Connection.Builder PushObserver (global::Okhttp3.Internal.Http2.IPushObserver pushObserver)
			{
				if (id_pushObserver_Lokhttp3_internal_http2_PushObserver_ == IntPtr.Zero)
					id_pushObserver_Lokhttp3_internal_http2_PushObserver_ = JNIEnv.GetMethodID (class_ref, "pushObserver", "(Lokhttp3/internal/http2/PushObserver;)Lokhttp3/internal/http2/Http2Connection$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (pushObserver);

					global::Okhttp3.Internal.Http2.Http2Connection.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pushObserver_Lokhttp3_internal_http2_PushObserver_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pushObserver", "(Lokhttp3/internal/http2/PushObserver;)Lokhttp3/internal/http2/Http2Connection$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_socket_Ljava_net_Socket_;
#pragma warning disable 0169
			static Delegate GetSocket_Ljava_net_Socket_Handler ()
			{
				if (cb_socket_Ljava_net_Socket_ == null)
					cb_socket_Ljava_net_Socket_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Socket_Ljava_net_Socket_);
				return cb_socket_Ljava_net_Socket_;
			}

			static IntPtr n_Socket_Ljava_net_Socket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_socket)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var socket = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_socket, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Socket (socket));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_socket_Ljava_net_Socket_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Builder']/method[@name='socket' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
			[Register ("socket", "(Ljava/net/Socket;)Lokhttp3/internal/http2/Http2Connection$Builder;", "GetSocket_Ljava_net_Socket_Handler")]
			public virtual unsafe global::Okhttp3.Internal.Http2.Http2Connection.Builder Socket (global::Java.Net.Socket socket)
			{
				if (id_socket_Ljava_net_Socket_ == IntPtr.Zero)
					id_socket_Ljava_net_Socket_ = JNIEnv.GetMethodID (class_ref, "socket", "(Ljava/net/Socket;)Lokhttp3/internal/http2/Http2Connection$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (socket);

					global::Okhttp3.Internal.Http2.Http2Connection.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_socket_Ljava_net_Socket_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "socket", "(Ljava/net/Socket;)Lokhttp3/internal/http2/Http2Connection$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Listener']"
		[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Connection$Listener", DoNotGenerateAcw=true)]
		public abstract partial class Listener : global::Java.Lang.Object {


			static IntPtr REFUSE_INCOMING_STREAMS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Listener']/field[@name='REFUSE_INCOMING_STREAMS']"
			[Register ("REFUSE_INCOMING_STREAMS")]
			public static global::Okhttp3.Internal.Http2.Http2Connection.Listener RefuseIncomingStreams {
				get {
					if (REFUSE_INCOMING_STREAMS_jfieldId == IntPtr.Zero)
						REFUSE_INCOMING_STREAMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUSE_INCOMING_STREAMS", "Lokhttp3/internal/http2/Http2Connection$Listener;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFUSE_INCOMING_STREAMS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Listener> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("okhttp3/internal/http2/Http2Connection$Listener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Listener); }
			}

			protected Listener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Listener']/constructor[@name='Http2Connection.Listener' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Listener ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Listener)) {
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

			static Delegate cb_onSettings_Lokhttp3_internal_http2_Http2Connection_;
#pragma warning disable 0169
			static Delegate GetOnSettings_Lokhttp3_internal_http2_Http2Connection_Handler ()
			{
				if (cb_onSettings_Lokhttp3_internal_http2_Http2Connection_ == null)
					cb_onSettings_Lokhttp3_internal_http2_Http2Connection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSettings_Lokhttp3_internal_http2_Http2Connection_);
				return cb_onSettings_Lokhttp3_internal_http2_Http2Connection_;
			}

			static void n_OnSettings_Lokhttp3_internal_http2_Http2Connection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_connection)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var connection = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection> (native_connection, JniHandleOwnership.DoNotTransfer);
				__this.OnSettings (connection);
			}
#pragma warning restore 0169

			static IntPtr id_onSettings_Lokhttp3_internal_http2_Http2Connection_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Listener']/method[@name='onSettings' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.Http2Connection']]"
			[Register ("onSettings", "(Lokhttp3/internal/http2/Http2Connection;)V", "GetOnSettings_Lokhttp3_internal_http2_Http2Connection_Handler")]
			public virtual unsafe void OnSettings (global::Okhttp3.Internal.Http2.Http2Connection connection)
			{
				if (id_onSettings_Lokhttp3_internal_http2_Http2Connection_ == IntPtr.Zero)
					id_onSettings_Lokhttp3_internal_http2_Http2Connection_ = JNIEnv.GetMethodID (class_ref, "onSettings", "(Lokhttp3/internal/http2/Http2Connection;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (connection);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSettings_Lokhttp3_internal_http2_Http2Connection_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSettings", "(Lokhttp3/internal/http2/Http2Connection;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onStream_Lokhttp3_internal_http2_Http2Stream_;
#pragma warning disable 0169
			static Delegate GetOnStream_Lokhttp3_internal_http2_Http2Stream_Handler ()
			{
				if (cb_onStream_Lokhttp3_internal_http2_Http2Stream_ == null)
					cb_onStream_Lokhttp3_internal_http2_Http2Stream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnStream_Lokhttp3_internal_http2_Http2Stream_);
				return cb_onStream_Lokhttp3_internal_http2_Http2Stream_;
			}

			static void n_OnStream_Lokhttp3_internal_http2_Http2Stream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Connection.Listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Stream> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStream (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Listener']/method[@name='onStream' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.Http2Stream']]"
			[Register ("onStream", "(Lokhttp3/internal/http2/Http2Stream;)V", "GetOnStream_Lokhttp3_internal_http2_Http2Stream_Handler")]
			public abstract void OnStream (global::Okhttp3.Internal.Http2.Http2Stream p0);

		}

		[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Connection$Listener", DoNotGenerateAcw=true)]
		internal partial class ListenerInvoker : Listener {

			public ListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ListenerInvoker); }
			}

			static IntPtr id_onStream_Lokhttp3_internal_http2_Http2Stream_;
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.Listener']/method[@name='onStream' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.Http2Stream']]"
			[Register ("onStream", "(Lokhttp3/internal/http2/Http2Stream;)V", "GetOnStream_Lokhttp3_internal_http2_Http2Stream_Handler")]
			public override unsafe void OnStream (global::Okhttp3.Internal.Http2.Http2Stream p0)
			{
				if (id_onStream_Lokhttp3_internal_http2_Http2Stream_ == IntPtr.Zero)
					id_onStream_Lokhttp3_internal_http2_Http2Stream_ = JNIEnv.GetMethodID (class_ref, "onStream", "(Lokhttp3/internal/http2/Http2Stream;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStream_Lokhttp3_internal_http2_Http2Stream_, __args);
				} finally {
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/internal/http2/Http2Connection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Http2Connection); }
		}

		internal Http2Connection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isShutdown;
		public unsafe bool IsShutdown {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='isShutdown' and count(parameter)=0]"
			[Register ("isShutdown", "()Z", "")]
			get {
				if (id_isShutdown == IntPtr.Zero)
					id_isShutdown = JNIEnv.GetMethodID (class_ref, "isShutdown", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isShutdown);
				} finally {
				}
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
			} finally {
			}
		}

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flush);
			} finally {
			}
		}

		static IntPtr id_maxConcurrentStreams;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='maxConcurrentStreams' and count(parameter)=0]"
		[Register ("maxConcurrentStreams", "()I", "")]
		public unsafe int MaxConcurrentStreams ()
		{
			if (id_maxConcurrentStreams == IntPtr.Zero)
				id_maxConcurrentStreams = JNIEnv.GetMethodID (class_ref, "maxConcurrentStreams", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_maxConcurrentStreams);
			} finally {
			}
		}

		static IntPtr id_newStream_Ljava_util_List_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='newStream' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;okhttp3.internal.http2.Header&gt;'] and parameter[2][@type='boolean']]"
		[Register ("newStream", "(Ljava/util/List;Z)Lokhttp3/internal/http2/Http2Stream;", "")]
		public unsafe global::Okhttp3.Internal.Http2.Http2Stream NewStream (global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> requestHeaders, bool @out)
		{
			if (id_newStream_Ljava_util_List_Z == IntPtr.Zero)
				id_newStream_Ljava_util_List_Z = JNIEnv.GetMethodID (class_ref, "newStream", "(Ljava/util/List;Z)Lokhttp3/internal/http2/Http2Stream;");
			IntPtr native_requestHeaders = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.ToLocalJniHandle (requestHeaders);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_requestHeaders);
				__args [1] = new JValue (@out);
				global::Okhttp3.Internal.Http2.Http2Stream __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Stream> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newStream_Ljava_util_List_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_requestHeaders);
			}
		}

		static IntPtr id_openStreamCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='openStreamCount' and count(parameter)=0]"
		[Register ("openStreamCount", "()I", "")]
		public unsafe int OpenStreamCount ()
		{
			if (id_openStreamCount == IntPtr.Zero)
				id_openStreamCount = JNIEnv.GetMethodID (class_ref, "openStreamCount", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_openStreamCount);
			} finally {
			}
		}

		static IntPtr id_pushStream_ILjava_util_List_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='pushStream' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.util.List&lt;okhttp3.internal.http2.Header&gt;'] and parameter[3][@type='boolean']]"
		[Register ("pushStream", "(ILjava/util/List;Z)Lokhttp3/internal/http2/Http2Stream;", "")]
		public unsafe global::Okhttp3.Internal.Http2.Http2Stream PushStream (int associatedStreamId, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> requestHeaders, bool @out)
		{
			if (id_pushStream_ILjava_util_List_Z == IntPtr.Zero)
				id_pushStream_ILjava_util_List_Z = JNIEnv.GetMethodID (class_ref, "pushStream", "(ILjava/util/List;Z)Lokhttp3/internal/http2/Http2Stream;");
			IntPtr native_requestHeaders = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.ToLocalJniHandle (requestHeaders);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (associatedStreamId);
				__args [1] = new JValue (native_requestHeaders);
				__args [2] = new JValue (@out);
				global::Okhttp3.Internal.Http2.Http2Stream __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Stream> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pushStream_ILjava_util_List_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_requestHeaders);
			}
		}

		static IntPtr id_setSettings_Lokhttp3_internal_http2_Settings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='setSettings' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.Settings']]"
		[Register ("setSettings", "(Lokhttp3/internal/http2/Settings;)V", "")]
		public unsafe void SetSettings (global::Okhttp3.Internal.Http2.Settings settings)
		{
			if (id_setSettings_Lokhttp3_internal_http2_Settings_ == IntPtr.Zero)
				id_setSettings_Lokhttp3_internal_http2_Settings_ = JNIEnv.GetMethodID (class_ref, "setSettings", "(Lokhttp3/internal/http2/Settings;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (settings);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSettings_Lokhttp3_internal_http2_Settings_, __args);
			} finally {
			}
		}

		static IntPtr id_shutdown_Lokhttp3_internal_http2_ErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='shutdown' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.http2.ErrorCode']]"
		[Register ("shutdown", "(Lokhttp3/internal/http2/ErrorCode;)V", "")]
		public unsafe void Shutdown (global::Okhttp3.Internal.Http2.ErrorCode statusCode)
		{
			if (id_shutdown_Lokhttp3_internal_http2_ErrorCode_ == IntPtr.Zero)
				id_shutdown_Lokhttp3_internal_http2_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "shutdown", "(Lokhttp3/internal/http2/ErrorCode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (statusCode);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutdown_Lokhttp3_internal_http2_ErrorCode_, __args);
			} finally {
			}
		}

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "")]
		public unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
			} finally {
			}
		}

	}
}
