using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='MaybeOnSubscribe']"
	[Register ("io/reactivex/MaybeOnSubscribe", "", "IO.Reactivex.IMaybeOnSubscribeInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IMaybeOnSubscribe : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='MaybeOnSubscribe']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.MaybeEmitter&lt;T&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/MaybeEmitter;)V", "GetSubscribe_Lio_reactivex_MaybeEmitter_Handler:IO.Reactivex.IMaybeOnSubscribeInvoker, AndriodBinding")]
		void Subscribe (global::IO.Reactivex.IMaybeEmitter p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/MaybeOnSubscribe", DoNotGenerateAcw=true)]
	internal partial class IMaybeOnSubscribeInvoker : global::Java.Lang.Object, IMaybeOnSubscribe {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/MaybeOnSubscribe");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMaybeOnSubscribeInvoker); }
		}

		IntPtr class_ref;

		public static IMaybeOnSubscribe GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMaybeOnSubscribe> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.MaybeOnSubscribe"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMaybeOnSubscribeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_subscribe_Lio_reactivex_MaybeEmitter_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Lio_reactivex_MaybeEmitter_Handler ()
		{
			if (cb_subscribe_Lio_reactivex_MaybeEmitter_ == null)
				cb_subscribe_Lio_reactivex_MaybeEmitter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Subscribe_Lio_reactivex_MaybeEmitter_);
			return cb_subscribe_Lio_reactivex_MaybeEmitter_;
		}

		static void n_Subscribe_Lio_reactivex_MaybeEmitter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.IMaybeOnSubscribe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.IMaybeEmitter)global::Java.Lang.Object.GetObject<global::IO.Reactivex.IMaybeEmitter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Subscribe (p0);
		}
#pragma warning restore 0169

		IntPtr id_subscribe_Lio_reactivex_MaybeEmitter_;
		public unsafe void Subscribe (global::IO.Reactivex.IMaybeEmitter p0)
		{
			if (id_subscribe_Lio_reactivex_MaybeEmitter_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_MaybeEmitter_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/MaybeEmitter;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_MaybeEmitter_, __args);
		}

	}

}
