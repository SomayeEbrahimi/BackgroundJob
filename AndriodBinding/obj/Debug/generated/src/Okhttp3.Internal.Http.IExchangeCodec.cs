using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Okhttp3.Internal.Http {

	[Register ("okhttp3/internal/http/ExchangeCodec", DoNotGenerateAcw=true)]
	public abstract class ExchangeCodec : Java.Lang.Object {

		internal ExchangeCodec ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='ExchangeCodec']/field[@name='DISCARD_STREAM_TIMEOUT_MILLIS']"
		[Register ("DISCARD_STREAM_TIMEOUT_MILLIS")]
		public const int DiscardStreamTimeoutMillis = (int) 100;
	}

	[Register ("okhttp3/internal/http/ExchangeCodec", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'ExchangeCodec' type. This type will be removed in a future release.", error: true)]
	public abstract class ExchangeCodecConsts : ExchangeCodec {

		private ExchangeCodecConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='ExchangeCodec']"
	[Register ("okhttp3/internal/http/ExchangeCodec", "", "Okhttp3.Internal.Http.IExchangeCodecInvoker")]
	public partial interface IExchangeCodec : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='ExchangeCodec']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:Okhttp3.Internal.Http.IExchangeCodecInvoker, AndriodBinding")]
		void Cancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='ExchangeCodec']/method[@name='connection' and count(parameter)=0]"
		[Register ("connection", "()Lokhttp3/internal/connection/RealConnection;", "GetConnectionHandler:Okhttp3.Internal.Http.IExchangeCodecInvoker, AndriodBinding")]
		global::Okhttp3.Internal.Connection.RealConnection Connection ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='ExchangeCodec']/method[@name='finishRequest' and count(parameter)=0]"
		[Register ("finishRequest", "()V", "GetFinishRequestHandler:Okhttp3.Internal.Http.IExchangeCodecInvoker, AndriodBinding")]
		void FinishRequest ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='ExchangeCodec']/method[@name='flushRequest' and count(parameter)=0]"
		[Register ("flushRequest", "()V", "GetFlushRequestHandler:Okhttp3.Internal.Http.IExchangeCodecInvoker, AndriodBinding")]
		void FlushRequest ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='ExchangeCodec']/method[@name='readResponseHeaders' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("readResponseHeaders", "(Z)Lokhttp3/Response$Builder;", "GetReadResponseHeaders_ZHandler:Okhttp3.Internal.Http.IExchangeCodecInvoker, AndriodBinding")]
		global::Okhttp3.Response.Builder ReadResponseHeaders (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='ExchangeCodec']/method[@name='reportedContentLength' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("reportedContentLength", "(Lokhttp3/Response;)J", "GetReportedContentLength_Lokhttp3_Response_Handler:Okhttp3.Internal.Http.IExchangeCodecInvoker, AndriodBinding")]
		long ReportedContentLength (global::Okhttp3.Response p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='ExchangeCodec']/method[@name='trailers' and count(parameter)=0]"
		[Register ("trailers", "()Lokhttp3/Headers;", "GetTrailersHandler:Okhttp3.Internal.Http.IExchangeCodecInvoker, AndriodBinding")]
		global::Okhttp3.Headers Trailers ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='ExchangeCodec']/method[@name='writeRequestHeaders' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("writeRequestHeaders", "(Lokhttp3/Request;)V", "GetWriteRequestHeaders_Lokhttp3_Request_Handler:Okhttp3.Internal.Http.IExchangeCodecInvoker, AndriodBinding")]
		void WriteRequestHeaders (global::Okhttp3.Request p0);

	}

	[global::Android.Runtime.Register ("okhttp3/internal/http/ExchangeCodec", DoNotGenerateAcw=true)]
	internal partial class IExchangeCodecInvoker : global::Java.Lang.Object, IExchangeCodec {

		static IntPtr java_class_ref = JNIEnv.FindClass ("okhttp3/internal/http/ExchangeCodec");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IExchangeCodecInvoker); }
		}

		IntPtr class_ref;

		public static IExchangeCodec GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExchangeCodec> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.http.ExchangeCodec"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExchangeCodecInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IExchangeCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_connection;
#pragma warning disable 0169
		static Delegate GetConnectionHandler ()
		{
			if (cb_connection == null)
				cb_connection = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Connection);
			return cb_connection;
		}

		static IntPtr n_Connection (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IExchangeCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Connection ());
		}
#pragma warning restore 0169

		IntPtr id_connection;
		public unsafe global::Okhttp3.Internal.Connection.RealConnection Connection ()
		{
			if (id_connection == IntPtr.Zero)
				id_connection = JNIEnv.GetMethodID (class_ref, "connection", "()Lokhttp3/internal/connection/RealConnection;");
			return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Connection.RealConnection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connection), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_finishRequest;
