using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionPool']"
	[global::Android.Runtime.Register ("okhttp3/ConnectionPool", DoNotGenerateAcw=true)]
	public sealed partial class ConnectionPool : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("okhttp3/ConnectionPool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionPool); }
		}

		internal ConnectionPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionPool']/constructor[@name='ConnectionPool' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectionPool ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConnectionPool)) {
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

		static IntPtr id_ctor_IJLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionPool']/constructor[@name='ConnectionPool' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register (".ctor", "(IJLjava/util/concurrent/TimeUnit;)V", "")]
		public unsafe ConnectionPool (int maxIdleConnections, long keepAliveDuration, global::Java.Util.Concurrent.TimeUnit timeUnit)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (maxIdleConnections);
				__args [1] = new JValue (keepAliveDuration);
				__args [2] = new JValue (timeUnit);
				if (((object) this).GetType () != typeof (ConnectionPool)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IJLjava/util/concurrent/TimeUnit;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IJLjava/util/concurrent/TimeUnit;)V", __args);
					return;
				}

				if (id_ctor_IJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_ctor_IJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IJLjava/util/concurrent/TimeUnit;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IJLjava_util_concurrent_TimeUnit_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IJLjava_util_concurrent_TimeUnit_, __args);
			} finally {
			}
		}

		static IntPtr id_connectionCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionPool']/method[@name='connectionCount' and count(parameter)=0]"
		[Register ("connectionCount", "()I", "")]
		public unsafe int ConnectionCount ()
		{
			if (id_connectionCount == IntPtr.Zero)
				id_connectionCount = JNIEnv.GetMethodID (class_ref, "connectionCount", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectionCount);
			} finally {
			}
		}

		static IntPtr id_evictAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionPool']/method[@name='evictAll' and count(parameter)=0]"
		[Register ("evictAll", "()V", "")]
		public unsafe void EvictAll ()
		{
			if (id_evictAll == IntPtr.Zero)
				id_evictAll = JNIEnv.GetMethodID (class_ref, "evictAll", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_evictAll);
			} finally {
			}
		}

		static IntPtr id_idleConnectionCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='ConnectionPool']/method[@name='idleConnectionCount' and count(parameter)=0]"
		[Register ("idleConnectionCount", "()I", "")]
		public unsafe int IdleConnectionCount ()
		{
			if (id_idleConnectionCount == IntPtr.Zero)
				id_idleConnectionCount = JNIEnv.GetMethodID (class_ref, "idleConnectionCount", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_idleConnectionCount);
			} finally {
			}
		}

	}
}
