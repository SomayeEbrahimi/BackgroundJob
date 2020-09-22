using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Concurrent {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/interface[@name='CircuitBreaker']"
	[Register ("org/apache/commons/lang3/concurrent/CircuitBreaker", "", "Org.Apache.Commons.Lang3.Concurrent.ICircuitBreakerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ICircuitBreaker : IJavaObject {

		bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/interface[@name='CircuitBreaker']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler:Org.Apache.Commons.Lang3.Concurrent.ICircuitBreakerInvoker, AndriodBinding")] get;
		}

		bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/interface[@name='CircuitBreaker']/method[@name='isOpen' and count(parameter)=0]"
			[Register ("isOpen", "()Z", "GetIsOpenHandler:Org.Apache.Commons.Lang3.Concurrent.ICircuitBreakerInvoker, AndriodBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/interface[@name='CircuitBreaker']/method[@name='checkState' and count(parameter)=0]"
		[Register ("checkState", "()Z", "GetCheckStateHandler:Org.Apache.Commons.Lang3.Concurrent.ICircuitBreakerInvoker, AndriodBinding")]
		bool CheckState ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/interface[@name='CircuitBreaker']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Org.Apache.Commons.Lang3.Concurrent.ICircuitBreakerInvoker, AndriodBinding")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/interface[@name='CircuitBreaker']/method[@name='incrementAndCheckState' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("incrementAndCheckState", "(Ljava/lang/Object;)Z", "GetIncrementAndCheckState_Ljava_lang_Object_Handler:Org.Apache.Commons.Lang3.Concurrent.ICircuitBreakerInvoker, AndriodBinding")]
		bool IncrementAndCheckState (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/interface[@name='CircuitBreaker']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()V", "GetOpenHandler:Org.Apache.Commons.Lang3.Concurrent.ICircuitBreakerInvoker, AndriodBinding")]
		void Open ();

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/CircuitBreaker", DoNotGenerateAcw=true)]
	internal partial class ICircuitBreakerInvoker : global::Java.Lang.Object, ICircuitBreaker {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/CircuitBreaker");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICircuitBreakerInvoker); }
		}

		IntPtr class_ref;

		public static ICircuitBreaker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICircuitBreaker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.apache.commons.lang3.concurrent.CircuitBreaker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICircuitBreakerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isClosed;
#pragma warning disable 0169
		static Delegate GetIsClosedHandler ()
		{
			if (cb_isClosed == null)
				cb_isClosed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsClosed);
			return cb_isClosed;
		}

		static bool n_IsClosed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.ICircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosed;
		}
#pragma warning restore 0169

		IntPtr id_isClosed;
		public unsafe bool IsClosed {
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClosed);
			}
		}

		static Delegate cb_isOpen;
#pragma warning disable 0169
		static Delegate GetIsOpenHandler ()
		{
			if (cb_isOpen == null)
				cb_isOpen = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsOpen);
			return cb_isOpen;
		}

		static bool n_IsOpen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.ICircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		IntPtr id_isOpen;
		public unsafe bool IsOpen {
			get {
				if (id_isOpen == IntPtr.Zero)
					id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpen);
			}
		}

		static Delegate cb_checkState;
#pragma warning disable 0169
		static Delegate GetCheckStateHandler ()
		{
			if (cb_checkState == null)
				cb_checkState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_CheckState);
			return cb_checkState;
		}

		static bool n_CheckState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.ICircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckState ();
		}
#pragma warning restore 0169

		IntPtr id_checkState;
		public unsafe bool CheckState ()
		{
			if (id_checkState == IntPtr.Zero)
				id_checkState = JNIEnv.GetMethodID (class_ref, "checkState", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkState);
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.ICircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_incrementAndCheckState_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetIncrementAndCheckState_Ljava_lang_Object_Handler ()
		{
			if (cb_incrementAndCheckState_Ljava_lang_Object_ == null)
				cb_incrementAndCheckState_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IncrementAndCheckState_Ljava_lang_Object_);
			return cb_incrementAndCheckState_Ljava_lang_Object_;
		}

		static bool n_IncrementAndCheckState_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.ICircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IncrementAndCheckState (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_incrementAndCheckState_Ljava_lang_Object_;
		public unsafe bool IncrementAndCheckState (global::Java.Lang.Object p0)
		{
			if (id_incrementAndCheckState_Ljava_lang_Object_ == IntPtr.Zero)
				id_incrementAndCheckState_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "incrementAndCheckState", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_incrementAndCheckState_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Open);
			return cb_open;
		}

		static void n_Open (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.ICircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Open ();
		}
#pragma warning restore 0169

		IntPtr id_open;
		public unsafe void Open ()
		{
			if (id_open == IntPtr.Zero)
				id_open = JNIEnv.GetMethodID (class_ref, "open", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_open);
		}

	}

}
