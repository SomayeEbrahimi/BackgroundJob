using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Concurrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='EventCountCircuitBreaker']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/EventCountCircuitBreaker", DoNotGenerateAcw=true)]
	public partial class EventCountCircuitBreaker : global::Org.Apache.Commons.Lang3.Concurrent.AbstractCircuitBreaker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/EventCountCircuitBreaker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventCountCircuitBreaker); }
		}

		protected EventCountCircuitBreaker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IJLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='EventCountCircuitBreaker']/constructor[@name='EventCountCircuitBreaker' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register (".ctor", "(IJLjava/util/concurrent/TimeUnit;)V", "")]
		public unsafe EventCountCircuitBreaker (int threshold, long checkInterval, global::Java.Util.Concurrent.TimeUnit checkUnit)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (threshold);
				__args [1] = new JValue (checkInterval);
				__args [2] = new JValue (checkUnit);
				if (((object) this).GetType () != typeof (EventCountCircuitBreaker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IJLjava/util/concurrent/TimeUnit;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IJLjava/util/concurrent/TimeUnit;)V", __args);
					return;
				}

				if (id_ctor_IJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_ctor_IJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IJLjava/util/concurrent/TimeUnit;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IJLjava_util_concurrent_TimeUnit_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IJLjava_util_concurrent_TimeUnit_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_IJLjava_util_concurrent_TimeUnit_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='EventCountCircuitBreaker']/constructor[@name='EventCountCircuitBreaker' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IJLjava/util/concurrent/TimeUnit;I)V", "")]
		public unsafe EventCountCircuitBreaker (int openingThreshold, long checkInterval, global::Java.Util.Concurrent.TimeUnit checkUnit, int closingThreshold)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (openingThreshold);
				__args [1] = new JValue (checkInterval);
				__args [2] = new JValue (checkUnit);
				__args [3] = new JValue (closingThreshold);
				if (((object) this).GetType () != typeof (EventCountCircuitBreaker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IJLjava/util/concurrent/TimeUnit;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IJLjava/util/concurrent/TimeUnit;I)V", __args);
					return;
				}

				if (id_ctor_IJLjava_util_concurrent_TimeUnit_I == IntPtr.Zero)
					id_ctor_IJLjava_util_concurrent_TimeUnit_I = JNIEnv.GetMethodID (class_ref, "<init>", "(IJLjava/util/concurrent/TimeUnit;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IJLjava_util_concurrent_TimeUnit_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IJLjava_util_concurrent_TimeUnit_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_IJLjava_util_concurrent_TimeUnit_IJLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='EventCountCircuitBreaker']/constructor[@name='EventCountCircuitBreaker' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='int'] and parameter[5][@type='long'] and parameter[6][@type='java.util.concurrent.TimeUnit']]"
		[Register (".ctor", "(IJLjava/util/concurrent/TimeUnit;IJLjava/util/concurrent/TimeUnit;)V", "")]
		public unsafe EventCountCircuitBreaker (int openingThreshold, long openingInterval, global::Java.Util.Concurrent.TimeUnit openingUnit, int closingThreshold, long closingInterval, global::Java.Util.Concurrent.TimeUnit closingUnit)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (openingThreshold);
				__args [1] = new JValue (openingInterval);
				__args [2] = new JValue (openingUnit);
				__args [3] = new JValue (closingThreshold);
				__args [4] = new JValue (closingInterval);
				__args [5] = new JValue (closingUnit);
				if (((object) this).GetType () != typeof (EventCountCircuitBreaker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IJLjava/util/concurrent/TimeUnit;IJLjava/util/concurrent/TimeUnit;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IJLjava/util/concurrent/TimeUnit;IJLjava/util/concurrent/TimeUnit;)V", __args);
					return;
				}

				if (id_ctor_IJLjava_util_concurrent_TimeUnit_IJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
					id_ctor_IJLjava_util_concurrent_TimeUnit_IJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IJLjava/util/concurrent/TimeUnit;IJLjava/util/concurrent/TimeUnit;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IJLjava_util_concurrent_TimeUnit_IJLjava_util_concurrent_TimeUnit_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IJLjava_util_concurrent_TimeUnit_IJLjava_util_concurrent_TimeUnit_, __args);
			} finally {
			}
		}

		static Delegate cb_getClosingInterval;
#pragma warning disable 0169
		static Delegate GetGetClosingIntervalHandler ()
		{
			if (cb_getClosingInterval == null)
				cb_getClosingInterval = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetClosingInterval);
			return cb_getClosingInterval;
		}

		static long n_GetClosingInterval (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.EventCountCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClosingInterval;
		}
#pragma warning restore 0169

		static IntPtr id_getClosingInterval;
		public virtual unsafe long ClosingInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='EventCountCircuitBreaker']/method[@name='getClosingInterval' and count(parameter)=0]"
			[Register ("getClosingInterval", "()J", "GetGetClosingIntervalHandler")]
			get {
				if (id_getClosingInterval == IntPtr.Zero)
					id_getClosingInterval = JNIEnv.GetMethodID (class_ref, "getClosingInterval", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getClosingInterval);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClosingInterval", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getClosingThreshold;
#pragma warning disable 0169
		static Delegate GetGetClosingThresholdHandler ()
		{
			if (cb_getClosingThreshold == null)
				cb_getClosingThreshold = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetClosingThreshold);
			return cb_getClosingThreshold;
		}

		static int n_GetClosingThreshold (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.EventCountCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClosingThreshold;
		}
