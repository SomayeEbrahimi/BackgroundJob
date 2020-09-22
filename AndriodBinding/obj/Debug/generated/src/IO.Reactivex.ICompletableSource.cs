using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='CompletableSource']"
	[Register ("io/reactivex/CompletableSource", "", "IO.Reactivex.ICompletableSourceInvoker")]
	public partial interface ICompletableSource : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='CompletableSource']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.CompletableObserver']]"
		[Register ("subscribe", "(Lio/reactivex/CompletableObserver;)V", "GetSubscribe_Lio_reactivex_CompletableObserver_Handler:IO.Reactivex.ICompletableSourceInvoker, AndriodBinding")]
		void Subscribe (global::IO.Reactivex.ICompletableObserver p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/CompletableSource", DoNotGenerateAcw=true)]
	internal partial class ICompletableSourceInvoker : global::Java.Lang.Object, ICompletableSource {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/CompletableSource");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICompletableSourceInvoker); }
		}

		IntPtr class_ref;

		public static ICompletableSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICompletableSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.CompletableSource"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICompletableSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_subscribe_Lio_reactivex_CompletableObserver_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Lio_reactivex_CompletableObserver_Handler ()
		{
			if (cb_subscribe_Lio_reactivex_CompletableObserver_ == null)
				cb_subscribe_Lio_reactivex_CompletableObserver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Subscribe_Lio_reactivex_CompletableObserver_);
			return cb_subscribe_Lio_reactivex_CompletableObserver_;
		}

		static void n_Subscribe_Lio_reactivex_CompletableObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.ICompletableSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.ICompletableObserver)global::Java.Lang.Object.GetObject<global::IO.Reactivex.ICompletableObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Subscribe (p0);
		}
#pragma warning restore 0169

		IntPtr id_subscribe_Lio_reactivex_CompletableObserver_;
		public unsafe void Subscribe (global::IO.Reactivex.ICompletableObserver p0)
		{
			if (id_subscribe_Lio_reactivex_CompletableObserver_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_CompletableObserver_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/CompletableObserver;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_CompletableObserver_, __args);
		}

	}

}
