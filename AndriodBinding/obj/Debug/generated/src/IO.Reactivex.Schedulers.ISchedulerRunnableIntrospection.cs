using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Schedulers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.schedulers']/interface[@name='SchedulerRunnableIntrospection']"
	[Register ("io/reactivex/schedulers/SchedulerRunnableIntrospection", "", "IO.Reactivex.Schedulers.ISchedulerRunnableIntrospectionInvoker")]
	public partial interface ISchedulerRunnableIntrospection : IJavaObject {

		global::Java.Lang.IRunnable WrappedRunnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.schedulers']/interface[@name='SchedulerRunnableIntrospection']/method[@name='getWrappedRunnable' and count(parameter)=0]"
			[Register ("getWrappedRunnable", "()Ljava/lang/Runnable;", "GetGetWrappedRunnableHandler:IO.Reactivex.Schedulers.ISchedulerRunnableIntrospectionInvoker, AndriodBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("io/reactivex/schedulers/SchedulerRunnableIntrospection", DoNotGenerateAcw=true)]
	internal partial class ISchedulerRunnableIntrospectionInvoker : global::Java.Lang.Object, ISchedulerRunnableIntrospection {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/schedulers/SchedulerRunnableIntrospection");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISchedulerRunnableIntrospectionInvoker); }
		}

		IntPtr class_ref;

		public static ISchedulerRunnableIntrospection GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISchedulerRunnableIntrospection> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.schedulers.SchedulerRunnableIntrospection"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISchedulerRunnableIntrospectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getWrappedRunnable;
#pragma warning disable 0169
		static Delegate GetGetWrappedRunnableHandler ()
		{
			if (cb_getWrappedRunnable == null)
				cb_getWrappedRunnable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWrappedRunnable);
			return cb_getWrappedRunnable;
		}

		static IntPtr n_GetWrappedRunnable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Schedulers.ISchedulerRunnableIntrospection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WrappedRunnable);
		}
#pragma warning restore 0169

		IntPtr id_getWrappedRunnable;
		public unsafe global::Java.Lang.IRunnable WrappedRunnable {
			get {
				if (id_getWrappedRunnable == IntPtr.Zero)
					id_getWrappedRunnable = JNIEnv.GetMethodID (class_ref, "getWrappedRunnable", "()Ljava/lang/Runnable;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWrappedRunnable), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