#pragma warning restore 0169

		static IntPtr id_getClosingThreshold;
		public virtual unsafe int ClosingThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='EventCountCircuitBreaker']/method[@name='getClosingThreshold' and count(parameter)=0]"
			[Register ("getClosingThreshold", "()I", "GetGetClosingThresholdHandler")]
			get {
				if (id_getClosingThreshold == IntPtr.Zero)
					id_getClosingThreshold = JNIEnv.GetMethodID (class_ref, "getClosingThreshold", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getClosingThreshold);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClosingThreshold", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getOpeningInterval;
#pragma warning disable 0169
		static Delegate GetGetOpeningIntervalHandler ()
		{
			if (cb_getOpeningInterval == null)
				cb_getOpeningInterval = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetOpeningInterval);
			return cb_getOpeningInterval;
		}

		static long n_GetOpeningInterval (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.EventCountCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OpeningInterval;
		}
#pragma warning restore 0169

		static IntPtr id_getOpeningInterval;
		public virtual unsafe long OpeningInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='EventCountCircuitBreaker']/method[@name='getOpeningInterval' and count(parameter)=0]"
			[Register ("getOpeningInterval", "()J", "GetGetOpeningIntervalHandler")]
			get {
				if (id_getOpeningInterval == IntPtr.Zero)
					id_getOpeningInterval = JNIEnv.GetMethodID (class_ref, "getOpeningInterval", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getOpeningInterval);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpeningInterval", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getOpeningThreshold;
#pragma warning disable 0169
		static Delegate GetGetOpeningThresholdHandler ()
		{
			if (cb_getOpeningThreshold == null)
				cb_getOpeningThreshold = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetOpeningThreshold);
			return cb_getOpeningThreshold;
		}

		static int n_GetOpeningThreshold (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.EventCountCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OpeningThreshold;
		}
#pragma warning restore 0169

		static IntPtr id_getOpeningThreshold;
		public virtual unsafe int OpeningThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='EventCountCircuitBreaker']/method[@name='getOpeningThreshold' and count(parameter)=0]"
			[Register ("getOpeningThreshold", "()I", "GetGetOpeningThresholdHandler")]
			get {
				if (id_getOpeningThreshold == IntPtr.Zero)
					id_getOpeningThreshold = JNIEnv.GetMethodID (class_ref, "getOpeningThreshold", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOpeningThreshold);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpeningThreshold", "()I"));
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.EventCountCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckState ();
		}
#pragma warning restore 0169

		static IntPtr id_checkState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='EventCountCircuitBreaker']/method[@name='checkState' and count(parameter)=0]"
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

		static Delegate cb_incrementAndCheckState;
#pragma warning disable 0169
		static Delegate GetIncrementAndCheckStateHandler ()
		{
			if (cb_incrementAndCheckState == null)
				cb_incrementAndCheckState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IncrementAndCheckState);
			return cb_incrementAndCheckState;
		}

		static bool n_IncrementAndCheckState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.EventCountCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IncrementAndCheckState ();
		}
#pragma warning restore 0169

		static IntPtr id_incrementAndCheckState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='EventCountCircuitBreaker']/method[@name='incrementAndCheckState' and count(parameter)=0]"
		[Register ("incrementAndCheckState", "()Z", "GetIncrementAndCheckStateHandler")]
		public virtual unsafe bool IncrementAndCheckState ()
		{
			if (id_incrementAndCheckState == IntPtr.Zero)
				id_incrementAndCheckState = JNIEnv.GetMethodID (class_ref, "incrementAndCheckState", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_incrementAndCheckState);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "incrementAndCheckState", "()Z"));
			} finally {
			}
		}

		static Delegate cb_incrementAndCheckState_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetIncrementAndCheckState_Ljava_lang_Integer_Handler ()
		{
			if (cb_incrementAndCheckState_Ljava_lang_Integer_ == null)
				cb_incrementAndCheckState_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IncrementAndCheckState_Ljava_lang_Integer_);
			return cb_incrementAndCheckState_Ljava_lang_Integer_;
		}

		static bool n_IncrementAndCheckState_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_increment)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.EventCountCircuitBreaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var increment = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_increment, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IncrementAndCheckState (increment);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_incrementAndCheckState_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='EventCountCircuitBreaker']/method[@name='incrementAndCheckState' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("incrementAndCheckState", "(Ljava/lang/Integer;)Z", "GetIncrementAndCheckState_Ljava_lang_Integer_Handler")]
		public virtual unsafe bool IncrementAndCheckState (global::Java.Lang.Integer increment)
		{
			if (id_incrementAndCheckState_Ljava_lang_Integer_ == IntPtr.Zero)
				id_incrementAndCheckState_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "incrementAndCheckState", "(Ljava/lang/Integer;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (increment);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_incrementAndCheckState_Ljava_lang_Integer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "incrementAndCheckState", "(Ljava/lang/Integer;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
