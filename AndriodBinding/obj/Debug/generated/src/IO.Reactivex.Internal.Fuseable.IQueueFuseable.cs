using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Fuseable {

	[Register ("io/reactivex/internal/fuseable/QueueFuseable", DoNotGenerateAcw=true)]
	public abstract class QueueFuseable : Java.Lang.Object {

		internal QueueFuseable ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='QueueFuseable']/field[@name='ANY']"
		[Register ("ANY")]
		public const int Any = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='QueueFuseable']/field[@name='ASYNC']"
		[Register ("ASYNC")]
		public const int Async = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='QueueFuseable']/field[@name='BOUNDARY']"
		[Register ("BOUNDARY")]
		public const int Boundary = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='QueueFuseable']/field[@name='NONE']"
		[Register ("NONE")]
		public const int None = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='QueueFuseable']/field[@name='SYNC']"
		[Register ("SYNC")]
		public const int Sync = (int) 1;

		// The following are fields from: io.reactivex.internal.fuseable.SimpleQueue
	}

	[Register ("io/reactivex/internal/fuseable/QueueFuseable", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'QueueFuseable' type. This type will be removed in a future release.", error: true)]
	public abstract class QueueFuseableConsts : QueueFuseable {

		private QueueFuseableConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='QueueFuseable']"
	[Register ("io/reactivex/internal/fuseable/QueueFuseable", "", "IO.Reactivex.Internal.Fuseable.IQueueFuseableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IQueueFuseable : global::IO.Reactivex.Internal.Fuseable.ISimpleQueue {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='QueueFuseable']/method[@name='requestFusion' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("requestFusion", "(I)I", "GetRequestFusion_IHandler:IO.Reactivex.Internal.Fuseable.IQueueFuseableInvoker, AndriodBinding")]
		int RequestFusion (int p0);

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/fuseable/QueueFuseable", DoNotGenerateAcw=true)]
	internal partial class IQueueFuseableInvoker : global::Java.Lang.Object, IQueueFuseable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/internal/fuseable/QueueFuseable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IQueueFuseableInvoker); }
		}

		IntPtr class_ref;

		public static IQueueFuseable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQueueFuseable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.internal.fuseable.QueueFuseable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQueueFuseableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_requestFusion_I;
#pragma warning disable 0169
		static Delegate GetRequestFusion_IHandler ()
		{
			if (cb_requestFusion_I == null)
				cb_requestFusion_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_RequestFusion_I);
			return cb_requestFusion_I;
		}

		static int n_RequestFusion_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Fuseable.IQueueFuseable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestFusion (p0);
		}
#pragma warning restore 0169

		IntPtr id_requestFusion_I;
		public unsafe int RequestFusion (int p0)
		{
			if (id_requestFusion_I == IntPtr.Zero)
				id_requestFusion_I = JNIEnv.GetMethodID (class_ref, "requestFusion", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_requestFusion_I, __args);
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Fuseable.IQueueFuseable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		IntPtr id_isEmpty;
		public unsafe bool IsEmpty {
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Fuseable.IQueueFuseable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
		}

		static Delegate cb_offer_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOffer_Ljava_lang_Object_Handler ()
		{
			if (cb_offer_Ljava_lang_Object_ == null)
				cb_offer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Offer_Ljava_lang_Object_);
			return cb_offer_Ljava_lang_Object_;
		}

		static bool n_Offer_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Fuseable.IQueueFuseable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Offer (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_offer_Ljava_lang_Object_;
		public unsafe bool Offer (global::Java.Lang.Object p0)
		{
			if (id_offer_Ljava_lang_Object_ == IntPtr.Zero)
				id_offer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offer", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offer_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_offer_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOffer_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_offer_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_offer_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_Offer_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_offer_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static bool n_Offer_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Fuseable.IQueueFuseable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Offer (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_offer_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe bool Offer (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_offer_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_offer_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offer", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offer_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_poll;
#pragma warning disable 0169
		static Delegate GetPollHandler ()
		{
			if (cb_poll == null)
				cb_poll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Poll);
			return cb_poll;
		}

		static IntPtr n_Poll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Fuseable.IQueueFuseable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Poll ());
		}
#pragma warning restore 0169

		IntPtr id_poll;
		public unsafe global::Java.Lang.Object Poll ()
		{
			if (id_poll == IntPtr.Zero)
				id_poll = JNIEnv.GetMethodID (class_ref, "poll", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_poll), JniHandleOwnership.TransferLocalRef);
		}

	}

}
