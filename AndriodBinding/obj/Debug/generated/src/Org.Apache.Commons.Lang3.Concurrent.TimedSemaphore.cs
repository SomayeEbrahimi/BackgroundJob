using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Concurrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/TimedSemaphore", DoNotGenerateAcw=true)]
	public partial class TimedSemaphore : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/field[@name='NO_LIMIT']"
		[Register ("NO_LIMIT")]
		public const int NoLimit = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/TimedSemaphore", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimedSemaphore); }
		}

		protected TimedSemaphore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_concurrent_ScheduledExecutorService_JLjava_util_concurrent_TimeUnit_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/constructor[@name='TimedSemaphore' and count(parameter)=4 and parameter[1][@type='java.util.concurrent.ScheduledExecutorService'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/util/concurrent/ScheduledExecutorService;JLjava/util/concurrent/TimeUnit;I)V", "")]
		public unsafe TimedSemaphore (global::Java.Util.Concurrent.IScheduledExecutorService service, long timePeriod, global::Java.Util.Concurrent.TimeUnit timeUnit, int limit)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (service);
				__args [1] = new JValue (timePeriod);
				__args [2] = new JValue (timeUnit);
				__args [3] = new JValue (limit);
				if (((object) this).GetType () != typeof (TimedSemaphore)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/concurrent/ScheduledExecutorService;JLjava/util/concurrent/TimeUnit;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/concurrent/ScheduledExecutorService;JLjava/util/concurrent/TimeUnit;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_concurrent_ScheduledExecutorService_JLjava_util_concurrent_TimeUnit_I == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_ScheduledExecutorService_JLjava_util_concurrent_TimeUnit_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/ScheduledExecutorService;JLjava/util/concurrent/TimeUnit;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_ScheduledExecutorService_JLjava_util_concurrent_TimeUnit_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_concurrent_ScheduledExecutorService_JLjava_util_concurrent_TimeUnit_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_JLjava_util_concurrent_TimeUnit_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/constructor[@name='TimedSemaphore' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit'] and parameter[3][@type='int']]"
		[Register (".ctor", "(JLjava/util/concurrent/TimeUnit;I)V", "")]
		public unsafe TimedSemaphore (long timePeriod, global::Java.Util.Concurrent.TimeUnit timeUnit, int limit)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (timePeriod);
				__args [1] = new JValue (timeUnit);
				__args [2] = new JValue (limit);
				if (((object) this).GetType () != typeof (TimedSemaphore)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JLjava/util/concurrent/TimeUnit;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JLjava/util/concurrent/TimeUnit;I)V", __args);
					return;
				}

				if (id_ctor_JLjava_util_concurrent_TimeUnit_I == IntPtr.Zero)
					id_ctor_JLjava_util_concurrent_TimeUnit_I = JNIEnv.GetMethodID (class_ref, "<init>", "(JLjava/util/concurrent/TimeUnit;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JLjava_util_concurrent_TimeUnit_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JLjava_util_concurrent_TimeUnit_I, __args);
			} finally {
			}
		}

		static Delegate cb_getAcquireCount;
#pragma warning disable 0169
		static Delegate GetGetAcquireCountHandler ()
		{
			if (cb_getAcquireCount == null)
				cb_getAcquireCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAcquireCount);
			return cb_getAcquireCount;
		}

		static int n_GetAcquireCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.TimedSemaphore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AcquireCount;
		}
