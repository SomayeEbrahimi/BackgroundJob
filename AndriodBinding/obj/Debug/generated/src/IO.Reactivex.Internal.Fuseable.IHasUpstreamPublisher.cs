using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Fuseable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='HasUpstreamPublisher']"
	[Register ("io/reactivex/internal/fuseable/HasUpstreamPublisher", "", "IO.Reactivex.Internal.Fuseable.IHasUpstreamPublisherInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IHasUpstreamPublisher : IJavaObject {

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/fuseable/HasUpstreamPublisher", DoNotGenerateAcw=true)]
	internal partial class IHasUpstreamPublisherInvoker : global::Java.Lang.Object, IHasUpstreamPublisher {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/internal/fuseable/HasUpstreamPublisher");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHasUpstreamPublisherInvoker); }
		}

		IntPtr class_ref;

		public static IHasUpstreamPublisher GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHasUpstreamPublisher> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.internal.fuseable.HasUpstreamPublisher"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHasUpstreamPublisherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
