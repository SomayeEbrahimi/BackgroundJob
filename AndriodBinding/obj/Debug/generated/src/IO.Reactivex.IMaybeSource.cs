using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='MaybeSource']"
	[Register ("io/reactivex/MaybeSource", "", "IO.Reactivex.IMaybeSourceInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IMaybeSource : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='MaybeSource']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeObserver&lt;? super T&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/MaybeObserver;)V", "GetSubscribe_Lio_reactivex_MaybeObserver_Handler:IO.Reactivex.IMaybeSourceInvoker, AndriodBinding")]
		void Subscribe (global::IO.Reactivex.IMaybeObserver p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/MaybeSource", DoNotGenerateAcw=true)]
	internal partial class IMaybeSourceInvoker : global::Java.Lang.Object, IMaybeSource {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/MaybeSource");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMaybeSourceInvoker); }
		}

		IntPtr class_ref;

		public static IMaybeSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMaybeSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.MaybeSource"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMaybeSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_subscribe_Lio_reactivex_MaybeObserver_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Lio_reactivex_MaybeObserver_Handler ()
		{
			if (cb_subscribe_Lio_reactivex_MaybeObserver_ == null)
				cb_subscribe_Lio_reactivex_MaybeObserver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Subscribe_Lio_reactivex_MaybeObserver_);
			return cb_subscribe_Lio_reactivex_MaybeObserver_;
		}

		static void n_Subscribe_Lio_reactivex_MaybeObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.IMaybeSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.IMaybeObserver)global::Java.Lang.Object.GetObject<global::IO.Reactivex.IMaybeObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Subscribe (p0);
		}
#pragma warning restore 0169

		IntPtr id_subscribe_Lio_reactivex_MaybeObserver_;
		public unsafe void Subscribe (global::IO.Reactivex.IMaybeObserver p0)
		{
			if (id_subscribe_Lio_reactivex_MaybeObserver_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_MaybeObserver_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/MaybeObserver;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_MaybeObserver_, __args);
		}

	}

}
