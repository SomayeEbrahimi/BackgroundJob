using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Queue {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.queue']/class[@name='SpscArrayQueue']"
	[global::Android.Runtime.Register ("io/reactivex/internal/queue/SpscArrayQueue", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
	public sealed partial class SpscArrayQueue : global::Java.Util.Concurrent.Atomic.AtomicReferenceArray, global::IO.Reactivex.Internal.Fuseable.ISimplePlainQueue {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/queue/SpscArrayQueue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpscArrayQueue); }
		}

		internal SpscArrayQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.queue']/class[@name='SpscArrayQueue']/constructor[@name='SpscArrayQueue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe SpscArrayQueue (int capacity)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (capacity);
				if (((object) this).GetType () != typeof (SpscArrayQueue)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_isEmpty;
		public unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.queue']/class[@name='SpscArrayQueue']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
				} finally {
				}
			}
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.queue']/class[@name='SpscArrayQueue']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
			} finally {
			}
		}

		static IntPtr id_offer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.queue']/class[@name='SpscArrayQueue']/method[@name='offer' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("offer", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Offer (global::Java.Lang.Object e)
		{
			if (id_offer_Ljava_lang_Object_ == IntPtr.Zero)
				id_offer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offer", "(Ljava/lang/Object;)Z");
			IntPtr native_e = JNIEnv.ToLocalJniHandle (e);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_e);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offer_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
			}
		}

		static IntPtr id_offer_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.queue']/class[@name='SpscArrayQueue']/method[@name='offer' and count(parameter)=2 and parameter[1][@type='E'] and parameter[2][@type='E']]"
		[Register ("offer", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public unsafe bool Offer (global::Java.Lang.Object v1, global::Java.Lang.Object v2)
		{
			if (id_offer_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_offer_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offer", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			IntPtr native_v1 = JNIEnv.ToLocalJniHandle (v1);
			IntPtr native_v2 = JNIEnv.ToLocalJniHandle (v2);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_v1);
				__args [1] = new JValue (native_v2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offer_Ljava_lang_Object_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_v1);
				JNIEnv.DeleteLocalRef (native_v2);
			}
		}

		static IntPtr id_poll;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.queue']/class[@name='SpscArrayQueue']/method[@name='poll' and count(parameter)=0]"
		[Register ("poll", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Poll ()
		{
			if (id_poll == IntPtr.Zero)
				id_poll = JNIEnv.GetMethodID (class_ref, "poll", "()Ljava/lang/Object;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_poll), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
