using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Retrofit2 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='retrofit2']/interface[@name='Call']"
	[Register ("retrofit2/Call", "", "Retrofit2.ICallInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ICall : global::Java.Lang.ICloneable {

		bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/interface[@name='Call']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler:Retrofit2.ICallInvoker, AndriodBinding")] get;
		}

		bool IsExecuted {
			// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/interface[@name='Call']/method[@name='isExecuted' and count(parameter)=0]"
			[Register ("isExecuted", "()Z", "GetIsExecutedHandler:Retrofit2.ICallInvoker, AndriodBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/interface[@name='Call']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:Retrofit2.ICallInvoker, AndriodBinding")]
		void Cancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/interface[@name='Call']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lretrofit2/Call;", "GetCloneHandler:Retrofit2.ICallInvoker, AndriodBinding")]
		global::Retrofit2.ICall Clone ();

		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/interface[@name='Call']/method[@name='enqueue' and count(parameter)=1 and parameter[1][@type='retrofit2.Callback&lt;T&gt;']]"
		[Register ("enqueue", "(Lretrofit2/Callback;)V", "GetEnqueue_Lretrofit2_Callback_Handler:Retrofit2.ICallInvoker, AndriodBinding")]
		void Enqueue (global::Retrofit2.ICallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/interface[@name='Call']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()Lretrofit2/Response;", "GetExecuteHandler:Retrofit2.ICallInvoker, AndriodBinding")]
		global::Retrofit2.Response Execute ();

		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/interface[@name='Call']/method[@name='request' and count(parameter)=0]"
		[Register ("request", "()Lokhttp3/Request;", "GetRequestHandler:Retrofit2.ICallInvoker, AndriodBinding")]
		global::Okhttp3.Request Request ();

	}

	[global::Android.Runtime.Register ("retrofit2/Call", DoNotGenerateAcw=true)]
	internal partial class ICallInvoker : global::Java.Lang.Object, ICall {

		static IntPtr java_class_ref = JNIEnv.FindClass ("retrofit2/Call");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICallInvoker); }
		}

		IntPtr class_ref;

		public static ICall GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICall> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "retrofit2.Call"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICallInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isCanceled;
#pragma warning disable 0169
		static Delegate GetIsCanceledHandler ()
		{
			if (cb_isCanceled == null)
				cb_isCanceled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCanceled);
			return cb_isCanceled;
		}

		static bool n_IsCanceled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.ICall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCanceled;
		}
#pragma warning restore 0169

		IntPtr id_isCanceled;
		public unsafe bool IsCanceled {
			get {
				if (id_isCanceled == IntPtr.Zero)
					id_isCanceled = JNIEnv.GetMethodID (class_ref, "isCanceled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCanceled);
			}
		}

		static Delegate cb_isExecuted;
#pragma warning disable 0169
		static Delegate GetIsExecutedHandler ()
		{
			if (cb_isExecuted == null)
				cb_isExecuted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExecuted);
			return cb_isExecuted;
		}

		static bool n_IsExecuted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.ICall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExecuted;
		}
#pragma warning restore 0169

		IntPtr id_isExecuted;
		public unsafe bool IsExecuted {
			get {
				if (id_isExecuted == IntPtr.Zero)
					id_isExecuted = JNIEnv.GetMethodID (class_ref, "isExecuted", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExecuted);
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.ICall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.ICall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		IntPtr id_clone;
		public unsafe global::Retrofit2.ICall Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lretrofit2/Call;");
			return global::Java.Lang.Object.GetObject<global::Retrofit2.ICall> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_enqueue_Lretrofit2_Callback_;
#pragma warning disable 0169
		static Delegate GetEnqueue_Lretrofit2_Callback_Handler ()
		{
			if (cb_enqueue_Lretrofit2_Callback_ == null)
				cb_enqueue_Lretrofit2_Callback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Enqueue_Lretrofit2_Callback_);
			return cb_enqueue_Lretrofit2_Callback_;
		}

		static void n_Enqueue_Lretrofit2_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.ICall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Retrofit2.ICallback)global::Java.Lang.Object.GetObject<global::Retrofit2.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Enqueue (p0);
		}
#pragma warning restore 0169

		IntPtr id_enqueue_Lretrofit2_Callback_;
		public unsafe void Enqueue (global::Retrofit2.ICallback p0)
		{
			if (id_enqueue_Lretrofit2_Callback_ == IntPtr.Zero)
				id_enqueue_Lretrofit2_Callback_ = JNIEnv.GetMethodID (class_ref, "enqueue", "(Lretrofit2/Callback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enqueue_Lretrofit2_Callback_, __args);
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Execute);
			return cb_execute;
		}

		static IntPtr n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.ICall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Execute ());
		}
#pragma warning restore 0169

		IntPtr id_execute;
		public unsafe global::Retrofit2.Response Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()Lretrofit2/Response;");
			return global::Java.Lang.Object.GetObject<global::Retrofit2.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_execute), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_request;
#pragma warning disable 0169
		static Delegate GetRequestHandler ()
		{
			if (cb_request == null)
				cb_request = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Request);
			return cb_request;
		}

		static IntPtr n_Request (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.ICall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request ());
		}
#pragma warning restore 0169

		IntPtr id_request;
		public unsafe global::Okhttp3.Request Request ()
		{
			if (id_request == IntPtr.Zero)
				id_request = JNIEnv.GetMethodID (class_ref, "request", "()Lokhttp3/Request;");
			return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_request), JniHandleOwnership.TransferLocalRef);
		}

	}

}