#pragma warning restore 0169

		static IntPtr id_getAcquireCount;
		public virtual unsafe int AcquireCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/method[@name='getAcquireCount' and count(parameter)=0]"
			[Register ("getAcquireCount", "()I", "GetGetAcquireCountHandler")]
			get {
				if (id_getAcquireCount == IntPtr.Zero)
					id_getAcquireCount = JNIEnv.GetMethodID (class_ref, "getAcquireCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAcquireCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAcquireCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getAvailablePermits;
#pragma warning disable 0169
		static Delegate GetGetAvailablePermitsHandler ()
		{
			if (cb_getAvailablePermits == null)
				cb_getAvailablePermits = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAvailablePermits);
			return cb_getAvailablePermits;
		}

		static int n_GetAvailablePermits (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.TimedSemaphore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AvailablePermits;
		}
#pragma warning restore 0169

		static IntPtr id_getAvailablePermits;
		public virtual unsafe int AvailablePermits {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/method[@name='getAvailablePermits' and count(parameter)=0]"
			[Register ("getAvailablePermits", "()I", "GetGetAvailablePermitsHandler")]
			get {
				if (id_getAvailablePermits == IntPtr.Zero)
					id_getAvailablePermits = JNIEnv.GetMethodID (class_ref, "getAvailablePermits", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAvailablePermits);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvailablePermits", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getAverageCallsPerPeriod;
#pragma warning disable 0169
		static Delegate GetGetAverageCallsPerPeriodHandler ()
		{
			if (cb_getAverageCallsPerPeriod == null)
				cb_getAverageCallsPerPeriod = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetAverageCallsPerPeriod);
			return cb_getAverageCallsPerPeriod;
		}

		static double n_GetAverageCallsPerPeriod (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.TimedSemaphore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AverageCallsPerPeriod;
		}
#pragma warning restore 0169

		static IntPtr id_getAverageCallsPerPeriod;
		public virtual unsafe double AverageCallsPerPeriod {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/method[@name='getAverageCallsPerPeriod' and count(parameter)=0]"
			[Register ("getAverageCallsPerPeriod", "()D", "GetGetAverageCallsPerPeriodHandler")]
			get {
				if (id_getAverageCallsPerPeriod == IntPtr.Zero)
					id_getAverageCallsPerPeriod = JNIEnv.GetMethodID (class_ref, "getAverageCallsPerPeriod", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getAverageCallsPerPeriod);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAverageCallsPerPeriod", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getExecutorService;
#pragma warning disable 0169
		static Delegate GetGetExecutorServiceHandler ()
		{
			if (cb_getExecutorService == null)
				cb_getExecutorService = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExecutorService);
			return cb_getExecutorService;
		}

		static IntPtr n_GetExecutorService (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.TimedSemaphore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExecutorService);
		}
#pragma warning restore 0169

		static IntPtr id_getExecutorService;
		protected virtual unsafe global::Java.Util.Concurrent.IScheduledExecutorService ExecutorService {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/method[@name='getExecutorService' and count(parameter)=0]"
			[Register ("getExecutorService", "()Ljava/util/concurrent/ScheduledExecutorService;", "GetGetExecutorServiceHandler")]
			get {
				if (id_getExecutorService == IntPtr.Zero)
					id_getExecutorService = JNIEnv.GetMethodID (class_ref, "getExecutorService", "()Ljava/util/concurrent/ScheduledExecutorService;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledExecutorService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExecutorService), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledExecutorService> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExecutorService", "()Ljava/util/concurrent/ScheduledExecutorService;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isShutdown;
#pragma warning disable 0169
		static Delegate GetIsShutdownHandler ()
		{
			if (cb_isShutdown == null)
				cb_isShutdown = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsShutdown);
			return cb_isShutdown;
		}

		static bool n_IsShutdown (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.TimedSemaphore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShutdown;
		}
#pragma warning restore 0169

		static IntPtr id_isShutdown;
		public virtual unsafe bool IsShutdown {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/method[@name='isShutdown' and count(parameter)=0]"
			[Register ("isShutdown", "()Z", "GetIsShutdownHandler")]
			get {
				if (id_isShutdown == IntPtr.Zero)
					id_isShutdown = JNIEnv.GetMethodID (class_ref, "isShutdown", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isShutdown);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShutdown", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLastAcquiresPerPeriod;
#pragma warning disable 0169
		static Delegate GetGetLastAcquiresPerPeriodHandler ()
		{
			if (cb_getLastAcquiresPerPeriod == null)
				cb_getLastAcquiresPerPeriod = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLastAcquiresPerPeriod);
			return cb_getLastAcquiresPerPeriod;
		}

		static int n_GetLastAcquiresPerPeriod (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.TimedSemaphore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastAcquiresPerPeriod;
		}
#pragma warning restore 0169

		static IntPtr id_getLastAcquiresPerPeriod;
		public virtual unsafe int LastAcquiresPerPeriod {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/method[@name='getLastAcquiresPerPeriod' and count(parameter)=0]"
			[Register ("getLastAcquiresPerPeriod", "()I", "GetGetLastAcquiresPerPeriodHandler")]
			get {
				if (id_getLastAcquiresPerPeriod == IntPtr.Zero)
					id_getLastAcquiresPerPeriod = JNIEnv.GetMethodID (class_ref, "getLastAcquiresPerPeriod", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLastAcquiresPerPeriod);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastAcquiresPerPeriod", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_getLimit;
		static IntPtr id_setLimit_I;
		public unsafe int Limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/method[@name='getLimit' and count(parameter)=0]"
			[Register ("getLimit", "()I", "")]
			get {
				if (id_getLimit == IntPtr.Zero)
					id_getLimit = JNIEnv.GetMethodID (class_ref, "getLimit", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLimit);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/method[@name='setLimit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLimit", "(I)V", "")]
			set {
				if (id_setLimit_I == IntPtr.Zero)
					id_setLimit_I = JNIEnv.GetMethodID (class_ref, "setLimit", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLimit_I, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPeriod;
#pragma warning disable 0169
		static Delegate GetGetPeriodHandler ()
		{
			if (cb_getPeriod == null)
				cb_getPeriod = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetPeriod);
			return cb_getPeriod;
		}

		static long n_GetPeriod (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.TimedSemaphore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Period;
		}
#pragma warning restore 0169

		static IntPtr id_getPeriod;
		public virtual unsafe long Period {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/method[@name='getPeriod' and count(parameter)=0]"
			[Register ("getPeriod", "()J", "GetGetPeriodHandler")]
			get {
				if (id_getPeriod == IntPtr.Zero)
					id_getPeriod = JNIEnv.GetMethodID (class_ref, "getPeriod", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPeriod);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeriod", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getUnit;
#pragma warning disable 0169
		static Delegate GetGetUnitHandler ()
		{
			if (cb_getUnit == null)
				cb_getUnit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUnit);
			return cb_getUnit;
		}

		static IntPtr n_GetUnit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.TimedSemaphore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Unit);
		}
#pragma warning restore 0169

		static IntPtr id_getUnit;
		public virtual unsafe global::Java.Util.Concurrent.TimeUnit Unit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/method[@name='getUnit' and count(parameter)=0]"
			[Register ("getUnit", "()Ljava/util/concurrent/TimeUnit;", "GetGetUnitHandler")]
			get {
				if (id_getUnit == IntPtr.Zero)
					id_getUnit = JNIEnv.GetMethodID (class_ref, "getUnit", "()Ljava/util/concurrent/TimeUnit;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUnit), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnit", "()Ljava/util/concurrent/TimeUnit;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_acquire;
#pragma warning disable 0169
		static Delegate GetAcquireHandler ()
		{
			if (cb_acquire == null)
				cb_acquire = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Acquire);
			return cb_acquire;
		}

		static void n_Acquire (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.TimedSemaphore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Acquire ();
		}
#pragma warning restore 0169

		static IntPtr id_acquire;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/method[@name='acquire' and count(parameter)=0]"
		[Register ("acquire", "()V", "GetAcquireHandler")]
		public virtual unsafe void Acquire ()
		{
			if (id_acquire == IntPtr.Zero)
				id_acquire = JNIEnv.GetMethodID (class_ref, "acquire", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_acquire);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "acquire", "()V"));
			} finally {
			}
		}

		static Delegate cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler ()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.TimedSemaphore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler")]
		public virtual unsafe void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutdown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutdown", "()V"));
			} finally {
			}
		}

		static Delegate cb_startTimer;
#pragma warning disable 0169
		static Delegate GetStartTimerHandler ()
		{
			if (cb_startTimer == null)
				cb_startTimer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_StartTimer);
			return cb_startTimer;
		}

		static IntPtr n_StartTimer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.TimedSemaphore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StartTimer ());
		}
#pragma warning restore 0169

		static IntPtr id_startTimer;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/method[@name='startTimer' and count(parameter)=0]"
		[Register ("startTimer", "()Ljava/util/concurrent/ScheduledFuture;", "GetStartTimerHandler")]
		protected virtual unsafe global::Java.Util.Concurrent.IScheduledFuture StartTimer ()
		{
			if (id_startTimer == IntPtr.Zero)
				id_startTimer = JNIEnv.GetMethodID (class_ref, "startTimer", "()Ljava/util/concurrent/ScheduledFuture;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startTimer), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startTimer", "()Ljava/util/concurrent/ScheduledFuture;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_tryAcquire;
#pragma warning disable 0169
		static Delegate GetTryAcquireHandler ()
		{
			if (cb_tryAcquire == null)
				cb_tryAcquire = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_TryAcquire);
			return cb_tryAcquire;
		}

		static bool n_TryAcquire (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.TimedSemaphore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TryAcquire ();
		}
#pragma warning restore 0169

		static IntPtr id_tryAcquire;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='TimedSemaphore']/method[@name='tryAcquire' and count(parameter)=0]"
		[Register ("tryAcquire", "()Z", "GetTryAcquireHandler")]
		public virtual unsafe bool TryAcquire ()
		{
			if (id_tryAcquire == IntPtr.Zero)
				id_tryAcquire = JNIEnv.GetMethodID (class_ref, "tryAcquire", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_tryAcquire);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tryAcquire", "()Z"));
			} finally {
			}
		}

	}
}
