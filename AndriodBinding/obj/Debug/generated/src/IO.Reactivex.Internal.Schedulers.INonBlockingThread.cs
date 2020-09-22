using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Schedulers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.internal.schedulers']/interface[@name='NonBlockingThread']"
	[Register ("io/reactivex/internal/schedulers/NonBlockingThread", "", "IO.Reactivex.Internal.Schedulers.INonBlockingThreadInvoker")]
	public partial interface INonBlockingThread : IJavaObject {

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/schedulers/NonBlockingThread", DoNotGenerateAcw=true)]
	internal partial class INonBlockingThreadInvoker : global::Java.Lang.Object, INonBlockingThread {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/internal/schedulers/NonBlockingThread");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INonBlockingThreadInvoker); }
		}

		IntPtr class_ref;

		public static INonBlockingThread GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INonBlockingThread> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.internal.schedulers.NonBlockingThread"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INonBlockingThreadInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
