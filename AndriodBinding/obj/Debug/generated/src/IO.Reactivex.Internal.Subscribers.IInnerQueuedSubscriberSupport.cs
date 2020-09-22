using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Subscribers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.internal.subscribers']/interface[@name='InnerQueuedSubscriberSupport']"
	[Register ("io/reactivex/internal/subscribers/InnerQueuedSubscriberSupport", "", "IO.Reactivex.Internal.Subscribers.IInnerQueuedSubscriberSupportInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IInnerQueuedSubscriberSupport : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.subscribers']/interface[@name='InnerQueuedSubscriberSupport']/method[@name='drain' and count(parameter)=0]"
		[Register ("drain", "()V", "GetDrainHandler:IO.Reactivex.Internal.Subscribers.IInnerQueuedSubscriberSupportInvoker, AndriodBinding")]
		void Drain ();

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/subscribers/InnerQueuedSubscriberSupport", DoNotGenerateAcw=true)]
	internal partial class IInnerQueuedSubscriberSupportInvoker : global::Java.Lang.Object, IInnerQueuedSubscriberSupport {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/internal/subscribers/InnerQueuedSubscriberSupport");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IInnerQueuedSubscriberSupportInvoker); }
		}

		IntPtr class_ref;

		public static IInnerQueuedSubscriberSupport GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInnerQueuedSubscriberSupport> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.internal.subscribers.InnerQueuedSubscriberSupport"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInnerQueuedSubscriberSupportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_drain;
#pragma warning disable 0169
		static Delegate GetDrainHandler ()
		{
			if (cb_drain == null)
				cb_drain = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Drain);
			return cb_drain;
		}

		static void n_Drain (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Subscribers.IInnerQueuedSubscriberSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Drain ();
		}
#pragma warning restore 0169

		IntPtr id_drain;
		public unsafe void Drain ()
		{
			if (id_drain == IntPtr.Zero)
				id_drain = JNIEnv.GetMethodID (class_ref, "drain", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_drain);
		}

	}

}
