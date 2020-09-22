using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.internal.util']/interface[@name='QueueDrain']"
	[Register ("io/reactivex/internal/util/QueueDrain", "", "IO.Reactivex.Internal.Util.IQueueDrainInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
	public partial interface IQueueDrain : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/interface[@name='QueueDrain']/method[@name='cancelled' and count(parameter)=0]"
		[Register ("cancelled", "()Z", "GetCancelledHandler:IO.Reactivex.Internal.Util.IQueueDrainInvoker, AndriodBinding")]
		bool Cancelled ();

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/interface[@name='QueueDrain']/method[@name='done' and count(parameter)=0]"
		[Register ("done", "()Z", "GetDoneHandler:IO.Reactivex.Internal.Util.IQueueDrainInvoker, AndriodBinding")]
		bool Done ();

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/interface[@name='QueueDrain']/method[@name='enter' and count(parameter)=0]"
		[Register ("enter", "()Z", "GetEnterHandler:IO.Reactivex.Internal.Util.IQueueDrainInvoker, AndriodBinding")]
		bool Enter ();

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/interface[@name='QueueDrain']/method[@name='error' and count(parameter)=0]"
		[Register ("error", "()Ljava/lang/Throwable;", "GetErrorHandler:IO.Reactivex.Internal.Util.IQueueDrainInvoker, AndriodBinding")]
		global::Java.Lang.Throwable Error ();

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/interface[@name='QueueDrain']/method[@name='leave' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("leave", "(I)I", "GetLeave_IHandler:IO.Reactivex.Internal.Util.IQueueDrainInvoker, AndriodBinding")]
		int Leave (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/interface[@name='QueueDrain']/method[@name='produced' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("produced", "(J)J", "GetProduced_JHandler:IO.Reactivex.Internal.Util.IQueueDrainInvoker, AndriodBinding")]
		long Produced (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.util']/interface[@name='QueueDrain']/method[@name='requested' and count(parameter)=0]"
		[Register ("requested", "()J", "GetRequestedHandler:IO.Reactivex.Internal.Util.IQueueDrainInvoker, AndriodBinding")]
		long Requested ();

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/util/QueueDrain", DoNotGenerateAcw=true)]
	internal partial class IQueueDrainInvoker : global::Java.Lang.Object, IQueueDrain {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/internal/util/QueueDrain");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IQueueDrainInvoker); }
		}

		IntPtr class_ref;

		public static IQueueDrain GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQueueDrain> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.internal.util.QueueDrain"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQueueDrainInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cancelled;
#pragma warning disable 0169
		static Delegate GetCancelledHandler ()
		{
			if (cb_cancelled == null)
				cb_cancelled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Cancelled);
			return cb_cancelled;
		}

		static bool n_Cancelled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.IQueueDrain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cancelled ();
		}
#pragma warning restore 0169

		IntPtr id_cancelled;
		public unsafe bool Cancelled ()
		{
			if (id_cancelled == IntPtr.Zero)
				id_cancelled = JNIEnv.GetMethodID (class_ref, "cancelled", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_cancelled);
		}

		static Delegate cb_done;
#pragma warning disable 0169
		static Delegate GetDoneHandler ()
		{
			if (cb_done == null)
				cb_done = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Done);
			return cb_done;
		}

		static bool n_Done (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.IQueueDrain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Done ();
		}
#pragma warning restore 0169

		IntPtr id_done;
		public unsafe bool Done ()
		{
			if (id_done == IntPtr.Zero)
				id_done = JNIEnv.GetMethodID (class_ref, "done", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_done);
		}

		static Delegate cb_enter;
#pragma warning disable 0169
		static Delegate GetEnterHandler ()
		{
			if (cb_enter == null)
				cb_enter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Enter);
			return cb_enter;
		}

		static bool n_Enter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.IQueueDrain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Enter ();
		}
#pragma warning restore 0169

		IntPtr id_enter;
		public unsafe bool Enter ()
		{
			if (id_enter == IntPtr.Zero)
				id_enter = JNIEnv.GetMethodID (class_ref, "enter", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_enter);
		}

		static Delegate cb_error;
#pragma warning disable 0169
		static Delegate GetErrorHandler ()
		{
			if (cb_error == null)
				cb_error = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Error);
			return cb_error;
		}

		static IntPtr n_Error (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.IQueueDrain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Error ());
		}
#pragma warning restore 0169

		IntPtr id_error;
		public unsafe global::Java.Lang.Throwable Error ()
		{
			if (id_error == IntPtr.Zero)
				id_error = JNIEnv.GetMethodID (class_ref, "error", "()Ljava/lang/Throwable;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_error), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_leave_I;
#pragma warning disable 0169
		static Delegate GetLeave_IHandler ()
		{
			if (cb_leave_I == null)
				cb_leave_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_Leave_I);
			return cb_leave_I;
		}

		static int n_Leave_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.IQueueDrain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Leave (p0);
		}
#pragma warning restore 0169

		IntPtr id_leave_I;
		public unsafe int Leave (int p0)
		{
			if (id_leave_I == IntPtr.Zero)
				id_leave_I = JNIEnv.GetMethodID (class_ref, "leave", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_leave_I, __args);
		}

		static Delegate cb_produced_J;
#pragma warning disable 0169
		static Delegate GetProduced_JHandler ()
		{
			if (cb_produced_J == null)
				cb_produced_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_J) n_Produced_J);
			return cb_produced_J;
		}

		static long n_Produced_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.IQueueDrain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Produced (p0);
		}
#pragma warning restore 0169

		IntPtr id_produced_J;
		public unsafe long Produced (long p0)
		{
			if (id_produced_J == IntPtr.Zero)
				id_produced_J = JNIEnv.GetMethodID (class_ref, "produced", "(J)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_produced_J, __args);
		}

		static Delegate cb_requested;
#pragma warning disable 0169
		static Delegate GetRequestedHandler ()
		{
			if (cb_requested == null)
				cb_requested = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_Requested);
			return cb_requested;
		}

		static long n_Requested (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Util.IQueueDrain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Requested ();
		}
#pragma warning restore 0169

		IntPtr id_requested;
		public unsafe long Requested ()
		{
			if (id_requested == IntPtr.Zero)
				id_requested = JNIEnv.GetMethodID (class_ref, "requested", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_requested);
		}

	}

}