#pragma warning disable 0169
		static Delegate GetFinishRequestHandler ()
		{
			if (cb_finishRequest == null)
				cb_finishRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FinishRequest);
			return cb_finishRequest;
		}

		static void n_FinishRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IExchangeCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinishRequest ();
		}
#pragma warning restore 0169

		IntPtr id_finishRequest;
		public unsafe void FinishRequest ()
		{
			if (id_finishRequest == IntPtr.Zero)
				id_finishRequest = JNIEnv.GetMethodID (class_ref, "finishRequest", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finishRequest);
		}

		static Delegate cb_flushRequest;
#pragma warning disable 0169
		static Delegate GetFlushRequestHandler ()
		{
			if (cb_flushRequest == null)
				cb_flushRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FlushRequest);
			return cb_flushRequest;
		}

		static void n_FlushRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IExchangeCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FlushRequest ();
		}
#pragma warning restore 0169

		IntPtr id_flushRequest;
		public unsafe void FlushRequest ()
		{
			if (id_flushRequest == IntPtr.Zero)
				id_flushRequest = JNIEnv.GetMethodID (class_ref, "flushRequest", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flushRequest);
		}

		static Delegate cb_readResponseHeaders_Z;
#pragma warning disable 0169
		static Delegate GetReadResponseHeaders_ZHandler ()
		{
			if (cb_readResponseHeaders_Z == null)
				cb_readResponseHeaders_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_ReadResponseHeaders_Z);
			return cb_readResponseHeaders_Z;
		}

		static IntPtr n_ReadResponseHeaders_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IExchangeCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadResponseHeaders (p0));
		}
#pragma warning restore 0169

		IntPtr id_readResponseHeaders_Z;
		public unsafe global::Okhttp3.Response.Builder ReadResponseHeaders (bool p0)
		{
			if (id_readResponseHeaders_Z == IntPtr.Zero)
				id_readResponseHeaders_Z = JNIEnv.GetMethodID (class_ref, "readResponseHeaders", "(Z)Lokhttp3/Response$Builder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Okhttp3.Response.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readResponseHeaders_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_reportedContentLength_Lokhttp3_Response_;
#pragma warning disable 0169
		static Delegate GetReportedContentLength_Lokhttp3_Response_Handler ()
		{
			if (cb_reportedContentLength_Lokhttp3_Response_ == null)
				cb_reportedContentLength_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_ReportedContentLength_Lokhttp3_Response_);
			return cb_reportedContentLength_Lokhttp3_Response_;
		}

		static long n_ReportedContentLength_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IExchangeCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.ReportedContentLength (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_reportedContentLength_Lokhttp3_Response_;
		public unsafe long ReportedContentLength (global::Okhttp3.Response p0)
		{
			if (id_reportedContentLength_Lokhttp3_Response_ == IntPtr.Zero)
				id_reportedContentLength_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "reportedContentLength", "(Lokhttp3/Response;)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			var __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_reportedContentLength_Lokhttp3_Response_, __args);
			return __ret;
		}

		static Delegate cb_trailers;
#pragma warning disable 0169
		static Delegate GetTrailersHandler ()
		{
			if (cb_trailers == null)
				cb_trailers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Trailers);
			return cb_trailers;
		}

		static IntPtr n_Trailers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IExchangeCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Trailers ());
		}
#pragma warning restore 0169

		IntPtr id_trailers;
		public unsafe global::Okhttp3.Headers Trailers ()
		{
			if (id_trailers == IntPtr.Zero)
				id_trailers = JNIEnv.GetMethodID (class_ref, "trailers", "()Lokhttp3/Headers;");
			return global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_trailers), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeRequestHeaders_Lokhttp3_Request_;
#pragma warning disable 0169
		static Delegate GetWriteRequestHeaders_Lokhttp3_Request_Handler ()
		{
			if (cb_writeRequestHeaders_Lokhttp3_Request_ == null)
				cb_writeRequestHeaders_Lokhttp3_Request_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteRequestHeaders_Lokhttp3_Request_);
			return cb_writeRequestHeaders_Lokhttp3_Request_;
		}

		static void n_WriteRequestHeaders_Lokhttp3_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.IExchangeCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteRequestHeaders (p0);
		}
#pragma warning restore 0169

		IntPtr id_writeRequestHeaders_Lokhttp3_Request_;
		public unsafe void WriteRequestHeaders (global::Okhttp3.Request p0)
		{
			if (id_writeRequestHeaders_Lokhttp3_Request_ == IntPtr.Zero)
				id_writeRequestHeaders_Lokhttp3_Request_ = JNIEnv.GetMethodID (class_ref, "writeRequestHeaders", "(Lokhttp3/Request;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeRequestHeaders_Lokhttp3_Request_, __args);
		}

	}

}
