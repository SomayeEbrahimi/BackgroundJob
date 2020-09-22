using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Concurrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AtomicSafeInitializer']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/AtomicSafeInitializer", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class AtomicSafeInitializer : global::Java.Lang.Object, global::Org.Apache.Commons.Lang3.Concurrent.IConcurrentInitializer {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/AtomicSafeInitializer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AtomicSafeInitializer); }
		}

		protected AtomicSafeInitializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AtomicSafeInitializer']/constructor[@name='AtomicSafeInitializer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AtomicSafeInitializer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AtomicSafeInitializer)) {
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

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AtomicSafeInitializer']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_initialize;
#pragma warning disable 0169
		static Delegate GetInitializeHandler ()
		{
			if (cb_initialize == null)
				cb_initialize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Initialize);
			return cb_initialize;
		}

		static IntPtr n_Initialize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.AtomicSafeInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Initialize ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AtomicSafeInitializer']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()Ljava/lang/Object;", "GetInitializeHandler")]
		protected abstract global::Java.Lang.Object Initialize ();

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/AtomicSafeInitializer", DoNotGenerateAcw=true)]
	internal partial class AtomicSafeInitializerInvoker : AtomicSafeInitializer, global::Org.Apache.Commons.Lang3.Concurrent.IConcurrentInitializer {

		public AtomicSafeInitializerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AtomicSafeInitializerInvoker); }
		}

		static IntPtr id_initialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='AtomicSafeInitializer']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()Ljava/lang/Object;", "GetInitializeHandler")]
		protected override unsafe global::Java.Lang.Object Initialize ()
		{
			if (id_initialize == IntPtr.Zero)
				id_initialize = JNIEnv.GetMethodID (class_ref, "initialize", "()Ljava/lang/Object;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_initialize), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
