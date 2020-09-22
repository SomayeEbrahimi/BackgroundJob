using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Concurrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ThresholdCircuitBreaker']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/ThresholdCircuitBreaker", DoNotGenerateAcw=true)]
	public partial class ThresholdCircuitBreaker : global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/ThresholdCircuitBreaker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThresholdCircuitBreaker); }
		}

		protected ThresholdCircuitBreaker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ThresholdCircuitBreaker']/constructor[@name='ThresholdCircuitBreaker' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe ThresholdCircuitBreaker (long threshold)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (threshold);
				if (((object) this).GetType () != typeof (ThresholdCircuitBreaker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static Delegate cb_getThreshold;
#pragma warning disable 0169
		static Delegate GetGetThresholdHandler ()
		{
			if (cb_getThreshold == null)
				cb_getThreshold = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetThreshold);
			return cb_getThreshold;
		}

		static long n_GetThreshold (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.ThresholdCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Threshold;
		}
#pragma warning restore 0169

		static IntPtr id_getThreshold;
		public virtual unsafe long Threshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ThresholdCircuitBreaker']/method[@name='getThreshold' and count(parameter)=0]"
			[Register ("getThreshold", "()J", "GetGetThresholdHandler")]
			get {
				if (id_getThreshold == IntPtr.Zero)
					id_getThreshold = JNIEnv.GetMethodID (class_ref, "getThreshold", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getThreshold);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThreshold", "()J"));
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.ThresholdCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckState ();
		}
#pragma warning restore 0169

		static IntPtr id_checkState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ThresholdCircuitBreaker']/method[@name='checkState' and count(parameter)=0]"
		[Register ("checkState", "()Z", "GetCheckStateHandler")]
		public override unsafe bool CheckState ()
		{
			if (id_checkState == IntPtr.Zero)
				id_checkState = JNIEnv.GetMethodID (class_ref, "checkState", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkState);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkState", "()Z"));
			} finally {
			}
		}

		static Delegate cb_incrementAndCheckState_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetIncrementAndCheckState_Ljava_lang_Long_Handler ()
		{
			if (cb_incrementAndCheckState_Ljava_lang_Long_ == null)
				cb_incrementAndCheckState_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IncrementAndCheckState_Ljava_lang_Long_);
			return cb_incrementAndCheckState_Ljava_lang_Long_;
		}

		static bool n_IncrementAndCheckState_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_increment)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.ThresholdCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var increment = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_increment, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IncrementAndCheckState (increment);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_incrementAndCheckState_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='ThresholdCircuitBreaker']/method[@name='incrementAndCheckState' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("incrementAndCheckState", "(Ljava/lang/Long;)Z", "GetIncrementAndCheckState_Ljava_lang_Long_Handler")]
		public virtual unsafe bool IncrementAndCheckState (global::Java.Lang.Long increment)
		{
			if (id_incrementAndCheckState_Ljava_lang_Long_ == IntPtr.Zero)
				id_incrementAndCheckState_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "incrementAndCheckState", "(Ljava/lang/Long;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (increment);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_incrementAndCheckState_Ljava_lang_Long_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "incrementAndCheckState", "(Ljava/lang/Long;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
