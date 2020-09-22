using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Retrofit2 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='retrofit2']/interface[@name='Callback']"
	[Register ("retrofit2/Callback", "", "Retrofit2.ICallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ICallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/interface[@name='Callback']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='retrofit2.Call&lt;T&gt;'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("onFailure", "(Lretrofit2/Call;Ljava/lang/Throwable;)V", "GetOnFailure_Lretrofit2_Call_Ljava_lang_Throwable_Handler:Retrofit2.ICallbackInvoker, AndriodBinding")]
		void OnFailure (global::Retrofit2.ICall p0, global::Java.Lang.Throwable p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/interface[@name='Callback']/method[@name='onResponse' and count(parameter)=2 and parameter[1][@type='retrofit2.Call&lt;T&gt;'] and parameter[2][@type='retrofit2.Response&lt;T&gt;']]"
		[Register ("onResponse", "(Lretrofit2/Call;Lretrofit2/Response;)V", "GetOnResponse_Lretrofit2_Call_Lretrofit2_Response_Handler:Retrofit2.ICallbackInvoker, AndriodBinding")]
		void OnResponse (global::Retrofit2.ICall p0, global::Retrofit2.Response p1);

	}

	[global::Android.Runtime.Register ("retrofit2/Callback", DoNotGenerateAcw=true)]
	internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("retrofit2/Callback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICallbackInvoker); }
		}

		IntPtr class_ref;

		public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "retrofit2.Callback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailure_Lretrofit2_Call_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lretrofit2_Call_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onFailure_Lretrofit2_Call_Ljava_lang_Throwable_ == null)
				cb_onFailure_Lretrofit2_Call_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnFailure_Lretrofit2_Call_Ljava_lang_Throwable_);
			return cb_onFailure_Lretrofit2_Call_Ljava_lang_Throwable_;
		}

		static void n_OnFailure_Lretrofit2_Call_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Retrofit2.ICall)global::Java.Lang.Object.GetObject<global::Retrofit2.ICall> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Lretrofit2_Call_Ljava_lang_Throwable_;
		public unsafe void OnFailure (global::Retrofit2.ICall p0, global::Java.Lang.Throwable p1)
		{
			if (id_onFailure_Lretrofit2_Call_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onFailure_Lretrofit2_Call_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lretrofit2/Call;Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lretrofit2_Call_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_onResponse_Lretrofit2_Call_Lretrofit2_Response_;
#pragma warning disable 0169
		static Delegate GetOnResponse_Lretrofit2_Call_Lretrofit2_Response_Handler ()
		{
			if (cb_onResponse_Lretrofit2_Call_Lretrofit2_Response_ == null)
				cb_onResponse_Lretrofit2_Call_Lretrofit2_Response_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnResponse_Lretrofit2_Call_Lretrofit2_Response_);
			return cb_onResponse_Lretrofit2_Call_Lretrofit2_Response_;
		}

		static void n_OnResponse_Lretrofit2_Call_Lretrofit2_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Retrofit2.ICall)global::Java.Lang.Object.GetObject<global::Retrofit2.ICall> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Retrofit2.Response> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onResponse_Lretrofit2_Call_Lretrofit2_Response_;
		public unsafe void OnResponse (global::Retrofit2.ICall p0, global::Retrofit2.Response p1)
		{
			if (id_onResponse_Lretrofit2_Call_Lretrofit2_Response_ == IntPtr.Zero)
				id_onResponse_Lretrofit2_Call_Lretrofit2_Response_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Lretrofit2/Call;Lretrofit2/Response;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponse_Lretrofit2_Call_Lretrofit2_Response_, __args);
		}

	}

}
