using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Concurrent {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/interface[@name='ConcurrentInitializer']"
	[Register ("org/apache/commons/lang3/concurrent/ConcurrentInitializer", "", "Org.Apache.Commons.Lang3.Concurrent.IConcurrentInitializerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IConcurrentInitializer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/interface[@name='ConcurrentInitializer']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "GetGetHandler:Org.Apache.Commons.Lang3.Concurrent.IConcurrentInitializerInvoker, AndriodBinding")]
		global::Java.Lang.Object Get ();

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/ConcurrentInitializer", DoNotGenerateAcw=true)]
	internal partial class IConcurrentInitializerInvoker : global::Java.Lang.Object, IConcurrentInitializer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/ConcurrentInitializer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConcurrentInitializerInvoker); }
		}

		IntPtr class_ref;

		public static IConcurrentInitializer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConcurrentInitializer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.apache.commons.lang3.concurrent.ConcurrentInitializer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConcurrentInitializerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.IConcurrentInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		IntPtr id_get;
		public unsafe global::Java.Lang.Object Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get), JniHandleOwnership.TransferLocalRef);
		}

	}

}
