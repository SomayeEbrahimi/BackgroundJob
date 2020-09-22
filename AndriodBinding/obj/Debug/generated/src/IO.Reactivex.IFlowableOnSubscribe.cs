using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex']/interface[@name='FlowableOnSubscribe']"
	[Register ("io/reactivex/FlowableOnSubscribe", "", "IO.Reactivex.IFlowableOnSubscribeInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IFlowableOnSubscribe : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex']/interface[@name='FlowableOnSubscribe']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='io.reactivex.FlowableEmitter&lt;T&gt;']]"
		[Register ("subscribe", "(Lio/reactivex/FlowableEmitter;)V", "GetSubscribe_Lio_reactivex_FlowableEmitter_Handler:IO.Reactivex.IFlowableOnSubscribeInvoker, AndriodBinding")]
		void Subscribe (global::IO.Reactivex.IFlowableEmitter p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/FlowableOnSubscribe", DoNotGenerateAcw=true)]
	internal partial class IFlowableOnSubscribeInvoker : global::Java.Lang.Object, IFlowableOnSubscribe {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/FlowableOnSubscribe");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFlowableOnSubscribeInvoker); }
		}

		IntPtr class_ref;

		public static IFlowableOnSubscribe GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFlowableOnSubscribe> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.FlowableOnSubscribe"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFlowableOnSubscribeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_subscribe_Lio_reactivex_FlowableEmitter_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Lio_reactivex_FlowableEmitter_Handler ()
		{
			if (cb_subscribe_Lio_reactivex_FlowableEmitter_ == null)
				cb_subscribe_Lio_reactivex_FlowableEmitter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Subscribe_Lio_reactivex_FlowableEmitter_);
			return cb_subscribe_Lio_reactivex_FlowableEmitter_;
		}

		static void n_Subscribe_Lio_reactivex_FlowableEmitter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.IFlowableOnSubscribe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::IO.Reactivex.IFlowableEmitter)global::Java.Lang.Object.GetObject<global::IO.Reactivex.IFlowableEmitter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Subscribe (p0);
		}
#pragma warning restore 0169

		IntPtr id_subscribe_Lio_reactivex_FlowableEmitter_;
		public unsafe void Subscribe (global::IO.Reactivex.IFlowableEmitter p0)
		{
			if (id_subscribe_Lio_reactivex_FlowableEmitter_ == IntPtr.Zero)
				id_subscribe_Lio_reactivex_FlowableEmitter_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Lio/reactivex/FlowableEmitter;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Lio_reactivex_FlowableEmitter_, __args);
		}

	}

}
