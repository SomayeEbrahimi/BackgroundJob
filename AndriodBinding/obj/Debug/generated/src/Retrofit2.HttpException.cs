using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Retrofit2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='retrofit2']/class[@name='HttpException']"
	[global::Android.Runtime.Register ("retrofit2/HttpException", DoNotGenerateAcw=true)]
	public partial class HttpException : global::Java.Lang.RuntimeException {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("retrofit2/HttpException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpException); }
		}

		protected HttpException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lretrofit2_Response_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='retrofit2']/class[@name='HttpException']/constructor[@name='HttpException' and count(parameter)=1 and parameter[1][@type='retrofit2.Response&lt;?&gt;']]"
		[Register (".ctor", "(Lretrofit2/Response;)V", "")]
		public unsafe HttpException (global::Retrofit2.Response response)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (response);
				if (((object) this).GetType () != typeof (HttpException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lretrofit2/Response;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Lretrofit2/Response;)V", __args);
					return;
				}

				if (id_ctor_Lretrofit2_Response_ == IntPtr.Zero)
					id_ctor_Lretrofit2_Response_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lretrofit2/Response;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lretrofit2_Response_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Lretrofit2_Response_, __args);
			} finally {
			}
		}

		static Delegate cb_code;
#pragma warning disable 0169
		static Delegate GetCodeHandler ()
		{
			if (cb_code == null)
				cb_code = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Code);
			return cb_code;
		}

		static int n_Code (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.HttpException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Code ();
		}
#pragma warning restore 0169

		static IntPtr id_code;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='HttpException']/method[@name='code' and count(parameter)=0]"
		[Register ("code", "()I", "GetCodeHandler")]
		public virtual unsafe int Code ()
		{
			if (id_code == IntPtr.Zero)
				id_code = JNIEnv.GetMethodID (class_ref, "code", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Throwable) this).Handle, id_code);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "code", "()I"));
			} finally {
			}
		}

		static Delegate cb_message;
#pragma warning disable 0169
		static Delegate GetInvokeMessageHandler ()
		{
			if (cb_message == null)
				cb_message = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_InvokeMessage);
			return cb_message;
		}

		static IntPtr n_InvokeMessage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.HttpException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InvokeMessage ());
		}
#pragma warning restore 0169

		static IntPtr id_message;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='HttpException']/method[@name='message' and count(parameter)=0]"
		[Register ("message", "()Ljava/lang/String;", "GetInvokeMessageHandler")]
		public virtual unsafe string InvokeMessage ()
		{
			if (id_message == IntPtr.Zero)
				id_message = JNIEnv.GetMethodID (class_ref, "message", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_message), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "message", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_response;
#pragma warning disable 0169
		static Delegate GetResponseHandler ()
		{
			if (cb_response == null)
				cb_response = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Response);
			return cb_response;
		}

		static IntPtr n_Response (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Retrofit2.HttpException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response ());
		}
#pragma warning restore 0169

		static IntPtr id_response;
		// Metadata.xml XPath method reference: path="/api/package[@name='retrofit2']/class[@name='HttpException']/method[@name='response' and count(parameter)=0]"
		[Register ("response", "()Lretrofit2/Response;", "GetResponseHandler")]
		public virtual unsafe global::Retrofit2.Response Response ()
		{
			if (id_response == IntPtr.Zero)
				id_response = JNIEnv.GetMethodID (class_ref, "response", "()Lretrofit2/Response;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Retrofit2.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_response), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Retrofit2.Response> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "response", "()Lretrofit2/Response;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
