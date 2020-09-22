using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='ObservableOnSubscribe']"
	[Register ("io/reactivex/ObservableOnSubscribe", "", "IO.Reactivex.IObservableOnSubscribeInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IObservableOnSubscribe : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='ObservableOnSubscribe']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.ObservableEmitter&lt;T&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/ObservableEmitter;)V", "GetSubscribe_Lio_reactivex_ObservableEmitter_Handler:IO.Reactivex.IObservableOnSubscribeInvoker, AndriodBinding")]
		void Subscribe (global::IO.Reactivex.IObservableEmitter p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/ObservableOnSubscribe", DoNotGenerateAcw=true)]
	internal partial class IObservableOnSubscribeInvoker : global::Java.Lang.Object, IObservableOnSubscribe {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/ObservableOnSubscribe");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IObservableOnSubscribeInvoker); }
		}

		IntPtr class_ref;

		public static IObservableOnSubscribe GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IObservableOnSubscribe> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.ObservableOnSubscribe"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IObservableOnSubscribeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_subscribe_Lio_reactivex_ObservableEmitter_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Lio_reactivex_ObservableEmitter_Handler ()
		{
			if (cb_subscribe_Lio_reactivex_ObservableEmitter_ == null)
				cb_subscribe_Lio_reactivex_ObservableEmitter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Subscribe_Lio_reactivex_ObservableEmitter_);
			return cb_subscribe_Lio_reactivex_ObservableEmitter_;
		}

		static void n_Subscribe_Lio_reactivex_ObservableEmitter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.IObservableOnSubscribe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.IObservableEmitter)global::Java.Lang.Object.GetObject<global::IO.Reactivex.IObservableEmitter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Subscribe (p0);
		}
#pragma warning restore 0169

		IntPtr id_subscribe_Lio_reactivex_ObservableEmitter_;
		public unsafe void Subscribe (global::IO.Reactivex.IObservableEmitter p0)
		{
			if (id_subscribe_Lio_reactivex_ObservableEmitter_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_ObservableEmitter_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/ObservableEmitter;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_ObservableEmitter_, __args);
		}

	}

}
